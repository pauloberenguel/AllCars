Imports AllCars.Module1
Imports System.Data.OleDb

Public Class frmcadastro
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents txtcod_cli As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnome_cli As System.Windows.Forms.TextBox
    Friend WithEvents txtend_cli As System.Windows.Forms.TextBox
    Friend WithEvents txtbairro_cli As System.Windows.Forms.TextBox
    Friend WithEvents txtcep_cli As System.Windows.Forms.TextBox
    Friend WithEvents txtrg_cli As System.Windows.Forms.TextBox
    Friend WithEvents txtcpf_cli As System.Windows.Forms.TextBox
    Friend WithEvents txtcelular_cli As System.Windows.Forms.TextBox
    Friend WithEvents txtcidade_cli As System.Windows.Forms.TextBox
    Friend WithEvents txtcnpj_cli As System.Windows.Forms.TextBox
    Friend WithEvents txttelefone_cli As System.Windows.Forms.TextBox
    Friend WithEvents cmbestado_cli As System.Windows.Forms.ComboBox
    Friend WithEvents rdbcpf_cli As System.Windows.Forms.RadioButton
    Friend WithEvents rdbcnpj_cli As System.Windows.Forms.RadioButton
    Friend WithEvents cb_search As System.Windows.Forms.Button
    Friend WithEvents Limpar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cb_apaga As System.Windows.Forms.Button
    Friend WithEvents cb_print As System.Windows.Forms.Button
    Friend WithEvents cb_altera As System.Windows.Forms.Button
    Friend WithEvents cadastro_venda As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_situacao As System.Windows.Forms.TextBox
    Friend WithEvents txtsaldo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmcadastro))
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtnome_cli = New System.Windows.Forms.TextBox
        Me.txtend_cli = New System.Windows.Forms.TextBox
        Me.txtbairro_cli = New System.Windows.Forms.TextBox
        Me.txtcep_cli = New System.Windows.Forms.TextBox
        Me.txtrg_cli = New System.Windows.Forms.TextBox
        Me.txtcpf_cli = New System.Windows.Forms.TextBox
        Me.txtcelular_cli = New System.Windows.Forms.TextBox
        Me.txtcidade_cli = New System.Windows.Forms.TextBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.txtcod_cli = New System.Windows.Forms.TextBox
        Me.txtcnpj_cli = New System.Windows.Forms.TextBox
        Me.txttelefone_cli = New System.Windows.Forms.TextBox
        Me.cmbestado_cli = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.rdbcpf_cli = New System.Windows.Forms.RadioButton
        Me.rdbcnpj_cli = New System.Windows.Forms.RadioButton
        Me.cb_search = New System.Windows.Forms.Button
        Me.Limpar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cb_apaga = New System.Windows.Forms.Button
        Me.cb_print = New System.Windows.Forms.Button
        Me.cb_altera = New System.Windows.Forms.Button
        Me.cadastro_venda = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_situacao = New System.Windows.Forms.TextBox
        Me.txtsaldo = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Beige
        Me.Label5.Location = New System.Drawing.Point(40, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "RG"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Beige
        Me.Label9.Location = New System.Drawing.Point(312, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 23)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Cidade"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Beige
        Me.Label10.Location = New System.Drawing.Point(192, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Estado"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnome_cli
        '
        Me.txtnome_cli.Location = New System.Drawing.Point(80, 80)
        Me.txtnome_cli.Name = "txtnome_cli"
        Me.txtnome_cli.Size = New System.Drawing.Size(280, 20)
        Me.txtnome_cli.TabIndex = 0
        Me.txtnome_cli.Text = ""
        '
        'txtend_cli
        '
        Me.txtend_cli.Location = New System.Drawing.Point(80, 112)
        Me.txtend_cli.Name = "txtend_cli"
        Me.txtend_cli.Size = New System.Drawing.Size(432, 20)
        Me.txtend_cli.TabIndex = 1
        Me.txtend_cli.Text = ""
        '
        'txtbairro_cli
        '
        Me.txtbairro_cli.Location = New System.Drawing.Point(80, 144)
        Me.txtbairro_cli.Name = "txtbairro_cli"
        Me.txtbairro_cli.Size = New System.Drawing.Size(280, 20)
        Me.txtbairro_cli.TabIndex = 2
        Me.txtbairro_cli.Text = ""
        '
        'txtcep_cli
        '
        Me.txtcep_cli.Location = New System.Drawing.Point(80, 176)
        Me.txtcep_cli.Name = "txtcep_cli"
        Me.txtcep_cli.Size = New System.Drawing.Size(104, 20)
        Me.txtcep_cli.TabIndex = 3
        Me.txtcep_cli.Text = ""
        '
        'txtrg_cli
        '
        Me.txtrg_cli.Location = New System.Drawing.Point(80, 240)
        Me.txtrg_cli.Name = "txtrg_cli"
        Me.txtrg_cli.Size = New System.Drawing.Size(128, 20)
        Me.txtrg_cli.TabIndex = 8
        Me.txtrg_cli.Text = ""
        '
        'txtcpf_cli
        '
        Me.txtcpf_cli.Location = New System.Drawing.Point(280, 240)
        Me.txtcpf_cli.MaxLength = 14
        Me.txtcpf_cli.Name = "txtcpf_cli"
        Me.txtcpf_cli.ReadOnly = True
        Me.txtcpf_cli.Size = New System.Drawing.Size(128, 20)
        Me.txtcpf_cli.TabIndex = 9
        Me.txtcpf_cli.Text = ""
        '
        'txtcelular_cli
        '
        Me.txtcelular_cli.Location = New System.Drawing.Point(280, 208)
        Me.txtcelular_cli.Name = "txtcelular_cli"
        Me.txtcelular_cli.Size = New System.Drawing.Size(128, 20)
        Me.txtcelular_cli.TabIndex = 7
        Me.txtcelular_cli.Text = ""
        '
        'txtcidade_cli
        '
        Me.txtcidade_cli.Location = New System.Drawing.Point(376, 176)
        Me.txtcidade_cli.Name = "txtcidade_cli"
        Me.txtcidade_cli.Size = New System.Drawing.Size(128, 20)
        Me.txtcidade_cli.TabIndex = 5
        Me.txtcidade_cli.Text = ""
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(1112, 64)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 56)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Voltar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtcod_cli
        '
        Me.txtcod_cli.Enabled = False
        Me.txtcod_cli.Location = New System.Drawing.Point(80, 48)
        Me.txtcod_cli.Name = "txtcod_cli"
        Me.txtcod_cli.ReadOnly = True
        Me.txtcod_cli.Size = New System.Drawing.Size(80, 20)
        Me.txtcod_cli.TabIndex = 0
        Me.txtcod_cli.Text = ""
        '
        'txtcnpj_cli
        '
        Me.txtcnpj_cli.Location = New System.Drawing.Point(80, 272)
        Me.txtcnpj_cli.MaxLength = 18
        Me.txtcnpj_cli.Name = "txtcnpj_cli"
        Me.txtcnpj_cli.ReadOnly = True
        Me.txtcnpj_cli.Size = New System.Drawing.Size(128, 20)
        Me.txtcnpj_cli.TabIndex = 10
        Me.txtcnpj_cli.Text = ""
        '
        'txttelefone_cli
        '
        Me.txttelefone_cli.Location = New System.Drawing.Point(80, 208)
        Me.txttelefone_cli.Name = "txttelefone_cli"
        Me.txttelefone_cli.Size = New System.Drawing.Size(128, 20)
        Me.txttelefone_cli.TabIndex = 6
        Me.txttelefone_cli.Text = ""
        '
        'cmbestado_cli
        '
        Me.cmbestado_cli.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"})
        Me.cmbestado_cli.Location = New System.Drawing.Point(256, 176)
        Me.cmbestado_cli.Name = "cmbestado_cli"
        Me.cmbestado_cli.Size = New System.Drawing.Size(40, 21)
        Me.cmbestado_cli.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Beige
        Me.Label15.Location = New System.Drawing.Point(8, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 23)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Telefone"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Beige
        Me.Label16.Location = New System.Drawing.Point(16, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 23)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Código"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Beige
        Me.Label17.Location = New System.Drawing.Point(224, 208)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 23)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Celular"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Beige
        Me.Label18.Location = New System.Drawing.Point(24, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 23)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Nome"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Beige
        Me.Label20.Location = New System.Drawing.Point(24, 176)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 23)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "CEP"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(8, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Endereço"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Beige
        Me.Label2.Location = New System.Drawing.Point(24, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Bairro"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(328, 40)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Cadastrar Clientes"
        '
        'rdbcpf_cli
        '
        Me.rdbcpf_cli.BackColor = System.Drawing.Color.Transparent
        Me.rdbcpf_cli.CausesValidation = False
        Me.rdbcpf_cli.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rdbcpf_cli.ForeColor = System.Drawing.Color.Beige
        Me.rdbcpf_cli.Location = New System.Drawing.Point(216, 240)
        Me.rdbcpf_cli.Name = "rdbcpf_cli"
        Me.rdbcpf_cli.TabIndex = 69
        Me.rdbcpf_cli.Text = "CPF"
        '
        'rdbcnpj_cli
        '
        Me.rdbcnpj_cli.BackColor = System.Drawing.Color.Transparent
        Me.rdbcnpj_cli.CausesValidation = False
        Me.rdbcnpj_cli.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rdbcnpj_cli.ForeColor = System.Drawing.Color.Beige
        Me.rdbcnpj_cli.Location = New System.Drawing.Point(24, 272)
        Me.rdbcnpj_cli.Name = "rdbcnpj_cli"
        Me.rdbcnpj_cli.TabIndex = 70
        Me.rdbcnpj_cli.Text = "CNPJ"
        '
        'cb_search
        '
        Me.cb_search.BackColor = System.Drawing.Color.White
        Me.cb_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_search.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_search.Image = CType(resources.GetObject("cb_search.Image"), System.Drawing.Image)
        Me.cb_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cb_search.Location = New System.Drawing.Point(432, 352)
        Me.cb_search.Name = "cb_search"
        Me.cb_search.Size = New System.Drawing.Size(144, 32)
        Me.cb_search.TabIndex = 241
        Me.cb_search.Text = "Localizar"
        Me.cb_search.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Limpar
        '
        Me.Limpar.BackColor = System.Drawing.Color.White
        Me.Limpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Limpar.Font = New System.Drawing.Font("Arial", 10.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Limpar.Image = CType(resources.GetObject("Limpar.Image"), System.Drawing.Image)
        Me.Limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Limpar.Location = New System.Drawing.Point(112, 312)
        Me.Limpar.Name = "Limpar"
        Me.Limpar.Size = New System.Drawing.Size(65, 75)
        Me.Limpar.TabIndex = 236
        Me.Limpar.Text = "Limpar"
        Me.Limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(352, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 75)
        Me.Button1.TabIndex = 240
        Me.Button1.Text = "Voltar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cb_apaga
        '
        Me.cb_apaga.BackColor = System.Drawing.Color.White
        Me.cb_apaga.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_apaga.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_apaga.Font = New System.Drawing.Font("Arial", 9.01!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.cb_apaga.Image = CType(resources.GetObject("cb_apaga.Image"), System.Drawing.Image)
        Me.cb_apaga.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cb_apaga.Location = New System.Drawing.Point(192, 312)
        Me.cb_apaga.Name = "cb_apaga"
        Me.cb_apaga.Size = New System.Drawing.Size(65, 75)
        Me.cb_apaga.TabIndex = 239
        Me.cb_apaga.Text = "Remover"
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
        Me.cb_print.Location = New System.Drawing.Point(432, 312)
        Me.cb_print.Name = "cb_print"
        Me.cb_print.Size = New System.Drawing.Size(144, 32)
        Me.cb_print.TabIndex = 238
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
        Me.cb_altera.Location = New System.Drawing.Point(272, 312)
        Me.cb_altera.Name = "cb_altera"
        Me.cb_altera.Size = New System.Drawing.Size(65, 75)
        Me.cb_altera.TabIndex = 237
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
        Me.cadastro_venda.Location = New System.Drawing.Point(32, 312)
        Me.cadastro_venda.Name = "cadastro_venda"
        Me.cadastro_venda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cadastro_venda.Size = New System.Drawing.Size(65, 75)
        Me.cadastro_venda.TabIndex = 235
        Me.cadastro_venda.Text = "Salvar"
        Me.cadastro_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(24, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(560, 88)
        Me.Label6.TabIndex = 242
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Beige
        Me.Label4.Location = New System.Drawing.Point(416, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 243
        Me.Label4.Text = "Situação"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Beige
        Me.Label7.Location = New System.Drawing.Point(424, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 23)
        Me.Label7.TabIndex = 244
        Me.Label7.Text = "Saldo:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_situacao
        '
        Me.txt_situacao.Location = New System.Drawing.Point(488, 240)
        Me.txt_situacao.Name = "txt_situacao"
        Me.txt_situacao.ReadOnly = True
        Me.txt_situacao.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_situacao.TabIndex = 245
        Me.txt_situacao.Text = "Normal"
        '
        'txtsaldo
        '
        Me.txtsaldo.Location = New System.Drawing.Point(488, 272)
        Me.txtsaldo.Name = "txtsaldo"
        Me.txtsaldo.ReadOnly = True
        Me.txtsaldo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtsaldo.TabIndex = 246
        Me.txtsaldo.Text = "0"
        '
        'frmcadastro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(608, 398)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtsaldo)
        Me.Controls.Add(Me.txt_situacao)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cb_search)
        Me.Controls.Add(Me.Limpar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_apaga)
        Me.Controls.Add(Me.cb_print)
        Me.Controls.Add(Me.cb_altera)
        Me.Controls.Add(Me.cadastro_venda)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbestado_cli)
        Me.Controls.Add(Me.txttelefone_cli)
        Me.Controls.Add(Me.txtcnpj_cli)
        Me.Controls.Add(Me.txtcod_cli)
        Me.Controls.Add(Me.txtcidade_cli)
        Me.Controls.Add(Me.txtcelular_cli)
        Me.Controls.Add(Me.txtcpf_cli)
        Me.Controls.Add(Me.txtrg_cli)
        Me.Controls.Add(Me.txtcep_cli)
        Me.Controls.Add(Me.txtbairro_cli)
        Me.Controls.Add(Me.txtend_cli)
        Me.Controls.Add(Me.txtnome_cli)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdbcpf_cli)
        Me.Controls.Add(Me.rdbcnpj_cli)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmcadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadastrar Cliente"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Formata CPF"
    Private Sub txtcpf_cli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcpf_cli.KeyPress
        If IsNumeric(e.KeyChar) AndAlso txtcpf_cli.TextLength < txtcpf_cli.MaxLength Then
            txtcpf_cli.Text &= e.KeyChar
            txtcpf_cli.SelectionStart = txtcpf_cli.TextLength
            Call formatacpf(txtcpf_cli)
        End If
        e.Handled = True
    End Sub
    Private Sub formatacpf(ByVal txtTexto As Object)
        If Len(txtTexto.Text) = 3 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 7 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 11 Then
            txtTexto.Text = txtTexto.Text & "-"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If
    End Sub
    Private Sub txtcnpj_cli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcnpj_cli.KeyPress
        If IsNumeric(e.KeyChar) AndAlso txtcnpj_cli.TextLength < txtcnpj_cli.MaxLength Then
            txtcnpj_cli.Text &= e.KeyChar
            txtcnpj_cli.SelectionStart = txtcnpj_cli.TextLength
            Call formatacnpj(txtcnpj_cli)
        End If
        e.Handled = True
    End Sub
    Private Sub formatacnpj(ByVal txtTexto As Object)
        If Len(txtTexto.Text) = 2 Or Len(txtTexto.Text) = 6 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If

        If Len(txtTexto.Text) = 10 Then
            txtTexto.Text = txtTexto.Text & "/"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If

        If Len(txtTexto.Text) = 15 Then
            txtTexto.Text = txtTexto.Text & "-"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If
    End Sub
#End Region


    Private Sub frmcadastro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Controle As New Control
        For Each Controle In Me.Controls
            If TypeOf Controle Is TextBox Or TypeOf Controle Is ComboBox Then
                Controle.Text = ""
            End If
        Next
        rdbcpf_cli.Checked = False
        rdbcnpj_cli.Checked = False
        If txtcpf_cli.Text = "" Then
        Else
            rdbcpf_cli.Checked = True
        End If
        If txtcnpj_cli.Text = "" Then
        Else
            rdbcnpj_cli.Checked = True
        End If
    End Sub

    Private Sub rdbcpf_cli_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbcpf_cli.CheckedChanged
        If rdbcpf_cli.Checked = True Then
            txtcpf_cli.ReadOnly = False
            txtcnpj_cli.Text = ""
        Else
            txtcpf_cli.ReadOnly = True
        End If
    End Sub

    Private Sub rdbcnpj_cli_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbcnpj_cli.CheckedChanged
        If rdbcnpj_cli.Checked = True Then
            txtcnpj_cli.ReadOnly = False
            txtcpf_cli.Text = ""
        Else
            txtcnpj_cli.ReadOnly = True
        End If
    End Sub

    Private Sub cmdcal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        calendario.ShowDialog()
    End Sub

    Private Sub cmbestado_cli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbestado_cli.SelectedIndexChanged

    End Sub

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub cadastro_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadastro_venda.Click
        If txtnome_cli.Text = "" Or txtend_cli.Text = "" Or txtbairro_cli.Text = "" Or txtcep_cli.Text = "" Or cmbestado_cli.Text = "" Or txtcidade_cli.Text = "" Or txttelefone_cli.Text = "" Or txtcelular_cli.Text = "" Or txtrg_cli.Text = "" Then
            MessageBox.Show("Todos os campos devem ser preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            If txtcpf_cli.Text = "" And txtcnpj_cli.Text = "" Then
                MessageBox.Show("Todos os campos devem ser preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                Dim Comando As OleDbCommand

                AbrirBD()
                Comando = New OleDbCommand("INSERT into CLIENTES (nome_cli,telefone_cli,cel_cli,endereco_cli,bairro_cli,cep_cli,cidade_cli,estado_cli,rg_cli,cpf_cli,cnpj_cli,situa_cli,saldo_cli) values (@nome,@telefone,@cel,@endereco,@bairro,@cep,@cidade,@estado,@rg,@cpf,@cnpj,@situ,@saldo)", Conexao)

                With Comando
                    .Parameters.Add(New OleDbParameter("@nome", OleDbType.VarChar, 50))
                    .Parameters("@nome").Value = txtnome_cli.Text.ToString
                    .Parameters.Add(New OleDbParameter("@telefone", OleDbType.VarChar, 50))
                    .Parameters("@telefone").Value = txttelefone_cli.Text.ToString
                    .Parameters.Add(New OleDbParameter("@cel", OleDbType.VarChar, 50))
                    .Parameters("@cel").Value = txtcelular_cli.Text.ToString
                    .Parameters.Add(New OleDbParameter("@endereco", OleDbType.VarChar, 50))
                    .Parameters("@endereco").Value = txtend_cli.Text.ToString
                    .Parameters.Add(New OleDbParameter("@bairro", OleDbType.VarChar, 50))
                    .Parameters("@bairro").Value = txtbairro_cli.Text.ToString
                    .Parameters.Add(New OleDbParameter("@cep", OleDbType.VarChar, 50))
                    .Parameters("@cep").Value = txtcep_cli.Text.ToString
                    .Parameters.Add(New OleDbParameter("@cidade", OleDbType.VarChar, 50))
                    .Parameters("@cidade").Value = txtcidade_cli.Text.ToString
                    .Parameters.Add(New OleDbParameter("@estado", OleDbType.VarChar, 2))
                    .Parameters("@estado").Value = cmbestado_cli.Text.ToString
                    .Parameters.Add(New OleDbParameter("@rg", OleDbType.VarChar, 50))
                    .Parameters("@rg").Value = txtrg_cli.Text.ToString
                    .Parameters.Add(New OleDbParameter("@cpf", OleDbType.VarChar, 50))
                    .Parameters("@cpf").Value = txtcpf_cli.Text.ToString
                    .Parameters.Add(New OleDbParameter("@cnpj", OleDbType.VarChar, 50))
                    .Parameters("@cnpj").Value = txtcnpj_cli.Text.ToString
                    .Parameters.Add(New OleDbParameter("@situ", OleDbType.VarChar, 50))
                    .Parameters("@situ").Value = "Normal"
                    .Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                    .Parameters("@saldo").Value = 0
                End With

                Try
                    Comando.ExecuteNonQuery()
                    MessageBox.Show("Registro cadastrado", "Inclusão de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Erro")
                Finally
                    FecharBD()
                End Try
            End If
        End If
    End Sub

    Private Sub cb_altera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_altera.Click
        If txtnome_cli.Text = "" Or txtend_cli.Text = "" Or txtbairro_cli.Text = "" Or txtcep_cli.Text = "" Or cmbestado_cli.Text = "" Or txtcidade_cli.Text = "" Or txttelefone_cli.Text = "" Or txtrg_cli.Text Or txtcelular_cli.Text = "" Then
            If txtcpf_cli.Text = "" And txtcnpj_cli.Text = "" Then
                MessageBox.Show("Todos os campos devem ser preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If
        Dim Comando As OleDbCommand

        Conexao.Open()
        Comando = New OleDbCommand("Update clientes set nome_cli=@nome,telefone_cli=@telefone,cel_cli=@cel,endereco_cli=@endereco,bairro_cli=@bairro,cep_cli=@cep,cidade_cli=@cidade,estado_cli=@estado,rg_cli=@rg,cpf_cli=@cpf,cnpj_cli=@cnpj where cod_cli=@codigocliente", Conexao)
        With Comando
            .Parameters.Add(New OleDbParameter("@nome", OleDbType.VarChar, 50))
            .Parameters("@nome").Value = txtnome_cli.Text.ToString
            .Parameters.Add(New OleDbParameter("@telefone", OleDbType.VarChar, 50))
            .Parameters("@telefone").Value = txttelefone_cli.Text.ToString
            .Parameters.Add(New OleDbParameter("@cel", OleDbType.VarChar, 50))
            .Parameters("@cel").Value = txtcelular_cli.Text.ToString
            .Parameters.Add(New OleDbParameter("@endereco", OleDbType.VarChar, 50))
            .Parameters("@endereco").Value = txtend_cli.Text.ToString
            .Parameters.Add(New OleDbParameter("@bairro", OleDbType.VarChar, 50))
            .Parameters("@bairro").Value = txtbairro_cli.Text.ToString
            .Parameters.Add(New OleDbParameter("@cep", OleDbType.VarChar, 50))
            .Parameters("@cep").Value = txtcep_cli.Text.ToString
            .Parameters.Add(New OleDbParameter("@cidade", OleDbType.VarChar, 50))
            .Parameters("@cidade").Value = txtcidade_cli.Text.ToString
            .Parameters.Add(New OleDbParameter("@estado", OleDbType.VarChar, 2))
            .Parameters("@estado").Value = cmbestado_cli.Text.ToString
            .Parameters.Add(New OleDbParameter("@rg", OleDbType.VarChar, 50))
            .Parameters("@rg").Value = txtrg_cli.Text.ToString
            .Parameters.Add(New OleDbParameter("@cpf", OleDbType.VarChar, 50))
            .Parameters("@cpf").Value = txtcpf_cli.Text.ToString
            .Parameters.Add(New OleDbParameter("@cnpj", OleDbType.VarChar, 50))
            .Parameters("@cnpj").Value = txtcnpj_cli.Text.ToString
            .Parameters.Add(New OleDbParameter("@codigocliente", OleDbType.VarChar, 50))
            .Parameters("@codigocliente").Value = txtcod_cli.Text.ToString
            Try
                Comando.ExecuteNonQuery()
                MessageBox.Show("Dados alterados", "Alteração de registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try
        End With
    End Sub

    Private Sub Limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpar.Click
        Dim Controle As New Control
        For Each Controle In Me.Controls
            If TypeOf Controle Is TextBox Or TypeOf Controle Is ComboBox Then
                Controle.Text = ""
            End If
        Next
    End Sub

    Private Sub cb_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_search.Click
        loccli.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
        principal.Visible = True
        principal.IconTray.Visible = False
    End Sub

    Private Sub cb_apaga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_apaga.Click
        Dim Comando As OleDbCommand
        AbrirBD()
        Comando = New OleDbCommand("delete from clientes where cod_cli=@cod", Conexao)
        Comando.Parameters.Add(New OleDbParameter("@cod", OleDbType.Integer, 50))
        Comando.Parameters("@cod").Value = txtcod_cli.Text.ToString
        If MessageBox.Show("Deseja realmente deletar?", "Apagar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Comando.ExecuteNonQuery()
                MessageBox.Show("Registro apagado", "Apagar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim Controle As New Control
                For Each Controle In Me.Controls
                    If TypeOf Controle Is TextBox Or TypeOf Controle Is ComboBox Then
                        Controle.Text = ""
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Apagar Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        FecharBD()
    End Sub



End Class
