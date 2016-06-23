<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createEvent
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
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblEvents = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblAthletes = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.lblAttachments = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.rdbTraining = New System.Windows.Forms.RadioButton()
        Me.rdbMeet = New System.Windows.Forms.RadioButton()
        Me.chbNA = New System.Windows.Forms.CheckBox()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblTemplate = New System.Windows.Forms.Label()
        Me.cmbTemplate = New System.Windows.Forms.ComboBox()
        Me.chbNone = New System.Windows.Forms.CheckBox()
        Me.pbAttach = New System.Windows.Forms.PictureBox()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.gbDetails = New System.Windows.Forms.GroupBox()
        Me.flpAttach = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.pbAttach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetails.SuspendLayout()
        Me.flpAttach.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.Location = New System.Drawing.Point(630, 164)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(144, 19)
        Me.btnSelect.TabIndex = 25
        Me.btnSelect.Text = "Select..."
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lblEvents
        '
        Me.lblEvents.AutoSize = True
        Me.lblEvents.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvents.Location = New System.Drawing.Point(515, 211)
        Me.lblEvents.Name = "lblEvents"
        Me.lblEvents.Size = New System.Drawing.Size(66, 24)
        Me.lblEvents.TabIndex = 24
        Me.lblEvents.Text = "Events"
        '
        'dtpStart
        '
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStart.Location = New System.Drawing.Point(120, 172)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.ShowUpDown = True
        Me.dtpStart.Size = New System.Drawing.Size(176, 20)
        Me.dtpStart.TabIndex = 23
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(120, 128)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(176, 20)
        Me.dtpDate.TabIndex = 22
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(644, 486)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 34)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(451, 486)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(86, 34)
        Me.btnOkay.TabIndex = 20
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.Location = New System.Drawing.Point(630, 211)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(144, 19)
        Me.btnBrowse.TabIndex = 19
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblAthletes
        '
        Me.lblAthletes.AutoSize = True
        Me.lblAthletes.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAthletes.Location = New System.Drawing.Point(515, 164)
        Me.lblAthletes.Name = "lblAthletes"
        Me.lblAthletes.Size = New System.Drawing.Size(78, 24)
        Me.lblAthletes.TabIndex = 18
        Me.lblAthletes.Text = "Athletes"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(10, 172)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(51, 24)
        Me.lblStart.TabIndex = 17
        Me.lblStart.Text = "Start"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(10, 128)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(49, 24)
        Me.lblDate.TabIndex = 16
        Me.lblDate.Text = "Date"
        '
        'dtpEnd
        '
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEnd.Location = New System.Drawing.Point(120, 214)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.ShowUpDown = True
        Me.dtpEnd.Size = New System.Drawing.Size(176, 20)
        Me.dtpEnd.TabIndex = 27
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(10, 214)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(46, 24)
        Me.lblEnd.TabIndex = 26
        Me.lblEnd.Text = "End"
        '
        'lblAttachments
        '
        Me.lblAttachments.AutoSize = True
        Me.lblAttachments.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttachments.Location = New System.Drawing.Point(12, 312)
        Me.lblAttachments.Name = "lblAttachments"
        Me.lblAttachments.Size = New System.Drawing.Size(114, 24)
        Me.lblAttachments.TabIndex = 28
        Me.lblAttachments.Text = "Attachments"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment.Location = New System.Drawing.Point(11, 260)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(87, 24)
        Me.lblComment.TabIndex = 29
        Me.lblComment.Text = "Comment"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(10, 87)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(50, 24)
        Me.lblType.TabIndex = 30
        Me.lblType.Text = "Type"
        '
        'rdbTraining
        '
        Me.rdbTraining.AutoSize = True
        Me.rdbTraining.Checked = True
        Me.rdbTraining.Location = New System.Drawing.Point(120, 87)
        Me.rdbTraining.Name = "rdbTraining"
        Me.rdbTraining.Size = New System.Drawing.Size(63, 17)
        Me.rdbTraining.TabIndex = 31
        Me.rdbTraining.TabStop = True
        Me.rdbTraining.Text = "Training"
        Me.rdbTraining.UseVisualStyleBackColor = True
        '
        'rdbMeet
        '
        Me.rdbMeet.AutoSize = True
        Me.rdbMeet.Location = New System.Drawing.Point(233, 87)
        Me.rdbMeet.Name = "rdbMeet"
        Me.rdbMeet.Size = New System.Drawing.Size(49, 17)
        Me.rdbMeet.TabIndex = 32
        Me.rdbMeet.Text = "Meet"
        Me.rdbMeet.UseVisualStyleBackColor = True
        '
        'chbNA
        '
        Me.chbNA.AutoSize = True
        Me.chbNA.Location = New System.Drawing.Point(803, 213)
        Me.chbNA.Name = "chbNA"
        Me.chbNA.Size = New System.Drawing.Size(46, 17)
        Me.chbNA.TabIndex = 33
        Me.chbNA.Text = "N/A"
        Me.chbNA.UseVisualStyleBackColor = True
        '
        'ofdOpen
        '
        Me.ofdOpen.FileName = "OpenFileDialog1"
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(104, 265)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(227, 20)
        Me.txtComment.TabIndex = 36
        Me.txtComment.Text = "Enter your comment here"
        Me.txtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(391, -1)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(167, 29)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Event Creator"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(11, 45)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 24)
        Me.lblName.TabIndex = 37
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(93, 49)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(227, 20)
        Me.txtName.TabIndex = 38
        Me.txtName.Text = "Enter the event name here"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTemplate
        '
        Me.lblTemplate.AutoSize = True
        Me.lblTemplate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemplate.Location = New System.Drawing.Point(10, 8)
        Me.lblTemplate.Name = "lblTemplate"
        Me.lblTemplate.Size = New System.Drawing.Size(88, 24)
        Me.lblTemplate.TabIndex = 40
        Me.lblTemplate.Text = "Template"
        '
        'cmbTemplate
        '
        Me.cmbTemplate.Enabled = False
        Me.cmbTemplate.FormattingEnabled = True
        Me.cmbTemplate.Location = New System.Drawing.Point(114, 13)
        Me.cmbTemplate.Name = "cmbTemplate"
        Me.cmbTemplate.Size = New System.Drawing.Size(182, 21)
        Me.cmbTemplate.TabIndex = 41
        '
        'chbNone
        '
        Me.chbNone.AutoSize = True
        Me.chbNone.Checked = True
        Me.chbNone.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbNone.Location = New System.Drawing.Point(302, 15)
        Me.chbNone.Name = "chbNone"
        Me.chbNone.Size = New System.Drawing.Size(52, 17)
        Me.chbNone.TabIndex = 43
        Me.chbNone.Text = "None"
        Me.chbNone.UseVisualStyleBackColor = True
        '
        'pbAttach
        '
        Me.pbAttach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAttach.Image = Global.main.My.Resources.Resources.transparent_plus
        Me.pbAttach.Location = New System.Drawing.Point(3, 3)
        Me.pbAttach.Name = "pbAttach"
        Me.pbAttach.Size = New System.Drawing.Size(352, 56)
        Me.pbAttach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAttach.TabIndex = 42
        Me.pbAttach.TabStop = False
        Me.pbAttach.Tag = "add"
        '
        'gbDetails
        '
        Me.gbDetails.Controls.Add(Me.chbNone)
        Me.gbDetails.Controls.Add(Me.cmbTemplate)
        Me.gbDetails.Controls.Add(Me.lblTemplate)
        Me.gbDetails.Controls.Add(Me.txtName)
        Me.gbDetails.Controls.Add(Me.lblName)
        Me.gbDetails.Controls.Add(Me.txtComment)
        Me.gbDetails.Controls.Add(Me.rdbMeet)
        Me.gbDetails.Controls.Add(Me.rdbTraining)
        Me.gbDetails.Controls.Add(Me.lblType)
        Me.gbDetails.Controls.Add(Me.lblComment)
        Me.gbDetails.Controls.Add(Me.dtpEnd)
        Me.gbDetails.Controls.Add(Me.lblEnd)
        Me.gbDetails.Controls.Add(Me.dtpStart)
        Me.gbDetails.Controls.Add(Me.dtpDate)
        Me.gbDetails.Controls.Add(Me.lblStart)
        Me.gbDetails.Controls.Add(Me.lblDate)
        Me.gbDetails.Location = New System.Drawing.Point(12, 5)
        Me.gbDetails.Name = "gbDetails"
        Me.gbDetails.Size = New System.Drawing.Size(362, 304)
        Me.gbDetails.TabIndex = 44
        Me.gbDetails.TabStop = False
        '
        'flpAttach
        '
        Me.flpAttach.BackColor = System.Drawing.SystemColors.ControlDark
        Me.flpAttach.Controls.Add(Me.pbAttach)
        Me.flpAttach.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpAttach.Location = New System.Drawing.Point(16, 339)
        Me.flpAttach.Name = "flpAttach"
        Me.flpAttach.Size = New System.Drawing.Size(358, 159)
        Me.flpAttach.TabIndex = 45
        '
        'createEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(992, 533)
        Me.Controls.Add(Me.flpAttach)
        Me.Controls.Add(Me.gbDetails)
        Me.Controls.Add(Me.chbNA)
        Me.Controls.Add(Me.lblAttachments)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblEvents)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.lblAthletes)
        Me.Controls.Add(Me.lblTitle)
        Me.MaximizeBox = False
        Me.Name = "createEvent"
        Me.Text = "createEvent"
        CType(Me.pbAttach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetails.ResumeLayout(False)
        Me.gbDetails.PerformLayout()
        Me.flpAttach.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents lblAthletes As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnOkay As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents lblEvents As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents lblEnd As Label
    Friend WithEvents lblAttachments As Label
    Friend WithEvents lblComment As Label
    Friend WithEvents lblType As Label
    Friend WithEvents rdbTraining As RadioButton
    Friend WithEvents rdbMeet As RadioButton
    Friend WithEvents chbNA As CheckBox
    Friend WithEvents ofdOpen As OpenFileDialog
    Friend WithEvents txtComment As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblTemplate As Label
    Friend WithEvents cmbTemplate As ComboBox
    Friend WithEvents pbAttach As PictureBox
    Friend WithEvents chbNone As CheckBox
    Friend WithEvents sfdSave As SaveFileDialog
    Friend WithEvents gbDetails As GroupBox
    Friend WithEvents flpAttach As FlowLayoutPanel
End Class
