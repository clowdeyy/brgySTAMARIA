Public Class ucAddUsers
    Dim edit As Integer = 0
    Dim userID As String
    Dim userIDs As String
    Sub butDisable()
        btnCancel.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDel.Enabled = False
    End Sub

    Sub txtEnable()
        cboType.Enabled = True
        txtUsername.Enabled = True
        txtName.Enabled = True
        txtPass.Enabled = True
        txtConfirm.Enabled = True
    End Sub

    Sub txtDisable()
        cboType.Enabled = False
        txtUsername.Enabled = False
        txtName.Enabled = False
        txtPass.Enabled = False
        txtConfirm.Enabled = False
    End Sub

    Sub txtClear()
        cboType.Items.Clear()
        txtName.Text = ""
        txtPass.Text = ""
        txtConfirm.Text = ""
        txtUsername.Text = ""
    End Sub

    Sub loadType()
        cboType.Items.Add("Secretary")
        cboType.Items.Add("Barangay Captain")
        cboType.Items.Add("Clerk")
    End Sub

    Private Sub ucAddUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        butDisable()
        txtDisable()
        loadLvwUsers()
        loadType()
        loadusers()
    End Sub

    Sub loadLvwUsers()
        lvwUsers.Items.Clear()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        Try
            DbConnect()
            Dim query As String = " SELECT user_id, user_username, user_type,user_fullname,user_password FROM users  WHERE user_type = 'Barangay Captain' OR user_type = 'Secretary' OR user_type = 'Clerk' ORDER by  user_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwUsers.Items.Add(reader.GetString("user_id"))
                    lvwUsers.Items(i).Font = Font
                    lvwUsers.Items(i).SubItems.Add(reader.GetString("user_type"))
                    lvwUsers.Items(i).SubItems.Add(reader.GetString("user_fullname"))
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

    Sub displayUser()
        Try
            DbConnect()
            Dim query As String = " SELECT user_id, user_username, user_type,user_fullname,user_password  FROM users WHERE user_id = '" & userID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    cboType.Text = reader.GetString("user_type")

                    txtName.Text = reader.GetString("user_fullname")
                    txtUsername.Text = reader.GetString("user_username")
                    txtPass.Text = reader.GetString("user_password")
                    txtConfirm.Text = reader.GetString("user_password")
                    txtID.Text = userID
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub saveUser()
        Try
            If edit = 0 Then
                DbConnect()
                Dim query As String = "INSERT INTO users set user_type =@usertype, user_fullname =@fullname, user_username =@username, user_password =@password, user_flag=@flag"
                ExecuteQueryParameter(query)
                command.Parameters.AddWithValue("@usertype", cboType.Text.ToString)
                command.Parameters.AddWithValue("@fullname", txtName.Text.Replace("'", "`").ToString)
                command.Parameters.AddWithValue("@username", txtUsername.Text.Replace("'", "`").ToString)
                command.Parameters.AddWithValue("@password", txtPass.Text.Replace("'", "`").ToString)
                command.Parameters.AddWithValue("@flag", "OFFLINE")
                reader = command.ExecuteReader
                MetroFramework.MetroMessageBox.Show(Me, " 
System user successfully added.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtClear()
                txtDisable()
                butDisable()
                loadLvwUsers()
                loadType()
                btnAdd.Enabled = True
                btnSave.Enabled = False
                DbDisconnect()

            ElseIf edit = 1 Then
                DbConnect()
                Dim query As String = "UPDATE users SET user_type ='" & cboType.Text & "', user_fullname ='" & txtName.Text & "', user_username ='" & txtUsername.Text & "', user_password ='" & txtPass.Text & "', user_flag = 'OFFLINE' WHERE user_id ='" & userID & "' "
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
System user successfully updated.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtClear()
                txtDisable()
                butDisable()
                loadLvwUsers()
                loadType()
                btnAdd.Enabled = True
                btnSave.Enabled = False
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub deleteUser()
        Try
            If MetroFramework.MetroMessageBox.Show(Me, " 
Are you sure to delete selected user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = vbYes Then
                DbConnect()
                Dim query As String = " DELETE FROM users WHERE user_id ='" & userID & "'"
                ExecuteQuery(query)

                DbConnect()
                Dim qry As String = " DELETE FROM users_logs WHERE user_id ='" & userID & "'"
                ExecuteQuery(qry)

                MetroFramework.MetroMessageBox.Show(Me, " 
System user successfully deleted.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtClear()
                txtDisable()
                loadLvwUsers()
                loaduserslogs()
                btnAdd.Enabled = True
                btnEdit.Enabled = False
                btnDel.Enabled = False
                btnCancel.Enabled = False
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtEnable()
        btnAdd.Enabled = False
        btnCancel.Enabled = True
        btnSave.Enabled = True


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtDisable()
        butDisable()
        txtClear()
        btnAdd.Enabled = True
        loadType()
        btnReset.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        edit = 1
        btnEdit.Enabled = False
        btnDel.Enabled = False
        btnSave.Enabled = True
        txtEnable()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            deleteUser()
            txtDisable()
            loadLvwUsers()
            butDisable()
            loadType()
            btnAdd.Enabled = True
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim pass As String = txtPass.Text
        Dim confirm As String = txtConfirm.Text

        If (pass.Equals(confirm)) Then
            lblWarning.Visible = False
        Else
            lblWarning.Visible = True
            Return
        End If

        If Trim(txtName.Text) = "" Or Trim(cboType.Text) = "" Or Trim(txtUsername.Text) = "" Or Trim(txtPass.Text) = "" Or Trim(txtConfirm.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        saveUser()
    End Sub

    Private Sub lvwUsers_Click(sender As Object, e As EventArgs) Handles lvwUsers.Click
        Try
            userID = lvwUsers.Items(lvwUsers.SelectedIndices(0)).Text
            btnAdd.Enabled = False
            btnEdit.Enabled = True
            btnDel.Enabled = True
            btnCancel.Enabled = True
            displayUser()
            btnReset.Enabled = True
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub


    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz  "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890  "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSearch1_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch1.OnValueChanged
        If txtSearch1.Text = "" Then
            loadLvwUsers()
        Else
            searchUser1(txtSearch1.Text)
        End If
    End Sub

    Private Sub txtSearch1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch1.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz  "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Sub searchUser1(keyword As String)
        lvwUsers.Items.Clear()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        Try
            DbConnect()
            Dim query As String = " SELECT user_id, user_username, user_type,user_fullname FROM users WHERE user_fullname LIKE '" & keyword & "%' ORDER  by  user_fullname DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwUsers.Items.Add(reader.GetString("user_id"))
                    lvwUsers.Items(i).Font = Font
                    lvwUsers.Items(i).SubItems.Add(reader.GetString("user_type"))
                    lvwUsers.Items(i).SubItems.Add(reader.GetString("user_fullname"))
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


    '======================= tab 2
    Sub loadusers()
        lvwLUsers.Items.Clear()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        Try
            DbConnect()
            Dim query As String = " SELECT user_id, user_username, user_type,user_fullname,user_password FROM users WHERE user_type = 'Barangay Captain' OR user_type = 'Secretary' OR user_type = 'Clerk' ORDER by  user_fullname DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwLUsers.Items.Add(reader.GetString("user_id"))
                    lvwLUsers.Items(i).Font = Font
                    lvwLUsers.Items(i).SubItems.Add(reader.GetString("user_fullname"))
                    lvwLUsers.Items(i).SubItems.Add(reader.GetString("user_type"))
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

    Sub loaduserslogs()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwLogs.Items.Clear()
        Try
            DbConnect()
            Dim query As String = " SELECT user_id, ul_date,ul_action FROM users_logs WHERE user_id ='" & userIDs & "' ORDER BY ul_id DESC"
            ExecuteQuery(query)

            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwLogs.Items.Add(reader.GetString("ul_date"))
                    lvwLogs.Items(i).Font = Font
                    lvwLogs.Items(i).SubItems.Add(reader.GetString("ul_action"))
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

    Private Sub lvwLUsers_Click(sender As Object, e As EventArgs) Handles lvwLUsers.Click
        If lvwLUsers.SelectedItems.Count > 0 Then
            userIDs = lvwLUsers.Items(lvwLUsers.SelectedIndices(0)).Text
            loaduserslogs()
        End If
    End Sub

    Private Sub txtSearchOwner_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearchOwner.OnValueChanged
        If txtSearchOwner.Text = "" Then
            loadusers()
        Else
            searchUser(txtSearchOwner.Text)
        End If
    End Sub

    Sub searchUser(keyword As String)
        lvwLUsers.Items.Clear()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        Try
            DbConnect()
            Dim query As String = " SELECT user_id, user_username, user_type,user_fullname,user_password FROM users WHERE user_fullname LIKE '" & keyword & "%' ORDER  by  user_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwLUsers.Items.Add(reader.GetString("user_id"))
                    lvwLUsers.Items(i).Font = Font
                    lvwLUsers.Items(i).SubItems.Add(reader.GetString("user_fullname"))
                    lvwLUsers.Items(i).SubItems.Add(reader.GetString("user_type"))
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

    Private Sub txtSearchOwner_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchOwner.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz  "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub


    Private Sub txtConfirm_KeyDown(sender As Object, e As KeyEventArgs) Handles txtConfirm.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave_Click(sender, e)
        End If
    End Sub

    Private Sub btnEmpty_Click(sender As Object, e As EventArgs) Handles btnEmpty.Click

        If MetroFramework.MetroMessageBox.Show(Me, " 
Empty user logs?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = vbYes Then
            DbConnect()
            Dim qrys As String = "TRUNCATE TABLE users_logs"
            ExecuteQuery(qrys)
            DbConnect()
            loaduserslogs()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        DbConnect()
        Dim qry As String = "UPDATE users SET user_flag = 'OFFLINE' WHERE user_ID = '" & txtID.Text & "'"
        ExecuteQuery(qry)
        DbDisconnect()
        MetroFramework.MetroMessageBox.Show(Me, " 
Reset successfully. Selected user can now log-in.", "Reset Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
        txtDisable()
        butDisable()
        txtClear()
        btnAdd.Enabled = True
        loadType()
        btnReset.Enabled = False
    End Sub
End Class
