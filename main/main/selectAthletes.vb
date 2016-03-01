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
                If createEvent.attendees.Contains(i) = False Then
                    MessageBox.Show(i)
                    createEvent.attendees.Add(i)
                End If
            Next
            Me.Hide()
        Else
            MessageBox.Show("You have not selected anyone.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
    Public Shared Function findSingleAgeGroup(ByVal idNum As Integer)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT AgeGroup FROM athleteDb WHERE ID = @idNumber", conn) '*takes the column with correct rows
                cmd.Parameters.Add(New OleDbParameter("@idNumber", idNum))
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim newPerson As String = dr("FirstName") + " " + dr(1)
                            'retrieve agegroup and use to display in selectAtheltes
                        Loop
                    End If
                End Using
            End Using
        End Using
        'Return
    End Function
    Public Shared Function findWholeAgeGroup(ByVal ageGroup As String)
        Dim ageAthletes As New List(Of String)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, FirstName, LastName FROM athleteDb WHERE AgeGroup = @age", conn) '*takes the column with correct rows
                cmd.Parameters.Add(New OleDbParameter("@age", ageGroup))
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim newPerson As String = dr("ID") & ": " & dr("FirstName") & " " & dr(1)
                            ageAthletes.Add(newPerson)
                        Loop
                    End If
                End Using
            End Using
        End Using
        Return ageAthletes.ToArray()
    End Function
    Dim savedU13 As String() = New String() {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j"}
    Dim savedU14
    Private Sub cmbGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroup.SelectedIndexChanged
        For Each person In clbAthletes.CheckedItems

        Next
        clbAthletes.Items.Clear()
        Select Case cmbGroup.SelectedItem
            Case "U13" : clbAthletes.Items.AddRange(findWholeAgeGroup("U13"))
            Case "U14" : clbAthletes.Items.AddRange(findWholeAgeGroup("U14"))
            Case "U15" : clbAthletes.Items.AddRange(findWholeAgeGroup("U15"))
            Case "U16" : clbAthletes.Items.AddRange(findWholeAgeGroup("U16"))
            Case "U17" : clbAthletes.Items.AddRange(findWholeAgeGroup("U17"))
            Case "Opens" : clbAthletes.Items.AddRange(findWholeAgeGroup("Opens"))
        End Select
    End Sub
    Private Sub selectAthletes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbGroup.SelectedIndex = 0
    End Sub
End Class