<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class confirmAddition
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
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.rchText = New System.Windows.Forms.RichTextBox()
        Me.lblTop = New System.Windows.Forms.Label()
        Me.lblBottom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(62, 318)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(101, 44)
        Me.btnYes.TabIndex = 1
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(228, 318)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(101, 44)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(264, 318)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(101, 44)
        Me.btnOkay.TabIndex = 3
        Me.btnOkay.Text = "OK"
        Me.btnOkay.UseVisualStyleBackColor = True
        Me.btnOkay.Visible = False
        '
        'rchText
        '
        Me.rchText.Enabled = False
        Me.rchText.Location = New System.Drawing.Point(22, 32)
        Me.rchText.Name = "rchText"
        Me.rchText.Size = New System.Drawing.Size(491, 232)
        Me.rchText.TabIndex = 4
        Me.rchText.Text = ""
        '
        'lblTop
        '
        Me.lblTop.AutoSize = True
        Me.lblTop.Location = New System.Drawing.Point(19, 16)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(36, 13)
        Me.lblTop.TabIndex = 0
        Me.lblTop.Text = "lblTop"
        '
        'lblBottom
        '
        Me.lblBottom.AutoSize = True
        Me.lblBottom.Location = New System.Drawing.Point(19, 267)
        Me.lblBottom.Name = "lblBottom"
        Me.lblBottom.Size = New System.Drawing.Size(59, 13)
        Me.lblBottom.TabIndex = 5
        Me.lblBottom.Text = "lblQuestion"
        '
        'confirmAddition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 403)
        Me.Controls.Add(Me.lblBottom)
        Me.Controls.Add(Me.rchText)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblTop)
        Me.Name = "confirmAddition"
        Me.Text = "Confirm Additions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents btnOkay As Button
    Friend WithEvents rchText As RichTextBox
    Friend WithEvents lblTop As Label
    Friend WithEvents lblBottom As Label
End Class
