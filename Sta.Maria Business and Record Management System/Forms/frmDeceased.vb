Public Class frmDeceased
    Dim transdate = DateTime.Now.ToString("MM-dd-yyyy")
    Private Sub lblExit_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim res As New ucResidence
        toPanelMain(res.Width, res.Height, res)
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tdate As String = txtDate.Text
        Try
            If Trim(txtDate.Text) = "" Or Trim(txtReason.Text) = "" Then
                MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            Else
                DbConnect()
                Dim qry As String = "INSERT INTO res_deceased SET rd_reason = '" & txtReason.Text.Replace("'", "`").ToString & "', rd_date = '" & tdate & "', res_id = '" & res_ID.Text & "'  "
                ExecuteQuery(qry)
                DbDisconnect()

                DbConnect()
                Dim query As String = "UPDATE residence SET is_deceased = 'yes' WHERE res_id = '" & res_ID.Text & "'"
                ExecuteQuery(query)

                MetroFramework.MetroMessageBox.Show(Me, " 
Selected resident marked as deceased.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                DbDisconnect()

                DbConnect()
                Dim query1 As String = " INSERT INTO residencelogs SET  rl_action = 'Marked as Deceased', rl_date = '" & transdate & "', rl_performby = '" & frmDashboard.txtUser.Text & "', res_id = '" & res_ID.Text & "' "
                ExecuteQuery(query1)
                DbDisconnect()

                DbConnect()
                Dim query2 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= '" & frmDashboard.txtID.Text & "'), ul_action = 'Marked a resident as deceased: " & res_name.Text.ToUpper & "', ul_date = '" & transdate & "'"
                ExecuteQuery(query2)
                DbDisconnect()
                Dim res As New ucResidence
                toPanelMain(res.Width, res.Height, res)
                Me.Dispose()
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub


    Private Sub txtReason_KeyDown(sender As Object, e As KeyEventArgs) Handles txtReason.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub txtDate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub
End Class