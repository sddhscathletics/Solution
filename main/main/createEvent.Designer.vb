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
        Me.btnSelectA = New System.Windows.Forms.Button()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSaveEvent = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.rdbTraining = New System.Windows.Forms.RadioButton()
        Me.rdbMeet = New System.Windows.Forms.RadioButton()
        Me.chbNA = New System.Windows.Forms.CheckBox()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblTemplate = New System.Windows.Forms.Label()
        Me.cmbTemplate = New System.Windows.Forms.ComboBox()
        Me.chbNone = New System.Windows.Forms.CheckBox()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.gbDetails = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.flpAttach = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlAttach = New System.Windows.Forms.Panel()
        Me.pbAttach = New System.Windows.Forms.PictureBox()
        Me.map = New GMap.NET.WindowsForms.GMapControl()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.lblSuburb = New System.Windows.Forms.Label()
        Me.txtSuburb = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.gbLocation = New System.Windows.Forms.GroupBox()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.gbEvents = New System.Windows.Forms.GroupBox()
        Me.btnSaveTimes = New System.Windows.Forms.Button()
        Me.cmbEvent = New System.Windows.Forms.ComboBox()
        Me.dtp13s = New System.Windows.Forms.DateTimePicker()
        Me.dtpOpens = New System.Windows.Forms.DateTimePicker()
        Me.lbl16s = New System.Windows.Forms.Label()
        Me.dtp16s = New System.Windows.Forms.DateTimePicker()
        Me.dtp15s = New System.Windows.Forms.DateTimePicker()
        Me.lbl17s = New System.Windows.Forms.Label()
        Me.dtp14s = New System.Windows.Forms.DateTimePicker()
        Me.lbl15s = New System.Windows.Forms.Label()
        Me.lbl13s = New System.Windows.Forms.Label()
        Me.dtp17s = New System.Windows.Forms.DateTimePicker()
        Me.lbl14s = New System.Windows.Forms.Label()
        Me.lblOpens = New System.Windows.Forms.Label()
        Me.gbAttachments = New System.Windows.Forms.GroupBox()
        Me.pbPlus = New System.Windows.Forms.PictureBox()
        Me.pbMinus = New System.Windows.Forms.PictureBox()
        Me.gbAthletes = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chbAll = New System.Windows.Forms.CheckBox()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.flpAthletes = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlAthlete = New System.Windows.Forms.Panel()
        Me.lblRollClass = New System.Windows.Forms.Label()
        Me.lblRecents = New System.Windows.Forms.Label()
        Me.lblUnexplained = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblAverages = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.chbAthlete = New System.Windows.Forms.CheckBox()
        Me.pbAthlete = New System.Windows.Forms.PictureBox()
        Me.gbDetails.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpAttach.SuspendLayout()
        Me.pnlAttach.SuspendLayout()
        CType(Me.pbAttach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLocation.SuspendLayout()
        Me.gbEvents.SuspendLayout()
        Me.gbAttachments.SuspendLayout()
        CType(Me.pbPlus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMinus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAthletes.SuspendLayout()
        Me.pnlAthlete.SuspendLayout()
        CType(Me.pbAthlete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelectA
        '
        Me.btnSelectA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectA.Location = New System.Drawing.Point(389, 295)
        Me.btnSelectA.Name = "btnSelectA"
        Me.btnSelectA.Size = New System.Drawing.Size(144, 19)
        Me.btnSelectA.TabIndex = 25
        Me.btnSelectA.Text = "Select..."
        Me.btnSelectA.UseVisualStyleBackColor = True
        '
        'dtpStart
        '
        Me.dtpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStart.Location = New System.Drawing.Point(117, 190)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.ShowUpDown = True
        Me.dtpStart.Size = New System.Drawing.Size(176, 20)
        Me.dtpStart.TabIndex = 23
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(117, 146)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(176, 20)
        Me.dtpDate.TabIndex = 22
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(522, 554)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 34)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSaveEvent
        '
        Me.btnSaveEvent.Location = New System.Drawing.Point(415, 554)
        Me.btnSaveEvent.Name = "btnSaveEvent"
        Me.btnSaveEvent.Size = New System.Drawing.Size(86, 34)
        Me.btnSaveEvent.TabIndex = 20
        Me.btnSaveEvent.Text = "Save"
        Me.btnSaveEvent.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.Location = New System.Drawing.Point(230, -1)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(144, 19)
        Me.btnBrowse.TabIndex = 19
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(7, 190)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(51, 24)
        Me.lblStart.TabIndex = 17
        Me.lblStart.Text = "Start"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(7, 146)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(49, 24)
        Me.lblDate.TabIndex = 16
        Me.lblDate.Text = "Date"
        '
        'dtpEnd
        '
        Me.dtpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEnd.Location = New System.Drawing.Point(117, 232)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.ShowUpDown = True
        Me.dtpEnd.Size = New System.Drawing.Size(176, 20)
        Me.dtpEnd.TabIndex = 27
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(7, 232)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(46, 24)
        Me.lblEnd.TabIndex = 26
        Me.lblEnd.Text = "End"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment.Location = New System.Drawing.Point(8, 278)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(87, 24)
        Me.lblComment.TabIndex = 29
        Me.lblComment.Text = "Comment"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(7, 105)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(50, 24)
        Me.lblType.TabIndex = 30
        Me.lblType.Text = "Type"
        '
        'rdbTraining
        '
        Me.rdbTraining.AutoSize = True
        Me.rdbTraining.Checked = True
        Me.rdbTraining.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTraining.Location = New System.Drawing.Point(117, 105)
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
        Me.rdbMeet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMeet.Location = New System.Drawing.Point(230, 105)
        Me.rdbMeet.Name = "rdbMeet"
        Me.rdbMeet.Size = New System.Drawing.Size(49, 17)
        Me.rdbMeet.TabIndex = 32
        Me.rdbMeet.Text = "Meet"
        Me.rdbMeet.UseVisualStyleBackColor = True
        '
        'chbNA
        '
        Me.chbNA.AutoSize = True
        Me.chbNA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbNA.Location = New System.Drawing.Point(11, 31)
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
        Me.txtComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.Location = New System.Drawing.Point(101, 283)
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
        Me.lblTitle.Location = New System.Drawing.Point(384, 2)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(167, 29)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Event Creator"
        '
        'lblEventName
        '
        Me.lblEventName.AutoSize = True
        Me.lblEventName.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventName.Location = New System.Drawing.Point(8, 63)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(59, 24)
        Me.lblEventName.TabIndex = 37
        Me.lblEventName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(90, 67)
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
        Me.lblTemplate.Location = New System.Drawing.Point(7, 26)
        Me.lblTemplate.Name = "lblTemplate"
        Me.lblTemplate.Size = New System.Drawing.Size(88, 24)
        Me.lblTemplate.TabIndex = 40
        Me.lblTemplate.Text = "Template"
        '
        'cmbTemplate
        '
        Me.cmbTemplate.Enabled = False
        Me.cmbTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTemplate.FormattingEnabled = True
        Me.cmbTemplate.Location = New System.Drawing.Point(111, 31)
        Me.cmbTemplate.Name = "cmbTemplate"
        Me.cmbTemplate.Size = New System.Drawing.Size(182, 21)
        Me.cmbTemplate.TabIndex = 41
        '
        'chbNone
        '
        Me.chbNone.AutoSize = True
        Me.chbNone.Checked = True
        Me.chbNone.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbNone.Location = New System.Drawing.Point(299, 33)
        Me.chbNone.Name = "chbNone"
        Me.chbNone.Size = New System.Drawing.Size(52, 17)
        Me.chbNone.TabIndex = 43
        Me.chbNone.Text = "None"
        Me.chbNone.UseVisualStyleBackColor = True
        '
        'gbDetails
        '
        Me.gbDetails.Controls.Add(Me.chbNone)
        Me.gbDetails.Controls.Add(Me.cmbTemplate)
        Me.gbDetails.Controls.Add(Me.DataGridView1)
        Me.gbDetails.Controls.Add(Me.lblTemplate)
        Me.gbDetails.Controls.Add(Me.txtName)
        Me.gbDetails.Controls.Add(Me.lblEventName)
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
        Me.gbDetails.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDetails.Location = New System.Drawing.Point(12, 5)
        Me.gbDetails.Name = "gbDetails"
        Me.gbDetails.Size = New System.Drawing.Size(362, 308)
        Me.gbDetails.TabIndex = 44
        Me.gbDetails.TabStop = False
        Me.gbDetails.Text = "Details"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(151, 161)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(236, 37)
        Me.DataGridView1.TabIndex = 55
        '
        'flpAttach
        '
        Me.flpAttach.AutoScroll = True
        Me.flpAttach.BackColor = System.Drawing.SystemColors.Control
        Me.flpAttach.Controls.Add(Me.pnlAttach)
        Me.flpAttach.Controls.Add(Me.pnlAthlete)
        Me.flpAttach.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpAttach.Location = New System.Drawing.Point(0, 24)
        Me.flpAttach.Name = "flpAttach"
        Me.flpAttach.Size = New System.Drawing.Size(328, 235)
        Me.flpAttach.TabIndex = 45
        Me.flpAttach.WrapContents = False
        '
        'pnlAttach
        '
        Me.pnlAttach.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlAttach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAttach.Controls.Add(Me.pbAttach)
        Me.pnlAttach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlAttach.Location = New System.Drawing.Point(3, 3)
        Me.pnlAttach.Name = "pnlAttach"
        Me.pnlAttach.Size = New System.Drawing.Size(305, 56)
        Me.pnlAttach.TabIndex = 43
        '
        'pbAttach
        '
        Me.pbAttach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAttach.Image = Global.main.My.Resources.Resources.transparent_plus
        Me.pbAttach.Location = New System.Drawing.Point(0, 0)
        Me.pbAttach.Name = "pbAttach"
        Me.pbAttach.Size = New System.Drawing.Size(74, 56)
        Me.pbAttach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAttach.TabIndex = 42
        Me.pbAttach.TabStop = False
        Me.pbAttach.Tag = "add"
        '
        'map
        '
        Me.map.Bearing = 0!
        Me.map.CanDragMap = True
        Me.map.Cursor = System.Windows.Forms.Cursors.Hand
        Me.map.EmptyTileColor = System.Drawing.Color.Navy
        Me.map.GrayScaleMode = False
        Me.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.map.LevelsKeepInMemmory = 5
        Me.map.Location = New System.Drawing.Point(561, 8)
        Me.map.MarkersEnabled = True
        Me.map.MaxZoom = 18
        Me.map.MinZoom = 2
        Me.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.map.Name = "map"
        Me.map.NegativeMode = False
        Me.map.PolygonsEnabled = True
        Me.map.RetryLoadTile = 0
        Me.map.RoutesEnabled = True
        Me.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.map.ShowTileGridLines = False
        Me.map.Size = New System.Drawing.Size(424, 290)
        Me.map.TabIndex = 46
        Me.map.Zoom = 10.0R
        '
        'txtStreet
        '
        Me.txtStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreet.Location = New System.Drawing.Point(9, 73)
        Me.txtStreet.Multiline = True
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(162, 35)
        Me.txtStreet.TabIndex = 47
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreet.Location = New System.Drawing.Point(5, 37)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(108, 24)
        Me.lblStreet.TabIndex = 44
        Me.lblStreet.Text = "Street/Place"
        '
        'lblSuburb
        '
        Me.lblSuburb.AutoSize = True
        Me.lblSuburb.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuburb.Location = New System.Drawing.Point(4, 127)
        Me.lblSuburb.Name = "lblSuburb"
        Me.lblSuburb.Size = New System.Drawing.Size(71, 24)
        Me.lblSuburb.TabIndex = 48
        Me.lblSuburb.Text = "Suburb"
        '
        'txtSuburb
        '
        Me.txtSuburb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuburb.Location = New System.Drawing.Point(78, 131)
        Me.txtSuburb.Name = "txtSuburb"
        Me.txtSuburb.Size = New System.Drawing.Size(100, 20)
        Me.txtSuburb.TabIndex = 49
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(4, 173)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(51, 24)
        Me.lblState.TabIndex = 50
        Me.lblState.Text = "State"
        '
        'gbLocation
        '
        Me.gbLocation.Controls.Add(Me.cmbState)
        Me.gbLocation.Controls.Add(Me.btnSearch)
        Me.gbLocation.Controls.Add(Me.lblState)
        Me.gbLocation.Controls.Add(Me.lblSuburb)
        Me.gbLocation.Controls.Add(Me.txtSuburb)
        Me.gbLocation.Controls.Add(Me.lblStreet)
        Me.gbLocation.Controls.Add(Me.txtStreet)
        Me.gbLocation.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLocation.Location = New System.Drawing.Point(375, 35)
        Me.gbLocation.Name = "gbLocation"
        Me.gbLocation.Size = New System.Drawing.Size(182, 254)
        Me.gbLocation.TabIndex = 54
        Me.gbLocation.TabStop = False
        Me.gbLocation.Text = "Location"
        '
        'cmbState
        '
        Me.cmbState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Items.AddRange(New Object() {"NSW", "ACT", "WA", "NT", "TAS", "SA", "QLD", "VIC"})
        Me.cmbState.Location = New System.Drawing.Point(78, 176)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(100, 21)
        Me.cmbState.TabIndex = 55
        Me.cmbState.Text = "NSW"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(56, 209)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 32)
        Me.btnSearch.TabIndex = 54
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'gbEvents
        '
        Me.gbEvents.Controls.Add(Me.btnSaveTimes)
        Me.gbEvents.Controls.Add(Me.cmbEvent)
        Me.gbEvents.Controls.Add(Me.dtp13s)
        Me.gbEvents.Controls.Add(Me.dtpOpens)
        Me.gbEvents.Controls.Add(Me.lbl16s)
        Me.gbEvents.Controls.Add(Me.dtp16s)
        Me.gbEvents.Controls.Add(Me.dtp15s)
        Me.gbEvents.Controls.Add(Me.chbNA)
        Me.gbEvents.Controls.Add(Me.lbl17s)
        Me.gbEvents.Controls.Add(Me.dtp14s)
        Me.gbEvents.Controls.Add(Me.lbl15s)
        Me.gbEvents.Controls.Add(Me.lbl13s)
        Me.gbEvents.Controls.Add(Me.dtp17s)
        Me.gbEvents.Controls.Add(Me.lbl14s)
        Me.gbEvents.Controls.Add(Me.lblOpens)
        Me.gbEvents.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEvents.Location = New System.Drawing.Point(722, 304)
        Me.gbEvents.Name = "gbEvents"
        Me.gbEvents.Size = New System.Drawing.Size(257, 277)
        Me.gbEvents.TabIndex = 58
        Me.gbEvents.TabStop = False
        Me.gbEvents.Text = "Events"
        '
        'btnSaveTimes
        '
        Me.btnSaveTimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveTimes.Location = New System.Drawing.Point(201, 29)
        Me.btnSaveTimes.Name = "btnSaveTimes"
        Me.btnSaveTimes.Size = New System.Drawing.Size(51, 23)
        Me.btnSaveTimes.TabIndex = 45
        Me.btnSaveTimes.Text = "Save"
        Me.btnSaveTimes.UseVisualStyleBackColor = True
        '
        'cmbEvent
        '
        Me.cmbEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEvent.FormattingEnabled = True
        Me.cmbEvent.Items.AddRange(New Object() {"100m", "200m", "400m", "800m", "1.5k", "3k", "Hurdles", "High Jump", "Long Jump", "Shotput"})
        Me.cmbEvent.Location = New System.Drawing.Point(59, 29)
        Me.cmbEvent.Name = "cmbEvent"
        Me.cmbEvent.Size = New System.Drawing.Size(136, 21)
        Me.cmbEvent.TabIndex = 44
        '
        'dtp13s
        '
        Me.dtp13s.Font = New System.Drawing.Font("Modern No. 20", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp13s.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp13s.Location = New System.Drawing.Point(76, 64)
        Me.dtp13s.Name = "dtp13s"
        Me.dtp13s.ShowUpDown = True
        Me.dtp13s.Size = New System.Drawing.Size(176, 26)
        Me.dtp13s.TabIndex = 71
        Me.dtp13s.Tag = "U13"
        '
        'dtpOpens
        '
        Me.dtpOpens.Font = New System.Drawing.Font("Modern No. 20", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOpens.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpOpens.Location = New System.Drawing.Point(76, 246)
        Me.dtpOpens.Name = "dtpOpens"
        Me.dtpOpens.ShowUpDown = True
        Me.dtpOpens.Size = New System.Drawing.Size(176, 26)
        Me.dtpOpens.TabIndex = 70
        Me.dtpOpens.Tag = "Opens"
        '
        'lbl16s
        '
        Me.lbl16s.AutoSize = True
        Me.lbl16s.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl16s.Location = New System.Drawing.Point(6, 176)
        Me.lbl16s.Name = "lbl16s"
        Me.lbl16s.Size = New System.Drawing.Size(43, 21)
        Me.lbl16s.TabIndex = 65
        Me.lbl16s.Text = "16's:"
        '
        'dtp16s
        '
        Me.dtp16s.Font = New System.Drawing.Font("Modern No. 20", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp16s.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp16s.Location = New System.Drawing.Point(76, 174)
        Me.dtp16s.Name = "dtp16s"
        Me.dtp16s.ShowUpDown = True
        Me.dtp16s.Size = New System.Drawing.Size(176, 26)
        Me.dtp16s.TabIndex = 67
        Me.dtp16s.Tag = "U16"
        '
        'dtp15s
        '
        Me.dtp15s.Font = New System.Drawing.Font("Modern No. 20", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp15s.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp15s.Location = New System.Drawing.Point(76, 138)
        Me.dtp15s.Name = "dtp15s"
        Me.dtp15s.ShowUpDown = True
        Me.dtp15s.Size = New System.Drawing.Size(176, 26)
        Me.dtp15s.TabIndex = 64
        Me.dtp15s.Tag = "U15"
        '
        'lbl17s
        '
        Me.lbl17s.AutoSize = True
        Me.lbl17s.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl17s.Location = New System.Drawing.Point(6, 210)
        Me.lbl17s.Name = "lbl17s"
        Me.lbl17s.Size = New System.Drawing.Size(43, 21)
        Me.lbl17s.TabIndex = 66
        Me.lbl17s.Text = "17's:"
        '
        'dtp14s
        '
        Me.dtp14s.Font = New System.Drawing.Font("Modern No. 20", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp14s.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp14s.Location = New System.Drawing.Point(76, 102)
        Me.dtp14s.Name = "dtp14s"
        Me.dtp14s.ShowUpDown = True
        Me.dtp14s.Size = New System.Drawing.Size(176, 26)
        Me.dtp14s.TabIndex = 63
        Me.dtp14s.Tag = "U14"
        '
        'lbl15s
        '
        Me.lbl15s.AutoSize = True
        Me.lbl15s.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl15s.Location = New System.Drawing.Point(6, 138)
        Me.lbl15s.Name = "lbl15s"
        Me.lbl15s.Size = New System.Drawing.Size(43, 21)
        Me.lbl15s.TabIndex = 62
        Me.lbl15s.Text = "15's:"
        '
        'lbl13s
        '
        Me.lbl13s.AutoSize = True
        Me.lbl13s.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13s.Location = New System.Drawing.Point(6, 65)
        Me.lbl13s.Name = "lbl13s"
        Me.lbl13s.Size = New System.Drawing.Size(43, 21)
        Me.lbl13s.TabIndex = 60
        Me.lbl13s.Text = "13's:"
        '
        'dtp17s
        '
        Me.dtp17s.Font = New System.Drawing.Font("Modern No. 20", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp17s.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp17s.Location = New System.Drawing.Point(76, 210)
        Me.dtp17s.Name = "dtp17s"
        Me.dtp17s.ShowUpDown = True
        Me.dtp17s.Size = New System.Drawing.Size(176, 26)
        Me.dtp17s.TabIndex = 68
        Me.dtp17s.Tag = "U17"
        '
        'lbl14s
        '
        Me.lbl14s.AutoSize = True
        Me.lbl14s.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl14s.Location = New System.Drawing.Point(6, 101)
        Me.lbl14s.Name = "lbl14s"
        Me.lbl14s.Size = New System.Drawing.Size(43, 21)
        Me.lbl14s.TabIndex = 61
        Me.lbl14s.Text = "14's:"
        '
        'lblOpens
        '
        Me.lblOpens.AutoSize = True
        Me.lblOpens.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpens.Location = New System.Drawing.Point(6, 246)
        Me.lblOpens.Name = "lblOpens"
        Me.lblOpens.Size = New System.Drawing.Size(60, 21)
        Me.lblOpens.TabIndex = 69
        Me.lblOpens.Text = "Opens:"
        '
        'gbAttachments
        '
        Me.gbAttachments.Controls.Add(Me.flpAttach)
        Me.gbAttachments.Controls.Add(Me.btnBrowse)
        Me.gbAttachments.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAttachments.Location = New System.Drawing.Point(12, 315)
        Me.gbAttachments.Name = "gbAttachments"
        Me.gbAttachments.Size = New System.Drawing.Size(332, 273)
        Me.gbAttachments.TabIndex = 59
        Me.gbAttachments.TabStop = False
        Me.gbAttachments.Text = "Attachments"
        '
        'pbPlus
        '
        Me.pbPlus.Image = Global.main.My.Resources.Resources.transparent_plus
        Me.pbPlus.Location = New System.Drawing.Point(960, 122)
        Me.pbPlus.Name = "pbPlus"
        Me.pbPlus.Size = New System.Drawing.Size(25, 25)
        Me.pbPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPlus.TabIndex = 57
        Me.pbPlus.TabStop = False
        '
        'pbMinus
        '
        Me.pbMinus.Image = Global.main.My.Resources.Resources.transparent_minus
        Me.pbMinus.Location = New System.Drawing.Point(960, 159)
        Me.pbMinus.Name = "pbMinus"
        Me.pbMinus.Size = New System.Drawing.Size(25, 25)
        Me.pbMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMinus.TabIndex = 56
        Me.pbMinus.TabStop = False
        '
        'gbAthletes
        '
        Me.gbAthletes.Controls.Add(Me.Button1)
        Me.gbAthletes.Controls.Add(Me.chbAll)
        Me.gbAthletes.Controls.Add(Me.cmbGroup)
        Me.gbAthletes.Controls.Add(Me.flpAthletes)
        Me.gbAthletes.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAthletes.Location = New System.Drawing.Point(345, 317)
        Me.gbAthletes.Name = "gbAthletes"
        Me.gbAthletes.Size = New System.Drawing.Size(371, 273)
        Me.gbAthletes.TabIndex = 60
        Me.gbAthletes.TabStop = False
        Me.gbAthletes.Text = "Athletes"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(238, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chbAll
        '
        Me.chbAll.AutoSize = True
        Me.chbAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbAll.Location = New System.Drawing.Point(11, 25)
        Me.chbAll.Name = "chbAll"
        Me.chbAll.Size = New System.Drawing.Size(70, 17)
        Me.chbAll.TabIndex = 48
        Me.chbAll.Text = "Select All"
        Me.chbAll.UseVisualStyleBackColor = True
        '
        'cmbGroup
        '
        Me.cmbGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Items.AddRange(New Object() {"U13", "U14", "U15", "U16", "U17", "Opens"})
        Me.cmbGroup.Location = New System.Drawing.Point(88, 23)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(136, 21)
        Me.cmbGroup.TabIndex = 46
        '
        'flpAthletes
        '
        Me.flpAthletes.AutoScroll = True
        Me.flpAthletes.BackColor = System.Drawing.SystemColors.Control
        Me.flpAthletes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpAthletes.Location = New System.Drawing.Point(0, 48)
        Me.flpAthletes.Name = "flpAthletes"
        Me.flpAthletes.Size = New System.Drawing.Size(371, 211)
        Me.flpAthletes.TabIndex = 45
        Me.flpAthletes.WrapContents = False
        '
        'pnlAthlete
        '
        Me.pnlAthlete.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlAthlete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAthlete.Controls.Add(Me.lblRollClass)
        Me.pnlAthlete.Controls.Add(Me.lblRecents)
        Me.pnlAthlete.Controls.Add(Me.lblUnexplained)
        Me.pnlAthlete.Controls.Add(Me.lblId)
        Me.pnlAthlete.Controls.Add(Me.lblAverages)
        Me.pnlAthlete.Controls.Add(Me.lblName)
        Me.pnlAthlete.Controls.Add(Me.chbAthlete)
        Me.pnlAthlete.Controls.Add(Me.pbAthlete)
        Me.pnlAthlete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlAthlete.Location = New System.Drawing.Point(3, 65)
        Me.pnlAthlete.Name = "pnlAthlete"
        Me.pnlAthlete.Size = New System.Drawing.Size(348, 58)
        Me.pnlAthlete.TabIndex = 43
        '
        'lblRollClass
        '
        Me.lblRollClass.AutoSize = True
        Me.lblRollClass.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRollClass.Location = New System.Drawing.Point(291, 0)
        Me.lblRollClass.Name = "lblRollClass"
        Me.lblRollClass.Size = New System.Drawing.Size(34, 15)
        Me.lblRollClass.TabIndex = 49
        Me.lblRollClass.Text = "Class:"
        '
        'lblRecents
        '
        Me.lblRecents.AutoSize = True
        Me.lblRecents.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecents.Location = New System.Drawing.Point(81, 36)
        Me.lblRecents.Name = "lblRecents"
        Me.lblRecents.Size = New System.Drawing.Size(44, 15)
        Me.lblRecents.TabIndex = 48
        Me.lblRecents.Text = "Recents:"
        '
        'lblUnexplained
        '
        Me.lblUnexplained.AutoSize = True
        Me.lblUnexplained.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnexplained.Location = New System.Drawing.Point(209, 37)
        Me.lblUnexplained.Name = "lblUnexplained"
        Me.lblUnexplained.Size = New System.Drawing.Size(106, 15)
        Me.lblUnexplained.TabIndex = 47
        Me.lblUnexplained.Text = "Unexplained Absences:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(209, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(18, 15)
        Me.lblId.TabIndex = 46
        Me.lblId.Text = "ID:"
        '
        'lblAverages
        '
        Me.lblAverages.AutoSize = True
        Me.lblAverages.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverages.Location = New System.Drawing.Point(81, 17)
        Me.lblAverages.Name = "lblAverages"
        Me.lblAverages.Size = New System.Drawing.Size(50, 15)
        Me.lblAverages.TabIndex = 45
        Me.lblAverages.Text = "Averages:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(81, -1)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 15)
        Me.lblName.TabIndex = 44
        Me.lblName.Text = "Name:"
        '
        'chbAthlete
        '
        Me.chbAthlete.AutoSize = True
        Me.chbAthlete.Location = New System.Drawing.Point(329, 18)
        Me.chbAthlete.Name = "chbAthlete"
        Me.chbAthlete.Size = New System.Drawing.Size(15, 14)
        Me.chbAthlete.TabIndex = 43
        Me.chbAthlete.UseVisualStyleBackColor = True
        '
        'pbAthlete
        '
        Me.pbAthlete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAthlete.Image = Global.main.My.Resources.Resources.transparent_plus
        Me.pbAthlete.Location = New System.Drawing.Point(0, 0)
        Me.pbAthlete.Name = "pbAthlete"
        Me.pbAthlete.Size = New System.Drawing.Size(74, 56)
        Me.pbAthlete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAthlete.TabIndex = 42
        Me.pbAthlete.TabStop = False
        Me.pbAthlete.Tag = "add"
        '
        'createEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(983, 591)
        Me.Controls.Add(Me.gbAttachments)
        Me.Controls.Add(Me.gbAthletes)
        Me.Controls.Add(Me.gbEvents)
        Me.Controls.Add(Me.pbPlus)
        Me.Controls.Add(Me.pbMinus)
        Me.Controls.Add(Me.gbLocation)
        Me.Controls.Add(Me.map)
        Me.Controls.Add(Me.gbDetails)
        Me.Controls.Add(Me.btnSelectA)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveEvent)
        Me.Controls.Add(Me.lblTitle)
        Me.MaximizeBox = False
        Me.Name = "createEvent"
        Me.Text = "createEvent"
        Me.gbDetails.ResumeLayout(False)
        Me.gbDetails.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpAttach.ResumeLayout(False)
        Me.pnlAttach.ResumeLayout(False)
        CType(Me.pbAttach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLocation.ResumeLayout(False)
        Me.gbLocation.PerformLayout()
        Me.gbEvents.ResumeLayout(False)
        Me.gbEvents.PerformLayout()
        Me.gbAttachments.ResumeLayout(False)
        CType(Me.pbPlus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMinus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAthletes.ResumeLayout(False)
        Me.gbAthletes.PerformLayout()
        Me.pnlAthlete.ResumeLayout(False)
        Me.pnlAthlete.PerformLayout()
        CType(Me.pbAthlete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnSaveEvent As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents btnSelectA As Button
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents lblEnd As Label
    Friend WithEvents lblComment As Label
    Friend WithEvents lblType As Label
    Friend WithEvents rdbTraining As RadioButton
    Friend WithEvents rdbMeet As RadioButton
    Friend WithEvents chbNA As CheckBox
    Friend WithEvents ofdOpen As OpenFileDialog
    Friend WithEvents txtComment As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblEventName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblTemplate As Label
    Friend WithEvents cmbTemplate As ComboBox
    Friend WithEvents pbAttach As PictureBox
    Friend WithEvents chbNone As CheckBox
    Friend WithEvents sfdSave As SaveFileDialog
    Friend WithEvents gbDetails As GroupBox
    Friend WithEvents flpAttach As FlowLayoutPanel
    Friend WithEvents pnlAttach As Panel
    Friend WithEvents map As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents lblStreet As Label
    Friend WithEvents lblSuburb As Label
    Friend WithEvents txtSuburb As TextBox
    Friend WithEvents lblState As Label
    Friend WithEvents gbLocation As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents pbMinus As PictureBox
    Friend WithEvents pbPlus As PictureBox
    Friend WithEvents gbEvents As GroupBox
    Friend WithEvents gbAttachments As GroupBox
    Friend WithEvents dtp13s As DateTimePicker
    Friend WithEvents dtpOpens As DateTimePicker
    Friend WithEvents lbl16s As Label
    Friend WithEvents dtp16s As DateTimePicker
    Friend WithEvents dtp15s As DateTimePicker
    Friend WithEvents lbl17s As Label
    Friend WithEvents dtp14s As DateTimePicker
    Friend WithEvents lbl15s As Label
    Friend WithEvents lbl13s As Label
    Friend WithEvents dtp17s As DateTimePicker
    Friend WithEvents lbl14s As Label
    Friend WithEvents lblOpens As Label
    Friend WithEvents cmbEvent As ComboBox
    Friend WithEvents btnSaveTimes As Button
    Friend WithEvents gbAthletes As GroupBox
    Friend WithEvents flpAthletes As FlowLayoutPanel
    Friend WithEvents pnlAthlete As Panel
    Friend WithEvents pbAthlete As PictureBox
    Friend WithEvents cmbGroup As ComboBox
    Friend WithEvents chbAll As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents chbAthlete As CheckBox
    Friend WithEvents lblRecents As Label
    Friend WithEvents lblUnexplained As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblAverages As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblRollClass As Label
End Class
