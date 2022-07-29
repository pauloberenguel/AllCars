Imports System.Data.OleDb
Imports AllCars.Module1
Imports System.Drawing.Image

Public Class frm_fornecedores
    Inherits System.Windows.Forms.Form
    Public Logo As String


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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcod_forn As System.Windows.Forms.TextBox
    Friend WithEvents txtnome_forn As System.Windows.Forms.TextBox
    Friend WithEvents txtend_forn As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_select As System.Windows.Forms.Button
    Friend WithEvents txtpais_forn As System.Windows.Forms.TextBox
    Friend WithEvents txtestado_forn As System.Windows.Forms.TextBox
    Friend WithEvents txtcida_forn As System.Windows.Forms.TextBox
    Friend WithEvents txtcnpj_forn As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents picture_logo As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cb_acessorios As System.Windows.Forms.CheckBox
    Friend WithEvents cb_pneus As System.Windows.Forms.CheckBox
    Friend WithEvents cb_rodas As System.Windows.Forms.CheckBox
    Friend WithEvents cb_som As System.Windows.Forms.CheckBox
    Friend WithEvents cb_vidros As System.Windows.Forms.CheckBox
    Friend WithEvents cb_outros As System.Windows.Forms.CheckBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefone As System.Windows.Forms.TextBox
    Friend WithEvents txt_fantasia As System.Windows.Forms.TextBox
    Friend WithEvents cb_search As System.Windows.Forms.Button
    Friend WithEvents Limpar As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents cb_apaga As System.Windows.Forms.Button
    Friend WithEvents cb_print As System.Windows.Forms.Button
    Friend WithEvents cb_altera As System.Windows.Forms.Button
    Friend WithEvents cadastro_venda As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_fornecedores))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcod_forn = New System.Windows.Forms.TextBox
        Me.txtnome_forn = New System.Windows.Forms.TextBox
        Me.txtend_forn = New System.Windows.Forms.TextBox
        Me.picture_logo = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.bt_select = New System.Windows.Forms.Button
        Me.txtpais_forn = New System.Windows.Forms.TextBox
        Me.txtestado_forn = New System.Windows.Forms.TextBox
        Me.txtcida_forn = New System.Windows.Forms.TextBox
        Me.txtcnpj_forn = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txt_fantasia = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_telefone = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cb_acessorios = New System.Windows.Forms.CheckBox
        Me.cb_pneus = New System.Windows.Forms.CheckBox
        Me.cb_rodas = New System.Windows.Forms.CheckBox
        Me.cb_som = New System.Windows.Forms.CheckBox
        Me.cb_vidros = New System.Windows.Forms.CheckBox
        Me.cb_outros = New System.Windows.Forms.CheckBox
        Me.cb_search = New System.Windows.Forms.Button
        Me.Limpar = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.cb_apaga = New System.Windows.Forms.Button
        Me.cb_print = New System.Windows.Forms.Button
        Me.cb_altera = New System.Windows.Forms.Button
        Me.cadastro_venda = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(424, 40)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Cadastrar Fornecedores"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Beige
        Me.Label16.Location = New System.Drawing.Point(456, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 24)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "Código"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(0, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 23)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Nome"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Beige
        Me.Label4.Location = New System.Drawing.Point(0, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 22)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Endereço"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcod_forn
        '
        Me.txtcod_forn.Location = New System.Drawing.Point(528, 9)
        Me.txtcod_forn.Name = "txtcod_forn"
        Me.txtcod_forn.ReadOnly = True
        Me.txtcod_forn.Size = New System.Drawing.Size(88, 20)
        Me.txtcod_forn.TabIndex = 93
        Me.txtcod_forn.Text = ""
        '
        'txtnome_forn
        '
        Me.txtnome_forn.Location = New System.Drawing.Point(72, 52)
        Me.txtnome_forn.Name = "txtnome_forn"
        Me.txtnome_forn.Size = New System.Drawing.Size(168, 20)
        Me.txtnome_forn.TabIndex = 1
        Me.txtnome_forn.Text = ""
        '
        'txtend_forn
        '
        Me.txtend_forn.Location = New System.Drawing.Point(72, 87)
        Me.txtend_forn.Name = "txtend_forn"
        Me.txtend_forn.Size = New System.Drawing.Size(384, 20)
        Me.txtend_forn.TabIndex = 3
        Me.txtend_forn.Text = ""
        '
        'picture_logo
        '
        Me.picture_logo.BackColor = System.Drawing.Color.White
        Me.picture_logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picture_logo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picture_logo.Location = New System.Drawing.Point(3, 17)
        Me.picture_logo.Name = "picture_logo"
        Me.picture_logo.Size = New System.Drawing.Size(130, 145)
        Me.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture_logo.TabIndex = 100
        Me.picture_logo.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.picture_logo)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox1.Location = New System.Drawing.Point(480, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 165)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Logo"
        '
        'bt_select
        '
        Me.bt_select.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_select.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bt_select.Location = New System.Drawing.Point(480, 52)
        Me.bt_select.Name = "bt_select"
        Me.bt_select.Size = New System.Drawing.Size(136, 25)
        Me.bt_select.TabIndex = 16
        Me.bt_select.Text = "Selecionar Logo"
        '
        'txtpais_forn
        '
        Me.txtpais_forn.Location = New System.Drawing.Point(72, 121)
        Me.txtpais_forn.Name = "txtpais_forn"
        Me.txtpais_forn.Size = New System.Drawing.Size(168, 20)
        Me.txtpais_forn.TabIndex = 4
        Me.txtpais_forn.Text = ""
        '
        'txtestado_forn
        '
        Me.txtestado_forn.Location = New System.Drawing.Point(72, 156)
        Me.txtestado_forn.Name = "txtestado_forn"
        Me.txtestado_forn.Size = New System.Drawing.Size(168, 20)
        Me.txtestado_forn.TabIndex = 6
        Me.txtestado_forn.Text = ""
        '
        'txtcida_forn
        '
        Me.txtcida_forn.Location = New System.Drawing.Point(72, 191)
        Me.txtcida_forn.Name = "txtcida_forn"
        Me.txtcida_forn.Size = New System.Drawing.Size(168, 20)
        Me.txtcida_forn.TabIndex = 8
        Me.txtcida_forn.Text = ""
        '
        'txtcnpj_forn
        '
        Me.txtcnpj_forn.Location = New System.Drawing.Point(312, 121)
        Me.txtcnpj_forn.Name = "txtcnpj_forn"
        Me.txtcnpj_forn.Size = New System.Drawing.Size(144, 20)
        Me.txtcnpj_forn.TabIndex = 5
        Me.txtcnpj_forn.Text = ""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Beige
        Me.Label8.Location = New System.Drawing.Point(0, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 23)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "País"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Beige
        Me.Label5.Location = New System.Drawing.Point(0, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 22)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Cidade"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Beige
        Me.Label2.Location = New System.Drawing.Point(248, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 23)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "CNPJ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Beige
        Me.Label7.Location = New System.Drawing.Point(0, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 23)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Estado"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_fantasia
        '
        Me.txt_fantasia.Location = New System.Drawing.Point(312, 52)
        Me.txt_fantasia.Name = "txt_fantasia"
        Me.txt_fantasia.Size = New System.Drawing.Size(144, 20)
        Me.txt_fantasia.TabIndex = 2
        Me.txt_fantasia.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Beige
        Me.Label6.Location = New System.Drawing.Point(248, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 23)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Fantasia"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Beige
        Me.Label9.Location = New System.Drawing.Point(248, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 23)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Telefone"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_telefone
        '
        Me.txt_telefone.Location = New System.Drawing.Point(312, 156)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(144, 20)
        Me.txt_telefone.TabIndex = 7
        Me.txt_telefone.Text = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Beige
        Me.Label10.Location = New System.Drawing.Point(248, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 22)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "E-mail"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(312, 191)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(144, 20)
        Me.txt_email.TabIndex = 9
        Me.txt_email.Text = ""
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Beige
        Me.Label11.Location = New System.Drawing.Point(8, 225)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 23)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "Produtos Fornecidos"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cb_acessorios
        '
        Me.cb_acessorios.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_acessorios.ForeColor = System.Drawing.Color.Beige
        Me.cb_acessorios.Location = New System.Drawing.Point(56, 251)
        Me.cb_acessorios.Name = "cb_acessorios"
        Me.cb_acessorios.Size = New System.Drawing.Size(96, 26)
        Me.cb_acessorios.TabIndex = 10
        Me.cb_acessorios.Text = "Acessórios"
        '
        'cb_pneus
        '
        Me.cb_pneus.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_pneus.ForeColor = System.Drawing.Color.Beige
        Me.cb_pneus.Location = New System.Drawing.Point(256, 251)
        Me.cb_pneus.Name = "cb_pneus"
        Me.cb_pneus.Size = New System.Drawing.Size(72, 26)
        Me.cb_pneus.TabIndex = 12
        Me.cb_pneus.Text = "Pneus"
        '
        'cb_rodas
        '
        Me.cb_rodas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_rodas.ForeColor = System.Drawing.Color.Beige
        Me.cb_rodas.Location = New System.Drawing.Point(432, 251)
        Me.cb_rodas.Name = "cb_rodas"
        Me.cb_rodas.Size = New System.Drawing.Size(72, 26)
        Me.cb_rodas.TabIndex = 14
        Me.cb_rodas.Text = "Rodas"
        '
        'cb_som
        '
        Me.cb_som.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_som.ForeColor = System.Drawing.Color.Beige
        Me.cb_som.Location = New System.Drawing.Point(168, 251)
        Me.cb_som.Name = "cb_som"
        Me.cb_som.Size = New System.Drawing.Size(72, 26)
        Me.cb_som.TabIndex = 11
        Me.cb_som.Text = "Som"
        '
        'cb_vidros
        '
        Me.cb_vidros.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_vidros.ForeColor = System.Drawing.Color.Beige
        Me.cb_vidros.Location = New System.Drawing.Point(344, 251)
        Me.cb_vidros.Name = "cb_vidros"
        Me.cb_vidros.Size = New System.Drawing.Size(72, 26)
        Me.cb_vidros.TabIndex = 13
        Me.cb_vidros.Text = "Vidros"
        '
        'cb_outros
        '
        Me.cb_outros.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_outros.ForeColor = System.Drawing.Color.Beige
        Me.cb_outros.Location = New System.Drawing.Point(520, 251)
        Me.cb_outros.Name = "cb_outros"
        Me.cb_outros.Size = New System.Drawing.Size(72, 26)
        Me.cb_outros.TabIndex = 15
        Me.cb_outros.Text = "Outros"
        '
        'cb_search
        '
        Me.cb_search.BackColor = System.Drawing.Color.White
        Me.cb_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_search.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_search.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cb_search.Image = CType(resources.GetObject("cb_search.Image"), System.Drawing.Image)
        Me.cb_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cb_search.Location = New System.Drawing.Point(440, 338)
        Me.cb_search.Name = "cb_search"
        Me.cb_search.Size = New System.Drawing.Size(144, 35)
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
        Me.Limpar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Limpar.Image = CType(resources.GetObject("Limpar.Image"), System.Drawing.Image)
        Me.Limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Limpar.Location = New System.Drawing.Point(120, 295)
        Me.Limpar.Name = "Limpar"
        Me.Limpar.Size = New System.Drawing.Size(65, 81)
        Me.Limpar.TabIndex = 236
        Me.Limpar.Text = "Limpar"
        Me.Limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.Button7.Location = New System.Drawing.Point(360, 295)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(65, 81)
        Me.Button7.TabIndex = 240
        Me.Button7.Text = "Voltar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cb_apaga
        '
        Me.cb_apaga.BackColor = System.Drawing.Color.White
        Me.cb_apaga.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_apaga.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_apaga.Font = New System.Drawing.Font("Arial", 9.01!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.cb_apaga.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cb_apaga.Image = CType(resources.GetObject("cb_apaga.Image"), System.Drawing.Image)
        Me.cb_apaga.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cb_apaga.Location = New System.Drawing.Point(200, 295)
        Me.cb_apaga.Name = "cb_apaga"
        Me.cb_apaga.Size = New System.Drawing.Size(65, 81)
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
        Me.cb_print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cb_print.Image = CType(resources.GetObject("cb_print.Image"), System.Drawing.Image)
        Me.cb_print.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cb_print.Location = New System.Drawing.Point(440, 295)
        Me.cb_print.Name = "cb_print"
        Me.cb_print.Size = New System.Drawing.Size(144, 34)
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
        Me.cb_altera.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cb_altera.Image = CType(resources.GetObject("cb_altera.Image"), System.Drawing.Image)
        Me.cb_altera.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.cb_altera.Location = New System.Drawing.Point(280, 295)
        Me.cb_altera.Name = "cb_altera"
        Me.cb_altera.Size = New System.Drawing.Size(65, 81)
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
        Me.cadastro_venda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cadastro_venda.Image = CType(resources.GetObject("cadastro_venda.Image"), System.Drawing.Image)
        Me.cadastro_venda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cadastro_venda.Location = New System.Drawing.Point(40, 295)
        Me.cadastro_venda.Name = "cadastro_venda"
        Me.cadastro_venda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cadastro_venda.Size = New System.Drawing.Size(65, 81)
        Me.cadastro_venda.TabIndex = 235
        Me.cadastro_venda.Text = "Salvar"
        Me.cadastro_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(32, 286)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(560, 95)
        Me.Label20.TabIndex = 242
        '
        'frm_fornecedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(632, 387)
        Me.ControlBox = False
        Me.Controls.Add(Me.cb_search)
        Me.Controls.Add(Me.Limpar)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.cb_apaga)
        Me.Controls.Add(Me.cb_print)
        Me.Controls.Add(Me.cb_altera)
        Me.Controls.Add(Me.cadastro_venda)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cb_outros)
        Me.Controls.Add(Me.cb_vidros)
        Me.Controls.Add(Me.cb_som)
        Me.Controls.Add(Me.cb_rodas)
        Me.Controls.Add(Me.cb_pneus)
        Me.Controls.Add(Me.cb_acessorios)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_fantasia)
        Me.Controls.Add(Me.txtpais_forn)
        Me.Controls.Add(Me.txtestado_forn)
        Me.Controls.Add(Me.txtcida_forn)
        Me.Controls.Add(Me.txtcnpj_forn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bt_select)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtend_forn)
        Me.Controls.Add(Me.txtnome_forn)
        Me.Controls.Add(Me.txtcod_forn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Name = "frm_fornecedores"
        Me.Text = "Cadastro de Fornecedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub bt_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_select.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Title = "Escolha uma imagem ne n_n weeeeeeeeee"
        OpenFileDialog1.InitialDirectory = Application.StartupPath & "\logos"

        OpenFileDialog1.Filter = "Arquivos de imagem|*.bmp;*.jpg"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Logo = OpenFileDialog1.FileName
            Dim newimg As Bitmap = New Bitmap(Logo)
            Me.picture_logo.Show()
            Me.picture_logo.Image = newimg

        End If
    End Sub

    Private Sub frm_fornecedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Controle As New Control
        For Each Controle In Me.Controls
            If TypeOf Controle Is TextBox Then
                Controle.Text = ""
            End If
        Next
        Me.picture_logo.Hide()
        cb_acessorios.CheckState = CheckState.Unchecked
        cb_vidros.CheckState = CheckState.Unchecked
        cb_som.CheckState = CheckState.Unchecked
        cb_pneus.CheckState = CheckState.Unchecked
        cb_rodas.CheckState = CheckState.Unchecked
        cb_outros.CheckState = CheckState.Unchecked

    End Sub

    Private Sub cadastro_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadastro_venda.Click
        If txtnome_forn.Text = "" Or txt_fantasia.Text = "" Or txtend_forn.Text = "" Or txtpais_forn.Text = "" Or txtcnpj_forn.Text = "" Or txtestado_forn.Text = "" Or txt_telefone.Text = "" Or txtcida_forn.Text = "" Or txt_email.Text = "" Then
            If cb_acessorios.Checked = False And cb_som.Checked = False And cb_pneus.Checked = False And cb_vidros.Checked = False And cb_rodas.Checked = False And cb_outros.Checked = False Then
                MsgBox("Por favor, preencha todos campos básicos necessários", MsgBoxStyle.Critical, "Incompleto")
                Exit Sub
            End If
        End If


        Dim acessorios As String
        Dim pneus As String
        Dim som As String
        Dim rodas As String
        Dim outros As String
        Dim vidros As String

        If cb_som.CheckState = CheckState.Checked Then
            som = "true"
        Else
            som = "false"
        End If
        If cb_acessorios.CheckState = CheckState.Checked Then
            acessorios = "true"
        Else
            acessorios = "false"
        End If
        If cb_pneus.CheckState = CheckState.Checked Then
            pneus = "true"
        Else
            pneus = "false"
        End If
        If cb_rodas.CheckState = CheckState.Checked Then
            rodas = "true"
        Else
            rodas = "false"
        End If
        If cb_outros.CheckState = CheckState.Checked Then
            outros = "true"
        Else
            outros = "false"
        End If
        If cb_vidros.CheckState = CheckState.Checked Then
            vidros = "true"
        Else
            vidros = "false"
        End If

        Dim comando As OleDbCommand

        Conexao.Open()
        comando = New OleDbCommand("INSERT into fornecedor(nome_forn,cnpj_forn,endereco_forn,cidade_forn,est_forn,pais_forn,logo_forn,email_forn,nome_fant_forn,telefone_forn,acessorios,som,pneus,vidros,outros,rodas,saldo_forn) values (@nome,@cnpj,@endereco,@cidade,@estado,@pais,@logo,@email,@fantasia,@telefone,@acessorios,@som,@pneus,@vidros,@outros,@rodas,'" & "0" & "')", Conexao)
        With comando
            .Parameters.Add(New OleDbParameter("@nome", OleDbType.VarChar, 255))
            .Parameters("@nome").Value = txtnome_forn.Text
            .Parameters.Add(New OleDbParameter("@cnpj", OleDbType.VarChar, 255))
            .Parameters("@cnpj").Value = txtcnpj_forn.Text
            .Parameters.Add(New OleDbParameter("@endereco", OleDbType.VarChar, 255))
            .Parameters("@endereco").Value = txtend_forn.Text
            .Parameters.Add(New OleDbParameter("@cidade", OleDbType.VarChar, 255))
            .Parameters("@cidade").Value = txtcida_forn.Text
            .Parameters.Add(New OleDbParameter("@estado", OleDbType.VarChar, 255))
            .Parameters("@estado").Value = txtestado_forn.Text
            .Parameters.Add(New OleDbParameter("@pais", OleDbType.VarChar, 255))
            .Parameters("@pais").Value = txtpais_forn.Text
            .Parameters.Add(New OleDbParameter("@logo", OleDbType.VarChar, 255))
            .Parameters("@logo").Value = Logo
            .Parameters.Add(New OleDbParameter("@email", OleDbType.VarChar, 255))
            .Parameters("@email").Value = txt_email.Text
            .Parameters.Add(New OleDbParameter("@fantasia", OleDbType.VarChar, 255))
            .Parameters("@fantasia").Value = txt_fantasia.Text
            .Parameters.Add(New OleDbParameter("@telefone", OleDbType.VarChar, 255))
            .Parameters("@telefone").Value = txt_telefone.Text
            .Parameters.Add(New OleDbParameter("@acessorios", OleDbType.Boolean))
            .Parameters("@acessorios").Value = acessorios
            .Parameters.Add(New OleDbParameter("@som", OleDbType.Boolean))
            .Parameters("@som").Value = som
            .Parameters.Add(New OleDbParameter("@pneus", OleDbType.Boolean))
            .Parameters("@pneus").Value = pneus
            .Parameters.Add(New OleDbParameter("@vidros", OleDbType.Boolean))
            .Parameters("@vidros").Value = vidros
            .Parameters.Add(New OleDbParameter("@outros", OleDbType.Boolean))
            .Parameters("@outros").Value = outros
            .Parameters.Add(New OleDbParameter("@rodas", OleDbType.Boolean))
            .Parameters("@rodas").Value = rodas
        End With
        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Registro cadastrado", "Inclusão de fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Erro")
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub Limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpar.Click
        Dim Controle As New Control
        For Each Controle In Me.Controls
            If TypeOf Controle Is TextBox Then
                Controle.Text = ""
            End If
        Next
        Me.picture_logo.Hide()
        cb_acessorios.CheckState = CheckState.Unchecked
        cb_vidros.CheckState = CheckState.Unchecked
        cb_som.CheckState = CheckState.Unchecked
        cb_pneus.CheckState = CheckState.Unchecked
        cb_rodas.CheckState = CheckState.Unchecked
        cb_outros.CheckState = CheckState.Unchecked
        Logo = ""
    End Sub

    Private Sub cb_altera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_altera.Click
        If txtnome_forn.Text = "" Or txt_fantasia.Text = "" Or txtend_forn.Text = "" Or txtpais_forn.Text = "" Or txtcnpj_forn.Text = "" Or txtestado_forn.Text = "" Or txt_telefone.Text = "" Or txtcida_forn.Text = "" Or txt_email.Text = "" Then
            If cb_acessorios.Checked = False And cb_som.Checked = False And cb_pneus.Checked = False And cb_vidros.Checked = False And cb_rodas.Checked = False And cb_outros.Checked = False Then
                MsgBox("Por favor, preencha todos campos básicos necessários", MsgBoxStyle.Critical, "Incompleto")
                Exit Sub
            End If
        End If


        Dim acessorios As String
        Dim pneus As String
        Dim som As String
        Dim rodas As String
        Dim outros As String
        Dim vidros As String

        If cb_som.CheckState = CheckState.Checked Then
            som = "true"
        Else
            som = "false"
        End If
        If cb_acessorios.CheckState = CheckState.Checked Then
            acessorios = "true"
        Else
            acessorios = "false"
        End If
        If cb_pneus.CheckState = CheckState.Checked Then
            pneus = "true"
        Else
            pneus = "false"
        End If
        If cb_rodas.CheckState = CheckState.Checked Then
            rodas = "true"
        Else
            rodas = "false"
        End If
        If cb_outros.CheckState = CheckState.Checked Then
            outros = "true"
        Else
            outros = "false"
        End If
        If cb_vidros.CheckState = CheckState.Checked Then
            vidros = "true"
        Else
            vidros = "false"
        End If
        AbrirBD()

        Dim comando As OleDbCommand
        comando = New OleDbCommand("Update fornecedor set nome_forn=@nome,cnpj_forn=@cnpj,endereco_forn=@endereco,cidade_forn=@cidade,est_forn=@estado,pais_forn=@pais,logo_forn=@logo,email_forn=@email,nome_fant_forn=@fantasia,telefone_forn=@telefone,acessorios=@acessorios,som=@som,pneus=@pneus,vidros=@vidros,outros=@outros,rodas=@rodas where cod_forn=@cod ", Conexao)
        With comando
            .Parameters.Add(New OleDbParameter("@nome", OleDbType.VarChar, 255))
            .Parameters("@nome").Value = txtnome_forn.Text
            .Parameters.Add(New OleDbParameter("@cnpj", OleDbType.VarChar, 255))
            .Parameters("@cnpj").Value = txtcnpj_forn.Text
            .Parameters.Add(New OleDbParameter("@endereco", OleDbType.VarChar, 255))
            .Parameters("@endereco").Value = txtend_forn.Text
            .Parameters.Add(New OleDbParameter("@cidade", OleDbType.VarChar, 255))
            .Parameters("@cidade").Value = txtcida_forn.Text
            .Parameters.Add(New OleDbParameter("@estado", OleDbType.VarChar, 255))
            .Parameters("@estado").Value = txtestado_forn.Text
            .Parameters.Add(New OleDbParameter("@pais", OleDbType.VarChar, 255))
            .Parameters("@pais").Value = txtpais_forn.Text
            .Parameters.Add(New OleDbParameter("@logo", OleDbType.VarChar, 255))
            .Parameters("@logo").Value = Logo
            .Parameters.Add(New OleDbParameter("@email", OleDbType.VarChar, 255))
            .Parameters("@email").Value = txt_email.Text
            .Parameters.Add(New OleDbParameter("@fantasia", OleDbType.VarChar, 255))
            .Parameters("@fantasia").Value = txt_fantasia.Text
            .Parameters.Add(New OleDbParameter("@telefone", OleDbType.VarChar, 255))
            .Parameters("@telefone").Value = txt_telefone.Text
            .Parameters.Add(New OleDbParameter("@acessorios", OleDbType.Boolean))
            .Parameters("@acessorios").Value = acessorios
            .Parameters.Add(New OleDbParameter("@som", OleDbType.Boolean))
            .Parameters("@som").Value = som
            .Parameters.Add(New OleDbParameter("@pneus", OleDbType.Boolean))
            .Parameters("@pneus").Value = pneus
            .Parameters.Add(New OleDbParameter("@vidros", OleDbType.Boolean))
            .Parameters("@vidros").Value = vidros
            .Parameters.Add(New OleDbParameter("@outros", OleDbType.Boolean))
            .Parameters("@outros").Value = outros
            .Parameters.Add(New OleDbParameter("@rodas", OleDbType.Boolean))
            .Parameters("@rodas").Value = rodas
            .Parameters.Add(New OleDbParameter("@cod", OleDbType.VarChar))
            .Parameters("@cod").Value = txtcod_forn.Text
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

    Private Sub cb_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_search.Click
        locforn.ShowDialog()
    End Sub

    Private Sub cb_apaga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_apaga.Click
        Dim Comando As OleDbCommand
        AbrirBD()
        Comando = New OleDbCommand("delete from fornecedor where cod_forn=@cod", Conexao)
        Comando.Parameters.Add(New OleDbParameter("@cod", OleDbType.Integer, 50))
        Comando.Parameters("@cod").Value = txtcod_forn.Text.ToString
        If MessageBox.Show("Deseja realmente deletar?", "Apagar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Comando.ExecuteNonQuery()
                MessageBox.Show("Registro apagado", "Apagar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim Controle As New Control
                For Each Controle In Me.Controls
                    If TypeOf Controle Is TextBox Then
                        Controle.Text = ""
                    End If
                Next
                cb_acessorios.CheckState = CheckState.Unchecked
                cb_vidros.CheckState = CheckState.Unchecked
                cb_som.CheckState = CheckState.Unchecked
                cb_pneus.CheckState = CheckState.Unchecked
                cb_rodas.CheckState = CheckState.Unchecked
                cb_outros.CheckState = CheckState.Unchecked
                Me.picture_logo.Hide()
                Logo = ""

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Apagar Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        FecharBD()

        locvei.lstvei.Items.Clear()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Visible = False
        principal.Visible = True
        principal.IconTray.Visible = False
    End Sub
End Class
