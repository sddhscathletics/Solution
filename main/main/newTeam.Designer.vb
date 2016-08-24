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
        Me.lblSelectMembers = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTeamName
        '
        Me.txtTeamName.Location = New System.Drawing.Point(12, 25)
        Me.txtTeamName.Name = "txtTeamName"
        Me.txtTeamName.Size = New System.Drawing.Size(179, 20)
        Me.txtTeamName.TabIndex = 0
        '
        'cmbAgeGroup
        '
        Me.cmbAgeGroup.FormattingEnabled = True
        Me.cmbAgeGroup.Items.AddRange(New Object() {"U13", "U14", "U15", "U16", "U17", "Opens"})
        Me.cmbAgeGroup.Location = New System.Drawing.Point(12, 51)
        Me.cmbAgeGroup.Name = "cmbAgeGroup"
        Me.cmbAgeGroup.Size = New System.Drawing.Size(121, 21)
        Me.cmbAgeGroup.TabIndex = 1
        Me.cmbAgeGroup.Text = "Age Group"
        '
        'lblTeamName
        '
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.Location = New System.Drawing.Point(9, 9)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(65, 13)
        Me.lblTeamName.TabIndex = 2
        Me.lblTeamName.Text = "Team Name"
        '
        'flpAthletes
        '
        Me.flpAthletes.AutoScroll = True
        Me.flpAthletes.Location = New System.Drawing.Point(12, 127)
        Me.flpAthletes.Name = "flpAthletes"
        Me.flpAthletes.Size = New System.Drawing.Size(479, 263)
        Me.flpAthletes.TabIndex = 84
        '
        'lblSelectMembers
        '
        Me.lblSelectMembers.AutoSize = True
        Me.lblSelectMembers.Location = New System.Drawing.Point(9, 85)
        Me.lblSelectMembers.Name = "lblSelectMembers"
        Me.lblSelectMembers.Size = New System.Drawing.Size(83, 13)
        Me.lblSelectMembers.TabIndex = 85
        Me.lblSelectMembers.Text = "Select Members"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 101)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(323, 20)
        Me.txtSearch.TabIndex = 86
        Me.txtSearch.Text = "Search"
        '
        'cmbFilter
        '
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"ID", "First Name (Ascending)", "First Name (Descending)", "Last Name (Ascending)", "Last Name (Descending)"})
        Me.cmbFilter.Location = New System.Drawing.Point(341, 101)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(150, 21)
        Me.cmbFilter.TabIndex = 87
        Me.cmbFilter.Text = "Filter"
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.main.My.Resources.Resources.iconCancel
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Location = New System.Drawing.Point(416, 9)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 75)
        Me.btnCancel.TabIndex = 83
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.main.My.Resources.Resources.iconSave
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Location = New System.Drawing.Point(335, 9)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 75)
        Me.btnSave.TabIndex = 82
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'newTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 402)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSelectMembers)
        Me.Controls.Add(Me.flpAthletes)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblTeamName)
        Me.Controls.Add(Me.cmbAgeGroup)
        Me.Controls.Add(Me.txtTeamName)
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
    Friend WithEvents lblSelectMembers As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbFilter As ComboBox
End Class
