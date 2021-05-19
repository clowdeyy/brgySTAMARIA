<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucIssuance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucIssuance))
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.btnLists = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnIs = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnMns = New System.Windows.Forms.Button()
        Me.btnMn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(208, 248)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(299, 66)
        Me.TextBox2.TabIndex = 36
        Me.TextBox2.Text = "Payment and printing of certificate"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(737, 248)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(262, 65)
        Me.TextBox1.TabIndex = 37
        Me.TextBox1.Text = "Displays list of issued certificate and total accumulated amount "
        '
        'btnIssue
        '
        Me.btnIssue.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnIssue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIssue.FlatAppearance.BorderSize = 0
        Me.btnIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.btnIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssue.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssue.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIssue.Location = New System.Drawing.Point(203, 212)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(317, 33)
        Me.btnIssue.TabIndex = 32
        Me.btnIssue.Text = "Issuance of Certificates"
        Me.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIssue.UseVisualStyleBackColor = False
        '
        'btnLists
        '
        Me.btnLists.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLists.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLists.FlatAppearance.BorderSize = 0
        Me.btnLists.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.btnLists.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLists.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLists.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnLists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLists.Location = New System.Drawing.Point(732, 212)
        Me.btnLists.Name = "btnLists"
        Me.btnLists.Size = New System.Drawing.Size(247, 33)
        Me.btnLists.TabIndex = 33
        Me.btnLists.Text = "List of Issued Certificates"
        Me.btnLists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLists.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1132, 10)
        Me.Panel1.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(515, 25)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Issuance of Certificates && List of Issued Certificates"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnIs
        '
        Me.btnIs.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnIs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIs.FlatAppearance.BorderSize = 0
        Me.btnIs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.btnIs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnIs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIs.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIs.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnIs.Image = CType(resources.GetObject("btnIs.Image"), System.Drawing.Image)
        Me.btnIs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIs.Location = New System.Drawing.Point(117, 212)
        Me.btnIs.Name = "btnIs"
        Me.btnIs.Size = New System.Drawing.Size(85, 91)
        Me.btnIs.TabIndex = 34
        Me.btnIs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIs.UseVisualStyleBackColor = False
        '
        'btnList
        '
        Me.btnList.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnList.FlatAppearance.BorderSize = 0
        Me.btnList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.btnList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnList.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnList.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnList.Image = CType(resources.GetObject("btnList.Image"), System.Drawing.Image)
        Me.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnList.Location = New System.Drawing.Point(641, 212)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(85, 91)
        Me.btnList.TabIndex = 35
        Me.btnList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnList.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(417, 406)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(358, 66)
        Me.TextBox3.TabIndex = 40
        Me.TextBox3.Text = "Update certificates charge amout and certificate Barangay Captain name"
        '
        'btnMns
        '
        Me.btnMns.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMns.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMns.FlatAppearance.BorderSize = 0
        Me.btnMns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.btnMns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnMns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMns.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMns.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnMns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMns.Location = New System.Drawing.Point(413, 370)
        Me.btnMns.Name = "btnMns"
        Me.btnMns.Size = New System.Drawing.Size(386, 33)
        Me.btnMns.TabIndex = 38
        Me.btnMns.Text = "Certificate Charges && Captain Name"
        Me.btnMns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMns.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMns.UseVisualStyleBackColor = False
        '
        'btnMn
        '
        Me.btnMn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMn.FlatAppearance.BorderSize = 0
        Me.btnMn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.btnMn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnMn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMn.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnMn.Image = CType(resources.GetObject("btnMn.Image"), System.Drawing.Image)
        Me.btnMn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMn.Location = New System.Drawing.Point(328, 370)
        Me.btnMn.Name = "btnMn"
        Me.btnMn.Size = New System.Drawing.Size(85, 91)
        Me.btnMn.TabIndex = 39
        Me.btnMn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMn.UseVisualStyleBackColor = False
        '
        'ucIssuance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.btnMns)
        Me.Controls.Add(Me.btnMn)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnIssue)
        Me.Controls.Add(Me.btnLists)
        Me.Controls.Add(Me.btnIs)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucIssuance"
        Me.Size = New System.Drawing.Size(1132, 627)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnIssue As Button
    Friend WithEvents btnLists As Button
    Friend WithEvents btnIs As Button
    Friend WithEvents btnList As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnMns As Button
    Friend WithEvents btnMn As Button
End Class
