Imports ProjetoConcessionária.Module1
Imports System.Data.OleDb
Public Class frmcadastro_prod
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
    Friend WithEvents cmdcal As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbforn As System.Windows.Forms.ComboBox
    Friend WithEvents txtcod_forn As System.Windows.Forms.TextBox
    Friend WithEvents NomeProduto As System.Windows.Forms.TextBox
    Friend WithEvents ValorCompra As System.Windows.Forms.TextBox
    Friend WithEvents ValorVenda As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Cb_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents cod_prod As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents marca_produto As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmcadastro_prod))
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdcal = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button23 = New System.Windows.Forms.Button
        Me.Button24 = New System.Windows.Forms.Button
        Me.Button25 = New System.Windows.Forms.Button
        Me.Button26 = New System.Windows.Forms.Button
        Me.Button27 = New System.Windows.Forms.Button
        Me.Button32 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtcod_forn = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbforn = New System.Windows.Forms.ComboBox
        Me.NomeProduto = New System.Windows.Forms.TextBox
        Me.ValorCompra = New System.Windows.Forms.TextBox
        Me.ValorVenda = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Cb_Tipo = New System.Windows.Forms.ComboBox
        Me.cod_prod = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.marca_produto = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(336, 37)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Cadastrar Produtos"
        '
        'cmdcal
        '
        Me.cmdcal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdcal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcal.ForeColor = System.Drawing.Color.Black
        Me.cmdcal.Image = CType(resources.GetObject("cmdcal.Image"), System.Drawing.Image)
        Me.cmdcal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdcal.Location = New System.Drawing.Point(534, 10)
        Me.cmdcal.Name = "cmdcal"
        Me.cmdcal.Size = New System.Drawing.Size(80, 74)
        Me.cmdcal.TabIndex = 67
        Me.cmdcal.Text = "Calendário"
        Me.cmdcal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.ForeColor = System.Drawing.Color.DarkGray
        Me.Label11.Location = New System.Drawing.Point(526, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 89)
        Me.Label11.TabIndex = 68
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button7.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(536, 192)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 52)
        Me.Button7.TabIndex = 77
        Me.Button7.Text = "Voltar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.ForeColor = System.Drawing.Color.DarkGray
        Me.Label13.Location = New System.Drawing.Point(0, 184)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(624, 66)
        Me.Label13.TabIndex = 78
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button23.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button23.Image = CType(resources.GetObject("Button23.Image"), System.Drawing.Image)
        Me.Button23.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button23.Location = New System.Drawing.Point(272, 192)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(80, 52)
        Me.Button23.TabIndex = 74
        Me.Button23.Text = "Localizar"
        Me.Button23.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button24.Image = CType(resources.GetObject("Button24.Image"), System.Drawing.Image)
        Me.Button24.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button24.Location = New System.Drawing.Point(360, 192)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(80, 52)
        Me.Button24.TabIndex = 75
        Me.Button24.Text = "Imprimir"
        Me.Button24.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button25.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.ForeColor = System.Drawing.Color.Black
        Me.Button25.Image = CType(resources.GetObject("Button25.Image"), System.Drawing.Image)
        Me.Button25.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button25.Location = New System.Drawing.Point(8, 192)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(80, 52)
        Me.Button25.TabIndex = 71
        Me.Button25.Text = "Efetuar Cadastro"
        Me.Button25.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button26.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button26.Image = CType(resources.GetObject("Button26.Image"), System.Drawing.Image)
        Me.Button26.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button26.Location = New System.Drawing.Point(184, 192)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(80, 52)
        Me.Button26.TabIndex = 73
        Me.Button26.Text = "Alterar"
        Me.Button26.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button27.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button27.Image = CType(resources.GetObject("Button27.Image"), System.Drawing.Image)
        Me.Button27.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button27.Location = New System.Drawing.Point(96, 192)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(80, 52)
        Me.Button27.TabIndex = 72
        Me.Button27.Text = "Limpar"
        Me.Button27.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button32
        '
        Me.Button32.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button32.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button32.Image = CType(resources.GetObject("Button32.Image"), System.Drawing.Image)
        Me.Button32.Location = New System.Drawing.Point(448, 192)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(80, 52)
        Me.Button32.TabIndex = 76
        Me.Button32.Text = "Excluir"
        Me.Button32.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(8, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 15)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Modelo do Produto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Beige
        Me.Label4.Location = New System.Drawing.Point(8, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 15)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Valor de compra"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Beige
        Me.Label5.Location = New System.Drawing.Point(8, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 14)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Valor de venda"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcod_forn
        '
        Me.txtcod_forn.Enabled = False
        Me.txtcod_forn.Location = New System.Drawing.Point(464, 0)
        Me.txtcod_forn.Name = "txtcod_forn"
        Me.txtcod_forn.ReadOnly = True
        Me.txtcod_forn.Size = New System.Drawing.Size(48, 19)
        Me.txtcod_forn.TabIndex = 84
        Me.txtcod_forn.Text = ""
        Me.txtcod_forn.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Beige
        Me.Label6.Location = New System.Drawing.Point(8, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 14)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Nome do Fornecedor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbforn
        '
        Me.cmbforn.Location = New System.Drawing.Point(160, 56)
        Me.cmbforn.Name = "cmbforn"
        Me.cmbforn.Size = New System.Drawing.Size(152, 20)
        Me.cmbforn.TabIndex = 88
        '
        'NomeProduto
        '
        Me.NomeProduto.Location = New System.Drawing.Point(160, 88)
        Me.NomeProduto.Name = "NomeProduto"
        Me.NomeProduto.Size = New System.Drawing.Size(152, 19)
        Me.NomeProduto.TabIndex = 89
        Me.NomeProduto.Text = ""
        '
        'ValorCompra
        '
        Me.ValorCompra.Location = New System.Drawing.Point(160, 119)
        Me.ValorCompra.Name = "ValorCompra"
        Me.ValorCompra.Size = New System.Drawing.Size(152, 19)
        Me.ValorCompra.TabIndex = 90
        Me.ValorCompra.Text = ""
        '
        'ValorVenda
        '
        Me.ValorVenda.Location = New System.Drawing.Point(160, 151)
        Me.ValorVenda.Name = "ValorVenda"
        Me.ValorVenda.Size = New System.Drawing.Size(152, 19)
        Me.ValorVenda.TabIndex = 91
        Me.ValorVenda.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SlateGray
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Beige
        Me.Label7.Location = New System.Drawing.Point(331, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 14)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Tipo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cb_Tipo
        '
        Me.Cb_Tipo.Items.AddRange(New Object() {"Acessorios", "Pneus", "Rodas", "Som", "Vidros", "Outros"})
        Me.Cb_Tipo.Location = New System.Drawing.Point(417, 138)
        Me.Cb_Tipo.Name = "Cb_Tipo"
        Me.Cb_Tipo.Size = New System.Drawing.Size(121, 20)
        Me.Cb_Tipo.TabIndex = 94
        '
        'cod_prod
        '
        Me.cod_prod.Location = New System.Drawing.Point(376, 48)
        Me.cod_prod.Name = "cod_prod"
        Me.cod_prod.ReadOnly = True
        Me.cod_prod.Size = New System.Drawing.Size(104, 19)
        Me.cod_prod.TabIndex = 95
        Me.cod_prod.Text = "Codigo do Produto"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Beige
        Me.Label8.Location = New System.Drawing.Point(329, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 15)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Marca"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'marca_produto
        '
        Me.marca_produto.Location = New System.Drawing.Point(416, 96)
        Me.marca_produto.Name = "marca_produto"
        Me.marca_produto.Size = New System.Drawing.Size(152, 20)
        Me.marca_produto.TabIndex = 98
        '
        'frmcadastro_prod
        '
        Me.AcceptButton = Me.Button25
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.CancelButton = Me.Button7
        Me.ClientSize = New System.Drawing.Size(624, 254)
        Me.Controls.Add(Me.marca_produto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cod_prod)
        Me.Controls.Add(Me.Cb_Tipo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ValorVenda)
        Me.Controls.Add(Me.ValorCompra)
        Me.Controls.Add(Me.NomeProduto)
        Me.Controls.Add(Me.cmbforn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcod_forn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button26)
        Me.Controls.Add(Me.Button27)
        Me.Controls.Add(Me.cmdcal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button32)
        Me.Controls.Add(Me.Label13)
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.MaximizeBox = False
        Me.Name = "frmcadastro_prod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadastrar Produtos"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        If NomeProduto.Text = "" Or cmbforn.Text = "" Or ValorCompra.Text = "" Or ValorVenda.Text = "" Or txtcod_forn.Text = "" Or Cb_Tipo.Text = "" Or cod_prod.Text = "" Then
            MessageBox.Show("Todos os campos devem ser preenchidos", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim Cmd_ALTERAR As OleDbCommand

            Conexao.Open()

            Cmd_ALTERAR = New OleDbCommand("update produtos set modelo_prod=@modelo,marca_prod=@marca,cod_forn=@forn,vcompra_prod=@vcompra,vvenda_prod=@vvenda,tipo_prod=@type where cod_prod=" & cod_prod.Text.ToString & "", Conexao)


            With Cmd_ALTERAR
                .Parameters.Add(New OleDbParameter("@modelo", OleDbType.VarChar, 100))
                .Parameters("@modelo").Value = NomeProduto.Text.ToString
                .Parameters.Add(New OleDbParameter("@marca", OleDbType.VarChar, 100))
                .Parameters("@marca").Value = marca_produto.Text.ToString
                .Parameters.Add(New OleDbParameter("@forn", OleDbType.VarChar, 100))
                .Parameters("@forn").Value = txtcod_forn.Text
                .Parameters.Add(New OleDbParameter("@vcompra", OleDbType.VarChar, 100))
                .Parameters("@vcompra").Value = ValorCompra.Text
                .Parameters.Add(New OleDbParameter("@vvenda", OleDbType.VarChar, 100))
                .Parameters("@vvenda").Value = ValorVenda.Text
                .Parameters.Add(New OleDbParameter("@type", OleDbType.VarChar, 100))
                .Parameters("@type").Value = Cb_Tipo.Text.ToString

            End With

            Try
                Cmd_ALTERAR.ExecuteNonQuery()
                MessageBox.Show("Dados alterados", "Alteracao de registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try
        End If

    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        If NomeProduto.Text = "" Or cmbforn.Text = "" Or ValorCompra.Text = "" Or ValorVenda.Text = "" Or txtcod_forn.Text = "" Or Cb_Tipo.Text = "" Then
            MessageBox.Show("Todos os campos devem ser preenchidos", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim comando As OleDbCommand


            Conexao.Open()
            comando = New OleDbCommand("INSERT into produtos(modelo_prod,marca_prod,cod_forn,vcompra_prod,vvenda_prod,tipo_prod) values (@modelo,@marca,@forn,@vcompra,@vvenda,@tipo)", Conexao)

            With comando
                .Parameters.Add(New OleDbParameter("@modelo", OleDbType.VarChar, 100))
                .Parameters("@modelo").Value = NomeProduto.Text
                .Parameters.Add(New OleDbParameter("@marca", OleDbType.VarChar, 100))
                .Parameters("@marca").Value = marca_produto.Text
                .Parameters.Add(New OleDbParameter("@forn", OleDbType.VarChar, 100))
                .Parameters("@forn").Value = txtcod_forn.Text
                .Parameters.Add(New OleDbParameter("@vcompra", OleDbType.VarChar, 100))
                .Parameters("@vcompra").Value = ValorCompra.Text
                .Parameters.Add(New OleDbParameter("@vvenda", OleDbType.VarChar, 100))
                .Parameters("@vvenda").Value = ValorVenda.Text
                .Parameters.Add(New OleDbParameter("@tipo", OleDbType.VarChar, 100))
                .Parameters("@tipo").Value = Cb_Tipo.Text
            End With
            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("Registro cadastrado", "Inclusao de produtos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Erro")
            Finally
                FecharBD()
            End Try
        End If
        cod_prod.Text = ""

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
        venda_produtos.List_Produtos.Items.Clear()
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Cb_Tipo.Text = ""
        marca_produto.Text = ""
        cod_prod.Text = "Codigo do Produto"
        NomeProduto.Text = ""
        txtcod_forn.Text = ""
        ValorCompra.Text = ""
        ValorVenda.Text = ""
        cmbforn.Text = ""
    End Sub

    Private Sub cadastro_prod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cb_Tipo.Text = ""
        marca_produto.Text = ""
        cod_prod.Text = "Codigo do Produto"
        NomeProduto.Text = ""
        txtcod_forn.Text = ""
        ValorCompra.Text = ""
        ValorVenda.Text = ""
        cmbforn.Text = ""

        cmbforn.Items.Clear()

        marca_produto.Items.Clear()
        Dim Comando As OleDbCommand
        Dim Comandoa As OleDbCommand
        Dim DR As OleDbDataReader
        Dim DRa As OleDbDataReader

        Comando = New OleDbCommand("select nome_fant_forn from fornecedor order by nome_fant_forn", Conexao)
        AbrirBD()
        DR = Comando.ExecuteReader
        While DR.Read
            cmbforn.Items.Add(DR("nome_fant_forn"))
        End While
        FecharBD()
        AbrirBD()
        Comandoa = New OleDbCommand("select distinct marca_prod from produtos order by marca_prod", Conexao)
        DRa = Comandoa.ExecuteReader
        While DRa.Read
            marca_produto.Items.Add(DRa("marca_prod"))
        End While
        DRa.Close()
        DR.Close()
        FecharBD()



    End Sub

    Private Sub cmbforn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbforn.SelectedIndexChanged

        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        If Conexao.State = ConnectionState.Closed Then
            Conexao.Open()
        End If
        Comando = New OleDbCommand("select * from fornecedor where nome_fant_forn=@nome_forn", Conexao)
        With Comando
            .Parameters.Add(New OleDbParameter("@nome_forn", OleDbType.VarChar, 50))
            .Parameters("@nome_forn").Value = cmbforn.SelectedItem.ToString
        End With
        Try
            DR = Comando.ExecuteReader
            If DR.Read Then
                txtcod_forn.Text = DR("cod_forn")
                DR.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Erro")
        Finally
            DR.Close()
            FecharBD()
        End Try

    End Sub

    Private Sub ValorCompra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorCompra.TextChanged
        ValorVenda.Text = Val(ValorCompra.Text) * 1.2
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        FecharBD()
        locprod.ShowDialog()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click

    End Sub

    Private Sub Deletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        Dim Comando As OleDbCommand
        AbrirBD()

        Comando = New OleDbCommand("delete from produtos where cod_prod=@cod", Conexao)
        Comando.Parameters.Add(New OleDbParameter("@cod", OleDbType.Integer, 50))
        Comando.Parameters("@cod").Value = cod_prod.Text.ToString
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

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub
End Class
