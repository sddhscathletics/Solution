<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class createEvent
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
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSaveEvent = New System.Windows.Forms.Button()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.rdbTraining = New System.Windows.Forms.RadioButton()
        Me.rdbMeet = New System.Windows.Forms.RadioButton()
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
        Me.flpAttach = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlAttach = New System.Windows.Forms.Panel()
        Me.map = New GMap.NET.WindowsForms.GMapControl()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.lblSuburb = New System.Windows.Forms.Label()
        Me.txtSuburb = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.gbLocation = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.gbAttachments = New System.Windows.Forms.GroupBox()
        Me.gbAthletes = New System.Windows.Forms.GroupBox()
        Me.chbAllNotes = New System.Windows.Forms.CheckBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.chbAllAthletes = New System.Windows.Forms.CheckBox()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.flpAthletes = New System.Windows.Forms.FlowLayoutPanel()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.lblOpens = New System.Windows.Forms.Label()
        Me.lbl14s = New System.Windows.Forms.Label()
        Me.dtp17s = New System.Windows.Forms.DateTimePicker()
        Me.lbl13s = New System.Windows.Forms.Label()
        Me.lbl15s = New System.Windows.Forms.Label()
        Me.dtp14s = New System.Windows.Forms.DateTimePicker()
        Me.lbl17s = New System.Windows.Forms.Label()
        Me.chbNA = New System.Windows.Forms.CheckBox()
        Me.dtp15s = New System.Windows.Forms.DateTimePicker()
        Me.dtp16s = New System.Windows.Forms.DateTimePicker()
        Me.lbl16s = New System.Windows.Forms.Label()
        Me.dtpOpens = New System.Windows.Forms.DateTimePicker()
        Me.dtp13s = New System.Windows.Forms.DateTimePicker()
        Me.cmbEvent = New System.Windows.Forms.ComboBox()
        Me.btnSaveTimes = New System.Windows.Forms.Button()
        Me.gbEvents = New System.Windows.Forms.GroupBox()
        Me.pbCmb = New System.Windows.Forms.PictureBox()
        Me.pbAttach = New System.Windows.Forms.PictureBox()
        Me.pbPlus = New System.Windows.Forms.PictureBox()
        Me.pbMinus = New System.Windows.Forms.PictureBox()
        Me.gbDetails.SuspendLayout()
        Me.flpAttach.SuspendLayout()
        Me.pnlAttach.SuspendLayout()
        Me.gbLocation.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAttachments.SuspendLayout()
        Me.gbAthletes.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbEvents.SuspendLayout()
        CType(Me.pbCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAttach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPlus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMinus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpStart
        '
        Me.dtpStart.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStart.Location = New System.Drawing.Point(98, 188)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.ShowUpDown = True
        Me.dtpStart.Size = New System.Drawing.Size(230, 23)
        Me.dtpStart.TabIndex = 23
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(98, 150)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(230, 23)
        Me.dtpDate.TabIndex = 22
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.Location = New System.Drawing.Point(856, 632)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(396, 37)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSaveEvent
        '
        Me.btnSaveEvent.BackColor = System.Drawing.Color.Gray
        Me.btnSaveEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveEvent.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnSaveEvent.Location = New System.Drawing.Point(856, 572)
        Me.btnSaveEvent.Name = "btnSaveEvent"
        Me.btnSaveEvent.Size = New System.Drawing.Size(396, 54)
        Me.btnSaveEvent.TabIndex = 20
        Me.btnSaveEvent.Text = "SAVE"
        Me.btnSaveEvent.UseVisualStyleBackColor = False
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(35, 188)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(46, 16)
        Me.lblStart.TabIndex = 17
        Me.lblStart.Text = "START"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(44, 155)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(41, 16)
        Me.lblDate.TabIndex = 16
        Me.lblDate.Text = "DATE"
        '
        'dtpEnd
        '
        Me.dtpEnd.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEnd.Location = New System.Drawing.Point(98, 217)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.ShowUpDown = True
        Me.dtpEnd.Size = New System.Drawing.Size(230, 23)
        Me.dtpEnd.TabIndex = 27
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(44, 222)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(34, 16)
        Me.lblEnd.TabIndex = 26
        Me.lblEnd.Text = "END"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment.Location = New System.Drawing.Point(8, 258)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(74, 16)
        Me.lblComment.TabIndex = 29
        Me.lblComment.Text = "COMMENT"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(44, 120)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(38, 16)
        Me.lblType.TabIndex = 30
        Me.lblType.Text = "TYPE"
        '
        'rdbTraining
        '
        Me.rdbTraining.AutoSize = True
        Me.rdbTraining.Checked = True
        Me.rdbTraining.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTraining.Location = New System.Drawing.Point(109, 118)
        Me.rdbTraining.Name = "rdbTraining"
        Me.rdbTraining.Size = New System.Drawing.Size(73, 20)
        Me.rdbTraining.TabIndex = 31
        Me.rdbTraining.TabStop = True
        Me.rdbTraining.Text = "Training"
        Me.rdbTraining.UseVisualStyleBackColor = True
        '
        'rdbMeet
        '
        Me.rdbMeet.AutoSize = True
        Me.rdbMeet.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMeet.Location = New System.Drawing.Point(188, 120)
        Me.rdbMeet.Name = "rdbMeet"
        Me.rdbMeet.Size = New System.Drawing.Size(55, 20)
        Me.rdbMeet.TabIndex = 32
        Me.rdbMeet.Text = "Meet"
        Me.rdbMeet.UseVisualStyleBackColor = True
        '
        'ofdOpen
        '
        Me.ofdOpen.FileName = "OpenFileDialog1"
        '
        'txtComment
        '
        Me.txtComment.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.Location = New System.Drawing.Point(98, 255)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(230, 54)
        Me.txtComment.TabIndex = 36
        Me.txtComment.Text = "Enter your comment here"
        Me.txtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblTitle.Location = New System.Drawing.Point(22, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(201, 27)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "EVENT CREATOR"
        '
        'lblEventName
        '
        Me.lblEventName.AutoSize = True
        Me.lblEventName.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventName.Location = New System.Drawing.Point(37, 93)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(45, 16)
        Me.lblEventName.TabIndex = 37
        Me.lblEventName.Text = "NAME"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(95, 86)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(230, 23)
        Me.txtName.TabIndex = 38
        Me.txtName.Text = "Enter the event name here"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTemplate
        '
        Me.lblTemplate.AutoSize = True
        Me.lblTemplate.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemplate.Location = New System.Drawing.Point(15, 51)
        Me.lblTemplate.Name = "lblTemplate"
        Me.lblTemplate.Size = New System.Drawing.Size(72, 16)
        Me.lblTemplate.TabIndex = 40
        Me.lblTemplate.Text = "TEMPLATE"
        '
        'cmbTemplate
        '
        Me.cmbTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTemplate.Enabled = False
        Me.cmbTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTemplate.FormattingEnabled = True
        Me.cmbTemplate.Location = New System.Drawing.Point(98, 46)
        Me.cmbTemplate.Name = "cmbTemplate"
        Me.cmbTemplate.Size = New System.Drawing.Size(161, 21)
        Me.cmbTemplate.TabIndex = 41
        '
        'chbNone
        '
        Me.chbNone.AutoSize = True
        Me.chbNone.Checked = True
        Me.chbNone.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbNone.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbNone.Location = New System.Drawing.Point(271, 47)
        Me.chbNone.Name = "chbNone"
        Me.chbNone.Size = New System.Drawing.Size(57, 20)
        Me.chbNone.TabIndex = 43
        Me.chbNone.Text = "None"
        Me.chbNone.UseVisualStyleBackColor = True
        '
        'gbDetails
        '
        Me.gbDetails.Controls.Add(Me.chbNone)
        Me.gbDetails.Controls.Add(Me.cmbTemplate)
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
        Me.gbDetails.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold)
        Me.gbDetails.Location = New System.Drawing.Point(12, 64)
        Me.gbDetails.Name = "gbDetails"
        Me.gbDetails.Size = New System.Drawing.Size(347, 343)
        Me.gbDetails.TabIndex = 44
        Me.gbDetails.TabStop = False
        Me.gbDetails.Text = "DETAILS"
        '
        'flpAttach
        '
        Me.flpAttach.AutoScroll = True
        Me.flpAttach.BackColor = System.Drawing.SystemColors.Control
        Me.flpAttach.Controls.Add(Me.pnlAttach)
        Me.flpAttach.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpAttach.Location = New System.Drawing.Point(2, 24)
        Me.flpAttach.Name = "flpAttach"
        Me.flpAttach.Size = New System.Drawing.Size(342, 178)
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
        Me.pnlAttach.Size = New System.Drawing.Size(319, 56)
        Me.pnlAttach.TabIndex = 43
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
        Me.map.Location = New System.Drawing.Point(856, 57)
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
        Me.map.Size = New System.Drawing.Size(394, 290)
        Me.map.TabIndex = 46
        Me.map.Zoom = 10.0R
        '
        'txtStreet
        '
        Me.txtStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreet.Location = New System.Drawing.Point(81, 71)
        Me.txtStreet.Multiline = True
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(213, 21)
        Me.txtStreet.TabIndex = 47
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreet.Location = New System.Drawing.Point(22, 75)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(53, 16)
        Me.lblStreet.TabIndex = 44
        Me.lblStreet.Text = "STREET"
        '
        'lblSuburb
        '
        Me.lblSuburb.AutoSize = True
        Me.lblSuburb.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuburb.Location = New System.Drawing.Point(18, 99)
        Me.lblSuburb.Name = "lblSuburb"
        Me.lblSuburb.Size = New System.Drawing.Size(57, 16)
        Me.lblSuburb.TabIndex = 48
        Me.lblSuburb.Text = "SUBURB"
        '
        'txtSuburb
        '
        Me.txtSuburb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuburb.Location = New System.Drawing.Point(81, 99)
        Me.txtSuburb.Name = "txtSuburb"
        Me.txtSuburb.Size = New System.Drawing.Size(213, 20)
        Me.txtSuburb.TabIndex = 49
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(29, 126)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(46, 16)
        Me.lblState.TabIndex = 50
        Me.lblState.Text = "STATE"
        '
        'gbLocation
        '
        Me.gbLocation.Controls.Add(Me.DataGridView1)
        Me.gbLocation.Controls.Add(Me.cmbState)
        Me.gbLocation.Controls.Add(Me.btnSearch)
        Me.gbLocation.Controls.Add(Me.lblState)
        Me.gbLocation.Controls.Add(Me.lblSuburb)
        Me.gbLocation.Controls.Add(Me.txtSuburb)
        Me.gbLocation.Controls.Add(Me.lblStreet)
        Me.gbLocation.Controls.Add(Me.txtStreet)
        Me.gbLocation.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold)
        Me.gbLocation.Location = New System.Drawing.Point(856, 375)
        Me.gbLocation.Name = "gbLocation"
        Me.gbLocation.Size = New System.Drawing.Size(394, 172)
        Me.gbLocation.TabIndex = 54
        Me.gbLocation.TabStop = False
        Me.gbLocation.Text = "LOCATION"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(163, 22)
        Me.DataGridView1.TabIndex = 44
        Me.DataGridView1.Visible = False
        '
        'cmbState
        '
        Me.cmbState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Items.AddRange(New Object() {"NSW", "ACT", "WA", "NT", "TAS", "SA", "QLD", "VIC"})
        Me.cmbState.Location = New System.Drawing.Point(81, 126)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(213, 21)
        Me.cmbState.TabIndex = 55
        Me.cmbState.Text = "NSW"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Gray
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(312, 48)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(76, 99)
        Me.btnSearch.TabIndex = 54
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'gbAttachments
        '
        Me.gbAttachments.Controls.Add(Me.flpAttach)
        Me.gbAttachments.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold)
        Me.gbAttachments.Location = New System.Drawing.Point(12, 406)
        Me.gbAttachments.Name = "gbAttachments"
        Me.gbAttachments.Size = New System.Drawing.Size(347, 206)
        Me.gbAttachments.TabIndex = 59
        Me.gbAttachments.TabStop = False
        Me.gbAttachments.Text = "ATTACHMENTS"
        '
        'gbAthletes
        '
        Me.gbAthletes.Controls.Add(Me.chbAllNotes)
        Me.gbAthletes.Controls.Add(Me.btnSelect)
        Me.gbAthletes.Controls.Add(Me.chbAllAthletes)
        Me.gbAthletes.Controls.Add(Me.cmbGroup)
        Me.gbAthletes.Controls.Add(Me.flpAthletes)
        Me.gbAthletes.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold)
        Me.gbAthletes.Location = New System.Drawing.Point(391, 64)
        Me.gbAthletes.Name = "gbAthletes"
        Me.gbAthletes.Size = New System.Drawing.Size(444, 263)
        Me.gbAthletes.TabIndex = 60
        Me.gbAthletes.TabStop = False
        Me.gbAthletes.Text = "ATHLETES"
        '
        'chbAllNotes
        '
        Me.chbAllNotes.AutoSize = True
        Me.chbAllNotes.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbAllNotes.Location = New System.Drawing.Point(134, 31)
        Me.chbAllNotes.Name = "chbAllNotes"
        Me.chbAllNotes.Size = New System.Drawing.Size(94, 20)
        Me.chbAllNotes.TabIndex = 62
        Me.chbAllNotes.Text = "ALL NOTES"
        Me.chbAllNotes.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Gray
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelect.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(365, 28)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 61
        Me.btnSelect.Text = "SELECT"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'chbAllAthletes
        '
        Me.chbAllAthletes.AutoSize = True
        Me.chbAllAthletes.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbAllAthletes.Location = New System.Drawing.Point(6, 31)
        Me.chbAllAthletes.Name = "chbAllAthletes"
        Me.chbAllAthletes.Size = New System.Drawing.Size(125, 20)
        Me.chbAllAthletes.TabIndex = 48
        Me.chbAllAthletes.Text = "ALL ATTENDING"
        Me.chbAllAthletes.UseVisualStyleBackColor = True
        '
        'cmbGroup
        '
        Me.cmbGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Items.AddRange(New Object() {"U13", "U14", "U15", "U16", "U17", "Opens"})
        Me.cmbGroup.Location = New System.Drawing.Point(226, 30)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(136, 21)
        Me.cmbGroup.TabIndex = 46
        '
        'flpAthletes
        '
        Me.flpAthletes.AutoScroll = True
        Me.flpAthletes.BackColor = System.Drawing.SystemColors.Control
        Me.flpAthletes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpAthletes.Location = New System.Drawing.Point(5, 54)
        Me.flpAthletes.Name = "flpAthletes"
        Me.flpAthletes.Size = New System.Drawing.Size(433, 206)
        Me.flpAthletes.TabIndex = 45
        Me.flpAthletes.WrapContents = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Enabled = False
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Swag", "Bomsl"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(619, 354)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 19)
        Me.CheckedListBox1.TabIndex = 61
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.exitBtn)
        Me.GroupBox2.Controls.Add(Me.lblTitle)
        Me.GroupBox2.Location = New System.Drawing.Point(-10, -11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1377, 58)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.exitBtn.FlatAppearance.BorderSize = 0
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.exitBtn.Location = New System.Drawing.Point(1228, 11)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(44, 44)
        Me.exitBtn.TabIndex = 6
        Me.exitBtn.Text = "exit"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'lblOpens
        '
        Me.lblOpens.AutoSize = True
        Me.lblOpens.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpens.Location = New System.Drawing.Point(5, 246)
        Me.lblOpens.Name = "lblOpens"
        Me.lblOpens.Size = New System.Drawing.Size(58, 15)
        Me.lblOpens.TabIndex = 69
        Me.lblOpens.Text = "OPENS:"
        '
        'lbl14s
        '
        Me.lbl14s.AutoSize = True
        Me.lbl14s.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl14s.Location = New System.Drawing.Point(26, 106)
        Me.lbl14s.Name = "lbl14s"
        Me.lbl14s.Size = New System.Drawing.Size(37, 15)
        Me.lbl14s.TabIndex = 61
        Me.lbl14s.Text = "14's:"
        '
        'dtp17s
        '
        Me.dtp17s.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp17s.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp17s.Location = New System.Drawing.Point(80, 210)
        Me.dtp17s.Name = "dtp17s"
        Me.dtp17s.ShowUpDown = True
        Me.dtp17s.Size = New System.Drawing.Size(176, 23)
        Me.dtp17s.TabIndex = 68
        Me.dtp17s.Tag = "U17"
        '
        'lbl13s
        '
        Me.lbl13s.AutoSize = True
        Me.lbl13s.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13s.Location = New System.Drawing.Point(26, 70)
        Me.lbl13s.Name = "lbl13s"
        Me.lbl13s.Size = New System.Drawing.Size(37, 15)
        Me.lbl13s.TabIndex = 60
        Me.lbl13s.Text = "13's:"
        '
        'lbl15s
        '
        Me.lbl15s.AutoSize = True
        Me.lbl15s.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl15s.Location = New System.Drawing.Point(26, 143)
        Me.lbl15s.Name = "lbl15s"
        Me.lbl15s.Size = New System.Drawing.Size(37, 15)
        Me.lbl15s.TabIndex = 62
        Me.lbl15s.Text = "15's:"
        '
        'dtp14s
        '
        Me.dtp14s.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp14s.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp14s.Location = New System.Drawing.Point(80, 102)
        Me.dtp14s.Name = "dtp14s"
        Me.dtp14s.ShowUpDown = True
        Me.dtp14s.Size = New System.Drawing.Size(176, 23)
        Me.dtp14s.TabIndex = 63
        Me.dtp14s.Tag = "U14"
        '
        'lbl17s
        '
        Me.lbl17s.AutoSize = True
        Me.lbl17s.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl17s.Location = New System.Drawing.Point(26, 215)
        Me.lbl17s.Name = "lbl17s"
        Me.lbl17s.Size = New System.Drawing.Size(37, 15)
        Me.lbl17s.TabIndex = 66
        Me.lbl17s.Text = "17's:"
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
        'dtp15s
        '
        Me.dtp15s.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp15s.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp15s.Location = New System.Drawing.Point(80, 138)
        Me.dtp15s.Name = "dtp15s"
        Me.dtp15s.ShowUpDown = True
        Me.dtp15s.Size = New System.Drawing.Size(176, 23)
        Me.dtp15s.TabIndex = 64
        Me.dtp15s.Tag = "U15"
        '
        'dtp16s
        '
        Me.dtp16s.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp16s.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp16s.Location = New System.Drawing.Point(80, 174)
        Me.dtp16s.Name = "dtp16s"
        Me.dtp16s.ShowUpDown = True
        Me.dtp16s.Size = New System.Drawing.Size(176, 23)
        Me.dtp16s.TabIndex = 67
        Me.dtp16s.Tag = "U16"
        '
        'lbl16s
        '
        Me.lbl16s.AutoSize = True
        Me.lbl16s.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl16s.Location = New System.Drawing.Point(26, 181)
        Me.lbl16s.Name = "lbl16s"
        Me.lbl16s.Size = New System.Drawing.Size(37, 15)
        Me.lbl16s.TabIndex = 65
        Me.lbl16s.Text = "16's:"
        '
        'dtpOpens
        '
        Me.dtpOpens.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOpens.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpOpens.Location = New System.Drawing.Point(80, 246)
        Me.dtpOpens.Name = "dtpOpens"
        Me.dtpOpens.ShowUpDown = True
        Me.dtpOpens.Size = New System.Drawing.Size(176, 23)
        Me.dtpOpens.TabIndex = 70
        Me.dtpOpens.Tag = "Opens"
        '
        'dtp13s
        '
        Me.dtp13s.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp13s.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp13s.Location = New System.Drawing.Point(80, 64)
        Me.dtp13s.Name = "dtp13s"
        Me.dtp13s.ShowUpDown = True
        Me.dtp13s.Size = New System.Drawing.Size(176, 23)
        Me.dtp13s.TabIndex = 71
        Me.dtp13s.Tag = "U13"
        '
        'cmbEvent
        '
        Me.cmbEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEvent.FormattingEnabled = True
        Me.cmbEvent.Items.AddRange(New Object() {"100m", "200m", "400m", "800m", "1.5k", "3k", "Hurdles", "High Jump", "Long Jump", "Shotput"})
        Me.cmbEvent.Location = New System.Drawing.Point(60, 29)
        Me.cmbEvent.Name = "cmbEvent"
        Me.cmbEvent.Size = New System.Drawing.Size(136, 21)
        Me.cmbEvent.TabIndex = 44
        '
        'btnSaveTimes
        '
        Me.btnSaveTimes.BackColor = System.Drawing.Color.Gray
        Me.btnSaveTimes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveTimes.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveTimes.Location = New System.Drawing.Point(204, 29)
        Me.btnSaveTimes.Name = "btnSaveTimes"
        Me.btnSaveTimes.Size = New System.Drawing.Size(51, 23)
        Me.btnSaveTimes.TabIndex = 45
        Me.btnSaveTimes.Text = "SAVE"
        Me.btnSaveTimes.UseVisualStyleBackColor = False
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
        Me.gbEvents.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEvents.Location = New System.Drawing.Point(396, 392)
        Me.gbEvents.Name = "gbEvents"
        Me.gbEvents.Size = New System.Drawing.Size(267, 277)
        Me.gbEvents.TabIndex = 58
        Me.gbEvents.TabStop = False
        Me.gbEvents.Text = "EVENTS"
        '
        'pbCmb
        '
        Me.pbCmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCmb.Image = Global.main.My.Resources.Resources.comboBoxImage
        Me.pbCmb.Location = New System.Drawing.Point(407, 333)
        Me.pbCmb.Name = "pbCmb"
        Me.pbCmb.Size = New System.Drawing.Size(182, 21)
        Me.pbCmb.TabIndex = 43
        Me.pbCmb.TabStop = False
        Me.pbCmb.Tag = "add"
        '
        'pbAttach
        '
        Me.pbAttach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAttach.Image = Global.main.My.Resources.Resources.transparent_plus
        Me.pbAttach.Location = New System.Drawing.Point(114, -1)
        Me.pbAttach.Name = "pbAttach"
        Me.pbAttach.Size = New System.Drawing.Size(74, 56)
        Me.pbAttach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAttach.TabIndex = 42
        Me.pbAttach.TabStop = False
        Me.pbAttach.Tag = "add"
        '
        'pbPlus
        '
        Me.pbPlus.Image = Global.main.My.Resources.Resources.transparent_plus
        Me.pbPlus.Location = New System.Drawing.Point(1225, 171)
        Me.pbPlus.Name = "pbPlus"
        Me.pbPlus.Size = New System.Drawing.Size(25, 25)
        Me.pbPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPlus.TabIndex = 57
        Me.pbPlus.TabStop = False
        '
        'pbMinus
        '
        Me.pbMinus.Image = Global.main.My.Resources.Resources.transparent_minus
        Me.pbMinus.Location = New System.Drawing.Point(1225, 208)
        Me.pbMinus.Name = "pbMinus"
        Me.pbMinus.Size = New System.Drawing.Size(25, 25)
        Me.pbMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMinus.TabIndex = 56
        Me.pbMinus.TabStop = False
        '
        'createEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.pbCmb)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.gbAttachments)
        Me.Controls.Add(Me.gbAthletes)
        Me.Controls.Add(Me.gbEvents)
        Me.Controls.Add(Me.pbPlus)
        Me.Controls.Add(Me.pbMinus)
        Me.Controls.Add(Me.gbLocation)
        Me.Controls.Add(Me.map)
        Me.Controls.Add(Me.gbDetails)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveEvent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "createEvent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "createEvent"
        Me.gbDetails.ResumeLayout(False)
        Me.gbDetails.PerformLayout()
        Me.flpAttach.ResumeLayout(False)
        Me.pnlAttach.ResumeLayout(False)
        Me.gbLocation.ResumeLayout(False)
        Me.gbLocation.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAttachments.ResumeLayout(False)
        Me.gbAthletes.ResumeLayout(False)
        Me.gbAthletes.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbEvents.ResumeLayout(False)
        Me.gbEvents.PerformLayout()
        CType(Me.pbCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAttach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPlus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMinus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents btnSaveEvent As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents lblEnd As Label
    Friend WithEvents lblComment As Label
    Friend WithEvents lblType As Label
    Friend WithEvents rdbTraining As RadioButton
    Friend WithEvents rdbMeet As RadioButton
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
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents pbMinus As PictureBox
    Friend WithEvents pbPlus As PictureBox
    Friend WithEvents gbAttachments As GroupBox
    Friend WithEvents gbAthletes As GroupBox
    Friend WithEvents flpAthletes As FlowLayoutPanel
    Friend WithEvents cmbGroup As ComboBox
    Friend WithEvents chbAllAthletes As CheckBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents chbAllNotes As CheckBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents gbEvents As GroupBox
    Friend WithEvents btnSaveTimes As Button
    Friend WithEvents cmbEvent As ComboBox
    Friend WithEvents dtp13s As DateTimePicker
    Friend WithEvents dtpOpens As DateTimePicker
    Friend WithEvents lbl16s As Label
    Friend WithEvents dtp16s As DateTimePicker
    Friend WithEvents dtp15s As DateTimePicker
    Friend WithEvents chbNA As CheckBox
    Friend WithEvents lbl17s As Label
    Friend WithEvents dtp14s As DateTimePicker
    Friend WithEvents lbl15s As Label
    Friend WithEvents lbl13s As Label
    Friend WithEvents dtp17s As DateTimePicker
    Friend WithEvents lbl14s As Label
    Friend WithEvents lblOpens As Label
    Friend WithEvents pbCmb As PictureBox
End Class
