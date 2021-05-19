Public Class frmLogin
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub


    Private Sub lblExit_Click_1(sender As Object, e As EventArgs) Handles lblExit.Click
        If (MessageBox.Show("Are you sure to Exit?", "Exit from the system", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Public captain, secretary, clerk As Boolean
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usr As String = txtUsername.Text
        Dim pwd As String = txtPassword.Text
        Dim flag As Integer = 0
        Dim transdate = DateTime.Now.ToString("MM-dd-yyyy")
        If Trim(usr) = "" Or Trim(pwd) = "" Then
            MsgBox("Please fill out all fields!", vbExclamation, "Warning!")
        Else
            Try
                DbConnect()
                Dim query As String = "SELECT * FROM users WHERE user_username = @username AND user_password = @password"
                ExecuteQueryParameter(query)
                command.Parameters.AddWithValue("@username", usr)
                command.Parameters.AddWithValue("@password", pwd)
                reader = command.ExecuteReader

                If reader.HasRows Then
                    reader.Read()
                    If reader.Item("user_type") = "Barangay Captain" Or reader.Item("user_type") = "superadmin" Then
                        If reader.Item("user_flag") = "ONLINE" Then
                            MsgBox("You're currently logged-in in another PC.", vbInformation, "This user is online!")
                            txtPassword.Clear()
                            Exit Sub
                        ElseIf reader.Item("user_flag") = "OFFLINE" Or (0).ToString() Then
                            captain = True
                            secretary = False
                            clerk = False
                            flag = 1
                            DbConnect()
                            Dim query1 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_Username= '" & usr & "'), ul_action = 'Logged in', ul_date = '" & transdate & "'"
                            ExecuteQuery(query1)
                            DbDisconnect()
                            frmDashboard.Show()
                            Me.Hide()
                        End If

                    ElseIf reader.Item("user_type") = "Secretary" Then
                        If reader.Item("user_flag") = "ONLINE" Then
                            MsgBox("You're currently logged-in in another PC.", vbInformation, "This user is online!")
                            txtPassword.Clear()
                            Exit Sub
                        ElseIf reader.Item("user_flag") = "OFFLINE" Or (0).ToString() Then
                            captain = False
                            secretary = True
                            clerk = False
                            flag = 3
                            DbConnect()
                            Dim query1 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_Username= '" & usr & "'), ul_action = 'Logged in', ul_date = '" & transdate & "'"
                            ExecuteQuery(query1)
                            DbDisconnect()
                            frmDashboard.Show()
                            Me.Hide()
                        End If

                    ElseIf reader.Item("user_type") = "Clerk" Then
                        If reader.Item("user_flag") = "ONLINE" Then
                            MsgBox("You're currently logged-in in another PC.", vbInformation, "This user is online!")
                            txtPassword.Clear()
                            Exit Sub
                        ElseIf reader.Item("user_flag") = "OFFLINE" Or (0).ToString() Then
                            captain = False
                            secretary = False
                            clerk = True
                            flag = 4
                            DbConnect()
                            Dim query1 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_Username= '" & usr & "'), ul_action = 'Logged in', ul_date = '" & transdate & "'"
                            ExecuteQuery(query1)
                            DbDisconnect()
                            frmDashboard.Show()
                            Me.Hide()
                        End If

                    End If
                Else
                    MsgBox("User not registered!", vbExclamation, "Access Denied!")
                    txtPassword.Clear()

                End If
                DbDisconnect()

                If flag = 1 Then
                    DbConnect()
                    Dim query3 As String = "UPDATE users SET user_flag = 'ONLINE'  WHERE user_Username = '" & usr & "'"
                    ExecuteQuery(query3)
                    DbDisconnect()
                ElseIf flag = 2 Then
                    DbConnect()
                    Dim query3 As String = "UPDATE users SET user_flag = 'ONLINE'  WHERE user_Username = '" & usr & "'"
                    ExecuteQuery(query3)
                    DbDisconnect()
                ElseIf flag = 3 Then
                    DbConnect()
                    Dim query3 As String = "UPDATE users SET user_flag = 'ONLINE'  WHERE user_Username = '" & usr & "'"
                    ExecuteQuery(query3)
                    DbDisconnect()
                ElseIf flag = 4 Then
                    DbConnect()
                    Dim query3 As String = "UPDATE users SET user_flag = 'ONLINE'  WHERE user_Username = '" & usr & "'"
                    ExecuteQuery(query3)
                    DbDisconnect()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                DisposeConnection()
            End Try

        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIP.Text = "127.0.0.1"
        txtUsername.Focus()
    End Sub

    Private Sub txtIP_Click(sender As Object, e As EventArgs) Handles txtIP.Click
        panelConfig.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a = TextBox1.Text
        If a = "" Then
            txtIP.Text = "127.0.0.1"
        Else
            txtIP.Text = ""
            txtIP.Text = a
        End If
        panelConfig.Visible = False
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        panelConfig.Visible = False
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub
End Class