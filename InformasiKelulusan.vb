Imports System.IO
Imports MySql.Data.MySqlClient

Public Class InformasiKelulusan
    Public Event DataDipilih(nim As String)

    Dim dataTable As New DataTable()
    Dim currentIndex As Integer = 0
    Private Sub InformasiKelulusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        loadData()
    End Sub

    Private Sub TampilkanData(index As Integer)
        If index >= 0 AndAlso index < dataTable.Rows.Count Then
            Dim row As DataRow = dataTable.Rows(index)

            txtNIM.Text = row("nim").ToString()
            txtNama.Text = row("nama").ToString()
            txtIPK.Text = row("ipk").ToString()
            txtJenis.Text = row("kelamin").ToString
            txtProdi.Text = row("prodi").ToString
            txtUlang.Text = row("ulang").ToString
            Dim fotoFile As String = row("foto").ToString()
            Dim imagePath As String = "D:\Kuliah\Semester 4\Pemrograman Visual\Kelas\UASNET\upload\" & fotoFile
            If IO.File.Exists(imagePath) Then
                PictureBox1.Image = Image.FromFile(imagePath)
            End If
        End If
    End Sub

    Private Sub formKosong()
        PictureBox1.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        btnEdit.Visible = False
        btnHapus.Visible = False
        btnNext.Visible = False
        btnPrev.Visible = False
        txtIPK.Visible = False
        txtJenis.Visible = False
        txtNama.Visible = False
        txtNIM.Visible = False
        txtProdi.Visible = False
        txtUlang.Visible = False
        lbkosong.Visible = True
        kosongpic.Visible = True
    End Sub

    Private Sub loadData()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM mahasiswatabel", CONN)
        dataTable.Clear()
        adapter.Fill(dataTable)

        If dataTable.Rows.Count > 0 Then
            currentIndex = 0
            TampilkanData(currentIndex)
            lbkosong.Visible = False
            kosongpic.Visible = False
        Else
            formKosong()
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            TampilkanData(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < dataTable.Rows.Count - 1 Then
            currentIndex += 1
            TampilkanData(currentIndex)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim nimTerpilih As String = txtNIM.Text
        RaiseEvent DataDipilih(nimTerpilih)
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Yakin ingin menghapus data ini?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            CMD = New MySqlCommand("DELETE FROM mahasiswatabel WHERE nim = @nim", CONN)
            CMD.Parameters.AddWithValue("@nim", txtNIM.Text)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus.", MsgBoxStyle.Information)
            loadData()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim g As Graphics = e.Graphics
        Dim fontTitle As New Font("Times New Roman", 24, FontStyle.Bold)
        Dim fontSubTitle As New Font("Times New Roman", 20, FontStyle.Regular)
        Dim fontText As New Font("Times New Roman", 16)
        Dim margin As Integer = 50

        Dim pageRect As New Rectangle(margin, margin, e.PageBounds.Width - (2 * margin), e.PageBounds.Height - (2 * margin))
        g.DrawRectangle(Pens.Black, pageRect)

        Dim y As Integer = margin + 60

        g.DrawString("UNIVERSITAS LINGKARAN TERBAGI", fontTitle, Brushes.Black, New PointF(e.PageBounds.Width \ 2 - 260, y))
        y += 80
        g.DrawString("menyatakan bahwa", fontText, Brushes.Black, New PointF(e.PageBounds.Width \ 2 - 150, y))
        y += 60
        g.DrawString(txtNama.Text.ToUpper, fontSubTitle, Brushes.Black, New PointF(e.PageBounds.Width \ 2 - 100, y))
        y += 50
        g.DrawString("telah berhasil menyelesaikan Program Pendidikan Sarjana", fontText, Brushes.Black, New PointF(e.PageBounds.Width \ 2 - 300, y))
        y += 50
        g.DrawString("Program Studi " & txtProdi.Text, fontSubTitle, Brushes.Black, New PointF(e.PageBounds.Width \ 2 - 150, y))
    End Sub


End Class