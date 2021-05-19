Public Class ucPay
    Dim businessPurpose As String
    Dim barangayPurpose As String
    Private Sub ucPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadType()
        loadID()
        txtCash.Clear()
        panelPay.BringToFront()
        DbConnect()
        Dim qry As String = "SELECT cap_name FROM captain_name"
        ExecuteQuery(qry)
        If reader.HasRows Then
            While reader.Read
                txtCap.Text = reader.GetString("cap_name")
            End While
        End If
        DbDisconnect()
    End Sub


    Private Sub radR_CheckedChanged(sender As Object, e As EventArgs) Handles radR.CheckedChanged
        businessPurpose = radR.Text
    End Sub

    Private Sub radN_CheckedChanged(sender As Object, e As EventArgs) Handles radN.CheckedChanged
        businessPurpose = radN.Text
    End Sub

    Private Sub radPolice_CheckedChanged(sender As Object, e As EventArgs) Handles radPolice.CheckedChanged
        barangayPurpose = radPolice.Text
    End Sub

    Private Sub radNBI_CheckedChanged(sender As Object, e As EventArgs) Handles radNBI.CheckedChanged
        barangayPurpose = radNBI.Text
    End Sub

    Private Sub radBIR_CheckedChanged(sender As Object, e As EventArgs) Handles radBIR.CheckedChanged
        barangayPurpose = radBIR.Text
    End Sub

    Private Sub radEmp_CheckedChanged(sender As Object, e As EventArgs) Handles radEmp.CheckedChanged
        barangayPurpose = radEmp.Text
    End Sub

    Private Sub radSchool_CheckedChanged(sender As Object, e As EventArgs) Handles radSchool.CheckedChanged
        barangayPurpose = radSchool.Text
    End Sub

    Private Sub radOthers_CheckedChanged(sender As Object, e As EventArgs) Handles radOthers.CheckedChanged
        If radOthers.Checked = True Then
            txtSpecify.Visible = True
            txtSpecify.Enabled = True
        End If
    End Sub

    Private Sub txtSpecify_OnValueChanged(sender As Object, e As EventArgs) Handles txtSpecify.OnValueChanged
        barangayPurpose = txtSpecify.Text
    End Sub

    Sub loadType()
        cboType.Items.Add("Barangay Clearance")
        cboType.Items.Add("Business Clearance")
        cboType.Items.Add("Certificate of Good Moral")
        cboType.Items.Add("Certificate of Indigency")
        'cboType.Items.Add("Certificate of Non-Voter Guarantor")
    End Sub

    Sub txtClear()
        txtAddress.Clear()
        txtSex.Clear()
        txtName.Clear()
        txtresID.Clear()
        cboBName.Items.Clear()
        ' txtBName.Clear()
        txtBAdd.Clear()
        txtBLine1.Clear()
        txtBusID.Clear()
        ' txtBNamePurpose.Clear()

    End Sub

    Sub loadID()
        Try
            DbConnect()
            Dim query As String = "SELECT cr_id from certificationreport ORDER BY cr_id DESC LIMIT 1"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtCtrlNo.Text = "CTR" & Val(Mid(reader.GetString(0), 4, 8)) + 1
                End While
            Else
                txtCtrlNo.Text = "CTR20001"
            End If
            DbDisconnect()
        Catch ex As Exception
            MessageBox.Show("An error occured." & ex.Message)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub panPrint()
        panelPrint.BringToFront()
        panelPay.SendToBack()
        Label1.Enabled = False
        Label3.Enabled = True
        picPay.Image = My.Resources.refg
        picPrint.Image = My.Resources.ru

        Try
            DbConnect()
            Dim query As String = "SELECT cr_id, cr_purpose, res_name, res_sex, res_bdate, res_nationality, res_status, street_name FROM certificationreport INNER JOIN residence ON certificationreport.res_id = residence.res_id INNER JOIN streets ON residence.street_ID = streets.street_ID WHERE cr_type = 'Barangay Clearance' ORDER BY cr_id DESC LIMIT 1"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtrid.Text = reader.GetString("cr_id")
                    txtRName.Text = reader.GetString("res_name")
                    txtRAddress.Text = reader.GetString("street_name")
                    txtRBday.Text = reader.GetString("res_bdate")
                    txtRNationality.Text = reader.GetString("res_nationality")
                    txtRCS.Text = reader.GetString("res_status")
                    If reader.GetString("res_sex") = "Male" Then
                        radRm.Checked = True
                    ElseIf reader.GetString("res_sex") = "Female" Then
                        radRf.Checked = True
                    End If
                    If reader.GetString("cr_purpose") = "Police Clearance" Then
                        radRPolice.Checked = True
                    ElseIf reader.GetString("cr_purpose") = "N.B.I. Clearance" Then
                        radRNBI.Checked = True
                    ElseIf reader.GetString("cr_purpose") = "B.I.R. (TIN)" Then
                        radRBIR.Checked = True
                    ElseIf reader.GetString("cr_purpose") = "Employment" Then
                        radREmployment.Checked = True
                    ElseIf reader.GetString("cr_purpose") = "School Requirements" Then
                        radRSchool.Checked = True
                    Else
                        radROthers.Checked = True
                        txtRSpecify.Text = reader.GetString("cr_purpose")
                        txtRSpecify.Visible = True
                        txtRSpecify.Enabled = True
                    End If
                    Dim rDay = DateAndTime.Today.ToString("dd")
                    cboRDay.Text = rDay
                    Dim rMonth = DateAndTime.Today.ToString("MMMM")
                    cboRMonth.Text = rMonth
                    Dim rYear = DateAndTime.Today.ToString("yyyy")
                    cboRYear.Text = rYear
                End While
            End If
            txtRAge.Focus()
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub panPrintBusiness()
        panelPrintBusiness.BringToFront()
        panelPay.SendToBack()
        Label1.Enabled = False
        Label3.Enabled = True
        picPay.Image = My.Resources.refg
        picPrint.Image = My.Resources.ru

        Try
            DbConnect()
            Dim query As String = "SELECT cr_id, cr_purpose, cr_issued, bo_name, bo_sex, bo_address FROM certificationreport INNER JOIN businessowners ON certificationreport.businessowner_id = businessowners.businessowner_id WHERE cr_type = 'Business Clearance' ORDER BY cr_id DESC LIMIT 1"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read

                    txtbid.Text = reader.GetString("cr_id")
                    txtd.Text = reader.GetString("cr_issued")
                    txtBOname.Text = reader.GetString("bo_name")
                    txtBOAddress.Text = reader.GetString("bo_address")
                    If reader.GetString("bo_sex") = "Male" Then
                        radBOM.Checked = True
                    ElseIf reader.GetString("bo_sex") = "Female" Then
                        radBOF.Checked = True
                    End If
                    If reader.GetString("cr_purpose") = "New application" Then
                        radBNew.Checked = True
                    ElseIf reader.GetString("cr_purpose") = "Re-new application" Then
                        radBRenew.Checked = True
                    End If

                End While
            End If
            DbDisconnect()

            DbConnect()
            Dim query1 As String = "SELECT business_name, street_name, line_name FROM business INNER JOIN streets ON business.street_id = streets.street_id INNER JOIN businesslines ON businesslines.line_id = business.line_id WHERE business_id ='" & txtBusID.Text & "'"
            ExecuteQuery(query1)
            If reader.HasRows Then
                While reader.Read
                    txtBName.Text = reader.GetString("business_name")
                    txtBAddress.Text = reader.GetString("street_name")
                    txtBLine.Text = reader.GetString("line_name")
                End While
                Dim bDay = DateAndTime.Today.ToString("dd")
                cboBDay.Text = bDay
                Dim bMonth = DateAndTime.Today.ToString("MMMM")
                cboBMonth.Text = bMonth
                Dim bYear = DateAndTime.Today.ToString("yyyy")
                cboBYear.Text = bYear
                txtBOAge.Focus()
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub panPrintIM()
        panIM.BringToFront()
        panelPay.SendToBack()
        Label1.Enabled = False
        Label3.Enabled = True
        picPay.Image = My.Resources.refg
        picPrint.Image = My.Resources.ru

        Try
            DbConnect()
            Dim query As String = "SELECT cr_id, cr_purpose, cr_type, res_name, res_sex, street_name FROM certificationreport INNER JOIN residence ON certificationreport.res_id = residence.res_id INNER JOIN streets ON residence.street_ID = streets.street_ID WHERE cr_type = 'Certificate of Indigency' ORDER BY cr_id DESC LIMIT 1"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtimid.Text = reader.GetString("cr_id")
                    txtIMType.Text = reader.GetString("cr_type")
                    txtIMName.Text = reader.GetString("res_name")
                    txtIMAdd.Text = reader.GetString("street_name")
                    txtIMPurpose.Text = reader.GetString("cr_purpose")
                    If reader.GetString("res_sex") = "Male" Then
                        radIMm.Checked = True
                    ElseIf reader.GetString("res_sex") = "Female" Then
                        radIMf.Checked = True
                    End If
                End While
                Dim imDay = DateAndTime.Today.ToString("dd")
                cboIMDay.Text = imDay
                Dim imMonth = DateAndTime.Today.ToString("MMMM")
                cboIMMonth.Text = imMonth
                Dim imYear = DateAndTime.Today.ToString("yyyy")
                cboIMYear.Text = imYear
            End If
            txtIMAge.Focus()
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub panPrintGM()
        panIM.BringToFront()
        panelPay.SendToBack()
        Label1.Enabled = False
        Label3.Enabled = True
        picPay.Image = My.Resources.refg
        picPrint.Image = My.Resources.ru

        Try
            DbConnect()
            Dim query As String = "SELECT cr_id, cr_purpose, cr_type, res_name, res_sex, street_name FROM certificationreport INNER JOIN residence ON certificationreport.res_id = residence.res_id INNER JOIN streets ON residence.street_ID = streets.street_ID WHERE cr_type = 'Certificate of Good Moral' ORDER BY cr_id DESC LIMIT 1"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtimid.Text = reader.GetString("cr_id")
                    txtIMType.Text = reader.GetString("cr_type")
                    txtIMName.Text = reader.GetString("res_name")
                    txtIMAdd.Text = reader.GetString("street_name")
                    txtIMPurpose.Text = reader.GetString("cr_purpose")
                    If reader.GetString("res_sex") = "Male" Then
                        radIMm.Checked = True
                    ElseIf reader.GetString("res_sex") = "Female" Then
                        radIMf.Checked = True
                    End If
                End While
                Dim gmDay = DateAndTime.Today.ToString("dd")
                cboIMDay.Text = gmDay
                Dim gmMonth = DateAndTime.Today.ToString("MMMM")
                cboIMMonth.Text = gmMonth
                Dim gmYear = DateAndTime.Today.ToString("yyyy")
                cboIMYear.Text = gmYear
            End If
            txtIMAge.Focus()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub


    Sub payment()
        Dim transdate = DateTime.Now.ToString("MM-dd-yyyy")
        Dim expire = DateTime.Now.AddYears(1).ToString("MM-dd-yyyy")
        Dim change As Double = Convert.ToDouble(txtCash.Text) - Convert.ToDouble(txtTotal.Text)
        Try
            If (change >= 0) Then

                If cboType.Text = "Barangay Clearance" Then
                    If Trim(barangayPurpose) = "" Or Trim(txtresID.Text) = "" Then
                        MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Return
                    End If
                    DbConnect()
                    Dim query As String = " INSERT INTO certificationreport SET cr_id = '" & txtCtrlNo.Text & "', cr_name = '" & txtName.Text & "', cr_type = '" & cboType.Text & "', cr_purpose = '" & barangayPurpose & "', cr_total = '" & txtTotal.Text & "', cr_issued = '" & transdate & "', res_id = '" & txtresID.Text & "', processed_by = '" & frmDashboard.txtUser.Text & "', is_print = 'no' "
                    ExecuteQuery(query)
                    DbDisconnect()

                    DbConnect()
                    Dim query1 As String = " INSERT INTO residencelogs SET  rl_action = 'Requested Barangay Clearance', rl_date = '" & transdate & "', rl_performby = '" & frmDashboard.txtUser.Text & "', res_id = '" & txtresID.Text & "' "
                    ExecuteQuery(query1)
                    DbDisconnect()
                    radPolice.Text = ""
                    radNBI.Text = ""
                    radBIR.Text = ""
                    radEmp.Text = ""
                    radSchool.Text = ""
                    radOthers.Text = ""
                    txtSpecify.Text = ""
                    txtClear()

                    If txtTotal.Text = "00.00" And Convert.ToString(txtCash.Text) = "" OrElse Convert.ToString(txtCash.Text) Is Nothing Then
                        MetroFramework.MetroMessageBox.Show(Me, " 
Transaction success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        txtClear()
                        cboType.Items.Clear()
                        txtTotal.Text = "00.00"
                        panelPrint.Visible = True
                        panelPay.Visible = False
                        panelPrintBusiness.Visible = False
                        panPrint()
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, " 
Change: ₱" & change, "Change:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MetroFramework.MetroMessageBox.Show(Me, " 
Transaction success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        txtClear()
                        cboType.Items.Clear()
                        txtTotal.Text = "00.00"
                        panelPrint.Visible = True
                        panelPay.Visible = False
                        panelPrintBusiness.Visible = False
                        panPrint()
                    End If


                ElseIf cboType.Text = "Business Clearance" Then
                    If Trim(businessPurpose) = "" Or Trim(txtresID.Text) = "" Then
                        MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Return
                    End If
                    DbConnect()
                    Dim query As String = " INSERT INTO certificationreport SET cr_id = '" & txtCtrlNo.Text & "', cr_name = '" & txtName.Text & "', cr_type = '" & cboType.Text & "', cr_purpose = '" & businessPurpose & "', cr_total = '" & txtTotal.Text & "', cr_issued = '" & transdate & "', businessowner_id = '" & txtresID.Text & "', processed_by = '" & frmDashboard.txtUser.Text & "', is_print = 'no', business_id = '" & txtBusID.Text & "' "
                    ExecuteQuery(query)
                    DbDisconnect()
                    cboBName.Items.Clear()

                    DbConnect()
                    Dim qry As String = " UPDATE business SET cr_issued = '" & transdate & "', cr_expire = '" & expire & "' WHERE business_id = '" & txtBusID.Text & "'"
                    ExecuteQuery(qry)
                    DbDisconnect()

                    If txtTotal.Text = "00.00" And Convert.ToString(txtCash.Text) = "" OrElse Convert.ToString(txtCash.Text) Is Nothing Then
                        MetroFramework.MetroMessageBox.Show(Me, " 
Transaction success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        txtTotal.Text = "00.00"
                        cboBName.Items.Clear()
                        cboType.Items.Clear()
                        radR.Text = ""
                        radN.Text = ""
                        panelPrint.Visible = False
                        panelPay.Visible = False
                        panelPrintBusiness.Visible = True
                        panPrintBusiness()
                        txtClear()
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, " 
Change: ₱" & change, "Change:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MetroFramework.MetroMessageBox.Show(Me, " 
Transaction success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        txtTotal.Text = "00.00"
                        radR.Text = ""
                        radN.Text = ""
                        cboBName.Items.Clear()
                        panelPrint.Visible = False
                        panelPay.Visible = False
                        panelPrintBusiness.Visible = True
                        panPrintBusiness()
                        txtClear()
                    End If



                ElseIf cboType.Text = "Certificate of Indigency" Then
                    If Trim(txtPurpose.Text) = "" Or Trim(txtresID.Text) = "" Then
                        MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Return
                    End If
                    DbConnect()
                    Dim query As String = " INSERT INTO certificationreport SET cr_id = '" & txtCtrlNo.Text & "', cr_name = '" & txtName.Text & "',  cr_type = '" & cboType.Text & "', cr_purpose = '" & txtPurpose.Text & "', cr_total = '" & txtTotal.Text & "', cr_issued = '" & transdate & "', res_id = '" & txtresID.Text & "', processed_by = '" & frmDashboard.txtUser.Text & "', is_print = 'no' "
                    ExecuteQuery(query)
                    DbDisconnect()

                    DbConnect()
                    Dim query1 As String = " INSERT INTO residencelogs SET  rl_action = 'Requested Certificate of Indigency', rl_date = '" & transdate & "', rl_performby = '" & frmDashboard.txtUser.Text & "', res_id = '" & txtresID.Text & "' "
                    ExecuteQuery(query1)
                    DbDisconnect()
                    txtPurpose.Text = ""
                    txtClear()

                    If txtTotal.Text = "00.00" And Convert.ToString(txtCash.Text) = "" OrElse Convert.ToString(txtCash.Text) Is Nothing Then
                        MetroFramework.MetroMessageBox.Show(Me, " 
Transaction success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        txtClear()
                        cboType.Items.Clear()
                        txtTotal.Text = "00.00"
                        panelPrint.Visible = False
                        panelPay.Visible = False
                        panelPrintBusiness.Visible = False
                        panIM.Visible = True
                        panPrintIM()
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, " 
Change: ₱" & change, "Change:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MetroFramework.MetroMessageBox.Show(Me, " 
Transaction success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        txtClear()
                        cboType.Items.Clear()
                        txtTotal.Text = "00.00"
                        panelPrint.Visible = False
                        panelPay.Visible = False
                        panelPrintBusiness.Visible = False
                        panIM.Visible = True
                        panPrintIM()
                    End If


                ElseIf cboType.Text = "Certificate of Good Moral" Then
                    If Trim(txtPurpose.Text) = "" Or Trim(txtresID.Text) = "" Then
                        MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Return
                    End If
                    DbConnect()
                    Dim query As String = " INSERT INTO certificationreport SET cr_id = '" & txtCtrlNo.Text & "', cr_name = '" & txtName.Text & "',  cr_type = '" & cboType.Text & "', cr_purpose = '" & txtPurpose.Text & "', cr_total = '" & txtTotal.Text & "', cr_issued = '" & transdate & "', res_id = '" & txtresID.Text & "', processed_by = '" & frmDashboard.txtUser.Text & "', is_print = 'no' "
                    ExecuteQuery(query)
                    DbDisconnect()

                    DbConnect()
                    Dim query1 As String = " INSERT INTO residencelogs SET  rl_action = 'Requested Certificate of Good Moral', rl_date = '" & transdate & "', rl_performby = '" & frmDashboard.txtUser.Text & "', res_id = '" & txtresID.Text & "' "
                    ExecuteQuery(query1)
                    DbDisconnect()
                    txtPurpose.Text = ""
                    txtClear()

                    If txtTotal.Text = "00.00" And Convert.ToString(txtCash.Text) = "" OrElse Convert.ToString(txtCash.Text) Is Nothing Then
                        MetroFramework.MetroMessageBox.Show(Me, " 
Transaction success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        txtClear()
                        cboType.Items.Clear()
                        txtTotal.Text = "00.00"
                        panelPrint.Visible = False
                        panelPay.Visible = False
                        panelPrintBusiness.Visible = False
                        panIM.Visible = True
                        panPrintGM()
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, " 
Change: ₱" & change, "Change:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MetroFramework.MetroMessageBox.Show(Me, " 
Transaction success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        txtClear()
                        cboType.Items.Clear()
                        txtTotal.Text = "00.00"
                        panelPrint.Visible = False
                        panelPay.Visible = False
                        panelPrintBusiness.Visible = False
                        panIM.Visible = True
                        panPrintGM()
                    End If
                End If

            Else
                MetroFramework.MetroMessageBox.Show(Me, " 
Insufficient funds.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            loadType()
            grpBarangayClearance.Visible = False
            grpIndigency.Visible = False
            grpBusinessPurpose.Visible = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cboType.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please select type of certificate.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf cboType.Text = "Business Clearance" Then
            txtClear()
            searchboid = ""
            frmBusinessList.ShowDialog()
            btnPay.Enabled = True
            Dim isSelected As Boolean = False
            If isSelected Then
                MetroFramework.MetroMessageBox.Show(Me, " 
Resident already selected.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf searchboid <> "" Or isSelected = False Then
                DbConnect()
                Dim querry = "SELECT businessowner_id, bo_name, bo_address, bo_sex FROM businessowners WHERE businessowner_id=@boid"
                ExecuteQueryParameter(querry)
                command.Parameters.AddWithValue("@boid", searchboid)
                command.Parameters.AddWithValue("@name", txtName.Text)
                command.Parameters.AddWithValue("@add", txtAddress.Text)
                command.Parameters.AddWithValue("@sex", txtSex.Text)
                reader = command.ExecuteReader
                If reader.HasRows Then
                    While reader.Read
                        txtresID.Text = reader.GetString("businessowner_id")
                        txtName.Text = reader.GetString("bo_name")
                        txtAddress.Text = reader.GetString("bo_address")
                        txtSex.Text = reader.GetString("bo_sex")
                    End While
                End If
                DbDisconnect()


                cboBName.Items.Clear()
                DbConnect()
                Dim query4 = "SELECT business_name FROM business INNER JOIN businessowners ON businessowners.business_id = business.business_ID WHERE businessowner_id=@boid "
                ExecuteQueryParameter(query4)
                command.Parameters.AddWithValue("@bname", cboBName)
                command.Parameters.AddWithValue("@boid", searchboid)
                reader = command.ExecuteReader
                If reader.HasRows Then
                    While reader.Read
                        cboBName.Items.Add(reader.GetString("business_name"))
                    End While
                End If
                DbDisconnect()

                '                DbConnect()
                '                Dim qry As String = "SELECT cr_expire FROM business INNER JOIN businessowners ON businessowners.business_id = business.business_ID WHERE businessowner_id=@boid"
                '                ExecuteQueryParameter(qry)
                '                command.Parameters.AddWithValue("@boid", searchboid)
                '                reader = command.ExecuteReader
                '                If reader.HasRows Then
                '                    While reader.Read
                '                        Dim colExpre = reader.GetOrdinal("cr_expire")
                '                        Dim exp As String = Nothing
                '                        If Not reader.IsDBNull(colExpre) Then
                '                            exp = reader.GetString("cr_expire").ToString
                '                            Dim a As Date = reader.GetString("cr_expire")
                '                            Dim b = Date.Now
                '                            If b <= a Then
                '                                MetroFramework.MetroMessageBox.Show(Me, " 
                'Selected Business Establishment clearance is still valid until  " + a + ".", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '                                txtClear()
                '                                Exit Sub
                '                            End If
                '                        End If
                '                    End While
                '                End If
                '                DbDisconnect()

            End If
            searchboid = ""

        ElseIf cboType.Text = "Barangay Clearance" Or cboType.Text = "Certificate of Indigency" Or cboType.Text = "Certificate of Good Moral" Then
            txtClear()
            searchresid = ""
            frmResidenceList.ShowDialog()
            btnPay.Enabled = True
            Dim isSelected As Boolean = False
            If isSelected Then
                MetroFramework.MetroMessageBox.Show(Me, " 
Resident is already selected.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf searchresid <> "" Or isSelected = False Then
                DbConnect()
                Dim query = "SELECT residence.res_id, res_name, street_name, res_sex FROM residence INNER JOIN streets ON residence.street_id = streets.street_id WHERE residence.res_id='" & searchresid & "'"
                ExecuteQuery(query)
                If reader.HasRows Then
                    While reader.Read
                        txtresID.Text = reader.GetString("res_id")
                        txtName.Text = reader.GetString("res_name")
                        txtAddress.Text = reader.GetString("street_name")
                        txtSex.Text = reader.GetString("res_sex")
                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim query1 As String = "SELECT bl_active, bc_name FROM blacklists INNER JOIN blacklistcriteria ON blacklists.bc_id = blacklistcriteria.bc_id INNER JOIN residence ON blacklists.res_id = residence.res_id WHERE bl_active = 'yes' AND blacklists.res_id = '" & searchresid & "'"
                ExecuteQuery(query1)
                If reader.HasRows Then
                    While reader.Read
                        Dim rs As String = reader.GetString("bc_name")
                        Dim a As String = reader.GetString("bl_active")
                        If a = "yes" Then
                            MetroFramework.MetroMessageBox.Show(Me, " 
Selected resident is blacklisted.

Reason: " + rs, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            txtClear()
                        End If
                    End While
                End If
                DbDisconnect()
            End If
            searchresid = ""
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtClear()
        txtCash.Clear()
        cboType.Items.Clear()
        loadType()
        grpBarangayClearance.Visible = False
        grpBusinessPurpose.Visible = False
        grpIndigency.Visible = False
        radPolice.Checked = False
        radNBI.Checked = False
        radSchool.Checked = False
        radBIR.Checked = False
        radEmp.Checked = False
        radOthers.Checked = False
        txtSpecify.Text = ""
        radR.Checked = False
        radN.Checked = False
        txtPurpose.Clear()
        btnPay.Enabled = False
        txtTotal.Text = "0.00"
    End Sub

    Private Sub cboBName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBName.SelectedIndexChanged
        DbConnect()
        Dim query5 As String = "SELECT businessowners.business_id, street_name, line_name, business_name FROM streets, businesslines, businessowners, business WHERE business.street_id = streets.street_ID AND businesslines.line_id = business.line_id AND businessowners.business_id = business.business_ID  AND business_name='" & cboBName.Text & "' "
        ExecuteQuery(query5)
        If reader.HasRows Then
            While reader.Read
                txtBAdd.Text = reader.GetString("street_name")
                txtBLine1.Text = reader.GetString("line_name")
                txtBusID.Text = reader.GetString("business_id")
            End While
        End If
        DbDisconnect()

        DbConnect()
        Dim qry As String = "SELECT cr_expire FROM business  WHERE business_ID=@busid"
        ExecuteQueryParameter(qry)
        command.Parameters.AddWithValue("@busid", txtBusID.Text)
        reader = command.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                Dim colExpre = reader.GetOrdinal("cr_expire")
                Dim exp As String = Nothing
                If Not reader.IsDBNull(colExpre) Then
                    exp = reader.GetString("cr_expire").ToString
                    Dim a As Date = reader.GetString("cr_expire")
                    Dim b = Date.Now
                    If b <= a Then
                        MetroFramework.MetroMessageBox.Show(Me, " 
Selected Business Establishment clearance is still valid until  " + a + ".", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        txtClear()
                        Exit Sub
                    End If
                End If
            End While
        End If
        DbDisconnect()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Try
            If Trim(txtCash.Text) = "" Then
                MetroFramework.MetroMessageBox.Show(Me, " 
            Please input the amount intended for the transaction.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                payment()
                loadID()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
        Exit Sub

    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        If cboType.Text = "Barangay Clearance" Then
            DbConnect()
            Dim qry As String = "SELECT cp_price FROM certificationprice WHERE cp_type = 'Barangay Clearance'"
            ExecuteQuery(qry)
            If reader.HasRows Then
                While reader.Read
                    txtClear()
                    txtTotal.Text = reader.GetString("cp_price") + ".00"
                    txtCash.Text = ""
                    lblAmountBa.Text = reader.GetString("cp_price") + ".00 Php Only"
                End While
            End If
            DbDisconnect()
            grpBarangayClearance.Visible = True
            grpIndigency.Visible = False
            grpBusinessPurpose.Visible = False
            lblTimeBa.Text = DateTime.Now.ToString("dd MMMM yyyy")

        ElseIf cboType.Text = "Business Clearance" Then
            DbConnect()
            Dim qry As String = "SELECT cp_price FROM certificationprice WHERE cp_type = 'Business Clearance'"
            ExecuteQuery(qry)
            If reader.HasRows Then
                While reader.Read
                    txtClear()
                    txtTotal.Text = reader.GetString("cp_price") + ".00"
                    txtCash.Text = ""
                    Label15.Text = reader.GetString("cp_price") + ".00 Php Only"
                End While
            End If
            grpBusinessPurpose.Visible = True
            grpIndigency.Visible = False
            grpBarangayClearance.Visible = False
            lblTimeB.Text = DateTime.Now.ToString("dd MMMM yyyy")

        ElseIf cboType.Text = "Certificate of Indigency" Then
            DbConnect()
            Dim qry As String = "SELECT cp_price FROM certificationprice WHERE cp_type = 'Certificate of Indigency'"
            ExecuteQuery(qry)
            If reader.HasRows Then
                While reader.Read
                    txtClear()
                    txtTotal.Text = reader.GetString("cp_price") + ".00"
                    txtCash.Text = ""
                    lblAmountIG.Text = reader.GetString("cp_price") + ".00 Php Only"
                End While
            End If
            grpIndigency.Visible = True
            grpBusinessPurpose.Visible = False
            grpBarangayClearance.Visible = False
            lblG.Text = DateTime.Now.ToString("dd MMMM yyyy")

        ElseIf cboType.Text = "Certificate of Good Moral" Then
            DbConnect()
            Dim qry As String = "SELECT cp_price FROM certificationprice WHERE cp_type = 'Certificate of Good Moral'"
            ExecuteQuery(qry)
            If reader.HasRows Then
                While reader.Read
                    txtClear()
                    txtTotal.Text = reader.GetString("cp_price") + ".00"
                    txtCash.Text = ""
                    lblAmountIG.Text = reader.GetString("cp_price") + ".00 Php Only"
                End While
            End If
            grpIndigency.Visible = True
            grpBusinessPurpose.Visible = False
            grpBarangayClearance.Visible = False
            lblG.Text = DateTime.Now.ToString("dd MMMM yyyy")

        Else
            txtName.Enabled = False
        End If
    End Sub

    Private Sub txtCash_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCash.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If Trim(txtCash.Text) = "" Then
                    MetroFramework.MetroMessageBox.Show(Me, " 
Please input the amount intended for the transaction.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Else
                    btnPay_Click(sender, e)
                End If
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                DisposeConnection()
            End Try
            Exit Sub
        End If
    End Sub

    Private Sub txtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress
        Try
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub passBusiness()
        Dim bname = txtName.Text
        txtBName.Text = bname
    End Sub

    Private Sub btnBPrint_Click(sender As Object, e As EventArgs) Handles btnBPrint.Click
        If Trim(txtBName.Text) = "" Or Trim(txtBAddress.Text) = "" Or Trim(txtBLine.Text) = "" Or Trim(txtBOname.Text) = "" Or Trim(txtBOAge.Text) = "" Or Trim(txtBOAddress.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            Dim report As New cRBClearance
            Dim txtobj As CrystalDecisions.CrystalReports.Engine.TextObject
            'capname
            txtobj = report.Section1.ReportObjects.Item("Text23")
            txtobj.Text = txtCap.Text.ToUpper
            'business info
            txtobj = report.Section1.ReportObjects.Item("Text26")
            txtobj.Text = txtBName.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text27")
            txtobj.Text = txtBLine.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text28")
            txtobj.Text = txtBAddress.Text.ToUpper
            'businessowner info 1
            txtobj = report.Section1.ReportObjects.Item("Text8")
            txtobj.Text = txtBOname.Text.ToUpper + ","
            txtobj = report.Section1.ReportObjects.Item("Text9")
            txtobj.Text = txtBOAge.Text.ToUpper + ","
            txtobj = report.Section1.ReportObjects.Item("Text12")
            txtobj.Text = txtBAddress.Text.ToUpper + ","
            'purpose and date 1
            txtobj = report.Section1.ReportObjects.Item("Text15")
            If radBRenew.Checked = True Then
                txtobj.Text = radBRenew.Text
            ElseIf radBNew.Checked = True Then
                txtobj.Text = radBNew.Text
            End If
            'date 1
            txtobj = report.Section1.ReportObjects.Item("Text30")
            txtobj.Text = cboBDay.Text.ToUpper + ","
            txtobj = report.Section1.ReportObjects.Item("Text33")
            txtobj.Text = cboBMonth.Text.ToUpper + ","
            txtobj = report.Section1.ReportObjects.Item("Text34")
            txtobj.Text = cboBYear.Text.ToUpper
            'businessowner info 2 w/purpose and anotha name
            txtobj = report.Section1.ReportObjects.Item("Text63")
            txtobj.Text = txtBOname.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text72")
            txtobj.Text = txtBOAddress.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text66")
            txtobj.Text = txtBOAge.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text68")
            If radBOM.Checked = True Then
                txtobj.Text = radBOM.Text
            ElseIf radBOF.Checked = True Then
                txtobj.Text = radBOF.Text
            End If
            txtobj = report.Section1.ReportObjects.Item("Text73")
            If radBRenew.Checked = True Then
                txtobj.Text = radBRenew.Text
            ElseIf radBNew.Checked = True Then
                txtobj.Text = radBNew.Text
            End If
            txtobj = report.Section1.ReportObjects.Item("Text76")
            txtobj.Text = txtBOname.Text
            'date 2
            txtobj = report.Section1.ReportObjects.Item("Text79")
            txtobj.Text = cboBDay.Text.ToUpper + ","
            txtobj = report.Section1.ReportObjects.Item("Text81")
            txtobj.Text = cboBMonth.Text.ToUpper + ","
            txtobj = report.Section1.ReportObjects.Item("Text82")
            txtobj.Text = cboBYear.Text.ToUpper
            'ctrl no. 1 and 2 and issued date
            txtobj = report.Section1.ReportObjects.Item("Text87")
            txtobj.Text = txtbid.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text88")
            txtobj.Text = txtbid.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text59")
            txtobj.Text = txtd.Text.ToUpper

            frmReport.CrystalReportViewer1.ReportSource = report
            frmReport.CrystalReportViewer1.Refresh()
            frmReport.ShowDialog()

            DbConnect()
            Dim query As String = "UPDATE certificationreport SET is_print = 'yes' WHERE cr_id = '" & txtbid.Text & "'"
            ExecuteQuery(query)
            DbDisconnect()

            txtBName.Clear()
            txtBAddress.Clear()
            txtBLine.Clear()
            txtBOname.Clear()
            txtBOAddress.Clear()
            txtBOAge.Clear()
            radBRenew.Checked = False
            radBNew.Checked = False
            radBOF.Checked = False
            radBOM.Checked = False

            Dim pay As New ucPay
            toPanelMain(pay.Width, pay.Height, pay)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnRPrint_Click(sender As Object, e As EventArgs) Handles btnRPrint.Click
        If Trim(txtRName.Text) = "" Or Trim(txtRAge.Text) = "" Or Trim(txtRAddress.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            Dim report As New crRClearance
            Dim txtobj As CrystalDecisions.CrystalReports.Engine.TextObject
            'capname
            txtobj = report.Section1.ReportObjects.Item("Text35")
            txtobj.Text = txtCap.Text.ToUpper

            txtobj = report.Section1.ReportObjects.Item("Text13")
            txtobj.Text = txtRName.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text17")
            txtobj.Text = txtRAge.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text15")
            txtobj.Text = txtRAddress.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text14")
            If radRm.Checked = True Then
                txtobj.Text = radRm.Text
            ElseIf radRf.Checked = True Then
                txtobj.Text = radRf.Text
            End If
            txtobj = report.Section1.ReportObjects.Item("Text19")
            txtobj.Text = txtRCS.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text12")
            txtobj.Text = txtRBday.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text21")
            txtobj.Text = txtRNationality.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text23")
            If radRPolice.Checked = True Then
                txtobj.Text = radRPolice.Text.ToUpper
            ElseIf radRNBI.Checked = True Then
                txtobj.Text = radRNBI.Text.ToUpper
            ElseIf radRBIR.Checked = True Then
                txtobj.Text = radRBIR.Text.ToUpper
            ElseIf radREmployment.Checked = True Then
                txtobj.Text = radREmployment.Text.ToUpper
            ElseIf radRSchool.Checked = True Then
                txtobj.Text = radRSchool.Text.ToUpper
            ElseIf radROthers.Checked = True Then
                txtobj.Text = txtRSpecify.Text.ToUpper
            End If
            txtobj = report.Section1.ReportObjects.Item("Text26")
            txtobj.Text = cboRDay.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text28")
            txtobj.Text = cboRMonth.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text29")
            txtobj.Text = cboRYear.Text.ToUpper
            txtobj = report.Section1.ReportObjects.Item("Text33")
            txtobj.Text = frmDashboard.txtUser.Text.ToUpper

            frmReport.CrystalReportViewer1.ReportSource = report
            frmReport.CrystalReportViewer1.Refresh()
            frmReport.ShowDialog()

            DbConnect()
            Dim query As String = "UPDATE certificationreport SET is_print = 'yes' WHERE cr_id = '" & txtrid.Text & "'"
            ExecuteQuery(query)
            DbDisconnect()

            txtRName.Clear()
            txtRAge.Clear()
            txtRAddress.Clear()
            radRf.Checked = False
            radRm.Checked = False
            txtRSpecify.Text = ""
            radRPolice.Checked = False
            radRBIR.Checked = False
            radRNBI.Checked = False
            radREmployment.Checked = False
            radRSchool.Checked = False
            radROthers.Checked = False

            Dim pay As New ucPay
            toPanelMain(pay.Width, pay.Height, pay)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnIMPrint_Click(sender As Object, e As EventArgs) Handles btnIMPrint.Click
        If Trim(txtIMName.Text) = "" Or Trim(txtIMAge.Text) = "" Or Trim(txtIMAdd.Text) = "" Or Trim(txtIMPurpose.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        Try
            If Trim(txtIMRelation.Text) = "" Or Trim(txtIMRequestor.Text) = "" Then
                Dim report As New crIGM2
                Dim txtobj As CrystalDecisions.CrystalReports.Engine.TextObject
                'capname
                txtobj = report.Section1.ReportObjects.Item("Text35")
                txtobj.Text = txtCap.Text.ToUpper

                txtobj = report.Section1.ReportObjects.Item("Text26")
                txtobj.Text = txtIMName.Text.ToUpper + ","
                txtobj = report.Section1.ReportObjects.Item("Text9")
                txtobj.Text = txtIMAge.Text.ToUpper + ","
                txtobj = report.Section1.ReportObjects.Item("Text11")
                txtobj.Text = txtIMAdd.Text.ToUpper
                txtobj = report.Section1.ReportObjects.Item("Text6")
                txtobj.Text = txtIMType.Text.ToUpper

                txtobj = report.Section1.ReportObjects.Item("Text14")
                txtobj.Text = txtIMPurpose.Text.ToUpper


                'date issued
                txtobj = report.Section1.ReportObjects.Item("Text20")
                txtobj.Text = cboIMDay.Text.ToUpper
                txtobj = report.Section1.ReportObjects.Item("Text28")
                txtobj.Text = cboIMMonth.Text.ToUpper
                txtobj = report.Section1.ReportObjects.Item("Text29")
                txtobj.Text = cboIMYear.Text.ToUpper

                frmReport.CrystalReportViewer1.ReportSource = report
                frmReport.CrystalReportViewer1.Refresh()
                frmReport.ShowDialog()

                DbConnect()
                Dim query As String = "UPDATE certificationreport SET is_print = 'yes' WHERE cr_id = '" & txtimid.Text & "'"
                ExecuteQuery(query)
                DbDisconnect()

                txtIMName.Clear()
                txtIMAge.Clear()
                txtIMAdd.Clear()
                txtIMType.Clear()
                txtIMRequestor.Clear()
                txtIMRelation.Clear()
                txtIMPurpose.Clear()
                panIM.SendToBack()
                panelPay.BringToFront()
                Label1.Enabled = True
                Label3.Enabled = False

                Dim pay As New ucPay
                toPanelMain(pay.Width, pay.Height, pay)

            Else
                Dim report As New crIGM
                Dim txtobj As CrystalDecisions.CrystalReports.Engine.TextObject
                'capname
                txtobj = report.Section1.ReportObjects.Item("Text35")
                txtobj.Text = txtCap.Text.ToUpper

                txtobj = report.Section1.ReportObjects.Item("Text26")
                txtobj.Text = txtIMName.Text.ToUpper + ","
                txtobj = report.Section1.ReportObjects.Item("Text9")
                txtobj.Text = txtIMAge.Text.ToUpper + ","
                txtobj = report.Section1.ReportObjects.Item("Text11")
                txtobj.Text = txtIMAdd.Text.ToUpper
                txtobj = report.Section1.ReportObjects.Item("Text6")
                txtobj.Text = txtIMType.Text.ToUpper

                txtobj = report.Section1.ReportObjects.Item("Text14")
                If txtIMRequestor.Text = "" Then
                    txtobj.Text = txtIMName.Text.ToUpper
                Else
                    txtobj.Text = txtIMRequestor.Text.ToUpper
                End If
                txtobj = report.Section1.ReportObjects.Item("Text15")
                If txtIMRelation.Text = "" Then
                    txtobj.Text = "             "
                Else
                    txtobj.Text = "(" + txtIMRelation.Text.ToUpper + ")"
                End If
                txtobj = report.Section1.ReportObjects.Item("Text17")
                txtobj.Text = txtIMPurpose.Text.ToUpper


                'date issued
                txtobj = report.Section1.ReportObjects.Item("Text20")
                txtobj.Text = cboIMDay.Text.ToUpper
                txtobj = report.Section1.ReportObjects.Item("Text28")
                txtobj.Text = cboIMMonth.Text.ToUpper
                txtobj = report.Section1.ReportObjects.Item("Text29")
                txtobj.Text = cboIMYear.Text.ToUpper

                frmReport.CrystalReportViewer1.ReportSource = report
                frmReport.CrystalReportViewer1.Refresh()
                frmReport.ShowDialog()

                DbConnect()
                Dim query As String = "UPDATE certificationreport SET is_print = 'yes' WHERE cr_id = '" & txtimid.Text & "'"
                ExecuteQuery(query)
                DbDisconnect()

                txtIMName.Clear()
                txtIMAge.Clear()
                txtIMAdd.Clear()
                txtIMType.Clear()
                txtIMRequestor.Clear()
                txtIMRelation.Clear()
                txtIMPurpose.Clear()
                panIM.SendToBack()
                panelPay.BringToFront()
                Label1.Enabled = True
                Label3.Enabled = False
                Dim pay As New ucPay
                toPanelMain(pay.Width, pay.Height, pay)
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub
End Class
