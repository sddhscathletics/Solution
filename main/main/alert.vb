Module alert
    Public alertCount As Integer

    Public Sub newAlert(name, change, extraData)
        Dim alert As String = name + " has "
        'Open edit database here
        'Dim date and time from edit database
        Select Case change
            Case "add"
                alert += "added"
            Case "edit"
                alert += "edited"
            Case "delete"
                alert += "deleted"
            Case "accAdd"
                alert += "added account"
            Case "accEdit"
                alert += "edited account"
            Case "accDelete"
                alert += "deleted account"
        End Select
        'Write to edit database using given data
    End Sub

    Public Sub readAlert()
        'Open edit dataase here
        'Get 
    End Sub
End Module