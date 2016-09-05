<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class makeuser
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
        Me.Access3 = New System.Windows.Forms.RadioButton()
        Me.Access2 = New System.Windows.Forms.RadioButton()
        Me.Access1 = New System.Windows.Forms.RadioButton()
        Me.newPass = New System.Windows.Forms.TextBox()
        Me.newId = New System.Windows.Forms.TextBox()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.okBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.newAccess3 = New System.Windows.Forms.RadioButton()
        Me.newAccess2 = New System.Windows.Forms.RadioButton()
        Me.newAccess1 = New System.Windows.Forms.RadioButton()
        Me.createNewPass = New System.Windows.Forms.TextBox()
        Me.createNewID = New System.Windows.Forms.TextBox()
        Me.createCancelBtn = New System.Windows.Forms.Button()
        Me.createOkBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Access3
        '
        Me.Access3.AutoSize = True
        Me.Access3.Location = New System.Drawing.Point(-310, 199)
        Me.Access3.Name = "Access3"
        Me.Access3.Size = New System.Drawing.Size(31, 17)
        Me.Access3.TabIndex = 15
        Me.Access3.TabStop = True
        Me.Access3.Text = "3"
        Me.Access3.UseVisualStyleBackColor = True
        '
        'Access2
        '
        Me.Access2.AutoSize = True
        Me.Access2.Location = New System.Drawing.Point(-399, 199)
        Me.Access2.Name = "Access2"
        Me.Access2.Size = New System.Drawing.Size(31, 17)
        Me.Access2.TabIndex = 16
        Me.Access2.TabStop = True
        Me.Access2.Text = "2"
        Me.Access2.UseVisualStyleBackColor = True
        '
        'Access1
        '
        Me.Access1.AutoSize = True
        Me.Access1.Location = New System.Drawing.Point(-495, 199)
        Me.Access1.Name = "Access1"
        Me.Access1.Size = New System.Drawing.Size(31, 17)
        Me.Access1.TabIndex = 17
        Me.Access1.TabStop = True
        Me.Access1.Text = "1"
        Me.Access1.UseVisualStyleBackColor = True
        '
        'newPass
        '
        Me.newPass.Location = New System.Drawing.Point(-451, 122)
        Me.newPass.Name = "newPass"
        Me.newPass.Size = New System.Drawing.Size(216, 20)
        Me.newPass.TabIndex = 13
        '
        'newId
        '
        Me.newId.Location = New System.Drawing.Point(-451, 72)
        Me.newId.Name = "newId"
        Me.newId.Size = New System.Drawing.Size(216, 20)
        Me.newId.TabIndex = 14
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(-310, 254)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelBtn.TabIndex = 11
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'okBtn
        '
        Me.okBtn.Location = New System.Drawing.Point(-480, 254)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(75, 23)
        Me.okBtn.TabIndex = 12
        Me.okBtn.Text = "OK"
        Me.okBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(-546, -15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1377, 58)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'newAccess3
        '
        Me.newAccess3.AutoSize = True
        Me.newAccess3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.newAccess3.Location = New System.Drawing.Point(50, 221)
        Me.newAccess3.Name = "newAccess3"
        Me.newAccess3.Size = New System.Drawing.Size(30, 17)
        Me.newAccess3.TabIndex = 22
        Me.newAccess3.TabStop = True
        Me.newAccess3.Text = "3"
        Me.newAccess3.UseVisualStyleBackColor = True
        '
        'newAccess2
        '
        Me.newAccess2.AutoSize = True
        Me.newAccess2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.newAccess2.Location = New System.Drawing.Point(50, 198)
        Me.newAccess2.Name = "newAccess2"
        Me.newAccess2.Size = New System.Drawing.Size(30, 17)
        Me.newAccess2.TabIndex = 23
        Me.newAccess2.TabStop = True
        Me.newAccess2.Text = "2"
        Me.newAccess2.UseVisualStyleBackColor = True
        '
        'newAccess1
        '
        Me.newAccess1.AutoSize = True
        Me.newAccess1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.newAccess1.Location = New System.Drawing.Point(50, 175)
        Me.newAccess1.Name = "newAccess1"
        Me.newAccess1.Size = New System.Drawing.Size(30, 17)
        Me.newAccess1.TabIndex = 24
        Me.newAccess1.TabStop = True
        Me.newAccess1.Text = "1"
        Me.newAccess1.UseVisualStyleBackColor = True
        '
        'createNewPass
        '
        Me.createNewPass.Location = New System.Drawing.Point(50, 120)
        Me.createNewPass.Name = "createNewPass"
        Me.createNewPass.Size = New System.Drawing.Size(216, 20)
        Me.createNewPass.TabIndex = 20
        '
        'createNewID
        '
        Me.createNewID.Location = New System.Drawing.Point(50, 72)
        Me.createNewID.Name = "createNewID"
        Me.createNewID.Size = New System.Drawing.Size(216, 20)
        Me.createNewID.TabIndex = 21
        '
        'createCancelBtn
        '
        Me.createCancelBtn.BackColor = System.Drawing.Color.Gray
        Me.createCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.createCancelBtn.Location = New System.Drawing.Point(227, 266)
        Me.createCancelBtn.Name = "createCancelBtn"
        Me.createCancelBtn.Size = New System.Drawing.Size(77, 48)
        Me.createCancelBtn.TabIndex = 18
        Me.createCancelBtn.Text = "Cancel"
        Me.createCancelBtn.UseVisualStyleBackColor = False
        '
        'createOkBtn
        '
        Me.createOkBtn.BackColor = System.Drawing.Color.Gray
        Me.createOkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.createOkBtn.Location = New System.Drawing.Point(12, 266)
        Me.createOkBtn.Name = "createOkBtn"
        Me.createOkBtn.Size = New System.Drawing.Size(209, 48)
        Me.createOkBtn.TabIndex = 19
        Me.createOkBtn.Text = "OK"
        Me.createOkBtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 19)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Access Level"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 19)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Pass"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 19)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "ID"
        '
        'makeuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(316, 326)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newAccess3)
        Me.Controls.Add(Me.newAccess2)
        Me.Controls.Add(Me.newAccess1)
        Me.Controls.Add(Me.createNewPass)
        Me.Controls.Add(Me.createNewID)
        Me.Controls.Add(Me.createCancelBtn)
        Me.Controls.Add(Me.createOkBtn)
        Me.Controls.Add(Me.Access3)
        Me.Controls.Add(Me.Access2)
        Me.Controls.Add(Me.Access1)
        Me.Controls.Add(Me.newPass)
        Me.Controls.Add(Me.newId)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.okBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "makeuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "makeuser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents newAccess3 As RadioButton
    Friend WithEvents newAccess2 As RadioButton
    Friend WithEvents newAccess1 As RadioButton
    Friend WithEvents createNewPass As TextBox
    Friend WithEvents createNewID As TextBox
    Friend WithEvents createCancelBtn As Button
    Friend WithEvents createOkBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents okBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents newId As TextBox
    Friend WithEvents newPass As TextBox
    Friend WithEvents Access1 As RadioButton
    Friend WithEvents Access2 As RadioButton
    Friend WithEvents Access3 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
