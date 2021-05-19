<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAddOfficials
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.radFri = New System.Windows.Forms.RadioButton()
        Me.radThu = New System.Windows.Forms.RadioButton()
        Me.radEntire = New System.Windows.Forms.RadioButton()
        Me.radWed = New System.Windows.Forms.RadioButton()
        Me.radSun = New System.Windows.Forms.RadioButton()
        Me.radSat = New System.Windows.Forms.RadioButton()
        Me.radTue = New System.Windows.Forms.RadioButton()
        Me.radMon = New System.Windows.Forms.RadioButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cboPos = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lvwOfficials = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1132, 10)
        Me.Panel1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Manage Barangay Officials"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpload)
        Me.GroupBox1.Controls.Add(Me.picImage)
        Me.GroupBox1.Controls.Add(Me.grp)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.cboPos)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 323)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'btnUpload
        '
        Me.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnUpload.Location = New System.Drawing.Point(332, 126)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(125, 35)
        Me.btnUpload.TabIndex = 22
        Me.btnUpload.Text = "Upload Image"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'picImage
        '
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage.Image = Global.Sta.Maria_Business_and_Record_Management_System.My.Resources.Resources.none
        Me.picImage.Location = New System.Drawing.Point(332, 22)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(125, 100)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImage.TabIndex = 21
        Me.picImage.TabStop = False
        '
        'grp
        '
        Me.grp.Controls.Add(Me.radFri)
        Me.grp.Controls.Add(Me.radThu)
        Me.grp.Controls.Add(Me.radEntire)
        Me.grp.Controls.Add(Me.radWed)
        Me.grp.Controls.Add(Me.radSun)
        Me.grp.Controls.Add(Me.radSat)
        Me.grp.Controls.Add(Me.radTue)
        Me.grp.Controls.Add(Me.radMon)
        Me.grp.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grp.Location = New System.Drawing.Point(16, 138)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(291, 163)
        Me.grp.TabIndex = 3
        Me.grp.TabStop = False
        Me.grp.Text = "Serving Days"
        '
        'radFri
        '
        Me.radFri.AutoSize = True
        Me.radFri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFri.ForeColor = System.Drawing.Color.Black
        Me.radFri.Location = New System.Drawing.Point(33, 133)
        Me.radFri.Name = "radFri"
        Me.radFri.Size = New System.Drawing.Size(68, 21)
        Me.radFri.TabIndex = 0
        Me.radFri.TabStop = True
        Me.radFri.Text = "Fridays"
        Me.radFri.UseVisualStyleBackColor = True
        '
        'radThu
        '
        Me.radThu.AutoSize = True
        Me.radThu.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radThu.ForeColor = System.Drawing.Color.Black
        Me.radThu.Location = New System.Drawing.Point(33, 106)
        Me.radThu.Name = "radThu"
        Me.radThu.Size = New System.Drawing.Size(85, 21)
        Me.radThu.TabIndex = 0
        Me.radThu.TabStop = True
        Me.radThu.Text = "Thursdays"
        Me.radThu.UseVisualStyleBackColor = True
        '
        'radEntire
        '
        Me.radEntire.AutoSize = True
        Me.radEntire.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEntire.ForeColor = System.Drawing.Color.Black
        Me.radEntire.Location = New System.Drawing.Point(172, 79)
        Me.radEntire.Name = "radEntire"
        Me.radEntire.Size = New System.Drawing.Size(100, 21)
        Me.radEntire.TabIndex = 0
        Me.radEntire.TabStop = True
        Me.radEntire.Text = "Entire week"
        Me.radEntire.UseVisualStyleBackColor = True
        '
        'radWed
        '
        Me.radWed.AutoSize = True
        Me.radWed.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWed.ForeColor = System.Drawing.Color.Black
        Me.radWed.Location = New System.Drawing.Point(33, 79)
        Me.radWed.Name = "radWed"
        Me.radWed.Size = New System.Drawing.Size(106, 21)
        Me.radWed.TabIndex = 0
        Me.radWed.TabStop = True
        Me.radWed.Text = "Wednesdays"
        Me.radWed.UseVisualStyleBackColor = True
        '
        'radSun
        '
        Me.radSun.AutoSize = True
        Me.radSun.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSun.ForeColor = System.Drawing.Color.Black
        Me.radSun.Location = New System.Drawing.Point(172, 52)
        Me.radSun.Name = "radSun"
        Me.radSun.Size = New System.Drawing.Size(77, 21)
        Me.radSun.TabIndex = 0
        Me.radSun.TabStop = True
        Me.radSun.Text = "Sundays"
        Me.radSun.UseVisualStyleBackColor = True
        '
        'radSat
        '
        Me.radSat.AutoSize = True
        Me.radSat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSat.ForeColor = System.Drawing.Color.Black
        Me.radSat.Location = New System.Drawing.Point(172, 25)
        Me.radSat.Name = "radSat"
        Me.radSat.Size = New System.Drawing.Size(87, 21)
        Me.radSat.TabIndex = 0
        Me.radSat.TabStop = True
        Me.radSat.Text = "Saturdays"
        Me.radSat.UseVisualStyleBackColor = True
        '
        'radTue
        '
        Me.radTue.AutoSize = True
        Me.radTue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTue.ForeColor = System.Drawing.Color.Black
        Me.radTue.Location = New System.Drawing.Point(33, 52)
        Me.radTue.Name = "radTue"
        Me.radTue.Size = New System.Drawing.Size(81, 21)
        Me.radTue.TabIndex = 0
        Me.radTue.TabStop = True
        Me.radTue.Text = "Tuesdays"
        Me.radTue.UseVisualStyleBackColor = True
        '
        'radMon
        '
        Me.radMon.AutoSize = True
        Me.radMon.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMon.ForeColor = System.Drawing.Color.Black
        Me.radMon.Location = New System.Drawing.Point(33, 25)
        Me.radMon.Name = "radMon"
        Me.radMon.Size = New System.Drawing.Size(83, 21)
        Me.radMon.TabIndex = 0
        Me.radMon.TabStop = True
        Me.radMon.Text = "Mondays"
        Me.radMon.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(86, 99)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(221, 23)
        Me.txtName.TabIndex = 2
        '
        'cboPos
        '
        Me.cboPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPos.FormattingEnabled = True
        Me.cboPos.Location = New System.Drawing.Point(86, 65)
        Me.cboPos.Name = "cboPos"
        Me.cboPos.Size = New System.Drawing.Size(221, 25)
        Me.cboPos.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(240, 36)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(67, 23)
        Me.txtID.TabIndex = 1
        Me.txtID.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Position:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Controls.Add(Me.btnDel)
        Me.GroupBox3.Controls.Add(Me.btnEdit)
        Me.GroupBox3.Controls.Add(Me.btnCancel)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 429)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(469, 79)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(372, 23)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 38)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.DarkGreen
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.FlatAppearance.BorderSize = 0
        Me.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(280, 23)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(88, 38)
        Me.btnDel.TabIndex = 0
        Me.btnDel.Text = "DELETE"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(189, 23)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(88, 38)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "UPDATE"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCancel.Location = New System.Drawing.Point(98, 23)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 38)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnAdd.Location = New System.Drawing.Point(7, 23)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 38)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "NEW"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lvwOfficials
        '
        Me.lvwOfficials.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwOfficials.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwOfficials.FullRowSelect = True
        Me.lvwOfficials.GridLines = True
        Me.lvwOfficials.HideSelection = False
        Me.lvwOfficials.Location = New System.Drawing.Point(537, 132)
        Me.lvwOfficials.Name = "lvwOfficials"
        Me.lvwOfficials.Size = New System.Drawing.Size(561, 376)
        Me.lvwOfficials.TabIndex = 19
        Me.lvwOfficials.UseCompatibleStateImageBehavior = False
        Me.lvwOfficials.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 281
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Position"
        Me.ColumnHeader3.Width = 149
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Serving Day/s"
        Me.ColumnHeader4.Width = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(535, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Officials Details:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ucAddOfficials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Controls.Add(Me.lvwOfficials)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucAddOfficials"
        Me.Size = New System.Drawing.Size(1132, 627)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grp As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents cboPos As ComboBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lvwOfficials As ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents radFri As RadioButton
    Friend WithEvents radThu As RadioButton
    Friend WithEvents radEntire As RadioButton
    Friend WithEvents radWed As RadioButton
    Friend WithEvents radSun As RadioButton
    Friend WithEvents radSat As RadioButton
    Friend WithEvents radTue As RadioButton
    Friend WithEvents radMon As RadioButton
    Friend WithEvents picImage As PictureBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
