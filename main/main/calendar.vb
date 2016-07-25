Imports System.Data.OleDb
Public Class calendar
    Dim firstSelection As DateTime
    Dim selectionCount As Integer = 0
    Dim firstClickTime As Integer = 0
    Dim eventInfo As New Dictionary(Of Date, List(Of String))
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
    Private Sub calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT EventName, EventDate FROM Events", conn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            mnCalendar.AddBoldedDate(CType(dr("EventDate"), Date)) '"#29/7/16#"
                            If eventInfo.ContainsKey(CType(dr("EventDate").ToString(), Date)) Then
                                Dim newList As List(Of String) = eventInfo(dr("EventDate").ToShortDateString())
                                newList.Add(dr("EventName").ToString())
                                eventInfo(dr("EventDate").ToString()) = newList
                            Else
                                eventInfo.Add(dr("EventDate").ToString(), New List(Of String)(New String() {dr("EventName").ToString()}))
                            End If
                        Loop
                    End If
                End Using
            End Using
            conn.Close()
        End Using
        mnCalendar.UpdateBoldedDates()
    End Sub
    Private Sub mnCalendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mnCalendar.DateChanged
        If mnCalendar.BoldedDates.Contains(e.Start.ToShortDateString()) Then
            cms.Show(Cursor.Position)
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        'Dim ptLowerLeft = New Point(0, sender.Height)
        'ptLowerLeft = sender.PointToScreen(ptLowerLeft)
        'Dim menu As New ContextMenuStrip
        'menu.Show(ptLowerLeft)

    End Sub
End Class