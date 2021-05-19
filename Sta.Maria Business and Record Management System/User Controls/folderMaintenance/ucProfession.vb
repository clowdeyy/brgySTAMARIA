Public Class ucProfession
    Dim edit As Integer = 0
    Dim profID As String
    Dim transdate = DateTime.Now.ToString("MM-dd-yyyy")

    Private Sub ucProfession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        butDisable()
        txtProf.Enabled = False
        loadProf()
    End Sub

    Sub saveProfession()
        Try
            If edit = 0 Then
                DbConnect()
                Dim query As String = "INSERT INTO res_prof set prof_name ='" & txtProf.Text.Replace("'", "`").ToString & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Profession successfully added.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtProf.Enabled = False
                butDisable()
                loadProf()
                DbDisconnect()

                DbConnect()
                Dim query2 As String = "INSERT INTO users_logs SET user_ID = (SELECT user_ID FROM users WHERE user_id= '" & frmDashboard.txtID.Text & "'), ul_action = 'Added a new profession: " & txtProf.Text & "', ul_date = '" & transdate & "'"
                ExecuteQuery(query2)
                DbDisconnect()
                txtProf.Clear()

            ElseIf edit = 1 Then
                DbConnect()
                Dim query As String = "UPDATE res_prof SET prof_name = '" & txtProf.Text.Replace("'", "`").ToString & "' WHERE rp_id ='" & profID & "' "
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Profession successfully updated.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtProf.Clear()
                txtProf.Enabled = False
                butDisable()
                btnAdd.Enabled = True
                btnSave.Enabled = False
                loadProf()
                DbDisconnect()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub loadProf()
        Dim font As Font
        font = New Font("Century Gothic", 10, FontStyle.Regular)
        lvwProf.Items.Clear()
        Try
            DbConnect()
            Dim query As String = " SELECT rp_id, prof_name FROM res_prof ORDER by  rp_id DESC"
            ExecuteQuery(query)
            Dim i As Integer = 0
            If reader.HasRows Then
                While reader.Read
                    lvwProf.Items.Add(reader.GetString("rp_id"))
                    lvwProf.Items(i).Font = Font
                    lvwProf.Items(i).SubItems.Add(reader.GetString("prof_name"))
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

    Sub displayProf()
        Try
            DbConnect()
            Dim query As String = " SELECT rp_id, prof_name FROM res_prof WHERE rp_id = '" & profID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtProf.Text = reader.GetString("prof_name")
                    txtProfid.Text = profID
                End While
            End If
            DbDisconnect()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub delProf()
        Try
            If MetroFramework.MetroMessageBox.Show(Me, " 
Are you sure to delete selected profession?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = vbYes Then
                DbConnect()
                Dim query As String = " DELETE FROM res_prof WHERE rp_id ='" & profID & "'"
                ExecuteQuery(query)
                MetroFramework.MetroMessageBox.Show(Me, " 
Selected profession successfully deleted.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtProf.Enabled = False
                btnAdd.Enabled = True
                btnEdit.Enabled = False
                btnDel.Enabled = False
                btnCancel.Enabled = False
                txtProf.Clear()
                loadProf()
                DbDisconnect()
            ElseIf vbNo Then
                Exit Sub
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Sub butDisable()
        btnEdit.Enabled = False
        btnCancel.Enabled = False
        btnDel.Enabled = False
        btnSave.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True
        txtProf.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnAdd.Enabled = True
        txtProf.Clear()
        txtProf.Enabled = False
        butDisable()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Trim(txtProf.Text) = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " 
Please fill out blank fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Return
        End If
        saveProfession()
    End Sub

    Private Sub lvwProf_Click(sender As Object, e As EventArgs) Handles lvwProf.Click
        profID = lvwProf.Items(lvwProf.SelectedIndices(0)).Text
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDel.Enabled = True
        btnCancel.Enabled = True
        displayProf()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            delProf()
            txtProf.Enabled = False
            butDisable()
            btnAdd.Enabled = True
            loadProf()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "An Error occured:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            DisposeConnection()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        edit = 1
        btnEdit.Enabled = False
        btnDel.Enabled = False
        btnSave.Enabled = True
        txtProf.Enabled = True
    End Sub


    Private Sub txtProf_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProf.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave_Click(sender, e)
        End If
    End Sub
End Class
