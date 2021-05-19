<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucAddZones
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvwZone = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Zone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAddZ = New System.Windows.Forms.Button()
        Me.btnCancelZ = New System.Windows.Forms.Button()
        Me.btnDelZ = New System.Windows.Forms.Button()
        Me.btnEditZ = New System.Windows.Forms.Button()
        Me.btnSaveZ = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtZone = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtResID = New System.Windows.Forms.TextBox()
        Me.txtZoneID = New System.Windows.Forms.TextBox()
        Me.txtPres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvwStreets = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAddS = New System.Windows.Forms.Button()
        Me.btnCancelS = New System.Windows.Forms.Button()
        Me.btnDelS = New System.Windows.Forms.Button()
        Me.btnEditS = New System.Windows.Forms.Button()
        Me.btnSaveS = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboZone = New System.Windows.Forms.ComboBox()
        Me.txtStreetID = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.Panel1.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Manage Zone and Streets"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(19, 73)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1097, 532)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvwZone)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1089, 502)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Manage Zone"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lvwZone
        '
        Me.lvwZone.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.Zone, Me.Description})
        Me.lvwZone.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwZone.FullRowSelect = True
        Me.lvwZone.GridLines = True
        Me.lvwZone.HideSelection = False
        Me.lvwZone.Location = New System.Drawing.Point(524, 51)
        Me.lvwZone.Name = "lvwZone"
        Me.lvwZone.Size = New System.Drawing.Size(511, 385)
        Me.lvwZone.TabIndex = 1
        Me.lvwZone.UseCompatibleStateImageBehavior = False
        Me.lvwZone.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "id"
        Me.id.Width = 0
        '
        'Zone
        '
        Me.Zone.Text = "Zone"
        Me.Zone.Width = 151
        '
        'Description
        '
        Me.Description.Text = "President"
        Me.Description.Width = 351
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAddZ)
        Me.GroupBox2.Controls.Add(Me.btnCancelZ)
        Me.GroupBox2.Controls.Add(Me.btnDelZ)
        Me.GroupBox2.Controls.Add(Me.btnEditZ)
        Me.GroupBox2.Controls.Add(Me.btnSaveZ)
        Me.GroupBox2.Location = New System.Drawing.Point(69, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 76)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'btnAddZ
        '
        Me.btnAddZ.BackColor = System.Drawing.Color.Transparent
        Me.btnAddZ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddZ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAddZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnAddZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddZ.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddZ.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnAddZ.Location = New System.Drawing.Point(5, 22)
        Me.btnAddZ.Name = "btnAddZ"
        Me.btnAddZ.Size = New System.Drawing.Size(79, 36)
        Me.btnAddZ.TabIndex = 0
        Me.btnAddZ.Text = "NEW"
        Me.btnAddZ.UseVisualStyleBackColor = False
        '
        'btnCancelZ
        '
        Me.btnCancelZ.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelZ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelZ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancelZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancelZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelZ.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelZ.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCancelZ.Location = New System.Drawing.Point(88, 22)
        Me.btnCancelZ.Name = "btnCancelZ"
        Me.btnCancelZ.Size = New System.Drawing.Size(79, 36)
        Me.btnCancelZ.TabIndex = 0
        Me.btnCancelZ.Text = "CANCEL"
        Me.btnCancelZ.UseVisualStyleBackColor = False
        '
        'btnDelZ
        '
        Me.btnDelZ.BackColor = System.Drawing.Color.DarkGreen
        Me.btnDelZ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelZ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnDelZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnDelZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelZ.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelZ.ForeColor = System.Drawing.Color.White
        Me.btnDelZ.Location = New System.Drawing.Point(170, 22)
        Me.btnDelZ.Name = "btnDelZ"
        Me.btnDelZ.Size = New System.Drawing.Size(79, 36)
        Me.btnDelZ.TabIndex = 0
        Me.btnDelZ.Text = "DELETE"
        Me.btnDelZ.UseVisualStyleBackColor = False
        '
        'btnEditZ
        '
        Me.btnEditZ.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEditZ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditZ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditZ.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditZ.ForeColor = System.Drawing.Color.White
        Me.btnEditZ.Location = New System.Drawing.Point(251, 22)
        Me.btnEditZ.Name = "btnEditZ"
        Me.btnEditZ.Size = New System.Drawing.Size(79, 36)
        Me.btnEditZ.TabIndex = 0
        Me.btnEditZ.Text = "UPDATE"
        Me.btnEditZ.UseVisualStyleBackColor = False
        '
        'btnSaveZ
        '
        Me.btnSaveZ.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSaveZ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveZ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSaveZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnSaveZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveZ.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveZ.ForeColor = System.Drawing.Color.White
        Me.btnSaveZ.Location = New System.Drawing.Point(332, 22)
        Me.btnSaveZ.Name = "btnSaveZ"
        Me.btnSaveZ.Size = New System.Drawing.Size(79, 36)
        Me.btnSaveZ.TabIndex = 0
        Me.btnSaveZ.Text = "SAVE"
        Me.btnSaveZ.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtZone)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtResID)
        Me.GroupBox1.Controls.Add(Me.txtZoneID)
        Me.GroupBox1.Controls.Add(Me.txtPres)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Zone Info."
        '
        'txtZone
        '
        Me.txtZone.Location = New System.Drawing.Point(130, 31)
        Me.txtZone.Name = "txtZone"
        Me.txtZone.Size = New System.Drawing.Size(258, 23)
        Me.txtZone.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSearch.Location = New System.Drawing.Point(352, 66)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(36, 25)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "•••"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtResID
        '
        Me.txtResID.Location = New System.Drawing.Point(4, 70)
        Me.txtResID.Multiline = True
        Me.txtResID.Name = "txtResID"
        Me.txtResID.Size = New System.Drawing.Size(25, 22)
        Me.txtResID.TabIndex = 1
        Me.txtResID.Visible = False
        '
        'txtZoneID
        '
        Me.txtZoneID.Location = New System.Drawing.Point(4, 96)
        Me.txtZoneID.Multiline = True
        Me.txtZoneID.Name = "txtZoneID"
        Me.txtZoneID.Size = New System.Drawing.Size(25, 22)
        Me.txtZoneID.TabIndex = 1
        Me.txtZoneID.Visible = False
        '
        'txtPres
        '
        Me.txtPres.Enabled = False
        Me.txtPres.Location = New System.Drawing.Point(130, 66)
        Me.txtPres.Multiline = True
        Me.txtPres.Name = "txtPres"
        Me.txtPres.Size = New System.Drawing.Size(219, 25)
        Me.txtPres.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(42, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "President:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(73, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Zone:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvwStreets)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1089, 502)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Manage Streets"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvwStreets
        '
        Me.lvwStreets.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvwStreets.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwStreets.FullRowSelect = True
        Me.lvwStreets.GridLines = True
        Me.lvwStreets.HideSelection = False
        Me.lvwStreets.Location = New System.Drawing.Point(524, 51)
        Me.lvwStreets.Name = "lvwStreets"
        Me.lvwStreets.Size = New System.Drawing.Size(511, 385)
        Me.lvwStreets.TabIndex = 4
        Me.lvwStreets.UseCompatibleStateImageBehavior = False
        Me.lvwStreets.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Street Name"
        Me.ColumnHeader2.Width = 388
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAddS)
        Me.GroupBox3.Controls.Add(Me.btnCancelS)
        Me.GroupBox3.Controls.Add(Me.btnDelS)
        Me.GroupBox3.Controls.Add(Me.btnEditS)
        Me.GroupBox3.Controls.Add(Me.btnSaveS)
        Me.GroupBox3.Location = New System.Drawing.Point(69, 202)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(415, 76)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'btnAddS
        '
        Me.btnAddS.BackColor = System.Drawing.Color.Transparent
        Me.btnAddS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnAddS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnAddS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddS.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnAddS.Location = New System.Drawing.Point(5, 24)
        Me.btnAddS.Name = "btnAddS"
        Me.btnAddS.Size = New System.Drawing.Size(79, 36)
        Me.btnAddS.TabIndex = 0
        Me.btnAddS.Text = "NEW"
        Me.btnAddS.UseVisualStyleBackColor = False
        '
        'btnCancelS
        '
        Me.btnCancelS.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancelS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancelS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelS.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelS.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCancelS.Location = New System.Drawing.Point(88, 24)
        Me.btnCancelS.Name = "btnCancelS"
        Me.btnCancelS.Size = New System.Drawing.Size(79, 36)
        Me.btnCancelS.TabIndex = 0
        Me.btnCancelS.Text = "CANCEL"
        Me.btnCancelS.UseVisualStyleBackColor = False
        '
        'btnDelS
        '
        Me.btnDelS.BackColor = System.Drawing.Color.DarkGreen
        Me.btnDelS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnDelS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnDelS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelS.ForeColor = System.Drawing.Color.White
        Me.btnDelS.Location = New System.Drawing.Point(170, 24)
        Me.btnDelS.Name = "btnDelS"
        Me.btnDelS.Size = New System.Drawing.Size(79, 36)
        Me.btnDelS.TabIndex = 0
        Me.btnDelS.Text = "DELETE"
        Me.btnDelS.UseVisualStyleBackColor = False
        '
        'btnEditS
        '
        Me.btnEditS.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEditS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnEditS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditS.ForeColor = System.Drawing.Color.White
        Me.btnEditS.Location = New System.Drawing.Point(251, 24)
        Me.btnEditS.Name = "btnEditS"
        Me.btnEditS.Size = New System.Drawing.Size(79, 36)
        Me.btnEditS.TabIndex = 0
        Me.btnEditS.Text = "UPDATE"
        Me.btnEditS.UseVisualStyleBackColor = False
        '
        'btnSaveS
        '
        Me.btnSaveS.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSaveS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSaveS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnSaveS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveS.ForeColor = System.Drawing.Color.White
        Me.btnSaveS.Location = New System.Drawing.Point(332, 24)
        Me.btnSaveS.Name = "btnSaveS"
        Me.btnSaveS.Size = New System.Drawing.Size(79, 36)
        Me.btnSaveS.TabIndex = 0
        Me.btnSaveS.Text = "SAVE"
        Me.btnSaveS.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboZone)
        Me.GroupBox4.Controls.Add(Me.txtStreetID)
        Me.GroupBox4.Controls.Add(Me.txtStreet)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(69, 44)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(415, 134)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Street Info."
        '
        'cboZone
        '
        Me.cboZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZone.FormattingEnabled = True
        Me.cboZone.Location = New System.Drawing.Point(130, 25)
        Me.cboZone.Name = "cboZone"
        Me.cboZone.Size = New System.Drawing.Size(267, 25)
        Me.cboZone.TabIndex = 3
        '
        'txtStreetID
        '
        Me.txtStreetID.Location = New System.Drawing.Point(5, 106)
        Me.txtStreetID.Multiline = True
        Me.txtStreetID.Name = "txtStreetID"
        Me.txtStreetID.Size = New System.Drawing.Size(52, 22)
        Me.txtStreetID.TabIndex = 1
        Me.txtStreetID.Visible = False
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(130, 60)
        Me.txtStreet.Multiline = True
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(267, 57)
        Me.txtStreet.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(17, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Street Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(73, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Zone:"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Zone No."
        Me.ColumnHeader3.Width = 116
        '
        'ucAddZones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucAddZones"
        Me.Size = New System.Drawing.Size(1132, 627)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAddZ As Button
    Friend WithEvents btnCancelZ As Button
    Friend WithEvents btnDelZ As Button
    Friend WithEvents btnEditZ As Button
    Friend WithEvents btnSaveZ As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtZoneID As TextBox
    Friend WithEvents txtPres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lvwZone As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents Zone As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents lvwStreets As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAddS As Button
    Friend WithEvents btnCancelS As Button
    Friend WithEvents btnDelS As Button
    Friend WithEvents btnEditS As Button
    Friend WithEvents btnSaveS As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cboZone As ComboBox
    Friend WithEvents txtStreetID As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents txtResID As TextBox
    Friend WithEvents txtZone As TextBox
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
