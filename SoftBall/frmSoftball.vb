' Program Name: Softball Scoreboard
' Date: October 20, 2024
' Author: K Bola
' Purpose: This application calculates the scores of each inning during a softball game for one team 

Public Class frmSoftball
    Private Sub frmSoftball_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstScore.Items.Clear()
    End Sub
    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        Dim strScore As String
        Dim decScore As Decimal
        Dim decTotalScore As Decimal = 0
        Dim decFinalScore As Decimal
        Dim strInputMessage As String = "Enter Score: "
        Dim strInputHeading As String = "Scoreboard"
        Dim strNonNumericValue As String = "Error - Enter a Valid Value: "
        Dim strNegativeValue As String = "Error - Enter a Positive Value: "
        Dim strCancelClicked As String = ""
        Dim intNumberOfEntries As Integer = 1
        Dim intMaxNumberOfEntries As Integer = 7
        strScore = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, "")
        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strScore = strCancelClicked
            If IsNumeric(strScore) Then
                decScore = Convert.ToDecimal(strScore)
                If decScore > 0 Then
                    lstScore.Items.Add(decScore)
                    decTotalScore += decScore
                    intNumberOfEntries += 1
                Else
                    strInputMessage = strNegativeValue
                End If
            Else
                strInputMessage = strNonNumericValue
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strScore = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, "")
            End If
        Loop
        If intNumberOfEntries > 1 Then
            decFinalScore = decTotalScore
            lblTotalFinalScore.Visible = True
            lblTotalFinalScore.Text = "Total Final Score: " & decFinalScore
        End If
        btnScore.Enabled = False
    End Sub
    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstScore.Items.Clear()
        lblTotalFinalScore.Text = ""
        btnScore.Enabled = True
    End Sub
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub
End Class
