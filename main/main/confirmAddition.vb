Public Class confirmAddition
    Private Sub confirmAddition_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'doesnt execute twice????
        lblPeople.Text = "The following people have not been added to the list of attendees:" + vbNewLine + vbNewLine
        Console.WriteLine(selectAthletes.peopleNotAdded.Count)
        For Each person In selectAthletes.peopleNotAdded
            rchText.Text += CStr(person) + vbNewLine
        Next
        lblQuestion.Text = "Would you like to add these people to the list of attendees?"
    End Sub
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Dim substring() As String = selectAthletes.peopleNotAdded(0).Split(":")
        selectAthletes.stopDropDownChange(substring(0))
        For person As Integer = 0 To selectAthletes.peopleNotAdded.Count - 1
            MessageBox.Show("orig: " + selectAthletes.peopleNotAdded(person) + " split: " + selectAthletes.peopleNotAdded((person)).Split(":")(0))
            If person = selectAthletes.peopleNotAdded.Count - 1 Then
                shownNotAdded = True
            End If
            selectAthletes.tickAthletes(selectAthletes.peopleNotAdded(person).Split(":")(0))
        Next
        Me.Hide()
    End Sub
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.Hide()
        shownNotAdded = True
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        shownNotAdded = True
    End Sub
End Class