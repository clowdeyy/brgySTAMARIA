Public Class ucHouseholdType
    Dim edit As Integer = 0
    Dim typeID As String
    Dim transdate = DateTime.Now.ToString("MM-dd-yyyy")

    Private Sub ucHouseholdType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        butDisable()
        txtType.Enabled = False
        loadType()
    End Sub

    Sub saveType()
        Try
            If edit = 0 Then
                DbConnect()
                Dim query As String = "INSERT INTO householdtype set hht_name ='" & txtType.Text.Replace("'", "`").ToString & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Household type successfully added.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtType.Enabled = False
                butDisable()
                loadType()
                DbDisconnect()

                DbConnect()
                Dim query2 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= '" & frmDashboard.txtID.Text & "'), ul_action = 'Added a new household type: " & txtType.Text & "', ul_date = '" & transdate & "'"
                ExecuteQuery(query2)
                DbDisconnect()
                txtType.Clear()

            ElseIf edit = 1 Then
                DbConnect()
                Dim query As String = "UPDATE householdtype SET hht_name = '" & txtType.Text.Replace("'", "`").ToString & "' WHERE hht_id ='" & typeID & "' "
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Profession successfully updated.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtType.Clear()
                txtType.Enabled = False
                butDisable()
                btnAdd.Enabled = True
                btnSave.Enabled = False
                loadType()
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub loadType()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwType.Items.Clear()
        Try
            DbConnect()
            Dim query As String = " SELECT hht_ID, hht_name FROM householdtype ORDER by  hht_ID DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwType.Items.Add(reader.GetString("hht_ID"))
                    lvwType.Items(i).Font = font
                    lvwType.Items(i).SubItems.Add(reader.GetString("hht_name"))
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

    Sub displayProf()
        Try
            DbConnect()
            Dim query As String = " SELECT hht_id, hht_name FROM householdtype WHERE hht_id = '" & typeID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtType.Text = reader.GetString("hht_name")
                    txtprofid.Text = typeID
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub delType()
        Try
            If MetroFramework.MetroMessageBox.Show(Me, " 
Are you sure to delete selected household type?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = vbYes Then
                DbConnect()
                Dim query As String = " DELETE FROM householdtype WHERE hht_id ='" & typeID & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Selected household type successfully deleted.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtType.Enabled = False
                btnAdd.Enabled = True
                btnEdit.Enabled = False
                btnDel.Enabled = False
                btnCancel.Enabled = False
                txtType.Clear()
                loadType()
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

    Sub butDisable()
        btnEdit.Enabled = False
        btnCancel.Enabled = False
        btnDel.Enabled = False
        btnSave.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True
        txtType.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnAdd.Enabled = True
        txtType.Clear()
        txtType.Enabled = False
        butDisable()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            delType()
            txtType.Enabled = False
            butDisable()
            btnAdd.Enabled = True
            loadType()
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
        txtType.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Trim(txtType.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Return
        End If
        saveType()

    End Sub

    Private Sub lvwType_Click(sender As Object, e As EventArgs) Handles lvwType.Click
        typeID = lvwType.Items(lvwType.SelectedIndices(0)).Text
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDel.Enabled = True
        btnCancel.Enabled = True
        displayProf()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hh As New ucAddHousehold
        toPanelMain(hh.Width, hh.Height, hh)
    End Sub

    Private Sub txtType_TextChanged(sender As Object, e As EventArgs) Handles txtType.TextChanged

    End Sub

    Private Sub txtType_KeyDown(sender As Object, e As KeyEventArgs) Handles txtType.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave_Click(sender, e)
        End If
    End Sub
End Class
