<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class selectAthlete
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
        Me.flpAthletes = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'flpAthletes
        '
        Me.flpAthletes.AutoScroll = True
        Me.flpAthletes.Location = New System.Drawing.Point(12, 12)
        Me.flpAthletes.Name = "flpAthletes"
        Me.flpAthletes.Size = New System.Drawing.Size(654, 376)
        Me.flpAthletes.TabIndex = 0
        '
        'selectAthlete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 400)
        Me.Controls.Add(Me.flpAthletes)
        Me.Name = "selectAthlete"
        Me.Text = "selectAthlete"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpAthletes As FlowLayoutPanel
End Class
