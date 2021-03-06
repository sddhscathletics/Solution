﻿Imports System.Data.OleDb

Public Class selectAthlete
    Dim listAthletes As New List(Of athlete)
    Dim listSorted As New List(Of athlete)
    Dim listSearched As New List(Of athlete)
    Dim listAdd As New List(Of String)
    Dim listRem As New List(Of String)
    Dim controlState As String = "first"
    Dim panelColor As Color = Color.CadetBlue

#Region "Dim Variables - JUN"
    Dim out As Boolean = False
    Dim cDrop As Boolean = False
    Dim rDrop As Boolean = False
    Dim cDown As Boolean = False
    Dim rDown As Boolean = False
    Dim atDrop As Boolean = False
    Dim atDown As Boolean = False
    Dim adDrop As Boolean = False
    Dim adDown As Boolean = False
    Dim jun As Integer = 0
#End Region
#Region "Sidebar"

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrAlert.Start()
        If access = 0 Or access = 1 Then
            sideadminBtn.Visible = False
            sideteamBtn.Visible = False
        End If
    End Sub

    Private Sub scrollclick(sender As Object, e As EventArgs) Handles scrollBtn.Click
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If out = False Then
            bigbtngroup.Left = bigbtngroup.Left + 20
            Sidebar.Left = Sidebar.Left + 20
            If Sidebar.Left = 0 Then
                out = True
                Timer1.Enabled = False
            End If
        ElseIf out = True Then
            Sidebar.Left = Sidebar.Left - 20
            bigbtngroup.Left = bigbtngroup.Left - 20
            If Sidebar.Left = -200 Then
                out = False
                Timer1.Enabled = False
            End If
        End If
    End Sub
    Private Sub sidebartime_Tick(sender As Object, e As EventArgs) Handles sidebartime.Tick
        ' results drop
        If rDrop = True Then
            If rDown = True Then
                sideAthletesBtn.Top += 10
                sideteamBtn.Top += 10
                sideResSub1.Top += 10
                sideResSub2.Top += 10
                sideadminBtn.Top += 10
            End If
            If rDown = False Then
                sideAthletesBtn.Top -= 10
                sideteamBtn.Top -= 10
                sideResSub1.Top -= 10
                sideResSub2.Top -= 10
                sideadminBtn.Top -= 10
            End If
            jun += 1
            If jun = 6 Then
                jun = 0
                rDrop = False
                sidebartime.Enabled = False
            End If
        End If
    End Sub
    Private Sub calDrop_Click(sender As Object, e As EventArgs)
        If cDrop = False Then
            cDrop = True
            If cDown = False Then
                cDown = True
            Else
                If cDown = True Then
                    cDown = False
                End If
            End If
            sidebartime.Enabled = True
        End If
    End Sub
    Private Sub resdrop_Click(sender As Object, e As EventArgs) Handles resdrop.Click
        If rDrop = False Then
            rDrop = True
            If rDown = False Then
                rDown = True
            Else
                If rDown = True Then
                    rDown = False
                End If
            End If
            sidebartime.Enabled = True
        End If
    End Sub

    Private Sub calendarBtn_Click(sender As Object, e As EventArgs) Handles sidecalendarBtn.Click
        calendar.Show()
        Me.Hide()
    End Sub
    Private Sub resultBtn_Click(sender As Object, e As EventArgs) Handles sideresultBtn.Click
        Results.Show()
        Me.Hide()
    End Sub
#End Region
#Region " Move Form "

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

#End Region

    Private Sub selectAthlete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrAlert.Start()
        toggleControls()
        listAthletes = populate(listAthletes)
        listSorted = listAthletes
        listSearched.AddRange(listAthletes)
        fillPanels(flpAthletes, "", listSearched)
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
        controlState = "show"
        toggleControls()
        Dim clicked As Panel = sender
        displayDetails(clicked.Name)
    End Sub

    Private Sub labelClicked(sender As Object, e As EventArgs)
        panelClicked(sender.Parent, e)
    End Sub

    Private Sub displayDetails(id As String)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, RollClass, FirstName, LastName, AgeGroup, Address, MedicalInfo, BestEvent, Email, PhoneNumber FROM athleteDb WHERE ID = " + id, conn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim photoNum As Integer = CInt(Math.Floor((3 - 1 + 1) * Rnd())) + 1
                            Select Case photoNum
                                Case 1
                                    pbPhoto.Image = My.Resources.student1
                                Case 2
                                    pbPhoto.Image = My.Resources.student2
                                Case 3
                                    pbPhoto.Image = My.Resources.student3
                            End Select

                            If access = 2 Then
                                Try
                                    lblHeaderAddress.Text = "Address"
                                    parseAddress(dr("Address"))
                                Catch ex As Exception
                                    lblHeaderAddress.Text = "No Address Specified"
                                    lblStNo.Text = ""
                                    lblSt.Text = ""
                                    lblSb.Text = ""
                                    lblPo.Text = ""
                                End Try
                                lblPhone.Text = "Phone Number: " + dr("PhoneNumber")
                                lblEmail.Text = "Email Address: " + dr("Email")
                                lblMedical.Text = dr("MedicalInfo")
                            End If
                            lblID.Text = dr("ID")
                            lblRoll.Text = "Roll Class: " + dr("RollClass")
                            lblFName.Text = dr("FirstName")
                            lblLName.Text = dr("LastName")
                            loadTeams(flpTeams, "rem")
                            If flpTeams.Controls.Count = Nothing Then
                                lblTeams.Text = "No Teams Assigned"
                            Else
                                lblTeams.Text = "Teams"
                            End If
                            lblAgeGroup.Text = "Age Group: " + dr("AgeGroup")
                            lblBestEvent.Text = "Best Event: " + dr("BestEvent")
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub parseAddress(address As String) 'Parse address
        'Default address format is UNIT/NUMBER STREET, SUBURB POSTCODE
        'Example: 1/23 Test Street, Suburbia 1234
        Dim adNo, adSt, adSb, adPo As String
        Dim i As Integer = 0

        While address(i) <> " " 'Parse until the space separator between unit/number and street is found
            adNo += address(i)
            i += 1
        End While

        i += 1
        While address(i) <> "," 'Parse until comma separator between street and subrub is found
            adSt += address(i)
            i += 1
        End While

        i += 2 'Jump two places in the string to account for the comma and space
        While address(i) <> " " 'Parse until the space separator between suburb and postcode is found
            adSb += address(i)
            i += 1
        End While

        i += 1
        For i = i To Len(address) - 1 'Parse until the end of the string to find post code
            adPo += address(i)
        Next

        lblStNo.Text = adNo
        lblSt.Text = adSt
        lblSb.Text = adSb
        lblPo.Text = adPo
    End Sub

    Private Sub teamPanelClicked(sender As Object, e As EventArgs) 'Optimise!
        Dim clicked As Panel = sender
        Dim colorSelect As Color
        Dim listSelect As List(Of String)
        If clicked.Tag = "add" Then
            colorSelect = Color.Green
            listSelect = listAdd
        Else
            colorSelect = Color.Red
            listSelect = listRem
        End If
        If controlState = "editing" Then
            If clicked.BackColor = colorSelect Then
                clicked.BackColor = panelColor
                listSelect.Remove(clicked.Name)
            Else
                clicked.BackColor = colorSelect 'Highlight team for addition
                listSelect.Add(clicked.Name)
            End If
        End If
    End Sub

    Private Sub teamLabelClicked(sender As Object, e As EventArgs)
        teamPanelClicked(sender.Parent, e)
    End Sub

    Private Sub loadTeams(flp As FlowLayoutPanel, tagType As String)
        flp.Controls.Clear()
        Dim append As String = ""
        If tagType = "add" Then
            append += " = 0"
            If cmbTeamAgeGroup.SelectedItem <> Nothing Then
                append += " AND AgeGroup = '" + cmbTeamAgeGroup.SelectedItem.ToString + "'"
            End If
        End If
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT Team FROM teamDb WHERE INSTR (Members, '" + lblID.Text + "')" + append, conn) 'Selects teams the student is a member of
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim newpanel As New Panel With
                            {
                            .Margin = New Padding(3, 3, 3, 3),
                            .Height = 20,
                            .Width = 140,
                            .BackColor = panelColor,
                            .Name = dr("Team"),
                            .Tag = tagType
                            }

                            Dim teamLabel As New Label With
                            {
                            .Text = dr("Team"),
                            .Width = 160,
                            .Font = New Font("Segoe UI", 10),
                            .Location = New Point(0, 0)
                            }
                            newpanel.Controls.Add(teamLabel)
                            flp.Controls.Add(newpanel)
                            AddHandler newpanel.MouseClick, AddressOf teamPanelClicked
                            AddHandler teamLabel.MouseClick, AddressOf teamLabelClicked
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub refreshTeams()
        loadTeams(flpAttachTeam, "add")
        loadTeams(flpTeams, "rem")
        listAdd.Clear()
        listRem.Clear()
    End Sub

    Private Sub btnCommitTeams_Click(sender As Object, e As EventArgs) Handles btnCommitTeams.Click
        If listAdd.Count = 0 And listRem.Count = 0 Then
            MsgBox("Please select teams to add/remove first.")
        Else
            Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
                conn.Open()
                For Each team As String In listAdd 'Add teams
                    Using cmd As New OleDbCommand("UPDATE teamDb SET Members = (Members + '" + lblID.Text + ";') WHERE Team = '" + team + "'", conn)
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using
            Dim memberList As String = ""
            Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
                conn.Open()
                For Each team As String In listRem 'Removes teams
                    Using cmd As New OleDbCommand("SELECT Members FROM teamDb WHERE Team = '" + team + "'", conn)
                        Using dr = cmd.ExecuteReader()
                            If dr.HasRows Then
                                Do While dr.Read()
                                    memberList = Replace(dr("Members"), lblID.Text + ";", "")
                                Loop
                            End If
                        End Using
                    End Using
                    Using cmd As New OleDbCommand("UPDATE teamDb SET (Team, Members, AgeGroup)  = '" + memberList + "' WHERE Team = '" + team + "'", conn)
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using
            refreshTeams()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        access = 2
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        controlState = "editing"
        toggleControls()
        Dim ageGroup As String = Replace(lblAgeGroup.Text, "Age Group: ", "")
        cmbAge.SelectedItem = ageGroup
        Dim bestEvent As String = Replace(lblBestEvent.Text, "Best Event: ", "")
        txtBestEvent.Text = bestEvent
        loadTeams(flpAttachTeam, "add")
    End Sub

    Private Sub toggleControls()
        Select Case controlState
            Case "first"
                btnHelp.Visible = False
                gpbAthlete.Visible = False
                gpbStudent.Visible = False
                gpbAddress.Visible = False
                gpbContact.Visible = False
                gpbMedical.Visible = False
                gpbEditing.Visible = False
                gpbTeamManagement.Visible = False
                btnEdit.Visible = False
                btnSave.Visible = False
                btnCancel.Visible = False
                btnCommitTeams.Visible = False
            Case "show"
                btnHelp.Visible = False
                gpbAthlete.Visible = True
                gpbStudent.Visible = True
                lblAgeGroup.Visible = True
                lblBestEvent.Visible = True
                gpbTeamManagement.Visible = False
                gpbEditing.Visible = False
                btnSave.Visible = False
                btnCancel.Visible = False
                btnCommitTeams.Visible = False
                If access = 1 Or access = 2 Then 'Check if the user is a coach or Kurt
                    gpbContact.Visible = True
                    gpbMedical.Visible = True
                    If access = 2 Then 'Check if the user is kurt
                        gpbAddress.Visible = True
                        btnEdit.Visible = True
                    End If
                End If
            Case "editing"
                btnHelp.Visible = True
                lblAgeGroup.Visible = False
                lblBestEvent.Visible = False
                gpbAddress.Visible = False
                gpbContact.Visible = False
                gpbMedical.Visible = False
                gpbEditing.Visible = True
                gpbTeamManagement.Visible = True
                btnEdit.Visible = False
                btnSave.Visible = True
                btnCancel.Visible = True
                btnCommitTeams.Visible = True
        End Select
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        savechanges()
        controlState = "show"
        toggleControls()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        controlState = "show"
        toggleControls()
        refreshTeams()
    End Sub

    Private Sub saveChanges()
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("UPDATE athleteDb SET BestEvent = '" + txtBestEvent.Text + "' WHERE ID = " + lblID.Text, conn)
                cmd.ExecuteNonQuery()
            End Using
            Using cmd As New OleDbCommand("UPDATE athleteDb SET AgeGroup = '" + cmbAge.Text + "' WHERE ID = " + lblID.Text, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        displayDetails(lblID.Text)
    End Sub

    Private Sub btnNewTeam_Click(sender As Object, e As EventArgs) Handles btnNewTeam.Click
        newTeam.Show()
    End Sub

    Private Sub cmbTeamAgeGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTeamAgeGroup.SelectedIndexChanged
        'Sorting unadded teams (Older sort method)
        loadTeams(flpAttachTeam, "add")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        If MessageBox.Show("Do you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub sideadminBtn_Click(sender As Object, e As EventArgs) Handles sideadminBtn.Click
        AddEdit_User.Show()
        Me.Close()
    End Sub

    Private Sub helpBtn_Click(sender As Object, e As EventArgs) Handles helpBtn.Click
        helpIdentifier = "selectAthlete"
        helpForm.Show()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            listSearched = updateSearched(listSearched, listSorted)
        Else
            listSearched = searchFilter(txtSearch, listSearched, listSorted)
        End If
        fillPanels(flpAthletes, "", listSearched)
    End Sub

    Private Sub tmrAlert_Tick(sender As Object, e As EventArgs) Handles tmrAlert.Tick
        lblAlertCount.Text = getNotifCount()
        If lblAlertCount.Text = "0" Then
            lblAlertCount.Text = ""
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        checkNotif.Show()
    End Sub

    Private Sub sideteamBtn_Click(sender As Object, e As EventArgs) Handles sideteamBtn.Click
        manageTeams.Show()
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MsgBox("The team management window allows easy assigning/removing of teams with regard to the current selected student. Select teams on either side to add/remove, then click the blue commit button to save changes. The student's best event and age group can also be modified at the bottom.", MsgBoxStyle.OkOnly, "Help")
    End Sub
End Class