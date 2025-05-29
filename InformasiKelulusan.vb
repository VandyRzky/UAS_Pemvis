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

End Class