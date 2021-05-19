Public Class ucDeceased
    Dim edit As Integer = 0
    Dim rd As String
    Private Sub ucDeceased_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDeceased()
        butDisable()
        txtDisable()
    End Sub

    Sub saveDeceased()
        Dim dt = txtDate
        txtDate.Format = DateTimePickerFormat.Custom
        dt.CustomFormat = "MM-dd-yyyy"
        Try

            If edit = 1 Then
                DbConnect()
                Dim query As String = "UPDATE res_deceased SET rd_reason = '" & txtReason.Text & "', rd_date = '" & dt.Text & "' WHERE rd_id ='" & rd & "' "
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Profession successfully updated.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                butDisable()
                txtDisable()
                txtClear()
                loadDeceased()
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub loadDeceased()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwDeceased.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT rd_id, rd_reason, rd_date, res_name, res_sex, street_name FROM res_deceased INNER JOIN residence ON residence.res_id = res_deceased.res_ID INNER JOIN streets ON streets.street_id = residence.street_ID ORDER by rd_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwDeceased.Items.Add(reader.GetString("rd_id"))
                    lvwDeceased.Items(i).Font = font
                    lvwDeceased.Items(i).SubItems.Add(reader.GetString("res_name"))
                    lvwDeceased.Items(i).SubItems.Add(reader.GetString("res_sex"))
                    lvwDeceased.Items(i).SubItems.Add(reader.GetString("street_name"))
                    lvwDeceased.Items(i).SubItems.Add(reader.GetString("rd_reason"))
                    lvwDeceased.Items(i).SubItems.Add(reader.GetString("rd_date"))
                    i += 1
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured: ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub displayDeceased()
        Try
            DbConnect()
            Dim query As String = "SELECT rd_reason, rd_date, residence.res_id, res_name, res_sex, street_name FROM res_deceased INNER JOIN residence ON residence.res_id = res_deceased.res_ID INNER JOIN streets ON streets.street_id = residence.street_ID WHERE rd_id = '" & rd & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    res_name.Text = reader.GetString("res_name")
                    res_sex.Text = reader.GetString("res_sex")
                    res_add.Text = reader.GetString("street_name")
                    txtReason.Text = reader.GetString("rd_reason")
                    txtDate.Text = reader.GetString("rd_date")
                    txtresID.Text = reader.GetString("res_id")
                    txtrdID.Text = rd
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub delDeceased()
        Try
            If MetroFramework.MetroMessageBox.Show(Me, " 
Are you sure to unmark selected deceased resident?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = vbYes Then
                DbConnect()
                Dim query As String = " DELETE FROM res_deceased WHERE rd_id ='" & rd & "'"
                ExecuteQuery(query)
                DbDisconnect()

                DbConnect()
                Dim qry As String = " UPDATE residence SET is_deceased = 'no' WHERE res_id ='" & txtresID.Text & "'"
                ExecuteQuery(qry)
                DbDisconnect()

                MetroFramework.MetroMessageBox.Show(Me, " 
Selected deceased resident successfully deleted.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtDisable()
                txtClear()
                butDisable()
                loadDeceased()
                DbDisconnect()
            ElseIf vbNo Then
                Exit Sub
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub butDisable()
        btnEdit.Enabled = False
        btnCancel.Enabled = False
        btnDel.Enabled = False
        btnSave.Enabled = False
    End Sub

    Sub txtDisable()
        res_add.Enabled = False
        res_name.Enabled = False
        res_sex.Enabled = False
        txtReason.Enabled = False
        txtDate.Enabled = False
    End Sub

    Sub txtEnable()
        res_add.Enabled = True
        res_name.Enabled = True
        res_sex.Enabled = True
        txtReason.Enabled = True
        txtDate.Enabled = True
    End Sub

    Sub txtClear()
        res_add.Clear()
        res_name.Clear()
        res_sex.Clear()
        txtReason.Clear()
        txtDate.ResetText()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As New ucResidence
        toPanelMain(res.Width, res.Height, res)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtReason.Clear()
        txtReason.Enabled = False
        txtDate.Enabled = False
        butDisable()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            delDeceased()
            txtReason.Enabled = False
            txtDate.Enabled = False
            butDisable()
            loadDeceased()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        edit = 1
        btnEdit.Enabled = False
        btnDel.Enabled = False
        btnSave.Enabled = True
        txtReason.Enabled = True
        txtDate.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Trim(txtReason.Text) = "" Or Trim(txtDate.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Return
        End If
        saveDeceased()
    End Sub

    Private Sub lvwDeceased_Click(sender As Object, e As EventArgs) Handles lvwDeceased.Click
        rd = lvwDeceased.Items(lvwDeceased.SelectedIndices(0)).Text
        btnEdit.Enabled = True
        btnDel.Enabled = True
        btnCancel.Enabled = True
        displayDeceased()
    End Sub
End Class
