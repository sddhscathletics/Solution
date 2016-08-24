Imports System.Data.OleDb
'Searching

Public Class newTeam
    Dim panelColor As Color = Color.CadetBlue
    Dim first As Boolean = True
    Dim listAthletes As New List(Of athlete)
    Dim listSelect As New List(Of String)

    Private Sub newTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sort()
    End Sub

    Private Sub populate(append As String)
        listAthletes.Clear()
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, RollClass, FirstName, LastName FROM athleteDb" + append, conn)
                'Need to add photo
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim ath As New athlete
                            ath.id = dr("ID")
                            ath.roll = dr("RollClass")
                            ath.fname = dr("FirstName")
                            ath.lname = dr("LastName")
                            listAthletes.Add(ath)
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub fillPanels()
        flpAthletes.Controls.Clear()
        For Each ath As athlete In listAthletes
            Dim newpanel As New Panel With
                {
                .Margin = New Padding(3, 3, 3, 3),
                .Height = 55,
                .Width = 140,
                .BackColor = panelColor,
                .Name = ath.id
                }

            Dim ID As New Label With
                {
                .Text = ath.id,
                .Font = New Font("Segoe UI", 9, FontStyle.Bold),
                .Height = 15,
                .Location = New Point(0, 0),
                .Name = ath.id + ".ID"
                }

            Dim roll As New Label With
                {
                .Text = ath.roll,
                .Font = New Font("Segoe UI", 8),
                .Height = 13,
                .Location = New Point(0, 15),
                .Name = ath.id.ToString + ".roll"
                }

            Dim lName As New Label With
                {
                .Text = ath.lname.ToUpper,
                .Font = New Font("Segoe UI", 8),
                .Height = 13,
                .Location = New Point(0, 28),
                .Name = ath.id.ToString + ".lName"
                }

            Dim fName As New Label With
                {
                .Text = ath.fname,
                .Font = New Font("Segoe UI", 8),
                .Height = 13,
                .Location = New Point(0, 41),
                .Name = ath.id.ToString + ".fName"
                }

            newpanel.Controls.Add(ID)
            newpanel.Controls.Add(roll)
            newpanel.Controls.Add(fName)
            newpanel.Controls.Add(lName)

            flpAthletes.Controls.Add(newpanel)
            AddHandler newpanel.MouseClick, AddressOf panelClicked
            AddHandler ID.MouseClick, AddressOf labelClicked
            AddHandler roll.MouseClick, AddressOf labelClicked
            AddHandler fName.MouseClick, AddressOf labelClicked
            AddHandler lName.MouseClick, AddressOf labelClicked
        Next
    End Sub

    Private Sub checkSelected()
        For Each pnl As Panel In flpAthletes.Controls 'Check for previously selected members
            If listSelect.Contains(pnl.Name) = True Then
                pnl.BackColor = Color.Green
            End If
        Next
    End Sub

    Private Sub panelClicked(sender As Object, e As EventArgs)
        Dim clicked As Panel = sender
        If clicked.BackColor = Color.Green Then
            clicked.BackColor = panelColor
            listSelect.Remove(clicked.Name)
        Else
            clicked.BackColor = Color.Green 'Highlight team for addition
            listSelect.Add(clicked.Name)
        End If
    End Sub

    Private Sub labelClicked(sender As Object, e As EventArgs)
        panelClicked(sender.Parent, e)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If txtTeamName.Text = "" Or cmbAgeGroup.SelectedItem = Nothing Or listSelect.Count <> 0 Then
            If MsgBox("You have unsaved changes. Continue?", MsgBoxStyle.YesNo, "Save Changes?") = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'Search in realtime
    End Sub

    Private Sub txtSearch_GotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus
        If first = True Then
            txtSearch.Text = ""
            first = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtTeamName.Text = "" Then 'Field checking (Absolutely disgusting field checking)
            MsgBox("Please enter a team name.")
        ElseIf cmbAgeGroup.SelectedItem = Nothing Then
            MsgBox("Please select an age group.")
        ElseIf listSelect.Count = 0 Then
            MsgBox("Please select members to add.")
        Else
            If MsgBox("You are creating a " + cmbAgeGroup.SelectedItem.ToString + " team with " + listSelect.Count.ToString + " members named " + txtTeamName.Text + ". Is this okay?", MsgBoxStyle.YesNo, "Confirm Team Creation") = MsgBoxResult.Yes Then
                Using conn As New OleDbConnection(dataPath + "\Athlete.accdb") 'Commits the team
                    conn.Open()
                    Using cmd As New OleDbCommand("INSERT INTO teamDb (Team, AgeGroup, Members) VALUES (@team, @AgeGroup, @Members)", conn) 'Appends the database with a new team
                        'Spool members list
                        Dim Members As String = ";" 'Leading separator character
                        For Each member As String In listSelect
                            Members += (member + ";")
                        Next
                        cmd.Parameters.AddWithValue("@Team", txtTeamName.Text)
                        cmd.Parameters.AddWithValue("@AgeGroup", cmbAgeGroup.SelectedItem.ToString)
                        cmd.Parameters.AddWithValue("@Members", Members)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                Me.Close()
            End If
        End If
    End Sub

    Private Sub cmbAgeGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAgeGroup.SelectedIndexChanged
        sort()
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        sort()
    End Sub

    Private Sub sort()
        Dim append As String = ""
        If cmbAgeGroup.SelectedItem <> Nothing Then
            append = " WHERE AgeGroup = '" + cmbAgeGroup.SelectedItem.ToString + "'" 'Filters by age group
        End If
        populate(append)
        If cmbFilter.SelectedItem <> Nothing Then
            Dim asc As Boolean = True
            Select Case cmbFilter.SelectedItem.ToString
                Case "ID"
                    listAthletes.Sort(Function(x, y) x.ID.CompareTo(y.ID))

                Case "First Name (Ascending)"
                    listAthletes.Sort(Function(x, y) x.fName.CompareTo(y.fName))

                Case "First Name (Descending)"
                    asc = False
                    listAthletes.Sort(Function(x, y) x.fName.CompareTo(y.fName))

                Case "Last Name (Ascending)"
                    listAthletes.Sort(Function(x, y) x.lName.CompareTo(y.lName))

                Case "Last Name (Descending)"
                    asc = False
                    listAthletes.Sort(Function(x, y) x.lName.CompareTo(y.lName))
            End Select
            If asc = False Then
                listAthletes.Reverse()
            End If
        End If
        fillPanels()
        checkSelected()
    End Sub
End Class