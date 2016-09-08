Imports System.Data.OleDb
Public Class home
#Region "Dim Variables"
    Dim out As Boolean = False
    Dim rDrop As Boolean = False
    Dim rDown As Boolean = False
    Dim atDrop As Boolean = False
    Dim atDown As Boolean = False
    Dim adDrop As Boolean = False
    Dim adDown As Boolean = False 'all side bar counters for movement
    Dim jun As Integer = 0 'jun is a counter for side bar horizontal movement
    Dim pictimer As Integer = 0 'counter for pic looping
    Dim pic2 As Boolean = True 'pic visible status
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


    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrAlert.Start()
        If access = 1 Or access = 0 Then 'checking accesslevel of user, if not admin cannot access certain functions
            addEditUserBtn.Visible = False
            sideadminBtn.Visible = False
        End If
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Calendar.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT EventName, EventDate, Notes, NotesGiven FROM Events WHERE Notes IS NOT NULL AND DateValue(EventDate) > DateValue(@date)", conn)
                cmd.Parameters.AddWithValue("@date", Today.Date.ToString("dd/MM/yyyy", Globalization.CultureInfo.InvariantCulture))
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows() Then
                        Do While dr.Read()
                            Dim daysLeft = DateDiff(DateInterval.Day, Today.Date, CType(dr("EventDate"), Date))
                            Dim noteIds() As String
                            Dim needNames As New List(Of String) From {}
                            Dim givenNames As New List(Of String) From {}
                            If daysLeft = 1 Or daysLeft = 2 Or daysLeft = 3 Or daysLeft = 5 Or daysLeft = 10 Then
                                noteIds = dr("Notes").split(";")
                                For Each noteId In noteIds
                                    needNames.Add(createEvent.getName(noteId))
                                Next
                                If dr("NotesGiven").ToString() <> "" Then
                                    noteIds = dr("NotesGiven").split(";")
                                    For Each noteId In noteIds
                                        givenNames.Add(createEvent.getName(noteId))
                                    Next
                                End If
                                Dim peopleWhoHaventSubmitted = needNames.Except(givenNames)
                                newEdit("misNotes", "from:" + vbNewLine + String.Join(vbNewLine, peopleWhoHaventSubmitted) + vbNewLine + "for " + dr("EventName") + " in " + daysLeft.ToString() + " days.")
                            End If
                        Loop
                    End If
                End Using
            End Using
            conn.Close()
        End Using
    End Sub

#Region "Sidebar"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles scrollBtn.Click
        sidebartime2.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles sidebartime2.Tick
        If out = False Then
            bigbtngroup.Left = bigbtngroup.Left + 20
            Sidebar.Left = Sidebar.Left + 20
            If Sidebar.Left = 0 Then
                out = True
                sidebartime2.Enabled = False
            End If
        ElseIf out = True Then
            Sidebar.Left = Sidebar.Left - 20
            bigbtngroup.Left = bigbtngroup.Left - 20
            If Sidebar.Left = -200 Then
                out = False
                sidebartime2.Enabled = False
            End If
        End If
    End Sub
    Private Sub sidebartime_Tick(sender As Object, e As EventArgs) Handles sidebartime.Tick
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

#Region "Buttons"
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        If MessageBox.Show("Do you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub check_Notif(sender As Object, e As EventArgs) Handles notifBtn.Click
        checkNotif.Show()
    End Sub

    Private Sub ShowCalendar(sender As Object, e As EventArgs) Handles calendarBtn.Click
        Me.Hide()
        Cursor.Current = Cursors.AppStarting
        calendar.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub addEdit_Click(sender As Object, e As EventArgs) Handles addEditUserBtn.Click
        AddEdit_User.Show()
        Me.Close()
    End Sub

    Private Sub selectAtheltes_Click(sender As Object, e As EventArgs) Handles selectAthletesBtn.Click
        selectAthlete.Show()
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
#End Region

    Private Sub clocktime_Tick(sender As Object, e As EventArgs) Handles clocktime.Tick
        timeLbl.Text = TimeOfDay 'sets date and time labels
        dateLbl.Text = Date.Today
        If pictimer < 100 Then
            pictimer += 1
        End If
        If pictimer = 100 Then
            If pic2 = True Then
                gallerypic2.Visible = False
                pic2 = False
            Else
                gallerypic2.Visible = True
                pic2 = True
            End If
            pictimer = 0
        End If
    End Sub


    Private Sub helpBtn_Click(sender As Object, e As EventArgs) Handles helpBtn.Click
        helpForm.Show()
    End Sub

    Private Sub tmrAlert_Tick(sender As Object, e As EventArgs) Handles tmrAlert.Tick
        lblAlertCount1.Text = getNotifCount()
        If lblAlertCount1.Text = "0" Then
            lblAlertCount1.Text = ""
        End If
    End Sub
End Class
