
Public Class Form1

    ' 表單初始化
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        BtnCon.Enabled = False
        BtnDiscon.Enabled = False
    End Sub

    ' 程式關閉時從工作管理員關閉
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Environment.Exit(Environment.ExitCode)
    End Sub


    ' 掃描ComPort
    Private Sub BtnScanPort_Click(sender As Object, e As EventArgs) Handles BtnScanPort.Click

        Dim myPort As Array
        Dim result As DialogResult
        Dim i As Integer

        ' 清除下拉式選單項目
        CmbPort.Items.Clear()

        ' 取得電腦所有COM Port連接號
        myPort = IO.Ports.SerialPort.GetPortNames()
        CmbPort.Items.AddRange(myPort)
        i = CmbPort.Items.Count
        i -= 1

        Try
            ' 默認選擇第一項
            CmbPort.SelectedIndex = i
        Catch ex As Exception
            result = MessageBox.Show("COM port not detect", "Warning", MessageBoxButtons.OK)

            ' 清除下拉式選單初始化
            CmbPort.Text = Nothing
            CmbPort.Items.Clear()

            ' 表單初始化
            Call Form1_Load(Me, e)
        End Try

        BtnCon.Enabled = True
        CmbPort.DroppedDown = True  ' 下拉式選單顯示項目

    End Sub

    ' ComPort 連結
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

    ' ComPort 斷開連結
    Private Sub BtnDiscon_Click(sender As Object, e As EventArgs) Handles BtnDiscon.Click
        BtnDiscon.Enabled = False
        SerialPort1.Close()
        BtnCon.Enabled = True
        Timer1.Stop()
        ddlBaudRate.Enabled = True
        lblData.Text = "0"
    End Sub

    ' 顯示接收數據
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim i As String = SerialPort1.ReadExisting

            ' 此區為自行調整區==================================
            ' 依據連接設備傳回來的資料型態做調整
            ' 本區段範例連接為重量感測器
            'If Not i = "" And i > 10 Then
            '    txtContent.Text += vbCrLf + i.ToString 換行顯示
            '    lblData.Text = i.ToString
            'Else
            '    lblData.Text = "0"
            'End If

            '本區段為讀卡機
            lblData.Text = i.ToString
            '===================================================

        Catch ex As Exception
        End Try
    End Sub

End Class
