Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdOk_Click_1(sender As Object, e As EventArgs) Handles cmdOk.Click
        lblSenhaAtual04.Text = lblSenhaAtual03.Text
        lblSenhaAtual03.Text = lblSenhaAtual02.Text
        lblSenhaAtual02.Text = lblSenhaAtual01.Text
        lblSenhaAtual01.Text = lblSenhaAtual.Text
        lblSenhaAtual.Text = txtSenha1.Text
        'My.Computer.Audio.Play("c:\b.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("c:\c.wav", AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub cmdAbrirVideo_Click(sender As Object, e As EventArgs) Handles cmdAbrirVideo.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            If AxVLCPlugin21.playlist.items.count > 0 Then
                AxVLCPlugin21.playlist.items.clear()
                AxVLCPlugin21.playlist.stop()
            End If
            AxVLCPlugin21.playlist.add(OpenFileDialog1.FileName)
            AxVLCPlugin21.AutoPlay = True
            AxVLCPlugin21.playlist.play()
        End If
    End Sub
End Class





