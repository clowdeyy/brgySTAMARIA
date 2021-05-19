Imports System.IO
Imports MySql.Data.MySqlClient
Public Class ucResidence
    Private kon As New MySqlConnection("server = '" & frmLogin.txtIP.Text & "'; username = 'root'; password = ''; database='dbstamaria'")
    Dim resID As String

    Private Sub ucResidence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadResidence()
        loadResidenceTwo()
        loadPermanentResidence()
        loadTemporaryResidence()
        loadSolvedCases()
        loadStreet()
        loadDeceased()
    End Sub

    '=================== Tab 1
    Sub loadResidence()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwResidence.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT res_id, res_name, res_type, res_sex, res_status, street_name FROM residence, streets WHERE streets.street_id = residence.street_id AND is_deceased = 'no' ORDER by res_name"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwResidence.Items.Add(reader.GetString("res_id"))
                    lvwResidence.Items(i).Font = font
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_name"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("street_name"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_type"))
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

    Sub displayResidence()
        Try
            DbConnect()
            Dim query As String = " SELECT hh_type, street_name, res_id, res_religion, res_status, res_name, res_bdate, res_profession, res_nationality, res_stay, res_bplace, res_nationality, res_precint, res_type, res_sex, res_image " _
                                   & "FROM residence INNER JOIN streets ON streets.street_id = residence.street_id INNER JOIN household ON household.hh_id = residence.hh_id WHERE res_id = '" & resID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    ID.Text = reader.GetString("res_id")
                    txtName.Text = reader.GetString("res_name")
                    txtPrecint.Text = reader.GetString("res_precint")
                    txtResident.Text = reader.GetString("res_type")
                    txtHousehold.Text = reader.GetString("hh_type")
                    txtCivil.Text = reader.GetString("res_status")
                    txtSex.Text = reader.GetString("res_sex")
                    txtNationality.Text = reader.GetString("res_nationality")
                    txtReligion.Text = reader.GetString("res_religion")
                    txtAddress.Text = reader.GetString("street_name")
                    txtBirthplace.Text = reader.GetString("res_bplace")
                    txtBirthday.Text = reader.GetString("res_bdate")
                    picImage.Image = Base64ToImage(reader.GetString("res_image"))

                    Dim columnProfession = reader.GetOrdinal("res_profession")
                    Dim prof As String = Nothing
                    If Not reader.IsDBNull(columnProfession) Then
                        prof = reader.GetString("res_profession").ToString
                        txtProf.Text = prof
                    Else
                        txtProf.Text = ""
                    End If

                    Dim columnStay = reader.GetOrdinal("res_stay")
                    Dim sty As String = Nothing
                    If Not reader.IsDBNull(columnStay) Then
                        sty = reader.GetString("res_stay").ToString
                        txtNumber.Text = sty
                    Else
                        txtNumber.Text = ""
                    End If

                    txtName.Visible = True
                    tx.Visible = True
                    txtPrecint.Visible = True
                    txtResident.Visible = True
                    txtHousehold.Visible = True
                    txtCivil.Visible = True
                    txtSex.Visible = True
                    txtSex.Visible = True
                    txtNationality.Visible = True
                    txtReligion.Visible = True
                    txtAddress.Visible = True
                    txtBirthplace.Visible = True
                    txtNumber.Visible = True
                    txtProf.Visible = True
                    txtBday.Visible = True
                    txtBirthday.Visible = True
                    txtR.Visible = True
                    txtH.Visible = True
                    txtS.Visible = True
                    txtC.Visible = True
                    txtN.Visible = True
                    txtRe.Visible = True
                    txtA.Visible = True
                    txtAd.Visible = True
                    txtB.Visible = True
                    txtBday.Visible = True
                    txtNo.Visible = True
                    txtP.Visible = True
                    picImage.Visible = True
                    btnMark.Visible = False
                End While
            End If
            DbDisconnect()

            DbConnect()
            Dim query1 As String = "SELECT bl_active FROM blacklists INNER JOIN residence ON blacklists.res_id = residence.res_id WHERE bl_active = 'yes' AND blacklists.res_id = '" & resID & "'"
            ExecuteQuery(query1)
            If reader.HasRows Then
                While reader.Read
                    Dim a As String = reader.GetString("bl_active")
                    If a = "yes" Then
                        btnMark.Visible = True
                    Else
                        btnMark.Visible = False
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

    Private Sub lvwResidence_Click(sender As Object, e As EventArgs) Handles lvwResidence.Click
        If lvwResidence.SelectedItems.Count > 0 Then
            resID = lvwResidence.Items(lvwResidence.SelectedIndices(0)).Text
            displayResidence()
            btnDeceased.Visible = True
        Else
            btnDeceased.Visible = False
        End If
    End Sub

    Sub search(keyword As String)
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwResidence.Items.Clear()
        Try
            DbConnect()
            Dim query As String = " SELECT res_id, res_name, res_type, res_sex, res_status, street_name FROM residence, streets WHERE residence.street_id = streets.street_id AND is_deceased = 'no' AND res_name LIKE '" & keyword & "%'"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwResidence.Items.Add(reader.GetString("res_id"))
                    lvwResidence.Items(i).Font = Font
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_name"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("street_name"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_type"))
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
            search(txtSearch.Text)
        End If
    End Sub

    '=================== Tab 2
    Sub loadResidenceTwo()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwResidence2.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT residence.res_id, res_name,res_type,res_precint,hh_type,res_status,res_sex,street_name,res_religion,res_bdate,res_bplace,res_profession FROM residence, streets, household WHERE streets.street_id = residence.street_id AND household.hh_id = residence.hh_id AND is_deceased = 'no' ORDER by res_name"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwResidence2.Items.Add(reader.GetString("res_id"))
                    lvwResidence2.Items(i).Font = Font
                    lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_name"))
                    lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_type"))
                    lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_precint"))
                    lvwResidence2.Items(i).SubItems.Add(reader.GetString("hh_type"))
                    lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_status"))
                    lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_sex"))
                    lvwResidence2.Items(i).SubItems.Add(reader.GetString("street_name"))
                    lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_religion"))
                    lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_bdate"))
                    lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_bplace"))
                    Dim columnProfession = reader.GetOrdinal("res_profession")
                    Dim prof As String = Nothing
                    If Not reader.IsDBNull(columnProfession) Then
                        prof = reader.GetString("res_profession")
                        lvwResidence2.Items(i).SubItems.Add(prof)
                    Else
                        Dim none As String = "NONE"
                        lvwResidence2.Items(i).SubItems.Add(none)
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

    Sub loadResidentType()
        cboDisplay.Items.Clear()
        cboDisplay.Items.Add("Voter")
        cboDisplay.Items.Add("Non-Voter")
    End Sub

    Sub loadHouseholdType()
        cboDisplay.Items.Clear()
        cboDisplay.Items.Add("Couple w/ children")
        cboDisplay.Items.Add("Couple w/o children")
        cboDisplay.Items.Add("One-parent family")
        cboDisplay.Items.Add("Other family")
        cboDisplay.Items.Add("Lone Person")
        cboDisplay.Items.Add("Other non-classified")
    End Sub

    Sub loadCivilStatus()
        cboDisplay.Items.Clear()
        cboDisplay.Items.Add("Single")
        cboDisplay.Items.Add("Married")
        cboDisplay.Items.Add("Widowed")
        cboDisplay.Items.Add("Annuled")
        cboDisplay.Items.Add("Divorced")
    End Sub

    Sub loadGender()
        cboDisplay.Items.Clear()
        cboDisplay.Items.Add("Male")
        cboDisplay.Items.Add("Female")
    End Sub

    Sub loadStreet()
        DbConnect()
        Dim query As String = "SELECT street_name FROM streets ORDER BY street_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboDisplay.Items.Clear()
            While reader.Read
                cboAddress.Items.Add(reader.GetString("street_name"))
            End While
        End If
        DbDisconnect()
    End Sub

    Sub loadProfession()
        DbConnect()
        Dim query As String = "SELECT prof_name FROM res_prof ORDER BY prof_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboDisplay.Items.Clear()
            While reader.Read
                cboDisplay.Items.Add(reader.GetString("prof_name"))
            End While
        End If
        DbDisconnect()
    End Sub

    Private Sub cboSort_TextChanged(sender As Object, e As EventArgs) Handles cboSort.TextChanged
        Try
            If cboSort.Text = "Resident Type" Then
                loadResidentType()
            ElseIf cboSort.Text = "Civil Status" Then
                loadCivilStatus()
            ElseIf cboSort.Text = "Gender" Then
                loadGender()
            ElseIf cboSort.Text = "Household Type" Then
                loadHouseholdType()
            ElseIf cboSort.Text = "Profession" Then
                loadProfession()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub sort(keyword As String)
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwResidence2.Items.Clear()
        Try
            If cboSort.Text = "Civil Status" Then
                DbConnect()
                Dim query As String = " SELECT * FROM residence INNER JOIN streets ON streets.street_id = residence.street_ID INNER JOIN household ON household.hh_id = residence.hh_id  WHERE res_status = '" & cboDisplay.Text & "' AND is_deceased = 'no' " _
                                     & " AND street_name = '" & cboAddress.Text & "'  ORDER by res_name"
                ExecuteQuery(query)
                Dim i As Integer = 0
                If reader.HasRows Then
                    While reader.Read
                        lvwResidence2.Items.Add(reader.GetString("res_id"))
                        lvwResidence2.Items(i).Font = Font
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_name"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_type"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_precint"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("hh_type"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_status"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_sex"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("street_name"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_religion"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_bdate"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_bplace"))
                        Dim columnProfession = reader.GetOrdinal("res_profession")
                        Dim prof As String = Nothing
                        If Not reader.IsDBNull(columnProfession) Then
                            prof = reader.GetString("res_profession")
                            lvwResidence2.Items(i).SubItems.Add(prof)
                        Else
                            Dim none As String = "NONE"
                            lvwResidence2.Items(i).SubItems.Add(none)
                        End If
                        i += 1
                    End While
                End If
                DbDisconnect()
            ElseIf cboSort.Text = "Resident Type" Then
                DbConnect()
                Dim query As String = " SELECT * FROM residence INNER JOIN streets ON streets.street_id = residence.street_ID INNER JOIN household ON household.hh_id = residence.hh_id  WHERE res_type = '" & cboDisplay.Text & "' AND is_deceased = 'no'" _
                                     & " AND street_name = '" & cboAddress.Text & "'  ORDER by res_name"
                ExecuteQuery(query)
                Dim i As Integer = 0
                If reader.HasRows Then
                    While reader.Read
                        lvwResidence2.Items.Add(reader.GetString("res_id"))
                        lvwResidence2.Items(i).Font = Font
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_name"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_type"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_precint"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("hh_type"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_status"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_sex"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("street_name"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_religion"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_bdate"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_bplace"))
                        Dim columnProfession = reader.GetOrdinal("res_profession")
                        Dim prof As String = Nothing
                        If Not reader.IsDBNull(columnProfession) Then
                            prof = reader.GetString("res_profession")
                            lvwResidence2.Items(i).SubItems.Add(prof)
                        Else
                            Dim none As String = "NONE"
                            lvwResidence2.Items(i).SubItems.Add(none)
                        End If
                        i += 1
                    End While
                End If
                DbDisconnect()
            ElseIf cboSort.Text = "Household Type" Then
                DbConnect()
                Dim query As String = " SELECT * FROM residence INNER JOIN streets ON streets.street_id = residence.street_ID INNER JOIN household ON household.hh_id = residence.hh_id  WHERE hh_type = '" & cboDisplay.Text & "'AND is_deceased = 'no'" _
                                     & " AND street_name = '" & cboAddress.Text & "'  ORDER by res_name"
                ExecuteQuery(query)
                Dim i As Integer = 0
                If reader.HasRows Then
                    While reader.Read
                        lvwResidence2.Items.Add(reader.GetString("res_id"))
                        lvwResidence2.Items(i).Font = Font
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_name"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_type"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_precint"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("hh_type"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_status"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_sex"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("street_name"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_religion"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_bdate"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_bplace"))
                        Dim columnProfession = reader.GetOrdinal("res_profession")
                        Dim prof As String = Nothing
                        If Not reader.IsDBNull(columnProfession) Then
                            prof = reader.GetString("res_profession")
                            lvwResidence2.Items(i).SubItems.Add(prof)
                        Else
                            Dim none As String = "NONE"
                            lvwResidence2.Items(i).SubItems.Add(none)
                        End If
                        i += 1
                    End While
                End If
                DbDisconnect()
            ElseIf cboSort.Text = "Gender" Then
                DbConnect()
                Dim query As String = " SELECT * FROM residence INNER JOIN streets ON streets.street_id = residence.street_ID INNER JOIN household ON household.hh_id = residence.hh_id  WHERE res_sex = '" & cboDisplay.Text & "' AND is_deceased = 'no'" _
                                     & " AND street_name = '" & cboAddress.Text & "'  ORDER by res_name"
                ExecuteQuery(query)
                Dim i As Integer = 0
                If reader.HasRows Then
                    While reader.Read
                        lvwResidence2.Items.Add(reader.GetString("res_id"))
                        lvwResidence2.Items(i).Font = Font
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_name"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_type"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_precint"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("hh_type"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_status"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_sex"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("street_name"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_religion"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_bdate"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_bplace"))
                        Dim columnProfession = reader.GetOrdinal("res_profession")
                        Dim prof As String = Nothing
                        If Not reader.IsDBNull(columnProfession) Then
                            prof = reader.GetString("res_profession")
                            lvwResidence2.Items(i).SubItems.Add(prof)
                        Else
                            Dim none As String = "NONE"
                            lvwResidence2.Items(i).SubItems.Add(none)
                        End If
                        i += 1
                    End While
                End If
                DbDisconnect()

            ElseIf cboSort.Text = "Profession" Then
                DbConnect()
                Dim query As String = " SELECT * FROM residence INNER JOIN streets ON streets.street_id = residence.street_ID INNER JOIN household ON household.hh_id = residence.hh_id  WHERE res_profession = '" & cboDisplay.Text & "' AND is_deceased = 'no'" _
                                     & " AND street_name = '" & cboAddress.Text & "'  ORDER by res_name"
                ExecuteQuery(query)
                Dim i As Integer = 0
                If reader.HasRows Then
                    While reader.Read
                        lvwResidence2.Items.Add(reader.GetString("res_id"))
                        lvwResidence2.Items(i).Font = Font
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_name"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_type"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_precint"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("hh_type"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_status"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_sex"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("street_name"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_religion"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_bdate"))
                        lvwResidence2.Items(i).SubItems.Add(reader.GetString("res_bplace"))
                        Dim columnProfession = reader.GetOrdinal("res_profession")
                        Dim prof As String = Nothing
                        If Not reader.IsDBNull(columnProfession) Then
                            prof = reader.GetString("res_profession")
                            lvwResidence2.Items(i).SubItems.Add(prof)
                        Else
                            Dim none As String = "NONE"
                            lvwResidence2.Items(i).SubItems.Add(none)
                        End If
                        i += 1
                    End While
                End If
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub cboDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDisplay.SelectedIndexChanged
        If cboDisplay.Text = "" Then
            loadResidenceTwo()
        Else
            sort(cboDisplay.Text)
        End If
    End Sub


    '=================== Tab 3
    'Permanent
    Sub loadPermanentResidence()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwPermanent.Items.Clear()
        Try
            DbConnect()
            ' Dim query As String = "SELECT bl_id,res_sex, res_name,street_name, bl_type, bl_desc FROM blacklists, streets, residence WHERE residence.res_id = blacklists.res_id AND streets.street_id=residence.street_id AND bl_type='Permanent' ORDER by bl_id DESC"
            Dim query As String = "SELECT bl_id, res_name, res_sex, bl_active, bl_remarks,bc_name, bc_type, street_name FROM blacklists, blacklistcriteria, streets, residence  WHERE residence.res_id = blacklists.res_id AND blacklistcriteria.bc_id = blacklists.bc_id  AND streets.street_id=residence.street_id AND bc_type='Permanent' ORDER by bl_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwPermanent.Items.Add(reader.GetString("bl_id"))
                    lvwPermanent.Items(i).Font = Font
                    lvwPermanent.Items(i).SubItems.Add(reader.GetString("res_name"))
                    lvwPermanent.Items(i).SubItems.Add(reader.GetString("res_sex"))
                    lvwPermanent.Items(i).SubItems.Add(reader.GetString("street_name"))
                    lvwPermanent.Items(i).SubItems.Add(reader.GetString("bc_name"))
                    lvwPermanent.Items(i).SubItems.Add(reader.GetString("bl_remarks"))
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

    'Temporary
    Sub loadTemporaryResidence()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwTemporary.Items.Clear()
        Try
            DbConnect()
            ' Dim query As String = "SELECT bl_id,res_sex, street_name,bl_active, res_name, bl_type, bl_desc FROM blacklists, streets, residence WHERE residence.res_id = blacklists.res_id AND streets.street_id=residence.street_id AND bl_type='Temporary' and bl_active='yes' ORDER by bl_id DESC"
            Dim query As String = "SELECT bl_id, res_name, res_sex, bl_active, bl_remarks,bc_name, bc_type, street_name FROM blacklists, blacklistcriteria, streets, residence  WHERE residence.res_id = blacklists.res_id AND  blacklistcriteria.bc_id = blacklists.bc_id  AND streets.street_id=residence.street_id AND  bc_type='Temporary' and bl_active='yes' ORDER by bl_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwTemporary.Items.Add(reader.GetString("bl_id"))
                    lvwTemporary.Items(i).Font = Font
                    lvwTemporary.Items(i).SubItems.Add(reader.GetString("res_name"))
                    lvwTemporary.Items(i).SubItems.Add(reader.GetString("res_sex"))
                    lvwTemporary.Items(i).SubItems.Add(reader.GetString("street_name"))
                    lvwTemporary.Items(i).SubItems.Add(reader.GetString("bc_name"))
                    lvwTemporary.Items(i).SubItems.Add(reader.GetString("bl_remarks"))
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

    Sub loadSolvedCases()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwSolved.Items.Clear()
        Try
            DbConnect()
            ' Dim query As String = "SELECT bl_id, bl_active, res_sex, street_name, res_name, solved_date, solved_by, bl_type, bl_desc FROM blacklists, streets, residence WHERE residence.res_id = blacklists.res_id AND streets.street_id=residence.street_id AND bl_type='Temporary' and bl_active='no' ORDER by bl_id DESC"
            Dim query As String = "SELECT bl_id, res_name, res_sex, bl_active, bl_remarks,bc_name, bc_desc, bc_type, street_name, solved_date, solved_by FROM blacklists, blacklistcriteria, streets, residence  WHERE residence.res_id = blacklists.res_id AND blacklistcriteria.bc_id = blacklists.bc_id  AND streets.street_id=residence.street_id AND bc_type='Temporary' and bl_active='no' ORDER by bl_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwSolved.Items.Add(reader.GetString("bl_id"))
                    lvwSolved.Items(i).Font = Font
                    lvwSolved.Items(i).SubItems.Add(reader.GetString("res_name"))
                    lvwSolved.Items(i).SubItems.Add(reader.GetString("res_sex"))
                    lvwSolved.Items(i).SubItems.Add(reader.GetString("street_name"))
                    lvwSolved.Items(i).SubItems.Add(reader.GetString("bc_desc"))
                    lvwSolved.Items(i).SubItems.Add(reader.GetString("solved_date"))
                    lvwSolved.Items(i).SubItems.Add(reader.GetString("solved_by"))

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
            searchboid = lvwResidence.Items(lvwResidence.SelectedIndices(0)).Text
            lvwResidence.SelectedIndices.Clear()
        End If

        Dim rt As New ucResTransaction
        toPanelMain(rt.Width, rt.Height, rt)
    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        cboDisplay.Enabled = False
        cboSort.Enabled = False
        cboSort.Items.Clear()
        cboDisplay.Items.Clear()
        lvwResidence2.Items.Clear()
        loadResidenceTwo()
        cboAddress.Items.Clear()
        loadStreet()
        cboSort.Items.Add("Resident Type")
        cboSort.Items.Add("Household Type")
        cboSort.Items.Add("Civil Status")
        cboSort.Items.Add("Resident Type")
        cboSort.Items.Add("Gender")
        cboSort.Items.Add("Profession")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim cmd As MySqlCommand
            Dim adp As New MySqlDataAdapter
            Dim dt As New DataSet
            Dim sql As String

            If cboSort.Text = "Civil Status" Then
                kon.Open()
                sql = " SELECT * FROM residence INNER JOIN streets ON streets.street_id = residence.street_ID INNER JOIN household ON household.hh_id = residence.hh_id  WHERE res_status = '" & cboDisplay.Text & "'" _
                                     & " AND street_name = '" & cboAddress.Text & "'  ORDER by res_name"
                cmd = New MySqlCommand(sql, kon)
                adp.SelectCommand = cmd
                adp.Fill(dt, "residencelist")

                Dim report As New crResidentlist
                Dim txtobj As CrystalDecisions.CrystalReports.Engine.TextObject
                txtobj = report.Section1.ReportObjects.Item("Text15")
                txtobj.Text = cboAddress.Text.ToUpper
                txtobj = report.Section1.ReportObjects.Item("Text16")
                txtobj.Text = cboDisplay.Text.ToUpper
                report.SetDataSource(dt)
                frmReport.CrystalReportViewer1.ReportSource = report
                frmReport.CrystalReportViewer1.Refresh()
                cmd.Dispose()
                adp.Dispose()
                dt.Dispose()
                kon.Close()
                frmReport.ShowDialog()

            ElseIf cboSort.Text = "Resident Type" Then
                kon.Open()
                sql = " SELECT * FROM residence INNER JOIN streets ON streets.street_id = residence.street_ID INNER JOIN household ON household.hh_id = residence.hh_id  WHERE res_type = '" & cboDisplay.Text & "'" _
                                     & " AND street_name = '" & cboAddress.Text & "'  ORDER by res_name"
                cmd = New MySqlCommand(sql, kon)
                adp.SelectCommand = cmd
                adp.Fill(dt, "residencelist")

                Dim report As New crResidentlist
                Dim txtobj As CrystalDecisions.CrystalReports.Engine.TextObject
                txtobj = report.Section1.ReportObjects.Item("Text15")
                txtobj.Text = cboAddress.Text.ToUpper
                txtobj = report.Section1.ReportObjects.Item("Text16")
                txtobj.Text = cboDisplay.Text.ToUpper
                report.SetDataSource(dt)
                frmReport.CrystalReportViewer1.ReportSource = report
                frmReport.CrystalReportViewer1.Refresh()
                cmd.Dispose()
                adp.Dispose()
                dt.Dispose()
                kon.Close()
                frmReport.ShowDialog()

            ElseIf cboSort.Text = "Household Type" Then
                kon.Open()
                sql = " SELECT * FROM residence INNER JOIN streets ON streets.street_id = residence.street_ID INNER JOIN household ON household.hh_id = residence.hh_id  WHERE hh_type = '" & cboDisplay.Text & "'" _
                                     & " AND street_name = '" & cboAddress.Text & "'  ORDER by res_name"
                cmd = New MySqlCommand(sql, kon)
                adp.SelectCommand = cmd
                adp.Fill(dt, "residencelist")

                Dim report As New crResidentlist
                Dim txtobj As CrystalDecisions.CrystalReports.Engine.TextObject
                txtobj = report.Section1.ReportObjects.Item("Text15")
                txtobj.Text = cboAddress.Text.ToUpper
                txtobj = report.Section1.ReportObjects.Item("Text16")
                txtobj.Text = cboDisplay.Text.ToUpper
                report.SetDataSource(dt)
                frmReport.CrystalReportViewer1.ReportSource = report
                frmReport.CrystalReportViewer1.Refresh()
                cmd.Dispose()
                adp.Dispose()
                dt.Dispose()
                kon.Close()
                frmReport.ShowDialog()

            ElseIf cboSort.Text = "Gender" Then
                kon.Open()
                sql = " SELECT * FROM residence INNER JOIN streets ON streets.street_id = residence.street_ID INNER JOIN household ON household.hh_id = residence.hh_id  WHERE res_sex = '" & cboDisplay.Text & "'" _
                                     & " AND street_name = '" & cboAddress.Text & "'  ORDER by res_name"
                cmd = New MySqlCommand(sql, kon)
                adp.SelectCommand = cmd
                adp.Fill(dt, "residencelist")

                Dim report As New crResidentlist
                Dim txtobj As CrystalDecisions.CrystalReports.Engine.TextObject
                txtobj = report.Section1.ReportObjects.Item("Text15")
                txtobj.Text = cboAddress.Text.ToUpper
                txtobj = report.Section1.ReportObjects.Item("Text16")
                txtobj.Text = cboDisplay.Text.ToUpper
                report.SetDataSource(dt)
                frmReport.CrystalReportViewer1.ReportSource = report
                frmReport.CrystalReportViewer1.Refresh()
                cmd.Dispose()
                adp.Dispose()
                dt.Dispose()
                kon.Close()
                frmReport.ShowDialog()

            ElseIf cboSort.Text = "" Then
                kon.Open()
                sql = " SELECT * FROM residence INNER JOIN streets ON streets.street_id = residence.street_ID INNER JOIN household ON household.hh_id = residence.hh_id  ORDER by res_name"
                cmd = New MySqlCommand(sql, kon)
                adp.SelectCommand = cmd
                adp.Fill(dt, "residencelist")

                Dim report As New crResidentlist
                Dim txtobj As CrystalDecisions.CrystalReports.Engine.TextObject
                txtobj = report.Section1.ReportObjects.Item("Text15")
                txtobj.Text = "ENTIRE BARANGAY"
                txtobj = report.Section1.ReportObjects.Item("Text16")
                txtobj.Text = ""
                report.SetDataSource(dt)
                frmReport.CrystalReportViewer1.ReportSource = report
                frmReport.CrystalReportViewer1.Refresh()
                cmd.Dispose()
                adp.Dispose()
                dt.Dispose()
                kon.Close()
                frmReport.ShowDialog()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub cboSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSort.SelectedIndexChanged
        cboDisplay.Enabled = True
    End Sub

    Private Sub cboAddress_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAddress.SelectedIndexChanged
        cboSort.Enabled = True
    End Sub

    Private Sub btnDeceased_Click(sender As Object, e As EventArgs) Handles btnDeceased.Click
        Try
            DbConnect()
            Dim qry As String = "SELECT res_id, res_name, res_sex, street_name FROM residence INNER JOIN streets ON residence.street_id = streets.street_ID WHERE res_ID = '" & ID.Text & "'"
            ExecuteQuery(qry)
            If reader.HasRows Then
                While reader.Read
                    frmDeceased.res_ID.Text = reader.GetString("res_id")
                    frmDeceased.res_name.Text = reader.GetString("res_name")
                    frmDeceased.res_sex.Text = reader.GetString("res_sex")
                    frmDeceased.res_add.Text = reader.GetString("street_name")
                End While
            End If
            DbDisconnect()
            frmDeceased.Show()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    '======================= tab/4
    Sub loadDeceased()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwDeceased.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT rd_id, rd_reason, rd_date, res_name, res_sex, street_name FROM res_deceased, residence, streets WHERE residence.res_id = res_deceased.res_id AND streets.street_id = residence.street_id AND is_deceased = 'yes' ORDER by res_name"
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
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim hh As New ucDeceased
        toPanelMain(hh.Width, hh.Height, hh)
    End Sub
End Class
