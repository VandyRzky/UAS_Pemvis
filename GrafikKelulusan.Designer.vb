<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrafikKelulusan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ChartIPK = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lbkosong = New System.Windows.Forms.Label()
        Me.kosongpic = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ChartIPK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kosongpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartIPK
        '
        Me.ChartIPK.BackColor = System.Drawing.Color.Transparent
        Me.ChartIPK.BorderlineColor = System.Drawing.Color.Transparent
        Me.ChartIPK.BorderlineWidth = 0
        Me.ChartIPK.BorderSkin.BackColor = System.Drawing.Color.Transparent
        Me.ChartIPK.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Me.ChartIPK.BorderSkin.BorderColor = System.Drawing.Color.Transparent
        Me.ChartIPK.BorderSkin.BorderWidth = 0
        ChartArea1.Name = "ChartArea1"
        Me.ChartIPK.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartIPK.Legends.Add(Legend1)
        Me.ChartIPK.Location = New System.Drawing.Point(52, 108)
        Me.ChartIPK.Name = "ChartIPK"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartIPK.Series.Add(Series1)
        Me.ChartIPK.Size = New System.Drawing.Size(371, 300)
        Me.ChartIPK.TabIndex = 0
        Me.ChartIPK.Text = "Chart1"
        '
        'lbkosong
        '
        Me.lbkosong.AutoSize = True
        Me.lbkosong.Location = New System.Drawing.Point(153, 285)
        Me.lbkosong.Name = "lbkosong"
        Me.lbkosong.Size = New System.Drawing.Size(173, 16)
        Me.lbkosong.TabIndex = 40
        Me.lbkosong.Text = "Belum ada data mahasiswa"
        '
        'kosongpic
        '
        Me.kosongpic.Image = Global.UASNET.My.Resources.Resources.empty
        Me.kosongpic.Location = New System.Drawing.Point(169, 108)
        Me.kosongpic.Name = "kosongpic"
        Me.kosongpic.Size = New System.Drawing.Size(145, 166)
        Me.kosongpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.kosongpic.TabIndex = 39
        Me.kosongpic.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Rata-rata IPK Setiap Prodi"
        '
        'GrafikKelulusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbkosong)
        Me.Controls.Add(Me.kosongpic)
        Me.Controls.Add(Me.ChartIPK)
        Me.Name = "GrafikKelulusan"
        Me.Text = "GrafikKelulusan"
        CType(Me.ChartIPK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kosongpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChartIPK As DataVisualization.Charting.Chart
    Friend WithEvents lbkosong As Label
    Friend WithEvents kosongpic As PictureBox
    Friend WithEvents Label1 As Label
End Class
