Imports System.Data.OleDb
Public Class athleteProfile
    'ID
    'Rollclass
    'First Name
    'Last Name
    'Age Group
    'Address (Parsed)
    'Medical Info (Check address)
    'Best Event
    'Email
    'Phone Number
    'Teams
    'Attachment

    'Removed athlete class
    Dim adNo, adSt, adSb, adPo As String
    Dim ID As Integer = 436448244

    Private Sub athleteProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Athlete.accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, RollClass, FirstName, LastName, AgeGroup, Address, MedicalInfo, BestEvent, Email, PhoneNumber, Teams FROM athleteDb WHERE ID = " + ID, conn) 'Selects unread edits
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            'newAthlete.ID = dr("ID")
                            'newAthlete.roll = dr("RollClass")
                            'newAthlete.fName = dr("FirstName")
                            'newAthlete.lName = dr("LastName")
                            'newAthlete.ageGroup = dr("AgeGroup")
                            'newAthlete.address = dr("Address")
                            'newAthlete.medical = dr("MedicalInfo")
                            'newAthlete.bestEvent = dr("BestEvent")
                            'newAthlete.email = dr("Email")
                            'newAthlete.phone = dr("PhoneNumber")
                            'newAthlete.teams = dr("Teams")
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub


    Private Sub btnParse_Click(sender As Object, e As EventArgs)
        'parseNo(newAthlete.address)
    End Sub

    Private Sub parseNo(address As String) 'Parse address number
        Dim i As Integer = 0
        While address(i) <> " "
            adNo += address(i)
            i += 1
        End While
        ' txtNo.Text = adNo
        parseSt(i, address)
    End Sub


    Private Sub parseSt(i As Integer, address As String) 'Parse address street
        i += 1
        While address(i) <> ","
            adSt += address(i)
            i += 1
        End While
        '  txtSt.Text = adSt
        parseSb(i, address)
    End Sub

    Private Sub parseSb(i As Integer, address As String) 'Parse address suburb
        i += 2
        While address(i) <> " "
            adSb += address(i)
            i += 1
        End While
        ' txtSb.Text = adSb
        parsePo(i, address)
    End Sub

    Private Sub parsePo(i As Integer, address As String) 'Parse address postcode
        i += 1
        For i = i To Len(address) - 1
            adPo += address(i)
        Next
        ' txtPo.Text = adPo
    End Sub
End Class