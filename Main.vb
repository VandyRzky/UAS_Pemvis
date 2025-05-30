Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Main
    Public Sub TampilkanFormKePanel(form As Form)
        PanelKonten.Controls.Clear()
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.None
        PanelKonten.Controls.Add(form)
        PanelKonten.AutoScroll = True
        form.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanFormKePanel(New InputData(""))
        HapusFotoTidakTerpakai()
    End Sub

    Private Sub lblInfo_Click(sender As Object, e As EventArgs) Handles lblInfo.Click
        Dim infoForm As New InformasiKelulusan()
        AddHandler infoForm.DataDipilih, AddressOf BukaFormInputDenganNIM
        TampilkanFormKePanel(infoForm)
    End Sub

    Private Sub lblInput_Click(sender As Object, e As EventArgs) Handles lblInput.Click
        TampilkanFormKePanel(New InputData(""))
    End Sub

    Private Sub BukaFormInputDenganNIM(nim As String)
        TampilkanFormKePanel(New InputData(nim))
    End Sub

    Public Sub HapusFotoTidakTerpakai()
        Dim folderPath As String = "D:\Kuliah\Semester 4\Pemrograman Visual\Kelas\UASNET\upload\"
        Dim daftarFotoDB As New HashSet(Of String)

        Dim CMD As New MySqlCommand("SELECT foto FROM mahasiswatabel", CONN)
        Dim RD As MySqlDataReader = CMD.ExecuteReader()
        While RD.Read()
            If Not IsDBNull(RD("foto")) Then
                daftarFotoDB.Add(RD("foto").ToString())
            End If
        End While
        RD.Close()

        For Each filePath As String In Directory.GetFiles(folderPath)
            Dim fileName As String = Path.GetFileName(filePath)

            If fileName.ToLower() = "null-profile.png" Then
                Continue For
            End If

            If Not daftarFotoDB.Contains(fileName) Then
                Try
                    File.Delete(filePath)
                Catch ex As Exception
                    MsgBox("Gagal menghapus file: " & fileName & vbCrLf & ex.Message)
                End Try
            End If
        Next
    End Sub

    Private Sub lblGrafik_Click(sender As Object, e As EventArgs) Handles lblGrafik.Click
        TampilkanFormKePanel(GrafikKelulusan)
    End Sub
End Class