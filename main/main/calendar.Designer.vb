<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calendar
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
        Me.mnCalendar = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdtyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnCalendar
        '
        Me.mnCalendar.Location = New System.Drawing.Point(57, 39)
        Me.mnCalendar.MaxSelectionCount = 1
        Me.mnCalendar.Name = "mnCalendar"
        Me.mnCalendar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'cms
        '
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EdtyToolStripMenuItem})
        Me.cms.Name = "cms"
        Me.cms.Size = New System.Drawing.Size(153, 70)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EdtyToolStripMenuItem
        '
        Me.EdtyToolStripMenuItem.Name = "EdtyToolStripMenuItem"
        Me.EdtyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EdtyToolStripMenuItem.Text = "Edty"
        '
        'calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 292)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnCalendar)
        Me.Name = "calendar"
        Me.Text = "Form1"
        Me.cms.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnCalendar As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents cms As ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdtyToolStripMenuItem As ToolStripMenuItem
End Class
