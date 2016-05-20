Imports System.Data.OleDb
Module alert
    Public Sub newEdit(changeType, changeMade) 'Appends the edit log with a new edit
        Dim edit As String = " has "
        Select Case changeType
            Case "evAdd"
                edit += ("added " + changeMade)
            Case "evEdit"
                edit += ("edited " + changeMade)
            Case "evDelete"
                edit += ("deleted " + changeMade)
            Case "acAdd"
                edit += ("added account " + changeMade)
            Case "acEdit"
                edit += ("edited account " + changeMade)
            Case "acDelete"
                edit += ("deleted account " + changeMade)
        End Select
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\edits.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("INSERT INTO edits (username, edit, lDate, lTime) VALUES (@edit, @username, @lDate, @lTime)", conn) 'Appends the database with a new edit
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@edit", edit)
                cmd.Parameters.AddWithValue("@lDate", DateTime.Now.ToString("dd/MM/yy"))
                cmd.Parameters.AddWithValue("@lTime", DateTime.Now.ToString("HH:mm"))
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub checkAlert() 'Creates a new alert from the recent edit made
        alertCount = 0
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\edits.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, lDate, lTime, edit, username FROM edits WHERE [read] = 0", conn) 'Selects unread edits
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            alertList.Add(dr("ID").ToString + " " + dr("lDate") + " " + dr("lTime") + ": " + dr("username") + dr("edit"))
                            alertCount += 1
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Sub markRead(ID)
        'Remove row by ID
        alertCount -= 1
    End Sub
End Module