Public Class confirmAddition
    Private Sub confirmAddition_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'doesnt execute twice????
        lblTop.Text = "The following people have attendance discrepancies that need to be resolved:" + vbNewLine + vbNewLine
        Console.WriteLine(selectAthletes.peopleNotAdded.Count)
        For Each person In selectAthletes.peopleNotAdded
            rchText.Text += CStr(person) + vbNewLine
        Next
        lblBottom.Text = "Would you like to fix the discrepancies?"
    End Sub
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Dim substring() As String = selectAthletes.peopleNotAdded(0).Split(":")
        selectAthletes.stopDropDownChange(substring(0))
        For person As Integer = 0 To selectAthletes.peopleNotAdded.Count - 1
            'MessageBox.Show("orig: " + selectAthletes.peopleNotAdded(person) + " split: " + selectAthletes.peopleNotAdded((person)).Split(":")(0))
            If person = selectAthletes.peopleNotAdded.Count - 1 Then
                shownNotAdded = True
            End If
            selectAthletes.tickAthletes(selectAthletes.peopleNotAdded(person).Split(":")(0))
        Next
        Me.Close()
    End Sub
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Dim added As New List(Of String)
        Dim removed As New List(Of String)
        For person As Integer = 0 To selectAthletes.peopleNotAdded.Count - 1
            If selectAthletes.peopleNotAdded(person).Contains("Currently not saved as attending") Then
                createEvent.attendees.Add(selectAthletes.peopleNotAdded(person).Split(":")(0))
                added.add(selectAthletes.getName(selectAthletes.peopleNotAdded(person).Split(":")(0)))
            Else
                createEvent.attendees.Remove(selectAthletes.peopleNotAdded(person).Split(":")(0))
                removed.add(selectAthletes.getName(selectAthletes.peopleNotAdded(person).Split(":")(0)))
            End If
        Next
        lblTop.Text = "The following changes were made:" + vbNewLine + vbNewLine
        rchText.Text = ""
        For Each person In added
            rchText.Text += CStr(person) + " was added" + vbNewLine
        Next
        For Each person In removed
            rchText.Text += CStr(person) + " was removed" + vbNewLine
        Next
        lblBottom.Text = ""
        btnYes.Hide()
        btnNo.Hide()
        btnOkay.Show()
        shownNotAdded = True
        selectAthletes.checkShownNotAdded()
    End Sub
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Me.Close()
    End Sub
End Class