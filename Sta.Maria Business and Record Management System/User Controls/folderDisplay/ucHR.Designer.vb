<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucHR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucHR))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnHouse = New System.Windows.Forms.Button()
        Me.btnRes = New System.Windows.Forms.Button()
        Me.btnHousehold = New System.Windows.Forms.Button()
        Me.btnResidence = New System.Windows.Forms.Button()
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
        Me.Label2.Size = New System.Drawing.Size(277, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Household and Residence"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(212, 261)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(299, 66)
        Me.TextBox2.TabIndex = 28
        Me.TextBox2.Text = "Displays list of households and its household members."
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(727, 260)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(262, 65)
        Me.TextBox1.TabIndex = 29
        Me.TextBox1.Text = "Displays list of individual resident info, blacklisted residents, and deceased re" &
    "sidents."
        '
        'btnHouse
        '
        Me.btnHouse.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHouse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHouse.FlatAppearance.BorderSize = 0
        Me.btnHouse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.btnHouse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHouse.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHouse.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnHouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHouse.Location = New System.Drawing.Point(207, 225)
        Me.btnHouse.Name = "btnHouse"
        Me.btnHouse.Size = New System.Drawing.Size(317, 33)
        Me.btnHouse.TabIndex = 24
        Me.btnHouse.Text = "Household Information"
        Me.btnHouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHouse.UseVisualStyleBackColor = False
        '
        'btnRes
        '
        Me.btnRes.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRes.FlatAppearance.BorderSize = 0
        Me.btnRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.btnRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRes.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRes.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRes.Location = New System.Drawing.Point(722, 224)
        Me.btnRes.Name = "btnRes"
        Me.btnRes.Size = New System.Drawing.Size(243, 33)
        Me.btnRes.TabIndex = 25
        Me.btnRes.Text = "Residents Information"
        Me.btnRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRes.UseVisualStyleBackColor = False
        '
        'btnHousehold
        '
        Me.btnHousehold.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHousehold.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHousehold.FlatAppearance.BorderSize = 0
        Me.btnHousehold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.btnHousehold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnHousehold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHousehold.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHousehold.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnHousehold.Image = CType(resources.GetObject("btnHousehold.Image"), System.Drawing.Image)
        Me.btnHousehold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHousehold.Location = New System.Drawing.Point(116, 225)
        Me.btnHousehold.Name = "btnHousehold"
        Me.btnHousehold.Size = New System.Drawing.Size(85, 91)
        Me.btnHousehold.TabIndex = 26
        Me.btnHousehold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHousehold.UseVisualStyleBackColor = False
        '
        'btnResidence
        '
        Me.btnResidence.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnResidence.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResidence.FlatAppearance.BorderSize = 0
        Me.btnResidence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.btnResidence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnResidence.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResidence.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResidence.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnResidence.Image = CType(resources.GetObject("btnResidence.Image"), System.Drawing.Image)
        Me.btnResidence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResidence.Location = New System.Drawing.Point(631, 224)
        Me.btnResidence.Name = "btnResidence"
        Me.btnResidence.Size = New System.Drawing.Size(85, 91)
        Me.btnResidence.TabIndex = 27
        Me.btnResidence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResidence.UseVisualStyleBackColor = False
        '
        'ucHR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnHouse)
        Me.Controls.Add(Me.btnRes)
        Me.Controls.Add(Me.btnHousehold)
        Me.Controls.Add(Me.btnResidence)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucHR"
        Me.Size = New System.Drawing.Size(1132, 627)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnHouse As Button
    Friend WithEvents btnRes As Button
    Friend WithEvents btnHousehold As Button
    Friend WithEvents btnResidence As Button
End Class
