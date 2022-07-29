Imports ProjetoConcessionária.Module1
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Public Class veiculos_venda
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
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents CBAC As System.Windows.Forms.CheckBox
    Friend WithEvents CBDH As System.Windows.Forms.CheckBox
    Friend WithEvents CBTE As System.Windows.Forms.CheckBox
    Friend WithEvents CBVE As System.Windows.Forms.CheckBox
    Friend WithEvents CBDVD As System.Windows.Forms.CheckBox
    Friend WithEvents CBSOM As System.Windows.Forms.CheckBox
    Friend WithEvents bot_localizar As System.Windows.Forms.Button
    Friend WithEvents cmbporta As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtchassi As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtcor As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Limpar As System.Windows.Forms.Button
    Friend WithEvents Excluir As System.Windows.Forms.Button
    Friend WithEvents Imprimir As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtval As System.Windows.Forms.TextBox
    Friend WithEvents txtpot As System.Windows.Forms.TextBox
    Friend WithEvents txttipo As System.Windows.Forms.TextBox
    Friend WithEvents txtcomb As System.Windows.Forms.TextBox
    Friend WithEvents txtplaca As System.Windows.Forms.TextBox
    Friend WithEvents txtano As System.Windows.Forms.TextBox
    Friend WithEvents txtvei As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcod_vei As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grpimagem As System.Windows.Forms.GroupBox
    Friend WithEvents Pctemp As System.Windows.Forms.PictureBox
    Friend WithEvents bt_obter As System.Windows.Forms.Button
    Friend WithEvents voltar As System.Windows.Forms.Button
    Friend WithEvents alterar_venda As System.Windows.Forms.Button
    Friend WithEvents cadastro_venda As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents marca_vei As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(veiculos_venda))
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.CBAC = New System.Windows.Forms.CheckBox
        Me.CBDH = New System.Windows.Forms.CheckBox
        Me.CBTE = New System.Windows.Forms.CheckBox
        Me.CBVE = New System.Windows.Forms.CheckBox
        Me.CBDVD = New System.Windows.Forms.CheckBox
        Me.CBSOM = New System.Windows.Forms.CheckBox
        Me.bot_localizar = New System.Windows.Forms.Button
        Me.cmbporta = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtchassi = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtcor = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Limpar = New System.Windows.Forms.Button
        Me.voltar = New System.Windows.Forms.Button
        Me.Excluir = New System.Windows.Forms.Button
        Me.Imprimir = New System.Windows.Forms.Button
        Me.alterar_venda = New System.Windows.Forms.Button
        Me.cadastro_venda = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtval = New System.Windows.Forms.TextBox
        Me.txtpot = New System.Windows.Forms.TextBox
        Me.txttipo = New System.Windows.Forms.TextBox
        Me.txtcomb = New System.Windows.Forms.TextBox
        Me.txtplaca = New System.Windows.Forms.TextBox
        Me.txtano = New System.Windows.Forms.TextBox
        Me.txtvei = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtcod_vei = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.grpimagem = New System.Windows.Forms.GroupBox
        Me.Pctemp = New System.Windows.Forms.PictureBox
        Me.bt_obter = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.marca_vei = New System.Windows.Forms.ComboBox
        Me.GroupBox7.SuspendLayout()
        Me.grpimagem.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.CBAC)
        Me.GroupBox7.Controls.Add(Me.CBDH)
        Me.GroupBox7.Controls.Add(Me.CBTE)
        Me.GroupBox7.Controls.Add(Me.CBVE)
        Me.GroupBox7.Controls.Add(Me.CBDVD)
        Me.GroupBox7.Controls.Add(Me.CBSOM)
        Me.GroupBox7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox7.Location = New System.Drawing.Point(424, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(160, 160)
        Me.GroupBox7.TabIndex = 124
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Acessorios"
        '
        'CBAC
        '
        Me.CBAC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBAC.Location = New System.Drawing.Point(15, 23)
        Me.CBAC.Name = "CBAC"
        Me.CBAC.Size = New System.Drawing.Size(131, 16)
        Me.CBAC.TabIndex = 56
        Me.CBAC.Text = "Ar Condicionado"
        '
        'CBDH
        '
        Me.CBDH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBDH.Location = New System.Drawing.Point(13, 93)
        Me.CBDH.Name = "CBDH"
        Me.CBDH.Size = New System.Drawing.Size(144, 16)
        Me.CBDH.TabIndex = 58
        Me.CBDH.Text = "Direcao Hidraulica"
        '
        'CBTE
        '
        Me.CBTE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTE.Location = New System.Drawing.Point(14, 70)
        Me.CBTE.Name = "CBTE"
        Me.CBTE.Size = New System.Drawing.Size(128, 16)
        Me.CBTE.TabIndex = 55
        Me.CBTE.Text = "Travas Eletrica"
        '
        'CBVE
        '
        Me.CBVE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBVE.Location = New System.Drawing.Point(14, 47)
        Me.CBVE.Name = "CBVE"
        Me.CBVE.Size = New System.Drawing.Size(124, 16)
        Me.CBVE.TabIndex = 59
        Me.CBVE.Text = "Vidros Eletricos"
        '
        'CBDVD
        '
        Me.CBDVD.BackColor = System.Drawing.Color.SlateGray
        Me.CBDVD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBDVD.ForeColor = System.Drawing.Color.Beige
        Me.CBDVD.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.CBDVD.Location = New System.Drawing.Point(13, 111)
        Me.CBDVD.Name = "CBDVD"
        Me.CBDVD.Size = New System.Drawing.Size(96, 24)
        Me.CBDVD.TabIndex = 57
        Me.CBDVD.Text = "DVD"
        '
        'CBSOM
        '
        Me.CBSOM.BackColor = System.Drawing.Color.SlateGray
        Me.CBSOM.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSOM.ForeColor = System.Drawing.Color.Beige
        Me.CBSOM.Location = New System.Drawing.Point(13, 137)
        Me.CBSOM.Name = "CBSOM"
        Me.CBSOM.Size = New System.Drawing.Size(72, 16)
        Me.CBSOM.TabIndex = 54
        Me.CBSOM.Text = "Som"
        '
        'bot_localizar
        '
        Me.bot_localizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bot_localizar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_localizar.Image = CType(resources.GetObject("bot_localizar.Image"), System.Drawing.Image)
        Me.bot_localizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bot_localizar.Location = New System.Drawing.Point(264, 477)
        Me.bot_localizar.Name = "bot_localizar"
        Me.bot_localizar.Size = New System.Drawing.Size(75, 56)
        Me.bot_localizar.TabIndex = 123
        Me.bot_localizar.Text = "Localizar"
        Me.bot_localizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmbporta
        '
        Me.cmbporta.Items.AddRange(New Object() {"2", "4"})
        Me.cmbporta.Location = New System.Drawing.Point(88, 347)
        Me.cmbporta.Name = "cmbporta"
        Me.cmbporta.Size = New System.Drawing.Size(104, 21)
        Me.cmbporta.TabIndex = 109
        Me.cmbporta.Text = "Selecionar"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Beige
        Me.Label14.Location = New System.Drawing.Point(24, 347)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 31)
        Me.Label14.TabIndex = 122
        Me.Label14.Text = "Portas"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtchassi
        '
        Me.txtchassi.AccessibleName = "R$"
        Me.txtchassi.Location = New System.Drawing.Point(88, 381)
        Me.txtchassi.Name = "txtchassi"
        Me.txtchassi.TabIndex = 111
        Me.txtchassi.Text = ""
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Beige
        Me.Label13.Location = New System.Drawing.Point(24, 381)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 24)
        Me.Label13.TabIndex = 120
        Me.Label13.Text = "Chassi"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcor
        '
        Me.txtcor.Location = New System.Drawing.Point(88, 312)
        Me.txtcor.Name = "txtcor"
        Me.txtcor.TabIndex = 108
        Me.txtcor.Text = ""
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Beige
        Me.Label12.Location = New System.Drawing.Point(40, 312)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 23)
        Me.Label12.TabIndex = 119
        Me.Label12.Text = "Cor"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Limpar
        '
        Me.Limpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Limpar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpar.Image = CType(resources.GetObject("Limpar.Image"), System.Drawing.Image)
        Me.Limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Limpar.Location = New System.Drawing.Point(88, 477)
        Me.Limpar.Name = "Limpar"
        Me.Limpar.Size = New System.Drawing.Size(80, 56)
        Me.Limpar.TabIndex = 114
        Me.Limpar.Text = "Limpar"
        Me.Limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'voltar
        '
        Me.voltar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.voltar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voltar.Image = CType(resources.GetObject("voltar.Image"), System.Drawing.Image)
        Me.voltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.voltar.Location = New System.Drawing.Point(512, 477)
        Me.voltar.Name = "voltar"
        Me.voltar.Size = New System.Drawing.Size(80, 56)
        Me.voltar.TabIndex = 118
        Me.voltar.Text = "Voltar"
        Me.voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Excluir
        '
        Me.Excluir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Excluir.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.Location = New System.Drawing.Point(424, 477)
        Me.Excluir.Name = "Excluir"
        Me.Excluir.Size = New System.Drawing.Size(80, 56)
        Me.Excluir.TabIndex = 117
        Me.Excluir.Text = "Excluir"
        Me.Excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Imprimir
        '
        Me.Imprimir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Imprimir.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Image)
        Me.Imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Imprimir.Location = New System.Drawing.Point(344, 477)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(75, 56)
        Me.Imprimir.TabIndex = 116
        Me.Imprimir.Text = "Imprimir"
        Me.Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'alterar_venda
        '
        Me.alterar_venda.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.alterar_venda.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alterar_venda.Image = CType(resources.GetObject("alterar_venda.Image"), System.Drawing.Image)
        Me.alterar_venda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.alterar_venda.Location = New System.Drawing.Point(176, 477)
        Me.alterar_venda.Name = "alterar_venda"
        Me.alterar_venda.Size = New System.Drawing.Size(80, 56)
        Me.alterar_venda.TabIndex = 115
        Me.alterar_venda.Text = "Alterar"
        Me.alterar_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cadastro_venda
        '
        Me.cadastro_venda.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cadastro_venda.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadastro_venda.Image = CType(resources.GetObject("cadastro_venda.Image"), System.Drawing.Image)
        Me.cadastro_venda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cadastro_venda.Location = New System.Drawing.Point(8, 477)
        Me.cadastro_venda.Name = "cadastro_venda"
        Me.cadastro_venda.Size = New System.Drawing.Size(75, 56)
        Me.cadastro_venda.TabIndex = 113
        Me.cadastro_venda.Text = "Efetuar Cadastro"
        Me.cadastro_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(0, 468)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(600, 73)
        Me.Label10.TabIndex = 110
        '
        'txtval
        '
        Me.txtval.AccessibleName = "R$"
        Me.txtval.Location = New System.Drawing.Point(88, 416)
        Me.txtval.Name = "txtval"
        Me.txtval.TabIndex = 112
        Me.txtval.Text = ""
        '
        'txtpot
        '
        Me.txtpot.Location = New System.Drawing.Point(88, 277)
        Me.txtpot.Name = "txtpot"
        Me.txtpot.TabIndex = 107
        Me.txtpot.Text = ""
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(88, 243)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.TabIndex = 106
        Me.txttipo.Text = ""
        '
        'txtcomb
        '
        Me.txtcomb.Location = New System.Drawing.Point(88, 208)
        Me.txtcomb.Name = "txtcomb"
        Me.txtcomb.TabIndex = 104
        Me.txtcomb.Text = ""
        '
        'txtplaca
        '
        Me.txtplaca.Location = New System.Drawing.Point(88, 173)
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.TabIndex = 103
        Me.txtplaca.Text = ""
        '
        'txtano
        '
        Me.txtano.Location = New System.Drawing.Point(88, 139)
        Me.txtano.Name = "txtano"
        Me.txtano.TabIndex = 102
        Me.txtano.Text = ""
        '
        'txtvei
        '
        Me.txtvei.Location = New System.Drawing.Point(88, 104)
        Me.txtvei.Name = "txtvei"
        Me.txtvei.Size = New System.Drawing.Size(312, 20)
        Me.txtvei.TabIndex = 101
        Me.txtvei.Text = ""
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Beige
        Me.Label9.Location = New System.Drawing.Point(8, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 24)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Potencia"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Beige
        Me.Label8.Location = New System.Drawing.Point(32, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 22)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Tipo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Beige
        Me.Label5.Location = New System.Drawing.Point(0, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 23)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Combustivel"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Beige
        Me.Label4.Location = New System.Drawing.Point(24, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Placa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Beige
        Me.Label2.Location = New System.Drawing.Point(32, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 22)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Ano"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(16, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Veiculo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcod_vei
        '
        Me.txtcod_vei.Enabled = False
        Me.txtcod_vei.Location = New System.Drawing.Point(88, 69)
        Me.txtcod_vei.Name = "txtcod_vei"
        Me.txtcod_vei.ReadOnly = True
        Me.txtcod_vei.Size = New System.Drawing.Size(80, 20)
        Me.txtcod_vei.TabIndex = 91
        Me.txtcod_vei.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(328, 40)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Cadastrar Veículo"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Beige
        Me.Label16.Location = New System.Drawing.Point(16, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 23)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "Codigo"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Beige
        Me.Label7.Location = New System.Drawing.Point(-8, 416)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 31)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Preco"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpimagem
        '
        Me.grpimagem.Controls.Add(Me.Pctemp)
        Me.grpimagem.Controls.Add(Me.bt_obter)
        Me.grpimagem.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grpimagem.ForeColor = System.Drawing.Color.Beige
        Me.grpimagem.Location = New System.Drawing.Point(208, 156)
        Me.grpimagem.Name = "grpimagem"
        Me.grpimagem.Size = New System.Drawing.Size(384, 304)
        Me.grpimagem.TabIndex = 121
        Me.grpimagem.TabStop = False
        Me.grpimagem.Text = "Imagem"
        '
        'Pctemp
        '
        Me.Pctemp.Location = New System.Drawing.Point(16, 24)
        Me.Pctemp.Name = "Pctemp"
        Me.Pctemp.Size = New System.Drawing.Size(352, 240)
        Me.Pctemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctemp.TabIndex = 85
        Me.Pctemp.TabStop = False
        '
        'bt_obter
        '
        Me.bt_obter.Location = New System.Drawing.Point(128, 272)
        Me.bt_obter.Name = "bt_obter"
        Me.bt_obter.Size = New System.Drawing.Size(120, 23)
        Me.bt_obter.TabIndex = 83
        Me.bt_obter.Text = "Obter Imagem"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Beige
        Me.Label6.Location = New System.Drawing.Point(200, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 23)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "Marca"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'marca_vei
        '
        Me.marca_vei.Location = New System.Drawing.Point(280, 69)
        Me.marca_vei.Name = "marca_vei"
        Me.marca_vei.Size = New System.Drawing.Size(121, 21)
        Me.marca_vei.TabIndex = 127
        '
        'veiculos_venda
        '
        Me.AcceptButton = Me.cadastro_venda
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.CancelButton = Me.voltar
        Me.ClientSize = New System.Drawing.Size(600, 543)
        Me.Controls.Add(Me.marca_vei)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.bot_localizar)
        Me.Controls.Add(Me.cmbporta)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtchassi)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtcor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Limpar)
        Me.Controls.Add(Me.voltar)
        Me.Controls.Add(Me.Excluir)
        Me.Controls.Add(Me.Imprimir)
        Me.Controls.Add(Me.alterar_venda)
        Me.Controls.Add(Me.cadastro_venda)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtval)
        Me.Controls.Add(Me.txtpot)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.txtcomb)
        Me.Controls.Add(Me.txtplaca)
        Me.Controls.Add(Me.txtano)
        Me.Controls.Add(Me.txtvei)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcod_vei)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.grpimagem)
        Me.Name = "veiculos_venda"
        Me.ShowInTaskbar = False
        Me.Text = "Venda de Veiculos"
        Me.GroupBox7.ResumeLayout(False)
        Me.grpimagem.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cadastro_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadastro_venda.Click
        Dim ac As String
        Dim DH As String
        Dim som As String
        Dim dvd As String
        Dim VE As String
        Dim TE As String

        If CBSOM.CheckState = CheckState.Checked Then
            som = "true,"
        Else
            som = "false,"
        End If
        If CBAC.CheckState = CheckState.Checked Then
            ac = "true,"
        Else
            ac = "false,"
        End If
        If CBDH.CheckState = CheckState.Checked Then
            DH = "true,"
        Else
            DH = "false,"
        End If
        If CBDVD.CheckState = CheckState.Checked Then
            dvd = "true,"
        Else
            dvd = "false,"
        End If
        If CBVE.CheckState = CheckState.Checked Then
            VE = "true,"
        Else
            VE = "false,"
        End If
        If CBTE.CheckState = CheckState.Checked Then
            TE = "true"
        Else
            TE = "false"
        End If

        If txtvei.Text = "" Or txtano.Text = "" Or txtplaca.Text = "" Or txttipo.Text = "" Or txtpot.Text = "" Or txtval.Text = "" Then
            MessageBox.Show("Todos os campos devem ser preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim comando As OleDbCommand
            AbrirBD()
            comando = New OleDbCommand("insert into veiculos_venda (nome_vei,marca_vei,ano_vei,placa_vei,comb_vei,tipo_vei,pot_vei,preco_vei,cor_vei,chassi_vei,porta_vei,ar_vei,direcao_vei,som_vei,dvd_vei,vidro_vei,trava_vei) values (@nome,@marca,@ano,@placa,@comb,@tipo,@pot,@preco_vei,@cor,@chassi,@porta," & ac & DH & som & dvd & VE & TE & ")", Conexao)

            With comando
                .Parameters.Add(New OleDbParameter("@nome", OleDbType.VarChar, 50))
                .Parameters("@nome").Value = txtvei.Text.ToString
                .Parameters.Add(New OleDbParameter("@marca", OleDbType.VarChar, 50))
                .Parameters("@marca").Value = marca_vei.Text.ToString
                .Parameters.Add(New OleDbParameter("@ano", OleDbType.VarChar, 50))
                .Parameters("@ano").Value = txtano.Text.ToString
                .Parameters.Add(New OleDbParameter("@placa", OleDbType.VarChar, 50))
                .Parameters("@placa").Value = txtplaca.Text.ToString
                .Parameters.Add(New OleDbParameter("@comb", OleDbType.VarChar, 50))
                .Parameters("@comb").Value = txtcomb.Text.ToString
                .Parameters.Add(New OleDbParameter("@tipo", OleDbType.VarChar, 50))
                .Parameters("@tipo").Value = txttipo.Text.ToString
                .Parameters.Add(New OleDbParameter("@pot", OleDbType.VarChar, 50))
                .Parameters("@pot").Value = txtpot.Text.ToString
                .Parameters.Add(New OleDbParameter("@preco_vei", OleDbType.VarChar, 50))
                .Parameters("@preco_vei").Value = txtval.Text.ToString
                .Parameters.Add(New OleDbParameter("@cor", OleDbType.VarChar, 50))
                .Parameters("@cor").Value = txtcor.Text.ToString
                .Parameters.Add(New OleDbParameter("@chassi", OleDbType.VarChar, 50))
                .Parameters("@chassi").Value = txtchassi.Text.ToString
                .Parameters.Add(New OleDbParameter("@porta", OleDbType.VarChar, 50))
                .Parameters("@porta").Value = cmbporta.Text.ToString
                '.Parameters.Add(New OleDbParameter("@image", OleDbType.VarChar, 50))
                '.Parameters("@image").Value = CamImagem.ToString
            End With
            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("Registro cadastrado", "Inclusao de Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Erro")
            Finally
                FecharBD()
            End Try
        End If

    End Sub

    Private Sub Limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpar.Click
        Dim Controle As New Control
        For Each Controle In Me.Controls
            If TypeOf Controle Is TextBox Or TypeOf Controle Is ComboBox Then
                Controle.Text = ""
            End If
        Next

        CBSOM.CheckState = CheckState.Unchecked
        CBAC.CheckState = CheckState.Unchecked
        CBDH.CheckState = CheckState.Unchecked
        CBDVD.CheckState = CheckState.Unchecked
        CBVE.CheckState = CheckState.Unchecked
        CBTE.CheckState = CheckState.Unchecked

    End Sub

    Private Sub voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles voltar.Click
        Me.Close()
    End Sub

    Private Sub Excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Excluir.Click
        Dim Comando As OleDbCommand
        AbrirBD()
        Comando = New OleDbCommand("delete from veiculos_venda where cod_vei=@cod", Conexao)
        Comando.Parameters.Add(New OleDbParameter("@cod", OleDbType.Integer, 50))
        Comando.Parameters("@cod").Value = Me.txtcod_vei.Text.ToString
        If MessageBox.Show("Deseja realmente deletar?", "Apagar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Comando.ExecuteNonQuery()
                MessageBox.Show("Registro apagado", "Apagar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim Controle As New Control
                For Each Controle In Me.Controls
                    If TypeOf Controle Is TextBox Or TypeOf Controle Is ComboBox Then
                        Controle.Text = ""
                    End If
                    CBSOM.CheckState = CheckState.Unchecked
                    CBAC.CheckState = CheckState.Unchecked
                    CBDH.CheckState = CheckState.Unchecked
                    CBDVD.CheckState = CheckState.Unchecked
                    CBVE.CheckState = CheckState.Unchecked
                    CBTE.CheckState = CheckState.Unchecked

                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Apagar Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        FecharBD()

        locvei.lstvei.Items.Clear()
    End Sub

    Private Sub alterar_vend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alterar_venda.Click
        Dim ac As String
        Dim DH As String
        Dim som As String
        Dim dvd As String
        Dim VE As String
        Dim TE As String

        If CBSOM.CheckState = CheckState.Checked Then
            som = "true,"
        Else
            som = "false,"
        End If
        If CBAC.CheckState = CheckState.Checked Then
            ac = "true,"
        Else
            ac = "false,"
        End If
        If CBDH.CheckState = CheckState.Checked Then
            DH = "true,"
        Else
            DH = "false,"
        End If
        If CBDVD.CheckState = CheckState.Checked Then
            dvd = "true,"
        Else
            dvd = "false,"
        End If
        If CBVE.CheckState = CheckState.Checked Then
            VE = "true,"
        Else
            VE = "false,"
        End If
        If CBTE.CheckState = CheckState.Checked Then
            TE = "true"
        Else
            TE = "false"
        End If

        AbrirBD()
        Dim comando As New OleDbCommand
        comando = New OleDbCommand("Update veiculos_venda set nome_vei=@nome,marca_vei=@marca,ano_vei=@ano,placa_vei=@placa,comb_vei=@comb,tipo_vei=@tipo,pot_vei=@pot,preco_vei=@preco,cor_vei=@cor,chassi_vei=@chassi,porta_vei=@porta,ar_vei=" & ac & "direcao_vei=" & DH & "som_vei=" & som & "dvd_vei=" & dvd & "vidro_vei=" & VE & "trava_vei=" & TE & " where cod_vei=@codvei", Conexao)
        With comando
            .Parameters.Add(New OleDbParameter("@nome", OleDbType.VarChar, 50))
            .Parameters("@nome").Value = txtvei.Text.ToString
            .Parameters.Add(New OleDbParameter("@marca", OleDbType.VarChar, 50))
            .Parameters("@marca").Value = marca_vei.Text.ToString
            .Parameters.Add(New OleDbParameter("@ano", OleDbType.VarChar, 50))
            .Parameters("@ano").Value = txtano.Text.ToString
            .Parameters.Add(New OleDbParameter("@placa", OleDbType.VarChar, 50))
            .Parameters("@placa").Value = txtplaca.Text.ToString
            .Parameters.Add(New OleDbParameter("@comb", OleDbType.VarChar, 50))
            .Parameters("@comb").Value = txtcomb.Text.ToString
            .Parameters.Add(New OleDbParameter("@tipo", OleDbType.VarChar, 50))
            .Parameters("@tipo").Value = txttipo.Text.ToString
            .Parameters.Add(New OleDbParameter("@pot", OleDbType.VarChar, 50))
            .Parameters("@pot").Value = txtpot.Text.ToString
            .Parameters.Add(New OleDbParameter("@preco", OleDbType.VarChar, 50))
            .Parameters("@preco").Value = txtval.Text.ToString
            .Parameters.Add(New OleDbParameter("@cor", OleDbType.VarChar, 50))
            .Parameters("@cor").Value = txtcor.Text.ToString
            .Parameters.Add(New OleDbParameter("@chassi", OleDbType.VarChar, 50))
            .Parameters("@chassi").Value = txtchassi.Text.ToString
            .Parameters.Add(New OleDbParameter("@porta", OleDbType.VarChar, 50))
            .Parameters("@porta").Value = cmbporta.Text.ToString
            .Parameters.Add(New OleDbParameter("@codvei", OleDbType.VarChar, 50))
            .Parameters("@codvei").Value = txtcod_vei.Text
        End With
        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Dados alterados", "Alteração de registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub bot_localizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot_localizar.Click
        locvei_venda.ShowDialog()
    End Sub

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click

    End Sub

    Private Sub veiculos_venda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader

        Comando = New OleDbCommand("select * from veiculos_venda order by marca_vei", Conexao)
        AbrirBD()
        DR = Comando.ExecuteReader
        While DR.Read
            marca_vei.Items.Add(DR("marca_vei"))
        End While
        FecharBD()
    End Sub
End Class
