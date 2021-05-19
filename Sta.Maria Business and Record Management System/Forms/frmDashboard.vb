Public Class frmDashboard
    Dim transdate = DateTime.Now.ToString("MM-dd-yyyy")

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss dddd, dd MMMM yyyy")
    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click, txtUser.Click, txtID.Click
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss dddd, dd MMMM yyyy")
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        sidePanel.Top = btnLogout.Top
        sidePanel.Height = btnLogout.Height

        If (MetroFramework.MetroMessageBox.Show(Me, " 
Are you sure to Exit?", "Exit from the system", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)) = DialogResult.Yes Then
            DbConnect()
            Dim query1 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= '" & txtID.Text & "'), ul_action = 'Logged out', ul_date = '" & transdate & "'"
            ExecuteQuery(query1)
            DbDisconnect()

            DbConnect()
            Dim qry As String = "UPDATE users SET user_flag = 'OFFLINE' WHERE user_ID = '" & txtID.Text & "'"
            ExecuteQuery(qry)
            DbDisconnect()
            frmLogin.txtUsername.Text = ""
            frmLogin.txtPassword.Text = ""
            frmLogin.Show()
            frmLogin.txtUsername.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DbConnect()
            Dim query As String = "SELECT user_fullname, user_id FROM users WHERE user_Username = '" & frmLogin.txtUsername.Text & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtUser.Text = reader.GetString("user_fullname")
                    txtID.Text = reader.GetString("user_id")
                End While
            End If
            DbDisconnect()

            Dim dash As New ucDashboard
            toPanelMain(dash.Width, dash.Height, dash)
        Catch ex As Exception
            MsgBox("An error occured:" & ex.Message)
        End Try


        If frmLogin.clerk Then
            btnMaint.Visible = False
            btnLogout.Location = New Point(12, 416)
        End If

    End Sub

    Private Sub btnResidence_Click(sender As Object, e As EventArgs) Handles btnResidence.Click
        sidePanel.Top = btnResidence.Top
        sidePanel.Height = btnResidence.Height

        Dim res As New ucHR
        toPanelMain(res.Width, res.Height, res)
    End Sub

    Private Sub btnBusiness_Click(sender As Object, e As EventArgs) Handles btnBusiness.Click
        sidePanel.Top = btnBusiness.Top
        sidePanel.Height = btnBusiness.Height

        Dim bus As New ucBusiness
        toPanelMain(bus.Width, bus.Height, bus)
    End Sub

    Private Sub btnMaint_Click(sender As Object, e As EventArgs) Handles btnMaint.Click
        sidePanel.Top = btnMaint.Top
        sidePanel.Height = btnMaint.Height

        Dim maint As New ucMaintenance
        toPanelMain(maint.Width, maint.Height, maint)
    End Sub

    Private Sub btnDisaster_Click(sender As Object, e As EventArgs) Handles btnDisaster.Click
        sidePanel.Height = btnDisaster.Height
        sidePanel.Top = btnDisaster.Top

        Dim dis As New ucDashboard
        toPanelMain(dis.Width, dis.Height, dis)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        sidePanel.Height = btnReport.Height
        sidePanel.Top = btnReport.Top

        Dim rep As New ucIssuance
        toPanelMain(rep.Width, rep.Height, rep)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        sidePanel.Height = btnDashboard.Height
        sidePanel.Top = btnDashboard.Top

        Dim dash As New ucDashboard
        toPanelMain(dash.Width, dash.Height, dash)
    End Sub
End Class