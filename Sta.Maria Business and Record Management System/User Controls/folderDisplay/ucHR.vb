Public Class ucHR
    Private Sub btnRes_Click(sender As Object, e As EventArgs) Handles btnRes.Click
        Dim res As New ucResidence
        toPanelMain(res.Width, res.Height, res)
    End Sub

    Private Sub btnResidence_Click(sender As Object, e As EventArgs) Handles btnResidence.Click
        Dim res As New ucResidence
        toPanelMain(res.Width, res.Height, res)
    End Sub

    Private Sub btnHouse_Click(sender As Object, e As EventArgs) Handles btnHouse.Click
        Dim hh As New ucHousehold
        toPanelMain(hh.Width, hh.Height, hh)
    End Sub

    Private Sub btnHousehold_Click(sender As Object, e As EventArgs) Handles btnHousehold.Click
        Dim hh As New ucHousehold
        toPanelMain(hh.Width, hh.Height, hh)
    End Sub
End Class
