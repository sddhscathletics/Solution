Imports System.Data.OleDb
Public Class AddEdit_User
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
    Dim storedID As String
#End Region
#Region "Sidebar"

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'access = 1 FOR TEST
        'If access = 2 Then
        If access = 0 Or access = 1 Then
            sideAdminBtn.Visible = False
            sideteamBtn.Visible = False
        End If
        lblAlertCount.Text = getNotifCount()
        If lblAlertCount.Text = "0" Then
            lblAlertCount.Text = ""
        End If
        sideteamBtn.Visible = True
        'End If
    End Sub

    Private Sub scrollclick(sender As Object, e As EventArgs) Handles scrollBtn.Click
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
        ' results drop
        If rDrop = True Then
            If rDown = True Then
                sideAthletesBtn.Top += 10
                sideteamBtn.Top += 10
                sideResSub1.Top += 10
                sideResSub2.Top += 10
                sideAdminBtn.Top += 10
            End If
            If rDown = False Then
                sideAthletesBtn.Top -= 10
                sideteamBtn.Top -= 10
                sideResSub1.Top -= 10
                sideResSub2.Top -= 10
                sideAdminBtn.Top -= 10
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


    Private Sub deleteUser(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim person As String = DataGridView1.CurrentCell.Value.ToString
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("DELETE ID, Pass, AccessLevel FROM userDb WHERE ID = @username", conn)
                cmd.Parameters.Add(New OleDbParameter("@Username", idText.Text))
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Me.UserDbTableAdapter1.Fill(Me.AthleteDataSet.userDb)
        confirmBtn.Visible = False
        editBtn.Visible = True
        deleteBtn.Visible = False
        idText.ReadOnly = True
        passText.ReadOnly = True
        access1.Enabled = False
        access2.Enabled = False
        access3.Enabled = False
    End Sub


    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        If MessageBox.Show("Do you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub editBtnClick(sender As Object, e As EventArgs) Handles editBtn.Click
        editBtn.Visible = False
        confirmBtn.Visible = True
        deleteBtn.Visible = True
        idText.ReadOnly = False
        passText.ReadOnly = False
        access1.Enabled = True
        access2.Enabled = True
        access3.Enabled = True
        storedID = idText.Text
    End Sub

    Private Sub AddEdit_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AthleteDataSet.userDb' table. You can move, or remove it, as needed.
        Me.UserDbTableAdapter1.Fill(Me.AthleteDataSet.userDb)

    End Sub
    Private Sub edit() Handles confirmBtn.Click
        Dim person As String = DataGridView1.CurrentCell.Value.ToString
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("DELETE ID, Pass, AccessLevel FROM userDb WHERE ID = @username", conn)
                cmd.Parameters.Add(New OleDbParameter("@Username", storedID))
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("INSERT INTO userDb (ID, Pass, AccessLevel) VALUES (@id, @pass, @accesslvl)", conn)
                cmd.Parameters.Add(New OleDbParameter("@id", idText.Text))
                cmd.Parameters.Add(New OleDbParameter("@pass", passText.Text))
                If access1.Checked Then
                    cmd.Parameters.Add(New OleDbParameter("@accesslvl", access1.Text))
                End If
                If access2.Checked Then
                    cmd.Parameters.Add(New OleDbParameter("@accesslvl", access2.Text))
                End If
                If access3.Checked Then
                    cmd.Parameters.Add(New OleDbParameter("@accesslvl", access3.Text))
                End If
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Me.UserDbTableAdapter1.Fill(Me.AthleteDataSet.userDb)
        confirmBtn.Visible = False
        editBtn.Visible = True
        deleteBtn.Visible = False
        idText.ReadOnly = True
        passText.ReadOnly = True
        access1.Enabled = False
        access2.Enabled = False
        access3.Enabled = False
    End Sub
    Private Sub NewUser() Handles createBtn.Click
        makeuser.Show()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex > -1 Then
            idText.Text = sender.rows(e.RowIndex).cells(0).value
            passText.Text = sender.rows(e.RowIndex).cells(1).value
            If sender.rows(e.RowIndex).cells(2).value = 0 Then
                access1.Checked = True
            End If
            If sender.rows(e.RowIndex).cells(2).value = 1 Then
                access2.Checked = True
            End If
            If sender.rows(e.RowIndex).cells(2).value = 2 Then
                access3.Checked = True
            End If
        End If
        confirmBtn.Visible = False
        editBtn.Visible = True
        deleteBtn.Visible = False
        idText.ReadOnly = True
        passText.ReadOnly = True
        access1.Enabled = False
        access2.Enabled = False
        access3.Enabled = False

    End Sub


    Private Sub help(sender As Object, e As EventArgs) Handles helpBtn.Click
        helpIdentifier = "addEdit"
        helpForm.Show()
    End Sub

    Private Sub notifBtn_Click(sender As Object, e As EventArgs) Handles notifBtn.Click
        checkNotif.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub sideAthletesBtn_Click(sender As Object, e As EventArgs) Handles sideAthletesBtn.Click
        selectAthlete.Show()
        Me.Close()
    End Sub

    Private Sub sideadminBtn_Click(sender As Object, e As EventArgs) Handles sideteamBtn.Click
        manageTeams.Show()
        Me.Close()
    End Sub

#Region "ID/Pass validation"
    Private Sub idText_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idText.KeyPress, passText.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub
#End Region

End Class
