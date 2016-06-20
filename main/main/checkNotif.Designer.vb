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
        Me.txtAlertCount = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.txtChangeType = New System.Windows.Forms.TextBox()
        Me.txtEdit = New System.Windows.Forms.TextBox()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.dgdNotifs = New System.Windows.Forms.DataGridView()
        Me.btnMarkRead = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgdNotifs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAlertCount
        '
        Me.txtAlertCount.Location = New System.Drawing.Point(463, 9)
        Me.txtAlertCount.Name = "txtAlertCount"
        Me.txtAlertCount.ReadOnly = True
        Me.txtAlertCount.Size = New System.Drawing.Size(75, 20)
        Me.txtAlertCount.TabIndex = 0
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(463, 35)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'txtChangeType
        '
        Me.txtChangeType.Location = New System.Drawing.Point(463, 81)
        Me.txtChangeType.Name = "txtChangeType"
        Me.txtChangeType.Size = New System.Drawing.Size(100, 20)
        Me.txtChangeType.TabIndex = 3
        '
        'txtEdit
        '
        Me.txtEdit.Location = New System.Drawing.Point(463, 120)
        Me.txtEdit.Name = "txtEdit"
        Me.txtEdit.Size = New System.Drawing.Size(100, 20)
        Me.txtEdit.TabIndex = 5
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(463, 146)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(75, 23)
        Me.btnCommit.TabIndex = 6
        Me.btnCommit.Text = "Commit"
        Me.btnCommit.UseVisualStyleBackColor = True
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
        Me.dgdNotifs.Size = New System.Drawing.Size(445, 300)
        Me.dgdNotifs.TabIndex = 7
        '
        'btnMarkRead
        '
        Me.btnMarkRead.Location = New System.Drawing.Point(463, 175)
        Me.btnMarkRead.Name = "btnMarkRead"
        Me.btnMarkRead.Size = New System.Drawing.Size(75, 23)
        Me.btnMarkRead.TabIndex = 8
        Me.btnMarkRead.Text = "Mark Read"
        Me.btnMarkRead.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(463, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Edit Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(460, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Edit Made"
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
        'checkNotif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 409)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMarkRead)
        Me.Controls.Add(Me.dgdNotifs)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.txtEdit)
        Me.Controls.Add(Me.txtChangeType)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtAlertCount)
        Me.Name = "checkNotif"
        Me.Text = "checkNotif"
        CType(Me.dgdNotifs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAlertCount As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents txtChangeType As TextBox
    Friend WithEvents txtEdit As TextBox
    Friend WithEvents btnCommit As Button
    Friend WithEvents dgdNotifs As DataGridView
    Friend WithEvents btnMarkRead As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents lTime As DataGridViewTextBoxColumn
    Friend WithEvents lDate As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewTextBoxColumn
End Class
