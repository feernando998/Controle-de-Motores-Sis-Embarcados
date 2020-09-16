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

        Dim textoInserido As String
        Dim stringAEnviar As String

        textoInserido = txtVel.Text


        If cmbMotor.SelectedIndex = 0 Then
            txtEnviado.Text = ""

            stringAEnviar = "1" + textoInserido + "/"
            txtEnviado.Text = stringAEnviar
            SerialPort1.Write(stringAEnviar)
        ElseIf cmbMotor.SelectedIndex = 1 Then
            txtEnviado.Text = ""

            stringAEnviar = "2" + textoInserido + "/"
            txtEnviado.Text = stringAEnviar
            SerialPort1.Write(stringAEnviar)
        ElseIf cmbMotor.SelectedIndex = 2 Then
            txtEnviado.Text = ""

            stringAEnviar = "3" + textoInserido + "/"
            txtEnviado.Text = stringAEnviar
            SerialPort1.Write(stringAEnviar)
        ElseIf cmbMotor.SelectedIndex = 3 Then
            txtEnviado.Text = ""

            stringAEnviar = "4" + textoInserido + "/"
            txtEnviado.Text = stringAEnviar
            SerialPort1.Write(stringAEnviar)
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim valorRecebido As Integer
        Dim voltagem As Integer
        Dim valorConvertido As Integer
        Dim valorPorcent As Integer

        If SerialPort1.BytesToRead > 0 Then
            txtRecebido.Text = ""
            txtRecebido.Text = SerialPort1.ReadExisting.Trim()
            valorRecebido = CInt(SerialPort1.ReadExisting.Trim())

            If valorRecebido >= 10 And valorRecebido <= 15 Then
                voltagem = valorRecebido - 10
                valorConvertido = (voltagem * 255) / 5
                valorPorcent = ((valorConvertido * 100) / 255)

                lblMotor1.Text = valorPorcent.ToString() + " %"
            End If
            If valorRecebido >= 20 And valorRecebido <= 25 Then
                voltagem = valorRecebido - 20
                valorConvertido = (voltagem * 255) / 5
                valorPorcent = ((valorConvertido * 100) / 255)

                lblMotor2.Text = valorPorcent.ToString() + " %"
            End If
            If valorRecebido >= 30 And valorRecebido <= 35 Then
                voltagem = valorRecebido - 30
                valorConvertido = (voltagem * 255) / 5
                valorPorcent = ((valorConvertido * 100) / 255)

                lblMotor3.Text = valorPorcent.ToString() + " %"
            End If
            If valorRecebido >= 40 And valorRecebido <= 45 Then
                voltagem = valorRecebido - 40
                valorConvertido = (voltagem * 255) / 5
                valorPorcent = ((valorConvertido * 100) / 255)

                lblMotor1.Text = valorPorcent.ToString() + " %"
                lblMotor2.Text = valorPorcent.ToString() + " %"
                lblMotor3.Text = valorPorcent.ToString() + " %"
            End If
        End If

    End Sub
End Class
