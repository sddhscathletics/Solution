<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calendar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.mnCalendar = New System.Windows.Forms.MonthCalendar()
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblInstruct = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mnCalendar
        '
        Me.mnCalendar.Location = New System.Drawing.Point(18, 18)
        Me.mnCalendar.MaxSelectionCount = 1
        Me.mnCalendar.Name = "mnCalendar"
        Me.mnCalendar.TabIndex = 0
        '
        'cms
        '
        Me.cms.Name = "cms"
        Me.cms.Size = New System.Drawing.Size(61, 4)
        '
        'lblInstruct
        '
        Me.lblInstruct.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct.Location = New System.Drawing.Point(257, 29)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(181, 151)
        Me.lblInstruct.TabIndex = 1
        Me.lblInstruct.Text = "Click a date to add or edit events scheduled on that day." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(437, 215)
        Me.Controls.Add(Me.lblInstruct)
        Me.Controls.Add(Me.mnCalendar)
        Me.Name = "calendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mnCalendar As MonthCalendar
    Friend WithEvents cms As ContextMenuStrip
    Friend WithEvents lblInstruct As Label
End Class
