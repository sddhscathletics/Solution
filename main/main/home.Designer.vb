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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
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
        Me.Sidebar.Controls.Add(Me.Button1)
        Me.Sidebar.Controls.Add(Me.Button5)
        Me.Sidebar.Controls.Add(Me.Button4)
        Me.Sidebar.Controls.Add(Me.Button2)
        Me.Sidebar.Controls.Add(Me.Button3)
        Me.Sidebar.Location = New System.Drawing.Point(-180, 20)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(200, 731)
        Me.Sidebar.TabIndex = 2
        Me.Sidebar.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
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
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button5.Location = New System.Drawing.Point(2, 186)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(196, 50)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "   ATHLETES"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.Location = New System.Drawing.Point(2, 135)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(196, 50)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "   RESULTS"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Location = New System.Drawing.Point(2, 237)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 50)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "   ADMIN SETTINGS"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Location = New System.Drawing.Point(2, 84)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(196, 50)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "   CALENDAR"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
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
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents backBtn As Button
    Friend WithEvents Button1 As Button
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
End Class
