Imports System.Data.OleDb
Public Class makeuser

#Region " Move Form "

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

#End Region

    Public Shared Function findUserPass(ByVal username As String)
        Dim enteredStuff As New List(Of String)
        Dim Found As Boolean
        Using conn As New System.Data.OleDb.OleDbConnection(dataPath + "\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID FROM UserDb WHERE ID = @Username", conn)
                '("SELECT * FROM UserDb WHERE User='" & TextBox1.Text & "' AND Pass = '" & TextBox2.Text & "'")
                cmd.Parameters.Add(New OleDbParameter("@Username", username))
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        If dr.Read() Then
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
    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles createOkBtn.Click
        If createNewID.Text = "" Or createNewPass.Text = "" Or (newAccess1.Checked = False And newAccess2.Checked = False And newAccess3.Checked = False) Then
            MessageBox.Show("Fill out all forms", "SBHS ATHLETICS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim existingUser As Boolean = findUserPass(username:=createNewID.Text)
            If existingUser = True Then
                MessageBox.Show("Username already exists", "SBHS ATHLETICS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                Using conn As New OleDbConnection(dataPath + "\Athlete.accdb")
                    conn.Open()
                    Using cmd As New OleDbCommand("INSERT INTO userDb (ID, Pass, AccessLevel) VALUES (@id, @pass, @accesslvl)", conn)
                        cmd.Parameters.Add(New OleDbParameter("@id", createNewID.Text))
                        cmd.Parameters.Add(New OleDbParameter("@pass", createNewPass.Text))
                        If newAccess1.Checked Then
                            cmd.Parameters.Add(New OleDbParameter("@accesslvl", newAccess1.Text))
                        End If
                        If newAccess2.Checked Then
                            cmd.Parameters.Add(New OleDbParameter("@accesslvl", newAccess2.Text))
                        End If
                        If newAccess3.Checked Then
                            cmd.Parameters.Add(New OleDbParameter("@accesslvl", newAccess3.Text))
                        End If
                        'if username already exists provide error
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                AddEdit_User.UserDbTableAdapter1.Fill(AddEdit_User.AthleteDataSet.userDb)
                Me.Close()
            End If
        End If
    End Sub
    Private Sub createCancelBtn_Click(sender As Object, e As EventArgs) Handles createCancelBtn.Click
        If createNewID.Text <> "" Or createNewPass.Text <> "" Then
            If MessageBox.Show("Discard entered information?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

End Class