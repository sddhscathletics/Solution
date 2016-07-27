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
        Me.SuspendLayout()
        '
        'mnCalendar
        '
        Me.mnCalendar.Location = New System.Drawing.Point(57, 39)
        Me.mnCalendar.MaxSelectionCount = 1
        Me.mnCalendar.Name = "mnCalendar"
        Me.mnCalendar.TabIndex = 0
        '
        'cms
        '
        Me.cms.Name = "cms"
        Me.cms.Size = New System.Drawing.Size(153, 26)
        '
        'calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 292)
        Me.Controls.Add(Me.mnCalendar)
        Me.Name = "calendar"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mnCalendar As MonthCalendar
    Friend WithEvents cms As ContextMenuStrip
End Class
