<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eventResults
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
        Me.gbNotes = New System.Windows.Forms.GroupBox()
        Me.chbAllNotes = New System.Windows.Forms.CheckBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.flpAthletes = New System.Windows.Forms.FlowLayoutPanel()
        Me.gbResults = New System.Windows.Forms.GroupBox()
        Me.pnlAttach = New System.Windows.Forms.Panel()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.pbAttach = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSaveEvent = New System.Windows.Forms.Button()
        Me.rchTxt = New System.Windows.Forms.RichTextBox()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.gbNotes.SuspendLayout()
        Me.pnlAttach.SuspendLayout()
        CType(Me.pbAttach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbNotes
        '
        Me.gbNotes.Controls.Add(Me.chbAllNotes)
        Me.gbNotes.Controls.Add(Me.btnSelect)
        Me.gbNotes.Controls.Add(Me.cmbGroup)
        Me.gbNotes.Controls.Add(Me.flpAthletes)
        Me.gbNotes.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNotes.Location = New System.Drawing.Point(12, 12)
        Me.gbNotes.Name = "gbNotes"
        Me.gbNotes.Size = New System.Drawing.Size(371, 349)
        Me.gbNotes.TabIndex = 61
        Me.gbNotes.TabStop = False
        Me.gbNotes.Text = "Notes"
        '
        'chbAllNotes
        '
        Me.chbAllNotes.AutoSize = True
        Me.chbAllNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbAllNotes.Location = New System.Drawing.Point(33, 25)
        Me.chbAllNotes.Name = "chbAllNotes"
        Me.chbAllNotes.Size = New System.Drawing.Size(68, 17)
        Me.chbAllNotes.TabIndex = 62
        Me.chbAllNotes.Text = "All Notes"
        Me.chbAllNotes.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(267, 23)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 61
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'cmbGroup
        '
        Me.cmbGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Items.AddRange(New Object() {"U13", "U14", "U15", "U16", "U17", "Opens"})
        Me.cmbGroup.Location = New System.Drawing.Point(107, 23)
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
        Me.flpAthletes.Location = New System.Drawing.Point(0, 48)
        Me.flpAthletes.Name = "flpAthletes"
        Me.flpAthletes.Size = New System.Drawing.Size(371, 295)
        Me.flpAthletes.TabIndex = 45
        Me.flpAthletes.WrapContents = False
        '
        'gbResults
        '
        Me.gbResults.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbResults.Location = New System.Drawing.Point(389, 12)
        Me.gbResults.Name = "gbResults"
        Me.gbResults.Size = New System.Drawing.Size(305, 82)
        Me.gbResults.TabIndex = 62
        Me.gbResults.TabStop = False
        Me.gbResults.Text = "Results"
        '
        'pnlAttach
        '
        Me.pnlAttach.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlAttach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAttach.Controls.Add(Me.pbAttach)
        Me.pnlAttach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlAttach.Location = New System.Drawing.Point(389, 34)
        Me.pnlAttach.Name = "pnlAttach"
        Me.pnlAttach.Size = New System.Drawing.Size(305, 56)
        Me.pnlAttach.TabIndex = 44
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(459, 211)
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
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(567, 330)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 34)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSaveEvent
        '
        Me.btnSaveEvent.Location = New System.Drawing.Point(434, 330)
        Me.btnSaveEvent.Name = "btnSaveEvent"
        Me.btnSaveEvent.Size = New System.Drawing.Size(86, 34)
        Me.btnSaveEvent.TabIndex = 43
        Me.btnSaveEvent.Text = "Save"
        Me.btnSaveEvent.UseVisualStyleBackColor = True
        '
        'rchTxt
        '
        Me.rchTxt.Enabled = False
        Me.rchTxt.Location = New System.Drawing.Point(389, 119)
        Me.rchTxt.Name = "rchTxt"
        Me.rchTxt.Size = New System.Drawing.Size(305, 208)
        Me.rchTxt.TabIndex = 63
        Me.rchTxt.Text = ""
        '
        'lblEdit
        '
        Me.lblEdit.AutoSize = True
        Me.lblEdit.Enabled = False
        Me.lblEdit.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.Location = New System.Drawing.Point(389, 94)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(65, 24)
        Me.lblEdit.TabIndex = 64
        Me.lblEdit.Text = "Editor"
        '
        'eventResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 373)
        Me.Controls.Add(Me.lblEdit)
        Me.Controls.Add(Me.rchTxt)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.btnSaveEvent)
        Me.Controls.Add(Me.pnlAttach)
        Me.Controls.Add(Me.gbResults)
        Me.Controls.Add(Me.gbNotes)
        Me.Name = "eventResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = ""
        Me.Text = "Form1"
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
End Class
