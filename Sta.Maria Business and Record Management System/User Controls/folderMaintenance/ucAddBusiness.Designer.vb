<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucAddBusiness
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucAddBusiness))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lvwBusiness = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboAddress = New System.Windows.Forms.ComboBox()
        Me.cboLine = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtBContact = New System.Windows.Forms.TextBox()
        Me.txtVehicle = New System.Windows.Forms.TextBox()
        Me.txtPermit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.PictureBox()
        Me.radF = New System.Windows.Forms.RadioButton()
        Me.txtboID = New System.Windows.Forms.TextBox()
        Me.radM = New System.Windows.Forms.RadioButton()
        Me.txtOContact = New System.Windows.Forms.TextBox()
        Me.txtOName = New System.Windows.Forms.TextBox()
        Me.txtOAddress = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvwLine = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnAddL = New System.Windows.Forms.Button()
        Me.btnCancelL = New System.Windows.Forms.Button()
        Me.btnDelL = New System.Windows.Forms.Button()
        Me.btnEditL = New System.Windows.Forms.Button()
        Me.btnSaveL = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtLineID = New System.Windows.Forms.TextBox()
        Me.txtLineDesc = New System.Windows.Forms.TextBox()
        Me.txtLineName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Manage Business"
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(19, 64)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1094, 550)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtSearch)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.lvwBusiness)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1086, 520)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Business Establishments"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.HintForeColor = System.Drawing.Color.Empty
        Me.txtSearch.HintText = "     search business name here"
        Me.txtSearch.isPassword = False
        Me.txtSearch.LineFocusedColor = System.Drawing.Color.LightGreen
        Me.txtSearch.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.txtSearch.LineMouseHoverColor = System.Drawing.Color.LightGreen
        Me.txtSearch.LineThickness = 3
        Me.txtSearch.Location = New System.Drawing.Point(529, 8)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(538, 29)
        Me.txtSearch.TabIndex = 25
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(454, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 18)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Search:"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button2.Location = New System.Drawing.Point(448, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(632, 33)
        Me.Button2.TabIndex = 27
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Controls.Add(Me.btnCancel)
        Me.GroupBox3.Controls.Add(Me.btnDel)
        Me.GroupBox3.Controls.Add(Me.btnEdit)
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 428)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(435, 72)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
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
        Me.btnAdd.Location = New System.Drawing.Point(4, 19)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 42)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "NEW"
        Me.btnAdd.UseVisualStyleBackColor = False
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
        Me.btnCancel.Location = New System.Drawing.Point(91, 19)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 42)
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
        Me.btnDel.Location = New System.Drawing.Point(177, 19)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(82, 42)
        Me.btnDel.TabIndex = 0
        Me.btnDel.Text = "DELETE"
        Me.btnDel.UseVisualStyleBackColor = False
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
        Me.btnEdit.Location = New System.Drawing.Point(262, 19)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(82, 42)
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
        Me.btnSave.Location = New System.Drawing.Point(347, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 42)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lvwBusiness
        '
        Me.lvwBusiness.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwBusiness.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwBusiness.FullRowSelect = True
        Me.lvwBusiness.GridLines = True
        Me.lvwBusiness.HideSelection = False
        Me.lvwBusiness.Location = New System.Drawing.Point(448, 40)
        Me.lvwBusiness.Name = "lvwBusiness"
        Me.lvwBusiness.Size = New System.Drawing.Size(632, 465)
        Me.lvwBusiness.TabIndex = 30
        Me.lvwBusiness.UseCompatibleStateImageBehavior = False
        Me.lvwBusiness.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Business Name"
        Me.ColumnHeader2.Width = 242
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Business Line"
        Me.ColumnHeader3.Width = 123
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Business Address"
        Me.ColumnHeader4.Width = 321
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cboAddress)
        Me.GroupBox1.Controls.Add(Me.cboLine)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtBContact)
        Me.GroupBox1.Controls.Add(Me.txtVehicle)
        Me.GroupBox1.Controls.Add(Me.txtPermit)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtBName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 244)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Business Information"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button1.Location = New System.Drawing.Point(402, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 26)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboAddress
        '
        Me.cboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddress.DropDownWidth = 300
        Me.cboAddress.FormattingEnabled = True
        Me.cboAddress.ItemHeight = 17
        Me.cboAddress.Location = New System.Drawing.Point(145, 104)
        Me.cboAddress.Name = "cboAddress"
        Me.cboAddress.Size = New System.Drawing.Size(251, 25)
        Me.cboAddress.TabIndex = 3
        '
        'cboLine
        '
        Me.cboLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLine.FormattingEnabled = True
        Me.cboLine.Location = New System.Drawing.Point(145, 75)
        Me.cboLine.Name = "cboLine"
        Me.cboLine.Size = New System.Drawing.Size(284, 25)
        Me.cboLine.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(386, 16)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(43, 10)
        Me.txtID.TabIndex = 7
        Me.txtID.Visible = False
        '
        'txtBContact
        '
        Me.txtBContact.Location = New System.Drawing.Point(145, 193)
        Me.txtBContact.Name = "txtBContact"
        Me.txtBContact.Size = New System.Drawing.Size(284, 23)
        Me.txtBContact.TabIndex = 6
        '
        'txtVehicle
        '
        Me.txtVehicle.Location = New System.Drawing.Point(145, 164)
        Me.txtVehicle.Name = "txtVehicle"
        Me.txtVehicle.Size = New System.Drawing.Size(284, 23)
        Me.txtVehicle.TabIndex = 5
        '
        'txtPermit
        '
        Me.txtPermit.Location = New System.Drawing.Point(145, 135)
        Me.txtPermit.Name = "txtPermit"
        Me.txtPermit.Size = New System.Drawing.Size(284, 23)
        Me.txtPermit.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(39, 198)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Contact No.:"
        '
        'txtBName
        '
        Me.txtBName.Location = New System.Drawing.Point(145, 28)
        Me.txtBName.Multiline = True
        Me.txtBName.Name = "txtBName"
        Me.txtBName.Size = New System.Drawing.Size(284, 41)
        Me.txtBName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(40, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Vehicle No.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(0, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Business Permit No.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Business Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(34, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Business Line:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Business Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.radF)
        Me.GroupBox2.Controls.Add(Me.txtboID)
        Me.GroupBox2.Controls.Add(Me.radM)
        Me.GroupBox2.Controls.Add(Me.txtOContact)
        Me.GroupBox2.Controls.Add(Me.txtOName)
        Me.GroupBox2.Controls.Add(Me.txtOAddress)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 268)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 140)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Business Owner Information"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Enabled = False
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(406, 29)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(20, 20)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnSearch.TabIndex = 43
        Me.btnSearch.TabStop = False
        '
        'radF
        '
        Me.radF.AutoSize = True
        Me.radF.Location = New System.Drawing.Point(356, 106)
        Me.radF.Name = "radF"
        Me.radF.Size = New System.Drawing.Size(73, 21)
        Me.radF.TabIndex = 10
        Me.radF.TabStop = True
        Me.radF.Text = "Female"
        Me.radF.UseVisualStyleBackColor = True
        '
        'txtboID
        '
        Me.txtboID.Location = New System.Drawing.Point(6, 56)
        Me.txtboID.Multiline = True
        Me.txtboID.Name = "txtboID"
        Me.txtboID.Size = New System.Drawing.Size(57, 19)
        Me.txtboID.TabIndex = 7
        Me.txtboID.Visible = False
        '
        'radM
        '
        Me.radM.AutoSize = True
        Me.radM.Location = New System.Drawing.Point(303, 106)
        Me.radM.Name = "radM"
        Me.radM.Size = New System.Drawing.Size(57, 21)
        Me.radM.TabIndex = 10
        Me.radM.TabStop = True
        Me.radM.Text = "Male"
        Me.radM.UseVisualStyleBackColor = True
        '
        'txtOContact
        '
        Me.txtOContact.Location = New System.Drawing.Point(145, 104)
        Me.txtOContact.Name = "txtOContact"
        Me.txtOContact.Size = New System.Drawing.Size(120, 23)
        Me.txtOContact.TabIndex = 9
        '
        'txtOName
        '
        Me.txtOName.Location = New System.Drawing.Point(145, 28)
        Me.txtOName.Name = "txtOName"
        Me.txtOName.Size = New System.Drawing.Size(255, 23)
        Me.txtOName.TabIndex = 7
        '
        'txtOAddress
        '
        Me.txtOAddress.Location = New System.Drawing.Point(145, 57)
        Me.txtOAddress.Multiline = True
        Me.txtOAddress.Name = "txtOAddress"
        Me.txtOAddress.Size = New System.Drawing.Size(284, 41)
        Me.txtOAddress.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(266, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Sex:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(40, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Contact No.:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(69, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Address:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(54, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 18)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Full Name:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvwLine)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1086, 520)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Business Line"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvwLine
        '
        Me.lvwLine.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvwLine.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwLine.FullRowSelect = True
        Me.lvwLine.GridLines = True
        Me.lvwLine.HideSelection = False
        Me.lvwLine.Location = New System.Drawing.Point(525, 39)
        Me.lvwLine.Name = "lvwLine"
        Me.lvwLine.Size = New System.Drawing.Size(520, 418)
        Me.lvwLine.TabIndex = 33
        Me.lvwLine.UseCompatibleStateImageBehavior = False
        Me.lvwLine.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "id"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Business Line Name"
        Me.ColumnHeader6.Width = 212
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Description"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 309
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnAddL)
        Me.GroupBox5.Controls.Add(Me.btnCancelL)
        Me.GroupBox5.Controls.Add(Me.btnDelL)
        Me.GroupBox5.Controls.Add(Me.btnEditL)
        Me.GroupBox5.Controls.Add(Me.btnSaveL)
        Me.GroupBox5.Location = New System.Drawing.Point(43, 178)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(457, 72)
        Me.GroupBox5.TabIndex = 32
        Me.GroupBox5.TabStop = False
        '
        'btnAddL
        '
        Me.btnAddL.BackColor = System.Drawing.Color.Transparent
        Me.btnAddL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAddL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnAddL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddL.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddL.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnAddL.Location = New System.Drawing.Point(6, 19)
        Me.btnAddL.Name = "btnAddL"
        Me.btnAddL.Size = New System.Drawing.Size(87, 42)
        Me.btnAddL.TabIndex = 0
        Me.btnAddL.Text = "NEW"
        Me.btnAddL.UseVisualStyleBackColor = False
        '
        'btnCancelL
        '
        Me.btnCancelL.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancelL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancelL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelL.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelL.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCancelL.Location = New System.Drawing.Point(98, 19)
        Me.btnCancelL.Name = "btnCancelL"
        Me.btnCancelL.Size = New System.Drawing.Size(87, 42)
        Me.btnCancelL.TabIndex = 0
        Me.btnCancelL.Text = "CANCEL"
        Me.btnCancelL.UseVisualStyleBackColor = False
        '
        'btnDelL
        '
        Me.btnDelL.BackColor = System.Drawing.Color.DarkGreen
        Me.btnDelL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnDelL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnDelL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelL.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelL.ForeColor = System.Drawing.Color.White
        Me.btnDelL.Location = New System.Drawing.Point(188, 19)
        Me.btnDelL.Name = "btnDelL"
        Me.btnDelL.Size = New System.Drawing.Size(87, 42)
        Me.btnDelL.TabIndex = 0
        Me.btnDelL.Text = "DELETE"
        Me.btnDelL.UseVisualStyleBackColor = False
        '
        'btnEditL
        '
        Me.btnEditL.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEditL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditL.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditL.ForeColor = System.Drawing.Color.White
        Me.btnEditL.Location = New System.Drawing.Point(277, 19)
        Me.btnEditL.Name = "btnEditL"
        Me.btnEditL.Size = New System.Drawing.Size(87, 42)
        Me.btnEditL.TabIndex = 0
        Me.btnEditL.Text = "UPDATE"
        Me.btnEditL.UseVisualStyleBackColor = False
        '
        'btnSaveL
        '
        Me.btnSaveL.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSaveL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSaveL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnSaveL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveL.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveL.ForeColor = System.Drawing.Color.White
        Me.btnSaveL.Location = New System.Drawing.Point(366, 19)
        Me.btnSaveL.Name = "btnSaveL"
        Me.btnSaveL.Size = New System.Drawing.Size(87, 42)
        Me.btnSaveL.TabIndex = 10
        Me.btnSaveL.Text = "SAVE"
        Me.btnSaveL.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtLineID)
        Me.GroupBox4.Controls.Add(Me.txtLineDesc)
        Me.GroupBox4.Controls.Add(Me.txtLineName)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(43, 34)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(457, 127)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Business Line Info."
        '
        'txtLineID
        '
        Me.txtLineID.Location = New System.Drawing.Point(6, 104)
        Me.txtLineID.Name = "txtLineID"
        Me.txtLineID.Size = New System.Drawing.Size(44, 23)
        Me.txtLineID.TabIndex = 0
        Me.txtLineID.Visible = False
        '
        'txtLineDesc
        '
        Me.txtLineDesc.Location = New System.Drawing.Point(176, 60)
        Me.txtLineDesc.Multiline = True
        Me.txtLineDesc.Name = "txtLineDesc"
        Me.txtLineDesc.Size = New System.Drawing.Size(270, 41)
        Me.txtLineDesc.TabIndex = 2
        '
        'txtLineName
        '
        Me.txtLineName.Location = New System.Drawing.Point(176, 31)
        Me.txtLineName.Name = "txtLineName"
        Me.txtLineName.Size = New System.Drawing.Size(270, 23)
        Me.txtLineName.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(79, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 18)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Description"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(16, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 18)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Business Line Name:"
        '
        'ucAddBusiness
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucAddBusiness"
        Me.Size = New System.Drawing.Size(1132, 627)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lvwBusiness As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboAddress As ComboBox
    Friend WithEvents cboLine As ComboBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtBContact As TextBox
    Friend WithEvents txtVehicle As TextBox
    Friend WithEvents txtPermit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtOContact As TextBox
    Friend WithEvents txtOName As TextBox
    Friend WithEvents txtOAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lvwLine As ListView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnAddL As Button
    Friend WithEvents btnCancelL As Button
    Friend WithEvents btnDelL As Button
    Friend WithEvents btnEditL As Button
    Friend WithEvents btnSaveL As Button
    Friend WithEvents txtLineID As TextBox
    Friend WithEvents txtLineDesc As TextBox
    Friend WithEvents txtLineName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents radF As RadioButton
    Friend WithEvents radM As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSearch As PictureBox
    Friend WithEvents txtboID As TextBox
    Friend WithEvents Button1 As Button
End Class
