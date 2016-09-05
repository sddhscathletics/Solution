<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.Sidebar = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.resdrop = New System.Windows.Forms.Button()
        Me.sideAthletesBtn = New System.Windows.Forms.Button()
        Me.sideadminBtn = New System.Windows.Forms.Button()
        Me.sideresultBtn = New System.Windows.Forms.Button()
        Me.sidecalendarBtn = New System.Windows.Forms.Button()
        Me.sideResSub1 = New System.Windows.Forms.Button()
        Me.sideResSub2 = New System.Windows.Forms.Button()
        Me.sidebartime = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.helpBtn = New System.Windows.Forms.Button()
        Me.lblAlertCount1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.scrollBtn = New System.Windows.Forms.Button()
        Me.lblAlertCount = New System.Windows.Forms.Label()
        Me.notifBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.bigbtngroup = New System.Windows.Forms.GroupBox()
        Me.dateLbl = New System.Windows.Forms.Label()
        Me.timeLbl = New System.Windows.Forms.Label()
        Me.resultBtn = New System.Windows.Forms.Button()
        Me.selectAthletesBtn = New System.Windows.Forms.Button()
        Me.addEditUserBtn = New System.Windows.Forms.Button()
        Me.calendarBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.gallerypic2 = New System.Windows.Forms.PictureBox()
        Me.gallerypic1 = New System.Windows.Forms.PictureBox()
        Me.sidebartime2 = New System.Windows.Forms.Timer(Me.components)
        Me.clocktime = New System.Windows.Forms.Timer(Me.components)
        Me.Sidebar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.bigbtngroup.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gallerypic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gallerypic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Sidebar.Controls.Add(Me.Button1)
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
        Me.Sidebar.TabIndex = 2
        Me.Sidebar.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Location = New System.Drawing.Point(2, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "   MAIN"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.sideadminBtn.Location = New System.Drawing.Point(2, 237)
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
        'sidebartime
        '
        Me.sidebartime.Interval = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.helpBtn)
        Me.GroupBox2.Controls.Add(Me.lblAlertCount1)
        Me.GroupBox2.Controls.Add(Me.lblTitle)
        Me.GroupBox2.Controls.Add(Me.scrollBtn)
        Me.GroupBox2.Controls.Add(Me.lblAlertCount)
        Me.GroupBox2.Controls.Add(Me.notifBtn)
        Me.GroupBox2.Controls.Add(Me.exitBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(-10, -11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1377, 58)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
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
        Me.helpBtn.TabIndex = 94
        Me.helpBtn.UseVisualStyleBackColor = False
        '
        'lblAlertCount1
        '
        Me.lblAlertCount1.AutoSize = True
        Me.lblAlertCount1.BackColor = System.Drawing.Color.DarkGray
        Me.lblAlertCount1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlertCount1.Location = New System.Drawing.Point(1224, 16)
        Me.lblAlertCount1.Name = "lblAlertCount1"
        Me.lblAlertCount1.Size = New System.Drawing.Size(15, 16)
        Me.lblAlertCount1.TabIndex = 93
        Me.lblAlertCount1.Text = "0"
        Me.lblAlertCount1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblTitle.Location = New System.Drawing.Point(82, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(72, 27)
        Me.lblTitle.TabIndex = 92
        Me.lblTitle.Text = "MAIN"
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
        'lblAlertCount
        '
        Me.lblAlertCount.Location = New System.Drawing.Point(0, 0)
        Me.lblAlertCount.Name = "lblAlertCount"
        Me.lblAlertCount.Size = New System.Drawing.Size(100, 23)
        Me.lblAlertCount.TabIndex = 3
        '
        'notifBtn
        '
        Me.notifBtn.BackColor = System.Drawing.SystemColors.GrayText
        Me.notifBtn.BackgroundImage = Global.main.My.Resources.Resources.notifbtn
        Me.notifBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.notifBtn.FlatAppearance.BorderSize = 0
        Me.notifBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.notifBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.notifBtn.Location = New System.Drawing.Point(1201, 11)
        Me.notifBtn.Name = "notifBtn"
        Me.notifBtn.Size = New System.Drawing.Size(44, 44)
        Me.notifBtn.TabIndex = 6
        Me.notifBtn.UseVisualStyleBackColor = False
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.SystemColors.GrayText
        Me.exitBtn.BackgroundImage = Global.main.My.Resources.Resources.close1
        Me.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exitBtn.FlatAppearance.BorderSize = 0
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.exitBtn.Location = New System.Drawing.Point(1245, 11)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(44, 44)
        Me.exitBtn.TabIndex = 6
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'bigbtngroup
        '
        Me.bigbtngroup.Controls.Add(Me.dateLbl)
        Me.bigbtngroup.Controls.Add(Me.timeLbl)
        Me.bigbtngroup.Controls.Add(Me.resultBtn)
        Me.bigbtngroup.Controls.Add(Me.selectAthletesBtn)
        Me.bigbtngroup.Controls.Add(Me.addEditUserBtn)
        Me.bigbtngroup.Controls.Add(Me.calendarBtn)
        Me.bigbtngroup.Controls.Add(Me.PictureBox1)
        Me.bigbtngroup.Controls.Add(Me.PictureBox3)
        Me.bigbtngroup.Controls.Add(Me.gallerypic2)
        Me.bigbtngroup.Controls.Add(Me.gallerypic1)
        Me.bigbtngroup.Location = New System.Drawing.Point(0, 0)
        Me.bigbtngroup.Name = "bigbtngroup"
        Me.bigbtngroup.Size = New System.Drawing.Size(1411, 723)
        Me.bigbtngroup.TabIndex = 5
        Me.bigbtngroup.TabStop = False
        Me.bigbtngroup.Text = "GroupBox1"
        '
        'dateLbl
        '
        Me.dateLbl.AutoSize = True
        Me.dateLbl.BackColor = System.Drawing.Color.DarkGray
        Me.dateLbl.Font = New System.Drawing.Font("Rockwell", 26.0!, System.Drawing.FontStyle.Italic)
        Me.dateLbl.Location = New System.Drawing.Point(83, 82)
        Me.dateLbl.Name = "dateLbl"
        Me.dateLbl.Size = New System.Drawing.Size(86, 38)
        Me.dateLbl.TabIndex = 1
        Me.dateLbl.Text = "date"
        '
        'timeLbl
        '
        Me.timeLbl.AutoSize = True
        Me.timeLbl.BackColor = System.Drawing.Color.DarkGray
        Me.timeLbl.Font = New System.Drawing.Font("Rockwell", 50.0!, System.Drawing.FontStyle.Italic)
        Me.timeLbl.Location = New System.Drawing.Point(64, 135)
        Me.timeLbl.Name = "timeLbl"
        Me.timeLbl.Size = New System.Drawing.Size(165, 75)
        Me.timeLbl.TabIndex = 1
        Me.timeLbl.Text = "time"
        '
        'resultBtn
        '
        Me.resultBtn.BackColor = System.Drawing.Color.Gray
        Me.resultBtn.BackgroundImage = Global.main.My.Resources.Resources.Results_Btn
        Me.resultBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.resultBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.resultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resultBtn.ForeColor = System.Drawing.Color.DarkBlue
        Me.resultBtn.Location = New System.Drawing.Point(436, 244)
        Me.resultBtn.Name = "resultBtn"
        Me.resultBtn.Size = New System.Drawing.Size(325, 195)
        Me.resultBtn.TabIndex = 0
        Me.resultBtn.UseVisualStyleBackColor = False
        '
        'selectAthletesBtn
        '
        Me.selectAthletesBtn.BackColor = System.Drawing.Color.Gray
        Me.selectAthletesBtn.BackgroundImage = Global.main.My.Resources.Resources.View_Athletes_Btn
        Me.selectAthletesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.selectAthletesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.selectAthletesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectAthletesBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.selectAthletesBtn.Location = New System.Drawing.Point(66, 481)
        Me.selectAthletesBtn.Name = "selectAthletesBtn"
        Me.selectAthletesBtn.Size = New System.Drawing.Size(325, 195)
        Me.selectAthletesBtn.TabIndex = 0
        Me.selectAthletesBtn.UseVisualStyleBackColor = False
        '
        'addEditUserBtn
        '
        Me.addEditUserBtn.BackColor = System.Drawing.Color.Gray
        Me.addEditUserBtn.BackgroundImage = Global.main.My.Resources.Resources.Manage_User_UPD_Btn
        Me.addEditUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.addEditUserBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addEditUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addEditUserBtn.ForeColor = System.Drawing.Color.Purple
        Me.addEditUserBtn.Location = New System.Drawing.Point(436, 481)
        Me.addEditUserBtn.Name = "addEditUserBtn"
        Me.addEditUserBtn.Size = New System.Drawing.Size(325, 195)
        Me.addEditUserBtn.TabIndex = 0
        Me.addEditUserBtn.UseVisualStyleBackColor = False
        '
        'calendarBtn
        '
        Me.calendarBtn.BackColor = System.Drawing.Color.Gray
        Me.calendarBtn.BackgroundImage = Global.main.My.Resources.Resources.Calendar_Btn
        Me.calendarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.calendarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calendarBtn.ForeColor = System.Drawing.Color.Maroon
        Me.calendarBtn.Location = New System.Drawing.Point(66, 244)
        Me.calendarBtn.Name = "calendarBtn"
        Me.calendarBtn.Size = New System.Drawing.Size(325, 195)
        Me.calendarBtn.TabIndex = 0
        Me.calendarBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox1.Location = New System.Drawing.Point(28, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(759, 633)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(727, 94)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 601)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'gallerypic2
        '
        Me.gallerypic2.BackgroundImage = Global.main.My.Resources.Resources.gallery2
        Me.gallerypic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.gallerypic2.Location = New System.Drawing.Point(556, 94)
        Me.gallerypic2.Name = "gallerypic2"
        Me.gallerypic2.Size = New System.Drawing.Size(689, 568)
        Me.gallerypic2.TabIndex = 5
        Me.gallerypic2.TabStop = False
        '
        'gallerypic1
        '
        Me.gallerypic1.BackgroundImage = Global.main.My.Resources.Resources.gallery1
        Me.gallerypic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.gallerypic1.Location = New System.Drawing.Point(556, 94)
        Me.gallerypic1.Name = "gallerypic1"
        Me.gallerypic1.Size = New System.Drawing.Size(689, 568)
        Me.gallerypic1.TabIndex = 3
        Me.gallerypic1.TabStop = False
        '
        'sidebartime2
        '
        Me.sidebartime2.Interval = 1
        '
        'clocktime
        '
        Me.clocktime.Enabled = True
        '
        'home
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
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.Sidebar.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.bigbtngroup.ResumeLayout(False)
        Me.bigbtngroup.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gallerypic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gallerypic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents scrollBtn As Button
    Friend WithEvents Sidebar As GroupBox
    Friend WithEvents sidebartime As Timer
    Friend WithEvents sidecalendarBtn As Button
    Friend WithEvents sideAthletesBtn As Button
    Friend WithEvents sideresultBtn As Button
    Friend WithEvents sideadminBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents bigbtngroup As GroupBox
    Friend WithEvents calendarBtn As Button
    Friend WithEvents selectAthletesBtn As Button
    Friend WithEvents addEditUserBtn As Button
    Friend WithEvents resultBtn As Button
    Friend WithEvents notifBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents resdrop As Button
    Friend WithEvents sidebartime2 As Timer
    Friend WithEvents sideResSub1 As Button
    Friend WithEvents sideResSub2 As Button


    Friend WithEvents sidecalbtn3 As Button
    Friend WithEvents lblAlertCount As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents timeLbl As System.Windows.Forms.Label
    Friend WithEvents clocktime As System.Windows.Forms.Timer
    Friend WithEvents dateLbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblAlertCount1 As System.Windows.Forms.Label
    Friend WithEvents gallerypic1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents gallerypic2 As System.Windows.Forms.PictureBox
    Friend WithEvents helpBtn As System.Windows.Forms.Button
End Class
