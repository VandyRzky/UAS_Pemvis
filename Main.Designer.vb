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
        Me.lblIjazah = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PanelKonten
        '
        Me.PanelKonten.Location = New System.Drawing.Point(204, 2)
        Me.PanelKonten.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelKonten.Name = "PanelKonten"
        Me.PanelKonten.Size = New System.Drawing.Size(497, 503)
        Me.PanelKonten.TabIndex = 0
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(21, 107)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(122, 16)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Informasi Kelulusan"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(21, 151)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(67, 16)
        Me.lblInput.TabIndex = 2
        Me.lblInput.Text = "Input Data"
        '
        'lblGrafik
        '
        Me.lblGrafik.AutoSize = True
        Me.lblGrafik.Location = New System.Drawing.Point(21, 197)
        Me.lblGrafik.Name = "lblGrafik"
        Me.lblGrafik.Size = New System.Drawing.Size(103, 16)
        Me.lblGrafik.TabIndex = 3
        Me.lblGrafik.Text = "Grafik Kelulusan"
        '
        'lblIjazah
        '
        Me.lblIjazah.AutoSize = True
        Me.lblIjazah.Location = New System.Drawing.Point(21, 244)
        Me.lblIjazah.Name = "lblIjazah"
        Me.lblIjazah.Size = New System.Drawing.Size(42, 16)
        Me.lblIjazah.TabIndex = 4
        Me.lblIjazah.Text = "Ijazah"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 516)
        Me.Controls.Add(Me.lblIjazah)
        Me.Controls.Add(Me.lblGrafik)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.PanelKonten)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelKonten As Panel
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents lblGrafik As Label
    Friend WithEvents lblIjazah As Label

End Class
