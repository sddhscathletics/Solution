<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Results
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
        Me.TitleResult = New System.Windows.Forms.Label()
        Me.EventView = New System.Windows.Forms.DataGridView()
        Me.AthleteName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Placement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeetName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeetRev = New System.Windows.Forms.Button()
        Me.SeasonRev = New System.Windows.Forms.Button()
        Me.PrintEve = New System.Windows.Forms.Button()
        Me.EVEname = New System.Windows.Forms.Label()
        Me.EVEdate = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Place = New System.Windows.Forms.Label()
        Me.MeetNam = New System.Windows.Forms.Label()
        Me.EvenName = New System.Windows.Forms.Label()
        Me.AthAgeGro = New System.Windows.Forms.Label()
        Me.AthNam = New System.Windows.Forms.Label()
        Me.EvenDat = New System.Windows.Forms.Label()
        Me.IdPhoto = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.EventView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.IdPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleResult
        '
        Me.TitleResult.AutoSize = True
        Me.TitleResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleResult.Location = New System.Drawing.Point(25, 9)
        Me.TitleResult.Name = "TitleResult"
        Me.TitleResult.Size = New System.Drawing.Size(150, 42)
        Me.TitleResult.TabIndex = 0
        Me.TitleResult.Text = "Results"
        '
        'EventView
        '
        Me.EventView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EventView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AthleteName, Me.AgeGroup, Me.Placement, Me.MeetName, Me.EventName, Me.EventDate})
        Me.EventView.GridColor = System.Drawing.SystemColors.Control
        Me.EventView.Location = New System.Drawing.Point(654, 41)
        Me.EventView.Name = "EventView"
        Me.EventView.Size = New System.Drawing.Size(236, 221)
        Me.EventView.TabIndex = 1
        '
        'AthleteName
        '
        Me.AthleteName.HeaderText = "AthleteName"
        Me.AthleteName.Name = "AthleteName"
        '
        'AgeGroup
        '
        Me.AgeGroup.HeaderText = "AgeGroup"
        Me.AgeGroup.Name = "AgeGroup"
        '
        'Placement
        '
        Me.Placement.HeaderText = "Placement"
        Me.Placement.Name = "Placement"
        '
        'MeetName
        '
        Me.MeetName.HeaderText = "MeetName"
        Me.MeetName.Name = "MeetName"
        '
        'EventName
        '
        Me.EventName.HeaderText = "EventName"
        Me.EventName.Name = "EventName"
        '
        'EventDate
        '
        Me.EventDate.HeaderText = "EventDate"
        Me.EventDate.Name = "EventDate"
        '
        'MeetRev
        '
        Me.MeetRev.Location = New System.Drawing.Point(45, 342)
        Me.MeetRev.Name = "MeetRev"
        Me.MeetRev.Size = New System.Drawing.Size(163, 63)
        Me.MeetRev.TabIndex = 2
        Me.MeetRev.Text = "Generate Meet Review"
        Me.MeetRev.UseVisualStyleBackColor = True
        '
        'SeasonRev
        '
        Me.SeasonRev.Location = New System.Drawing.Point(45, 446)
        Me.SeasonRev.Name = "SeasonRev"
        Me.SeasonRev.Size = New System.Drawing.Size(163, 63)
        Me.SeasonRev.TabIndex = 3
        Me.SeasonRev.Text = "Generate Season Review"
        Me.SeasonRev.UseVisualStyleBackColor = True
        '
        'PrintEve
        '
        Me.PrintEve.Location = New System.Drawing.Point(823, 493)
        Me.PrintEve.Name = "PrintEve"
        Me.PrintEve.Size = New System.Drawing.Size(86, 45)
        Me.PrintEve.TabIndex = 4
        Me.PrintEve.Text = "Print"
        Me.PrintEve.UseVisualStyleBackColor = True
        '
        'EVEname
        '
        Me.EVEname.AutoSize = True
        Me.EVEname.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EVEname.Location = New System.Drawing.Point(19, 60)
        Me.EVEname.Name = "EVEname"
        Me.EVEname.Size = New System.Drawing.Size(156, 31)
        Me.EVEname.TabIndex = 6
        Me.EVEname.Text = "EventName"
        '
        'EVEdate
        '
        Me.EVEdate.AutoSize = True
        Me.EVEdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EVEdate.Location = New System.Drawing.Point(26, 105)
        Me.EVEdate.Name = "EVEdate"
        Me.EVEdate.Size = New System.Drawing.Size(142, 31)
        Me.EVEdate.TabIndex = 7
        Me.EVEdate.Text = "EventDate"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(225, 19)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(391, 519)
        Me.FlowLayoutPanel2.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Place)
        Me.Panel1.Controls.Add(Me.MeetNam)
        Me.Panel1.Controls.Add(Me.EvenName)
        Me.Panel1.Controls.Add(Me.AthAgeGro)
        Me.Panel1.Controls.Add(Me.AthNam)
        Me.Panel1.Controls.Add(Me.EvenDat)
        Me.Panel1.Controls.Add(Me.IdPhoto)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 100)
        Me.Panel1.TabIndex = 0
        '
        'Place
        '
        Me.Place.AutoSize = True
        Me.Place.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Place.Location = New System.Drawing.Point(285, 72)
        Me.Place.Name = "Place"
        Me.Place.Size = New System.Drawing.Size(43, 16)
        Me.Place.TabIndex = 6
        Me.Place.Text = "Place"
        '
        'MeetNam
        '
        Me.MeetNam.AutoSize = True
        Me.MeetNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeetNam.Location = New System.Drawing.Point(285, 22)
        Me.MeetNam.Name = "MeetNam"
        Me.MeetNam.Size = New System.Drawing.Size(38, 16)
        Me.MeetNam.TabIndex = 5
        Me.MeetNam.Text = "Meet"
        '
        'EvenName
        '
        Me.EvenName.AutoSize = True
        Me.EvenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EvenName.Location = New System.Drawing.Point(201, 72)
        Me.EvenName.Name = "EvenName"
        Me.EvenName.Size = New System.Drawing.Size(42, 16)
        Me.EvenName.TabIndex = 4
        Me.EvenName.Text = "Event"
        '
        'AthAgeGro
        '
        Me.AthAgeGro.AutoSize = True
        Me.AthAgeGro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AthAgeGro.Location = New System.Drawing.Point(201, 22)
        Me.AthAgeGro.Name = "AthAgeGro"
        Me.AthAgeGro.Size = New System.Drawing.Size(70, 16)
        Me.AthAgeGro.TabIndex = 3
        Me.AthAgeGro.Text = "AgeGroup"
        '
        'AthNam
        '
        Me.AthNam.AutoSize = True
        Me.AthNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AthNam.Location = New System.Drawing.Point(112, 22)
        Me.AthNam.Name = "AthNam"
        Me.AthNam.Size = New System.Drawing.Size(64, 16)
        Me.AthNam.TabIndex = 2
        Me.AthNam.Text = "AthName"
        '
        'EvenDat
        '
        Me.EvenDat.AutoSize = True
        Me.EvenDat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EvenDat.Location = New System.Drawing.Point(112, 72)
        Me.EvenDat.Name = "EvenDat"
        Me.EvenDat.Size = New System.Drawing.Size(37, 16)
        Me.EvenDat.TabIndex = 1
        Me.EvenDat.Text = "Date"
        '
        'IdPhoto
        '
        Me.IdPhoto.Location = New System.Drawing.Point(3, 0)
        Me.IdPhoto.Name = "IdPhoto"
        Me.IdPhoto.Size = New System.Drawing.Size(90, 97)
        Me.IdPhoto.TabIndex = 0
        Me.IdPhoto.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(185, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Age Group:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(285, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Meet:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(273, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Placement:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(201, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Event:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(112, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date:"
        '
        'Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 550)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.EVEdate)
        Me.Controls.Add(Me.EVEname)
        Me.Controls.Add(Me.PrintEve)
        Me.Controls.Add(Me.SeasonRev)
        Me.Controls.Add(Me.MeetRev)
        Me.Controls.Add(Me.EventView)
        Me.Controls.Add(Me.TitleResult)
        Me.Name = "Results"
        Me.Text = "Results"
        CType(Me.EventView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IdPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleResult As Label
    Friend WithEvents EventView As DataGridView
    Friend WithEvents MeetRev As Button
    Friend WithEvents SeasonRev As Button
    Friend WithEvents PrintEve As Button
    Friend WithEvents AthleteName As DataGridViewTextBoxColumn
    Friend WithEvents AgeGroup As DataGridViewTextBoxColumn
    Friend WithEvents Placement As DataGridViewTextBoxColumn
    Friend WithEvents MeetName As DataGridViewTextBoxColumn
    Friend WithEvents EventName As DataGridViewTextBoxColumn
    Friend WithEvents EventDate As DataGridViewTextBoxColumn
    Friend WithEvents EVEname As Label
    Friend WithEvents EVEdate As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Place As Label
    Friend WithEvents MeetNam As Label
    Friend WithEvents EvenName As Label
    Friend WithEvents AthAgeGro As Label
    Friend WithEvents AthNam As Label
    Friend WithEvents EvenDat As Label
    Friend WithEvents IdPhoto As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
