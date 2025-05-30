Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization
Imports System.Windows.Forms.DataVisualization.Charting

Public Class GrafikKelulusan
    Private Sub GrafikKelulusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TampilkanGrafikRataIPK()
    End Sub

    Private Sub TampilkanGrafikRataIPK()
        ChartIPK.Series.Clear()
        ChartIPK.ChartAreas.Clear()
        ChartIPK.Legends.Clear()
        ChartIPK.Size = New Size(280, 280)

        ChartIPK.ChartAreas.Add("MainArea")
        With ChartIPK.ChartAreas("MainArea")
            .AxisX.Title = "Program Studi"
            .AxisY.Title = "Rata-rata IPK"
            .AxisY.Minimum = 0
            .AxisY.Maximum = 4
            .AxisY.Interval = 0.5
            .AxisX.MajorGrid.Enabled = False
            .AxisY.MajorGrid.Enabled = False 
        End With

        CMD = New MySqlCommand("SELECT prodi, AVG(ipk) AS rata_ipk FROM mahasiswatabel GROUP BY prodi", CONN)
        RD = CMD.ExecuteReader()
        If Not RD.HasRows Then
            ChartIPK.Visible = False
            Label1.Visible = False
            kosongpic.Visible = True
            lbkosong.Visible = True
            Return
        End If
        lbkosong.Visible = False
        kosongpic.Visible = False
        ChartIPK.Visible = True
        Label1.Visible = True

        Dim series As New Series("Rata-rata IPK")
        series.ChartType = SeriesChartType.Column
        series.IsValueShownAsLabel = True

        While RD.Read()
            Dim prodi As String = RD("prodi").ToString()
            Dim rataIPK As Double = Convert.ToDouble(RD("rata_ipk"))
            series.Points.AddXY(prodi, Math.Round(rataIPK, 2))
        End While
        RD.Close()

        ChartIPK.Series.Add(series)
    End Sub

End Class