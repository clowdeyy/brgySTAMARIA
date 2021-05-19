Public Class frmResidenceListV
    Private Sub frmResidenceListV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadResidence()
    End Sub

    Sub loadResidence()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwResidence.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT res_id, res_name, res_status, res_sex, street_name FROM residence,streets where residence.street_id = streets.street_ID AND is_deceased = 'no' AND res_type = 'Voter' order by res_name"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwResidence.Items.Add(reader.GetString("res_id"))
                    lvwResidence.Items(i).Font = font
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_name"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("street_name"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_sex"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_status"))
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

    Sub searchResident(keyword As String)
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwResidence.Items.Clear()
        Try
            DbConnect()
            Dim query As String = " SELECT res_id, res_name, res_type, res_sex, res_status, street_name FROM residence, streets WHERE residence.street_id = streets.street_id AND is_deceased = 'no' AND  AND res_type = 'Voter' AND res_name LIKE '" & keyword & "%'"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwResidence.Items.Add(reader.GetString("res_id"))
                    lvwResidence.Items(i).Font = Font
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_name"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("street_name"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_sex"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_status"))
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
            loadResidence()
        Else
            searchResident(txtSearch.Text)
        End If
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If lvwResidence.SelectedIndices.Count > 0 Then
            searchresid = lvwResidence.Items(lvwResidence.SelectedIndices(0)).Text
            lvwResidence.SelectedIndices.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
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

    Private Sub lvwResidence_DoubleClick(sender As Object, e As EventArgs) Handles lvwResidence.DoubleClick
        If lvwResidence.SelectedIndices.Count > 0 Then
            searchresid = lvwResidence.Items(lvwResidence.SelectedIndices(0)).Text
            lvwResidence.SelectedIndices.Clear()
            Me.Close()
        End If
    End Sub
End Class