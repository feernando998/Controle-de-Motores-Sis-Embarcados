<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEnviado = New System.Windows.Forms.TextBox()
        Me.txtRecebido = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMotor = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblValM3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblVoltM3 = New System.Windows.Forms.Label()
        Me.lblMotor3 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblValM2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblVoltM2 = New System.Windows.Forms.Label()
        Me.lblMotor2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblValM1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVoltM1 = New System.Windows.Forms.Label()
        Me.lblMotor1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtEnviado)
        Me.GroupBox1.Controls.Add(Me.txtRecebido)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(221, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 100)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mensagens"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Enviado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Recebido"
        '
        'txtEnviado
        '
        Me.txtEnviado.Enabled = False
        Me.txtEnviado.Location = New System.Drawing.Point(66, 57)
        Me.txtEnviado.Name = "txtEnviado"
        Me.txtEnviado.Size = New System.Drawing.Size(166, 21)
        Me.txtEnviado.TabIndex = 5
        '
        'txtRecebido
        '
        Me.txtRecebido.Enabled = False
        Me.txtRecebido.Location = New System.Drawing.Point(66, 31)
        Me.txtRecebido.Name = "txtRecebido"
        Me.txtRecebido.Size = New System.Drawing.Size(166, 21)
        Me.txtRecebido.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEnviar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtVel)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbMotor)
        Me.GroupBox2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(203, 167)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controle"
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(10, 110)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(187, 23)
        Me.btnEnviar.TabIndex = 3
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Motor"
        '
        'txtVel
        '
        Me.txtVel.Location = New System.Drawing.Point(54, 44)
        Me.txtVel.Name = "txtVel"
        Me.txtVel.Size = New System.Drawing.Size(60, 21)
        Me.txtVel.TabIndex = 1
        Me.txtVel.Text = "5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Velocidade (0 - 5v)"
        '
        'cmbMotor
        '
        Me.cmbMotor.FormattingEnabled = True
        Me.cmbMotor.Items.AddRange(New Object() {"Motor 1", "Motor 2", "Motor 3", "Todos"})
        Me.cmbMotor.Location = New System.Drawing.Point(54, 83)
        Me.cmbMotor.Name = "cmbMotor"
        Me.cmbMotor.Size = New System.Drawing.Size(99, 21)
        Me.cmbMotor.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 185)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(449, 144)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Velocidades (%)"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblValM3)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.lblVoltM3)
        Me.GroupBox6.Controls.Add(Me.lblMotor3)
        Me.GroupBox6.Location = New System.Drawing.Point(300, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(141, 114)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Motor 3"
        '
        'lblValM3
        '
        Me.lblValM3.AutoSize = True
        Me.lblValM3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValM3.Location = New System.Drawing.Point(15, 72)
        Me.lblValM3.Name = "lblValM3"
        Me.lblValM3.Size = New System.Drawing.Size(20, 22)
        Me.lblValM3.TabIndex = 14
        Me.lblValM3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "-"
        '
        'lblVoltM3
        '
        Me.lblVoltM3.AutoSize = True
        Me.lblVoltM3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoltM3.Location = New System.Drawing.Point(78, 72)
        Me.lblVoltM3.Name = "lblVoltM3"
        Me.lblVoltM3.Size = New System.Drawing.Size(34, 22)
        Me.lblVoltM3.TabIndex = 12
        Me.lblVoltM3.Text = "0 v"
        '
        'lblMotor3
        '
        Me.lblMotor3.AutoSize = True
        Me.lblMotor3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotor3.Location = New System.Drawing.Point(44, 25)
        Me.lblMotor3.Name = "lblMotor3"
        Me.lblMotor3.Size = New System.Drawing.Size(57, 30)
        Me.lblMotor3.TabIndex = 9
        Me.lblMotor3.Text = "0 %"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblValM2)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.lblVoltM2)
        Me.GroupBox5.Controls.Add(Me.lblMotor2)
        Me.GroupBox5.Location = New System.Drawing.Point(153, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(141, 114)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Motor 2"
        '
        'lblValM2
        '
        Me.lblValM2.AutoSize = True
        Me.lblValM2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValM2.Location = New System.Drawing.Point(16, 72)
        Me.lblValM2.Name = "lblValM2"
        Me.lblValM2.Size = New System.Drawing.Size(20, 22)
        Me.lblValM2.TabIndex = 14
        Me.lblValM2.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "-"
        '
        'lblVoltM2
        '
        Me.lblVoltM2.AutoSize = True
        Me.lblVoltM2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoltM2.Location = New System.Drawing.Point(81, 72)
        Me.lblVoltM2.Name = "lblVoltM2"
        Me.lblVoltM2.Size = New System.Drawing.Size(34, 22)
        Me.lblVoltM2.TabIndex = 12
        Me.lblVoltM2.Text = "0 v"
        '
        'lblMotor2
        '
        Me.lblMotor2.AutoSize = True
        Me.lblMotor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotor2.Location = New System.Drawing.Point(44, 25)
        Me.lblMotor2.Name = "lblMotor2"
        Me.lblMotor2.Size = New System.Drawing.Size(57, 30)
        Me.lblMotor2.TabIndex = 8
        Me.lblMotor2.Text = "0 %"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblValM1)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.lblVoltM1)
        Me.GroupBox4.Controls.Add(Me.lblMotor1)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(141, 114)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Motor 1"
        '
        'lblValM1
        '
        Me.lblValM1.AutoSize = True
        Me.lblValM1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValM1.Location = New System.Drawing.Point(14, 72)
        Me.lblValM1.Name = "lblValM1"
        Me.lblValM1.Size = New System.Drawing.Size(20, 22)
        Me.lblValM1.TabIndex = 13
        Me.lblValM1.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "-"
        '
        'lblVoltM1
        '
        Me.lblVoltM1.AutoSize = True
        Me.lblVoltM1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoltM1.Location = New System.Drawing.Point(74, 72)
        Me.lblVoltM1.Name = "lblVoltM1"
        Me.lblVoltM1.Size = New System.Drawing.Size(34, 22)
        Me.lblVoltM1.TabIndex = 11
        Me.lblVoltM1.Text = "0 v"
        '
        'lblMotor1
        '
        Me.lblMotor1.AutoSize = True
        Me.lblMotor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotor1.Location = New System.Drawing.Point(43, 25)
        Me.lblMotor1.Name = "lblMotor1"
        Me.lblMotor1.Size = New System.Drawing.Size(57, 30)
        Me.lblMotor1.TabIndex = 10
        Me.lblMotor1.Text = "0 %"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 338)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Controle de tensão"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEnviado As System.Windows.Forms.TextBox
    Friend WithEvents txtRecebido As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMotor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblValM3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblVoltM3 As System.Windows.Forms.Label
    Friend WithEvents lblMotor3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblValM2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblVoltM2 As System.Windows.Forms.Label
    Friend WithEvents lblMotor2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblValM1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblVoltM1 As System.Windows.Forms.Label
    Friend WithEvents lblMotor1 As System.Windows.Forms.Label

End Class
