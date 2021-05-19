Public Class frmBusinessList
    Private Sub frmBusinessList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadBOwners()
    End Sub

    Sub loadBOwners()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwBEstablishments.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT DISTINCT businessowner_ID, bo_name, bo_sex, bo_address  FROM businessowners order by bo_name"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwBEstablishments.Items.Add(reader.GetString("businessowner_ID"))
                    lvwBEstablishments.Items(i).Font = font
                    lvwBEstablishments.Items(i).SubItems.Add(reader.GetString("bo_name"))
                    lvwBEstablishments.Items(i).SubItems.Add(reader.GetString("bo_address"))
                    lvwBEstablishments.Items(i).SubItems.Add(reader.GetString("bo_sex"))
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

    Sub searchOwner(keyword As String)
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwBEstablishments.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT DISTINCT businessowner_ID, bo_name, bo_sex, bo_address  FROM businessowners WHERE bo_name LIKE '" & keyword & "%'"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwBEstablishments.Items.Add(reader.GetString("businessowner_ID"))
                    lvwBEstablishments.Items(i).Font = Font
                    lvwBEstablishments.Items(i).SubItems.Add(reader.GetString("bo_name"))
                    lvwBEstablishments.Items(i).SubItems.Add(reader.GetString("bo_address"))
                    lvwBEstablishments.Items(i).SubItems.Add(reader.GetString("bo_sex"))
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

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        If txtSearch.Text = "" Then
            loadBOwners()
        Else
            searchOwner(txtSearch.Text)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If lvwBEstablishments.SelectedIndices.Count > 0 Then
            searchboid = lvwBEstablishments.Items(lvwBEstablishments.SelectedIndices(0)).Text
            lvwBEstablishments.SelectedIndices.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz  "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub lvwBEstablishments_DoubleClick(sender As Object, e As EventArgs) Handles lvwBEstablishments.DoubleClick
        If lvwBEstablishments.SelectedIndices.Count > 0 Then
            searchboid = lvwBEstablishments.Items(lvwBEstablishments.SelectedIndices(0)).Text
            lvwBEstablishments.SelectedIndices.Clear()
            Me.Close()
        End If
    End Sub
End Class