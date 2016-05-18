Public Class checkNotif
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        checkAlert()
        txtAlertCount.Text = alertCount
        For Each alert In alertList
            txtOutput.Text += (alert + vbCrLf)
        Next
    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        newEdit(username, txtChangeType.Text, txtEdit.Text)
    End Sub
End Class