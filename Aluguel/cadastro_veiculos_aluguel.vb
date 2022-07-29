Imports AllCars.Module1
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.InteropServices

Public Class cadastro_vei_alu
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
    Friend WithEvents cb_ano As System.Windows.Forms.ComboBox
    Friend WithEvents cb_cor As System.Windows.Forms.ComboBox
    Friend WithEvents cb_comb As System.Windows.Forms.ComboBox
    Friend WithEvents grpimagem As System.Windows.Forms.GroupBox
    Friend WithEvents Pctemp As System.Windows.Forms.PictureBox
    Friend WithEvents cb_versao As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_modelo As System.Windows.Forms.ComboBox
    Friend WithEvents marca_vei As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbporta As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtchassi As System.Windows.Forms.TextBox
    Friend WithEvents voltar As System.Windows.Forms.Button
    Friend WithEvents txttipo As System.Windows.Forms.TextBox
    Friend WithEvents txtplaca As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcod_vei As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
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
    Friend WithEvents cmbcond As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents bt_imports As System.Windows.Forms.Button
    Friend WithEvents bt_export As System.Windows.Forms.Button
    Friend WithEvents bt_search As System.Windows.Forms.Button
    Friend WithEvents bt_change As System.Windows.Forms.Button
    Friend WithEvents lk_another As System.Windows.Forms.LinkLabel
    Friend WithEvents bt_print As System.Windows.Forms.Button
    Friend WithEvents txt_renavam As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_diaria As System.Windows.Forms.TextBox
    Friend WithEvents lk_export As System.Windows.Forms.LinkLabel
    Friend WithEvents bt_export2 As System.Windows.Forms.Button
    Friend WithEvents txtpot As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(cadastro_vei_alu))
        Me.cb_ano = New System.Windows.Forms.ComboBox
        Me.cb_cor = New System.Windows.Forms.ComboBox
        Me.cb_comb = New System.Windows.Forms.ComboBox
        Me.grpimagem = New System.Windows.Forms.GroupBox
        Me.Pctemp = New System.Windows.Forms.PictureBox
        Me.cb_versao = New System.Windows.Forms.ComboBox
        Me.Cb_modelo = New System.Windows.Forms.ComboBox
        Me.marca_vei = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.bt_search = New System.Windows.Forms.Button
        Me.cmbporta = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtchassi = New System.Windows.Forms.TextBox
        Me.voltar = New System.Windows.Forms.Button
        Me.bt_print = New System.Windows.Forms.Button
        Me.bt_change = New System.Windows.Forms.Button
        Me.txt_diaria = New System.Windows.Forms.TextBox
        Me.txttipo = New System.Windows.Forms.TextBox
        Me.txtplaca = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtcod_vei = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
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
        Me.cmbcond = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.bt_imports = New System.Windows.Forms.Button
        Me.bt_export = New System.Windows.Forms.Button
        Me.lk_another = New System.Windows.Forms.LinkLabel
        Me.txt_renavam = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lk_export = New System.Windows.Forms.LinkLabel
        Me.bt_export2 = New System.Windows.Forms.Button
        Me.txtpot = New System.Windows.Forms.NumericUpDown
        Me.grpimagem.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.txtpot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_ano
        '
        Me.cb_ano.Location = New System.Drawing.Point(336, 128)
        Me.cb_ano.Name = "cb_ano"
        Me.cb_ano.Size = New System.Drawing.Size(64, 20)
        Me.cb_ano.TabIndex = 225
        '
        'cb_cor
        '
        Me.cb_cor.Items.AddRange(New Object() {"Amarelo", "Azul", "Beje", "Branco", "Cinza", "Dourado", "Indefinida", "Laranja", "Marrom", "Prata", "Preto", "Roxo", "Verde", "Vermelho", "Vinho"})
        Me.cb_cor.Location = New System.Drawing.Point(88, 240)
        Me.cb_cor.Name = "cb_cor"
        Me.cb_cor.Size = New System.Drawing.Size(104, 20)
        Me.cb_cor.TabIndex = 224
        '
        'cb_comb
        '
        Me.cb_comb.Items.AddRange(New Object() {"Alcool", "Alcool e Gas Natural", "Diesel", "Gas Natural", "Gasolina", "Gasolina e Alcool", "Gasolina e Gas Natural", "Gasolina, Alcool e Gas Natural", "Gasolina, Alcool, Gas Natural e Benzina"})
        Me.cb_comb.Location = New System.Drawing.Point(88, 168)
        Me.cb_comb.Name = "cb_comb"
        Me.cb_comb.Size = New System.Drawing.Size(344, 20)
        Me.cb_comb.TabIndex = 223
        '
        'grpimagem
        '
        Me.grpimagem.Controls.Add(Me.Pctemp)
        Me.grpimagem.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grpimagem.ForeColor = System.Drawing.Color.Beige
        Me.grpimagem.Location = New System.Drawing.Point(416, 248)
        Me.grpimagem.Name = "grpimagem"
        Me.grpimagem.Size = New System.Drawing.Size(384, 272)
        Me.grpimagem.TabIndex = 205
        Me.grpimagem.TabStop = False
        Me.grpimagem.Text = "Foto"
        '
        'Pctemp
        '
        Me.Pctemp.Location = New System.Drawing.Point(16, 32)
        Me.Pctemp.Name = "Pctemp"
        Me.Pctemp.Size = New System.Drawing.Size(352, 224)
        Me.Pctemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctemp.TabIndex = 85
        Me.Pctemp.TabStop = False
        '
        'cb_versao
        '
        Me.cb_versao.Location = New System.Drawing.Point(336, 88)
        Me.cb_versao.Name = "cb_versao"
        Me.cb_versao.Size = New System.Drawing.Size(144, 20)
        Me.cb_versao.TabIndex = 222
        '
        'Cb_modelo
        '
        Me.Cb_modelo.Location = New System.Drawing.Point(88, 128)
        Me.Cb_modelo.Name = "Cb_modelo"
        Me.Cb_modelo.Size = New System.Drawing.Size(144, 20)
        Me.Cb_modelo.TabIndex = 221
        '
        'marca_vei
        '
        Me.marca_vei.Location = New System.Drawing.Point(88, 88)
        Me.marca_vei.Name = "marca_vei"
        Me.marca_vei.Size = New System.Drawing.Size(144, 20)
        Me.marca_vei.TabIndex = 210
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Beige
        Me.Label13.Location = New System.Drawing.Point(208, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 22)
        Me.Label13.TabIndex = 204
        Me.Label13.Text = "Chassi"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Beige
        Me.Label12.Location = New System.Drawing.Point(0, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 21)
        Me.Label12.TabIndex = 203
        Me.Label12.Text = "Cor"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Beige
        Me.Label6.Location = New System.Drawing.Point(256, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 21)
        Me.Label6.TabIndex = 209
        Me.Label6.Text = "Vers„o"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bt_search
        '
        Me.bt_search.BackColor = System.Drawing.Color.White
        Me.bt_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_search.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_search.Image = CType(resources.GetObject("bt_search.Image"), System.Drawing.Image)
        Me.bt_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_search.Location = New System.Drawing.Point(16, 472)
        Me.bt_search.Name = "bt_search"
        Me.bt_search.Size = New System.Drawing.Size(168, 45)
        Me.bt_search.TabIndex = 207
        Me.bt_search.Text = "Localizar"
        Me.bt_search.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cmbporta
        '
        Me.cmbporta.Items.AddRange(New Object() {"2", "3", "4"})
        Me.cmbporta.Location = New System.Drawing.Point(296, 272)
        Me.cmbporta.Name = "cmbporta"
        Me.cmbporta.Size = New System.Drawing.Size(40, 20)
        Me.cmbporta.TabIndex = 194
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Beige
        Me.Label14.Location = New System.Drawing.Point(208, 272)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 29)
        Me.Label14.TabIndex = 206
        Me.Label14.Text = "NÅã de Portas"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtchassi
        '
        Me.txtchassi.AccessibleName = "R$"
        Me.txtchassi.Location = New System.Drawing.Point(296, 208)
        Me.txtchassi.Name = "txtchassi"
        Me.txtchassi.Size = New System.Drawing.Size(112, 19)
        Me.txtchassi.TabIndex = 195
        Me.txtchassi.Text = ""
        '
        'voltar
        '
        Me.voltar.BackColor = System.Drawing.Color.White
        Me.voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.voltar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.voltar.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voltar.Image = CType(resources.GetObject("voltar.Image"), System.Drawing.Image)
        Me.voltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.voltar.Location = New System.Drawing.Point(320, 384)
        Me.voltar.Name = "voltar"
        Me.voltar.Size = New System.Drawing.Size(65, 75)
        Me.voltar.TabIndex = 202
        Me.voltar.Text = "Voltar"
        Me.voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_print
        '
        Me.bt_print.BackColor = System.Drawing.Color.White
        Me.bt_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_print.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_print.Image = CType(resources.GetObject("bt_print.Image"), System.Drawing.Image)
        Me.bt_print.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_print.Location = New System.Drawing.Point(232, 472)
        Me.bt_print.Name = "bt_print"
        Me.bt_print.Size = New System.Drawing.Size(160, 45)
        Me.bt_print.TabIndex = 200
        Me.bt_print.Text = "Imprimir"
        Me.bt_print.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'bt_change
        '
        Me.bt_change.BackColor = System.Drawing.Color.White
        Me.bt_change.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_change.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_change.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_change.Image = CType(resources.GetObject("bt_change.Image"), System.Drawing.Image)
        Me.bt_change.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.bt_change.Location = New System.Drawing.Point(224, 384)
        Me.bt_change.Name = "bt_change"
        Me.bt_change.Size = New System.Drawing.Size(65, 75)
        Me.bt_change.TabIndex = 199
        Me.bt_change.Text = "Alterar"
        Me.bt_change.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txt_diaria
        '
        Me.txt_diaria.AccessibleName = "R$"
        Me.txt_diaria.Location = New System.Drawing.Point(296, 336)
        Me.txt_diaria.Name = "txt_diaria"
        Me.txt_diaria.Size = New System.Drawing.Size(112, 19)
        Me.txt_diaria.TabIndex = 196
        Me.txt_diaria.Text = ""
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(88, 304)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.TabIndex = 192
        Me.txttipo.Text = ""
        '
        'txtplaca
        '
        Me.txtplaca.Location = New System.Drawing.Point(88, 272)
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.TabIndex = 191
        Me.txtplaca.Text = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Beige
        Me.Label8.Location = New System.Drawing.Point(0, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 21)
        Me.Label8.TabIndex = 189
        Me.Label8.Text = "Tipo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Beige
        Me.Label5.Location = New System.Drawing.Point(0, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 21)
        Me.Label5.TabIndex = 187
        Me.Label5.Text = "Combustivel"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Beige
        Me.Label4.Location = New System.Drawing.Point(0, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 22)
        Me.Label4.TabIndex = 186
        Me.Label4.Text = "Placa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Beige
        Me.Label2.Location = New System.Drawing.Point(256, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 185
        Me.Label2.Text = "Ano"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(0, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Modelo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcod_vei
        '
        Me.txtcod_vei.Enabled = False
        Me.txtcod_vei.Location = New System.Drawing.Point(88, 48)
        Me.txtcod_vei.Name = "txtcod_vei"
        Me.txtcod_vei.ReadOnly = True
        Me.txtcod_vei.Size = New System.Drawing.Size(80, 19)
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
        Me.Label3.Size = New System.Drawing.Size(408, 40)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Veiculos para AluguÈis"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Beige
        Me.Label19.Location = New System.Drawing.Point(0, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 21)
        Me.Label19.TabIndex = 220
        Me.Label19.Text = "Marca"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Beige
        Me.Label7.Location = New System.Drawing.Point(200, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 29)
        Me.Label7.TabIndex = 188
        Me.Label7.Text = "Valor da Di·ria"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Beige
        Me.Label16.Location = New System.Drawing.Point(0, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 21)
        Me.Label16.TabIndex = 183
        Me.Label16.Text = "CÛdigo do Veiculo"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(8, 376)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(400, 145)
        Me.Label20.TabIndex = 226
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
        Me.GroupBox7.Location = New System.Drawing.Point(488, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(304, 248)
        Me.GroupBox7.TabIndex = 208
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Adicionais"
        '
        'Cb_banco
        '
        Me.Cb_banco.BackColor = System.Drawing.Color.SlateGray
        Me.Cb_banco.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_banco.ForeColor = System.Drawing.Color.Beige
        Me.Cb_banco.Location = New System.Drawing.Point(15, 121)
        Me.Cb_banco.Name = "Cb_banco"
        Me.Cb_banco.Size = New System.Drawing.Size(118, 30)
        Me.Cb_banco.TabIndex = 69
        Me.Cb_banco.Text = "Bancos em couro"
        '
        'cb_arquente
        '
        Me.cb_arquente.BackColor = System.Drawing.Color.SlateGray
        Me.cb_arquente.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_arquente.ForeColor = System.Drawing.Color.Beige
        Me.cb_arquente.Location = New System.Drawing.Point(15, 98)
        Me.cb_arquente.Name = "cb_arquente"
        Me.cb_arquente.Size = New System.Drawing.Size(118, 17)
        Me.cb_arquente.TabIndex = 68
        Me.cb_arquente.Text = "" & Microsoft.VisualBasic.ChrW(9) & "Ar quente"
        '
        'cb_desembaca
        '
        Me.cb_desembaca.BackColor = System.Drawing.Color.SlateGray
        Me.cb_desembaca.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_desembaca.ForeColor = System.Drawing.Color.Beige
        Me.cb_desembaca.Location = New System.Drawing.Point(15, 179)
        Me.cb_desembaca.Name = "cb_desembaca"
        Me.cb_desembaca.Size = New System.Drawing.Size(118, 28)
        Me.cb_desembaca.TabIndex = 61
        Me.cb_desembaca.Text = "Desembacador Traseiro"
        '
        'CBAC
        '
        Me.CBAC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBAC.Location = New System.Drawing.Point(15, 71)
        Me.CBAC.Name = "CBAC"
        Me.CBAC.Size = New System.Drawing.Size(131, 15)
        Me.CBAC.TabIndex = 56
        Me.CBAC.Text = "Ar Condicionado"
        '
        'CBDH
        '
        Me.CBDH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBDH.Location = New System.Drawing.Point(15, 215)
        Me.CBDH.Name = "CBDH"
        Me.CBDH.Size = New System.Drawing.Size(144, 15)
        Me.CBDH.TabIndex = 58
        Me.CBDH.Text = "DireÁ„o Hidr·ulica"
        '
        'CBDVD
        '
        Me.CBDVD.BackColor = System.Drawing.Color.SlateGray
        Me.CBDVD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBDVD.ForeColor = System.Drawing.Color.Beige
        Me.CBDVD.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.CBDVD.Location = New System.Drawing.Point(170, 16)
        Me.CBDVD.Name = "CBDVD"
        Me.CBDVD.Size = New System.Drawing.Size(96, 23)
        Me.CBDVD.TabIndex = 57
        Me.CBDVD.Text = "DVD"
        '
        'cb_abd
        '
        Me.cb_abd.BackColor = System.Drawing.Color.SlateGray
        Me.cb_abd.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_abd.ForeColor = System.Drawing.Color.Beige
        Me.cb_abd.Location = New System.Drawing.Point(15, 12)
        Me.cb_abd.Name = "cb_abd"
        Me.cb_abd.Size = New System.Drawing.Size(118, 30)
        Me.cb_abd.TabIndex = 66
        Me.cb_abd.Text = "Air bag duplo"
        '
        'cb_alarme
        '
        Me.cb_alarme.BackColor = System.Drawing.Color.SlateGray
        Me.cb_alarme.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_alarme.ForeColor = System.Drawing.Color.Beige
        Me.cb_alarme.Location = New System.Drawing.Point(15, 36)
        Me.cb_alarme.Name = "cb_alarme"
        Me.cb_alarme.Size = New System.Drawing.Size(118, 30)
        Me.cb_alarme.TabIndex = 65
        Me.cb_alarme.Text = "Alarme"
        '
        'cb_limpa
        '
        Me.cb_limpa.BackColor = System.Drawing.Color.SlateGray
        Me.cb_limpa.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_limpa.ForeColor = System.Drawing.Color.Beige
        Me.cb_limpa.Location = New System.Drawing.Point(170, 66)
        Me.cb_limpa.Name = "cb_limpa"
        Me.cb_limpa.Size = New System.Drawing.Size(118, 30)
        Me.cb_limpa.TabIndex = 63
        Me.cb_limpa.Text = "Limpador traseiro"
        '
        'cb_abs
        '
        Me.cb_abs.BackColor = System.Drawing.Color.SlateGray
        Me.cb_abs.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_abs.ForeColor = System.Drawing.Color.Beige
        Me.cb_abs.Location = New System.Drawing.Point(170, 38)
        Me.cb_abs.Name = "cb_abs"
        Me.cb_abs.Size = New System.Drawing.Size(118, 28)
        Me.cb_abs.TabIndex = 62
        Me.cb_abs.Text = "Freio ABS"
        '
        'CBVE
        '
        Me.CBVE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBVE.Location = New System.Drawing.Point(170, 188)
        Me.CBVE.Name = "CBVE"
        Me.CBVE.Size = New System.Drawing.Size(124, 15)
        Me.CBVE.TabIndex = 59
        Me.CBVE.Text = "Vidros ElÈtricos"
        '
        'CBSOM
        '
        Me.CBSOM.BackColor = System.Drawing.Color.SlateGray
        Me.CBSOM.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSOM.ForeColor = System.Drawing.Color.Beige
        Me.CBSOM.Location = New System.Drawing.Point(170, 102)
        Me.CBSOM.Name = "CBSOM"
        Me.CBSOM.Size = New System.Drawing.Size(72, 15)
        Me.CBSOM.TabIndex = 54
        Me.CBSOM.Text = "Som"
        '
        'cb_teto
        '
        Me.cb_teto.BackColor = System.Drawing.Color.SlateGray
        Me.cb_teto.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_teto.ForeColor = System.Drawing.Color.Beige
        Me.cb_teto.Location = New System.Drawing.Point(170, 130)
        Me.cb_teto.Name = "cb_teto"
        Me.cb_teto.Size = New System.Drawing.Size(118, 15)
        Me.cb_teto.TabIndex = 60
        Me.cb_teto.Text = "Teto Solar"
        '
        'CBTE
        '
        Me.CBTE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTE.Location = New System.Drawing.Point(170, 159)
        Me.CBTE.Name = "CBTE"
        Me.CBTE.Size = New System.Drawing.Size(128, 14)
        Me.CBTE.TabIndex = 55
        Me.CBTE.Text = "Travas ElÈtricas"
        '
        'Cb_blindado
        '
        Me.Cb_blindado.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_blindado.Location = New System.Drawing.Point(15, 158)
        Me.Cb_blindado.Name = "Cb_blindado"
        Me.Cb_blindado.Size = New System.Drawing.Size(144, 15)
        Me.Cb_blindado.TabIndex = 176
        Me.Cb_blindado.Text = "Blindado"
        '
        'cmbcond
        '
        Me.cmbcond.Items.AddRange(New Object() {"D - Disponivel", "A - Alugado"})
        Me.cmbcond.Location = New System.Drawing.Point(296, 240)
        Me.cmbcond.Name = "cmbcond"
        Me.cmbcond.Size = New System.Drawing.Size(112, 20)
        Me.cmbcond.TabIndex = 227
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Beige
        Me.Label11.Location = New System.Drawing.Point(208, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 22)
        Me.Label11.TabIndex = 228
        Me.Label11.Text = "CondiÁ„o"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Beige
        Me.Label9.Location = New System.Drawing.Point(0, 336)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 22)
        Me.Label9.TabIndex = 229
        Me.Label9.Text = "PotÍncia"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bt_imports
        '
        Me.bt_imports.BackColor = System.Drawing.Color.White
        Me.bt_imports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_imports.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_imports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_imports.Font = New System.Drawing.Font("Arial", 9.05!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.bt_imports.Image = CType(resources.GetObject("bt_imports.Image"), System.Drawing.Image)
        Me.bt_imports.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_imports.Location = New System.Drawing.Point(24, 384)
        Me.bt_imports.Name = "bt_imports"
        Me.bt_imports.Size = New System.Drawing.Size(65, 75)
        Me.bt_imports.TabIndex = 233
        Me.bt_imports.Text = "Importar"
        Me.bt_imports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_export
        '
        Me.bt_export.BackColor = System.Drawing.Color.White
        Me.bt_export.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_export.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_export.Font = New System.Drawing.Font("Arial", 9.05!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.bt_export.Image = CType(resources.GetObject("bt_export.Image"), System.Drawing.Image)
        Me.bt_export.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.bt_export.Location = New System.Drawing.Point(120, 384)
        Me.bt_export.Name = "bt_export"
        Me.bt_export.Size = New System.Drawing.Size(65, 75)
        Me.bt_export.TabIndex = 234
        Me.bt_export.Text = "Exportar"
        Me.bt_export.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lk_another
        '
        Me.lk_another.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lk_another.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lk_another.LinkColor = System.Drawing.Color.OrangeRed
        Me.lk_another.Location = New System.Drawing.Point(96, 440)
        Me.lk_another.Name = "lk_another"
        Me.lk_another.Size = New System.Drawing.Size(224, 16)
        Me.lk_another.TabIndex = 235
        Me.lk_another.TabStop = True
        Me.lk_another.Text = "Localizar outro ve˙Äulo para importar"
        Me.lk_another.Visible = False
        '
        'txt_renavam
        '
        Me.txt_renavam.AccessibleName = "R$"
        Me.txt_renavam.Location = New System.Drawing.Point(88, 208)
        Me.txt_renavam.MaxLength = 9
        Me.txt_renavam.Name = "txt_renavam"
        Me.txt_renavam.TabIndex = 236
        Me.txt_renavam.Text = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Beige
        Me.Label10.Location = New System.Drawing.Point(0, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 32)
        Me.Label10.TabIndex = 237
        Me.Label10.Text = "CÛdigo RENAVAM"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lk_export
        '
        Me.lk_export.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lk_export.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lk_export.LinkColor = System.Drawing.Color.OrangeRed
        Me.lk_export.Location = New System.Drawing.Point(96, 440)
        Me.lk_export.Name = "lk_export"
        Me.lk_export.Size = New System.Drawing.Size(224, 16)
        Me.lk_export.TabIndex = 238
        Me.lk_export.TabStop = True
        Me.lk_export.Text = "Localizar outro ve˙Äulo para exportar"
        Me.lk_export.Visible = False
        '
        'bt_export2
        '
        Me.bt_export2.BackColor = System.Drawing.Color.White
        Me.bt_export2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_export2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_export2.Font = New System.Drawing.Font("Arial", 9.05!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.bt_export2.Image = CType(resources.GetObject("bt_export2.Image"), System.Drawing.Image)
        Me.bt_export2.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.bt_export2.Location = New System.Drawing.Point(24, 384)
        Me.bt_export2.Name = "bt_export2"
        Me.bt_export2.Size = New System.Drawing.Size(65, 75)
        Me.bt_export2.TabIndex = 239
        Me.bt_export2.Text = "Exportar"
        Me.bt_export2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_export2.Visible = False
        '
        'txtpot
        '
        Me.txtpot.DecimalPlaces = 1
        Me.txtpot.Increment = New Decimal(New Integer() {2, 0, 0, 65536})
        Me.txtpot.Location = New System.Drawing.Point(88, 336)
        Me.txtpot.Name = "txtpot"
        Me.txtpot.Size = New System.Drawing.Size(96, 19)
        Me.txtpot.TabIndex = 247
        Me.txtpot.Value = New Decimal(New Integer() {10, 0, 0, 65536})
        '
        'cadastro_vei_alu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(808, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtpot)
        Me.Controls.Add(Me.bt_imports)
        Me.Controls.Add(Me.bt_export2)
        Me.Controls.Add(Me.lk_another)
        Me.Controls.Add(Me.lk_export)
        Me.Controls.Add(Me.txt_renavam)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.bt_export)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbcond)
        Me.Controls.Add(Me.cb_ano)
        Me.Controls.Add(Me.cb_cor)
        Me.Controls.Add(Me.cb_comb)
        Me.Controls.Add(Me.grpimagem)
        Me.Controls.Add(Me.cb_versao)
        Me.Controls.Add(Me.Cb_modelo)
        Me.Controls.Add(Me.marca_vei)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bt_search)
        Me.Controls.Add(Me.cmbporta)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtchassi)
        Me.Controls.Add(Me.voltar)
        Me.Controls.Add(Me.bt_print)
        Me.Controls.Add(Me.bt_change)
        Me.Controls.Add(Me.txt_diaria)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.txtplaca)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcod_vei)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.Label20)
        Me.MaximizeBox = False
        Me.Name = "cadastro_vei_alu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Veiculos de aluguÈis"
        Me.grpimagem.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.txtpot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Import"

    Private Sub bt_imports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imports.Click
        'Verificacao baaasica
        If txtcod_vei.Text = "" Then
            MsgBox("Dever·s informar o ve˙Äulo a ser importado primeiro", MsgBoxStyle.Information, "Selecionar veiculo")
            locvei_venda_usado.ShowDialog()
            Exit Sub
        ElseIf txt_diaria.Text = "" Then
            MsgBox("Por favor, insira o valor da di·ria do ve˙Äulo", MsgBoxStyle.Information, "Valor da diaria: vazio")
            Exit Sub
        End If


        If MessageBox.Show("Nota: Se importar este ve˙Äulo, este n„o ficarÅEmais dispon˙el na seÁ„o de ve˙Äulos usados", "Deseja realmente importar???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


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

            'Variaveis
            Dim preco_compra As String
            Dim Name_cli As String
            Dim cod_cli As String
            Dim imagem As String

            Dim Comando As OleDbCommand
            Dim dr As OleDbDataReader

            'Puxar alguns dados
            Comando = New OleDbCommand("select * from veiculos_venda_usado where cod_vei=" & txtcod_vei.Text, Conexao)
            AbrirBD()
            dr = Comando.ExecuteReader
            If dr.Read Then
                Name_cli = dr("nome_cli")
                cod_cli = dr("cod_cli")
                preco_compra = dr("preco_compra_vei")
                imagem = dr("img_vei")
            End If
            dr.Close()

            'Deletando da tabela de veiculos usados
            Comando = New OleDbCommand("delete from veiculos_venda_usado where cod_vei=@cod", Conexao)
            Comando.Parameters.Add(New OleDbParameter("@cod", OleDbType.Integer, 50))
            Comando.Parameters("@cod").Value = Me.txtcod_vei.Text.ToString
            Comando.ExecuteNonQuery()

            'Codigo para registo na tabela de veiculos de alugueis
            Comando = New OleDbCommand("insert into veiculos_alu(estado_vei,diaria_vei,cod_cli,cod_renavam_vei,nome_cli,modelo_vei,marca_vei,versao_vei,ano_vei,placa_vei,comb_vei,tipo_vei,pot_vei,cor_vei,porta_vei,chassi_vei,preco_compra_vei,img_vei,ar_vei,direcao_vei,som_vei,dvd_vei,vidro_vei,trava_vei,airbagduplo_vei,alarme_vei,arquente_vei,bancocouro_vei,blindado_vei,desembaca_tras_vei,freioabs_vei,limptraseiro_vei,tetosolar_vei) values (@estado_vei,@diaria,@cod_cli,@codrenavam,@nome_cli,@modelo,@marca,@versao,@ano,@placa,@comb,@tipo,@pot,@cor,@porta,@chassi,@precocompra,'" & imagem.ToString & "'," & ac & DH & som & dvd & VE & TE & ABD & ALARME & ArQuente & Banco & Blindado & Desembaca & Freio & Limpa & Teto & ")", Conexao)
            With Comando
                .Parameters.Add(New OleDbParameter("@estado_vei", OleDbType.VarChar, 50))
                .Parameters("@estado_vei").Value = cmbcond.Text
                .Parameters.Add(New OleDbParameter("@diaria", OleDbType.VarChar, 50))
                .Parameters("@diaria").Value = txt_diaria.Text
                .Parameters.Add(New OleDbParameter("@cod_cli", OleDbType.Numeric, 50))
                .Parameters("@cod_cli").Value = cod_cli
                .Parameters.Add(New OleDbParameter("@codrenavam", OleDbType.Numeric, 50))
                .Parameters("@codrenavam").Value = txt_renavam.Text
                .Parameters.Add(New OleDbParameter("@nome_cli", OleDbType.VarChar, 50))
                .Parameters("@nome_cli").Value = Name_cli
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
                .Parameters.Add(New OleDbParameter("@porta", OleDbType.VarChar, 50))
                .Parameters("@porta").Value = cmbporta.Text.ToString
                .Parameters.Add(New OleDbParameter("@chassi", OleDbType.VarChar, 50))
                .Parameters("@chassi").Value = txtchassi.Text.ToString
                .Parameters.Add(New OleDbParameter("@precocompra", OleDbType.VarChar, 50))
                .Parameters("@precocompra").Value = preco_compra
            End With

            Try
                Comando.ExecuteNonQuery()
                MessageBox.Show("Registro importado para aluguÈis", "ImportaÁ„o de Ve˙Äulo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Erro")
            End Try
            FecharBD()
            bt_export.Visible = True
            bt_change.Visible = True
            lk_another.Visible = False


            Dim Controle As New Control
            For Each Controle In cadastro_veiculos_aluguel.Controls
                If TypeOf Controle Is TextBox Or TypeOf Controle Is ComboBox Or TypeOf Controle Is CheckBox Then
                    Controle.Enabled = True
                End If
            Next
            For Each Controle In cadastro_veiculos_aluguel.GroupBox7.Controls
                If TypeOf Controle Is CheckBox Then
                    Controle.Enabled = True
                End If
            Next
            txtpot.Enabled = True
            txtcod_vei.ReadOnly = True

        End If
    End Sub

    Private Sub lk_export_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lk_export.LinkClicked
        locvei.ShowDialog()
    End Sub

    Private Sub lk_another_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lk_another.LinkClicked
        locvei_venda_usado.ShowDialog()
    End Sub

#End Region

#Region "Export"

    Private Sub bt_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_export.Click
        'Verificacao baaasica
        If txtcod_vei.Text = "" Then
            MsgBox("Deveras informar o veiculo a ser exportado primeiro", MsgBoxStyle.Information, "Selecionar veiculo")
            locvei.ShowDialog()
            Exit Sub
        End If
    End Sub

    Private Sub bt_export2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_export2.Click
        'Verificacao baaasica
        If txtcod_vei.Text = "" Then
            MsgBox("Deveras informar o veiculo a ser exportado primeiro", MsgBoxStyle.Information, "Selecionar veiculo")
            locvei.ShowDialog()
            Exit Sub
        End If


        If MessageBox.Show("Nota: Se exportar este veiculo, nao ficara mais disponivel na secao de alugueis", "Deseja realmente exportar???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


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

            'Variaveis
            Dim preco_compra As String
            Dim Name_cli As String
            Dim cod_cli As String
            Dim imagem As String

            Dim Comando As OleDbCommand
            Dim dr As OleDbDataReader

            'Puxar alguns dados
            Comando = New OleDbCommand("select * from veiculos_alu where cod_vei=" & txtcod_vei.Text, Conexao)
            AbrirBD()
            dr = Comando.ExecuteReader
            If dr.Read Then
                Name_cli = dr("nome_cli")
                cod_cli = dr("cod_cli")
                preco_compra = dr("preco_compra_vei")
                imagem = dr("img_vei")
            End If
            dr.Close()

            'Deletando da tabela de veiculos alugados
            Comando = New OleDbCommand("delete from veiculos_alu where cod_vei=@cod", Conexao)
            Comando.Parameters.Add(New OleDbParameter("@cod", OleDbType.Integer, 50))
            Comando.Parameters("@cod").Value = Me.txtcod_vei.Text.ToString
            Comando.ExecuteNonQuery()

            'Codigo para registo na tabela de veiculos de veiculos usados

            Comando = New OleDbCommand("insert into veiculos_venda_usado(cod_cli,cod_renavam_vei,nome_cli,modelo_vei,marca_vei,versao_vei,ano_vei,quilometragem_vei,placa_vei,comb_vei,tipo_vei,pot_vei,cor_vei,porta_vei,chassi_vei,preco_compra_vei,preco_venda_vei,img_vei,ar_vei,direcao_vei,som_vei,dvd_vei,vidro_vei,trava_vei,airbagduplo_vei,alarme_vei,arquente_vei,bancocouro_vei,blindado_vei,desembaca_tras_vei,freioabs_vei,limptraseiro_vei,tetosolar_vei) values (@cod_cli,@codrenavam,@nome_cli,@modelo,@marca,@versao,@ano,@quilometragem,@placa,@comb,@tipo,@pot,@cor,@porta,@chassi,@precocompra,@precovenda,'" & imagem.ToString & "'," & ac & DH & som & dvd & VE & TE & ABD & ALARME & ArQuente & Banco & Blindado & Desembaca & Freio & Limpa & Teto & ")", Conexao)
            With Comando
                .Parameters.Add(New OleDbParameter("@cod_cli", OleDbType.Numeric, 50))
                .Parameters("@cod_cli").Value = cod_cli
                .Parameters.Add(New OleDbParameter("@codrenavam", OleDbType.Numeric, 50))
                .Parameters("@codrenavam").Value = txt_renavam.Text
                .Parameters.Add(New OleDbParameter("@nome_cli", OleDbType.VarChar, 50))
                .Parameters("@nome_cli").Value = Name_cli
                .Parameters.Add(New OleDbParameter("@modelo", OleDbType.VarChar, 50))
                .Parameters("@modelo").Value = Cb_modelo.Text.ToString
                .Parameters.Add(New OleDbParameter("@marca", OleDbType.VarChar, 50))
                .Parameters("@marca").Value = marca_vei.Text.ToString
                .Parameters.Add(New OleDbParameter("@versao", OleDbType.VarChar, 50))
                .Parameters("@versao").Value = cb_versao.Text.ToString
                .Parameters.Add(New OleDbParameter("@ano", OleDbType.VarChar, 50))
                .Parameters("@ano").Value = cb_ano.Text.ToString
                .Parameters.Add(New OleDbParameter("@quilometragem", OleDbType.VarChar, 50))
                .Parameters("@quilometragem").Value = "*Atualizar Quilometragem*"
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
                .Parameters.Add(New OleDbParameter("@porta", OleDbType.VarChar, 50))
                .Parameters("@porta").Value = cmbporta.Text.ToString
                .Parameters.Add(New OleDbParameter("@chassi", OleDbType.VarChar, 50))
                .Parameters("@chassi").Value = txtchassi.Text.ToString
                .Parameters.Add(New OleDbParameter("@precocompra", OleDbType.VarChar, 50))
                .Parameters("@precocompra").Value = preco_compra
                .Parameters.Add(New OleDbParameter("@precovenda", OleDbType.VarChar, 50))
                .Parameters("@precovenda").Value = Val(preco_compra * 1.2)
            End With
            Try
                Comando.ExecuteNonQuery()
                MessageBox.Show("Registro exportado para secao de veiculos usados", "Exportacao de Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Erro")
            End Try
            FecharBD()
            txtcod_vei.Text = ""

            bt_imports.Visible = True
            bt_change.Visible = True
            lk_another.Visible = False


        End If
    End Sub

#End Region

#Region "Change"

#End Region

    Private Sub voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles voltar.Click
        Me.Visible = False
        Aluguel.Visible = True
    End Sub

    Private Sub bt_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_search.Click
        locvei.ShowDialog()
    End Sub

    Private Sub cadastro_vei_alu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
