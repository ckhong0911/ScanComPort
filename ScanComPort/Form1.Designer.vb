<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnCon = New System.Windows.Forms.Button()
        Me.BtnScanPort = New System.Windows.Forms.Button()
        Me.CmbPort = New System.Windows.Forms.ComboBox()
        Me.BtnDiscon = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ddlBaudRate = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCon
        '
        Me.BtnCon.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnCon.Location = New System.Drawing.Point(321, 87)
        Me.BtnCon.Name = "BtnCon"
        Me.BtnCon.Size = New System.Drawing.Size(95, 31)
        Me.BtnCon.TabIndex = 26
        Me.BtnCon.Text = "Connect"
        Me.BtnCon.UseVisualStyleBackColor = True
        '
        'BtnScanPort
        '
        Me.BtnScanPort.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnScanPort.Location = New System.Drawing.Point(24, 36)
        Me.BtnScanPort.Name = "BtnScanPort"
        Me.BtnScanPort.Size = New System.Drawing.Size(138, 31)
        Me.BtnScanPort.TabIndex = 25
        Me.BtnScanPort.Text = "Scan Serial Port"
        Me.BtnScanPort.UseVisualStyleBackColor = True
        '
        'CmbPort
        '
        Me.CmbPort.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CmbPort.FormattingEnabled = True
        Me.CmbPort.Location = New System.Drawing.Point(168, 38)
        Me.CmbPort.Name = "CmbPort"
        Me.CmbPort.Size = New System.Drawing.Size(147, 27)
        Me.CmbPort.TabIndex = 22
        '
        'BtnDiscon
        '
        Me.BtnDiscon.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnDiscon.Location = New System.Drawing.Point(422, 87)
        Me.BtnDiscon.Name = "BtnDiscon"
        Me.BtnDiscon.Size = New System.Drawing.Size(104, 31)
        Me.BtnDiscon.TabIndex = 28
        Me.BtnDiscon.Text = "DisConnect"
        Me.BtnDiscon.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 19200
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ddlBaudRate)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnDiscon)
        Me.GroupBox1.Controls.Add(Me.CmbPort)
        Me.GroupBox1.Controls.Add(Me.BtnScanPort)
        Me.GroupBox1.Controls.Add(Me.BtnCon)
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 285)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conditions of use"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblData)
        Me.Panel1.Location = New System.Drawing.Point(24, 190)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(502, 70)
        Me.Panel1.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("新細明體", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 64)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "g"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblData.Font = New System.Drawing.Font("新細明體", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblData.Location = New System.Drawing.Point(0, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(57, 64)
        Me.lblData.TabIndex = 47
        Me.lblData.Text = "0"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.Location = New System.Drawing.Point(422, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 28)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'ddlBaudRate
        '
        Me.ddlBaudRate.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ddlBaudRate.FormattingEnabled = True
        Me.ddlBaudRate.Items.AddRange(New Object() {"9600", "19200", "38400", "115200"})
        Me.ddlBaudRate.Location = New System.Drawing.Point(168, 89)
        Me.ddlBaudRate.Name = "ddlBaudRate"
        Me.ddlBaudRate.Size = New System.Drawing.Size(147, 27)
        Me.ddlBaudRate.TabIndex = 44
        Me.ddlBaudRate.Text = "9600"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(24, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 31)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Baud Rate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 19)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Data Reader:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 332)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scan ComPort"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCon As Button
    Friend WithEvents BtnScanPort As Button
    Friend WithEvents CmbPort As ComboBox
    Friend WithEvents BtnDiscon As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ddlBaudRate As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblData As Label
End Class
