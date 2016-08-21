Imports System.Data.OleDb

Public Class newTeam
    Dim panelColor As Color = Color.CadetBlue
    Dim first As Boolean = True
    Dim listAdd As New List(Of String)

    Private Sub newTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
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

    Private Sub panelClicked(sender As Object, e As EventArgs)
        Dim clicked As Panel = sender
        Dim listSelect As List(Of String)
        If clicked.BackColor = Color.Green Then
            clicked.BackColor = panelColor
            listAdd.Remove(clicked.Name)
        Else
            clicked.BackColor = Color.Green 'Highlight team for addition
            listAdd.Add(clicked.Name)
        End If
    End Sub

    Private Sub labelClicked(sender As Object, e As EventArgs)
        panelClicked(sender.Parent, e)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
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
        'Commit team and members
        Me.Close()
    End Sub
End Class