Imports System
Imports System.IO.Ports

Public Class Form1
    Dim m9803r_data As New M9803R_struct
    Dim Sys_Form_isloaded As Boolean = False
    Dim myPort As Array

    Structure M9803R_struct
        Public status As Byte ' bit 0 = OL, bit 2 = battery, bit 3 = negative sign
        Public data0 As Byte ' lsbyte
        Public data1 As Byte
        Public data2 As Byte
        Public data3 As Byte ' msbyte
        Public unit As Byte 'unit
        Public range As Byte 'range
        Public special_1 As Byte ' bit 0 = hold, bit 1 = rel, bit 2 = min, bit 3 = max
        Public special_2 As Byte ' bit 0 = apof, bit 1 = manl, bit 2 = auto, bit 3 = mem
        Public carriagereturn As Byte ' vbCr
        Public linefeed As Byte ' vbLf
    End Structure

    Private Sub TimerProgressBar_Tick(sender As Object, e As EventArgs) Handles TimerProgressBar.Tick
        ProgressBar1.Value = ProgressBar1.Value + ProgressBar1.Step
        If ProgressBar1.Value >= ProgressBar1.Maximum / 2 Then
            ProgressBar1.Value = ProgressBar1.Minimum
            If ProgressBar1.RightToLeftLayout = True Then
                ProgressBar1.RightToLeft = Windows.Forms.RightToLeft.No
                ProgressBar1.RightToLeftLayout = False
            Else
                ProgressBar1.RightToLeft = Windows.Forms.RightToLeft.Yes
                ProgressBar1.RightToLeftLayout = True
            End If
        End If


    End Sub

    Private Sub ComboBoxUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUnit.SelectedIndexChanged
        m9803r_data.unit = ComboBoxUnit.SelectedIndex
    End Sub

    Private Sub ComboBoxRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRange.SelectedIndexChanged
        m9803r_data.range = ComboBoxRange.SelectedIndex
    End Sub

    Private Sub CheckBoxSign_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSign.CheckedChanged
        If CheckBoxSign.Checked = True Then
            m9803r_data.status = m9803r_data.status Or &H8
        Else
            m9803r_data.status = m9803r_data.status And (Not &H8)
        End If

    End Sub

    Private Sub CheckBoxBattery_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBattery.CheckedChanged
        If CheckBoxBattery.Checked = True Then
            m9803r_data.status = m9803r_data.status Or &H4
        Else
            m9803r_data.status = m9803r_data.status And (Not &H4)
        End If

    End Sub

    Private Sub CheckBoxOverflow_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOverflow.CheckedChanged
        If CheckBoxOverflow.Checked = True Then
            m9803r_data.status = m9803r_data.status Or &H1
        Else
            m9803r_data.status = m9803r_data.status And (Not &H1)
        End If

    End Sub

    Private Sub CheckBoxMax_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMax.CheckedChanged
        If CheckBoxMax.Checked = True Then
            m9803r_data.special_1 = m9803r_data.special_1 Or &H8
        Else
            m9803r_data.special_1 = m9803r_data.special_1 And (Not &H8)
        End If

    End Sub

    Private Sub CheckBoxMin_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMin.CheckedChanged
        If CheckBoxMin.Checked = True Then
            m9803r_data.special_1 = m9803r_data.special_1 Or &H4
        Else
            m9803r_data.special_1 = m9803r_data.special_1 And (Not &H4)
        End If
    End Sub

    Private Sub CheckBoxRel_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRel.CheckedChanged
        If CheckBoxRel.Checked = True Then
            m9803r_data.special_1 = m9803r_data.special_1 Or &H2
        Else
            m9803r_data.special_1 = m9803r_data.special_1 And (Not &H2)
        End If
    End Sub

    Private Sub CheckBoxHold_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxHold.CheckedChanged
        If CheckBoxHold.Checked = True Then
            m9803r_data.special_1 = m9803r_data.special_1 Or &H1
        Else
            m9803r_data.special_1 = m9803r_data.special_1 And (Not &H1)
        End If
    End Sub

    Private Sub CheckBoxMem_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMem.CheckedChanged
        If CheckBoxMem.Checked = True Then
            m9803r_data.special_2 = m9803r_data.special_2 Or &H8
        Else
            m9803r_data.special_2 = m9803r_data.special_2 And (Not &H8)
        End If

    End Sub

    Private Sub CheckBoxAuto_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAuto.CheckedChanged
        If CheckBoxAuto.Checked = True Then
            m9803r_data.special_2 = m9803r_data.special_2 Or &H4
        Else
            m9803r_data.special_2 = m9803r_data.special_2 And (Not &H4)
        End If
    End Sub

    Private Sub CheckBoxManl_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxManl.CheckedChanged
        If CheckBoxManl.Checked = True Then
            m9803r_data.special_2 = m9803r_data.special_2 Or &H2
        Else
            m9803r_data.special_2 = m9803r_data.special_2 And (Not &H2)
        End If
    End Sub

    Private Sub CheckBoxApof_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxApof.CheckedChanged
        If CheckBoxApof.Checked = True Then
            m9803r_data.special_2 = m9803r_data.special_2 Or &H1
        Else
            m9803r_data.special_2 = m9803r_data.special_2 And (Not &H1)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxValue.TextChanged

        If TextBoxValue.TextLength > 4 Then
            TextBoxValue.Text = TextBoxValue.Text.Substring(0, 4)
        End If

        If Not IsNumeric(TextBoxValue.Text) Then
            TextBoxValue.Text = "0000"
        End If
        If TextBoxValue.TextLength = 4 Then
            m9803r_data.data3 = Convert.ToByte(Mid(TextBoxValue.Text, 1, 1))
            m9803r_data.data2 = Convert.ToByte(Mid(TextBoxValue.Text, 2, 1))
            m9803r_data.data1 = Convert.ToByte(Mid(TextBoxValue.Text, 3, 1))
            m9803r_data.data0 = Convert.ToByte(Mid(TextBoxValue.Text, 4, 1))
        ElseIf TextBoxValue.TextLength = 3 Then
            m9803r_data.data3 = 0
            m9803r_data.data2 = Convert.ToByte(Mid(TextBoxValue.Text, 1, 1))
            m9803r_data.data1 = Convert.ToByte(Mid(TextBoxValue.Text, 2, 1))
            m9803r_data.data0 = Convert.ToByte(Mid(TextBoxValue.Text, 3, 1))
        ElseIf TextBoxValue.TextLength = 2 Then
            m9803r_data.data3 = 0
            m9803r_data.data2 = 0
            m9803r_data.data1 = Convert.ToByte(Mid(TextBoxValue.Text, 1, 1))
            m9803r_data.data0 = Convert.ToByte(Mid(TextBoxValue.Text, 2, 1))
        ElseIf TextBoxValue.TextLength = 1 Then
            m9803r_data.data3 = 0
            m9803r_data.data2 = 0
            m9803r_data.data1 = 0
            m9803r_data.data0 = Convert.ToByte(Mid(TextBoxValue.Text, 1, 1))
        ElseIf TextBoxValue.TextLength = 0 Then
            m9803r_data.data3 = 0
            m9803r_data.data2 = 0
            m9803r_data.data1 = 0
            m9803r_data.data0 = 0

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(m9803r_data.data0.ToString() & " " & m9803r_data.data1.ToString() & " " & m9803r_data.data2.ToString() & " " & m9803r_data.data3.ToString())
    End Sub

    Private Sub TimerCOM_Tick(sender As Object, e As EventArgs) Handles TimerCOM.Tick
        Dim dati(10) As Byte

        dati(0) = m9803r_data.status
        dati(1) = m9803r_data.data0
        dati(2) = m9803r_data.data1
        dati(3) = m9803r_data.data2
        dati(4) = m9803r_data.data3
        dati(5) = m9803r_data.unit
        dati(6) = m9803r_data.range
        dati(7) = m9803r_data.special_1
        dati(8) = m9803r_data.special_2
        dati(9) = &HD
        dati(10) = &HA

        Try
            SerialPortM9803R.Write(dati, 0, dati.Length)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonCheckCOMs_Click(sender As Object, e As EventArgs) Handles ButtonCheckCOMs.Click
        'Ricerca COM e mettile in ComboBoxCOM
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxCOM.Items.Clear()
        ComboBoxCOM.Items.AddRange(myPort)
    End Sub

    Private Sub ButtonSerialPort_Click(sender As Object, e As EventArgs) Handles ButtonSerialPort.Click
        'Apri la connessione scelta dall'utente nella ComboBox
        Try
            If (SerialPortM9803R.IsOpen = False) Then
                SerialPortM9803R.PortName = ComboBoxCOM.Text
                SerialPortM9803R.Open()
                MsgBox("Porta " + SerialPortM9803R.PortName + " aperta." + vbCrLf + "Verificare la correttezza.", MessageBoxIcon.Information)
            ElseIf (SerialPortM9803R.IsOpen = True) Then
                MsgBox("Porta " + SerialPortM9803R.PortName + " gia' aperta.", MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox("Selezionare un Porta COM valida oppure Porta COM gia' aperta.", MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonCloseCOM_Click(sender As Object, e As EventArgs) Handles ButtonCloseCOM.Click
        Try
            If SerialPortM9803R.IsOpen Then
                SerialPortM9803R.Close()
            End If
        Catch ex As Exception
            MsgBox("Errore in chiusura della Porta COM.", MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CheckBoxRS232C_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRS232C.CheckedChanged
        If CheckBoxRS232C.Checked = True Then
            TimerCOM.Enabled = True
        Else
            TimerCOM.Enabled = False
        End If
    End Sub
End Class
