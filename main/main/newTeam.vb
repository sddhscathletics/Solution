Imports System.Data.OleDb
'Searching
'Halp

Public Class newTeam
    Dim panelColor As Color = Color.CadetBlue
    Dim first As Boolean = True
    Dim listAthletes As New List(Of athlete)
    Dim listSelected As New List(Of athlete)

    Private Sub newTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listAthletes = refreshFlp(cmbAgeGroup, cmbSort, listAthletes)
        fillPanels(flpAthletes, "", listAthletes)
    End Sub

    Private Sub cmbAgeGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAgeGroup.SelectedIndexChanged
        listAthletes = refreshFlp(cmbAgeGroup, cmbSort, listAthletes)
        checkDuplicates()
        fillPanels(flpAthletes, "", listAthletes)
        fillPanels(flpSelected, "sel", listSelected)
    End Sub

    Private Sub cmbSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSort.SelectedIndexChanged
        listAthletes = refreshFlp(cmbAgeGroup, cmbSort, listAthletes)
        checkDuplicates()
        fillPanels(flpAthletes, "", listAthletes)
        fillPanels(flpSelected, "sel", listSelected)
    End Sub

    Private Sub checkDuplicates() 'Pls halp
        For Each athlete In listSelected
            listAthletes.Remove(athlete)
        Next
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
            listSelected.Remove(ath)
        Else
            Dim ath As athlete = listAthletes.Find(Function(x) x.ID = clicked.Name)
            listSelected.Add(ath)
            listAthletes.Remove(ath)
        End If
        fillPanels(flpAthletes, "", listAthletes)
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
        ElseIf listSelected.Count = 0 Then
            MsgBox("Please select members to add.")
        Else
            If MsgBox("You are creating a " + cmbAgeGroup.SelectedItem.ToString + " team with " + listSelected.Count.ToString + " members named " + txtTeamName.Text + ". Is this okay?", MsgBoxStyle.YesNo, "Confirm Team Creation") = MsgBoxResult.Yes Then
                Using conn As New OleDbConnection(dataPath + "\Athlete.accdb") 'Commits the team
                    conn.Open()
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
        End If
    End Sub

End Class