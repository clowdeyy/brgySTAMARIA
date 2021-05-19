<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnResidence = New System.Windows.Forms.Button()
        Me.btnBusiness = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnDisaster = New System.Windows.Forms.Button()
        Me.btnMaint = New System.Windows.Forms.Button()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtID = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnResidence)
        Me.Panel1.Controls.Add(Me.btnBusiness)
        Me.Panel1.Controls.Add(Me.btnReport)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.btnDisaster)
        Me.Panel1.Controls.Add(Me.btnMaint)
        Me.Panel1.Controls.Add(Me.sidePanel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(188, 749)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DarkGreen
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(12, 477)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(174, 55)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "   Log-out"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnResidence
        '
        Me.btnResidence.BackColor = System.Drawing.Color.DarkGreen
        Me.btnResidence.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResidence.FlatAppearance.BorderSize = 0
        Me.btnResidence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnResidence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnResidence.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResidence.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResidence.ForeColor = System.Drawing.Color.White
        Me.btnResidence.Image = CType(resources.GetObject("btnResidence.Image"), System.Drawing.Image)
        Me.btnResidence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResidence.Location = New System.Drawing.Point(12, 237)
        Me.btnResidence.Name = "btnResidence"
        Me.btnResidence.Size = New System.Drawing.Size(174, 55)
        Me.btnResidence.TabIndex = 0
        Me.btnResidence.Text = "   Household && Residents   "
        Me.btnResidence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResidence.UseVisualStyleBackColor = False
        '
        'btnBusiness
        '
        Me.btnBusiness.BackColor = System.Drawing.Color.DarkGreen
        Me.btnBusiness.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBusiness.FlatAppearance.BorderSize = 0
        Me.btnBusiness.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnBusiness.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBusiness.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusiness.ForeColor = System.Drawing.Color.White
        Me.btnBusiness.Image = CType(resources.GetObject("btnBusiness.Image"), System.Drawing.Image)
        Me.btnBusiness.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBusiness.Location = New System.Drawing.Point(12, 294)
        Me.btnBusiness.Name = "btnBusiness"
        Me.btnBusiness.Size = New System.Drawing.Size(174, 55)
        Me.btnBusiness.TabIndex = 0
        Me.btnBusiness.Text = "   Business                Establishments"
        Me.btnBusiness.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBusiness.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.DarkGreen
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(12, 355)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(174, 55)
        Me.btnReport.TabIndex = 0
        Me.btnReport.Text = "   Certification"
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.DarkGreen
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(12, 177)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(174, 55)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnDisaster
        '
        Me.btnDisaster.BackColor = System.Drawing.Color.DarkGreen
        Me.btnDisaster.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDisaster.FlatAppearance.BorderSize = 0
        Me.btnDisaster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnDisaster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnDisaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisaster.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisaster.ForeColor = System.Drawing.Color.White
        Me.btnDisaster.Image = CType(resources.GetObject("btnDisaster.Image"), System.Drawing.Image)
        Me.btnDisaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDisaster.Location = New System.Drawing.Point(12, 539)
        Me.btnDisaster.Name = "btnDisaster"
        Me.btnDisaster.Size = New System.Drawing.Size(174, 55)
        Me.btnDisaster.TabIndex = 0
        Me.btnDisaster.Text = "  Disaster    Support"
        Me.btnDisaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDisaster.UseVisualStyleBackColor = False
        Me.btnDisaster.Visible = False
        '
        'btnMaint
        '
        Me.btnMaint.BackColor = System.Drawing.Color.DarkGreen
        Me.btnMaint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaint.FlatAppearance.BorderSize = 0
        Me.btnMaint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btnMaint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnMaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaint.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaint.ForeColor = System.Drawing.Color.White
        Me.btnMaint.Image = CType(resources.GetObject("btnMaint.Image"), System.Drawing.Image)
        Me.btnMaint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMaint.Location = New System.Drawing.Point(12, 416)
        Me.btnMaint.Name = "btnMaint"
        Me.btnMaint.Size = New System.Drawing.Size(174, 55)
        Me.btnMaint.TabIndex = 0
        Me.btnMaint.Text = "   Data Entry &&       Maintenance"
        Me.btnMaint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaint.UseVisualStyleBackColor = False
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.Black
        Me.sidePanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.sidePanel.Location = New System.Drawing.Point(0, 178)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(12, 55)
        Me.sidePanel.TabIndex = 7
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblTime.Location = New System.Drawing.Point(771, 5)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(106, 23)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "Time_Here"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.LightGray
        Me.panelMain.Location = New System.Drawing.Point(215, 83)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1132, 627)
        Me.panelMain.TabIndex = 7
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(217, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(488, 27)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Barangay Sta.Maria Residents and Business"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(217, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(505, 27)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Establishments Record Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.lblTime)
        Me.Panel2.Controls.Add(Me.txtID)
        Me.Panel2.Controls.Add(Me.txtUser)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(188, 716)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1182, 33)
        Me.Panel2.TabIndex = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(24, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(743, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'txtID
        '
        Me.txtID.AutoSize = True
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.Black
        Me.txtID.Location = New System.Drawing.Point(227, 5)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(145, 23)
        Me.txtID.TabIndex = 8
        Me.txtID.Text = "user ID _______"
        Me.txtID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUser
        '
        Me.txtUser.AutoSize = True
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtUser.Location = New System.Drawing.Point(49, 5)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(133, 23)
        Me.txtUser.TabIndex = 8
        Me.txtUser.Text = "Administrator"
        Me.txtUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDashboard"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnMaint As Button
    Friend WithEvents sidePanel As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents panelMain As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBusiness As Button
    Friend WithEvents btnResidence As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtUser As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnDisaster As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents txtID As Label
End Class
