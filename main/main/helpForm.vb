Public Class helpForm

    Private Sub helpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If access = 1 Or access = 0 Then
            helpTab.TabPages.Remove(addEditTab)
        End If
        If helpIdentifier = "createEvent" Then
            helpTab.SelectedTab = calendarTab
        End If
        If helpIdentifier = "addEdit" Then
            helpTab.SelectedTab = addEditTab
        End If
        If helpIdentifier = "selectAthlete" Then
            helpTab.SelectedTab = selectAthletesTab
        End If
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class