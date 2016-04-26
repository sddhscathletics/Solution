<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eventTimes
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
        Me.dtp15s = New System.Windows.Forms.DateTimePicker()
        Me.dtp14s = New System.Windows.Forms.DateTimePicker()
        Me.lbl15s = New System.Windows.Forms.Label()
        Me.lbl14s = New System.Windows.Forms.Label()
        Me.lbl13s = New System.Windows.Forms.Label()
        Me.dtp17s = New System.Windows.Forms.DateTimePicker()
        Me.dtp16s = New System.Windows.Forms.DateTimePicker()
        Me.lbl17s = New System.Windows.Forms.Label()
        Me.lbl16s = New System.Windows.Forms.Label()
        Me.dtpOpens = New System.Windows.Forms.DateTimePicker()
        Me.lblOpens = New System.Windows.Forms.Label()
        Me.dtp13s = New System.Windows.Forms.DateTimePicker()
        Me.cmbEvent = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtp15s
        '
        Me.dtp15s.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp15s.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp15s.Location = New System.Drawing.Point(188, 167)
        Me.dtp15s.Name = "dtp15s"
        Me.dtp15s.ShowUpDown = True
        Me.dtp15s.Size = New System.Drawing.Size(176, 28)
        Me.dtp15s.TabIndex = 33
        Me.dtp15s.Tag = "U15"
        '
        'dtp14s
        '
        Me.dtp14s.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp14s.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp14s.Location = New System.Drawing.Point(188, 113)
        Me.dtp14s.Name = "dtp14s"
        Me.dtp14s.ShowUpDown = True
        Me.dtp14s.Size = New System.Drawing.Size(176, 28)
        Me.dtp14s.TabIndex = 32
        Me.dtp14s.Tag = "U14"
        '
        'lbl15s
        '
        Me.lbl15s.AutoSize = True
        Me.lbl15s.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl15s.Location = New System.Drawing.Point(94, 167)
        Me.lbl15s.Name = "lbl15s"
        Me.lbl15s.Size = New System.Drawing.Size(47, 24)
        Me.lbl15s.TabIndex = 31
        Me.lbl15s.Text = "15's:"
        '
        'lbl14s
        '
        Me.lbl14s.AutoSize = True
        Me.lbl14s.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl14s.Location = New System.Drawing.Point(94, 115)
        Me.lbl14s.Name = "lbl14s"
        Me.lbl14s.Size = New System.Drawing.Size(47, 24)
        Me.lbl14s.TabIndex = 30
        Me.lbl14s.Text = "14's:"
        '
        'lbl13s
        '
        Me.lbl13s.AutoSize = True
        Me.lbl13s.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13s.Location = New System.Drawing.Point(94, 64)
        Me.lbl13s.Name = "lbl13s"
        Me.lbl13s.Size = New System.Drawing.Size(47, 24)
        Me.lbl13s.TabIndex = 29
        Me.lbl13s.Text = "13's:"
        '
        'dtp17s
        '
        Me.dtp17s.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp17s.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp17s.Location = New System.Drawing.Point(188, 275)
        Me.dtp17s.Name = "dtp17s"
        Me.dtp17s.ShowUpDown = True
        Me.dtp17s.Size = New System.Drawing.Size(176, 28)
        Me.dtp17s.TabIndex = 37
        Me.dtp17s.Tag = "U17"
        '
        'dtp16s
        '
        Me.dtp16s.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp16s.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp16s.Location = New System.Drawing.Point(188, 221)
        Me.dtp16s.Name = "dtp16s"
        Me.dtp16s.ShowUpDown = True
        Me.dtp16s.Size = New System.Drawing.Size(176, 28)
        Me.dtp16s.TabIndex = 36
        Me.dtp16s.Tag = "U16"
        '
        'lbl17s
        '
        Me.lbl17s.AutoSize = True
        Me.lbl17s.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl17s.Location = New System.Drawing.Point(94, 275)
        Me.lbl17s.Name = "lbl17s"
        Me.lbl17s.Size = New System.Drawing.Size(47, 24)
        Me.lbl17s.TabIndex = 35
        Me.lbl17s.Text = "17's:"
        '
        'lbl16s
        '
        Me.lbl16s.AutoSize = True
        Me.lbl16s.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl16s.Location = New System.Drawing.Point(94, 223)
        Me.lbl16s.Name = "lbl16s"
        Me.lbl16s.Size = New System.Drawing.Size(47, 24)
        Me.lbl16s.TabIndex = 34
        Me.lbl16s.Text = "16's:"
        '
        'dtpOpens
        '
        Me.dtpOpens.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOpens.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpOpens.Location = New System.Drawing.Point(188, 324)
        Me.dtpOpens.Name = "dtpOpens"
        Me.dtpOpens.ShowUpDown = True
        Me.dtpOpens.Size = New System.Drawing.Size(176, 28)
        Me.dtpOpens.TabIndex = 39
        Me.dtpOpens.Tag = "Opens"
        '
        'lblOpens
        '
        Me.lblOpens.AutoSize = True
        Me.lblOpens.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpens.Location = New System.Drawing.Point(94, 324)
        Me.lblOpens.Name = "lblOpens"
        Me.lblOpens.Size = New System.Drawing.Size(64, 24)
        Me.lblOpens.TabIndex = 38
        Me.lblOpens.Text = "Opens:"
        '
        'dtp13s
        '
        Me.dtp13s.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp13s.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp13s.Location = New System.Drawing.Point(188, 60)
        Me.dtp13s.Name = "dtp13s"
        Me.dtp13s.ShowUpDown = True
        Me.dtp13s.Size = New System.Drawing.Size(176, 28)
        Me.dtp13s.TabIndex = 40
        Me.dtp13s.Tag = "U13"
        '
        'cmbEvent
        '
        Me.cmbEvent.FormattingEnabled = True
        Me.cmbEvent.Items.AddRange(New Object() {"100m", "200m", "400m", "800m", "1.5k", "3k", "Hurdles", "High Jump", "Long Jump", "Shotput"})
        Me.cmbEvent.Location = New System.Drawing.Point(44, 12)
        Me.cmbEvent.Name = "cmbEvent"
        Me.cmbEvent.Size = New System.Drawing.Size(136, 21)
        Me.cmbEvent.TabIndex = 43
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(289, 373)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 42
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(78, 373)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 41
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'eventTimes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(474, 425)
        Me.Controls.Add(Me.cmbEvent)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtp13s)
        Me.Controls.Add(Me.dtpOpens)
        Me.Controls.Add(Me.lblOpens)
        Me.Controls.Add(Me.dtp17s)
        Me.Controls.Add(Me.dtp16s)
        Me.Controls.Add(Me.lbl17s)
        Me.Controls.Add(Me.lbl16s)
        Me.Controls.Add(Me.dtp15s)
        Me.Controls.Add(Me.dtp14s)
        Me.Controls.Add(Me.lbl15s)
        Me.Controls.Add(Me.lbl14s)
        Me.Controls.Add(Me.lbl13s)
        Me.Name = "eventTimes"
        Me.Text = "eventTimes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtp15s As DateTimePicker
    Friend WithEvents dtp14s As DateTimePicker
    Friend WithEvents lbl15s As Label
    Friend WithEvents lbl14s As Label
    Friend WithEvents lbl13s As Label
    Friend WithEvents dtp17s As DateTimePicker
    Friend WithEvents dtp16s As DateTimePicker
    Friend WithEvents lbl17s As Label
    Friend WithEvents lbl16s As Label
    Friend WithEvents dtpOpens As DateTimePicker
    Friend WithEvents lblOpens As Label
    Friend WithEvents dtp13s As DateTimePicker
    Friend WithEvents cmbEvent As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class
