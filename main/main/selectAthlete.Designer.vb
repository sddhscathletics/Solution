<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectAthlete
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
        Me.gpbTeamManagement = New System.Windows.Forms.GroupBox()
        Me.lblTeamSearch = New System.Windows.Forms.Label()
        Me.cmbTeamAgeGroup = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblHeaderTeamManagement = New System.Windows.Forms.Label()
        Me.btnNewTeam = New System.Windows.Forms.Button()
        Me.flpAttachTeam = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblBestEvent = New System.Windows.Forms.Label()
        Me.lblHeaderContact = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtBestEvent = New System.Windows.Forms.TextBox()
        Me.cmbAge = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gpbMedical = New System.Windows.Forms.GroupBox()
        Me.lblHeaderMedical = New System.Windows.Forms.Label()
        Me.lblMedical = New System.Windows.Forms.Label()
        Me.gpbStudent = New System.Windows.Forms.GroupBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblRoll = New System.Windows.Forms.Label()
        Me.flpAthletes = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblAgeGroup = New System.Windows.Forms.Label()
        Me.lblHeaderAddress = New System.Windows.Forms.Label()
        Me.lblPo = New System.Windows.Forms.Label()
        Me.lblSb = New System.Windows.Forms.Label()
        Me.gpbContact = New System.Windows.Forms.GroupBox()
        Me.lblSt = New System.Windows.Forms.Label()
        Me.gpbAthlete = New System.Windows.Forms.GroupBox()
        Me.btnCommitTeams = New System.Windows.Forms.Button()
        Me.lblTeams = New System.Windows.Forms.Label()
        Me.flpTeams = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblHeaderAthlete = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.gpbAddress = New System.Windows.Forms.GroupBox()
        Me.lblStNo = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.cmbSort = New System.Windows.Forms.ComboBox()
        Me.cmbAgeGroup = New System.Windows.Forms.ComboBox()
        Me.gpbTeamManagement.SuspendLayout()
        Me.gpbMedical.SuspendLayout()
        Me.gpbStudent.SuspendLayout()
        Me.gpbContact.SuspendLayout()
        Me.gpbAthlete.SuspendLayout()
        Me.gpbAddress.SuspendLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbTeamManagement
        '
        Me.gpbTeamManagement.Controls.Add(Me.lblTeamSearch)
        Me.gpbTeamManagement.Controls.Add(Me.cmbTeamAgeGroup)
        Me.gpbTeamManagement.Controls.Add(Me.TextBox1)
        Me.gpbTeamManagement.Controls.Add(Me.lblHeaderTeamManagement)
        Me.gpbTeamManagement.Controls.Add(Me.btnNewTeam)
        Me.gpbTeamManagement.Controls.Add(Me.flpAttachTeam)
        Me.gpbTeamManagement.Location = New System.Drawing.Point(1068, 162)
        Me.gpbTeamManagement.Name = "gpbTeamManagement"
        Me.gpbTeamManagement.Size = New System.Drawing.Size(184, 333)
        Me.gpbTeamManagement.TabIndex = 84
        Me.gpbTeamManagement.TabStop = False
        '
        'lblTeamSearch
        '
        Me.lblTeamSearch.AutoSize = True
        Me.lblTeamSearch.Location = New System.Drawing.Point(3, 20)
        Me.lblTeamSearch.Name = "lblTeamSearch"
        Me.lblTeamSearch.Size = New System.Drawing.Size(41, 13)
        Me.lblTeamSearch.TabIndex = 51
        Me.lblTeamSearch.Text = "Search"
        '
        'cmbTeamAgeGroup
        '
        Me.cmbTeamAgeGroup.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTeamAgeGroup.FormattingEnabled = True
        Me.cmbTeamAgeGroup.Items.AddRange(New Object() {"U13", "U14", "U15", "U16", "U17", "Opens"})
        Me.cmbTeamAgeGroup.Location = New System.Drawing.Point(6, 62)
        Me.cmbTeamAgeGroup.Name = "cmbTeamAgeGroup"
        Me.cmbTeamAgeGroup.Size = New System.Drawing.Size(170, 24)
        Me.cmbTeamAgeGroup.TabIndex = 90
        Me.cmbTeamAgeGroup.Text = "Age Group"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 20)
        Me.TextBox1.TabIndex = 53
        '
        'lblHeaderTeamManagement
        '
        Me.lblHeaderTeamManagement.AutoSize = True
        Me.lblHeaderTeamManagement.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTeamManagement.Location = New System.Drawing.Point(6, 0)
        Me.lblHeaderTeamManagement.Name = "lblHeaderTeamManagement"
        Me.lblHeaderTeamManagement.Size = New System.Drawing.Size(151, 19)
        Me.lblHeaderTeamManagement.TabIndex = 34
        Me.lblHeaderTeamManagement.Text = "Team Management"
        '
        'btnNewTeam
        '
        Me.btnNewTeam.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewTeam.Location = New System.Drawing.Point(6, 295)
        Me.btnNewTeam.Name = "btnNewTeam"
        Me.btnNewTeam.Size = New System.Drawing.Size(170, 31)
        Me.btnNewTeam.TabIndex = 51
        Me.btnNewTeam.Text = "Create New Team"
        Me.btnNewTeam.UseVisualStyleBackColor = True
        '
        'flpAttachTeam
        '
        Me.flpAttachTeam.AutoScroll = True
        Me.flpAttachTeam.Location = New System.Drawing.Point(6, 89)
        Me.flpAttachTeam.Name = "flpAttachTeam"
        Me.flpAttachTeam.Size = New System.Drawing.Size(170, 200)
        Me.flpAttachTeam.TabIndex = 50
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(618, 65)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(206, 24)
        Me.lblID.TabIndex = 71
        Me.lblID.Text = "Select a student to start."
        '
        'lblBestEvent
        '
        Me.lblBestEvent.AutoSize = True
        Me.lblBestEvent.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBestEvent.Location = New System.Drawing.Point(10, 33)
        Me.lblBestEvent.Name = "lblBestEvent"
        Me.lblBestEvent.Size = New System.Drawing.Size(69, 16)
        Me.lblBestEvent.TabIndex = 27
        Me.lblBestEvent.Text = "Best Event"
        '
        'lblHeaderContact
        '
        Me.lblHeaderContact.AutoSize = True
        Me.lblHeaderContact.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderContact.Location = New System.Drawing.Point(6, 0)
        Me.lblHeaderContact.Name = "lblHeaderContact"
        Me.lblHeaderContact.Size = New System.Drawing.Size(120, 19)
        Me.lblHeaderContact.TabIndex = 34
        Me.lblHeaderContact.Text = "Contact Details"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(7, 33)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(92, 16)
        Me.lblEmail.TabIndex = 28
        Me.lblEmail.Text = "Email Address"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(7, 20)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(93, 16)
        Me.lblPhone.TabIndex = 29
        Me.lblPhone.Text = "Phone Number"
        '
        'txtBestEvent
        '
        Me.txtBestEvent.Location = New System.Drawing.Point(622, 475)
        Me.txtBestEvent.Name = "txtBestEvent"
        Me.txtBestEvent.Size = New System.Drawing.Size(172, 20)
        Me.txtBestEvent.TabIndex = 82
        '
        'cmbAge
        '
        Me.cmbAge.FormattingEnabled = True
        Me.cmbAge.Items.AddRange(New Object() {"U13", "U14", "U15", "U16", "Opens"})
        Me.cmbAge.Location = New System.Drawing.Point(622, 498)
        Me.cmbAge.Name = "cmbAge"
        Me.cmbAge.Size = New System.Drawing.Size(74, 21)
        Me.cmbAge.TabIndex = 83
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(703, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 75)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "GIB ADMIN OR RIOT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gpbMedical
        '
        Me.gpbMedical.Controls.Add(Me.lblHeaderMedical)
        Me.gpbMedical.Controls.Add(Me.lblMedical)
        Me.gpbMedical.Location = New System.Drawing.Point(828, 335)
        Me.gpbMedical.Name = "gpbMedical"
        Me.gpbMedical.Size = New System.Drawing.Size(234, 43)
        Me.gpbMedical.TabIndex = 75
        Me.gpbMedical.TabStop = False
        '
        'lblHeaderMedical
        '
        Me.lblHeaderMedical.AutoSize = True
        Me.lblHeaderMedical.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderMedical.Location = New System.Drawing.Point(6, 0)
        Me.lblHeaderMedical.Name = "lblHeaderMedical"
        Me.lblHeaderMedical.Size = New System.Drawing.Size(121, 19)
        Me.lblHeaderMedical.TabIndex = 33
        Me.lblHeaderMedical.Text = "Medical Details"
        '
        'lblMedical
        '
        Me.lblMedical.AutoSize = True
        Me.lblMedical.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedical.Location = New System.Drawing.Point(7, 20)
        Me.lblMedical.Name = "lblMedical"
        Me.lblMedical.Size = New System.Drawing.Size(123, 16)
        Me.lblMedical.TabIndex = 31
        Me.lblMedical.Text = "Medical Information"
        '
        'gpbStudent
        '
        Me.gpbStudent.Controls.Add(Me.lblLName)
        Me.gpbStudent.Controls.Add(Me.lblFName)
        Me.gpbStudent.Controls.Add(Me.lblRoll)
        Me.gpbStudent.Location = New System.Drawing.Point(828, 92)
        Me.gpbStudent.Name = "gpbStudent"
        Me.gpbStudent.Size = New System.Drawing.Size(234, 64)
        Me.gpbStudent.TabIndex = 77
        Me.gpbStudent.TabStop = False
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(9, 0)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(86, 19)
        Me.lblLName.TabIndex = 17
        Me.lblLName.Text = "Last Name"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(9, 20)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(89, 19)
        Me.lblFName.TabIndex = 18
        Me.lblFName.Text = "First Name"
        '
        'lblRoll
        '
        Me.lblRoll.AutoSize = True
        Me.lblRoll.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoll.Location = New System.Drawing.Point(9, 40)
        Me.lblRoll.Name = "lblRoll"
        Me.lblRoll.Size = New System.Drawing.Size(79, 19)
        Me.lblRoll.TabIndex = 19
        Me.lblRoll.Text = "Roll Class"
        '
        'flpAthletes
        '
        Me.flpAthletes.AutoScroll = True
        Me.flpAthletes.Location = New System.Drawing.Point(12, 65)
        Me.flpAthletes.Name = "flpAthletes"
        Me.flpAthletes.Size = New System.Drawing.Size(604, 604)
        Me.flpAthletes.TabIndex = 69
        '
        'lblAgeGroup
        '
        Me.lblAgeGroup.AutoSize = True
        Me.lblAgeGroup.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeGroup.Location = New System.Drawing.Point(10, 20)
        Me.lblAgeGroup.Name = "lblAgeGroup"
        Me.lblAgeGroup.Size = New System.Drawing.Size(72, 16)
        Me.lblAgeGroup.TabIndex = 26
        Me.lblAgeGroup.Text = "Age Group"
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
        'lblPo
        '
        Me.lblPo.AutoSize = True
        Me.lblPo.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPo.Location = New System.Drawing.Point(5, 59)
        Me.lblPo.Name = "lblPo"
        Me.lblPo.Size = New System.Drawing.Size(61, 16)
        Me.lblPo.TabIndex = 22
        Me.lblPo.Text = "Postcode"
        '
        'lblSb
        '
        Me.lblSb.AutoSize = True
        Me.lblSb.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSb.Location = New System.Drawing.Point(5, 46)
        Me.lblSb.Name = "lblSb"
        Me.lblSb.Size = New System.Drawing.Size(50, 16)
        Me.lblSb.TabIndex = 23
        Me.lblSb.Text = "Suburb"
        '
        'gpbContact
        '
        Me.gpbContact.Controls.Add(Me.lblHeaderContact)
        Me.gpbContact.Controls.Add(Me.lblEmail)
        Me.gpbContact.Controls.Add(Me.lblPhone)
        Me.gpbContact.Location = New System.Drawing.Point(828, 384)
        Me.gpbContact.Name = "gpbContact"
        Me.gpbContact.Size = New System.Drawing.Size(234, 52)
        Me.gpbContact.TabIndex = 74
        Me.gpbContact.TabStop = False
        '
        'lblSt
        '
        Me.lblSt.AutoSize = True
        Me.lblSt.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSt.Location = New System.Drawing.Point(5, 33)
        Me.lblSt.Name = "lblSt"
        Me.lblSt.Size = New System.Drawing.Size(42, 16)
        Me.lblSt.TabIndex = 24
        Me.lblSt.Text = "Street"
        '
        'gpbAthlete
        '
        Me.gpbAthlete.Controls.Add(Me.btnCommitTeams)
        Me.gpbAthlete.Controls.Add(Me.lblTeams)
        Me.gpbAthlete.Controls.Add(Me.flpTeams)
        Me.gpbAthlete.Controls.Add(Me.lblHeaderAthlete)
        Me.gpbAthlete.Controls.Add(Me.lblAgeGroup)
        Me.gpbAthlete.Controls.Add(Me.lblBestEvent)
        Me.gpbAthlete.Location = New System.Drawing.Point(828, 162)
        Me.gpbAthlete.Name = "gpbAthlete"
        Me.gpbAthlete.Size = New System.Drawing.Size(234, 167)
        Me.gpbAthlete.TabIndex = 76
        Me.gpbAthlete.TabStop = False
        '
        'btnCommitTeams
        '
        Me.btnCommitTeams.BackgroundImage = Global.main.My.Resources.Resources.iconSwitch
        Me.btnCommitTeams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCommitTeams.Location = New System.Drawing.Point(189, 93)
        Me.btnCommitTeams.Name = "btnCommitTeams"
        Me.btnCommitTeams.Size = New System.Drawing.Size(40, 40)
        Me.btnCommitTeams.TabIndex = 49
        Me.btnCommitTeams.UseVisualStyleBackColor = True
        '
        'lblTeams
        '
        Me.lblTeams.AutoSize = True
        Me.lblTeams.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeams.Location = New System.Drawing.Point(10, 55)
        Me.lblTeams.Name = "lblTeams"
        Me.lblTeams.Size = New System.Drawing.Size(46, 16)
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
        Me.lblHeaderAthlete.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderAthlete.Location = New System.Drawing.Point(6, 0)
        Me.lblHeaderAthlete.Name = "lblHeaderAthlete"
        Me.lblHeaderAthlete.Size = New System.Drawing.Size(115, 19)
        Me.lblHeaderAthlete.TabIndex = 34
        Me.lblHeaderAthlete.Text = "Athlete Details"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(432, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(397, 20)
        Me.txtSearch.TabIndex = 70
        '
        'gpbAddress
        '
        Me.gpbAddress.Controls.Add(Me.lblHeaderAddress)
        Me.gpbAddress.Controls.Add(Me.lblPo)
        Me.gpbAddress.Controls.Add(Me.lblSb)
        Me.gpbAddress.Controls.Add(Me.lblSt)
        Me.gpbAddress.Controls.Add(Me.lblStNo)
        Me.gpbAddress.Location = New System.Drawing.Point(828, 442)
        Me.gpbAddress.Name = "gpbAddress"
        Me.gpbAddress.Size = New System.Drawing.Size(234, 79)
        Me.gpbAddress.TabIndex = 73
        Me.gpbAddress.TabStop = False
        '
        'lblStNo
        '
        Me.lblStNo.AutoSize = True
        Me.lblStNo.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStNo.Location = New System.Drawing.Point(5, 20)
        Me.lblStNo.Name = "lblStNo"
        Me.lblStNo.Size = New System.Drawing.Size(92, 16)
        Me.lblStNo.TabIndex = 25
        Me.lblStNo.Text = "Street Number"
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = Global.main.My.Resources.Resources.iconNotepad
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Location = New System.Drawing.Point(622, 398)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 75)
        Me.btnEdit.TabIndex = 78
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.main.My.Resources.Resources.iconCancel
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Location = New System.Drawing.Point(703, 594)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 75)
        Me.btnCancel.TabIndex = 81
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.main.My.Resources.Resources.iconSave
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Location = New System.Drawing.Point(622, 594)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 75)
        Me.btnSave.TabIndex = 80
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'pbPhoto
        '
        Me.pbPhoto.Location = New System.Drawing.Point(622, 92)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(200, 300)
        Me.pbPhoto.TabIndex = 72
        Me.pbPhoto.TabStop = False
        '
        'cmbSort
        '
        Me.cmbSort.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSort.FormattingEnabled = True
        Me.cmbSort.Items.AddRange(New Object() {"ID", "First Name (Ascending)", "First Name (Descending)", "Last Name (Ascending)", "Last Name (Descending)"})
        Me.cmbSort.Location = New System.Drawing.Point(432, 38)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(150, 24)
        Me.cmbSort.TabIndex = 89
        Me.cmbSort.Text = "Sort By"
        '
        'cmbAgeGroup
        '
        Me.cmbAgeGroup.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgeGroup.FormattingEnabled = True
        Me.cmbAgeGroup.Items.AddRange(New Object() {"U13", "U14", "U15", "U16", "U17", "Opens"})
        Me.cmbAgeGroup.Location = New System.Drawing.Point(588, 38)
        Me.cmbAgeGroup.Name = "cmbAgeGroup"
        Me.cmbAgeGroup.Size = New System.Drawing.Size(121, 24)
        Me.cmbAgeGroup.TabIndex = 88
        Me.cmbAgeGroup.Text = "Age Group"
        '
        'selectAthlete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.cmbSort)
        Me.Controls.Add(Me.gpbTeamManagement)
        Me.Controls.Add(Me.cmbAgeGroup)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtBestEvent)
        Me.Controls.Add(Me.cmbAge)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gpbMedical)
        Me.Controls.Add(Me.gpbStudent)
        Me.Controls.Add(Me.flpAthletes)
        Me.Controls.Add(Me.pbPhoto)
        Me.Controls.Add(Me.gpbContact)
        Me.Controls.Add(Me.gpbAthlete)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.gpbAddress)
        Me.Name = "selectAthlete"
        Me.Text = "selectAthlete"
        Me.gpbTeamManagement.ResumeLayout(False)
        Me.gpbTeamManagement.PerformLayout()
        Me.gpbMedical.ResumeLayout(False)
        Me.gpbMedical.PerformLayout()
        Me.gpbStudent.ResumeLayout(False)
        Me.gpbStudent.PerformLayout()
        Me.gpbContact.ResumeLayout(False)
        Me.gpbContact.PerformLayout()
        Me.gpbAthlete.ResumeLayout(False)
        Me.gpbAthlete.PerformLayout()
        Me.gpbAddress.ResumeLayout(False)
        Me.gpbAddress.PerformLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gpbTeamManagement As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblHeaderTeamManagement As Label
    Friend WithEvents btnNewTeam As Button
    Friend WithEvents flpAttachTeam As FlowLayoutPanel
    Friend WithEvents lblID As Label
    Friend WithEvents lblBestEvent As Label
    Friend WithEvents lblHeaderContact As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtBestEvent As TextBox
    Friend WithEvents cmbAge As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents gpbMedical As GroupBox
    Friend WithEvents lblHeaderMedical As Label
    Friend WithEvents lblMedical As Label
    Friend WithEvents gpbStudent As GroupBox
    Friend WithEvents lblLName As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents lblRoll As Label
    Friend WithEvents flpAthletes As FlowLayoutPanel
    Friend WithEvents lblAgeGroup As Label
    Friend WithEvents lblHeaderAddress As Label
    Friend WithEvents pbPhoto As PictureBox
    Friend WithEvents lblPo As Label
    Friend WithEvents lblSb As Label
    Friend WithEvents gpbContact As GroupBox
    Friend WithEvents lblSt As Label
    Friend WithEvents gpbAthlete As GroupBox
    Friend WithEvents btnCommitTeams As Button
    Friend WithEvents lblTeams As Label
    Friend WithEvents flpTeams As FlowLayoutPanel
    Friend WithEvents lblHeaderAthlete As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents gpbAddress As GroupBox
    Friend WithEvents lblStNo As Label
    Friend WithEvents cmbSort As ComboBox
    Friend WithEvents cmbAgeGroup As ComboBox
    Friend WithEvents lblTeamSearch As Label
    Friend WithEvents cmbTeamAgeGroup As ComboBox
End Class
