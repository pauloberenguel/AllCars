#Region "Imports"
Imports AllCars.Module1
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Drawing.Image
#End Region

Public Class Cadastrar_veiculo_usado
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
    Friend WithEvents marca_vei As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Limpar As System.Windows.Forms.Button
    Friend WithEvents voltar As System.Windows.Forms.Button
    Friend WithEvents Excluir As System.Windows.Forms.Button
    Friend WithEvents Imprimir As System.Windows.Forms.Button
    Friend WithEvents alterar_venda As System.Windows.Forms.Button
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grpimagem As System.Windows.Forms.GroupBox
    Friend WithEvents Pctemp As System.Windows.Forms.PictureBox
    Friend WithEvents bt_obter As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_codcli As System.Windows.Forms.TextBox
    Friend WithEvents cb_cli As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_vvenda As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Cb_modelo As System.Windows.Forms.ComboBox
    Friend WithEvents cb_cor As System.Windows.Forms.ComboBox
    Friend WithEvents cb_teto As System.Windows.Forms.CheckBox
    Friend WithEvents cb_desembaca As System.Windows.Forms.CheckBox
    Friend WithEvents cb_abs As System.Windows.Forms.CheckBox
    Friend WithEvents cb_limpa As System.Windows.Forms.CheckBox
    Friend WithEvents cb_alarme As System.Windows.Forms.CheckBox
    Friend WithEvents cb_abd As System.Windows.Forms.CheckBox
    Friend WithEvents cb_arquente As System.Windows.Forms.CheckBox
    Friend WithEvents Cb_banco As System.Windows.Forms.CheckBox
    Friend WithEvents Cb_blindado As System.Windows.Forms.CheckBox
    Friend WithEvents cb_dono As System.Windows.Forms.CheckBox
    Friend WithEvents cb_comb As System.Windows.Forms.ComboBox
    Friend WithEvents cb_ano As System.Windows.Forms.ComboBox
    Friend WithEvents cb_versao As System.Windows.Forms.ComboBox
    Friend WithEvents txt_quilometragem As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rb_excluir As System.Windows.Forms.RadioButton
    Friend WithEvents rb_alterar As System.Windows.Forms.RadioButton
    Friend WithEvents pc_del As System.Windows.Forms.PictureBox
    Friend WithEvents pc_change As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_renavam As System.Windows.Forms.TextBox
    Friend WithEvents txttipo As System.Windows.Forms.ComboBox
    Friend WithEvents status As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents txtpot As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Cadastrar_veiculo_usado))
        Me.marca_vei = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
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
        Me.bot_localizar = New System.Windows.Forms.Button
        Me.cmbporta = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtchassi = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Limpar = New System.Windows.Forms.Button
        Me.voltar = New System.Windows.Forms.Button
        Me.Excluir = New System.Windows.Forms.Button
        Me.Imprimir = New System.Windows.Forms.Button
        Me.alterar_venda = New System.Windows.Forms.Button
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
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.grpimagem = New System.Windows.Forms.GroupBox
        Me.Pctemp = New System.Windows.Forms.PictureBox
        Me.bt_obter = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txt_codcli = New System.Windows.Forms.TextBox
        Me.cb_cli = New System.Windows.Forms.ComboBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_vvenda = New System.Windows.Forms.TextBox
        Me.cb_dono = New System.Windows.Forms.CheckBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txt_quilometragem = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Cb_modelo = New System.Windows.Forms.ComboBox
        Me.cb_versao = New System.Windows.Forms.ComboBox
        Me.cb_comb = New System.Windows.Forms.ComboBox
        Me.cb_cor = New System.Windows.Forms.ComboBox
        Me.cb_ano = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.rb_excluir = New System.Windows.Forms.RadioButton
        Me.rb_alterar = New System.Windows.Forms.RadioButton
        Me.pc_del = New System.Windows.Forms.PictureBox
        Me.pc_change = New System.Windows.Forms.PictureBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txt_renavam = New System.Windows.Forms.TextBox
        Me.txttipo = New System.Windows.Forms.ComboBox
        Me.status = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.txtpot = New System.Windows.Forms.NumericUpDown
        Me.GroupBox7.SuspendLayout()
        Me.grpimagem.SuspendLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'marca_vei
        '
        Me.marca_vei.Location = New System.Drawing.Point(88, 52)
        Me.marca_vei.Name = "marca_vei"
        Me.marca_vei.Size = New System.Drawing.Size(144, 21)
        Me.marca_vei.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Beige
        Me.Label6.Location = New System.Drawing.Point(16, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 22)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "Versão"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.GroupBox7.Size = New System.Drawing.Size(334, 269)
        Me.GroupBox7.TabIndex = 18
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
        Me.Cb_banco.TabIndex = 22
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
        Me.cb_arquente.TabIndex = 21
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
        Me.cb_desembaca.TabIndex = 24
        Me.cb_desembaca.Text = "Desembaçador Traseiro"
        '
        'CBAC
        '
        Me.CBAC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBAC.Location = New System.Drawing.Point(15, 77)
        Me.CBAC.Name = "CBAC"
        Me.CBAC.Size = New System.Drawing.Size(131, 16)
        Me.CBAC.TabIndex = 20
        Me.CBAC.Text = "Ar Condicionado"
        '
        'CBDH
        '
        Me.CBDH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBDH.Location = New System.Drawing.Point(15, 233)
        Me.CBDH.Name = "CBDH"
        Me.CBDH.Size = New System.Drawing.Size(144, 16)
        Me.CBDH.TabIndex = 25
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
        Me.CBDVD.TabIndex = 26
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
        Me.cb_abd.TabIndex = 18
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
        Me.cb_alarme.TabIndex = 19
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
        Me.cb_limpa.TabIndex = 28
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
        Me.cb_abs.TabIndex = 27
        Me.cb_abs.Text = "Freio ABS"
        '
        'CBVE
        '
        Me.CBVE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBVE.Location = New System.Drawing.Point(170, 204)
        Me.CBVE.Name = "CBVE"
        Me.CBVE.Size = New System.Drawing.Size(124, 16)
        Me.CBVE.TabIndex = 32
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
        Me.CBSOM.TabIndex = 29
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
        Me.cb_teto.TabIndex = 30
        Me.cb_teto.Text = "Teto Solar"
        '
        'CBTE
        '
        Me.CBTE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTE.Location = New System.Drawing.Point(170, 172)
        Me.CBTE.Name = "CBTE"
        Me.CBTE.Size = New System.Drawing.Size(128, 15)
        Me.CBTE.TabIndex = 31
        Me.CBTE.Text = "Travas Elétricas"
        '
        'Cb_blindado
        '
        Me.Cb_blindado.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_blindado.Location = New System.Drawing.Point(15, 171)
        Me.Cb_blindado.Name = "Cb_blindado"
        Me.Cb_blindado.Size = New System.Drawing.Size(144, 16)
        Me.Cb_blindado.TabIndex = 23
        Me.Cb_blindado.Text = "Blindado"
        '
        'bot_localizar
        '
        Me.bot_localizar.BackColor = System.Drawing.Color.White
        Me.bot_localizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_localizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bot_localizar.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_localizar.Image = CType(resources.GetObject("bot_localizar.Image"), System.Drawing.Image)
        Me.bot_localizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bot_localizar.Location = New System.Drawing.Point(16, 511)
        Me.bot_localizar.Name = "bot_localizar"
        Me.bot_localizar.Size = New System.Drawing.Size(168, 49)
        Me.bot_localizar.TabIndex = 37
        Me.bot_localizar.Text = "Localizar"
        Me.bot_localizar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cmbporta
        '
        Me.cmbporta.Items.AddRange(New Object() {"2", "3", "4"})
        Me.cmbporta.Location = New System.Drawing.Point(96, 364)
        Me.cmbporta.Name = "cmbporta"
        Me.cmbporta.Size = New System.Drawing.Size(40, 21)
        Me.cmbporta.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Beige
        Me.Label14.Location = New System.Drawing.Point(8, 364)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 31)
        Me.Label14.TabIndex = 158
        Me.Label14.Text = "N‹ de Portas"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtchassi
        '
        Me.txtchassi.AccessibleName = "R$"
        Me.txtchassi.Location = New System.Drawing.Point(272, 260)
        Me.txtchassi.MaxLength = 17
        Me.txtchassi.Name = "txtchassi"
        Me.txtchassi.TabIndex = 11
        Me.txtchassi.Text = ""
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Beige
        Me.Label13.Location = New System.Drawing.Point(216, 260)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 24)
        Me.Label13.TabIndex = 156
        Me.Label13.Text = "Chassi"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Beige
        Me.Label12.Location = New System.Drawing.Point(40, 225)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 23)
        Me.Label12.TabIndex = 155
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
        Me.Limpar.TabIndex = 35
        Me.Limpar.Text = "Limpar"
        Me.Limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.voltar.Location = New System.Drawing.Point(336, 416)
        Me.voltar.Name = "voltar"
        Me.voltar.Size = New System.Drawing.Size(65, 81)
        Me.voltar.TabIndex = 36
        Me.voltar.Text = "Voltar"
        Me.voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Excluir
        '
        Me.Excluir.BackColor = System.Drawing.Color.White
        Me.Excluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Excluir.Enabled = False
        Me.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Excluir.Font = New System.Drawing.Font("Arial", 10.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Excluir.Location = New System.Drawing.Point(176, 416)
        Me.Excluir.Name = "Excluir"
        Me.Excluir.Size = New System.Drawing.Size(65, 81)
        Me.Excluir.TabIndex = 153
        Me.Excluir.Text = "Excluir"
        Me.Excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Imprimir
        '
        Me.Imprimir.BackColor = System.Drawing.Color.White
        Me.Imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Imprimir.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Image)
        Me.Imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Imprimir.Location = New System.Drawing.Point(232, 511)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(160, 49)
        Me.Imprimir.TabIndex = 38
        Me.Imprimir.Text = "Imprimir"
        Me.Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'alterar_venda
        '
        Me.alterar_venda.BackColor = System.Drawing.Color.White
        Me.alterar_venda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.alterar_venda.Enabled = False
        Me.alterar_venda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.alterar_venda.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alterar_venda.Image = CType(resources.GetObject("alterar_venda.Image"), System.Drawing.Image)
        Me.alterar_venda.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.alterar_venda.Location = New System.Drawing.Point(256, 416)
        Me.alterar_venda.Name = "alterar_venda"
        Me.alterar_venda.Size = New System.Drawing.Size(65, 81)
        Me.alterar_venda.TabIndex = 151
        Me.alterar_venda.Text = "Alterar"
        Me.alterar_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cadastro_venda
        '
        Me.cadastro_venda.BackColor = System.Drawing.Color.White
        Me.cadastro_venda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cadastro_venda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cadastro_venda.Font = New System.Drawing.Font("Arial", 9.05!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.cadastro_venda.Image = CType(resources.GetObject("cadastro_venda.Image"), System.Drawing.Image)
        Me.cadastro_venda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cadastro_venda.Location = New System.Drawing.Point(16, 416)
        Me.cadastro_venda.Name = "cadastro_venda"
        Me.cadastro_venda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cadastro_venda.Size = New System.Drawing.Size(65, 81)
        Me.cadastro_venda.TabIndex = 34
        Me.cadastro_venda.Text = "Comprar"
        Me.cadastro_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtval
        '
        Me.txtval.AccessibleName = "R$"
        Me.txtval.Location = New System.Drawing.Point(272, 295)
        Me.txtval.Name = "txtval"
        Me.txtval.TabIndex = 13
        Me.txtval.Text = ""
        '
        'txtplaca
        '
        Me.txtplaca.Location = New System.Drawing.Point(88, 295)
        Me.txtplaca.MaxLength = 7
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.TabIndex = 12
        Me.txtplaca.Text = ""
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Beige
        Me.Label9.Location = New System.Drawing.Point(8, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 24)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "Potência"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Beige
        Me.Label8.Location = New System.Drawing.Point(32, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 23)
        Me.Label8.TabIndex = 136
        Me.Label8.Text = "Tipo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Beige
        Me.Label5.Location = New System.Drawing.Point(0, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 22)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "Combustível"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Beige
        Me.Label4.Location = New System.Drawing.Point(24, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "Placa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Beige
        Me.Label2.Location = New System.Drawing.Point(240, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 22)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Ano"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(240, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Modelo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcod_vei
        '
        Me.txtcod_vei.Enabled = False
        Me.txtcod_vei.Location = New System.Drawing.Point(360, 26)
        Me.txtcod_vei.Name = "txtcod_vei"
        Me.txtcod_vei.ReadOnly = True
        Me.txtcod_vei.Size = New System.Drawing.Size(80, 20)
        Me.txtcod_vei.TabIndex = 129
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
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Comprar Veiculo"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Beige
        Me.Label16.Location = New System.Drawing.Point(336, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 23)
        Me.Label16.TabIndex = 130
        Me.Label16.Text = "Código do Veículo"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Beige
        Me.Label7.Location = New System.Drawing.Point(184, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 31)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Preço de Compra"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpimagem
        '
        Me.grpimagem.Controls.Add(Me.Pctemp)
        Me.grpimagem.Controls.Add(Me.bt_obter)
        Me.grpimagem.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grpimagem.ForeColor = System.Drawing.Color.Beige
        Me.grpimagem.Location = New System.Drawing.Point(416, 269)
        Me.grpimagem.Name = "grpimagem"
        Me.grpimagem.Size = New System.Drawing.Size(384, 294)
        Me.grpimagem.TabIndex = 33
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
        Me.bt_obter.Location = New System.Drawing.Point(128, 271)
        Me.bt_obter.Name = "bt_obter"
        Me.bt_obter.Size = New System.Drawing.Size(120, 23)
        Me.bt_obter.TabIndex = 33
        Me.bt_obter.Text = "Obter Foto"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Beige
        Me.Label11.Location = New System.Drawing.Point(16, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 163
        Me.Label11.Text = "Cliente"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Beige
        Me.Label15.Location = New System.Drawing.Point(248, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 23)
        Me.Label15.TabIndex = 164
        Me.Label15.Text = "Cod. Cliente"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_codcli
        '
        Me.txt_codcli.Location = New System.Drawing.Point(336, 121)
        Me.txt_codcli.Name = "txt_codcli"
        Me.txt_codcli.ReadOnly = True
        Me.txt_codcli.Size = New System.Drawing.Size(104, 20)
        Me.txt_codcli.TabIndex = 165
        Me.txt_codcli.Text = ""
        '
        'cb_cli
        '
        Me.cb_cli.Location = New System.Drawing.Point(88, 121)
        Me.cb_cli.Name = "cb_cli"
        Me.cb_cli.Size = New System.Drawing.Size(144, 21)
        Me.cb_cli.TabIndex = 5
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Aqua
        Me.LinkLabel1.Location = New System.Drawing.Point(16, 156)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(96, 17)
        Me.LinkLabel1.TabIndex = 60
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Buscar Cliente"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Beige
        Me.Label17.Location = New System.Drawing.Point(184, 321)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 31)
        Me.Label17.TabIndex = 167
        Me.Label17.Text = "Preço de venda"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_vvenda
        '
        Me.txt_vvenda.Location = New System.Drawing.Point(272, 329)
        Me.txt_vvenda.Name = "txt_vvenda"
        Me.txt_vvenda.TabIndex = 15
        Me.txt_vvenda.Text = ""
        '
        'cb_dono
        '
        Me.cb_dono.BackColor = System.Drawing.Color.SlateGray
        Me.cb_dono.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_dono.ForeColor = System.Drawing.Color.Beige
        Me.cb_dono.Location = New System.Drawing.Point(256, 373)
        Me.cb_dono.Name = "cb_dono"
        Me.cb_dono.Size = New System.Drawing.Size(118, 17)
        Me.cb_dono.TabIndex = 17
        Me.cb_dono.Text = "Único Dono?"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Beige
        Me.Label18.Location = New System.Drawing.Point(144, 156)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 23)
        Me.Label18.TabIndex = 170
        Me.Label18.Text = "Quilometragem"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_quilometragem
        '
        Me.txt_quilometragem.Location = New System.Drawing.Point(256, 156)
        Me.txt_quilometragem.Name = "txt_quilometragem"
        Me.txt_quilometragem.Size = New System.Drawing.Size(184, 20)
        Me.txt_quilometragem.TabIndex = 6
        Me.txt_quilometragem.Text = ""
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Beige
        Me.Label19.Location = New System.Drawing.Point(16, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 23)
        Me.Label19.TabIndex = 172
        Me.Label19.Text = "Marca"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cb_modelo
        '
        Me.Cb_modelo.Location = New System.Drawing.Point(296, 52)
        Me.Cb_modelo.Name = "Cb_modelo"
        Me.Cb_modelo.Size = New System.Drawing.Size(144, 21)
        Me.Cb_modelo.TabIndex = 2
        '
        'cb_versao
        '
        Me.cb_versao.Location = New System.Drawing.Point(88, 87)
        Me.cb_versao.Name = "cb_versao"
        Me.cb_versao.Size = New System.Drawing.Size(144, 21)
        Me.cb_versao.TabIndex = 3
        '
        'cb_comb
        '
        Me.cb_comb.Items.AddRange(New Object() {"Alcool", "Alcool e Gas Natural", "Diesel", "Gas Natural", "Gasolina", "Gasolina e Alcool", "Gasolina e Gas Natural", "Gasolina, Alcool e Gas Natural", "Gasolina, Alcool, Gas Natural e Benzina"})
        Me.cb_comb.Location = New System.Drawing.Point(88, 191)
        Me.cb_comb.Name = "cb_comb"
        Me.cb_comb.Size = New System.Drawing.Size(288, 21)
        Me.cb_comb.TabIndex = 7
        '
        'cb_cor
        '
        Me.cb_cor.Items.AddRange(New Object() {"Amarelo", "Azul", "Beje", "Branco", "Cinza", "Dourado", "Indefinida", "Laranja", "Marrom", "Prata", "Preto", "Roxo", "Verde", "Vermelho", "Vinho"})
        Me.cb_cor.Location = New System.Drawing.Point(88, 225)
        Me.cb_cor.Name = "cb_cor"
        Me.cb_cor.Size = New System.Drawing.Size(104, 21)
        Me.cb_cor.TabIndex = 8
        '
        'cb_ano
        '
        Me.cb_ano.Location = New System.Drawing.Point(296, 87)
        Me.cb_ano.Name = "cb_ano"
        Me.cb_ano.Size = New System.Drawing.Size(144, 21)
        Me.cb_ano.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(4, 407)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(400, 157)
        Me.Label10.TabIndex = 179
        '
        'rb_excluir
        '
        Me.rb_excluir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.rb_excluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_excluir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rb_excluir.Location = New System.Drawing.Point(176, 485)
        Me.rb_excluir.Name = "rb_excluir"
        Me.rb_excluir.Size = New System.Drawing.Size(72, 18)
        Me.rb_excluir.TabIndex = 180
        Me.rb_excluir.Text = "Excluir"
        Me.rb_excluir.Visible = False
        '
        'rb_alterar
        '
        Me.rb_alterar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.rb_alterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_alterar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rb_alterar.Location = New System.Drawing.Point(256, 485)
        Me.rb_alterar.Name = "rb_alterar"
        Me.rb_alterar.Size = New System.Drawing.Size(72, 18)
        Me.rb_alterar.TabIndex = 181
        Me.rb_alterar.Text = "Alterar"
        Me.rb_alterar.Visible = False
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
        Me.pc_del.TabIndex = 182
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
        Me.pc_change.TabIndex = 183
        Me.pc_change.TabStop = False
        Me.pc_change.Visible = False
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Beige
        Me.Label20.Location = New System.Drawing.Point(200, 217)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 34)
        Me.Label20.TabIndex = 184
        Me.Label20.Text = "Codigo RENAVAM"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_renavam
        '
        Me.txt_renavam.AccessibleName = "R$"
        Me.txt_renavam.Location = New System.Drawing.Point(272, 225)
        Me.txt_renavam.MaxLength = 9
        Me.txt_renavam.Name = "txt_renavam"
        Me.txt_renavam.TabIndex = 9
        Me.txt_renavam.Text = ""
        '
        'txttipo
        '
        Me.txttipo.Items.AddRange(New Object() {"Carro", "Moto", "Pick-up", "Van", "Caminhao/Rebocador", "Onibus/Microonibus"})
        Me.txttipo.Location = New System.Drawing.Point(88, 260)
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
        Me.status.Size = New System.Drawing.Size(806, 22)
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
        'txtpot
        '
        Me.txtpot.DecimalPlaces = 1
        Me.txtpot.Increment = New Decimal(New Integer() {2, 0, 0, 65536})
        Me.txtpot.Location = New System.Drawing.Point(88, 329)
        Me.txtpot.Name = "txtpot"
        Me.txtpot.Size = New System.Drawing.Size(96, 20)
        Me.txtpot.TabIndex = 247
        Me.txtpot.Value = New Decimal(New Integer() {10, 0, 0, 65536})
        '
        'Cadastrar_veiculo_usado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(806, 593)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtpot)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.txt_renavam)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.rb_excluir)
        Me.Controls.Add(Me.pc_del)
        Me.Controls.Add(Me.pc_change)
        Me.Controls.Add(Me.rb_alterar)
        Me.Controls.Add(Me.grpimagem)
        Me.Controls.Add(Me.cb_ano)
        Me.Controls.Add(Me.cb_cor)
        Me.Controls.Add(Me.cb_comb)
        Me.Controls.Add(Me.cb_versao)
        Me.Controls.Add(Me.Cb_modelo)
        Me.Controls.Add(Me.txt_quilometragem)
        Me.Controls.Add(Me.txt_vvenda)
        Me.Controls.Add(Me.txt_codcli)
        Me.Controls.Add(Me.txtchassi)
        Me.Controls.Add(Me.txtval)
        Me.Controls.Add(Me.txtplaca)
        Me.Controls.Add(Me.txtcod_vei)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cb_dono)
        Me.Controls.Add(Me.cb_cli)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.marca_vei)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bot_localizar)
        Me.Controls.Add(Me.cmbporta)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Limpar)
        Me.Controls.Add(Me.voltar)
        Me.Controls.Add(Me.Excluir)
        Me.Controls.Add(Me.Imprimir)
        Me.Controls.Add(Me.alterar_venda)
        Me.Controls.Add(Me.cadastro_venda)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cadastrar_veiculo_usado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra de veiculos usados"
        Me.GroupBox7.ResumeLayout(False)
        Me.grpimagem.ResumeLayout(False)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Obter Cliente, Marca, Modelo, Versao , Ano ..."

    Private Sub marca_vei_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles marca_vei.GotFocus
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader

        Comando = New OleDbCommand("select distinct modelo_vei from veiculos_venda_usado where marca_vei='" & marca_vei.Text.ToString & "'", Conexao)
        AbrirBD()
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                Cb_modelo.Items.Add(DR("modelo_vei"))
            End While
            DR.Close()
        Catch ex As Exception
        End Try
        FecharBD()
    End Sub

    Private Sub Cb_modelo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cb_modelo.GotFocus
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Comando = New OleDbCommand("select distinct versao_vei from veiculos_venda_usado where modelo_vei='" & Cb_modelo.Text.ToString & "'", Conexao)
        AbrirBD()
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                cb_versao.Items.Add(DR("versao_vei"))
            End While
            DR.Close()
        Catch ex As Exception
        End Try
        FecharBD()
    End Sub

    Private Sub cb_versao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_versao.GotFocus
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Try
            Comando = New OleDbCommand("select distinct ano_vei from veiculos_venda_usado where versao_vei='" & cb_versao.Text.ToString & "'", Conexao)
            AbrirBD()
            DR = Comando.ExecuteReader
            While DR.Read
                cb_ano.Items.Add(DR("ano_vei"))
            End While
            DR.Close()
        Catch ex As Exception
        End Try
        FecharBD()
    End Sub

    Private Sub cb_cli_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_cli.Leave
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Comando = New OleDbCommand("select cod_cli from clientes where nome_cli='" & cb_cli.Text.ToString & "'", Conexao)
        AbrirBD()
        Try
            DR = Comando.ExecuteReader
        If DR.Read Then
            txt_codcli.Text = DR("cod_cli")
        End If
            DR.Close()
        Catch ex As Exception
        End Try
        FecharBD()
    End Sub

    Private Sub Cadastrar_veiculo_usado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cb_cli.Items.Clear()
        Me.marca_vei.Items.Clear()

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
        cb_dono.CheckState = CheckState.Unchecked
        cb_teto.CheckState = CheckState.Unchecked
        cb_desembaca.CheckState = CheckState.Unchecked
        Cb_blindado.CheckState = CheckState.Unchecked
        cb_limpa.CheckState = CheckState.Unchecked
        cb_abs.CheckState = CheckState.Unchecked
        Cb_banco.CheckState = CheckState.Unchecked
        cb_arquente.CheckState = CheckState.Unchecked
        cb_alarme.CheckState = CheckState.Unchecked
        cb_abd.CheckState = CheckState.Unchecked

        Me.alterar_venda.Visible = True
        Me.Excluir.Visible = True
        Me.alterar_venda.Enabled = False
        Me.Excluir.Enabled = False
        Me.pc_change.Visible = False
        Me.pc_del.Visible = False
        Me.rb_alterar.Visible = False
        Me.rb_excluir.Visible = False
        Me.Pctemp.Hide()

        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader

        AbrirBD()
        Comando = New OleDbCommand("select distinct marca_vei from veiculos_venda_usado order by marca_vei", Conexao)
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                marca_vei.Items.Add(DR("marca_vei"))
            End While
            DR.Close()
        Catch ex As Exception
        Finally
            FecharBD()
        End Try


        Comando = New OleDbCommand("select nome_cli from clientes order by nome_cli", Conexao)
        AbrirBD()
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                cb_cli.Items.Add(DR("nome_cli"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            FecharBD()
        End Try

    End Sub


#End Region

#Region "Cadastrar e Alterar"

    Private Sub cadastro_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadastro_venda.Click

        'Imagem do veiculo...
        Dim imagem As String
        Try
            Me.Pctemp.Image.Save(Application.StartupPath & "\fotos\" & Me.txtplaca.Text.ToString & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            imagem = (Application.StartupPath & "\fotos\" & Me.txtplaca.Text.ToString & ".jpg")
        Catch ex As Exception

            MsgBox("  Se a foto já foi selecionada, por favor" & (Chr(13)) & "confira se este veículo já não foi cadastrado", MsgBoxStyle.Critical, "Veiculo já existente ou Foto não setada")
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
            Teto = "true,"
        Else
            Teto = "false,"
        End If

        If cb_dono.CheckState = CheckState.Checked Then
            UniDono = "true"
        Else
            UniDono = "false"
        End If

        'Verificacao de campos

        If txtplaca.Text = "" Then
            MessageBox.Show("Todos os campos devem ser preenchidos", "Atencaoo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim comando As OleDbCommand
            AbrirBD()

            'Codigo para registo na tabela de veiculos usados

            comando = New OleDbCommand("insert into veiculos_venda_usado(cod_cli,cod_renavam_vei,nome_cli,modelo_vei,marca_vei,versao_vei,ano_vei,quilometragem_vei,placa_vei,comb_vei,tipo_vei,pot_vei,cor_vei,porta_vei,chassi_vei,preco_compra_vei,preco_venda_vei,img_vei,ar_vei,direcao_vei,som_vei,dvd_vei,vidro_vei,trava_vei,airbagduplo_vei,alarme_vei,arquente_vei,bancocouro_vei,blindado_vei,desembaca_tras_vei,freioabs_vei,limptraseiro_vei,tetosolar_vei,unicodono_vei) values (@cod_cli,@codrenavam,@nome_cli,@modelo,@marca,@versao,@ano,@quilometragem,@placa,@comb,@tipo,@pot,@cor,@porta,@chassi,@precocompra,@precovenda,'" & imagem.ToString & "'," & ac & DH & som & dvd & VE & TE & ABD & ALARME & ArQuente & Banco & Blindado & Desembaca & Freio & Limpa & Teto & UniDono & ")", Conexao)
            With comando
                .Parameters.Add(New OleDbParameter("@cod_cli", OleDbType.Numeric, 50))
                .Parameters("@cod_cli").Value = txt_codcli.Text.ToString
                .Parameters.Add(New OleDbParameter("@codrenavam", OleDbType.Numeric, 50))
                .Parameters("@codrenavam").Value = txt_renavam.Text
                .Parameters.Add(New OleDbParameter("@nome_cli", OleDbType.VarChar, 50))
                .Parameters("@nome_cli").Value = cb_cli.Text.ToString
                .Parameters.Add(New OleDbParameter("@modelo", OleDbType.VarChar, 50))
                .Parameters("@modelo").Value = Cb_modelo.Text.ToString
                .Parameters.Add(New OleDbParameter("@marca", OleDbType.VarChar, 50))
                .Parameters("@marca").Value = marca_vei.Text.ToString
                .Parameters.Add(New OleDbParameter("@versao", OleDbType.VarChar, 50))
                .Parameters("@versao").Value = cb_versao.Text.ToString
                .Parameters.Add(New OleDbParameter("@ano", OleDbType.VarChar, 50))
                .Parameters("@ano").Value = cb_ano.Text.ToString
                .Parameters.Add(New OleDbParameter("@quilometragem", OleDbType.VarChar, 50))
                .Parameters("@quilometragem").Value = txt_quilometragem.Text.ToString
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
                .Parameters("@precocompra").Value = txtval.Text.ToString
                .Parameters.Add(New OleDbParameter("@precovenda", OleDbType.VarChar, 50))
                .Parameters("@precovenda").Value = txt_vvenda.Text.ToString
            End With

            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("Registro cadastrado", "Inclusao de Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Erro")
            End Try

            'Codigo para registro na tabela de Compras de veiculos usados


            Dim cmd_compra As OleDbCommand
            AbrirBD()
            cmd_compra = New OleDbCommand("INSERT into compra_vei_usado(placa_vei,cod_cli,nome_cli,dia_compra,preco_compra_vei)values(@placa_vei,@codcli,@nomecli,@dia,@preco)", Conexao)

            With cmd_compra
                .Parameters.Add(New OleDbParameter("@placa_vei", OleDbType.VarChar, 100))
                .Parameters("@placa_vei").Value = txtplaca.Text
                .Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 100))
                .Parameters("@codcli").Value = txt_codcli.Text
                .Parameters.Add(New OleDbParameter("@nomecli", OleDbType.VarChar, 100))
                .Parameters("@nomecli").Value = cb_cli.Text.ToString
                .Parameters.Add(New OleDbParameter("@dia", OleDbType.DBDate, 10))
                .Parameters("@dia").Value = Now.Date.Today
                .Parameters.Add(New OleDbParameter("@preco", OleDbType.VarChar, 100))
                .Parameters("@preco").Value = Val(txtval.Text)
            End With
            cmd_compra.ExecuteNonQuery()
            FecharBD()


            '''''ATUALIZACAO DO SALDO DO CLIENTE

            Dim dr As OleDbDataReader
            Dim cmd_cli As OleDbCommand
            Dim comando2 As OleDbCommand
            Dim temp As Long

            AbrirBD()
            cmd_cli = New OleDbCommand("select saldo_cli from clientes where cod_cli=@codcli", Conexao)
            cmd_cli.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
            cmd_cli.Parameters("@codcli").Value = Me.txt_codcli.Text
            dr = cmd_cli.ExecuteReader
            If dr.Read Then
                temp = Val(dr("saldo_cli")) + Val(txtval.Text)
            End If
            dr.Close()

            If (temp > 0) Then
                comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                comando2.Parameters("@saldo").Value = Val(temp)
                comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                comando2.Parameters("@situacao").Value = "A receber"
                comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                comando2.Parameters("@codcli").Value = Me.txt_codcli.Text

            Else
                If (temp = 0) Then
                    comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                    comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                    comando2.Parameters("@saldo").Value = Val(temp)
                    comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                    comando2.Parameters("@situacao").Value = "Normal"
                    comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                    comando2.Parameters("@codcli").Value = Me.txt_codcli.Text
                Else
                    comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                    comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                    comando2.Parameters("@saldo").Value = Val(temp)
                    comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                    comando2.Parameters("@situacao").Value = "A pagar"
                    comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                    comando2.Parameters("@codcli").Value = Me.txt_codcli.Text
                End If
            End If
            comando2.ExecuteNonQuery()
        End If
        FecharBD()




    End Sub

    Private Sub alterar_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alterar_venda.Click


        If MessageBox.Show("Deseja realmente alterar?", "Alterar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim imagem As String
            'ATUALIZANDO (OUNAO) A IMAGEM DE ACORDO COM A PLACA DO VEICULO
            Try
                Pctemp.Image.Save(Application.StartupPath & "\fotos\" & Me.txtplaca.Text.ToString & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                imagem = (Application.StartupPath & "\fotos\" & Me.txtplaca.Text.ToString & ".jpg")
            Catch ex As Exception
                Dim cmdimg As OleDbCommand
                Dim drimg As OleDbDataReader
                cmdimg = New OleDbCommand("select img_vei from veiculos_venda_usado where cod_vei=" & Me.txtcod_vei.Text, Conexao)
                AbrirBD()
                drimg = cmdimg.ExecuteReader
                If drimg.Read Then
                    imagem = drimg("img_vei")
                End If
                FecharBD()
            End Try

            'PEGANDO VALOR DE COMPRA INICIAL

            Dim V_antigo As Long
            Dim comando_veiculo As OleDbCommand
            Dim dr_vei As OleDbDataReader
            AbrirBD()
            comando_veiculo = New OleDbCommand("select preco_compra_vei from veiculos_venda_usado where cod_vei=" & Me.txtcod_vei.Text, Conexao)
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
            Dim UniDono As Boolean
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

            If cb_dono.CheckState = CheckState.Checked Then
                UniDono = True
            Else
                UniDono = False
            End If

            'ATUALIZACAO NA TABELA DE VEICULOS.......

            If txtplaca.Text = "" Then
                MessageBox.Show("Todos os campos devem ser preenchidos", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                Dim comando As OleDbCommand
                AbrirBD()
                comando = New OleDbCommand("update veiculos_venda_usado set cod_cli=@cod_cli,cod_renavam_vei=@codrenavam,nome_cli=@nome_cli,modelo_vei=@modelo,marca_vei=@marca,versao_vei=@versao,ano_vei=@ano,quilometragem_vei=@quilometragem,placa_vei=@placa,comb_vei=@comb,tipo_vei=@tipo,pot_vei=@pot,cor_vei=@cor,porta_vei=@porta,chassi_vei=@chassi,preco_compra_vei=@precocompra,preco_venda_vei=@precovenda,img_vei='" & imagem & "',ar_vei=" & ac & ",direcao_vei=" & DH & ",som_vei=" & som & ",dvd_vei=" & dvd & ",vidro_vei=" & VE & ",trava_vei=" & TE & ",airbagduplo_vei=" & ABD & ",alarme_vei=" & ALARME & ",arquente_vei=" & ArQuente & ",bancocouro_vei=" & Banco & ",blindado_vei=" & Blindado & ",desembaca_tras_vei=" & Desembaca & ",freioabs_vei=" & Freio & ",limptraseiro_vei=" & Limpa & ",tetosolar_vei=" & Teto & ",unicodono_vei=" & UniDono & " where cod_vei=@codigo ", Conexao)
                With comando
                    .Parameters.Add(New OleDbParameter("@codrenavam", OleDbType.Numeric, 50))
                    .Parameters("@codrenavam").Value = txt_renavam.Text
                    .Parameters.Add(New OleDbParameter("@cod_cli", OleDbType.Numeric, 50))
                    .Parameters("@cod_cli").Value = txt_codcli.Text.ToString
                    .Parameters.Add(New OleDbParameter("@nome_cli", OleDbType.VarChar, 50))
                    .Parameters("@nome_cli").Value = cb_cli.Text.ToString
                    .Parameters.Add(New OleDbParameter("@modelo", OleDbType.VarChar, 50))
                    .Parameters("@modelo").Value = Cb_modelo.Text.ToString
                    .Parameters.Add(New OleDbParameter("@marca", OleDbType.VarChar, 50))
                    .Parameters("@marca").Value = marca_vei.Text.ToString
                    .Parameters.Add(New OleDbParameter("@versao", OleDbType.VarChar, 50))
                    .Parameters("@versao").Value = cb_versao.Text.ToString
                    .Parameters.Add(New OleDbParameter("@ano", OleDbType.VarChar, 50))
                    .Parameters("@ano").Value = cb_ano.Text.ToString
                    .Parameters.Add(New OleDbParameter("@quilometragem", OleDbType.VarChar, 50))
                    .Parameters("@quilometragem").Value = txt_quilometragem.Text.ToString
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
                    .Parameters("@precocompra").Value = txtval.Text.ToString
                    .Parameters.Add(New OleDbParameter("@precovenda", OleDbType.VarChar, 50))
                    .Parameters("@precovenda").Value = txt_vvenda.Text.ToString
                    .Parameters.Add(New OleDbParameter("@codigo", OleDbType.VarChar, 50))
                    .Parameters("@codigo").Value = txtcod_vei.Text.ToString
                End With
                Try
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Registro alterado", "Alteracao de Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Erro")
                End Try
                FecharBD()




                'ALTERACAO DO SALDO DO CLIENTE

                Dim dr As OleDbDataReader
                Dim cmd_cli As OleDbCommand
                Dim comando2 As OleDbCommand
                Dim saldo_anterior As Long
                Dim novo_saldo As Long
                Dim tmp As Long


                cmd_cli = New OleDbCommand("select saldo_cli from clientes where cod_cli=@codcli", Conexao)
                cmd_cli.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                cmd_cli.Parameters("@codcli").Value = Me.txt_codcli.Text
                AbrirBD()
                dr = cmd_cli.ExecuteReader
                If dr.Read Then
                    saldo_anterior = dr("saldo_cli")
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


                If (novo_saldo > 0) Then
                    comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                    comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                    comando2.Parameters("@saldo").Value = novo_saldo
                    comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                    comando2.Parameters("@situacao").Value = "A receber"
                    comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                    comando2.Parameters("@codcli").Value = Me.txt_codcli.Text
                Else
                    If (novo_saldo = 0) Then
                        comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                        comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                        comando2.Parameters("@saldo").Value = novo_saldo
                        comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                        comando2.Parameters("@situacao").Value = "Normal"
                        comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                        comando2.Parameters("@codcli").Value = Me.txt_codcli.Text
                    Else
                        comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                        comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                        comando2.Parameters("@saldo").Value = novo_saldo
                        comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                        comando2.Parameters("@situacao").Value = "A pagar"
                        comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                        comando2.Parameters("@codcli").Value = Me.txt_codcli.Text
                    End If
                End If
                AbrirBD()
                comando2.ExecuteNonQuery()
                FecharBD()
            End If
            FecharBD()

            'Codigo para  atualizacao da tabela de Compras de veiculos usados


            Dim cmd_compra As OleDbCommand
            AbrirBD()
            cmd_compra = New OleDbCommand("update compra_vei_usado set cod_cli=@codcli,nome_cli=@nomecli,preco_compra_vei=@preco where placa_vei=@placa_vei", Conexao)
            With cmd_compra
                .Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 100))
                .Parameters("@codcli").Value = txt_codcli.Text
                .Parameters.Add(New OleDbParameter("@nomecli", OleDbType.VarChar, 100))
                .Parameters("@nomecli").Value = cb_cli.Text.ToString
                .Parameters.Add(New OleDbParameter("@preco", OleDbType.VarChar, 100))
                .Parameters("@preco").Value = Val(txtval.Text)
                .Parameters.Add(New OleDbParameter("@placa_vei", OleDbType.VarChar, 100))
                .Parameters("@placa_vei").Value = txtplaca.Text
            End With
            cmd_compra.ExecuteNonQuery()
            FecharBD()


            'Esquema de Alterar e Excluir
            Me.alterar_venda.Visible = True
            Me.Excluir.Visible = True
            Me.alterar_venda.Enabled = False
            Me.Excluir.Enabled = False
            Me.pc_change.Visible = False
            Me.pc_del.Visible = False
            Me.rb_alterar.Visible = False
            Me.rb_excluir.Visible = False

        End If
    End Sub
#End Region

#Region "Esquema de Alterar e Excluir"

    Private Sub rb_excluir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_excluir.CheckedChanged
        Me.pc_change.Visible = False
        Me.pc_del.Visible = False
        Excluir.Enabled = True
        Excluir.Visible = True
        alterar_venda.Visible = False
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
        Excluir.Visible = False
        alterar_venda.Enabled = True
        alterar_venda.Visible = True
        rb_alterar.Visible = False
        rb_excluir.Visible = False
    End Sub


    Private Sub pc_change_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pc_change.MouseLeave
        rb_alterar.ForeColor = Color.Black
    End Sub

    Private Sub pc_change_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pc_change.MouseEnter
        rb_alterar.ForeColor = Color.White
    End Sub

    Private Sub pc_del_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pc_del.MouseEnter
        rb_excluir.ForeColor = Color.White
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

#Region "Demais subs"

    Private Sub txtval_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtval.KeyUp
        txt_vvenda.Text = Val(txtval.Text) * 1.2
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        loccli.ShowDialog()
    End Sub
    Private Sub bot_localizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bot_localizar.Click
        locvei_venda_usado.ShowDialog()
        rb_excluir.Checked = False
        rb_alterar.Checked = False
    End Sub
    Private Sub bt_obter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_obter.Click
        Capturar.ShowDialog()
    End Sub


#End Region

#Region "Limpar, Excluir, Voltar"
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
        cb_dono.CheckState = CheckState.Unchecked
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

    Private Sub Excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Excluir.Click
        If MessageBox.Show("Deseja realmente deletar?", "Apagar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Coletar valor do veiculo para desconto do saldo do cliente
            Dim valor_veiculo As Long
            Dim com_val As OleDbCommand
            Dim dr_val As OleDbDataReader
            AbrirBD()
            com_val = New OleDbCommand("select preco_compra_vei from compra_vei_usado where placa_vei='" & txtplaca.Text & "'", Conexao)
            dr_val = com_val.ExecuteReader
            If dr_val.Read Then
                valor_veiculo = Val(dr_val("preco_compra_vei"))
            End If
            FecharBD()

            'Remover da tabela de vendas de autos usados
            AbrirBD()
            Dim cmd_new As OleDbCommand
            cmd_new = New OleDbCommand("delete from compra_vei_usado where placa_vei='" & txtplaca.Text & "'", Conexao)
            cmd_new.ExecuteNonQuery()
            FecharBD()

            'Alteracao do saldo do cliente
            AbrirBD()
            Dim dr As OleDbDataReader
            Dim saldo_atual As Long
            Dim novo_saldo As Long
            Dim comando_cli As OleDbCommand
            comando_cli = New OleDbCommand("select * from clientes where cod_cli=" & txt_codcli.Text & "", Conexao)
            dr = comando_cli.ExecuteReader
            If dr.Read Then
                saldo_atual = dr("saldo_cli")
            End If
            dr.Close()
            FecharBD()

            novo_saldo = Val(saldo_atual - valor_veiculo)

            Dim comando2 As OleDbCommand

            If (novo_saldo > 0) Then
                comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                comando2.Parameters("@saldo").Value = novo_saldo
                comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                comando2.Parameters("@situacao").Value = "A receber"
                comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                comando2.Parameters("@codcli").Value = Me.txt_codcli.Text
            Else
                If (novo_saldo = 0) Then
                    comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                    comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                    comando2.Parameters("@saldo").Value = novo_saldo
                    comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                    comando2.Parameters("@situacao").Value = "Normal"
                    comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                    comando2.Parameters("@codcli").Value = Me.txt_codcli.Text
                Else
                    comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                    comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                    comando2.Parameters("@saldo").Value = novo_saldo
                    comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                    comando2.Parameters("@situacao").Value = "A pagar"
                    comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                    comando2.Parameters("@codcli").Value = Me.txt_codcli.Text
                End If
            End If
            AbrirBD()
            comando2.ExecuteNonQuery()
            FecharBD()

            'Deletar da tabela de veiculos usados
            Dim Comando As OleDbCommand


            AbrirBD()
            Comando = New OleDbCommand("delete from veiculos_venda_usado where cod_vei=@cod", Conexao)
            Comando.Parameters.Add(New OleDbParameter("@cod", OleDbType.Integer, 50))
            Comando.Parameters("@cod").Value = Me.txtcod_vei.Text.ToString

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
                    cb_dono.CheckState = CheckState.Unchecked
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

            'Esquema de alterar e remover

            Me.Pctemp.Hide()

            Me.alterar_venda.Visible = True
            Me.Excluir.Visible = True
            Me.alterar_venda.Enabled = False
            Me.Excluir.Enabled = False
            Me.pc_change.Visible = False
            Me.pc_del.Visible = False
            Me.rb_alterar.Visible = False
            Me.rb_excluir.Visible = False
        End If
    End Sub

    Private Sub voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles voltar.Click
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
        cb_dono.CheckState = CheckState.Unchecked
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

#End Region

End Class
