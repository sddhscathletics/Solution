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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.txtChangeType = New System.Windows.Forms.TextBox()
        Me.txtEdit = New System.Windows.Forms.TextBox()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAlertCount
        '
        Me.txtAlertCount.Location = New System.Drawing.Point(363, 12)
        Me.txtAlertCount.Name = "txtAlertCount"
        Me.txtAlertCount.ReadOnly = True
        Me.txtAlertCount.Size = New System.Drawing.Size(75, 20)
        Me.txtAlertCount.TabIndex = 0
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 12)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(345, 385)
        Me.txtOutput.TabIndex = 1
        Me.txtOutput.TabStop = False
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(363, 38)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'txtChangeType
        '
        Me.txtChangeType.Location = New System.Drawing.Point(363, 84)
        Me.txtChangeType.Name = "txtChangeType"
        Me.txtChangeType.Size = New System.Drawing.Size(100, 20)
        Me.txtChangeType.TabIndex = 3
        '
        'txtEdit
        '
        Me.txtEdit.Location = New System.Drawing.Point(363, 110)
        Me.txtEdit.Name = "txtEdit"
        Me.txtEdit.Size = New System.Drawing.Size(100, 20)
        Me.txtEdit.TabIndex = 5
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(363, 136)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(75, 23)
        Me.btnCommit.TabIndex = 6
        Me.btnCommit.Text = "Commit"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'checkNotif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 409)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.txtEdit)
        Me.Controls.Add(Me.txtChangeType)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtAlertCount)
        Me.Name = "checkNotif"
        Me.Text = "checkNotif"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAlertCount As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents txtChangeType As TextBox
    Friend WithEvents txtEdit As TextBox
    Friend WithEvents btnCommit As Button
End Class
