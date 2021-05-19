<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucManageCT
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAddC = New System.Windows.Forms.Button()
        Me.btnCancelC = New System.Windows.Forms.Button()
        Me.btnDelC = New System.Windows.Forms.Button()
        Me.btnEditC = New System.Windows.Forms.Button()
        Me.btnSaveC = New System.Windows.Forms.Button()
        Me.lvwCertificate = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Zone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnAddP = New System.Windows.Forms.Button()
        Me.btnCancelP = New System.Windows.Forms.Button()
        Me.btnDelP = New System.Windows.Forms.Button()
        Me.btnEditP = New System.Windows.Forms.Button()
        Me.btnSaveP = New System.Windows.Forms.Button()
        Me.lvwPurpose = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1132, 10)
        Me.Panel1.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(561, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Manage Types of Certificates and Certificate purposes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(29, 84)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1075, 508)
        Me.TabControl1.TabIndex = 34
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvwCertificate)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1067, 478)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Types of Certificates"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvwPurpose)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1067, 478)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Certificates Purpose"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtCID)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 120)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Certificate Info."
        '
        'txtCID
        '
        Me.txtCID.Location = New System.Drawing.Point(6, 22)
        Me.txtCID.Multiline = True
        Me.txtCID.Name = "txtCID"
        Me.txtCID.Size = New System.Drawing.Size(52, 17)
        Me.txtCID.TabIndex = 1
        Me.txtCID.Visible = False
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(114, 40)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(258, 23)
        Me.txtName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(46, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Amount to Pay:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(178, 75)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(194, 23)
        Me.txtPrice.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAddC)
        Me.GroupBox2.Controls.Add(Me.btnCancelC)
        Me.GroupBox2.Controls.Add(Me.btnDelC)
        Me.GroupBox2.Controls.Add(Me.btnEditC)
        Me.GroupBox2.Controls.Add(Me.btnSaveC)
        Me.GroupBox2.Location = New System.Drawing.Point(48, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 76)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btnAddC
        '
        Me.btnAddC.BackColor = System.Drawing.Color.Transparent
        Me.btnAddC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAddC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnAddC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddC.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddC.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnAddC.Location = New System.Drawing.Point(5, 22)
        Me.btnAddC.Name = "btnAddC"
        Me.btnAddC.Size = New System.Drawing.Size(79, 36)
        Me.btnAddC.TabIndex = 0
        Me.btnAddC.Text = "ADD"
        Me.btnAddC.UseVisualStyleBackColor = False
        '
        'btnCancelC
        '
        Me.btnCancelC.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelC.Enabled = False
        Me.btnCancelC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancelC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancelC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelC.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelC.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCancelC.Location = New System.Drawing.Point(88, 22)
        Me.btnCancelC.Name = "btnCancelC"
        Me.btnCancelC.Size = New System.Drawing.Size(79, 36)
        Me.btnCancelC.TabIndex = 0
        Me.btnCancelC.Text = "CANCEL"
        Me.btnCancelC.UseVisualStyleBackColor = False
        '
        'btnDelC
        '
        Me.btnDelC.BackColor = System.Drawing.Color.DarkGreen
        Me.btnDelC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelC.Enabled = False
        Me.btnDelC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnDelC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnDelC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelC.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelC.ForeColor = System.Drawing.Color.White
        Me.btnDelC.Location = New System.Drawing.Point(170, 22)
        Me.btnDelC.Name = "btnDelC"
        Me.btnDelC.Size = New System.Drawing.Size(79, 36)
        Me.btnDelC.TabIndex = 0
        Me.btnDelC.Text = "DELETE"
        Me.btnDelC.UseVisualStyleBackColor = False
        '
        'btnEditC
        '
        Me.btnEditC.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEditC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditC.Enabled = False
        Me.btnEditC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditC.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditC.ForeColor = System.Drawing.Color.White
        Me.btnEditC.Location = New System.Drawing.Point(251, 22)
        Me.btnEditC.Name = "btnEditC"
        Me.btnEditC.Size = New System.Drawing.Size(79, 36)
        Me.btnEditC.TabIndex = 0
        Me.btnEditC.Text = "EDIT"
        Me.btnEditC.UseVisualStyleBackColor = False
        '
        'btnSaveC
        '
        Me.btnSaveC.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSaveC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveC.Enabled = False
        Me.btnSaveC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSaveC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnSaveC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveC.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveC.ForeColor = System.Drawing.Color.White
        Me.btnSaveC.Location = New System.Drawing.Point(332, 22)
        Me.btnSaveC.Name = "btnSaveC"
        Me.btnSaveC.Size = New System.Drawing.Size(79, 36)
        Me.btnSaveC.TabIndex = 0
        Me.btnSaveC.Text = "SAVE"
        Me.btnSaveC.UseVisualStyleBackColor = False
        '
        'lvwCertificate
        '
        Me.lvwCertificate.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.Zone, Me.Description})
        Me.lvwCertificate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwCertificate.FullRowSelect = True
        Me.lvwCertificate.GridLines = True
        Me.lvwCertificate.HideSelection = False
        Me.lvwCertificate.Location = New System.Drawing.Point(507, 58)
        Me.lvwCertificate.Name = "lvwCertificate"
        Me.lvwCertificate.Size = New System.Drawing.Size(511, 385)
        Me.lvwCertificate.TabIndex = 3
        Me.lvwCertificate.UseCompatibleStateImageBehavior = False
        Me.lvwCertificate.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "id"
        Me.id.Width = 0
        '
        'Zone
        '
        Me.Zone.Text = "Name of Certificate"
        Me.Zone.Width = 409
        '
        'Description
        '
        Me.Description.Text = "Price"
        Me.Description.Width = 108
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtPID)
        Me.GroupBox3.Location = New System.Drawing.Point(48, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(415, 144)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Certificate Purpose Info."
        '
        'txtPID
        '
        Me.txtPID.Location = New System.Drawing.Point(6, 22)
        Me.txtPID.Multiline = True
        Me.txtPID.Name = "txtPID"
        Me.txtPID.Size = New System.Drawing.Size(52, 17)
        Me.txtPID.TabIndex = 1
        Me.txtPID.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(20, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Purpose:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(20, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Certificate Type:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(158, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 25)
        Me.ComboBox1.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(100, 75)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(298, 49)
        Me.TextBox1.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnAddP)
        Me.GroupBox4.Controls.Add(Me.btnCancelP)
        Me.GroupBox4.Controls.Add(Me.btnDelP)
        Me.GroupBox4.Controls.Add(Me.btnEditP)
        Me.GroupBox4.Controls.Add(Me.btnSaveP)
        Me.GroupBox4.Location = New System.Drawing.Point(48, 226)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(415, 76)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'btnAddP
        '
        Me.btnAddP.BackColor = System.Drawing.Color.Transparent
        Me.btnAddP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAddP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnAddP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddP.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddP.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnAddP.Location = New System.Drawing.Point(5, 22)
        Me.btnAddP.Name = "btnAddP"
        Me.btnAddP.Size = New System.Drawing.Size(79, 36)
        Me.btnAddP.TabIndex = 0
        Me.btnAddP.Text = "ADD"
        Me.btnAddP.UseVisualStyleBackColor = False
        '
        'btnCancelP
        '
        Me.btnCancelP.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelP.Enabled = False
        Me.btnCancelP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancelP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancelP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelP.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelP.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCancelP.Location = New System.Drawing.Point(88, 22)
        Me.btnCancelP.Name = "btnCancelP"
        Me.btnCancelP.Size = New System.Drawing.Size(79, 36)
        Me.btnCancelP.TabIndex = 0
        Me.btnCancelP.Text = "CANCEL"
        Me.btnCancelP.UseVisualStyleBackColor = False
        '
        'btnDelP
        '
        Me.btnDelP.BackColor = System.Drawing.Color.DarkGreen
        Me.btnDelP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelP.Enabled = False
        Me.btnDelP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnDelP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnDelP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelP.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelP.ForeColor = System.Drawing.Color.White
        Me.btnDelP.Location = New System.Drawing.Point(170, 22)
        Me.btnDelP.Name = "btnDelP"
        Me.btnDelP.Size = New System.Drawing.Size(79, 36)
        Me.btnDelP.TabIndex = 0
        Me.btnDelP.Text = "DELETE"
        Me.btnDelP.UseVisualStyleBackColor = False
        '
        'btnEditP
        '
        Me.btnEditP.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEditP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditP.Enabled = False
        Me.btnEditP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditP.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditP.ForeColor = System.Drawing.Color.White
        Me.btnEditP.Location = New System.Drawing.Point(251, 22)
        Me.btnEditP.Name = "btnEditP"
        Me.btnEditP.Size = New System.Drawing.Size(79, 36)
        Me.btnEditP.TabIndex = 0
        Me.btnEditP.Text = "EDIT"
        Me.btnEditP.UseVisualStyleBackColor = False
        '
        'btnSaveP
        '
        Me.btnSaveP.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSaveP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveP.Enabled = False
        Me.btnSaveP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSaveP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnSaveP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveP.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveP.ForeColor = System.Drawing.Color.White
        Me.btnSaveP.Location = New System.Drawing.Point(332, 22)
        Me.btnSaveP.Name = "btnSaveP"
        Me.btnSaveP.Size = New System.Drawing.Size(79, 36)
        Me.btnSaveP.TabIndex = 0
        Me.btnSaveP.Text = "SAVE"
        Me.btnSaveP.UseVisualStyleBackColor = False
        '
        'lvwPurpose
        '
        Me.lvwPurpose.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvwPurpose.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwPurpose.FullRowSelect = True
        Me.lvwPurpose.GridLines = True
        Me.lvwPurpose.HideSelection = False
        Me.lvwPurpose.Location = New System.Drawing.Point(507, 58)
        Me.lvwPurpose.Name = "lvwPurpose"
        Me.lvwPurpose.Size = New System.Drawing.Size(511, 385)
        Me.lvwPurpose.TabIndex = 4
        Me.lvwPurpose.UseCompatibleStateImageBehavior = False
        Me.lvwPurpose.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name of Certificate"
        Me.ColumnHeader2.Width = 280
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Purpose"
        Me.ColumnHeader3.Width = 370
        '
        'ucManageCT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucManageCT"
        Me.Size = New System.Drawing.Size(1132, 627)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPrice As NumericUpDown
    Friend WithEvents txtCID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAddC As Button
    Friend WithEvents btnCancelC As Button
    Friend WithEvents btnDelC As Button
    Friend WithEvents btnEditC As Button
    Friend WithEvents btnSaveC As Button
    Friend WithEvents lvwCertificate As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents Zone As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPID As TextBox
    Friend WithEvents lvwPurpose As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnAddP As Button
    Friend WithEvents btnCancelP As Button
    Friend WithEvents btnDelP As Button
    Friend WithEvents btnEditP As Button
    Friend WithEvents btnSaveP As Button
    Friend WithEvents TextBox1 As TextBox
End Class
