<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InputData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnUnggah = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtIPK = New System.Windows.Forms.TextBox()
        Me.cbProdi = New System.Windows.Forms.ComboBox()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.rbPerem = New System.Windows.Forms.RadioButton()
        Me.rbYa = New System.Windows.Forms.RadioButton()
        Me.rbTdk = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UASNET.My.Resources.Resources.null_profile
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnUnggah
        '
        Me.btnUnggah.Location = New System.Drawing.Point(11, 163)
        Me.btnUnggah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUnggah.Name = "btnUnggah"
        Me.btnUnggah.Size = New System.Drawing.Size(94, 29)
        Me.btnUnggah.TabIndex = 1
        Me.btnUnggah.Text = "Unggah"
        Me.btnUnggah.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(337, 163)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(94, 29)
        Me.btnBatal.TabIndex = 2
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(116, 163)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(84, 29)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(209, 163)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(84, 29)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "No Induk Mahasiswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama Lengkap"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Program Studi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Pernah Mengulang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 438)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "IPK"
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(186, 210)
        Me.txtNIM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(245, 22)
        Me.txtNIM.TabIndex = 11
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(186, 255)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(245, 22)
        Me.txtNama.TabIndex = 12
        '
        'txtIPK
        '
        Me.txtIPK.Location = New System.Drawing.Point(186, 435)
        Me.txtIPK.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIPK.Name = "txtIPK"
        Me.txtIPK.Size = New System.Drawing.Size(245, 22)
        Me.txtIPK.TabIndex = 16
        '
        'cbProdi
        '
        Me.cbProdi.FormattingEnabled = True
        Me.cbProdi.Items.AddRange(New Object() {"Informatika", "Sistem Informasi", "Elektro"})
        Me.cbProdi.Location = New System.Drawing.Point(186, 343)
        Me.cbProdi.Name = "cbProdi"
        Me.cbProdi.Size = New System.Drawing.Size(245, 24)
        Me.cbProdi.TabIndex = 17
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Location = New System.Drawing.Point(6, 15)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(78, 20)
        Me.rbLaki.TabIndex = 18
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki-laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'rbPerem
        '
        Me.rbPerem.AutoSize = True
        Me.rbPerem.Location = New System.Drawing.Point(141, 15)
        Me.rbPerem.Name = "rbPerem"
        Me.rbPerem.Size = New System.Drawing.Size(98, 20)
        Me.rbPerem.TabIndex = 19
        Me.rbPerem.TabStop = True
        Me.rbPerem.Text = "Perempuan"
        Me.rbPerem.UseVisualStyleBackColor = True
        '
        'rbYa
        '
        Me.rbYa.AutoSize = True
        Me.rbYa.Location = New System.Drawing.Point(6, 9)
        Me.rbYa.Name = "rbYa"
        Me.rbYa.Size = New System.Drawing.Size(45, 20)
        Me.rbYa.TabIndex = 20
        Me.rbYa.TabStop = True
        Me.rbYa.Text = "Ya"
        Me.rbYa.UseVisualStyleBackColor = True
        '
        'rbTdk
        '
        Me.rbTdk.AutoSize = True
        Me.rbTdk.Location = New System.Drawing.Point(176, 9)
        Me.rbTdk.Name = "rbTdk"
        Me.rbTdk.Size = New System.Drawing.Size(63, 20)
        Me.rbTdk.TabIndex = 21
        Me.rbTdk.TabStop = True
        Me.rbTdk.Text = "Tidak"
        Me.rbTdk.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbLaki)
        Me.GroupBox1.Controls.Add(Me.rbPerem)
        Me.GroupBox1.Location = New System.Drawing.Point(186, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 46)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbYa)
        Me.GroupBox2.Controls.Add(Me.rbTdk)
        Me.GroupBox2.Location = New System.Drawing.Point(186, 378)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 33)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " "
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'InputData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 504)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbProdi)
        Me.Controls.Add(Me.txtIPK)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIM)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnUnggah)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "InputData"
        Me.Text = "InputData"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUnggah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents cbProdi As ComboBox
    Friend WithEvents rbYa As RadioButton
    Friend WithEvents rbTdk As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerem As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
