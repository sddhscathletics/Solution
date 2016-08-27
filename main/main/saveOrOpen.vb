Public Class saveOrOpen
    Public Shared result As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        result = "save"
        Me.Close()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        result = "open"
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        result = "cancel"
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        result = "delete"
        Me.Close()
    End Sub
    Private Sub saveOrOpen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        result = "cancel"
        If Me.Tag = "results" Then
            btnSave.Text = "Save Edit"
            If eventResults.editMade = True Then
                btnSave.Enabled = True
            Else
                btnSave.Enabled = False
            End If
            btnOpen.Text = "Edit"
            Me.Tag = ""
        Else
            btnSave.Text = "Save"
            btnSave.Enabled = True
            btnOpen.Text = "Open"
        End If
    End Sub
End Class