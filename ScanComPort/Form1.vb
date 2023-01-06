
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        BtnCon.Enabled = False
        BtnDiscon.Enabled = False
    End Sub

    Private Sub SwitchStatusDetect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        BtnCon.Enabled = False
        BtnDiscon.Enabled = False
    End Sub

    Private Sub BtnScanPort_Click(sender As Object, e As EventArgs) Handles BtnScanPort.Click
        CmbPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        CmbPort.Items.AddRange(myPort)
        i = CmbPort.Items.Count
        i -= 1
        Try
            CmbPort.SelectedIndex = i
        Catch ex As Exception
            Dim result As DialogResult
            result = MessageBox.Show("COM port not detect", "Warning", MessageBoxButtons.OK)
            CmbPort.Text = Nothing
            CmbPort.Items.Clear()
            Call SwitchStatusDetect_Load(Me, e)
        End Try
        BtnCon.Enabled = True
        CmbPort.DroppedDown = True
    End Sub

    Private Sub BtnCon_Click(sender As Object, e As EventArgs) Handles BtnCon.Click
        BtnCon.Enabled = False
        SerialPort1.PortName = CmbPort.SelectedItem
        SerialPort1.BaudRate = ddlBaudRate.Text

        Try
            SerialPort1.Open()
            Timer1.Start()
            BtnDiscon.Enabled = True
            ddlBaudRate.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "IT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try

    End Sub


    Private Sub BtnDiscon_Click(sender As Object, e As EventArgs) Handles BtnDiscon.Click
        BtnDiscon.Enabled = False
        SerialPort1.Close()
        BtnCon.Enabled = True
        Timer1.Stop()
        ddlBaudRate.Enabled = True
        lblData.Text = "0"
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim i As String = SerialPort1.ReadExisting
            If Not i = "" And i > 10 Then
                'txtContent.Text += vbCrLf + i.ToString 換行顯示
                lblData.Text = i.ToString
            Else
                lblData.Text = "0"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        System.Environment.Exit(System.Environment.ExitCode)
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    txtContent.Text = ""
    'End Sub

End Class
