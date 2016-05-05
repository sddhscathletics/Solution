Imports System.Data.OleDb
Imports System.IO.FileStream
Imports Microsoft.Office.Interop
Public Class createEvent
    Public Shared attendees As New List(Of String) 'list of id's with which you look back at the database to find agegroup to display tick or not
    Public Shared times As New List(Of String) 'list of "event: time"
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        eventTimes.Show()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        If filePaths.Count > 0 And attendees.Count > 0 AndAlso (times.Count > 0 Or chbNA.Checked = True) Then
            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Calendar.accdb")
                conn.Open()
                Using cmd As New OleDbCommand("INSERT INTO Events (EventName, EventDate, Type, StartTime, EndTime, Personnel, Events, AttachNames, Comment) VALUES (@name, @date, @type, @start, @end, @personnel, @times, @fileNames, @comment)", conn)
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
                    Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Calendar.accdb")
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
        ElseIf attendees.Count <= 0 Then
            MessageBox.Show("You must select athletes for the event.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf (times.Count <= 0 AndAlso chbNA.Checked = False) Then
            MessageBox.Show("You must either set event times or tick N/A", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Calendar.accdb")
                conn.Open()
                Using cmd As New OleDbCommand("INSERT INTO Events (EventName, EventDate, Type, StartTime, EndTime, Personnel, Events, Comment) VALUES (@name, @date, @type, @start, @end, @personnel, @times, @comment)", conn)
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
                    cmd.Parameters.AddWithValue("@comment", txtComment.Text)
                    cmd.ExecuteNonQuery()
                End Using
                conn.Close()
            End Using
        End If

        'retrieving and displaying images (change SQL query as needed)
        'Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Calendar.accdb")
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
            btnBrowse.Enabled = False
        Else
            btnBrowse.Enabled = True
        End If
    End Sub
    Dim filePaths As New List(Of String)
    Dim newAttachBoxLocation As Point = New Point(135, 377)
    Private Sub pbAttach_Click(sender As Object, e As EventArgs) Handles pbAttach.Click
        If sender.Tag = "add" Then
            ofdOpen.FileName = ""
            ofdOpen.ShowDialog()
            If ofdOpen.FileName <> "" Then
                Dim text As String = InputBox("What name would you like for this file?")
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
                lbl.Width = sender.width
                lbl.Font = New Drawing.Font("Arial", 9)
                'Dim backSplit = ofdOpen.FileName.Split("\")
                'lbl.Text = backSplit(backSplit.Count - 1).Split(".")(0)
                lbl.Text = text
                Me.Controls.Add(lbl)
                lbl.Parent = sender
                lbl.BackColor = Color.Transparent
                lbl.BringToFront()
                createPictureBox(sender)
            End If
        ElseIf sender.Tag.Contains("docx") Then
            checkFileBeforeOpen(sender.Tag)
        End If
    End Sub
    Private Sub createPictureBox(sender As Object)
        If sender.Tag = "add" Then
            Dim pb As New PictureBox
            pb.Image = My.Resources.transparent_plus
            pb.Tag = "add"
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.Width = sender.width
            pb.Height = sender.height
            If sender.location.x + 2 * sender.width + 5 > Me.Width - 15 Then
                For Each control In Me.Controls
                    If control.Location.Y > sender.location.Y + 20 Then
                        control.Location = New Point(control.location.x, control.location.y + pbAttach.Height + 5)
                    End If
                Next
                For Each control In Me.Controls.OfType(Of PictureBox)()
                    If control.Location.X = pbAttach.Location.X And control.Location.Y = sender.location.Y Then
                        pb.Location = New Point(pbAttach.Location.X, control.Location.Y + pbAttach.Height + 5)
                    End If
                Next
                Me.Height += pbAttach.Height + 5
            Else
                pb.Location = New Point(sender.location.x + sender.width + 5, sender.location.y)
            End If
            newAttachBoxLocation = pb.Location
            pb.Cursor = Cursors.Hand
            AddHandler pb.Click, AddressOf pbAttach_Click
            Me.Controls.Add(pb)
        ElseIf sender.Tag.Contains(".docx") Then
            Dim pb As New PictureBox
            pb.Image = My.Resources.transparent_plus
            pb.Tag = "add"
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.Width = sender.width
            pb.Height = sender.height
            If sender.location.x + 2 * sender.width + 5 > Me.Width - 15 Then
                For Each control In Me.Controls
                    If control.Location.Y > sender.location.Y + 20 Then
                        control.Location = New Point(control.location.x, control.location.y + pbAttach.Height + 5)
                    End If
                Next
                For Each control In Me.Controls.OfType(Of PictureBox)()
                    If control.Location.X = pbAttach.Location.X And control.Location.Y = sender.location.Y Then
                        pb.Location = New Point(pbAttach.Location.X, control.Location.Y + pbAttach.Height + 5)
                    End If
                Next
                Me.Height += pbAttach.Height + 5
            Else
                pb.Location = New Point(sender.location.x + sender.width + 5, sender.location.y)
            End If
            newAttachBoxLocation = pb.Location
            pb.Cursor = Cursors.Hand
            AddHandler pb.Click, AddressOf pbAttach_Click
            Me.Controls.Add(pb)
        Else
            If sender.Tag.Contains(".xlsx") Then
                Dim pb As New PictureBox
                pb.Image = My.Resources.transparent_plus
                pb.Tag = "add"
                pb.SizeMode = PictureBoxSizeMode.StretchImage
                pb.Width = sender.width
                pb.Height = sender.height
                If sender.location.x + 2 * sender.width + 5 > Me.Width - 15 Then
                    For Each control In Me.Controls
                        If control.Location.Y > sender.location.Y + 20 Then
                            control.Location = New Point(control.location.x, control.location.y + pbAttach.Height + 5)
                        End If
                    Next
                    For Each control In Me.Controls.OfType(Of PictureBox)()
                        If control.Location.X = pbAttach.Location.X And control.Location.Y = sender.location.Y Then
                            pb.Location = New Point(pbAttach.Location.X, control.Location.Y + pbAttach.Height + 5)
                        End If
                    Next
                    Me.Height += pbAttach.Height + 5
                Else
                    pb.Location = New Point(sender.location.x + sender.width + 5, sender.location.y)
                End If
                newAttachBoxLocation = pb.Location
                pb.Cursor = Cursors.Hand
                AddHandler pb.Click, AddressOf pbAttach_Click
                Me.Controls.Add(pb)
            End If
        End If
    End Sub
    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click
        Dim ptLowerLeft = New Point(0, sender.Height)
        ptLowerLeft = sender.PointToScreen(ptLowerLeft)
        'cmsTemplate.Show(ptLowerLeft)
    End Sub
    Dim templateEvents As New List(Of String) From {"Enter the event name here 13/05/2016"}
    Private Sub createEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim savedEvents As New Dictionary(Of Date, String)
        'Dim dates As New List(Of Date)
        'Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Calendar.accdb")
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
    End Sub
    Private Sub chbNone_CheckedChanged(sender As Object, e As EventArgs) Handles chbNone.CheckedChanged
        If chbNone.Checked = False Then
            cmbTemplate.Enabled = True
        Else
            cmbTemplate.Enabled = False
        End If
    End Sub
    Private Sub cmbTemplate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTemplate.SelectedIndexChanged
        newAttachBoxLocation = New Point(135 - 62 - 5, 377)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Calendar.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT * FROM Events WHERE EventDate = @date AND EventName = @name", conn) '*takes the column with correct rows
                cmd.Parameters.AddWithValue("@date", cmbTemplate.SelectedItem.Split(" ")(0))
                Dim name As String = ""
                For Each part In cmbTemplate.SelectedItem.Split(" ")
                    If part <> cmbTemplate.SelectedItem.Split(" ")(0) Then
                        If part = cmbTemplate.SelectedItem.split(" ")(1) Then
                            name += part
                        Else
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
                                For Each fileName In fileNames
                                    If fileName <> fileNames(0) Then
                                        Dim tempPb As New PictureBox
                                        With tempPb
                                            .Width = pbAttach.Width
                                            .Height = pbAttach.Height
                                            .Location = newAttachBoxLocation
                                            .Tag = fileName
                                        End With
                                        createPictureBox(tempPb)
                                    Else
                                        pbAttach.Tag = fileName
                                        pbAttach.Image = My.Resources.word
                                    End If
                                Next
                            End If
                            txtComment.Text = dr("Comment")
                        Loop
                    End If
                End Using
            End Using
            conn.Close()
        End Using
    End Sub
    Sub checkFileBeforeOpen(ByVal fileName As String)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Calendar.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT FileInfo FROM Attachments WHERE FileName = @fileName", conn)
                cmd.Parameters.AddWithValue("@fileName", fileName)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            Dim fileInfo As Byte() = CType(dr("FileInfo"), Byte())
                            Using ms As New System.IO.MemoryStream(fileInfo)
                                'tempPath = System.IO.Path.GetTempFileName()
                                Dim officeType As Type
                                saveOrOpen.ShowDialog()
                                If saveOrOpen.result = "save" Then
                                    sfdSave.FileName = fileName
                                    If fileName.EndsWith("docx") Then
                                        officeType = Type.GetTypeFromProgID("Word.Application")
                                        sfdSave.Filter = "(*.docx)|*.docx"
                                    Else
                                        officeType = Type.GetTypeFromProgID("Excel.Application")
                                        sfdSave.Filter = "(*.xlsx)|*.xlsx"
                                    End If
                                    If sfdSave.ShowDialog() <> DialogResult.Cancel And sfdSave.FileName <> "" And officeType <> Nothing Then
                                        Cursor = Cursors.AppStarting
                                        Dim fs As New System.IO.FileStream(sfdSave.FileName, System.IO.FileMode.Create, System.IO.FileAccess.Write)
                                        fs.Write(fileInfo, 0, ms.Length)
                                        fs.Dispose()
                                        If fileName.EndsWith("docx") Then
                                            openWordFile(sfdSave.FileName)
                                        Else
                                            openExcelFile(sfdSave.FileName)
                                        End If
                                    ElseIf officeType = Nothing Then
                                        If fileName.EndsWith("docx") Then
                                            MessageBox.Show("You do not have Word installed.")
                                        Else
                                            MessageBox.Show("You do not have Excel installed.")
                                        End If
                                    ElseIf sfdSave.FileName = "" Then
                                        MessageBox.Show("Please enter a valid file name.")
                                    End If
                                ElseIf saveOrOpen.result = "open" Then
                                    Dim fileValid As Boolean = False
                                    While fileValid = False
                                        ofdOpen.FileName = ""
                                        If fileName.EndsWith("docx") Then
                                            officeType = Type.GetTypeFromProgID("Word.Application")
                                            ofdOpen.Filter = "(*.docx)|*.docx"
                                        Else
                                            officeType = Type.GetTypeFromProgID("Excel.Application")
                                            ofdOpen.Filter = "(*.xlsx)|*.xlsx"
                                        End If
                                        If ofdOpen.ShowDialog() <> DialogResult.Cancel And System.IO.Path.GetFileName(ofdOpen.FileName) = fileName And officeType <> Nothing Then
                                            If fileName.EndsWith("docx") Then
                                                openWordFile(ofdOpen.FileName)
                                            Else
                                                openExcelFile(ofdOpen.FileName)
                                            End If
                                            fileValid = True
                                        ElseIf officeType = Nothing Then
                                            If fileName.EndsWith("docx") Then
                                                MessageBox.Show("You do not have Word installed.")
                                            Else
                                                MessageBox.Show("You do not have Excel installed.")
                                            End If
                                            fileValid = True
                                        ElseIf System.IO.Path.GetFileName(ofdOpen.FileName) <> fileName Then
                                            If MessageBox.Show("You have not selected the attachment file." + vbNewLine + "Please select the file again.", "Wrong File Selected", MessageBoxButtons.RetryCancel) = DialogResult.Cancel Then
                                                fileValid = True
                                            Else
                                                fileValid = False
                                            End If
                                        End If
                                    End While
                                End If
                            End Using
                        Loop
                    Else
                        MessageBox.Show("Please upload the file first before opening.")
                    End If
                End Using
            End Using
            conn.Close()
        End Using
    End Sub
    Private Sub openWordFile(ByVal path As String)
        Try
            Cursor = Cursors.AppStarting
            'browseAttach.docBrowser.Navigate(path)
            'browseAttach.Show()
            app = New Word.Application
            app.Visible = True
            'app.DisplayAlerts = False
            'fix "being used by another user thingo
            app.Documents.Open(path)
            'doc.Protect(Word.WdProtectionType.wdAllowOnlyReading)

            'doc = app.Documents(1)

            Cursor = Cursors.Default
        Catch e As Exception
            If MessageBox.Show("The file was unable to be opened. Please make sure the file is not already open.", "Unable To Open File", MessageBoxButtons.RetryCancel) = DialogResult.Cancel Then
                word_Quit(doc, Nothing)
            Else
                openWordFile(path)
            End If
            'Dim p() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("WINWORD")
            'p.Last.Kill()
        End Try
    End Sub
    Public WithEvents app As Word.Application
    Dim doc As Word.Document
    Private Sub word_Quit(ByVal tempDoc As Word.Document, ByRef cancel As Boolean) Handles app.DocumentBeforeClose
        Try
            app.NormalTemplate.Saved = True
            'doc.Saved = True
            'doc.Close(SaveChanges:=False)
            'System.Runtime.InteropServices.Marshal.ReleaseComObject(doc)
            doc = Nothing
            'app.DisplayAlerts = False
            app.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app)
            app = Nothing
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
        End Try
    End Sub
    Private Sub rdbTraining_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTraining.CheckedChanged
        If rdbTraining.Checked = True Then
            rdbMeet.Checked = False
        Else
            rdbMeet.Checked = True
        End If
    End Sub
End Class