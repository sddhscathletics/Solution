<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkNotif
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
        Me.dgdNotifs = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMarkRead = New System.Windows.Forms.Button()
        CType(Me.dgdNotifs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgdNotifs
        '
        Me.dgdNotifs.AllowUserToAddRows = False
        Me.dgdNotifs.AllowUserToDeleteRows = False
        Me.dgdNotifs.AllowUserToResizeRows = False
        Me.dgdNotifs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdNotifs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.lTime, Me.lDate, Me.username, Me.edit})
        Me.dgdNotifs.Location = New System.Drawing.Point(12, 9)
        Me.dgdNotifs.MultiSelect = False
        Me.dgdNotifs.Name = "dgdNotifs"
        Me.dgdNotifs.ReadOnly = True
        Me.dgdNotifs.Size = New System.Drawing.Size(445, 300)
        Me.dgdNotifs.TabIndex = 7
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'lTime
        '
        Me.lTime.HeaderText = "Time"
        Me.lTime.Name = "lTime"
        Me.lTime.ReadOnly = True
        '
        'lDate
        '
        Me.lDate.HeaderText = "Date"
        Me.lDate.Name = "lDate"
        Me.lDate.ReadOnly = True
        '
        'username
        '
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        '
        'edit
        '
        Me.edit.HeaderText = "Edit"
        Me.edit.Name = "edit"
        Me.edit.ReadOnly = True
        '
        'btnMarkRead
        '
        Me.btnMarkRead.Location = New System.Drawing.Point(12, 315)
        Me.btnMarkRead.Name = "btnMarkRead"
        Me.btnMarkRead.Size = New System.Drawing.Size(75, 23)
        Me.btnMarkRead.TabIndex = 8
        Me.btnMarkRead.Text = "Mark Read"
        Me.btnMarkRead.UseVisualStyleBackColor = True
        '
        'checkNotif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(469, 344)
        Me.Controls.Add(Me.btnMarkRead)
        Me.Controls.Add(Me.dgdNotifs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "checkNotif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notifications"
        CType(Me.dgdNotifs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgdNotifs As DataGridView
    Friend WithEvents btnMarkRead As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents lTime As DataGridViewTextBoxColumn
    Friend WithEvents lDate As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewTextBoxColumn
End Class
