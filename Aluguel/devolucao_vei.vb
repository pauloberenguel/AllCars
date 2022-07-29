Imports System.Data.OleDb

Public Class devolucao_vei
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcod_alu As System.Windows.Forms.TextBox
    Friend WithEvents bt_ok As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents placa_vei As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_modelo As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_vei As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents v_diaria As System.Windows.Forms.TextBox
    Friend WithEvents txt_juros As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CodCLI As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cb_Cli As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_dataalu As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_jurostotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents cb_print As System.Windows.Forms.Button
    Friend WithEvents efetuar_aluguel As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(devolucao_vei))
        Me.txtcod_alu = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.status = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.bt_ok = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.placa_vei = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_modelo = New System.Windows.Forms.TextBox
        Me.txt_cod_vei = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.v_diaria = New System.Windows.Forms.TextBox
        Me.txt_juros = New System.Windows.Forms.TextBox
        Me.txt_dataalu = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cb_Cli = New System.Windows.Forms.TextBox
        Me.CodCLI = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_jurostotal = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.cb_print = New System.Windows.Forms.Button
        Me.efetuar_aluguel = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcod_alu
        '
        Me.txtcod_alu.Location = New System.Drawing.Point(480, 16)
        Me.txtcod_alu.Name = "txtcod_alu"
        Me.txtcod_alu.Size = New System.Drawing.Size(56, 20)
        Me.txtcod_alu.TabIndex = 0
        Me.txtcod_alu.Text = ""
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Beige
        Me.Label11.Location = New System.Drawing.Point(408, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 32)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "Código do aluguel"
        '
        'status
        '
        Me.status.Cursor = System.Windows.Forms.Cursors.Cross
        Me.status.Font = New System.Drawing.Font("Vrinda", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.Location = New System.Drawing.Point(0, 384)
        Me.status.Name = "status"
        Me.status.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.status.ShowPanels = True
        Me.status.Size = New System.Drawing.Size(568, 22)
        Me.status.TabIndex = 258
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Icon = CType(resources.GetObject("StatusBarPanel1.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel1.ToolTipText = "Atualizacao de saldo do fornecedor"
        Me.StatusBarPanel1.Width = 552
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(400, 43)
        Me.Label7.TabIndex = 275
        Me.Label7.Text = "Devolução de Veículos"
        '
        'bt_ok
        '
        Me.bt_ok.BackColor = System.Drawing.Color.White
        Me.bt_ok.Location = New System.Drawing.Point(536, 16)
        Me.bt_ok.Name = "bt_ok"
        Me.bt_ok.Size = New System.Drawing.Size(24, 25)
        Me.bt_ok.TabIndex = 276
        Me.bt_ok.Text = "ok"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(296, 56)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(264, 216)
        Me.ListView1.TabIndex = 277
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.placa_vei)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_modelo)
        Me.GroupBox1.Controls.Add(Me.txt_cod_vei)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.v_diaria)
        Me.GroupBox1.Controls.Add(Me.txt_juros)
        Me.GroupBox1.Controls.Add(Me.txt_dataalu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 120)
        Me.GroupBox1.TabIndex = 278
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veículo"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Beige
        Me.Label9.Location = New System.Drawing.Point(8, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 34)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Juros(p/dia)"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Beige
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Placa"
        '
        'placa_vei
        '
        Me.placa_vei.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.placa_vei.Location = New System.Drawing.Point(72, 52)
        Me.placa_vei.Name = "placa_vei"
        Me.placa_vei.ReadOnly = True
        Me.placa_vei.Size = New System.Drawing.Size(56, 19)
        Me.placa_vei.TabIndex = 5
        Me.placa_vei.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(144, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Modelo"
        '
        'txt_modelo
        '
        Me.txt_modelo.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.txt_modelo.Location = New System.Drawing.Point(200, 88)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.ReadOnly = True
        Me.txt_modelo.Size = New System.Drawing.Size(80, 19)
        Me.txt_modelo.TabIndex = 73
        Me.txt_modelo.Text = ""
        '
        'txt_cod_vei
        '
        Me.txt_cod_vei.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.txt_cod_vei.Location = New System.Drawing.Point(208, 9)
        Me.txt_cod_vei.Name = "txt_cod_vei"
        Me.txt_cod_vei.ReadOnly = True
        Me.txt_cod_vei.Size = New System.Drawing.Size(72, 19)
        Me.txt_cod_vei.TabIndex = 71
        Me.txt_cod_vei.Text = "Cod. Veiculo"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Beige
        Me.Label5.Location = New System.Drawing.Point(8, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 31)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Diária($)"
        '
        'v_diaria
        '
        Me.v_diaria.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.v_diaria.Location = New System.Drawing.Point(72, 17)
        Me.v_diaria.Name = "v_diaria"
        Me.v_diaria.ReadOnly = True
        Me.v_diaria.Size = New System.Drawing.Size(88, 19)
        Me.v_diaria.TabIndex = 43
        Me.v_diaria.Text = ""
        '
        'txt_juros
        '
        Me.txt_juros.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.txt_juros.Location = New System.Drawing.Point(72, 88)
        Me.txt_juros.Name = "txt_juros"
        Me.txt_juros.ReadOnly = True
        Me.txt_juros.Size = New System.Drawing.Size(56, 19)
        Me.txt_juros.TabIndex = 76
        Me.txt_juros.Text = ""
        '
        'txt_dataalu
        '
        Me.txt_dataalu.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.txt_dataalu.Location = New System.Drawing.Point(200, 48)
        Me.txt_dataalu.Name = "txt_dataalu"
        Me.txt_dataalu.ReadOnly = True
        Me.txt_dataalu.Size = New System.Drawing.Size(80, 19)
        Me.txt_dataalu.TabIndex = 279
        Me.txt_dataalu.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Beige
        Me.Label3.Location = New System.Drawing.Point(144, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 32)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Data do Aluguel"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Beige
        Me.Label10.Location = New System.Drawing.Point(176, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 32)
        Me.Label10.TabIndex = 280
        Me.Label10.Text = "Cód Veículo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_Cli)
        Me.GroupBox2.Controls.Add(Me.CodCLI)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox2.Location = New System.Drawing.Point(8, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 48)
        Me.GroupBox2.TabIndex = 279
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'cb_Cli
        '
        Me.cb_Cli.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Cli.Location = New System.Drawing.Point(72, 16)
        Me.cb_Cli.Name = "cb_Cli"
        Me.cb_Cli.ReadOnly = True
        Me.cb_Cli.Size = New System.Drawing.Size(128, 21)
        Me.cb_Cli.TabIndex = 282
        Me.cb_Cli.Text = ""
        '
        'CodCLI
        '
        Me.CodCLI.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.CodCLI.Location = New System.Drawing.Point(208, 16)
        Me.CodCLI.Name = "CodCLI"
        Me.CodCLI.ReadOnly = True
        Me.CodCLI.Size = New System.Drawing.Size(72, 19)
        Me.CodCLI.TabIndex = 4
        Me.CodCLI.Text = "Cod. Cliente"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Beige
        Me.Label4.Location = New System.Drawing.Point(8, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Nome"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(96, 256)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(88, 20)
        Me.txttotal.TabIndex = 280
        Me.txttotal.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Beige
        Me.Label6.Location = New System.Drawing.Point(8, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 26)
        Me.Label6.TabIndex = 281
        Me.Label6.Text = "Total"
        '
        'txt_jurostotal
        '
        Me.txt_jurostotal.Location = New System.Drawing.Point(96, 224)
        Me.txt_jurostotal.Name = "txt_jurostotal"
        Me.txt_jurostotal.ReadOnly = True
        Me.txt_jurostotal.Size = New System.Drawing.Size(88, 20)
        Me.txt_jurostotal.TabIndex = 282
        Me.txt_jurostotal.Text = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Beige
        Me.Label8.Location = New System.Drawing.Point(8, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 26)
        Me.Label8.TabIndex = 283
        Me.Label8.Text = "Juros"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(368, 352)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 18)
        Me.Label12.TabIndex = 292
        Me.Label12.Text = "Voltar"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(256, 352)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 18)
        Me.Label13.TabIndex = 291
        Me.Label13.Text = "Imprimir"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(136, 352)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 18)
        Me.Label14.TabIndex = 290
        Me.Label14.Text = "Efetua Aluguel"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(360, 296)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 60)
        Me.Button7.TabIndex = 288
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cb_print
        '
        Me.cb_print.BackColor = System.Drawing.Color.White
        Me.cb_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_print.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cb_print.Image = CType(resources.GetObject("cb_print.Image"), System.Drawing.Image)
        Me.cb_print.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cb_print.Location = New System.Drawing.Point(256, 296)
        Me.cb_print.Name = "cb_print"
        Me.cb_print.Size = New System.Drawing.Size(56, 60)
        Me.cb_print.TabIndex = 287
        Me.cb_print.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'efetuar_aluguel
        '
        Me.efetuar_aluguel.BackColor = System.Drawing.Color.White
        Me.efetuar_aluguel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.efetuar_aluguel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.efetuar_aluguel.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.efetuar_aluguel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.efetuar_aluguel.Image = CType(resources.GetObject("efetuar_aluguel.Image"), System.Drawing.Image)
        Me.efetuar_aluguel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.efetuar_aluguel.Location = New System.Drawing.Point(152, 296)
        Me.efetuar_aluguel.Name = "efetuar_aluguel"
        Me.efetuar_aluguel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.efetuar_aluguel.Size = New System.Drawing.Size(56, 60)
        Me.efetuar_aluguel.TabIndex = 286
        Me.efetuar_aluguel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(128, 288)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(304, 87)
        Me.Label20.TabIndex = 289
        '
        'devolucao_vei
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(568, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.cb_print)
        Me.Controls.Add(Me.efetuar_aluguel)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt_jurostotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtcod_alu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.bt_ok)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label11)
        Me.Name = "devolucao_vei"
        Me.Text = "Devolucao de veiculos"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Friend diacombinado As Date
    Friend situ As String 

    Private Sub devolucao_vei_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        comando = New OleDbCommand("select * from alugueis", Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            While dr.Read
                Dim lista As New ListViewItem
                lista.Text = dr("modelo_vei")
                lista.SubItems.Add(dr("cod_aluguel"))
                situ = dr("situacao_alu")
                If situ = "A - Alugado" Then
                    ListView1.Items.Add(lista)
                End If
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub bt_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ok.Click
        If Me.txtcod_alu.Text = "" Then
            Dim prompt As String
            prompt = "Entre com o código do aluguel"
            txtcod_alu.Text = InputBox(prompt)
            txtcod_alu.ReadOnly = False
        End If
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        comando = New OleDbCommand("select * from alugueis where cod_aluguel=" & txtcod_alu.Text.ToString, Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            If dr.Read Then
                situ = dr("situacao_alu")
                If situ = "D - Devolvido" Then
                    Exit Sub
                End If
                v_diaria.Text = dr("vdiaria_vei")
                txt_cod_vei.Text = dr("cod_vei")
                placa_vei.Text = dr("placa_vei")
                txt_dataalu.Text = dr("data_aluguel")
                txt_modelo.Text = dr("modelo_vei")
                txt_juros.Text = dr("juros_dia_aluguel")
                cb_Cli.Text = dr("nome_cli")
                CodCLI.Text = dr("cod_cli")
                diacombinado = dr("data_entrega_aluguel")
                Dim lol As String = diacombinado.Date.Subtract(txt_dataalu.Text).TotalDays
                txt_jurostotal.Text = Val(Today.Date.Subtract(diacombinado.Date).TotalDays) * Val(txt_juros.Text)
                txttotal.Text = lol * Val(v_diaria.Text)
            End If
            txtcod_alu.ReadOnly = True
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        comando = New OleDbCommand("select * from alugueis where cod_aluguel=" & ListView1.FocusedItem.SubItems(1).Text.ToString, Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            If dr.Read Then
                v_diaria.Text = dr("vdiaria_vei")
                txt_cod_vei.Text = dr("cod_vei")
                placa_vei.Text = dr("placa_vei")
                txt_dataalu.Text = dr("data_aluguel")
                txt_modelo.Text = dr("modelo_vei")
                txt_juros.Text = dr("juros_dia_aluguel")
                cb_Cli.Text = dr("nome_cli")
                CodCLI.Text = dr("cod_cli")
                txtcod_alu.Text = dr("cod_aluguel")
                diacombinado = dr("data_entrega_aluguel")
                Dim lol As String = diacombinado.Date.Subtract(txt_dataalu.Text).TotalDays
                txt_jurostotal.Text = Val(Today.Date.Subtract(diacombinado.Date).TotalDays) * Val(txt_juros.Text)
                txttotal.Text = lol * Val(v_diaria.Text)
                If Val(txt_jurostotal.Text) < 0 Then
                    txt_jurostotal.Text = "0"
                Else
                    txttotal.Text = Val(txt_jurostotal.Text) + Val(txttotal.Text)
                End If
            End If
            txtcod_alu.ReadOnly = True
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Visible = False
        Aluguel.Visible = True

        Dim Controle As New Control
        For Each Controle In Me.Controls
            If TypeOf Controle Is TextBox Or TypeOf Controle Is ComboBox Then
                Controle.Text = ""
            End If
        Next

    End Sub

    Private Sub efetuar_aluguel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles efetuar_aluguel.Click

        Dim comando2 As OleDbCommand
        Dim temp As Single
        Dim vtemp As Single
        Dim cmd_cli As OleDbCommand
        Dim dr As OleDbDataReader
        Dim comando As OleDbCommand

        'Atualizacao de saldo do cliente
        AbrirBD()

        cmd_cli = New OleDbCommand("select saldo_cli from clientes where cod_cli=@codcli", Conexao)
        cmd_cli.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
        cmd_cli.Parameters("@codcli").Value = Me.CodCLI.Text
        dr = cmd_cli.ExecuteReader
        If dr.Read Then
            temp = Val(dr("saldo_cli") - (txttotal.Text))
        End If
        dr.Close()
        status.Panels.Item(0).Text = "Saldo atual de " & cb_Cli.Text & " R$ " & temp


        If (temp > 0) Then
            comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
            comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
            comando2.Parameters("@saldo").Value = temp
            comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
            comando2.Parameters("@situacao").Value = "A receber"
            comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
            comando2.Parameters("@codcli").Value = Me.CodCLI.Text
        Else
            If (temp = 0) Then
                comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                comando2.Parameters("@saldo").Value = temp
                comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                comando2.Parameters("@situacao").Value = "Normal"
                comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                comando2.Parameters("@codcli").Value = Me.CodCLI.Text
            Else
                comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                comando2.Parameters("@saldo").Value = temp
                comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                comando2.Parameters("@situacao").Value = "A pagar"
                comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                comando2.Parameters("@codcli").Value = Me.CodCLI.Text
            End If
            comando2.ExecuteNonQuery()
        End If
        FecharBD()

        'Atualização do estado do aluguel
        comando = New OleDbCommand("update alugueis set situacao_alu='D - Devolvido' where cod_aluguel=" & Me.txtcod_alu.Text.ToString, Conexao)
        Try
            AbrirBD()
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try


        ' Atualização do estado do veículo
        AbrirBD()
        comando = New OleDbCommand("Update veiculos_alu set estado_vei='D - Disponivel' where cod_vei=" & Me.txt_cod_vei.Text.ToString, Conexao)
        Try
            comando.ExecuteNonQuery()
            MsgBox("Devolução cadastrada", MsgBoxStyle.Exclamation, "Devolução de veículos")
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try

        Dim Controle As New Control
        For Each Controle In Me.Controls
            If TypeOf Controle Is TextBox Or TypeOf Controle Is ComboBox Then
                Controle.Text = ""
            End If
        Next
    End Sub
End Class
