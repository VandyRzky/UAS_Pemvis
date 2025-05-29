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
End Class