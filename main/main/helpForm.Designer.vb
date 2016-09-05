<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class helpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(helpForm))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAlertCount = New System.Windows.Forms.Label()
        Me.helpBtn = New System.Windows.Forms.Button()
        Me.notifBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.helpTab = New System.Windows.Forms.TabControl()
        Me.calendarTab = New System.Windows.Forms.TabPage()
        Me.lblCalendar = New System.Windows.Forms.Label()
        Me.resultsTab = New System.Windows.Forms.TabPage()
        Me.selectAthletesTab = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.addEditTab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.eventsTab = New System.Windows.Forms.TabPage()
        Me.lblEvents = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.helpTab.SuspendLayout()
        Me.calendarTab.SuspendLayout()
        Me.selectAthletesTab.SuspendLayout()
        Me.addEditTab.SuspendLayout()
        Me.eventsTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.closeBtn)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.lblTitle)
        Me.GroupBox2.Controls.Add(Me.lblAlertCount)
        Me.GroupBox2.Controls.Add(Me.helpBtn)
        Me.GroupBox2.Controls.Add(Me.notifBtn)
        Me.GroupBox2.Controls.Add(Me.exitBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(-10, -11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1377, 58)
        Me.GroupBox2.TabIndex = 95
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.SystemColors.GrayText
        Me.closeBtn.BackgroundImage = Global.main.My.Resources.Resources.close1
        Me.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeBtn.FlatAppearance.BorderSize = 0
        Me.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.closeBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.closeBtn.Location = New System.Drawing.Point(302, 11)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(44, 44)
        Me.closeBtn.TabIndex = 7
        Me.closeBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button1.BackgroundImage = Global.main.My.Resources.Resources.helpbtn
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(12, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 37)
        Me.Button1.TabIndex = 17
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblTitle.Location = New System.Drawing.Point(54, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(67, 27)
        Me.lblTitle.TabIndex = 16
        Me.lblTitle.Text = "HELP"
        '
        'lblAlertCount
        '
        Me.lblAlertCount.AutoSize = True
        Me.lblAlertCount.BackColor = System.Drawing.Color.DarkGray
        Me.lblAlertCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlertCount.Location = New System.Drawing.Point(1215, 16)
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
        'notifBtn
        '
        Me.notifBtn.BackColor = System.Drawing.SystemColors.GrayText
        Me.notifBtn.BackgroundImage = Global.main.My.Resources.Resources.notifbtn
        Me.notifBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.notifBtn.Cursor = System.Windows.Forms.Cursors.Hand
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
        'helpTab
        '
        Me.helpTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.helpTab.Controls.Add(Me.calendarTab)
        Me.helpTab.Controls.Add(Me.eventsTab)
        Me.helpTab.Controls.Add(Me.resultsTab)
        Me.helpTab.Controls.Add(Me.selectAthletesTab)
        Me.helpTab.Controls.Add(Me.addEditTab)
        Me.helpTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpTab.Location = New System.Drawing.Point(12, 53)
        Me.helpTab.Name = "helpTab"
        Me.helpTab.SelectedIndex = 0
        Me.helpTab.Size = New System.Drawing.Size(324, 298)
        Me.helpTab.TabIndex = 96
        '
        'calendarTab
        '
        Me.calendarTab.BackColor = System.Drawing.Color.LightGray
        Me.calendarTab.Controls.Add(Me.lblCalendar)
        Me.calendarTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendarTab.Location = New System.Drawing.Point(4, 27)
        Me.calendarTab.Name = "calendarTab"
        Me.calendarTab.Padding = New System.Windows.Forms.Padding(3)
        Me.calendarTab.Size = New System.Drawing.Size(316, 267)
        Me.calendarTab.TabIndex = 0
        Me.calendarTab.Text = "Calendar"
        '
        'lblCalendar
        '
        Me.lblCalendar.AutoSize = True
        Me.lblCalendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalendar.Location = New System.Drawing.Point(0, 3)
        Me.lblCalendar.Name = "lblCalendar"
        Me.lblCalendar.Size = New System.Drawing.Size(320, 150)
        Me.lblCalendar.TabIndex = 1
        Me.lblCalendar.Text = resources.GetString("lblCalendar.Text")
        '
        'resultsTab
        '
        Me.resultsTab.BackColor = System.Drawing.Color.LightGray
        Me.resultsTab.Location = New System.Drawing.Point(4, 27)
        Me.resultsTab.Name = "resultsTab"
        Me.resultsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.resultsTab.Size = New System.Drawing.Size(316, 267)
        Me.resultsTab.TabIndex = 1
        Me.resultsTab.Text = "Results"
        '
        'selectAthletesTab
        '
        Me.selectAthletesTab.BackColor = System.Drawing.Color.LightGray
        Me.selectAthletesTab.Controls.Add(Me.Label2)
        Me.selectAthletesTab.Location = New System.Drawing.Point(4, 27)
        Me.selectAthletesTab.Name = "selectAthletesTab"
        Me.selectAthletesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.selectAthletesTab.Size = New System.Drawing.Size(316, 267)
        Me.selectAthletesTab.TabIndex = 2
        Me.selectAthletesTab.Text = "View Athletes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "put yo info here"
        '
        'addEditTab
        '
        Me.addEditTab.BackColor = System.Drawing.Color.LightGray
        Me.addEditTab.Controls.Add(Me.Label1)
        Me.addEditTab.Location = New System.Drawing.Point(4, 27)
        Me.addEditTab.Name = "addEditTab"
        Me.addEditTab.Padding = New System.Windows.Forms.Padding(3)
        Me.addEditTab.Size = New System.Drawing.Size(316, 267)
        Me.addEditTab.TabIndex = 3
        Me.addEditTab.Text = "Manage Users"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 180)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'eventsTab
        '
        Me.eventsTab.Controls.Add(Me.lblEvents)
        Me.eventsTab.Location = New System.Drawing.Point(4, 27)
        Me.eventsTab.Name = "eventsTab"
        Me.eventsTab.Size = New System.Drawing.Size(316, 267)
        Me.eventsTab.TabIndex = 4
        Me.eventsTab.Text = "Events"
        Me.eventsTab.UseVisualStyleBackColor = True
        '
        'lblEvents
        '
        Me.lblEvents.AutoSize = True
        Me.lblEvents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvents.Location = New System.Drawing.Point(0, 0)
        Me.lblEvents.Name = "lblEvents"
        Me.lblEvents.Size = New System.Drawing.Size(320, 150)
        Me.lblEvents.TabIndex = 2
        Me.lblEvents.Text = resources.GetString("lblEvents.Text")
        '
        'helpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(344, 360)
        Me.Controls.Add(Me.helpTab)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "helpForm"
        Me.Text = "helpForm"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.helpTab.ResumeLayout(False)
        Me.calendarTab.ResumeLayout(False)
        Me.calendarTab.PerformLayout()
        Me.selectAthletesTab.ResumeLayout(False)
        Me.selectAthletesTab.PerformLayout()
        Me.addEditTab.ResumeLayout(False)
        Me.addEditTab.PerformLayout()
        Me.eventsTab.ResumeLayout(False)
        Me.eventsTab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblAlertCount As System.Windows.Forms.Label
    Friend WithEvents helpBtn As System.Windows.Forms.Button
    Friend WithEvents notifBtn As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents helpTab As System.Windows.Forms.TabControl
    Friend WithEvents calendarTab As System.Windows.Forms.TabPage
    Friend WithEvents resultsTab As System.Windows.Forms.TabPage
    Friend WithEvents selectAthletesTab As System.Windows.Forms.TabPage
    Friend WithEvents addEditTab As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCalendar As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents eventsTab As TabPage
    Friend WithEvents lblEvents As Label
End Class
