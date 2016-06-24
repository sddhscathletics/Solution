Imports System.Data.OleDb
Public Class Logon
    Dim adpCustomer As OleDbDataAdapter
    Dim conCreditUnion As OleDbConnection
    Dim datCustomer As New DataSet()
    Dim User As String
    Dim valid As Boolean = False
    Dim Pass As String
    Dim DataTable As DataTable
    Dim rowCurrent As DataRow
    Dim Key(0) As DataColumn
    Public attempts As Integer = 3


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("u missin somefin")
        Else
            Dim success As Boolean = findUserPass(username:=TextBox1.Text, pass:=TextBox2.Text)
            If success = False Then
                ' Reseting fields, +1 to number of login tries
                TextBox2.Text = ""
                TextBox1.Text = ""
                TextBox1.Focus()
                attempts -= 1
                MsgBox("yo suck wrong pw/user fooooool")
                TextBox2.Text = ""
                TextBox1.Text = ""
                TextBox1.Focus()
                If attempts = 0 Then ' 3 Tries used up, locked out
                    Button1.Enabled = False
                    MsgBox("you audi")
                    TextBox1.ReadOnly = True
                    TextBox2.ReadOnly = True
                End If
            End If
            If success = True Then
                MsgBox("ye boiiiiiiiiiiii!")
                home.Show()
                Me.Close()
            End If
        End If
    End Sub

    Public Shared Function findUserPass(ByVal username As String, pass As String)
        Dim enteredStuff As New List(Of String)
        Dim Found As Boolean
        Using conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=|DataDirectory|User.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, Pass FROM UserDb WHERE ID = @Username AND Pass = @Pass", conn)
                '("SELECT * FROM UserDb WHERE User='" & TextBox1.Text & "' AND Pass = '" & TextBox2.Text & "'")
                cmd.Parameters.Add(New OleDbParameter("@Username", username))
                cmd.Parameters.Add(New OleDbParameter("@Pass", pass)) 'maps your variable to that string
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

    Private Sub Logon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adpCustomer.SelectCommand = New OleDbCommand()
        With adpCustomer.SelectCommand
            .Connection = conCreditUnion
            .CommandText = "SELECT * FROM UserDb"
            .CommandType = CommandType.Text
            .ExecuteNonQuery()
        End With
    End Sub
End Class