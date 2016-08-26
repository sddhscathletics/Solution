Imports System.Data.OleDb
'Searching
'Profile photo
'Team Manager

Public Class selectAthlete
    Dim listAthletes As New List(Of athlete)
    Dim listAdd As New List(Of String)
    Dim listRem As New List(Of String)
    Dim controlState As String = "first"
    Dim panelColor As Color = Color.CadetBlue

    Private Sub selectAthlete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toggleControls()
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
                            'pbPhoto.Image = dr("Photo")
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
                            flpTeams.Controls.Clear()
                            loadTeams(flpTeams, "rem")
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
                    Using cmd As New OleDbCommand("UPDATE teamDb SET Members = '" + memberList + "' WHERE Team = '" + team + "'", conn)
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
        loadTeams(flpAttachTeam, "add")
    End Sub

    Private Sub toggleControls()
        Select Case controlState
            Case "first"
                gpbAthlete.Visible = False
                gpbStudent.Visible = False
                gpbAddress.Visible = False
                gpbContact.Visible = False
                gpbMedical.Visible = False
                gpbTeamManagement.Visible = False
                btnEdit.Visible = False
                btnSave.Visible = False
                btnCancel.Visible = False
                btnCommitTeams.Visible = False
            Case "show"
                gpbAthlete.Visible = True
                gpbStudent.Visible = True
                gpbTeamManagement.Visible = False
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
                gpbAddress.Visible = False
                gpbContact.Visible = False
                gpbMedical.Visible = False
                gpbTeamManagement.Visible = True
                btnEdit.Visible = False
                btnSave.Visible = True
                btnCancel.Visible = True
                btnCommitTeams.Visible = True
        End Select
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'checkChanges()
        'saveChanges()
        controlState = "show"
        toggleControls()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        controlState = "show"
        toggleControls()
        refreshTeams()
    End Sub

    Private Sub checkChanges()
        'Compare textbox contents and labels
    End Sub

    Private Sub saveChanges()
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("UPDATE teamDb SET [read] = 1 WHERE ID = ", conn) 'Selects unread edits
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            'Add team to student's details
                            'Add student ID to team
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnNewTeam_Click(sender As Object, e As EventArgs) Handles btnNewTeam.Click
        newTeam.Show()
    End Sub

    Private Sub cmbAgeGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAgeGroup.SelectedIndexChanged
        sort()
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        sort()
    End Sub

    Private Sub SortFilterSearch(InputFirstName As List(Of String), InputLastName As List(Of String), InputRollClass As List(Of String), InputIDString As List(Of String), InputYearGroup As List(Of String), OutputIndex As List(Of Integer), SearchTextBox As TextBox, FilterComboBox As ComboBox, SortComboBox As ComboBox, YearGroupArray() As Integer)
        Dim SortList As New List(Of String)                                                         'Temporary list used to sort database list without changing indexes
        Dim SortArray() As Object = {InputLastName, InputFirstName, InputRollClass, InputIDString}  'Array matching the sort combo box index to its respective list 
        Dim position As Integer = 0                                                                 'Position to start index search, used when there are multiple people with the same primary value
        Dim FirstPanel As Boolean = True                                                            'Boolean showing whether the panel being filled is the first panel
        Dim SearchList As New List(Of String)                                                       'Temporary list used to get sorted values prior to being filtered by the search module
        Dim FilterList As New List(Of Integer)
        OutputIndex.Clear()
        SortList.Clear()
        SearchList.Clear()
        FilterList.Clear()
        FirstPanel = True
        For i As Integer = 0 To InputIDString.Count - 1 'Add relevant dbColumn to string
            Select Case SortComboBox.SelectedIndex
                Case 1
                    SortList.Add(InputFirstName(i))
                Case 2
                    SortList.Add(InputRollClass(i))
                Case 3
                    SortList.Add(InputIDString(i))
                Case Else
                    SortList.Add(InputLastName(i))
            End Select
        Next
        SortList.Sort()                                 'Sort
        For Each i As String In SortList                'Check for dupes and get index
            If FirstPanel = True Then
                FilterList.Add(SortArray(SortComboBox.SelectedIndex).IndexOf(i))
            ElseIf i = InputLastName(FilterList.Last) Or i = InputFirstName(FilterList.Last) Or i = InputIDString(FilterList.Last) Then
                position = FilterList.Last + 1
                If SortArray(SortComboBox.SelectedIndex).IndexOf(i, position) <> -1 Then
                    FilterList.Add(SortArray(SortComboBox.SelectedIndex).IndexOf(i, position))
                End If
            Else
                FilterList.Add(SortArray(SortComboBox.SelectedIndex).IndexOf(i))
            End If
            FirstPanel = False
        Next
        For Each num As Integer In FilterList           'Filter by year group and search box
            If FilterComboBox.SelectedIndex <> 0 Then
                If CInt(InputYearGroup(num)) = YearGroupArray(FilterComboBox.SelectedIndex) Then
                    If InputLastName(num).ToLower.Contains(SortComboBox.Text.ToLower) Or InputFirstName(num).ToLower.Contains(SortComboBox.Text.ToLower) Or InputIDString(num).ToLower.Contains(SortComboBox.Text.ToLower) Then
                        OutputIndex.Add(num)
                    End If
                End If
            Else
                If InputLastName(num).ToLower.Contains(SortComboBox.Text.ToLower) Or InputFirstName(num).ToLower.Contains(SortComboBox.Text.ToLower) Or InputIDString(num).ToLower.Contains(SortComboBox.Text.ToLower) Then
                    OutputIndex.Add(num)
                End If
            End If
        Next
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
                    listAthletes.Sort(Function(x, y) x.id.CompareTo(y.id))

                Case "First Name (Ascending)"
                    listAthletes.Sort(Function(x, y) x.fname.CompareTo(y.fname))

                Case "First Name (Descending)"
                    asc = False
                    listAthletes.Sort(Function(x, y) x.fname.CompareTo(y.fname))

                Case "Last Name (Ascending)"
                    listAthletes.Sort(Function(x, y) x.lname.CompareTo(y.lname))

                Case "Last Name (Descending)"
                    asc = False
                    listAthletes.Sort(Function(x, y) x.lname.CompareTo(y.lname))
            End Select
            If asc = False Then
                listAthletes.Reverse()
            End If
        End If
        fillPanels()
    End Sub

    Private Sub cmbTeamAgeGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTeamAgeGroup.SelectedIndexChanged
        loadTeams(flpAttachTeam, "add")
    End Sub
End Class