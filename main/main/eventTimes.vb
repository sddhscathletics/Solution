Public Class eventTimes
    'created or not global variable to see if needs labels and dates when click pb
    'possibly dynamic tabs with vertical tab group
    Dim created200 As Boolean = False
    Dim selected As String = "100"
    Public Shared timesNotAdded As New List(Of String)
    Public Shared previousDropSelection As String
    Private Sub eventTimes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbEvent.SelectedIndex = 0
        previousDropSelection = cmbEvent.SelectedItem
        Dim tmpBox As New PictureBox
        tmpBox.Tag = "firstOpen"
        cmbEvent_SelectionChangeCommitted(tmpBox, Nothing)
    End Sub
    Private Sub cmbEvent_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbEvent.SelectionChangeCommitted
        If createEvent.times.Count > 0 And sender.Tag <> "firstOpen" Then
            For Each dtp As DateTimePicker In Me.Controls.OfType(Of DateTimePicker)()
                Dim hasMatch As Boolean = False
                Dim eventTime As String = previousDropSelection & " " & dtp.Tag & " " & dtp.Text 'string in the form: event age time
                For Each ageGroup In createEvent.times
                    Dim substring() = ageGroup.Split(" ")
                    substring(2) = substring(2) & " " & substring(3) 'adds the PM to the time element
                    If substring(0) = previousDropSelection And substring(1) = dtp.Tag Then 'checks if event and age match
                        'check if not match FOR ALL AGEGROUP
                        If substring(2) = dtp.Text Then 'checks if time is the same
                            hasMatch = True             'if they are the same, then the entry is already saved
                        End If
                    End If
                Next
                If hasMatch = False Then 'an entry for a certain agegroup has not been saved
                    Dim message As String = dtp.Text + " not saved for " + dtp.Tag + " " + previousDropSelection
                    timesNotAdded.Add(message)
                End If
                'If createEvent.times.Contains(eventTime) = False Then
            Next
            If timesNotAdded.Count > 0 Then
                confirmAddition.Tag = "times"
                confirmAddition.ShowDialog()
            Else
                previousDropSelection = cmbEvent.SelectedItem
            End If
        Else
            previousDropSelection = cmbEvent.SelectedItem
        End If
        For Each dtp As DateTimePicker In Me.Controls.OfType(Of DateTimePicker)()
            dtp.Text = "12:00:00 AM" 'sets all times to 12:00:00 AM, since the ones that have entries will be updated below
        Next
        For Each ageGroup In createEvent.times 'setting all event times to the relevant saved times
            Dim substring() = ageGroup.Split(" ")
            If substring(0) = cmbEvent.SelectedItem Then
                substring(2) = substring(2) & " " & substring(3)
                For Each dtp As DateTimePicker In Me.Controls.OfType(Of DateTimePicker)()
                    If substring(1) = dtp.Tag Then
                        dtp.Text = substring(2)
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub btnSaveTimes_Click(sender As Object, e As EventArgs) Handles btnSaveTimes.Click
        For Each dtp As DateTimePicker In Me.Controls.OfType(Of DateTimePicker)()
            Dim hasEntry As Boolean = False
            Dim eventTime As String = cmbEvent.SelectedItem & " " & dtp.Tag & " " & dtp.Text
            If createEvent.times.Count > 0 Then
                For ageGroup As Integer = 0 To createEvent.times.Count - 1
                    Dim substring() = createEvent.times(ageGroup).Split(" ")
                    substring(2) = substring(2) & " " & substring(3)
                    If substring(0) = cmbEvent.SelectedItem And substring(1) = dtp.Tag Then
                        hasEntry = True
                        If substring(2) <> dtp.Text Then
                            createEvent.times(ageGroup) = eventTime
                        End If
                    End If
                Next
                If hasEntry = False Then
                    createEvent.times.Add(eventTime)
                End If
            Else
                createEvent.times.Add(eventTime)
            End If
        Next
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class