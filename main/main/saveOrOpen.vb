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
End Class