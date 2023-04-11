Public Class Form1
    Private intSizeofArray As Integer = 11
    Private strSavings(intSizeofArray) As String
    Private decBill(intSizeofArray) As Decimal
    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        'Dim selectMonth As ComboBox
        'Dim monthSavings As Decimal
        'Dim mostSavings As Decimal
        ComputeAverage()
        ComputeMaxSavings()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strSavingsAmount As String
        Dim intCount As Integer = 0
        Dim intFill As Integer

        lblSavings.Text = ""
        lblMonthlySavings.Text = ""
        lblMostSavings.Text = ""

        If IO.File.Exists("C:\Users\kenji\source\repos\savings.txt") = True Then
            objReader = IO.File.OpenText("C:\Users\kenji\source\repos\savings.txt")
            Do While objReader.Peek <> -1
                strSavings(intCount) = objReader.ReadLine()
                strSavingsAmount = objReader.ReadLine()
                decBill(intCount) = Convert.ToDecimal(strSavingsAmount)
                intCount += 1

            Loop
            objReader.Close()
            For intFill = 0 To (strSavings.Length - 1)
                cboSelectMonth.Items.Add(strSavings(intFill))
            Next
        Else
            MsgBox("The file is not available. Restart the program when the file is available", , "Error")
            Close()
        End If
    End Sub

    Private Sub cboSelectMonth_SelectedIndexChanged(sender As System.Object, ByVal e As System.EventArgs) Handles cboSelectMonth.SelectedIndexChanged
        Dim intSelectedCityIndex As Integer

        intSelectedCityIndex = cboSelectMonth.SelectedIndex
        lblSavings.Text = "The electric savings for " & strSavings(intSelectedCityIndex) & " is $" & decBill(intSelectedCityIndex).ToString()
        btnStatistics.Visible = True
    End Sub

    Private Sub ComputeMaxSavings()
        Dim intMonths As Integer
        Dim intLargestSavingsValue As Integer = 0
        Dim intIndexValue As Integer = 0
        Dim strYearValue As String = ""

        For Each intMonths In decBill
            intLargestSavingsValue = Math.Max(intLargestSavingsValue, intMonths)
            If (intMonths >= intLargestSavingsValue) Then
                strYearValue = strSavings(intIndexValue)
            End If
            intIndexValue += 1
        Next
        lblMostSavings.Text = strYearValue & " had the most significant monthly savings"

    End Sub

    Private Sub ComputeAverage()
        Dim intCountYears As Integer
        Dim intYears As Integer = 0
        Dim decTotalBill As Decimal = 0
        Dim decAverageNumberOfBill As Decimal = 0D

        For Each intCountYears In decBill
            decTotalBill += decBill(intYears)
            intYears += 1
        Next
        decAverageNumberOfBill = decTotalBill / Convert.ToDecimal(decBill.Length())
        lblMonthlySavings.Text = "The average monthly savings: " & decAverageNumberOfBill.ToString("C2")
    End Sub
End Class
