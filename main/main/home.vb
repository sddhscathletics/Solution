
Public Class home
    Dim out As Boolean = False
    Dim cDrop As Boolean = False
    Dim jun As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles scrollBtn.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If out = False Then
            bigbtngroup.Left = bigbtngroup.Left + 20
            Sidebar.Left = Sidebar.Left + 20
            If Sidebar.Left = 0 Then
                out = True
                Timer1.Enabled = False
            End If
        ElseIf out = True Then
            Sidebar.Left = Sidebar.Left - 20
            bigbtngroup.Left = bigbtngroup.Left - 20
            If Sidebar.Left = -200 Then
                out = False
                Timer1.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub calendarBtn_Click(sender As Object, e As EventArgs) Handles calendarBtn.Click, sidecalendarBtn.Click
        calendar.Show()
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Close()
    End Sub

    Private Sub resultBtn_Click(sender As Object, e As EventArgs) Handles resultBtn.Click, sideresultsBtn.Click
        Results.Show()
        Me.Hide()
    End Sub

    Private Sub calDrop_Click(sender As Object, e As EventArgs) Handles calDrop.Click
        If cDrop = False Then
            cDrop = True
            sidebartime.Enabled = True
        End If

    End Sub

    Private Sub sidebartime_Tick(sender As Object, e As EventArgs) Handles sidebartime.Tick
        If cDrop = True Then
            sideresultsBtn.Top += 10
            sideAthletesBtn.Top += 10
            sideadminBtn.Top += 10
            resdr
        End If
    End Sub
End Class
