﻿Imports System.Data.OleDb
Public Class calendar
    Dim firstSelection As DateTime
    Dim selectionCount As Integer = 0
    Dim firstClickTime As Integer = 0
    Dim eventInfo As New Dictionary(Of Date, List(Of String))
    Dim showPos As Point
    Private Sub mnCalendar_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mnCalendar.DateSelected
        'If selectionCount = 0 Then
        '    firstSelection = mnCalendar.SelectionStart
        '    selectionCount += 1
        '    firstClickTime = Environment.TickCount
        'Else
        '    If firstSelection = mnCalendar.SelectionStart Then
        '        Dim timeBetweenClicks = Environment.TickCount - firstClickTime
        '        If timeBetweenClicks <= SystemInformation.DoubleClickTime Then
        '            Cursor.Current = Cursors.AppStarting
        '            createEvent.Show()
        '            Cursor.Current = Cursors.Default
        '        End If
        '    End If
        '    selectionCount = 0
        'End If
        cms.Items.Clear()
        If mnCalendar.BoldedDates.Contains(e.Start.ToShortDateString()) Then
            For Each dt In eventInfo
                If dt.Key.ToShortDateString() = e.Start.ToShortDateString() Then
                    For Each eventName In dt.Value
                        Dim newMnuItm As New ToolStripMenuItem
                        With newMnuItm
                            .Text = eventName
                            .Tag = e.Start.ToShortDateString()
                        End With
                        AddHandler newMnuItm.MouseEnter, AddressOf newMnuItem_MouseEnter
                        For i As Integer = 1 To 3
                            Dim subMnuItm As New ToolStripMenuItem
                            With subMnuItm
                                Select Case i
                                    Case 1
                                        .Text = "Edit"
                                        AddHandler subMnuItm.Click, AddressOf menuItemEdit_Click
                                    Case 2
                                        .Text = "Results"
                                        AddHandler subMnuItm.Click, AddressOf menuItemResults_Click
                                    Case 3
                                        .Text = "Delete"
                                        AddHandler subMnuItm.Click, AddressOf menuItemDelete_Click
                                End Select
                            End With
                            newMnuItm.DropDownItems.Add(subMnuItm)
                        Next
                        cms.Items.Add(newMnuItm)
                    Next
                    Exit For
                End If
            Next
            cms.Items.Add("Add", Nothing, AddressOf menuItemAdd_Click)
            'Dim ptLowerLeft = New Point(0, sender.Height)
            'ptLowerLeft = sender.PointToScreen(ptLowerLeft)
            'Dim menu As New ContextMenuStrip
            'menu.Show(ptLowerLeft)
        Else
            cms.Items.Add("Add", Nothing, AddressOf menuItemAdd_Click)
        End If
        showPos = Cursor.Position
        cms.Show(showPos)
    End Sub
    Private Sub newMnuItem_MouseEnter(sender As Object, e As EventArgs)
        Dim notesEntered = hasNote(sender.text, sender.tag)
        Dim resultsEntered = hasResult(sender.text, sender.tag)
        If notesEntered And resultsEntered Then
            '.BackColor = Color.Green
        ElseIf (notesEntered And resultsEntered = False) Or (notesEntered = False And resultsEntered) Then
            '  .ForeColor = Color.DarkOrange
            Using brder As New Pen(Color.Orange)
                Using myBrush As New System.Drawing.SolidBrush(Color.FromArgb(128, Color.Orange))
                    Using g As Graphics = Me.CreateGraphics()



                        Dim xloc = e '+ sender.width
                        Dim yloc = cms.Location.Y '+ sender.height + 1
                        g.FillRectangle(myBrush, New Rectangle(showPos.X, showPos.Y, sender.DropDownItems(1).Bounds.Width, sender.DropDownItems(1).Bounds.Height))
                        'g.DrawLine(brder, 10, 50, 200, 50)
                        ' myBrush.Color = Color.BlueViolet ' change brush color
                        ' g.FillEllipse(myBrush, 40, 90, 86, 30)
                    End Using
                End Using
            End Using
        End If
    End Sub
    Private Sub cms_MouseLeave(sender As Object, e As EventArgs) Handles cms.MouseLeave
        Me.Refresh()
    End Sub
    Public Sub calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mnCalendar.BoldedDates = New Date() {}
        eventInfo.Clear()
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT EventName, EventDate FROM Events", conn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            mnCalendar.AddBoldedDate(CType(dr("EventDate"), Date)) '"#29/7/16#"
                            If eventInfo.ContainsKey(CType(dr("EventDate").ToString(), Date)) Then
                                Dim newList As List(Of String) = eventInfo(dr("EventDate").ToString())
                                newList.Add(dr("EventName").ToString())
                                eventInfo(dr("EventDate").ToString()) = newList
                            Else
                                eventInfo.Add(dr("EventDate").ToString(), New List(Of String)(New String() {dr("EventName").ToString()}))
                            End If
                        Loop
                    End If
                End Using
            End Using
            conn.Close()
        End Using
        mnCalendar.UpdateBoldedDates()
    End Sub
    Private Function hasResult(eventName, eventDate)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT TOP 1 AthleteName FROM resultsDb WHERE MeetName = @name AND EventDate = @date", conn)
                cmd.Parameters.AddWithValue("@name", eventName)
                cmd.Parameters.AddWithValue("@date", eventDate)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows() Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
            conn.Close()
        End Using
    End Function
    Private Function hasNote(eventName, eventDate)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT TOP 1 * FROM Events WHERE EventName = @name AND EventDate = @date AND NotesGiven IS NOT NULL", conn)
                cmd.Parameters.AddWithValue("@name", eventName)
                cmd.Parameters.AddWithValue("@date", eventDate)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows() Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
            conn.Close()
        End Using
    End Function
    Private Sub menuItemAdd_Click()
        Cursor.Current = Cursors.AppStarting
        createEvent.Show()
        createEvent.Tag = "add"
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub menuItemEdit_Click(sender As Object, e As EventArgs)
        Cursor.Current = Cursors.AppStarting
        Dim cmbSender As New ComboBox
        With cmbSender
            .Items.Add(sender.OwnerItem.Text + " " + sender.OwnerItem.Tag)
            .SelectedItem = sender.OwnerItem.Text + " " + sender.OwnerItem.Tag
        End With
        createEvent.Show()
        createEvent.Tag = "edit" + " " + sender.OwnerItem.Text + " " + sender.OwnerItem.Tag
        createEvent.cmbTemplate_SelectedIndexChanged(cmbSender, Nothing)
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub menuItemResults_Click(sender As Object, e As EventArgs)
        Cursor.Current = Cursors.AppStarting
        eventResults.Tag = sender.OwnerItem.Text + " " + sender.OwnerItem.Tag
        eventResults.Show()
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub menuItemDelete_Click(sender As Object, e As EventArgs)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("DELETE FROM Events WHERE EventName = @name AND EventDate = @date", conn) '*takes the column with correct rows
                cmd.Parameters.AddWithValue("@name", sender.OwnerItem.Text)
                cmd.Parameters.AddWithValue("@date", sender.OwnerItem.Tag)
                cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
        If eventInfo(sender.OwnerItem.Tag).Count > 1 Then
            eventInfo(sender.OwnerItem.Tag).Remove(sender.OwnerItem.Text)
        Else
            eventInfo.Remove(sender.OwnerItem.Tag)
        End If
        If eventInfo.ContainsKey(sender.OwnerItem.Tag) = False Then
            Dim newList As List(Of Date) = mnCalendar.BoldedDates.ToList()
            newList.Remove(sender.OwnerItem.Tag)
            mnCalendar.BoldedDates = newList.ToArray()
            mnCalendar.UpdateBoldedDates()
        End If
    End Sub
End Class