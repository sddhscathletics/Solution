﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(selectAthlete))
        Me.gpbTeamManagement = New System.Windows.Forms.GroupBox()
        Me.cmbTeamAgeGroup = New System.Windows.Forms.ComboBox()
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
        Me.cmbSort = New System.Windows.Forms.ComboBox()
        Me.cmbAgeGroup = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAlertCount = New System.Windows.Forms.Label()
        Me.helpBtn = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.scrollBtn = New System.Windows.Forms.Button()
        Me.Sidebar = New System.Windows.Forms.GroupBox()
        Me.sideteamBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.resdrop = New System.Windows.Forms.Button()
        Me.sideAthletesBtn = New System.Windows.Forms.Button()
        Me.sideadminBtn = New System.Windows.Forms.Button()
        Me.sideresultBtn = New System.Windows.Forms.Button()
        Me.sidecalendarBtn = New System.Windows.Forms.Button()
        Me.sideResSub1 = New System.Windows.Forms.Button()
        Me.sideResSub2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.sidebartime = New System.Windows.Forms.Timer(Me.components)
        Me.bigbtngroup = New System.Windows.Forms.GroupBox()
        Me.gpbEditing = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tmrAlert = New System.Windows.Forms.Timer(Me.components)
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.gpbTeamManagement.SuspendLayout()
        Me.gpbMedical.SuspendLayout()
        Me.gpbStudent.SuspendLayout()
        Me.gpbContact.SuspendLayout()
        Me.gpbAthlete.SuspendLayout()
        Me.gpbAddress.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Sidebar.SuspendLayout()
        Me.bigbtngroup.SuspendLayout()
        Me.gpbEditing.SuspendLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbTeamManagement
        '
        Me.gpbTeamManagement.Controls.Add(Me.cmbTeamAgeGroup)
        Me.gpbTeamManagement.Controls.Add(Me.lblHeaderTeamManagement)
        Me.gpbTeamManagement.Controls.Add(Me.btnNewTeam)
        Me.gpbTeamManagement.Controls.Add(Me.flpAttachTeam)
        Me.gpbTeamManagement.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbTeamManagement.Location = New System.Drawing.Point(1082, 206)
        Me.gpbTeamManagement.Name = "gpbTeamManagement"
        Me.gpbTeamManagement.Size = New System.Drawing.Size(184, 314)
        Me.gpbTeamManagement.TabIndex = 84
        Me.gpbTeamManagement.TabStop = False
        '
        'cmbTeamAgeGroup
        '
        Me.cmbTeamAgeGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTeamAgeGroup.FormattingEnabled = True
        Me.cmbTeamAgeGroup.Items.AddRange(New Object() {"U13", "U14", "U15", "U16", "U17", "Opens"})
        Me.cmbTeamAgeGroup.Location = New System.Drawing.Point(6, 29)
        Me.cmbTeamAgeGroup.Name = "cmbTeamAgeGroup"
        Me.cmbTeamAgeGroup.Size = New System.Drawing.Size(170, 24)
        Me.cmbTeamAgeGroup.TabIndex = 90
        Me.cmbTeamAgeGroup.Text = "Age Group"
        '
        'lblHeaderTeamManagement
        '
        Me.lblHeaderTeamManagement.AutoSize = True
        Me.lblHeaderTeamManagement.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTeamManagement.Location = New System.Drawing.Point(6, 7)
        Me.lblHeaderTeamManagement.Name = "lblHeaderTeamManagement"
        Me.lblHeaderTeamManagement.Size = New System.Drawing.Size(150, 19)
        Me.lblHeaderTeamManagement.TabIndex = 34
        Me.lblHeaderTeamManagement.Text = "Team Management"
        '
        'btnNewTeam
        '
        Me.btnNewTeam.BackColor = System.Drawing.Color.Gray
        Me.btnNewTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewTeam.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewTeam.Location = New System.Drawing.Point(6, 277)
        Me.btnNewTeam.Name = "btnNewTeam"
        Me.btnNewTeam.Size = New System.Drawing.Size(170, 31)
        Me.btnNewTeam.TabIndex = 51
        Me.btnNewTeam.Text = "CREATE NEW TEAM"
        Me.btnNewTeam.UseVisualStyleBackColor = False
        '
        'flpAttachTeam
        '
        Me.flpAttachTeam.AutoScroll = True
        Me.flpAttachTeam.Location = New System.Drawing.Point(6, 59)
        Me.flpAttachTeam.Name = "flpAttachTeam"
        Me.flpAttachTeam.Size = New System.Drawing.Size(170, 212)
        Me.flpAttachTeam.TabIndex = 50
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(632, 109)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(278, 24)
        Me.lblID.TabIndex = 71
        Me.lblID.Text = "SELECT A STUDENT TO START"
        '
        'lblBestEvent
        '
        Me.lblBestEvent.AutoSize = True
        Me.lblBestEvent.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBestEvent.Location = New System.Drawing.Point(10, 39)
        Me.lblBestEvent.Name = "lblBestEvent"
        Me.lblBestEvent.Size = New System.Drawing.Size(71, 17)
        Me.lblBestEvent.TabIndex = 27
        Me.lblBestEvent.Text = "Best Event"
        '
        'lblHeaderContact
        '
        Me.lblHeaderContact.AutoSize = True
        Me.lblHeaderContact.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderContact.Location = New System.Drawing.Point(6, 0)
        Me.lblHeaderContact.Name = "lblHeaderContact"
        Me.lblHeaderContact.Size = New System.Drawing.Size(120, 19)
        Me.lblHeaderContact.TabIndex = 34
        Me.lblHeaderContact.Text = "Contact Details"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(7, 42)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(92, 17)
        Me.lblEmail.TabIndex = 28
        Me.lblEmail.Text = "Email Address"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(7, 20)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(100, 17)
        Me.lblPhone.TabIndex = 29
        Me.lblPhone.Text = "Phone Number"
        '
        'txtBestEvent
        '
        Me.txtBestEvent.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBestEvent.Location = New System.Drawing.Point(4, 89)
        Me.txtBestEvent.Name = "txtBestEvent"
        Me.txtBestEvent.Size = New System.Drawing.Size(172, 23)
        Me.txtBestEvent.TabIndex = 82
        '
        'cmbAge
        '
        Me.cmbAge.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAge.FormattingEnabled = True
        Me.cmbAge.Items.AddRange(New Object() {"U13", "U14", "U15", "U16", "Opens"})
        Me.cmbAge.Location = New System.Drawing.Point(6, 38)
        Me.cmbAge.Name = "cmbAge"
        Me.cmbAge.Size = New System.Drawing.Size(74, 23)
        Me.cmbAge.TabIndex = 83
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(717, 445)
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
        Me.gpbMedical.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbMedical.Location = New System.Drawing.Point(842, 379)
        Me.gpbMedical.Name = "gpbMedical"
        Me.gpbMedical.Size = New System.Drawing.Size(234, 43)
        Me.gpbMedical.TabIndex = 75
        Me.gpbMedical.TabStop = False
        '
        'lblHeaderMedical
        '
        Me.lblHeaderMedical.AutoSize = True
        Me.lblHeaderMedical.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderMedical.Location = New System.Drawing.Point(6, 0)
        Me.lblHeaderMedical.Name = "lblHeaderMedical"
        Me.lblHeaderMedical.Size = New System.Drawing.Size(121, 19)
        Me.lblHeaderMedical.TabIndex = 33
        Me.lblHeaderMedical.Text = "Medical Details"
        '
        'lblMedical
        '
        Me.lblMedical.AutoSize = True
        Me.lblMedical.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedical.Location = New System.Drawing.Point(7, 20)
        Me.lblMedical.Name = "lblMedical"
        Me.lblMedical.Size = New System.Drawing.Size(130, 17)
        Me.lblMedical.TabIndex = 31
        Me.lblMedical.Text = "Medical Information"
        '
        'gpbStudent
        '
        Me.gpbStudent.Controls.Add(Me.lblLName)
        Me.gpbStudent.Controls.Add(Me.lblFName)
        Me.gpbStudent.Controls.Add(Me.lblRoll)
        Me.gpbStudent.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbStudent.Location = New System.Drawing.Point(842, 136)
        Me.gpbStudent.Name = "gpbStudent"
        Me.gpbStudent.Size = New System.Drawing.Size(234, 64)
        Me.gpbStudent.TabIndex = 77
        Me.gpbStudent.TabStop = False
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(9, 0)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(85, 19)
        Me.lblLName.TabIndex = 17
        Me.lblLName.Text = "Last Name"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(9, 20)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(73, 17)
        Me.lblFName.TabIndex = 18
        Me.lblFName.Text = "First Name"
        '
        'lblRoll
        '
        Me.lblRoll.AutoSize = True
        Me.lblRoll.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoll.Location = New System.Drawing.Point(9, 40)
        Me.lblRoll.Name = "lblRoll"
        Me.lblRoll.Size = New System.Drawing.Size(64, 17)
        Me.lblRoll.TabIndex = 19
        Me.lblRoll.Text = "Roll Class"
        '
        'flpAthletes
        '
        Me.flpAthletes.AutoScroll = True
        Me.flpAthletes.Location = New System.Drawing.Point(6, 108)
        Me.flpAthletes.Name = "flpAthletes"
        Me.flpAthletes.Size = New System.Drawing.Size(624, 532)
        Me.flpAthletes.TabIndex = 69
        '
        'lblAgeGroup
        '
        Me.lblAgeGroup.AutoSize = True
        Me.lblAgeGroup.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeGroup.Location = New System.Drawing.Point(10, 20)
        Me.lblAgeGroup.Name = "lblAgeGroup"
        Me.lblAgeGroup.Size = New System.Drawing.Size(74, 17)
        Me.lblAgeGroup.TabIndex = 26
        Me.lblAgeGroup.Text = "Age Group"
        '
        'lblHeaderAddress
        '
        Me.lblHeaderAddress.AutoSize = True
        Me.lblHeaderAddress.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderAddress.Location = New System.Drawing.Point(4, 0)
        Me.lblHeaderAddress.Name = "lblHeaderAddress"
        Me.lblHeaderAddress.Size = New System.Drawing.Size(69, 19)
        Me.lblHeaderAddress.TabIndex = 32
        Me.lblHeaderAddress.Text = "Address"
        '
        'lblPo
        '
        Me.lblPo.AutoSize = True
        Me.lblPo.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPo.Location = New System.Drawing.Point(5, 71)
        Me.lblPo.Name = "lblPo"
        Me.lblPo.Size = New System.Drawing.Size(64, 17)
        Me.lblPo.TabIndex = 22
        Me.lblPo.Text = "Postcode"
        '
        'lblSb
        '
        Me.lblSb.AutoSize = True
        Me.lblSb.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSb.Location = New System.Drawing.Point(5, 54)
        Me.lblSb.Name = "lblSb"
        Me.lblSb.Size = New System.Drawing.Size(52, 17)
        Me.lblSb.TabIndex = 23
        Me.lblSb.Text = "Suburb"
        '
        'gpbContact
        '
        Me.gpbContact.Controls.Add(Me.lblHeaderContact)
        Me.gpbContact.Controls.Add(Me.lblEmail)
        Me.gpbContact.Controls.Add(Me.lblPhone)
        Me.gpbContact.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbContact.Location = New System.Drawing.Point(842, 428)
        Me.gpbContact.Name = "gpbContact"
        Me.gpbContact.Size = New System.Drawing.Size(234, 67)
        Me.gpbContact.TabIndex = 74
        Me.gpbContact.TabStop = False
        '
        'lblSt
        '
        Me.lblSt.AutoSize = True
        Me.lblSt.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSt.Location = New System.Drawing.Point(5, 37)
        Me.lblSt.Name = "lblSt"
        Me.lblSt.Size = New System.Drawing.Size(44, 17)
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
        Me.gpbAthlete.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbAthlete.Location = New System.Drawing.Point(842, 206)
        Me.gpbAthlete.Name = "gpbAthlete"
        Me.gpbAthlete.Size = New System.Drawing.Size(234, 167)
        Me.gpbAthlete.TabIndex = 76
        Me.gpbAthlete.TabStop = False
        '
        'btnCommitTeams
        '
        Me.btnCommitTeams.BackgroundImage = Global.main.My.Resources.Resources.iconSwitch
        Me.btnCommitTeams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCommitTeams.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCommitTeams.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCommitTeams.Location = New System.Drawing.Point(189, 93)
        Me.btnCommitTeams.Name = "btnCommitTeams"
        Me.btnCommitTeams.Size = New System.Drawing.Size(40, 40)
        Me.btnCommitTeams.TabIndex = 49
        Me.btnCommitTeams.UseVisualStyleBackColor = True
        '
        'lblTeams
        '
        Me.lblTeams.AutoSize = True
        Me.lblTeams.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeams.Location = New System.Drawing.Point(10, 55)
        Me.lblTeams.Name = "lblTeams"
        Me.lblTeams.Size = New System.Drawing.Size(47, 17)
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
        Me.lblHeaderAthlete.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderAthlete.Location = New System.Drawing.Point(6, 0)
        Me.lblHeaderAthlete.Name = "lblHeaderAthlete"
        Me.lblHeaderAthlete.Size = New System.Drawing.Size(117, 19)
        Me.lblHeaderAthlete.TabIndex = 34
        Me.lblHeaderAthlete.Text = "Athlete Details"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(411, 51)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(397, 24)
        Me.txtSearch.TabIndex = 70
        '
        'gpbAddress
        '
        Me.gpbAddress.Controls.Add(Me.lblHeaderAddress)
        Me.gpbAddress.Controls.Add(Me.lblPo)
        Me.gpbAddress.Controls.Add(Me.lblSb)
        Me.gpbAddress.Controls.Add(Me.lblSt)
        Me.gpbAddress.Controls.Add(Me.lblStNo)
        Me.gpbAddress.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbAddress.Location = New System.Drawing.Point(842, 501)
        Me.gpbAddress.Name = "gpbAddress"
        Me.gpbAddress.Size = New System.Drawing.Size(234, 96)
        Me.gpbAddress.TabIndex = 73
        Me.gpbAddress.TabStop = False
        '
        'lblStNo
        '
        Me.lblStNo.AutoSize = True
        Me.lblStNo.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStNo.Location = New System.Drawing.Point(5, 20)
        Me.lblStNo.Name = "lblStNo"
        Me.lblStNo.Size = New System.Drawing.Size(97, 17)
        Me.lblStNo.TabIndex = 25
        Me.lblStNo.Text = "Street Number"
        '
        'cmbSort
        '
        Me.cmbSort.Font = New System.Drawing.Font("Microsoft JhengHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSort.FormattingEnabled = True
        Me.cmbSort.Items.AddRange(New Object() {"ID", "First Name (Ascending)", "First Name (Descending)", "Last Name (Ascending)", "Last Name (Descending)"})
        Me.cmbSort.Location = New System.Drawing.Point(480, 81)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(150, 22)
        Me.cmbSort.TabIndex = 89
        Me.cmbSort.Text = "Sort By"
        '
        'cmbAgeGroup
        '
        Me.cmbAgeGroup.Font = New System.Drawing.Font("Microsoft JhengHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgeGroup.FormattingEnabled = True
        Me.cmbAgeGroup.Items.AddRange(New Object() {"All", "U13", "U14", "U15", "U16", "U17", "Opens"})
        Me.cmbAgeGroup.Location = New System.Drawing.Point(636, 81)
        Me.cmbAgeGroup.Name = "cmbAgeGroup"
        Me.cmbAgeGroup.Size = New System.Drawing.Size(121, 22)
        Me.cmbAgeGroup.TabIndex = 88
        Me.cmbAgeGroup.Text = "Age Group"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.lblTitle)
        Me.GroupBox2.Controls.Add(Me.lblAlertCount)
        Me.GroupBox2.Controls.Add(Me.helpBtn)
        Me.GroupBox2.Controls.Add(Me.Button13)
        Me.GroupBox2.Controls.Add(Me.exitBtn)
        Me.GroupBox2.Controls.Add(Me.scrollBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(-10, -11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1377, 58)
        Me.GroupBox2.TabIndex = 90
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblTitle.Location = New System.Drawing.Point(84, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(192, 27)
        Me.lblTitle.TabIndex = 91
        Me.lblTitle.Text = "VIEW ATHLETES"
        '
        'lblAlertCount
        '
        Me.lblAlertCount.AutoSize = True
        Me.lblAlertCount.BackColor = System.Drawing.Color.DarkGray
        Me.lblAlertCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlertCount.Location = New System.Drawing.Point(1224, 17)
        Me.lblAlertCount.Name = "lblAlertCount"
        Me.lblAlertCount.Size = New System.Drawing.Size(15, 16)
        Me.lblAlertCount.TabIndex = 3
        Me.lblAlertCount.Text = "0"
        Me.lblAlertCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'helpBtn
        '
        Me.helpBtn.BackColor = System.Drawing.SystemColors.GrayText
        Me.helpBtn.BackgroundImage = Global.main.My.Resources.Resources.helpbtn
        Me.helpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.helpBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.helpBtn.FlatAppearance.BorderSize = 0
        Me.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.helpBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.helpBtn.Location = New System.Drawing.Point(1157, 11)
        Me.helpBtn.Name = "helpBtn"
        Me.helpBtn.Size = New System.Drawing.Size(44, 44)
        Me.helpBtn.TabIndex = 6
        Me.helpBtn.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.GrayText
        Me.Button13.BackgroundImage = Global.main.My.Resources.Resources.notifbtn
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button13.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button13.Location = New System.Drawing.Point(1201, 11)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(44, 44)
        Me.Button13.TabIndex = 6
        Me.Button13.UseVisualStyleBackColor = False
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.SystemColors.GrayText
        Me.exitBtn.BackgroundImage = Global.main.My.Resources.Resources.close1
        Me.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitBtn.FlatAppearance.BorderSize = 0
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.exitBtn.Location = New System.Drawing.Point(1245, 11)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(44, 44)
        Me.exitBtn.TabIndex = 6
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'scrollBtn
        '
        Me.scrollBtn.BackColor = System.Drawing.SystemColors.GrayText
        Me.scrollBtn.BackgroundImage = Global.main.My.Resources.Resources.scrollbtn
        Me.scrollBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.scrollBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.scrollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scrollBtn.Location = New System.Drawing.Point(10, 11)
        Me.scrollBtn.Name = "scrollBtn"
        Me.scrollBtn.Size = New System.Drawing.Size(44, 44)
        Me.scrollBtn.TabIndex = 3
        Me.scrollBtn.UseVisualStyleBackColor = False
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Sidebar.Controls.Add(Me.sideteamBtn)
        Me.Sidebar.Controls.Add(Me.Button2)
        Me.Sidebar.Controls.Add(Me.resdrop)
        Me.Sidebar.Controls.Add(Me.sideAthletesBtn)
        Me.Sidebar.Controls.Add(Me.sideadminBtn)
        Me.Sidebar.Controls.Add(Me.sideresultBtn)
        Me.Sidebar.Controls.Add(Me.sidecalendarBtn)
        Me.Sidebar.Controls.Add(Me.sideResSub1)
        Me.Sidebar.Controls.Add(Me.sideResSub2)
        Me.Sidebar.Location = New System.Drawing.Point(-200, 20)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(200, 731)
        Me.Sidebar.TabIndex = 91
        Me.Sidebar.TabStop = False
        '
        'sideteamBtn
        '
        Me.sideteamBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sideteamBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sideteamBtn.FlatAppearance.BorderSize = 0
        Me.sideteamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sideteamBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sideteamBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sideteamBtn.Location = New System.Drawing.Point(2, 237)
        Me.sideteamBtn.Name = "sideteamBtn"
        Me.sideteamBtn.Size = New System.Drawing.Size(196, 50)
        Me.sideteamBtn.TabIndex = 4
        Me.sideteamBtn.Text = "   MANAGE TEAMS"
        Me.sideteamBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sideteamBtn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Location = New System.Drawing.Point(2, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 50)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "   MAIN"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'resdrop
        '
        Me.resdrop.BackColor = System.Drawing.Color.Gray
        Me.resdrop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.resdrop.FlatAppearance.BorderSize = 0
        Me.resdrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.resdrop.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.resdrop.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.resdrop.Location = New System.Drawing.Point(173, 135)
        Me.resdrop.Name = "resdrop"
        Me.resdrop.Size = New System.Drawing.Size(25, 50)
        Me.resdrop.TabIndex = 1
        Me.resdrop.Text = "▼"
        Me.resdrop.UseVisualStyleBackColor = False
        '
        'sideAthletesBtn
        '
        Me.sideAthletesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sideAthletesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sideAthletesBtn.FlatAppearance.BorderSize = 0
        Me.sideAthletesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sideAthletesBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.sideAthletesBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sideAthletesBtn.Location = New System.Drawing.Point(2, 186)
        Me.sideAthletesBtn.Name = "sideAthletesBtn"
        Me.sideAthletesBtn.Size = New System.Drawing.Size(196, 50)
        Me.sideAthletesBtn.TabIndex = 0
        Me.sideAthletesBtn.Text = "   ATHLETES"
        Me.sideAthletesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sideAthletesBtn.UseVisualStyleBackColor = False
        '
        'sideadminBtn
        '
        Me.sideadminBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sideadminBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sideadminBtn.FlatAppearance.BorderSize = 0
        Me.sideadminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sideadminBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sideadminBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sideadminBtn.Location = New System.Drawing.Point(2, 288)
        Me.sideadminBtn.Name = "sideadminBtn"
        Me.sideadminBtn.Size = New System.Drawing.Size(196, 50)
        Me.sideadminBtn.TabIndex = 0
        Me.sideadminBtn.Text = "   MANAGE USERS"
        Me.sideadminBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sideadminBtn.UseVisualStyleBackColor = False
        '
        'sideresultBtn
        '
        Me.sideresultBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sideresultBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sideresultBtn.FlatAppearance.BorderSize = 0
        Me.sideresultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sideresultBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.sideresultBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sideresultBtn.Location = New System.Drawing.Point(2, 135)
        Me.sideresultBtn.Name = "sideresultBtn"
        Me.sideresultBtn.Size = New System.Drawing.Size(196, 50)
        Me.sideresultBtn.TabIndex = 0
        Me.sideresultBtn.Text = "   RESULTS"
        Me.sideresultBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sideresultBtn.UseVisualStyleBackColor = False
        '
        'sidecalendarBtn
        '
        Me.sidecalendarBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sidecalendarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sidecalendarBtn.FlatAppearance.BorderSize = 0
        Me.sidecalendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sidecalendarBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.sidecalendarBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sidecalendarBtn.Location = New System.Drawing.Point(2, 84)
        Me.sidecalendarBtn.Name = "sidecalendarBtn"
        Me.sidecalendarBtn.Size = New System.Drawing.Size(196, 50)
        Me.sidecalendarBtn.TabIndex = 0
        Me.sidecalendarBtn.Text = "   CALENDAR"
        Me.sidecalendarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sidecalendarBtn.UseVisualStyleBackColor = False
        '
        'sideResSub1
        '
        Me.sideResSub1.BackColor = System.Drawing.Color.Gray
        Me.sideResSub1.FlatAppearance.BorderSize = 0
        Me.sideResSub1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sideResSub1.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.sideResSub1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sideResSub1.Location = New System.Drawing.Point(2, 126)
        Me.sideResSub1.Name = "sideResSub1"
        Me.sideResSub1.Size = New System.Drawing.Size(196, 29)
        Me.sideResSub1.TabIndex = 2
        Me.sideResSub1.Text = "   RESULTS SUB 1"
        Me.sideResSub1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sideResSub1.UseVisualStyleBackColor = False
        '
        'sideResSub2
        '
        Me.sideResSub2.BackColor = System.Drawing.Color.Gray
        Me.sideResSub2.FlatAppearance.BorderSize = 0
        Me.sideResSub2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sideResSub2.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.sideResSub2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sideResSub2.Location = New System.Drawing.Point(2, 156)
        Me.sideResSub2.Name = "sideResSub2"
        Me.sideResSub2.Size = New System.Drawing.Size(196, 29)
        Me.sideResSub2.TabIndex = 2
        Me.sideResSub2.Text = "   RESULTS SUB 1"
        Me.sideResSub2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sideResSub2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'sidebartime
        '
        Me.sidebartime.Interval = 1
        '
        'bigbtngroup
        '
        Me.bigbtngroup.Controls.Add(Me.btnHelp)
        Me.bigbtngroup.Controls.Add(Me.gpbEditing)
        Me.bigbtngroup.Controls.Add(Me.cmbSort)
        Me.bigbtngroup.Controls.Add(Me.flpAthletes)
        Me.bigbtngroup.Controls.Add(Me.Button1)
        Me.bigbtngroup.Controls.Add(Me.gpbAddress)
        Me.bigbtngroup.Controls.Add(Me.gpbTeamManagement)
        Me.bigbtngroup.Controls.Add(Me.txtSearch)
        Me.bigbtngroup.Controls.Add(Me.cmbAgeGroup)
        Me.bigbtngroup.Controls.Add(Me.gpbAthlete)
        Me.bigbtngroup.Controls.Add(Me.lblID)
        Me.bigbtngroup.Controls.Add(Me.gpbContact)
        Me.bigbtngroup.Controls.Add(Me.btnEdit)
        Me.bigbtngroup.Controls.Add(Me.pbPhoto)
        Me.bigbtngroup.Controls.Add(Me.btnCancel)
        Me.bigbtngroup.Controls.Add(Me.gpbStudent)
        Me.bigbtngroup.Controls.Add(Me.btnSave)
        Me.bigbtngroup.Controls.Add(Me.gpbMedical)
        Me.bigbtngroup.Location = New System.Drawing.Point(0, 10)
        Me.bigbtngroup.Name = "bigbtngroup"
        Me.bigbtngroup.Size = New System.Drawing.Size(1279, 678)
        Me.bigbtngroup.TabIndex = 92
        Me.bigbtngroup.TabStop = False
        '
        'gpbEditing
        '
        Me.gpbEditing.Controls.Add(Me.Label3)
        Me.gpbEditing.Controls.Add(Me.Label2)
        Me.gpbEditing.Controls.Add(Me.Label1)
        Me.gpbEditing.Controls.Add(Me.txtBestEvent)
        Me.gpbEditing.Controls.Add(Me.cmbAge)
        Me.gpbEditing.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbEditing.Location = New System.Drawing.Point(1082, 526)
        Me.gpbEditing.Name = "gpbEditing"
        Me.gpbEditing.Size = New System.Drawing.Size(184, 125)
        Me.gpbEditing.TabIndex = 74
        Me.gpbEditing.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Best Event"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Age Group"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Editing"
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = Global.main.My.Resources.Resources.iconNotepad
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Location = New System.Drawing.Point(636, 442)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 75)
        Me.btnEdit.TabIndex = 78
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'pbPhoto
        '
        Me.pbPhoto.Location = New System.Drawing.Point(636, 136)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(200, 300)
        Me.pbPhoto.TabIndex = 72
        Me.pbPhoto.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.BackgroundImage = Global.main.My.Resources.Resources.close1
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(717, 566)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 75)
        Me.btnCancel.TabIndex = 81
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSave.BackgroundImage = Global.main.My.Resources.Resources.savebtn
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(636, 566)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 75)
        Me.btnSave.TabIndex = 80
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'tmrAlert
        '
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(1245, 43)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(23, 23)
        Me.btnHelp.TabIndex = 94
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'selectAthlete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Sidebar)
        Me.Controls.Add(Me.bigbtngroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "selectAthlete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Sidebar.ResumeLayout(False)
        Me.bigbtngroup.ResumeLayout(False)
        Me.bigbtngroup.PerformLayout()
        Me.gpbEditing.ResumeLayout(False)
        Me.gpbEditing.PerformLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbTeamManagement As GroupBox
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAlertCount As System.Windows.Forms.Label
    Friend WithEvents helpBtn As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents scrollBtn As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Sidebar As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents resdrop As System.Windows.Forms.Button
    Friend WithEvents sideAthletesBtn As System.Windows.Forms.Button
    Friend WithEvents sideadminBtn As System.Windows.Forms.Button
    Friend WithEvents sideresultBtn As System.Windows.Forms.Button
    Friend WithEvents sidecalendarBtn As System.Windows.Forms.Button
    Friend WithEvents sideResSub1 As System.Windows.Forms.Button
    Friend WithEvents sideResSub2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents sidebartime As System.Windows.Forms.Timer
    Friend WithEvents cmbTeamAgeGroup As System.Windows.Forms.ComboBox
    Friend WithEvents bigbtngroup As System.Windows.Forms.GroupBox
    Friend WithEvents gpbEditing As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tmrAlert As Timer
    Friend WithEvents sideteamBtn As System.Windows.Forms.Button
    Friend WithEvents btnHelp As Button
End Class
