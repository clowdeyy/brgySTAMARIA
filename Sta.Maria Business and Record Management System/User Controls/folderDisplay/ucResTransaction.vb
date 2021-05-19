Public Class ucResTransaction
    Private Sub ucResTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLogs()
    End Sub

    Sub loadLogs()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwTransac.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT rl_id, res_name,rl_action, rl_date, rl_performby FROM residencelogs INNER JOIN residence ON residencelogs.res_id = residence.res_id WHERE residencelogs.res_id = '" & searchboid & "' ORDER by rl_date"
            ExecuteQuery(query)

            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwTransac.Items.Add(reader.GetString("rl_id"))
                    lvwTransac.Items(i).Font = Font
                    lvwTransac.Items(i).SubItems.Add(reader.GetString("res_name"))
                    lvwTransac.Items(i).SubItems.Add(reader.GetString("rl_action"))
                    lvwTransac.Items(i).SubItems.Add(reader.GetString("rl_date"))
                    lvwTransac.Items(i).SubItems.Add(reader.GetString("rl_performby"))
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As New ucResidence
        toPanelMain(res.Width, res.Height, res)
    End Sub
End Class
