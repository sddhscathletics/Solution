
Public Class home

#Region "Dim Variables"
    Dim out As Boolean = False
    Dim cDrop As Boolean = False
    Dim rDrop As Boolean = False
    Dim cDown As Boolean = False
    Dim rDown As Boolean = False
    Dim atDrop As Boolean = False
    Dim atDown As Boolean = False
    Dim adDrop As Boolean = False
    Dim adDown As Boolean = False
    Dim jun As Integer = 0 'jun is a counter for side bar scrolling
    Dim pictimer As Integer = 0
    Dim pic2 As Boolean = True
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

#Region "Sidebar"

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAlertCount.Text = getNotifCount()
        If lblAlertCount.Text = "0" Then
            lblAlertCount.Text = ""
        End If
        If access = 0 Or access = 1 Then
            sideadminBtn.Visible = False
            addEditUserBtn.Visible = False
        End If
    End Sub

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
        Me.Hide()
    End Sub
    Private Sub resultBtn_Click(sender As Object, e As EventArgs) Handles sideresultBtn.Click
        Results.Show()
        Me.Hide()
    End Sub
#End Region

#Region "Buttons"
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        If MessageBox.Show("Do you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles notifBtn.Click
        checkNotif.Show()
    End Sub

    Private Sub resultBtn_Click_1(sender As Object, e As EventArgs) Handles resultBtn.Click
        Results.Show()
    End Sub

    Private Sub ShowCalendar(sender As Object, e As EventArgs) Handles calendarBtn.Click
        Me.Hide()
        Cursor.Current = Cursors.AppStarting
        calendar.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles addEditUserBtn.Click
        AddEdit_User.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles selectAthletesBtn.Click
        selectAthlete.Show()
        Me.Hide()
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
        timeLbl.Text = TimeOfDay
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

End Class
