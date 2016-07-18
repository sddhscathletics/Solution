<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class athleteProfile
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblMedical = New System.Windows.Forms.Label()
        Me.lblMedicalHeader = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblBestEvent = New System.Windows.Forms.Label()
        Me.lblAgeGroup = New System.Windows.Forms.Label()
        Me.lblStNo = New System.Windows.Forms.Label()
        Me.lblSt = New System.Windows.Forms.Label()
        Me.lblSb = New System.Windows.Forms.Label()
        Me.lblPo = New System.Windows.Forms.Label()
        Me.lblTeams = New System.Windows.Forms.Label()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.lblRoll = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(3, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 33
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblMedical
        '
        Me.lblMedical.AutoSize = True
        Me.lblMedical.Location = New System.Drawing.Point(110, 313)
        Me.lblMedical.Name = "lblMedical"
        Me.lblMedical.Size = New System.Drawing.Size(99, 13)
        Me.lblMedical.TabIndex = 32
        Me.lblMedical.Text = "Medical Information"
        '
        'lblMedicalHeader
        '
        Me.lblMedicalHeader.AutoSize = True
        Me.lblMedicalHeader.Location = New System.Drawing.Point(110, 300)
        Me.lblMedicalHeader.Name = "lblMedicalHeader"
        Me.lblMedicalHeader.Size = New System.Drawing.Size(79, 13)
        Me.lblMedicalHeader.TabIndex = 31
        Me.lblMedicalHeader.Text = "Medical Details"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(110, 274)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(78, 13)
        Me.lblPhone.TabIndex = 30
        Me.lblPhone.Text = "Phone Number"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(110, 287)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(73, 13)
        Me.lblEmail.TabIndex = 29
        Me.lblEmail.Text = "Email Address"
        '
        'lblBestEvent
        '
        Me.lblBestEvent.AutoSize = True
        Me.lblBestEvent.Location = New System.Drawing.Point(110, 174)
        Me.lblBestEvent.Name = "lblBestEvent"
        Me.lblBestEvent.Size = New System.Drawing.Size(59, 13)
        Me.lblBestEvent.TabIndex = 28
        Me.lblBestEvent.Text = "Best Event"
        '
        'lblAgeGroup
        '
        Me.lblAgeGroup.AutoSize = True
        Me.lblAgeGroup.Location = New System.Drawing.Point(110, 148)
        Me.lblAgeGroup.Name = "lblAgeGroup"
        Me.lblAgeGroup.Size = New System.Drawing.Size(58, 13)
        Me.lblAgeGroup.TabIndex = 27
        Me.lblAgeGroup.Text = "Age Group"
        '
        'lblStNo
        '
        Me.lblStNo.AutoSize = True
        Me.lblStNo.Location = New System.Drawing.Point(110, 212)
        Me.lblStNo.Name = "lblStNo"
        Me.lblStNo.Size = New System.Drawing.Size(75, 13)
        Me.lblStNo.TabIndex = 26
        Me.lblStNo.Text = "Street Number"
        '
        'lblSt
        '
        Me.lblSt.AutoSize = True
        Me.lblSt.Location = New System.Drawing.Point(110, 225)
        Me.lblSt.Name = "lblSt"
        Me.lblSt.Size = New System.Drawing.Size(35, 13)
        Me.lblSt.TabIndex = 25
        Me.lblSt.Text = "Street"
        '
        'lblSb
        '
        Me.lblSb.AutoSize = True
        Me.lblSb.Location = New System.Drawing.Point(110, 238)
        Me.lblSb.Name = "lblSb"
        Me.lblSb.Size = New System.Drawing.Size(41, 13)
        Me.lblSb.TabIndex = 24
        Me.lblSb.Text = "Suburb"
        '
        'lblPo
        '
        Me.lblPo.AutoSize = True
        Me.lblPo.Location = New System.Drawing.Point(110, 251)
        Me.lblPo.Name = "lblPo"
        Me.lblPo.Size = New System.Drawing.Size(52, 13)
        Me.lblPo.TabIndex = 23
        Me.lblPo.Text = "Postcode"
        '
        'lblTeams
        '
        Me.lblTeams.AutoSize = True
        Me.lblTeams.Location = New System.Drawing.Point(110, 161)
        Me.lblTeams.Name = "lblTeams"
        Me.lblTeams.Size = New System.Drawing.Size(39, 13)
        Me.lblTeams.TabIndex = 22
        Me.lblTeams.Text = "Teams"
        '
        'pbPhoto
        '
        Me.pbPhoto.Location = New System.Drawing.Point(3, 34)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(100, 150)
        Me.pbPhoto.TabIndex = 21
        Me.pbPhoto.TabStop = False
        '
        'lblRoll
        '
        Me.lblRoll.AutoSize = True
        Me.lblRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoll.Location = New System.Drawing.Point(109, 98)
        Me.lblRoll.Name = "lblRoll"
        Me.lblRoll.Size = New System.Drawing.Size(79, 20)
        Me.lblRoll.TabIndex = 20
        Me.lblRoll.Text = "Roll Class"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(109, 78)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(86, 20)
        Me.lblFName.TabIndex = 19
        Me.lblFName.Text = "First Name"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(109, 58)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(86, 20)
        Me.lblLName.TabIndex = 18
        Me.lblLName.Text = "Last Name"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(109, 34)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(96, 24)
        Me.lblID.TabIndex = 17
        Me.lblID.Text = "Student ID"
        '
        'athleteProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblMedical)
        Me.Controls.Add(Me.lblMedicalHeader)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblBestEvent)
        Me.Controls.Add(Me.lblAgeGroup)
        Me.Controls.Add(Me.lblStNo)
        Me.Controls.Add(Me.lblSt)
        Me.Controls.Add(Me.lblSb)
        Me.Controls.Add(Me.lblPo)
        Me.Controls.Add(Me.lblTeams)
        Me.Controls.Add(Me.pbPhoto)
        Me.Controls.Add(Me.lblRoll)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblID)
        Me.Name = "athleteProfile"
        Me.Size = New System.Drawing.Size(295, 353)
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblMedical As Label
    Friend WithEvents lblMedicalHeader As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblBestEvent As Label
    Friend WithEvents lblAgeGroup As Label
    Friend WithEvents lblStNo As Label
    Friend WithEvents lblSt As Label
    Friend WithEvents lblSb As Label
    Friend WithEvents lblPo As Label
    Friend WithEvents lblTeams As Label
    Friend WithEvents pbPhoto As PictureBox
    Friend WithEvents lblRoll As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents lblID As Label
End Class
