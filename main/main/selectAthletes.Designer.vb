<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectAthletes
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
        Me.clbAthletes = New System.Windows.Forms.CheckedListBox()
        Me.chbAll = New System.Windows.Forms.CheckBox()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'clbAthletes
        '
        Me.clbAthletes.FormattingEnabled = True
        Me.clbAthletes.Items.AddRange(New Object() {"bob", "mike", "jay", "lenny"})
        Me.clbAthletes.Location = New System.Drawing.Point(23, 71)
        Me.clbAthletes.Name = "clbAthletes"
        Me.clbAthletes.Size = New System.Drawing.Size(261, 94)
        Me.clbAthletes.TabIndex = 8
        '
        'chbAll
        '
        Me.chbAll.AutoSize = True
        Me.chbAll.Location = New System.Drawing.Point(31, 48)
        Me.chbAll.Name = "chbAll"
        Me.chbAll.Size = New System.Drawing.Size(70, 17)
        Me.chbAll.TabIndex = 9
        Me.chbAll.Text = "Select All"
        Me.chbAll.UseVisualStyleBackColor = True
        '
        'cmbGroup
        '
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Items.AddRange(New Object() {"U13", "U14", "U15", "U16", "U17", "Opens"})
        Me.cmbGroup.Location = New System.Drawing.Point(12, 12)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(136, 21)
        Me.cmbGroup.TabIndex = 7
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(209, 237)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(23, 237)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(31, 48)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "Select All"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'selectAthletes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 316)
        Me.Controls.Add(Me.clbAthletes)
        Me.Controls.Add(Me.chbAll)
        Me.Controls.Add(Me.cmbGroup)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.CheckBox2)
        Me.Name = "selectAthletes"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clbAthletes As CheckedListBox
    Friend WithEvents chbAll As CheckBox
    Friend WithEvents cmbGroup As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents CheckBox2 As CheckBox
End Class
