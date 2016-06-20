Imports System.Data.OleDb
Module alert
    Public Sub newEdit(changeType, changeMade) 'Appends the edit log with a new edit
        Dim edit As String = ""
        Select Case changeType
            Case "evAdd"
                edit = ("Added " + changeMade)
            Case "evEdit"
                edit = ("Edited " + changeMade)
            Case "evDelete"
                edit = ("Deleted " + changeMade)
            Case "acAdd"
                edit = ("Added account " + changeMade)
            Case "acEdit"
                edit = ("Edited account " + changeMade)
            Case "acDelete"
                edit = ("Deleted account " + changeMade)
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
        alertList.Clear()
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\edits.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, lDate, lTime, edit, username FROM edits WHERE [read] = 0", conn) 'Selects unread edits
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim newnotif As New notif
                            newnotif.ID = dr("ID")
                            newnotif.ldate = dr("lDate")
                            newnotif.ltime = dr("lTime")
                            newnotif.username = dr("username")
                            newnotif.edit = dr("edit")
                            alertList.Add(newnotif)
                            alertCount = alertList.Count
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Sub markRead(ID)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\edits.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("UPDATE edits SET [read] = 1 WHERE ID = " + ID, conn) 'Selects unread edits
            End Using
        End Using
        alertCount = alertList.Count
    End Sub
End Module