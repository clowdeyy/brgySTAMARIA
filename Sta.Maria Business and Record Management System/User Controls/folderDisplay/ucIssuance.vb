Public Class ucIssuance
    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click
        Dim pay As New ucPay
        toPanelMain(pay.Width, pay.Height, pay)
    End Sub

    Private Sub btnIs_Click(sender As Object, e As EventArgs) Handles btnIs.Click
        Dim pay As New ucPay
        toPanelMain(pay.Width, pay.Height, pay)
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Dim lor As New ucListofReports
        toPanelMain(lor.Width, lor.Height, lor)
    End Sub

    Private Sub btnLists_Click(sender As Object, e As EventArgs) Handles btnLists.Click
        Dim lor As New ucListofReports
        toPanelMain(lor.Width, lor.Height, lor)
    End Sub

    Private Sub btnMn_Click(sender As Object, e As EventArgs) Handles btnMn.Click
        Dim ca As New ucCertAmount
        toPanelMain(ca.Width, ca.Height, ca)
    End Sub

    Private Sub btnMns_Click(sender As Object, e As EventArgs) Handles btnMns.Click
        Dim ca As New ucCertAmount
        toPanelMain(ca.Width, ca.Height, ca)
    End Sub

    Private Sub ucIssuance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmLogin.clerk Then
            btnMn.Visible = False
            btnMns.Visible = False
            TextBox3.Visible = False
        End If
    End Sub
End Class
