<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucBusiness
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucBusiness))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnClear = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExpired = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSex = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.txtIssued = New System.Windows.Forms.Label()
        Me.txtExpires = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lvwBusiness = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboLine1 = New System.Windows.Forms.ComboBox()
        Me.cboLine = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvwList = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwOwners = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearchOwner = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(484, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "List of Business Establishments && Business Owners"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1132, 10)
        Me.Panel1.TabIndex = 13
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(19, 64)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1098, 550)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnClear)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.lvwBusiness)
        Me.TabPage1.Controls.Add(Me.cboLine1)
        Me.TabPage1.Controls.Add(Me.cboLine)
        Me.TabPage1.Controls.Add(Me.PictureBox3)
        Me.TabPage1.Controls.Add(Me.txtSearch)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1090, 520)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List of Business Establishments"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(876, 16)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(20, 20)
        Me.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnClear.TabIndex = 65
        Me.btnClear.TabStop = False
        Me.btnClear.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnExpired)
        Me.Panel2.Controls.Add(Me.txtAddress)
        Me.Panel2.Controls.Add(Me.txtSex)
        Me.Panel2.Controls.Add(Me.txtContact)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lbl6)
        Me.Panel2.Controls.Add(Me.txtIssued)
        Me.Panel2.Controls.Add(Me.txtExpires)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lbl4)
        Me.Panel2.Controls.Add(Me.lbl3)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.lbl2)
        Me.Panel2.Controls.Add(Me.lbl1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(745, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(335, 472)
        Me.Panel2.TabIndex = 62
        '
        'btnExpired
        '
        Me.btnExpired.FlatAppearance.BorderSize = 2
        Me.btnExpired.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExpired.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExpired.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpired.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpired.ForeColor = System.Drawing.Color.Maroon
        Me.btnExpired.Location = New System.Drawing.Point(18, 368)
        Me.btnExpired.Name = "btnExpired"
        Me.btnExpired.Size = New System.Drawing.Size(200, 34)
        Me.btnExpired.TabIndex = 41
        Me.btnExpired.Text = "CLEARANCE EXPIRED"
        Me.btnExpired.UseVisualStyleBackColor = True
        Me.btnExpired.Visible = False
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(96, 143)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(226, 62)
        Me.txtAddress.TabIndex = 40
        '
        'txtSex
        '
        Me.txtSex.AutoSize = True
        Me.txtSex.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSex.Location = New System.Drawing.Point(92, 91)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(0, 20)
        Me.txtSex.TabIndex = 39
        Me.txtSex.Visible = False
        '
        'txtContact
        '
        Me.txtContact.AutoSize = True
        Me.txtContact.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContact.Location = New System.Drawing.Point(92, 230)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(0, 20)
        Me.txtContact.TabIndex = 39
        Me.txtContact.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(15, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 18)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Sex:"
        Me.Label7.Visible = False
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl6.Location = New System.Drawing.Point(303, 446)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(28, 18)
        Me.lbl6.TabIndex = 39
        Me.lbl6.Text = "Ah"
        Me.lbl6.Visible = False
        '
        'txtIssued
        '
        Me.txtIssued.AutoSize = True
        Me.txtIssued.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssued.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtIssued.Location = New System.Drawing.Point(140, 298)
        Me.txtIssued.Name = "txtIssued"
        Me.txtIssued.Size = New System.Drawing.Size(78, 18)
        Me.txtIssued.TabIndex = 39
        Me.txtIssued.Text = "2/09/2021"
        Me.txtIssued.Visible = False
        '
        'txtExpires
        '
        Me.txtExpires.AutoSize = True
        Me.txtExpires.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpires.ForeColor = System.Drawing.Color.Maroon
        Me.txtExpires.Location = New System.Drawing.Point(140, 329)
        Me.txtExpires.Name = "txtExpires"
        Me.txtExpires.Size = New System.Drawing.Size(78, 18)
        Me.txtExpires.TabIndex = 39
        Me.txtExpires.Text = "2/09/2021"
        Me.txtExpires.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(46, 329)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 18)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Expires on:"
        Me.Label10.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(13, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 18)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Date renewed:"
        Me.Label8.Visible = False
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl4.Location = New System.Drawing.Point(13, 232)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(71, 18)
        Me.lbl4.TabIndex = 39
        Me.lbl4.Text = "Contact:"
        Me.lbl4.Visible = False
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(13, 143)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(70, 18)
        Me.lbl3.TabIndex = 39
        Me.lbl3.Text = "Address:"
        Me.lbl3.Visible = False
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(92, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(0, 20)
        Me.txtName.TabIndex = 39
        Me.txtName.Visible = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(13, 51)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(57, 18)
        Me.lbl2.TabIndex = 39
        Me.lbl2.Text = "Name:"
        Me.lbl2.Visible = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(15, 14)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(177, 18)
        Me.lbl1.TabIndex = 39
        Me.lbl1.Text = "Business Owner Details:"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(335, 472)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGreen
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(981, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 34)
        Me.Button3.TabIndex = 63
        Me.Button3.Text = "PRINT LIST"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'lvwBusiness
        '
        Me.lvwBusiness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwBusiness.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader11})
        Me.lvwBusiness.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwBusiness.FullRowSelect = True
        Me.lvwBusiness.GridLines = True
        Me.lvwBusiness.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwBusiness.HideSelection = False
        Me.lvwBusiness.Location = New System.Drawing.Point(15, 42)
        Me.lvwBusiness.MultiSelect = False
        Me.lvwBusiness.Name = "lvwBusiness"
        Me.lvwBusiness.Size = New System.Drawing.Size(721, 472)
        Me.lvwBusiness.TabIndex = 61
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
        Me.ColumnHeader2.Text = "Name of Business"
        Me.ColumnHeader2.Width = 211
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Business Address"
        Me.ColumnHeader3.Width = 175
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Business Line"
        Me.ColumnHeader4.Width = 168
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Business Permit Number"
        Me.ColumnHeader5.Width = 170
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Remarks"
        Me.ColumnHeader11.Width = 230
        '
        'cboLine1
        '
        Me.cboLine1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLine1.FormattingEnabled = True
        Me.cboLine1.Location = New System.Drawing.Point(743, 13)
        Me.cboLine1.Name = "cboLine1"
        Me.cboLine1.Size = New System.Drawing.Size(127, 25)
        Me.cboLine1.TabIndex = 60
        Me.cboLine1.Visible = False
        '
        'cboLine
        '
        Me.cboLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLine.FormattingEnabled = True
        Me.cboLine.Location = New System.Drawing.Point(610, 13)
        Me.cboLine.Name = "cboLine"
        Me.cboLine.Size = New System.Drawing.Size(127, 25)
        Me.cboLine.TabIndex = 60
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(26, 18)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 59
        Me.PictureBox3.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.HintForeColor = System.Drawing.Color.Empty
        Me.txtSearch.HintText = "    search business establishments here"
        Me.txtSearch.isPassword = False
        Me.txtSearch.LineFocusedColor = System.Drawing.Color.LightGreen
        Me.txtSearch.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.txtSearch.LineMouseHoverColor = System.Drawing.Color.LightGreen
        Me.txtSearch.LineThickness = 3
        Me.txtSearch.Location = New System.Drawing.Point(123, 11)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(384, 29)
        Me.txtSearch.TabIndex = 58
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(517, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Sort by Line:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(51, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Search:"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button2.Location = New System.Drawing.Point(15, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(496, 33)
        Me.Button2.TabIndex = 64
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvwList)
        Me.TabPage2.Controls.Add(Me.lvwOwners)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtSearchOwner)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1090, 520)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Business Owners"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvwList
        '
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.lvwList.Enabled = False
        Me.lvwList.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwList.FullRowSelect = True
        Me.lvwList.GridLines = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(548, 74)
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(525, 425)
        Me.lvwList.TabIndex = 44
        Me.lvwList.UseCompatibleStateImageBehavior = False
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Business Name"
        Me.ColumnHeader10.Width = 190
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Line"
        Me.ColumnHeader14.Width = 162
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Street Located"
        Me.ColumnHeader15.Width = 166
        '
        'lvwOwners
        '
        Me.lvwOwners.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvwOwners.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwOwners.FullRowSelect = True
        Me.lvwOwners.GridLines = True
        Me.lvwOwners.HideSelection = False
        Me.lvwOwners.Location = New System.Drawing.Point(27, 74)
        Me.lvwOwners.Name = "lvwOwners"
        Me.lvwOwners.Size = New System.Drawing.Size(501, 425)
        Me.lvwOwners.TabIndex = 43
        Me.lvwOwners.UseCompatibleStateImageBehavior = False
        Me.lvwOwners.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "id"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Owner Name"
        Me.ColumnHeader7.Width = 217
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Address"
        Me.ColumnHeader8.Width = 146
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Contact Number"
        Me.ColumnHeader9.Width = 141
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(545, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "List of selected owner Business:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(23, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "List of Business Owners:"
        '
        'txtSearchOwner
        '
        Me.txtSearchOwner.BackColor = System.Drawing.Color.White
        Me.txtSearchOwner.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchOwner.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSearchOwner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearchOwner.HintForeColor = System.Drawing.Color.Empty
        Me.txtSearchOwner.HintText = "Search business owner name"
        Me.txtSearchOwner.isPassword = False
        Me.txtSearchOwner.LineFocusedColor = System.Drawing.Color.LightGreen
        Me.txtSearchOwner.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.txtSearchOwner.LineMouseHoverColor = System.Drawing.Color.LightGreen
        Me.txtSearchOwner.LineThickness = 3
        Me.txtSearchOwner.Location = New System.Drawing.Point(130, 42)
        Me.txtSearchOwner.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchOwner.Name = "txtSearchOwner"
        Me.txtSearchOwner.Size = New System.Drawing.Size(387, 29)
        Me.txtSearchOwner.TabIndex = 41
        Me.txtSearchOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(58, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Search:"
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button4.Location = New System.Drawing.Point(29, 39)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(499, 33)
        Me.Button4.TabIndex = 39
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ucBusiness
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucBusiness"
        Me.Size = New System.Drawing.Size(1132, 627)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContact As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents txtName As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lvwBusiness As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents cboLine As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSearchOwner As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents lvwList As ListView
    Friend WithEvents lvwOwners As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents Label6 As Label
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents cboLine1 As ComboBox
    Friend WithEvents btnClear As PictureBox
    Friend WithEvents txtSex As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIssued As Label
    Friend WithEvents txtExpires As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents btnExpired As Button
End Class
