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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBoxMem = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMax = New System.Windows.Forms.CheckBox()
        Me.CheckBoxApof = New System.Windows.Forms.CheckBox()
        Me.CheckBoxManl = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAuto = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHold = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRel = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMin = New System.Windows.Forms.CheckBox()
        Me.TextBoxValue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxRange = New System.Windows.Forms.ComboBox()
        Me.CheckBoxOverflow = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBattery = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSign = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxUnit = New System.Windows.Forms.ComboBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TimerCOM = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPortM9803R = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerProgressBar = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonCheckCOMs = New System.Windows.Forms.Button()
        Me.ButtonCloseCOM = New System.Windows.Forms.Button()
        Me.ButtonSerialPort = New System.Windows.Forms.Button()
        Me.ComboBoxCOM = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CheckBoxRS232C = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CheckBoxMem)
        Me.GroupBox1.Controls.Add(Me.CheckBoxMax)
        Me.GroupBox1.Controls.Add(Me.CheckBoxApof)
        Me.GroupBox1.Controls.Add(Me.CheckBoxManl)
        Me.GroupBox1.Controls.Add(Me.CheckBoxAuto)
        Me.GroupBox1.Controls.Add(Me.CheckBoxHold)
        Me.GroupBox1.Controls.Add(Me.CheckBoxRel)
        Me.GroupBox1.Controls.Add(Me.CheckBoxMin)
        Me.GroupBox1.Controls.Add(Me.TextBoxValue)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBoxRange)
        Me.GroupBox1.Controls.Add(Me.CheckBoxOverflow)
        Me.GroupBox1.Controls.Add(Me.CheckBoxBattery)
        Me.GroupBox1.Controls.Add(Me.CheckBoxSign)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxUnit)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 212)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "M9803R"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Check Value"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBoxMem
        '
        Me.CheckBoxMem.AutoSize = True
        Me.CheckBoxMem.Location = New System.Drawing.Point(210, 118)
        Me.CheckBoxMem.Name = "CheckBoxMem"
        Me.CheckBoxMem.Size = New System.Drawing.Size(49, 17)
        Me.CheckBoxMem.TabIndex = 16
        Me.CheckBoxMem.Text = "Mem"
        Me.CheckBoxMem.UseVisualStyleBackColor = True
        '
        'CheckBoxMax
        '
        Me.CheckBoxMax.AutoSize = True
        Me.CheckBoxMax.Location = New System.Drawing.Point(110, 118)
        Me.CheckBoxMax.Name = "CheckBoxMax"
        Me.CheckBoxMax.Size = New System.Drawing.Size(46, 17)
        Me.CheckBoxMax.TabIndex = 15
        Me.CheckBoxMax.Text = "Max"
        Me.CheckBoxMax.UseVisualStyleBackColor = True
        '
        'CheckBoxApof
        '
        Me.CheckBoxApof.AutoSize = True
        Me.CheckBoxApof.Location = New System.Drawing.Point(210, 189)
        Me.CheckBoxApof.Name = "CheckBoxApof"
        Me.CheckBoxApof.Size = New System.Drawing.Size(48, 17)
        Me.CheckBoxApof.TabIndex = 14
        Me.CheckBoxApof.Text = "Apof"
        Me.CheckBoxApof.UseVisualStyleBackColor = True
        '
        'CheckBoxManl
        '
        Me.CheckBoxManl.AutoSize = True
        Me.CheckBoxManl.Location = New System.Drawing.Point(210, 165)
        Me.CheckBoxManl.Name = "CheckBoxManl"
        Me.CheckBoxManl.Size = New System.Drawing.Size(49, 17)
        Me.CheckBoxManl.TabIndex = 13
        Me.CheckBoxManl.Text = "Manl"
        Me.CheckBoxManl.UseVisualStyleBackColor = True
        '
        'CheckBoxAuto
        '
        Me.CheckBoxAuto.AutoSize = True
        Me.CheckBoxAuto.Location = New System.Drawing.Point(210, 141)
        Me.CheckBoxAuto.Name = "CheckBoxAuto"
        Me.CheckBoxAuto.Size = New System.Drawing.Size(48, 17)
        Me.CheckBoxAuto.TabIndex = 12
        Me.CheckBoxAuto.Text = "Auto"
        Me.CheckBoxAuto.UseVisualStyleBackColor = True
        '
        'CheckBoxHold
        '
        Me.CheckBoxHold.AutoSize = True
        Me.CheckBoxHold.Location = New System.Drawing.Point(110, 189)
        Me.CheckBoxHold.Name = "CheckBoxHold"
        Me.CheckBoxHold.Size = New System.Drawing.Size(48, 17)
        Me.CheckBoxHold.TabIndex = 11
        Me.CheckBoxHold.Text = "Hold"
        Me.CheckBoxHold.UseVisualStyleBackColor = True
        '
        'CheckBoxRel
        '
        Me.CheckBoxRel.AutoSize = True
        Me.CheckBoxRel.Location = New System.Drawing.Point(110, 165)
        Me.CheckBoxRel.Name = "CheckBoxRel"
        Me.CheckBoxRel.Size = New System.Drawing.Size(42, 17)
        Me.CheckBoxRel.TabIndex = 10
        Me.CheckBoxRel.Text = "Rel"
        Me.CheckBoxRel.UseVisualStyleBackColor = True
        '
        'CheckBoxMin
        '
        Me.CheckBoxMin.AutoSize = True
        Me.CheckBoxMin.Location = New System.Drawing.Point(110, 141)
        Me.CheckBoxMin.Name = "CheckBoxMin"
        Me.CheckBoxMin.Size = New System.Drawing.Size(43, 17)
        Me.CheckBoxMin.TabIndex = 9
        Me.CheckBoxMin.Text = "Min"
        Me.CheckBoxMin.UseVisualStyleBackColor = True
        '
        'TextBoxValue
        '
        Me.TextBoxValue.Location = New System.Drawing.Point(54, 76)
        Me.TextBoxValue.Name = "TextBoxValue"
        Me.TextBoxValue.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxValue.TabIndex = 8
        Me.TextBoxValue.Text = "0222"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Value:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Range:"
        '
        'ComboBoxRange
        '
        Me.ComboBoxRange.FormattingEnabled = True
        Me.ComboBoxRange.Items.AddRange(New Object() {"400mV,4mA,400ohm,10kHz,4nF,Buzzer", "4V,40mA,4kohm,100kHz,40nF,Diode", "40V,400mA,40kohm,1000kHz,400nF", "400V,4000mA,400kohm,4uF", "4000V,4Mohm,40uF", "40Mohm,100Hz", "1000Hz"})
        Me.ComboBoxRange.Location = New System.Drawing.Point(54, 49)
        Me.ComboBoxRange.Name = "ComboBoxRange"
        Me.ComboBoxRange.Size = New System.Drawing.Size(254, 21)
        Me.ComboBoxRange.TabIndex = 5
        Me.ComboBoxRange.Text = "400V,4000mA,400kohm,4uF"
        '
        'CheckBoxOverflow
        '
        Me.CheckBoxOverflow.AutoSize = True
        Me.CheckBoxOverflow.Location = New System.Drawing.Point(6, 189)
        Me.CheckBoxOverflow.Name = "CheckBoxOverflow"
        Me.CheckBoxOverflow.Size = New System.Drawing.Size(84, 17)
        Me.CheckBoxOverflow.TabIndex = 4
        Me.CheckBoxOverflow.Text = "Over Range"
        Me.CheckBoxOverflow.UseVisualStyleBackColor = True
        '
        'CheckBoxBattery
        '
        Me.CheckBoxBattery.AutoSize = True
        Me.CheckBoxBattery.Location = New System.Drawing.Point(6, 165)
        Me.CheckBoxBattery.Name = "CheckBoxBattery"
        Me.CheckBoxBattery.Size = New System.Drawing.Size(99, 17)
        Me.CheckBoxBattery.TabIndex = 3
        Me.CheckBoxBattery.Text = "Batteria scarica"
        Me.CheckBoxBattery.UseVisualStyleBackColor = True
        '
        'CheckBoxSign
        '
        Me.CheckBoxSign.AutoSize = True
        Me.CheckBoxSign.Location = New System.Drawing.Point(6, 141)
        Me.CheckBoxSign.Name = "CheckBoxSign"
        Me.CheckBoxSign.Size = New System.Drawing.Size(95, 17)
        Me.CheckBoxSign.TabIndex = 2
        Me.CheckBoxSign.Text = "Segno: meno -"
        Me.CheckBoxSign.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Unit:"
        '
        'ComboBoxUnit
        '
        Me.ComboBoxUnit.FormattingEnabled = True
        Me.ComboBoxUnit.Items.AddRange(New Object() {"DC V", "AC V", "DC mA", "AC mA", "Ohm", "Buzzer", "Diode", "ADP", "DC A", "AC A", "Hz", "", "CAP"})
        Me.ComboBoxUnit.Location = New System.Drawing.Point(41, 22)
        Me.ComboBoxUnit.Name = "ComboBoxUnit"
        Me.ComboBoxUnit.Size = New System.Drawing.Size(267, 21)
        Me.ComboBoxUnit.TabIndex = 0
        Me.ComboBoxUnit.Text = "DC V"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(13, 231)
        Me.ProgressBar1.MarqueeAnimationSpeed = 1
        Me.ProgressBar1.Maximum = 50
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar1.RightToLeftLayout = True
        Me.ProgressBar1.Size = New System.Drawing.Size(314, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 32
        '
        'TimerCOM
        '
        Me.TimerCOM.Interval = 1000
        '
        'SerialPortM9803R
        '
        Me.SerialPortM9803R.PortName = "COM3"
        '
        'TimerProgressBar
        '
        Me.TimerProgressBar.Enabled = True
        Me.TimerProgressBar.Interval = 300
        '
        'ButtonCheckCOMs
        '
        Me.ButtonCheckCOMs.Location = New System.Drawing.Point(337, 57)
        Me.ButtonCheckCOMs.Name = "ButtonCheckCOMs"
        Me.ButtonCheckCOMs.Size = New System.Drawing.Size(110, 23)
        Me.ButtonCheckCOMs.TabIndex = 39
        Me.ButtonCheckCOMs.Text = "Aggiorna COM"
        Me.ButtonCheckCOMs.UseVisualStyleBackColor = True
        '
        'ButtonCloseCOM
        '
        Me.ButtonCloseCOM.Location = New System.Drawing.Point(337, 115)
        Me.ButtonCloseCOM.Name = "ButtonCloseCOM"
        Me.ButtonCloseCOM.Size = New System.Drawing.Size(110, 23)
        Me.ButtonCloseCOM.TabIndex = 38
        Me.ButtonCloseCOM.Text = "Chiudi COM"
        Me.ButtonCloseCOM.UseVisualStyleBackColor = True
        '
        'ButtonSerialPort
        '
        Me.ButtonSerialPort.Location = New System.Drawing.Point(337, 86)
        Me.ButtonSerialPort.Name = "ButtonSerialPort"
        Me.ButtonSerialPort.Size = New System.Drawing.Size(110, 23)
        Me.ButtonSerialPort.TabIndex = 37
        Me.ButtonSerialPort.Text = "Imposta M9803R"
        Me.ButtonSerialPort.UseVisualStyleBackColor = True
        '
        'ComboBoxCOM
        '
        Me.ComboBoxCOM.FormattingEnabled = True
        Me.ComboBoxCOM.Location = New System.Drawing.Point(337, 29)
        Me.ComboBoxCOM.Name = "ComboBoxCOM"
        Me.ComboBoxCOM.Size = New System.Drawing.Size(116, 21)
        Me.ComboBoxCOM.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(344, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Porta COM:"
        '
        'CheckBoxRS232C
        '
        Me.CheckBoxRS232C.AutoSize = True
        Me.CheckBoxRS232C.Location = New System.Drawing.Point(337, 144)
        Me.CheckBoxRS232C.Name = "CheckBoxRS232C"
        Me.CheckBoxRS232C.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxRS232C.TabIndex = 18
        Me.CheckBoxRS232C.Text = "RS232C"
        Me.CheckBoxRS232C.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 266)
        Me.Controls.Add(Me.CheckBoxRS232C)
        Me.Controls.Add(Me.ButtonCheckCOMs)
        Me.Controls.Add(Me.ButtonCloseCOM)
        Me.Controls.Add(Me.ButtonSerialPort)
        Me.Controls.Add(Me.ComboBoxCOM)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Virtual Instruments M9803R"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxOverflow As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxBattery As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSign As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxUnit As System.Windows.Forms.ComboBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TimerCOM As System.Windows.Forms.Timer
    Friend WithEvents SerialPortM9803R As System.IO.Ports.SerialPort
    Friend WithEvents TimerProgressBar As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxRange As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxMem As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMax As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxApof As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxManl As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAuto As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHold As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxRel As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMin As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxValue As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonCheckCOMs As System.Windows.Forms.Button
    Friend WithEvents ButtonCloseCOM As System.Windows.Forms.Button
    Friend WithEvents ButtonSerialPort As System.Windows.Forms.Button
    Friend WithEvents ComboBoxCOM As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxRS232C As System.Windows.Forms.CheckBox

End Class
