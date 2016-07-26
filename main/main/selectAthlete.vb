Imports System.Data.OleDb
'Searching and sorting
'Profile photo
'Adding and editing

Public Class selectAthlete
    Dim athleteList As New List(Of athlete)
    Dim editing As Boolean = False
    Dim panelColor As Color = Color.CadetBlue

    Private Sub selectAthlete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hidecontrols()
        btnSave.Visible = False
        btnCancel.Visible = False
        populate()
    End Sub

    Private Sub panelClicked(sender As Object, e As EventArgs)
        showcontrols()
        Dim clicked As Panel = sender
        displayDetails(clicked.Tag)
    End Sub

    Private Sub labelClicked(sender As Object, e As EventArgs)
        panelClicked(sender.Parent, e)
    End Sub

    Private Sub populate()
        flpAthletes.Controls.Clear()
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, RollClass, FirstName, LastName FROM athleteDb", conn)
                'Need to add photo
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim newpanel As New Panel With
                                {
                                .Margin = New Padding(3, 3, 3, 3),
                                .Height = 55,
                                .Width = 140,
                                .BackColor = panelColor,
                                .Name = dr("ID"),
                                .Tag = dr("ID")
                                }

                            Dim ID As New Label With
                                {
                                .Text = dr("ID").ToString,
                                .Font = New Font("Segoe UI", 9, FontStyle.Bold),
                                .Height = 15,
                                .Location = New Point(0, 0),
                                .Name = dr("ID").ToString + ".ID"
                                }

                            Dim roll As New Label With
                                {
                                .Text = dr("RollClass"),
                                .Font = New Font("Segoe UI", 8),
                                .Height = 13,
                                .Location = New Point(0, 15),
                                .Name = dr("ID").ToString + ".roll"
                                }

                            Dim lName As New Label With
                                {
                                .Text = dr("LastName").ToString.ToUpper,
                                .Font = New Font("Segoe UI", 8),
                                .Height = 13,
                                .Location = New Point(0, 28),
                                .Name = dr("ID").ToString + ".lName"
                                }

                            Dim fName As New Label With
                                {
                                .Text = dr("FirstName"),
                                .Font = New Font("Segoe UI", 8),
                                .Height = 13,
                                .Location = New Point(0, 41),
                                .Name = dr("ID").ToString + ".fName"
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
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub displayDetails(id As String)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, RollClass, FirstName, LastName, AgeGroup, Address, MedicalInfo, BestEvent, Email, PhoneNumber, Teams FROM athleteDb WHERE ID = " + id, conn)
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
                            If dr("Teams") <> "None Specified" Then
                                lblTeams.Text = "Teams"
                                parseTeams(id)
                            Else
                                lblTeams.Text = "No Teams Specified"
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
        adNo = ""
        adSt = ""
        adSb = ""
        adPo = ""
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

    Private Sub parseTeams(id As String)
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT Team FROM teamDb WHERE Members.Value =" + id, conn) 'Selects unread edits
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim newpanel As New Panel With
                            {
                            .Margin = New Padding(3, 3, 3, 3),
                            .Height = 30,
                            .Width = 160,
                            .BackColor = panelColor,
                            .Name = dr("Team") + ".panel",
                            .Tag = dr("Team")
                            }
                            Dim teamLabel As New Label With
                            {
                            .Text = dr("Team"),
                            .Font = New Font("Segoe UI", 10),
                            .Location = New Point(0, 0),
                            .Name = dr("Team") + ".name"
                            }
                            newpanel.Controls.Add(teamLabel)
                            flpTeams.Controls.Add(newpanel)
                            AddHandler newpanel.MouseClick, AddressOf teamPanelClicked
                            AddHandler teamLabel.MouseClick, AddressOf teamLabelClicked
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub teamPanelClicked(sender As Object, e As EventArgs)
        Dim clicked As Panel = sender
        If editing = True Then
            If clicked.BackColor = Color.Red Then
                clicked.BackColor = panelColor
            Else
                clicked.BackColor = Color.Red
                'Highlight for deletion
            End If
        Else
            MsgBox("Go to " + clicked.Tag + "?")
            'Go to team page
        End If
    End Sub

    Private Sub teamLabelClicked(sender As Object, e As EventArgs)
        teamPanelClicked(sender.Parent, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        access = 2
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        editing = True
        hidecontrols()
        gpbStudent.Visible = True
        gpbAthlete.Visible = True
        'Show delete team button
        'Delete team selection
        'Show add team button
    End Sub

    Private Sub hidecontrols()
        gpbAthlete.Visible = False
        gpbStudent.Visible = False
        gpbAddress.Visible = False
        gpbContact.Visible = False
        gpbMedical.Visible = False
        btnEdit.Visible = False
        If editing = True Then
            btnSave.Visible = True
            btnCancel.Visible = True
            btnAddTeam.Visible = True
            btnDeleteTeam.Visible = True
        End If
    End Sub

    Private Sub showcontrols()
        gpbAthlete.Visible = True
        gpbStudent.Visible = True
        btnEdit.Visible = True
        btnSave.Visible = False
        btnCancel.Visible = False
        btnAddTeam.Visible = False
        btnDeleteTeam.Visible = False
        If access = 1 Or access = 2 Then 'Check if the user is a coach or Kurt
            gpbContact.Visible = True
            gpbMedical.Visible = True
            If access = 2 Then 'Check if the user is kurt
                gpbAddress.Visible = True
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        checkChanges()
        'saveChanges()
        showcontrols()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        showcontrols()
    End Sub

    Private Sub checkChanges()
        'Compare textbox contents and labels
    End Sub

    Public Sub saveChanges()
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
End Class