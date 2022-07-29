Imports AllCars.Module1
Imports System.Data.OleDb
Public Class Venda_Vei
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents loc_cli As System.Windows.Forms.Button
    Friend WithEvents txt_codcli As System.Windows.Forms.TextBox
    Friend WithEvents cb_cli As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents cb_print As System.Windows.Forms.Button
    Friend WithEvents efetuar_venda As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_vvenda As System.Windows.Forms.TextBox
    Friend WithEvents txtplaca As System.Windows.Forms.TextBox
    Friend WithEvents cb_versao As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_modelo As System.Windows.Forms.ComboBox
    Friend WithEvents marca_vei As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcod_vei As System.Windows.Forms.TextBox
    Friend WithEvents loc_vei As System.Windows.Forms.Button
    Friend WithEvents grpimagem As System.Windows.Forms.GroupBox
    Friend WithEvents Pctemp As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Venda_Vei))
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.loc_cli = New System.Windows.Forms.Button
        Me.txt_codcli = New System.Windows.Forms.TextBox
        Me.cb_cli = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.status = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.cb_print = New System.Windows.Forms.Button
        Me.efetuar_venda = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_vvenda = New System.Windows.Forms.TextBox
        Me.txtplaca = New System.Windows.Forms.TextBox
        Me.cb_versao = New System.Windows.Forms.ComboBox
        Me.Cb_modelo = New System.Windows.Forms.ComboBox
        Me.marca_vei = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtcod_vei = New System.Windows.Forms.TextBox
        Me.loc_vei = New System.Windows.Forms.Button
        Me.grpimagem = New System.Windows.Forms.GroupBox
        Me.Pctemp = New System.Windows.Forms.PictureBox
        Me.GroupBox2.SuspendLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpimagem.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(-8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(392, 40)
        Me.Label3.TabIndex = 279
        Me.Label3.Text = "Vender veiculos novos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.loc_cli)
        Me.GroupBox2.Controls.Add(Me.txt_codcli)
        Me.GroupBox2.Controls.Add(Me.cb_cli)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox2.Location = New System.Drawing.Point(0, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 95)
        Me.GroupBox2.TabIndex = 278
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'loc_cli
        '
        Me.loc_cli.BackColor = System.Drawing.Color.White
        Me.loc_cli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loc_cli.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.loc_cli.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loc_cli.ForeColor = System.Drawing.SystemColors.ControlText
        Me.loc_cli.Image = CType(resources.GetObject("loc_cli.Image"), System.Drawing.Image)
        Me.loc_cli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.loc_cli.Location = New System.Drawing.Point(213, 52)
        Me.loc_cli.Name = "loc_cli"
        Me.loc_cli.Size = New System.Drawing.Size(131, 42)
        Me.loc_cli.TabIndex = 269
        Me.loc_cli.Text = "Localizar"
        Me.loc_cli.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_codcli
        '
        Me.txt_codcli.Location = New System.Drawing.Point(124, 55)
        Me.txt_codcli.Name = "txt_codcli"
        Me.txt_codcli.ReadOnly = True
        Me.txt_codcli.Size = New System.Drawing.Size(80, 21)
        Me.txt_codcli.TabIndex = 167
        Me.txt_codcli.Text = ""
        '
        'cb_cli
        '
        Me.cb_cli.Location = New System.Drawing.Point(125, 17)
        Me.cb_cli.Name = "cb_cli"
        Me.cb_cli.Size = New System.Drawing.Size(220, 21)
        Me.cb_cli.TabIndex = 166
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Beige
        Me.Label15.Location = New System.Drawing.Point(5, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 23)
        Me.Label15.TabIndex = 177
        Me.Label15.Text = "Código Cliente"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Beige
        Me.Label11.Location = New System.Drawing.Point(4, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 176
        Me.Label11.Text = "Nome"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'status
        '
        Me.status.Cursor = System.Windows.Forms.Cursors.Cross
        Me.status.Font = New System.Drawing.Font("Vrinda", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.Location = New System.Drawing.Point(0, 436)
        Me.status.Name = "status"
        Me.status.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.status.ShowPanels = True
        Me.status.Size = New System.Drawing.Size(744, 21)
        Me.status.TabIndex = 277
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Icon = CType(resources.GetObject("StatusBarPanel1.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel1.ToolTipText = "Atualizacao de saldo do fornecedor"
        Me.StatusBarPanel1.Width = 728
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(480, 407)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 18)
        Me.Label10.TabIndex = 276
        Me.Label10.Text = "Voltar"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(368, 407)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 18)
        Me.Label9.TabIndex = 275
        Me.Label9.Text = "Imprimir"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(240, 407)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 18)
        Me.Label8.TabIndex = 274
        Me.Label8.Text = "Finalizar Venda"
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
        Me.Button7.Location = New System.Drawing.Point(480, 347)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 60)
        Me.Button7.TabIndex = 272
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
        Me.cb_print.Location = New System.Drawing.Point(368, 347)
        Me.cb_print.Name = "cb_print"
        Me.cb_print.Size = New System.Drawing.Size(56, 60)
        Me.cb_print.TabIndex = 271
        Me.cb_print.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'efetuar_venda
        '
        Me.efetuar_venda.BackColor = System.Drawing.Color.White
        Me.efetuar_venda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.efetuar_venda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.efetuar_venda.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.efetuar_venda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.efetuar_venda.Image = CType(resources.GetObject("efetuar_venda.Image"), System.Drawing.Image)
        Me.efetuar_venda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.efetuar_venda.Location = New System.Drawing.Point(256, 347)
        Me.efetuar_venda.Name = "efetuar_venda"
        Me.efetuar_venda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.efetuar_venda.Size = New System.Drawing.Size(56, 60)
        Me.efetuar_venda.TabIndex = 270
        Me.efetuar_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(240, 338)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(304, 87)
        Me.Label20.TabIndex = 273
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_vvenda)
        Me.GroupBox1.Controls.Add(Me.txtplaca)
        Me.GroupBox1.Controls.Add(Me.cb_versao)
        Me.GroupBox1.Controls.Add(Me.Cb_modelo)
        Me.GroupBox1.Controls.Add(Me.marca_vei)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtcod_vei)
        Me.GroupBox1.Controls.Add(Me.loc_vei)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox1.Location = New System.Drawing.Point(0, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 173)
        Me.GroupBox1.TabIndex = 269
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veículo"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Beige
        Me.Label2.Location = New System.Drawing.Point(227, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 269
        Me.Label2.Text = "Preço"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Beige
        Me.Label16.Location = New System.Drawing.Point(171, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 20)
        Me.Label16.TabIndex = 180
        Me.Label16.Text = "Cód. Veiculo"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_vvenda
        '
        Me.txt_vvenda.Location = New System.Drawing.Point(232, 92)
        Me.txt_vvenda.Name = "txt_vvenda"
        Me.txt_vvenda.Size = New System.Drawing.Size(111, 21)
        Me.txt_vvenda.TabIndex = 135
        Me.txt_vvenda.Text = ""
        '
        'txtplaca
        '
        Me.txtplaca.Location = New System.Drawing.Point(63, 29)
        Me.txtplaca.MaxLength = 7
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.TabIndex = 134
        Me.txtplaca.Text = ""
        '
        'cb_versao
        '
        Me.cb_versao.Location = New System.Drawing.Point(63, 132)
        Me.cb_versao.Name = "cb_versao"
        Me.cb_versao.Size = New System.Drawing.Size(144, 21)
        Me.cb_versao.TabIndex = 133
        '
        'Cb_modelo
        '
        Me.Cb_modelo.Location = New System.Drawing.Point(63, 100)
        Me.Cb_modelo.Name = "Cb_modelo"
        Me.Cb_modelo.Size = New System.Drawing.Size(144, 21)
        Me.Cb_modelo.TabIndex = 132
        '
        'marca_vei
        '
        Me.marca_vei.Location = New System.Drawing.Point(64, 66)
        Me.marca_vei.Name = "marca_vei"
        Me.marca_vei.Size = New System.Drawing.Size(144, 21)
        Me.marca_vei.TabIndex = 131
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Beige
        Me.Label19.Location = New System.Drawing.Point(4, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 23)
        Me.Label19.TabIndex = 179
        Me.Label19.Text = "Marca"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(4, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Modelo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Beige
        Me.Label4.Location = New System.Drawing.Point(8, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "Placa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Beige
        Me.Label6.Location = New System.Drawing.Point(5, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 23)
        Me.Label6.TabIndex = 175
        Me.Label6.Text = "Versão"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcod_vei
        '
        Me.txtcod_vei.Enabled = False
        Me.txtcod_vei.Location = New System.Drawing.Point(260, 29)
        Me.txtcod_vei.Name = "txtcod_vei"
        Me.txtcod_vei.ReadOnly = True
        Me.txtcod_vei.Size = New System.Drawing.Size(83, 21)
        Me.txtcod_vei.TabIndex = 130
        Me.txtcod_vei.Text = ""
        '
        'loc_vei
        '
        Me.loc_vei.BackColor = System.Drawing.Color.White
        Me.loc_vei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loc_vei.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.loc_vei.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loc_vei.ForeColor = System.Drawing.SystemColors.ControlText
        Me.loc_vei.Image = CType(resources.GetObject("loc_vei.Image"), System.Drawing.Image)
        Me.loc_vei.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.loc_vei.Location = New System.Drawing.Point(213, 130)
        Me.loc_vei.Name = "loc_vei"
        Me.loc_vei.Size = New System.Drawing.Size(131, 42)
        Me.loc_vei.TabIndex = 268
        Me.loc_vei.Text = "Localizar"
        Me.loc_vei.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'grpimagem
        '
        Me.grpimagem.Controls.Add(Me.Pctemp)
        Me.grpimagem.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grpimagem.ForeColor = System.Drawing.Color.Beige
        Me.grpimagem.Location = New System.Drawing.Point(360, 52)
        Me.grpimagem.Name = "grpimagem"
        Me.grpimagem.Size = New System.Drawing.Size(376, 278)
        Me.grpimagem.TabIndex = 268
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
        'Venda_Vei
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(744, 457)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.cb_print)
        Me.Controls.Add(Me.efetuar_venda)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpimagem)
        Me.MaximizeBox = False
        Me.Name = "Venda_Vei"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venda de Veiculos Novos"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.grpimagem.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub BTCadastra_vei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        buy_newvei.ShowDialog()

    End Sub

    Private Sub BTCadastra_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cadastrocli_alu.ShowDialog()
    End Sub

    Private Sub BTLocaliza_Cli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loccli.ShowDialog()
    End Sub

    Private Sub BTLocaliza_vei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        locvei_venda.ShowDialog()
    End Sub

    Private Sub Bt_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Bt_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub efetuar_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles efetuar_venda.Click
        'Declaracao de variaveis
        Dim cont As Integer
        Dim tot As Single
        Dim produtos As String
        Dim cmd_cli As OleDbCommand
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader

        'Variaveis utilizadas na atualizacao de saldo do cliente
        Dim comando2 As OleDbCommand
        Dim temp As Single
        Dim vtemp As Single


        'Arquivar venda
        AbrirBD()
        comando = New OleDbCommand("INSERT into venda_vei_novo(cod_cliente,nome_cliente,placa_veiculo,modelo_veiculo,dia_venda,preco_venda) values (@cod_cliente,@nome_cliente,@placa_veiculo,@modelo_veiculo,@dia_venda,@preco_venda)", Conexao)
        With comando
            .Parameters.Add(New OleDbParameter("@cod_cliente", OleDbType.Numeric, 50))
            .Parameters("@cod_cliente").Value = txt_codcli.Text
            .Parameters.Add(New OleDbParameter("@nome_cliente", OleDbType.VarChar, 50))
            .Parameters("@nome_cliente").Value = cb_cli.Text.ToString
            .Parameters.Add(New OleDbParameter("@modelo_veiculo", OleDbType.VarChar, 50))
            .Parameters("@modelo_veiculo").Value = Cb_modelo.Text
            .Parameters.Add(New OleDbParameter("@placa_veiculo", OleDbType.VarChar, 50))
            .Parameters("@placa_veiculo").Value = txtplaca.Text
            .Parameters.Add(New OleDbParameter("@dia_venda", OleDbType.DBDate, 50))
            .Parameters("@dia_venda").Value = Now.Date.Today
            .Parameters.Add(New OleDbParameter("@preco_venda", OleDbType.VarChar, 50))
            .Parameters("@preco_venda").Value = txt_vvenda.Text
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
        AbrirBD()
        cmd_cli = New OleDbCommand("select saldo_cli from clientes where cod_cli=@codcli", Conexao)
        cmd_cli.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
        cmd_cli.Parameters("@codcli").Value = txt_codcli.Text
        dr = cmd_cli.ExecuteReader
        If dr.Read Then
            temp = Val(dr("saldo_cli") - (txt_vvenda.Text))
        End If
        dr.Close()
        status.Panels.Item(0).Text = "Saldo atual de " & cb_cli.Text & " R$ " & temp


        If (temp > 0) Then
            comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
            comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
            comando2.Parameters("@saldo").Value = temp
            comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
            comando2.Parameters("@situacao").Value = "A receber"
            comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
            comando2.Parameters("@codcli").Value = Me.txt_codcli.Text
        Else
            If (temp = 0) Then
                comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                comando2.Parameters("@saldo").Value = temp
                comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                comando2.Parameters("@situacao").Value = "Normal"
                comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                comando2.Parameters("@codcli").Value = Me.txt_codcli.Text
            Else
                comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                comando2.Parameters("@saldo").Value = temp
                comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                comando2.Parameters("@situacao").Value = "A pagar"
                comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                comando2.Parameters("@codcli").Value = Me.txt_codcli.Text
            End If
            comando2.ExecuteNonQuery()
        End If
        FecharBD()
        'Excluir veiculo venda

        Dim Cmd_del As OleDbCommand
        AbrirBD()
        Cmd_del = New OleDbCommand("delete from veiculos_venda where placa_vei=@placa_vei", Conexao)
        Cmd_del.Parameters.Add(New OleDbParameter("@placa_vei", OleDbType.VarChar, 50))
        Cmd_del.Parameters("@placa_vei").Value = txtplaca.Text.ToString

        Try
            Cmd_del.ExecuteNonQuery()
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

        FecharBD()

    End Sub

    Private Sub loc_vei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loc_vei.Click
        locvei_venda.ShowDialog()
    End Sub

    Private Sub loc_cli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loc_cli.Click
        loccli.ShowDialog()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Visible = False
        principal.Visible = True
        principal.IconTray.Visible = False
    End Sub
End Class
