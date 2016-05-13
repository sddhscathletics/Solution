<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkNotif
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
        Me.txtListNotifs = New System.Windows.Forms.TextBox()
        Me.lblAlertCount = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtListNotifs
        '
        Me.txtListNotifs.Location = New System.Drawing.Point(12, 12)
        Me.txtListNotifs.Multiline = True
        Me.txtListNotifs.Name = "txtListNotifs"
        Me.txtListNotifs.Size = New System.Drawing.Size(413, 372)
        Me.txtListNotifs.TabIndex = 0
        '
        'lblAlertCount
        '
        Me.lblAlertCount.AutoSize = True
        Me.lblAlertCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlertCount.Location = New System.Drawing.Point(431, 12)
        Me.lblAlertCount.Name = "lblAlertCount"
        Me.lblAlertCount.Size = New System.Drawing.Size(17, 18)
        Me.lblAlertCount.TabIndex = 1
        Me.lblAlertCount.Text = "0"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(431, 356)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(23, 23)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'checkNotif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 391)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblAlertCount)
        Me.Controls.Add(Me.txtListNotifs)
        Me.Name = "checkNotif"
        Me.Text = "checkNotif"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtListNotifs As TextBox
    Friend WithEvents lblAlertCount As Label
    Friend WithEvents btnGo As Button
End Class
