Imports System.Data.OleDb

Module common
    Public Function populate(append As String, list As List(Of athlete))
        list.Clear()
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, RollClass, FirstName, LastName FROM athleteDb" + append, conn)
                'Need to add photo
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim ath As New athlete
                            ath.ID = dr("ID")
                            ath.roll = dr("RollClass")
                            ath.fName = dr("FirstName")
                            ath.lName = dr("LastName")
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

    Public Sub refreshFlp(cmdA As ComboBox, cmbS As ComboBox, list As List(Of athlete))
        If cmdA.SelectedItem <> Nothing Then
            list = populate(" WHERE AgeGroup = '" + cmdA.SelectedItem.ToString + "'", list)
        Else
            list = populate("", list)
        End If
        list = sort(cmbS, list)
    End Sub
End Module
