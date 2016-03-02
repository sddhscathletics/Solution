Public Class confirmAddition
    Private Sub confirmAddition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPeople.Text = "The following people have not been added to the list of attendees:" + vbNewLine + vbNewLine
        Console.WriteLine(selectAthletes.peopleNotAdded.Count)
        For Each person In selectAthletes.peopleNotAdded
            rchText.Text += CStr(person) + vbNewLine
        Next
        lblQuestion.Text = "Would you like to add these people to the list of attendees?"
    End Sub
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        changeDropDownSelection = False
        Me.Hide()
    End Sub
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        changeDropDownSelection = True
        Me.Hide()
    End Sub
End Class