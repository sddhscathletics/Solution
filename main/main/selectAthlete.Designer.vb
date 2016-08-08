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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblMedical = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblBestEvent = New System.Windows.Forms.Label()
        Me.lblAgeGroup = New System.Windows.Forms.Label()
        Me.lblStNo = New System.Windows.Forms.Label()
        Me.lblSt = New System.Windows.Forms.Label()
        Me.lblSb = New System.Windows.Forms.Label()
        Me.lblPo = New System.Windows.Forms.Label()
        Me.lblRoll = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblHeaderAddress = New System.Windows.Forms.Label()
        Me.lblHeaderMedical = New System.Windows.Forms.Label()
        Me.lblHeaderContact = New System.Windows.Forms.Label()
        Me.gpbAddress = New System.Windows.Forms.GroupBox()
        Me.gpbContact = New System.Windows.Forms.GroupBox()
        Me.gpbMedical = New System.Windows.Forms.GroupBox()
        Me.gpbAthlete = New System.Windows.Forms.GroupBox()
        Me.btnDeleteTeam = New System.Windows.Forms.Button()
        Me.btnAddTeam = New System.Windows.Forms.Button()
        Me.lblTeams = New System.Windows.Forms.Label()
        Me.flpTeams = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblHeaderAthlete = New System.Windows.Forms.Label()
        Me.gpbStudent = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBestEvent = New System.Windows.Forms.TextBox()
        Me.cmbAge = New System.Windows.Forms.ComboBox()
        Me.flpAttachTeam = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnNewTeam = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.gpbTeamManagement = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblHeaderTeamManagement = New System.Windows.Forms.Label()
        Me.gpbAddress.SuspendLayout()
        Me.gpbContact.SuspendLayout()
        Me.gpbMedical.SuspendLayout()
        Me.gpbAthlete.SuspendLayout()
        Me.gpbStudent.SuspendLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbTeamManagement.SuspendLayout()
        Me.SuspendLayout()
        '
        'flpAthletes
        '
        Me.flpAthletes.AutoScroll = True
        Me.flpAthletes.Location = New System.Drawing.Point(12, 51)
        Me.flpAthletes.Name = "flpAthletes"
        Me.flpAthletes.Size = New System.Drawing.Size(604, 618)
        Me.flpAthletes.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(432, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(397, 20)
        Me.txtSearch.TabIndex = 1
        '
        'lblMedical
        '
        Me.lblMedical.AutoSize = True
        Me.lblMedical.Location = New System.Drawing.Point(7, 20)
        Me.lblMedical.Name = "lblMedical"
        Me.lblMedical.Size = New System.Drawing.Size(99, 13)
        Me.lblMedical.TabIndex = 31
        Me.lblMedical.Text = "Medical Information"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(7, 20)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(78, 13)
        Me.lblPhone.TabIndex = 29
        Me.lblPhone.Text = "Phone Number"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(7, 33)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(73, 13)
        Me.lblEmail.TabIndex = 28
        Me.lblEmail.Text = "Email Address"
        '
        'lblBestEvent
        '
        Me.lblBestEvent.AutoSize = True
        Me.lblBestEvent.Location = New System.Drawing.Point(10, 33)
        Me.lblBestEvent.Name = "lblBestEvent"
        Me.lblBestEvent.Size = New System.Drawing.Size(59, 13)
        Me.lblBestEvent.TabIndex = 27
        Me.lblBestEvent.Text = "Best Event"
        '
        'lblAgeGroup
        '
        Me.lblAgeGroup.AutoSize = True
        Me.lblAgeGroup.Location = New System.Drawing.Point(10, 20)
        Me.lblAgeGroup.Name = "lblAgeGroup"
        Me.lblAgeGroup.Size = New System.Drawing.Size(58, 13)
        Me.lblAgeGroup.TabIndex = 26
        Me.lblAgeGroup.Text = "Age Group"
        '
        'lblStNo
        '
        Me.lblStNo.AutoSize = True
        Me.lblStNo.Location = New System.Drawing.Point(5, 20)
        Me.lblStNo.Name = "lblStNo"
        Me.lblStNo.Size = New System.Drawing.Size(75, 13)
        Me.lblStNo.TabIndex = 25
        Me.lblStNo.Text = "Street Number"
        '
        'lblSt
        '
        Me.lblSt.AutoSize = True
        Me.lblSt.Location = New System.Drawing.Point(5, 33)
        Me.lblSt.Name = "lblSt"
        Me.lblSt.Size = New System.Drawing.Size(35, 13)
        Me.lblSt.TabIndex = 24
        Me.lblSt.Text = "Street"
        '
        'lblSb
        '
        Me.lblSb.AutoSize = True
        Me.lblSb.Location = New System.Drawing.Point(5, 46)
        Me.lblSb.Name = "lblSb"
        Me.lblSb.Size = New System.Drawing.Size(41, 13)
        Me.lblSb.TabIndex = 23
        Me.lblSb.Text = "Suburb"
        '
        'lblPo
        '
        Me.lblPo.AutoSize = True
        Me.lblPo.Location = New System.Drawing.Point(5, 59)
        Me.lblPo.Name = "lblPo"
        Me.lblPo.Size = New System.Drawing.Size(52, 13)
        Me.lblPo.TabIndex = 22
        Me.lblPo.Text = "Postcode"
        '
        'lblRoll
        '
        Me.lblRoll.AutoSize = True
        Me.lblRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoll.Location = New System.Drawing.Point(9, 40)
        Me.lblRoll.Name = "lblRoll"
        Me.lblRoll.Size = New System.Drawing.Size(79, 20)
        Me.lblRoll.TabIndex = 19
        Me.lblRoll.Text = "Roll Class"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(9, 20)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(86, 20)
        Me.lblFName.TabIndex = 18
        Me.lblFName.Text = "First Name"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(622, 51)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(206, 24)
        Me.lblID.TabIndex = 16
        Me.lblID.Text = "Select a student to start."
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(9, 0)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(86, 20)
        Me.lblLName.TabIndex = 17
        Me.lblLName.Text = "Last Name"
        '
        'lblHeaderAddress
        '
        Me.lblHeaderAddress.AutoSize = True
        Me.lblHeaderAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderAddress.Location = New System.Drawing.Point(4, 0)
        Me.lblHeaderAddress.Name = "lblHeaderAddress"
        Me.lblHeaderAddress.Size = New System.Drawing.Size(68, 20)
        Me.lblHeaderAddress.TabIndex = 32
        Me.lblHeaderAddress.Text = "Address"
        '
        'lblHeaderMedical
        '
        Me.lblHeaderMedical.AutoSize = True
        Me.lblHeaderMedical.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderMedical.Location = New System.Drawing.Point(6, 0)
        Me.lblHeaderMedical.Name = "lblHeaderMedical"
        Me.lblHeaderMedical.Size = New System.Drawing.Size(116, 20)
        Me.lblHeaderMedical.TabIndex = 33
        Me.lblHeaderMedical.Text = "Medical Details"
        '
        'lblHeaderContact
        '
        Me.lblHeaderContact.AutoSize = True
        Me.lblHeaderContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderContact.Location = New System.Drawing.Point(6, 0)
        Me.lblHeaderContact.Name = "lblHeaderContact"
        Me.lblHeaderContact.Size = New System.Drawing.Size(118, 20)
        Me.lblHeaderContact.TabIndex = 34
        Me.lblHeaderContact.Text = "Contact Details"
        '
        'gpbAddress
        '
        Me.gpbAddress.Controls.Add(Me.lblHeaderAddress)
        Me.gpbAddress.Controls.Add(Me.lblPo)
        Me.gpbAddress.Controls.Add(Me.lblSb)
        Me.gpbAddress.Controls.Add(Me.lblSt)
        Me.gpbAddress.Controls.Add(Me.lblStNo)
        Me.gpbAddress.Location = New System.Drawing.Point(828, 428)
        Me.gpbAddress.Name = "gpbAddress"
        Me.gpbAddress.Size = New System.Drawing.Size(234, 79)
        Me.gpbAddress.TabIndex = 35
        Me.gpbAddress.TabStop = False
        '
        'gpbContact
        '
        Me.gpbContact.Controls.Add(Me.lblHeaderContact)
        Me.gpbContact.Controls.Add(Me.lblEmail)
        Me.gpbContact.Controls.Add(Me.lblPhone)
        Me.gpbContact.Location = New System.Drawing.Point(828, 370)
        Me.gpbContact.Name = "gpbContact"
        Me.gpbContact.Size = New System.Drawing.Size(234, 52)
        Me.gpbContact.TabIndex = 36
        Me.gpbContact.TabStop = False
        '
        'gpbMedical
        '
        Me.gpbMedical.Controls.Add(Me.lblHeaderMedical)
        Me.gpbMedical.Controls.Add(Me.lblMedical)
        Me.gpbMedical.Location = New System.Drawing.Point(828, 321)
        Me.gpbMedical.Name = "gpbMedical"
        Me.gpbMedical.Size = New System.Drawing.Size(234, 43)
        Me.gpbMedical.TabIndex = 37
        Me.gpbMedical.TabStop = False
        '
        'gpbAthlete
        '
        Me.gpbAthlete.Controls.Add(Me.btnDeleteTeam)
        Me.gpbAthlete.Controls.Add(Me.btnAddTeam)
        Me.gpbAthlete.Controls.Add(Me.lblTeams)
        Me.gpbAthlete.Controls.Add(Me.flpTeams)
        Me.gpbAthlete.Controls.Add(Me.lblHeaderAthlete)
        Me.gpbAthlete.Controls.Add(Me.lblAgeGroup)
        Me.gpbAthlete.Controls.Add(Me.lblBestEvent)
        Me.gpbAthlete.Location = New System.Drawing.Point(828, 148)
        Me.gpbAthlete.Name = "gpbAthlete"
        Me.gpbAthlete.Size = New System.Drawing.Size(234, 167)
        Me.gpbAthlete.TabIndex = 38
        Me.gpbAthlete.TabStop = False
        '
        'btnDeleteTeam
        '
        Me.btnDeleteTeam.BackgroundImage = Global.main.My.Resources.Resources.iconCancel
        Me.btnDeleteTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteTeam.Location = New System.Drawing.Point(189, 117)
        Me.btnDeleteTeam.Name = "btnDeleteTeam"
        Me.btnDeleteTeam.Size = New System.Drawing.Size(40, 40)
        Me.btnDeleteTeam.TabIndex = 51
        Me.btnDeleteTeam.UseVisualStyleBackColor = True
        '
        'btnAddTeam
        '
        Me.btnAddTeam.BackgroundImage = Global.main.My.Resources.Resources.iconAdd
        Me.btnAddTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddTeam.Location = New System.Drawing.Point(189, 71)
        Me.btnAddTeam.Name = "btnAddTeam"
        Me.btnAddTeam.Size = New System.Drawing.Size(40, 40)
        Me.btnAddTeam.TabIndex = 49
        Me.btnAddTeam.UseVisualStyleBackColor = True
        '
        'lblTeams
        '
        Me.lblTeams.AutoSize = True
        Me.lblTeams.Location = New System.Drawing.Point(10, 55)
        Me.lblTeams.Name = "lblTeams"
        Me.lblTeams.Size = New System.Drawing.Size(39, 13)
        Me.lblTeams.TabIndex = 50
        Me.lblTeams.Text = "Teams"
        '
        'flpTeams
        '
        Me.flpTeams.AutoScroll = True
        Me.flpTeams.Location = New System.Drawing.Point(13, 71)
        Me.flpTeams.Name = "flpTeams"
        Me.flpTeams.Size = New System.Drawing.Size(170, 86)
        Me.flpTeams.TabIndex = 49
        '
        'lblHeaderAthlete
        '
        Me.lblHeaderAthlete.AutoSize = True
        Me.lblHeaderAthlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderAthlete.Location = New System.Drawing.Point(6, 0)
        Me.lblHeaderAthlete.Name = "lblHeaderAthlete"
        Me.lblHeaderAthlete.Size = New System.Drawing.Size(113, 20)
        Me.lblHeaderAthlete.TabIndex = 34
        Me.lblHeaderAthlete.Text = "Athlete Details"
        '
        'gpbStudent
        '
        Me.gpbStudent.Controls.Add(Me.lblLName)
        Me.gpbStudent.Controls.Add(Me.lblFName)
        Me.gpbStudent.Controls.Add(Me.lblRoll)
        Me.gpbStudent.Location = New System.Drawing.Point(828, 78)
        Me.gpbStudent.Name = "gpbStudent"
        Me.gpbStudent.Size = New System.Drawing.Size(234, 64)
        Me.gpbStudent.TabIndex = 39
        Me.gpbStudent.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(703, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 75)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "GIB ADMIN OR RIOT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBestEvent
        '
        Me.txtBestEvent.Location = New System.Drawing.Point(622, 461)
        Me.txtBestEvent.Name = "txtBestEvent"
        Me.txtBestEvent.Size = New System.Drawing.Size(172, 20)
        Me.txtBestEvent.TabIndex = 47
        '
        'cmbAge
        '
        Me.cmbAge.FormattingEnabled = True
        Me.cmbAge.Items.AddRange(New Object() {"U13", "U14", "U15", "U16", "Opens"})
        Me.cmbAge.Location = New System.Drawing.Point(622, 484)
        Me.cmbAge.Name = "cmbAge"
        Me.cmbAge.Size = New System.Drawing.Size(74, 21)
        Me.cmbAge.TabIndex = 48
        '
        'flpAttachTeam
        '
        Me.flpAttachTeam.AutoScroll = True
        Me.flpAttachTeam.Location = New System.Drawing.Point(6, 49)
        Me.flpAttachTeam.Name = "flpAttachTeam"
        Me.flpAttachTeam.Size = New System.Drawing.Size(172, 196)
        Me.flpAttachTeam.TabIndex = 50
        '
        'btnNewTeam
        '
        Me.btnNewTeam.Location = New System.Drawing.Point(6, 251)
        Me.btnNewTeam.Name = "btnNewTeam"
        Me.btnNewTeam.Size = New System.Drawing.Size(172, 31)
        Me.btnNewTeam.TabIndex = 51
        Me.btnNewTeam.Text = "Create New Team"
        Me.btnNewTeam.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.main.My.Resources.Resources.iconCancel
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Location = New System.Drawing.Point(703, 594)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 75)
        Me.btnCancel.TabIndex = 43
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.main.My.Resources.Resources.iconSave
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Location = New System.Drawing.Point(622, 594)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 75)
        Me.btnSave.TabIndex = 42
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = Global.main.My.Resources.Resources.iconEdit
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Location = New System.Drawing.Point(622, 384)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 75)
        Me.btnEdit.TabIndex = 40
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'pbPhoto
        '
        Me.pbPhoto.Location = New System.Drawing.Point(622, 78)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(200, 300)
        Me.pbPhoto.TabIndex = 20
        Me.pbPhoto.TabStop = False
        '
        'gpbTeamManagement
        '
        Me.gpbTeamManagement.Controls.Add(Me.TextBox1)
        Me.gpbTeamManagement.Controls.Add(Me.lblHeaderTeamManagement)
        Me.gpbTeamManagement.Controls.Add(Me.btnNewTeam)
        Me.gpbTeamManagement.Controls.Add(Me.flpAttachTeam)
        Me.gpbTeamManagement.Location = New System.Drawing.Point(1068, 148)
        Me.gpbTeamManagement.Name = "gpbTeamManagement"
        Me.gpbTeamManagement.Size = New System.Drawing.Size(184, 288)
        Me.gpbTeamManagement.TabIndex = 52
        Me.gpbTeamManagement.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(172, 20)
        Me.TextBox1.TabIndex = 53
        '
        'lblHeaderTeamManagement
        '
        Me.lblHeaderTeamManagement.AutoSize = True
        Me.lblHeaderTeamManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTeamManagement.Location = New System.Drawing.Point(6, 0)
        Me.lblHeaderTeamManagement.Name = "lblHeaderTeamManagement"
        Me.lblHeaderTeamManagement.Size = New System.Drawing.Size(147, 20)
        Me.lblHeaderTeamManagement.TabIndex = 34
        Me.lblHeaderTeamManagement.Text = "Team Management"
        '
        'selectAthlete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.gpbTeamManagement)
        Me.Controls.Add(Me.txtBestEvent)
        Me.Controls.Add(Me.cmbAge)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.gpbStudent)
        Me.Controls.Add(Me.gpbAthlete)
        Me.Controls.Add(Me.gpbMedical)
        Me.Controls.Add(Me.gpbContact)
        Me.Controls.Add(Me.gpbAddress)
        Me.Controls.Add(Me.pbPhoto)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.flpAthletes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "selectAthlete"
        Me.Text = "selectAthlete"
        Me.gpbAddress.ResumeLayout(False)
        Me.gpbAddress.PerformLayout()
        Me.gpbContact.ResumeLayout(False)
        Me.gpbContact.PerformLayout()
        Me.gpbMedical.ResumeLayout(False)
        Me.gpbMedical.PerformLayout()
        Me.gpbAthlete.ResumeLayout(False)
        Me.gpbAthlete.PerformLayout()
        Me.gpbStudent.ResumeLayout(False)
        Me.gpbStudent.PerformLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbTeamManagement.ResumeLayout(False)
        Me.gpbTeamManagement.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents flpAthletes As FlowLayoutPanel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblMedical As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblBestEvent As Label
    Friend WithEvents lblAgeGroup As Label
    Friend WithEvents lblStNo As Label
    Friend WithEvents lblSt As Label
    Friend WithEvents lblSb As Label
    Friend WithEvents lblPo As Label
    Friend WithEvents pbPhoto As PictureBox
    Friend WithEvents lblRoll As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents lblHeaderAddress As Label
    Friend WithEvents lblHeaderMedical As Label
    Friend WithEvents lblHeaderContact As Label
    Friend WithEvents gpbAddress As GroupBox
    Friend WithEvents gpbContact As GroupBox
    Friend WithEvents gpbMedical As GroupBox
    Friend WithEvents gpbAthlete As GroupBox
    Friend WithEvents lblHeaderAthlete As Label
    Friend WithEvents gpbStudent As GroupBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtBestEvent As TextBox
    Friend WithEvents cmbAge As ComboBox
    Friend WithEvents flpTeams As FlowLayoutPanel
    Friend WithEvents lblTeams As Label
    Friend WithEvents btnDeleteTeam As Button
    Friend WithEvents btnAddTeam As Button
    Friend WithEvents flpAttachTeam As FlowLayoutPanel
    Friend WithEvents btnNewTeam As Button
    Friend WithEvents gpbTeamManagement As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblHeaderTeamManagement As Label
End Class
