<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Me.PanelKonten = New System.Windows.Forms.Panel()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.lblGrafik = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblKeluar = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelKonten
        '
        Me.PanelKonten.Location = New System.Drawing.Point(250, 4)
        Me.PanelKonten.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelKonten.Name = "PanelKonten"
        Me.PanelKonten.Size = New System.Drawing.Size(461, 552)
        Me.PanelKonten.TabIndex = 0
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(17, 211)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(175, 20)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Informasi Kelulusan"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.Location = New System.Drawing.Point(18, 258)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(96, 20)
        Me.lblInput.TabIndex = 2
        Me.lblInput.Text = "Input Data"
        '
        'lblGrafik
        '
        Me.lblGrafik.AutoSize = True
        Me.lblGrafik.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrafik.Location = New System.Drawing.Point(18, 310)
        Me.lblGrafik.Name = "lblGrafik"
        Me.lblGrafik.Size = New System.Drawing.Size(148, 20)
        Me.lblGrafik.TabIndex = 3
        Me.lblGrafik.Text = "Grafik Kelulusan"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UASNET.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(19, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblKeluar
        '
        Me.lblKeluar.AutoSize = True
        Me.lblKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeluar.Location = New System.Drawing.Point(65, 493)
        Me.lblKeluar.Name = "lblKeluar"
        Me.lblKeluar.Size = New System.Drawing.Size(63, 20)
        Me.lblKeluar.TabIndex = 5
        Me.lblKeluar.Text = "Keluar"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(716, 558)
        Me.Controls.Add(Me.lblKeluar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblGrafik)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.PanelKonten)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Main"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelKonten As Panel
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents lblGrafik As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblKeluar As Label
End Class
