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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.rchText = New System.Windows.Forms.RichTextBox()
        Me.lblPeople = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
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
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(386, 318)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 44)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
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
        'lblPeople
        '
        Me.lblPeople.AutoSize = True
        Me.lblPeople.Location = New System.Drawing.Point(19, 16)
        Me.lblPeople.Name = "lblPeople"
        Me.lblPeople.Size = New System.Drawing.Size(39, 13)
        Me.lblPeople.TabIndex = 0
        Me.lblPeople.Text = "Label1"
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(19, 267)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(59, 13)
        Me.lblQuestion.TabIndex = 5
        Me.lblQuestion.Text = "lblQuestion"
        '
        'confirmAddition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 403)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.rchText)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblPeople)
        Me.Name = "confirmAddition"
        Me.Text = "Confirm Additions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents rchText As RichTextBox
    Friend WithEvents lblPeople As Label
    Friend WithEvents lblQuestion As Label
End Class
