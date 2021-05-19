Imports MySql.Data.MySqlClient

Module modReport
    Private conn As New MySqlConnection
    Dim cmd As MySqlCommand
    Dim adp As New MySqlDataAdapter

    Public Sub crConnect()
        Try
            conn = New MySqlConnection("server='" & frmLogin.txtIP.Text & "';uid=root;pwd='';database=dbstamaria;")
            conn.Open()
        Catch ex As Exception
            MsgBox("An error occured:" & ex.Message)
            Return
        End Try
    End Sub

    Public Sub executeCR(query As String)
        cmd = New MySqlCommand(query, conn)
        adp.SelectCommand = cmd

    End Sub

    Public Sub crDispose()
        cmd.Dispose()
        adp.Dispose()
        conn.Close()
    End Sub
End Module
