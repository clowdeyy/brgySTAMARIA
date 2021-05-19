Imports System.IO
Public Class ucDashboard

    Private Sub ucDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSteetsR()
        loadSteetsB()
        loadSteetsH()
        loadLine()
    End Sub

    Private Sub btnOfficials_Click(sender As Object, e As EventArgs)
        Dim off As New ucAddOfficials
        toPanelMain(off.Width, off.Height, off)
    End Sub

    Private Declare Function HideCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean
    Private Sub txtMale_GotFocus(sender As Object, e As EventArgs) Handles txtMale.GotFocus
        HideCaret(txtMale.Handle)
    End Sub

    Private Sub txtFemale_GotFocus(sender As Object, e As EventArgs) Handles txtFemale.GotFocus
        HideCaret(txtFemale.Handle)
    End Sub

    Private Sub txtVoter_GotFocus(sender As Object, e As EventArgs) Handles txtVoter.GotFocus
        HideCaret(txtVoter.Handle)
    End Sub

    Private Sub txtNonvoter_GotFocus(sender As Object, e As EventArgs) Handles txtNonvoter.GotFocus
        HideCaret(txtNonvoter.Handle)
    End Sub

    Private Sub txtHousehold_GotFocus(sender As Object, e As EventArgs) Handles txtHousehold.GotFocus
        HideCaret(txtHousehold.Handle)
    End Sub

    Private Sub txtBusiness_GotFocus(sender As Object, e As EventArgs) Handles txtBusiness.GotFocus
        HideCaret(txtBusiness.Handle)
    End Sub

    Private Sub txtTotal_GotFocus(sender As Object, e As EventArgs) Handles txtTotal.GotFocus
        HideCaret(txtTotal.Handle)
    End Sub

    '==== /1

    Sub loadSteetsR()
        DbConnect()
        Dim query As String = "SELECT street_name FROM streets ORDER BY street_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboAreaR.Items.Clear()
            While reader.Read
                cboAreaR.Items.Add(reader.GetString("street_name"))
            End While
        End If
        DbDisconnect()
    End Sub

    Sub loadResidentType()
        cboBy.Items.Clear()
        cboBy.Items.Add("Voter")
        cboBy.Items.Add("Non-Voter")
    End Sub

    Sub loadHouseholdType()
        cboBy.Items.Clear()
        cboBy.Items.Add("Couple w/ children")
        cboBy.Items.Add("Couple w/o children")
        cboBy.Items.Add("One-parent family")
        cboBy.Items.Add("Other family")
        cboBy.Items.Add("Lone Person")
        cboBy.Items.Add("Other non-classified")
    End Sub

    Sub loadCivilStatus()
        cboBy.Items.Clear()
        cboBy.Items.Add("Single")
        cboBy.Items.Add("Married")
        cboBy.Items.Add("Widowed")
        cboBy.Items.Add("Annuled")
        cboBy.Items.Add("Divorced")
    End Sub

    Sub loadGender()
        cboBy.Items.Clear()
        cboBy.Items.Add("Male")
        cboBy.Items.Add("Female")
    End Sub
    Private Sub cboCount_TextChanged(sender As Object, e As EventArgs) Handles cboCount.TextChanged
        Try
            If cboCount.Text = "Resident Type" Then
                loadResidentType()
            ElseIf cboCount.Text = "Civil Status" Then
                loadCivilStatus()
            ElseIf cboCount.Text = "Gender" Then
                loadGender()
            ElseIf cboCount.Text = "Household Type" Then
                loadHouseholdType()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub countR()

    End Sub

    '==== /2
    Sub loadSteetsB()
        DbConnect()
        Dim query As String = "SELECT street_name FROM streets ORDER BY street_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboAreaB.Items.Clear()
            While reader.Read
                cboAreaB.Items.Add(reader.GetString("street_name"))
            End While
        End If
        DbDisconnect()
    End Sub

    Sub loadLine()
        DbConnect()
        Dim query As String = "SELECT * FROM businesslines ORDER BY line_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboCountB.Items.Clear()
            While reader.Read
                cboCountB.Items.Add(reader.GetString(1))
            End While
        End If
        DbDisconnect()
    End Sub

    Sub countB()

    End Sub

    '=== /3
    Sub loadSteetsH()
        DbConnect()
        Dim query As String = "SELECT street_name FROM streets ORDER BY street_name"
        ExecuteQuery(query)
        If reader.HasRows Then
            cboAreaH.Items.Clear()
            While reader.Read
                cboAreaH.Items.Add(reader.GetString("street_name"))
            End While
        End If
        DbDisconnect()
    End Sub

    Private Sub ucDisaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DbConnect()
            Dim query As String = " SELECT COUNT(*) FROM residence WHERE res_sex = 'Male' "
            ExecuteQueryParameter(query)
            Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
            txtMale.Text = count.ToString()
            DbDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            DbConnect()
            Dim query As String = " SELECT COUNT(*) FROM residence WHERE res_sex = 'Female' "
            ExecuteQueryParameter(query)
            Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
            txtFemale.Text = count.ToString()
            DbDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            DbConnect()
            Dim query As String = " SELECT COUNT(*) FROM residence WHERE res_type = 'Voter' "
            ExecuteQueryParameter(query)
            Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
            txtVoter.Text = count.ToString()
            DbDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            DbConnect()
            Dim query As String = " SELECT COUNT(*) FROM residence WHERE res_type = 'Non-Voter' "
            ExecuteQueryParameter(query)
            Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
            txtNonvoter.Text = count.ToString()
            DbDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            DbConnect()
            Dim query As String = " SELECT COUNT(*) FROM household"
            ExecuteQueryParameter(query)
            Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
            txtHousehold.Text = count.ToString()
            DbDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            DbConnect()
            Dim query As String = " SELECT COUNT(*) FROM business"
            ExecuteQueryParameter(query)
            Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
            txtBusiness.Text = count.ToString()
            DbDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            DbConnect()
            Dim query As String = " SELECT COUNT(*) FROM residence"
            ExecuteQueryParameter(query)
            Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
            txtTotal.Text = count.ToString()
            DbDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'loadOfficials()

    End Sub

    Private Sub cboAreaH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAreaH.SelectedIndexChanged
        Try
            DbConnect()
            Dim query As String = " SELECT COUNT(*) FROM household INNER JOIN streets ON streets.street_id = household.street_id WHERE street_name = '" & cboAreaH.Text & "' "
            ExecuteQueryParameter(query)
            Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
            txtCountH.Text = count.ToString()
            DbDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboCountB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCountB.SelectedIndexChanged
        Try
            DbConnect()
            Dim query As String = " SELECT COUNT(*) FROM business INNER JOIN streets ON streets.street_id = business.street_id INNER JOIN businesslines ON businesslines.line_id = business.line_id  " _
                                  & "WHERE line_name = '" & cboCountB.Text & "' AND  street_name = '" & cboAreaB.Text & "'"
            ExecuteQueryParameter(query)
            Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
            txtCountB.Text = count.ToString()
            DbDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBy.SelectedIndexChanged
        If cboCount.Text = "Household Type" Then
            Try

                DbConnect()
                Dim query As String = " SELECT COUNT(*) FROM household INNER JOIN streets ON streets.street_id = household.street_id  " _
                                      & "WHERE hh_type = '" & cboBy.Text & "' AND  street_name = '" & cboAreaR.Text & "'"
                ExecuteQueryParameter(query)
                Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
                txtCountR.Text = count.ToString()
                DbDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf cboCount.Text = "Resident Type" Then
            Try

                DbConnect()
                Dim query As String = " SELECT COUNT(*) FROM residence INNER JOIN streets ON streets.street_id = residence.street_id INNER JOIN household ON household.hh_id = residence.hh_id  " _
                                      & "WHERE res_type = '" & cboBy.Text & "' AND  street_name = '" & cboAreaR.Text & "'"
                ExecuteQueryParameter(query)
                Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
                txtCountR.Text = count.ToString()
                DbDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf cboCount.Text = "Civil Status" Then
            Try

                DbConnect()
                Dim query As String = " SELECT COUNT(*) FROM residence INNER JOIN streets ON streets.street_id = residence.street_id INNER JOIN household ON household.hh_id = residence.hh_id  " _
                                      & "WHERE res_status = '" & cboBy.Text & "' AND  street_name = '" & cboAreaR.Text & "'"
                ExecuteQueryParameter(query)
                Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
                txtCountR.Text = count.ToString()
                DbDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf cboCount.Text = "Gender" Then
            Try

                DbConnect()
                Dim query As String = " SELECT COUNT(*) FROM residence INNER JOIN streets ON streets.street_id = residence.street_id INNER JOIN household ON household.hh_id = residence.hh_id  " _
                                      & "WHERE res_sex = '" & cboBy.Text & "' AND  street_name = '" & cboAreaR.Text & "'"
                ExecuteQueryParameter(query)
                Dim count As Int16 = Convert.ToInt16(command.ExecuteScalar())
                txtCountR.Text = count.ToString()
                DbDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cboAreaR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAreaR.SelectedIndexChanged
        cboCount.Enabled = True
    End Sub

    Private Sub cboCount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCount.SelectedIndexChanged
        cboBy.Enabled = True
    End Sub

    Private Sub cboAreaB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAreaB.SelectedIndexChanged
        cboCountB.Enabled = True
    End Sub

    Private Sub btnClear3_Click(sender As Object, e As EventArgs) Handles btnClear3.Click
        cboAreaH.Items.Clear()
        txtCountH.Text = "00"
        loadSteetsH()

    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        cboAreaB.Items.Clear()
        cboCountB.Items.Clear()
        txtCountB.Text = "00"
        loadSteetsB()
        loadLine()
    End Sub

    Private Sub btnClear1_Click(sender As Object, e As EventArgs) Handles btnClear1.Click
        cboAreaR.Items.Clear()
        cboCount.Items.Clear()
        cboBy.Items.Clear()
        txtCountB.Text = "00"
        loadSteetsR()
        cboCount.Items.Add("Household Type")
        cboCount.Items.Add("Resident Type")
        cboCount.Items.Add("Civil Status")
        cboCount.Items.Add("Gender")
    End Sub


    'Sub loadOfficials()

    '    Try
    '        DbConnect()
    '        Dim query As String = "SELECT off_name, off_type, off_image FROM officials WHERE off_type = 'Barangay Captain'"
    '        ExecuteQuery(query)
    '        If reader.HasRows Then
    '            While reader.Read
    '                lblCap.Text = reader.GetString("off_name")
    '                picCap.Image = Base64ToImage(reader.GetString("off_image"))
    '            End While
    '        End If
    '        DbDisconnect()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    Try
    '        DbConnect()
    '        Dim query As String = "SELECT off_name, off_type, off_image, off_servingday FROM officials WHERE off_type = 'Barangay Kagawad' AND off_servingday = 'Mondays'"
    '        ExecuteQuery(query)
    '        If reader.HasRows Then
    '            While reader.Read
    '                lblK1.Text = reader.GetString("off_name")
    '                txtDuty1.Text = reader.GetString("off_servingday")
    '                picKagawad1.Image = Base64ToImage(reader.GetString("off_image"))
    '            End While
    '        End If
    '        DbDisconnect()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    Try
    '        DbConnect()
    '        Dim query As String = "SELECT off_name, off_type, off_image, off_servingday FROM officials WHERE off_type = 'Barangay Kagawad' AND off_servingday = 'Tuesdays'"
    '        ExecuteQuery(query)
    '        If reader.HasRows Then
    '            While reader.Read
    '                lblK2.Text = reader.GetString("off_name")
    '                txtDuty2.Text = reader.GetString("off_servingday")
    '                picKagawad2.Image = Base64ToImage(reader.GetString("off_image"))
    '            End While
    '        End If
    '        DbDisconnect()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    Try
    '        DbConnect()
    '        Dim query As String = "SELECT off_name, off_type, off_image, off_servingday FROM officials WHERE off_type = 'Barangay Kagawad' AND off_servingday = 'Wednesdays'"
    '        ExecuteQuery(query)
    '        If reader.HasRows Then
    '            While reader.Read
    '                lblK3.Text = reader.GetString("off_name")
    '                txtDuty3.Text = reader.GetString("off_servingday")
    '                picKagawad3.Image = Base64ToImage(reader.GetString("off_image"))
    '            End While
    '        End If
    '        DbDisconnect()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    Try
    '        DbConnect()
    '        Dim query As String = "SELECT off_name, off_type, off_image, off_servingday FROM officials WHERE off_type = 'Barangay Kagawad' AND off_servingday = 'Thursdays'"
    '        ExecuteQuery(query)
    '        If reader.HasRows Then
    '            While reader.Read
    '                lblK4.Text = reader.GetString("off_name")
    '                txtDuty4.Text = reader.GetString("off_servingday")
    '                picKagawad4.Image = Base64ToImage(reader.GetString("off_image"))
    '            End While
    '        End If
    '        DbDisconnect()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    Try
    '        DbConnect()
    '        Dim query As String = "SELECT off_name, off_type, off_image, off_servingday FROM officials WHERE off_type = 'Barangay Kagawad' AND off_servingday = 'Fridays'"
    '        ExecuteQuery(query)
    '        If reader.HasRows Then
    '            While reader.Read
    '                lblK5.Text = reader.GetString("off_name")
    '                txtDuty5.Text = reader.GetString("off_servingday")
    '                picKagawad5.Image = Base64ToImage(reader.GetString("off_image"))
    '            End While
    '        End If
    '        DbDisconnect()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    Try
    '        DbConnect()
    '        Dim query As String = "SELECT off_name, off_type, off_image, off_servingday FROM officials WHERE off_type = 'Barangay Kagawad' AND off_servingday = 'Saturdays'"
    '        ExecuteQuery(query)
    '        If reader.HasRows Then
    '            While reader.Read
    '                lblK6.Text = reader.GetString("off_name")
    '                txtDuty6.Text = reader.GetString("off_servingday")
    '                picKagawad6.Image = Base64ToImage(reader.GetString("off_image"))
    '            End While
    '        End If
    '        DbDisconnect()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    Try
    '        DbConnect()
    '        Dim query As String = "SELECT off_name, off_type, off_image, off_servingday FROM officials WHERE off_type = 'Barangay Kagawad' AND off_servingday = 'Sundays'"
    '        ExecuteQuery(query)
    '        If reader.HasRows Then
    '            While reader.Read
    '                lblK7.Text = reader.GetString("off_name")
    '                txtDuty7.Text = reader.GetString("off_servingday")
    '                picKagawad7.Image = Base64ToImage(reader.GetString("off_image"))
    '            End While
    '        End If
    '        DbDisconnect()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    Try
    '        DbConnect()
    '        Dim query As String = "SELECT off_name, off_type, off_image, off_servingday FROM officials WHERE off_type = 'Barangay Secretary'"
    '        ExecuteQuery(query)
    '        If reader.HasRows Then
    '            While reader.Read
    '                lblS.Text = reader.GetString("off_name")
    '                lblSS.Text = reader.GetString("off_servingday")
    '                picS.Image = Base64ToImage(reader.GetString("off_image"))
    '            End While
    '        End If
    '        DbDisconnect()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    Try
    '        DbConnect()
    '        Dim query As String = "SELECT off_name, off_type, off_image, off_servingday FROM officials WHERE off_type = 'Barangay Treasurer'"
    '        ExecuteQuery(query)
    '        If reader.HasRows Then
    '            While reader.Read
    '                lblT.Text = reader.GetString("off_name")
    '                lblTS.Text = reader.GetString("off_servingday")
    '                picT.Image = Base64ToImage(reader.GetString("off_image"))
    '            End While
    '        End If
    '        DbDisconnect()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Function Base64ToImage(ByVal base64String As String) As Image
    '    Try
    '        Dim imageByte() As Byte = Convert.FromBase64String(base64String)
    '        Dim ms As New MemoryStream(imageByte, 0, imageByte.Length)
    '        ms.Write(imageByte, 0, imageByte.Length)
    '        Dim image As Image = image.FromStream(ms, True)
    '        Return image
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function

End Class
