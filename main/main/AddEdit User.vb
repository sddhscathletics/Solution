Imports System.Data.OleDb
Public Class AddEdit_User

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
    Dim jun As Integer = 0

    Dim Pass As String = ""
#End Region

#Region " Move Form "

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    GroupBox2.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    GroupBox2.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    GroupBox2.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

#End Region

#Region "Sidebar"
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
                athdrop.Top += 10
                admDrop.Top += 10
                sideCalSub1.Top += 10
                sideCalSub2.Top += 10

                sideResSub1.Top += 10
                sideResSub2.Top += 10
            End If
            If cDown = False Then
                sideresultBtn.Top -= 10
                sideAthletesBtn.Top -= 10
                sideadminBtn.Top -= 10
                resdrop.Top -= 10
                athdrop.Top -= 10
                admDrop.Top -= 10
                sideCalSub1.Top -= 10
                sideCalSub2.Top -= 10

                sideResSub1.Top -= 10
                sideResSub2.Top -= 10
            End If
            jun += 1
            If jun = 6 Then
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
                athdrop.Top += 10
                admDrop.Top += 10
                sideResSub1.Top += 10
                sideResSub2.Top += 10
            End If
            If rDown = False Then
                sideAthletesBtn.Top -= 10
                sideadminBtn.Top -= 10
                athdrop.Top -= 10
                admDrop.Top -= 10
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
    Private Sub calDrop_Click(sender As Object, e As EventArgs) Handles caldrop.Click
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        home.Show()
        Me.Close()
    End Sub


#End Region



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim person As String = DataGridView1.CurrentCell.Value.ToString
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("DELETE ID, Pass, AccessLevel FROM userDb WHERE ID = @username", conn)
                cmd.Parameters.Add(New OleDbParameter("@Username", username))
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Me.UserDbTableAdapter1.Fill(Me.AthleteDataSet.userDb)
    End Sub


    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        home.Close()
    End Sub


    Private Sub AddEdit_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AthleteDataSet.userDb' table. You can move, or remove it, as needed.
        Me.UserDbTableAdapter1.Fill(Me.AthleteDataSet.userDb)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("INSERT INTO userDb (ID, Pass, AccessLevel) VALUES (@id, @pass, @accesslvl)", conn)
                cmd.Parameters.Add(New OleDbParameter("@id", idText.Text))
                cmd.Parameters.Add(New OleDbParameter("@pass", passText.Text))
                If RadioButton1.Checked Then
                    cmd.Parameters.Add(New OleDbParameter("@accesslvl", RadioButton1.Text))
                End If
                If RadioButton2.Checked Then
                    cmd.Parameters.Add(New OleDbParameter("@accesslvl", RadioButton2.Text))
                End If
                If RadioButton3.Checked Then
                    cmd.Parameters.Add(New OleDbParameter("@accesslvl", RadioButton3.Text))
                End If
                'if username already exists provide error
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Me.UserDbTableAdapter1.Fill(Me.AthleteDataSet.userDb)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim person As String = DataGridView1.CurrentCell.Value.ToString
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("DELETE ID, Pass, AccessLevel FROM userDb WHERE ID = @username", conn)
                cmd.Parameters.Add(New OleDbParameter("@Username", username))
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("INSERT INTO userDb (ID, Pass, AccessLevel) VALUES (@id, @pass, @accesslvl)", conn)
                cmd.Parameters.Add(New OleDbParameter("@id", idText.Text))
                cmd.Parameters.Add(New OleDbParameter("@pass", passText.Text))
                If RadioButton1.Checked Then
                    cmd.Parameters.Add(New OleDbParameter("@accesslvl", RadioButton1.Text))
                End If
                If RadioButton2.Checked Then
                    cmd.Parameters.Add(New OleDbParameter("@accesslvl", RadioButton2.Text))
                End If
                If RadioButton3.Checked Then
                    cmd.Parameters.Add(New OleDbParameter("@accesslvl", RadioButton3.Text))
                End If
                'if username already exists provide error
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Me.UserDbTableAdapter1.Fill(Me.AthleteDataSet.userDb)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex > -1 Then
            idText.Text = sender.rows(e.RowIndex).cells(0).value
            passText.Text = sender.rows(e.RowIndex).cells(1).value
            If sender.rows(e.RowIndex).cells(2).value = 0 Then
                RadioButton1.Checked = True
            End If
            If sender.rows(e.RowIndex).cells(2).value = 1 Then
                RadioButton2.Checked = True
            End If
            If sender.rows(e.RowIndex).cells(2).value = 2 Then
                RadioButton3.Checked = True
            End If
        End If
    End Sub

End Class
