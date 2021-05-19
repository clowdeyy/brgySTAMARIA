Imports System.IO


Public Class ucAddResidence
    Dim edit As Integer = 0
    Dim resID As String
    Dim resType As String
    Dim sexType As String
    Dim street As String
    Dim sID As String

    Private Sub radV_CheckedChanged(sender As Object, e As EventArgs) Handles radV.CheckedChanged
        resType = radV.Text
        If radV.Checked = True Then
            txtGName.Clear()
            txtGPrecint.Clear()
            txtGPrecint.Clear()
            txtGRelation.Clear()
            grpVoter.Visible = True
            grpNonV.Visible = False
            grpVoter.BringToFront()
            grpNonV.SendToBack()
        End If
    End Sub

    Private Sub radN_CheckedChanged(sender As Object, e As EventArgs) Handles radN.CheckedChanged
        resType = radN.Text
        If radN.Checked = True Then
            txtVPrecint.Clear()
            txtGName.Clear()
            txtGPrecint.Clear()
            txtGPrecint.Clear()
            txtGRelation.Clear()
            grpNonV.Visible = True
            grpVoter.Visible = False
            grpNonV.BringToFront()
            grpVoter.SendToBack()
        End If
    End Sub

    Private Sub radM_CheckedChanged(sender As Object, e As EventArgs) Handles radM.CheckedChanged
        sexType = radM.Text
    End Sub

    Private Sub radF_CheckedChanged(sender As Object, e As EventArgs) Handles radF.CheckedChanged
        sexType = radF.Text
    End Sub

    Sub butEnable()
        btnCancel.Enabled = True
        btnEdit.Enabled = True
        btnDel.Enabled = True
        btnSave.Enabled = True
    End Sub

    Sub butDisable()
        btnCancel.Enabled = False
        btnEdit.Enabled = False
        btnDel.Enabled = False
        btnSave.Enabled = False

    End Sub

    Sub txtDisable()
        btnprof.Enabled = False
        radV.Enabled = False
        radN.Enabled = False
        radM.Enabled = False
        radF.Enabled = False
        txtName.Enabled = False
        cboStatus.Enabled = False
        txtNationality.Enabled = False
        cboReligion.Enabled = False
        txtBdate.Enabled = False
        txtProfession.Enabled = False
        txtBirthplace.Enabled = False
        txtYrs.Enabled = False
        cboAddress.Enabled = False

        txtVPrecint.Enabled = False
        txtGName.Enabled = False
        txtGPrecint.Enabled = False
        txtGRelation.Enabled = False
        btnSearch.Enabled = False
    End Sub

    Sub txtEnable()
        btnprof.Enabled = True
        radV.Enabled = True
        radN.Enabled = True
        radM.Enabled = True
        radF.Enabled = True
        txtName.Enabled = True
        cboStatus.Enabled = True
        txtNationality.Enabled = True
        cboReligion.Enabled = True
        txtBdate.Enabled = True
        txtProfession.Enabled = True
        txtBirthplace.Enabled = True
        txtYrs.Enabled = True

        txtVPrecint.Enabled = True
        txtGRelation.Enabled = True
        btnSearch.Enabled = True
    End Sub

    Sub txtClear()
        radV.Checked = False
        radN.Checked = False
        radM.Checked = False
        radF.Checked = False
        txtHousehold.Clear()
        txtName.Clear()
        cboStatus.Items.Clear()
        txtNationality.Clear()
        cboReligion.Items.Clear()
        txtBdate.Text = ""
        txtProfession.Text = ""
        txtBirthplace.Clear()
        txtYrs.Clear()
        cboAddress.Items.Clear()
        picImage.Image = My.Resources.na

        txtVPrecint.Clear()
        txtGName.Clear()
        txtGPrecint.Clear()
        txtGRelation.Clear()
    End Sub

    Sub loadAddress()
        DbConnect()
        Dim query As String = "SELECT street_id, street_name FROM streets ORDER BY street_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboAddress.Items.Clear()
            While reader.Read
                cboAddress.Items.Add(reader.GetString(1))
            End While
        End If
        DbDisconnect()
    End Sub

    Sub loadProfession()
        DbConnect()
        Dim query As String = "SELECT prof_name FROM res_prof ORDER BY prof_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            txtProfession.Items.Clear()
            While reader.Read
                txtProfession.Items.Add(reader.GetString("prof_name"))
            End While
        End If
        DbDisconnect()
    End Sub

    Sub loadCivilStatus()
        cboStatus.Items.Add("Single")
        cboStatus.Items.Add("Married")
        cboStatus.Items.Add("Widowed")
        cboStatus.Items.Add("Separated")
        cboStatus.Items.Add("Divorced")
    End Sub

    Sub loadReligion()

        cboReligion.Items.Add("Islam")
        cboReligion.Items.Add("RC")
        cboReligion.Items.Add("Alliance")
        cboReligion.Items.Add("Others")

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


    Sub search(keyword As String)
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)

        lvwResidence.Items.Clear()
        Try
            DbConnect()
            Dim query As String = " SELECT res_id, res_name, res_type FROM residence WHERE res_name LIKE '" & keyword & "%' OR res_type LIKE '" & keyword & "%' "
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwResidence.Items.Add(reader.GetString("res_id"))
                    lvwResidence.Items(i).Font = font
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_name"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_type"))
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

    Sub loadLvw()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwResidence.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT res_id, res_name, res_type FROM residence ORDER by res_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwResidence.Items.Add(reader.GetString("res_id"))
                    lvwResidence.Items(i).Font = font
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_name"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_type"))
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

    Sub displayResidence()
        txtVPrecint.Text = ""
        txtGName.Text = ""
        txtGPrecint.Text = ""
        txtGRelation.Text = ""
        txtYrs.Text = ""
        txtProfession.Text = ""
        Try
            DbConnect()
            Dim query As String = "SELECT hh_type, street_name, res_religion, res_status, res_name, res_bdate, res_profession, res_nationality, res_stay, res_bplace, res_nationality, res_precint, res_type, res_sex, res_image " _
                                   & "FROM residence INNER JOIN streets ON streets.street_id = residence.street_id INNER JOIN household ON household.hh_id = residence.hh_id  WHERE res_id = '" & resID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtHousehold.Text = reader.GetString("hh_type")
                    cboAddress.Text = reader.GetString("street_name")
                    cboReligion.Text = reader.GetString("res_religion")
                    cboStatus.Text = reader.GetString("res_status")
                    txtName.Text = reader.GetString("res_name")
                    txtBdate.Value = reader.GetString("res_bdate")
                    txtBirthplace.Text = reader.GetString("res_bplace")
                    txtNationality.Text = reader.GetString("res_nationality")
                    txtVPrecint.Text = reader.GetString("res_precint")
                    Dim columnProfession = reader.GetOrdinal("res_profession")
                    Dim columnStay = reader.GetOrdinal("res_stay")

                    Dim prof As String = Nothing
                    If Not reader.IsDBNull(columnProfession) Then
                        prof = reader.GetString("res_profession")
                        txtProfession.Text = prof
                    End If

                    Dim sty As String = Nothing
                    If Not reader.IsDBNull(columnStay) Then
                        sty = reader.GetString("res_stay")
                        txtYrs.Text = sty
                    End If

                    If radM.Text = reader.GetString("res_sex") Then
                        radM.Select()
                    ElseIf radF.Text = reader.GetString("res_sex") Then
                        radF.Select()
                    End If

                    If radV.Text = reader.GetString("res_type") Then
                        radV.Select()
                    ElseIf radN.Text = reader.GetString("res_type") Then
                        radN.Select()
                    End If
                    picImage.Image = Base64ToImage(reader.GetString("res_image"))
                    ' picImage.Image = Base64ToImage(reader.Item("res_image").ToString)
                    txtID.Text = resID

                End While
            End If
            DbDisconnect()

            DbConnect()
            Dim qry As String = "SELECT guar_name, guar_relation, guar_precint FROM res_guarantor WHERE res_id = '" & resID & "'"
            ExecuteQuery(qry)
            If reader.HasRows Then
                While reader.Read
                    Dim cloumnGuarname = reader.GetOrdinal("guar_name")
                    Dim columnGuarprecint = reader.GetOrdinal("guar_precint")
                    Dim columnGuarrelation = reader.GetOrdinal("guar_relation")

                    Dim guarn As String = Nothing
                    If Not reader.IsDBNull(cloumnGuarname) Then
                        guarn = reader.GetString("guar_name")
                        txtGName.Text = guarn
                    End If

                    Dim guarp As String = Nothing
                    If Not reader.IsDBNull(columnGuarprecint) Then
                        guarp = reader.GetString("guar_precint")
                        txtGPrecint.Text = guarp
                    End If

                    Dim guarr As String = Nothing
                    If Not reader.IsDBNull(columnGuarrelation) Then
                        guarr = reader.GetString("guar_relation")
                        txtGRelation.Text = guarr
                    End If
                End While
            End If
            DbDisconnect()

            DbConnect()
            Dim ar As String = "SELECT street_id FROM streets WHERE street_name = '" & cboAddress.Text & "'"
            ExecuteQuery(ar)
            If reader.HasRows Then
                While reader.Read
                    street = reader.GetString("street_id")
                End While
            End If
            DbDisconnect()

            DbConnect()
            Dim qrry As String = "SELECT zone_no FROM streets, zone WHERE streets.zone_id = zone.zone_id AND street_id ='" & street.ToString & "'"
            ExecuteQuery(qrry)
            If reader.HasRows Then
                While reader.Read
                    cboZone.Text = reader.GetString("zone_no")
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub saveResidence()
        Dim transdate = DateTime.Now.ToString("MM-dd-yyyy")
        Dim sex As String = sexType.ToString
        Dim type As String = resType.ToString
        Dim bday = txtBdate
        txtBdate.Format = DateTimePickerFormat.Custom
        bday.CustomFormat = "yyyy-MM-dd"


        Try
            If edit = 0 Then
                DbConnect()
                Dim qry0 As String = "SET GLOBAL max_allowed_packet=32*1024*1024;"
                Dim query3 As String = "SELECT street_id FROM streets WHERE street_name = '" & cboAddress.Text & "'"
                ExecuteQuery(qry0 + query3)
                If reader.HasRows Then
                    While reader.Read
                        street = reader.GetString(0)
                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim query As String = "INSERT INTO residence SET res_image ='" & ImageToBase64(picImage.Image, System.Drawing.Imaging.ImageFormat.Png) & "'," _
                    & " res_type ='" & resType & "', res_name ='" & txtName.Text & "', res_status ='" & cboStatus.Text & "', res_sex ='" & sexType & "'," _
                    & " res_nationality ='" & txtNationality.Text & "', res_religion ='" & cboReligion.Text & "', res_bdate ='" & bday.Text & "', res_profession ='" & txtProfession.Text & "', res_bplace ='" & txtBirthplace.Text & "'," _
                    & " res_stay ='" & txtYrs.Text & "', res_precint ='" & txtVPrecint.Text & "', guar_name ='" & txtGName.Text & "', guar_relation ='" & txtGRelation.Text & "', guar_precint ='" & txtGPrecint.Text & "', street_id = '" & street & "' "
                ExecuteQuery(query)
                If MetroFramework.MetroMessageBox.Show(Me, " 
You are about to save resident information, please consider by clicking 'Yes', the filled-out fields are true and correct.", "Please Conifrm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    MetroFramework.MetroMessageBox.Show(Me, " 
Resident successfully added.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Else
                    Return
                End If
                btnAdd.Enabled = True
                btnSave.Enabled = False
                btnUpload.Enabled = False
                btnCapture.Enabled = False
                txtClear()
                txtDisable()
                butDisable()
                loadLvw()
                loadAddress()
                loadCivilStatus()
                loadProfession()
                loadReligion()
                grpVoter.Visible = False
                grpNonV.Visible = False
                DbDisconnect()

            ElseIf edit = 1 Then
                DbConnect()
                Dim query3 As String = "SELECT street_id FROM streets WHERE street_name = '" & cboAddress.Text & "'"
                ExecuteQuery(query3)
                If reader.HasRows Then
                    While reader.Read
                        street = reader.GetString(0)
                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim query As String = "UPDATE residence SET res_image ='" & ImageToBase64(picImage.Image, System.Drawing.Imaging.ImageFormat.Png) & "'," _
                    & " res_type ='" & resType & "', res_name ='" & txtName.Text & "', res_status ='" & cboStatus.Text & "', res_sex ='" & sexType & "'," _
                    & " res_nationality ='" & txtNationality.Text & "', res_religion ='" & cboReligion.Text & "', res_bdate ='" & bday.Text & "', res_profession ='" & txtProfession.Text & "', res_bplace ='" & txtBirthplace.Text & "'," _
                    & " res_stay ='" & txtYrs.Text & "', res_precint ='" & txtVPrecint.Text & "',  street_id ='" & street & "' WHERE res_id = '" & resID & "'"
                ExecuteQuery(query)
                DbDisconnect()

                DbConnect()
                Dim qry As String = "INSERT INTO res_guarantor SET guar_name ='" & txtGName.Text & "', guar_relation ='" & txtGRelation.Text.Replace("'", "`").ToString & "', guar_precint ='" & txtGPrecint.Text & "', res_id = '" & resID & "' "
                ExecuteQuery(qry)
                DbDisconnect()

                DbConnect()
                Dim query2 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= '" & frmDashboard.txtID.Text & "'), ul_action = 'Updated resident personal information: " & txtName.Text & "', ul_date = '" & transdate & "'"
                ExecuteQuery(query2)
                DbDisconnect()

                MetroFramework.MetroMessageBox.Show(Me, " 
Resident successfully updated.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                btnAdd.Enabled = True
                btnSave.Enabled = False
                btnUpload.Enabled = False
                btnCapture.Enabled = False
                txtClear()
                txtDisable()
                butDisable()
                loadLvw()
                loadAddress()
                loadCivilStatus()
                loadProfession()
                loadReligion()
                grpVoter.Visible = False
                grpNonV.Visible = False


                DbConnect()
                Dim query1 As String = " INSERT INTO residencelogs SET  rl_action = 'Updated resident information', rl_date = '" & transdate & "', rl_performby = '" & frmDashboard.txtUser.Text & "', res_id = '" & resID & "' "
                ExecuteQuery(query1)
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub deleteResidence()
        Try
            If MetroFramework.MetroMessageBox.Show(Me, " 
Are you sure to delete selected resident?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = vbYes Then
                DbConnect()
                Dim query As String = " DELETE FROM residence WHERE res_id ='" & resID & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Selected resident successfully deleted.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                btnAdd.Enabled = True
                btnEdit.Enabled = False
                btnDel.Enabled = False
                btnCancel.Enabled = False
                txtClear()
                txtDisable()
                loadLvw()
                loadAddress()
                loadCivilStatus()
                loadProfession()
                loadReligion()
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

    Private Sub ucAddResidence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        butDisable()
        txtDisable()
        btnUpload.Enabled = False
        btnCapture.Enabled = False
        loadLvw()
        loadAddress()
        loadCivilStatus()
        loadProfession()
        loadReligion()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        txtEnable()
        btnUpload.Enabled = True
        btnCapture.Enabled = True
        txtName.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtClear()
        txtDisable()
        butDisable()
        btnAdd.Enabled = True
        grpNonV.Visible = False
        grpVoter.Visible = False
        btnUpload.Enabled = False
        btnCapture.Enabled = False
        txtVPrecint.Clear()
        txtGPrecint.Clear()
        txtGName.Clear()
        txtGRelation.Clear()

        loadAddress()
        loadCivilStatus()
        loadProfession()
        loadReligion()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            deleteResidence()
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        edit = 1
        btnEdit.Enabled = False
        btnDel.Enabled = False
        btnSave.Enabled = True
        btnUpload.Enabled = True
        btnCapture.Enabled = True
        txtEnable()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Trim(resType) = "" Or Trim(txtHousehold.Text) = "" Or Trim(txtName.Text) = "" Or Trim(cboStatus.Text) = "" Or Trim(sexType) = "" Or Trim(txtBdate.Text) = "" Or Trim(cboAddress.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        saveResidence()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        OpenFileDialog1.Filter = "Image Files(*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF|All Files(*.*)| *.* "
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            picImage.Image = Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub lvwResidence_Click(sender As Object, e As EventArgs) Handles lvwResidence.Click
        If lvwResidence.SelectedItems.Count > 0 Then
            Try
                resID = lvwResidence.Items(lvwResidence.SelectedIndices(0)).Text
                btnAdd.Enabled = False
                btnEdit.Enabled = True
                btnDel.Enabled = True
                btnCancel.Enabled = True
                displayResidence()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                DisposeConnection()
            End Try
        End If
    End Sub

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        If txtSearch.Text = "" Then
            loadLvw()
        Else
            search(txtSearch.Text)
        End If
    End Sub


    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress, txtHousehold.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz  "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtBirthplace_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBirthplace.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz  "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
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

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        Dim a = txtID.Text
        frmCapture.resID.Text = a
        frmCapture.ShowDialog()
    End Sub

    Private Sub btnprof_Click(sender As Object, e As EventArgs) Handles btnprof.Click
        Dim prof As New ucProfession
        toPanelMain(prof.Width, prof.Height, prof)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchresid = ""
        frmResidenceListV.ShowDialog()
        Dim isSelected As Boolean = False
        If isSelected Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Resident is already selected.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf searchresid <> "" Or isSelected = False Then
            Try
                DbConnect()
                Dim query As String = "SELECT res_id, res_name, res_precint FROM residence WHERE res_ID ='" & searchresid & "'"
                ExecuteQuery(query)
                If reader.HasRows Then
                    While reader.Read()
                        txtResID.Text = reader.GetString("res_id")
                        txtGName.Text = reader.GetString("res_name")
                        txtGPrecint.Text = reader.GetString("res_precint")
                    End While
                End If
                DbDisconnect()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                DisposeConnection()
            End Try
        End If
        DbDisconnect()
        searchresid = ""
    End Sub
End Class
