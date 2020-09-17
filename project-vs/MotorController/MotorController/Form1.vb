Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo ErroAbertura
        Dim x As Integer
        cmbMotor.SelectedIndex = 0
        If SerialPort1.IsOpen = False Then
            SerialPort1.Open()
        End If
        Exit Sub
ErroAbertura:
        x = MsgBox("Erro ao abrir a porta serial. Verifique...", MsgBoxStyle.OkOnly, "Erro de Hardware")
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        '5V     - 255

        Dim stringAEnviar As String
        Dim valor As Double
        Dim valorConvertido As Integer

        valor = CDbl(txtVel.Text)
        valorConvertido = (valor * 255) / 5

        If cmbMotor.SelectedIndex = 0 Then
            txtEnviado.Text = ""

            stringAEnviar = (valorConvertido + 1000).ToString + "/"
            txtEnviado.Text = stringAEnviar
            SerialPort1.Write(stringAEnviar)
        ElseIf cmbMotor.SelectedIndex = 1 Then
            txtEnviado.Text = ""

            stringAEnviar = (valorConvertido + 2000).ToString + "/"
            txtEnviado.Text = stringAEnviar
            SerialPort1.Write(stringAEnviar)
        ElseIf cmbMotor.SelectedIndex = 2 Then
            txtEnviado.Text = ""

            stringAEnviar = (valorConvertido + 3000).ToString + "/"
            txtEnviado.Text = stringAEnviar
            SerialPort1.Write(stringAEnviar)
        ElseIf cmbMotor.SelectedIndex = 3 Then
            txtEnviado.Text = ""

            stringAEnviar = (valorConvertido + 4000).ToString + "/"
            txtEnviado.Text = stringAEnviar
            SerialPort1.Write(stringAEnviar)
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        '255    - 5v
        'valor  - x
        Dim valorRecebido As Double
        Dim voltagem As Double
        Dim valorConvertido As Integer
        Dim valorPorcent As Integer

        If SerialPort1.BytesToRead > 0 Then
            txtRecebido.Text = ""
            txtRecebido.Text = SerialPort1.ReadExisting.Trim()

            valorRecebido = CInt(txtRecebido.Text)

            If valorRecebido >= 1000 And valorRecebido < 1256 Then
                valorConvertido = valorRecebido - 1000
                voltagem = (valorConvertido * 5) / 255
                valorPorcent = ((valorConvertido * 100) / 255)

                lblMotor1.Text = valorPorcent.ToString() + " %"
                lblValM1.Text = valorConvertido.ToString
                lblVoltM1.Text = FormatNumber(voltagem, 2) + " v"
            End If
            If valorRecebido >= 2000 And valorRecebido < 2256 Then
                valorConvertido = valorRecebido - 2000
                voltagem = (valorConvertido * 5) / 255
                valorPorcent = ((valorConvertido * 100) / 255)

                lblMotor2.Text = valorPorcent.ToString() + " %"
                lblValM2.Text = valorConvertido.ToString
                lblVoltM2.Text = FormatNumber(voltagem, 2) + " v"
            End If
            If valorRecebido >= 3000 And valorRecebido < 3256 Then
                valorConvertido = valorRecebido - 3000
                voltagem = (valorConvertido * 5) / 255
                valorPorcent = ((valorConvertido * 100) / 255)

                lblMotor3.Text = valorPorcent.ToString() + " %"
                lblValM3.Text = valorConvertido.ToString
                lblVoltM3.Text = FormatNumber(voltagem, 2) + " v"
            End If
            If valorRecebido >= 4000 And valorRecebido < 4256 Then
                valorConvertido = valorRecebido - 4000
                voltagem = (valorConvertido * 5) / 255
                valorPorcent = ((valorConvertido * 100) / 255)

                lblMotor1.Text = valorPorcent.ToString() + " %"
                lblMotor2.Text = valorPorcent.ToString() + " %"
                lblMotor3.Text = valorPorcent.ToString() + " %"

                lblValM1.Text = valorConvertido.ToString
                lblValM2.Text = valorConvertido.ToString
                lblValM3.Text = valorConvertido.ToString

                lblVoltM1.Text = FormatNumber(voltagem, 2) + " v"
                lblVoltM2.Text = FormatNumber(voltagem, 2) + " v"
                lblVoltM3.Text = FormatNumber(voltagem, 2) + " v"
            End If
        End If

    End Sub

End Class
