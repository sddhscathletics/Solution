Imports System.Data.OleDb
Module alert
    Public alertCount As Integer = 0

    Public Sub newEdit(name, changeType, changeMade) 'Appends the edit log with a new edit
        Dim edit As String = name + " has "
        'Open edit database here
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\edit.accdb") 'add your access file to bin\debug and then repalce \athelte with \(name of your file)
            conn.Open() 'open the connection to the database
            Using cmd As New OleDbCommand("SELECT *the columns you need* FROM *the table name* WHERE *field* = *variable*", conn) '*takes the column with correct rows
                'cmd.Parameters.Add(New OleDbParameter("madeupVariable", variableYouNeedToFind)) 'maps your variable to that string
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
        Select Case changeType
            Case "evAdd"
                edit += ("added" + changeMade)
            Case "evEdit"
                edit += ("edited" + changeMade)
            Case "evDelete"
                edit += ("deleted" + changeMade)
            Case "acAdd"
                edit += ("added account" + changeMade)
            Case "acEdit"
                edit += ("edited account" + changeMade)
            Case "acDelete"
                edit += ("deleted account" + changeMade)
        End Select
        'Write to edit database using given data
        'If name = "" Then
        'Write editDb from Date, time, enteredUsername, Message, event
        '	'example: 12/1/16 12:01PM, Kurt Rich, “has added”, 14/5/16 Carnival
        'Else
        'Write editDb from Date, time, enteredUsername, Message, change, name
        '       'example: 12/1/16 12:01PM, “Kurt Rich”, “has added account” Jun Lin
        'End If
    End Sub

    Public Sub checkAlert(name, change, time, editDate) 'Creates a new alert from the recent edit made
        'Open edit database here
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\edit.accdb") 'add your access file to bin\debug and then repalce \athelte with \(name of your file)
            conn.Open() 'open the connection to the database
            Using cmd As New OleDbCommand("SELECT edit, user, date, time FROM edits WHERE read = FALSE", conn) '*takes the column with correct rows
                'cmd.Parameters.Add(New OleDbParameter("madeupVariable", variableYouNeedToFind)) 'maps your variable to that string
                Using dr = cmd.ExecuteReader() 'reads the database
                    If dr.HasRows Then 'checks if there are records that fulfill your criteria
                        Do While dr.Read() 'while loop that goes to eof
                            '*your function to perform*
                            '(access columns with dr(*index*) Or dr(*fieldName*))
                            alertCount += 1
                        Loop
                    End If
                End Using
            End Using
        End Using
        'Determine which alerts have been read
        'Get name, change made, time and date of change
        'Display in one line
    End Sub
End Module