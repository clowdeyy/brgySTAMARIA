<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucAddResidence
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucAddResidence))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lvwResidence = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboZone = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cboAddress = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grpNonV = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtResID = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtGPrecint = New System.Windows.Forms.TextBox()
        Me.txtGRelation = New System.Windows.Forms.TextBox()
        Me.txtGName = New System.Windows.Forms.TextBox()
        Me.btnprof = New System.Windows.Forms.Button()
        Me.txtProfession = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.radN = New System.Windows.Forms.RadioButton()
        Me.radV = New System.Windows.Forms.RadioButton()
        Me.txtNationality = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radF = New System.Windows.Forms.RadioButton()
        Me.radM = New System.Windows.Forms.RadioButton()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.grpVoter = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtVPrecint = New System.Windows.Forms.TextBox()
        Me.txtYrs = New System.Windows.Forms.TextBox()
        Me.txtBdate = New System.Windows.Forms.DateTimePicker()
        Me.cboReligion = New System.Windows.Forms.ComboBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBirthplace = New System.Windows.Forms.TextBox()
        Me.txtHousehold = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpNonV.SuspendLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.grpVoter.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(428, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Manage Individual Residents Information"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1132, 10)
        Me.Panel1.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnDel)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 541)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 72)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnAdd.Location = New System.Drawing.Point(21, 18)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 42)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        Me.btnAdd.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCancel.Location = New System.Drawing.Point(95, 18)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 42)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.DarkGreen
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(98, 18)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(82, 42)
        Me.btnDel.TabIndex = 0
        Me.btnDel.Text = "DELETE"
        Me.btnDel.UseVisualStyleBackColor = False
        Me.btnDel.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(189, 18)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(88, 42)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "UPDATE"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(283, 18)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 42)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lvwResidence
        '
        Me.lvwResidence.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvwResidence.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwResidence.FullRowSelect = True
        Me.lvwResidence.GridLines = True
        Me.lvwResidence.HideSelection = False
        Me.lvwResidence.Location = New System.Drawing.Point(505, 209)
        Me.lvwResidence.Name = "lvwResidence"
        Me.lvwResidence.Size = New System.Drawing.Size(606, 404)
        Me.lvwResidence.TabIndex = 22
        Me.lvwResidence.UseCompatibleStateImageBehavior = False
        Me.lvwResidence.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 449
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Resident type"
        Me.ColumnHeader3.Width = 153
        '
        'btnUpload
        '
        Me.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnUpload.Image = CType(resources.GetObject("btnUpload.Image"), System.Drawing.Image)
        Me.btnUpload.Location = New System.Drawing.Point(986, 170)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(60, 35)
        Me.btnUpload.TabIndex = 13
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'picImage
        '
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage.Image = Global.Sta.Maria_Business_and_Record_Management_System.My.Resources.Resources.na
        Me.picImage.Location = New System.Drawing.Point(986, 67)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(125, 100)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImage.TabIndex = 20
        Me.picImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(512, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Search:"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button2.Location = New System.Drawing.Point(505, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(464, 33)
        Me.Button2.TabIndex = 24
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.HintForeColor = System.Drawing.Color.Empty
        Me.txtSearch.HintText = "    search name here"
        Me.txtSearch.isPassword = False
        Me.txtSearch.LineFocusedColor = System.Drawing.Color.LightGreen
        Me.txtSearch.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.txtSearch.LineMouseHoverColor = System.Drawing.Color.LightGreen
        Me.txtSearch.LineThickness = 3
        Me.txtSearch.Location = New System.Drawing.Point(575, 177)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(282, 29)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboZone)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.cboAddress)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(505, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 100)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Address"
        '
        'cboZone
        '
        Me.cboZone.Enabled = False
        Me.cboZone.Location = New System.Drawing.Point(57, 26)
        Me.cboZone.Name = "cboZone"
        Me.cboZone.Size = New System.Drawing.Size(39, 23)
        Me.cboZone.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(406, 58)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(45, 23)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "7000"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(279, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 23)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "Philippines"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(87, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 23)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Zamboanga Del Sur"
        '
        'cboAddress
        '
        Me.cboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddress.Enabled = False
        Me.cboAddress.FormattingEnabled = True
        Me.cboAddress.Location = New System.Drawing.Point(148, 24)
        Me.cboAddress.Name = "cboAddress"
        Me.cboAddress.Size = New System.Drawing.Size(303, 25)
        Me.cboAddress.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(14, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Province:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(100, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Street:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(14, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Zone:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnprof)
        Me.GroupBox3.Controls.Add(Me.txtProfession)
        Me.GroupBox3.Controls.Add(Me.txtID)
        Me.GroupBox3.Controls.Add(Me.radN)
        Me.GroupBox3.Controls.Add(Me.radV)
        Me.GroupBox3.Controls.Add(Me.txtNationality)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.Controls.Add(Me.grpVoter)
        Me.GroupBox3.Controls.Add(Me.txtYrs)
        Me.GroupBox3.Controls.Add(Me.txtBdate)
        Me.GroupBox3.Controls.Add(Me.cboReligion)
        Me.GroupBox3.Controls.Add(Me.cboStatus)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtBirthplace)
        Me.GroupBox3.Controls.Add(Me.txtHousehold)
        Me.GroupBox3.Controls.Add(Me.txtName)
        Me.GroupBox3.Controls.Add(Me.grpNonV)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 475)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Personal Information"
        '
        'grpNonV
        '
        Me.grpNonV.Controls.Add(Me.btnSearch)
        Me.grpNonV.Controls.Add(Me.Label19)
        Me.grpNonV.Controls.Add(Me.Label18)
        Me.grpNonV.Controls.Add(Me.txtResID)
        Me.grpNonV.Controls.Add(Me.Label17)
        Me.grpNonV.Controls.Add(Me.txtGPrecint)
        Me.grpNonV.Controls.Add(Me.txtGRelation)
        Me.grpNonV.Controls.Add(Me.txtGName)
        Me.grpNonV.Location = New System.Drawing.Point(32, 336)
        Me.grpNonV.Name = "grpNonV"
        Me.grpNonV.Size = New System.Drawing.Size(397, 130)
        Me.grpNonV.TabIndex = 8
        Me.grpNonV.TabStop = False
        Me.grpNonV.Text = "Non-Voter Guarantor"
        Me.grpNonV.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Enabled = False
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(345, 28)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(20, 20)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnSearch.TabIndex = 44
        Me.btnSearch.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(6, 63)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(125, 18)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Precint Number:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(30, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 18)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Relationship:"
        '
        'txtResID
        '
        Me.txtResID.Location = New System.Drawing.Point(375, 112)
        Me.txtResID.Multiline = True
        Me.txtResID.Name = "txtResID"
        Me.txtResID.Size = New System.Drawing.Size(16, 12)
        Me.txtResID.TabIndex = 11
        Me.txtResID.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(46, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 18)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Full Name:"
        '
        'txtGPrecint
        '
        Me.txtGPrecint.Enabled = False
        Me.txtGPrecint.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGPrecint.Location = New System.Drawing.Point(137, 58)
        Me.txtGPrecint.Name = "txtGPrecint"
        Me.txtGPrecint.Size = New System.Drawing.Size(202, 26)
        Me.txtGPrecint.TabIndex = 13
        '
        'txtGRelation
        '
        Me.txtGRelation.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGRelation.Location = New System.Drawing.Point(137, 90)
        Me.txtGRelation.Name = "txtGRelation"
        Me.txtGRelation.Size = New System.Drawing.Size(202, 26)
        Me.txtGRelation.TabIndex = 12
        '
        'txtGName
        '
        Me.txtGName.Enabled = False
        Me.txtGName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGName.Location = New System.Drawing.Point(137, 24)
        Me.txtGName.Name = "txtGName"
        Me.txtGName.Size = New System.Drawing.Size(202, 26)
        Me.txtGName.TabIndex = 11
        '
        'btnprof
        '
        Me.btnprof.Enabled = False
        Me.btnprof.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprof.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprof.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnprof.Location = New System.Drawing.Point(393, 244)
        Me.btnprof.Name = "btnprof"
        Me.btnprof.Size = New System.Drawing.Size(26, 26)
        Me.btnprof.TabIndex = 25
        Me.btnprof.Text = "+"
        Me.btnprof.UseVisualStyleBackColor = True
        '
        'txtProfession
        '
        Me.txtProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtProfession.FormattingEnabled = True
        Me.txtProfession.Location = New System.Drawing.Point(132, 244)
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Size = New System.Drawing.Size(255, 25)
        Me.txtProfession.TabIndex = 12
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(448, 11)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(16, 12)
        Me.txtID.TabIndex = 11
        Me.txtID.Visible = False
        '
        'radN
        '
        Me.radN.AutoSize = True
        Me.radN.Location = New System.Drawing.Point(222, 42)
        Me.radN.Name = "radN"
        Me.radN.Size = New System.Drawing.Size(92, 21)
        Me.radN.TabIndex = 0
        Me.radN.TabStop = True
        Me.radN.Text = "Non-Voter"
        Me.radN.UseVisualStyleBackColor = True
        '
        'radV
        '
        Me.radV.AutoSize = True
        Me.radV.Location = New System.Drawing.Point(155, 41)
        Me.radV.Name = "radV"
        Me.radV.Size = New System.Drawing.Size(61, 21)
        Me.radV.TabIndex = 0
        Me.radV.TabStop = True
        Me.radV.Text = "Voter"
        Me.radV.UseVisualStyleBackColor = True
        '
        'txtNationality
        '
        Me.txtNationality.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNationality.Location = New System.Drawing.Point(132, 170)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Size = New System.Drawing.Size(111, 26)
        Me.txtNationality.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radF)
        Me.GroupBox4.Controls.Add(Me.radM)
        Me.GroupBox4.Location = New System.Drawing.Point(277, 128)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(143, 35)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'radF
        '
        Me.radF.AutoSize = True
        Me.radF.Location = New System.Drawing.Point(69, 10)
        Me.radF.Name = "radF"
        Me.radF.Size = New System.Drawing.Size(73, 21)
        Me.radF.TabIndex = 0
        Me.radF.TabStop = True
        Me.radF.Text = "Female"
        Me.radF.UseVisualStyleBackColor = True
        '
        'radM
        '
        Me.radM.AutoSize = True
        Me.radM.Location = New System.Drawing.Point(6, 10)
        Me.radM.Name = "radM"
        Me.radM.Size = New System.Drawing.Size(57, 21)
        Me.radM.TabIndex = 0
        Me.radM.TabStop = True
        Me.radM.Text = "Male"
        Me.radM.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(333, 307)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(47, 23)
        Me.TextBox8.TabIndex = 0
        Me.TextBox8.Text = "years"
        '
        'grpVoter
        '
        Me.grpVoter.BackColor = System.Drawing.SystemColors.Control
        Me.grpVoter.Controls.Add(Me.Label20)
        Me.grpVoter.Controls.Add(Me.txtVPrecint)
        Me.grpVoter.Location = New System.Drawing.Point(32, 336)
        Me.grpVoter.Name = "grpVoter"
        Me.grpVoter.Size = New System.Drawing.Size(397, 63)
        Me.grpVoter.TabIndex = 10
        Me.grpVoter.TabStop = False
        Me.grpVoter.Text = "Voter Precint"
        Me.grpVoter.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(6, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(125, 18)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Precint Number:"
        '
        'txtVPrecint
        '
        Me.txtVPrecint.BackColor = System.Drawing.Color.White
        Me.txtVPrecint.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVPrecint.Location = New System.Drawing.Point(137, 22)
        Me.txtVPrecint.Multiline = True
        Me.txtVPrecint.Name = "txtVPrecint"
        Me.txtVPrecint.Size = New System.Drawing.Size(243, 29)
        Me.txtVPrecint.TabIndex = 11
        '
        'txtYrs
        '
        Me.txtYrs.Location = New System.Drawing.Point(274, 307)
        Me.txtYrs.Name = "txtYrs"
        Me.txtYrs.Size = New System.Drawing.Size(53, 23)
        Me.txtYrs.TabIndex = 10
        '
        'txtBdate
        '
        Me.txtBdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtBdate.Location = New System.Drawing.Point(132, 207)
        Me.txtBdate.Name = "txtBdate"
        Me.txtBdate.Size = New System.Drawing.Size(288, 23)
        Me.txtBdate.TabIndex = 7
        Me.txtBdate.Value = New Date(2019, 10, 25, 23, 59, 59, 0)
        '
        'cboReligion
        '
        Me.cboReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReligion.FormattingEnabled = True
        Me.cboReligion.Location = New System.Drawing.Point(314, 172)
        Me.cboReligion.Name = "cboReligion"
        Me.cboReligion.Size = New System.Drawing.Size(106, 25)
        Me.cboReligion.TabIndex = 6
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(132, 137)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(99, 25)
        Me.cboStatus.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(245, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Religion:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(236, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Sex:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(41, 309)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(227, 18)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "No. years stayed in Barangay:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(40, 278)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 18)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Birthplace:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(42, 244)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Profession:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(42, 209)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 18)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Birthdate:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(41, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 18)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Citizenship:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(41, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Civil Status:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(41, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Household:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(41, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Resident Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(41, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Full Name:"
        '
        'txtBirthplace
        '
        Me.txtBirthplace.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthplace.Location = New System.Drawing.Point(132, 275)
        Me.txtBirthplace.Name = "txtBirthplace"
        Me.txtBirthplace.Size = New System.Drawing.Size(288, 26)
        Me.txtBirthplace.TabIndex = 9
        '
        'txtHousehold
        '
        Me.txtHousehold.Enabled = False
        Me.txtHousehold.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHousehold.Location = New System.Drawing.Point(132, 67)
        Me.txtHousehold.Name = "txtHousehold"
        Me.txtHousehold.Size = New System.Drawing.Size(290, 26)
        Me.txtHousehold.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(132, 99)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(290, 26)
        Me.txtName.TabIndex = 2
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnCapture
        '
        Me.btnCapture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCapture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCapture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCapture.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCapture.Image = CType(resources.GetObject("btnCapture.Image"), System.Drawing.Image)
        Me.btnCapture.Location = New System.Drawing.Point(1051, 170)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(60, 35)
        Me.btnCapture.TabIndex = 13
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'ucAddResidence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lvwResidence)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucAddResidence"
        Me.Size = New System.Drawing.Size(1132, 627)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpNonV.ResumeLayout(False)
        Me.grpNonV.PerformLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpVoter.ResumeLayout(False)
        Me.grpVoter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lvwResidence As ListView
    Friend WithEvents btnUpload As Button
    Friend WithEvents picImage As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cboAddress As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cboReligion As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNationality As TextBox
    Friend WithEvents txtBdate As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents txtYrs As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtBirthplace As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents radF As RadioButton
    Friend WithEvents radM As RadioButton
    Friend WithEvents grpNonV As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtGPrecint As TextBox
    Friend WithEvents txtGRelation As TextBox
    Friend WithEvents txtGName As TextBox
    Friend WithEvents grpVoter As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtVPrecint As TextBox
    Friend WithEvents radN As RadioButton
    Friend WithEvents radV As RadioButton
    Friend WithEvents txtID As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtHousehold As TextBox
    Friend WithEvents btnCapture As Button
    Friend WithEvents txtProfession As ComboBox
    Friend WithEvents btnprof As Button
    Friend WithEvents btnSearch As PictureBox
    Friend WithEvents txtResID As TextBox
    Friend WithEvents cboZone As TextBox
End Class
