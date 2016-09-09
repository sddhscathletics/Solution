<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newTeam
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
        Me.txtTeamName = New System.Windows.Forms.TextBox()
        Me.cmbAgeGroup = New System.Windows.Forms.ComboBox()
        Me.lblTeamName = New System.Windows.Forms.Label()
        Me.flpAthletes = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblAddMembers = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSort = New System.Windows.Forms.ComboBox()
        Me.lblSelectedMembers = New System.Windows.Forms.Label()
        Me.flpSelected = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTeamName
        '
        Me.txtTeamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeamName.Location = New System.Drawing.Point(177, 23)
        Me.txtTeamName.Name = "txtTeamName"
        Me.txtTeamName.Size = New System.Drawing.Size(179, 21)
        Me.txtTeamName.TabIndex = 0
        '
        'cmbAgeGroup
        '
        Me.cmbAgeGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgeGroup.FormattingEnabled = True
        Me.cmbAgeGroup.Items.AddRange(New Object() {"All", "U13", "U14", "U15", "U16", "U17", "Opens"})
        Me.cmbAgeGroup.Location = New System.Drawing.Point(177, 49)
        Me.cmbAgeGroup.Name = "cmbAgeGroup"
        Me.cmbAgeGroup.Size = New System.Drawing.Size(121, 23)
        Me.cmbAgeGroup.TabIndex = 1
        Me.cmbAgeGroup.Text = "Age Group"
        '
        'lblTeamName
        '
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamName.Location = New System.Drawing.Point(174, 7)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(71, 13)
        Me.lblTeamName.TabIndex = 2
        Me.lblTeamName.Text = "TEAM NAME"
        '
        'flpAthletes
        '
        Me.flpAthletes.AutoScroll = True
        Me.flpAthletes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flpAthletes.Location = New System.Drawing.Point(12, 127)
        Me.flpAthletes.Name = "flpAthletes"
        Me.flpAthletes.Size = New System.Drawing.Size(459, 263)
        Me.flpAthletes.TabIndex = 84
        '
        'lblAddMembers
        '
        Me.lblAddMembers.AutoSize = True
        Me.lblAddMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddMembers.Location = New System.Drawing.Point(9, 85)
        Me.lblAddMembers.Name = "lblAddMembers"
        Me.lblAddMembers.Size = New System.Drawing.Size(87, 13)
        Me.lblAddMembers.TabIndex = 85
        Me.lblAddMembers.Text = "ADD MEMBERS"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 101)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(303, 21)
        Me.txtSearch.TabIndex = 86
        '
        'cmbSort
        '
        Me.cmbSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSort.FormattingEnabled = True
        Me.cmbSort.Items.AddRange(New Object() {"ID", "First Name (Ascending)", "First Name (Descending)", "Last Name (Ascending)", "Last Name (Descending)"})
        Me.cmbSort.Location = New System.Drawing.Point(321, 101)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(150, 23)
        Me.cmbSort.TabIndex = 87
        Me.cmbSort.Text = "Sort By"
        '
        'lblSelectedMembers
        '
        Me.lblSelectedMembers.AutoSize = True
        Me.lblSelectedMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedMembers.Location = New System.Drawing.Point(477, 106)
        Me.lblSelectedMembers.Name = "lblSelectedMembers"
        Me.lblSelectedMembers.Size = New System.Drawing.Size(120, 13)
        Me.lblSelectedMembers.TabIndex = 88
        Me.lblSelectedMembers.Text = "SELECTED MEMBERS"
        '
        'flpSelected
        '
        Me.flpSelected.AutoScroll = True
        Me.flpSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flpSelected.Location = New System.Drawing.Point(477, 127)
        Me.flpSelected.Name = "flpSelected"
        Me.flpSelected.Size = New System.Drawing.Size(172, 263)
        Me.flpSelected.TabIndex = 85
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.BackgroundImage = Global.main.My.Resources.Resources.close1
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(93, 7)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 75)
        Me.btnCancel.TabIndex = 83
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.BackgroundImage = Global.main.My.Resources.Resources.savebtn
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(12, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 75)
        Me.btnSave.TabIndex = 82
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(626, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(23, 23)
        Me.btnHelp.TabIndex = 93
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'newTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 402)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.flpSelected)
        Me.Controls.Add(Me.lblSelectedMembers)
        Me.Controls.Add(Me.cmbSort)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblAddMembers)
        Me.Controls.Add(Me.flpAthletes)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblTeamName)
        Me.Controls.Add(Me.cmbAgeGroup)
        Me.Controls.Add(Me.txtTeamName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newTeam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New Team"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTeamName As TextBox
    Friend WithEvents cmbAgeGroup As ComboBox
    Friend WithEvents lblTeamName As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents flpAthletes As FlowLayoutPanel
    Friend WithEvents lblAddMembers As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbSort As ComboBox
    Friend WithEvents lblSelectedMembers As Label
    Friend WithEvents flpSelected As FlowLayoutPanel
    Friend WithEvents btnHelp As Button
End Class
