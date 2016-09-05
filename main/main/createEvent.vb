
#Region "Imports"
Imports System.Data.OleDb
Imports System.IO.FileStream
Imports System.Threading
Imports Microsoft.Office.Interop
Imports GMap.NET
Imports GMap.NET.WindowsForms
#End Region
Public Class createEvent
#Region "Declarations"
    Public Shared attendees As New List(Of String) 'list of id's
    Public Shared times As New List(Of String) 'list of "event: time"
    Public Shared templateEvents As New List(Of String) From {"Enter the event name here 19/07/2016", "Testing all 21/07/2016"}
    Dim proxyPresent As Boolean = True
    Dim waitForDrop As Thread = Nothing
    'Attachments
    Dim filePaths As New List(Of String)
    Dim newAttachBoxLocation As Point = New Point(135, 377)
    Dim pbCount = 1
    Dim tempFilePath As String = ""
    'Office
    Private WithEvents wordApp As Word.Application
    Private WithEvents excelApp As Excel.Application
    Dim doc As Word.Document
    Dim workbook As Excel.Workbook
    Dim sheets As Excel.Workbooks
    Dim deleteWordFileThread As Thread = Nothing
    Dim deleteExcelFileThread As Thread = Nothing
    'Map
    Dim hasRunClickEvent As Boolean = False
    Dim tooManySelected As Boolean = False
    Dim waitThread As Thread = Nothing
    Dim mainThreadID As Integer = 0
    Dim overlayCount As Integer = 0
    Dim connectionPresent As Boolean = True
    'Events
    Dim created200 As Boolean = False
    Dim selected As String = "100"
    Public Shared timesNotAdded As New List(Of String)
    Public Shared previousDropSelection As String
    'Athletes
    Dim changesSaved As Boolean = False
    Public Shared peopleNotAdded As New List(Of String)
    Public Shared notes As New List(Of String)
#End Region
#Region "Dim Variables - JUN"
    Dim out As Boolean = False
    Dim cDrop As Boolean = False
    Dim rDrop As Boolean = False
    Dim cDown As Boolean = False
    Dim rDown As Boolean = False
    Dim atDrop As Boolean = False
    Dim atDown As Boolean = False
    Dim adDrop As Boolean = False
    Dim adDown As Boolean = False
    Dim jun As Integer = 0
#End Region
#Region "Form Operations"
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        calendar.Show()
        Me.Close()
    End Sub

    Private Sub btnSaveEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveEvent.Click
#Region "Add"
        Cursor.Current = Cursors.AppStarting
        If Me.Tag.contains("add") Then
            Dim nameDateMatch As Boolean = False
            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                conn.Open()
                Using cmd As New OleDbCommand("SELECT EventName, EventDate FROM Events WHERE EventName = @name AND EventDate = @date", conn) '*takes the column with correct rows
                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                    dtpDate.Format = DateTimePickerFormat.Short
                    cmd.Parameters.AddWithValue("@date", dtpDate.Text)
                    dtpDate.Format = DateTimePickerFormat.Long
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            Do While dr.Read()
                                nameDateMatch = True
                            Loop
                        Else
                            nameDateMatch = False
                        End If
                    End Using
                End Using
                conn.Close()
            End Using
            If nameDateMatch = False Then
                If attendees.Count > 0 AndAlso ((clbDays.CheckedItems.Count > 0 AndAlso cmbRepType.Text <> "") Or chbRepNA.Checked) AndAlso filePaths.Count > 0 AndAlso (times.Count > 0 Or chbNA.Checked = True) And map.Overlays.Count = 1 Then
                    'create repeating event functionality for 12 of the type
                    If chbRepNA.Checked = False Then
                        For day = 0 To clbDays.CheckedItems.Count - 1
                            For i = 0 To 11
                                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                    conn.Open()
                                    Using cmd As New OleDbCommand("INSERT INTO Events (EventName, EventDate, Type, StartTime, EndTime, Personnel, Notes, Events, Location, AttachNames, Comment, Repeats, IsRepeat) VALUES (@name, @date, @type, @start, @end, @personnel, @notes, @times, @location, @fileNames, @comment, @repeats, @isRepeat)", conn)
                                        cmd.Parameters.AddWithValue("@name", txtName.Text)
                                        dtpDate.Format = DateTimePickerFormat.Short
                                        Dim sundayRelativeDate = dtpDate.Value.AddDays(-dtpDate.Value.DayOfWeek) 'gets you to the relative Sunday date
                                        Dim dateToSave As Date
                                        Select Case cmbRepType.SelectedItem
                                            Case "Weekly" : dateToSave = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(clbDays.CheckedItems(day)) + i * 7)
                                            Case "Monthly" : dateToSave = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(clbDays.CheckedItems(day))).AddMonths(i)
                                            Case "Yearly" : dateToSave = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(clbDays.CheckedItems(day))).AddYears(i)
                                        End Select
                                        cmd.Parameters.AddWithValue("@Date", dateToSave.ToShortDateString())
                                        dtpDate.Format = DateTimePickerFormat.Long
                                        If rdbTraining.Checked Then
                                            cmd.Parameters.AddWithValue("@type", "Training")
                                        Else
                                            cmd.Parameters.AddWithValue("@type", "Meet")
                                        End If
                                        cmd.Parameters.AddWithValue("@start", dtpStart.Text)
                                        cmd.Parameters.AddWithValue("@End", dtpEnd.Text)
                                        Dim attendingAthletes As String = ""
                                        For athlete As Integer = 0 To attendees.Count - 1
                                            If athlete = 0 Then
                                                attendingAthletes = attendees(athlete)
                                            Else
                                                attendingAthletes += ";" & attendees(athlete)
                                            End If
                                        Next
                                        cmd.Parameters.AddWithValue("@personnel", attendingAthletes)
                                        Dim notesNeeded As String = ""
                                        For note As Integer = 0 To notes.Count - 1
                                            If note = 0 Then
                                                notesNeeded = notes(note)
                                            Else
                                                notesNeeded += ";" & notes(note)
                                            End If
                                        Next
                                        cmd.Parameters.AddWithValue("@notes", notesNeeded)
                                        If chbNA.Checked = False Then
                                            Dim eventTimes As String = ""
                                            For time As Integer = 0 To times.Count - 1
                                                If time = 0 Then
                                                    eventTimes = times(time)
                                                Else
                                                    eventTimes += ";" & times(time)
                                                End If
                                            Next
                                            cmd.Parameters.AddWithValue("@times", eventTimes)
                                        Else
                                            cmd.Parameters.AddWithValue("@times", "N/A")
                                        End If
                                        Dim location As String = ""
                                        For Each overlay In map.Overlays
                                            For Each marker In overlay.Markers
                                                location = marker.Position.Lat.ToString() + ";" + marker.Position.Lng.ToString()
                                                Exit For 'since there is only one marker
                                            Next
                                            Exit For
                                        Next
                                        cmd.Parameters.AddWithValue("@location", location)
                                        Dim fileNames As String = ""
                                        For Each filePath In filePaths
                                            If filePath = filePaths(0) Then
                                                Dim splitPath = filePath.Split("\")
                                                fileNames = splitPath(splitPath.Count - 1)
                                            Else
                                                Dim splitPath = filePath.Split("\")
                                                fileNames += ";" & splitPath(splitPath.Count - 1)
                                            End If
                                        Next
                                        cmd.Parameters.AddWithValue("@fileNames", fileNames)
                                        cmd.Parameters.AddWithValue("@comment", txtComment.Text)
                                        Dim reps = ""
                                        If chbRepNA.Checked = False And i = 0 Then
                                            For Each item In clbDays.CheckedItems
                                                If item = clbDays.CheckedItems(0) Then
                                                    reps += item
                                                Else
                                                    reps += ";" + item
                                                End If
                                            Next
                                            reps += ";" + cmbRepType.SelectedItem
                                        Else
                                            reps = "N/A"
                                        End If
                                        cmd.Parameters.AddWithValue("@repeats", reps)
                                        If i = 0 Then
                                            cmd.Parameters.AddWithValue("@isRepeat", False)
                                        Else
                                            cmd.Parameters.AddWithValue("@isRepeat", True)
                                        End If
                                        cmd.ExecuteNonQuery()
                                    End Using
                                    conn.Close()
                                End Using
                            Next
                            For Each filePath In filePaths
                                If filePath.Contains("\") Then
                                    'check if the results file exists and then either add or update
                                    Dim hasMatch As Boolean = False
                                    Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                        conn.Open()
                                        Using cmd As New OleDbCommand("Select FileName FROM Attachments WHERE FileName = @name", conn) 'WHERE NOT EXISTS(SELECT FileName FROM Attachments WHERE FileName = @name)
                                            Dim splitPath = filePath.Split("\")
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
                                        Using fs As New System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                                            Dim myData(fs.Length) As Byte
                                            fs.Read(myData, 0, fs.Length)
                                            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                                conn.Open()
                                                Using cmd As New OleDbCommand("INSERT INTO Attachments (FileName, FileInfo) VALUES (@name, @attachment)", conn) 'INSERT INTO Attachments (FileName, FileInfo) VALUES (@name, @attachment)
                                                    Dim splitPath = filePath.Split("\")
                                                    cmd.Parameters.AddWithValue("@name", splitPath(splitPath.Count - 1))
                                                    cmd.Parameters.Add("@attachments", OleDbType.VarBinary, fs.Length).Value = myData
                                                    cmd.ExecuteNonQuery()
                                                End Using
                                            End Using
                                        End Using
                                    Else
                                        Using fs As New System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                                            Dim myData(fs.Length) As Byte
                                            fs.Read(myData, 0, fs.Length)
                                            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                                conn.Open()
                                                Using cmd As New OleDbCommand("UPDATE Attachments Set FileInfo = @attachment WHERE FileName = @name", conn)
                                                    Dim splitPath = filePath.Split("\")
                                                    cmd.Parameters.Add("@attachment", OleDbType.VarBinary, fs.Length).Value = myData
                                                    cmd.Parameters.AddWithValue("@name", splitPath(splitPath.Count - 1))
                                                    cmd.ExecuteNonQuery()
                                                End Using
                                            End Using
                                        End Using
                                    End If
                                    'Else
                                    '    MessageBox.Show("Attachment: '" + filePath.Split("\")(filePath.Split("\").Count - 1) + "' is already in the database.")
                                    'Else
                                    '    MessageBox.Show("You are trying to upload '" + filePath + "' which was input from the template.")
                                End If
                            Next
                        Next
                    Else
                        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                            conn.Open()
                            Using cmd As New OleDbCommand("INSERT INTO Events (EventName, EventDate, Type, StartTime, EndTime, Personnel, Notes, Events, Location, AttachNames, Comment, Repeats, IsRepeat) VALUES (@name, @date, @type, @start, @end, @personnel, @notes, @times, @location, @fileNames, @comment, @repeats, @isRepeat)", conn)
                                cmd.Parameters.AddWithValue("@name", txtName.Text)
                                dtpDate.Format = DateTimePickerFormat.Short
                                cmd.Parameters.AddWithValue("@Date", dtpDate.Text)
                                dtpDate.Format = DateTimePickerFormat.Long
                                If rdbTraining.Checked Then
                                    cmd.Parameters.AddWithValue("@type", "Training")
                                Else
                                    cmd.Parameters.AddWithValue("@type", "Meet")
                                End If
                                cmd.Parameters.AddWithValue("@start", dtpStart.Text)
                                cmd.Parameters.AddWithValue("@End", dtpEnd.Text)
                                Dim attendingAthletes As String = ""
                                For athlete As Integer = 0 To attendees.Count - 1
                                    If athlete = 0 Then
                                        attendingAthletes = attendees(athlete)
                                    Else
                                        attendingAthletes += ";" & attendees(athlete)
                                    End If
                                Next
                                cmd.Parameters.AddWithValue("@personnel", attendingAthletes)
                                Dim notesNeeded As String = ""
                                For note As Integer = 0 To notes.Count - 1
                                    If note = 0 Then
                                        notesNeeded = notes(note)
                                    Else
                                        notesNeeded += ";" & notes(note)
                                    End If
                                Next
                                cmd.Parameters.AddWithValue("@notes", notesNeeded)
                                If chbNA.Checked = False Then
                                    Dim eventTimes As String = ""
                                    For time As Integer = 0 To times.Count - 1
                                        If time = 0 Then
                                            eventTimes = times(time)
                                        Else
                                            eventTimes += ";" & times(time)
                                        End If
                                    Next
                                    cmd.Parameters.AddWithValue("@times", eventTimes)
                                Else
                                    cmd.Parameters.AddWithValue("@times", "N/A")
                                End If
                                Dim location As String = ""
                                For Each overlay In map.Overlays
                                    For Each marker In overlay.Markers
                                        location = marker.Position.Lat.ToString() + ";" + marker.Position.Lng.ToString()
                                        Exit For 'since there is only one marker
                                    Next
                                    Exit For
                                Next
                                cmd.Parameters.AddWithValue("@location", location)
                                Dim fileNames As String = ""
                                For Each filePath In filePaths
                                    If filePath = filePaths(0) Then
                                        Dim splitPath = filePath.Split("\")
                                        fileNames = splitPath(splitPath.Count - 1)
                                    Else
                                        Dim splitPath = filePath.Split("\")
                                        fileNames += ";" & splitPath(splitPath.Count - 1)
                                    End If
                                Next
                                cmd.Parameters.AddWithValue("@fileNames", fileNames)
                                cmd.Parameters.AddWithValue("@comment", txtComment.Text)
                                Dim reps = ""
                                If chbRepNA.Checked = False Then
                                    For Each item In clbDays.CheckedItems
                                        If item = clbDays.CheckedItems(0) Then
                                            reps += item
                                        Else
                                            reps += ";" + item
                                        End If
                                    Next
                                    reps += ";" + cmbRepType.SelectedItem
                                Else
                                    reps = "N/A"
                                End If
                                cmd.Parameters.AddWithValue("@repeats", reps)
                                cmd.Parameters.AddWithValue("@isRepeat", False)
                                cmd.ExecuteNonQuery()
                            End Using
                            conn.Close()
                        End Using
                        For Each filePath In filePaths
                            If filePath.Contains("\") Then
                                'check if the results file exists and then either add or update
                                Dim hasMatch As Boolean = False
                                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                    conn.Open()
                                    Using cmd As New OleDbCommand("Select FileName FROM Attachments WHERE FileName = @name", conn) 'WHERE NOT EXISTS(SELECT FileName FROM Attachments WHERE FileName = @name)
                                        Dim splitPath = filePath.Split("\")
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
                                    Using fs As New System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                                        Dim myData(fs.Length) As Byte
                                        fs.Read(myData, 0, fs.Length)
                                        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                            conn.Open()
                                            Using cmd As New OleDbCommand("INSERT INTO Attachments (FileName, FileInfo) VALUES (@name, @attachment)", conn) 'INSERT INTO Attachments (FileName, FileInfo) VALUES (@name, @attachment)
                                                Dim splitPath = filePath.Split("\")
                                                cmd.Parameters.AddWithValue("@name", splitPath(splitPath.Count - 1))
                                                cmd.Parameters.Add("@attachments", OleDbType.VarBinary, fs.Length).Value = myData
                                                cmd.ExecuteNonQuery()
                                            End Using
                                        End Using
                                    End Using
                                Else
                                    Using fs As New System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                                        Dim myData(fs.Length) As Byte
                                        fs.Read(myData, 0, fs.Length)
                                        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                            conn.Open()
                                            Using cmd As New OleDbCommand("UPDATE Attachments Set FileInfo = @attachment WHERE FileName = @name", conn)
                                                Dim splitPath = filePath.Split("\")
                                                cmd.Parameters.Add("@attachment", OleDbType.VarBinary, fs.Length).Value = myData
                                                cmd.Parameters.AddWithValue("@name", splitPath(splitPath.Count - 1))
                                                cmd.ExecuteNonQuery()
                                            End Using
                                        End Using
                                    End Using
                                End If
                                'Else
                                '    MessageBox.Show("Attachment: '" + filePath.Split("\")(filePath.Split("\").Count - 1) + "' is already in the database.")
                                'Else
                                '    MessageBox.Show("You are trying to upload '" + filePath + "' which was input from the template.")
                            End If
                        Next
                    End If
                    btnSaveEvent.Tag = "saved"
                    If MessageBox.Show("Your event has been saved" + vbNewLine + "Would you like to create a template from this event?", "Template Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        dtpDate.Format = DateTimePickerFormat.Short
                        If templateEvents.Contains(txtName.Text + " " + dtpDate.Text) = False Then
                            templateEvents.Add(txtName.Text + " " + dtpDate.Text)
                        End If
                        dtpDate.Format = DateTimePickerFormat.Long
                    End If
                    newEdit("evAdd", txtName.Text + " on the " + dtpDate.Text + ".")
                    Me.Close()
                ElseIf attendees.Count = 0 Then
                    MessageBox.Show("You must select athletes for the event.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf (times.Count = 0 AndAlso chbNA.Checked = False) Then
                    MessageBox.Show("You must either set event times or tick N/A", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf map.Overlays.Count <> 1 Then
                    If map.Overlays.Count < 1 Then
                        MessageBox.Show("You must select a location. (A marker must be showing on the map)", "No Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        MessageBox.Show("Please select only one location.", "Multpiple Locations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                ElseIf clbDays.CheckedItems.Count = 0 And chbRepNA.Checked = False Then
                    MessageBox.Show("You must specify the days to repeat the event or tick N/A to not specify any repeats", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf cmbRepType.Text = "" And chbRepNA.Checked = False Then
                    MessageBox.Show("You must specify the event's repeating style or tick N/A to not specify any repeats", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If chbRepNA.Checked = False Then
                        For day = 0 To clbDays.CheckedItems.Count - 1
                            For i = 0 To 11
                                Using conn As New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                    conn.Open()
                                    Using cmd As New OleDbCommand("INSERT INTO Events (EventName, EventDate, Type, StartTime, EndTime, Personnel, Notes, Events, Location, Comment, Repeats, IsRepeat) VALUES (@name, @Date, @type, @start, @End, @personnel, @notes, @times, @location, @comment, @repeats, @isRepeat)", conn)
                                        cmd.Parameters.AddWithValue("@name", txtName.Text)
                                        dtpDate.Format = DateTimePickerFormat.Short
                                        Dim sundayRelativeDate = dtpDate.Value.AddDays(-dtpDate.Value.DayOfWeek) 'gets you to the relative Sunday date
                                        Dim dateToSave As Date
                                        Select Case cmbRepType.SelectedItem
                                            Case "Weekly" : dateToSave = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(clbDays.CheckedItems(day)) + i * 7)
                                            Case "Monthly" : dateToSave = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(clbDays.CheckedItems(day))).AddMonths(i)
                                            Case "Yearly" : dateToSave = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(clbDays.CheckedItems(day))).AddYears(i)
                                        End Select
                                        cmd.Parameters.AddWithValue("@Date", dateToSave.ToShortDateString())
                                        dtpDate.Format = DateTimePickerFormat.Long
                                        If rdbTraining.Checked Then
                                            cmd.Parameters.AddWithValue("@type", "Training")
                                        Else
                                            cmd.Parameters.AddWithValue("@type", "Meet")
                                        End If
                                        cmd.Parameters.AddWithValue("@start", dtpStart.Text)
                                        cmd.Parameters.AddWithValue("@End", dtpEnd.Text)
                                        Dim attendingAthletes As String = ""
                                        For athlete As Integer = 0 To attendees.Count - 1
                                            If athlete = 0 Then
                                                attendingAthletes = attendees(athlete)
                                            Else
                                                attendingAthletes += ";" & attendees(athlete)
                                            End If
                                        Next
                                        cmd.Parameters.AddWithValue("@personnel", attendingAthletes)
                                        Dim notesNeeded As String = ""
                                        For note As Integer = 0 To notes.Count - 1
                                            If note = 0 Then
                                                notesNeeded = notes(note)
                                            Else
                                                notesNeeded += ";" & notes(note)
                                            End If
                                        Next
                                        cmd.Parameters.AddWithValue("@notes", notesNeeded)
                                        If chbNA.Checked = False Then
                                            Dim eventTimes As String = ""
                                            For time As Integer = 0 To times.Count - 1
                                                If time = 0 Then
                                                    eventTimes = times(time)
                                                Else
                                                    eventTimes += ";" & times(time)
                                                End If
                                            Next
                                            cmd.Parameters.AddWithValue("@times", eventTimes)
                                        Else
                                            cmd.Parameters.AddWithValue("@times", "None")
                                        End If
                                        Dim location As String = ""
                                        For Each overlay In map.Overlays
                                            For Each marker In overlay.Markers
                                                location = marker.Position.Lat.ToString() + ";" + marker.Position.Lng.ToString()
                                                Exit For 'since there is only one marker
                                            Next
                                            Exit For
                                        Next
                                        cmd.Parameters.AddWithValue("@location", location)
                                        cmd.Parameters.AddWithValue("@comment", txtComment.Text)
                                        Dim reps = ""
                                        If chbRepNA.Checked = False And i = 0 Then
                                            For Each item In clbDays.CheckedItems
                                                If item = clbDays.CheckedItems(0) Then
                                                    reps += item
                                                Else
                                                    reps += ";" + item
                                                End If
                                            Next
                                            reps += ";" + cmbRepType.SelectedItem
                                        Else
                                            reps = "N/A"
                                        End If
                                        cmd.Parameters.AddWithValue("@repeats", reps)
                                        If i = 0 Then
                                            cmd.Parameters.AddWithValue("@isRepeat", False)
                                        Else
                                            cmd.Parameters.AddWithValue("@isRepeat", True)
                                        End If
                                        cmd.ExecuteNonQuery()
                                    End Using
                                    conn.Close()
                                End Using
                            Next
                        Next
                    Else
                        Using conn As New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                            conn.Open()
                            Using cmd As New OleDbCommand("INSERT INTO Events (EventName, EventDate, Type, StartTime, EndTime, Personnel, Notes, Events, Location, Comment, Repeats, IsRepeat) VALUES (@name, @Date, @type, @start, @End, @personnel, @notes, @times, @location, @comment, @repeats, @isRepeat)", conn)
                                cmd.Parameters.AddWithValue("@name", txtName.Text)
                                dtpDate.Format = DateTimePickerFormat.Short
                                cmd.Parameters.AddWithValue("@Date", dtpDate.Text)
                                dtpDate.Format = DateTimePickerFormat.Long
                                If rdbTraining.Checked Then
                                    cmd.Parameters.AddWithValue("@type", "Training")
                                Else
                                    cmd.Parameters.AddWithValue("@type", "Meet")
                                End If
                                cmd.Parameters.AddWithValue("@start", dtpStart.Text)
                                cmd.Parameters.AddWithValue("@End", dtpEnd.Text)
                                Dim attendingAthletes As String = ""
                                For athlete As Integer = 0 To attendees.Count - 1
                                    If athlete = 0 Then
                                        attendingAthletes = attendees(athlete)
                                    Else
                                        attendingAthletes += ";" & attendees(athlete)
                                    End If
                                Next
                                cmd.Parameters.AddWithValue("@personnel", attendingAthletes)
                                Dim notesNeeded As String = ""
                                For note As Integer = 0 To notes.Count - 1
                                    If note = 0 Then
                                        notesNeeded = notes(note)
                                    Else
                                        notesNeeded += ";" & notes(note)
                                    End If
                                Next
                                cmd.Parameters.AddWithValue("@notes", notesNeeded)
                                If chbNA.Checked = False Then
                                    Dim eventTimes As String = ""
                                    For time As Integer = 0 To times.Count - 1
                                        If time = 0 Then
                                            eventTimes = times(time)
                                        Else
                                            eventTimes += ";" & times(time)
                                        End If
                                    Next
                                    cmd.Parameters.AddWithValue("@times", eventTimes)
                                Else
                                    cmd.Parameters.AddWithValue("@times", "None")
                                End If
                                Dim location As String = ""
                                For Each overlay In map.Overlays
                                    For Each marker In overlay.Markers
                                        location = marker.Position.Lat.ToString() + ";" + marker.Position.Lng.ToString()
                                        Exit For 'since there is only one marker
                                    Next
                                    Exit For
                                Next
                                cmd.Parameters.AddWithValue("@location", location)
                                cmd.Parameters.AddWithValue("@comment", txtComment.Text)
                                Dim reps = ""
                                If chbRepNA.Checked = False Then
                                    For Each item In clbDays.CheckedItems
                                        If item = clbDays.CheckedItems(0) Then
                                            reps += item
                                        Else
                                            reps += ";" + item
                                        End If
                                    Next
                                    reps += ";" + cmbRepType.SelectedItem
                                Else
                                    reps = "N/A"
                                End If
                                cmd.Parameters.AddWithValue("@repeats", reps)
                                cmd.Parameters.AddWithValue("@isRepeat", False)
                                cmd.ExecuteNonQuery()
                            End Using
                            conn.Close()
                        End Using
                    End If
                    btnSaveEvent.Tag = "saved"
                    If MessageBox.Show("Your event has been saved" + vbNewLine + "Would you like to create a template from this event?", "Template Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        dtpDate.Format = DateTimePickerFormat.Short
                        If templateEvents.Contains(txtName.Text + " " + dtpDate.Text) = False Then
                            templateEvents.Add(txtName.Text + " " + dtpDate.Text)
                        End If
                        dtpDate.Format = DateTimePickerFormat.Long
                    End If
                    newEdit("evAdd", txtName.Text + " on " + dtpDate.Text + ".")
                    Me.Close()
                End If
            Else
                MessageBox.Show("The name And date of this event match an exisiting event." + vbNewLine + "Please change either Of these And retry.", "Corresponding Event Exists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
#End Region
#Region "Edit"
        ElseIf Me.Tag.Contains("edit") Then
            'since any change should be reflected in all repeats, it is easiest to create a new record and delete all previous records
            If attendees.Count > 0 AndAlso ((clbDays.CheckedItems.Count > 0 AndAlso cmbRepType.Text <> "") Or chbRepNA.Checked) AndAlso filePaths.Count > 0 AndAlso (times.Count > 0 Or chbNA.Checked = True) And map.Overlays.Count = 1 Then
                'delete any of the relevant attachments
                Dim oldAttachments() As String = {}
                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                    conn.Open()
                    Using cmd As New OleDbCommand("SELECT AttachNames FROM Events WHERE AttachNames IS NOT NULL AND EventName = @name AND EventDate = @date", conn) '*takes the column with correct rows
                        Dim tagSplit = Me.Tag.split(" ")
                        Dim name As String = ""
                        For part As Integer = 0 To tagSplit.Length - 1
                            If part <> 0 And part <> tagSplit.Length - 1 Then
                                name += tagSplit(part) + " "
                            End If
                        Next
                        name = RTrim(name)
                        cmd.Parameters.AddWithValue("@name", name)
                        cmd.Parameters.AddWithValue("@date", tagSplit(tagSplit.Length - 1))
                        Using dr = cmd.ExecuteReader()
                            If dr.HasRows Then
                                Do While dr.Read()
                                    oldAttachments = dr(0).split(";")
                                Loop
                            End If
                        End Using
                    End Using
                    conn.Close()
                End Using
                Dim newfiles As New List(Of String) From {}
                For Each file In filePaths
                    newfiles.Add(IO.Path.GetFileNameWithoutExtension(file))
                Next
                For Each file In oldAttachments
                    If newfiles.Contains(file) = False Then 'if the new attachments doesnt have an old attachment then delete
                        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                            conn.Open()
                            Using cmd As New OleDbCommand("DELETE FROM Attachments WHERE FileName = @filename", conn)
                                cmd.Parameters.AddWithValue("@filename", file)
                                cmd.ExecuteNonQuery()
                            End Using
                            conn.Close()
                        End Using
                    End If
                Next
                'delete the current record
                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                    conn.Open()
                    Using cmd As New OleDbCommand("DELETE FROM Events WHERE EventName = @name AND EventDate = @date", conn)
                        Dim tagSplit = Me.Tag.split(" ")
                        Dim name As String = ""
                        For part As Integer = 0 To tagSplit.Length - 1
                            If part <> 0 And part <> tagSplit.Length - 1 Then
                                name += tagSplit(part) + " "
                            End If
                        Next
                        name = RTrim(name)
                        cmd.Parameters.AddWithValue("@name", name)
                        cmd.Parameters.AddWithValue("@date", tagSplit(tagSplit.Length - 1))
                        cmd.ExecuteNonQuery()
                    End Using
                    conn.Close()
                End Using
                'create repeating event functionality for 12 of the type
                If chbRepNA.Checked = False Then
                    For day = 0 To clbDays.CheckedItems.Count - 1
                        For i = 0 To 11
                            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                conn.Open()
                                Using cmd As New OleDbCommand("INSERT INTO Events (EventName, EventDate, Type, StartTime, EndTime, Personnel, Notes, Events, Location, AttachNames, Comment, Repeats, IsRepeat) VALUES (@name, @date, @type, @start, @end, @personnel, @notes, @times, @location, @fileNames, @comment, @repeats, @isRepeat)", conn)
                                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                                    dtpDate.Format = DateTimePickerFormat.Short
                                    Dim sundayRelativeDate = dtpDate.Value.AddDays(-dtpDate.Value.DayOfWeek) 'gets you to the relative Sunday date
                                    Dim dateToSave As Date
                                    Select Case cmbRepType.SelectedItem
                                        Case "Weekly" : dateToSave = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(clbDays.CheckedItems(day)) + i * 7)
                                        Case "Monthly" : dateToSave = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(clbDays.CheckedItems(day))).AddMonths(i)
                                        Case "Yearly" : dateToSave = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(clbDays.CheckedItems(day))).AddYears(i)
                                    End Select
                                    cmd.Parameters.AddWithValue("@Date", dateToSave.ToShortDateString())
                                    dtpDate.Format = DateTimePickerFormat.Long
                                    If rdbTraining.Checked Then
                                        cmd.Parameters.AddWithValue("@type", "Training")
                                    Else
                                        cmd.Parameters.AddWithValue("@type", "Meet")
                                    End If
                                    cmd.Parameters.AddWithValue("@start", dtpStart.Text)
                                    cmd.Parameters.AddWithValue("@End", dtpEnd.Text)
                                    Dim attendingAthletes As String = ""
                                    For athlete As Integer = 0 To attendees.Count - 1
                                        If athlete = 0 Then
                                            attendingAthletes = attendees(athlete)
                                        Else
                                            attendingAthletes += ";" & attendees(athlete)
                                        End If
                                    Next
                                    cmd.Parameters.AddWithValue("@personnel", attendingAthletes)
                                    Dim notesNeeded As String = ""
                                    For note As Integer = 0 To notes.Count - 1
                                        If note = 0 Then
                                            notesNeeded = notes(note)
                                        Else
                                            notesNeeded += ";" & notes(note)
                                        End If
                                    Next
                                    cmd.Parameters.AddWithValue("@notes", notesNeeded)
                                    If chbNA.Checked = False Then
                                        Dim eventTimes As String = ""
                                        For time As Integer = 0 To times.Count - 1
                                            If time = 0 Then
                                                eventTimes = times(time)
                                            Else
                                                eventTimes += ";" & times(time)
                                            End If
                                        Next
                                        cmd.Parameters.AddWithValue("@times", eventTimes)
                                    Else
                                        cmd.Parameters.AddWithValue("@times", "N/A")
                                    End If
                                    Dim location As String = ""
                                    For Each overlay In map.Overlays
                                        For Each marker In overlay.Markers
                                            location = marker.Position.Lat.ToString() + ";" + marker.Position.Lng.ToString()
                                            Exit For 'since there is only one marker
                                        Next
                                        Exit For
                                    Next
                                    cmd.Parameters.AddWithValue("@location", location)
                                    Dim fileNames As String = ""
                                    For Each filePath In filePaths
                                        If filePath = filePaths(0) Then
                                            Dim splitPath = filePath.Split("\")
                                            fileNames = splitPath(splitPath.Count - 1)
                                        Else
                                            Dim splitPath = filePath.Split("\")
                                            fileNames += ";" & splitPath(splitPath.Count - 1)
                                        End If
                                    Next
                                    cmd.Parameters.AddWithValue("@fileNames", fileNames)
                                    cmd.Parameters.AddWithValue("@comment", txtComment.Text)
                                    Dim reps = ""
                                    If chbRepNA.Checked = False And i = 0 Then
                                        For Each item In clbDays.CheckedItems
                                            If item = clbDays.CheckedItems(0) Then
                                                reps += item
                                            Else
                                                reps += ";" + item
                                            End If
                                        Next
                                        reps += ";" + cmbRepType.SelectedItem
                                    Else
                                        reps = "N/A"
                                    End If
                                    cmd.Parameters.AddWithValue("@repeats", reps)
                                    If i = 0 Then
                                        cmd.Parameters.AddWithValue("@isRepeat", False)
                                    Else
                                        cmd.Parameters.AddWithValue("@isRepeat", True)
                                    End If
                                    cmd.ExecuteNonQuery()
                                End Using
                                conn.Close()
                            End Using
                        Next
                        For Each filePath In filePaths
                            If filePath.Contains("\") Then
                                'check if the results file exists and then either add or update
                                Dim hasMatch As Boolean = False
                                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                    conn.Open()
                                    Using cmd As New OleDbCommand("Select FileName FROM Attachments WHERE FileName = @name", conn) 'WHERE NOT EXISTS(SELECT FileName FROM Attachments WHERE FileName = @name)
                                        Dim splitPath = filePath.Split("\")
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
                                    Using fs As New System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                                        Dim myData(fs.Length) As Byte
                                        fs.Read(myData, 0, fs.Length)
                                        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                            conn.Open()
                                            Using cmd As New OleDbCommand("INSERT INTO Attachments (FileName, FileInfo) VALUES (@name, @attachment)", conn) 'INSERT INTO Attachments (FileName, FileInfo) VALUES (@name, @attachment)
                                                Dim splitPath = filePath.Split("\")
                                                cmd.Parameters.AddWithValue("@name", splitPath(splitPath.Count - 1))
                                                cmd.Parameters.Add("@attachments", OleDbType.VarBinary, fs.Length).Value = myData
                                                cmd.ExecuteNonQuery()
                                            End Using
                                        End Using
                                    End Using
                                Else
                                    Using fs As New System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                                        Dim myData(fs.Length) As Byte
                                        fs.Read(myData, 0, fs.Length)
                                        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                            conn.Open()
                                            Using cmd As New OleDbCommand("UPDATE Attachments Set FileInfo = @attachment WHERE FileName = @name", conn)
                                                Dim splitPath = filePath.Split("\")
                                                cmd.Parameters.Add("@attachment", OleDbType.VarBinary, fs.Length).Value = myData
                                                cmd.Parameters.AddWithValue("@name", splitPath(splitPath.Count - 1))
                                                cmd.ExecuteNonQuery()
                                            End Using
                                        End Using
                                    End Using
                                End If
                                'Else
                                '    MessageBox.Show("Attachment: '" + filePath.Split("\")(filePath.Split("\").Count - 1) + "' is already in the database.")
                                'Else
                                '    MessageBox.Show("You are trying to upload '" + filePath + "' which was input from the template.")
                            End If
                        Next
                    Next
                Else
                    Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                        conn.Open()
                        Using cmd As New OleDbCommand("INSERT INTO Events (EventName, EventDate, Type, StartTime, EndTime, Personnel, Notes, Events, Location, AttachNames, Comment, Repeats, IsRepeat) VALUES (@name, @date, @type, @start, @end, @personnel, @notes, @times, @location, @fileNames, @comment, @repeats, @isRepeat)", conn)
                            cmd.Parameters.AddWithValue("@name", txtName.Text)
                            dtpDate.Format = DateTimePickerFormat.Short
                            cmd.Parameters.AddWithValue("@Date", dtpDate.Text)
                            dtpDate.Format = DateTimePickerFormat.Long
                            If rdbTraining.Checked Then
                                cmd.Parameters.AddWithValue("@type", "Training")
                            Else
                                cmd.Parameters.AddWithValue("@type", "Meet")
                            End If
                            cmd.Parameters.AddWithValue("@start", dtpStart.Text)
                            cmd.Parameters.AddWithValue("@End", dtpEnd.Text)
                            Dim attendingAthletes As String = ""
                            For athlete As Integer = 0 To attendees.Count - 1
                                If athlete = 0 Then
                                    attendingAthletes = attendees(athlete)
                                Else
                                    attendingAthletes += ";" & attendees(athlete)
                                End If
                            Next
                            cmd.Parameters.AddWithValue("@personnel", attendingAthletes)
                            Dim notesNeeded As String = ""
                            For note As Integer = 0 To notes.Count - 1
                                If note = 0 Then
                                    notesNeeded = notes(note)
                                Else
                                    notesNeeded += ";" & notes(note)
                                End If
                            Next
                            cmd.Parameters.AddWithValue("@notes", notesNeeded)
                            If chbNA.Checked = False Then
                                Dim eventTimes As String = ""
                                For time As Integer = 0 To times.Count - 1
                                    If time = 0 Then
                                        eventTimes = times(time)
                                    Else
                                        eventTimes += ";" & times(time)
                                    End If
                                Next
                                cmd.Parameters.AddWithValue("@times", eventTimes)
                            Else
                                cmd.Parameters.AddWithValue("@times", "N/A")
                            End If
                            Dim location As String = ""
                            For Each overlay In map.Overlays
                                For Each marker In overlay.Markers
                                    location = marker.Position.Lat.ToString() + ";" + marker.Position.Lng.ToString()
                                    Exit For 'since there is only one marker
                                Next
                                Exit For
                            Next
                            cmd.Parameters.AddWithValue("@location", location)
                            Dim fileNames As String = ""
                            For Each filePath In filePaths
                                If filePath = filePaths(0) Then
                                    Dim splitPath = filePath.Split("\")
                                    fileNames = splitPath(splitPath.Count - 1)
                                Else
                                    Dim splitPath = filePath.Split("\")
                                    fileNames += ";" & splitPath(splitPath.Count - 1)
                                End If
                            Next
                            cmd.Parameters.AddWithValue("@fileNames", fileNames)
                            cmd.Parameters.AddWithValue("@comment", txtComment.Text)
                            Dim reps = ""
                            If chbRepNA.Checked = False Then
                                For Each item In clbDays.CheckedItems
                                    If item = clbDays.CheckedItems(0) Then
                                        reps += item
                                    Else
                                        reps += ";" + item
                                    End If
                                Next
                                reps += ";" + cmbRepType.SelectedItem
                            Else
                                reps = "N/A"
                            End If
                            cmd.Parameters.AddWithValue("@repeats", reps)
                            cmd.Parameters.AddWithValue("@isRepeat", False)
                            cmd.ExecuteNonQuery()
                        End Using
                        conn.Close()
                    End Using
                    For Each filePath In filePaths
                        If filePath.Contains("\") Then
                            'check if the results file exists and then either add or update
                            Dim hasMatch As Boolean = False
                            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                conn.Open()
                                Using cmd As New OleDbCommand("Select FileName FROM Attachments WHERE FileName = @name", conn) 'WHERE NOT EXISTS(SELECT FileName FROM Attachments WHERE FileName = @name)
                                    Dim splitPath = filePath.Split("\")
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
                                Using fs As New System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                                    Dim myData(fs.Length) As Byte
                                    fs.Read(myData, 0, fs.Length)
                                    Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                        conn.Open()
                                        Using cmd As New OleDbCommand("INSERT INTO Attachments (FileName, FileInfo) VALUES (@name, @attachment)", conn) 'INSERT INTO Attachments (FileName, FileInfo) VALUES (@name, @attachment)
                                            Dim splitPath = filePath.Split("\")
                                            cmd.Parameters.AddWithValue("@name", splitPath(splitPath.Count - 1))
                                            cmd.Parameters.Add("@attachments", OleDbType.VarBinary, fs.Length).Value = myData
                                            cmd.ExecuteNonQuery()
                                        End Using
                                    End Using
                                End Using
                            Else
                                Using fs As New System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                                    Dim myData(fs.Length) As Byte
                                    fs.Read(myData, 0, fs.Length)
                                    Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                        conn.Open()
                                        Using cmd As New OleDbCommand("UPDATE Attachments Set FileInfo = @attachment WHERE FileName = @name", conn)
                                            Dim splitPath = filePath.Split("\")
                                            cmd.Parameters.Add("@attachment", OleDbType.VarBinary, fs.Length).Value = myData
                                            cmd.Parameters.AddWithValue("@name", splitPath(splitPath.Count - 1))
                                            cmd.ExecuteNonQuery()
                                        End Using
                                    End Using
                                End Using
                            End If
                            'Else
                            '    MessageBox.Show("Attachment: '" + filePath.Split("\")(filePath.Split("\").Count - 1) + "' is already in the database.")
                            'Else
                            '    MessageBox.Show("You are trying to upload '" + filePath + "' which was input from the template.")
                        End If
                    Next
                End If
                If chbRepNA.Enabled Then 'if it's the original event
                    'delete all repeated versions of the event:
                    '1) find the repeat conditions
                    Dim repeatInfo As New List(Of String)
                    Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                        conn.Open()
                        Using cmd As New OleDbCommand("SELECT Repeats FROM Events WHERE EventName = @name AND EventDate = @date AND Repeats <> 'N/A'", conn) '*takes the column with correct rows
                            Dim tagSplit = Me.Tag.split(" ")
                            Dim name As String = ""
                            For part As Integer = 0 To tagSplit.Length - 1
                                If part <> 0 And part <> tagSplit.Length - 1 Then
                                    name += tagSplit(part) + " "
                                End If
                            Next
                            name = RTrim(name)
                            cmd.Parameters.AddWithValue("@name", name)
                            cmd.Parameters.AddWithValue("@date", tagSplit(tagSplit.Length - 1))
                            Using dr = cmd.ExecuteReader()
                                If dr.HasRows() Then
                                    Do While dr.Read()
                                        Dim repeatColumn() As String = dr("Repeats").split(";")
                                        repeatInfo = repeatColumn.ToList()
                                    Loop
                                End If
                            End Using
                        End Using
                        conn.Close()
                    End Using
                    '2) delete all repeating versions
                    If repeatInfo.Count > 0 Then
                        Dim repeatType = repeatInfo(repeatInfo.Count - 1)
                        repeatInfo.Remove(repeatType)
                        For day = 0 To repeatInfo.Count - 1
                            For i = 0 To 11
                                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                    conn.Open()
                                    Using cmd As New OleDbCommand("DELETE FROM Events WHERE EventName = @name AND EventDate = @date", conn) '*takes the column with correct rows
                                        Dim tagSplit = Me.Tag.split(" ")
                                        Dim name As String = ""
                                        For part As Integer = 0 To tagSplit.Length - 1
                                            If part <> 0 And part <> tagSplit.Length - 1 Then
                                                name += tagSplit(part) + " "
                                            End If
                                        Next
                                        name = RTrim(name)
                                        cmd.Parameters.AddWithValue("@name", name)
                                        Dim sundayRelativeDate = CType(tagSplit(tagSplit.Length - 1), Date).AddDays(-CType(tagSplit(tagSplit.Length - 1), Date).DayOfWeek)
                                        Dim dateToRemove As Date
                                        Select Case repeatType
                                            Case "Weekly" : dateToRemove = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(repeatInfo(day))).AddDays(i * 7)
                                            Case "Monthly" : dateToRemove = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(repeatInfo(day))).AddMonths(i)
                                            Case "Yearly" : dateToRemove = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(repeatInfo(day))).AddYears(i)
                                        End Select
                                        cmd.Parameters.AddWithValue("@date", dateToRemove.ToShortDateString())
                                        cmd.ExecuteNonQuery()
                                    End Using
                                    conn.Close()
                                End Using
                            Next
                        Next
                    End If
                End If
                btnSaveEvent.Tag = "saved"
                If MessageBox.Show("Your event has been saved" + vbNewLine + "Would you like to create a template from this event?", "Template Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    dtpDate.Format = DateTimePickerFormat.Short
                    If templateEvents.Contains(txtName.Text + " " + dtpDate.Text) = False Then
                        templateEvents.Add(txtName.Text + " " + dtpDate.Text)
                    End If
                    dtpDate.Format = DateTimePickerFormat.Long
                End If
                newEdit("evEdit", txtName.Text + " on " + dtpDate.Text + ".")
                Me.Close()
            ElseIf attendees.Count = 0 Then
                MessageBox.Show("You must select athletes for the event.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf (times.Count = 0 AndAlso chbNA.Checked = False) Then
                MessageBox.Show("You must either set event times or tick N/A", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf map.Overlays.Count <> 1 Then
                If map.Overlays.Count < 1 Then
                    MessageBox.Show("You must select a location. (A marker must be showing on the map)", "No Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("Please select only one location.", "Multpiple Locations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            ElseIf clbDays.CheckedItems.Count = 0 And chbRepNA.Checked = False Then
                MessageBox.Show("You must specify the event's repeating style or tick N/A", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf cmbRepType.Text = "" And chbRepNA.Checked = False Then
                MessageBox.Show("You must specify the event's repeating style or tick N/A to not specify any repeats", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                'delete any of the relevant attachments
                Dim oldAttachments() As String = {}
                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                    conn.Open()
                    Using cmd As New OleDbCommand("SELECT AttachNames FROM Events WHERE AttachNames IS NOT NULL AND EventName = @name AND EventDate = @date", conn) '*takes the column with correct rows
                        Dim tagSplit = Me.Tag.split(" ")
                        Dim name As String = ""
                        For part As Integer = 0 To tagSplit.Length - 1
                            If part <> 0 And part <> tagSplit.Length - 1 Then
                                name += tagSplit(part) + " "
                            End If
                        Next
                        name = RTrim(name)
                        cmd.Parameters.AddWithValue("@name", name)
                        cmd.Parameters.AddWithValue("@date", tagSplit(tagSplit.Length - 1))
                        Using dr = cmd.ExecuteReader()
                            If dr.HasRows Then
                                Do While dr.Read()
                                    oldAttachments = dr(0).split(";")
                                Loop
                            End If
                        End Using
                    End Using
                    conn.Close()
                End Using
                For Each file In oldAttachments
                    Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                        conn.Open()
                        Using cmd As New OleDbCommand("DELETE FROM Attachments WHERE FileName = @filename", conn)
                            cmd.Parameters.AddWithValue("@filename", file)
                            cmd.ExecuteNonQuery()
                        End Using
                        conn.Close()
                    End Using
                Next
                'delete only the current record
                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                    conn.Open()
                    Using cmd As New OleDbCommand("DELETE FROM Events WHERE EventName = @name AND EventDate = @date", conn) '*takes the column with correct rows
                        Dim tagSplit = Me.Tag.split(" ")
                        Dim name As String = ""
                        For part As Integer = 0 To tagSplit.Length - 1
                            If part <> 0 And part <> tagSplit.Length - 1 Then
                                name += tagSplit(part) + " "
                            End If
                        Next
                        name = RTrim(name)
                        cmd.Parameters.AddWithValue("@name", name)
                        cmd.Parameters.AddWithValue("@date", tagSplit(tagSplit.Length - 1))
                        cmd.ExecuteNonQuery()
                    End Using
                    conn.Close()
                End Using
                If chbRepNA.Checked = False Then
                    For day = 0 To clbDays.CheckedItems.Count - 1
                        For i = 0 To 11
                            Using conn As New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                conn.Open()
                                Using cmd As New OleDbCommand("INSERT INTO Events (EventName, EventDate, Type, StartTime, EndTime, Personnel, Notes, Events, Location, Comment, Repeats, IsRepeat) VALUES (@name, @Date, @type, @start, @End, @personnel, @notes, @times, @location, @comment, @repeats, @isRepeat)", conn)
                                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                                    dtpDate.Format = DateTimePickerFormat.Short
                                    Dim sundayRelativeDate = dtpDate.Value.AddDays(-dtpDate.Value.DayOfWeek) 'gets you to the relative Sunday date
                                    Dim dateToSave As Date
                                    Select Case cmbRepType.SelectedItem
                                        Case "Weekly" : dateToSave = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(clbDays.CheckedItems(day)) + i * 7)
                                        Case "Monthly" : dateToSave = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(clbDays.CheckedItems(day))).AddMonths(i)
                                        Case "Yearly" : dateToSave = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(clbDays.CheckedItems(day))).AddYears(i)
                                    End Select
                                    cmd.Parameters.AddWithValue("@Date", dateToSave.ToShortDateString())
                                    dtpDate.Format = DateTimePickerFormat.Long
                                    If rdbTraining.Checked Then
                                        cmd.Parameters.AddWithValue("@type", "Training")
                                    Else
                                        cmd.Parameters.AddWithValue("@type", "Meet")
                                    End If
                                    cmd.Parameters.AddWithValue("@start", dtpStart.Text)
                                    cmd.Parameters.AddWithValue("@End", dtpEnd.Text)
                                    Dim attendingAthletes As String = ""
                                    For athlete As Integer = 0 To attendees.Count - 1
                                        If athlete = 0 Then
                                            attendingAthletes = attendees(athlete)
                                        Else
                                            attendingAthletes += ";" & attendees(athlete)
                                        End If
                                    Next
                                    cmd.Parameters.AddWithValue("@personnel", attendingAthletes)
                                    Dim notesNeeded As String = ""
                                    For note As Integer = 0 To notes.Count - 1
                                        If note = 0 Then
                                            notesNeeded = notes(note)
                                        Else
                                            notesNeeded += ";" & notes(note)
                                        End If
                                    Next
                                    cmd.Parameters.AddWithValue("@notes", notesNeeded)
                                    If chbNA.Checked = False Then
                                        Dim eventTimes As String = ""
                                        For time As Integer = 0 To times.Count - 1
                                            If time = 0 Then
                                                eventTimes = times(time)
                                            Else
                                                eventTimes += ";" & times(time)
                                            End If
                                        Next
                                        cmd.Parameters.AddWithValue("@times", eventTimes)
                                    Else
                                        cmd.Parameters.AddWithValue("@times", "None")
                                    End If
                                    Dim location As String = ""
                                    For Each overlay In map.Overlays
                                        For Each marker In overlay.Markers
                                            location = marker.Position.Lat.ToString() + ";" + marker.Position.Lng.ToString()
                                            Exit For 'since there is only one marker
                                        Next
                                        Exit For
                                    Next
                                    cmd.Parameters.AddWithValue("@location", location)
                                    cmd.Parameters.AddWithValue("@comment", txtComment.Text)
                                    Dim reps = ""
                                    If chbRepNA.Checked = False And i = 0 Then
                                        For Each item In clbDays.CheckedItems
                                            If item = clbDays.CheckedItems(0) Then
                                                reps += item
                                            Else
                                                reps += ";" + item
                                            End If
                                        Next
                                        reps += ";" + cmbRepType.SelectedItem
                                    Else
                                        reps = "N/A"
                                    End If
                                    cmd.Parameters.AddWithValue("@repeats", reps)
                                    If i = 0 Then
                                        cmd.Parameters.AddWithValue("@isRepeat", False)
                                    Else
                                        cmd.Parameters.AddWithValue("@isRepeat", True)
                                    End If
                                    cmd.ExecuteNonQuery()
                                End Using
                                conn.Close()
                            End Using
                        Next
                    Next
                Else
                    Using conn As New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                        conn.Open()
                        Using cmd As New OleDbCommand("INSERT INTO Events (EventName, EventDate, Type, StartTime, EndTime, Personnel, Notes, Events, Location, Comment, Repeats, IsRepeat) VALUES (@name, @Date, @type, @start, @End, @personnel, @notes, @times, @location, @comment, @repeats, @isRepeat)", conn)
                            cmd.Parameters.AddWithValue("@name", txtName.Text)
                            dtpDate.Format = DateTimePickerFormat.Short
                            cmd.Parameters.AddWithValue("@Date", dtpDate.Text)
                            dtpDate.Format = DateTimePickerFormat.Long
                            If rdbTraining.Checked Then
                                cmd.Parameters.AddWithValue("@type", "Training")
                            Else
                                cmd.Parameters.AddWithValue("@type", "Meet")
                            End If
                            cmd.Parameters.AddWithValue("@start", dtpStart.Text)
                            cmd.Parameters.AddWithValue("@End", dtpEnd.Text)
                            Dim attendingAthletes As String = ""
                            For athlete As Integer = 0 To attendees.Count - 1
                                If athlete = 0 Then
                                    attendingAthletes = attendees(athlete)
                                Else
                                    attendingAthletes += ";" & attendees(athlete)
                                End If
                            Next
                            cmd.Parameters.AddWithValue("@personnel", attendingAthletes)
                            Dim notesNeeded As String = ""
                            For note As Integer = 0 To notes.Count - 1
                                If note = 0 Then
                                    notesNeeded = notes(note)
                                Else
                                    notesNeeded += ";" & notes(note)
                                End If
                            Next
                            cmd.Parameters.AddWithValue("@notes", notesNeeded)
                            If chbNA.Checked = False Then
                                Dim eventTimes As String = ""
                                For time As Integer = 0 To times.Count - 1
                                    If time = 0 Then
                                        eventTimes = times(time)
                                    Else
                                        eventTimes += ";" & times(time)
                                    End If
                                Next
                                cmd.Parameters.AddWithValue("@times", eventTimes)
                            Else
                                cmd.Parameters.AddWithValue("@times", "None")
                            End If
                            Dim location As String = ""
                            For Each overlay In map.Overlays
                                For Each marker In overlay.Markers
                                    location = marker.Position.Lat.ToString() + ";" + marker.Position.Lng.ToString()
                                    Exit For 'since there is only one marker
                                Next
                                Exit For
                            Next
                            cmd.Parameters.AddWithValue("@location", location)
                            cmd.Parameters.AddWithValue("@comment", txtComment.Text)
                            Dim reps = ""
                            If chbRepNA.Checked = False Then
                                For Each item In clbDays.CheckedItems
                                    If item = clbDays.CheckedItems(0) Then
                                        reps += item
                                    Else
                                        reps += ";" + item
                                    End If
                                Next
                                reps += ";" + cmbRepType.SelectedItem
                            Else
                                reps = "N/A"
                            End If
                            cmd.Parameters.AddWithValue("@repeats", reps)
                            cmd.Parameters.AddWithValue("@isRepeat", False)
                            cmd.ExecuteNonQuery()
                        End Using
                        conn.Close()
                    End Using
                End If
                If chbRepNA.Enabled Then 'if it's the original event
                    'delete all repeated versions of the event:
                    '1) find the repeat conditions
                    Dim repeatInfo As New List(Of String)
                    Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                        conn.Open()
                        Using cmd As New OleDbCommand("SELECT Repeats FROM Events WHERE EventName = @name AND EventDate = @date AND Repeats <> 'N/A'", conn) '*takes the column with correct rows
                            Dim tagSplit = Me.Tag.split(" ")
                            Dim name As String = ""
                            For part As Integer = 0 To tagSplit.Length - 1
                                If part <> 0 And part <> tagSplit.Length - 1 Then
                                    name += tagSplit(part) + " "
                                End If
                            Next
                            name = RTrim(name)
                            cmd.Parameters.AddWithValue("@name", name)
                            cmd.Parameters.AddWithValue("@date", tagSplit(tagSplit.Length - 1))
                            Using dr = cmd.ExecuteReader()
                                If dr.HasRows() Then
                                    Do While dr.Read()
                                        Dim repeatColumn() As String = dr("Repeats").split(";")
                                        repeatInfo = repeatColumn.ToList()
                                    Loop
                                End If
                            End Using
                        End Using
                        conn.Close()
                    End Using
                    '2) delete all repeating versions
                    If repeatInfo.Count > 0 Then
                        Dim repeatType = repeatInfo(repeatInfo.Count - 1)
                        repeatInfo.Remove(repeatType)
                        For day = 0 To repeatInfo.Count - 1
                            For i = 0 To 11
                                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                                    conn.Open()
                                    Using cmd As New OleDbCommand("DELETE FROM Events WHERE EventName = @name AND EventDate = @date", conn) '*takes the column with correct rows
                                        Dim tagSplit = Me.Tag.split(" ")
                                        Dim name As String = ""
                                        For part As Integer = 0 To tagSplit.Length - 1
                                            If part <> 0 And part <> tagSplit.Length - 1 Then
                                                name += tagSplit(part) + " "
                                            End If
                                        Next
                                        name = RTrim(name)
                                        cmd.Parameters.AddWithValue("@name", name)
                                        Dim sundayRelativeDate = CType(tagSplit(tagSplit.Length - 1), Date).AddDays(-CType(tagSplit(tagSplit.Length - 1), Date).DayOfWeek)
                                        Dim dateToRemove As Date
                                        Select Case repeatType
                                            Case "Weekly" : dateToRemove = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(repeatInfo(day))).AddDays(i * 7)
                                            Case "Monthly" : dateToRemove = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(repeatInfo(day))).AddMonths(i)
                                            Case "Yearly" : dateToRemove = sundayRelativeDate.AddDays(clbDays.Items.IndexOf(repeatInfo(day))).AddYears(i)
                                        End Select
                                        cmd.Parameters.AddWithValue("@date", dateToRemove.ToShortDateString())
                                        cmd.ExecuteNonQuery()
                                    End Using
                                    conn.Close()
                                End Using
                            Next
                        Next
                    End If
                End If
                btnSaveEvent.Tag = "saved"
                If MessageBox.Show("Your event has been edited." + vbNewLine + "Would you like to create a template from this event?", "Template Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    dtpDate.Format = DateTimePickerFormat.Short
                    If templateEvents.Contains(txtName.Text + " " + dtpDate.Text) = False Then
                        templateEvents.Add(txtName.Text + " " + dtpDate.Text)
                    End If
                    dtpDate.Format = DateTimePickerFormat.Long
                End If
                newEdit("evEdit", txtName.Text + " on " + dtpDate.Text + ".")
                Me.Close()
            End If
        End If
        Cursor.Current = Cursors.Default
#End Region
    End Sub
    Private Sub chbNA_CheckedChanged(sender As Object, e As EventArgs) Handles chbNA.CheckedChanged
        If chbNA.CheckState = CheckState.Checked Then
            For Each control In gbEvents.Controls()
                If control.name <> "chbNA" Then
                    control.enabled = False
                End If
            Next
        Else
            For Each control In gbEvents.Controls()
                control.enabled = True
            Next
        End If
    End Sub
    Private Sub chbRepNA_CheckedChanged(sender As Object, e As EventArgs) Handles chbRepNA.CheckedChanged
        If chbRepNA.CheckState = CheckState.Checked Then
            For Each control In gbRepeats.Controls()
                If control.name <> "chbRepNA" Then
                    control.enabled = False
                End If
            Next
        Else
            For Each control In gbRepeats.Controls()
                control.enabled = True
            Next
        End If
    End Sub
    Private Sub createEvent_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        If btnSaveEvent.Tag <> "saved" Then
            If MessageBox.Show("Are you sure you want to close the form?" + vbNewLine + "If there is information that has not been saved, it will be lost.", "Close confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                attendees.Clear()
                times.Clear()
                notes.Clear()
            Else
                e.Cancel = True
            End If
        Else
            btnSaveEvent.Tag = Nothing
            attendees.Clear()
            times.Clear()
            notes.Clear()
        End If
        calendar.Show()
    End Sub
    Private Sub createEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chbNA.Checked = False
        cmbTemplate.Items.AddRange(templateEvents.ToArray())
        rdbTraining_CheckedChanged(Nothing, Nothing)
        dtpDate.Text = calendar.mnCalendar.SelectionStart
        flpAthletes.BackColor = Color.FromArgb(197, 197, 197)
        flpAttach.BackColor = Color.FromArgb(197, 197, 197)
        clbDays.Location = New Point(pbCmb.Location.X, pbCmb.Location.Y + pbCmb.Height)
        clbDays.Width = pbCmb.Width
        clbDays.ClientSize = New Size(clbDays.ClientSize.Width, clbDays.GetItemRectangle(0).Height * clbDays.Items.Count) 'sets the height dynamically
        'btnCmb.Image = My.Resources.comboBoxImage
        'btnCmb.Enabled = True
        'btnCmb.Cursor = Cursors.Hand
        'btnCmb.SizeMode = PictureBoxSizeMode.Normal
        'Maps
        Dim proxyTester = Net.WebRequest.GetSystemWebProxy()
        If (proxyTester.GetProxy(New Uri("http://www.google.com")).Equals(New Uri("http://www.google.com"))) Then 'check if no proxy present by comparing URI's
            proxyPresent = False
        Else 'set proxy
            proxyPresent = True
            MapProviders.GoogleMapProvider.WebProxy = New Net.WebProxy("proxy.intranet", 8080)
            MapProviders.GoogleMapProvider.WebProxy.Credentials = New Net.NetworkCredential("eddie.belokopytov", "zorba491")
        End If
        map.MapProvider = MapProviders.GoogleMapProvider.Instance
        map.Manager.Mode = AccessMode.ServerAndCache
        If Me.Tag.contains("add") Then
            map.Position = New PointLatLng(-33.891543077486077, 151.21914625167847)
            map.Zoom += 4
        Else
            If map.Overlays.Count <> 0 Then
                Dim address = map.Overlays(0).Markers(0).ToolTipText.Split(",")
                For i As Integer = 0 To address.Count - 2 'to skip "Australia"
                    If i = address.Count - 2 Then 'the part with SUBURB STATE POSTCODE
                        Dim details = LTrim(address(i)).Split(" ")
                        txtSuburb.Text = ""
                        For j As Integer = 0 To details.Count - 2 'to skip the postcode
                            If j <> details.Count - 2 Then
                                txtSuburb.Text += details(j) + " "
                            Else
                                cmbState.SelectedItem = details(j)
                            End If
                        Next
                        txtSuburb.Text = RTrim(txtSuburb.Text)
                    Else
                        txtStreet.Text = address(i)
                    End If
                Next
                map.ZoomAndCenterMarkers(Nothing)
                map.Zoom += 4
            End If
        End If
        map.DragButton = MouseButtons.Left
        map.ShowCenter = False
        pbPlus.Parent = map
        pbPlus.BackColor = Color.Transparent
        pbPlus.Location = New Point((map.Width - pbPlus.Width - 5), Int(map.Height / 2 - (pbPlus.Height / 2) - 5))
        pbMinus.Parent = map
        pbMinus.Location = New Point((map.Width - pbMinus.Width - 5), Int(map.Height / 2 + (pbMinus.Height / 2) + 5))
        pbMinus.BackColor = Color.Transparent
        mainThreadID = Thread.CurrentThread.ManagedThreadId
        If Me.Tag.contains("view") Then
            gbLocation.Enabled = False
            gbDetails.Enabled = False
            btnSelect.Enabled = False
            btnSaveTimes.Enabled = False
            btnSaveEvent.Enabled = False
            btnCancel.Enabled = False
            gbRepeats.Enabled = False
            chbAllAthletes.Enabled = False
            chbAllNotes.Enabled = False
            chbNA.Enabled = False
            map.Enabled = False
        End If
        'Events
        cmbEvent.SelectedIndex = 0
        previousDropSelection = cmbEvent.SelectedItem
        'Dim tmpBox As New PictureBox
        'tmpBox.Tag = "firstOpen"
        'cmbEvent_SelectedValueChanged(tmpBox, Nothing)
        'Athletes
        cmbGroup.SelectedIndex = 0
        'Dim tmpCmb As New ComboBox
        'tmpCmb.Tag = "template"
        'cmbGroup_SelectedValueChanged(tmpCmb, Nothing)
        For Each control As Control In bigbtngroup.Controls
            If control.GetType() = GetType(GroupBox) Then
                AddHandler control.MouseClick, AddressOf clickHandler
                For Each item As Control In control.Controls
                    If item.Name <> "pbCmb" And item.Name <> "clbDays" Then
                        AddHandler item.MouseClick, AddressOf clickHandler
                    End If
                Next
            Else
                AddHandler control.MouseClick, AddressOf clickHandler
            End If
        Next
        AddHandler bigbtngroup.Click, AddressOf clickHandler
    End Sub
    Private Sub clickHandler(sender As Object, e As MouseEventArgs)
        If clbDays.Visible Then
            'Dim clickRect As New Rectangle(New Point(e.X, e.Y), New Size(1, 1))
            'Dim pbCmbRect As New Rectangle(pbCmb.Location, pbCmb.Size)
            'Dim chlbRect As New Rectangle(clbDays.Location, clbDays.Size)
            'If clickRect.IntersectsWith(pbCmbRect) = False And clickRect.IntersectsWith(chlbRect) = False Then
            pbCmb_NotActiveControl()
            'End If
        End If
    End Sub
    Private Sub chbNone_CheckedChanged(sender As Object, e As EventArgs) Handles chbNone.CheckedChanged
        If chbNone.Checked = False Then
            cmbTemplate.Enabled = True
        Else
            cmbTemplate.Text = ""
            cmbTemplate.Enabled = False
        End If
    End Sub
    Private Sub rdbTraining_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTraining.CheckedChanged
        If rdbTraining.Checked = True Then
            rdbMeet.Checked = False
            chbNA.Checked = True
        Else
            rdbMeet.Checked = True
            chbNA.Checked = False
        End If
    End Sub
    Private Sub pbCmb_MouseHover(sender As Object, e As EventArgs) Handles pbCmb.MouseHover
        If clbDays.Visible = False Then
            pbCmb.Image = My.Resources.comboBoxHover
        End If
    End Sub
    Private Sub pbCmb_MouseLeave(sender As Object, e As EventArgs) Handles pbCmb.MouseLeave
        'check if the current control (me.activecontrol) that has focus is the same as the previous
        'make event that hanldes all click with for loop, add any control tat is dynamically created
        If clbDays.Visible = False Then
            pbCmb.Image = My.Resources.comboBoxImage
        End If
    End Sub
    Private Sub pbCmb_Click(sender As Object, e As EventArgs) Handles pbCmb.Click
        pbCmb.Image = My.Resources.comboBoxDropped
        clbDays.BringToFront()
        clbDays.Visible = True
    End Sub
    Private Sub pbCmb_EnabledChanged(sender As Object, e As EventArgs) Handles pbCmb.EnabledChanged
        If pbCmb.Enabled Then
            pbCmb.Image = My.Resources.comboBoxDisabled
        Else
            pbCmb.Image = My.Resources.comboBoxImage
        End If
        clbDays.Visible = False
    End Sub
    Private Sub pbCmb_NotActiveControl()
        pbCmb.Image = My.Resources.comboBoxImage
        clbDays.Visible = False
    End Sub
    Public Sub cmbTemplate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTemplate.SelectedIndexChanged
#Region "Template Load"
        Cursor.Current = Cursors.AppStarting
        newAttachBoxLocation = New Point(135 - 62 - 5, 377)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT * FROM Events WHERE EventDate = @Date And EventName = @name", conn) '*takes the column with correct rows
                Dim eventSplit As String() = sender.SelectedItem.Split(" ")
                cmd.Parameters.AddWithValue("@Date", eventSplit(eventSplit.Length - 1))
                Dim name As String = ""
                For Each part In eventSplit
                    If part <> eventSplit(eventSplit.Length - 1) Then 'if it's not the last element (the date)
                        If part = eventSplit(0) Then                  'if it's the first part of the name
                            name += part
                        Else                                          'if it's any other part of the anme
                            name += " " & part
                        End If
                    End If
                Next
                cmd.Parameters.AddWithValue("@name", name)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            txtName.Text = dr("EventName")
                            dtpDate.Text = dr("EventDate")
                            If dr("Type") = "Training" Then
                                rdbTraining.Checked = True
                            Else
                                rdbMeet.Checked = True
                            End If
                            dtpStart.Text = dr("StartTime")
                            dtpEnd.Text = dr("EndTime")
                            attendees.Clear()
                            Dim tmpSender As New ComboBox
                            tmpSender.Tag = "template"
                            gbAthletes.Enabled = True
                            If dr("Personnel").ToString() <> "" Then
                                attendees.AddRange(dr("Personnel").Split(";"))
                            End If
                            notes.Clear()
                            If dr("Notes").ToString() <> "" Then
                                notes.AddRange(dr("Notes").Split(";"))
                            End If
                            If dr("Personnel").ToString() <> "" Then
                                cmbGroup_SelectedValueChanged(tmpSender, Nothing)
                            End If
                            Cursor.Current = Cursors.AppStarting
                            times.Clear()
                            If dr("Events") = "N/A" Then
                                chbNA.Checked = True
                                cmbEvent.Enabled = False
                                btnSaveTimes.Enabled = False
                                dtp13s.Enabled = False
                                dtp14s.Enabled = False
                                dtp15s.Enabled = False
                                dtp16s.Enabled = False
                                dtp17s.Enabled = False
                                dtpOpens.Enabled = False
                                lbl13s.Enabled = False
                                lbl14s.Enabled = False
                                lbl15s.Enabled = False
                                lbl16s.Enabled = False
                                lbl17s.Enabled = False
                                lblOpens.Enabled = False
                            Else
                                times.AddRange(dr("Events").Split(";"))
                                tmpSender.Tag = "firstOpen"
                                cmbEvent_SelectedValueChanged(tmpSender, Nothing)
                            End If
                            If dr("AttachNames").ToString() <> "" Then
                                Dim fileNames() As String = dr("AttachNames").Split(";")
                                filePaths = fileNames.ToList()
                                If fileNames.Count > 0 Then
                                    Dim tempPb As New PictureBox    'creates a temporary picturebox to be used as a sender
                                    With tempPb
                                        .Width = pbAttach.Width
                                        .Height = pbAttach.Height
                                        .Tag = "add"
                                        .SizeMode = PictureBoxSizeMode.StretchImage
                                    End With
                                    pbAttach.Tag = fileNames(0) 'sets the filename to the existing picturebox
                                    If fileNames(0).EndsWith("doc") Or fileNames(0).EndsWith("docx") Then
                                        pbAttach.Image = My.Resources.word
                                    Else
                                        pbAttach.Image = My.Resources.excel
                                    End If
                                    pbAttach.Location = New Point(-1, -1)
                                    If pnlAttach.Controls.Count = 2 Then
                                        For Each pnl In flpAttach.Controls.OfType(Of Panel)()
                                            If pnl.Name = pnlAttach.Name Then
                                                For Each lbl In pnl.Controls.OfType(Of Label)()
                                                    lbl.Text = fileNames(0)
                                                Next
                                                Exit For
                                            End If
                                        Next
                                    ElseIf pnlAttach.Controls.Count = 1 Then
                                        Dim lbl As New Label
                                        lbl.Cursor = Cursors.Default
                                        lbl.AutoSize = True
                                        lbl.Font = New Drawing.Font("Arial", 9)
                                        lbl.Text = fileNames(0)
                                        Me.Controls.Add(lbl)
                                        lbl.Parent = pbAttach.Parent
                                        lbl.Location = New Point(75, 0)
                                        lbl.BackColor = Color.Transparent
                                        lbl.BringToFront()
                                        AddHandler lbl.Click, AddressOf clickHandler
                                    End If
                                    If fileNames.Count = 1 Then
                                        createPictureBox(tempPb)
                                    End If
                                    If fileNames.Count = pbCount Then 'if the number of files matches the number of panels
                                        Dim currentNum As Integer = 2, numPanels As Integer = pbCount
                                        While currentNum <= fileNames.Count 'add the files
                                            For Each pnl In flpAttach.Controls.OfType(Of Panel)()
                                                If pnl.Name = "pnl" & currentNum.ToString() Then
                                                    For Each control In pnl.Controls
                                                        If currentNum = fileNames.Count Then
                                                            If control.GetType() Is GetType(PictureBox) Then
                                                                control.Tag = fileNames(currentNum - 1)
                                                                If fileNames(currentNum - 1).EndsWith("doc") Or fileNames(currentNum - 1).EndsWith("docx") Then
                                                                    control.Image = My.Resources.word
                                                                Else
                                                                    control.Image = My.Resources.excel
                                                                End If
                                                                control.Location = New Point(-1, -1)
                                                            End If
                                                            Dim lbl As New Label
                                                            lbl.Cursor = Cursors.Default
                                                            lbl.AutoSize = True
                                                            lbl.Font = New Drawing.Font("Arial", 9)
                                                            lbl.Text = fileNames(currentNum - 1)
                                                            Me.Controls.Add(lbl)
                                                            lbl.Parent = pnl
                                                            lbl.Location = New Point(75, 0)
                                                            lbl.BackColor = Color.Transparent
                                                            lbl.BringToFront()
                                                            AddHandler lbl.Click, AddressOf clickHandler
                                                        Else
                                                            If control.GetType() Is GetType(PictureBox) Then
                                                                control.Tag = fileNames(currentNum - 1)
                                                                If fileNames(currentNum - 1).EndsWith("doc") Or fileNames(currentNum - 1).EndsWith("docx") Then
                                                                    control.Image = My.Resources.word
                                                                Else
                                                                    control.Image = My.Resources.excel
                                                                End If
                                                                control.Location = New Point(-1, -1)
                                                            ElseIf control.GetType() Is GetType(Label) Then
                                                                control.text = fileNames(currentNum - 1)
                                                            End If
                                                        End If
                                                    Next
                                                    Exit For
                                                End If
                                            Next
                                            currentNum += 1
                                        End While
                                        createPictureBox(tempPb)
                                    ElseIf fileNames.Count < pbCount Then
                                        Dim currentNum As Integer = 2, numPanels As Integer = pbCount
                                        While currentNum <= fileNames.Count 'add the files
                                            For Each pnl In flpAttach.Controls.OfType(Of Panel)()
                                                If pnl.Name = "pnl" & currentNum.ToString() Then
                                                    Dim hasLabel As Boolean = False
                                                    For Each control In pnl.Controls
                                                        If control.GetType() Is GetType(PictureBox) Then
                                                            control.Tag = fileNames(currentNum - 1)
                                                            If fileNames(currentNum - 1).EndsWith("doc") Or fileNames(currentNum - 1).EndsWith("docx") Then
                                                                control.Image = My.Resources.word
                                                            Else
                                                                control.Image = My.Resources.excel
                                                            End If
                                                            control.Location = New Point(-1, -1)
                                                        ElseIf control.GetType() Is GetType(Label) Then
                                                            hasLabel = True
                                                            control.text = fileNames(currentNum - 1)
                                                        End If
                                                    Next
                                                    If hasLabel = False Then
                                                        Dim lbl As New Label
                                                        lbl.Cursor = Cursors.Default
                                                        lbl.AutoSize = True
                                                        lbl.Font = New Drawing.Font("Arial", 9)
                                                        lbl.Text = fileNames(currentNum - 1)
                                                        Me.Controls.Add(lbl)
                                                        lbl.Parent = pnl
                                                        lbl.Location = New Point(75, 0)
                                                        lbl.BackColor = Color.Transparent
                                                        lbl.BringToFront()
                                                        AddHandler lbl.Click, AddressOf clickHandler
                                                    End If
                                                    Exit For
                                                End If
                                            Next
                                            currentNum += 1
                                        End While
                                        While currentNum <= numPanels
                                            If currentNum = fileNames.Count + 1 Then
                                                For Each pnl In flpAttach.Controls.OfType(Of Panel)()
                                                    If pnl.Name = "pnl" & currentNum.ToString() Then
                                                        pnl.Controls.Clear()
                                                        Dim pb As New PictureBox
                                                        With pb
                                                            .Tag = "add"
                                                            .Name = "pb" & currentNum.ToString()
                                                            .Image = My.Resources.transparent_plus
                                                            .SizeMode = pbAttach.SizeMode
                                                            .Width = pbAttach.Width
                                                            .Height = pbAttach.Height
                                                            .Cursor = Cursors.Hand
                                                        End With
                                                        AddHandler pb.Click, AddressOf pbAttach_Click
                                                        pnl.Controls.Add(pb)
                                                        pb.Location = New Point((pnlAttach.Width / 2 - pbAttach.Width / 2), -1)
                                                        Exit For
                                                    End If
                                                Next
                                            Else
                                                For Each pnl In flpAttach.Controls.OfType(Of Panel)()
                                                    If pnl.Name = "pnl" & currentNum.ToString() Then
                                                        flpAttach.Controls.Remove(pnl)
                                                        pbCount -= 1
                                                        Exit For
                                                    End If
                                                Next
                                            End If
                                            currentNum += 1
                                        End While
                                    Else
                                        Dim currentNum As Integer = 2, numPanels As Integer = pbCount
                                        While currentNum <= numPanels 'add the files
                                            For Each pnl In flpAttach.Controls.OfType(Of Panel)()
                                                If pnl.Name = "pnl" & currentNum.ToString() Then
                                                    Dim hasLabel As Boolean = False
                                                    For Each control In pnl.Controls
                                                        If control.GetType() Is GetType(PictureBox) Then
                                                            control.Tag = fileNames(currentNum - 1)
                                                            If fileNames(currentNum - 1).EndsWith("doc") Or fileNames(currentNum - 1).EndsWith("docx") Then
                                                                control.Image = My.Resources.word
                                                            Else
                                                                control.Image = My.Resources.excel
                                                            End If
                                                            control.Location = New Point(-1, -1)
                                                        ElseIf control.GetType() Is GetType(Label) Then
                                                            hasLabel = True
                                                            control.text = fileNames(currentNum - 1)
                                                        End If
                                                    Next
                                                    If hasLabel = False Then
                                                        Dim lbl As New Label
                                                        lbl.Cursor = Cursors.Default
                                                        lbl.AutoSize = True
                                                        lbl.Font = New Drawing.Font("Arial", 9)
                                                        lbl.Text = fileNames(currentNum - 1)
                                                        Me.Controls.Add(lbl)
                                                        lbl.Parent = pnl
                                                        lbl.Location = New Point(75, 0)
                                                        lbl.BackColor = Color.Transparent
                                                        lbl.BringToFront()
                                                        AddHandler lbl.Click, AddressOf clickHandler
                                                    End If
                                                    Exit For
                                                End If
                                            Next
                                            currentNum += 1
                                        End While
                                        While currentNum <= fileNames.Count
                                            pbCount += 1
                                            Dim pnl As New Panel
                                            With pnl
                                                pnl.BackColor = pnlAttach.BackColor
                                                pnl.Name = "pnl" & pbCount
                                                pnl.Width = pnlAttach.Width
                                                pnl.Height = pnlAttach.Height
                                                pnl.BorderStyle = pnlAttach.BorderStyle
                                                pnl.Cursor = Cursors.Hand
                                            End With
                                            AddHandler pnl.Click, AddressOf pnlAttach_Click
                                            flpAttach.Controls.Add(pnl)
                                            Dim pb As New PictureBox
                                            pb.Name = "pb" & pbCount
                                            pb.SizeMode = pbAttach.SizeMode
                                            pb.Width = pbAttach.Width
                                            pb.Height = pbAttach.Height
                                            If fileNames(currentNum - 1).EndsWith("doc") Or fileNames(currentNum - 1).EndsWith("docx") Then
                                                pb.Image = My.Resources.word
                                            Else
                                                pb.Image = My.Resources.excel
                                            End If
                                            pb.Tag = fileNames(currentNum - 1)
                                            pb.Cursor = Cursors.Hand
                                            AddHandler pb.Click, AddressOf pbAttach_Click
                                            pnl.Controls.Add(pb)
                                            pb.Location = New Point(-1, -1)
                                            Dim lbl As New Label
                                            lbl.Cursor = Cursors.Default
                                            lbl.AutoSize = True
                                            lbl.Font = New Drawing.Font("Arial", 9)
                                            lbl.Text = fileNames(currentNum - 1)
                                            Me.Controls.Add(lbl)
                                            lbl.Parent = pnl
                                            lbl.Location = New Point(75, 0)
                                            lbl.BackColor = Color.Transparent
                                            lbl.BringToFront()
                                            AddHandler lbl.Click, AddressOf clickHandler
                                            If currentNum = fileNames.Count Then
                                                createPictureBox(tempPb)
                                            End If
                                            currentNum += 1
                                        End While
                                    End If
                                End If
                            Else
                                filePaths.Clear()
                                Dim panels As List(Of Panel) = flpAttach.Controls.OfType(Of Panel)().ToList
                                For Each pnl In panels
                                    If pnl.Name <> pnlAttach.Name And pnl.Name <> "pnl2" Then
                                        flpAttach.Controls.Remove(pnl)
                                    ElseIf pnl.Name = "pnl2" Then
                                        pnl.Controls.Clear()
                                        Dim pb As New PictureBox
                                        pb.Name = "pb2"
                                        pb.SizeMode = pbAttach.SizeMode
                                        pb.Width = pbAttach.Width
                                        pb.Height = pbAttach.Height
                                        pb.Image = My.Resources.transparent_plus
                                        pb.Tag = "add"
                                        pb.Cursor = Cursors.Hand
                                        AddHandler pb.Click, AddressOf pbAttach_Click
                                        pnl.Controls.Add(pb)
                                        pb.Location = New Point((pnlAttach.Width / 2 - pb.Width / 2), -1)
                                    End If
                                Next
                                pbCount = 2
                                deleteAttachment(pbAttach)
                            End If
                            placeMarker(CType(dr("Location").split(";")(0), Double), CType(dr("Location").split(";")(1), Double), "click")
                            Cursor.Current = Cursors.AppStarting
                            txtComment.Text = dr("Comment")
                            If dr("Repeats").ToString() <> "N/A" Then
                                Dim reps As String() = dr("Repeats").split(";")
                                cmbRepType.SelectedItem = reps(reps.Length - 1)
                                Dim repsList = reps.ToList
                                repsList.RemoveAt(reps.Count - 1)
                                For Each day In repsList
                                    clbDays.SetItemChecked(clbDays.Items.IndexOf(day), True)
                                Next
                            Else
                                chbRepNA.Checked = True
                            End If
                            If dr("IsRepeat") Then
                                chbRepNA.Enabled = False
                                lblRepeat.Visible = True
                                lblRepeat.Location = New Point(pbCmb.Location.X, pbCmb.Location.Y + pbCmb.Height + 20)
                                lblRepeat.AutoSize = False
                                lblRepeat.Width = pbCmb.Width - 10
                                lblRepeat.Height = 80
                                Dim baseText = "This is a repeating event."
                                If access = 2 Then
                                    lblRepeat.Text = baseText + vbNewLine + "If you wish to make changes to the repeating style, do so on the original event."
                                Else
                                    lblRepeat.Text = baseText
                                End If
                            End If
                        Loop
                    End If
                End Using
            End Using
            conn.Close()
        End Using
        Cursor.Current = Cursors.Default
#End Region
    End Sub
#End Region
#Region "Attachment Operations"
    Private Sub pbAttach_Click(sender As Object, e As EventArgs) Handles pbAttach.Click
        If sender.Tag = "add" Then
            ofdOpen.FileName = ""
            ofdOpen.Filter = "Word And Excel (*.docx, * .doc, * .xls * .xlsx)|*.docx; *.doc; *xls; *.xlsx"
            ofdOpen.ShowDialog()
            If ofdOpen.FileName <> "" Then
                sender.location = New Point(-1, -1)
                Dim dotSplit = ofdOpen.FileName.Split(".")
                Dim backSplit = ofdOpen.FileName.Split("\")
                Select Case dotSplit(dotSplit.Count - 1)
                    Case "docx" : sender.Image = My.Resources.word
                        sender.Tag = backSplit(backSplit.Count - 1)
                    Case "xlsx" : sender.Image = My.Resources.excel
                        sender.Tag = backSplit(backSplit.Count - 1)
                End Select
                filePaths.Add(ofdOpen.FileName)
                Dim lbl As New Label
                lbl.Cursor = Cursors.Default
                lbl.Font = New Drawing.Font("Arial", 9)
                lbl.Text = sender.Tag
                Me.Controls.Add(lbl)
                lbl.Parent = sender.Parent
                lbl.Location = New Point(75, 0)
                lbl.AutoSize = True
                lbl.BackColor = Color.Transparent
                lbl.BringToFront()
                AddHandler lbl.Click, AddressOf clickHandler
                createPictureBox(sender)
            End If
        ElseIf sender.Tag.Contains("docx") Or sender.Tag.Contains("xlsx") Then
            checkFileBeforeOpen(sender.Tag, sender)
        End If
    End Sub
    Private Sub pnlAttach_Click(sender As Object, e As EventArgs) Handles pnlAttach.Click
        Dim tmpPbName As String = "pb"
        If sender.name <> pnlAttach.Name Then
            tmpPbName += CStr(Int(sender.name.Split("pnl".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)(0).ToString())) 'splits the string on "pnl" and gets the number after
        Else
            tmpPbName = "pbAttach"
        End If
        For Each pb In sender.Controls
            If pb.Name = tmpPbName Then
                pbAttach_Click(pb, e)
                Exit For
            End If
        Next
    End Sub
    Private Sub createPictureBox(sender As Object)
        pbCount += 1
        Dim pnl As New Panel
        With pnl
            pnl.BackColor = pnlAttach.BackColor
            pnl.Name = "pnl" & pbCount
            pnl.Width = pnlAttach.Width
            pnl.Height = pnlAttach.Height
            pnl.BorderStyle = pnlAttach.BorderStyle
            pnl.Cursor = Cursors.Hand
        End With
        AddHandler pnl.Click, AddressOf pnlAttach_Click
        flpAttach.Controls.Add(pnl)
        Dim pb As New PictureBox
        pb.Name = "pb" & pbCount
        pb.SizeMode = sender.sizeMode
        pb.Width = sender.width
        pb.Height = sender.height
        pb.Image = My.Resources.transparent_plus
        pb.Tag = "add"
        pb.Cursor = Cursors.Hand
        AddHandler pb.Click, AddressOf pbAttach_Click
        pnl.Controls.Add(pb)
        pb.Location = New Point((pnlAttach.Width / 2 - pb.Width / 2), -1)
    End Sub
    Sub checkFileBeforeOpen(ByVal fileName As String, ByVal sender As Object)
        If (fileName.EndsWith("xlsx") Or fileName.EndsWith("xls")) AndAlso excelApp Is Nothing OrElse (fileName.EndsWith("doc") Or fileName.EndsWith("docx")) AndAlso wordApp Is Nothing Then
            Dim officeType As Type
            If access <> 2 Then
                saveOrOpen.Tag = "view"
            End If
            saveOrOpen.ShowDialog()
            If saveOrOpen.result = "save" Then
                sfdSave.FileName = fileName
                If fileName.EndsWith("doc") Or fileName.EndsWith("docx") Then
                    officeType = Type.GetTypeFromProgID("Word.Application")
                    sfdSave.Filter = "(*.docx, *.doc)|*.docx; *.doc"
                Else
                    officeType = Type.GetTypeFromProgID("Excel.Application")
                    sfdSave.Filter = "(*.xlsx, *.xls)|*.xlsx; *.xls"
                End If
                Using conn As New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                    conn.Open()
                    Using cmd As New OleDbCommand("Select FileInfo FROM Attachments WHERE FileName = @fileName", conn)
                        cmd.Parameters.AddWithValue("@fileName", fileName)
                        Using dr = cmd.ExecuteReader()
                            If dr.HasRows Then
                                If sfdSave.ShowDialog() <> DialogResult.Cancel And sfdSave.FileName <> "" And officeType <> Nothing Then
                                    dr.Read()
                                    Dim fileInfo As Byte() = CType(dr("FileInfo"), Byte())
                                    Using ms As New System.IO.MemoryStream(fileInfo)
                                        Dim fs As New System.IO.FileStream(sfdSave.FileName, System.IO.FileMode.Create, System.IO.FileAccess.Write)
                                        fs.Write(fileInfo, 0, ms.Length)
                                        fs.Dispose()
                                        If fileName.EndsWith("doc") Or fileName.EndsWith("docx") Then
                                            openWordFile(sfdSave.FileName)
                                        Else
                                            openExcelFile(sfdSave.FileName)
                                        End If
                                    End Using
                                ElseIf officeType = Nothing Then
                                    If fileName.EndsWith("doc") Or fileName.EndsWith("docx") Then
                                        MessageBox.Show("You do not have Word installed.", "Missing Application", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        MessageBox.Show("You do not have Excel installed.", "Missing Application", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    End If
                                ElseIf sfdSave.FileName = "" Then
                                    MessageBox.Show("Please enter a valid file name.", "Invalid Filename", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Else
                                MessageBox.Show("Please upload the file first before trying to save.", "Invalid Save Request", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End Using
                    End Using
                    conn.Close()
                End Using
            ElseIf saveOrOpen.result = "open" Then
                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                    conn.Open()
                    Using cmd As New OleDbCommand("Select FileInfo FROM Attachments WHERE FileName = @fileName", conn)
                        cmd.Parameters.AddWithValue("@fileName", fileName)
                        Using dr = cmd.ExecuteReader()
                            If dr.HasRows Then
                                dr.Read()
                                Dim fileInfo As Byte() = CType(dr("FileInfo"), Byte())
                                Using ms As New System.IO.MemoryStream(fileInfo)
                                    tempFilePath = System.IO.Path.GetTempFileName
                                    If fileName.EndsWith("doc") Or fileName.EndsWith("docx") Then
                                        deleteWordFileThread = New Thread(Sub() deleteTempFile(tempFilePath))
                                    Else
                                        deleteExcelFileThread = New Thread(Sub() deleteTempFile(tempFilePath))
                                    End If
                                    Dim fs As New System.IO.FileStream(tempFilePath, System.IO.FileMode.Create, System.IO.FileAccess.Write)
                                    fs.Write(fileInfo, 0, ms.Length)
                                    fs.Dispose()
                                    If fileName.EndsWith("doc") Or fileName.EndsWith("docx") Then
                                        openWordFile(tempFilePath)
                                    Else
                                        openExcelFile(tempFilePath)
                                    End If
                                End Using
                            Else
                                If MessageBox.Show("The file has not been uploaded yet." + vbNewLine + "Would you like to open the file from your computer?", "File Not Uploaded", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                                    Dim fileValid As Boolean = False
                                    While fileValid = False
                                        ofdOpen.FileName = ""
                                        If fileName.EndsWith("doc") Or fileName.EndsWith("docx") Then
                                            officeType = Type.GetTypeFromProgID("Word.Application")
                                            ofdOpen.Filter = "(*.docx, *.doc)|*.docx; *.doc"
                                        Else
                                            officeType = Type.GetTypeFromProgID("Excel.Application")
                                            ofdOpen.Filter = "(*.xlsx, *.xsl)|*.xlsx; *.xls"
                                        End If
                                        If ofdOpen.ShowDialog() <> DialogResult.Cancel And System.IO.Path.GetFileName(ofdOpen.FileName) = fileName And officeType <> Nothing Then
                                            If fileName.EndsWith("doc") Or fileName.EndsWith("docx") Then
                                                openWordFile(ofdOpen.FileName)
                                            Else
                                                openExcelFile(ofdOpen.FileName)
                                            End If
                                            fileValid = True
                                        ElseIf officeType = Nothing Then
                                            If fileName.EndsWith("doc") Or fileName.EndsWith("docx") Then
                                                MessageBox.Show("You do not have Word installed.", "Missing Application", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            Else
                                                MessageBox.Show("You do not have Excel installed.", "Missing Application", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            End If
                                            fileValid = True
                                        ElseIf System.IO.Path.GetFileName(ofdOpen.FileName) <> fileName Then
                                            If MessageBox.Show("You have not selected the attachment file." + vbNewLine + "Would you like to select the file again?", "Wrong File Selected", MessageBoxButtons.RetryCancel) = DialogResult.Cancel Then
                                                fileValid = True
                                            Else
                                                fileValid = False
                                            End If
                                        End If
                                    End While
                                End If
                            End If
                        End Using
                    End Using
                    conn.Close()
                End Using
            ElseIf saveOrOpen.result = "delete" Then
                deleteAttachment(sender)
            End If
        Else
            MessageBox.Show("You already have the attachment open." + vbNewLine + "Please finish operations With the open attachment before trying to interact with this one.", "Attachment Open", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub deleteAttachment(ByVal sender As Object)
        Dim pnlToDelete As String = "pnl", numIndicator As Integer = 0
        filePaths.Remove(sender.tag)
        If sender.name <> pbAttach.Name Then
            numIndicator = Int(sender.name.split("pb".ToCharArray, StringSplitOptions.RemoveEmptyEntries)(0).ToString()) 'splits on "pb" and gets the number after
            pnlToDelete += CStr(numIndicator + 1)
        Else
            pnlToDelete = "pnl2"
            numIndicator = 1
        End If
        'place the contents of the panel below the sender into the sender and then delete the one below
        For Each pnlForDelete In flpAttach.Controls.OfType(Of Panel)() 'find the panel to delete
            If pnlForDelete.Name = pnlToDelete Then
                For Each pbForDelete In pnlForDelete.Controls.OfType(Of PictureBox)() 'find the picturebox in the panel
                    sender.image = pbForDelete.Image
                    sender.tag = pbForDelete.Tag
                    sender.location = pbForDelete.Location
                    Exit For 'since there is only one picturebox in each panel
                Next
                For Each lbl In sender.parent.controls 'find the label in the panel to overwrite
                    If lbl.GetType() Is GetType(Label) Then
                        If pnlForDelete.Controls.OfType(Of Label)().Count > 0 Then 'if the panel to delete has a label
                            For Each lblForDelete In pnlForDelete.Controls.OfType(Of Label)() 'find the label in the panel to delete
                                lbl.text = lblForDelete.Text
                                Exit For
                            Next
                        Else
                            sender.parent.controls.remove(lbl)
                        End If
                        Exit For 'since there is only one label in each panel
                    End If
                Next
                flpAttach.Controls.Remove(pnlForDelete)
                Exit For
            End If
        Next
        'this "copy And delete" results in panels below the sender being one number to high
        'we now need to decrement these and their elements
        For Each pnlForDecrement In flpAttach.Controls.OfType(Of Panel)() 'find the panels to decrement
            If pnlForDecrement.Name <> pnlAttach.Name Then 'since the first panel will always have the correct name
                Dim currentNum = Int(pnlForDecrement.Name.Split("pnl".ToCharArray, StringSplitOptions.RemoveEmptyEntries)(0).ToString())
                If currentNum > numIndicator Then
                    For Each pb In pnlForDecrement.Controls.OfType(Of PictureBox)()
                        pnlForDecrement.Name = "pnl" & CStr(currentNum - 1)
                        pb.Name = "pb" & CStr(currentNum - 1)
                        Exit For
                    Next
                End If
            End If
        Next
        pbCount -= 1
    End Sub
#End Region
#Region "Microsoft Office Interactions"
    Private Sub openWordFile(ByVal path As String)
        Try
            Cursor = Cursors.AppStarting
            'browseAttach.docBrowser.Navigate(path)
            'browseAttach.Show()
            wordApp = New Word.Application
            wordApp.Visible = True
            'app.DisplayAlerts = False
            'fix "being used by another user thingo
            wordApp.Documents.Open(path)
            'doc.Protect(Word.WdProtectionType.wdAllowOnlyReading)

            'doc =wordApp.Documents(1)

            Cursor = Cursors.Default
        Catch e As Exception
            If MessageBox.Show("The file was unable to be opened. Please make sure the file is not already open.", "Unable To Open File", MessageBoxButtons.RetryCancel) = DialogResult.Cancel Then
                word_Quit(doc, Nothing)
            Else
                word_Quit(doc, Nothing)
                openWordFile(path)
            End If
            'Dim p() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("WINWORD")
            'p.Last.Kill()
        End Try
    End Sub
    Private Sub word_Quit(ByVal tempDoc As Word.Document, ByRef cancel As Boolean) Handles wordApp.DocumentBeforeClose
        Try
            wordApp.NormalTemplate.Saved = True
            'doc.Saved = True
            'doc.Close(SaveChanges:=False)
            'System.Runtime.InteropServices.Marshal.ReleaseComObject(doc)

            'app.DisplayAlerts = False
            wordApp.Quit()

            'My.Computer.FileSystem.DeleteFile(path)
            'Dim p As System.Diagnostics.Process
            'For Each p In System.Diagnostics.Process.GetProcesses()
            '    If p.ProcessName = "WINWORD" Then
            '        p.Kill()
            '    End If
            'Next
            'Need to kill the process after it closes (use a boolean?)
        Catch e As Exception
            MessageBox.Show(e.ToString())
        Finally
            doc = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp)
            wordApp = Nothing
            deleteWordFileThread.Start()
        End Try
    End Sub
    Private Sub openExcelFile(ByVal path As String)
        Try
            Cursor = Cursors.AppStarting
            excelApp = New Excel.Application
            excelApp.Visible = True
            sheets = excelApp.Workbooks
            'app.DisplayAlerts = False
            'fix "being used by another user thingo
            workbook = sheets.Open(path)
            'doc.Protect(Word.WdProtectionType.wdAllowOnlyReading)

            'doc =wordApp.Documents(1)

            Cursor = Cursors.Default
        Catch e As Exception
            If MessageBox.Show("The file was unable to be opened. Please make sure the file is not already open.", "Unable To Open File", MessageBoxButtons.RetryCancel) = DialogResult.Cancel Then
                excel_Quit(workbook, Nothing)
            Else
                excel_Quit(workbook, Nothing)
                openExcelFile(path)
            End If
            'Dim p() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("WINWORD")
            'p.Last.Kill()
        End Try
    End Sub
    Private Sub excel_Quit(ByVal tempBook As Excel.Workbook, ByRef cancel As Boolean) Handles excelApp.WorkbookBeforeClose
        Try
            'excelApp.NormalTemplate.Saved = True
            'doc.Saved = True
            'doc.Close(SaveChanges:=False)
            'System.Runtime.InteropServices.Marshal.ReleaseComObject(doc)
            workbook.Saved = True
            'app.DisplayAlerts = False
            excelApp.Quit()

            'My.Computer.FileSystem.DeleteFile(path)
            'Dim p As System.Diagnostics.Process
            'For Each p In System.Diagnostics.Process.GetProcesses()
            '    If p.ProcessName = "WINWORD" Then
            '        p.Kill()
            '    End If
            'Next
            'Need to kill the process after it closes (use a boolean?)
        Catch e As Exception
            MessageBox.Show(e.ToString())
        Finally
            System.Runtime.InteropServices.Marshal.ReleaseComObject(sheets)
            sheets = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
            workbook = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
            excelApp = Nothing
            deleteExcelFileThread.Start()
        End Try
    End Sub
    Private Sub deleteTempFile(path As String)
        While My.Computer.FileSystem.FileExists(path)
            Try
                System.IO.File.Delete(path)
            Catch ex As Exception
                Thread.Sleep(1000)
            End Try
        End While
    End Sub
#End Region
#Region "Map Operations"
    Private Sub map_DoubleClick(sender As Object, e As MouseEventArgs) Handles map.MouseDoubleClick
        Dim lat = map.FromLocalToLatLng(e.X, e.Y).Lat
        Dim lng = map.FromLocalToLatLng(e.X, e.Y).Lng
        If map.Overlays.Count = 0 Then
            placeMarker(lat, lng, "click")
        Else
            If MessageBox.Show("You already have a marker placed." + vbNewLine + "You can only have one location for your event." + vbNewLine + "Would you like to change the location to your new selection?", "Single Location Only", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                placeMarker(lat, lng, "click")
            End If
        End If
    End Sub
    Private Sub map_OnMarkerClick(sender As Object, e As MouseEventArgs) Handles map.OnMarkerClick
        If hasRunClickEvent = False Then
            hasRunClickEvent = True
            If tooManySelected = False Or (sender.position.lat = -33.8688197 AndAlso sender.position.lng = 151.2092955) Then
                If map.Overlays.Count > 1 Then
                    If MessageBox.Show("Are you sure you want to select " + sender.tooltiptext + "?", "Marker Selection", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        Dim lat = sender.position.lat
                        Dim lng = sender.position.lng
                        Dim places As List(Of Placemark) = Nothing
                        Dim status = MapProviders.GoogleMapProvider.Instance.GetPlacemarks(New PointLatLng(lat, lng), places)
                        If status = GeoCoderStatusCode.G_GEO_SUCCESS And places IsNot Nothing Then
                            Dim address = places(0).Address.Split(",")
                            For i As Integer = 0 To address.Count - 2 'to skip "Australia"
                                If i = address.Count - 2 Then 'the part with SUBURB STATE POSTCODE
                                    Dim details = LTrim(address(i)).Split(" ")
                                    txtSuburb.Text = ""
                                    For j As Integer = 0 To details.Count - 2 'to skip the postcode
                                        If j <> details.Count - 2 Then
                                            txtSuburb.Text += details(j) + " "
                                        Else
                                            cmbState.SelectedItem = details(j)
                                        End If
                                    Next
                                    txtSuburb.Text = RTrim(txtSuburb.Text)
                                Else
                                    txtStreet.Text = address(i)
                                End If
                            Next
                        End If
                        map.ZoomAndCenterMarkers(sender.overlay.id)
                        map.Zoom += 4
                        waitThread = New Thread(Sub() waitForSubEnd(lat, lng, "click"))
                        waitThread.Start()
                    End If
                End If
            Else
                MessageBox.Show("You have selected more than one marker." + vbNewLine + "Try zooming in closer and select only one marker.")
                tooManySelected = False
            End If
        Else
            hasRunClickEvent = False
        End If
    End Sub
    Private Sub map_Click(sender As Object, e As MouseEventArgs) Handles map.Click
        Dim hoverCount As Integer = 0
        For Each layer In map.Overlays
            For Each marker In layer.Markers
                If marker.IsMouseOver Then
                    hoverCount += 1
                End If
            Next
        Next
        If hoverCount > 1 Then
            tooManySelected = True
        End If
    End Sub
    Private Sub waitForSubEnd(lat, lng, type)
        Thread.Sleep(500)
        placeMarker(lat, lng, type)
    End Sub
    Private Sub checkConnection()
        Try
            'Dim client As Net.WebClient = New Net.WebClient()
            'client.Proxy = proxy
            'Dim resp = client.DownloadString(url)
            'connectionPresent = True
            Dim url As String = "http://maps.google.com/maps/api/geocode/xml?address=sydney&sensor=false"
            Dim request As Net.WebRequest = Net.WebRequest.Create(url)
            If proxyPresent Then
                Dim proxy As Net.IWebProxy = New Net.WebProxy("proxy.intranet", 8080)
                proxy.Credentials = New Net.NetworkCredential("eddie.belokopytov", "zorba491")
                request.Proxy = proxy
            End If
            Using response As Net.WebResponse = DirectCast(request.GetResponse(), Net.HttpWebResponse)
                connectionPresent = True
            End Using
        Catch ex As Exception
            connectionPresent = False
        End Try
    End Sub
    Private Sub placeMarker(lat As Double, lng As Double, type As String)
        Cursor.Current = Cursors.AppStarting
        If type = "click" Then
            map.Overlays.Clear()
            overlayCount = 0
        End If
        overlayCount += 1
        Dim overlayId As String = "overlay" & CStr(overlayCount)
        Dim overlay As New GMapOverlay(overlayId)
        Dim marker As Markers.GMarkerGoogle = New Markers.GMarkerGoogle(New GMap.NET.PointLatLng(lat, lng), Markers.GMarkerGoogleType.green)
        map.Overlays.Add(overlay)
        overlay.Markers.Add(marker)
        Dim places As List(Of Placemark) = Nothing
        Dim status = MapProviders.GoogleMapProvider.Instance.GetPlacemarks(New PointLatLng(lat, lng), places)
        If status = GeoCoderStatusCode.G_GEO_SUCCESS And places IsNot Nothing Then
            Dim placeInfo As String = places(0).Address.ToString()
            marker.ToolTip = New GMapToolTip(marker)
            marker.ToolTipText = placeInfo
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver
            If Thread.CurrentThread.ManagedThreadId = mainThreadID Then 'checks if it's the main thread so that textboxes can be updated
                If map.Overlays.Count <= 1 Then
                    Dim address = places(0).Address.Split(",")
                    For i As Integer = 0 To address.Count - 2 'to skip "Australia"
                        If i = address.Count - 2 Then 'the part with SUBURB STATE POSTCODE
                            Dim details = LTrim(address(i)).Split(" ")
                            txtSuburb.Text = ""
                            For j As Integer = 0 To details.Count - 2 'to skip the postcode
                                If j <> details.Count - 2 Then
                                    txtSuburb.Text += details(j) + " "
                                Else
                                    cmbState.SelectedItem = details(j)
                                End If
                            Next
                            txtSuburb.Text = RTrim(txtSuburb.Text)
                        Else
                            txtStreet.Text = address(i)
                        End If
                    Next
                    map.ZoomAndCenterMarkers(Nothing)
                    map.Zoom += 4
                End If
            End If
        ElseIf places Is Nothing Then
            connectionPresent = False
            MessageBox.Show("There is no server access to Google currently." + vbNewLine + "Markers will still be placed but will not have a tooltip appear on hover.", "No server access", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        checkConnection()
        Dim searchLocation As String = "", incorrectAddress As String = ""
        If txtStreet.Text <> "" Then
            searchLocation += txtStreet.Text
        Else
            incorrectAddress = "street/place"
        End If
        If txtSuburb.Text <> "" Then
            searchLocation += ", " + txtSuburb.Text
        Else
            If incorrectAddress <> "" Then
                incorrectAddress += " and suburb"
            Else
                incorrectAddress = "suburb"
            End If
        End If
        searchLocation += ", " + cmbState.SelectedItem + ", Australia"
        Dim noResult As Boolean = False
        If connectionPresent And incorrectAddress = "" Then
            Cursor.Current = Cursors.AppStarting
            Dim url As String = "http://maps.google.com/maps/api/geocode/xml?address=" + searchLocation + "&sensor=false"
            Dim request As Net.WebRequest = Net.WebRequest.Create(url)
            If proxyPresent Then
                Dim proxy As Net.IWebProxy = New Net.WebProxy("proxy.intranet", 8080)
                proxy.Credentials = New Net.NetworkCredential("eddie.belokopytov", "zorba491")
                request.Proxy = proxy
            End If
            Using response As Net.WebResponse = DirectCast(request.GetResponse(), Net.HttpWebResponse)
                Using reader As New IO.StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8)
                    Dim dsResult As New DataSet()
                    dsResult.ReadXml(reader)
                    Dim dtCoordinates As New DataTable()
                    dtCoordinates.Columns.AddRange(New DataColumn(3) {New DataColumn("Id", GetType(Integer)), New DataColumn("Address", GetType(String)), New DataColumn("Latitude", GetType(String)), New DataColumn("Longitude", GetType(String))})
                    If dsResult.Tables("result") IsNot Nothing Then
                        For Each row As DataRow In dsResult.Tables("result").Rows
                            Dim geometry_id As String = dsResult.Tables("geometry").[Select]("result_id = " + row("result_id").ToString())(0)("geometry_id").ToString()
                            Dim location As DataRow = dsResult.Tables("location").[Select](Convert.ToString("geometry_id = ") & geometry_id)(0)
                            dtCoordinates.Rows.Add(row("result_id"), row("formatted_address"), location("lat"), location("lng"))
                        Next
                        DataGridView1.DataSource = dtCoordinates
                        DataGridView1.Refresh()
                    Else
                        noResult = True
                    End If
                End Using
            End Using
            If noResult = False Then
                map.Overlays.Clear()
                overlayCount = 0
                For Each row As DataGridViewRow In DataGridView1.Rows()
                    If row.Index <> DataGridView1.Rows().Count - 1 Then 'if it's not the empty "input" row
                        placeMarker(CType(row.Cells(2).Value, Double), CType(row.Cells(3).Value, Double), "search")
                    End If
                Next
                If map.Overlays.Count > 1 Then
                    MessageBox.Show(map.Overlays.Count.ToString() + " results found." + vbNewLine + "Please select one of the markers as your location.")
                End If
                map.ZoomAndCenterMarkers(Nothing)
                If map.Overlays.Count < 2 Then
                    map.Zoom += 4
                End If
                Cursor.Current = Cursors.Default
            Else
                MessageBox.Show("Google could not find the address you are looking for." + vbNewLine + "Please recheck your location and try again.", "Location not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf incorrectAddress <> "" Then
            MessageBox.Show("You must enter a " + incorrectAddress + ".")
        Else
            MessageBox.Show("There is no server access to Google currently so your address cannot currently be displayed on the map.", "No server access", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub map_ZoomChange() Handles map.OnMapZoomChanged
        If map.Zoom = map.MaxZoom Then
            MessageBox.Show("You have reached maximum zoom.")
        ElseIf map.Zoom = map.MinZoom Then
            MessageBox.Show("You have reached minimum zoom.")
        End If
    End Sub
    Private Sub pbPlus_Click(sender As Object, e As EventArgs) Handles pbPlus.Click
        map.Zoom += 1
    End Sub
    Private Sub pbMinus_Click(sender As Object, e As EventArgs) Handles pbMinus.Click
        map.Zoom -= 1
    End Sub
#End Region
#Region "Event Operations"
    Private Sub cmbEvent_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbEvent.SelectedValueChanged
        If times.Count > 0 And sender.Tag <> "firstOpen" And Me.Tag.contains("view") = False Then
            For Each dtp As DateTimePicker In gbEvents.Controls.OfType(Of DateTimePicker)()
                Dim hasMatch As Boolean = False
                Dim eventTime As String = previousDropSelection & " " & dtp.Tag & " " & dtp.Text 'string in the form: event age time
                For Each ageGroup In times
                    Dim substring() = ageGroup.Split(" ")
                    substring(2) = substring(2) & " " & substring(3) 'adds the PM to the time element
                    If substring(0) = previousDropSelection And substring(1) = dtp.Tag Then 'checks if event and age match
                        'check if not match FOR ALL AGEGROUP
                        If substring(2) = dtp.Text Then 'checks if time is the same
                            hasMatch = True             'if they are the same, then the entry is already saved
                            Exit For
                        End If
                    End If
                Next
                If hasMatch = False Then 'an entry for a certain agegroup has not been saved
                    Dim message As String = dtp.Text + " not saved for " + dtp.Tag + " " + previousDropSelection
                    timesNotAdded.Add(message)
                End If
                'If createEvent.times.Contains(eventTime) = False Then
            Next
            If timesNotAdded.Count > 0 Then
                confirmAddition.Tag = "times"
                confirmAddition.ShowDialog()
            Else
                previousDropSelection = cmbEvent.SelectedItem
            End If
        Else
            previousDropSelection = cmbEvent.SelectedItem
        End If
        For Each dtp As DateTimePicker In gbEvents.Controls.OfType(Of DateTimePicker)()
            dtp.Text = "12:00:00 AM" 'sets all times to 12:00:00 AM, since the ones that have entries will be updated below
        Next
        For Each ageGroup In times 'setting all event times to the relevant saved times
            Dim substring() = ageGroup.Split(" ")
            If substring(0) = cmbEvent.SelectedItem Then
                substring(2) = substring(2) & " " & substring(3)
                For Each dtp As DateTimePicker In gbEvents.Controls.OfType(Of DateTimePicker)()
                    If substring(1) = dtp.Tag Then
                        dtp.Text = substring(2)
                        Exit For
                    End If
                Next
            End If
        Next
        If Me.Tag.contains("view") Then
            For Each dtp In gbEvents.Controls.OfType(Of DateTimePicker)()
                dtp.Enabled = False
            Next
            chbNA.Enabled = False
            btnSaveTimes.Enabled = False
        End If
    End Sub
    Private Sub btnSaveTimes_Click(sender As Object, e As EventArgs) Handles btnSaveTimes.Click
        Dim changes As Integer = 0, added As Integer = 0
        For Each dtp As DateTimePicker In gbEvents.Controls.OfType(Of DateTimePicker)()
            Dim hasEntry As Boolean = False
            Dim eventTime As String = cmbEvent.SelectedItem & " " & dtp.Tag & " " & dtp.Text
            If times.Count > 0 Then
                For ageGroup As Integer = 0 To times.Count - 1
                    Dim substring() = times(ageGroup).Split(" ")
                    substring(2) = substring(2) & " " & substring(3)
                    If substring(0) = cmbEvent.SelectedItem And substring(1) = dtp.Tag Then
                        hasEntry = True
                        If substring(2) <> dtp.Text Then
                            times(ageGroup) = eventTime
                            changes += 1
                            Exit For
                        End If
                    End If
                Next
                If hasEntry = False Then
                    times.Add(eventTime)
                    added += 1
                End If
            Else
                times.Add(eventTime)
                added += 1
            End If
        Next
        If changes = 0 And added = 0 Then
            MessageBox.Show("No changes to the times were made.", "No changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf changes = 1 And added = 0 Then
            MessageBox.Show(added.ToString() + " time was added for " + cmbEvent.SelectedItem + " and " + changes.ToString() + " times were updated.", "Times changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf changes = 0 And added = 1 Then
            MessageBox.Show(added.ToString() + " times were added for " + cmbEvent.SelectedItem + " and " + changes.ToString() + " time was updated.", "Times changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(added.ToString() + " times were added for " + cmbEvent.SelectedItem + " and " + changes.ToString() + " times were updated.", "Times changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region
#Region "Athlete Operations"
    Private Sub chbAllAthletes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbAllAthletes.Click
        If chbAllAthletes.Checked = True Then
            For Each panel In flpAthletes.Controls.OfType(Of Panel)()
                For Each chb In panel.Controls.OfType(Of CheckBox)()
                    If chb.Name = "chbAthlete" Then
                        chb.Checked = True
                        Exit For
                    End If
                Next
            Next
        Else
            For Each panel In flpAthletes.Controls.OfType(Of Panel)()
                For Each chb In panel.Controls.OfType(Of CheckBox)()
                    If chb.Name = "chbAthlete" Then
                        chb.Checked = False
                        Exit For
                    End If
                Next
            Next
        End If
    End Sub
    Private Sub chbAllNotes_Click(sender As Object, e As EventArgs) Handles chbAllNotes.Click
        If chbAllNotes.Checked = True Then
            chbAllAthletes.Checked = True
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
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim added As Integer = 0, removedPeople As Integer = 0, notesAdded As Integer = 0, notesRemoved As Integer = 0
        For Each panel In flpAthletes.Controls.OfType(Of Panel)()
            For Each label In panel.Controls.OfType(Of Label)()
                If label.Name = "lblId" Then
                    If attendees.Contains(LTrim(label.Text.Split(":")(1))) = False Then
                        For Each chb In panel.Controls.OfType(Of CheckBox)()
                            If chb.Name = "chbAthlete" Then
                                If chb.Checked = True Then
                                    attendees.Add(LTrim(label.Text.Split(":")(1)))
                                    added += 1
                                End If
                                Exit For
                            End If
                        Next
                    Else
                        For Each chb In panel.Controls.OfType(Of CheckBox)()
                            If chb.Name = "chbAthlete" Then
                                If chb.Checked = False Then
                                    attendees.Remove(LTrim(label.Text.Split(":")(1)))
                                    removedPeople += 1
                                End If
                                Exit For
                            End If
                        Next
                    End If
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
            Next
        Next
        If added = 0 And removedPeople = 0 And notesAdded = 0 And notesRemoved = 0 Then
            MessageBox.Show("No changes were made to the attendees.", "No changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added = 1 And removedPeople <> 1 And notesAdded <> 1 And notesRemoved <> 1 Then
            MessageBox.Show(added.ToString() & " athlete was added to the attendees and " & removedPeople.ToString() & " were removed." + vbNewLine + notesAdded.ToString() & " notes were added and " & notesRemoved.ToString() & " were removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added <> 1 And removedPeople = 1 And notesAdded <> 1 And notesRemoved <> 1 Then
            MessageBox.Show(added.ToString() & " athletes were added to the attendees and " & removedPeople.ToString() & " was removed." + vbNewLine + notesAdded.ToString() & " notes were added and " & notesRemoved.ToString() & " were removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added <> 1 And removedPeople <> 1 And notesAdded = 1 And notesRemoved <> 1 Then
            MessageBox.Show(added.ToString() & " athletes were added to the attendees and " & removedPeople.ToString() & " were removed." + vbNewLine + notesAdded.ToString() & " note was added and " & notesRemoved.ToString() & " were removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added <> 1 And removedPeople <> 1 And notesAdded <> 1 And notesRemoved = 1 Then
            MessageBox.Show(added.ToString() & " athletes were added to the attendees and " & removedPeople.ToString() & " were removed." + vbNewLine + notesAdded.ToString() & " notes were added and " & notesRemoved.ToString() & " was removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added = 1 And removedPeople = 1 And notesAdded <> 1 And notesRemoved <> 1 Then
            MessageBox.Show(added.ToString() & " athlete was added to the attendees and " & removedPeople.ToString() & " was removed." + vbNewLine + notesAdded.ToString() & " notes were added and " & notesRemoved.ToString() & " were removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added = 1 And removedPeople <> 1 And notesAdded = 1 And notesRemoved <> 1 Then
            MessageBox.Show(added.ToString() & " athlete was added to the attendees and " & removedPeople.ToString() & " were removed." + vbNewLine + notesAdded.ToString() & " note was added and " & notesRemoved.ToString() & " were removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added = 1 And removedPeople <> 1 And notesAdded <> 1 And notesRemoved = 1 Then
            MessageBox.Show(added.ToString() & " athlete was added to the attendees and " & removedPeople.ToString() & " were removed." + vbNewLine + notesAdded.ToString() & " notes were added and " & notesRemoved.ToString() & " was removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added <> 1 And removedPeople = 1 And notesAdded = 1 And notesRemoved <> 1 Then
            MessageBox.Show(added.ToString() & " athletes were added to the attendees and " & removedPeople.ToString() & " was removed." + vbNewLine + notesAdded.ToString() & " note was added and " & notesRemoved.ToString() & " were removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added <> 1 And removedPeople = 1 And notesAdded <> 1 And notesRemoved = 1 Then
            MessageBox.Show(added.ToString() & " athletes were added to the attendees and " & removedPeople.ToString() & " was removed." + vbNewLine + notesAdded.ToString() & " notes were added and " & notesRemoved.ToString() & " was removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added <> 1 And removedPeople <> 1 And notesAdded = 1 And notesRemoved = 1 Then
            MessageBox.Show(added.ToString() & " athletes were added to the attendees and " & removedPeople.ToString() & " were removed." + vbNewLine + notesAdded.ToString() & " note was added and " & notesRemoved.ToString() & " was removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added = 1 And removedPeople = 1 And notesAdded = 1 And notesRemoved <> 1 Then
            MessageBox.Show(added.ToString() & " athlete was added to the attendees and " & removedPeople.ToString() & " was removed." + vbNewLine + notesAdded.ToString() & " note was added and " & notesRemoved.ToString() & " were removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added <> 1 And removedPeople = 1 And notesAdded = 1 And notesRemoved = 1 Then
            MessageBox.Show(added.ToString() & " athletes were added to the attendees and " & removedPeople.ToString() & " was removed." + vbNewLine + notesAdded.ToString() & " note was added and " & notesRemoved.ToString() & " was removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf added = 1 And removedPeople = 1 And notesAdded = 1 And notesRemoved = 1 Then
            MessageBox.Show(added.ToString() & " athlete was added to the attendees and " & removedPeople.ToString() & " was removed." + vbNewLine + notesAdded.ToString() & " note was added and " & notesRemoved.ToString() & " was removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(added.ToString() & " athletes were added to the attendees and " & removedPeople.ToString() & " were removed." + vbNewLine + notesAdded.ToString() & " notes were added and " & notesRemoved.ToString() & " were removed.", "Attendees changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Shared Function getName(ByVal idNum As Integer)
        Dim fullName As String = ""
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT FirstName, LastName FROM athleteDb WHERE ID = @idNumber", conn) '*takes the column with correct rows
                cmd.Parameters.Add(New OleDbParameter("@idNumber", idNum))
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            fullName += dr("FirstName") + " " + dr("LastName")
                        Loop
                    End If
                End Using
            End Using
            conn.Close()
        End Using
        Return fullName
    End Function
    Public Shared Function getIdByName(ByVal name As String)
        Dim ID As String = ""
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID FROM athleteDb WHERE FirstName = @fname AND LastName = @lname", conn) '*takes the column with correct rows
                cmd.Parameters.Add(New OleDbParameter("@fName", name.Split(" ")(0)))
                If name.Split(" ").Count > 2 Then
                    Dim lname As String = ""
                    For i As Integer = 1 To name.Split(" ").Count - 1 'to skip the fname
                        If i = name.Split(" ").Count - 1 Then
                            lname += name.Split(" ")(i)
                        Else
                            lname += name.Split(" ")(i) + " "
                        End If
                    Next
                    cmd.Parameters.Add(New OleDbParameter("@lName", lname))
                Else
                    cmd.Parameters.Add(New OleDbParameter("@lName", name.Split(" ")(1)))
                End If
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            ID = dr("ID")
                        Loop
                    End If
                End Using
            End Using
            conn.Close()
        End Using
        Return ID
    End Function
    Public Shared Function getWholeAgeGroup(ByVal ageGroup As String)
        Dim ageAthletes As New List(Of String)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT * FROM athleteDb WHERE AgeGroup = @age", conn) '*takes the column with correct rows
                cmd.Parameters.Add(New OleDbParameter("@age", ageGroup))
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim newPerson As String = dr("FirstName") & " " & dr("LastName") & ";" & dr("ID") & ";" & dr("RollClass") & ";" & "12.5 100m, 25.2 200m" & ";" & "12.5 100m, 24.8 200m" & ";" & "5"
                            ageAthletes.Add(newPerson)
                        Loop
                    End If
                End Using
            End Using
            conn.Close()
        End Using
        Return ageAthletes.ToArray()
    End Function
    Public Shared Sub tickAthletes(ByVal idNum, ByVal last)
        For Each panel In createEvent.flpAthletes.Controls.OfType(Of Panel)()
            For Each label In panel.Controls.OfType(Of Label)()
                If label.Name = "lblId" Then
                    If label.Text.Contains(idNum) Then
                        For Each chb In panel.Controls.OfType(Of CheckBox)()
                            If chb.Name = "chbAthlete" Then
                                chb.Checked = True
                                Exit For
                            End If
                        Next
                    End If
                    Exit For
                End If
            Next
            If last = True Then
                checkShownNotAdded()
                checkAllChecked()
            End If
        Next
    End Sub
    Public Shared Sub tickNotes(ByVal idNum, ByVal last)
        For Each panel In createEvent.flpAthletes.Controls.OfType(Of Panel)()
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
                checkShownNotAdded()
                checkAllChecked()
            End If
        Next
    End Sub
    Public Shared Sub checkShownNotAdded()
        If shownNotAdded = True Then
            If confirmAddition.Tag = "people" Then
                peopleNotAdded.Clear()
            Else
                previousDropSelection = createEvent.cmbEvent.SelectedItem
                timesNotAdded.Clear()
            End If
        End If
    End Sub
    Public Shared Sub checkAllChecked()
        Dim checkedAth As Integer = 0, checkedNote As Integer = 0
        For Each panel In createEvent.flpAthletes.Controls.OfType(Of Panel)()
            For Each chb In panel.Controls.OfType(Of CheckBox)()
                If chb.Name = "chbAthlete" Then
                    If chb.Checked = True Then
                        checkedAth += 1
                    End If
                Else
                    If chb.Checked = True Then
                        checkedNote += 1
                    End If
                End If
            Next
        Next
        If checkedAth <> createEvent.flpAthletes.Controls.OfType(Of Panel)().Count Then
            createEvent.chbAllAthletes.Checked = False
        Else
            createEvent.chbAllAthletes.Checked = True
        End If
        If checkedNote <> createEvent.flpAthletes.Controls.OfType(Of Panel)().Count Then
            createEvent.chbAllNotes.Checked = False
        Else
            createEvent.chbAllNotes.Checked = True
        End If
    End Sub
    Private Sub cmbGroup_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGroup.SelectedValueChanged
        Cursor.Current = Cursors.AppStarting
        If sender.tag <> "template" And Me.Tag.contains("view") = False Then
            For Each panel In flpAthletes.Controls.OfType(Of Panel)()
                For Each label In panel.Controls.OfType(Of Label)()
                    If label.Name = "lblId" Then
                        If attendees.Contains(LTrim(label.Text.Split(":")(1))) = False Then
                            For Each chb In panel.Controls.OfType(Of CheckBox)()
                                If chb.Name = "chbAthlete" Then
                                    If chb.Checked = True Then
                                        Dim message As String = getName(LTrim(label.Text.Split(":")(1))) + " currently not saved as attending"
                                        peopleNotAdded.Add(message)
                                    End If
                                    Exit For
                                End If
                            Next
                        Else
                            For Each chb In panel.Controls.OfType(Of CheckBox)()
                                If chb.Name = "chbAthlete" Then
                                    If chb.Checked = False Then
                                        Dim message As String = getName(LTrim(label.Text.Split(":")(1))) + " currently incorrectly saved as attending"
                                        peopleNotAdded.Add(message)
                                    End If
                                    Exit For
                                End If
                            Next
                        End If
                        If notes.Contains(LTrim(label.Text.Split(":")(1))) = False Then
                            For Each chb In panel.Controls.OfType(Of CheckBox)()
                                If chb.Name = "chbNote" Then
                                    If chb.Checked = True Then
                                        Dim message As String = getName(LTrim(label.Text.Split(":")(1))) + " currently not saved as needing a note"
                                        peopleNotAdded.Add(message)
                                    End If
                                    Exit For
                                End If
                            Next
                        Else
                            For Each chb In panel.Controls.OfType(Of CheckBox)()
                                If chb.Name = "chbNote" Then
                                    If chb.Checked = False Then
                                        Dim message As String = getName(LTrim(label.Text.Split(":")(1))) + " currently incorrectly saved as needing a note"
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
        ElseIf sender.tag = "template" Then
            sender.tag = ""
        End If
        If peopleNotAdded.Count > 0 Then
            shownNotAdded = False
            confirmAddition.Tag = "people"
            confirmAddition.ShowDialog()
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
        If Me.Tag.contains("view") Then
            For Each pnl In flpAthletes.Controls.OfType(Of Panel)()
                pnl.Enabled = False
            Next
        End If
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub createAthletePanel(info As String)
        'info is in the form: name; id; rollclass; averages; recents; unexplained
        Dim pnl As New Panel
        With pnl
            .BackColor = Color.Gray
            .Size = New Size(410, 56)
            .Cursor = Cursors.Hand
        End With
        ttp.SetToolTip(pnl, "Click anywhere on the panel to change whether you want the athlete to participate in the event")
        flpAthletes.Controls.Add(pnl)
        AddHandler pnl.Click, AddressOf athletePanel_Click
        AddHandler pnl.Click, AddressOf clickHandler
        Dim chbAthelte As New CheckBox
        With chbAthelte
            .Name = "chbAthlete"
            .Font = New Font("Microsoft Sans Serif", 8)
            .Text = "Attending"
            .Location = New Point(332, 15)
        End With
        pnl.Controls.Add(chbAthelte)
        chbAthelte.BringToFront()
        AddHandler chbAthelte.Click, AddressOf chb_Click
        AddHandler chbAthelte.Click, AddressOf clickHandler
        Dim chbNote As New CheckBox
        With chbNote
            .Name = "chbNote"
            .Font = New Font("Microsoft Sans Serif", 8)
            .Text = "Needs Note"
            .Location = New Point(332, 36)
        End With
        pnl.Controls.Add(chbNote)
        chbNote.BringToFront()
        AddHandler chbNote.Click, AddressOf chb_Click
        AddHandler chbNote.Click, AddressOf clickHandler
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
        AddHandler pb.Click, AddressOf clickHandler
        pb.Location = New Point(0, 0)
        Dim lblName As New Label
        With lblName
            .Font = New Font("Microsoft Sans Serif", 8)
            .Text = "Name: " & info.Split(";")(0)
            .Name = "lblName"
            .AutoSize = True
            .Cursor = Cursors.Hand
        End With
        pnl.Controls.Add(lblName)
        AddHandler lblName.Click, AddressOf athletePanel_Click
        AddHandler lblName.Click, AddressOf clickHandler
        lblName.Location = New Point(81, 0)
        Dim lblId As New Label
        With lblId
            .Font = New Font("Microsoft Sans Serif", 8)
            .Text = "ID: " & info.Split(";")(1)
            .Name = "lblId"
            .AutoSize = True
            .Cursor = Cursors.Hand
        End With
        AddHandler lblId.Click, AddressOf athletePanel_Click
        AddHandler lblId.Click, AddressOf clickHandler
        pnl.Controls.Add(lblId)
        lblId.Location = New Point(332, 0)
        'Dim lblRollClass As New Label
        'With lblRollClass
        '    .Font = New Font("Microsoft Sans Serif", 8)
        '    .Text = "Class: " & info.Split(";")(2)
        '    .Name = "lblRollClass"
        '    .AutoSize = True
        '    .Cursor = Cursors.Hand
        'End With
        'pnl.Controls.Add(lblRollClass)
        'AddHandler lblRollClass.Click, AddressOf athletePanel_Click
        'lblRollClass.Location = New Point(291, 37)
        Dim lblAverages As New Label
        With lblAverages
            .Font = New Font("Microsoft Sans Serif", 8)
            .Text = "Averages: " & info.Split(";")(3)
            .Name = "lblAverages"
            .AutoSize = True
            .Cursor = Cursors.Hand
        End With
        pnl.Controls.Add(lblAverages)
        AddHandler lblAverages.Click, AddressOf athletePanel_Click
        AddHandler lblAverages.Click, AddressOf clickHandler
        lblAverages.Location = New Point(81, 17)
        Dim lblRecents As New Label
        With lblRecents
            .Font = New Font("Microsoft Sans Serif", 8)
            .Text = "Recents: " & info.Split(";")(4)
            .Name = "lblRecents"
            .AutoSize = True
            .Cursor = Cursors.Hand
        End With
        pnl.Controls.Add(lblRecents)
        AddHandler lblRecents.Click, AddressOf athletePanel_Click
        AddHandler lblRecents.Click, AddressOf clickHandler
        lblRecents.Location = New Point(81, 36)
        'Dim lblUnexplained As New Label
        'With lblUnexplained
        '    .Font = New Font("Microsoft Sans Serif", 8)
        '    .Text = "Unexplained: " & info.Split(";")(5)
        '    .Name = "lblUnexplained"
        '    .AutoSize = True
        'End With
        'pnl.Controls.Add(lblUnexplained)
        'AddHandler lblUnexplained.Click, AddressOf athletePanel_Click
        'lblUnexplained.Location = New Point(272, 36)
    End Sub
    Private Sub chb_Click(sender As CheckBox, e As EventArgs)
        If sender.Name = "chbNote" And sender.Checked = True Then
            For Each chb In sender.Parent.Controls.OfType(Of CheckBox)
                If chb.Name = "chbAthlete" Then
                    chb.Checked = True
                End If
            Next
        End If
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
            If chb.Name = "chbAthlete" Then
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
#End Region
#Region "Sidebar"

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'access = 1 FOR TEST
        'If access = 2 Then
        lblAlertCount.Text = getNotifCount()
        If lblAlertCount.Text = "0" Then
            lblAlertCount.Text = ""
        End If
        sideadminBtn.Visible = True
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles scrollBtn.Click
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If out = False Then
            bigbtngroup.Left = bigbtngroup.Left + 20
            Sidebar.Left = Sidebar.Left + 20
            If Sidebar.Left = 0 Then
                out = True
                Timer1.Enabled = False
            End If
        ElseIf out = True Then
            Sidebar.Left = Sidebar.Left - 20
            bigbtngroup.Left = bigbtngroup.Left - 20
            If Sidebar.Left = -200 Then
                out = False
                Timer1.Enabled = False
            End If
        End If
    End Sub
    Private Sub sidebartime_Tick(sender As Object, e As EventArgs) Handles sidebartime.Tick
        'calendar drop
        If cDrop = True Then
            If cDown = True Then
                sideresultBtn.Top += 10
                sideAthletesBtn.Top += 10
                sideadminBtn.Top += 10
                resdrop.Top += 10
                sideResSub1.Top += 10
                sideResSub2.Top += 10
            End If
            If cDown = False Then
                sideresultBtn.Top -= 10
                sideAthletesBtn.Top -= 10
                sideadminBtn.Top -= 10
                resdrop.Top -= 10

                sideResSub1.Top -= 10
                sideResSub2.Top -= 10
            End If
            jun += 1
            If jun = 9 Then
                jun = 0
                cDrop = False
                sidebartime.Enabled = False
            End If
        End If
        ' results drop
        If rDrop = True Then
            If rDown = True Then
                sideAthletesBtn.Top += 10
                sideadminBtn.Top += 10
                sideResSub1.Top += 10
                sideResSub2.Top += 10
            End If
            If rDown = False Then
                sideAthletesBtn.Top -= 10
                sideadminBtn.Top -= 10
                sideResSub1.Top -= 10
                sideResSub2.Top -= 10
            End If
            jun += 1
            If jun = 6 Then
                jun = 0
                rDrop = False
                sidebartime.Enabled = False
            End If
        End If
    End Sub
    Private Sub calDrop_Click(sender As Object, e As EventArgs)
        If cDrop = False Then
            cDrop = True
            If cDown = False Then
                cDown = True
            Else
                If cDown = True Then
                    cDown = False
                End If
            End If
            sidebartime.Enabled = True
        End If
    End Sub
    Private Sub resdrop_Click(sender As Object, e As EventArgs) Handles resdrop.Click
        If rDrop = False Then
            rDrop = True
            If rDown = False Then
                rDown = True
            Else
                If rDown = True Then
                    rDown = False
                End If
            End If
            sidebartime.Enabled = True
        End If
    End Sub

    Private Sub calendarBtn_Click(sender As Object, e As EventArgs) Handles sidecalendarBtn.Click
        calendar.Show()
        Me.Close()
    End Sub
    Private Sub resultBtn_Click(sender As Object, e As EventArgs) Handles sideresultBtn.Click
        Results.Show()
        Me.Close()
    End Sub
#End Region
#Region " Move Form "

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles GroupBox2.MouseDown, lblTitle.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles GroupBox2.MouseMove, lblTitle.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles GroupBox2.MouseUp, lblTitle.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

#End Region
#Region "TopBar"
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles notifBtn.Click
        checkNotif.Show()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles exitBtn.Click
        If MessageBox.Show("Do you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            End
        End If
    End Sub

#End Region

    Private Sub helpBtn_Click(sender As Object, e As EventArgs) Handles helpBtn.Click
        helpIdentifier = "createEvent"
        helpForm.Show()
        helpForm.TopMost = True
    End Sub

    Private Sub sideMainBtn_Click(sender As Object, e As EventArgs) Handles sideMainBtn.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub sideAthletesBtn_Click(sender As Object, e As EventArgs) Handles sideAthletesBtn.Click
        selectAthlete.Show()
        Me.Close()
    End Sub

    Private Sub sideadminBtn_Click(sender As Object, e As EventArgs) Handles sideadminBtn.Click
        AddEdit_User.Show()
        Me.Close()
    End Sub
End Class