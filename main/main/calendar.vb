Imports System.Data.OleDb
Public Class calendar
    Dim firstSelection As DateTime
    Dim selectionCount As Integer = 0
    Dim firstClickTime As Integer = 0
    Private Sub mnCalendar_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mnCalendar.DateSelected
        If selectionCount = 0 Then
            firstSelection = mnCalendar.SelectionStart
            selectionCount += 1
            firstClickTime = Environment.TickCount
            Dim ptLowerLeft = New Point(0, sender.Height)
            ptLowerLeft = sender.PointToScreen(ptLowerLeft)
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
    Private Sub calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT EventName, EventDate FROM Events", conn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()

                        Loop
                    End If
                End Using
            End Using
            conn.Close()
        End Using
    End Sub
End Class