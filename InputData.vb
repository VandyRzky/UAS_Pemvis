Imports System.Text
Imports MySql.Data.MySqlClient

Public Class InputData
    Dim nim As String
    Dim jenis As String
    Dim ulang As String
    Dim prodi As String
    Dim filePath As String
    Dim newFilePath As String
    Dim newFileName As String
    Public Sub New(nimInput As String)
        InitializeComponent()
        nim = nimInput
    End Sub
    Private Sub clear()
        txtIPK.Clear()
        txtNama.Clear()
        txtNIM.Clear()
        rbLaki.Checked = False
        rbPerem.Checked = False
        rbYa.Checked = False
        rbTdk.Checked = False
        filePath = ""
        newFilePath = ""
        newFileName = ""
        PictureBox1.Image = Image.FromFile("D:\Kuliah\Semester 4\Pemrograman Visual\Kelas\UASNET\upload\null-profile.png")
        txtNIM.Focus()
    End Sub

    Public Sub tipeForm()
        If nim = "" Then
            btnEdit.Enabled = False
            btnSimpan.Enabled = True
        Else
            btnEdit.Enabled = True
            btnSimpan.Enabled = False
        End If
    End Sub

    Public Function cekInput()
        If txtIPK.Text = Nothing Or txtNama.Text = Nothing Or txtNIM.Text = Nothing Then
            Return True
        End If
        Return False
    End Function

    Public Function getKelamin()
        If rbLaki.Checked = True Then
            jenis = "Laki-laki"
            Return False
        ElseIf rbPerem.Checked = True Then
            jenis = "Perempuan"
            Return False
        End If
        Return True
    End Function

    Private Function getUlang()
        If rbYa.Checked = True Then
            ulang = "Ya"
            Return False
        ElseIf rbTdk.Checked = True Then
            ulang = "Tidak"
            Return False
        End If
        Return True
    End Function

    Private Function getProdi()
        If cbProdi.Text = "" Then
            Return True
        End If
        prodi = cbProdi.Text
        Return False
    End Function

    Private Function cekNIM()
        CMD = New MySqlCommand("SELECT * FROM mahasiswatabel WHERE nim = @nim", CONN)
        CMD.Parameters.AddWithValue("@nim", txtNIM.Text)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            RD.Close()
            Return True
        End If
        RD.Close()
        Return False
    End Function

    Private Sub InputData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        koneksi()
        tipeForm()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cekInput() Or getKelamin() Or getUlang() Or getProdi() Or newFileName = "" Then
            MsgBox("Input tidak boleh kosong")
            Return
        End If
        If cekNIM() Then
            MsgBox("NIM Sudah dipakai")
            Return
        End If
        CMD = New MySqlCommand("INSERT INTO mahasiswatabel (nim, nama, kelamin, prodi, ulang, ipk, foto) VALUES (@nim, @nama, @kelamin, @prodi, @ulang, @ipk, @foto)", CONN)
        CMD.Parameters.AddWithValue("@nim", txtNIM.Text)
        CMD.Parameters.AddWithValue("@nama", txtNama.Text)
        CMD.Parameters.AddWithValue("@kelamin", jenis)
        CMD.Parameters.AddWithValue("@prodi", cbProdi.Text)
        CMD.Parameters.AddWithValue("@ulang", ulang)
        CMD.Parameters.AddWithValue("@ipk", txtIPK.Text)
        CMD.Parameters.AddWithValue("@foto", newFileName)
        CMD.ExecuteNonQuery()
        IO.File.Copy(filePath, newFilePath, True)
        clear()
    End Sub

    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnUnggah_Click(sender As Object, e As EventArgs) Handles btnUnggah.Click
        Dim openfile As New OpenFileDialog
        openfile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openfile.ShowDialog = DialogResult.OK Then
            filePath = openfile.FileName
            PictureBox1.Image = Image.FromFile(filePath)
            newFileName = "foto_" & Now.ToString("yyyyMMdd_HHmmss") & ".jpg" ' Nama baru
            Dim saveFolder As String = "D:\Kuliah\Semester 4\Pemrograman Visual\Kelas\UASNET\upload\"

            newFilePath = IO.Path.Combine(saveFolder, newFileName)
        End If
    End Sub
End Class