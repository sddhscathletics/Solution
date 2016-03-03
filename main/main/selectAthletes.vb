Imports System.Data.OleDb
Public Class selectAthletes
    Private Sub chbAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbAll.CheckedChanged
        If chbAll.Checked = True Then
            For i As Integer = 0 To clbAthletes.Items.Count - 1
                clbAthletes.SetItemChecked(i, True)
            Next
        Else
            For i As Integer = 0 To clbAthletes.Items.Count - 1
                clbAthletes.SetItemChecked(i, False)
            Next
        End If
    End Sub
    Dim changesSaved As Boolean = False
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If clbAthletes.CheckedItems.Count() > 0 Then
            For Each i In clbAthletes.CheckedItems
                Dim idNumber As String = ""
                If createEvent.attendees.Contains(i) = False Then
                    For Each letter In i
                        If IsNumeric(letter) Then
                            idNumber += letter
                        End If
                    Next
                    MessageBox.Show(idNumber)
                    createEvent.attendees.Add(idNumber)
                End If
            Next
        Else
            MessageBox.Show("You have not selected anyone.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
    Public Shared Function getName(ByVal idNum As Integer)
        Dim fullName As String = ""
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT FirstName, LastName FROM athleteDb WHERE ID = @idNumber", conn) '*takes the column with correct rows
                cmd.Parameters.Add(New OleDbParameter("@idNumber", idNum))
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            fullName += dr("FirstName") + " " + dr("LastName")
                        Loop
                    End If
                End Using
            End Using
        End Using
        Return fullName
    End Function
    Public Shared Function findSingleAgeGroup(ByVal idNum As Integer)
        Dim ageGroup As String = ""
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT AgeGroup FROM athleteDb WHERE ID = @idNumber", conn) '*takes the column with correct rows
                cmd.Parameters.Add(New OleDbParameter("@idNumber", idNum))
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            ageGroup += dr("AgeGroup")
                            'retrieve agegroup and use to display in selectAtheltes
                        Loop
                    End If
                End Using
            End Using
        End Using
        Return ageGroup
    End Function
    Public Shared Function getWholeAgeGroup(ByVal ageGroup As String)
        Dim ageAthletes As New List(Of String)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, FirstName, LastName FROM athleteDb WHERE AgeGroup = @age", conn) '*takes the column with correct rows
                cmd.Parameters.Add(New OleDbParameter("@age", ageGroup))
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim newPerson As String = dr("ID") & ": " & dr("FirstName") & " " & dr("LastName")
                            ageAthletes.Add(newPerson)
                        Loop
                    End If
                End Using
            End Using
        End Using
        Return ageAthletes.ToArray()
    End Function
    Dim savedU13 As String() = New String() {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j"}
    Public Shared peopleNotAdded As New List(Of String)
    Public Shared Sub stopDropDownChange(ByVal idNum As Integer)
        Select Case findSingleAgeGroup(idNum)
            Case "U13" : selectAthletes.cmbGroup.SelectedItem = "U13"
            Case "U14" : selectAthletes.cmbGroup.SelectedItem = "U14"
            Case "U15" : selectAthletes.cmbGroup.SelectedItem = "U15"
            Case "U16" : selectAthletes.cmbGroup.SelectedItem = "U16"
            Case "U17" : selectAthletes.cmbGroup.SelectedItem = "U17"
            Case "Opens" : selectAthletes.cmbGroup.SelectedItem = "Opens"
        End Select
        selectAthletes.cmbGroup_SelectionChangeCommitted(Nothing, Nothing)
    End Sub
    Public Shared Sub tickAthletes(ByVal idNum)
        For person As Integer = 0 To selectAthletes.clbAthletes.Items.Count - 1
            If selectAthletes.clbAthletes.Items.Item(person).Contains(idNum) Then
                selectAthletes.clbAthletes.SetItemChecked(person, True)
            End If
        Next
        selectAthletes.checkShownNotAdded()
        selectAthletes.checkAllChecked()
    End Sub
    Public Shared Sub checkShownNotAdded()
        If shownNotAdded = True Then
            peopleNotAdded.Clear()
        End If
    End Sub
    Public Shared Sub checkAllChecked()
        If selectAthletes.clbAthletes.CheckedItems.Count() <> selectAthletes.clbAthletes.Items.Count() Then
            selectAthletes.chbAll.Checked = False
        Else
            selectAthletes.chbAll.Checked = True
        End If
    End Sub
    Private Sub cmbGroup_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbGroup.SelectionChangeCommitted
        For Each person In clbAthletes.CheckedItems
            Dim idNumber As String = ""
            For Each letter In person
                If IsNumeric(letter) Then
                    idNumber += letter
                End If
            Next
            If createEvent.attendees.Contains(idNumber) = False Then
                peopleNotAdded.Add(person)
            End If
        Next
        If peopleNotAdded.Count > 0 Then
            shownNotAdded = False
            confirmAddition.Show()
        End If
        clbAthletes.Items.Clear()
        Select Case cmbGroup.SelectedItem
            Case "U13" : clbAthletes.Items.AddRange(getWholeAgeGroup("U13"))
            Case "U14" : clbAthletes.Items.AddRange(getWholeAgeGroup("U14"))
            Case "U15" : clbAthletes.Items.AddRange(getWholeAgeGroup("U15"))
            Case "U16" : clbAthletes.Items.AddRange(getWholeAgeGroup("U16"))
            Case "U17" : clbAthletes.Items.AddRange(getWholeAgeGroup("U17"))
            Case "Opens" : clbAthletes.Items.AddRange(getWholeAgeGroup("Opens"))
        End Select
        For Each athleteID In createEvent.attendees
            tickAthletes(athleteID)
        Next
        checkAllChecked()
    End Sub
    Private Sub selectAthletes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbGroup.SelectedIndex = 0
        cmbGroup_SelectionChangeCommitted(Nothing, Nothing)
    End Sub
    Private Sub clbAthletes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbAthletes.SelectedIndexChanged
        clbAthletes.SetItemChecked(clbAthletes.SelectedIndex, True)
    End Sub
End Class