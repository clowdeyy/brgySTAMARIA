Public Class frmConfirm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnCont_Click(sender As Object, e As EventArgs) Handles btnCont.Click
        Dim pw As String = txtPw.Text
        Dim name As String = frmDashboard.txtUser.Text
        Dim transdate = DateTime.Now.ToString("MM-dd-yyyy")

        If Trim(pw) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try
                DbConnect()
                Dim query As String = "SELECT * FROM users WHERE user_password = @password AND user_fullname = @name"
                ExecuteQueryParameter(query)
                command.Parameters.AddWithValue("@password", pw)
                command.Parameters.AddWithValue("@name", name)
                reader = command.ExecuteReader

                If reader.HasRows Then
                    reader.Read()
                    If reader.Item("user_type") = "Barangay Captain" Then
                        DbConnect()
                        Dim qry As String = "INSERT INTO certificationclear SET cc_purpose = '" & txtPurp.Text & "', cc_date = '" & transdate & "', cc_by = '" & frmDashboard.txtUser.Text & "'"
                        ExecuteQuery(qry)
                        DbConnect()

                        DbConnect()
                        Dim qrys As String = "TRUNCATE TABLE certificationreport"
                        ExecuteQuery(qrys)
                        DbConnect()

                        DbConnect()
                        Dim query2 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= '" & frmDashboard.txtID.Text & "'), ul_action = 'TRUNCATED CERTIFICATION LIST', ul_date = '" & transdate & "'"
                        ExecuteQuery(query2)
                        DbDisconnect()

                        MetroFramework.MetroMessageBox.Show(Me, " 
Certification list successfully truncated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        Dim lor As New ucListofReports
                        toPanelMain(lor.Width, lor.Height, lor)
                        Me.Dispose()

                    ElseIf reader.Item("user_type") = "Secretary" Then
                        DbConnect()
                        Dim qry As String = "INSERT INTO certificationclear SET cc_purpose = '" & txtPurp.Text & "', cc_date = '" & transdate & "', cc_by = '" & frmDashboard.txtUser.Text & "'"
                        ExecuteQuery(qry)
                        DbConnect()

                        Dim qrys As String = "TRUNCATE TABLE certificationreport"
                        ExecuteQuery(qrys)
                        DbConnect()

                        DbConnect()
                        Dim query2 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= '" & frmDashboard.txtID.Text & "'), ul_action = 'TRUNCATED CERTIFICATION LIST', ul_date = '" & transdate & "'"
                        ExecuteQuery(query2)
                        DbDisconnect()

                        MetroFramework.MetroMessageBox.Show(Me, " 
Certification list successfully truncated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        Dim lor As New ucListofReports
                        toPanelMain(lor.Width, lor.Height, lor)
                        Me.Dispose()
                    End If
                Else
                    MetroFramework.MetroMessageBox.Show(Me, " 
Invalid password", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
                DbDisconnect()

            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                DisposeConnection()
            End Try
        End If
    End Sub
End Class