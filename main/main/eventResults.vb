Imports System.Data.OleDb
Public Class eventResults
    Public Shared notesNotAdded As New List(Of String) From {}
    Public Shared newNotes As New List(Of String) From {} 'any new notes given in the current entry
    Public Shared editMade As Boolean = False
    Dim loadThread As Threading.Thread = New Threading.Thread(Sub() loadVariables())
    Private Sub cmbGroup_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroup.SelectedValueChanged
        Cursor.Current = Cursors.AppStarting
        flpAthletes.Enabled = True
        chbAllNotes.Enabled = True
        btnSelect.Enabled = True
        lblNotes.Visible = False
        If cmbGroup.Tag <> "template" Then
            For Each panel In flpAthletes.Controls.OfType(Of Panel)()
                For Each label In panel.Controls.OfType(Of Label)()
                    If label.Name = "lblId" Then
                        Dim id = LTrim(label.Text.Split(":")(1))
                        For Each chb In panel.Controls.OfType(Of CheckBox)()
                            If chb.Name = "chbNote" Then
                                If chb.Checked = True Then
                                    If newNotes.Contains(id) = False Then
                                        Dim message As String = createEvent.getName(id) + " currently not saved as having submitted a note"
                                        notesNotAdded.Add(message)
                                    End If
                                Else
                                    If newNotes.Contains(id) Then
                                        Dim message As String = createEvent.getName(id) + " currently incorrectly saved as having submitted a note"
                                        notesNotAdded.Add(message)
                                    End If
                                End If
                                Exit For
                            End If
                        Next
                        Exit For
                    End If
                Next
            Next
        Else
            cmbGroup.Tag = ""
        End If
        If notesNotAdded.Count > 0 Then
            shownNotAdded = False
            confirmAddition.Tag = "results"
            confirmAddition.ShowDialog()
            notesNotAdded.Clear()
        End If
        flpAthletes.Controls.Clear()
        Dim athletes = Nothing
        Select Case cmbGroup.SelectedItem
            Case "U13" : athletes = getAgeGroupWithNotes("U13")
            Case "U14" : athletes = getAgeGroupWithNotes("U14")
            Case "U15" : athletes = getAgeGroupWithNotes("U15")
            Case "U16" : athletes = getAgeGroupWithNotes("U16")
            Case "U17" : athletes = getAgeGroupWithNotes("U17")
            Case "Opens" : athletes = getAgeGroupWithNotes("Opens")
        End Select
        If athletes.Count > 0 Then
            For Each person In athletes
                createAthletePanel(person)
            Next
            For Each athleteID In newNotes
                If athleteID <> newNotes(newNotes.Count - 1) Then
                    tickNotes(athleteID, False)
                Else
                    tickNotes(athleteID, True)
                End If
            Next
            checkAllChecked()
        Else
            flpAthletes.Enabled = False
            chbAllNotes.Enabled = False
            btnSelect.Enabled = False
            lblNotes.Visible = True
            lblNotes.Font = New Font("Microsoft Sans Serif", 15)
            lblNotes.Enabled = False
            lblNotes.Location = New Point(25, 150)
        End If
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub tickNotes(ByVal idNum, ByVal last)
        For Each panel In flpAthletes.Controls.OfType(Of Panel)()
            For Each label In panel.Controls.OfType(Of Label)()
                If label.Name = "lblId" Then
                    If label.Text.Contains(idNum) Then
                        For Each chb In panel.Controls.OfType(Of CheckBox)()
                            If chb.Name = "chbNote" Then
                                chb.Checked = True
                                Exit For
                            End If
                        Next
                    End If
                    Exit For
                End If
            Next
            If last = True Then
                checkAllChecked()
            End If
        Next
    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim added As Integer = 0, removed As Integer = 0
        For Each panel In flpAthletes.Controls.OfType(Of Panel)()
            For Each label In panel.Controls.OfType(Of Label)()
                If label.Name = "lblId" Then
                    Dim id = LTrim(label.Text.Split(":")(1))
                    For Each chb In panel.Controls.OfType(Of CheckBox)()
                        If chb.Name = "chbNote" Then
                            If chb.Checked = True Then
                                If newNotes.Contains(id) = False Then
                                    newNotes.Add(id)
                                    added += 1
                                End If
                            Else
                                If newNotes.Contains(id) = True Then
                                    newNotes.Remove(id)
                                    removed += 1
                                End If
                            End If
                            Exit For
                        End If
                    Next
                    Exit For
                End If
            Next
        Next
        If added = 0 And removed = 0 Then
            MessageBox.Show("No changes were made to the submitted notes.", "No changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added = 1 And removed <> 1 Then
            MessageBox.Show(added.ToString() & " note was added and " & removed.ToString() & " were removed.", "Notes changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added <> 1 And removed = 1 Then
            MessageBox.Show(added.ToString() & " notes were added and " & removed.ToString() & " was removed.", "Notes changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added = 1 And removed = 1 Then
            MessageBox.Show(added.ToString() & " note was added and " & removed.ToString() & " was removed.", "Notes changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(added.ToString() & " notes were added and " & removed.ToString() & " were removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Function getAgeGroupWithNotes(ByVal ageGroup As String)
        Dim ageAthletes As New List(Of String) From {}
        Dim eventNotes = getNotes()
        For Each note In eventNotes
            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb")
                conn.Open()
                Using cmd As New OleDbCommand("SELECT * FROM athleteDb WHERE ID = @id AND AgeGroup = @age", conn) '*takes the column with correct rows
                    cmd.Parameters.Add(New OleDbParameter("@id", note))
                    cmd.Parameters.AddWithValue("@age", ageGroup)
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
        Next
        Return ageAthletes
    End Function
    Private Function getNotes()
        Dim eventNotes As String = ""
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT Notes FROM Events WHERE EventName = @name AND EventDate = @date", conn) '*takes the column with correct rows
                Dim tagSplit = Me.Tag.split(" ")
                Dim name As String = ""
                For part As Integer = 0 To tagSplit.Length - 2
                    If part <> tagSplit.Length - 2 Then
                        name += tagSplit(part) + " "
                    Else
                        name += tagSplit(part)
                    End If
                Next
                cmd.Parameters.AddWithValue("@name", RTrim(name))
                cmd.Parameters.AddWithValue("@date", tagSplit(tagSplit.Length - 1))
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            If dr(0).ToString() <> "" Then
                                eventNotes = dr(0)
                            Else
                                Return New List(Of String) From {}
                            End If
                        Loop
                    Else
                        Return New List(Of String) From {}
                    End If
                End Using
            End Using
            conn.Close()
        End Using
        Dim eventList = eventNotes.Split(";")
        Return eventList.ToList()
    End Function
    Private Function getAlreadyInNotes()
        Dim notesIn As String = ""
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT NotesGiven FROM Events WHERE EventName = @name AND EventDate = @date AND NotesGiven ", conn) '*takes the column with correct rows
                Dim tagSplit = Me.Tag.split(" ")
                Dim name As String = ""
                For part As Integer = 0 To tagSplit.Length - 2
                    If part <> tagSplit.Length - 2 Then
                        name += tagSplit(part) + " "
                    Else
                        name += tagSplit(part)
                    End If
                Next
                cmd.Parameters.AddWithValue("@name", RTrim(name))
                cmd.Parameters.AddWithValue("@date", tagSplit(tagSplit.Length - 1))
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            If dr(0).ToString() <> "" Then
                                notesIn = dr(0)
                            Else
                                Return New List(Of String) From {}
                            End If
                        Loop
                    Else
                        Return New List(Of String) From {}
                    End If
                End Using
            End Using
            conn.Close()
        End Using
        Dim eventList = notesIn.Split(";")
        Return eventList.ToList()
    End Function
    Private Function getAgeGroupByName(name)
        Dim age As String = ""
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT AgeGroup FROM athleteDb WHERE LastName = ? AND FirstName = ?", conn) '*takes the column with correct rows
                Dim nameSplit() As String = name.Split(" ")
                Dim p1 = cmd.CreateParameter()
                p1.Value = nameSplit(nameSplit.Count - 1)
                cmd.Parameters.Add(p1)
                Dim tempList = nameSplit.ToList()
                tempList.RemoveAt(nameSplit.Count - 1)
                Dim p2 = cmd.CreateParameter()
                p2.Value = String.Join(" ", tempList)
                cmd.Parameters.Add(p2)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            age = dr(0)
                        Loop
                    End If
                End Using
            End Using
            conn.Close()
        End Using
        Return age
    End Function
    Private Sub createAthletePanel(info As String)
        'info is in the form: name; id; rollclass; averages; recents; unexplained
        Dim pnl As New Panel
        With pnl
            .BackColor = Color.Gray
            .Size = New Size(348, 56)
            .Cursor = Cursors.Hand
        End With
        flpAthletes.Controls.Add(pnl)
        AddHandler pnl.Click, AddressOf athletePanel_Click
        Dim chbNote As New CheckBox
        With chbNote
            .Name = "chbNote"
            .Font = New Font("Microsoft Sans Serif", 12)
            .Text = "Submitted Note"
            .AutoSize = True
            .Location = New Point(210, 22)
        End With
        pnl.Controls.Add(chbNote)
        chbNote.BringToFront()
        AddHandler chbNote.Click, AddressOf chbNote_Click
        Dim pb As New PictureBox
        With pb
            .Image = My.Resources.transparent_plus
            .Size = New Size(74, 56)
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Name = "pbAthlete"
            .Cursor = Cursors.Hand
        End With
        pnl.Controls.Add(pb)
        AddHandler pb.Click, AddressOf athletePanel_Click
        pb.Location = New Point(0, 0)
        Dim lblName As New Label
        With lblName
            .Font = New Font("Microsoft Sans Serif", 12)
            .Text = "Name: " & info.Split(";")(0)
            .Name = "lblName"
            .AutoSize = True
            .Cursor = Cursors.Hand
        End With
        pnl.Controls.Add(lblName)
        AddHandler lblName.Click, AddressOf athletePanel_Click
        lblName.Location = New Point(81, 4)
        Dim lblId As New Label
        With lblId
            .Font = New Font("Microsoft Sans Serif", 12)
            .Text = "ID: " & info.Split(";")(1)
            .Name = "lblId"
            .AutoSize = True
            .Cursor = Cursors.Hand
        End With
        AddHandler lblId.Click, AddressOf athletePanel_Click
        pnl.Controls.Add(lblId)
        lblId.Location = New Point(81, 30)
    End Sub
    Private Sub chbNote_Click(sender As Object, e As EventArgs)
        checkAllChecked()
    End Sub
    Private Sub athletePanel_Click(sender As Object, e As EventArgs)
        Dim pnl As Panel
        If sender.GetType() Is GetType(Panel) Then
            pnl = sender
        Else
            pnl = sender.parent
        End If
        For Each chb In pnl.Controls.OfType(Of CheckBox)()
            If chb.Name = "chbNote" Then
                If chb.Checked = True Then
                    chb.Checked = False
                Else
                    chb.Checked = True
                End If
                Exit For
            End If
        Next
        checkAllChecked()
    End Sub
    Private Sub checkAllChecked()
        Dim checkedNote As Integer = 0
        For Each panel In flpAthletes.Controls.OfType(Of Panel)()
            For Each chb In panel.Controls.OfType(Of CheckBox)()
                If chb.Name = "chbNote" Then
                    If chb.Checked = True Then
                        checkedNote += 1
                    End If
                    Exit For
                End If
            Next
        Next
        If checkedNote <> createEvent.flpAthletes.Controls.OfType(Of Panel)().Count Then
            createEvent.chbAllNotes.Checked = False
        Else
            createEvent.chbAllNotes.Checked = True
        End If
    End Sub
    Private Sub chbAllNotes_Click(sender As Object, e As EventArgs) Handles chbAllNotes.Click
        If chbAllNotes.Checked = True Then
            For Each panel In flpAthletes.Controls.OfType(Of Panel)()
                For Each chb In panel.Controls.OfType(Of CheckBox)()
                    If chb.Name = "chbNote" Then
                        chb.Checked = True
                        Exit For
                    End If
                Next
            Next
        Else
            For Each panel In flpAthletes.Controls.OfType(Of Panel)()
                For Each chb In panel.Controls.OfType(Of CheckBox)()
                    If chb.Name = "chbNote" Then
                        chb.Checked = False
                        Exit For
                    End If
                Next
            Next
        End If
    End Sub
    Private Sub loadVariables()
        newNotes = getAlreadyInNotes()
    End Sub
    Private Sub eventResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadThread.Start()
        cmbGroup.SelectedIndex = 0
    End Sub
    Private Sub pnlAttach_Click(sender As Object, e As EventArgs) Handles pnlAttach.Click
        If pbAttach.Tag = "add" Then
            ofdOpen.FileName = ""
            ofdOpen.Filter = "Text Files (*.txt)|*.txt"
            ofdOpen.ShowDialog()
            If ofdOpen.FileName <> "" Then
                editMade = False
                pbAttach.Location = New Point(-1, -1)
                Dim backSplit = ofdOpen.FileName.Split("\")
                pbAttach.Tag = backSplit(backSplit.Count - 1)
                pbAttach.Image = My.Resources.iconNotepad
                Dim lbl As New Label
                lbl.Cursor = Cursors.Default
                lbl.Font = New Drawing.Font("Arial", 9)
                lbl.Text = pbAttach.Tag
                pnlAttach.Controls.Add(lbl)
                lbl.Parent = pnlAttach
                lbl.Location = New Point(75, 0)
                lbl.AutoSize = True
                lbl.BackColor = Color.Transparent
                lbl.BringToFront()
            End If
        Else
            saveOrOpen.Tag = "results"
            saveOrOpen.ShowDialog()
            If saveOrOpen.result = "save" Then
                sfdSave.FileName = IO.Path.GetFileNameWithoutExtension(ofdOpen.FileName) + " Edit.txt"
                sfdSave.Filter = "Text Files (*.txt)|*.txt"
                sfdSave.ShowDialog()
                Using writer As IO.StreamWriter = New IO.StreamWriter(sfdSave.FileName)
                    Dim k = rchTxt.Text.Split(ControlChars.Lf)
                    For Each line In k
                        writer.WriteLine(line)
                    Next
                End Using
                If MessageBox.Show("Would you like to use this edited file for your results?", "Confirm Results File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    pbAttach.Tag = IO.Path.GetFileNameWithoutExtension(sfdSave.FileName) + ".txt"
                    For Each lbl In pnlAttach.Controls.OfType(Of Label)
                        lbl.Text = pbAttach.Tag
                    Next
                    ofdOpen.FileName = sfdSave.FileName
                End If
            ElseIf saveOrOpen.result = "open" Then
                rchTxt.Enabled = True
                lblEdit.Enabled = True
                Using reader As IO.StreamReader = New IO.StreamReader(ofdOpen.FileName)
                    Dim line As String
                    line = reader.ReadLine()
                    Do While (line IsNot Nothing)
                        rchTxt.Text += line + vbNewLine
                        line = reader.ReadLine()
                    Loop
                End Using
                rchTxt.Tag = ""
            ElseIf saveOrOpen.result = "delete" Then
                pbAttach.Location = New Point(114, 0)
                pbAttach.Image = My.Resources.transparent_plus
                editMade = False
                lblEdit.Enabled = False
                rchTxt.Enabled = False
                rchTxt.Text = ""
                rchTxt.Tag = "empty"
                For Each lbl In pnlAttach.Controls.OfType(Of Label)
                    pnlAttach.Controls.Remove(lbl)
                    Exit For
                Next
            End If
        End If
    End Sub
    Private Sub pbAttach_Click(sender As Object, e As EventArgs) Handles pbAttach.Click
        pnlAttach_Click(Nothing, Nothing)
    End Sub
    Private Sub rchTxt_TextChanged(sender As Object, e As EventArgs) Handles rchTxt.TextChanged
        If rchTxt.Tag <> "empty" Then
            Dim txt As String = ""
            Using reader As IO.StreamReader = New IO.StreamReader(ofdOpen.FileName)
                Dim line As String
                line = reader.ReadLine()
                Do While (line IsNot Nothing)
                    txt += line + vbNewLine
                    line = reader.ReadLine()
                Loop
            End Using
            If txt = rchTxt.Text Then
                editMade = False
            Else
                editMade = True
            End If
        End If
    End Sub
    Private Sub eventResults_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        If btnSaveEvent.Tag <> "saved" Then
            If MessageBox.Show("Are you sure you want to close the form?" + vbNewLine + "If there is information that has not been saved, it will be lost.", "Close Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                notesNotAdded.Clear()
                newNotes.Clear()
                editMade = False
            Else
                e.Cancel = True
            End If
        Else
            btnSaveEvent.Tag = ""
            notesNotAdded.Clear()
            newNotes.Clear()
            editMade = False
        End If
        calendar.calendar_Load(Nothing, Nothing)
    End Sub
    'how are you going to keep the text file there when you open the same thing after save?
    'maybe add into attachments?
    'what about new results being added?
    'remove the previous results for that event and rewrite
    'provide warning that ALL results need to be included
    'when generating toolstripitem, yellow for only one, green for two
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnSaveEvent_Click(sender As Object, e As EventArgs) Handles btnSaveEvent.Click
        'update the notes handed in
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("UPDATE Events SET NotesGiven = ? WHERE EventName = @name AND EventDate = @date", conn)
                Dim notesGiven As String = ""
                For note As Integer = 0 To newNotes.Count - 1
                    If note = 0 Then
                        notesGiven = newNotes(note)
                    Else
                        notesGiven += ";" & newNotes(note)
                    End If
                Next
                Dim p1 = cmd.CreateParameter()
                p1.Value = notesGiven
                cmd.Parameters.Add(p1)
                Dim tagSplit = Me.Tag.split(" ")
                Dim name As String = ""
                For part As Integer = 0 To tagSplit.Length - 2
                    If part <> tagSplit.Length - 2 Then
                        name += tagSplit(part) + " "
                    Else
                        name += tagSplit(part)
                    End If
                Next
                cmd.Parameters.AddWithValue("@name", RTrim(name))
                cmd.Parameters.AddWithValue("@date", tagSplit(tagSplit.Length - 1))
            End Using
            conn.Close()
        End Using
        Dim resultsAdded As Boolean = False, changes As Integer = 0
        If pbAttach.Tag <> "add" Then
            If MessageBox.Show("If previous results have been entered they will all be deleted and the new results will be entered." + vbNewLine + "Would you like to continue?", "New Results", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'delete all previous results if they exist
                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb")
                    conn.Open()
                    Using cmd As New OleDbCommand("DELETE FROM resultsDb WHERE MeetName = @name AND EventDate = @date", conn)
                        Dim tagSplit = Me.Tag.split(" ")
                        Dim name As String = ""
                        For part As Integer = 0 To tagSplit.Length - 2
                            If part <> tagSplit.Length - 2 Then
                                name += tagSplit(part) + " "
                            Else
                                name += tagSplit(part)
                            End If
                        Next
                        cmd.Parameters.AddWithValue("@name", RTrim(name))
                        cmd.Parameters.AddWithValue("@date", tagSplit(tagSplit.Length - 1))
                        cmd.ExecuteNonQuery()
                    End Using
                    conn.Close()
                End Using
                'read the results file and add the results
                Using reader As IO.StreamReader = New IO.StreamReader(ofdOpen.FileName)
                    Dim line As String
                    line = reader.ReadLine()
                    Do While (line IsNot Nothing)
                        Dim splitLine = line.Split(" ")
                        If line.Contains("4x100m") Then
                            Dim commaSplit = line.Split(",")
                            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb")
                                conn.Open()
                                Using cmd As New OleDbCommand("INSERT INTO resultsDb (AthleteName, AgeGroup, Result, MeetName, EventName, EventDate) VALUES (@person, @age, @result, @name, @event, @date)", conn)
                                    Dim tagSplit = Me.Tag.split(" ")
                                    Dim name As String = ""
                                    For part As Integer = 0 To tagSplit.Length - 2
                                        If part <> tagSplit.Length - 2 Then
                                            name += tagSplit(part) + " "
                                        Else
                                            name += tagSplit(part)
                                        End If
                                    Next
                                    Dim tempList = splitLine.ToList()
                                    tempList.RemoveAt(tempList.Count - 1)
                                    tempList.RemoveAt(tempList.Count - 1)
                                    cmd.Parameters.AddWithValue("@person", String.Join(" ", tempList))
                                    cmd.Parameters.AddWithValue("@age", getAgeGroupByName(commaSplit(0)))
                                    cmd.Parameters.AddWithValue("@result", splitLine(splitLine.Count - 1))
                                    cmd.Parameters.AddWithValue("@name", RTrim(name))
                                    cmd.Parameters.AddWithValue("@event", "4x100m")
                                    cmd.Parameters.AddWithValue("@date", tagSplit(tagSplit.Length - 1))
                                    changes += cmd.ExecuteNonQuery()
                                End Using
                                conn.Close()
                            End Using
                        Else
                            Dim name As String = ""
                            For index = splitLine.Count - 1 To 1 Step -2
                                If Char.IsDigit(splitLine(index)) = False Then
                                    Dim tempList = splitLine.ToList
                                    tempList.RemoveRange(index + 1, splitLine.Count - (index + 1))
                                    name = String.Join(" ", tempList)
                                    Exit For
                                End If
                            Next
                            For i = splitLine.Count - 1 To 1 Step -2
                                If Char.IsDigit(splitLine(i)) Then
                                    Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb")
                                        conn.Open()
                                        'paramaters to wrong field?
                                        Using cmd As New OleDbCommand("INSERT INTO resultsDb (AthleteName, AgeGroup, Result, MeetName, EventName, EventDate) VALUES (@person, @age, @result, @name, @event, @date)", conn)
                                            Dim tagSplit = Me.Tag.split(" ")
                                            Dim evName As String = ""
                                            For part As Integer = 0 To tagSplit.Length - 2
                                                If part <> tagSplit.Length - 2 Then
                                                    evName += tagSplit(part) + " "
                                                Else
                                                    evName += tagSplit(part)
                                                End If
                                            Next
                                            cmd.Parameters.AddWithValue("@person", name)
                                            cmd.Parameters.AddWithValue("@age", getAgeGroupByName(name))
                                            cmd.Parameters.AddWithValue("@result", splitLine(i))
                                            cmd.Parameters.AddWithValue("@name", RTrim(evName))
                                            cmd.Parameters.AddWithValue("@event", splitLine(i - 1))
                                            cmd.Parameters.AddWithValue("@date", tagSplit(tagSplit.Length - 1))
                                            changes += cmd.ExecuteNonQuery()
                                        End Using
                                        conn.Close()
                                    End Using
                                End If
                            Next
                        End If
                        line = reader.ReadLine()
                    Loop
                End Using
                'check if the results file exists and then either add or update
                Dim hasMatch As Boolean = False
                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                    conn.Open()
                    Using cmd As New OleDbCommand("SELECT FileName FROM Attachments WHERE FileName = @name", conn)
                        Dim splitPath = ofdOpen.FileName.Split("\")
                        cmd.Parameters.AddWithValue("@name", splitPath(splitPath.Count - 1))
                        Using dr = cmd.ExecuteReader()
                            If dr.HasRows Then
                                Do While dr.Read()
                                    hasMatch = True
                                Loop
                            Else
                                hasMatch = False
                            End If
                        End Using
                    End Using
                End Using
                If hasMatch = False Then
                    Using fs As New System.IO.FileStream(ofdOpen.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                        Dim myData(fs.Length) As Byte
                        fs.Read(myData, 0, fs.Length)
                        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                            conn.Open()
                            Using cmd As New OleDbCommand("INSERT INTO Attachments (FileName, FileInfo) VALUES (@name, @attachment)", conn) 'INSERT INTO Attachments (FileName, FileInfo) VALUES (@name, @attachment)
                                Dim splitPath = ofdOpen.FileName.Split("\")
                                cmd.Parameters.AddWithValue("@name", splitPath(splitPath.Count - 1))
                                cmd.Parameters.Add("@attachments", OleDbType.VarBinary, fs.Length).Value = myData
                                cmd.ExecuteNonQuery()
                            End Using
                        End Using
                    End Using
                Else
                    Using fs As New System.IO.FileStream(ofdOpen.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                        Dim myData(fs.Length) As Byte
                        fs.Read(myData, 0, fs.Length)
                        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                            conn.Open()
                            Using cmd As New OleDbCommand("UPDATE Attachments SET FileInfo = @attachment WHERE FileName = @name", conn)
                                Dim splitPath = ofdOpen.FileName.Split("\")
                                cmd.Parameters.Add("@attachment", OleDbType.VarBinary, fs.Length).Value = myData
                                cmd.Parameters.AddWithValue("@name", splitPath(splitPath.Count - 1))
                                cmd.ExecuteNonQuery()
                            End Using
                        End Using
                    End Using
                End If
            End If
        End If
        btnSaveEvent.Tag = "saved"
        If changes <> 0 Then
            MessageBox.Show("Notes handed in were updated and results were saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Notes handed in were updated.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Close()
    End Sub
End Class