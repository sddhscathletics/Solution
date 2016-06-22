
Public Class home
    Dim out As Boolean = False
    Dim cDrop As Boolean = False
    Dim cDown As Boolean = False
    Dim atDrop As Boolean = False
    Dim atDown As Boolean = False
    Dim adDrop As Boolean = False
    Dim adDown As Boolean = False
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

<<<<<<< HEAD
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
        ' DO SQL STUFF
        If cDrop = False Then
            cDrop = True
            If cDown = False Then
                cDown = True
            Else
                If cDown = True Then
                    cDown = False
                End If
            End If
            sidebartime.Enabled = True
        End If

    End Sub

    Private Sub sidebartime_Tick(sender As Object, e As EventArgs) Handles sidebartime.Tick
        If cDrop = True Then
            If cDown = True Then
                sideresultsBtn.Top += 10
                sideAthletesBtn.Top += 10
                sideadminBtn.Top += 10
                resDrop.Top += 10
                athDrop.Top += 10
                admDrop.Top += 10
                sideCalSub1.Top += 10
                sideCalSub2.Top += 10
            End If
            If cDown = False Then
                sideresultsBtn.Top -= 10
                sideAthletesBtn.Top -= 10
                sideadminBtn.Top -= 10
                resDrop.Top -= 10
                athDrop.Top -= 10
                admDrop.Top -= 10
                sideCalSub1.Top -= 10
                sideCalSub2.Top -= 10
            End If
            jun += 1
            If jun = 8 Then
                jun = 0
                cDrop = False
                sidebartime.Enabled = False
            End If
        End If
=======
    Private Sub bigbtngroup_Enter(sender As Object, e As EventArgs) Handles bigbtngroup.Enter

>>>>>>> origin/master
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        checkNotif.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        calendar.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub
End Class
