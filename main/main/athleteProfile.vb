Imports System.Data.OleDb

Public Class athleteProfile
    'Add the ability to copy?
    'ID Photo (2:3)
    'Draw best event based on participation
    'Get teams

    Dim adNo, adSt, adSb, adPo As String
    Dim ID As String = "436448244"

    Private Sub athleteProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, RollClass, FirstName, LastName, AgeGroup, Address, MedicalInfo, BestEvent, Email, PhoneNumber, Teams FROM athleteDb WHERE ID = " + ID, conn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            'pbPhoto.Image = dr("Photo")
                            If access = 2 Then
                                parseNo(dr("Address"))
                                lblPhone.Text = "Phone Number: " + dr("PhoneNumber")
                                lblEmail.Text = "Email Address: " + dr("Email")
                                lblMedical.Text = dr("MedicalInfo")
                            End If
                            lblID.Text = dr("ID")
                            lblRoll.Text = "Roll Class: " + dr("RollClass")
                            lblFName.Text = dr("FirstName")
                            lblLName.Text = dr("LastName")
                            lblTeams.Text = "Teams: " + dr("Teams")
                            lblAgeGroup.Text = "Age Group: " + dr("AgeGroup")
                            lblBestEvent.Text = "Best Event: " + dr("BestEvent")
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub parseNo(address As String) 'Parse address number
        Dim i As Integer = 0
        While address(i) <> " "
            adNo += address(i)
            i += 1
        End While
        lblStNo.Text = adNo
        parseSt(i, address)
    End Sub

    Private Sub parseSt(i As Integer, address As String) 'Parse address street
        i += 1
        While address(i) <> ","
            adSt += address(i)
            i += 1
        End While
        lblSt.Text = adSt
        parseSb(i, address)
    End Sub

    Private Sub parseSb(i As Integer, address As String) 'Parse address suburb
        i += 2
        While address(i) <> " "
            adSb += address(i)
            i += 1
        End While
        lblSb.Text = adSb
        parsePo(i, address)
    End Sub

    Private Sub parsePo(i As Integer, address As String) 'Parse address postcode
        i += 1
        For i = i To Len(address) - 1
            adPo += address(i)
        Next
        lblPo.Text = adPo
    End Sub
End Class