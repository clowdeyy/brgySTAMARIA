Public Class ucAddBusiness
    Dim edit As Integer = 0
    Dim lineID As String
    Dim businessID As String
    Dim lID As String
    Dim sID As String
    Dim sex As String
    Private line As String
    Private street As String
    Dim transdate = DateTime.Now.ToString("MM-dd-yyyy")

    '====================================== Start of Business Establishments
    Sub butDisable()
        btnCancel.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDel.Enabled = False
    End Sub

    Sub txtDisable()
        Button1.Enabled = False
        btnSearch.Enabled = False
        txtBName.Enabled = False
        txtBContact.Enabled = False
        cboAddress.Enabled = False
        cboLine.Enabled = False
        txtPermit.Enabled = False
        txtVehicle.Enabled = False
        txtOAddress.Enabled = False
        txtOContact.Enabled = False
        txtOName.Enabled = False
        radF.Enabled = False
        radM.Enabled = False
    End Sub

    Sub txtEnable()
        Button1.Enabled = True
        btnSearch.Enabled = True
        txtBName.Enabled = True
        txtBContact.Enabled = True
        cboLine.Enabled = True
        cboAddress.Enabled = True
        txtPermit.Enabled = True
        txtVehicle.Enabled = True
        txtOAddress.Enabled = True
        txtOContact.Enabled = True
        txtOName.Enabled = True
        radF.Enabled = True
        radM.Enabled = True
    End Sub

    Sub txtClear()
        txtBName.Clear()
        txtBContact.Clear()
        cboLine.Items.Clear()
        cboAddress.Items.Clear()
        txtPermit.Clear()
        txtVehicle.Clear()
        txtOAddress.Clear()
        txtOContact.Clear()
        txtOName.Clear()
        radF.Checked = False
        radM.Checked = False
    End Sub

    Sub loadID()
        Try
            DbConnect()
            Dim query As String = "SELECT businessowner_id from businessowners ORDER BY businessowner_id DESC LIMIT 1"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtboID.Text = "BID" & Val(Mid(reader.GetString(0), 4, 8)) + 1
                End While
            Else
                txtboID.Text = "BID20001"
            End If
            DbDisconnect()
        Catch ex As Exception
            MessageBox.Show("An error occured." & ex.Message)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub loadLine()
        DbConnect()
        Dim query As String = "SELECT * FROM businesslines ORDER BY line_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboLine.Items.Clear()
            While reader.Read
                cboLine.Items.Add(reader.GetString(1))
            End While
        End If
        DbDisconnect()
    End Sub

    Sub loadAddress()
        DbConnect()
        Dim query As String = "SELECT * FROM streets ORDER BY street_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboAddress.Items.Clear()
            While reader.Read
                cboAddress.Items.Add(reader.GetString(1))
            End While
        End If
        DbDisconnect()
    End Sub

    Sub search(keyword As String)
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwBusiness.Items.Clear()
        Try
            DbConnect()
            Dim query As String = " SELECT business_id, business_name, street_name, line_name, business_permit  FROM business INNER JOIN streets ON streets.street_id = business.street_id" _
                                & " INNER JOIN businesslines ON businesslines.line_id = business.line_id" _
                                & " WHERE business_name LIKE '" & keyword & "%'"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwBusiness.Items.Add(reader.GetString("business_id"))
                    lvwBusiness.Items(i).Font = font
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("business_name"))
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("street_name"))
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("line_name"))
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("business_permit"))
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

    Sub loadLvwBusiness()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwBusiness.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT business_id, business_name, line_name, street_name FROM business, businesslines, streets WHERE business.line_id = businesslines.line_id and business.street_id = streets.street_id ORDER by business_id DESC"
            ExecuteQuery(query)

            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwBusiness.Items.Add(reader.GetString("business_id"))
                    lvwBusiness.Items(i).Font = font
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("business_name"))
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("line_name"))
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("street_name"))
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

    Sub displayBusiness()
        Try
            DbConnect()
            Dim query As String = "SELECT business.business_id, bo_sex, business_name, business_contact, business_permit, business_vehicle, bo_name, bo_address, bo_contact, line_name, street_name FROM business, businesslines, businessowners, streets WHERE business.line_id = businesslines.line_id AND business.street_id = streets.street_id AND business.business_ID = businessowners.business_ID AND business.business_id = '" & businessID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    cboLine.Text = reader.GetString("line_name")
                    cboAddress.Text = reader.GetString("street_name")
                    txtBName.Text = reader.GetString("business_name")
                    txtBContact.Text = reader.GetString("business_contact")
                    txtPermit.Text = reader.GetString("business_permit")
                    txtVehicle.Text = reader.GetString("business_vehicle")
                    txtOName.Text = reader.GetString("bo_name")
                    txtOAddress.Text = reader.GetString("bo_address")
                    txtOContact.Text = reader.GetString("bo_contact")
                    If radM.Text = reader.GetString("bo_sex") Then
                        radM.Select()
                    ElseIf radF.Text = reader.GetString("bo_sex") Then
                        radF.Select()
                    End If
                    txtID.Text = businessID
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub
    Dim bID As String
    Sub saveBusiness()
        Try
            If edit = 0 Then
                DbConnect()
                Dim query2 As String = "SELECT line_id FROM businesslines WHERE line_name = '" & cboLine.Text & "'"
                ExecuteQuery(query2)
                If reader.HasRows Then
                    While reader.Read
                        line = reader.GetString(0)
                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim query3 As String = "SELECT street_id FROM streets WHERE street_name = '" & cboAddress.Text & "'"
                ExecuteQuery(query3)
                If reader.HasRows Then
                    While reader.Read
                        street = reader.GetString(0)
                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim query As String = "INSERT INTO business set business_name = @bname, business_permit = @permit, business_vehicle = @vehicle, line_ID = @line, business_contact = @bcontact, street_id = @street"
                ExecuteQueryParameter(query)
                command.Parameters.AddWithValue("@bname", txtBName.Text.Replace("'", "`").ToString)
                command.Parameters.AddWithValue("@permit", txtPermit.Text.ToString)
                command.Parameters.AddWithValue("@vehicle", txtVehicle.Text.ToString)
                command.Parameters.AddWithValue("@line", line)
                command.Parameters.AddWithValue("@bcontact", txtBContact.Text.ToString)
                command.Parameters.AddWithValue("@street", street)
                reader = command.ExecuteReader
                DbDisconnect()

                DbConnect()
                Dim query4 As String = "SELECT business_ID FROM business"
                ExecuteQuery(query4)
                If reader.HasRows Then
                    While reader.Read
                        bID = reader.GetString(0)
                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim querry As String = " INSERT INTO businessowners set businessowner_id = @boid, bo_name = @oname, bo_address = @oaddress, bo_contact = @ocontact, bo_sex = @sex, business_id = @bid"
                ExecuteQueryParameter(querry)
                command.Parameters.AddWithValue("@boid", txtboID.Text)
                command.Parameters.AddWithValue("@oname", txtOName.Text)
                command.Parameters.AddWithValue("@oaddress", txtOAddress.Text.Replace("'", "`").ToString)
                command.Parameters.AddWithValue("@ocontact", txtOContact.Text)
                command.Parameters.AddWithValue("@sex", sex)
                command.Parameters.AddWithValue("@bid", bID)
                reader = command.ExecuteReader
                MetroFramework.MetroMessageBox.Show(Me, " 
Business Establishment successfully added.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                DbDisconnect()

                DbConnect()
                Dim query1 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= @id), ul_action = @action, ul_date = @date"
                ExecuteQueryParameter(query1)
                command.Parameters.AddWithValue("@id", frmDashboard.txtID.Text)
                command.Parameters.AddWithValue("@action", "Added a new business establishment: " & txtBName.Text.ToString & "")
                command.Parameters.AddWithValue("@date", transdate)
                reader = command.ExecuteReader
                DbDisconnect()

                btnAdd.Enabled = True
                btnSave.Enabled = False
                txtClear()
                txtDisable()
                butDisable()
                loadLvwBusiness()
                loadLine()
                loadAddress()
                DbDisconnect()

            ElseIf edit = 1 Then
                DbConnect()
                Dim query2 As String = "SELECT line_id FROM businesslines WHERE line_name = '" & cboLine.Text & "'"
                ExecuteQuery(query2)
                If reader.HasRows Then
                    While reader.Read
                        line = reader.GetString(0)
                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim query3 As String = "SELECT street_id FROM streets WHERE street_name = '" & cboAddress.Text & "'"
                ExecuteQuery(query3)
                If reader.HasRows Then
                    While reader.Read
                        street = reader.GetString(0)
                    End While
                End If
                DbDisconnect()

                DbConnect()
                ' Dim query As String = "UPDATE business SET business_name = '" & txtBName.Text & "', business_permit = '" & txtPermit.Text & "', business_vehicle = '" & txtVehicle.Text & "', business_contact = '" & txtBContact.Text & "' WHERE business.business_id = '" & businessID & "' "
                Dim query As String = "UPDATE business set business_name = @bname, business_permit = @permit, business_vehicle = @vehicle, line_ID = @line, business_contact = @bcontact, street_id = @street WHERE business.business_id = @bid"
                ExecuteQueryParameter(query)
                command.Parameters.AddWithValue("@bname", txtBName.Text.Replace("'", "`").ToString)
                command.Parameters.AddWithValue("@permit", txtPermit.Text.ToString)
                command.Parameters.AddWithValue("@vehicle", txtVehicle.Text.ToString)
                command.Parameters.AddWithValue("@line", line)
                command.Parameters.AddWithValue("@bcontact", txtBContact.Text.ToString)
                command.Parameters.AddWithValue("@street", street)
                command.Parameters.AddWithValue("@bid", businessID)
                reader = command.ExecuteReader
                DbDisconnect()

                DbConnect()
                Dim querrry As String = " UPDATE businessowners SET bo_name = @oname, bo_address = @oaddress, bo_contact = @ocontact, bo_sex = @sex WHERE businessowners.business_id = @bid "
                ExecuteQueryParameter(querrry)
                command.Parameters.AddWithValue("@oname", txtOName.Text)
                command.Parameters.AddWithValue("@oaddress", txtOAddress.Text.Replace("'", "`").ToString)
                command.Parameters.AddWithValue("@ocontact", txtOContact.Text)
                command.Parameters.AddWithValue("@sex", sex)
                command.Parameters.AddWithValue("@bid", businessID)
                reader = command.ExecuteReader
                MetroFramework.MetroMessageBox.Show(Me, " 
Business Establishment successfully updated.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                DbDisconnect()

                DbConnect()
                Dim query1 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= @id), ul_action = @action, ul_date = @date"
                ExecuteQueryParameter(query1)
                command.Parameters.AddWithValue("@id", frmDashboard.txtID.Text)
                command.Parameters.AddWithValue("@action", "'Updated business establishment information: " & txtBName.Text.ToString & "'")
                command.Parameters.AddWithValue("@date", transdate)
                reader = command.ExecuteReader
                DbDisconnect()

                btnAdd.Enabled = True
                btnSave.Enabled = False
                txtClear()
                txtDisable()
                butDisable()
                loadLvwBusiness()
                loadLine()
                loadAddress()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub deleteBusiness()
        Try
            If MetroFramework.MetroMessageBox.Show(Me, " 
Are you sure to delete selected business establishment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = vbYes Then
                DbConnect()
                Dim query As String = " DELETE FROM business WHERE business_id ='" & businessID & "'"
                ExecuteQuery(query)
                DbDisconnect()

                'DbConnect()
                'Dim query4 As String = "SELECT business_ID FROM business "
                'ExecuteQuery(query4)
                'If reader.HasRows Then
                '    While reader.Read
                '        bID = reader.GetString(0)
                '    End While
                'End If
                'DbDisconnect()

                DbConnect()
                Dim query1 As String = " DELETE FROM businessowners WHERE business_id ='" & businessID & "'"
                ExecuteQuery(query1)
                MetroFramework.MetroMessageBox.Show(Me, " 
Selected business establishment successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                btnAdd.Enabled = True
                btnEdit.Enabled = False
                btnDel.Enabled = False
                btnCancel.Enabled = False
                txtClear()
                txtDisable()
                loadLvwBusiness()
                loadLine()
                loadAddress()
                DbDisconnect()
            ElseIf vbNo Then
                txtClear()
                Exit Sub
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub


    Private Sub radF_CheckedChanged(sender As Object, e As EventArgs) Handles radF.CheckedChanged
        sex = radF.Text
    End Sub

    Private Sub radM_CheckedChanged(sender As Object, e As EventArgs) Handles radM.CheckedChanged
        sex = radM.Text
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtEnable()
        btnCancel.Enabled = True
        btnSave.Enabled = True
        btnAdd.Enabled = False

        'loadAddress()
        'loadLine()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtClear()
        butDisable()
        btnAdd.Enabled = True
        txtDisable()
        loadAddress()
        cboLine.Items.Clear()
        loadLine()
        cboLine.Refresh()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            deleteBusiness()
            txtDisable()
            butDisable()
            btnAdd.Enabled = True
            loadLvwBusiness()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        edit = 1
        btnEdit.Enabled = False
        btnDel.Enabled = False
        btnSave.Enabled = True
        txtEnable()
        btnSearch.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Trim(txtBName.Text) = "" Or Trim(cboLine.Text) = "" Or Trim(cboAddress.Text) = "" Or Trim(txtPermit.Text) = "" Or Trim(txtOContact.Text) = "" Or Trim(txtOName.Text) = "" Or Trim(txtOAddress.Text) = "" Or Trim(txtOContact.Text) = "" Or Trim(sex) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out necessary fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        saveBusiness()
        loadID()
    End Sub

    Private Sub lvwBusiness_Click(sender As Object, e As EventArgs) Handles lvwBusiness.Click
        If lvwBusiness.SelectedItems.Count > 0 Then
            Try
                businessID = lvwBusiness.Items(lvwBusiness.SelectedIndices(0)).Text
                btnAdd.Enabled = False
                btnEdit.Enabled = True
                btnDel.Enabled = True
                btnCancel.Enabled = True
                displayBusiness()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                DisposeConnection()
            End Try
        End If
    End Sub
    '====================================== End of Business Establishments


    Private Sub ucAddBusiness_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        butDisable()
        txtDisable()
        txtBName.Focus()
        loadLvwBusiness()
        cboLine.Items.Clear()
        loadLine()
        cboLine.Refresh()
        loadAddress()
        loadID()

        butDisableL()
        txtLineName.Enabled = False
        txtLineDesc.Enabled = False
        txtLineName.Focus()
        loadLvwLine()
    End Sub

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        If txtSearch.Text = "" Then
            loadLvwBusiness()
        Else
            search(txtSearch.Text)
        End If
    End Sub


    '====================================== Start of Business Line
    Sub butDisableL()
        btnCancelL.Enabled = False
        btnEditL.Enabled = False
        btnSaveL.Enabled = False
        btnDelL.Enabled = False
    End Sub

    Sub loadLvwLine()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwLine.Items.Clear()
        Try
            DbConnect()
            Dim query As String = " SELECT line_id, line_name, line_desc FROM businesslines ORDER by  line_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwLine.Items.Add(reader.GetString("line_id"))
                    lvwLine.Items(i).Font = font
                    lvwLine.Items(i).SubItems.Add(reader.GetString("line_name"))
                    lvwLine.Items(i).SubItems.Add(reader.GetString("line_desc"))
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

    Sub displayLine()
        Try
            DbConnect()
            Dim query As String = " SELECT line_id, line_name, line_desc FROM businesslines WHERE line_id = '" & lineID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtLineName.Text = reader.GetString("line_name")
                    txtLineDesc.Text = reader.GetString("line_desc")
                    txtLineID.Text = lineID
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub saveLine()
        Try
            If edit = 0 Then
                DbConnect()
                Dim query As String = "INSERT INTO businesslines set line_name = @linename, line_desc = @linedesc"
                ExecuteQueryParameter(query)
                command.Parameters.AddWithValue("@linename", txtLineName.Text)
                command.Parameters.AddWithValue("@linedesc", txtLineDesc.Text)
                reader = command.ExecuteReader

                MetroFramework.MetroMessageBox.Show(Me, " 
Business Line successfully added.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtLineName.Clear()
                txtLineDesc.Clear()
                txtLineName.Enabled = False
                txtLineDesc.Enabled = False
                btnAddL.Enabled = True
                btnSaveL.Enabled = False
                butDisableL()
                loadLvwLine()
                DbDisconnect()

            ElseIf edit = 1 Then
                DbConnect()
                Dim query As String = " UPDATE businesslines set line_name = '" & txtLineName.Text & "', line_desc = '" & txtLineDesc.Text & "' WHERE line_id = '" & lineID & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Business Line successfully updated.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtLineName.Clear()
                txtLineDesc.Clear()
                txtLineName.Enabled = False
                txtLineDesc.Enabled = False
                btnAddL.Enabled = True
                btnSaveL.Enabled = False
                butDisableL()
                loadLvwLine()
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub deleteLine()
        Try
            If MetroFramework.MetroMessageBox.Show(Me, "Are you sure to delete selected business line?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = vbYes Then
                DbConnect()
                Dim query As String = " DELETE FROM businesslines WHERE line_id ='" & lineID & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Selected business line successfully deleted.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                btnAddL.Enabled = True
                btnEditL.Enabled = False
                btnDelL.Enabled = False
                btnCancelL.Enabled = False
                txtLineName.Clear()
                txtLineDesc.Clear()
                txtLineName.Enabled = False
                txtLineDesc.Enabled = False
                loadLvwLine()
                DbDisconnect()
            ElseIf vbNo Then
                txtLineDesc.Clear()
                txtLineName.Clear()
                Exit Sub
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnAddL_Click(sender As Object, e As EventArgs) Handles btnAddL.Click
        txtLineName.Enabled = True
        txtLineDesc.Enabled = True
        btnCancelL.Enabled = True
        btnSaveL.Enabled = True
        btnAddL.Enabled = False
    End Sub

    Private Sub btnCancelL_Click(sender As Object, e As EventArgs) Handles btnCancelL.Click
        txtLineName.Clear()
        txtLineDesc.Clear()
        butDisableL()
        btnAddL.Enabled = True
        txtLineName.Enabled = False
        txtLineDesc.Enabled = False
    End Sub

    Private Sub btnDelL_Click(sender As Object, e As EventArgs) Handles btnDelL.Click
        Try
            deleteLine()
            txtLineName.Enabled = False
            txtLineDesc.Enabled = False
            butDisableL()
            btnAddL.Enabled = True
            loadLvwLine()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try

    End Sub

    Private Sub btnEditL_Click(sender As Object, e As EventArgs) Handles btnEditL.Click
        edit = 1
        btnEditL.Enabled = False
        btnDelL.Enabled = False
        btnSaveL.Enabled = True
        txtLineName.Enabled = True
        txtLineDesc.Enabled = True
    End Sub

    Private Sub btnSaveL_Click(sender As Object, e As EventArgs) Handles btnSaveL.Click
        If Trim(txtLineName.Text) = "" Or Trim(txtLineDesc.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        saveLine()
        loadLine()
    End Sub

    Private Sub lvwLine_Click(sender As Object, e As EventArgs) Handles lvwLine.Click
        Try
            lineID = lvwLine.Items(lvwLine.SelectedIndices(0)).Text
            btnAddL.Enabled = False
            btnEditL.Enabled = True
            btnDelL.Enabled = True
            btnCancelL.Enabled = True
            displayLine()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'txtClear()
        searchboid = ""
        frmBusinessList.ShowDialog()
        Dim isSelected As Boolean = False
        If isSelected Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Resident is already selected.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf searchboid <> "" Or isSelected = False Then
            Try
                DbConnect()
                Dim query As String = "SELECT * FROM businessowners WHERE businessowner_id ='" & searchboid & "'"
                ExecuteQuery(query)
                If reader.HasRows Then
                    While reader.Read()
                        txtboID.Text = reader.GetString("businessowner_id")
                        txtOName.Text = reader.GetString("bo_name")
                        txtOContact.Text = reader.GetString("bo_contact")
                        txtOAddress.Text = reader.GetString("bo_address")
                        If radM.Text = reader.GetString("bo_sex") Then
                            radM.Select()
                        ElseIf radF.Text = reader.GetString("bo_sex") Then
                            radF.Select()
                        End If
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
        searchboid = ""
    End Sub

    Private Sub txtBContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBContact.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890-"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtOContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOContact.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890-"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz  "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        cboLine.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim zone As New ucAddZones
        toPanelMain(zone.Width, zone.Height, zone)
    End Sub


    Private Sub txtBContact_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBContact.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave_Click(sender, e)
        End If
    End Sub

End Class
