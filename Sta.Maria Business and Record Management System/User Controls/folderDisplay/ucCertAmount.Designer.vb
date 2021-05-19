<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCertAmount
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
        Me.lvwCertificate = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Zone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.NumericUpDown()
        Me.txtCID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCa = New System.Windows.Forms.Button()
        Me.btnEd = New System.Windows.Forms.Button()
        Me.btnSa = New System.Windows.Forms.Button()
        Me.lvwCap = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCapname = New System.Windows.Forms.TextBox()
        Me.txtCapID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.Label2.Size = New System.Drawing.Size(597, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Manage Certificates Charges && Certificate Captain Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lvwCertificate
        '
        Me.lvwCertificate.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.Zone, Me.Description})
        Me.lvwCertificate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwCertificate.FullRowSelect = True
        Me.lvwCertificate.GridLines = True
        Me.lvwCertificate.HideSelection = False
        Me.lvwCertificate.Location = New System.Drawing.Point(483, 36)
        Me.lvwCertificate.Name = "lvwCertificate"
        Me.lvwCertificate.Size = New System.Drawing.Size(511, 385)
        Me.lvwCertificate.TabIndex = 36
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
        Me.Description.Width = 93
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 76)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Enabled = False
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCancel.Location = New System.Drawing.Point(67, 22)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 36)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Enabled = False
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(152, 22)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(79, 36)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "UPDATE"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Enabled = False
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(237, 22)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 36)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboType)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtCID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 120)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Certificate Info."
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(114, 39)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(258, 25)
        Me.cboType.TabIndex = 3
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(178, 75)
        Me.txtPrice.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(194, 23)
        Me.txtPrice.TabIndex = 2
        '
        'txtCID
        '
        Me.txtCID.Location = New System.Drawing.Point(6, 22)
        Me.txtCID.Multiline = True
        Me.txtCID.Name = "txtCID"
        Me.txtCID.Size = New System.Drawing.Size(21, 17)
        Me.txtCID.TabIndex = 1
        Me.txtCID.Visible = False
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(55, 91)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1026, 503)
        Me.TabControl1.TabIndex = 37
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvwCertificate)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1018, 473)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Certificates amount"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.lvwCap)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1018, 473)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Certificate Captain name"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnCa)
        Me.GroupBox4.Controls.Add(Me.btnEd)
        Me.GroupBox4.Controls.Add(Me.btnSa)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 172)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(415, 76)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        '
        'btnCa
        '
        Me.btnCa.BackColor = System.Drawing.Color.Transparent
        Me.btnCa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCa.Enabled = False
        Me.btnCa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnCa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCa.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCa.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCa.Location = New System.Drawing.Point(67, 22)
        Me.btnCa.Name = "btnCa"
        Me.btnCa.Size = New System.Drawing.Size(79, 36)
        Me.btnCa.TabIndex = 0
        Me.btnCa.Text = "CANCEL"
        Me.btnCa.UseVisualStyleBackColor = False
        '
        'btnEd
        '
        Me.btnEd.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEd.Enabled = False
        Me.btnEd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnEd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnEd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEd.ForeColor = System.Drawing.Color.White
        Me.btnEd.Location = New System.Drawing.Point(152, 22)
        Me.btnEd.Name = "btnEd"
        Me.btnEd.Size = New System.Drawing.Size(79, 36)
        Me.btnEd.TabIndex = 0
        Me.btnEd.Text = "UPDATE"
        Me.btnEd.UseVisualStyleBackColor = False
        '
        'btnSa
        '
        Me.btnSa.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSa.Enabled = False
        Me.btnSa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnSa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnSa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSa.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSa.ForeColor = System.Drawing.Color.White
        Me.btnSa.Location = New System.Drawing.Point(237, 22)
        Me.btnSa.Name = "btnSa"
        Me.btnSa.Size = New System.Drawing.Size(79, 36)
        Me.btnSa.TabIndex = 0
        Me.btnSa.Text = "SAVE"
        Me.btnSa.UseVisualStyleBackColor = False
        '
        'lvwCap
        '
        Me.lvwCap.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvwCap.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwCap.FullRowSelect = True
        Me.lvwCap.GridLines = True
        Me.lvwCap.HideSelection = False
        Me.lvwCap.Location = New System.Drawing.Point(486, 52)
        Me.lvwCap.Name = "lvwCap"
        Me.lvwCap.Size = New System.Drawing.Size(511, 340)
        Me.lvwCap.TabIndex = 38
        Me.lvwCap.UseCompatibleStateImageBehavior = False
        Me.lvwCap.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Captain Name"
        Me.ColumnHeader2.Width = 506
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCapname)
        Me.GroupBox3.Controls.Add(Me.txtCapID)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(415, 103)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Captain Name"
        '
        'txtCapname
        '
        Me.txtCapname.Location = New System.Drawing.Point(107, 39)
        Me.txtCapname.Multiline = True
        Me.txtCapname.Name = "txtCapname"
        Me.txtCapname.Size = New System.Drawing.Size(276, 46)
        Me.txtCapname.TabIndex = 2
        '
        'txtCapID
        '
        Me.txtCapID.Location = New System.Drawing.Point(6, 22)
        Me.txtCapID.Multiline = True
        Me.txtCapID.Name = "txtCapID"
        Me.txtCapID.Size = New System.Drawing.Size(21, 17)
        Me.txtCapID.TabIndex = 1
        Me.txtCapID.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(39, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Name:"
        '
        'ucCertAmount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucCertAmount"
        Me.Size = New System.Drawing.Size(1132, 627)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lvwCertificate As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents Zone As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtPrice As NumericUpDown
    Friend WithEvents txtCID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCa As Button
    Friend WithEvents btnEd As Button
    Friend WithEvents btnSa As Button
    Friend WithEvents lvwCap As ListView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCapname As TextBox
    Friend WithEvents txtCapID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
