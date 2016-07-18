Module variables
    Public username = "Student"
    Public id As String = ""
    Public access As Integer = 0
    Public alertCount As Integer = 0
    Public alertList As New List(Of notif)

    Public Class notif
        Property ID As String
        Property ltime As String
        Property ldate As String
        Property username As String
        Property edit As String
    End Class

    Public Class athlete
        'To show on card
        Property ID As String
        Property roll As String
        Property fName As String
        Property lName As String

        'Team information
        Property teams As String
        Property ageGroup As String
        Property bestEvent As String

        'Private details
        Property phone As String
        Property email As String
        Property medical As String
        Property address As String
    End Class

    'eddie
    Public shownNotAdded As Boolean = False
End Module