Public Class ucCertAmount
    Dim edit As Integer = 0
    Dim cpID As String
    Dim capID As String

    Private Sub ucCertAmount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCancel.Enabled = False
        btnSave.Enabled = False
        btnEdit.Enabled = False
        loadCA()
        loadType()
        txtPrice.Enabled = False
        cboType.Enabled = False

        btnCa.Enabled = False
        btnSa.Enabled = False
        btnEd.Enabled = False
        loadCap()
        txtCapname.Enabled = False
    End Sub

    Sub loadType()
        cboType.Items.Add("Barangay Clearance")
        cboType.Items.Add("Business Clearance")
        cboType.Items.Add("Certificate of Good Moral")
        cboType.Items.Add("Certificate of Indigency")
    End Sub

    Sub loadCA()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwCertificate.Items.Clear()
        Try
            DbConnect()
            Dim query As String = " SELECT cp_id, cp_price, cp_type FROM certificationprice ORDER by  cp_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwCertificate.Items.Add(reader.GetString("cp_id"))
                    lvwCertificate.Items(i).Font = font
                    lvwCertificate.Items(i).SubItems.Add(reader.GetString("cp_type"))
                    lvwCertificate.Items(i).SubItems.Add(reader.GetString("cp_price"))
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

    Sub saveCA()
        Try
            If edit = 1 Then
                DbConnect()
                Dim query As String = "UPDATE certificationprice SET cp_price = '" & txtPrice.Text & "', cp_type = '" & cboType.Text & "'  WHERE cp_id ='" & cpID & "' "
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Certification charge successfully updated.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtPrice.ResetText()
                txtPrice.Enabled = False
                cboType.Enabled = False
                cboType.Items.Clear()
                loadType()
                btnCancel.Enabled = False
                btnSave.Enabled = False
                btnEdit.Enabled = False
                loadCA()
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub displayCA()
        Try
            DbConnect()
            Dim query As String = " SELECT cp_id, cp_price, cp_type FROM certificationprice WHERE cp_id = '" & cpID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    cboType.Text = reader.GetString("cp_type")
                    txtPrice.Text = reader.GetString("cp_price")
                    txtCID.Text = cpID
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnCancel.Enabled = False
        btnSave.Enabled = False
        btnEdit.Enabled = False
        txtPrice.Enabled = False
        txtPrice.ResetText()
        cboType.Items.Clear()
        loadType()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        edit = 1
        btnEdit.Enabled = False
        btnSave.Enabled = True
        txtPrice.Enabled = True
        cboType.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Trim(txtPrice.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Return
        End If
        saveCA()
    End Sub

    Private Sub lvwCertificate_Click(sender As Object, e As EventArgs) Handles lvwCertificate.Click
        cpID = lvwCertificate.Items(lvwCertificate.SelectedIndices(0)).Text
        btnEdit.Enabled = True
        btnCancel.Enabled = True
        displayCA()
    End Sub

    '============== tab 2========================

    Sub loadCap()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwCap.Items.Clear()
        Try
            DbConnect()
            Dim query As String = " SELECT cap_id, cap_name FROM captain_name"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwCap.Items.Add(reader.GetString("cap_id"))
                    lvwCap.Items(i).Font = font
                    lvwCap.Items(i).SubItems.Add(reader.GetString("cap_name"))
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

    Sub saveCap()
        Try
            If edit = 1 Then
                DbConnect()
                Dim query As String = "UPDATE captain_name SET cap_name = '" & txtCapname.Text & "'  WHERE cap_id ='" & capID & "' "
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Certification captain name successfully updated.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtCapname.ResetText()
                txtCapname.Enabled = False
                btnCa.Enabled = False
                btnSa.Enabled = False
                btnEd.Enabled = False
                loadCap()
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub displayCap()
        Try
            DbConnect()
            Dim query As String = " SELECT cap_name FROM captain_name WHERE cap_id = '" & capID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtCapname.Text = reader.GetString("cap_name")
                    txtCapID.Text = capID
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub


    Private Sub btnCa_Click(sender As Object, e As EventArgs) Handles btnCa.Click
        btnCa.Enabled = False
        btnSa.Enabled = False
        btnEd.Enabled = False
        txtCapname.Enabled = False
        txtCapname.ResetText()
    End Sub

    Private Sub btnEd_Click(sender As Object, e As EventArgs) Handles btnEd.Click
        edit = 1
        btnEd.Enabled = False
        btnSa.Enabled = True
        txtCapname.Enabled = True
    End Sub

    Private Sub btnSa_Click(sender As Object, e As EventArgs) Handles btnSa.Click
        If Trim(txtCapname.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Return
        End If
        saveCap()
    End Sub

    Private Sub lvwCap_Click(sender As Object, e As EventArgs) Handles lvwCap.Click
        capID = lvwCap.Items(lvwCap.SelectedIndices(0)).Text
        btnEd.Enabled = True
        btnCa.Enabled = True
        displayCap()
    End Sub
End Class