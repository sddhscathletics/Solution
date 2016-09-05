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
            Case "results"
                lblTop.Text = "The following people have attendance or note discrepancies that need to be resolved:" + vbNewLine + vbNewLine
                For Each person In eventResults.notesNotAdded
                    rchText.Text += CStr(person) + vbNewLine
                Next
        End Select
        lblBottom.Text = "Would you like to fix the discrepancies?"
    End Sub
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        shownNotAdded = True
        If Me.Tag = "people" Then
            createEvent.checkShownNotAdded()
        End If
        Me.Close()
    End Sub
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Dim addedPeople As New List(Of String)
        Dim removedPeople As New List(Of String)
        Dim addedNotes As New List(Of String)
        Dim removedNotes As New List(Of String)
        Dim addedResults As New List(Of String)
        Dim removedResults As New List(Of String)
        Dim addedAbsence As New List(Of String)
        Dim removedAbsence As New List(Of String)
        If Me.Tag = "people" Then
            For person As Integer = 0 To createEvent.peopleNotAdded.Count - 1
                If createEvent.peopleNotAdded(person).Contains("currently not saved as attending") Then
                    Dim name() As String = createEvent.peopleNotAdded(person).Split(" ")
                    Dim fullName = name.ToList()
                    fullName.RemoveRange(fullName.IndexOf("currently"), fullName.Count - fullName.IndexOf("currently"))
                    createEvent.attendees.Add(createEvent.getIdByName(String.Join(" ", fullName)))
                    addedPeople.Add(String.Join(" ", fullName))
                ElseIf createEvent.peopleNotAdded(person).Contains("currently not saved as needing a note") Then
                    Dim name() As String = createEvent.peopleNotAdded(person).Split(" ")
                    Dim fullName = name.ToList()
                    fullName.RemoveRange(fullName.IndexOf("currently"), fullName.Count - fullName.IndexOf("currently"))
                    createEvent.notes.Add(createEvent.getIdByName(String.Join(" ", fullName)))
                    addedNotes.Add(String.Join(" ", fullName))
                ElseIf createEvent.peopleNotAdded(person).Contains("currently incorrectly saved as needing a note") Then
                    Dim name() As String = createEvent.peopleNotAdded(person).Split(" ")
                    Dim fullName = name.ToList()
                    fullName.RemoveRange(fullName.IndexOf("currently"), fullName.Count - fullName.IndexOf("currently"))
                    createEvent.notes.Remove(createEvent.getIdByName(String.Join(" ", fullName)))
                    removedNotes.Add(String.Join(" ", fullName))
                Else
                    Dim name() As String = createEvent.peopleNotAdded(person).Split(" ")
                    Dim fullName = name.ToList()
                    fullName.RemoveRange(fullName.IndexOf("currently"), fullName.Count - fullName.IndexOf("currently"))
                    createEvent.attendees.Remove(createEvent.getIdByName(String.Join(" ", fullName)))
                    removedPeople.Add(String.Join(" ", fullName))
                End If
            Next
        ElseIf Me.Tag = "results" Then
            For note As Integer = 0 To eventResults.notesNotAdded.Count - 1
                If eventResults.notesNotAdded(note).Contains("currently not saved as having submitted a note") Then
                    Dim name() As String = eventResults.notesNotAdded(note).Split(" ")
                    Dim fullName = name.ToList()
                    fullName.RemoveRange(fullName.IndexOf("currently"), fullName.Count - fullName.IndexOf("currently"))
                    eventResults.newNotes.Add(createEvent.getIdByName(String.Join(" ", fullName)))
                    addedResults.Add(String.Join(" ", fullName))
                ElseIf eventResults.notesNotAdded(note).Contains("currently not saved as being absent") Then
                    Dim name() As String = eventResults.notesNotAdded(note).Split(" ")
                    Dim fullName = name.ToList()
                    fullName.RemoveRange(fullName.IndexOf("currently"), fullName.Count - fullName.IndexOf("currently"))
                    eventResults.newAbsences.Add(createEvent.getIdByName(String.Join(" ", fullName)))
                    addedAbsence.Add(String.Join(" ", fullName))
                ElseIf eventResults.notesNotAdded(note).Contains("currently incorrectly saved as being present") Then
                    Dim name() As String = eventResults.notesNotAdded(note).Split(" ")
                    Dim fullName = name.ToList()
                    fullName.RemoveRange(fullName.IndexOf("currently"), fullName.Count - fullName.IndexOf("currently"))
                    eventResults.newAbsences.Remove(createEvent.getIdByName(String.Join(" ", fullName)))
                    removedAbsence.Add(String.Join(" ", fullName))
                Else
                    Dim name() As String = eventResults.notesNotAdded(note).Split(" ")
                    Dim fullName = name.ToList()
                    fullName.RemoveRange(fullName.IndexOf("currently"), fullName.Count - fullName.IndexOf("currently"))
                    eventResults.newNotes.Remove(createEvent.getIdByName(String.Join(" ", fullName)))
                    removedResults.Add(String.Join(" ", fullName))
                End If
            Next
        Else
            For time As Integer = 0 To createEvent.timesNotAdded.Count - 1
                Dim substring As String() = createEvent.timesNotAdded(time).Split(" ")
                Dim eventTime As String = substring(6) & " " & substring(5) & " " & substring(0) 'event age time
                createEvent.times.Add(eventTime)
                addedPeople.Add(eventTime)
            Next
        End If
        lblTop.Text = "The following changes were made:" + vbNewLine + vbNewLine
        rchText.Text = ""
        If Me.Tag = "people" Then
            For Each person In addedPeople
                rchText.Text += CStr(person) + " was added" + vbNewLine
            Next
            For Each note In addedNotes
                rchText.Text += CStr(note) + " is now saved as needing a note" + vbNewLine
            Next
            For Each person In removedPeople
                rchText.Text += CStr(person) + " was removed" + vbNewLine
            Next
            For Each note In removedNotes
                rchText.Text += CStr(note) + " is now saved as not needing a note" + vbNewLine
            Next
        ElseIf Me.Tag = "results" Then
            For Each note In addedResults
                rchText.Text += CStr(note) + " is now saved as having submitted a note" + vbNewLine
            Next
            For Each note In removedResults
                rchText.Text += CStr(note) + " is now saved as not having submitted a note" + vbNewLine
            Next
            For Each note In addedAbsence
                rchText.Text += CStr(note) + " is now saved as being absent" + vbNewLine
            Next
            For Each note In removedAbsence
                rchText.Text += CStr(note) + " is now saved as being present" + vbNewLine
            Next
        Else
            For Each time In addedPeople
                Dim substring As String() = time.Split(" ")
                rchText.Text += substring(2) + " was added for " + substring(1) + " " + substring(0) + vbNewLine
            Next
        End If
        lblBottom.Text = ""
        btnYes.Hide()
        btnNo.Hide()
        btnOkay.Show()
        shownNotAdded = True
        If Me.Tag = "people" Then
            createEvent.checkShownNotAdded()
        End If
    End Sub
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Me.Close()
    End Sub
End Class