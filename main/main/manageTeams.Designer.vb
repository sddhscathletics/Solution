<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manageTeams
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
        Me.flpTeams = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cmbAgeGroup = New System.Windows.Forms.ComboBox()
        Me.chbAll = New System.Windows.Forms.CheckBox()
        Me.txtMembers = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'flpTeams
        '
        Me.flpTeams.AutoScroll = True
        Me.flpTeams.Location = New System.Drawing.Point(93, 41)
        Me.flpTeams.Name = "flpTeams"
        Me.flpTeams.Size = New System.Drawing.Size(459, 234)
        Me.flpTeams.TabIndex = 87
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = Global.main.My.Resources.Resources.iconNotepad
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Location = New System.Drawing.Point(12, 122)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 75)
        Me.btnEdit.TabIndex = 86
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = Global.main.My.Resources.Resources.iconAdd
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Location = New System.Drawing.Point(12, 41)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 75)
        Me.btnAdd.TabIndex = 85
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = Global.main.My.Resources.Resources.iconCancel
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Location = New System.Drawing.Point(12, 203)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 75)
        Me.btnDelete.TabIndex = 84
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'cmbAgeGroup
        '
        Me.cmbAgeGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgeGroup.FormattingEnabled = True
        Me.cmbAgeGroup.Items.AddRange(New Object() {"All", "U13", "U14", "U15", "U16", "U17", "Opens"})
        Me.cmbAgeGroup.Location = New System.Drawing.Point(431, 12)
        Me.cmbAgeGroup.Name = "cmbAgeGroup"
        Me.cmbAgeGroup.Size = New System.Drawing.Size(121, 23)
        Me.cmbAgeGroup.TabIndex = 2
        Me.cmbAgeGroup.Text = "Age Group"
        '
        'chbAll
        '
        Me.chbAll.AutoSize = True
        Me.chbAll.Location = New System.Drawing.Point(329, 16)
        Me.chbAll.Name = "chbAll"
        Me.chbAll.Size = New System.Drawing.Size(96, 17)
        Me.chbAll.TabIndex = 88
        Me.chbAll.Text = "All Age Groups"
        Me.chbAll.UseVisualStyleBackColor = True
        '
        'txtMembers
        '
        Me.txtMembers.Enabled = False
        Me.txtMembers.Location = New System.Drawing.Point(558, 61)
        Me.txtMembers.Multiline = True
        Me.txtMembers.Name = "txtMembers"
        Me.txtMembers.Size = New System.Drawing.Size(200, 214)
        Me.txtMembers.TabIndex = 89
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(554, 38)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(161, 20)
        Me.lblName.TabIndex = 90
        Me.lblName.Text = "Select a team to start"
        '
        'manageTeams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 287)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtMembers)
        Me.Controls.Add(Me.chbAll)
        Me.Controls.Add(Me.cmbAgeGroup)
        Me.Controls.Add(Me.flpTeams)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Name = "manageTeams"
        Me.Text = "manageTeams"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents flpTeams As FlowLayoutPanel
    Friend WithEvents cmbAgeGroup As ComboBox
    Friend WithEvents chbAll As CheckBox
    Friend WithEvents txtMembers As TextBox
    Friend WithEvents lblName As Label
End Class
