Public Class calendar
    Dim firstSelection As DateTime
    Dim selectionCount As Integer = 0
    Dim firstClickTime As Integer = 0
    Private Sub mnCalendar_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mnCalendar.DateSelected
        If selectionCount = 0 Then
            firstSelection = mnCalendar.SelectionStart
            selectionCount += 1
            firstClickTime = Environment.TickCount
        Else
            If firstSelection = mnCalendar.SelectionStart Then
                Dim timeBetweenClicks = Environment.TickCount - firstClickTime
                If timeBetweenClicks <= SystemInformation.DoubleClickTime Then
                    Cursor.Current = Cursors.AppStarting
                    createEvent.Show()
                    Cursor.Current = Cursors.Default
                End If
            End If
            selectionCount = 0
        End If
    End Sub
End Class