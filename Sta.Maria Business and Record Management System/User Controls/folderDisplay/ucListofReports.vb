Imports MySql.Data.MySqlClient

Public Class ucListofReports
    Private kon As New MySqlConnection("server = '" & frmLogin.txtIP.Text & "'; username = 'root'; password = ''; database='dbstamaria'")
    Dim certID As String
    Private Sub ucListofReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCertificates()
        loadTotal()
        loadArchive()

        If frmLogin.clerk Then
            Label8.Visible = False
            txtTotalAmnt.Visible = False
            txtTotalAmnt.Text = ""
            Label26.Visible = False
        End If

    End Sub

    Sub loadCertificates()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwList.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT cr_id, cr_issued, cr_type, cr_name FROM certificationreport  ORDER by cr_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwList.Items.Add(reader.GetString("cr_id"))
                    lvwList.Items(i).Font = Font
                    lvwList.Items(i).SubItems.Add(reader.GetString("cr_name"))
                    lvwList.Items(i).SubItems.Add(reader.GetString("cr_type"))
                    lvwList.Items(i).SubItems.Add(reader.GetString("cr_issued"))
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

    Sub displayCert()
        Try
            For z = 0 To lvwList.Items.Count - 1
                If lvwList.Items(z).SubItems(2).Text = "Business Clearance" Then
                    DbConnect()
                    Dim query2 As String = "SELECT cr_id, certificationreport.cr_issued, cr_type, cr_name, cr_total, processed_by, cr_purpose, is_print, business_name FROM certificationreport INNER JOIN business ON certificationreport.business_id = business.business_id WHERE cr_id = '" & certID & "' "
                    ExecuteQuery(query2)
                    If reader.HasRows Then
                        While reader.Read
                            ctrid.Text = reader.GetString("cr_id")
                            If reader.Item("is_print") = "no" Then
                                btnMark.Text = "PRINT"
                                btnMark.ForeColor = Color.DarkGreen
                                btnMark.Cursor = Cursors.Hand
                                btnMark.Visible = True
                            ElseIf reader.Item("is_print") = "yes" Then
                                btnMark.Text = "PRINTED"
                                btnMark.ForeColor = Color.DarkRed
                                btnMark.Cursor = Cursors.Default
                                btnMark.Visible = True
                            Else
                                btnMark.Visible = False
                            End If
                            txtProcessed.Text = reader.GetString("processed_by")
                            txtIssued.Text = reader.GetString("cr_issued")
                            txtTotal.Text = reader.GetString("cr_total")
                            txtPurpose.Text = reader.GetString("cr_purpose")
                            txtResident.Text = reader.GetString("cr_name")
                            txtCertificate.Text = reader.GetString("cr_type")
                            txtBusinessName.Text = reader.GetString("business_name")
                            txtProcessed.Visible = True
                            txtIssued.Visible = True
                            txtTotal.Visible = True
                            txtPurpose.Visible = True
                            txtResident.Visible = True
                            txtCertificate.Visible = True
                            txtBName.Visible = True
                            txtBusinessName.Visible = True

                        End While
                    End If
                    DbDisconnect()

                ElseIf lvwList.Items(z).SubItems(2).Text = "Barangay Clearance" Or lvwList.Items(z).SubItems(2).Text = "Certificate of Indigency" Or lvwList.Items(z).SubItems(2).Text = "Certificate of Good Moral" Then
                    DbConnect()
                    Dim query1 As String = "SELECT cr_id, cr_issued, cr_type, cr_name, cr_total, processed_by, cr_purpose, is_print FROM certificationreport WHERE cr_id = '" & certID & "' "
                    ExecuteQuery(query1)
                    If reader.HasRows Then
                        While reader.Read
                            ctrid.Text = reader.GetString("cr_id")
                            If reader.Item("is_print") = "no" Then
                                btnMark.Text = "PRINT"
                                btnMark.ForeColor = Color.DarkGreen
                                btnMark.Cursor = Cursors.Hand
                                btnMark.Visible = True
                            ElseIf reader.Item("is_print") = "yes" Then
                                btnMark.Text = "PRINTED"
                                btnMark.ForeColor = Color.DarkRed
                                btnMark.Cursor = Cursors.Default
                                btnMark.Visible = True
                            Else
                                btnMark.Visible = False
                            End If
                            txtProcessed.Text = reader.GetString("processed_by")
                            txtIssued.Text = reader.GetString("cr_issued")
                            txtTotal.Text = reader.GetString("cr_total")
                            txtPurpose.Text = reader.GetString("cr_purpose")
                            txtResident.Text = reader.GetString("cr_name")
                            txtCertificate.Text = reader.GetString("cr_type")
                            txtProcessed.Visible = True
                            txtIssued.Visible = True
                            txtTotal.Visible = True
                            txtPurpose.Visible = True
                            txtResident.Visible = True
                            txtCertificate.Visible = True
                            txtBusinessName.Visible = False
                            txtBName.Visible = False
                        End While
                    End If
                    DbDisconnect()

                End If
            Next
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub lvwList_Click(sender As Object, e As EventArgs) Handles lvwList.Click
        If lvwList.SelectedItems.Count > 0 Then
            certID = lvwList.Items(lvwList.SelectedIndices(0)).Text
            displayCert()
        End If
    End Sub

    Private Declare Function HideCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean
    Private Sub txtPurpose_GotFocus(sender As Object, e As EventArgs) Handles txtPurpose.GotFocus
        HideCaret(txtPurpose.Handle)
    End Sub

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        If txtSearch.Text = "" Then
            loadCertificates()
        Else
            search(txtSearch.Text)
        End If
    End Sub

    Sub search(keyword As String)
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwList.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT cr_id, cr_issued, cr_type, cr_name FROM certificationreport WHERE cr_id LIKE '" & keyword & "%' OR cr_name LIKE '" & keyword & "%'"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwList.Items.Add(reader.GetString("cr_id"))
                    lvwList.Items(i).Font = font
                    lvwList.Items(i).SubItems.Add(reader.GetString("cr_name"))
                    lvwList.Items(i).SubItems.Add(reader.GetString("cr_type"))
                    lvwList.Items(i).SubItems.Add(reader.GetString("cr_issued"))
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

    Private Sub cboSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSort.SelectedIndexChanged
        If cboSort.Text = "" Then
            loadCertificates()
        Else
            sort(cboSort.Text)
        End If
    End Sub

    Sub sort(keyword As String)
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwList.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT cr_id, cr_issued, cr_type, cr_name FROM certificationreport WHERE cr_type LIKE '" & keyword & "%'"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwList.Items.Add(reader.GetString("cr_id"))
                    lvwList.Items(i).Font = font
                    lvwList.Items(i).SubItems.Add(reader.GetString("cr_name"))
                    lvwList.Items(i).SubItems.Add(reader.GetString("cr_type"))
                    lvwList.Items(i).SubItems.Add(reader.GetString("cr_issued"))
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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboSort.Items.Clear()
        lvwList.Items.Clear()
        loadCertificates()
        cboSort.Items.Add("Barangay Clearance")
        cboSort.Items.Add("Business Clearance")
        cboSort.Items.Add("Certificates of Indigency")
        cboSort.Items.Add("Certificates of Good Moral")
    End Sub

    '=============================== Tab2

    Sub loadTotal()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwIssued.Items.Clear()
        Try
            Dim df As Date = dpFrom.Value
            Dim dt As Date = dpTo.Value
            Dim datu As Date

            txtTotalAmnt.ResetText()
            DbConnect()
            Dim query As String = "SELECT cr_id, cr_type, cr_name, cr_purpose, cr_issued, processed_by, cr_total FROM certificationreport ORDER by cr_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    datu = reader.GetString("cr_issued")
                    If DateTime.Compare(Format(datu, "MM-dd-yyyy"), Format(df, "MM-dd-yyyy")) >= 0 And DateTime.Compare(Format(datu, "MM-dd-yyyy"), Format(dt, "MM-dd-yyyy")) <= 0 Then
                        lvwIssued.Items.Add(reader.GetString("cr_id"))
                        lvwIssued.Items(i).Font = Font
                        lvwIssued.Items(i).SubItems.Add(reader.GetString("cr_name"))
                        lvwIssued.Items(i).SubItems.Add(reader.GetString("cr_type"))
                        lvwIssued.Items(i).SubItems.Add(reader.GetString("cr_purpose"))
                        lvwIssued.Items(i).SubItems.Add(reader.GetString("cr_issued"))
                        lvwIssued.Items(i).SubItems.Add(reader.GetString("processed_by"))
                        lvwIssued.Items(i).SubItems.Add(reader.GetString("cr_total"))
                        txtTotalAmnt.Text = Val(txtTotalAmnt.Text) + Val(reader.GetString("cr_total"))
                        i += 1
                    End If
                End While
            End If
            DbDisconnect()

            txtTotalAmnt.Text = Format(Val(txtTotalAmnt.Text), "0.00")
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
        If lvwIssued.Items.Count = 0 Then
            txtTotalAmnt.Text = "0.00"
        End If
    End Sub

    Private Sub dpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dpFrom.ValueChanged
        loadTotal()
    End Sub

    Private Sub dpTo_ValueChanged(sender As Object, e As EventArgs) Handles dpTo.ValueChanged
        loadTotal()
    End Sub


    Private Sub cboSortt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSortt.SelectedIndexChanged
        If cboSortt.Text = "" Then
            loadTotal()
        Else
            sortt(cboSortt.Text)
        End If
    End Sub

    Sub sortt(keyword As String)
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwIssued.Items.Clear()
        Try
            Dim df As Date = dpFrom.Value
            Dim dt As Date = dpTo.Value
            Dim datu As Date

            txtTotalAmnt.ResetText()
            DbConnect()
            Dim query As String = "SELECT cr_id, cr_type, cr_name, cr_purpose, cr_issued, processed_by, cr_total FROM certificationreport WHERE cr_type LIKE '" & keyword & "%'"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    datu = reader.GetString("cr_issued")
                    If DateTime.Compare(Format(datu, "MM-dd-yyyy"), Format(df, "MM-dd-yyyy")) >= 0 And DateTime.Compare(Format(datu, "MM-dd-yyyy"), Format(dt, "MM-dd-yyyy")) <= 0 Then
                        lvwIssued.Items.Add(reader.GetString("cr_id"))
                        lvwIssued.Items(i).Font = Font
                        lvwIssued.Items(i).SubItems.Add(reader.GetString("cr_name"))
                        lvwIssued.Items(i).SubItems.Add(reader.GetString("cr_type"))
                        lvwIssued.Items(i).SubItems.Add(reader.GetString("cr_purpose"))
                        lvwIssued.Items(i).SubItems.Add(reader.GetString("cr_issued"))
                        lvwIssued.Items(i).SubItems.Add(reader.GetString("processed_by"))
                        lvwIssued.Items(i).SubItems.Add(reader.GetString("cr_total"))
                        txtTotalAmnt.Text = Val(txtTotalAmnt.Text) + Val(reader.GetString("cr_total"))
                        i += 1
                    End If
                End While
            End If
            DbDisconnect()

            txtTotalAmnt.Text = Format(Val(txtTotalAmnt.Text), "0.00")
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
        If lvwIssued.Items.Count = 0 Then
            txtTotalAmnt.Text = "0.00"
        End If
    End Sub

    Private Sub btnClearr_Click(sender As Object, e As EventArgs) Handles btnClearr.Click
        cboSortt.Items.Clear()
        lvwIssued.Items.Clear()
        loadTotal()
        cboSortt.Items.Add("Barangay Clearance")
        cboSortt.Items.Add("Business Clearance")
        cboSortt.Items.Add("Certificate of Indigency")
        cboSortt.Items.Add("Certificate of Good Moral")
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

    Private Sub btnMark_Click(sender As Object, e As EventArgs) Handles btnMark.Click
        If txtCertificate.Text = "Business Clearance" And btnMark.Text = "PRINT" Then
            Try
                DbConnect()
                Dim query As String = "SELECT cr_id, cr_purpose, cr_issued, bo_name, bo_sex, bo_address, certificationreport.business_id FROM certificationreport INNER JOIN businessowners ON certificationreport.businessowner_id = businessowners.businessowner_id WHERE cr_id='" & ctrid.Text & "'"
                ExecuteQuery(query)
                If reader.HasRows Then
                    While reader.Read
                        frmReprint.txtbusid.Text = reader.GetString("business_id")
                        frmReprint.txtbid.Text = reader.GetString("cr_id")
                        frmReprint.txtd.Text = reader.GetString("cr_issued")
                        frmReprint.txtBOname.Text = reader.GetString("bo_name")
                        frmReprint.txtBOAddress.Text = reader.GetString("bo_address")
                        If reader.GetString("bo_sex") = "Male" Then
                            frmReprint.radBOM.Checked = True
                        ElseIf reader.GetString("bo_sex") = "Female" Then
                            frmReprint.radBOF.Checked = True
                        End If
                        If reader.GetString("cr_purpose") = "New application" Then
                            frmReprint.radBNew.Checked = True
                        ElseIf reader.GetString("cr_purpose") = "Re-new application" Then
                            frmReprint.radBRenew.Checked = True
                        End If

                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim query1 As String = "SELECT business_name, street_name, line_name FROM business INNER JOIN streets ON business.street_id = streets.street_id INNER JOIN businesslines ON businesslines.line_id = business.line_id WHERE business_id ='" & frmReprint.txtbusid.Text & "'"

                ExecuteQuery(query1)
                If reader.HasRows Then
                    While reader.Read
                        frmReprint.txtBName.Text = reader.GetString("business_name")
                        frmReprint.txtBAddress.Text = reader.GetString("street_name")
                        frmReprint.txtBLine.Text = reader.GetString("line_name")
                    End While
                    Dim bDay = DateAndTime.Today.ToString("dd")
                    frmReprint.cboBDay.Text = bDay
                    Dim bMonth = DateAndTime.Today.ToString("MMMM")
                    frmReprint.cboBMonth.Text = bMonth
                    Dim bYear = DateAndTime.Today.ToString("yyyy")
                    frmReprint.cboBYear.Text = bYear
                    frmReprint.txtBOAge.Focus()
                End If
                DbDisconnect()

                frmReprint.panelPrintBusiness.Visible = True
                frmReprint.panelPrint.Visible = False
                frmReprint.panIM.Visible = False
                frmReprint.ShowDialog()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                DisposeConnection()
            End Try

        ElseIf txtCertificate.Text = "Certificate of Indigency" And btnMark.Text = "PRINT" Then
            Try
                DbConnect()
                Dim query As String = "SELECT cr_id, cr_purpose, cr_type, res_name, res_sex, street_name FROM certificationreport INNER JOIN residence ON certificationreport.res_id = residence.res_id INNER JOIN streets ON residence.street_ID = streets.street_ID WHERE cr_id='" & ctrid.Text & "'"
                ExecuteQuery(query)
                If reader.HasRows Then
                    While reader.Read
                        frmReprint.txtimid.Text = reader.GetString("cr_id")
                        frmReprint.txtIMType.Text = reader.GetString("cr_type")
                        frmReprint.txtIMName.Text = reader.GetString("res_name")
                        frmReprint.txtIMAdd.Text = reader.GetString("street_name")
                        frmReprint.txtIMPurpose.Text = reader.GetString("cr_purpose")
                        If reader.GetString("res_sex") = "Male" Then
                            frmReprint.radIMm.Checked = True
                        ElseIf reader.GetString("res_sex") = "Female" Then
                            frmReprint.radIMf.Checked = True
                        End If
                    End While
                    Dim imDay = DateAndTime.Today.ToString("dd")
                    frmReprint.cboIMDay.Text = imDay
                    Dim imMonth = DateAndTime.Today.ToString("MMMM")
                    frmReprint.cboIMMonth.Text = imMonth
                    Dim imYear = DateAndTime.Today.ToString("yyyy")
                    frmReprint.cboIMYear.Text = imYear
                End If
                frmReprint.txtIMAge.Focus()
                DbDisconnect()

                frmReprint.panIM.Visible = True
                frmReprint.panelPrint.Visible = False
                frmReprint.panelPrintBusiness.Visible = False
                frmReprint.ShowDialog()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                DisposeConnection()
            End Try

        ElseIf txtCertificate.Text = "Certificate of Good Moral" And btnMark.Text = "PRINT" Then
            Try
                DbConnect()
                Dim query As String = "SELECT cr_id, cr_purpose, cr_type, res_name, res_sex, street_name FROM certificationreport INNER JOIN residence ON certificationreport.res_id = residence.res_id INNER JOIN streets ON residence.street_ID = streets.street_ID WHERE cr_id='" & ctrid.Text & "'"
                ExecuteQuery(query)
                If reader.HasRows Then
                    While reader.Read
                        frmReprint.txtimid.Text = reader.GetString("cr_id")
                        frmReprint.txtIMType.Text = reader.GetString("cr_type")
                        frmReprint.txtIMName.Text = reader.GetString("res_name")
                        frmReprint.txtIMAdd.Text = reader.GetString("street_name")
                        frmReprint.txtIMPurpose.Text = reader.GetString("cr_purpose")
                        If reader.GetString("res_sex") = "Male" Then
                            frmReprint.radIMm.Checked = True
                        ElseIf reader.GetString("res_sex") = "Female" Then
                            frmReprint.radIMf.Checked = True
                        End If
                    End While
                    Dim imDay = DateAndTime.Today.ToString("dd")
                    frmReprint.cboIMDay.Text = imDay
                    Dim imMonth = DateAndTime.Today.ToString("MMMM")
                    frmReprint.cboIMMonth.Text = imMonth
                    Dim imYear = DateAndTime.Today.ToString("yyyy")
                    frmReprint.cboIMYear.Text = imYear
                End If
                frmReprint.txtIMAge.Focus()
                DbDisconnect()

                frmReprint.panIM.Visible = True
                frmReprint.panelPrint.Visible = False
                frmReprint.panelPrintBusiness.Visible = False
                frmReprint.ShowDialog()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                DisposeConnection()
            End Try

        ElseIf txtCertificate.Text = "Barangay Clearance" And btnMark.Text = "PRINT" Then
            Try
                DbConnect()
                Dim query As String = "SELECT cr_id, cr_purpose, res_name, res_sex, res_bdate, res_nationality, res_status, street_name FROM certificationreport INNER JOIN residence ON certificationreport.res_id = residence.res_id INNER JOIN streets ON residence.street_ID = streets.street_ID WHERE cr_id='" & ctrid.Text & "'"
                ExecuteQuery(query)
                If reader.HasRows Then
                    While reader.Read
                        frmReprint.txtrid.Text = reader.GetString("cr_id")
                        frmReprint.txtRName.Text = reader.GetString("res_name")
                        frmReprint.txtRAddress.Text = reader.GetString("street_name")
                        frmReprint.txtRBday.Text = reader.GetString("res_bdate")
                        frmReprint.txtRNationality.Text = reader.GetString("res_nationality")
                        frmReprint.txtRCS.Text = reader.GetString("res_status")
                        If reader.GetString("res_sex") = "Male" Then
                            frmReprint.radRm.Checked = True
                        ElseIf reader.GetString("res_sex") = "Female" Then
                            frmReprint.radRf.Checked = True
                        End If
                        If reader.GetString("cr_purpose") = "Police Clearance" Then
                            frmReprint.radRPolice.Checked = True
                        ElseIf reader.GetString("cr_purpose") = "N.B.I. Clearance" Then
                            frmReprint.radRNBI.Checked = True
                        ElseIf reader.GetString("cr_purpose") = "B.I.R. (TIN)" Then
                            frmReprint.radRBIR.Checked = True
                        ElseIf reader.GetString("cr_purpose") = "Employment" Then
                            frmReprint.radREmployment.Checked = True
                        ElseIf reader.GetString("cr_purpose") = "School Requirements" Then
                            frmReprint.radRSchool.Checked = True
                        Else
                            frmReprint.radROthers.Checked = True
                            frmReprint.txtRSpecify.Text = reader.GetString("cr_purpose")
                            frmReprint.txtRSpecify.Visible = True
                            frmReprint.txtRSpecify.Enabled = True
                        End If
                        Dim rDay = DateAndTime.Today.ToString("dd")
                        frmReprint.cboRDay.Text = rDay
                        Dim rMonth = DateAndTime.Today.ToString("MMMM")
                        frmReprint.cboRMonth.Text = rMonth
                        Dim rYear = DateAndTime.Today.ToString("yyyy")
                        frmReprint.cboRYear.Text = rYear
                    End While
                End If
                frmReprint.txtRAge.Focus()
                DbDisconnect()
                frmReprint.panelPrint.Visible = True
                frmReprint.panelPrintBusiness.Visible = False
                frmReprint.panIM.Visible = False
                frmReprint.ShowDialog()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                DisposeConnection()
            End Try
        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If cboSortt.Text = "" Then
            Try
                Dim cmd As MySqlCommand
                Dim adp As New MySqlDataAdapter
                Dim dt As New DataSet
                Dim sql As String
                Dim dfr As Date = dpFrom.Value
                Dim dto As Date = dpTo.Value

                kon.Open()
                sql = "SELECT cr_id, cr_type, cr_name, cr_purpose, cr_total, cr_issued FROM certificationreport WHERE cr_issued BETWEEN '" & Format(dfr, "MM-dd-yyyy") & "' AND '" & Format(dto, "MM-dd-yyyy") & "'"
                cmd = New MySqlCommand(sql, kon)
                adp.SelectCommand = cmd
                adp.Fill(dt, "certificationreport")

                Dim report As New crCertilist
                Dim txtobj As CrystalDecisions.CrystalReports.Engine.TextObject
                txtobj = report.Section1.ReportObjects.Item("Text15")
                txtobj.Text = txtTotalAmnt.Text.ToUpper

                txtobj = report.Section1.ReportObjects.Item("Text17")
                txtobj.Text = Format(dfr, "MM-dd-yyyy")
                txtobj = report.Section1.ReportObjects.Item("Text19")
                txtobj.Text = Format(dto, "MM-dd-yyyy")

                report.SetDataSource(dt)
                frmReport.CrystalReportViewer1.ReportSource = report
                frmReport.CrystalReportViewer1.Refresh()
                cmd.Dispose()
                adp.Dispose()
                dt.Dispose()
                kon.Close()

                frmReport.ShowDialog()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                kon.Close()
            End Try
        Else
            Try
                Dim type As String = cboSortt.Text
                Dim cmd As MySqlCommand
                Dim adp As New MySqlDataAdapter
                Dim dt As New DataSet
                Dim sql As String
                Dim dfr As Date = dpFrom.Value
                Dim dto As Date = dpTo.Value

                kon.Open()
                sql = "SELECT cr_id, cr_type, cr_name, cr_purpose, cr_total, cr_issued FROM certificationreport WHERE cr_type = '" & type & "' AND cr_issued BETWEEN '" & Format(dfr, "MM-dd-yyyy") & "' AND '" & Format(dto, "MM-dd-yyyy") & "'"
                cmd = New MySqlCommand(sql, kon)
                adp.SelectCommand = cmd
                adp.Fill(dt, "certificationreport")



                Dim report As New crCertilist
                Dim txtobj As CrystalDecisions.CrystalReports.Engine.TextObject
                txtobj = report.Section1.ReportObjects.Item("Text15")
                txtobj.Text = txtTotalAmnt.Text.ToUpper
                txtobj = report.Section1.ReportObjects.Item("Text12")
                txtobj.Text = type.ToUpper

                txtobj = report.Section1.ReportObjects.Item("Text17")
                txtobj.Text = Format(dfr, "MM-dd-yyyy")
                txtobj = report.Section1.ReportObjects.Item("Text19")
                txtobj.Text = Format(dto, "MM-dd-yyyy")

                report.SetDataSource(dt)
                frmReport.CrystalReportViewer1.ReportSource = report
                frmReport.CrystalReportViewer1.Refresh()
                cmd.Dispose()
                adp.Dispose()
                dt.Dispose()
                kon.Close()

                frmReport.ShowDialog()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                kon.Close()
            End Try
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If frmLogin.captain Or frmLogin.secretary Then
            If Trim(txtReason.Text) = "" Then
                MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return
            Else
                Dim a = txtReason.Text
                frmConfirm.txtPurp.Text = a
                frmConfirm.ShowDialog()
            End If

        ElseIf frmLogin.clerk Then
            MetroFramework.MetroMessageBox.Show(Me, "
You do not have enough Access Privileges.", "UNAUTHORIZED ACCESS!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Sub loadArchive()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwArchive.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT cc_id,cc_purpose, cc_by,cc_date FROM certificationclear ORDER BY cc_ID DESC "
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwArchive.Items.Add(reader.GetString("cc_id"))
                    lvwArchive.Items(i).Font = Font
                    lvwArchive.Items(i).SubItems.Add(reader.GetString("cc_purpose"))
                    lvwArchive.Items(i).SubItems.Add(reader.GetString("cc_by"))
                    lvwArchive.Items(i).SubItems.Add(reader.GetString("cc_date"))
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

End Class
