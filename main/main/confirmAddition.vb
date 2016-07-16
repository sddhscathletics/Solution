Public Class confirmAddition
    Private Sub confirmAddition_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'doesnt execute twice????
        rchText.Text = ""
        Select Case Me.Tag
            Case "people"
                lblTop.Text = "The following people have attendance discrepancies that need to be resolved:" + vbNewLine + vbNewLine
                For Each person In createEvent.peopleNotAdded
                    rchText.Text += CStr(person) + vbNewLine
                Next
            Case "times"
                lblTop.Text = "The following events have time discrepancies that need to be resolved:" + vbNewLine + vbNewLine
                For Each person In createEvent.timesNotAdded
                    rchText.Text += CStr(person) + vbNewLine
                Next
        End Select
        lblBottom.Text = "Would you like to fix the discrepancies?"
    End Sub
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        If Me.Tag = "people" Then
            'Dim substring() As String = createEvent.peopleNotAdded(0).Split(":")
            'createEvent.stopDropDownChange(substring(0))
            For person As Integer = 0 To createEvent.peopleNotAdded.Count - 1
                If person = createEvent.peopleNotAdded.Count - 1 Then
                    shownNotAdded = True
                End If
                'createEvent.tickAthletes(createEvent.peopleNotAdded(person).Split(":")(0))
            Next
        Else
            'eventTimes.cmbEvent.SelectedItem = eventTimes.previousDropSelection
            shownNotAdded = True
        End If
        createEvent.checkShownNotAdded()
        Me.Close()
    End Sub
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Dim added As New List(Of String)
        Dim removed As New List(Of String)
        If Me.Tag = "people" Then
            For person As Integer = 0 To createEvent.peopleNotAdded.Count - 1
                If createEvent.peopleNotAdded(person).Contains("currently not saved as attending") Then
                    Dim name As String = createEvent.peopleNotAdded(person).Split(" ")(0) + " " + createEvent.peopleNotAdded(person).Split(" ")(1)
                    createEvent.attendees.Add(createEvent.getIdByName(name))
                    added.Add(name)
                Else
                    createEvent.attendees.Remove(createEvent.getIdByName(Name))
                    removed.Add(Name)
                End If
            Next
        Else
            For time As Integer = 0 To createEvent.timesNotAdded.Count - 1
                Dim substring As String() = createEvent.timesNotAdded(time).Split(" ")
                Dim eventTime As String = substring(6) & " " & substring(5) & " " & substring(0) 'event age time
                createEvent.times.Add(eventTime)
                added.Add(eventTime)
            Next
        End If
        lblTop.Text = "The following changes were made:" + vbNewLine + vbNewLine
        rchText.Text = ""
        If Me.Tag = "people" Then
            For Each person In added
                rchText.Text += CStr(person) + " was added" + vbNewLine
            Next
        Else
            For Each time In added
                Dim substring As String() = time.Split(" ")
                rchText.Text += substring(2) + " was added for " + substring(1) + " " + substring(0) + vbNewLine
            Next
        End If
        For Each person In removed
            rchText.Text += CStr(person) + " was removed" + vbNewLine
        Next
        lblBottom.Text = ""
        btnYes.Hide()
        btnNo.Hide()
        btnOkay.Show()
        shownNotAdded = True
        createEvent.checkShownNotAdded()
    End Sub
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Me.Close()
    End Sub
End Class