Module searchSortFilter
    Private Sub SortFilterSearch(InputFirstName As List(Of String), InputLastName As List(Of String), InputRollClass As List(Of String), InputIDString As List(Of String), InputYearGroup As List(Of String), OutputIndex As List(Of Integer), SearchTextBox As TextBox, FilterComboBox As ComboBox, SortComboBox As ComboBox, YearGroupArray() As Integer)
        Dim SortList As New List(Of String)                                                         'Temporary list used to sort database list without changing indexes
        Dim SortArray() As Object = {InputLastName, InputFirstName, InputRollClass, InputIDString}  'Array matching the sort combo box index to its respective list 
        Dim position As Integer = 0                                                                 'Position to start index search, used when there are multiple people with the same primary value
        Dim FirstPanel As Boolean = True                                                            'Boolean showing whether the panel being filled is the first panel
        Dim SearchList As New List(Of String)                                                       'Temporary list used to get sorted values prior to being filtered by the search module
        Dim FilterList As New List(Of Integer)
        OutputIndex.Clear()
        SortList.Clear()
        SearchList.Clear()
        FilterList.Clear()
        FirstPanel = True
        For i As Integer = 0 To InputIDString.Count - 1 'Add relevant dbColumn to string
            Select Case SortComboBox.SelectedIndex
                Case 1
                    SortList.Add(InputFirstName(i))
                Case 2
                    SortList.Add(InputRollClass(i))
                Case 3
                    SortList.Add(InputIDString(i))
                Case Else
                    SortList.Add(InputLastName(i))
            End Select
        Next
        SortList.Sort()                                 'Sort
        For Each i As String In SortList                'Check for dupes and get index
            If FirstPanel = True Then
                FilterList.Add(SortArray(SortComboBox.SelectedIndex).IndexOf(i))
            ElseIf i = InputLastName(FilterList.Last) Or i = InputFirstName(FilterList.Last) Or i = InputIDString(FilterList.Last) Then
                position = FilterList.Last + 1
                If SortArray(SortComboBox.SelectedIndex).IndexOf(i, position) <> -1 Then
                    FilterList.Add(SortArray(SortComboBox.SelectedIndex).IndexOf(i, position))
                End If
            Else
                FilterList.Add(SortArray(SortComboBox.SelectedIndex).IndexOf(i))
            End If
            FirstPanel = False
        Next
        For Each num As Integer In FilterList           'Filter by year group and search box
            If FilterComboBox.SelectedIndex <> 0 Then
                If CInt(InputYearGroup(num)) = YearGroupArray(FilterComboBox.SelectedIndex) Then
                    If InputLastName(num).ToLower.Contains(SortComboBox.Text.ToLower) Or InputFirstName(num).ToLower.Contains(SortComboBox.Text.ToLower) Or InputIDString(num).ToLower.Contains(SortComboBox.Text.ToLower) Then
                        OutputIndex.Add(num)
                    End If
                End If
            Else
                If InputLastName(num).ToLower.Contains(SortComboBox.Text.ToLower) Or InputFirstName(num).ToLower.Contains(SortComboBox.Text.ToLower) Or InputIDString(num).ToLower.Contains(SortComboBox.Text.ToLower) Then
                    OutputIndex.Add(num)
                End If
            End If
        Next
    End Sub
End Module
