Imports System.Data.OleDb
Imports System.IO.FileStream
#Region "Imports"
Imports System.Threading
Imports Microsoft.Office.Interop
Imports GMap.NET
Imports GMap.NET.WindowsForms
#End Region
Public Class createEvent
#Region "Declarations"
    Public Shared attendees As New List(Of String) 'list of id's with which you look back at the database to find agegroup to display tick or not
    Public Shared times As New List(Of String) 'list of "event: time"
    'Attachments
    Dim filePaths As New List(Of String)
    Dim newAttachBoxLocation As Point = New Point(135, 377)
    Dim pbCount = 1
    Dim templateEvents As New List(Of String) From {"Enter the event name here 13/05/2016", "Test Record Layout 23/06/2016"}
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
#End Region
#Region "Form Operations"
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        eventTimes.Show()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
    Private Sub btnSaveEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveEvent.Click
        If filePaths.Count > 0 And attendees.Count > 0 AndAlso (times.Count > 0 Or chbNA.Checked = True) And map.Overlays.Count = 1 Then
            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                conn.Open()
                Using cmd As New OleDbCommand("INSERT INTO Events (EventName, EventDate, Type, StartTime, EndTime, Personnel, Events, Location, AttachNames, Comment) VALUES (@name, @date, @type, @start, @end, @personnel, @times, @location, @fileNames, @comment)", conn)
                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                    dtpDate.Format = DateTimePickerFormat.Short
                    cmd.Parameters.AddWithValue("@date", dtpDate.Text)
                    dtpDate.Format = DateTimePickerFormat.Long
                    If rdbTraining.Checked Then
                        cmd.Parameters.AddWithValue("@type", "Training")
                    Else
                        cmd.Parameters.AddWithValue("@type", "Meet")
                    End If
                    cmd.Parameters.AddWithValue("@start", dtpStart.Text)
                    cmd.Parameters.AddWithValue("@end", dtpEnd.Text)
                    Dim attendingAthletes As String = ""
                    For athlete As Integer = 0 To attendees.Count - 1
                        If athlete = 0 Then
                            attendingAthletes = attendees(athlete)
                        Else
                            attendingAthletes += ";" & attendees(athlete)
                        End If
                    Next
                    cmd.Parameters.AddWithValue("@personnel", attendingAthletes)
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
                    cmd.ExecuteNonQuery()
                End Using
                conn.Close()
            End Using
            For Each filePath In filePaths
                Using fs As New System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                    Dim myData(fs.Length) As Byte
                    fs.Read(myData, 0, fs.Length)
                    Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                        conn.Open()
                        Using cmd As New OleDbCommand("INSERT INTO Attachments (FileName, FileInfo) VALUES (@name, @attachment)", conn)
                            Dim splitPath = filePath.Split("\")
                            cmd.Parameters.AddWithValue("@name", splitPath(splitPath.Count - 1))
                            cmd.Parameters.Add("@attachments", OleDbType.VarBinary, fs.Length).Value = myData
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                End Using
            Next
            Me.Close()
        ElseIf attendees.Count = 0 Then
            MessageBox.Show("You must select athletes for the event.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf (times.Count = 0 AndAlso chbNA.Checked = False) Then
            MessageBox.Show("You must either set event times or tick N/A", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf map.Overlays.Count <> 1 Then
            If map.Overlays.Count < 1 Then
                MessageBox.Show("You must select a location.", "No location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Please select only one location.", "Multpiple locations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                conn.Open()
                Using cmd As New OleDbCommand("INSERT INTO Events (EventName, EventDate, Type, StartTime, EndTime, Personnel, Events, Location, AttachNames, Comment) VALUES (@name, @date, @type, @start, @end, @personnel, @times, @location, @fileNames, @comment)", conn)
                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                    dtpDate.Format = DateTimePickerFormat.Short
                    cmd.Parameters.AddWithValue("@date", dtpDate.Text)
                    dtpDate.Format = DateTimePickerFormat.Long
                    If rdbTraining.Checked Then
                        cmd.Parameters.AddWithValue("@type", "Training")
                    Else
                        cmd.Parameters.AddWithValue("@type", "Meet")
                    End If
                    cmd.Parameters.AddWithValue("@start", dtpStart.Text)
                    cmd.Parameters.AddWithValue("@end", dtpEnd.Text)
                    Dim attendingAthletes As String = ""
                    For athlete As Integer = 0 To attendees.Count - 1
                        If athlete = 0 Then
                            attendingAthletes = attendees(athlete)
                        Else
                            attendingAthletes += ";" & attendees(athlete)
                        End If
                    Next
                    cmd.Parameters.AddWithValue("@personnel", attendingAthletes)
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
                    cmd.ExecuteNonQuery()
                End Using
                conn.Close()
            End Using
            Me.Close()
        End If

        'retrieving and displaying images (change SQL query as needed)
        'Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
        '    conn.Open()
        '    Using cmd As New OleDbCommand("SELECT Attachments FROM Events WHERE ID = 3", conn) '*takes the column with correct rows
        '        'cmd.Parameters.Add(New OleDbParameter("@age", ageGroup))
        '        Using dr = cmd.ExecuteReader()
        '            If dr.HasRows Then
        '                Do While dr.Read()
        '                    Dim bImage As Byte() = CType(dr("Attachments"), Byte())
        '                    Using ms As New IO.MemoryStream(bImage)
        '                        picImage.Image = Image.FromStream(ms)
        '                        picImage.SizeMode = PictureBoxSizeMode.StretchImage
        '                    End Using
        '                Loop
        '            End If
        '        End Using
        '    End Using
        '    conn.Close()
        'End Using
    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        selectAthletes.Show()
    End Sub
    Private Sub chbNA_CheckedChanged(sender As Object, e As EventArgs) Handles chbNA.CheckedChanged
        If chbNA.CheckState = CheckState.Checked Then
            For Each control In gbEvents.Controls()
                If control IsNot chbNA Then
                    control.enabled = False
                End If
            Next
        Else
            For Each control In gbEvents.Controls()
                If control IsNot chbNA Then
                    control.enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click
        Dim ptLowerLeft = New Point(0, sender.Height)
        ptLowerLeft = sender.PointToScreen(ptLowerLeft)
        'cmsTemplate.Show(ptLowerLeft)
    End Sub
    Private Sub createEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim savedEvents As New Dictionary(Of Date, String)
        'Dim dates As New List(Of Date)
        'Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
        '    conn.Open()
        '    Using cmd As New OleDbCommand("SELECT EventName, EventDate FROM Events", conn) '*takes the column with correct rows
        '        Using dr = cmd.ExecuteReader()
        '            If dr.HasRows Then
        '                Do While dr.Read()
        '                    Dim savedEvent As String = dr("EventDate") & " " & dr("EventName")
        '                    savedEvents.Add(dr("EventDate"), dr("EventName"))
        '                    dates.Add(dr("EventDate"))
        '                Loop
        '            End If
        '        End Using
        '    End Using
        '    conn.Close()
        'End Using
        'dates.Sort()
        'Dim finalList As New List(Of String)
        'For Each entry In dates
        '    finalList.Add(entry.ToShortDateString() & " " & savedEvents(entry))
        'Next
        'cmbTemplate.Items.AddRange(finalList.ToArray())
        cmbTemplate.Items.AddRange(templateEvents.ToArray())
        pbAttach.Location = New Point((pnlAttach.Width / 2 - pbAttach.Width / 2), -1)
        'Maps
        map.MapProvider = MapProviders.GoogleMapProvider.Instance
        map.Manager.Mode = AccessMode.ServerAndCache
        map.SetPositionByKeywords("Sydney, Australia")
        map.DragButton = MouseButtons.Left
        map.ShowCenter = False
        pbPlus.Parent = map
        pbPlus.BackColor = Color.Transparent
        pbPlus.Location = New Point((map.Width - pbPlus.Width - 5), Int(map.Height / 2 - (pbPlus.Height / 2) - 5))
        pbMinus.Parent = map
        pbMinus.Location = New Point((map.Width - pbMinus.Width - 5), Int(map.Height / 2 + (pbMinus.Height / 2) + 5))
        pbMinus.BackColor = Color.Transparent
        mainThreadID = Thread.CurrentThread.ManagedThreadId
        'Events
        cmbEvent.SelectedIndex = 0
        previousDropSelection = cmbEvent.SelectedItem
        Dim tmpBox As New PictureBox
        tmpBox.Tag = "firstOpen"
        cmbEvent_SelectionChangeCommitted(tmpBox, Nothing)
    End Sub
    Private Sub chbNone_CheckedChanged(sender As Object, e As EventArgs) Handles chbNone.CheckedChanged
        If chbNone.Checked = False Then
            cmbTemplate.Enabled = True
        Else
            cmbTemplate.Enabled = False
        End If
    End Sub
    Private Sub rdbTraining_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTraining.CheckedChanged
        If rdbTraining.Checked = True Then
            rdbMeet.Checked = False
        Else
            rdbMeet.Checked = True
        End If
    End Sub
    Private Sub cmbTemplate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTemplate.SelectedIndexChanged
        newAttachBoxLocation = New Point(135 - 62 - 5, 377)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT * FROM Events WHERE EventDate = @date And EventName = @name", conn) '*takes the column with correct rows
                Dim eventSplit As String() = cmbTemplate.SelectedItem.Split(" ")
                cmd.Parameters.AddWithValue("@date", eventSplit(eventSplit.Length - 1))
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
                            attendees.AddRange(dr("Personnel").Split(";"))
                            times.AddRange(dr("Events").Split(";"))
                            Dim fileNames() As String = dr("AttachNames").Split(";")
                            If fileNames.Count > 0 Then
                                Dim tempPb As New PictureBox    'creates a temporary picturebox to be used as a sender
                                With tempPb
                                    .Width = pbAttach.Width
                                    .Height = pbAttach.Height
                                    .Tag = "add"
                                    .SizeMode = PictureBoxSizeMode.StretchImage
                                End With
                                For Each fileName In fileNames
                                    If fileName <> fileNames(0) Then    'checks if it's the first file
                                        If fileNames.Count = pbCount Then 'if the number of files matches the number of panels
                                            Dim currentNum As Integer = 2, numPanels As Integer = pbCount
                                            While currentNum <= fileNames.Count 'add the files
                                                For Each pnl In flpAttach.Controls.OfType(Of Panel)()
                                                    If pnl.Name = "pnl" & currentNum.ToString() Then
                                                        For Each control In pnl.Controls
                                                            If currentNum = fileNames.Count Then
                                                                If control.GetType() Is GetType(PictureBox) Then
                                                                    control.Tag = fileName
                                                                    If fileName.EndsWith("doc") Or fileName.EndsWith("docx") Then
                                                                        control.Image = My.Resources.word
                                                                    Else
                                                                        control.Image = My.Resources.excel
                                                                    End If
                                                                    control.Location = New Point(-1, -1)
                                                                End If
                                                                Dim lbl As New Label
                                                                lbl.Width = 500
                                                                lbl.Font = New Drawing.Font("Arial", 9)
                                                                lbl.Text = fileName
                                                                Me.Controls.Add(lbl)
                                                                lbl.Parent = pnl
                                                                lbl.Location = New Point(75, 0)
                                                                lbl.BackColor = Color.Transparent
                                                                lbl.BringToFront()
                                                            Else
                                                                If control.GetType() Is GetType(PictureBox) Then
                                                                    control.Tag = fileName
                                                                    If fileName.EndsWith("doc") Or fileName.EndsWith("docx") Then
                                                                        control.Image = My.Resources.word
                                                                    Else
                                                                        control.Image = My.Resources.excel
                                                                    End If
                                                                    control.Location = New Point(-1, -1)
                                                                ElseIf control.GetType() Is GetType(Label) Then
                                                                    control.text = fileName
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
                                                        For Each control In pnl.Controls
                                                            If control.GetType() Is GetType(PictureBox) Then
                                                                control.Tag = fileName
                                                                If fileName.EndsWith("doc") Or fileName.EndsWith("docx") Then
                                                                    control.Image = My.Resources.word
                                                                Else
                                                                    control.Image = My.Resources.excel
                                                                End If
                                                                control.Location = New Point(-1, -1)
                                                            ElseIf control.GetType() Is GetType(Label) Then
                                                                control.text = fileName
                                                            End If
                                                        Next
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
                                                        For Each control In pnl.Controls
                                                            If control.GetType() Is GetType(PictureBox) Then
                                                                control.Tag = fileName
                                                                If fileName.EndsWith("doc") Or fileName.EndsWith("docx") Then
                                                                    control.Image = My.Resources.word
                                                                Else
                                                                    control.Image = My.Resources.excel
                                                                End If
                                                                control.Location = New Point(-1, -1)
                                                            ElseIf control.GetType() Is GetType(Label) Then
                                                                control.text = fileName
                                                            End If
                                                        Next
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
                                                If fileName.EndsWith("doc") Or fileName.EndsWith("docx") Then
                                                    pb.Image = My.Resources.word
                                                Else
                                                    pb.Image = My.Resources.excel
                                                End If
                                                pb.Tag = fileName
                                                pb.Cursor = Cursors.Hand
                                                AddHandler pb.Click, AddressOf pbAttach_Click
                                                pnl.Controls.Add(pb)
                                                pb.Location = New Point(-1, -1)
                                                Dim lbl As New Label
                                                lbl.Width = 500
                                                lbl.Font = New Drawing.Font("Arial", 9)
                                                lbl.Text = fileName
                                                Me.Controls.Add(lbl)
                                                lbl.Parent = pnl
                                                lbl.Location = New Point(75, 0)
                                                lbl.BackColor = Color.Transparent
                                                lbl.BringToFront()
                                                If currentNum = fileNames.Count Then
                                                    createPictureBox(tempPb)
                                                End If
                                                currentNum += 1
                                            End While
                                        End If
                                    Else                                'sets the filename to the existing picturebox
                                        pbAttach.Tag = fileName
                                        If fileName.EndsWith("doc") Or fileName.EndsWith("docx") Then
                                            pbAttach.Image = My.Resources.word
                                        Else
                                            pbAttach.Image = My.Resources.excel
                                        End If
                                        pbAttach.Location = New Point(-1, -1)
                                        If pnlAttach.Controls.Count = 2 Then
                                            For Each pnl In flpAttach.Controls.OfType(Of Panel)()
                                                If pnl.Name = pnlAttach.Name Then
                                                    For Each lbl In pnl.Controls.OfType(Of Label)()
                                                        lbl.Text = fileName
                                                    Next
                                                    Exit For
                                                End If
                                            Next
                                        ElseIf pnlAttach.Controls.Count = 1 Then
                                            Dim lbl As New Label
                                            lbl.Width = 500
                                            lbl.Font = New Drawing.Font("Arial", 9)
                                            lbl.Text = fileName
                                            Me.Controls.Add(lbl)
                                            lbl.Parent = pbAttach.Parent
                                            lbl.Location = New Point(75, 0)
                                            lbl.BackColor = Color.Transparent
                                            lbl.BringToFront()
                                        End If
                                        If fileNames.Count = 1 Then
                                            createPictureBox(tempPb)
                                        End If
                                    End If
                                Next
                            End If
                            placeMarker(CType(dr("Location").split(";")(0), Double), CType(dr("Location").split(";")(1), Double), "click")
                            txtComment.Text = dr("Comment")
                        Loop
                    End If
                End Using
            End Using
            conn.Close()
        End Using
    End Sub
#End Region
#Region "Attachment Operations"
    Private Sub pbAttach_Click(sender As Object, e As EventArgs) Handles pbAttach.Click
        If sender.Tag = "add" Then
            ofdOpen.FileName = ""
            ofdOpen.Filter = "Word and Excel (*.docx, *.doc, *.xls *.xlsx)|*.docx; *.doc; *xls; *.xlsx"
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
                lbl.Font = New Drawing.Font("Arial", 9)
                lbl.Text = sender.Tag
                Me.Controls.Add(lbl)
                lbl.Parent = sender.Parent
                lbl.Location = New Point(75, 0)
                lbl.Width = 500
                lbl.BackColor = Color.Transparent
                lbl.BringToFront()
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
                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                    conn.Open()
                    Using cmd As New OleDbCommand("SELECT FileInfo FROM Attachments WHERE FileName = @fileName", conn)
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
                                        MessageBox.Show("You do Not have Word installed.")
                                    Else
                                        MessageBox.Show("You do Not have Excel installed.")
                                    End If
                                ElseIf sfdSave.FileName = "" Then
                                    MessageBox.Show("Please enter a valid file name.")
                                End If
                            Else
                                MessageBox.Show("Please upload the file first before trying to save.")
                            End If
                        End Using
                    End Using
                    conn.Close()
                End Using
            ElseIf saveOrOpen.result = "open" Then
                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
                    conn.Open()
                    Using cmd As New OleDbCommand("SELECT FileInfo FROM Attachments WHERE FileName = @fileName", conn)
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
                                If MessageBox.Show("The file has not been uploaded yet." + vbNewLine + "Would you like to open the file from your computer?", "File Not uploaded", MessageBoxButtons.OKCancel) = DialogResult.OK Then
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
                                                MessageBox.Show("You do Not have Word installed.")
                                            Else
                                                MessageBox.Show("You do Not have Excel installed.")
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
            MessageBox.Show("You already have the attachment open." + vbNewLine + "Please finish operations with the open attachment before trying to interact with this one.", "Attachment Open", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub deleteAttachment(ByVal sender As Object)
        Dim pnlToDelete As String = "pnl", numIndicator As Integer = 0
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
        'this "copy and delete" results in panels below the sender being one number to high
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
            If tooManySelected = False Or (Math.Round(sender.position.lat, 0) = -34 AndAlso Math.Round(sender.position.lng, 0) = 151) Then
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
        Dim places As List(Of Placemark) = Nothing
        Dim status = MapProviders.GoogleMapProvider.Instance.GetPlacemarks(New PointLatLng(-33, 150), places)
        If status = GeoCoderStatusCode.G_GEO_SUCCESS And places IsNot Nothing Then
            connectionPresent = True
        Else
            connectionPresent = False
        End If
    End Sub
    Private Sub placeMarker(lat As Double, lng As Double, type As String)
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
            If Thread.CurrentThread.ManagedThreadId = mainThreadID Then
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
            MessageBox.Show("There is no server access to Google currently." + vbNewLine + "Please input the location in the textboxes provided.")
            overlay.Markers.Clear()
            overlayCount = 0
        End If
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
                    If row.Index <> DataGridView1.Rows().Count - 1 Then
                        placeMarker(CType(row.Cells(2).Value, Double), CType(row.Cells(3).Value, Double), "search")
                    End If
                Next
                If map.Overlays.Count > 1 Then
                    MessageBox.Show(map.Overlays.Count.ToString() + " results found." + vbNewLine + "Please select one of the markers as your location.")
                End If
                map.ZoomAndCenterMarkers(Nothing)
                If map.Overlays.Count < 3 Then
                    map.Zoom += 4
                End If
                Cursor.Current = Cursors.Default
            Else
                MessageBox.Show("Google could not find the address you are looking for." + vbNewLine + "Please recheck your location and try again.")
            End If
        ElseIf incorrectAddress <> "" Then
            MessageBox.Show("You must enter a " + incorrectAddress + ".")
        Else
            MessageBox.Show("There is no server access to Google currently so your address cannot currently be displayed on the map.")
        End If
    End Sub
    Private Sub pbPlus_Click(sender As Object, e As EventArgs) Handles pbPlus.Click
        If map.Zoom = map.MaxZoom Then
            MessageBox.Show("You have reached maximum zoom.")
        Else
            map.Zoom += 1
        End If
    End Sub
    Private Sub pbMinus_Click(sender As Object, e As EventArgs) Handles pbMinus.Click
        If map.Zoom = map.MinZoom Then
            MessageBox.Show("You have reached minimum zoom.")
        Else
            map.Zoom -= 1
        End If
    End Sub
#End Region
#Region "Event Operations"
    Private Sub cmbEvent_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbEvent.SelectionChangeCommitted
        If createEvent.times.Count > 0 And sender.Tag <> "firstOpen" Then
            For Each dtp As DateTimePicker In gbEvents.Controls.OfType(Of DateTimePicker)()
                Dim hasMatch As Boolean = False
                Dim eventTime As String = previousDropSelection & " " & dtp.Tag & " " & dtp.Text 'string in the form: event age time
                For Each ageGroup In createEvent.times
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
        For Each ageGroup In createEvent.times 'setting all event times to the relevant saved times
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
    End Sub
    Private Sub btnSaveTimes_Click(sender As Object, e As EventArgs) Handles btnSaveTimes.Click
        For Each dtp As DateTimePicker In gbEvents.Controls.OfType(Of DateTimePicker)()
            Dim hasEntry As Boolean = False
            Dim eventTime As String = cmbEvent.SelectedItem & " " & dtp.Tag & " " & dtp.Text
            If createEvent.times.Count > 0 Then
                For ageGroup As Integer = 0 To createEvent.times.Count - 1
                    Dim substring() = createEvent.times(ageGroup).Split(" ")
                    substring(2) = substring(2) & " " & substring(3)
                    If substring(0) = cmbEvent.SelectedItem And substring(1) = dtp.Tag Then
                        hasEntry = True
                        If substring(2) <> dtp.Text Then
                            createEvent.times(ageGroup) = eventTime
                            Exit For
                        End If
                    End If
                Next
                If hasEntry = False Then
                    createEvent.times.Add(eventTime)
                End If
            Else
                createEvent.times.Add(eventTime)
            End If
        Next
    End Sub
#End Region
End Class