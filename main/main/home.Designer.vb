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
        Me.scrollBtn = New System.Windows.Forms.Button()
        Me.Sidebar = New System.Windows.Forms.GroupBox()
        Me.sidemainBtn = New System.Windows.Forms.Button()
        Me.calDrop = New System.Windows.Forms.Button()
        Me.sidecalendarBtn = New System.Windows.Forms.Button()
        Me.resDrop = New System.Windows.Forms.Button()
        Me.sideresultsBtn = New System.Windows.Forms.Button()
        Me.athDrop = New System.Windows.Forms.Button()
        Me.sideAthletesBtn = New System.Windows.Forms.Button()
        Me.admDrop = New System.Windows.Forms.Button()
        Me.sideadminBtn = New System.Windows.Forms.Button()
        Me.sideCalSub2 = New System.Windows.Forms.Button()
        Me.sideCalSub1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.bigbtngroup = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.resultBtn = New System.Windows.Forms.Button()
        Me.adminBtn = New System.Windows.Forms.Button()
        Me.athletesBtn = New System.Windows.Forms.Button()
        Me.calendarBtn = New System.Windows.Forms.Button()
        Me.sidebartime = New System.Windows.Forms.Timer(Me.components)
        Me.Sidebar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.bigbtngroup.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'scrollBtn
        '
        Me.scrollBtn.BackColor = System.Drawing.Color.Gray
        Me.scrollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scrollBtn.Location = New System.Drawing.Point(10, 11)
        Me.scrollBtn.Name = "scrollBtn"
        Me.scrollBtn.Size = New System.Drawing.Size(44, 44)
        Me.scrollBtn.TabIndex = 3
        Me.scrollBtn.Text = "scrollbarbutton"
        Me.scrollBtn.UseVisualStyleBackColor = False
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Sidebar.Controls.Add(Me.sidemainBtn)
        Me.Sidebar.Controls.Add(Me.calDrop)
        Me.Sidebar.Controls.Add(Me.resDrop)
        Me.Sidebar.Controls.Add(Me.sideresultsBtn)
        Me.Sidebar.Controls.Add(Me.athDrop)
        Me.Sidebar.Controls.Add(Me.sideAthletesBtn)
        Me.Sidebar.Controls.Add(Me.admDrop)
        Me.Sidebar.Controls.Add(Me.sideadminBtn)
        Me.Sidebar.Controls.Add(Me.sidecalendarBtn)
        Me.Sidebar.Controls.Add(Me.sideCalSub1)
        Me.Sidebar.Controls.Add(Me.sideCalSub2)
        Me.Sidebar.Location = New System.Drawing.Point(0, 20)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(200, 731)
        Me.Sidebar.TabIndex = 2
        Me.Sidebar.TabStop = False
        '
        'sidemainBtn
        '
        Me.sidemainBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sidemainBtn.FlatAppearance.BorderSize = 0
        Me.sidemainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sidemainBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.sidemainBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sidemainBtn.Location = New System.Drawing.Point(2, 33)
        Me.sidemainBtn.Name = "sidemainBtn"
        Me.sidemainBtn.Size = New System.Drawing.Size(196, 50)
        Me.sidemainBtn.TabIndex = 0
        Me.sidemainBtn.Text = "   MAIN"
        Me.sidemainBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sidemainBtn.UseVisualStyleBackColor = False
        '
        'calDrop
        '
        Me.calDrop.BackColor = System.Drawing.Color.Gray
        Me.calDrop.FlatAppearance.BorderSize = 0
        Me.calDrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.calDrop.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.calDrop.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.calDrop.Location = New System.Drawing.Point(166, 84)
        Me.calDrop.Name = "calDrop"
        Me.calDrop.Size = New System.Drawing.Size(32, 50)
        Me.calDrop.TabIndex = 0
        Me.calDrop.Text = "▼"
        Me.calDrop.UseVisualStyleBackColor = False
        '
        'sidecalendarBtn
        '
        Me.sidecalendarBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
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
        'resDrop
        '
        Me.resDrop.BackColor = System.Drawing.Color.Gray
        Me.resDrop.FlatAppearance.BorderSize = 0
        Me.resDrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.resDrop.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.resDrop.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.resDrop.Location = New System.Drawing.Point(166, 135)
        Me.resDrop.Name = "resDrop"
        Me.resDrop.Size = New System.Drawing.Size(32, 50)
        Me.resDrop.TabIndex = 0
        Me.resDrop.Text = "▼"
        Me.resDrop.UseVisualStyleBackColor = False
        '
        'sideresultsBtn
        '
        Me.sideresultsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sideresultsBtn.FlatAppearance.BorderSize = 0
        Me.sideresultsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sideresultsBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.sideresultsBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sideresultsBtn.Location = New System.Drawing.Point(2, 135)
        Me.sideresultsBtn.Name = "sideresultsBtn"
        Me.sideresultsBtn.Size = New System.Drawing.Size(196, 50)
        Me.sideresultsBtn.TabIndex = 0
        Me.sideresultsBtn.Text = "   RESULTS"
        Me.sideresultsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sideresultsBtn.UseVisualStyleBackColor = False
        '
        'athDrop
        '
        Me.athDrop.BackColor = System.Drawing.Color.Gray
        Me.athDrop.FlatAppearance.BorderSize = 0
        Me.athDrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.athDrop.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.athDrop.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.athDrop.Location = New System.Drawing.Point(166, 186)
        Me.athDrop.Name = "athDrop"
        Me.athDrop.Size = New System.Drawing.Size(32, 50)
        Me.athDrop.TabIndex = 0
        Me.athDrop.Text = "▼"
        Me.athDrop.UseVisualStyleBackColor = False
        '
        'sideAthletesBtn
        '
        Me.sideAthletesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
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
        'admDrop
        '
        Me.admDrop.BackColor = System.Drawing.Color.Gray
        Me.admDrop.FlatAppearance.BorderSize = 0
        Me.admDrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.admDrop.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.admDrop.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.admDrop.Location = New System.Drawing.Point(166, 237)
        Me.admDrop.Name = "admDrop"
        Me.admDrop.Size = New System.Drawing.Size(32, 50)
        Me.admDrop.TabIndex = 0
        Me.admDrop.Text = "▼"
        Me.admDrop.UseVisualStyleBackColor = False
        '
        'sideadminBtn
        '
        Me.sideadminBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sideadminBtn.FlatAppearance.BorderSize = 0
        Me.sideadminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sideadminBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sideadminBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sideadminBtn.Location = New System.Drawing.Point(2, 237)
        Me.sideadminBtn.Name = "sideadminBtn"
        Me.sideadminBtn.Size = New System.Drawing.Size(196, 50)
        Me.sideadminBtn.TabIndex = 0
        Me.sideadminBtn.Text = "   ADMIN SETTINGS"
        Me.sideadminBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sideadminBtn.UseVisualStyleBackColor = False
        '
        'sideCalSub2
        '
        Me.sideCalSub2.BackColor = System.Drawing.Color.Gray
        Me.sideCalSub2.FlatAppearance.BorderSize = 0
        Me.sideCalSub2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sideCalSub2.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.sideCalSub2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sideCalSub2.Location = New System.Drawing.Point(2, 94)
        Me.sideCalSub2.Name = "sideCalSub2"
        Me.sideCalSub2.Size = New System.Drawing.Size(196, 40)
        Me.sideCalSub2.TabIndex = 0
        Me.sideCalSub2.Text = "   EVENT TIMES"
        Me.sideCalSub2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sideCalSub2.UseVisualStyleBackColor = False
        '
        'sideCalSub1
        '
        Me.sideCalSub1.BackColor = System.Drawing.Color.Gray
        Me.sideCalSub1.FlatAppearance.BorderSize = 0
        Me.sideCalSub1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sideCalSub1.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.sideCalSub1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sideCalSub1.Location = New System.Drawing.Point(2, 55)
        Me.sideCalSub1.Name = "sideCalSub1"
        Me.sideCalSub1.Size = New System.Drawing.Size(196, 40)
        Me.sideCalSub1.TabIndex = 0
        Me.sideCalSub1.Text = "   CREATE EVENT"
        Me.sideCalSub1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sideCalSub1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Button14)
        Me.GroupBox2.Controls.Add(Me.Button13)
        Me.GroupBox2.Controls.Add(Me.Button12)
        Me.GroupBox2.Controls.Add(Me.Button11)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.backBtn)
        Me.GroupBox2.Controls.Add(Me.scrollBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(-10, -11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1377, 58)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button14.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button14.Location = New System.Drawing.Point(1011, 23)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(24, 21)
        Me.Button14.TabIndex = 6
        Me.Button14.Text = "search"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button13.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button13.Location = New System.Drawing.Point(1228, 12)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(44, 44)
        Me.Button13.TabIndex = 6
        Me.Button13.Text = "notif"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button12.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button12.Location = New System.Drawing.Point(1272, 12)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(44, 44)
        Me.Button12.TabIndex = 6
        Me.Button12.Text = "settings"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button11.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button11.Location = New System.Drawing.Point(1316, 12)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(44, 44)
        Me.Button11.TabIndex = 6
        Me.Button11.Text = "exit"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(372, 23)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(633, 22)
        Me.TextBox1.TabIndex = 5
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.backBtn.FlatAppearance.BorderSize = 0
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.backBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.backBtn.Location = New System.Drawing.Point(54, 11)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(44, 44)
        Me.backBtn.TabIndex = 4
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'bigbtngroup
        '
        Me.bigbtngroup.Controls.Add(Me.PictureBox1)
        Me.bigbtngroup.Controls.Add(Me.resultBtn)
        Me.bigbtngroup.Controls.Add(Me.adminBtn)
        Me.bigbtngroup.Controls.Add(Me.athletesBtn)
        Me.bigbtngroup.Controls.Add(Me.calendarBtn)
        Me.bigbtngroup.Location = New System.Drawing.Point(0, 0)
        Me.bigbtngroup.Name = "bigbtngroup"
        Me.bigbtngroup.Size = New System.Drawing.Size(1411, 731)
        Me.bigbtngroup.TabIndex = 5
        Me.bigbtngroup.TabStop = False
        Me.bigbtngroup.Text = "GroupBox1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.main.My.Resources.Resources.excel
        Me.PictureBox1.Location = New System.Drawing.Point(1179, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 623)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'resultBtn
        '
        Me.resultBtn.BackColor = System.Drawing.Color.Gray
        Me.resultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resultBtn.Location = New System.Drawing.Point(45, 409)
        Me.resultBtn.Name = "resultBtn"
        Me.resultBtn.Size = New System.Drawing.Size(529, 300)
        Me.resultBtn.TabIndex = 0
        Me.resultBtn.Text = "Results"
        Me.resultBtn.UseVisualStyleBackColor = False
        '
        'adminBtn
        '
        Me.adminBtn.BackColor = System.Drawing.Color.Gray
        Me.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminBtn.Location = New System.Drawing.Point(599, 516)
        Me.adminBtn.Name = "adminBtn"
        Me.adminBtn.Size = New System.Drawing.Size(551, 193)
        Me.adminBtn.TabIndex = 0
        Me.adminBtn.Text = "Administrator Settings"
        Me.adminBtn.UseVisualStyleBackColor = False
        '
        'athletesBtn
        '
        Me.athletesBtn.BackColor = System.Drawing.Color.Gray
        Me.athletesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.athletesBtn.Location = New System.Drawing.Point(45, 86)
        Me.athletesBtn.Name = "athletesBtn"
        Me.athletesBtn.Size = New System.Drawing.Size(529, 295)
        Me.athletesBtn.TabIndex = 0
        Me.athletesBtn.Text = "Athletes"
        Me.athletesBtn.UseVisualStyleBackColor = False
        '
        'calendarBtn
        '
        Me.calendarBtn.BackColor = System.Drawing.Color.Gray
        Me.calendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calendarBtn.Location = New System.Drawing.Point(599, 86)
        Me.calendarBtn.Name = "calendarBtn"
        Me.calendarBtn.Size = New System.Drawing.Size(551, 408)
        Me.calendarBtn.TabIndex = 0
        Me.calendarBtn.Text = "Calendar"
        Me.calendarBtn.UseVisualStyleBackColor = False
        '
        'sidebartime
        '
        Me.sidebartime.Interval = 1
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Sidebar)
        Me.Controls.Add(Me.bigbtngroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "home"
        Me.Text = "Form1"
        Me.Sidebar.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.bigbtngroup.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents scrollBtn As Button
    Friend WithEvents Sidebar As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents sidecalendarBtn As Button
    Friend WithEvents sideAthletesBtn As Button
    Friend WithEvents sideresultsBtn As Button
    Friend WithEvents sideadminBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents backBtn As Button
    Friend WithEvents sidemainBtn As Button
    Friend WithEvents bigbtngroup As GroupBox
    Friend WithEvents calendarBtn As Button
    Friend WithEvents adminBtn As Button
    Friend WithEvents athletesBtn As Button
    Friend WithEvents resultBtn As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents sideCalSub1 As Button
    Friend WithEvents admDrop As Button
    Friend WithEvents athDrop As Button
    Friend WithEvents resDrop As Button
    Friend WithEvents calDrop As Button
    Friend WithEvents sideCalSub2 As Button
    Friend WithEvents sidebartime As Timer
End Class
