Public Class frmReprint
    Private Sub frmReprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Dispose()
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
            Me.Dispose()
            Dim lor As New ucListofReports
            toPanelMain(lor.Width, lor.Height, lor)
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
                Me.Dispose()
                Dim lor As New ucListofReports
                toPanelMain(lor.Width, lor.Height, lor)
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

                Me.Dispose()
                Dim lor As New ucListofReports
                toPanelMain(lor.Width, lor.Height, lor)
            End If

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
            Me.Dispose()
            Dim lor As New ucListofReports
            toPanelMain(lor.Width, lor.Height, lor)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub txtRAge_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRAge.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnRPrint_Click(sender, e)
        End If
    End Sub


    Private Sub txtBOAge_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBOAge.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBPrint_Click(sender, e)
        End If
    End Sub

    Private Sub txtIMAge_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIMAge.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnIMPrint_Click(sender, e)
        End If
    End Sub
End Class