Public Class checkNotif
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        loadAlerts()
    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        newEdit(txtChangeType.Text, txtEdit.Text)
    End Sub

    Private Sub dgdNotifs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdNotifs.CellClick
        dgdNotifs.CurrentRow.Selected = True
    End Sub

    Private Sub checkNotif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAlerts()
    End Sub

    Private Sub loadAlerts()
        dgdNotifs.Rows.Clear()
        checkAlert()
        txtAlertCount.Text = alertCount
        For Each notif As notif In alertList
            Me.dgdNotifs.Rows.Add(notif.ID, notif.ltime, notif.ldate, notif.username, notif.edit)
        Next
    End Sub

    Private Sub btnMarkRead_Click(sender As Object, e As EventArgs) Handles btnMarkRead.Click
        Dim ID As String = dgdNotifs.SelectedRows(0).Cells(0).ToString
        markRead(ID)
    End Sub
End Class