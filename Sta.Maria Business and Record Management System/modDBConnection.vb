Imports MySql.Data.MySqlClient

Module modDBConnection
    Public connect As New MySqlConnection
    Public reader As MySqlDataReader
    Public command As New MySqlCommand
    Public Adapter As New MySqlDataAdapter
    Public searchresid As String
    Public searchboid As String
    Public printboid As String
    Public printresid As String

    Public Sub DbConnect()
        Try
            connect = New MySqlConnection("server='" & frmLogin.txtIP.Text & "';uid=root;pwd='';database=dbstamaria;")
            'connect = New MySqlConnection("server=localhost;uid=root;pwd='';database=dbstamaria;")
            connect.Open()
        Catch ex As Exception
            MsgBox("An error occured:" & ex.Message)
            Return
        End Try

    End Sub

    Public Sub DbDisconnect()
        connect.Close()
    End Sub


    Public Sub ExecuteQuery(query As String)
        Try
            command = New MySqlCommand(query, connect)
            reader = command.ExecuteReader
        Catch ex As Exception
            MsgBox("An error occured:" & ex.Message)
            Return
        End Try

    End Sub


    Public Sub ExecuteQueryParameter(query As String)
        command = New MySqlCommand(query, connect)
    End Sub

    Public Sub DisposeConnection()
        connect.Dispose()
    End Sub

    ''pans
    Public Sub toPanelMain(width As Integer, height As Integer, control As Control)
        control.SetBounds((frmDashboard.panelMain.Width - width) / 2, (frmDashboard.panelMain.Width - width) / 2, width, height)
        frmDashboard.panelMain.Controls.Clear()
        frmDashboard.panelMain.Controls.Add(control)
    End Sub
End Module
