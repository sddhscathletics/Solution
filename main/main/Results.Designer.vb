<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Results
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EventView = New System.Windows.Forms.DataGridView()
        Me.MeetRev = New System.Windows.Forms.Button()
        Me.SeasonRev = New System.Windows.Forms.Button()
        Me.PrintEve = New System.Windows.Forms.Button()
        CType(Me.EventView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(202, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'EventView
        '
        Me.EventView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EventView.GridColor = System.Drawing.SystemColors.Control
        Me.EventView.Location = New System.Drawing.Point(69, 62)
        Me.EventView.Name = "EventView"
        Me.EventView.Size = New System.Drawing.Size(415, 275)
        Me.EventView.TabIndex = 1
        '
        'MeetRev
        '
        Me.MeetRev.Location = New System.Drawing.Point(398, 370)
        Me.MeetRev.Name = "MeetRev"
        Me.MeetRev.Size = New System.Drawing.Size(86, 45)
        Me.MeetRev.TabIndex = 2
        Me.MeetRev.Text = "Generate Meet Review"
        Me.MeetRev.UseVisualStyleBackColor = True
        '
        'SeasonRev
        '
        Me.SeasonRev.Location = New System.Drawing.Point(69, 370)
        Me.SeasonRev.Name = "SeasonRev"
        Me.SeasonRev.Size = New System.Drawing.Size(86, 55)
        Me.SeasonRev.TabIndex = 3
        Me.SeasonRev.Text = "Generate Season Review"
        Me.SeasonRev.UseVisualStyleBackColor = True
        '
        'PrintEve
        '
        Me.PrintEve.Location = New System.Drawing.Point(259, 370)
        Me.PrintEve.Name = "PrintEve"
        Me.PrintEve.Size = New System.Drawing.Size(86, 45)
        Me.PrintEve.TabIndex = 4
        Me.PrintEve.Text = "Print"
        Me.PrintEve.UseVisualStyleBackColor = True
        '
        'Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 482)
        Me.Controls.Add(Me.PrintEve)
        Me.Controls.Add(Me.SeasonRev)
        Me.Controls.Add(Me.MeetRev)
        Me.Controls.Add(Me.EventView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Results"
        Me.Text = "Results"
        CType(Me.EventView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents EventView As DataGridView
    Friend WithEvents MeetRev As Button
    Friend WithEvents SeasonRev As Button
    Friend WithEvents PrintEve As Button
End Class
