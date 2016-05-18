Public Class checkNotif
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        checkAlert()
        txtAlertCount.Text = ToString(alertCount)
        For Each alert In alertList
            txtOutput.Text += (alert + vbCrLf)
        Next
    End Sub
End Class