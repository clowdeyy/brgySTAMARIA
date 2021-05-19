Imports System.IO
Public Class ucAddHousehold
    Dim _orderDictionary As New Dictionary(Of String, List(Of String))
    Dim sex As String
    Dim voterType As String
    Dim houseType As String
    Dim resType As String
    Dim stayType As String
    Private street As String
    Private hhID As String
    Dim hh As String
    Dim edit As Integer
    Dim transdate = DateTime.Now.ToString("MM-dd-yyyy")

    Function ImageToBase64(ByVal image As Image, ByVal format As System.Drawing.Imaging.ImageFormat) As String
        Dim ms As New MemoryStream
        image.Save(ms, format)
        Dim imageByte() As Byte = ms.ToArray()
        Dim base64string As String = Convert.ToBase64String(imageByte)
        Return base64string
    End Function


    Private Sub ucAddHousehold_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
        btnCancel.Enabled = False
        txtDisable()

        loadHousehold()
        loadRAddress()
        loadRHType()
        loadHHID()
    End Sub


    Private Sub radM_CheckedChanged(sender As Object, e As EventArgs) Handles radM.CheckedChanged
        sex = radM.Text
    End Sub

    Private Sub radF_CheckedChanged(sender As Object, e As EventArgs) Handles radF.CheckedChanged
        sex = radF.Text
    End Sub

    Private Sub radPerma_CheckedChanged(sender As Object, e As EventArgs) Handles radPerma.CheckedChanged
        houseType = radPerma.Text
    End Sub

    Private Sub radTempo_CheckedChanged(sender As Object, e As EventArgs) Handles radTempo.CheckedChanged
        houseType = radTempo.Text
    End Sub

    Private Sub radNonVoter_CheckedChanged(sender As Object, e As EventArgs) Handles radNonVoter.CheckedChanged
        voterType = radNonVoter.Text
    End Sub

    Private Sub radVoter_CheckedChanged(sender As Object, e As EventArgs) Handles radVoter.CheckedChanged
        voterType = radVoter.Text
        If radVoter.Checked = True Then
            txtPrecint.Enabled = True
            txtPrecint.Visible = True
        Else
            txtPrecint.Enabled = False
            txtPrecint.Visible = False
            txtPrecint.Text = ""
        End If
    End Sub


    Private Sub radHead_CheckedChanged(sender As Object, e As EventArgs) Handles radHead.CheckedChanged
        resType = radHead.Text
    End Sub

    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        resType = radMember.Text
    End Sub

    Sub txtEnable()
        cboProf.Enabled = True
        btnprof.Enabled = True
        Button1.Enabled = True
        btnHHT.Enabled = True
        cboType.Enabled = True
        cboAddress.Enabled = True
        cboStatus.Enabled = True
        cboReligion.Enabled = True
        txtName.Enabled = True
        txtNationality.Enabled = True
        txtBdate.Enabled = True
        txtBirthplace.Enabled = True
        radM.Enabled = True
        radF.Enabled = True
        radTempo.Enabled = True
        radPerma.Enabled = True
        radNonVoter.Enabled = True
        radVoter.Enabled = True
        radHead.Enabled = True
        radMember.Enabled = True
    End Sub


    Sub txtClear()
        cboType.Items.Clear()
        cboAddress.Items.Clear()
        cboStatus.Items.Clear()
        cboReligion.Items.Clear()
        txtName.Clear()
        txtNationality.Clear()
        txtBdate.Text = ""
        txtBirthplace.Clear()
        txtCitID.Clear()
        radM.Checked = False
        radF.Checked = False
        radPerma.Checked = False
        radTempo.Checked = False
        radNonVoter.Checked = False
        radVoter.Checked = False
        radHead.Enabled = False
        radMember.Enabled = False
    End Sub

    Sub txtClearTransfer()
        txtName.Clear()
        txtBdate.Text = ""
        radM.Checked = False
        radF.Checked = False
        radNonVoter.Checked = False
        radVoter.Checked = False
        radHead.Checked = False
        radMember.Checked = False
        cboStatus.Items.Clear()
        cboProf.Items.Clear()
        txtBirthplace.Clear()
        txtPrecint.Text = ""

    End Sub

    Sub txtDisable()
        cboProf.Enabled = False
        btnprof.Enabled = False
        Button1.Enabled = False
        btnHHT.Enabled = False
        cboType.Enabled = False
        cboStatus.Enabled = False
        cboAddress.Enabled = False
        cboReligion.Enabled = False
        txtName.Enabled = False
        txtNationality.Enabled = False
        txtBdate.Enabled = False
        txtBirthplace.Enabled = False
        radM.Enabled = False
        radF.Enabled = False
        radPerma.Enabled = False
        radTempo.Enabled = False
        radNonVoter.Enabled = False
        radVoter.Enabled = False
        radHead.Checked = False
        radMember.Checked = False
        txtBirthplace.Enabled = False
        txtPrecint.Enabled = False
    End Sub

    Sub loadHHID()
        Try
            DbConnect()
            Dim query As String = "SELECT hh_id from household ORDER BY hh_id DESC LIMIT 1"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtHouseID.Text = "HHI" & Val(Mid(reader.GetString(0), 4, 8)) + 1
                End While
            Else
                txtHouseID.Text = "HHI20001"
            End If
            DbDisconnect()
        Catch ex As Exception
            MessageBox.Show("An error occured." & ex.Message)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub loadID()
        Try
            DbConnect()
            Dim query As String = "SELECT res_id from residence ORDER BY res_id DESC LIMIT 1"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtCitID.Text = reader.GetString(0) + 1
                End While
            Else
                txtCitID.Text = "1"
            End If
            DbDisconnect()
        Catch ex As Exception
            MessageBox.Show("An error occured." & ex.Message)
        Finally
            DisposeConnection()
        End Try
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

    Sub loadHType()
        DbConnect()
        Dim query As String = "SELECT hht_id, hht_name FROM householdtype ORDER BY hht_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboType.Items.Clear()
            While reader.Read
                cboType.Items.Add(reader.GetString(1))
            End While
        End If
        DbDisconnect()
    End Sub

    Sub loadReligion()
        cboReligion.Items.Add("Islam")
        cboReligion.Items.Add("RC")
        cboReligion.Items.Add("Alliance")
        cboReligion.Items.Add("Others")

    End Sub

    Sub Status()
        cboStatus.Items.Add("Single")
        cboStatus.Items.Add("Married")
        cboStatus.Items.Add("Divorced")
        cboStatus.Items.Add("Widowed")
        cboStatus.Items.Add("Separated")
    End Sub

    Sub loadProfession()
        DbConnect()
        Dim query As String = "SELECT prof_name FROM res_prof ORDER BY prof_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboProf.Items.Clear()
            While reader.Read
                cboProf.Items.Add(reader.GetString("prof_name"))
            End While
        End If
        DbDisconnect()
    End Sub

    Sub transferResident()
        Try
            Dim font As Font
            font = New Font("Century Gothic", 10, FontStyle.Regular)

            If _orderDictionary.ContainsKey(txtCitID.Text) Then
                MetroFramework.MetroMessageBox.Show(Me, " 
Data already exist. Please increment resident ID", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                _orderDictionary.Add(txtCitID.Text, New List(Of String))
                _orderDictionary(txtCitID.Text).Add(resType)
                _orderDictionary(txtCitID.Text).Add(txtName.Text)
                _orderDictionary(txtCitID.Text).Add(sex)
                _orderDictionary(txtCitID.Text).Add(txtNationality.Text)
                _orderDictionary(txtCitID.Text).Add(txtBdate.Text)
                _orderDictionary(txtCitID.Text).Add(cboReligion.Text)
                _orderDictionary(txtCitID.Text).Add(txtBirthplace.Text)
                _orderDictionary(txtCitID.Text).Add(voterType)
                _orderDictionary(txtCitID.Text).Add(txtPrecint.Text)
                _orderDictionary(txtCitID.Text).Add(cboStatus.Text)
                _orderDictionary(txtCitID.Text).Add(cboProf.Text)

                Dim res As New ListViewItem(txtCitID.Text)

                Dim rt As String = resType
                res.SubItems.Add(rt).Font = font

                Dim name As String = txtName.Text
                res.SubItems.Add(name).Font = font

                Dim sx As String = sex
                res.SubItems.Add(sx).Font = font

                Dim cit As String = txtNationality.Text
                res.SubItems.Add(cit).Font = font

                Dim bdate As String = txtBdate.Text
                res.SubItems.Add(bdate).Font = font

                Dim rel As String = cboReligion.Text
                res.SubItems.Add(rel).Font = font

                Dim bplace As String = txtBirthplace.Text
                res.SubItems.Add(bplace).Font = font

                Dim vt As String = voterType
                res.SubItems.Add(vt).Font = font
                If radVoter.Checked = True Then
                    Dim prec As String = txtPrecint.Text
                    res.SubItems.Add(prec).Font = font
                ElseIf radNonVoter.Checked = True Then
                    txtPrecint.Text = "None"
                    res.SubItems.Add(txtPrecint.Text).Font = font
                End If

                Dim status As String = cboStatus.Text
                res.SubItems.Add(status).Font = font

                Dim prof As String = cboProf.Text
                res.SubItems.Add(prof).Font = font

                btnSave.Enabled = True
                Dim cc As Boolean = False

                For x = 0 To lvwHousehold.Items.Count - 1
                    If lvwHousehold.Items(x).SubItems(1).Text = txtCitID.Text Then
                        cc = True
                    End If
                Next
                If cc <> True Or lvwHousehold.Items.Count = 0 Then
                    lvwHousehold.Items.Add(res).Font = font
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnTransfer.Enabled = True
        txtEnable()
        loadID()
        loadAddress()
        loadReligion()
        Status()
        loadProfession()
        loadHType()

    End Sub


    Sub saveHousehold()
        Try

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
            'Dim query As String = " INSERT INTO household SET hh_id = '" & txtHouseID.Text & "', hh_type = '" & cboType.Text & "', hh_staytype = '" & houseType & "', street_id = '" & street & "'"
            'ExecuteQuery(query)
            Dim query As String = " INSERT INTO household SET hh_id =@hhid, hh_type =@hhtype, hh_staytype =@hhstaytype, street_id =@street"
            ExecuteQueryParameter(query)
            command.Parameters.AddWithValue("@hhid", txtHouseID.Text)
            command.Parameters.AddWithValue("@hhtype", cboType.Text)
            command.Parameters.AddWithValue("@hhstaytype", houseType)
            command.Parameters.AddWithValue("@street", street)
            reader = command.ExecuteReader
            DbDisconnect()

            For Each resident As ListViewItem In lvwHousehold.Items
                Dim id = resident.Text
                Dim order = resident.SubItems(1).Text
                Dim name = resident.SubItems(2).Text.Replace("'", "`").ToString
                Dim sex = resident.SubItems(3).Text
                Dim citizen = resident.SubItems(4).Text
                Dim bdate = resident.SubItems(5).Text
                Dim religion = resident.SubItems(6).Text
                Dim bplace = resident.SubItems(7).Text.Replace("'", "`").ToString
                Dim restype = resident.SubItems(8).Text
                Dim prec1 = resident.SubItems(9).Text
                Dim stat = resident.SubItems(10).Text
                Dim prof = resident.SubItems(11).Text

                DbConnect()
                Dim query4 As String = " INSERT INTO residence SET res_id = '" & id & "', res_order = '" & order & "', res_name = '" & name & "', " _
                        & " res_sex = '" & sex & "', res_nationality = '" & citizen & "', res_bdate = '" & bdate & "', res_religion = '" & religion & "',  " _
                        & " res_bplace = '" & bplace & "', res_type = '" & restype & "', res_image = '" & ImageToBase64(picImage.Image, System.Drawing.Imaging.ImageFormat.Png) & "', res_precint = '" & prec1 & "', street_id = '" & street & "', hh_id = '" & txtHouseID.Text & "', res_status = '" & stat & "', res_profession = '" & prof & "', is_deceased='no'"
                ExecuteQuery(query4)
                'Dim query4 As String = " INSERT INTO residence SET res_id = @resid, res_order = @resorder, res_name = @resname, " _
                '        & " res_sex = @ressex, res_nationality =@resnatio, res_bdate = @resbdate, res_religion = @resreligion,  " _
                '        & " res_bplace = @resbplace, res_type = @restype, res_image = @resimage, res_precint = @precint, street_id = @street, hh_id = @hh, res_status = @status"
                'ExecuteQueryParameter(query4)
                'command.Parameters.AddWithValue("@resid", id)
                'command.Parameters.AddWithValue("@resorder", order)
                'command.Parameters.AddWithValue("@resname", name)
                'command.Parameters.AddWithValue("@ressex", sex)
                'command.Parameters.AddWithValue("@resnatio", citizen)
                'command.Parameters.AddWithValue("@resbdate", bdate)
                'command.Parameters.AddWithValue("@resreligion", religion)
                'command.Parameters.AddWithValue("@resbplace", bplace)
                'command.Parameters.AddWithValue("@restype", restype)
                'command.Parameters.AddWithValue("@resimage", ImageToBase64(picImage.Image, System.Drawing.Imaging.ImageFormat.Png))
                'command.Parameters.AddWithValue("@precint", prec1)
                'command.Parameters.AddWithValue("@street", street)
                'command.Parameters.AddWithValue("@hh.Text", txtHouseID.Text)
                'command.Parameters.AddWithValue("@status", stat)
                'reader = command.ExecuteReader
                DbDisconnect()


                DbConnect()
                Dim query2 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= '" & frmDashboard.txtID.Text & "'), ul_action = 'Added a new household with id: " & txtHouseID.Text & "', ul_date = '" & transdate & "'"
                ExecuteQuery(query2)
                DbDisconnect()

            Next
            MetroFramework.MetroMessageBox.Show(Me, " 
Household successfully saved.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            loadID()
            lvwHousehold.Items.Clear()
            txtClear()
            txtClearTransfer()
            txtDisable()
            btnSave.Enabled = False
            btnCancel.Enabled = False
            btnAdd.Enabled = True
            btnTransfer.Enabled = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Trim(txtHouseID.Text) = "" Or Trim(cboAddress.Text) = "" Or Trim(cboType.Text) = "" Or Trim(houseType) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out necessary fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        saveHousehold()
        loadHousehold()
        _orderDictionary.Clear()
        loadHHID()

        For Each ctrl As Control In Controls
            If TypeOf ctrl Is Label Then
            Else
                ctrl.ResetText()
            End If
        Next
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        If Trim(txtName.Text) = "" Or Trim(cboReligion.Text) = "" Or Trim(txtBdate.Text) = "" Or Trim(txtNationality.Text) = "" Or Trim(txtBirthplace.Text) = "" Or Trim(sex) = "" Or Trim(voterType) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            transferResident()
            For x = 0 To lvwHousehold.Items.Count - 1
                If lvwHousehold.Items(x).SubItems(1).Text = "Head" Then
                    radHead.Enabled = False
                End If
            Next
            If cboType.Text = "Lone Person" Then
                radNonVoter.Enabled = False
                radVoter.Enabled = False
                radM.Enabled = False
                radF.Enabled = False
                txtName.Enabled = False
                txtNationality.Enabled = False
                txtBdate.Enabled = False
                txtBirthplace.Enabled = False
                cboStatus.Enabled = False
                btnTransfer.Enabled = False
            End If
            txtClearTransfer()
            txtCitID.Text = (txtCitID.Text + 1).ToString
            txtPrecint.Visible = False
            Status()
            loadProfession()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnTransfer.Enabled = False
        txtDisable()
        txtClear()
    End Sub

    '============================================================================= Tab2

    Sub loadHousehold()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwRHH.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT household.hh_id, hh_type, hh_staytype, res_name, res_order, street_name, is_deceased FROM residence,household,streets WHERE household.street_id = streets.street_ID AND residence.hh_id = household.hh_id AND res_order = 'Head' ORDER by hh_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    If reader.GetString("is_deceased") = "yes" Then
                        lvwRHH.Items.Add(reader.GetString("hh_ID"))
                        lvwRHH.Items(i).Font = font
                        lvwRHH.Items(i).Font = New Font(lvwRHH.Items(i).Font, lvwRHH.Items(i).Font.Style Or FontStyle.Strikeout)
                        lvwRHH.Items(i).ForeColor = Color.Maroon
                        lvwRHH.Items(i).SubItems.Add(reader.GetString("hh_type"))
                        lvwRHH.Items(i).SubItems.Add(reader.GetString("res_name"))
                    Else
                        lvwRHH.Items.Add(reader.GetString("hh_ID"))
                        lvwRHH.Items(i).Font = font
                        lvwRHH.Items(i).SubItems.Add(reader.GetString("hh_type"))
                        lvwRHH.Items(i).SubItems.Add(reader.GetString("res_name"))
                    End If
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

    Sub loadMembers()
        lvwRHM.Items.Clear()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        Try
            DbConnect()
            Dim query As String = " SELECT res_id, res_name, res_order, res_sex, res_bdate, street_name, is_deceased FROM residence,streets " _
                                    & " WHERE hh_id = '" & hh & "' AND streets.street_id = residence.street_ID"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    If reader.GetString("is_deceased") = "yes" Then
                        lvwRHM.Items.Add(reader.GetString("res_id"))
                        lvwRHM.Items(i).Font = font
                        lvwRHM.Items(i).Font = New Font(lvwRHM.Items(i).Font, lvwRHM.Items(i).Font.Style Or FontStyle.Strikeout)
                        lvwRHM.Items(i).ForeColor = Color.Maroon
                        lvwRHM.Items(i).SubItems.Add(reader.GetString("res_name"))
                        lvwRHM.Items(i).SubItems.Add(reader.GetString("res_order"))
                        lvwRHM.Items(i).SubItems.Add(reader.GetString("res_sex"))
                        lvwRHM.Items(i).SubItems.Add(reader.GetString("res_bdate"))
                    Else
                        lvwRHM.Items.Add(reader.GetString("res_id"))
                        lvwRHM.Items(i).Font = font
                        lvwRHM.Items(i).SubItems.Add(reader.GetString("res_name"))
                        lvwRHM.Items(i).SubItems.Add(reader.GetString("res_order"))
                        lvwRHM.Items(i).SubItems.Add(reader.GetString("res_sex"))
                        lvwRHM.Items(i).SubItems.Add(reader.GetString("res_bdate"))
                    End If
                    i += 1
                End While
            End If
            DbDisconnect()


            cboHead.Items.Clear()
            DbConnect()
            Dim query4 = "SELECT res_name FROM residence WHERE hh_id=@resid "
            ExecuteQueryParameter(query4)
            command.Parameters.AddWithValue("@bname", cboHead)
            command.Parameters.AddWithValue("@resid", hh)
            reader = command.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    cboHead.Items.Add(reader.GetString("res_name"))
                End While
            End If
            DbDisconnect()

            DbConnect()
            query = "SELECT household.hh_id, hh_type, hh_staytype, street_name, res_name, res_order FROM residence, household, streets WHERE household.hh_id = '" & hh & "' AND household.street_id = streets.street_ID AND residence.hh_id = household.hh_id AND res_order ='Head'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    grpDetails.Text = "Household No: " + reader.GetString("hh_id")
                    cboRType.Text = reader.GetString("hh_type")
                    cboHead.Text = reader.GetString("res_name")
                    cboRAddress.Text = reader.GetString("street_name")
                    If radP.Text = reader.GetString("hh_staytype") Then
                        radP.Select()
                    ElseIf radT.Text = reader.GetString("hh_staytype") Then
                        radT.Select()
                    End If

                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub radP_CheckedChanged(sender As Object, e As EventArgs) Handles radP.CheckedChanged
        stayType = radP.Text
    End Sub

    Private Sub radT_CheckedChanged(sender As Object, e As EventArgs) Handles radT.CheckedChanged
        stayType = radT.Text
    End Sub

    Private Sub lvwRHH_Click(sender As Object, e As EventArgs) Handles lvwRHH.Click
        If lvwRHH.SelectedItems.Count > 0 Then
            Try
                hh = lvwRHH.Items(lvwRHH.SelectedIndices(0)).Text
                loadMembers()
                btnRemove.Enabled = True
                btnUpdate.Enabled = True
                btnRCancel.Enabled = True
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                DisposeConnection()
            End Try
        End If
    End Sub

    Sub loadRAddress()
        DbConnect()
        Dim query As String = "SELECT street_id, street_name FROM streets ORDER BY street_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboAddress.Items.Clear()
            While reader.Read
                cboRAddress.Items.Add(reader.GetString(1))
            End While
        End If
        DbDisconnect()
    End Sub

    Sub loadRHType()
        DbConnect()
        Dim query As String = "SELECT hht_id, hht_name FROM householdtype ORDER BY hht_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboRType.Items.Clear()
            While reader.Read
                cboRType.Items.Add(reader.GetString(1))
            End While
        End If
        DbDisconnect()
    End Sub

    Sub txtREnable()
        cboRAddress.Enabled = True
        cboHead.Enabled = True
        cboRType.Enabled = True
        radT.Enabled = True
        radP.Enabled = True
    End Sub

    Sub txtRDisable()
        cboRAddress.Enabled = False
        cboHead.Enabled = False
        cboRType.Enabled = False
        radT.Enabled = False
        radP.Enabled = False
    End Sub

    Sub txtRClear()
        cboHead.Items.Clear()
        cboRAddress.Items.Clear()
        grpDetails.Text = ""
        cboRType.Items.Clear()
        radP.Checked = False
        radT.Checked = False
    End Sub

    Sub btnDisable()
        btnRCancel.Enabled = False
        btnRemove.Enabled = False
        btnUpdate.Enabled = False
        btnSavee.Enabled = False
    End Sub

    Sub save()
        Try
            If edit = 1 Then
                DbConnect()
                Dim query3 As String = "SELECT street_id FROM streets WHERE street_name = '" & cboRAddress.Text & "'"
                ExecuteQuery(query3)
                If reader.HasRows Then
                    While reader.Read
                        street = reader.GetString(0)
                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim query As String = "UPDATE household SET hh_type = '" & cboRType.Text & "', hh_staytype = '" & stayType & "', street_ID = '" & street & "' WHERE hh_id = '" & hh & "'"
                ExecuteQuery(query)
                DbDisconnect()

                DbConnect()
                Dim query1 As String = " UPDATE residence SET street_ID = '" & street & "' WHERE hh_id = '" & hh & "'"
                ExecuteQuery(query1)
                DbDisconnect()

                DbConnect()
                Dim query2 As String = " UPDATE residence SET res_order = 'Member' WHERE hh_id = '" & hh & "'"
                ExecuteQuery(query2)
                DbDisconnect()

                DbConnect()
                Dim qry As String = " UPDATE residence SET res_order = 'Head' WHERE res_name = '" & cboHead.Text & "' AND hh_id = '" & hh & "' "
                ExecuteQuery(qry)
                DbDisconnect()

                DbConnect()
                Dim query4 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= '" & frmDashboard.txtID.Text & "'), ul_action = 'Updated household information with id: " & hh & "', ul_date = '" & transdate & "'"
                ExecuteQuery(query4)
                DbDisconnect()
                MetroFramework.MetroMessageBox.Show(Me, " 
Household successfully updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                loadHousehold()
                lvwRHM.Items.Clear()
                txtRClear()
                txtRDisable()
                btnDisable()
                loadRAddress()
                loadRHType()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub remove()
        Try
            If MetroFramework.MetroMessageBox.Show(Me, " 
By deleting household, resident information registered on selected household will also be deleted. Continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = vbYes Then
                DbConnect()
                Dim query As String = " DELETE FROM household WHERE hh_ID ='" & hh & "'"
                ExecuteQuery(query)
                DbDisconnect()

                DbConnect()
                Dim query1 As String = " DELETE FROM residence WHERE hh_ID ='" & hh & "'"
                ExecuteQuery(query1)

                MetroFramework.MetroMessageBox.Show(Me, " 
Selected household successfully removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                DbDisconnect()

            ElseIf vbNo Then
                txtRClear()
                lvwRHM.Items.Clear()
                Exit Sub
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        edit = 1
        txtREnable()
        btnCancel.Enabled = True
        btnRemove.Enabled = False
        btnUpdate.Enabled = False
        btnSavee.Enabled = True
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            remove()
            btnDisable()
            txtRClear()
            txtRDisable()
            lvwRHM.Items.Clear()
            loadHousehold()
            loadRAddress()
            loadRHType()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnSavee_Click(sender As Object, e As EventArgs) Handles btnSavee.Click
        If Trim(stayType) = "" Or Trim(cboRAddress.Text) = "" Or Trim(cboRType.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out necessary fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        save()
    End Sub

    Private Sub btnRCancel_Click(sender As Object, e As EventArgs) Handles btnRCancel.Click
        btnDisable()
        txtRDisable()
        txtRClear()
        lvwRHM.Items.Clear()

        loadRAddress()
        loadRHType()

    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        If cboType.Text = "Lone Person" Then
            radMember.Enabled = False
        Else
            radMember.Enabled = True
        End If
    End Sub

    Private Sub RemoveSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSelectedToolStripMenuItem.Click
        Try
            If lvwHousehold.SelectedItems(0).SubItems(1).Text = "Head" Then
                radHead.Enabled = True
                txtEnable()
                btnTransfer.Enabled = True
                lvwHousehold.SelectedItems(0).Remove()
            ElseIf lvwHousehold.SelectedItems(0).SubItems(1).Text = "Member" Then
                lvwHousehold.SelectedItems(0).Remove()
            Else
                radHead.Enabled = False
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "
No data in the fieldlist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub


    Private Sub lvwHousehold_MouseUp(sender As Object, e As MouseEventArgs) Handles lvwHousehold.MouseUp
        Try
            If e.Button = MouseButtons.Right Then
                ContextMenuStrip1.Show(lvwHousehold, e.Location)
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        If txtSearch.Text = "" Then
            loadHousehold()
        Else
            search(txtSearch.Text)
        End If
    End Sub

    Sub search(keyword As String)
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwRHH.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT household.hh_id, hh_type, hh_staytype, res_name, res_order, street_name FROM residence,household,streets WHERE household.street_id = streets.street_ID AND residence.hh_id = household.hh_id AND res_order = 'Head' " _
                                 & "AND res_name LIKE '" & keyword & "%'"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwRHH.Items.Add(reader.GetString("hh_ID"))
                    lvwRHH.Items(i).Font = font
                    lvwRHH.Items(i).SubItems.Add(reader.GetString("hh_type"))
                    lvwRHH.Items(i).SubItems.Add(reader.GetString("res_name"))
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


    Private Sub txtBirthplace_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBirthplace.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz  "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim zone As New ucAddZones
        toPanelMain(zone.Width, zone.Height, zone)
    End Sub

    Private Sub btnprof_Click(sender As Object, e As EventArgs) Handles btnprof.Click
        Dim prof As New ucProfession
        toPanelMain(prof.Width, prof.Height, prof)
    End Sub

    Private Sub btnHHT_Click(sender As Object, e As EventArgs) Handles btnHHT.Click
        Dim hht As New ucHouseholdType
        toPanelMain(hht.Width, hht.Height, hht)
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
End Class
