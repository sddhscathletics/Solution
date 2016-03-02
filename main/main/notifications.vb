Imports System.Data.OleDb

Module notifications
    Dim unread As Boolean = False 'Whether there are new notifications
    Dim backlog As Boolean = False

    Public Sub ping()

    End Sub 'Change icon if there are new notifications

    Public Sub connect() 'Run at startup to check notifications
        Dim unreadCheck As String
        If backlog Then
            unreadCheck = ""
        Else
            unreadCheck = " WHERE read = FALSE"
        End If
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\edit.accdb") 'add your access file to bin\debug and then repalce \athelte with \(name of your file)
            conn.Open() 'open the connection to the database
            Using cmd As New OleDbCommand("SELECT edit, user, date, time FROM edits" + unreadCheck, conn) '*takes the column with correct rows
                Using dr = cmd.ExecuteReader() 'reads the database
                    If dr.HasRows And backlog = False Then
                        unread = True
                        ping()
                    End If
                    If dr.HasRows Then 'checks if there are records that fulfill your criteria
                        Do While dr.Read() 'while loop that goes to eof 
                            '*your function to perform* (access columns with dr(*index*) Or dr(*fieldName*))
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub 'Connects to edit database and reads fresh edits

    Public Sub populateNotifs()

    End Sub 'Populates notification list with unread notifications

    Public Sub showBacklog()

    End Sub 'Populates a backlog with all notifications
End Module
