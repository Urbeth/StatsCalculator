Imports VbStatsCalculator

Public Class Form1

    Private Sub buttonCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonCalculate.Click
        calculateStats()
    End Sub
    Private Sub calculateStats()
        If ListBoxValues.Items.Count > 0 Then
            Dim intList As List(Of Int32) = New List(Of Int32)
            For Each i As String In ListBoxValues.Items
                intList.Add(CInt(i))
            Next
            Dim sc As VbStatsCalculator.VbStatsCalculator.StatsCalculator = New VbStatsCalculator.VbStatsCalculator.StatsCalculator(intList)
            TextBoxMean.Text = sc.Mean.ToString()
            TextBoxMode.Text = sc.Mode.ToString()
            TextBoxFrequency.Text = sc.ModeFrequency.ToString()
            TextBoxMedian.Text = sc.Median.ToString()
        End If
    End Sub
End Class
