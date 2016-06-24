Public Class checkNotif
    'Let's make this panels!
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
        If dgdNotifs.RowCount > 0 Then
            dgdNotifs.CurrentRow.Selected = True
        End If
    End Sub

    Private Sub btnMarkRead_Click(sender As Object, e As EventArgs) Handles btnMarkRead.Click
        If dgdNotifs.RowCount > 0 Then
            Dim ID As String = dgdNotifs.SelectedRows(0).Cells(0).Value.ToString
            markRead(ID)
            loadAlerts()
        End If
    End Sub
End Class