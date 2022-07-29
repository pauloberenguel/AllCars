Imports System.Data.OleDb



Public Class efetua_aluguel
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_Cli As System.Windows.Forms.ComboBox
    Friend WithEvents CodCLI As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_sit As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pc_thumb As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents placa_vei As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_modelo As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_vei As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents v_diaria As System.Windows.Forms.TextBox
    Friend WithEvents txt_juros As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cb_print As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents dia_entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents efetuar_aluguel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(efetua_aluguel))
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cb_Cli = New System.Windows.Forms.ComboBox
        Me.CodCLI = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_sit = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.pc_thumb = New System.Windows.Forms.PictureBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.placa_vei = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_modelo = New System.Windows.Forms.TextBox
        Me.txt_cod_vei = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.v_diaria = New System.Windows.Forms.TextBox
        Me.txt_juros = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cb_print = New System.Windows.Forms.Button
        Me.efetuar_aluguel = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.dia_entrega = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(344, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 285
        Me.Label4.Text = "Voltar"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(232, 303)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 18)
        Me.Label12.TabIndex = 284
        Me.Label12.Text = "Imprimir"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(112, 303)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 18)
        Me.Label13.TabIndex = 283
        Me.Label13.Text = "Efetua Aluguel"
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
        Me.Button7.Location = New System.Drawing.Point(336, 243)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 60)
        Me.Button7.TabIndex = 281
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_Cli)
        Me.GroupBox2.Controls.Add(Me.CodCLI)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox2.Location = New System.Drawing.Point(272, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 78)
        Me.GroupBox2.TabIndex = 276
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'cb_Cli
        '
        Me.cb_Cli.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.cb_Cli.Location = New System.Drawing.Point(64, 17)
        Me.cb_Cli.Name = "cb_Cli"
        Me.cb_Cli.Size = New System.Drawing.Size(136, 20)
        Me.cb_Cli.TabIndex = 80
        '
        'CodCLI
        '
        Me.CodCLI.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.HelpProvider1.SetHelpNavigator(Me.CodCLI, System.Windows.Forms.HelpNavigator.Index)
        Me.HelpProvider1.SetHelpString(Me.CodCLI, "Digite o codigo do cliente")
        Me.CodCLI.Location = New System.Drawing.Point(128, 52)
        Me.CodCLI.Name = "CodCLI"
        Me.CodCLI.ReadOnly = True
        Me.HelpProvider1.SetShowHelp(Me.CodCLI, True)
        Me.CodCLI.Size = New System.Drawing.Size(72, 19)
        Me.CodCLI.TabIndex = 4
        Me.CodCLI.Text = "Cod. Cliente"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Beige
        Me.Label11.Location = New System.Drawing.Point(8, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 17)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Nome"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_sit)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.pc_thumb)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.placa_vei)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_modelo)
        Me.GroupBox1.Controls.Add(Me.txt_cod_vei)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.v_diaria)
        Me.GroupBox1.Controls.Add(Me.txt_juros)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox1.Location = New System.Drawing.Point(0, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 164)
        Me.GroupBox1.TabIndex = 275
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veículo"
        '
        'txt_sit
        '
        Me.txt_sit.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.HelpProvider1.SetHelpString(Me.txt_sit, "")
        Me.txt_sit.Location = New System.Drawing.Point(200, 52)
        Me.txt_sit.Name = "txt_sit"
        Me.txt_sit.ReadOnly = True
        Me.HelpProvider1.SetShowHelp(Me.txt_sit, True)
        Me.txt_sit.Size = New System.Drawing.Size(64, 19)
        Me.txt_sit.TabIndex = 79
        Me.txt_sit.Text = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Beige
        Me.Label10.Location = New System.Drawing.Point(176, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 17)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Miniatura"
        '
        'pc_thumb
        '
        Me.pc_thumb.Location = New System.Drawing.Point(176, 95)
        Me.pc_thumb.Name = "pc_thumb"
        Me.pc_thumb.Size = New System.Drawing.Size(86, 61)
        Me.pc_thumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pc_thumb.TabIndex = 77
        Me.pc_thumb.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Beige
        Me.Label9.Location = New System.Drawing.Point(8, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 34)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Juros(p/dia)"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Beige
        Me.Label2.Location = New System.Drawing.Point(8, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Placa"
        '
        'placa_vei
        '
        Me.placa_vei.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.HelpProvider1.SetHelpString(Me.placa_vei, "Digite o codigo do veiculo")
        Me.placa_vei.Location = New System.Drawing.Point(72, 52)
        Me.placa_vei.Name = "placa_vei"
        Me.placa_vei.ReadOnly = True
        Me.HelpProvider1.SetShowHelp(Me.placa_vei, True)
        Me.placa_vei.Size = New System.Drawing.Size(56, 19)
        Me.placa_vei.TabIndex = 5
        Me.placa_vei.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(8, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Modelo"
        '
        'txt_modelo
        '
        Me.txt_modelo.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.txt_modelo.Location = New System.Drawing.Point(72, 87)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.ReadOnly = True
        Me.txt_modelo.Size = New System.Drawing.Size(88, 19)
        Me.txt_modelo.TabIndex = 73
        Me.txt_modelo.Text = ""
        '
        'txt_cod_vei
        '
        Me.txt_cod_vei.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.HelpProvider1.SetHelpNavigator(Me.txt_cod_vei, System.Windows.Forms.HelpNavigator.Index)
        Me.HelpProvider1.SetHelpString(Me.txt_cod_vei, "Digite o codigo do cliente")
        Me.txt_cod_vei.Location = New System.Drawing.Point(192, 9)
        Me.txt_cod_vei.Name = "txt_cod_vei"
        Me.txt_cod_vei.ReadOnly = True
        Me.HelpProvider1.SetShowHelp(Me.txt_cod_vei, True)
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
        Me.txt_juros.Location = New System.Drawing.Point(72, 121)
        Me.txt_juros.Name = "txt_juros"
        Me.txt_juros.Size = New System.Drawing.Size(88, 19)
        Me.txt_juros.TabIndex = 76
        Me.txt_juros.Text = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Beige
        Me.Label8.Location = New System.Drawing.Point(136, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 17)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Situação"
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
        Me.cb_print.Location = New System.Drawing.Point(232, 243)
        Me.cb_print.Name = "cb_print"
        Me.cb_print.Size = New System.Drawing.Size(56, 60)
        Me.cb_print.TabIndex = 280
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
        Me.efetuar_aluguel.Location = New System.Drawing.Point(128, 243)
        Me.efetuar_aluguel.Name = "efetuar_aluguel"
        Me.efetuar_aluguel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.efetuar_aluguel.Size = New System.Drawing.Size(56, 60)
        Me.efetuar_aluguel.TabIndex = 279
        Me.efetuar_aluguel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(104, 234)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(304, 87)
        Me.Label20.TabIndex = 282
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Aqua
        Me.LinkLabel2.Location = New System.Drawing.Point(384, 43)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(96, 18)
        Me.LinkLabel2.TabIndex = 278
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Buscar Cliente"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Aqua
        Me.LinkLabel1.Location = New System.Drawing.Point(168, 43)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(96, 18)
        Me.LinkLabel1.TabIndex = 277
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Buscar Veículo"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Beige
        Me.Label3.Location = New System.Drawing.Point(272, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 26)
        Me.Label3.TabIndex = 270
        Me.Label3.Text = "Ficará com o carro até dia:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(296, 43)
        Me.Label7.TabIndex = 274
        Me.Label7.Text = "Efetuar Aluguéis"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(360, 199)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.TabIndex = 272
        Me.txttotal.Text = ""
        '
        'dia_entrega
        '
        Me.dia_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dia_entrega.Location = New System.Drawing.Point(368, 156)
        Me.dia_entrega.Name = "dia_entrega"
        Me.dia_entrega.Size = New System.Drawing.Size(112, 20)
        Me.dia_entrega.TabIndex = 271
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Beige
        Me.Label6.Location = New System.Drawing.Point(272, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 26)
        Me.Label6.TabIndex = 273
        Me.Label6.Text = "Total (Estimado)"
        '
        'efetua_aluguel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(488, 327)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cb_print)
        Me.Controls.Add(Me.efetuar_aluguel)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.dia_entrega)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "efetua_aluguel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Efetuar Aluguéis"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        locvei.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        loccli.ShowDialog()
    End Sub

    Private Sub v_diaria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v_diaria.TextChanged
        txt_juros.Text = Val(v_diaria.Text) * 0.05

    End Sub

    Private Sub frmaluguel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dia_entrega.MinDate = Now.Today
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        comando = New OleDbCommand("select nome_cli from clientes order by nome_cli", Conexao)
        AbrirBD()
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                cb_Cli.Items.Add(DR("nome_cli"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub dia_entrega_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dia_entrega.ValueChanged
        Dim lol As String
        lol = dia_entrega.Value.Date.Subtract(Now.Today.Date.ToShortDateString).TotalDays
        txttotal.Text = lol * Val(v_diaria.Text)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Dim Controle As New Control
        For Each Controle In Me.Controls
            If TypeOf Controle Is TextBox Or TypeOf Controle Is ComboBox Then
                Controle.Text = ""
            End If
        Next

        Me.Visible = False
        Aluguel.Visible = True
    End Sub

    Private Sub efetuar_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles efetuar_aluguel.Click

        If txt_sit.Text = "A - Alugado" Then
            MsgBox("Este veículo já esta alugado", MsgBoxStyle.OKOnly, "Escolha outro veiculo")
            Exit Sub
        End If

        Dim Command As OleDbCommand
        Command = New OleDbCommand("insert into alugueis(cod_vei,modelo_vei,nome_cli,cod_cli,data_aluguel,data_entrega_aluguel,juros_dia_aluguel,situacao_alu,vdiaria_vei,placa_vei) values (@codvei,@modvei,@nomecli,@codcli,@dataluguel,@datentregaluguel,@juros_dia_aluguel,@situacao_vei,@vdiaria_vei,@placa_vei)", Conexao)
        With Command
            .Parameters.Add(New OleDbParameter("@codvei", OleDbType.VarChar, 250))
            .Parameters("@codvei").Value = txt_cod_vei.Text.ToString
 
            .Parameters.Add(New OleDbParameter("@modvei", OleDbType.VarChar, 250))
            .Parameters("@modvei").Value = txt_modelo.Text.ToString

            .Parameters.Add(New OleDbParameter("@nomecli", OleDbType.VarChar, 250))
            .Parameters("@nomecli").Value = cb_Cli.Text.ToString

            .Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 250))
            .Parameters("@codcli").Value = CodCLI.Text.ToString

            .Parameters.Add(New OleDbParameter("@dataluguel", OleDbType.VarChar, 250))
            .Parameters("@dataluguel").Value = Now.Today.Date.ToShortDateString

            .Parameters.Add(New OleDbParameter("@datentregaluguel", OleDbType.VarChar, 250))
            .Parameters("@datentregaluguel").Value = dia_entrega.Value.Date.ToShortDateString

            .Parameters.Add(New OleDbParameter("@juros_dia_aluguel", OleDbType.VarChar, 250))
            .Parameters("@juros_dia_aluguel").Value = txt_juros.Text.ToString

            .Parameters.Add(New OleDbParameter("@situacao_vei", OleDbType.VarChar, 250))
            .Parameters("@situacao_vei").Value = "A - Alugado"

            .Parameters.Add(New OleDbParameter("@vdiaria_vei", OleDbType.VarChar, 250))
            .Parameters("@vdiaria_vei").Value = v_diaria.Text

            .Parameters.Add(New OleDbParameter("@placa_vei", OleDbType.VarChar, 250))
            .Parameters("@placa_vei").Value = placa_vei.Text.ToString

        End With
        Try
            AbrirBD()
            Command.ExecuteNonQuery()
            MsgBox("Aluguel registrado", MsgBoxStyle.OKOnly, "Registro de aluguéis")
        Catch ex As Exception
            MsgBox("", MsgBoxStyle.Critical, "Erro")
        Finally
            FecharBD()
        End Try

    End Sub



    Private Sub cb_Cli_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Cli.Leave
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Comando = New OleDbCommand("select cod_cli from clientes where nome_cli='" & cb_Cli.Text.ToString & "'", Conexao)
        AbrirBD()
        Try
            DR = Comando.ExecuteReader
            If DR.Read Then
                CodCLI.Text = DR("cod_cli")
            End If
            DR.Close()
        Catch ex As Exception
        End Try
        FecharBD()
    End Sub
End Class
