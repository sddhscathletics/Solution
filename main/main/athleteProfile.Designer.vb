<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class athleteProfile
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.txtSt = New System.Windows.Forms.TextBox()
        Me.txtPo = New System.Windows.Forms.TextBox()
        Me.txtSb = New System.Windows.Forms.TextBox()
        Me.btnParse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(12, 12)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(224, 20)
        Me.txtInput.TabIndex = 0
        Me.txtInput.Text = "5/26 Monmouth St, Randwick 2032"
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(12, 38)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(100, 20)
        Me.txtNo.TabIndex = 1
        Me.txtNo.Text = "Number"
        '
        'txtSt
        '
        Me.txtSt.Location = New System.Drawing.Point(12, 64)
        Me.txtSt.Name = "txtSt"
        Me.txtSt.Size = New System.Drawing.Size(100, 20)
        Me.txtSt.TabIndex = 2
        Me.txtSt.Text = "Street"
        '
        'txtPo
        '
        Me.txtPo.Location = New System.Drawing.Point(12, 116)
        Me.txtPo.Name = "txtPo"
        Me.txtPo.Size = New System.Drawing.Size(100, 20)
        Me.txtPo.TabIndex = 3
        Me.txtPo.Text = "Postcode"
        '
        'txtSb
        '
        Me.txtSb.Location = New System.Drawing.Point(12, 90)
        Me.txtSb.Name = "txtSb"
        Me.txtSb.Size = New System.Drawing.Size(100, 20)
        Me.txtSb.TabIndex = 4
        Me.txtSb.Text = "Suburb"
        '
        'btnParse
        '
        Me.btnParse.Location = New System.Drawing.Point(118, 38)
        Me.btnParse.Name = "btnParse"
        Me.btnParse.Size = New System.Drawing.Size(118, 98)
        Me.btnParse.TabIndex = 5
        Me.btnParse.Text = "Parse"
        Me.btnParse.UseVisualStyleBackColor = True
        '
        'athleteProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 149)
        Me.Controls.Add(Me.btnParse)
        Me.Controls.Add(Me.txtSb)
        Me.Controls.Add(Me.txtPo)
        Me.Controls.Add(Me.txtSt)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "athleteProfile"
        Me.Text = "athleteProfile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtSt As TextBox
    Friend WithEvents txtPo As TextBox
    Friend WithEvents txtSb As TextBox
    Friend WithEvents btnParse As Button
End Class
