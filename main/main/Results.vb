
Imports System.Data.OleDb

Public Class Results
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles Me.Load
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb") 'add your access file to bin\debug and then repalce \athelte with \(name of your file)
            conn.Open() 'open the connection to the database
            Using cmd As New OleDbCommand("SELECT AthleteName, AgeGroup, Placement, MeetName, EventName, EventDate FROM resultsDb", conn) '*takes the column with correct rows
                'cmd.Parameters.Add(New OleDbParameter("madeupVariable", Event)) 'maps your variable to that string
                Using dr = cmd.ExecuteReader() 'reads the database
                    If dr.HasRows Then 'checks if there are records that fulfill your criteria
                        Do While dr.Read() 'while loop that goes to eof

                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub MeetRev_Click(sender As Object, e As EventArgs) Handles MeetRev.Click
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb") 'add your access file to bin\debug and then repalce \athelte with \(name of your file)
            conn.Open() 'open the connection to the database
            Using cmd As New OleDbCommand("SELECT AthleteName, AgeGroup, Placement, MeetName, EventName, EventDate FROM resultsDb", conn) '*takes the column with correct rows
                'cmd.Parameters.Add(New OleDbParameter("madeupVariable", Event)) 'maps your variable to that string
                Using dr = cmd.ExecuteReader() 'reads the database
                    If dr.HasRows Then 'checks if there are records that fulfill your criteria
                        Do While dr.Read() 'while loop that goes to eof
                            'EventView.DataSource
                            If dr("MeetName") = "Happy Meet" Then
                                AthAgeGro.Text = dr(1)
                                AthNam.Text = dr(0)
                                MeetNam.Text = dr(3)
                                Place.Text = dr(2)
                                EvenName.Text = dr(4)
                                EvenDat.Text = dr(5)
                            End If

                            '(access columns with dr(*index*) Or dr(*fieldName*))
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub SeasonRev_Click(sender As Object, e As EventArgs) Handles SeasonRev.Click
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|Resources|\Athlete.accdb") 'add your access file to bin\debug and then repalce \athelte with \(name of your file)
            conn.Open() 'open the connection to the database
            Using cmd As New OleDbCommand("SELECT *the columns you need* FROM *the table name* WHERE *field* = *variable*", conn) '*takes the column with correct rows
                'cmd.Parameters.Add(New OleDbParameter("madeupVariable", Event)) 'maps your variable to that string
                Using dr = cmd.ExecuteReader() 'reads the database
                    If dr.HasRows Then 'checks if there are records that fulfill your criteria
                        Do While dr.Read() 'while loop that goes to eof
                            '*your function to perform*
                            '(access columns with dr(*index*) Or dr(*fieldName*))
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub


End Class
