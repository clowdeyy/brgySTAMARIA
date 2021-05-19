Public Class ucMaintenance
    Private Sub btnResidence_Click(sender As Object, e As EventArgs) Handles btnResidence.Click
        Dim res As New ucAddResidence
        toPanelMain(res.Width, res.Height, res)
    End Sub

    Private Sub btnRes_Click(sender As Object, e As EventArgs) Handles btnRes.Click
        Dim res As New ucAddResidence
        toPanelMain(res.Width, res.Height, res)
    End Sub

    Private Sub btnBusiness_Click(sender As Object, e As EventArgs) Handles btnBusiness.Click
        Dim bus As New ucAddBusiness
        toPanelMain(bus.Width, bus.Height, bus)
    End Sub

    Private Sub btnBus_Click(sender As Object, e As EventArgs) Handles btnBus.Click
        Dim bus As New ucAddBusiness
        toPanelMain(bus.Width, bus.Height, bus)
    End Sub

    Private Sub btnZones_Click(sender As Object, e As EventArgs) Handles btnZones.Click
        Dim zone As New ucAddZones
        toPanelMain(zone.Width, zone.Height, zone)
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        Dim zone As New ucAddZones
        toPanelMain(zone.Width, zone.Height, zone)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim user As New ucAddUsers
        toPanelMain(user.Width, user.Height, user)
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        Dim user As New ucAddUsers
        toPanelMain(user.Width, user.Height, user)
    End Sub

    Private Sub btnBlack_Click(sender As Object, e As EventArgs) Handles btnBlack.Click
        Dim black As New ucAddBlacklisted
        toPanelMain(black.Width, black.Height, black)
    End Sub

    Private Sub btnBlacklisted_Click(sender As Object, e As EventArgs) Handles btnBlacklisted.Click
        Dim black As New ucAddBlacklisted
        toPanelMain(black.Width, black.Height, black)
    End Sub

    Private Sub btnHouse_Click(sender As Object, e As EventArgs) Handles btnHouse.Click
        Dim hh As New ucAddHousehold
        toPanelMain(hh.Width, hh.Height, hh)
    End Sub

    Private Sub btnHousehold_Click(sender As Object, e As EventArgs) Handles btnHousehold.Click
        Dim hh As New ucAddHousehold
        toPanelMain(hh.Width, hh.Height, hh)
    End Sub

    Private Sub ucMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmLogin.secretary Then
            btnUsers.Visible = False
            btnU.Visible = False
            TextBox4.Visible = False
            btnZones.Location = New Point(403, 433)
            btnZ.Location = New Point(494, 433)
            TextBox3.Location = New Point(499, 469)
        End If
    End Sub
End Class
