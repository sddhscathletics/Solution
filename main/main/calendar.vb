﻿Public Class calendar
    Dim firstSelection As DateTime
    Dim selectionCount As Integer = 0
    Private Sub MonthCalendar1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        If selectionCount = 0 Then
            firstSelection = MonthCalendar1.SelectionStart
            selectionCount += 1
        Else
            If firstSelection = MonthCalendar1.SelectionStart Then
                createEvent.Show()
            End If
            selectionCount = 0
        End If
    End Sub
    Public Structure Meet
        Public name As String
        Public day As DateTime
        Public events As Array
        Public participants As Array
    End Structure
    Public Sub viewEvents(ByVal day As DateTime)
        createEvent.Show()
    End Sub
End Class