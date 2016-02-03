

' Ananta Bhandari
' IS 250, Project 2: States Information Program
' Project started: 07/12/2014, Project Submitted: 07/15/2014
' Purpose of the program: The purpose of this application is to choose the winner by comparing their
'respective finishing time for the race. Upon execution the program should open another form where it
'places the respective runner on pedestal depending on their Race Status. The program also places the runner on 
'pedestal if they have same finishing time.

Option Strict On

Public Class frmRaceResults

    Private Sub btnCalculateResults_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculateResults.Click

        'capture input
        Dim strRunner1 As String = txtRunner1.Text
        Dim strRunner2 As String = txtRunner2.Text
        Dim strRunner3 As String = txtRunner3.Text

        'declare a variable 
        Dim dblRunnerTime1, dblRunnerTime2, dblRunnerTime3 As Double

        'Validating the name is entered for Runner 1
        If strRunner1 = String.Empty Then


            'Shows error if the label is empty
            MessageBox.Show("Please Give a name of Runner1. The name cannot be blank")
            txtRunner1.BackColor = Color.LightBlue ' The text box changes Color
            txtRunner1.Focus()
            Exit Sub
        Else
            'Validating the name is entered for Runner 2
            If strRunner2 = String.Empty Then


                'Shows error if the label is empty
                MessageBox.Show("Please Give a name of Runner2. The name cannot be blank")
                txtRunner2.BackColor = Color.LightBlue ' The text box changes Color 
                txtRunner2.Focus()
                Exit Sub
            Else
                'Validating the name is entered for Runner 3
                If strRunner3 = String.Empty Then


                    'Shows error if the label is empty
                    MessageBox.Show("Please Give a name of Runner3. The name cannot be blank")
                    txtRunner3.BackColor = Color.LightBlue ' The text box changes Color 
                    txtRunner3.Focus()
                    Exit Sub
                End If
            End If
        End If

        'Validate the users enters the numeric values for time
        'Validate the Runner 1 time is valid
        If Not Double.TryParse(txtRunner1Time.Text, dblRunnerTime1) Then

            'Show message box to enter valid numeric value
            MessageBox.Show("Please enter time for runner 1")
            txtRunner1Time.BackColor = Color.LightBlue ' The text box changes Color 
            txtRunner1Time.Focus() ' move the focus back to runner 1 time
            Exit Sub
        ElseIf dblRunnerTime1 <= 0 Or dblRunnerTime1 > 20 Then

            'Show message box to enter valid numeric value
            MessageBox.Show("Please enter the positive number for runner 1 between 1 and 20")
            txtRunner1Time.BackColor = Color.LightBlue ' The text box changes Color 
            txtRunner1Time.Focus() ' move the focus back to runner 1 time
            Exit Sub
        Else
            'Validate the Runner 2 time is valid
            If Not Double.TryParse(txtRunner2Time.Text, dblRunnerTime2) Then

                'Show message box to enter valid numeric value
                MessageBox.Show("Please enter time for runner2")
                txtRunner2Time.BackColor = Color.LightBlue ' The text box changes Color 
                txtRunner2Time.Focus() ' move the focus back to runner 2 time
                Exit Sub
            ElseIf dblRunnerTime2 <= 0 Or dblRunnerTime2 > 20 Then

                MessageBox.Show("Please enter the positive number for runner 2")
                txtRunner2Time.BackColor = Color.LightBlue ' The text box changes Color
                txtRunner2Time.Focus() ' move the focus back to runner 2 time
                Exit Sub
            Else
                'Validate the Runner 3 time is valid
                If Not Double.TryParse(txtRunner3Time.Text, dblRunnerTime3) Then
                    'Show message box to enter valid numeric value
                    MessageBox.Show("Please enter time for runner3")
                    txtRunner3Time.BackColor = Color.LightBlue ' The text box changes Color
                    txtRunner3Time.Focus() ' move the focus back to runner 3 time
                    Exit Sub
                ElseIf dblRunnerTime3 <= 0 Or dblRunnerTime3 > 20 Then
                    txtRunner3Time.BackColor = Color.LightBlue ' The text box changes Color
                    MessageBox.Show("Please enter the positive number for runner3")
                    txtRunner3Time.BackColor = Color.LightBlue ' The text box changes Color
                    txtRunner3Time.Focus() ' move the focus back to runner 3 time
                    Exit Sub
                End If
            End If
        End If

        ' Determine if Runner 1 has the best time 
        If (dblRunnerTime1 < dblRunnerTime2) And (dblRunnerTime2 < dblRunnerTime3) Then
            lbl1stPlace.Text = strRunner1
            lbl2ndPlace.Text = strRunner2
            lbl3rdPlace.Text = strRunner3

            'Determine if 3rd runner has second best time with 1st runner being best
        ElseIf (dblRunnerTime1 < dblRunnerTime2) And (dblRunnerTime3 < dblRunnerTime2) Then
            lbl1stPlace.Text = strRunner1
            lbl2ndPlace.Text = strRunner3
            lbl3rdPlace.Text = strRunner2

            ' Determine if Runner 2 has the best time 
        ElseIf (dblRunnerTime2 < dblRunnerTime1) And (dblRunnerTime1 < dblRunnerTime3) Then
            lbl1stPlace.Text = strRunner2
            lbl2ndPlace.Text = strRunner1
            lbl3rdPlace.Text = strRunner3

            'Determine if 3rd runner has second best time with 2nd runner being best
        ElseIf (dblRunnerTime2 < dblRunnerTime3) And (dblRunnerTime3 < dblRunnerTime1) Then
            lbl1stPlace.Text = strRunner2
            lbl2ndPlace.Text = strRunner3
            lbl3rdPlace.Text = strRunner1


            ' Determine if Runner 3 has the best time 
        ElseIf (dblRunnerTime3 < dblRunnerTime2) And (dblRunnerTime2 < dblRunnerTime1) Then
            lbl1stPlace.Text = strRunner3
            lbl2ndPlace.Text = strRunner2
            lbl3rdPlace.Text = strRunner1

            ' Determine if Runner 3 has the best time with 1st runner as 2nd best 
        ElseIf (dblRunnerTime3 < dblRunnerTime1) And (dblRunnerTime1 < dblRunnerTime2) Then
            lbl1stPlace.Text = strRunner3
            lbl2ndPlace.Text = strRunner1
            lbl3rdPlace.Text = strRunner2

            ' Determine if there is a tie among racers 
            'Determine if all other racers are tied
        ElseIf (dblRunnerTime1 = dblRunnerTime2) And (dblRunnerTime1 = dblRunnerTime3) Then

            lbl1stPlace.Text = strRunner1 & " And " & strRunner2 & " And " & strRunner3
            lbl2ndPlace.Text = "WOW there is a tie"
            lbl3rdPlace.Text = "Wow there is a tie"

            'Tie for first place between runner1 and runner 2
        ElseIf (dblRunnerTime1 = dblRunnerTime2) And (dblRunnerTime2 < dblRunnerTime3) Then

            lbl1stPlace.Text = strRunner1 & " And " & strRunner2
            lbl2ndPlace.Text = strRunner3
            lbl3rdPlace.Text = "WOW there is a tie"

            'Tie for first place between runner1 and runner 3
        ElseIf (dblRunnerTime1 = dblRunnerTime3) And (dblRunnerTime3 < dblRunnerTime2) Then

            lbl1stPlace.Text = strRunner1 & " And " & strRunner3
            lbl2ndPlace.Text = strRunner2
            lbl3rdPlace.Text = "WOW there is a tie"

            'Tie for first place between runner2 and runner 3
        ElseIf (dblRunnerTime2 = dblRunnerTime3) And (dblRunnerTime2 < dblRunnerTime1) Then

            lbl1stPlace.Text = strRunner2 & " And " & strRunner3
            lbl2ndPlace.Text = strRunner1
            lbl3rdPlace.Text = "WOW there is a tie"

            'Tie for second place between runner1 and runner 2
        ElseIf (dblRunnerTime3 < dblRunnerTime2) And (dblRunnerTime2 = dblRunnerTime1) Then

            lbl1stPlace.Text = strRunner3
            lbl2ndPlace.Text = strRunner2 & " And " & strRunner1
            lbl3rdPlace.Text = "WOW there is a tie"

            'Tie for second place between runner2 and runner 3
        ElseIf (dblRunnerTime1 < dblRunnerTime2) And (dblRunnerTime2 = dblRunnerTime3) Then

            lbl1stPlace.Text = strRunner1
            lbl2ndPlace.Text = strRunner2 & " And " & strRunner3
            lbl3rdPlace.Text = "WOW there is a tie"

            'Tie for second place between runner1 and runner 3
        ElseIf (dblRunnerTime2 < dblRunnerTime1) And (dblRunnerTime1 = dblRunnerTime3) Then

            lbl1stPlace.Text = strRunner2
            lbl2ndPlace.Text = strRunner1 & " And " & strRunner3
            lbl3rdPlace.Text = "WOW there is a tie"
        End If

       
        Pedestal()
    End Sub
    Private Sub Pedestal()
        Dim frmRacePedestal As New frmPedestal
        With frmRacePedestal

            .lblGold.Text = lbl1stPlace.Text
            .lblSilver.Text = lbl2ndPlace.Text
            .lblBronze.Text = lbl3rdPlace.Text


            .ShowDialog()
        End With
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        'Clear all the values 
        txtRunner1.Text = String.Empty ' clears value for runner 1
        txtRunner2.Text = String.Empty ' clears value for runner 2
        txtRunner3.Text = String.Empty ' clears value for runner 3
        txtRunner1Time.Text = String.Empty ' clears value for runner1 time
        txtRunner2Time.Text = String.Empty ' clears value for runner2 time
        txtRunner3Time.Text = String.Empty ' clears value for runner3 time
        lbl1stPlace.Text = String.Empty ' clears value for 1st place
        lbl2ndPlace.Text = String.Empty ' clears value for 2nd place
        lbl3rdPlace.Text = String.Empty ' clears value for 3rd place
        'Give focus to Runner 1
        txtRunner1.Focus() ' move the focus back to Runner 1
        AllTextBoxesWhite() ' calling a procedure to clear back color
    End Sub
    Sub AllTextBoxesWhite()
        'all txtboxes are white to begin with
        txtRunner1.BackColor = Color.White
        txtRunner2.BackColor = Color.White
        txtRunner3.BackColor = Color.White
        txtRunner1Time.BackColor = Color.White
        txtRunner2Time.BackColor = Color.White
        txtRunner3Time.BackColor = Color.White
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class