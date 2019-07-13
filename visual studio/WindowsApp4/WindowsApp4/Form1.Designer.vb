<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.label11 = New System.Windows.Forms.Label()
        Me.txtSenha1 = New System.Windows.Forms.TextBox()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSenhaAtual01 = New System.Windows.Forms.Label()
        Me.lblSenhaAtual02 = New System.Windows.Forms.Label()
        Me.lblSenhaAtual = New System.Windows.Forms.Label()
        Me.lblSenhaAtual03 = New System.Windows.Forms.Label()
        Me.lblSenhaAtual04 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AxVLCPlugin21 = New AxAXVLC.AxVLCPlugin2()
        Me.cmdAbrirVideo = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.Lime
        Me.label11.Location = New System.Drawing.Point(433, 30)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(394, 73)
        Me.label11.TabIndex = 0
        Me.label11.Text = "Senha atual:"
        '
        'txtSenha1
        '
        Me.txtSenha1.Location = New System.Drawing.Point(503, 277)
        Me.txtSenha1.Name = "txtSenha1"
        Me.txtSenha1.Size = New System.Drawing.Size(100, 20)
        Me.txtSenha1.TabIndex = 1
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(639, 274)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 2
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(444, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(253, 33)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Senha anterior 02:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Lime
        Me.Label7.Location = New System.Drawing.Point(444, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(253, 33)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Senha anterior 03:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label8.Location = New System.Drawing.Point(444, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(253, 33)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Senha anterior 04:"
        '
        'lblSenhaAtual01
        '
        Me.lblSenhaAtual01.AutoSize = True
        Me.lblSenhaAtual01.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenhaAtual01.ForeColor = System.Drawing.Color.Lime
        Me.lblSenhaAtual01.Location = New System.Drawing.Point(703, 103)
        Me.lblSenhaAtual01.Name = "lblSenhaAtual01"
        Me.lblSenhaAtual01.Size = New System.Drawing.Size(35, 33)
        Me.lblSenhaAtual01.TabIndex = 8
        Me.lblSenhaAtual01.Text = "--"
        '
        'lblSenhaAtual02
        '
        Me.lblSenhaAtual02.AutoSize = True
        Me.lblSenhaAtual02.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenhaAtual02.ForeColor = System.Drawing.Color.Lime
        Me.lblSenhaAtual02.Location = New System.Drawing.Point(703, 149)
        Me.lblSenhaAtual02.Name = "lblSenhaAtual02"
        Me.lblSenhaAtual02.Size = New System.Drawing.Size(35, 33)
        Me.lblSenhaAtual02.TabIndex = 9
        Me.lblSenhaAtual02.Text = "--"
        '
        'lblSenhaAtual
        '
        Me.lblSenhaAtual.AutoSize = True
        Me.lblSenhaAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenhaAtual.ForeColor = System.Drawing.Color.Lime
        Me.lblSenhaAtual.Location = New System.Drawing.Point(833, -5)
        Me.lblSenhaAtual.Name = "lblSenhaAtual"
        Me.lblSenhaAtual.Size = New System.Drawing.Size(109, 108)
        Me.lblSenhaAtual.TabIndex = 10
        Me.lblSenhaAtual.Text = "--"
        '
        'lblSenhaAtual03
        '
        Me.lblSenhaAtual03.AutoSize = True
        Me.lblSenhaAtual03.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenhaAtual03.ForeColor = System.Drawing.Color.Lime
        Me.lblSenhaAtual03.Location = New System.Drawing.Point(703, 194)
        Me.lblSenhaAtual03.Name = "lblSenhaAtual03"
        Me.lblSenhaAtual03.Size = New System.Drawing.Size(35, 33)
        Me.lblSenhaAtual03.TabIndex = 11
        Me.lblSenhaAtual03.Text = "--"
        '
        'lblSenhaAtual04
        '
        Me.lblSenhaAtual04.AutoSize = True
        Me.lblSenhaAtual04.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenhaAtual04.ForeColor = System.Drawing.Color.Lime
        Me.lblSenhaAtual04.Location = New System.Drawing.Point(703, 227)
        Me.lblSenhaAtual04.Name = "lblSenhaAtual04"
        Me.lblSenhaAtual04.Size = New System.Drawing.Size(35, 33)
        Me.lblSenhaAtual04.TabIndex = 12
        Me.lblSenhaAtual04.Text = "--"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(444, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 33)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Senha anterior 01:"
        '
        'AxVLCPlugin21
        '
        Me.AxVLCPlugin21.Enabled = True
        Me.AxVLCPlugin21.Location = New System.Drawing.Point(12, 12)
        Me.AxVLCPlugin21.Name = "AxVLCPlugin21"
        Me.AxVLCPlugin21.OcxState = CType(resources.GetObject("AxVLCPlugin21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPlugin21.Size = New System.Drawing.Size(425, 349)
        Me.AxVLCPlugin21.TabIndex = 14
        '
        'cmdAbrirVideo
        '
        Me.cmdAbrirVideo.Location = New System.Drawing.Point(12, 367)
        Me.cmdAbrirVideo.Name = "cmdAbrirVideo"
        Me.cmdAbrirVideo.Size = New System.Drawing.Size(109, 23)
        Me.cmdAbrirVideo.TabIndex = 15
        Me.cmdAbrirVideo.Text = "Abrir o vídeo"
        Me.cmdAbrirVideo.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(1152, 542)
        Me.Controls.Add(Me.cmdAbrirVideo)
        Me.Controls.Add(Me.AxVLCPlugin21)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSenhaAtual04)
        Me.Controls.Add(Me.lblSenhaAtual03)
        Me.Controls.Add(Me.lblSenhaAtual)
        Me.Controls.Add(Me.lblSenhaAtual02)
        Me.Controls.Add(Me.lblSenhaAtual01)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtSenha1)
        Me.Controls.Add(Me.label11)
        Me.Name = "Form1"
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblsenha1 As Label
    Friend WithEvents Label2 As Label

    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents btnSenha As Button
    Friend WithEvents label11 As Label
    Friend WithEvents txtSenha1 As TextBox
    Friend WithEvents cmdOk As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblSenhaAtual01 As Label
    Friend WithEvents lblSenhaAtual02 As Label
    Friend WithEvents lblSenhaAtual As Label
    Friend WithEvents lblSenhaAtual03 As Label
    Friend WithEvents lblSenhaAtual04 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AxVLCPlugin21 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents cmdAbrirVideo As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
