﻿
Public Class home
    Dim out As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles scrollBtn.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If out = False Then
            Sidebar.Left = Sidebar.Left + 20
            If Sidebar.Left = 0 Then
                out = True
                Timer1.Enabled = False
            End If
        ElseIf out = True Then
            Sidebar.Left = Sidebar.Left - 20
            If Sidebar.Left = -200 Then
                out = False
                Timer1.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
End Class
