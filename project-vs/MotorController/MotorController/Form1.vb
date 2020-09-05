Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo ErroAbertura
        Dim x As Integer
        If SerialPort1.IsOpen = False Then
            SerialPort1.Open()
        End If
        Exit Sub
ErroAbertura:
        x = MsgBox("Erro ao abrir a porta serial. Verifique...", MsgBoxStyle.OkOnly, "Erro de Hardware")
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        '5V     - 255

        Dim textoInserido As String
        Dim valorConvertido As Integer
        Dim porcentagem As Integer
        Dim stringAEnviar As String

        textoInserido = txtVel.Text

        valorConvertido = (CInt(textoInserido) * 255) / 5
        porcentagem = (valorConvertido * 100) / 255

        If porcentagem > 99 Then
            porcentagem = 99
        End If

        If cmbMotor.SelectedIndex = 0 Then
            lblMotor1.Text = porcentagem.ToString + " %"
            txtEnviado.Text = ""

            stringAEnviar = (valorConvertido + 1000).ToString + "-" + porcentagem.ToString + "/"
            txtEnviado.Text = stringAEnviar
            SerialPort1.Write(stringAEnviar)
        ElseIf cmbMotor.SelectedIndex = 1 Then
            lblMotor2.Text = porcentagem.ToString + " %"
            txtEnviado.Text = ""

            stringAEnviar = (valorConvertido + 2000).ToString + "-" + porcentagem.ToString + "/"
            txtEnviado.Text = stringAEnviar
            SerialPort1.Write(stringAEnviar)
        ElseIf cmbMotor.SelectedIndex = 2 Then
            lblMotor3.Text = porcentagem.ToString + " %"
            txtEnviado.Text = ""

            stringAEnviar = (valorConvertido + 3000).ToString + "-" + porcentagem.ToString + "/"
            txtEnviado.Text = stringAEnviar
            SerialPort1.Write(stringAEnviar)
        ElseIf cmbMotor.SelectedIndex = 3 Then
            lblMotor1.Text = porcentagem.ToString + " %"
            lblMotor2.Text = porcentagem.ToString + " %"
            lblMotor3.Text = porcentagem.ToString + " %"
            txtEnviado.Text = ""

            stringAEnviar = (valorConvertido + 4000).ToString + "-" + porcentagem.ToString + "/"
            txtEnviado.Text = stringAEnviar
            SerialPort1.Write(stringAEnviar)
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If SerialPort1.BytesToRead > 0 Then
            txtRecebido.Text = ""
            txtRecebido.Text = SerialPort1.ReadExisting
        End If

    End Sub
End Class
