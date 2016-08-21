Imports System.Data.OleDb
Public Class eventResults
    Dim peopleNotAdded As List(Of String)
    Dim notes As List(Of String)
    Private Sub cmbGroup_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroup.SelectedValueChanged
        Cursor.Current = Cursors.AppStarting
        For Each panel In flpAthletes.Controls.OfType(Of Panel)()
            For Each label In panel.Controls.OfType(Of Label)()
                If label.Name = "lblId" Then
                    If notes.Contains(LTrim(label.Text.Split(":")(1))) = False Then
                        For Each chb In panel.Controls.OfType(Of CheckBox)()
                            If chb.Name = "chbNote" Then
                                If chb.Checked = True Then
                                    Dim message As String = createEvent.getName(LTrim(label.Text.Split(":")(1))) + " currently not saved as having submitted a note"
                                    peopleNotAdded.Add(message)
                                End If
                                Exit For
                            End If
                        Next
                    Else
                        For Each chb In panel.Controls.OfType(Of CheckBox)()
                            If chb.Name = "chbNote" Then
                                If chb.Checked = False Then
                                    Dim message As String = createEvent.getName(LTrim(label.Text.Split(":")(1))) + " currently incorrectly saved as having submitted a note"
                                    peopleNotAdded.Add(message)
                                End If
                                Exit For
                            End If
                        Next
                    End If
                    Exit For
                End If
            Next
        Next
        If peopleNotAdded.Count > 0 Then
            shownNotAdded = False
            confirmAddition.Tag = "people"
            confirmAddition.ShowDialog()
            peopleNotAdded.Clear()
        End If
        flpAthletes.Controls.Clear()
        Dim athletes = Nothing
        Select Case cmbGroup.SelectedItem
            Case "U13" : athletes = getWholeAgeGroup("U13")
            Case "U14" : athletes = getWholeAgeGroup("U14")
            Case "U15" : athletes = getWholeAgeGroup("U15")
            Case "U16" : athletes = getWholeAgeGroup("U16")
            Case "U17" : athletes = getWholeAgeGroup("U17")
            Case "Opens" : athletes = getWholeAgeGroup("Opens")
        End Select
        For Each person In athletes
            createAthletePanel(person)
        Next
        For Each athleteID In attendees
            If athleteID <> attendees(attendees.Count - 1) Then
                tickAthletes(athleteID, False)
            Else
                tickAthletes(athleteID, True)
            End If
        Next
        For Each athleteID In notes
            If athleteID <> attendees(attendees.Count - 1) Then
                tickNotes(athleteID, False)
            Else
                tickNotes(athleteID, True)
            End If
        Next
        checkAllChecked()
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim notesAdded As Integer = 0, notesRemoved As Integer = 0
        For Each panel In flpAthletes.Controls.OfType(Of Panel)()
            For Each label In panel.Controls.OfType(Of Label)()
                If label.Name = "lblId" Then
                    If notes.Contains(LTrim(label.Text.Split(":")(1))) = False Then
                        For Each chb In panel.Controls.OfType(Of CheckBox)()
                            If chb.Name = "chbNote" Then
                                If chb.Checked = True Then
                                    notes.Add(LTrim(label.Text.Split(":")(1)))
                                    notesAdded += 1
                                End If
                                Exit For
                            End If
                        Next
                    Else
                        For Each chb In panel.Controls.OfType(Of CheckBox)()
                            If chb.Name = "chbNote" Then
                                If chb.Checked = False Then
                                    notes.Remove(LTrim(label.Text.Split(":")(1)))
                                    notesRemoved += 1
                                End If
                                Exit For
                            End If
                        Next
                    End If
                End If
                Exit For
            Next
        Next
        If notesAdded = 0 And notesRemoved = 0 Then
            MessageBox.Show("No changes were made to the submitted notes.", "No changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf notesAdded = 1 And notesRemoved <> 1 Then
            MessageBox.Show(notesAdded.ToString() & " note was added and " & notesRemoved.ToString() & " were removed.", "Notes changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf notesAdded <> 1 And notesRemoved = 1 Then
            MessageBox.Show(notesAdded.ToString() & " notes were added and " & notesRemoved.ToString() & " was removed.", "Notes changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(notesAdded.ToString() & " notes were added and " & notesRemoved.ToString() & " were removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Function getNotesAgeGroup(ByVal ageGroup As String)
        Dim ageAthletes As New List(Of String)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT * FROM athleteDb WHERE AgeGroup = @age", conn) '*takes the column with correct rows
                cmd.Parameters.Add(New OleDbParameter("@age", ageGroup))
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim newPerson As String = dr("FirstName") & " " & dr("LastName") & ";" & dr("ID")
                            ageAthletes.Add(newPerson)
                        Loop
                    End If
                End Using
            End Using
            conn.Close()
        End Using
        Return ageAthletes.ToArray()
    End Function
    'Private Sub createAthletePanel(info As String)
    '    'info is in the form: name; id; rollclass; averages; recents; unexplained
    '    Dim pnl As New Panel
    '    With pnl
    '        .BackColor = Color.Gray
    '        .Size = New Size(348, 56)
    '        .Cursor = Cursors.Hand
    '    End With
    '    flpAthletes.Controls.Add(pnl)
    '    AddHandler pnl.Click, AddressOf athletePanel_Click
    '    Dim chbAthelte As New CheckBox
    '    With chbAthelte
    '        .Name = "chbAthlete"
    '        .Font = New Font("Microsoft Sans Serif", 8)
    '        .Text = "Attending"
    '        .Location = New Point(272, 15)
    '    End With
    '    pnl.Controls.Add(chbAthelte)
    '    chbAthelte.BringToFront()
    '    Dim chbNote As New CheckBox
    '    With chbNote
    '        .Name = "chbNote"
    '        .Font = New Font("Microsoft Sans Serif", 8)
    '        .Text = "Needs Note"
    '        .Location = New Point(272, 36)
    '    End With
    '    pnl.Controls.Add(chbNote)
    '    chbNote.BringToFront()
    '    AddHandler chbNote.Click, AddressOf chbNote_Click
    '    Dim pb As New PictureBox
    '    With pb
    '        .Image = My.Resources.transparent_plus
    '        .Size = New Size(74, 56)
    '        .SizeMode = PictureBoxSizeMode.StretchImage
    '        .Name = "pbAthlete"
    '        .Cursor = Cursors.Hand
    '    End With
    '    pnl.Controls.Add(pb)
    '    AddHandler pb.Click, AddressOf athletePanel_Click
    '    pb.Location = New Point(0, 0)
    '    Dim lblName As New Label
    '    With lblName
    '        .Font = New Font("Microsoft Sans Serif", 8)
    '        .Text = "Name: " & info.Split(";")(0)
    '        .Name = "lblName"
    '        .AutoSize = True
    '        .Cursor = Cursors.Hand
    '    End With
    '    pnl.Controls.Add(lblName)
    '    AddHandler lblName.Click, AddressOf athletePanel_Click
    '    lblName.Location = New Point(81, 0)
    '    Dim lblId As New Label
    '    With lblId
    '        .Font = New Font("Microsoft Sans Serif", 8)
    '        .Text = "ID: " & info.Split(";")(1)
    '        .Name = "lblId"
    '        .AutoSize = True
    '        .Cursor = Cursors.Hand
    '    End With
    '    AddHandler lblId.Click, AddressOf athletePanel_Click
    '    pnl.Controls.Add(lblId)
    '    lblId.Location = New Point(272, 0)
    '    'Dim lblRollClass As New Label
    '    'With lblRollClass
    '    '    .Font = New Font("Microsoft Sans Serif", 8)
    '    '    .Text = "Class: " & info.Split(";")(2)
    '    '    .Name = "lblRollClass"
    '    '    .AutoSize = True
    '    '    .Cursor = Cursors.Hand
    '    'End With
    '    'pnl.Controls.Add(lblRollClass)
    '    'AddHandler lblRollClass.Click, AddressOf athletePanel_Click
    '    'lblRollClass.Location = New Point(291, 37)
    '    Dim lblAverages As New Label
    '    With lblAverages
    '        .Font = New Font("Microsoft Sans Serif", 8)
    '        .Text = "Averages: " & info.Split(";")(3)
    '        .Name = "lblAverages"
    '        .AutoSize = True
    '        .Cursor = Cursors.Hand
    '    End With
    '    pnl.Controls.Add(lblAverages)
    '    AddHandler lblAverages.Click, AddressOf athletePanel_Click
    '    lblAverages.Location = New Point(81, 17)
    '    Dim lblRecents As New Label
    '    With lblRecents
    '        .Font = New Font("Microsoft Sans Serif", 8)
    '        .Text = "Recents: " & info.Split(";")(4)
    '        .Name = "lblRecents"
    '        .AutoSize = True
    '        .Cursor = Cursors.Hand
    '    End With
    '    pnl.Controls.Add(lblRecents)
    '    AddHandler lblRecents.Click, AddressOf athletePanel_Click
    '    lblRecents.Location = New Point(81, 36)
    '    'Dim lblUnexplained As New Label
    '    'With lblUnexplained
    '    '    .Font = New Font("Microsoft Sans Serif", 8)
    '    '    .Text = "Unexplained: " & info.Split(";")(5)
    '    '    .Name = "lblUnexplained"
    '    '    .AutoSize = True
    '    'End With
    '    'pnl.Controls.Add(lblUnexplained)
    '    'AddHandler lblUnexplained.Click, AddressOf athletePanel_Click
    '    'lblUnexplained.Location = New Point(272, 36)
    'End Sub
    'Private Sub chbNote_Click(sender As Object, e As EventArgs)
    '    checkAllChecked()
    'End Sub
    'Private Sub athletePanel_Click(sender As Object, e As EventArgs)
    '    Dim pnl As Panel
    '    If sender.GetType() Is GetType(Panel) Then
    '        pnl = sender
    '    Else
    '        pnl = sender.parent
    '    End If
    '    For Each chb In pnl.Controls.OfType(Of CheckBox)()
    '        If chb.Name = "chbAthlete" Then
    '            If chb.Checked = True Then
    '                chb.Checked = False
    '            Else
    '                chb.Checked = True
    '            End If
    '            Exit For
    '        End If
    '    Next
    '    checkAllChecked()
    'End Sub
End Class