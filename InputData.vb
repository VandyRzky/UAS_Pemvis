Imports System.Text
Imports MySql.Data.MySqlClient

Public Class InputData
    Dim nim As String
    Dim jenis As String
    Dim ulang As String
    Dim prodi As String
    Dim filePath As String
    Dim oldFilePath As String
    Dim newFilePath As String
    Dim oldFileName As String
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
        oldFilePath = ""
        newFileName = ""
        oldFileName = ""
        PictureBox1.Image = Image.FromFile("D:\Kuliah\Semester 4\Pemrograman Visual\Kelas\UASNET\upload\null-profile.png")
        txtNIM.Focus()
    End Sub

    Public Sub editLoad()
        CMD = New MySqlCommand("SELECT * FROM mahasiswatabel WHERE nim = @nim", CONN)
        CMD.Parameters.AddWithValue("@nim", nim)
        RD = CMD.ExecuteReader

        If RD.Read() Then
            txtNIM.Text = RD("nim").ToString()
            txtNama.Text = RD("nama").ToString()
            txtIPK.Text = RD("ipk").ToString()
            cbProdi.Text = RD("prodi").ToString()

            Dim kelamin As String = RD("kelamin").ToString()
            If kelamin = "Laki-laki" Then
                rbLaki.Checked = True
            ElseIf kelamin = "Perempuan" Then
                rbPerem.Checked = True
            End If

            Dim ulang As String = RD("ulang").ToString()
            If ulang = "Ya" Then
                rbYa.Checked = True
            ElseIf ulang = "Tidak" Then
                rbTdk.Checked = True
            End If

            oldFileName = RD("foto").ToString()
            oldFilePath = "D:\Kuliah\Semester 4\Pemrograman Visual\Kelas\UASNET\upload\" & oldFileName
            If IO.File.Exists(oldFilePath) Then
                PictureBox1.Image = Image.FromFile(oldFilePath)
            End If
        Else
            MsgBox("Data tidak ditemukan untuk NIM: " & nim, MsgBoxStyle.Exclamation)
        End If

        RD.Close()
    End Sub

    Public Sub tipeForm()
        If nim = "" Then
            btnEdit.Enabled = False
            btnSimpan.Enabled = True
        Else
            editLoad()
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

        cbProdi.DropDownStyle = ComboBoxStyle.DropDownList
        txtNIM.MaxLength = 10
        txtIPK.MaxLength = 4
    End Sub

    Private Function cekIPK()
        'Dim ipk As Double = Double.Parse(txtIPK.Text)
        If Double.Parse(txtIPK.Text) > 4.0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cekInput() Or getKelamin() Or getUlang() Or getProdi() Or newFileName = "" Then
            MsgBox("Input tidak boleh kosong")
            Return
        End If
        If cekIPK() Then
            MsgBox("IPK tidak boleh lebih dari 4")
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
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If cekInput() Or getKelamin() Or getUlang() Or getProdi() Or newFileName = "" Then
            MsgBox("Input tidak boleh kosong")
            Return
        End If
        If cekIPK() Then
            MsgBox("IPK tidak boleh lebih dari 4")
            Return
        End If
        CMD = New MySqlCommand("SELECT * FROM mahasiswatabel WHERE nim = @nimBaru AND nim <> @nimLama", CONN)
        CMD.Parameters.AddWithValue("@nimBaru", txtNIM.Text)
        CMD.Parameters.AddWithValue("@nimLama", nim)
        RD = CMD.ExecuteReader()
        If RD.HasRows Then
            RD.Close()
            MsgBox("NIM Sudah dipakai")
        Else
            RD.Close()
            CMD = New MySqlCommand("UPDATE mahasiswatabel SET nim = @nimbaru, nama = @nama, kelamin = @kelamin, prodi = @prodi, ulang = @ulang, ipk = @ipk, foto = @foto  WHERE nim = @nim", CONN)
            CMD.Parameters.AddWithValue("@nim", nim)
            CMD.Parameters.AddWithValue("@nimbaru", txtNIM.Text)
            CMD.Parameters.AddWithValue("@nama", txtNama.Text)
            CMD.Parameters.AddWithValue("@kelamin", jenis)
            CMD.Parameters.AddWithValue("@prodi", cbProdi.Text)
            CMD.Parameters.AddWithValue("@ulang", ulang)
            CMD.Parameters.AddWithValue("@ipk", txtIPK.Text)
            CMD.Parameters.AddWithValue("@foto", newFileName)
            CMD.ExecuteNonQuery()
            IO.File.Copy(filePath, newFilePath, True)

            clear()
            Dim parentForm As Main = CType(Me.ParentForm, Main)
            parentForm.TampilkanFormKePanel(InformasiKelulusan)
        End If
    End Sub


    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        If nim = "" Then
            clear()
        Else
            Dim parentForm As Main = CType(Me.ParentForm, Main)
            parentForm.TampilkanFormKePanel(InformasiKelulusan)
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        ' Hanya izinkan huruf, backspace dan spasi
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIPK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIPK.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        If e.KeyChar = "."c AndAlso txtIPK.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub
End Class