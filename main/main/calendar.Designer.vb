<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calendar
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
        Me.mnCalendar = New System.Windows.Forms.MonthCalendar()
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblInstruct = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAlertCount = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnCalendar
        '
        Me.mnCalendar.Location = New System.Drawing.Point(16, 59)
        Me.mnCalendar.MaxSelectionCount = 1
        Me.mnCalendar.Name = "mnCalendar"
        Me.mnCalendar.TabIndex = 0
        '
        'cms
        '
        Me.cms.Name = "cms"
        Me.cms.Size = New System.Drawing.Size(61, 4)
        '
        'lblInstruct
        '
        Me.lblInstruct.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct.Location = New System.Drawing.Point(255, 59)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(175, 151)
        Me.lblInstruct.TabIndex = 1
        Me.lblInstruct.Text = "Click a date to add or edit events scheduled on that day." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.lblTitle)
        Me.GroupBox2.Controls.Add(Me.lblAlertCount)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button13)
        Me.GroupBox2.Controls.Add(Me.exitBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(-10, -11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1377, 58)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblTitle.Location = New System.Drawing.Point(22, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(135, 27)
        Me.lblTitle.TabIndex = 91
        Me.lblTitle.Text = "CALENDAR"
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
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.GrayText
        Me.Button4.BackgroundImage = Global.main.My.Resources.Resources.helpbtn
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(1157, 11)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 44)
        Me.Button4.TabIndex = 6
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.GrayText
        Me.Button13.BackgroundImage = Global.main.My.Resources.Resources.notifbtn
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.exitBtn.FlatAppearance.BorderSize = 0
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.exitBtn.Location = New System.Drawing.Point(1245, 11)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(44, 44)
        Me.exitBtn.TabIndex = 6
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.Gray
        Me.backBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.Location = New System.Drawing.Point(355, 198)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(75, 23)
        Me.backBtn.TabIndex = 92
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(442, 237)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblInstruct)
        Me.Controls.Add(Me.mnCalendar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "calendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mnCalendar As MonthCalendar
    Friend WithEvents cms As ContextMenuStrip
    Friend WithEvents lblInstruct As Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblAlertCount As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents backBtn As System.Windows.Forms.Button
End Class
