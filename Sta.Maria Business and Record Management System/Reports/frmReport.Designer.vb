<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.crIGM1 = New Sta.Maria_Business_and_Record_Management_System.crIGM()
        Me.cRBClearance1 = New Sta.Maria_Business_and_Record_Management_System.cRBClearance()
        Me.crRClearance1 = New Sta.Maria_Business_and_Record_Management_System.crRClearance()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.crHouseholdList1 = New Sta.Maria_Business_and_Record_Management_System.crHouseholdList()
        Me.crIGM21 = New Sta.Maria_Business_and_Record_Management_System.crIGM2()
        Me.crResidentlist1 = New Sta.Maria_Business_and_Record_Management_System.crResidentlist()
        Me.crCertilist1 = New Sta.Maria_Business_and_Record_Management_System.crCertilist()
        Me.crBusinesslist1 = New Sta.Maria_Business_and_Record_Management_System.crBusinesslist()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1111, 802)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 802)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReport"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crRClearance1 As crRClearance
    Friend WithEvents cRBClearance1 As cRBClearance
    Friend WithEvents crIGM1 As crIGM
    Friend WithEvents crBusinesslist1 As crBusinesslist
    Friend WithEvents crCertilist1 As crCertilist
    Friend WithEvents crResidentlist1 As crResidentlist
    Friend WithEvents crIGM21 As crIGM2
    Friend WithEvents crHouseholdList1 As crHouseholdList
End Class
