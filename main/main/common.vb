﻿Imports System.Data.OleDb

Module common
    Public Sub newEdit(changeType As String, changeMade As String) 'Appends the edit log with a new edit
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
            Case "misNotes"
                edit = ("Missing notes " + changeMade)
            Case "custom"
                edit = (changeMade)
        End Select
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("INSERT INTO editDb (username, edit, lDate, lTime) VALUES (@edit, @username, @lDate, @lTime)", conn) 'Appends the database with a new edit
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
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, lDate, lTime, edit, username FROM editDb WHERE [read] = 0", conn) 'Selects unread edits
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim newnotif As New notif With
                                {
                                .ID = dr("ID"),
                                .ldate = dr("lDate"),
                                .ltime = dr("lTime"),
                                .username = dr("username"),
                                .edit = dr("edit")
                                }
                            alertList.Add(newnotif)
                            alertCount = alertList.Count
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Function getNotifCount()
        alertCount = 0
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT * FROM editDb WHERE [read] = 0", conn) 'Selects unread edits
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            alertCount += 1
                        Loop
                    End If
                End Using
            End Using
        End Using
        Return alertCount
    End Function

    Public Sub markRead(ID)
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("UPDATE editDb SET [read] = 1 WHERE ID = " + ID, conn) 'Marks edits as read using the given ID
                cmd.ExecuteNonQuery()
            End Using
        End Using
        alertCount = alertList.Count
    End Sub

    Public Function populate(list As List(Of athlete))
        list.Clear()
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, RollClass, FirstName, LastName, AgeGroup FROM athleteDb", conn)
                'Need to add photo
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim ath As New athlete
                            ath.ID = dr("ID")
                            ath.roll = dr("RollClass")
                            ath.fName = dr("FirstName")
                            ath.lName = dr("LastName")
                            ath.ageGroup = dr("AgeGroup")
                            list.Add(ath)
                        Loop
                    End If
                End Using
            End Using
        End Using
        Return list
    End Function

    Public Function sort(cmb As ComboBox, list As List(Of athlete)) 'cmb should be the 'Sort by' combobox
        If cmb.SelectedItem <> Nothing Then 'Sorting
            Dim asc As Boolean = True
            Select Case cmb.SelectedItem.ToString
                Case "ID"
                    list.Sort(Function(x, y) x.ID.CompareTo(y.ID))

                Case "Roll Class" 'Not working yet
                    asc = False
                    list.Sort(Function(x, y) x.roll.CompareTo(y.roll))

                Case "First Name (Ascending)"
                    list.Sort(Function(x, y) x.fName.CompareTo(y.fName))

                Case "First Name (Descending)"
                    asc = False
                    list.Sort(Function(x, y) x.fName.CompareTo(y.fName))

                Case "Last Name (Ascending)"
                    list.Sort(Function(x, y) x.lName.CompareTo(y.lName))

                Case "Last Name (Descending)"
                    asc = False
                    list.Sort(Function(x, y) x.lName.CompareTo(y.lName))
            End Select

            If asc = False Then
                list.Reverse()
            End If
        End If
        Return list
    End Function

    Public Function updateSearched(searched As List(Of athlete), sorted As List(Of athlete))
        searched.Clear()
        searched.AddRange(sorted)
        Return searched
    End Function

    Public Function searchFilter(filter As TextBox, searched As List(Of athlete), sorted As List(Of athlete))
        searched.Clear()
        For Each ath As athlete In sorted
            If ath.fName.ToLower.Contains(filter.Text.ToLower) Or ath.lName.ToLower.Contains(filter.Text.ToLower) Or ath.ID.ToLower.Contains(filter.Text.ToLower) Then
                searched.Add(ath)
            End If
        Next
        Return searched
    End Function
End Module