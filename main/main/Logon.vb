﻿Imports System.Data.OleDb
Public Class Logon

    'login info: ID: kurt, PW: kurtiscool access 2
    '           ID: jun, PW: juniscool1 access 0
    '           ID ben, PW: beniscool access 1


#Region "Dim Variables"
    Dim adpCustomer As New OleDbDataAdapter
    Dim conCreditUnion As OleDbConnection
    Dim datCustomer As New DataSet()
    Dim valid As Boolean = False
    Dim Pass As String
    Dim DataTable As DataTable
    Dim rowCurrent As DataRow
    Dim Key(0) As DataColumn
    Public attempts As Integer = 3
#End Region

#Region " Move Form "
    'simple movement of form when dragging from a point to replace top form bar
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles GroupBox2.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles GroupBox2.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles GroupBox2.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

#End Region

#Region "Login Feedback"
    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Fill out all forms", "SBHS ATHLETICS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim success As Boolean = findUserPass(username:=TextBox1.Text, pass:=TextBox2.Text)
            If success = False Then
                ' Reseting fields, +1 to number of login tries
                TextBox2.Text = ""
                TextBox1.Text = ""
                TextBox1.Focus()
                attempts -= 1
                MessageBox.Show("Incorrect username or password", "SBHS ATHLETICS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox2.Text = ""
                TextBox1.Text = ""
                TextBox1.Focus()
                If attempts = 0 Then ' 3 Tries used up, locked out
                    okBtn.Enabled = False
                    MessageBox.Show("Email Kurt at: Kurt.Rich@gmail.com for your login details", "SBHS ATHLETICS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox1.ReadOnly = True
                    TextBox2.ReadOnly = True
                End If
            End If
            If success = True Then
                home.Show()
                Me.Hide()
            End If
        End If
    End Sub
#End Region

#Region "Match User/Pass"
    Public Shared Function findUserPass(ByVal username As String, pass As String)
        Dim enteredStuff As New List(Of String)
        Dim Found As Boolean
        Using conn As New System.Data.OleDb.OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, Pass, AccessLevel FROM UserDb WHERE ID = @Username AND Pass = @Pass", conn)
                '("SELECT * FROM UserDb WHERE User='" & TextBox1.Text & "' AND Pass = '" & TextBox2.Text & "'")
                cmd.Parameters.Add(New OleDbParameter("@Username", username))
                cmd.Parameters.Add(New OleDbParameter("@Pass", pass)) 'maps your variable to that string
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        If dr.Read() Then
                            access = dr("AccessLevel") 'sets access to accesslevel of the logged in account
                            Found = True
                        Else
                            Found = False
                        End If
                    End If
                End Using
            End Using
        End Using
        Return Found
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        End
    End Sub

    Private Sub ForgotPw(sender As Object, e As EventArgs) Handles forgotPwBtn.Click
        MessageBox.Show("Email Kurt at: Kurt.Rich@gmail.com", "SBHS ATHLETICS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

    End Sub
#End Region


    Private Sub adminTestAccess(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        home.Show()
    End Sub

#Region "Data Validation for login/pass"
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress
   if e.KeyChar <> ControlChars.Back then
            e.Handled = Not (Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub
#End Region

End Class