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
        Me.pbAttach = New System.Windows.Forms.PictureBox()
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
        Me.gbResults.Size = New System.Drawing.Size(305, 98)
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
        Me.pnlAttach.Location = New System.Drawing.Point(389, 41)
        Me.pnlAttach.Name = "pnlAttach"
        Me.pnlAttach.Size = New System.Drawing.Size(305, 56)
        Me.pnlAttach.TabIndex = 44
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
        'eventResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 373)
        Me.Controls.Add(Me.pnlAttach)
        Me.Controls.Add(Me.gbResults)
        Me.Controls.Add(Me.gbNotes)
        Me.Name = "eventResults"
        Me.Text = "Form1"
        Me.gbNotes.ResumeLayout(False)
        Me.gbNotes.PerformLayout()
        Me.pnlAttach.ResumeLayout(False)
        CType(Me.pbAttach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbNotes As GroupBox
    Friend WithEvents chbAllNotes As CheckBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents cmbGroup As ComboBox
    Friend WithEvents flpAthletes As FlowLayoutPanel
    Friend WithEvents gbResults As GroupBox
    Friend WithEvents pnlAttach As Panel
    Friend WithEvents pbAttach As PictureBox
End Class
