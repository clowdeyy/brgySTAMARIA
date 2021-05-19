Imports MySql.Data.MySqlClient
Public Class ucHousehold
    Private kon As New MySqlConnection("server = '" & frmLogin.txtIP.Text & "'; username = 'root'; password = ''; database='dbstamaria'")
    Dim id As String
    Dim hh As String

    Private Sub ucHousehold_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadHousehold()
        loadType()
    End Sub

    Private Sub lvwHousehold_Click(sender As Object, e As EventArgs) Handles lvwHousehold.Click

        If lvwHousehold.SelectedItems.Count > 0 Then
            Try
                hh = lvwHousehold.Items(lvwHousehold.SelectedIndices(0)).Text
                loadMembers()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                DisposeConnection()
            End Try
        End If
    End Sub

    Sub loadHousehold()
        Dim fonts As Font
        fonts = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwHousehold.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT household.hh_id, hh_type, hh_staytype, res_name, res_order, street_name, is_deceased FROM residence,household,streets WHERE household.street_id = streets.street_ID AND residence.hh_id = household.hh_id AND res_order = 'Head' ORDER by hh_id"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    If reader.GetString("is_deceased") = "yes" Then
                        lvwHousehold.Items.Add(reader.GetString("hh_ID"))
                        lvwHousehold.Items(i).Font = fonts
                        lvwHousehold.Items(i).Font = New Font(lvwHousehold.Items(i).Font, lvwHousehold.Items(i).Font.Style Or FontStyle.Strikeout)
                        lvwHousehold.Items(i).ForeColor = Color.Maroon
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("hh_type"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("res_name"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("hh_staytype"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("street_name"))
                    Else
                        lvwHousehold.Items.Add(reader.GetString("hh_ID"))
                        lvwHousehold.Items(i).Font = font
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("hh_type"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("res_name"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("hh_staytype"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("street_name"))
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
        lvwMembers.Items.Clear()
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
                        lvwMembers.Items.Add(reader.GetString("res_id"))
                        lvwMembers.Items(i).Font = font
                        lvwMembers.Items(i).Font = New Font(lvwMembers.Items(i).Font, lvwMembers.Items(i).Font.Style Or FontStyle.Strikeout)
                        lvwMembers.Items(i).ForeColor = Color.Maroon
                        lvwMembers.Items(i).SubItems.Add(reader.GetString("res_name"))
                        lvwMembers.Items(i).SubItems.Add(reader.GetString("res_order"))
                        lvwMembers.Items(i).SubItems.Add(reader.GetString("res_sex"))
                        lvwMembers.Items(i).SubItems.Add(reader.GetString("res_bdate"))
                    Else
                        lvwMembers.Items.Add(reader.GetString("res_id"))
                        lvwMembers.Items(i).Font = font
                        lvwMembers.Items(i).SubItems.Add(reader.GetString("res_name"))
                        lvwMembers.Items(i).SubItems.Add(reader.GetString("res_order"))
                        lvwMembers.Items(i).SubItems.Add(reader.GetString("res_sex"))
                        lvwMembers.Items(i).SubItems.Add(reader.GetString("res_bdate"))
                    End If
                    i += 1
                End While
            End If
            DbDisconnect()

            DbConnect()
            query = "SELECT household.hh_id, hh_type, hh_staytype, street_name, res_name, res_order FROM residence, household, streets WHERE household.hh_id = '" & hh & "' AND household.street_id = streets.street_ID AND residence.hh_id = household.hh_id AND res_order ='Head'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtHouseID.Text = reader.GetString("hh_id")
                    txtHouseType.Text = reader.GetString("hh_type")
                    txtHouseHead.Text = reader.GetString("res_name")
                    txtAddress.Text = reader.GetString("street_name")
                End While
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub sort(keyword As String)
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwHousehold.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT household.hh_id, hh_type, hh_staytype, res_name, res_order, street_name, is_deceased FROM residence INNER JOIN household ON residence.hh_id = household.hh_id INNER JOIN streets ON residence.street_id = streets.street_id WHERE res_order = 'Head' AND hh_type LIKE '" & keyword & "%'"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    If reader.GetString("is_deceased") = "yes" Then
                        lvwHousehold.Items.Add(reader.GetString("hh_ID"))
                        lvwHousehold.Items(i).Font = font
                        lvwHousehold.Items(i).Font = New Font(lvwHousehold.Items(i).Font, lvwHousehold.Items(i).Font.Style Or FontStyle.Strikeout)
                        lvwHousehold.Items(i).ForeColor = Color.Maroon
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("hh_type"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("res_name"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("hh_staytype"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("street_name"))
                    Else
                        lvwHousehold.Items.Add(reader.GetString("hh_ID"))
                        lvwHousehold.Items(i).Font = font
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("hh_type"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("res_name"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("hh_staytype"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("street_name"))
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

    Sub search(keyword As String)
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwHousehold.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT household.hh_id, hh_type, hh_staytype, res_name, res_order, street_name, is_deceased FROM residence,household,streets WHERE household.street_id = streets.street_ID AND residence.hh_id = household.hh_id AND res_order = 'Head'" _
                                    & " AND res_name LIKE '" & keyword & "%'"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    If reader.GetString("is_deceased") = "yes" Then
                        lvwHousehold.Items.Add(reader.GetString("hh_ID"))
                        lvwHousehold.Items(i).Font = font
                        lvwHousehold.Items(i).Font = New Font(lvwHousehold.Items(i).Font, lvwHousehold.Items(i).Font.Style Or FontStyle.Strikeout)
                        lvwHousehold.Items(i).ForeColor = Color.Red
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("hh_type"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("res_name"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("hh_staytype"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("street_name"))
                    Else
                        lvwHousehold.Items.Add(reader.GetString("hh_ID"))
                        lvwHousehold.Items(i).Font = font
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("hh_type"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("res_name"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("hh_staytype"))
                        lvwHousehold.Items(i).SubItems.Add(reader.GetString("street_name"))
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

    Sub loadType()
        DbConnect()
        Dim query As String = "SELECT hht_id, hht_name FROM householdtype ORDER BY hht_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboSort.Items.Clear()
            While reader.Read
                cboSort.Items.Add(reader.GetString(1))
            End While
        End If
        DbDisconnect()
    End Sub


    Private Sub cboSort_TextChanged(sender As Object, e As EventArgs) Handles cboSort.TextChanged
        If cboSort.Text = "" Then
            loadHousehold()
        Else
            sort(cboSort.Text)
        End If
    End Sub


    Private Sub lvwMembers_DoubleClick(sender As Object, e As EventArgs) Handles lvwMembers.DoubleClick
        If lvwMembers.SelectedIndices.Count > 0 Then
            searchresid = lvwMembers.Items(lvwMembers.SelectedIndices(0)).Text
            'lvwMembers.SelectedIndices.Clear()

            Dim res As New ucResidence
            toPanelMain(res.Width, res.Height, res)

            For I As Integer = 0 To res.lvwResidence.Items.Count - 1
                If res.lvwResidence.Items(I).Text = searchresid Then
                    res.lvwResidence.Items(I).Selected = True
                    res.lvwResidence.Items(I).EnsureVisible()
                    res.lvwResidence.Select()
                    res.displayResidence()
                End If
            Next
        End If
    End Sub


    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        If txtSearch.Text = "" Then
            loadHousehold()
        Else
            search(txtSearch.Text)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboSort.Items.Clear()
        lvwHousehold.Items.Clear()
        loadHousehold()
        cboSort.Visible = True
        loadType()
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

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If cboSort.Text = "" Then
            Try
                Dim cmd As MySqlCommand
                Dim adp As New MySqlDataAdapter
                Dim dt As New DataSet
                Dim sql As String

                kon.Open()
                sql = "SELECT household.hh_id, res_name, res_sex, street_name FROM residence INNER JOIN household ON residence.hh_id = household.hh_id INNER JOIN streets ON streets.street_id = household.street_id"
                cmd = New MySqlCommand(sql, kon)
                adp.SelectCommand = cmd
                adp.Fill(dt, "householdlist")

                Dim report As New crHouseholdList
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
                Dim cmd As MySqlCommand
                Dim adp As New MySqlDataAdapter
                Dim dt As New DataSet
                Dim sql As String

                kon.Open()
                sql = "SELECT household.hh_id, res_name, res_sex, street_name FROM residence INNER JOIN household ON residence.hh_id = household.hh_id INNER JOIN streets ON streets.street_id = household.street_id WHERE hh_type = '" & cboSort.Text.ToString & "'"
                cmd = New MySqlCommand(sql, kon)
                adp.SelectCommand = cmd
                adp.Fill(dt, "householdlist")

                Dim report As New crHouseholdList
                Dim txtobj As CrystalDecisions.CrystalReports.Engine.TextObject
                txtobj = report.Section1.ReportObjects.Item("Text12")
                txtobj.Text = cboSort.Text.ToUpper
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
