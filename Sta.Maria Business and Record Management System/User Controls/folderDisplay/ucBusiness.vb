Imports MySql.Data.MySqlClient
Public Class ucBusiness
    Private kon As New MySqlConnection("server = '" & frmLogin.txtIP.Text & "'; username = 'root'; password = ''; database='dbstamaria'")
    Dim businessID As String
    Dim ownerID As String
    Private Sub ucBusiness_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLvwBusiness()
        loadOwners()

        cboLine.Items.Add("Business Line")
        cboLine.Items.Add("Streets")
    End Sub

    Sub search(keyword As String)
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwBusiness.Items.Clear()
        Try
            DbConnect()
            Dim query As String = " SELECT  business_id, business_name, street_name, cr_expire, line_name, business_permit  FROM business INNER JOIN streets ON streets.street_id = business.street_id" _
                                & " INNER JOIN businesslines ON businesslines.line_id = business.line_id" _
                                & " WHERE business_name LIKE '" & keyword & "%'" _
                                & " OR business_permit LIKE '" & keyword & "%' OR street_name LIKE '" & keyword & "%'"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwBusiness.Items.Add(reader.GetString("business_id"))
                    lvwBusiness.Items(i).Font = font
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("business_name"))
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("street_name"))
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("line_name"))
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("business_permit"))
                    'lvwBusiness.Items(i).SubItems.Add("Clearance expires on: " + (reader.GetString("cr_expire")))
                    Dim colExpre = reader.GetOrdinal("cr_expire")
                    Dim exp As String = Nothing
                    If Not reader.IsDBNull(colExpre) Then
                        exp = reader.GetString("cr_expire")
                        lvwBusiness.Items(i).SubItems.Add("Clearance expires on: " + (exp))
                    Else
                        Dim none As String = "  "
                        lvwBusiness.Items(i).SubItems.Add(none)
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

    Sub sort(keyword As String)
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwBusiness.Items.Clear()
        Try
            DbConnect()
            Dim query As String = " SELECT  business_id, business_name, street_name, cr_expire, line_name,business_permit FROM business INNER JOIN streets ON streets.street_id = business.street_id" _
                                & " INNER JOIN businesslines ON businesslines.line_id = business.line_id" _
                                & " WHERE line_name LIKE '" & keyword & "%' or  street_name LIKE '" & keyword & "%'"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwBusiness.Items.Add(reader.GetString("business_id"))
                    lvwBusiness.Items(i).Font = Font
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("business_name"))
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("street_name"))
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("line_name"))
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("business_permit"))
                    ' lvwBusiness.Items(i).SubItems.Add("Clearance expires on: " + (reader.GetString("cr_expire")))
                    Dim colExpre = reader.GetOrdinal("cr_expire")
                    Dim exp As String = Nothing
                    If Not reader.IsDBNull(colExpre) Then
                        exp = reader.GetString("cr_expire")
                        lvwBusiness.Items(i).SubItems.Add("Clearance expires on: " + (exp))
                    Else
                        Dim none As String = "  "
                        lvwBusiness.Items(i).SubItems.Add(none)
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


    Sub loadLvwBusiness()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwBusiness.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT business_id, business_name,street_name, line_name, business_permit,cr_expire  FROM business, businesslines, streets WHERE business.line_id = businesslines.line_id and business.street_id = streets.street_id ORDER by business_name"
            ExecuteQuery(query)

            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwBusiness.Items.Add(reader.GetString("business_id"))
                    lvwBusiness.Items(i).Font = Font
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("business_name"))
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("street_name"))
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("line_name"))
                    lvwBusiness.Items(i).SubItems.Add(reader.GetString("business_permit"))
                    'lvwBusiness.Items(i).SubItems.Add("Clearance expires on: " + (reader.GetString("cr_expire")))

                    Dim colExpre = reader.GetOrdinal("cr_expire")
                    Dim exp As String = Nothing
                    If Not reader.IsDBNull(colExpre) Then
                        exp = reader.GetString("cr_expire")
                        lvwBusiness.Items(i).SubItems.Add("Clearance expires on: " + (exp))
                    Else
                        Dim none As String = "  "
                        lvwBusiness.Items(i).SubItems.Add(none)
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

    Sub displayBusiness()
        Try
            DbConnect()
            ' Dim query As String = "SELECT business_id, owner_name, owner_address, owner_contact FROM business, businesslines, streets WHERE business.line_id = businesslines.line_id and business.street_id = streets.street_id and business_id = '" & businessID & "'"
            Dim query As String = "SELECT business.business_id, bo_name, bo_sex, bo_address, bo_contact, line_name, street_name, cr_issued, cr_expire FROM business, businesslines, businessowners, streets WHERE business.line_id = businesslines.line_id AND business.street_id = streets.street_id AND business.business_ID = businessowners.business_ID AND business.business_id = '" & businessID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtName.Text = reader.GetString("bo_name")
                    txtAddress.Text = reader.GetString("bo_address")
                    txtContact.Text = reader.GetString("bo_contact")
                    'txtIssued.Text = reader.GetString("cr_issued")
                    'txtExpires.Text = reader.GetString("cr_expire")
                    txtSex.Text = reader.GetString("bo_sex")
                    lbl6.Text = businessID
                    Dim colExpre = reader.GetOrdinal("cr_expire")
                    Dim exp As String = Nothing
                    If Not reader.IsDBNull(colExpre) Then
                        exp = reader.GetString("cr_expire").ToString
                        txtExpires.Text = exp
                    Else
                        txtExpires.Text = ""
                    End If
                    Dim colIssued = reader.GetOrdinal("cr_issued")
                    Dim iss As String = Nothing
                    If Not reader.IsDBNull(colIssued) Then
                        iss = reader.GetString("cr_issued").ToString
                        txtIssued.Text = iss
                    Else
                        txtIssued.Text = ""
                    End If
                    lbl1.Visible = True
                    lbl2.Visible = True
                    lbl3.Visible = True
                    lbl4.Visible = True
                    Label7.Visible = True
                    Label8.Visible = True
                    Label10.Visible = True
                    txtName.Visible = True
                    txtContact.Visible = True
                    txtAddress.Visible = True
                    txtSex.Visible = True
                    txtIssued.Visible = True
                    txtExpires.Visible = True
                    btnExpired.Visible = False

                    If txtExpires.Text = "" Or txtExpires.Text Is Nothing Then
                        btnExpired.Visible = False
                    Else
                        Dim a As Date = txtExpires.Text
                        Dim b = Date.Now
                        If b >= a Then
                            btnExpired.Visible = True
                        Else
                            btnExpired.Visible = False
                        End If
                    End If
                End While
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub loadLine()
        DbConnect()
        Dim query As String = "SELECT * FROM businesslines ORDER BY line_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboLine1.Items.Clear()
            While reader.Read
                cboLine1.Items.Add(reader.GetString(1))
            End While
        End If
        DbDisconnect()
    End Sub

    Sub LoadStreets()
        DbConnect()
        Dim query As String = "SELECT street_name FROM streets ORDER BY street_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboLine1.Items.Clear()
            While reader.Read
                cboLine1.Items.Add(reader.GetString("street_name"))
            End While
        End If
        DbDisconnect()
    End Sub

    Private Sub lvwBusiness_Click(sender As Object, e As EventArgs) Handles lvwBusiness.Click

        If lvwBusiness.SelectedItems.Count > 0 Then
            businessID = lvwBusiness.Items(lvwBusiness.SelectedIndices(0)).Text
            displayBusiness()
        End If
    End Sub

    Private Sub txtSearch_OnValueChanged_1(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        If txtSearch.Text = "" Then
            loadLvwBusiness()
        Else
            search(txtSearch.Text)
        End If
    End Sub

    Private Sub cboLine1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLine1.SelectedIndexChanged
        If cboLine1.Text = "" Then
            loadLvwBusiness()
        Else
            sort(cboLine1.Text)
        End If
    End Sub

    Private Sub cboLine_TextChanged(sender As Object, e As EventArgs) Handles cboLine.TextChanged
        Try
            If cboLine.Text = "Business Line" Then
                loadLine()
                cboLine1.Visible = True
                btnClear.Visible = True
            ElseIf cboLine.Text = "Streets" Then
                LoadStreets()
                cboLine1.Visible = True
                btnClear.Visible = True
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    '=================================================== TAB 2

    Sub loadOwners()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwOwners.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT DISTINCT businessowner_id, bo_name, bo_address, bo_contact FROM businessowners ORDER by bo_name"
            ExecuteQuery(query)

            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwOwners.Items.Add(reader.GetString("businessowner_id"))
                    lvwOwners.Items(i).Font = Font
                    lvwOwners.Items(i).SubItems.Add(reader.GetString("bo_name"))
                    lvwOwners.Items(i).SubItems.Add(reader.GetString("bo_address"))
                    lvwOwners.Items(i).SubItems.Add(reader.GetString("bo_contact"))
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
        Dim font As Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwOwners.Items.Clear()
        Try
            DbConnect()
            Dim query As String = " SELECT DISTINCT businessowner_id, bo_name, bo_address, bo_contact FROM businessowners WHERE bo_name LIKE '" & keyword & "%'"
            '& " OR bo_address LIKE '" & keyword & "%' OR bo_contact LIKE '" & keyword & "%'"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwOwners.Items.Add(reader.GetString("businessowner_id"))
                    lvwOwners.Items(i).Font = font
                    lvwOwners.Items(i).SubItems.Add(reader.GetString("bo_name"))
                    lvwOwners.Items(i).SubItems.Add(reader.GetString("bo_address"))
                    lvwOwners.Items(i).SubItems.Add(reader.GetString("bo_contact"))
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

    Sub loadOwnersBusiness()
        Font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwList.Items.Clear()
        Try
            DbConnect()
            Dim query As String = " SELECT business_name,street_name, line_name FROM business, businesslines, streets, businessowners WHERE business.line_id = businesslines.line_id and business.street_id = streets.street_id AND business.business_id = businessowners.business_id AND businessowner_id ='" & ownerID & "'"
            ExecuteQuery(query)

            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwList.Items.Add(reader.GetString("business_name"))
                    lvwList.Items(i).Font = Font
                    '  lvwList.Items(i).SubItems.Add(reader.GetString("business_name"))
                    lvwList.Items(i).SubItems.Add(reader.GetString("line_name"))
                    lvwList.Items(i).SubItems.Add(reader.GetString("street_name"))
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

    Private Sub lvwOwners_Click(sender As Object, e As EventArgs) Handles lvwOwners.Click
        If lvwOwners.SelectedItems.Count > 0 Then
            ownerID = lvwOwners.Items(lvwOwners.SelectedIndices(0)).Text
            loadOwnersBusiness()
        End If
    End Sub

    Private Sub txtSearchOwner_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearchOwner.OnValueChanged
        If txtSearchOwner.Text = "" Then
            loadOwners()
        Else
            searchOwner(txtSearchOwner.Text)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnClear.Visible = False
        cboLine.Items.Clear()
        cboLine1.Items.Clear()
        cboLine1.Visible = False
        lvwBusiness.Items.Clear()
        loadLvwBusiness()
        cboLine.Items.Add("Business Line")
        cboLine.Items.Add("Streets")
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

    Private Sub txtSearchOwner_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchOwner.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz  "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cboLine.Text = "" Then
            Try
                Dim cmd As MySqlCommand
                Dim adp As New MySqlDataAdapter
                Dim dt As New DataSet
                Dim sql As String

                kon.Open()
                sql = "SELECT business_name, business_permit, line_name, street_name FROM business INNER JOIN streets ON streets.street_id = business.street_id INNER JOIN businesslines ON businesslines.line_id = business.line_id"
                cmd = New MySqlCommand(sql, kon)
                adp.SelectCommand = cmd
                adp.Fill(dt, "Businesslist")

                Dim report As New crBusinesslist
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

        ElseIf cboLine.Text = "Streets" Then
            Try
                Dim cmd As MySqlCommand
                Dim adp As New MySqlDataAdapter
                Dim dt As New DataSet
                Dim sql As String

                kon.Open()
                sql = "SELECT business_name, business_permit, line_name, street_name FROM business INNER JOIN streets ON streets.street_id = business.street_id INNER JOIN businesslines ON businesslines.line_id = business.line_id WHERE street_name = '" & cboLine1.Text.ToString & "'"
                cmd = New MySqlCommand(sql, kon)
                adp.SelectCommand = cmd
                adp.Fill(dt, "Businesslist")

                Dim report As New crBusinesslist
                Dim txtobj As CrystalDecisions.CrystalReports.Engine.TextObject
                txtobj = report.Section1.ReportObjects.Item("Text11")
                txtobj.Text = cboLine1.Text.ToUpper
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

        ElseIf cboLine.Text = "Business Line" Then
            Try
                Dim cmd As MySqlCommand
                Dim adp As New MySqlDataAdapter
                Dim dt As New DataSet
                Dim sql As String

                kon.Open()
                sql = "SELECT business_name, business_permit, line_name, street_name FROM business INNER JOIN streets ON streets.street_id = business.street_id INNER JOIN businesslines ON businesslines.line_id = business.line_id WHERE line_name = '" & cboLine1.Text.ToString & "'"
                cmd = New MySqlCommand(sql, kon)
                adp.SelectCommand = cmd
                adp.Fill(dt, "Businesslist")

                Dim report As New crBusinesslist
                Dim txtobj As CrystalDecisions.CrystalReports.Engine.TextObject
                txtobj = report.Section1.ReportObjects.Item("Text11")
                txtobj.Text = cboLine1.Text.ToUpper
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
End Class
