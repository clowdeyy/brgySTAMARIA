Imports System.IO
Public Class ucAddOfficials
    Dim edit As Integer = 0
    Dim offID As String
    Dim servingDay As String

    Private Sub ucAddOfficials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = True
        butDisable()
        txtDisable()

        loadLvw()
        loadType()
    End Sub

    Function ImageToBase64(ByVal image As Image, ByVal format As System.Drawing.Imaging.ImageFormat) As String
        Dim ms As New MemoryStream
        image.Save(ms, format)
        Dim imageByte() As Byte = ms.ToArray()
        Dim base64string As String = Convert.ToBase64String(imageByte)
        Return base64string
    End Function

    Function Base64ToImage(ByVal base64String As String) As Image
        Try
            Dim imageByte() As Byte = Convert.FromBase64String(base64String)
            Dim ms As New MemoryStream(imageByte, 0, imageByte.Length)
            ms.Write(imageByte, 0, imageByte.Length)
            Dim image As Image = Image.FromStream(ms, True)
            Return image
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Sub butDisable()
        btnCancel.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDel.Enabled = False
    End Sub

    Sub txtEnable()
        cboPos.Enabled = True
        txtName.Enabled = True
        btnUpload.Enabled = True
        grp.Enabled = True
    End Sub

    Sub txtDisable()
        cboPos.Enabled = False
        txtName.Enabled = False
        btnUpload.Enabled = False
        grp.Enabled = False
    End Sub

    Sub txtClear()
        cboPos.Items.Clear()
        txtName.Clear()
        radMon.Checked = False
        radTue.Checked = False
        radWed.Checked = False
        radThu.Checked = False
        radFri.Checked = False
        radSat.Checked = False
        radSun.Checked = False
        radEntire.Checked = False
        picImage.Image = My.Resources.none
    End Sub

    Sub loadType()
        cboPos.Items.Add("Barangay Captain")
        cboPos.Items.Add("Barangay Kagawad")
        cboPos.Items.Add("Barangay Secretary")
        cboPos.Items.Add("Barangay Treasurer")
    End Sub

    Private Sub radMon_CheckedChanged(sender As Object, e As EventArgs) Handles radMon.CheckedChanged
        servingDay = radMon.Text
    End Sub

    Private Sub radTue_CheckedChanged(sender As Object, e As EventArgs) Handles radTue.CheckedChanged
        servingDay = radTue.Text
    End Sub

    Private Sub radWed_CheckedChanged(sender As Object, e As EventArgs) Handles radWed.CheckedChanged
        servingDay = radWed.Text
    End Sub

    Private Sub radThu_CheckedChanged(sender As Object, e As EventArgs) Handles radThu.CheckedChanged
        servingDay = radThu.Text
    End Sub

    Private Sub radFri_CheckedChanged(sender As Object, e As EventArgs) Handles radFri.CheckedChanged
        servingDay = radFri.Text
    End Sub

    Private Sub radSat_CheckedChanged(sender As Object, e As EventArgs) Handles radSat.CheckedChanged
        servingDay = radSat.Text
    End Sub

    Private Sub radSun_CheckedChanged(sender As Object, e As EventArgs) Handles radSun.CheckedChanged
        servingDay = radSun.Text
    End Sub

    Private Sub radEntire_CheckedChanged(sender As Object, e As EventArgs) Handles radEntire.CheckedChanged
        servingDay = radEntire.Text
    End Sub

    Private Sub cboPos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPos.SelectedIndexChanged
        If cboPos.Text = "Barangay Captain" Then
            radEntire.Select()
        Else
            radEntire.Checked = False
        End If

        Try
            If cboPos.Text = "Barangay Captain" Then
                DbConnect()
                Dim query As String = " SELECT COUNT(*) FROM officials WHERE off_type = 'Barangay Captain' "
                ExecuteQueryParameter(query)
                Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
                If count = 1 Then
                    MetroFramework.MetroMessageBox.Show(Me, " 
Barangay Captain is already existing.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txtClear()
                    butDisable()
                    txtDisable()
                    loadType()
                End If
            ElseIf cboPos.Text = "Barangay Kagawad" Then
                DbConnect()
                Dim query As String = " SELECT COUNT(*) FROM officials WHERE off_type = 'Barangay Kagawad' "
                ExecuteQueryParameter(query)
                Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
                If count = 7 Then
                    MetroFramework.MetroMessageBox.Show(Me, " 
Barangay Kagawad has already reached its max data.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txtClear()
                    butDisable()
                    txtDisable()
                    loadType()
                End If
            ElseIf cboPos.Text = "Barangay Secretary" Then
                DbConnect()
                Dim query As String = " SELECT COUNT(*) FROM officials WHERE off_type = 'Barangay Secretary' "
                ExecuteQueryParameter(query)
                Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
                If count = 1 Then
                    MetroFramework.MetroMessageBox.Show(Me, " 
Barangay Secretary is already existing", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txtClear()
                    butDisable()
                    txtDisable()
                    loadType()
                End If
            ElseIf cboPos.Text = "Barangay Treasurer" Then
                DbConnect()
                Dim query As String = " SELECT COUNT(*) FROM officials WHERE off_type = 'Barangay Treasurer' "
                ExecuteQueryParameter(query)
                Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
                If count = 1 Then
                    MetroFramework.MetroMessageBox.Show(Me, " 
Barangay Treasurer is already existing.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txtClear()
                    butDisable()
                    txtDisable()
                    loadType()
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtEnable()
        btnSave.Enabled = True
        btnCancel.Enabled = True

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtDisable()
        txtClear()
        butDisable()
        btnAdd.Enabled = True
        loadType()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        edit = 1
        btnEdit.Enabled = False
        btnDel.Enabled = False
        btnSave.Enabled = True
        btnUpload.Enabled = True
        txtEnable()
        cboPos.Enabled = False
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            deleteOfficials()
            txtDisable()
            butDisable()
            btnAdd.Enabled = True
            loadLvw()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If edit = 0 Then
            If Trim(cboPos.Text) = "" Or Trim(txtName.Text) = "" Or Trim(servingDay) = "" Then
                MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return
            End If
            saveOfficials()
        ElseIf edit = 1 Then
            If Trim(txtName.Text) = "" Or Trim(servingDay) = "" Then
                MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return
            End If
            saveOfficials()
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        OpenFileDialog1.Filter = "Image Files(*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF|All Files(*.*)| *.* "
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            picImage.Image = Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Sub saveOfficials()
        Dim day As String = servingDay.ToString
        Try
            If edit = 0 Then

                DbConnect()
                Dim query As String = "INSERT INTO officials SET off_image ='" & ImageToBase64(picImage.Image, System.Drawing.Imaging.ImageFormat.Png) & "', " _
                    & " off_name = '" & txtName.Text & "', off_type = '" & cboPos.Text & "', off_servingday = '" & day & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Baranaga official successfully added.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                btnAdd.Enabled = True
                btnSave.Enabled = False
                btnUpload.Enabled = False
                txtClear()
                txtDisable()
                butDisable()
                loadLvw()
                loadType()
                DbDisconnect()

            ElseIf edit = 1 Then

                DbConnect()
                Dim query As String = "UPDATE officials SET off_image ='" & ImageToBase64(picImage.Image, System.Drawing.Imaging.ImageFormat.Png) & "', " _
                    & " off_name = '" & txtName.Text & "', off_servingday = '" & day & "' WHERE off_id = '" & offID & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Resident successfully updated.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                btnAdd.Enabled = True
                btnSave.Enabled = False
                btnUpload.Enabled = False
                txtClear()
                txtDisable()
                butDisable()
                loadLvw()
                loadType()
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub loadLvw()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwOfficials.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT off_id, off_name, off_type, off_servingday FROM officials ORDER by off_type"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwOfficials.Items.Add(reader.GetString("off_id"))
                    lvwOfficials.Items(i).Font = font
                    lvwOfficials.Items(i).SubItems.Add(reader.GetString("off_name"))
                    lvwOfficials.Items(i).SubItems.Add(reader.GetString("off_type"))
                    lvwOfficials.Items(i).SubItems.Add(reader.GetString("off_servingday"))
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

    Sub displayOfficials()
        Try
            DbConnect()
            Dim query As String = "SELECT off_id, off_name, off_type, off_servingday, off_image FROM officials WHERE off_id ='" & offID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    'cboPos.Text = reader.GetString("off_type")
                    txtName.Text = reader.GetString("off_name")
                    picImage.Image = Base64ToImage(reader.GetString("off_image"))
                    If radMon.Text = reader.GetString("off_servingday") Then
                        radMon.Select()
                    ElseIf radTue.Text = reader.GetString("off_servingday") Then
                        radTue.Select()
                    ElseIf radWed.Text = reader.GetString("off_servingday") Then
                        radWed.Select()
                    ElseIf radThu.Text = reader.GetString("off_servingday") Then
                        radThu.Select()
                    ElseIf radFri.Text = reader.GetString("off_servingday") Then
                        radFri.Select()
                    ElseIf radSat.Text = reader.GetString("off_servingday") Then
                        radSat.Select()
                    ElseIf radSun.Text = reader.GetString("off_servingday") Then
                        radSun.Select()
                    ElseIf radEntire.Text = reader.GetString("off_servingday") Then
                        radEntire.Select()
                    End If
                    txtID.Text = offID
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub deleteOfficials()
        Try
            If MetroFramework.MetroMessageBox.Show(Me, " 
Are you sure to delete selected official?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = vbYes Then
                DbConnect()
                Dim query As String = " DELETE FROM officials WHERE off_id ='" & offID & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Selected official successfully deleted.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                btnAdd.Enabled = True
                btnEdit.Enabled = False
                btnDel.Enabled = False
                btnCancel.Enabled = False
                txtClear()
                txtDisable()
                loadLvw()
                DbDisconnect()
            ElseIf vbNo Then
                txtClear()
                Exit Sub
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub lvwOfficials_Click(sender As Object, e As EventArgs) Handles lvwOfficials.Click
        If lvwOfficials.SelectedItems.Count > 0 Then
            Try
                offID = lvwOfficials.Items(lvwOfficials.SelectedIndices(0)).Text
                btnAdd.Enabled = False
                btnEdit.Enabled = True
                btnDel.Enabled = True
                btnCancel.Enabled = True
                displayOfficials()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                DisposeConnection()
            End Try
        End If
    End Sub


    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz  "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class
