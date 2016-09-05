<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class eventResults
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
        Me.gbNotes = New System.Windows.Forms.GroupBox()
        Me.chbAllNotes = New System.Windows.Forms.CheckBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.flpAthletes = New System.Windows.Forms.FlowLayoutPanel()
        Me.gbResults = New System.Windows.Forms.GroupBox()
        Me.pnlAttach = New System.Windows.Forms.Panel()
        Me.pbAttach = New System.Windows.Forms.PictureBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSaveEvent = New System.Windows.Forms.Button()
        Me.rchTxt = New System.Windows.Forms.RichTextBox()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.chbAllAbsent = New System.Windows.Forms.CheckBox()
        Me.gbNotes.SuspendLayout()
        Me.pnlAttach.SuspendLayout()
        CType(Me.pbAttach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbNotes
        '
        Me.gbNotes.Controls.Add(Me.chbAllAbsent)
        Me.gbNotes.Controls.Add(Me.chbAllNotes)
        Me.gbNotes.Controls.Add(Me.btnSelect)
        Me.gbNotes.Controls.Add(Me.cmbGroup)
        Me.gbNotes.Controls.Add(Me.flpAthletes)
        Me.gbNotes.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNotes.Location = New System.Drawing.Point(12, 12)
        Me.gbNotes.Name = "gbNotes"
        Me.gbNotes.Size = New System.Drawing.Size(385, 349)
        Me.gbNotes.TabIndex = 61
        Me.gbNotes.TabStop = False
        Me.gbNotes.Text = "NOTES"
        '
        'chbAllNotes
        '
        Me.chbAllNotes.AutoSize = True
        Me.chbAllNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbAllNotes.Location = New System.Drawing.Point(96, 25)
        Me.chbAllNotes.Name = "chbAllNotes"
        Me.chbAllNotes.Size = New System.Drawing.Size(85, 17)
        Me.chbAllNotes.TabIndex = 62
        Me.chbAllNotes.Text = "ALL NOTES"
        Me.chbAllNotes.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(320, 23)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(61, 23)
        Me.btnSelect.TabIndex = 61
        Me.btnSelect.Text = "SELECT"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'cmbGroup
        '
        Me.cmbGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Items.AddRange(New Object() {"U13", "U14", "U15", "U16", "U17", "Opens"})
        Me.cmbGroup.Location = New System.Drawing.Point(180, 23)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(136, 21)
        Me.cmbGroup.TabIndex = 46
        Me.cmbGroup.Tag = "template"
        '
        'flpAthletes
        '
        Me.flpAthletes.AutoScroll = True
        Me.flpAthletes.BackColor = System.Drawing.SystemColors.Control
        Me.flpAthletes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpAthletes.Location = New System.Drawing.Point(5, 48)
        Me.flpAthletes.Name = "flpAthletes"
        Me.flpAthletes.Size = New System.Drawing.Size(376, 295)
        Me.flpAthletes.TabIndex = 45
        Me.flpAthletes.WrapContents = False
        '
        'gbResults
        '
        Me.gbResults.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbResults.Location = New System.Drawing.Point(403, 12)
        Me.gbResults.Name = "gbResults"
        Me.gbResults.Size = New System.Drawing.Size(305, 82)
        Me.gbResults.TabIndex = 62
        Me.gbResults.TabStop = False
        Me.gbResults.Text = "RESULTS"
        '
        'pnlAttach
        '
        Me.pnlAttach.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlAttach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAttach.Controls.Add(Me.pbAttach)
        Me.pnlAttach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlAttach.Location = New System.Drawing.Point(403, 34)
        Me.pnlAttach.Name = "pnlAttach"
        Me.pnlAttach.Size = New System.Drawing.Size(305, 56)
        Me.pnlAttach.TabIndex = 44
        '
        'pbAttach
        '
        Me.pbAttach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAttach.Image = Global.main.My.Resources.Resources.transparent_plus
        Me.pbAttach.Location = New System.Drawing.Point(114, 0)
        Me.pbAttach.Name = "pbAttach"
        Me.pbAttach.Size = New System.Drawing.Size(74, 56)
        Me.pbAttach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAttach.TabIndex = 42
        Me.pbAttach.TabStop = False
        Me.pbAttach.Tag = "add"
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(473, 211)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(164, 13)
        Me.lblNotes.TabIndex = 0
        Me.lblNotes.Text = "No notes requested for this event"
        Me.lblNotes.Visible = False
        '
        'ofdOpen
        '
        Me.ofdOpen.FileName = "OpenFileDialog1"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(581, 330)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 34)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSaveEvent
        '
        Me.btnSaveEvent.Location = New System.Drawing.Point(448, 330)
        Me.btnSaveEvent.Name = "btnSaveEvent"
        Me.btnSaveEvent.Size = New System.Drawing.Size(86, 34)
        Me.btnSaveEvent.TabIndex = 43
        Me.btnSaveEvent.Text = "SAVE"
        Me.btnSaveEvent.UseVisualStyleBackColor = True
        '
        'rchTxt
        '
        Me.rchTxt.Enabled = False
        Me.rchTxt.Location = New System.Drawing.Point(403, 119)
        Me.rchTxt.Name = "rchTxt"
        Me.rchTxt.Size = New System.Drawing.Size(305, 208)
        Me.rchTxt.TabIndex = 63
        Me.rchTxt.Tag = "empty"
        Me.rchTxt.Text = ""
        '
        'lblEdit
        '
        Me.lblEdit.AutoSize = True
        Me.lblEdit.Enabled = False
        Me.lblEdit.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.Location = New System.Drawing.Point(403, 94)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(87, 23)
        Me.lblEdit.TabIndex = 64
        Me.lblEdit.Text = "EDITOR"
        '
        'chbAllAbsent
        '
        Me.chbAllAbsent.AutoSize = True
        Me.chbAllAbsent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbAllAbsent.Location = New System.Drawing.Point(6, 25)
        Me.chbAllAbsent.Name = "chbAllAbsent"
        Me.chbAllAbsent.Size = New System.Drawing.Size(91, 17)
        Me.chbAllAbsent.TabIndex = 63
        Me.chbAllAbsent.Text = "ALL ABSENT"
        Me.chbAllAbsent.UseVisualStyleBackColor = True
        '
        'eventResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(715, 373)
        Me.Controls.Add(Me.lblEdit)
        Me.Controls.Add(Me.rchTxt)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.btnSaveEvent)
        Me.Controls.Add(Me.pnlAttach)
        Me.Controls.Add(Me.gbResults)
        Me.Controls.Add(Me.gbNotes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "eventResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Event Results"
        Me.gbNotes.ResumeLayout(False)
        Me.gbNotes.PerformLayout()
        Me.pnlAttach.ResumeLayout(False)
        CType(Me.pbAttach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbNotes As GroupBox
    Friend WithEvents chbAllNotes As CheckBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents cmbGroup As ComboBox
    Friend WithEvents flpAthletes As FlowLayoutPanel
    Friend WithEvents gbResults As GroupBox
    Friend WithEvents pnlAttach As Panel
    Friend WithEvents pbAttach As PictureBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents ofdOpen As OpenFileDialog
    Friend WithEvents rchTxt As RichTextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSaveEvent As Button
    Friend WithEvents lblEdit As Label
    Friend WithEvents sfdSave As SaveFileDialog
    Friend WithEvents chbAllAbsent As CheckBox
End Class
