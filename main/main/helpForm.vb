Public Class helpForm
    Dim coachCalendar As String = "The first thing to be noted is that bolded dates indicate" + vbNewLine +
"that there are one Or more events saved On that day." + vbNewLine +
"Now you can begin operations by right or left clicking" + vbNewLine +
"on any date from any month Or year" + vbNewLine +
"  If the date selected is bolded, then a menu will appear" + vbNewLine +
    "with the events scheduled for that day, as well as the" + vbNewLine +
"ability to add another event. If you wish to operate with" + vbNewLine +
"one of the listed events then placing your mouse over" + vbNewLine +
"its menu item will cause another menu to popup." + vbNewLine +
"From here you can choose to edit the event by clicking" + vbNewLine +
"'Edit', add absence information, permission note hand-" + vbNewLine +
"ins And results files by clicking 'Results', Or to delete the " + vbNewLine +
"event by clicking 'delete'." + vbNewLine +
"  Otherwise if the date selected Is unbolded, then a menu" + vbNewLine +
"will appear with the ability to add an event on that day by " + vbNewLine +
"clicking the menu item." + vbNewLine +
"This sums up all you need to know for the calendar, enjoy!"
    Dim userCalendar As String = "The first thing to be noted is that bolded dates indicate" + vbNewLine +
"that there are one Or more events saved On that day." + vbNewLine +
"Now you can begin operations by right or left clicking" + vbNewLine +
"on any bolded date from any month or year:" + vbNewLine +
"  If the date selected is bolded, then a menu will appear" + vbNewLine +
"with the ability to view that event by clicking on the" + vbNewLine +
"menu item." + vbNewLine +
"  Otherwise if the date selected is not bolded, then you" + vbNewLine +
"cannot do anything with that date." + vbNewLine +
"This sums up all you need to know for the calendar, enjoy!"
    Dim coachEvents As String = "The first thing to be noted is that all events require their" + vbNewLine +
"name And Date To be a unique pair, As well As needing" + vbNewLine +
"athletes And a location." + vbNewLine +
"By default, some entries are already made on the screen" + vbNewLine +
"and it is at your discretion to change them." + vbNewLine +
"When modifying athletes and times, ensure that you click" + vbNewLine +
"the relevant button to save your input, otherwise it will" + vbNewLine +
"Not be saved In the Event When you click the large save " + vbNewLine +
"button In the bottom right-hand corner." + vbNewLine +
"When working with attachments, you have the ability to" + vbNewLine +
"add, save, open and delete. Your ability to open an" + vbNewLine +
"attachment depends on it being present in the database" + vbNewLine +
"(after the event is saved). If it is not present, then you will" + vbNewLine +
"be asked if you wish to open it locally, or can later save it." + vbNewLine +
"You can also choose to repeat the event. if you wish to do" + vbNewLine +
"so you must indicate the days and type of repetition." + vbNewLine +
"This sums up all you need to know for the events, enjoy!"
    Dim userEvents = "The first thing to be noted is all controls except athletes," + vbNewLine +
"attachments And events are disabled." + vbNewLine +
"When using the athletes or events boxes, you can select" + vbNewLine +
"or type your desired age group to veiw in the relevant" + vbNewLine +
"combobox to view the event times scheduled or athletes" + vbNewLine +
"specified as in the attendees of this event." + vbNewLine +
"When opening attachments, you have the ability To" + vbNewLine +
"save or open. You can only open one Excel and one Word" + vbNewLine +
"file at a time using the application." + vbNewLine +
"This sums up all you need to know for the events, enjoy!"
    Private Sub helpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If access = 1 Or access = 0 Then
            helpTab.TabPages.Remove(addEditTab)
            lblCalendar.Text = userCalendar
            lblEvents.Text = userEvents
        Else
            lblCalendar.Text = coachCalendar
            lblEvents.Text = coachEvents
        End If
        If helpIdentifier = "calendar" Then
            helpTab.SelectedTab = calendarTab
        End If
        If helpIdentifier = "createEvent" Then
            helpTab.SelectedTab = eventsTab
        End If
        If helpIdentifier = "addEdit" Then
            helpTab.SelectedTab = addEditTab
        End If
        If helpIdentifier = "selectAthlete" Then
            helpTab.SelectedTab = selectAthletesTab
        End If
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class