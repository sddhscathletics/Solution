Public Class athleteProfile
    Dim adNo, adSt, adSb, adPo As String
    Private Sub athleteProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub parseNo(address As String)
        '5/26 Monmouth St, Randwick 2032
        Dim i As Integer = 1
        While address(i) <> " "
            adNo += address(i)
            i += 1
        End While
        parseSt(i, address)
    End Sub

    Private Sub parseSt(i, address)
        i += 1
        While address(i) <> ","
            adSt += address(i)
            i += 1
        End While
        parseSb(i, address)
    End Sub

    Private Sub parseSb(i, address)
        i += 2
        While address(i) <> " "
            adSb += address(i)
            i += 1
        End While
    End Sub

    Private Sub parsePo(i, address)
        i += 1
        For k = i To Len(address)
            adPo += address(i)
        Next
    End Sub
End Class