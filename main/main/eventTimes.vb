Public Class eventTimes
    'created or not global variable to see if needs labels and dates when click pb
    'possibly dynamic tabs with vertical tab group
    Dim created200 As Boolean = False
    Dim selected As String = "100"
    Private Sub pb100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb100.Click
        pb100.BackColor = Color.Transparent
        lbl100.BackColor = Color.Transparent
        For Each pb In Me.Controls
            If pb Is pb200 OrElse pb Is pb400 OrElse pb Is PictureBox1 OrElse pb Is PictureBox2 OrElse pb Is pb800 OrElse pb Is PictureBox5 OrElse pb Is PictureBox6 OrElse pb Is lbl200 OrElse pb Is lbl400 Then
                pb.BackColor = SystemColors.Control
            End If
            'If pb isNot lbl100 andalso pb isnot lbl200 andalso pb isnot lbl400 
        Next
    End Sub
    Private Sub pb200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb200.Click
        If created200 = False Then
            Dim dt20013 As New DateTimePicker
            With dt20013
                .Size = New Size(176, 28)
                .Location = New Point(192, 12)
                .Format = DateTimePickerFormat.Time
                .ShowUpDown = True
                .Font = New Font("Modern No. 20", 14)
            End With
            Me.Controls.Add(dt20013)
            Dim dt20014 As New DateTimePicker
            With dt20014
                .Size = New Size(176, 28)
                .Location = New Point(192, 66)
                .Format = DateTimePickerFormat.Time
                .ShowUpDown = True
                .Font = New Font("Modern No. 20", 14)
            End With
            Me.Controls.Add(dt20014)
            Dim dt20015 As New DateTimePicker
            With dt20015
                .Size = New Size(176, 28)
                .Location = New Point(192, 120)
                .Format = DateTimePickerFormat.Time
                .ShowUpDown = True
                .Font = New Font("Modern No. 20", 14)
            End With
            Me.Controls.Add(dt20015)
            created200 = True
        End If
        pb200.BackColor = Color.Transparent
        lbl200.BackColor = Color.Transparent
        For Each pb In Me.Controls
            If pb Is pb100 OrElse pb Is pb400 OrElse pb Is PictureBox1 OrElse pb Is PictureBox2 OrElse pb Is pb800 OrElse pb Is PictureBox5 OrElse pb Is PictureBox6 OrElse pb Is lbl100 OrElse pb Is lbl400 Then
                pb.BackColor = SystemColors.Control
            End If
        Next
        Select Case selected
            'hiding the dtps of other events
            'declaration protection level???
            'Case "100" : dt10013.visible = False
        End Select
    End Sub
    Private Sub pb400_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb400.Click
        pb400.BackColor = Color.Transparent
        lbl400.BackColor = Color.Transparent
        For Each pb In Me.Controls
            If pb Is pb100 OrElse pb Is pb200 OrElse pb Is PictureBox1 OrElse pb Is PictureBox2 OrElse pb Is pb800 OrElse pb Is PictureBox5 OrElse pb Is PictureBox6 OrElse pb Is lbl200 OrElse pb Is lbl100 Then
                pb.BackColor = SystemColors.Control
            End If
        Next
    End Sub
    Public Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt10013 As New DateTimePicker
        With dt10013
            .Size = New Size(176, 28)
            .Location = New Point(192, 12)
            .Format = DateTimePickerFormat.Time
            .ShowUpDown = True
            .Font = New Font("Modern No. 20", 14)
        End With
        Me.Controls.Add(dt10013)
        Dim dt10014 As New DateTimePicker
        With dt10014
            .Size = New Size(176, 28)
            .Location = New Point(192, 66)
            .Format = DateTimePickerFormat.Time
            .ShowUpDown = True
            .Font = New Font("Modern No. 20", 14)
        End With
        Me.Controls.Add(dt10014)
        Dim dt10015 As New DateTimePicker
        With dt10015
            .Size = New Size(176, 28)
            .Location = New Point(192, 120)
            .Format = DateTimePickerFormat.Time
            .ShowUpDown = True
            .Font = New Font("Modern No. 20", 14)
        End With
        Me.Controls.Add(dt10015)
    End Sub
End Class