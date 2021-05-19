Public Class ucAddZones
    Dim edit As Integer = 0
    Dim streetID As String
    Dim zoneid As String
    Dim zn As String
    Dim transdate = DateTime.Now.ToString("MM-dd-yyyy")
    Private Sub ucAddZones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        butDisable()
        butDisableZ()
        txtStreet.Enabled = False
        cboZone.Enabled = False
        txtZone.Enabled = False
        txtPres.Enabled = False
        loadLvw()
        loadZone()
        loadZones()
    End Sub

    '========================================= ZONE ==============
    Sub butDisableZ()
        btnEditZ.Enabled = False
        btnCancelZ.Enabled = False
        btnDelZ.Enabled = False
        btnSaveZ.Enabled = False
        btnSearch.Enabled = False
    End Sub

    Sub saveZone()
        Try
            If edit = 0 Then
                DbConnect()
                Dim query As String = "INSERT INTO zone set zone_no ='" & txtZone.Text.Replace("'", "`").ToString & "',zone_pres ='" & txtPres.Text & "' "
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Zone successfully added.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtZone.Text = ""
                txtPres.Clear()
                txtZone.Enabled = False
                txtPres.Enabled = False
                butDisableZ()
                btnAddZ.Enabled = True
                btnSaveZ.Enabled = False
                loadZone()
                loadZones()
                DbDisconnect()

                DbConnect()
                Dim query2 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= '" & frmDashboard.txtID.Text & "'), ul_action = 'Added a new zone: " & txtZone.Text & "', ul_date = '" & transdate & "'"
                ExecuteQuery(query2)
                DbDisconnect()

            ElseIf edit = 1 Then
                DbConnect()
                Dim query As String = "UPDATE zone SET zone_no ='" & txtZone.Text.Replace("'", "`").ToString & "',zone_pres ='" & txtPres.Text & "' WHERE zone_id ='" & zoneid & "' "
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Zone successfully updated.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtZone.Text = ""
                txtPres.Clear()
                txtZone.Enabled = False
                txtPres.Enabled = False
                butDisableZ()
                btnAddZ.Enabled = True
                btnSaveZ.Enabled = False
                loadZone()
                loadZones()
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub loadZone()
        lvwZone.Items.Clear()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        Try
            DbConnect()
            Dim query As String = " SELECT zone_id, zone_no, zone_pres FROM zone ORDER by  zone_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwZone.Items.Add(reader.GetString("zone_id"))
                    lvwZone.Items(i).Font = Font
                    lvwZone.Items(i).SubItems.Add(reader.GetString("zone_no"))
                    lvwZone.Items(i).SubItems.Add(reader.GetString("zone_pres"))
                    i += 1
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub deleteZone()
        Try
            If MetroFramework.MetroMessageBox.Show(Me, " 
Are you sure to delete selected zone?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = vbYes Then
                DbConnect()
                Dim query As String = " DELETE FROM zone WHERE zone_id ='" & zoneid & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Zone street successfully deleted.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtZone.Enabled = False
                btnSearch.Enabled = False
                txtZone.Text = ""
                txtPres.Clear()
                btnAddZ.Enabled = True
                btnEditZ.Enabled = False
                btnDelZ.Enabled = False
                btnCancelZ.Enabled = False
                loadZone()
                DbDisconnect()
            ElseIf vbNo Then
                Exit Sub
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub displayZone()
        Try
            DbConnect()
            Dim query As String = " SELECT zone_id, zone_no, zone_pres FROM zone WHERE zone_id = '" & zoneid & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtZone.Text = reader.GetString("zone_no")
                    txtPres.Text = reader.GetString("zone_pres")
                    txtZoneID.Text = streetID
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub


    Private Sub btnAddZ_Click(sender As Object, e As EventArgs) Handles btnAddZ.Click
        btnSaveZ.Enabled = True
        btnCancelZ.Enabled = True
        txtZone.Enabled = True
        btnSearch.Enabled = True
    End Sub

    Private Sub btnCancelZ_Click(sender As Object, e As EventArgs) Handles btnCancelZ.Click
        btnAddZ.Enabled = True
        butDisableZ()
        txtZone.Text = ""
        txtPres.Clear()
        txtResID.Clear()
        txtZoneID.Clear()
        txtZone.Enabled = False
        btnSaveZ.Enabled = False
    End Sub

    Private Sub btnDelZ_Click(sender As Object, e As EventArgs) Handles btnDelZ.Click
        Try
            deleteZone()
            txtZone.Enabled = False
            btnSearch.Enabled = False
            butDisableZ()
            btnAddZ.Enabled = True
            loadZone()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnEditZ_Click(sender As Object, e As EventArgs) Handles btnEditZ.Click
        edit = 1
        btnEditZ.Enabled = False
        btnDelZ.Enabled = False
        btnSaveZ.Enabled = True
        txtZone.Enabled = True
        btnSearch.Enabled = True
    End Sub

    Private Sub btnSavez_Click(sender As Object, e As EventArgs) Handles btnSaveZ.Click
        If Trim(txtZone.Text) = "" Or Trim(txtPres.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        saveZone()
        loadLvw()
    End Sub


    Private Sub lvwZone_Click(sender As Object, e As EventArgs) Handles lvwZone.Click
        zoneid = lvwZone.Items(lvwZone.SelectedIndices(0)).Text
        btnAddZ.Enabled = False
        btnEditZ.Enabled = True
        btnDelZ.Enabled = True
        btnCancelZ.Enabled = True
        displayZone()
    End Sub


    Private Sub txtZone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtZone.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSavez_Click(sender, e)
        End If
    End Sub



    '================================ Street ====================================
    Sub butDisable()
        btnEditS.Enabled = False
        btnCancelS.Enabled = False
        btnDelS.Enabled = False
        btnSaveS.Enabled = False
    End Sub

    Sub loadZones()
        DbConnect()
        Dim query As String = "SELECT zone_no FROM zone ORDER BY zone_id DESC"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboZone.Items.Clear()
            While reader.Read
                cboZone.Items.Add(reader.GetString("zone_no"))
            End While
        End If
        DbDisconnect()
    End Sub

    Sub saveStreet()
        Try
            If edit = 0 Then
                DbConnect()
                Dim query4 As String = "SELECT zone_id FROM zone WHERE zone_no = '" & cboZone.Text & "' "
                ExecuteQuery(query4)
                If reader.HasRows Then
                    While reader.Read
                        zn = reader.GetString(0)
                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim query As String = "INSERT INTO streets set street_name ='" & txtStreet.Text.Replace("'", "`").ToString & "', zone_id = '" & zn & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Street successfully added.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtStreet.Enabled = False
                cboZone.Enabled = False
                butDisable()
                loadLvw()
                DbDisconnect()

                DbConnect()
                Dim query2 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= '" & frmDashboard.txtID.Text & "'), ul_action = 'Added a new street: " & txtStreet.Text & "', ul_date = '" & transdate & "'"
                ExecuteQuery(query2)
                DbDisconnect()
                txtStreet.Clear()
                cboZone.Items.Clear()
                loadZones()

            ElseIf edit = 1 Then
                DbConnect()
                Dim query4 As String = "SELECT zone_id FROM zone WHERE zone_no = '" & cboZone.Text & "' "
                ExecuteQuery(query4)
                If reader.HasRows Then
                    While reader.Read
                        zn = reader.GetString(0)
                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim query As String = "UPDATE streets SET street_name = '" & txtStreet.Text.Replace("'", "`").ToString & "',  zone_id = '" & zn & "' WHERE street_id ='" & streetID & "' "
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Street successfully updated.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtStreet.Clear()
                txtStreet.Enabled = False
                cboZone.Enabled = False
                cboZone.Items.Clear()
                loadZones()
                butDisable()
                btnAddS.Enabled = True
                btnSaveS.Enabled = False
                loadLvw()
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub deleteStreet()
        Try
            If MetroFramework.MetroMessageBox.Show(Me, " 
Are you sure to delete selected street?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = vbYes Then
                DbConnect()
                Dim query As String = " DELETE FROM streets WHERE street_id ='" & streetID & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Selected street successfully deleted.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtStreet.Enabled = False
                cboZone.Enabled = False
                btnAddS.Enabled = True
                btnEditS.Enabled = False
                btnDelS.Enabled = False
                btnCancelS.Enabled = False
                txtStreet.Clear()
                cboZone.Items.Clear()
                loadZones()
                loadLvw()
                DbDisconnect()
            ElseIf vbNo Then
                Exit Sub
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub loadLvw()
        lvwStreets.Items.Clear()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        Try
            DbConnect()
            Dim query As String = " SELECT street_id, street_name, zone_no FROM streets,zone WHERE streets.zone_id = zone.zone_id ORDER by street_ID DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwStreets.Items.Add(reader.GetString("street_ID"))
                    lvwStreets.Items(i).Font = Font
                    lvwStreets.Items(i).SubItems.Add(reader.GetString("street_name"))
                    Dim colZone = reader.GetOrdinal("zone_no")
                    Dim zon As String = Nothing
                    If Not reader.IsDBNull(colZone) Then
                        zon = reader.GetString("zone_no")
                        lvwStreets.Items(i).SubItems.Add(zon)
                    Else
                        Dim none As String = "NONE"
                        lvwStreets.Items(i).SubItems.Add(none)
                    End If
                    i += 1
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub displayStreet()
        Try
            DbConnect()
            Dim query As String = " SELECT street_id, street_name, zone_no FROM streets, zone WHERE streets.zone_id = zone.zone_id AND street_ID = '" & streetID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtStreet.Text = reader.GetString("street_name")
                    cboZone.Text = reader.GetString("zone_no")
                    txtStreetID.Text = streetID
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnAddS_Click(sender As Object, e As EventArgs) Handles btnAddS.Click
        btnSaveS.Enabled = True
        btnCancelS.Enabled = True
        txtStreet.Enabled = True
        cboZone.Enabled = True

    End Sub

    Private Sub btnCancelS_Click(sender As Object, e As EventArgs) Handles btnCancelS.Click
        btnAddS.Enabled = True
        butDisable()
        txtStreet.Clear()
        txtStreet.Enabled = False
        cboZone.Enabled = False
        cboZone.Items.Clear()
        loadZones()
    End Sub

    Private Sub btnDelS_Click(sender As Object, e As EventArgs) Handles btnDelS.Click
        Try
            deleteStreet()
            txtStreet.Enabled = False
            cboZone.Enabled = False
            butDisable()
            btnAddS.Enabled = True
            loadLvw()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnEditS_Click(sender As Object, e As EventArgs) Handles btnEditS.Click
        edit = 1
        btnEditS.Enabled = False
        btnDelS.Enabled = False
        btnSaveS.Enabled = True
        txtStreet.Enabled = True
        cboZone.Enabled = True
    End Sub

    Private Sub btnSaveS_Click(sender As Object, e As EventArgs) Handles btnSaveS.Click
        If Trim(txtStreet.Text) = "" Or Trim(cboZone.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Return
        End If
        saveStreet()
    End Sub

    Private Sub lvwStreets_Click(sender As Object, e As EventArgs) Handles lvwStreets.Click
        streetID = lvwStreets.Items(lvwStreets.SelectedIndices(0)).Text
        btnAddS.Enabled = False
        btnEditS.Enabled = True
        btnDelS.Enabled = True
        btnCancelS.Enabled = True
        displayStreet()
    End Sub


    Private Sub txtStreet_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStreet.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSaveS_Click(sender, e)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchresid = ""
        frmResidenceListv.ShowDialog()
        Dim isSelected As Boolean = False
        If isSelected Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Resident is already selected.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf searchresid <> "" Or isSelected = False Then
            Try
                DbConnect()
                Dim query As String = "SELECT res_id,res_name FROM residence WHERE res_id ='" & searchresid & "'"
                ExecuteQuery(query)
                If reader.HasRows Then
                    While reader.Read()
                        txtResID.Text = reader.GetString("res_id")
                        txtPres.Text = reader.GetString("res_name")
                    End While
                End If
                DbDisconnect()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                DisposeConnection()
            End Try
        End If
        DbDisconnect()
        searchresid = ""
    End Sub

End Class
