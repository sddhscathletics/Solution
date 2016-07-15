Imports System.Data.OleDb

Public Class selectAthlete
    Private Sub selectAthlete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub panelClicked(sender As Object, e As EventArgs)
        Dim clicked As Panel = sender
        MsgBox(clicked.Tag)
    End Sub

    Private Sub labelClicked(sender As Object, e As EventArgs)
        panelClicked(sender.Parent, e)
    End Sub

    Private Sub populate()
        flpAthletes.Controls.Clear()
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, RollClass, FirstName, LastName FROM athleteDb", conn)
                'Need to add photo
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim newAthlete As New athlete With
                                {
                                .ID = dr("ID"),
                                .roll = dr("RollClass"),
                                .fName = dr("FirstName"),
                                .lName = dr("LastName").ToString.ToUpper
                                }
                            athleteList.Add(newAthlete)

                            Dim newpanel As New Panel With
                                {
                                .Height = 55,
                                .Width = 140,
                                .BackColor = Color.CadetBlue,
                                .Name = newAthlete.ID,
                                .Tag = dr("ID")
                                }

                            Dim ID As New Label With
                                {
                                .Text = newAthlete.ID,
                                .Font = New Font("Segoe UI", 9, FontStyle.Bold),
                                .Height = 15,
                                .Location = New Point(0, 0),
                                .Name = newAthlete.ID + ".ID"
                                }

                            Dim roll As New Label With
                                {
                                .Text = newAthlete.roll,
                                .Font = New Font("Segoe UI", 8),
                                .Height = 13,
                                .Location = New Point(0, 15),
                                .Name = newAthlete.ID + ".roll"
                                }

                            Dim lName As New Label With
                                {
                                .Text = newAthlete.lName,
                                .Font = New Font("Segoe UI", 8),
                                .Height = 13,
                                .Location = New Point(0, 28),
                                .Name = newAthlete.ID + ".lName"
                                }

                            Dim fName As New Label With
                                {
                                .Text = newAthlete.fName,
                                .Font = New Font("Segoe UI", 8),
                                .Height = 13,
                                .Location = New Point(0, 41),
                                .Name = newAthlete.ID + ".fName"
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
End Class