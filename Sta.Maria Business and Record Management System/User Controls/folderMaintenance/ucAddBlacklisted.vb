Public Class ucAddBlacklisted
    Dim edit As Integer = 0
    Dim resID As String
    Dim caseType As String
    Dim caseTypeC As String
    Dim street As String
    Dim resident As String
    Dim criteriaID As String
    Dim criteriname As String
    Dim transdate = DateTime.Now.ToString("MM-dd-yyyy")

    Private Sub radTempo_CheckedChanged(sender As Object, e As EventArgs) Handles radTempo.CheckedChanged
        caseType = radTempo.Text
        If radTempo.Checked = True Then
            cboCriteria.Items.Clear()
            txtCaseDesc.Clear()
            loadCriteriaTempo()
        End If
    End Sub

    Private Sub radPerma_CheckedChanged(sender As Object, e As EventArgs) Handles radPerma.CheckedChanged
        caseType = radPerma.Text
        If radPerma.Checked = True Then
            cboCriteria.Items.Clear()
            txtCaseDesc.Clear()
            loadCriteriaPerma()
        End If
    End Sub

    Private Sub ucAddBlacklisted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        butDisable()
        txtDisable()
        loadListResidence()

        btnDisableC()
        txtDisableC()
        loadCriteria()

    End Sub

    Sub butDisable()
        btnCancel.Enabled = False
        btnDel.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
    End Sub

    Sub txtDisable()
        txtName.Enabled = False
        radTempo.Enabled = False
        radPerma.Enabled = False
        txtCaseDesc.Enabled = False
        txtBdate.Enabled = False
        cboCriteria.Enabled = False
        txtRemarks.Enabled = False
        btnSearch.Enabled = False
    End Sub

    Sub txtEnable()
        ' txtName.Enabled = True
        radTempo.Enabled = True
        radPerma.Enabled = True
        cboCriteria.Enabled = True
        txtRemarks.Enabled = True
        btnSearch.Enabled = True
    End Sub

    Sub txtClear()
        txtName.Clear()
        txtAddress.Clear()
        radV.Checked = Nothing
        radN.Checked = Nothing
        radM.Checked = Nothing
        radF.Checked = Nothing
        txtBdate.Text = ""
        txtNationality.Clear()
        radTempo.Checked = Nothing
        radPerma.Checked = Nothing
        txtCaseDesc.Clear()
        cboCriteria.Items.Clear()
        txtRemarks.Clear()
    End Sub

    Sub loadCriteriaPerma()
        DbConnect()
        Dim query As String = "SELECT  bc_name FROM blacklistcriteria WHERE bc_type = 'Permanent' "
        ExecuteQuery(query)
        If reader.HasRows Then
            While reader.Read
                cboCriteria.Items.Add(reader.GetString("bc_name"))
            End While
        End If
        DbDisconnect()
    End Sub

    Sub loadCriteriaTempo()
        DbConnect()
        Dim query As String = "SELECT  bc_name FROM blacklistcriteria WHERE bc_type = 'Temporary' "
        ExecuteQuery(query)
        If reader.HasRows Then
            While reader.Read
                cboCriteria.Items.Add(reader.GetString("bc_name"))
            End While
        End If
        DbDisconnect()

    End Sub

    Dim criteria As String
    Sub saveResidence()
        Dim caso As String = caseType.ToString
        Try
            If edit = 0 Then
                DbConnect()
                Dim query3 As String = "SELECT res_id FROM residence WHERE res_name = '" & txtName.Text & "'"
                ExecuteQuery(query3)
                If reader.HasRows Then
                    While reader.Read
                        resident = reader.GetString(0)
                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim query4 As String = "SELECT bc_id FROM blacklistcriteria WHERE bc_name = '" & cboCriteria.Text & "' "
                ExecuteQuery(query4)
                If reader.HasRows Then
                    While reader.Read
                        criteria = reader.GetString(0)
                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim query As String = "SELECT * FROM blacklists WHERE res_id = @resid and bl_active = 'yes'"
                ExecuteQueryParameter(query)
                command.Parameters.AddWithValue("@resid", resident)
                reader = command.ExecuteReader
                If reader.HasRows Then
                    MetroFramework.MetroMessageBox.Show(Me, " 
Selected resident already marked as blacklicklisted.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Else
                    DbConnect()
                    Dim query5 As String = "INSERT INTO blacklists set bl_active = 'yes',  bl_remarks = @remarks, res_id = @resident, bc_id = @criteria"
                    ExecuteQueryParameter(query5)
                    command.Parameters.AddWithValue("@remarks", txtRemarks.Text.ToString)
                    command.Parameters.AddWithValue("@resident", resident)
                    command.Parameters.AddWithValue("@criteria", criteria)
                    reader = command.ExecuteReader
                    MetroFramework.MetroMessageBox.Show(Me, " 
Resident successfully marked as blacklicklisted.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    DbDisconnect()
                End If
                btnAdd.Enabled = True
                btnSave.Enabled = False
                DbDisconnect()

                DbConnect()
                Dim query1 As String = " INSERT INTO residencelogs SET  rl_action = 'Marked as blacklisted', rl_date = '" & transdate & "', rl_performby = '" & frmDashboard.txtUser.Text & "', res_id = '" & resident & "' "
                ExecuteQuery(query1)
                DbDisconnect()

                DbConnect()
                Dim query2 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= '" & frmDashboard.txtID.Text & "'), ul_action = 'Marked a resident as blacklisted: " & txtName.Text & "', ul_date = '" & transdate & "'"
                ExecuteQuery(query2)
                DbDisconnect()

                txtClear()
                txtDisable()
                butDisable()
                loadListResidence()


            ElseIf edit = 1 Then
                DbConnect()
                Dim query3 As String = "SELECT res_id FROM residence WHERE res_name = '" & txtName.Text & "'"
                ExecuteQuery(query3)
                If reader.HasRows Then
                    While reader.Read
                        resident = reader.GetString(0)
                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim query4 As String = "SELECT bc_id FROM blacklistcriteria WHERE bc_name = '" & cboCriteria.Text & "' "
                ExecuteQuery(query4)
                If reader.HasRows Then
                    While reader.Read
                        criteria = reader.GetString(0)
                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim query As String = "UPDATE blacklists set  bl_active =@blactive, bl_remarks =@remarks, res_id = @resid, bc_id =@bcid WHERE bl_id = @blid"
                ExecuteQueryParameter(query)
                command.Parameters.AddWithValue("@blactive", "yes")
                command.Parameters.AddWithValue("@remarks", txtRemarks.Text)
                command.Parameters.AddWithValue("@resid", resident)
                command.Parameters.AddWithValue("@bcid", criteria)
                command.Parameters.AddWithValue("@blid", resID)
                reader = command.ExecuteReader
                MetroFramework.MetroMessageBox.Show(Me, " 
Resident case successfully updated.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                btnAdd.Enabled = True
                btnSave.Enabled = False

                DbConnect()
                Dim query2 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= '" & frmDashboard.txtID.Text & "'), ul_action = 'Updated blacklisted resident case: " & txtName.Text & "', ul_date = '" & transdate & "'"
                ExecuteQuery(query2)
                DbDisconnect()

                txtClear()
                txtDisable()
                butDisable()
                loadListResidence()
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub caseSolve()
        Dim no As String = "no"
        Try
            If MetroFramework.MetroMessageBox.Show(Me, " 
You are about to dismiss selected Resident as blacklisted, continue? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = vbYes Then
                DbConnect()
                Dim query As String = " UPDATE blacklists set bl_active ='no', solved_by = '" & frmDashboard.txtUser.Text & "', solved_date = '" & transdate & "' WHERE bl_id = '" & resID & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Selected resident successfully dismissed.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                btnAdd.Enabled = True
                btnEdit.Enabled = False
                btnDel.Enabled = False
                btnCancel.Enabled = False

                DbConnect()
                Dim query2 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= '" & frmDashboard.txtID.Text & "'), ul_action = 'Marked as case solved for blacklisted resident: " & txtName.Text & "', ul_date = '" & transdate & "'"
                ExecuteQuery(query2)
                DbDisconnect()

                txtClear()
                txtDisable()
                loadListResidence()
                DbDisconnect()

                DbConnect()
                Dim query3 As String = "SELECT res_id FROM residence WHERE res_name = '" & txtName.Text & "'"
                ExecuteQuery(query3)
                If reader.HasRows Then
                    While reader.Read
                        resident = reader.GetString(0)
                    End While
                End If
                DbDisconnect()

                DbConnect()
                Dim query1 As String = " INSERT INTO residencelogs SET  rl_action = 'Blacklisted case marked as solved', rl_date = '" & transdate & "', rl_performby = '" & frmDashboard.txtUser.Text & "', res_id = '" & resident & "' "
                ExecuteQuery(query1)
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

    Sub loadListResidence()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwResidence.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT bl_id, res_name, bl_active, bl_remarks,bc_name, bc_desc, bc_type FROM blacklists, blacklistcriteria, residence  WHERE residence.res_id = blacklists.res_id AND blacklistcriteria.bc_id = blacklists.bc_id AND bl_active='yes' ORDER by bl_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwResidence.Items.Add(reader.GetString("bl_id"))
                    lvwResidence.Items(i).Font = font
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_name"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("bc_type"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("bc_name"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("bc_desc"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("bl_remarks"))

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
            If lvwResidence.SelectedItems.Count > 0 Then
                Dim res As ListViewItem = lvwResidence.SelectedItems(0)
                txtID.Text = resID
                txtName.Text = res.SubItems(1).Text
                If radTempo.Text = res.SubItems(2).Text Then
                    radTempo.Select()
                    btnDel.Enabled = True
                ElseIf radPerma.Text = res.SubItems(2).Text Then
                    radPerma.Select()
                    btnDel.Enabled = False
                End If
                cboCriteria.Text = res.SubItems(3).Text
                txtCaseDesc.Text = res.SubItems(4).Text
                txtRemarks.Text = res.SubItems(5).Text
                DbConnect()
                Dim query = "SELECT res_bdate, res_nationality, res_sex, res_type, street_name FROM streets,residence, blacklists WHERE blacklists.res_id = residence.res_id AND residence.street_id = streets.street_id and bl_id = '" & resID & "'"
                ExecuteQuery(query)
                If reader.HasRows Then
                    While reader.Read
                        txtNationality.Text = reader.GetString("res_nationality")
                        txtBdate.Text = reader.GetString("res_bdate")
                        txtAddress.Text = reader.GetString("street_name")
                        'If radV.Text = res.SubItems("res_type").Text Then
                        '    radV.Select()
                        'ElseIf radN.Text = res.SubItems("res_type").Text Then
                        '    radN.Select()
                        'ElseIf radM.Text = res.SubItems("res_sex").Text Then
                        '    radM.Select()
                        'ElseIf radF.Text = res.SubItems("res_sex").Text Then
                        '    radF.Select()
                        'End If
                    End While
                End If
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
        txtEnable()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        butDisable()
        txtDisable()
        txtClear()
        btnAdd.Enabled = True
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        caseSolve()
        txtDisable()
        butDisable()
        btnAdd.Enabled = True
        loadListResidence()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        edit = 1
        btnEdit.Enabled = False
        btnDel.Enabled = False
        btnSave.Enabled = True
        txtEnable()
        btnSearch.Enabled = False
        txtName.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Trim(txtCaseDesc.Text) = "" Or Trim(caseType) = "" Or Trim(txtName.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
        Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        saveResidence()
    End Sub

    Dim ney, add, bdate, nation
    Private Sub lvwResidence_Click(sender As Object, e As EventArgs) Handles lvwResidence.Click
        If lvwResidence.SelectedItems.Count > 0 Then
            Try
                resID = lvwResidence.Items(lvwResidence.SelectedIndices(0)).Text
                btnAdd.Enabled = False
                btnEdit.Enabled = True
                btnCancel.Enabled = True
                ' btnDel.Enabled = True
                displayResidence()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                DisposeConnection()
            End Try
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

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz  "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Sub search(keyword As String)
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwResidence.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT bl_id, res_name, bl_active, bl_remarks,bc_name, bc_desc, bc_type FROM blacklists, blacklistcriteria, residence  WHERE residence.res_id = blacklists.res_id AND blacklistcriteria.bc_id = blacklists.bc_id AND bl_active='yes' " _
                                 & "AND res_name LIKE '" & keyword & "%'"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwResidence.Items.Add(reader.GetString("bl_id"))
                    lvwResidence.Items(i).Font = font
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("res_name"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("bc_type"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("bc_name"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("bc_desc"))
                    lvwResidence.Items(i).SubItems.Add(reader.GetString("bl_remarks"))

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
            loadListResidence()
        Else
            search(txtSearch.Text)
        End If
    End Sub

    '================================ Tab2

    Private Sub radCTemp_CheckedChanged(sender As Object, e As EventArgs) Handles radCTemp.CheckedChanged
        caseTypeC = radCTemp.Text
    End Sub

    Private Sub radCPerma_CheckedChanged(sender As Object, e As EventArgs) Handles radCPerma.CheckedChanged
        caseTypeC = radPerma.Text
    End Sub

    Sub btnEnableC()
        btnCancelC.Enabled = True
        btnEditC.Enabled = True
        btnDelC.Enabled = True
        btnSaveC.Enabled = True
    End Sub

    Sub btnDisableC()
        btnCancelC.Enabled = False
        btnEditC.Enabled = False
        btnDelC.Enabled = False
        btnSaveC.Enabled = False
    End Sub

    Sub txtClearC()
        radCTemp.Checked = False
        radCPerma.Checked = False
        txtCCriteria.Clear()
        txtCDesc.Clear()
    End Sub

    Sub txtDisableC()
        radCTemp.Enabled = False
        radCPerma.Enabled = False
        txtCCriteria.Enabled = False
        txtCDesc.Enabled = False
    End Sub

    Sub txtEnableC()
        radCTemp.Enabled = True
        radCPerma.Enabled = True
        txtCCriteria.Enabled = True
        txtCDesc.Enabled = True
    End Sub

    Sub loadCriteria()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwCriteria.Items.Clear()
        Try
            DbConnect()
            Dim query As String = "SELECT bc_id, bc_type, bc_name, bc_desc FROM blacklistcriteria ORDER by bc_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwCriteria.Items.Add(reader.GetString("bc_id"))
                    lvwCriteria.Items(i).Font = font
                    lvwCriteria.Items(i).SubItems.Add(reader.GetString("bc_type"))
                    lvwCriteria.Items(i).SubItems.Add(reader.GetString("bc_name"))
                    lvwCriteria.Items(i).SubItems.Add(reader.GetString("bc_desc"))
                    i += 1
                End While
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub displayCriteria()
        Try
            DbConnect()
            Dim query = "SELECT bc_type, bc_name, bc_desc FROM blacklistcriteria WHERE  bc_id = '" & criteriaID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtCCriteria.Text = reader.GetString("bc_name")
                    txtCDesc.Text = reader.GetString("bc_desc")
                    If radCPerma.Text = reader.GetString("bc_type") Then
                        radCPerma.Select()
                    ElseIf radCTemp.Text = reader.GetString("bc_type") Then
                        radCTemp.Select()
                    End If
                    txtCriteriaID.Text = criteriaID
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub saveCriteria()
        Dim criteria As String = caseTypeC.ToString
        lvwCriteria.Items.Clear()
        Try
            If edit = 0 Then
                DbConnect()
                Dim query As String = "INSERT INTO blacklistcriteria set bc_type = '" & criteria & "', bc_name = '" & txtCCriteria.Text & "', bc_desc = '" & txtCDesc.Text & "' "
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Blacklist criteria successfully added.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                btnAddC.Enabled = True
                btnSaveC.Enabled = False
                txtClearC()
                txtDisableC()
                btnDisableC()
                loadCriteria()
                DbDisconnect()

            ElseIf edit = 1 Then
                DbConnect()
                Dim query As String = "UPDATE blacklistcriteria set bc_type = '" & criteria & "', bc_name = '" & txtCCriteria.Text & "', bc_desc = '" & txtCDesc.Text & "' WHERE bc_id = '" & criteriaID & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Blacklist criteria successfully updated.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                btnAddC.Enabled = True
                btnSaveC.Enabled = False
                txtClearC()
                txtDisableC()
                btnDisableC()
                loadCriteria()
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub deleteCriteria()
        Try
            If MetroFramework.MetroMessageBox.Show(Me, " 
You are about to delete selected Criteria, continue? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = vbYes Then
                DbConnect()
                Dim query As String = " DELETE FROM blacklistcriteria WHERE bc_id = '" & criteriaID & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Selected criteria successfully dismissed.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                btnAddC.Enabled = True
                btnEditC.Enabled = False
                btnDelC.Enabled = False
                btnCancelC.Enabled = False
                txtClearC()
                txtDisableC()
                loadCriteria()
                DbDisconnect()
                Exit Sub
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnAddC_Click(sender As Object, e As EventArgs) Handles btnAddC.Click
        txtEnableC()
        btnSaveC.Enabled = True
        btnCancelC.Enabled = True
        btnAddC.Enabled = False
    End Sub

    Private Sub btnCancelC_Click(sender As Object, e As EventArgs) Handles btnCancelC.Click
        btnDisableC()
        txtDisableC()
        txtClearC()
        btnAddC.Enabled = True
    End Sub

    Private Sub btnEditC_Click(sender As Object, e As EventArgs) Handles btnEditC.Click
        edit = 1
        btnEditC.Enabled = False
        btnDelC.Enabled = False
        btnSaveC.Enabled = True
        txtEnableC()
    End Sub

    Private Sub cboCriteria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCriteria.SelectedIndexChanged
        DbConnect()
        Dim query As String = "SELECT bc_desc FROM blacklistcriteria WHERE bc_name = '" & cboCriteria.Text & "'"
        ExecuteQuery(query)
        If reader.HasRows Then
            While reader.Read
                txtCaseDesc.Text = reader.GetString("bc_desc")
            End While
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        txtClear()
        searchresid = ""
        frmResidenceList.ShowDialog()
        Dim isSelected As Boolean = False
        If isSelected Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Resident is already selected.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf searchresid <> "" Or isSelected = False Then
            Try
                DbConnect()
                Dim query As String = "SELECT * FROM residence, streets WHERE streets.street_id = residence.street_id AND res_id ='" & searchresid & "'"
                ExecuteQuery(query)
                If reader.HasRows Then
                    While reader.Read()
                        txtName.Text = reader.GetString("res_name")
                        txtAddress.Text = reader.GetString("street_name")
                        txtBdate.Text = reader.GetString("res_bdate")
                        txtNationality.Text = reader.GetString("res_nationality")
                        If radV.Text = reader.GetString("res_type") Then
                            radV.Select()
                        ElseIf radN.Text = reader.GetString("res_type") Then
                            radN.Select()
                        End If
                        If radM.Text = reader.GetString("res_sex") Then
                            radM.Select()
                        ElseIf radF.Text = reader.GetString("res_sex") Then
                            radF.Select()
                        End If
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


    Private Sub btnDelC_Click(sender As Object, e As EventArgs) Handles btnDelC.Click
        Try
            deleteCriteria()
            txtDisableC()
            btnDisableC()
            btnAddC.Enabled = True
            loadCriteria()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub


    Private Sub btnSaveC_Click(sender As Object, e As EventArgs) Handles btnSaveC.Click
        If Trim(radCPerma.Text) = "" Or Trim(radCTemp.Text) = "" Or Trim(txtCCriteria.Text) = "" Or Trim(txtCDesc.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
        Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        saveCriteria()
    End Sub

    Private Sub lvwCriteria_Click(sender As Object, e As EventArgs) Handles lvwCriteria.Click
        If lvwCriteria.SelectedItems.Count > 0 Then
            Try
                criteriaID = lvwCriteria.Items(lvwCriteria.SelectedIndices(0)).Text
                btnAddC.Enabled = False
                btnEditC.Enabled = True
                btnCancelC.Enabled = True
                btnDelC.Enabled = True
                displayCriteria()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                DisposeConnection()
            End Try
        End If
    End Sub

    Private Sub txtRemarks_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRemarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave_Click(sender, e)
        End If
    End Sub
End Class
