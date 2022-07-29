Imports AllCars.Module1
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
    Friend WithEvents grpimagem As System.Windows.Forms.GroupBox
    Friend WithEvents Pctemp As System.Windows.Forms.PictureBox
    Friend WithEvents bt_obter As System.Windows.Forms.Button
    Friend WithEvents cb_ano As System.Windows.Forms.ComboBox
    Friend WithEvents cb_cor As System.Windows.Forms.ComboBox
    Friend WithEvents cb_comb As System.Windows.Forms.ComboBox
    Friend WithEvents cb_versao As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents marca_vei As System.Windows.Forms.ComboBox
    Friend WithEvents cmbporta As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Cb_modelo As System.Windows.Forms.ComboBox
    Friend WithEvents txt_vvenda As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtchassi As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cadastro_venda As System.Windows.Forms.Button
    Friend WithEvents txtval As System.Windows.Forms.TextBox
    Friend WithEvents txtplaca As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcod_vei As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_banco As System.Windows.Forms.CheckBox
    Friend WithEvents cb_arquente As System.Windows.Forms.CheckBox
    Friend WithEvents cb_desembaca As System.Windows.Forms.CheckBox
    Friend WithEvents CBAC As System.Windows.Forms.CheckBox
    Friend WithEvents CBDH As System.Windows.Forms.CheckBox
    Friend WithEvents CBDVD As System.Windows.Forms.CheckBox
    Friend WithEvents cb_abd As System.Windows.Forms.CheckBox
    Friend WithEvents cb_alarme As System.Windows.Forms.CheckBox
    Friend WithEvents cb_limpa As System.Windows.Forms.CheckBox
    Friend WithEvents cb_abs As System.Windows.Forms.CheckBox
    Friend WithEvents CBVE As System.Windows.Forms.CheckBox
    Friend WithEvents CBSOM As System.Windows.Forms.CheckBox
    Friend WithEvents cb_teto As System.Windows.Forms.CheckBox
    Friend WithEvents CBTE As System.Windows.Forms.CheckBox
    Friend WithEvents Cb_blindado As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cb_search As System.Windows.Forms.Button
    Friend WithEvents Limpar As System.Windows.Forms.Button
    Friend WithEvents cb_volta As System.Windows.Forms.Button
    Friend WithEvents cb_apaga As System.Windows.Forms.Button
    Friend WithEvents cb_print As System.Windows.Forms.Button
    Friend WithEvents cb_altera As System.Windows.Forms.Button
    Friend WithEvents cb_forn As System.Windows.Forms.ComboBox
    Friend WithEvents txt_codforn As System.Windows.Forms.TextBox
    Friend WithEvents txttipo As System.Windows.Forms.ComboBox
    Friend WithEvents status As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents rb_excluir As System.Windows.Forms.RadioButton
    Friend WithEvents pc_del As System.Windows.Forms.PictureBox
    Friend WithEvents pc_change As System.Windows.Forms.PictureBox
    Friend WithEvents rb_alterar As System.Windows.Forms.RadioButton
    Friend WithEvents txtpot As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(veiculos_venda))
        Me.grpimagem = New System.Windows.Forms.GroupBox
        Me.Pctemp = New System.Windows.Forms.PictureBox
        Me.bt_obter = New System.Windows.Forms.Button
        Me.cb_ano = New System.Windows.Forms.ComboBox
        Me.cb_cor = New System.Windows.Forms.ComboBox
        Me.cb_comb = New System.Windows.Forms.ComboBox
        Me.cb_versao = New System.Windows.Forms.ComboBox
        Me.cb_forn = New System.Windows.Forms.ComboBox
        Me.txt_codforn = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.marca_vei = New System.Windows.Forms.ComboBox
        Me.cb_search = New System.Windows.Forms.Button
        Me.cmbporta = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Cb_modelo = New System.Windows.Forms.ComboBox
        Me.txt_vvenda = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtchassi = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Limpar = New System.Windows.Forms.Button
        Me.cb_volta = New System.Windows.Forms.Button
        Me.cb_apaga = New System.Windows.Forms.Button
        Me.cb_print = New System.Windows.Forms.Button
        Me.cb_altera = New System.Windows.Forms.Button
        Me.cadastro_venda = New System.Windows.Forms.Button
        Me.txtval = New System.Windows.Forms.TextBox
        Me.txtplaca = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtcod_vei = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Cb_banco = New System.Windows.Forms.CheckBox
        Me.cb_arquente = New System.Windows.Forms.CheckBox
        Me.cb_desembaca = New System.Windows.Forms.CheckBox
        Me.CBAC = New System.Windows.Forms.CheckBox
        Me.CBDH = New System.Windows.Forms.CheckBox
        Me.CBDVD = New System.Windows.Forms.CheckBox
        Me.cb_abd = New System.Windows.Forms.CheckBox
        Me.cb_alarme = New System.Windows.Forms.CheckBox
        Me.cb_limpa = New System.Windows.Forms.CheckBox
        Me.cb_abs = New System.Windows.Forms.CheckBox
        Me.CBVE = New System.Windows.Forms.CheckBox
        Me.CBSOM = New System.Windows.Forms.CheckBox
        Me.cb_teto = New System.Windows.Forms.CheckBox
        Me.CBTE = New System.Windows.Forms.CheckBox
        Me.Cb_blindado = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txttipo = New System.Windows.Forms.ComboBox
        Me.status = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.rb_excluir = New System.Windows.Forms.RadioButton
        Me.pc_del = New System.Windows.Forms.PictureBox
        Me.pc_change = New System.Windows.Forms.PictureBox
        Me.rb_alterar = New System.Windows.Forms.RadioButton
        Me.txtpot = New System.Windows.Forms.NumericUpDown
        Me.grpimagem.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpimagem
        '
        Me.grpimagem.Controls.Add(Me.Pctemp)
        Me.grpimagem.Controls.Add(Me.bt_obter)
        Me.grpimagem.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grpimagem.ForeColor = System.Drawing.Color.Beige
        Me.grpimagem.Location = New System.Drawing.Point(408, 269)
        Me.grpimagem.Name = "grpimagem"
        Me.grpimagem.Size = New System.Drawing.Size(384, 294)
        Me.grpimagem.TabIndex = 205
        Me.grpimagem.TabStop = False
        Me.grpimagem.Text = "Foto"
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
        Me.bt_obter.Location = New System.Drawing.Point(128, 265)
        Me.bt_obter.Name = "bt_obter"
        Me.bt_obter.Size = New System.Drawing.Size(120, 23)
        Me.bt_obter.TabIndex = 83
        Me.bt_obter.Text = "Obter Foto"
        '
        'cb_ano
        '
        Me.cb_ano.Location = New System.Drawing.Point(296, 121)
        Me.cb_ano.Name = "cb_ano"
        Me.cb_ano.Size = New System.Drawing.Size(144, 21)
        Me.cb_ano.TabIndex = 4
        '
        'cb_cor
        '
        Me.cb_cor.Items.AddRange(New Object() {"Amarelo", "Azul", "Beje", "Branco", "Cinza", "Dourado", "Indefinida", "Laranja", "Marrom", "Prata", "Preto", "Roxo", "Verde", "Vermelho", "Vinho"})
        Me.cb_cor.Location = New System.Drawing.Point(88, 260)
        Me.cb_cor.Name = "cb_cor"
        Me.cb_cor.Size = New System.Drawing.Size(104, 21)
        Me.cb_cor.TabIndex = 8
        '
        'cb_comb
        '
        Me.cb_comb.Items.AddRange(New Object() {"Alcool", "Alcool e Gas Natural", "Diesel", "Gas Natural", "Gasolina", "Gasolina e Alcool", "Gasolina e Gas Natural", "Gasolina, Alcool e Gas Natural", "Gasolina, Alcool, Gas Natural e Benzina"})
        Me.cb_comb.Location = New System.Drawing.Point(88, 225)
        Me.cb_comb.Name = "cb_comb"
        Me.cb_comb.Size = New System.Drawing.Size(288, 21)
        Me.cb_comb.TabIndex = 7
        '
        'cb_versao
        '
        Me.cb_versao.Location = New System.Drawing.Point(88, 121)
        Me.cb_versao.Name = "cb_versao"
        Me.cb_versao.Size = New System.Drawing.Size(144, 21)
        Me.cb_versao.TabIndex = 3
        '
        'cb_forn
        '
        Me.cb_forn.Location = New System.Drawing.Point(88, 156)
        Me.cb_forn.Name = "cb_forn"
        Me.cb_forn.Size = New System.Drawing.Size(144, 21)
        Me.cb_forn.TabIndex = 5
        '
        'txt_codforn
        '
        Me.txt_codforn.Location = New System.Drawing.Point(344, 156)
        Me.txt_codforn.Name = "txt_codforn"
        Me.txt_codforn.ReadOnly = True
        Me.txt_codforn.Size = New System.Drawing.Size(96, 20)
        Me.txt_codforn.TabIndex = 213
        Me.txt_codforn.Text = ""
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Beige
        Me.Label15.Location = New System.Drawing.Point(232, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 23)
        Me.Label15.TabIndex = 212
        Me.Label15.Text = "Cod. Fornecedor"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'marca_vei
        '
        Me.marca_vei.Location = New System.Drawing.Point(88, 87)
        Me.marca_vei.Name = "marca_vei"
        Me.marca_vei.Size = New System.Drawing.Size(144, 21)
        Me.marca_vei.TabIndex = 1
        '
        'cb_search
        '
        Me.cb_search.BackColor = System.Drawing.Color.White
        Me.cb_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_search.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_search.Image = CType(resources.GetObject("cb_search.Image"), System.Drawing.Image)
        Me.cb_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cb_search.Location = New System.Drawing.Point(16, 511)
        Me.cb_search.Name = "cb_search"
        Me.cb_search.Size = New System.Drawing.Size(168, 49)
        Me.cb_search.TabIndex = 207
        Me.cb_search.Text = "Localizar"
        Me.cb_search.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cmbporta
        '
        Me.cmbporta.Items.AddRange(New Object() {"2", "3", "4"})
        Me.cmbporta.Location = New System.Drawing.Point(328, 191)
        Me.cmbporta.Name = "cmbporta"
        Me.cmbporta.Size = New System.Drawing.Size(48, 21)
        Me.cmbporta.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Beige
        Me.Label14.Location = New System.Drawing.Point(240, 191)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 31)
        Me.Label14.TabIndex = 206
        Me.Label14.Text = "N‹ de Portas"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cb_modelo
        '
        Me.Cb_modelo.Location = New System.Drawing.Point(296, 87)
        Me.Cb_modelo.Name = "Cb_modelo"
        Me.Cb_modelo.Size = New System.Drawing.Size(144, 21)
        Me.Cb_modelo.TabIndex = 2
        '
        'txt_vvenda
        '
        Me.txt_vvenda.Location = New System.Drawing.Point(272, 347)
        Me.txt_vvenda.Name = "txt_vvenda"
        Me.txt_vvenda.TabIndex = 13
        Me.txt_vvenda.Text = ""
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Beige
        Me.Label11.Location = New System.Drawing.Point(8, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 211
        Me.Label11.Text = "Fornecedor"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Beige
        Me.Label6.Location = New System.Drawing.Point(16, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 23)
        Me.Label6.TabIndex = 209
        Me.Label6.Text = "Versão"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtchassi
        '
        Me.txtchassi.AccessibleName = "R$"
        Me.txtchassi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtchassi.Location = New System.Drawing.Point(272, 260)
        Me.txtchassi.MaxLength = 17
        Me.txtchassi.Name = "txtchassi"
        Me.txtchassi.TabIndex = 9
        Me.txtchassi.Text = ""
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Beige
        Me.Label13.Location = New System.Drawing.Point(216, 260)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 24)
        Me.Label13.TabIndex = 204
        Me.Label13.Text = "Chassi"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Beige
        Me.Label12.Location = New System.Drawing.Point(40, 260)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 23)
        Me.Label12.TabIndex = 203
        Me.Label12.Text = "Cor"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Limpar
        '
        Me.Limpar.BackColor = System.Drawing.Color.White
        Me.Limpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Limpar.Font = New System.Drawing.Font("Arial", 10.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Limpar.Image = CType(resources.GetObject("Limpar.Image"), System.Drawing.Image)
        Me.Limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Limpar.Location = New System.Drawing.Point(96, 416)
        Me.Limpar.Name = "Limpar"
        Me.Limpar.Size = New System.Drawing.Size(65, 81)
        Me.Limpar.TabIndex = 198
        Me.Limpar.Text = "Limpar"
        Me.Limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cb_volta
        '
        Me.cb_volta.BackColor = System.Drawing.Color.White
        Me.cb_volta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_volta.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cb_volta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_volta.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_volta.Image = CType(resources.GetObject("cb_volta.Image"), System.Drawing.Image)
        Me.cb_volta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cb_volta.Location = New System.Drawing.Point(336, 416)
        Me.cb_volta.Name = "cb_volta"
        Me.cb_volta.Size = New System.Drawing.Size(65, 81)
        Me.cb_volta.TabIndex = 202
        Me.cb_volta.Text = "Voltar"
        Me.cb_volta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cb_apaga
        '
        Me.cb_apaga.BackColor = System.Drawing.Color.White
        Me.cb_apaga.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_apaga.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_apaga.Font = New System.Drawing.Font("Arial", 10.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.cb_apaga.Image = CType(resources.GetObject("cb_apaga.Image"), System.Drawing.Image)
        Me.cb_apaga.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cb_apaga.Location = New System.Drawing.Point(176, 416)
        Me.cb_apaga.Name = "cb_apaga"
        Me.cb_apaga.Size = New System.Drawing.Size(65, 81)
        Me.cb_apaga.TabIndex = 201
        Me.cb_apaga.Text = "Apagar"
        Me.cb_apaga.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cb_print
        '
        Me.cb_print.BackColor = System.Drawing.Color.White
        Me.cb_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_print.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_print.Image = CType(resources.GetObject("cb_print.Image"), System.Drawing.Image)
        Me.cb_print.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cb_print.Location = New System.Drawing.Point(232, 511)
        Me.cb_print.Name = "cb_print"
        Me.cb_print.Size = New System.Drawing.Size(160, 49)
        Me.cb_print.TabIndex = 200
        Me.cb_print.Text = "Imprimir"
        Me.cb_print.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cb_altera
        '
        Me.cb_altera.BackColor = System.Drawing.Color.White
        Me.cb_altera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_altera.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_altera.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_altera.Image = CType(resources.GetObject("cb_altera.Image"), System.Drawing.Image)
        Me.cb_altera.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.cb_altera.Location = New System.Drawing.Point(256, 416)
        Me.cb_altera.Name = "cb_altera"
        Me.cb_altera.Size = New System.Drawing.Size(65, 81)
        Me.cb_altera.TabIndex = 199
        Me.cb_altera.Text = "Alterar"
        Me.cb_altera.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cadastro_venda
        '
        Me.cadastro_venda.BackColor = System.Drawing.Color.White
        Me.cadastro_venda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cadastro_venda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cadastro_venda.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadastro_venda.Image = CType(resources.GetObject("cadastro_venda.Image"), System.Drawing.Image)
        Me.cadastro_venda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cadastro_venda.Location = New System.Drawing.Point(16, 416)
        Me.cadastro_venda.Name = "cadastro_venda"
        Me.cadastro_venda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cadastro_venda.Size = New System.Drawing.Size(65, 81)
        Me.cadastro_venda.TabIndex = 197
        Me.cadastro_venda.Text = "Salvar"
        Me.cadastro_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtval
        '
        Me.txtval.AccessibleName = "R$"
        Me.txtval.Location = New System.Drawing.Point(272, 303)
        Me.txtval.Name = "txtval"
        Me.txtval.TabIndex = 11
        Me.txtval.Text = ""
        '
        'txtplaca
        '
        Me.txtplaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtplaca.Location = New System.Drawing.Point(88, 329)
        Me.txtplaca.MaxLength = 7
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.TabIndex = 12
        Me.txtplaca.Text = ""
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Beige
        Me.Label9.Location = New System.Drawing.Point(8, 364)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 24)
        Me.Label9.TabIndex = 190
        Me.Label9.Text = "Potência"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Beige
        Me.Label8.Location = New System.Drawing.Point(32, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 22)
        Me.Label8.TabIndex = 189
        Me.Label8.Text = "Tipo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Beige
        Me.Label5.Location = New System.Drawing.Point(0, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 23)
        Me.Label5.TabIndex = 187
        Me.Label5.Text = "Combustivel"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Beige
        Me.Label4.Location = New System.Drawing.Point(16, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 186
        Me.Label4.Text = "Placa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Beige
        Me.Label2.Location = New System.Drawing.Point(240, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 185
        Me.Label2.Text = "Ano"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(240, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 22)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Modelo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcod_vei
        '
        Me.txtcod_vei.Enabled = False
        Me.txtcod_vei.Location = New System.Drawing.Point(152, 52)
        Me.txtcod_vei.Name = "txtcod_vei"
        Me.txtcod_vei.ReadOnly = True
        Me.txtcod_vei.Size = New System.Drawing.Size(80, 20)
        Me.txtcod_vei.TabIndex = 182
        Me.txtcod_vei.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(304, 40)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Comprar Veiculo"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Aqua
        Me.LinkLabel1.Location = New System.Drawing.Point(16, 191)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(128, 17)
        Me.LinkLabel1.TabIndex = 180
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Buscar Fornecedor"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Beige
        Me.Label19.Location = New System.Drawing.Point(16, 87)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 22)
        Me.Label19.TabIndex = 220
        Me.Label19.Text = "Marca"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Beige
        Me.Label17.Location = New System.Drawing.Point(184, 338)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 31)
        Me.Label17.TabIndex = 215
        Me.Label17.Text = "Preço de venda"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.Cb_banco)
        Me.GroupBox7.Controls.Add(Me.cb_arquente)
        Me.GroupBox7.Controls.Add(Me.cb_desembaca)
        Me.GroupBox7.Controls.Add(Me.CBAC)
        Me.GroupBox7.Controls.Add(Me.CBDH)
        Me.GroupBox7.Controls.Add(Me.CBDVD)
        Me.GroupBox7.Controls.Add(Me.cb_abd)
        Me.GroupBox7.Controls.Add(Me.cb_alarme)
        Me.GroupBox7.Controls.Add(Me.cb_limpa)
        Me.GroupBox7.Controls.Add(Me.cb_abs)
        Me.GroupBox7.Controls.Add(Me.CBVE)
        Me.GroupBox7.Controls.Add(Me.CBSOM)
        Me.GroupBox7.Controls.Add(Me.cb_teto)
        Me.GroupBox7.Controls.Add(Me.CBTE)
        Me.GroupBox7.Controls.Add(Me.Cb_blindado)
        Me.GroupBox7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox7.Location = New System.Drawing.Point(464, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(328, 269)
        Me.GroupBox7.TabIndex = 208
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Adicionais"
        '
        'Cb_banco
        '
        Me.Cb_banco.BackColor = System.Drawing.Color.SlateGray
        Me.Cb_banco.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_banco.ForeColor = System.Drawing.Color.Beige
        Me.Cb_banco.Location = New System.Drawing.Point(15, 131)
        Me.Cb_banco.Name = "Cb_banco"
        Me.Cb_banco.Size = New System.Drawing.Size(118, 33)
        Me.Cb_banco.TabIndex = 69
        Me.Cb_banco.Text = "Bancos em couro"
        '
        'cb_arquente
        '
        Me.cb_arquente.BackColor = System.Drawing.Color.SlateGray
        Me.cb_arquente.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_arquente.ForeColor = System.Drawing.Color.Beige
        Me.cb_arquente.Location = New System.Drawing.Point(15, 106)
        Me.cb_arquente.Name = "cb_arquente"
        Me.cb_arquente.Size = New System.Drawing.Size(118, 19)
        Me.cb_arquente.TabIndex = 68
        Me.cb_arquente.Text = "" & Microsoft.VisualBasic.ChrW(9) & "Ar quente"
        '
        'cb_desembaca
        '
        Me.cb_desembaca.BackColor = System.Drawing.Color.SlateGray
        Me.cb_desembaca.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_desembaca.ForeColor = System.Drawing.Color.Beige
        Me.cb_desembaca.Location = New System.Drawing.Point(15, 194)
        Me.cb_desembaca.Name = "cb_desembaca"
        Me.cb_desembaca.Size = New System.Drawing.Size(118, 30)
        Me.cb_desembaca.TabIndex = 61
        Me.cb_desembaca.Text = "Desembaçador Traseiro"
        '
        'CBAC
        '
        Me.CBAC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBAC.Location = New System.Drawing.Point(15, 77)
        Me.CBAC.Name = "CBAC"
        Me.CBAC.Size = New System.Drawing.Size(131, 16)
        Me.CBAC.TabIndex = 56
        Me.CBAC.Text = "Ar Condicionado"
        '
        'CBDH
        '
        Me.CBDH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBDH.Location = New System.Drawing.Point(15, 233)
        Me.CBDH.Name = "CBDH"
        Me.CBDH.Size = New System.Drawing.Size(144, 16)
        Me.CBDH.TabIndex = 58
        Me.CBDH.Text = "Direção Hidráulica"
        '
        'CBDVD
        '
        Me.CBDVD.BackColor = System.Drawing.Color.SlateGray
        Me.CBDVD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBDVD.ForeColor = System.Drawing.Color.Beige
        Me.CBDVD.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.CBDVD.Location = New System.Drawing.Point(170, 17)
        Me.CBDVD.Name = "CBDVD"
        Me.CBDVD.Size = New System.Drawing.Size(96, 25)
        Me.CBDVD.TabIndex = 57
        Me.CBDVD.Text = "DVD"
        '
        'cb_abd
        '
        Me.cb_abd.BackColor = System.Drawing.Color.SlateGray
        Me.cb_abd.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_abd.ForeColor = System.Drawing.Color.Beige
        Me.cb_abd.Location = New System.Drawing.Point(15, 13)
        Me.cb_abd.Name = "cb_abd"
        Me.cb_abd.Size = New System.Drawing.Size(118, 33)
        Me.cb_abd.TabIndex = 66
        Me.cb_abd.Text = "Air bag duplo"
        '
        'cb_alarme
        '
        Me.cb_alarme.BackColor = System.Drawing.Color.SlateGray
        Me.cb_alarme.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_alarme.ForeColor = System.Drawing.Color.Beige
        Me.cb_alarme.Location = New System.Drawing.Point(15, 39)
        Me.cb_alarme.Name = "cb_alarme"
        Me.cb_alarme.Size = New System.Drawing.Size(118, 33)
        Me.cb_alarme.TabIndex = 65
        Me.cb_alarme.Text = "Alarme"
        '
        'cb_limpa
        '
        Me.cb_limpa.BackColor = System.Drawing.Color.SlateGray
        Me.cb_limpa.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_limpa.ForeColor = System.Drawing.Color.Beige
        Me.cb_limpa.Location = New System.Drawing.Point(170, 72)
        Me.cb_limpa.Name = "cb_limpa"
        Me.cb_limpa.Size = New System.Drawing.Size(118, 32)
        Me.cb_limpa.TabIndex = 63
        Me.cb_limpa.Text = "Limpador traseiro"
        '
        'cb_abs
        '
        Me.cb_abs.BackColor = System.Drawing.Color.SlateGray
        Me.cb_abs.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_abs.ForeColor = System.Drawing.Color.Beige
        Me.cb_abs.Location = New System.Drawing.Point(170, 41)
        Me.cb_abs.Name = "cb_abs"
        Me.cb_abs.Size = New System.Drawing.Size(118, 31)
        Me.cb_abs.TabIndex = 62
        Me.cb_abs.Text = "Freio ABS"
        '
        'CBVE
        '
        Me.CBVE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBVE.Location = New System.Drawing.Point(170, 204)
        Me.CBVE.Name = "CBVE"
        Me.CBVE.Size = New System.Drawing.Size(124, 16)
        Me.CBVE.TabIndex = 59
        Me.CBVE.Text = "Vidros Elétricos"
        '
        'CBSOM
        '
        Me.CBSOM.BackColor = System.Drawing.Color.SlateGray
        Me.CBSOM.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSOM.ForeColor = System.Drawing.Color.Beige
        Me.CBSOM.Location = New System.Drawing.Point(170, 111)
        Me.CBSOM.Name = "CBSOM"
        Me.CBSOM.Size = New System.Drawing.Size(72, 16)
        Me.CBSOM.TabIndex = 54
        Me.CBSOM.Text = "Som"
        '
        'cb_teto
        '
        Me.cb_teto.BackColor = System.Drawing.Color.SlateGray
        Me.cb_teto.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_teto.ForeColor = System.Drawing.Color.Beige
        Me.cb_teto.Location = New System.Drawing.Point(170, 141)
        Me.cb_teto.Name = "cb_teto"
        Me.cb_teto.Size = New System.Drawing.Size(118, 16)
        Me.cb_teto.TabIndex = 60
        Me.cb_teto.Text = "Teto Solar"
        '
        'CBTE
        '
        Me.CBTE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTE.Location = New System.Drawing.Point(170, 172)
        Me.CBTE.Name = "CBTE"
        Me.CBTE.Size = New System.Drawing.Size(128, 15)
        Me.CBTE.TabIndex = 55
        Me.CBTE.Text = "Travas Elétricas"
        '
        'Cb_blindado
        '
        Me.Cb_blindado.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_blindado.Location = New System.Drawing.Point(15, 171)
        Me.Cb_blindado.Name = "Cb_blindado"
        Me.Cb_blindado.Size = New System.Drawing.Size(144, 16)
        Me.Cb_blindado.TabIndex = 176
        Me.Cb_blindado.Text = "Blindado"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Beige
        Me.Label7.Location = New System.Drawing.Point(184, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 31)
        Me.Label7.TabIndex = 188
        Me.Label7.Text = "Preço de Compra"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Beige
        Me.Label16.Location = New System.Drawing.Point(8, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 23)
        Me.Label16.TabIndex = 183
        Me.Label16.Text = "Código do Veiculo"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(4, 407)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(400, 157)
        Me.Label20.TabIndex = 226
        '
        'txttipo
        '
        Me.txttipo.Items.AddRange(New Object() {"Carro", "Moto", "Pick-up", "Van", "Caminhao/Rebocador", "Onibus/Microonibus"})
        Me.txttipo.Location = New System.Drawing.Point(88, 295)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(104, 21)
        Me.txttipo.TabIndex = 10
        '
        'status
        '
        Me.status.Cursor = System.Windows.Forms.Cursors.Cross
        Me.status.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.status.Location = New System.Drawing.Point(0, 571)
        Me.status.Name = "status"
        Me.status.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.status.ShowPanels = True
        Me.status.Size = New System.Drawing.Size(800, 22)
        Me.status.TabIndex = 241
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Icon = CType(resources.GetObject("StatusBarPanel1.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel1.ToolTipText = "Atualizacao de saldo do fornecedor"
        Me.StatusBarPanel1.Width = 31
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel2.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel2.Width = 10
        '
        'rb_excluir
        '
        Me.rb_excluir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.rb_excluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_excluir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rb_excluir.Location = New System.Drawing.Point(176, 485)
        Me.rb_excluir.Name = "rb_excluir"
        Me.rb_excluir.Size = New System.Drawing.Size(72, 18)
        Me.rb_excluir.TabIndex = 242
        Me.rb_excluir.Text = "Excluir"
        Me.rb_excluir.Visible = False
        '
        'pc_del
        '
        Me.pc_del.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pc_del.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pc_del.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pc_del.Image = CType(resources.GetObject("pc_del.Image"), System.Drawing.Image)
        Me.pc_del.Location = New System.Drawing.Point(184, 425)
        Me.pc_del.Name = "pc_del"
        Me.pc_del.Size = New System.Drawing.Size(50, 54)
        Me.pc_del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pc_del.TabIndex = 244
        Me.pc_del.TabStop = False
        Me.pc_del.Visible = False
        '
        'pc_change
        '
        Me.pc_change.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pc_change.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pc_change.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pc_change.Image = CType(resources.GetObject("pc_change.Image"), System.Drawing.Image)
        Me.pc_change.Location = New System.Drawing.Point(264, 425)
        Me.pc_change.Name = "pc_change"
        Me.pc_change.Size = New System.Drawing.Size(50, 54)
        Me.pc_change.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pc_change.TabIndex = 245
        Me.pc_change.TabStop = False
        Me.pc_change.Visible = False
        '
        'rb_alterar
        '
        Me.rb_alterar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.rb_alterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_alterar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rb_alterar.Location = New System.Drawing.Point(256, 485)
        Me.rb_alterar.Name = "rb_alterar"
        Me.rb_alterar.Size = New System.Drawing.Size(72, 18)
        Me.rb_alterar.TabIndex = 243
        Me.rb_alterar.Text = "Alterar"
        Me.rb_alterar.Visible = False
        '
        'txtpot
        '
        Me.txtpot.DecimalPlaces = 1
        Me.txtpot.Increment = New Decimal(New Integer() {2, 0, 0, 65536})
        Me.txtpot.Location = New System.Drawing.Point(88, 364)
        Me.txtpot.Name = "txtpot"
        Me.txtpot.Size = New System.Drawing.Size(96, 20)
        Me.txtpot.TabIndex = 246
        Me.txtpot.Value = New Decimal(New Integer() {10, 0, 0, 65536})
        '
        'veiculos_venda
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(800, 593)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtpot)
        Me.Controls.Add(Me.rb_excluir)
        Me.Controls.Add(Me.pc_del)
        Me.Controls.Add(Me.pc_change)
        Me.Controls.Add(Me.rb_alterar)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.grpimagem)
        Me.Controls.Add(Me.cb_ano)
        Me.Controls.Add(Me.cb_cor)
        Me.Controls.Add(Me.cb_comb)
        Me.Controls.Add(Me.cb_versao)
        Me.Controls.Add(Me.cb_forn)
        Me.Controls.Add(Me.txt_codforn)
        Me.Controls.Add(Me.txt_vvenda)
        Me.Controls.Add(Me.txtchassi)
        Me.Controls.Add(Me.txtval)
        Me.Controls.Add(Me.txtplaca)
        Me.Controls.Add(Me.txtcod_vei)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.marca_vei)
        Me.Controls.Add(Me.cb_search)
        Me.Controls.Add(Me.cmbporta)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Cb_modelo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Limpar)
        Me.Controls.Add(Me.cb_volta)
        Me.Controls.Add(Me.cb_apaga)
        Me.Controls.Add(Me.cb_print)
        Me.Controls.Add(Me.cb_altera)
        Me.Controls.Add(Me.cadastro_venda)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label20)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "veiculos_venda"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra de veiculos novos"
        Me.grpimagem.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Obter Valores..."

    Private Sub veiculos_venda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cb_forn.Items.Clear()
        Me.marca_vei.Items.Clear()

        Me.cb_altera.Visible = True
        Me.cb_apaga.Visible = True
        Me.cb_altera.Enabled = False
        Me.cb_apaga.Enabled = False
        Me.pc_change.Visible = False
        Me.pc_del.Visible = False
        Me.rb_alterar.Visible = False
        Me.rb_excluir.Visible = False
        Me.Pctemp.Hide()


    End Sub


    Private Sub cb_forn_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_forn.Leave
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Try
            Comando = New OleDbCommand("select cod_forn from fornecedor where nome_fant_forn='" & Me.cb_forn.Text.ToString & "'", Conexao)
            AbrirBD()
            DR = Comando.ExecuteReader
            If DR.Read Then
                Me.txt_codforn.Text = DR("cod_forn")
            End If
            DR.Close()
            FecharBD()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cb_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_search.Click
        rb_excluir.Checked = False
        rb_alterar.Checked = False
        locvei_venda.ShowDialog()
    End Sub

    Private Sub marca_vei_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles marca_vei.Leave
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Try
            Comando = New OleDbCommand("select distinct modelo_vei from veiculos_venda where marca_vei='" & marca_vei.Text.ToString & "'", Conexao)
            AbrirBD()
            DR = Comando.ExecuteReader
            While DR.Read
                Cb_modelo.Items.Add(DR("modelo_vei"))
            End While
            DR.Close()
            FecharBD()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Cb_modelo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cb_modelo.Leave
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Try
            Comando = New OleDbCommand("select distinct versao_vei from veiculos_venda where modelo_vei='" & Cb_modelo.Text.ToString & "'", Conexao)
            AbrirBD()
            DR = Comando.ExecuteReader
            While DR.Read
                cb_versao.Items.Add(DR("versao_vei"))
            End While
            DR.Close()
            FecharBD()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cb_versao_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_versao.Leave
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Try
            Comando = New OleDbCommand("select distinct ano_vei from veiculos_venda where versao_vei='" & cb_versao.Text.ToString & "'", Conexao)
            AbrirBD()
            DR = Comando.ExecuteReader
            While DR.Read
                cb_ano.Items.Add(DR("ano_vei"))
            End While
            DR.Close()
            FecharBD()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cb_forn_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_forn.GotFocus
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Comando = New OleDbCommand("select nome_fant_forn from fornecedor order by nome_fant_forn", Conexao)
        AbrirBD()
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                cb_forn.Items.Add(DR("nome_fant_forn"))
            End While
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try
    End Sub


    Private Sub marca_vei_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles marca_vei.GotFocus
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Comando = New OleDbCommand("select * from veiculos_venda order by marca_vei", Conexao)
        AbrirBD()
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                marca_vei.Items.Add(DR("marca_vei"))
            End While
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try
    End Sub

#End Region

#Region "Cadastrar"

    Private Sub cadastro_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadastro_venda.Click

        'Imagem do veiculo...
        Dim imagem As String
        Try
            Me.Pctemp.Image.Save(Application.StartupPath & "\fotos\" & Me.txtplaca.Text.ToString & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            imagem = (Application.StartupPath & "\fotos\" & Me.txtplaca.Text.ToString & ".jpg")
        Catch ex As Exception
            MsgBox("   Se a foto ja foi selecionada, por favor" & (Chr(13)) & "confira se este veiculo ja nao foi cadastrado", MsgBoxStyle.Critical, "Veiculo ja existente ou Foto nao setada")
            Exit Sub
        End Try


        '''VALORIZACAO DE ESTADO DAS CHECKBOXs
        Dim ABD As String
        Dim ALARME As String
        Dim ArQuente As String
        Dim Banco As String
        Dim Blindado As String
        Dim Desembaca As String
        Dim Freio As String
        Dim Limpa As String
        Dim Teto As String
        Dim UniDono As String
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
            TE = "true,"
        Else
            TE = "false,"
        End If

        If cb_abd.CheckState = CheckState.Checked Then
            ABD = "true,"
        Else
            ABD = "false,"
        End If

        If cb_alarme.CheckState = CheckState.Checked Then
            ALARME = "true,"
        Else
            ALARME = "false,"
        End If

        If cb_arquente.CheckState = CheckState.Checked Then
            ArQuente = "true,"
        Else
            ArQuente = "false,"
        End If

        If Cb_banco.CheckState = CheckState.Checked Then
            Banco = "true,"
        Else
            Banco = "false,"
        End If

        If cb_abs.CheckState = CheckState.Checked Then
            Freio = "true,"
        Else
            Freio = "false,"
        End If

        If cb_limpa.CheckState = CheckState.Checked Then
            Limpa = "true,"
        Else
            Limpa = "false,"
        End If

        If Cb_blindado.CheckState = CheckState.Checked Then
            Blindado = "true,"
        Else
            Blindado = "false,"
        End If

        If cb_desembaca.CheckState = CheckState.Checked Then
            Desembaca = "true,"
        Else
            Desembaca = "false,"
        End If

        If cb_teto.CheckState = CheckState.Checked Then
            Teto = "true"
        Else
            Teto = "false"
        End If

        'Verificacao de campos

        If txtplaca.Text = "" Then
            MessageBox.Show("Todos os campos devem ser preenchidos", "Atencaoo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim comando As OleDbCommand
            AbrirBD()

            'Codigo para registo na tabela de veiculos usados

            comando = New OleDbCommand("insert into veiculos_venda(cod_forn,nome_forn,modelo_vei,marca_vei,versao_vei,ano_vei,placa_vei,comb_vei,tipo_vei,pot_vei,cor_vei,porta_vei,chassi_vei,preco_compra_vei,preco_venda_vei,img_vei,ar_vei,direcao_vei,som_vei,dvd_vei,vidro_vei,trava_vei,airbagduplo_vei,alarme_vei,arquente_vei,bancocouro_vei,blindado_vei,desembaca_tras_vei,freioabs_vei,limptraseiro_vei,tetosolar_vei) values (@cod_forn,@nome_forn,@modelo,@marca,@versao,@ano,@placa,@comb,@tipo,@pot,@cor,@porta,@chassi,@precocompra,@precovenda,'" & imagem.ToString & "'," & ac & DH & som & dvd & VE & TE & ABD & ALARME & ArQuente & Banco & Blindado & Desembaca & Freio & Limpa & Teto & ")", Conexao)

            With comando
                .Parameters.Add(New OleDbParameter("@cod_forn", OleDbType.Numeric, 50))
                .Parameters("@cod_forn").Value = txt_codforn.Text
                .Parameters.Add(New OleDbParameter("@nome_forn", OleDbType.VarChar, 50))
                .Parameters("@nome_forn").Value = cb_forn.Text.ToString
                .Parameters.Add(New OleDbParameter("@modelo", OleDbType.VarChar, 50))
                .Parameters("@modelo").Value = Cb_modelo.Text.ToString
                .Parameters.Add(New OleDbParameter("@marca", OleDbType.VarChar, 50))
                .Parameters("@marca").Value = marca_vei.Text.ToString
                .Parameters.Add(New OleDbParameter("@versao", OleDbType.VarChar, 50))
                .Parameters("@versao").Value = cb_versao.Text.ToString
                .Parameters.Add(New OleDbParameter("@ano", OleDbType.VarChar, 50))
                .Parameters("@ano").Value = cb_ano.Text.ToString
                .Parameters.Add(New OleDbParameter("@placa", OleDbType.VarChar, 50))
                .Parameters("@placa").Value = txtplaca.Text.ToString
                .Parameters.Add(New OleDbParameter("@comb", OleDbType.VarChar, 50))
                .Parameters("@comb").Value = cb_comb.Text.ToString
                .Parameters.Add(New OleDbParameter("@tipo", OleDbType.VarChar, 50))
                .Parameters("@tipo").Value = txttipo.Text.ToString
                .Parameters.Add(New OleDbParameter("@pot", OleDbType.VarChar, 50))
                .Parameters("@pot").Value = txtpot.Text.ToString
                .Parameters.Add(New OleDbParameter("@cor", OleDbType.VarChar, 50))
                .Parameters("@cor").Value = cb_cor.Text.ToString
                .Parameters.Add(New OleDbParameter("@porta", OleDbType.Numeric, 50))
                .Parameters("@porta").Value = cmbporta.Text
                .Parameters.Add(New OleDbParameter("@chassi", OleDbType.VarChar, 50))
                .Parameters("@chassi").Value = txtchassi.Text.ToString
                .Parameters.Add(New OleDbParameter("@precocompra", OleDbType.VarChar, 50))
                .Parameters("@precocompra").Value = txtval.Text
                .Parameters.Add(New OleDbParameter("@precovenda", OleDbType.VarChar, 50))
                .Parameters("@precovenda").Value = txt_vvenda.Text
            End With

            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("Registro cadastrado", "Inclusao de Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Erro")
            End Try

            'Codigo para registro na tabela de Compras de veiculos novos

            Dim cmd_compra As OleDbCommand
            AbrirBD()
            cmd_compra = New OleDbCommand("insert into compra_vei_novo(placa_vei,preco_compra_vei,dia_compra,cod_forn,nome_fant_forn)values(@placa_vei,@preco_compra_vei,@dia_compra,@cod_forn,@nome_forn)", Conexao)

            With cmd_compra
                .Parameters.Add(New OleDbParameter("@placa_vei", OleDbType.VarChar, 100))
                .Parameters("@placa_vei").Value = txtplaca.Text
                .Parameters.Add(New OleDbParameter("@preco_compra_vei", OleDbType.VarChar, 100))
                .Parameters("@preco_compra_vei").Value = txtval.Text
                .Parameters.Add(New OleDbParameter("@dia_compra", OleDbType.DBDate, 100))
                .Parameters("@dia_compra").Value = Now.Date.Today
                .Parameters.Add(New OleDbParameter("@cod_forn", OleDbType.VarChar, 10))
                .Parameters("@cod_forn").Value = txt_codforn.Text
                .Parameters.Add(New OleDbParameter("@nome_forn", OleDbType.VarChar, 100))
                .Parameters("@nome_forn").Value = cb_forn.Text
            End With

            cmd_compra.ExecuteNonQuery()
            FecharBD()

            '''''ATUALIZACAO DO SALDO DO Fornecedor

            Dim dr As OleDbDataReader
            Dim cmd_forn As OleDbCommand
            Dim comando2 As OleDbCommand
            Dim temp As Long

            AbrirBD()
            cmd_forn = New OleDbCommand("select saldo_forn from fornecedor where cod_forn=@cod_forn", Conexao)
            cmd_forn.Parameters.Add(New OleDbParameter("@cod_forn", OleDbType.VarChar, 50))
            cmd_forn.Parameters("@cod_forn").Value = Me.txt_codforn.Text
            dr = cmd_forn.ExecuteReader
            If dr.Read Then
                temp = Val(dr("saldo_forn") + (txtval.Text))
            End If
            dr.Close()
            comando2 = New OleDbCommand("update fornecedor set saldo_forn=@saldo where cod_forn=@cod", Conexao)
            comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
            comando2.Parameters("@saldo").Value = temp
            comando2.Parameters.Add(New OleDbParameter("@cod", OleDbType.VarChar, 50))
            comando2.Parameters("@cod").Value = Me.txt_codforn.Text
            comando2.ExecuteNonQuery()
        End If
        FecharBD()

    End Sub

#End Region

#Region "Alterar"

    Private Sub cb_altera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_altera.Click
        Dim imagem As String
        'ATUALIZANDO (OUNAO) A IMAGEM DE ACORDO COM A PLACA DO VEICULO
        Try
            Pctemp.Image.Save(Application.StartupPath & "\fotos\" & Me.txtplaca.Text.ToString & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            imagem = (Application.StartupPath & "\fotos\" & Me.txtplaca.Text.ToString & ".jpg")
        Catch ex As Exception
            Dim cmdimg As OleDbCommand
            Dim drimg As OleDbDataReader
            cmdimg = New OleDbCommand("select img_vei from veiculos_venda where cod_vei=" & Me.txtcod_vei.Text, Conexao)
            AbrirBD()
            drimg = cmdimg.ExecuteReader
            If drimg.Read Then
                imagem = drimg("img_vei")
            End If
            FecharBD()
        End Try

        'PEGANDO VALOR DE COMPRA INICIAL

        Dim V_antigo As Single
        Dim comando_veiculo As OleDbCommand
        Dim dr_vei As OleDbDataReader
        AbrirBD()
        comando_veiculo = New OleDbCommand("select preco_compra_vei from veiculos_venda where cod_vei=" & Me.txtcod_vei.Text, Conexao)
        dr_vei = comando_veiculo.ExecuteReader
        If dr_vei.Read Then
            V_antigo = dr_vei("preco_compra_vei")
        End If
        dr_vei.Close()
        FecharBD()

        'VERIFICANDO CHECKBOXS

        Dim ABD As Boolean
        Dim ALARME As Boolean
        Dim ArQuente As Boolean
        Dim Banco As Boolean
        Dim Blindado As Boolean
        Dim Desembaca As Boolean
        Dim Freio As Boolean
        Dim Limpa As Boolean
        Dim Teto As Boolean
        Dim ac As Boolean
        Dim DH As Boolean
        Dim som As Boolean
        Dim dvd As Boolean
        Dim VE As Boolean
        Dim TE As Boolean


        If CBSOM.CheckState = CheckState.Checked Then
            som = True
        Else
            som = False
        End If
        If CBAC.CheckState = CheckState.Checked Then
            ac = True
        Else
            ac = False
        End If
        If CBDH.CheckState = CheckState.Checked Then
            DH = True
        Else
            DH = False
        End If
        If CBDVD.CheckState = CheckState.Checked Then
            dvd = True
        Else
            dvd = False
        End If
        If CBVE.CheckState = CheckState.Checked Then
            VE = True
        Else
            VE = False
        End If
        If CBTE.CheckState = CheckState.Checked Then
            TE = True
        Else
            TE = False
        End If

        If cb_abd.CheckState = CheckState.Checked Then
            ABD = True
        Else
            ABD = False
        End If

        If cb_alarme.CheckState = CheckState.Checked Then
            ALARME = True
        Else
            ALARME = False
        End If

        If cb_arquente.CheckState = CheckState.Checked Then
            ArQuente = True
        Else
            ArQuente = False
        End If

        If Cb_banco.CheckState = CheckState.Checked Then
            Banco = True
        Else
            Banco = False
        End If

        If cb_abs.CheckState = CheckState.Checked Then
            Freio = True
        Else
            Freio = False
        End If

        If cb_limpa.CheckState = CheckState.Checked Then
            Limpa = True
        Else
            Limpa = False
        End If

        If Cb_blindado.CheckState = CheckState.Checked Then
            Blindado = True
        Else
            Blindado = False
        End If

        If cb_desembaca.CheckState = CheckState.Checked Then
            Desembaca = True
        Else
            Desembaca = False
        End If

        If cb_teto.CheckState = CheckState.Checked Then
            Teto = True
        Else
            Teto = False
        End If

        'ATUALIZACAO NA TABELA DE VEICULOS.......

        If txtplaca.Text = "" Then
            MessageBox.Show("Todos os campos devem ser preenchidos", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else


            Dim comando As OleDbCommand
            AbrirBD()
            comando = New OleDbCommand("update veiculos_venda set cod_forn=@cod_forn,nome_forn=@nome_forn,modelo_vei=@modelo,marca_vei=@marca,versao_vei=@versao,ano_vei=@ano,placa_vei=@placa,comb_vei=@comb,tipo_vei=@tipo,pot_vei=@pot,cor_vei=@cor,porta_vei=@porta,chassi_vei=@chassi,preco_compra_vei=@precocompra,preco_venda_vei=@precovenda,img_vei='" & imagem.ToString & "',ar_vei=" & ac & ",direcao_vei=" & DH & ",som_vei=" & som & ",dvd_vei=" & dvd & ",vidro_vei=" & VE & ",trava_vei=" & TE & ",airbagduplo_vei=" & ABD & ",alarme_vei=" & ALARME & ",arquente_vei=" & ArQuente & ",bancocouro_vei=" & Banco & ",blindado_vei=" & Blindado & ",desembaca_tras_vei=" & Desembaca & ",freioabs_vei=" & Freio & ",limptraseiro_vei=" & Limpa & ",tetosolar_vei=" & Teto & " where cod_vei=" & txtcod_vei.Text, Conexao)
            With comando
                .Parameters.Add(New OleDbParameter("@cod_forn", OleDbType.Numeric, 50))
                .Parameters("@cod_forn").Value = txt_codforn.Text
                .Parameters.Add(New OleDbParameter("@nome_forn", OleDbType.VarChar, 50))
                .Parameters("@nome_forn").Value = cb_forn.Text.ToString
                .Parameters.Add(New OleDbParameter("@modelo", OleDbType.VarChar, 50))
                .Parameters("@modelo").Value = Cb_modelo.Text.ToString
                .Parameters.Add(New OleDbParameter("@marca", OleDbType.VarChar, 50))
                .Parameters("@marca").Value = marca_vei.Text.ToString
                .Parameters.Add(New OleDbParameter("@versao", OleDbType.VarChar, 50))
                .Parameters("@versao").Value = cb_versao.Text.ToString
                .Parameters.Add(New OleDbParameter("@ano", OleDbType.VarChar, 50))
                .Parameters("@ano").Value = cb_ano.Text.ToString
                .Parameters.Add(New OleDbParameter("@placa", OleDbType.VarChar, 50))
                .Parameters("@placa").Value = txtplaca.Text.ToString
                .Parameters.Add(New OleDbParameter("@comb", OleDbType.VarChar, 50))
                .Parameters("@comb").Value = cb_comb.Text.ToString
                .Parameters.Add(New OleDbParameter("@tipo", OleDbType.VarChar, 50))
                .Parameters("@tipo").Value = txttipo.Text.ToString
                .Parameters.Add(New OleDbParameter("@pot", OleDbType.VarChar, 50))
                .Parameters("@pot").Value = txtpot.Text.ToString
                .Parameters.Add(New OleDbParameter("@cor", OleDbType.VarChar, 50))
                .Parameters("@cor").Value = cb_cor.Text.ToString
                .Parameters.Add(New OleDbParameter("@porta", OleDbType.Numeric, 50))
                .Parameters("@porta").Value = cmbporta.Text
                .Parameters.Add(New OleDbParameter("@chassi", OleDbType.VarChar, 50))
                .Parameters("@chassi").Value = txtchassi.Text.ToString
                .Parameters.Add(New OleDbParameter("@precocompra", OleDbType.VarChar, 50))
                .Parameters("@precocompra").Value = txtval.Text
                .Parameters.Add(New OleDbParameter("@precovenda", OleDbType.VarChar, 50))
                .Parameters("@precovenda").Value = txt_vvenda.Text
            End With
            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("Registro alterado", "Alteracao de Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Erro")
            End Try
            FecharBD()

            'ALTERACAO DO SALDO DO Fornecedor

            Dim dr As OleDbDataReader
            Dim cmd_cli As OleDbCommand
            Dim comando2 As OleDbCommand
            Dim saldo_anterior As Single
            Dim novo_saldo As Single
            Dim tmp As Single

            cmd_cli = New OleDbCommand("select saldo_forn from fornecedor where cod_forn=" & txt_codforn.Text, Conexao)
            AbrirBD()
            dr = cmd_cli.ExecuteReader
            If dr.Read Then
                saldo_anterior = dr("saldo_forn")
            End If
            dr.Close()
            FecharBD()

            If V_antigo > txtval.Text Then
                tmp = V_antigo - txtval.Text
                novo_saldo = saldo_anterior - tmp
            Else
                If V_antigo = txtval.Text Then
                    novo_saldo = saldo_anterior
                Else
                    tmp = txtval.Text - V_antigo
                    novo_saldo = saldo_anterior + tmp
                End If
            End If

            comando2 = New OleDbCommand("Update fornecedor set saldo_forn='" & novo_saldo & "' where cod_forn=" & txt_codforn.Text, Conexao)
            AbrirBD()
            comando2.ExecuteNonQuery()
            FecharBD()
        End If
        FecharBD()


        'Codigo para  atualizacao da tabela de Compras de veiculos usados


        Dim cmd_compra As OleDbCommand
        AbrirBD()
        cmd_compra = New OleDbCommand("update compra_vei_novo set cod_forn=@codforn,nome_fant_forn=@forn,preco_compra_vei=@preco where placa_vei=@placa_vei", Conexao)
        With cmd_compra
            .Parameters.Add(New OleDbParameter("@placa_vei", OleDbType.VarChar, 100))
            .Parameters("@placa_vei").Value = txtplaca.Text
            .Parameters.Add(New OleDbParameter("@codforn", OleDbType.VarChar, 100))
            .Parameters("@codforn").Value = txt_codforn.Text
            .Parameters.Add(New OleDbParameter("@forn", OleDbType.VarChar, 100))
            .Parameters("@forn").Value = cb_forn.Text.ToString
            .Parameters.Add(New OleDbParameter("@preco", OleDbType.VarChar, 100))
            .Parameters("@preco").Value = Val(txtval.Text)
        End With
        cmd_compra.ExecuteNonQuery()
        FecharBD()


        'Esquema de Alterar e Excluir
        'Me.alterar_venda.Visible = True
        'Me.Excluir.Visible = True
        'Me.alterar_venda.Enabled = False
        'Me.Excluir.Enabled = False
        'Me.pc_change.Visible = False
        'Me.pc_del.Visible = False
        'Me.rb_alterar.Visible = False
        'Me.rb_excluir.Visible = False

    End Sub

#End Region

#Region "Deletar"

    Private Sub cb_apaga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_apaga.Click

        'Coletar valor do veiculo para desconto do saldo do fornecedor
        Dim valor_veiculo As Single
        Dim com_val As OleDbCommand
        Dim dr_val As OleDbDataReader
        AbrirBD()
        com_val = New OleDbCommand("select preco_compra_vei from compra_vei_novo where placa_vei='" & txtplaca.Text & "'", Conexao)
        dr_val = com_val.ExecuteReader
        If dr_val.Read Then
            valor_veiculo = Val(dr_val("preco_compra_vei"))
        End If
        FecharBD()

        'Remover da tabela de vendas de autos novos
        AbrirBD()
        Dim cmd_new As OleDbCommand
        cmd_new = New OleDbCommand("delete from compra_vei_novo where placa_vei='" & txtplaca.Text & "'", Conexao)
        cmd_new.ExecuteNonQuery()
        FecharBD()

        'Alteracao do saldo do fornecedor
        AbrirBD()
        Dim dr As OleDbDataReader
        Dim saldo_atual As Long
        Dim novo_saldo As Long
        Dim comando_cli As OleDbCommand
        comando_cli = New OleDbCommand("select * from fornecedor where cod_forn=" & txt_codforn.Text & "", Conexao)
        dr = comando_cli.ExecuteReader
        If dr.Read Then
            saldo_atual = dr("saldo_forn")
        End If
        dr.Close()
        FecharBD()
        novo_saldo = Val(saldo_atual - valor_veiculo)
        Dim comando2 As OleDbCommand
        comando2 = New OleDbCommand("Update fornecedor set saldo_forn=@saldo where cod_forn=@cod_forn", Conexao)
        comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
        comando2.Parameters("@saldo").Value = novo_saldo
        comando2.Parameters.Add(New OleDbParameter("@cod_forn", OleDbType.VarChar, 50))
        comando2.Parameters("@cod_forn").Value = Me.txt_codforn.Text
        AbrirBD()
        comando2.ExecuteNonQuery()
        FecharBD()

        'Deletar da tabela de veiculos usados
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
                    cb_teto.CheckState = CheckState.Unchecked
                    cb_desembaca.CheckState = CheckState.Unchecked
                    Cb_blindado.CheckState = CheckState.Unchecked
                    cb_limpa.CheckState = CheckState.Unchecked
                    cb_abs.CheckState = CheckState.Unchecked
                    Cb_banco.CheckState = CheckState.Unchecked
                    cb_arquente.CheckState = CheckState.Unchecked
                    cb_alarme.CheckState = CheckState.Unchecked
                    cb_abd.CheckState = CheckState.Unchecked
                    Me.Pctemp.Hide()
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Apagar Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try
        End If

        Me.Pctemp.Hide()



    End Sub

#End Region

#Region "Limpar, voltar etc.."
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
        cb_teto.CheckState = CheckState.Unchecked
        cb_desembaca.CheckState = CheckState.Unchecked
        Cb_blindado.CheckState = CheckState.Unchecked
        cb_limpa.CheckState = CheckState.Unchecked
        cb_abs.CheckState = CheckState.Unchecked
        Cb_banco.CheckState = CheckState.Unchecked
        cb_arquente.CheckState = CheckState.Unchecked
        cb_alarme.CheckState = CheckState.Unchecked
        cb_abd.CheckState = CheckState.Unchecked

        Me.Pctemp.Hide()

    End Sub

    Private Sub cb_volta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_volta.Click
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
        cb_teto.CheckState = CheckState.Unchecked
        cb_desembaca.CheckState = CheckState.Unchecked
        Cb_blindado.CheckState = CheckState.Unchecked
        cb_limpa.CheckState = CheckState.Unchecked
        cb_abs.CheckState = CheckState.Unchecked
        Cb_banco.CheckState = CheckState.Unchecked
        cb_arquente.CheckState = CheckState.Unchecked
        cb_alarme.CheckState = CheckState.Unchecked
        cb_abd.CheckState = CheckState.Unchecked
        bt_obter.Visible = True
        Me.Pctemp.Hide()
        Me.Visible = False
        principal.Visible = True
        principal.IconTray.Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        locforn.ShowDialog()
    End Sub

    Private Sub bt_obter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_obter.Click
        Capturar.ShowDialog()
    End Sub
    Private Sub txtval_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtval.KeyUp
        txt_vvenda.Text = Val(txtval.Text) * 1.2
    End Sub


#End Region

#Region "Esquema de Alterar e Excluir"

    Private Sub rb_excluir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_excluir.CheckedChanged
        Me.pc_change.Visible = False
        Me.pc_del.Visible = False
        cb_apaga.Enabled = True
        cb_apaga.Visible = True
        cb_altera.Visible = False
        rb_alterar.Visible = False
        rb_excluir.Visible = False
    End Sub

    Private Sub rb_alterar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_alterar.CheckedChanged
        Dim Controle As New Control
        For Each Controle In buy_oldvei.Controls
            If TypeOf Controle Is TextBox Or TypeOf Controle Is ComboBox Or TypeOf Controle Is CheckBox Then
                Controle.Enabled = True
            End If
        Next
        For Each Controle In buy_oldvei.GroupBox7.Controls
            If TypeOf Controle Is CheckBox Then
                Controle.Enabled = True
            End If
        Next
        txtpot.Enabled = True

        Me.bt_obter.Visible = True
        Me.pc_change.Visible = False
        Me.pc_del.Visible = False
        cb_apaga.Visible = False
        cb_altera.Enabled = True
        cb_altera.Visible = True
        rb_alterar.Visible = False
        rb_excluir.Visible = False
    End Sub

    Private Sub pc_change_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pc_change.MouseLeave
        rb_alterar.ForeColor = Color.Black
    End Sub

    Private Sub pc_change_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pc_change.MouseEnter
        rb_alterar.ForeColor = Color.FloralWhite
    End Sub

    Private Sub pc_del_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pc_del.MouseEnter
        rb_excluir.ForeColor = Color.FloralWhite
    End Sub

    Private Sub pc_del_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pc_del.MouseLeave
        rb_excluir.ForeColor = Color.Black
    End Sub

    Private Sub pc_change_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pc_change.Click
        Me.rb_alterar.Checked = True
    End Sub

    Private Sub pc_del_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pc_del.Click
        Me.rb_excluir.Checked = True
    End Sub

#End Region
End Class
