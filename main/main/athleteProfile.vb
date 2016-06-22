Public Class athleteProfile
    Dim adNo, adSt, adSb, adPo As String

    Private Sub btnParse_Click(sender As Object, e As EventArgs) Handles btnParse.Click
        parseNo(txtInput.Text)
    End Sub

    Private Sub txtInput_Click(sender As Object, e As EventArgs) Handles txtInput.Click
        txtInput.Clear()
    End Sub

    Private Sub parseNo(address As String)
        '5/26 Monmouth St, Randwick 2032
        Dim i As Integer = 0
        While address(i) <> " "
            adNo += address(i)
            i += 1
        End While
        txtNo.Text = adNo
        parseSt(i, address)
    End Sub

    Private Sub parseSt(i As Integer, address As String)
        i += 1
        While address(i) <> ","
            adSt += address(i)
            i += 1
        End While
        txtSt.Text = adSt
        parseSb(i, address)
    End Sub

    Private Sub parseSb(i As Integer, address As String)
        i += 2
        While address(i) <> " "
            adSb += address(i)
            i += 1
        End While
        txtSb.Text = adSb
        parsePo(i, address)
    End Sub

    Private Sub parsePo(i As Integer, address As String)
        i += 1
        For i = i To Len(address) - 1
            adPo += address(i)
        Next
        txtPo.Text = adPo
    End Sub
End Class