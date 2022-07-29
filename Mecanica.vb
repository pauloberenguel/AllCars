Imports System.Data.OleDb
Public Class MECANICA
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_carroceria As System.Windows.Forms.CheckBox
    Friend WithEvents cb_direcao As System.Windows.Forms.CheckBox
    Friend WithEvents cb_freios As System.Windows.Forms.CheckBox
    Friend WithEvents cb_motor As System.Windows.Forms.CheckBox
    Friend WithEvents cb_eletric As System.Windows.Forms.CheckBox
    Friend WithEvents cb_suspensao As System.Windows.Forms.CheckBox
    Friend WithEvents cb_transmicao As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Cb_Cli As System.Windows.Forms.ComboBox
    Friend WithEvents txt_orcamento As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_prodtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_maoobra As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents cb_print As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents arquivo_mecanica As System.Windows.Forms.Button
    Friend WithEvents cb_search As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents codcli As System.Windows.Forms.TextBox
    Friend WithEvents txt_modelo As System.Windows.Forms.TextBox
    Friend WithEvents txt_placa As System.Windows.Forms.TextBox
    Friend WithEvents status As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MECANICA))
        Me.txt_orcamento = New System.Windows.Forms.TextBox
        Me.txt_placa = New System.Windows.Forms.TextBox
        Me.txt_modelo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.cb_carroceria = New System.Windows.Forms.CheckBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.cb_direcao = New System.Windows.Forms.CheckBox
        Me.cb_freios = New System.Windows.Forms.CheckBox
        Me.cb_motor = New System.Windows.Forms.CheckBox
        Me.cb_eletric = New System.Windows.Forms.CheckBox
        Me.cb_suspensao = New System.Windows.Forms.CheckBox
        Me.cb_transmicao = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Cb_Cli = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_prodtotal = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_maoobra = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.cb_print = New System.Windows.Forms.Button
        Me.arquivo_mecanica = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cb_search = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.codcli = New System.Windows.Forms.TextBox
        Me.status = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.GroupBox1.SuspendLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_orcamento
        '
        Me.txt_orcamento.Location = New System.Drawing.Point(248, 425)
        Me.txt_orcamento.Name = "txt_orcamento"
        Me.txt_orcamento.Size = New System.Drawing.Size(112, 20)
        Me.txt_orcamento.TabIndex = 1
        Me.txt_orcamento.Text = ""
        '
        'txt_placa
        '
        Me.txt_placa.Location = New System.Drawing.Point(264, 78)
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(104, 20)
        Me.txt_placa.TabIndex = 4
        Me.txt_placa.Text = ""
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(112, 121)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(176, 20)
        Me.txt_modelo.TabIndex = 5
        Me.txt_modelo.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Beige
        Me.Label3.Location = New System.Drawing.Point(0, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 26)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Nome do Cliente"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(200, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 35)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Placa do Carro"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Beige
        Me.Label4.Location = New System.Drawing.Point(112, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 16)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "OrÁamento Final"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Beige
        Me.Label6.Location = New System.Drawing.Point(0, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 26)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Modelo do carro do cliente"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(0, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 69)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Produtos a serem utilizados"
        '
        'cb_carroceria
        '
        Me.cb_carroceria.BackColor = System.Drawing.Color.Transparent
        Me.cb_carroceria.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cb_carroceria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_carroceria.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_carroceria.ForeColor = System.Drawing.Color.Beige
        Me.cb_carroceria.Location = New System.Drawing.Point(8, 69)
        Me.cb_carroceria.Name = "cb_carroceria"
        Me.cb_carroceria.Size = New System.Drawing.Size(88, 35)
        Me.cb_carroceria.TabIndex = 66
        Me.cb_carroceria.Text = "Carroceria"
        Me.cb_carroceria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(96, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 68
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(176, 26)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(70, 49)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 69
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(256, 26)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(70, 49)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 70
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(32, 113)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(70, 48)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 71
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(136, 113)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(70, 48)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 72
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(240, 113)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(70, 48)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 73
        Me.PictureBox7.TabStop = False
        '
        'cb_direcao
        '
        Me.cb_direcao.BackColor = System.Drawing.Color.Transparent
        Me.cb_direcao.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cb_direcao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_direcao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_direcao.ForeColor = System.Drawing.Color.Beige
        Me.cb_direcao.Location = New System.Drawing.Point(104, 69)
        Me.cb_direcao.Name = "cb_direcao"
        Me.cb_direcao.Size = New System.Drawing.Size(72, 35)
        Me.cb_direcao.TabIndex = 74
        Me.cb_direcao.Text = "DireÁ„o"
        Me.cb_direcao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_freios
        '
        Me.cb_freios.BackColor = System.Drawing.Color.Transparent
        Me.cb_freios.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cb_freios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_freios.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_freios.ForeColor = System.Drawing.Color.Beige
        Me.cb_freios.Location = New System.Drawing.Point(184, 69)
        Me.cb_freios.Name = "cb_freios"
        Me.cb_freios.Size = New System.Drawing.Size(64, 35)
        Me.cb_freios.TabIndex = 75
        Me.cb_freios.Text = "Freios"
        Me.cb_freios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_motor
        '
        Me.cb_motor.BackColor = System.Drawing.Color.Transparent
        Me.cb_motor.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cb_motor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_motor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_motor.ForeColor = System.Drawing.Color.Beige
        Me.cb_motor.Location = New System.Drawing.Point(264, 69)
        Me.cb_motor.Name = "cb_motor"
        Me.cb_motor.Size = New System.Drawing.Size(64, 35)
        Me.cb_motor.TabIndex = 76
        Me.cb_motor.Text = "Motor"
        Me.cb_motor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_eletric
        '
        Me.cb_eletric.BackColor = System.Drawing.Color.Transparent
        Me.cb_eletric.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cb_eletric.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_eletric.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_eletric.ForeColor = System.Drawing.Color.Beige
        Me.cb_eletric.Location = New System.Drawing.Point(0, 156)
        Me.cb_eletric.Name = "cb_eletric"
        Me.cb_eletric.Size = New System.Drawing.Size(136, 35)
        Me.cb_eletric.TabIndex = 77
        Me.cb_eletric.Text = "Sistemas-ElÈtricos"
        Me.cb_eletric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_suspensao
        '
        Me.cb_suspensao.BackColor = System.Drawing.Color.Transparent
        Me.cb_suspensao.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cb_suspensao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_suspensao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_suspensao.ForeColor = System.Drawing.Color.Beige
        Me.cb_suspensao.Location = New System.Drawing.Point(128, 156)
        Me.cb_suspensao.Name = "cb_suspensao"
        Me.cb_suspensao.Size = New System.Drawing.Size(96, 35)
        Me.cb_suspensao.TabIndex = 78
        Me.cb_suspensao.Text = "Suspens„o"
        Me.cb_suspensao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_transmicao
        '
        Me.cb_transmicao.BackColor = System.Drawing.Color.Transparent
        Me.cb_transmicao.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cb_transmicao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_transmicao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cb_transmicao.ForeColor = System.Drawing.Color.Beige
        Me.cb_transmicao.Location = New System.Drawing.Point(224, 156)
        Me.cb_transmicao.Name = "cb_transmicao"
        Me.cb_transmicao.Size = New System.Drawing.Size(96, 35)
        Me.cb_transmicao.TabIndex = 79
        Me.cb_transmicao.Text = "TransmiÁ„o"
        Me.cb_transmicao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(Me.cb_eletric)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.PictureBox6)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.cb_carroceria)
        Me.GroupBox1.Controls.Add(Me.cb_freios)
        Me.GroupBox1.Controls.Add(Me.cb_direcao)
        Me.GroupBox1.Controls.Add(Me.cb_motor)
        Me.GroupBox1.Controls.Add(Me.cb_suspensao)
        Me.GroupBox1.Controls.Add(Me.cb_transmicao)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox1.Location = New System.Drawing.Point(24, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 199)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Servicos"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 40)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Mecanica"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Aqua
        Me.LinkLabel1.Location = New System.Drawing.Point(72, 87)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(80, 17)
        Me.LinkLabel1.TabIndex = 70
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Novo Cliente?"
        '
        'Cb_Cli
        '
        Me.Cb_Cli.Location = New System.Drawing.Point(72, 61)
        Me.Cb_Cli.Name = "Cb_Cli"
        Me.Cb_Cli.Size = New System.Drawing.Size(121, 21)
        Me.Cb_Cli.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Beige
        Me.Label5.Location = New System.Drawing.Point(112, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Total em Produtos"
        '
        'txt_prodtotal
        '
        Me.txt_prodtotal.Location = New System.Drawing.Point(248, 373)
        Me.txt_prodtotal.Name = "txt_prodtotal"
        Me.txt_prodtotal.Size = New System.Drawing.Size(112, 20)
        Me.txt_prodtotal.TabIndex = 73
        Me.txt_prodtotal.Text = ""
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Beige
        Me.Label7.Location = New System.Drawing.Point(112, 399)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 16)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Mao de Obra"
        '
        'txt_maoobra
        '
        Me.txt_maoobra.Location = New System.Drawing.Point(248, 399)
        Me.txt_maoobra.Name = "txt_maoobra"
        Me.txt_maoobra.Size = New System.Drawing.Size(112, 20)
        Me.txt_maoobra.TabIndex = 75
        Me.txt_maoobra.Text = ""
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
        Me.Button7.Location = New System.Drawing.Point(192, 468)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 61)
        Me.Button7.TabIndex = 240
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
        Me.cb_print.Location = New System.Drawing.Point(120, 468)
        Me.cb_print.Name = "cb_print"
        Me.cb_print.Size = New System.Drawing.Size(56, 61)
        Me.cb_print.TabIndex = 238
        Me.cb_print.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'arquivo_mecanica
        '
        Me.arquivo_mecanica.BackColor = System.Drawing.Color.White
        Me.arquivo_mecanica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.arquivo_mecanica.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.arquivo_mecanica.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arquivo_mecanica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.arquivo_mecanica.Image = CType(resources.GetObject("arquivo_mecanica.Image"), System.Drawing.Image)
        Me.arquivo_mecanica.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.arquivo_mecanica.Location = New System.Drawing.Point(48, 468)
        Me.arquivo_mecanica.Name = "arquivo_mecanica"
        Me.arquivo_mecanica.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.arquivo_mecanica.Size = New System.Drawing.Size(56, 61)
        Me.arquivo_mecanica.TabIndex = 235
        Me.arquivo_mecanica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(40, 459)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(296, 87)
        Me.Label20.TabIndex = 242
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(40, 529)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 243
        Me.Label8.Text = "Arquivar"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(120, 529)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 17)
        Me.Label9.TabIndex = 244
        Me.Label9.Text = "Imprimir"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(200, 529)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 245
        Me.Label10.Text = "Voltar"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Beige
        Me.Label11.Location = New System.Drawing.Point(176, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 34)
        Me.Label11.TabIndex = 246
        Me.Label11.Text = "Prazo para entrega"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(256, 9)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 20)
        Me.DateTimePicker1.TabIndex = 247
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
        Me.cb_search.Location = New System.Drawing.Point(264, 468)
        Me.cb_search.Name = "cb_search"
        Me.cb_search.Size = New System.Drawing.Size(56, 61)
        Me.cb_search.TabIndex = 248
        Me.cb_search.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(264, 529)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 17)
        Me.Label12.TabIndex = 249
        Me.Label12.Text = "ServiÁos"
        '
        'codcli
        '
        Me.codcli.Location = New System.Drawing.Point(280, 43)
        Me.codcli.Name = "codcli"
        Me.codcli.ReadOnly = True
        Me.codcli.Size = New System.Drawing.Size(88, 20)
        Me.codcli.TabIndex = 250
        Me.codcli.Text = "Cod do Cliente"
        '
        'status
        '
        Me.status.Cursor = System.Windows.Forms.Cursors.Cross
        Me.status.Font = New System.Drawing.Font("Vrinda", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.Location = New System.Drawing.Point(0, 550)
        Me.status.Name = "status"
        Me.status.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.status.ShowPanels = True
        Me.status.Size = New System.Drawing.Size(370, 22)
        Me.status.TabIndex = 258
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Icon = CType(resources.GetObject("StatusBarPanel1.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel1.ToolTipText = "Atualizacao de saldo do fornecedor"
        Me.StatusBarPanel1.Width = 354
        '
        'MECANICA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(370, 572)
        Me.ControlBox = False
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.codcli)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cb_search)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.cb_print)
        Me.Controls.Add(Me.arquivo_mecanica)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt_maoobra)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_prodtotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cb_Cli)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_modelo)
        Me.Controls.Add(Me.txt_placa)
        Me.Controls.Add(Me.txt_orcamento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MECANICA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mecanica"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Pics com Checks"
    Private Sub PictureBox1_mouse(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        cb_carroceria.Focus()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If cb_carroceria.CheckState = CheckState.Checked Then
            cb_carroceria.CheckState = CheckState.Unchecked
        Else
            cb_carroceria.CheckState = CheckState.Checked
        End If
    End Sub
    Private Sub PictureBox2_mouse(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        cb_direcao.Focus()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If cb_direcao.CheckState = CheckState.Checked Then
            cb_direcao.CheckState = CheckState.Unchecked
        Else
            cb_direcao.CheckState = CheckState.Checked
        End If
    End Sub
    Private Sub PictureBox3_mouse(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter

        cb_freios.Focus()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If cb_freios.CheckState = CheckState.Checked Then
            cb_freios.CheckState = CheckState.Unchecked
        Else
            cb_freios.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub PictureBox4_mouse(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        cb_motor.Focus()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If cb_motor.CheckState = CheckState.Checked Then
            cb_motor.CheckState = CheckState.Unchecked
        Else
            cb_motor.CheckState = CheckState.Checked
        End If
    End Sub
    Private Sub PictureBox5_mouse(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        cb_eletric.Focus()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If cb_eletric.CheckState = CheckState.Checked Then
            cb_eletric.CheckState = CheckState.Unchecked
        Else
            cb_eletric.CheckState = CheckState.Checked
        End If
    End Sub
    Private Sub PictureBox6_mouse(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseEnter
        cb_suspensao.Focus()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If cb_suspensao.CheckState = CheckState.Checked Then
            cb_suspensao.CheckState = CheckState.Unchecked
        Else
            cb_suspensao.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub PictureBox7_mouse(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseEnter
        cb_transmicao.Focus()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        If cb_transmicao.CheckState = CheckState.Checked Then
            cb_transmicao.CheckState = CheckState.Unchecked
        Else
            cb_transmicao.CheckState = CheckState.Checked
        End If
    End Sub

#End Region

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        cadastrocli_alu.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        prod_mec.ShowDialog()
    End Sub

    Private Sub txt_maoobra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_maoobra.TextChanged
        If txt_prodtotal.Text = "" Or txt_maoobra.Text = "" Then
            Exit Sub
        Else
            Dim prod As Single
            Dim obra As Single
            prod = txt_prodtotal.Text
            obra = txt_maoobra.Text
            txt_orcamento.Text = (prod + obra)
        End If
    End Sub

    Private Sub txt_prodtotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_prodtotal.TextChanged
        If txt_maoobra.Text = "" Or txt_prodtotal.Text = "" Then
            Exit Sub
        Else
            Dim prod As Single
            Dim obra As Single
            prod = txt_prodtotal.Text
            obra = txt_maoobra.Text
            txt_orcamento.Text = (prod + obra)
        End If
    End Sub

    Private Sub MECANICA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader

        Comando = New OleDbCommand("select nome_cli from clientes order by nome_cli", Conexao)
        AbrirBD()
        DR = Comando.ExecuteReader
        While DR.Read
            Cb_Cli.Items.Add(DR("nome_cli"))
        End While
        FecharBD()
    End Sub

    Private Sub arquivo_mecanica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arquivo_mecanica.Click

        'Atualizacao de quantidade no estoque dos produtos
        Dim comando_buy As OleDbCommand
        Dim dr_buy As OleDbDataReader
        Dim quantidade_anterior As Single
        Dim nova_quantidade As Single
        Dim cont As Integer

        For cont = 0 To prod_mec.List_Produtos.Items.Count - 1
            AbrirBD()
            comando_buy = New OleDbCommand("select estoque_prod from produtos where cod_prod=" & prod_mec.List_Produtos.Items(cont).SubItems(4).Text, Conexao)
            dr_buy = comando_buy.ExecuteReader
            If dr_buy.Read Then
                quantidade_anterior = Val(dr_buy("estoque_prod"))
            End If
            dr_buy.Close()
            nova_quantidade = Val(quantidade_anterior - prod_mec.List_Produtos.Items(cont).Text)
            If (nova_quantidade < 0) Then
                MsgBox("Quantidade de produtos insuficiente no estoque", MsgBoxStyle.Critical, "Por favor, verifique quantidade no estoque")
                Exit Sub
            End If
            If (nova_quantidade = 0) Then
                MsgBox("Quantidade em estoque do produto chegou a zero" & (Chr(10)) & " se necessitar de mais contate o fornecedor", MsgBoxStyle.Information, "Quantidade zerada")
            End If
            comando_buy = New OleDbCommand("Update produtos set estoque_prod=" & Val(nova_quantidade) & " where cod_prod=" & prod_mec.List_Produtos.Items(cont).SubItems(4).Text, Conexao)
            comando_buy.ExecuteNonQuery()
            FecharBD()
        Next
        FecharBD()

        'Arquivar servico da mecanica
        Dim comando As OleDbCommand

        AbrirBD()
        comando = New OleDbCommand("INSERT into mecanica(nome_cli,cod_cli,modelo_vei,placa_vei,prazo_entrega_mec,final_mec,total_prod_mec,mao_obra_mec,data_cadservico_mec,carroceria_mec,direcao_mec,freios_mec,motor_mec,syseletico_mec,suspencao_mec,transmicao_mec) values (@nome_cli,@cod_cli,@modelo_vei,@placa_vei,@prazo_entrega_mec,@final_mec,@total_prod_mec,@mao_obra_mec,@data_cadservico_mec,@carroceria_mec,@direcao_mec,@freios_mec,@motor_mec,@syseletico_mec,@suspencao_mec,@transmicao_mec)", Conexao)

        With comando
            .Parameters.Add(New OleDbParameter("@nome_cli", OleDbType.VarChar, 50))
            .Parameters("@nome_cli").Value = Cb_Cli.Text
            .Parameters.Add(New OleDbParameter("@cod_cli", OleDbType.VarChar, 50))
            .Parameters("@cod_cli").Value = codcli.Text
            .Parameters.Add(New OleDbParameter("@modelo_vei", OleDbType.VarChar, 50))
            .Parameters("@modelo_vei").Value = txt_modelo.Text
            .Parameters.Add(New OleDbParameter("@placa_vei", OleDbType.VarChar, 50))
            .Parameters("@placa_vei").Value = txt_placa.Text
            .Parameters.Add(New OleDbParameter("@prazo_entrega_mec", OleDbType.VarChar, 50))
            .Parameters("@prazo_entrega_mec").Value = DateTimePicker1.Value.Date

            .Parameters.Add(New OleDbParameter("@total_prod_mec", OleDbType.VarChar, 50))
            .Parameters("@total_prod_mec").Value = txt_prodtotal.Text

            .Parameters.Add(New OleDbParameter("@mao_obra_mec", OleDbType.VarChar, 50))
            .Parameters("@mao_obra_mec").Value = txt_maoobra.Text

            .Parameters.Add(New OleDbParameter("@final_mec", OleDbType.VarChar, 50))
            .Parameters("@final_mec").Value = txt_orcamento.Text

            .Parameters.Add(New OleDbParameter("@data_cadservico_mec", OleDbType.DBDate, 50))
            .Parameters("@data_cadservico_mec").Value = Now.Today
            .Parameters.Add(New OleDbParameter("@carroceria_mec", OleDbType.Boolean, 50))
            .Parameters("@carroceria_mec").Value = cb_carroceria.Checked
            .Parameters.Add(New OleDbParameter("@direcao_mec", OleDbType.Boolean, 50))
            .Parameters("@direcao_mec").Value = cb_direcao.Checked
            .Parameters.Add(New OleDbParameter("@freios_mec", OleDbType.Boolean, 50))
            .Parameters("@freios_mec").Value = cb_freios.Checked
            .Parameters.Add(New OleDbParameter("@motor_mec", OleDbType.Boolean, 50))
            .Parameters("@motor_mec").Value = cb_motor.Checked
            .Parameters.Add(New OleDbParameter("@syseletico_mec", OleDbType.Boolean, 50))
            .Parameters("@syseletico_mec").Value = cb_eletric.Checked
            .Parameters.Add(New OleDbParameter("@suspencao_mec", OleDbType.Boolean, 50))
            .Parameters("@suspencao_mec").Value = cb_suspensao.Checked
            .Parameters.Add(New OleDbParameter("@transmicao_mec", OleDbType.Boolean, 50))
            .Parameters("@transmicao_mec").Value = cb_transmicao.Checked
        End With
        'Tratamento de erro
        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Venda Cadastrada", "Efetuar Venda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Erro")
        Finally
            FecharBD()
        End Try

        'Atualizacao de saldo do cliente
        Dim cmd_cli As OleDbCommand
        Dim dr As OleDbDataReader
        Dim comando2 As OleDbCommand
        Dim temp As Single

        AbrirBD()
        cmd_cli = New OleDbCommand("select saldo_cli from clientes where cod_cli=@codcli", Conexao)
        cmd_cli.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
        cmd_cli.Parameters("@codcli").Value = codcli.Text
        dr = cmd_cli.ExecuteReader
        If dr.Read Then
            temp = Val(dr("saldo_cli") - (txt_orcamento.Text))
        End If
        dr.Close()
        status.Panels.Item(0).Text = "Saldo atual de " & Cb_Cli.Text & " R$ " & temp


        If (temp > 0) Then
            comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
            comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
            comando2.Parameters("@saldo").Value = temp
            comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
            comando2.Parameters("@situacao").Value = "A receber"
            comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
            comando2.Parameters("@codcli").Value = codcli.Text
        Else
            If (temp = 0) Then
                comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                comando2.Parameters("@saldo").Value = temp
                comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                comando2.Parameters("@situacao").Value = "Normal"
                comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                comando2.Parameters("@codcli").Value = codcli.Text
            Else
                comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                comando2.Parameters("@saldo").Value = temp
                comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                comando2.Parameters("@situacao").Value = "A pagar"
                comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                comando2.Parameters("@codcli").Value = codcli.Text
            End If
            comando2.ExecuteNonQuery()
        End If

        FecharBD()

        prod_mec.List_Produtos.Items.Clear()

        Dim Controle As New Control
        For Each Controle In Me.Controls
            If TypeOf Controle Is TextBox Or TypeOf Controle Is ComboBox Then
                Controle.Text = ""
            End If
        Next

        cb_carroceria.Checked = False
        cb_direcao.Checked = False
        cb_freios.Checked = False
        cb_motor.Checked = False
        cb_eletric.Checked = False
        cb_suspensao.Checked = False
        cb_transmicao.Checked = False
        DateTimePicker1.Value = Now.Today

        'î¸âÿÅEà§ÇµÇƒÇÈ()

    End Sub

    Private Sub Cb_Cli_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cb_Cli.Leave
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Try
            Comando = New OleDbCommand("select cod_cli from clientes where nome_cli='" & Cb_Cli.Text & "'", Conexao)
            AbrirBD()
            DR = Comando.ExecuteReader
            If DR.Read Then
                codcli.Text = DR("cod_cli")
            End If
        Catch ex As Exception
            MsgBox("erro", MsgBoxStyle.Critical, "erro")
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Visible = False
        principal.Visible = True
        principal.IconTray.Visible = False
    End Sub
End Class
