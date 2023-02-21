' Program: Orlando AirBNB
' Author: Zachary Conley
' Date: February 21, 2023
' Purpose: This app allows the user to insert an amount of days to stay at the airBNB and then outputs the price for the number of nights entered.

Public Class Form1
    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        'This event handler closes the program when the button is hit
        Close()

    End Sub

    Private Sub Btncost_Click(sender As Object, e As EventArgs) Handles Btncost.Click
        ' This event handler is activated when the button is clicked and calculates the total cost
        ' according to the amount of nights that were entered
        Const cdecCostPerNight As Decimal = 79D
        Dim strEnterNumberOfNights As String
        Dim intEnterNumberOfNights As Integer
        Dim decTotalCostOfStay As Decimal

        strEnterNumberOfNights = Txtnumnights.Text
        intEnterNumberOfNights = Convert.ToInt32(strEnterNumberOfNights)
        decTotalCostOfStay = intEnterNumberOfNights * cdecCostPerNight
        Lbltotalcost.Text = decTotalCostOfStay.ToString("C")

    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        ' This event handler clears the total cost text box as well as the nights entered by the user
        ' happens when the button is clicked
        Txtnumnights.Clear()
        Lbltotalcost.Text = ""
        Txtnumnights.Focus()

    End Sub
End Class
