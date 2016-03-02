Imports System.Data.OleDb

Module notifications
    Dim notif As Boolean = False 'Whether there are new notifications

    Public Sub ping()

    End Sub 'Change icon if there are new notifications

    Public Sub connect()
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\edit.accdb") 'add your access file to bin\debug and then repalce \athelte with \(name of your file)
            conn.Open() 'open the connection to the database
            Using cmd As New OleDbCommand("SELECT edit, user, date, time FROM edits WHERE read = FALSE", conn) '*takes the column with correct rows
                Using dr = cmd.ExecuteReader() 'reads the database
                    If dr.HasRows Then 'checks if there are records that fulfill your criteria
                        Do While dr.Read() 'while loop that goes to eof
                            '*your function to perform* (access columns with dr(*index*) Or dr(*fieldName*))
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub 'Connects to edit database and reads fresh edits
End Module
