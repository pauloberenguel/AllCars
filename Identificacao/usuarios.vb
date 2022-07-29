Imports System.Drawing.Drawing2D
Imports System.Data.OleDb
Imports System.DateTime


Public Class usuarios
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
    Friend WithEvents lbl_criar As System.Windows.Forms.Label
    Friend WithEvents lbl_deletar As System.Windows.Forms.Label
    Friend WithEvents lbl_alterar As System.Windows.Forms.Label
    Friend WithEvents lbl_back As System.Windows.Forms.Label
    Public WithEvents pc_change As System.Windows.Forms.PictureBox
    Public WithEvents pc_del As System.Windows.Forms.PictureBox
    Public WithEvents pc_add As System.Windows.Forms.PictureBox
    Public WithEvents pc_back As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents bt_ok As System.Windows.Forms.Button
    Friend WithEvents bt_closelemb As System.Windows.Forms.Button
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents text_pass1 As System.Windows.Forms.TextBox
    Friend WithEvents text_pass2 As System.Windows.Forms.TextBox
    Friend WithEvents Combo_users As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cb_mec As System.Windows.Forms.CheckBox
    Friend WithEvents cb_compras As System.Windows.Forms.CheckBox
    Friend WithEvents cb_vendas As System.Windows.Forms.CheckBox
    Friend WithEvents cb_financas As System.Windows.Forms.CheckBox
    Friend WithEvents cb_alugueis As System.Windows.Forms.CheckBox
    Friend WithEvents cb_cadastros As System.Windows.Forms.CheckBox
    Friend WithEvents cb_adm As System.Windows.Forms.CheckBox
    Friend WithEvents txt_nomereal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox_acesso As System.Windows.Forms.GroupBox
    Public WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Public WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_lembrete As System.Windows.Forms.TextBox
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbau As System.Windows.Forms.Label
    Friend WithEvents lbv As System.Windows.Forms.Label
    Friend WithEvents lbcu As System.Windows.Forms.Label
    Public WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbdu As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(usuarios))
        Me.lbl_criar = New System.Windows.Forms.Label
        Me.lbl_deletar = New System.Windows.Forms.Label
        Me.lbl_alterar = New System.Windows.Forms.Label
        Me.lbl_back = New System.Windows.Forms.Label
        Me.pc_change = New System.Windows.Forms.PictureBox
        Me.pc_del = New System.Windows.Forms.PictureBox
        Me.pc_add = New System.Windows.Forms.PictureBox
        Me.pc_back = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.bt_closelemb = New System.Windows.Forms.Button
        Me.bt_ok = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_user = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnome = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txt_lembrete = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cb_cadastros = New System.Windows.Forms.CheckBox
        Me.cb_alugueis = New System.Windows.Forms.CheckBox
        Me.cb_financas = New System.Windows.Forms.CheckBox
        Me.cb_vendas = New System.Windows.Forms.CheckBox
        Me.cb_compras = New System.Windows.Forms.CheckBox
        Me.cb_mec = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Combo_users = New System.Windows.Forms.ComboBox
        Me.text_pass2 = New System.Windows.Forms.TextBox
        Me.txt_nomereal = New System.Windows.Forms.TextBox
        Me.text_pass1 = New System.Windows.Forms.TextBox
        Me.cb_adm = New System.Windows.Forms.CheckBox
        Me.GroupBox_acesso = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lbau = New System.Windows.Forms.Label
        Me.lbv = New System.Windows.Forms.Label
        Me.lbcu = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lbdu = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox_acesso.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_criar
        '
        Me.lbl_criar.AutoSize = True
        Me.lbl_criar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_criar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_criar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_criar.Font = New System.Drawing.Font("Niagara Solid", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_criar.Location = New System.Drawing.Point(0, 78)
        Me.lbl_criar.Name = "lbl_criar"
        Me.lbl_criar.Size = New System.Drawing.Size(65, 26)
        Me.lbl_criar.TabIndex = 0
        Me.lbl_criar.Text = "Criar user"
        '
        'lbl_deletar
        '
        Me.lbl_deletar.AutoSize = True
        Me.lbl_deletar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_deletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_deletar.Font = New System.Drawing.Font("Niagara Solid", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_deletar.Location = New System.Drawing.Point(104, 78)
        Me.lbl_deletar.Name = "lbl_deletar"
        Me.lbl_deletar.Size = New System.Drawing.Size(76, 26)
        Me.lbl_deletar.TabIndex = 1
        Me.lbl_deletar.Text = "Deletar user"
        '
        'lbl_alterar
        '
        Me.lbl_alterar.AutoSize = True
        Me.lbl_alterar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_alterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_alterar.Font = New System.Drawing.Font("Niagara Solid", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alterar.Location = New System.Drawing.Point(208, 78)
        Me.lbl_alterar.Name = "lbl_alterar"
        Me.lbl_alterar.Size = New System.Drawing.Size(75, 26)
        Me.lbl_alterar.TabIndex = 2
        Me.lbl_alterar.Text = "Alterar user"
        '
        'lbl_back
        '
        Me.lbl_back.AutoSize = True
        Me.lbl_back.BackColor = System.Drawing.Color.Transparent
        Me.lbl_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_back.Font = New System.Drawing.Font("Niagara Solid", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_back.Location = New System.Drawing.Point(328, 78)
        Me.lbl_back.Name = "lbl_back"
        Me.lbl_back.Size = New System.Drawing.Size(41, 26)
        Me.lbl_back.TabIndex = 3
        Me.lbl_back.Text = "Voltar"
        '
        'pc_change
        '
        Me.pc_change.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pc_change.Image = CType(resources.GetObject("pc_change.Image"), System.Drawing.Image)
        Me.pc_change.Location = New System.Drawing.Point(216, 9)
        Me.pc_change.Name = "pc_change"
        Me.pc_change.Size = New System.Drawing.Size(60, 65)
        Me.pc_change.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pc_change.TabIndex = 5
        Me.pc_change.TabStop = False
        '
        'pc_del
        '
        Me.pc_del.BackColor = System.Drawing.Color.Transparent
        Me.pc_del.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pc_del.Image = CType(resources.GetObject("pc_del.Image"), System.Drawing.Image)
        Me.pc_del.Location = New System.Drawing.Point(112, 9)
        Me.pc_del.Name = "pc_del"
        Me.pc_del.Size = New System.Drawing.Size(60, 65)
        Me.pc_del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pc_del.TabIndex = 6
        Me.pc_del.TabStop = False
        '
        'pc_add
        '
        Me.pc_add.BackColor = System.Drawing.Color.Transparent
        Me.pc_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pc_add.Image = CType(resources.GetObject("pc_add.Image"), System.Drawing.Image)
        Me.pc_add.Location = New System.Drawing.Point(8, 9)
        Me.pc_add.Name = "pc_add"
        Me.pc_add.Size = New System.Drawing.Size(60, 65)
        Me.pc_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pc_add.TabIndex = 7
        Me.pc_add.TabStop = False
        '
        'pc_back
        '
        Me.pc_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pc_back.Image = CType(resources.GetObject("pc_back.Image"), System.Drawing.Image)
        Me.pc_back.Location = New System.Drawing.Point(320, 9)
        Me.pc_back.Name = "pc_back"
        Me.pc_back.Size = New System.Drawing.Size(60, 65)
        Me.pc_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pc_back.TabIndex = 8
        Me.pc_back.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.pc_del)
        Me.GroupBox1.Controls.Add(Me.lbl_alterar)
        Me.GroupBox1.Controls.Add(Me.lbl_back)
        Me.GroupBox1.Controls.Add(Me.lbl_criar)
        Me.GroupBox1.Controls.Add(Me.pc_change)
        Me.GroupBox1.Controls.Add(Me.lbl_deletar)
        Me.GroupBox1.Controls.Add(Me.pc_add)
        Me.GroupBox1.Controls.Add(Me.pc_back)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 108)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.bt_closelemb)
        Me.GroupBox2.Controls.Add(Me.bt_ok)
        Me.GroupBox2.Controls.Add(Me.RichTextBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_pass)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_user)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtnome)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 407)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'bt_closelemb
        '
        Me.bt_closelemb.BackColor = System.Drawing.Color.DimGray
        Me.bt_closelemb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_closelemb.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_closelemb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_closelemb.Font = New System.Drawing.Font("Kristen ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_closelemb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_closelemb.Location = New System.Drawing.Point(368, 17)
        Me.bt_closelemb.Name = "bt_closelemb"
        Me.bt_closelemb.Size = New System.Drawing.Size(32, 26)
        Me.bt_closelemb.TabIndex = 42
        Me.bt_closelemb.Text = "X"
        '
        'bt_ok
        '
        Me.bt_ok.BackColor = System.Drawing.Color.Black
        Me.bt_ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_ok.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.bt_ok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_ok.Location = New System.Drawing.Point(344, 338)
        Me.bt_ok.Name = "bt_ok"
        Me.bt_ok.Size = New System.Drawing.Size(40, 35)
        Me.bt_ok.TabIndex = 41
        Me.bt_ok.Text = "OK"
        Me.bt_ok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.SlateGray
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RichTextBox1.DetectUrls = False
        Me.RichTextBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.HideSelection = False
        Me.RichTextBox1.Location = New System.Drawing.Point(24, 87)
        Me.RichTextBox1.MaxLength = 1000
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(360, 52)
        Me.RichTextBox1.TabIndex = 40
        Me.RichTextBox1.Text = "" & Microsoft.VisualBasic.ChrW(9) & "Por medidas de seguranca, qualquer alteracao nesta secao, antes de ser executada" & _
        ", pedimos que entre novamente com seus dados"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(288, 43)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Security System"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(152, 277)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(120, 20)
        Me.txt_pass.TabIndex = 7
        Me.txt_pass.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Ivory
        Me.Label2.Location = New System.Drawing.Point(48, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(152, 225)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(120, 20)
        Me.txt_user.TabIndex = 4
        Me.txt_user.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Ivory
        Me.Label1.Location = New System.Drawing.Point(48, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(152, 173)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(232, 20)
        Me.txtnome.TabIndex = 2
        Me.txtnome.Text = ""
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Ivory
        Me.Label18.Location = New System.Drawing.Point(48, 173)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 25)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Nome real"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_lembrete)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.cb_cadastros)
        Me.GroupBox3.Controls.Add(Me.cb_alugueis)
        Me.GroupBox3.Controls.Add(Me.cb_financas)
        Me.GroupBox3.Controls.Add(Me.cb_vendas)
        Me.GroupBox3.Controls.Add(Me.cb_compras)
        Me.GroupBox3.Controls.Add(Me.cb_mec)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Combo_users)
        Me.GroupBox3.Controls.Add(Me.text_pass2)
        Me.GroupBox3.Controls.Add(Me.txt_nomereal)
        Me.GroupBox3.Controls.Add(Me.text_pass1)
        Me.GroupBox3.Controls.Add(Me.cb_adm)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 113)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(408, 294)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'txt_lembrete
        '
        Me.txt_lembrete.Location = New System.Drawing.Point(304, 78)
        Me.txt_lembrete.Multiline = True
        Me.txt_lembrete.Name = "txt_lembrete"
        Me.txt_lembrete.Size = New System.Drawing.Size(100, 61)
        Me.txt_lembrete.TabIndex = 30
        Me.txt_lembrete.Text = ""
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Ivory
        Me.Label13.Location = New System.Drawing.Point(232, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 25)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Lembrete de senha"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cb_cadastros
        '
        Me.cb_cadastros.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_cadastros.ForeColor = System.Drawing.Color.Ivory
        Me.cb_cadastros.Location = New System.Drawing.Point(296, 243)
        Me.cb_cadastros.Name = "cb_cadastros"
        Me.cb_cadastros.Size = New System.Drawing.Size(96, 26)
        Me.cb_cadastros.TabIndex = 28
        Me.cb_cadastros.Text = "Cadastros"
        '
        'cb_alugueis
        '
        Me.cb_alugueis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_alugueis.ForeColor = System.Drawing.Color.Ivory
        Me.cb_alugueis.Location = New System.Drawing.Point(208, 243)
        Me.cb_alugueis.Name = "cb_alugueis"
        Me.cb_alugueis.Size = New System.Drawing.Size(120, 26)
        Me.cb_alugueis.TabIndex = 27
        Me.cb_alugueis.Text = "Aluguéis"
        '
        'cb_financas
        '
        Me.cb_financas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_financas.ForeColor = System.Drawing.Color.Ivory
        Me.cb_financas.Location = New System.Drawing.Point(120, 243)
        Me.cb_financas.Name = "cb_financas"
        Me.cb_financas.Size = New System.Drawing.Size(120, 26)
        Me.cb_financas.TabIndex = 26
        Me.cb_financas.Text = "Finanças"
        '
        'cb_vendas
        '
        Me.cb_vendas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_vendas.ForeColor = System.Drawing.Color.Ivory
        Me.cb_vendas.Location = New System.Drawing.Point(296, 208)
        Me.cb_vendas.Name = "cb_vendas"
        Me.cb_vendas.Size = New System.Drawing.Size(88, 26)
        Me.cb_vendas.TabIndex = 25
        Me.cb_vendas.Text = "Vendas"
        '
        'cb_compras
        '
        Me.cb_compras.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_compras.ForeColor = System.Drawing.Color.Ivory
        Me.cb_compras.Location = New System.Drawing.Point(208, 208)
        Me.cb_compras.Name = "cb_compras"
        Me.cb_compras.Size = New System.Drawing.Size(120, 26)
        Me.cb_compras.TabIndex = 24
        Me.cb_compras.Text = "Compras"
        '
        'cb_mec
        '
        Me.cb_mec.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_mec.ForeColor = System.Drawing.Color.Ivory
        Me.cb_mec.Location = New System.Drawing.Point(120, 208)
        Me.cb_mec.Name = "cb_mec"
        Me.cb_mec.Size = New System.Drawing.Size(120, 26)
        Me.cb_mec.TabIndex = 23
        Me.cb_mec.Text = "Mecânica"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Ivory
        Me.Label8.Location = New System.Drawing.Point(24, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 25)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Direito de acesso"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Ivory
        Me.Label6.Location = New System.Drawing.Point(24, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Nome real"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Ivory
        Me.Label7.Location = New System.Drawing.Point(24, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 25)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Repita o Password"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Ivory
        Me.Label5.Location = New System.Drawing.Point(24, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Password"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Ivory
        Me.Label3.Location = New System.Drawing.Point(24, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Username"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Combo_users
        '
        Me.Combo_users.Location = New System.Drawing.Point(120, 35)
        Me.Combo_users.Name = "Combo_users"
        Me.Combo_users.Size = New System.Drawing.Size(152, 21)
        Me.Combo_users.TabIndex = 16
        '
        'text_pass2
        '
        Me.text_pass2.Location = New System.Drawing.Point(120, 121)
        Me.text_pass2.Name = "text_pass2"
        Me.text_pass2.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.text_pass2.TabIndex = 14
        Me.text_pass2.Text = ""
        '
        'txt_nomereal
        '
        Me.txt_nomereal.Location = New System.Drawing.Point(120, 165)
        Me.txt_nomereal.Name = "txt_nomereal"
        Me.txt_nomereal.Size = New System.Drawing.Size(152, 20)
        Me.txt_nomereal.TabIndex = 13
        Me.txt_nomereal.Text = ""
        '
        'text_pass1
        '
        Me.text_pass1.Location = New System.Drawing.Point(120, 78)
        Me.text_pass1.Name = "text_pass1"
        Me.text_pass1.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.text_pass1.TabIndex = 12
        Me.text_pass1.Text = ""
        '
        'cb_adm
        '
        Me.cb_adm.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_adm.ForeColor = System.Drawing.Color.Tomato
        Me.cb_adm.Location = New System.Drawing.Point(336, 17)
        Me.cb_adm.Name = "cb_adm"
        Me.cb_adm.Size = New System.Drawing.Size(64, 18)
        Me.cb_adm.TabIndex = 12
        Me.cb_adm.Text = "Adm?"
        '
        'GroupBox_acesso
        '
        Me.GroupBox_acesso.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox_acesso.Controls.Add(Me.PictureBox1)
        Me.GroupBox_acesso.Controls.Add(Me.lbau)
        Me.GroupBox_acesso.Controls.Add(Me.lbv)
        Me.GroupBox_acesso.Controls.Add(Me.lbcu)
        Me.GroupBox_acesso.Controls.Add(Me.PictureBox2)
        Me.GroupBox_acesso.Controls.Add(Me.lbdu)
        Me.GroupBox_acesso.Controls.Add(Me.PictureBox3)
        Me.GroupBox_acesso.Controls.Add(Me.PictureBox4)
        Me.GroupBox_acesso.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox_acesso.Name = "GroupBox_acesso"
        Me.GroupBox_acesso.Size = New System.Drawing.Size(408, 108)
        Me.GroupBox_acesso.TabIndex = 12
        Me.GroupBox_acesso.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(112, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'lbau
        '
        Me.lbau.AutoSize = True
        Me.lbau.BackColor = System.Drawing.Color.Transparent
        Me.lbau.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbau.Font = New System.Drawing.Font("Niagara Solid", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbau.Location = New System.Drawing.Point(208, 78)
        Me.lbau.Name = "lbau"
        Me.lbau.Size = New System.Drawing.Size(75, 26)
        Me.lbau.TabIndex = 2
        Me.lbau.Text = "Alterar user"
        '
        'lbv
        '
        Me.lbv.AutoSize = True
        Me.lbv.BackColor = System.Drawing.Color.Transparent
        Me.lbv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbv.Font = New System.Drawing.Font("Niagara Solid", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbv.Location = New System.Drawing.Point(328, 78)
        Me.lbv.Name = "lbv"
        Me.lbv.Size = New System.Drawing.Size(41, 26)
        Me.lbv.TabIndex = 3
        Me.lbv.Text = "Voltar"
        '
        'lbcu
        '
        Me.lbcu.AutoSize = True
        Me.lbcu.BackColor = System.Drawing.Color.Transparent
        Me.lbcu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbcu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbcu.Font = New System.Drawing.Font("Niagara Solid", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcu.Location = New System.Drawing.Point(0, 78)
        Me.lbcu.Name = "lbcu"
        Me.lbcu.Size = New System.Drawing.Size(65, 26)
        Me.lbcu.TabIndex = 0
        Me.lbcu.Text = "Criar user"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(216, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'lbdu
        '
        Me.lbdu.AutoSize = True
        Me.lbdu.BackColor = System.Drawing.Color.Transparent
        Me.lbdu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbdu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbdu.Font = New System.Drawing.Font("Niagara Solid", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdu.Location = New System.Drawing.Point(104, 78)
        Me.lbdu.Name = "lbdu"
        Me.lbdu.Size = New System.Drawing.Size(76, 26)
        Me.lbdu.TabIndex = 1
        Me.lbdu.Text = "Deletar user"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(8, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 65)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(320, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(60, 65)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'usuarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(424, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox_acesso)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximumSize = New System.Drawing.Size(432, 424)
        Me.MinimumSize = New System.Drawing.Size(432, 136)
        Me.Name = "usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Usuários"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox_acesso.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim allow As Boolean
    Dim count As Integer

#Region "Esqueminha de cores"
    Private Sub usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox_acesso.Visible = False
        GroupBox3.Visible = False
        Me.Size = New Size(432, 136)
        Dim bolinha As New GraphicsPath
        bolinha.AddPie(0, 0, 30, 30, 0, 360)
        bt_ok.Region = New System.Drawing.Region(bolinha)
        bt_closelemb.Region = New System.Drawing.Region(bolinha)
    End Sub

    Private Sub pc_add_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_add.MouseEnter
        lbl_criar.Focus()
        lbl_criar.ForeColor = Color.Aqua
    End Sub

    Private Sub pc_change_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_change.MouseEnter
        lbl_alterar.Focus()
        lbl_alterar.ForeColor = Color.Aqua
    End Sub

    Private Sub pc_del_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_del.MouseEnter
        lbl_deletar.Focus()
        lbl_deletar.ForeColor = Color.Aqua
    End Sub

    Private Sub pc_change_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pc_change.MouseLeave
        lbl_alterar.ForeColor = Color.Black
    End Sub

    Private Sub pc_back_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pc_back.MouseLeave
        lbl_back.ForeColor = Color.Black
    End Sub

    Private Sub pc_back_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pc_back.MouseEnter
        lbl_back.Focus()
        lbl_back.ForeColor = Color.Aqua
    End Sub

    Private Sub pc_del_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pc_del.MouseLeave
        lbl_deletar.ForeColor = Color.Black
    End Sub

    Private Sub pc_add_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pc_add.MouseLeave
        lbl_criar.ForeColor = Color.Black
    End Sub


    Private Sub lbl_deletar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_deletar.MouseEnter
        lbl_deletar.ForeColor = Color.Aqua
    End Sub

    Private Sub lbl_deletar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_deletar.MouseLeave
        lbl_deletar.ForeColor = Color.Black
    End Sub

    Private Sub lbl_back_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_back.MouseEnter
        lbl_back.ForeColor = Color.Aqua
    End Sub

    Private Sub lbl_back_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_back.MouseLeave
        lbl_back.ForeColor = Color.Black
    End Sub

    Private Sub lbl_alterar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_alterar.MouseEnter
        lbl_alterar.ForeColor = Color.Aqua
    End Sub

    Private Sub lbl_alterar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_alterar.MouseLeave
        lbl_alterar.ForeColor = Color.Black
    End Sub

    Private Sub lbl_criar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_criar.MouseEnter
        lbl_criar.ForeColor = Color.Aqua
    End Sub

    Private Sub lbl_criar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_criar.MouseLeave
        lbl_criar.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        lbcu.ForeColor = Color.Aqua
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        lbcu.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        lbdu.ForeColor = Color.Aqua
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        lbdu.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        lbau.ForeColor = Color.Aqua
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        lbau.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        lbv.ForeColor = Color.Aqua
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        lbv.ForeColor = Color.Black
    End Sub

#End Region

#Region "Verificacao..."
    Private Sub bt_closelemb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_closelemb.Click
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        Me.Size = New Size(432, 136)

    End Sub

    Private Sub bt_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ok.Click
        Dim nama As String
        Dim comando As OleDbCommand
        Dim data As OleDbDataReader
        Dim pass As String
        Dim verificacao_time As Date
        Dim admtmp As Boolean

        comando = New OleDbCommand("select * from usuarios where username='" & txt_user.Text & "'", Conexao)
        Try
            AbrirBD()
            data = comando.ExecuteReader
            If data.Read Then
                pass = data("passwordd")
                verificacao_time = data("time_again")
                allow = data("allowed")
                nama = data("true_name")
                admtmp = data("adm")
            End If
        Catch ex As Exception
            MsgBox("Verifique campos digitados", MsgBoxStyle.OKOnly, "Campos")
        Finally
            FecharBD()
        End Try

        If System.DateTime.Compare(verificacao_time, System.DateTime.Now.ToShortTimeString) < 0 Then
            allow = True
            Dim comando2 As OleDbCommand
            comando2 = New OleDbCommand("Update usuarios set allowed=@allowed where username=@username", Conexao)
            comando2.Parameters.Add(New OleDbParameter("@allowed", OleDbType.Boolean, 50))
            comando2.Parameters("@allowed").Value = allow
            comando2.Parameters.Add(New OleDbParameter("@username", OleDbType.VarChar, 50))
            comando2.Parameters("@username").Value = txt_user.Text
            AbrirBD()
            Try
                comando2.ExecuteNonQuery()
                FecharBD()
            Catch ex As Exception
                MsgBox("erro")
            End Try

        End If



        If (txt_pass.Text.ToString = pass) And (txtnome.Text.ToString = nama) Then
            If admtmp = True Then
                txt_pass.Text = ""
                txt_user.Text = ""
                count = 1
                GroupBox_acesso.Visible = True
                GroupBox1.Visible = False
                GroupBox3.Visible = True
                GroupBox2.Visible = False
            End If
        Else
            count = count + 1
            MsgBox("Password e/ou nome errado(s) | Erros:  " & count & " | Tentativas restantes:  " & Val(5 - count))
        End If

        If count = 5 Then
            Dim comando2 As OleDbCommand
            allow = False
            comando2 = New OleDbCommand("Update usuarios set time_again=@tempo,allowed=@allowed,dia_aux=@day where username=@username", Conexao)
            comando2.Parameters.Add(New OleDbParameter("@tempo", OleDbType.VarChar, 50))
            comando2.Parameters("@tempo").Value = System.DateTime.Now.AddMinutes(10).ToShortTimeString
            comando2.Parameters.Add(New OleDbParameter("@day", OleDbType.DBDate))
            comando2.Parameters("@day").Value = System.DateTime.Today.ToShortDateString
            comando2.Parameters.Add(New OleDbParameter("@allowed", OleDbType.Boolean, 50))
            comando2.Parameters("@allowed").Value = allow
            comando2.Parameters.Add(New OleDbParameter("@username", OleDbType.VarChar, 50))
            comando2.Parameters("@username").Value = txt_user.Text
            MsgBox("Números excedentes de erros permitidos, aguarde 10 minutos", MsgBoxStyle.OKOnly, "Aguarde")
            AbrirBD()
            comando2.ExecuteNonQuery()
            FecharBD()
            inicial.Visible = True
            principal.Visible = False
            Me.Visible = False
            principal.IconTray.Visible = False
        End If
        FecharBD()


    End Sub

#End Region

#Region "Groupbox cima"
    Private Sub pc_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_add.Click
        Me.Size = New Size(432, 424)
        GroupBox1.Visible = False
        GroupBox2.Visible = True
    End Sub

    Private Sub lbl_criar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_criar.Click
        Me.Size = New Size(432, 424)
        GroupBox1.Visible = False
        GroupBox2.Visible = True
    End Sub

    Private Sub pc_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_del.Click
        Me.Size = New Size(432, 424)
        GroupBox1.Visible = False
        GroupBox2.Visible = True
    End Sub

    Private Sub lbl_deletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_deletar.Click
        Me.Size = New Size(432, 424)
        GroupBox1.Visible = False
        GroupBox2.Visible = True
    End Sub

    Private Sub pc_change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_change.Click
        Me.Size = New Size(432, 424)
        GroupBox1.Visible = False
        GroupBox2.Visible = True
    End Sub

    Private Sub lbl_alterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_alterar.Click
        Me.Size = New Size(432, 424)
        GroupBox1.Visible = False
        GroupBox2.Visible = True
    End Sub

    Private Sub pc_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_back.Click
        Me.Visible = False
        principal.Visible = True
        principal.IconTray.Visible = False

    End Sub

    Private Sub lbl_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_back.Click
        Me.Visible = False
        principal.Visible = True
        principal.IconTray.Visible = False
    End Sub
#End Region

    Private Sub adduser_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If text_pass1.Text = text_pass2.Text Then
            Dim comando As OleDbCommand
            AbrirBD()
            comando = New OleDbCommand("INSERT into usuarios(username,passwordd,true_name,pass_help,time_again,dia_aux,allowed,adm,mecanica,compras,vendas,financas,alugueis,cadastros)values(@username,@passwordd,@true_name,@pass_help,'00:00','2000/05/05',true,@adm,@mecanica,@compras,@vendas,@financas,@alugueis,@cadastros)", Conexao)
            With comando
                .Parameters.Add(New OleDbParameter("@username", OleDbType.VarChar, 100))
                .Parameters("@username").Value = Combo_users.Text
                .Parameters.Add(New OleDbParameter("@passwordd", OleDbType.VarChar, 100))
                .Parameters("@passwordd").Value = text_pass1.Text
                .Parameters.Add(New OleDbParameter("@true_name", OleDbType.VarChar, 100))
                .Parameters("@true_name").Value = txt_nomereal.Text
                .Parameters.Add(New OleDbParameter("@pass_help", OleDbType.VarChar, 100))
                .Parameters("@pass_help").Value = txt_lembrete.Text
                .Parameters.Add(New OleDbParameter("@adm", OleDbType.Boolean))
                .Parameters("@adm").Value = cb_adm.Checked
                .Parameters.Add(New OleDbParameter("@mecanica", OleDbType.Boolean))
                .Parameters("@mecanica").Value = cb_mec.Checked
                .Parameters.Add(New OleDbParameter("@compras", OleDbType.Boolean))
                .Parameters("@compras").Value = cb_compras.Checked
                .Parameters.Add(New OleDbParameter("@vendas", OleDbType.Boolean))
                .Parameters("@vendas").Value = cb_vendas.Checked
                .Parameters.Add(New OleDbParameter("@financas", OleDbType.Boolean))
                .Parameters("@financas").Value = cb_financas.Checked
                .Parameters.Add(New OleDbParameter("@alugueis", OleDbType.Boolean))
                .Parameters("@alugueis").Value = cb_alugueis.Checked
                .Parameters.Add(New OleDbParameter("@cadastros", OleDbType.Boolean))
                .Parameters("@cadastros").Value = cb_cadastros.Checked
            End With

            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("registrado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button3, MessageBoxOptions.DefaultDesktopOnly)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Erro")
            Finally
                FecharBD()
            End Try
        Else
            MsgBox("Passwords diferentes", MsgBoxStyle.Information, "Digite novamente")
        End If
    End Sub

    Private Sub ladduser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbcu.Click
        PictureBox3.InitializeLifetimeService()
    End Sub

    Private Sub deluser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim Comando As OleDbCommand
        AbrirBD()
        Comando = New OleDbCommand("delete from usuarios where username=@username", Conexao)
        Comando.Parameters.Add(New OleDbParameter("@username", OleDbType.VarChar, 50))
        Comando.Parameters("@username").Value = Combo_users.Text.ToString
        If MessageBox.Show("Deseja realmente deletar este usuario?", "Apagar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Comando.ExecuteNonQuery()
                MessageBox.Show("Usuario deletado", "Apagar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Combo_users.Text = ""
                text_pass1.Text = ""
                text_pass2.Text = ""
                txt_nomereal.Text = ""
                txt_lembrete.Text = ""
                cb_mec.Checked = False
                cb_compras.Checked = False
                cb_vendas.Checked = False
                cb_financas.Checked = False
                cb_adm.Checked = False
                cb_alugueis.Checked = False
                cb_cadastros.Checked = False
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Apagar Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        FecharBD()
    End Sub

    Private Sub ldeluser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbdu.Click

    End Sub

    Private Sub changeuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If text_pass1.Text = text_pass2.Text Then
            Dim comando As OleDbCommand
            AbrirBD()
            comando = New OleDbCommand("Update usuarios set passwordd=@passwordd,true_name=@true_name,pass_help=@pass_help,time_again='00:00',dia_aux='2000/05/05',allowed=true,adm=@adm,mecanica=@mecanica,compras=@compras,vendas=@vendas,financas=@financas,alugueis=@alugueis,cadastros=@cadastros where username=@username", Conexao)
            With comando
                .Parameters.Add(New OleDbParameter("@passwordd", OleDbType.VarChar, 100))
                .Parameters("@passwordd").Value = text_pass1.Text
                .Parameters.Add(New OleDbParameter("@true_name", OleDbType.VarChar, 100))
                .Parameters("@true_name").Value = txt_nomereal.Text
                .Parameters.Add(New OleDbParameter("@pass_help", OleDbType.VarChar, 100))
                .Parameters("@pass_help").Value = txt_lembrete.Text
                .Parameters.Add(New OleDbParameter("@adm", OleDbType.Boolean))
                .Parameters("@adm").Value = cb_adm.Checked
                .Parameters.Add(New OleDbParameter("@mecanica", OleDbType.Boolean))
                .Parameters("@mecanica").Value = cb_mec.Checked
                .Parameters.Add(New OleDbParameter("@compras", OleDbType.Boolean))
                .Parameters("@compras").Value = cb_compras.Checked
                .Parameters.Add(New OleDbParameter("@vendas", OleDbType.Boolean))
                .Parameters("@vendas").Value = cb_vendas.Checked
                .Parameters.Add(New OleDbParameter("@financas", OleDbType.Boolean))
                .Parameters("@financas").Value = cb_financas.Checked
                .Parameters.Add(New OleDbParameter("@alugueis", OleDbType.Boolean))
                .Parameters("@alugueis").Value = cb_alugueis.Checked
                .Parameters.Add(New OleDbParameter("@cadastros", OleDbType.Boolean))
                .Parameters("@cadastros").Value = cb_cadastros.Checked
                .Parameters.Add(New OleDbParameter("@username", OleDbType.VarChar, 100))
                .Parameters("@username").Value = Combo_users.Text
            End With
            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("Dados alterados", "Alteracao de registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try
        Else
            MsgBox("Passwords diferentes", MsgBoxStyle.Information, "Digite novamente")
        End If
    End Sub

    Private Sub Lchangeuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbau.Click

    End Sub

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Me.Visible = False
        principal.Visible = True
        principal.IconTray.Visible = False
    End Sub

    Private Sub Lback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbv.Click
        Me.Visible = False
        principal.Visible = True
        principal.IconTray.Visible = False
    End Sub

    Private Sub Combo_users_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_users.GotFocus
        Combo_users.Items.Clear()
        Dim comando As OleDbCommand
        Dim D As OleDbDataReader
        comando = New OleDbCommand("select username from usuarios", Conexao)
        AbrirBD()
        D = comando.ExecuteReader
        While D.Read
            Combo_users.Items.Add(D("username"))
        End While
        D.Close()
        FecharBD()
    End Sub

    Private Sub Combo_users_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_users.SelectedIndexChanged
        Dim comando As OleDbCommand
        Dim D As OleDbDataReader
        comando = New OleDbCommand("select * from usuarios where username='" & Combo_users.Text.ToString & "'", Conexao)
        AbrirBD()
        D = comando.ExecuteReader
        If D.Read Then
            txt_lembrete.Text = D("pass_help")
            text_pass1.Text = D("passwordd")
            text_pass2.Text = D("passwordd")
            txt_nomereal.Text = D("true_name")
            cb_mec.Checked = D("mecanica")
            cb_compras.Checked = D("compras")
            cb_vendas.Checked = D("vendas")
            cb_financas.Checked = D("financas")
            cb_alugueis.Checked = D("alugueis")
            cb_cadastros.Checked = D("cadastros")
            cb_adm.Checked = D("adm")
        End If
        D.Close()
        FecharBD()
    End Sub

    Private Sub cb_adm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_adm.CheckedChanged
        cb_mec.Checked = cb_adm.CheckState
        cb_compras.Checked = cb_adm.CheckState
        cb_vendas.Checked = cb_adm.CheckState
        cb_financas.Checked = cb_adm.CheckState
        cb_alugueis.Checked = cb_adm.CheckState
        cb_cadastros.Checked = cb_adm.CheckState
        cb_adm.Checked = cb_adm.CheckState
    End Sub


End Class
