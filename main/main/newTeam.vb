Imports System.Data.OleDb

Public Class newTeam
    Public editor As Boolean = False
    Dim panelColor As Color = Color.CadetBlue
    Dim listAthletes As New List(Of athlete) 'Master list
    Dim listSorted As New List(Of athlete) 'Actual list displayed
    Dim listSearched As New List(Of athlete)
    Dim listSelected As New List(Of athlete) 'People selected

    Private Sub newTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listAthletes = populate(listAthletes) 'Populate with athletes
        If editor = True Then
            loadMembers()
            txtTeamName.Text = manageTeams.target.Name
            cmbAgeGroup.SelectedItem = manageTeams.target.Tag
        End If
        listSorted = listAthletes.FindAll(Function(x) x.ageGroup = cmbAgeGroup.SelectedItem)
        listSearched.AddRange(listSorted)
        fillPanels(flpSelected, "sel", listSelected)
        fillPanels(flpAthletes, "", listSorted)
    End Sub

    Private Sub loadMembers()
        Dim temp As String = ""
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT Members FROM teamDb WHERE Team = '" + manageTeams.target.Name + "'", conn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            For i = 1 To dr("Members").Length - 1
                                If dr("Members")(i) = ";" And temp.Length > 1 Then 'Check for the leading separator
                                    Using cmd2 As New OleDbCommand("SELECT RollClass, FirstName, LastName, AgeGroup FROM athleteDb WHERE ID = " + temp, conn) 'Load athlete details
                                        Using dr2 = cmd2.ExecuteReader()
                                            If dr2.HasRows Then
                                                Do While dr2.Read()
                                                    Dim ath As New athlete
                                                    ath.ID = temp
                                                    ath.fName = dr2("FirstName")
                                                    ath.lName = dr2("LastName")
                                                    ath.roll = dr2("RollClass")
                                                    ath.ageGroup = dr2("AgeGroup")
                                                    listSelected.Add(ath)
                                                    Dim athRem As athlete = listAthletes.Find(Function(x) x.ID = temp)
                                                    listAthletes.Remove(athRem)
                                                Loop
                                            End If
                                        End Using
                                    End Using
                                    temp = ""
                                Else
                                    temp += dr("Members")(i)
                                End If
                            Next
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub cmbAgeGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAgeGroup.SelectedIndexChanged
        If cmbAgeGroup.SelectedItem = "All" Then
            listSorted = listAthletes
        Else
            listSorted = listAthletes.FindAll(Function(x) x.ageGroup = cmbAgeGroup.SelectedItem) 'Filter by age group
        End If
        listSorted = sort(cmbSort, listSorted)
        listSearched = updateSearched(listSearched, listSorted)
        fillPanels(flpAthletes, "", listSearched)
    End Sub

    Private Sub cmbSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSort.SelectedIndexChanged
        listSorted = sort(cmbSort, listSorted)
        listSearched = updateSearched(listSearched, listSorted)
        fillPanels(flpAthletes, "", listSearched)
    End Sub

    Private Sub fillPanels(flp As FlowLayoutPanel, tag As String, list As List(Of athlete))
        flp.Controls.Clear() 'Filling panels
        For Each ath As athlete In list
            Dim newpanel As New Panel With
                {
                .Margin = New Padding(3, 3, 3, 3),
                .Height = 55,
                .Width = 140,
                .BackColor = panelColor,
                .Name = ath.ID,
                .Tag = tag
                }

            Dim ID As New Label With
                {
                .Text = ath.ID,
                .Font = New Font("Segoe UI", 9, FontStyle.Bold),
                .Height = 15,
                .Location = New Point(0, 0),
                .Name = ath.ID + ".ID"
                }

            Dim roll As New Label With
                {
                .Text = ath.roll,
                .Font = New Font("Segoe UI", 8),
                .Height = 13,
                .Location = New Point(0, 15),
                .Name = ath.ID.ToString + ".roll"
                }

            Dim lName As New Label With
                {
                .Text = ath.lName.ToUpper,
                .Font = New Font("Segoe UI", 8),
                .Height = 13,
                .Location = New Point(0, 28),
                .Name = ath.ID.ToString + ".lName"
                }

            Dim fName As New Label With
                {
                .Text = ath.fName,
                .Font = New Font("Segoe UI", 8),
                .Height = 13,
                .Location = New Point(0, 41),
                .Name = ath.ID.ToString + ".fName"
                }

            newpanel.Controls.Add(ID)
            newpanel.Controls.Add(roll)
            newpanel.Controls.Add(fName)
            newpanel.Controls.Add(lName)

            flp.Controls.Add(newpanel)
            AddHandler newpanel.MouseClick, AddressOf panelClicked
            AddHandler ID.MouseClick, AddressOf labelClicked
            AddHandler roll.MouseClick, AddressOf labelClicked
            AddHandler fName.MouseClick, AddressOf labelClicked
            AddHandler lName.MouseClick, AddressOf labelClicked
        Next
    End Sub

    Private Sub panelClicked(sender As Object, e As EventArgs)
        Dim clicked As Panel = sender
        If clicked.Tag = "sel" Then
            Dim ath As athlete = listSelected.Find(Function(x) x.ID = clicked.Name)
            listAthletes.Add(ath)
            listSorted.Add(ath)
            listSelected.Remove(ath)
        Else
            Dim ath As athlete = listAthletes.Find(Function(x) x.ID = clicked.Name)
            listSelected.Add(ath)
            listSorted.Remove(ath)
            listAthletes.Remove(ath)
        End If
        fillPanels(flpAthletes, "", listSorted)
        fillPanels(flpSelected, "sel", listSelected)
    End Sub

    Private Sub labelClicked(sender As Object, e As EventArgs)
        panelClicked(sender.Parent, e)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If txtTeamName.Text <> "" Or cmbAgeGroup.SelectedItem <> Nothing Or listSelected.Count <> 0 Then
            If MsgBox("You have unsaved changes. Continue?", MsgBoxStyle.YesNo, "Save Changes?") = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            listSearched = updateSearched(listSearched, listSorted)
        Else
            listSearched = searchFilter(txtSearch, listSearched, listSorted)
        End If
        fillPanels(flpAthletes, "", listSearched)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtTeamName.Text = "" Then 'Field checking (Absolutely disgusting field checking)
            MsgBox("Please enter a team name.", MsgBoxStyle.OkOnly, "Error")
        ElseIf cmbAgeGroup.SelectedItem = Nothing Then
            MsgBox("Please select an age group.", MsgBoxStyle.OkOnly, "Error")
        ElseIf listSelected.Count = 0 Then
            MsgBox("Please select members to add.", MsgBoxStyle.OkOnly, "Error")
        Else
            If MsgBox("You are creating a " + cmbAgeGroup.SelectedItem.ToString + " team with " + listSelected.Count.ToString + " members named " + txtTeamName.Text + ". Is this okay?", MsgBoxStyle.YesNo, "Confirm Team Creation") = MsgBoxResult.Yes Then
                Using conn As New OleDbConnection(dataPath + "\Athlete.accdb") 'Commits the team
                    conn.Open()
                    If editor = True Then
                        Using cmd As New OleDbCommand("DELETE FROM teamDb WHERE Team = '" + txtTeamName.Text + "'", conn)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                    Using cmd As New OleDbCommand("INSERT INTO teamDb (Team, AgeGroup, Members) VALUES (@team, @AgeGroup, @Members)", conn) 'Appends the database with a new team
                        'Spool members list
                        Dim Members As String = ";" 'Leading separator character
                        For Each ath As athlete In listSelected
                            Members += (ath.ID + ";")
                        Next
                        cmd.Parameters.AddWithValue("@Team", txtTeamName.Text)
                        cmd.Parameters.AddWithValue("@AgeGroup", cmbAgeGroup.SelectedItem.ToString)
                        cmd.Parameters.AddWithValue("@Members", Members)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                Me.Close()
            End If
            manageTeams.refreshPanels()
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MsgBox("To begin, enter a team name and select an age group. Members can be added on the left and removed on the right. They can also be searched, sorted and filtered.", MsgBoxStyle.OkOnly, "Help")
    End Sub
End Class