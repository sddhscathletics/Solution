Imports System.Data.OleDb

Public Class manageTeams
    Dim panelColor As Color = Color.CadetBlue
    Dim listTeams As New List(Of team)
    Dim listSorted As New List(Of team)
    Dim panelSelected As Boolean = False
    Public target As Panel

    Public Sub refreshPanels()
        populate()
        listSorted = listTeams
        fillPanels()
    End Sub

    Private Sub manageTeams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshPanels()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        newTeam.Show()
    End Sub

    Private Sub populate()
        listTeams.Clear()
        Dim temp As String = ""
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT Team, Members, AgeGroup FROM teamDb", conn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim team As New team
                            team.name = dr("Team")
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
                                                    team.members.Add(ath)
                                                Loop
                                            End If
                                        End Using
                                    End Using
                                    temp = ""
                                Else
                                    temp += dr("Members")(i)
                                End If
                            Next
                            team.ageGroup = dr("AgeGroup")
                            listTeams.Add(team)
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub fillPanels()
        flpTeams.Controls.Clear()
        For Each team In listSorted
            Dim newpanel As New Panel With
            {
            .Margin = New Padding(3, 3, 3, 3),
            .Height = 40,
            .Width = 140,
            .BackColor = panelColor,
            .Name = team.name,
            .Tag = team.ageGroup
            }

            Dim name As New Label With
            {
            .Text = team.name,
            .Font = New Font("Segoe UI", 8),
            .Height = 13,
            .Location = New Point(0, 0),
            .Name = team.name
            }

            Dim ageGroup As New Label With
            {
            .Text = team.ageGroup,
            .Font = New Font("Segoe UI", 8),
            .Height = 13,
            .Location = New Point(0, 13),
            .Name = team.name + ".ageGroup"
            }

            Dim memberCount As New Label With
            {
            .Text = "Members: " + team.members.Count.ToString,
            .Font = New Font("Segoe UI", 8),
            .Height = 13,
            .Location = New Point(0, 26),
            .Name = team.name + ".memberCount"
            }

            newpanel.Controls.Add(name)
            newpanel.Controls.Add(ageGroup)
            newpanel.Controls.Add(memberCount)
            flpTeams.Controls.Add(newpanel)
            AddHandler newpanel.MouseClick, AddressOf panelClicked
            AddHandler name.MouseClick, AddressOf labelClicked
            AddHandler ageGroup.MouseClick, AddressOf labelClicked
            AddHandler memberCount.MouseClick, AddressOf labelClicked
        Next
    End Sub

    Private Sub panelClicked(sender As Object, e As EventArgs)
        txtMembers.Text = ""
        panelSelected = True
        Dim clicked As Panel = sender
        target = sender
        For Each pnl As Panel In flpTeams.Controls
            If pnl.BackColor = Color.Green Then
                pnl.BackColor = panelColor
            End If
        Next
        clicked.BackColor = Color.Green
        Dim team As team = listTeams.Find(Function(x) x.name = clicked.Name)
        If team.members.Count <> Nothing Then 'Spool team members
            For Each ath As athlete In team.members
                'Sample: 123456789: LASTNAME, FirstName [AgeGroup]
                txtMembers.Text += ath.ID + ": " + ath.lName.ToUpper + ", " + ath.fName + " [" + ath.ageGroup + "]"
                txtMembers.Text += vbNewLine
            Next
        Else
            txtMembers.Text = "This team has no members assigned to it. Assign some by pressing the edit button on the left hand side."
        End If
    End Sub

    Private Sub labelClicked(sender As Object, e As EventArgs)
        panelClicked(sender.Parent, e)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If panelSelected = True Then
            If MsgBox("Are you sure you want to delete " + target.Name + "?", MsgBoxStyle.YesNo, "Delete Team?") = MsgBoxResult.Yes Then
                Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
                    conn.Open()
                    Using cmd As New OleDbCommand("DELETE FROM teamDb WHERE Team = '" + target.Name + "'", conn) 'Delete team
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                fillPanels()
            End If
        Else
            MsgBox("Please select a team first", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub chbAll_CheckedChanged(sender As Object, e As EventArgs) Handles chbAll.CheckedChanged
        If chbAll.CheckState = CheckState.Checked Then
            cmbAgeGroup.Enabled = False
        Else
            cmbAgeGroup.Enabled = True
        End If
    End Sub

    Private Sub cmbAgeGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAgeGroup.SelectedIndexChanged
        listSorted = listTeams.FindAll(Function(x) x.ageGroup = cmbAgeGroup.SelectedItem) 'Filter by age group
        fillPanels()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If panelSelected = True Then
            newTeam.editor = True
            newTeam.Show()
        Else
            MsgBox("Please select a team first", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
End Class