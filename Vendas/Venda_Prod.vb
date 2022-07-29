Imports AllCars.Module1
Imports System.Data.OleDb
Public Class venda_prod
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cod_cli As System.Windows.Forms.TextBox
    Public WithEvents List_Produtos As System.Windows.Forms.ListView
    Friend WithEvents Remover As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Preco As System.Windows.Forms.ColumnHeader
    Friend WithEvents Total As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nome_cli As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents cb_print As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Quanti As System.Windows.Forms.ColumnHeader
    Friend WithEvents Produto As System.Windows.Forms.ColumnHeader
    Friend WithEvents CodPRod As System.Windows.Forms.ColumnHeader
    Friend WithEvents Marca As System.Windows.Forms.ColumnHeader
    Friend WithEvents status As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents efetuar_venda As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(venda_prod))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cod_cli = New System.Windows.Forms.TextBox
        Me.List_Produtos = New System.Windows.Forms.ListView
        Me.Quanti = New System.Windows.Forms.ColumnHeader
        Me.Produto = New System.Windows.Forms.ColumnHeader
        Me.Marca = New System.Windows.Forms.ColumnHeader
        Me.Preco = New System.Windows.Forms.ColumnHeader
        Me.CodPRod = New System.Windows.Forms.ColumnHeader
        Me.Remover = New System.Windows.Forms.Button
        Me.Total = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.nome_cli = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.cb_print = New System.Windows.Forms.Button
        Me.efetuar_venda = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.status = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(32, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Cliente:"
        '
        'cod_cli
        '
        Me.cod_cli.Location = New System.Drawing.Point(216, 9)
        Me.cod_cli.Name = "cod_cli"
        Me.cod_cli.ReadOnly = True
        Me.cod_cli.Size = New System.Drawing.Size(96, 20)
        Me.cod_cli.TabIndex = 53
        Me.cod_cli.Text = "CÛdigo do Cliente"
        '
        'List_Produtos
        '
        Me.List_Produtos.AllowDrop = True
        Me.List_Produtos.AutoArrange = False
        Me.List_Produtos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.List_Produtos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Quanti, Me.Produto, Me.Marca, Me.Preco, Me.CodPRod})
        Me.List_Produtos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.List_Produtos.FullRowSelect = True
        Me.List_Produtos.GridLines = True
        Me.List_Produtos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.List_Produtos.HoverSelection = True
        Me.List_Produtos.ImeMode = System.Windows.Forms.ImeMode.On
        Me.List_Produtos.LabelEdit = True
        Me.List_Produtos.LabelWrap = False
        Me.List_Produtos.Location = New System.Drawing.Point(24, 95)
        Me.List_Produtos.MultiSelect = False
        Me.List_Produtos.Name = "List_Produtos"
        Me.List_Produtos.Size = New System.Drawing.Size(272, 130)
        Me.List_Produtos.TabIndex = 52
        Me.List_Produtos.View = System.Windows.Forms.View.Details
        '
        'Quanti
        '
        Me.Quanti.Text = CType(configurationAppSettings.GetValue("ColumnHeader3.Text", GetType(System.String)), String)
        Me.Quanti.Width = 70
        '
        'Produto
        '
        Me.Produto.Text = "Produto"
        Me.Produto.Width = 69
        '
        'Marca
        '
        Me.Marca.Text = "Marca"
        '
        'Preco
        '
        Me.Preco.Text = "PreÁo Unit."
        Me.Preco.Width = 71
        '
        'CodPRod
        '
        Me.CodPRod.Text = "Codigo do Produto"
        Me.CodPRod.Width = 0
        '
        'Remover
        '
        Me.Remover.BackColor = System.Drawing.Color.AliceBlue
        Me.Remover.Location = New System.Drawing.Point(8, 269)
        Me.Remover.Name = "Remover"
        Me.Remover.Size = New System.Drawing.Size(64, 26)
        Me.Remover.TabIndex = 54
        Me.Remover.Text = "Remover"
        '
        'Total
        '
        Me.Total.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Total.Location = New System.Drawing.Point(176, 269)
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.TabIndex = 56
        Me.Total.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Beige
        Me.Label3.Location = New System.Drawing.Point(176, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Total"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Aqua
        Me.LinkLabel1.Location = New System.Drawing.Point(32, 69)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(96, 18)
        Me.LinkLabel1.TabIndex = 58
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Localizar Cliente"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Lime
        Me.LinkLabel2.Location = New System.Drawing.Point(48, 243)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(100, 17)
        Me.LinkLabel2.TabIndex = 59
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Adicionar Produto"
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.Lime
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(8, 225)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 60
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 43)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Vendas"
        '
        'nome_cli
        '
        Me.nome_cli.Location = New System.Drawing.Point(128, 52)
        Me.nome_cli.Name = "nome_cli"
        Me.nome_cli.Size = New System.Drawing.Size(168, 21)
        Me.nome_cli.TabIndex = 71
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(256, 381)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 18)
        Me.Label10.TabIndex = 256
        Me.Label10.Text = "Voltar"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(128, 381)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 18)
        Me.Label9.TabIndex = 255
        Me.Label9.Text = "Imprimir"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 381)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 18)
        Me.Label8.TabIndex = 254
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
        Me.Button7.Location = New System.Drawing.Point(248, 321)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 60)
        Me.Button7.TabIndex = 252
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
        Me.cb_print.Location = New System.Drawing.Point(128, 321)
        Me.cb_print.Name = "cb_print"
        Me.cb_print.Size = New System.Drawing.Size(56, 60)
        Me.cb_print.TabIndex = 251
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
        Me.efetuar_venda.Location = New System.Drawing.Point(16, 321)
        Me.efetuar_venda.Name = "efetuar_venda"
        Me.efetuar_venda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.efetuar_venda.Size = New System.Drawing.Size(56, 60)
        Me.efetuar_venda.TabIndex = 250
        Me.efetuar_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(8, 312)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(304, 87)
        Me.Label20.TabIndex = 253
        '
        'status
        '
        Me.status.Cursor = System.Windows.Forms.Cursors.Cross
        Me.status.Font = New System.Drawing.Font("Vrinda", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.Location = New System.Drawing.Point(0, 410)
        Me.status.Name = "status"
        Me.status.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.status.ShowPanels = True
        Me.status.Size = New System.Drawing.Size(320, 21)
        Me.status.TabIndex = 257
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Icon = CType(resources.GetObject("StatusBarPanel1.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel1.ToolTipText = "Atualizacao de saldo do fornecedor"
        Me.StatusBarPanel1.Width = 304
        '
        'venda_prod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(320, 431)
        Me.ControlBox = False
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.cb_print)
        Me.Controls.Add(Me.efetuar_venda)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.nome_cli)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.cod_cli)
        Me.Controls.Add(Me.Remover)
        Me.Controls.Add(Me.List_Produtos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "venda_prod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Venda de Produtos"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Subs basicas....."

    Private Sub Cadastrar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cadastrocli_alu.ShowDialog()
    End Sub

    Private Sub Cadastrar_Prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        buy_prod.ShowDialog()
    End Sub

    Private Sub Localizar_Prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        locprod.ShowDialog()
    End Sub

    Private Sub Localizar_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loccli.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        loccli.ShowDialog()
    End Sub

    Private Sub PictureBox3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseUp
        LinkLabel2.Focus()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        locprod.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        locprod.ShowDialog()
    End Sub

    Private Sub List_Produtos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles List_Produtos.KeyDown
        Dim cont As Integer
        Dim tot As Single
        Dim vtemp As Single

        For cont = 0 To List_Produtos.Items.Count - 1
            vtemp = Val(List_Produtos.Items.Item(cont).Text * List_Produtos.Items.Item(cont).SubItems(3).Text)
            tot = vtemp + tot
        Next
        Total.Text = tot
    End Sub

    Private Sub List_Produtos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles List_Produtos.MouseMove
        Dim cont As Integer
        Dim tot As Single
        Dim vtemp As Single

        For cont = 0 To List_Produtos.Items.Count - 1
            vtemp = Val(List_Produtos.Items.Item(cont).Text * List_Produtos.Items.Item(cont).SubItems(3).Text)
            tot = vtemp + tot
        Next
        Total.Text = tot
    End Sub

    Private Sub List_Produtos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles List_Produtos.SelectedIndexChanged
        Dim cont As Integer
        Dim tot As Single
        Dim vtemp As Single

        For cont = 0 To List_Produtos.Items.Count - 1
            vtemp = Val(List_Produtos.Items.Item(cont).Text * List_Produtos.Items.Item(cont).SubItems(3).Text)
            tot = vtemp + tot
        Next
        Total.Text = tot
    End Sub

    Private Sub Remover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remover.Click
        List_Produtos.FocusedItem.Remove()
        Dim cont As Integer
        Dim tot As Single
        Dim vtemp As Single

        For cont = 0 To List_Produtos.Items.Count - 1
            vtemp = Val(List_Produtos.Items.Item(cont).Text * List_Produtos.Items.Item(cont).SubItems(3).Text)
            tot = vtemp + tot
        Next
        Total.Text = tot
    End Sub


    Private Sub nome_cli_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nome_cli.GotFocus
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader

        Comando = New OleDbCommand("select cod_cli from clientes where nome_cli='" & nome_cli.Text.ToString & "'", Conexao)
        AbrirBD()
        DR = Comando.ExecuteReader
        If DR.Read Then
            cod_cli.Text = DR("cod_cli")
        End If
        FecharBD()
    End Sub




#End Region

    Private Sub efetuar_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles efetuar_venda.Click

        If MessageBox.Show("Confirme a venda", "Confirmacao de valores", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then

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


            'Variaveis utilizadas na atualizacao de quantidade de estoque dos produtos
            Dim comando_buy As OleDbCommand
            Dim dr_buy As OleDbDataReader
            Dim quantidade_anterior As Single
            Dim nova_quantidade As Single

            'Atualizacao de quantidade no estoque dos produtos
            For cont = 0 To List_Produtos.Items.Count - 1
                AbrirBD()
                comando_buy = New OleDbCommand("select estoque_prod from produtos where cod_prod=" & List_Produtos.Items(cont).SubItems(4).Text, Conexao)
                dr_buy = comando_buy.ExecuteReader
                If dr_buy.Read Then
                    quantidade_anterior = Val(dr_buy("estoque_prod"))
                End If
                dr_buy.Close()
                nova_quantidade = Val(quantidade_anterior - List_Produtos.Items(cont).Text)
                If (nova_quantidade < 0) Then
                    MsgBox("Quantidade de produtos insuficiente no estoque", MsgBoxStyle.Critical, "Por favor, verifique quantidade no estoque")
                    Exit Sub
                End If
                If (nova_quantidade = 0) Then
                    MsgBox("Quantidade em estoque do produto chegou a zero" & (Chr(10)) & " se necessitar mais contate o fornecedor", MsgBoxStyle.Information, "Quantidade zerada")
                End If
                comando_buy = New OleDbCommand("Update produtos set estoque_prod=" & Val(nova_quantidade) & " where cod_prod=" & List_Produtos.Items(cont).SubItems(4).Text, Conexao)
                comando_buy.ExecuteNonQuery()
                FecharBD()
            Next
            FecharBD()

            'Listando todos produtos da lista + preco total
            For cont = 0 To List_Produtos.Items.Count - 1
                vtemp = List_Produtos.Items.Item(cont).Text.ToString * List_Produtos.Items.Item(cont).SubItems(3).Text.ToString
                tot = vtemp + tot
            Next
            Total.Text = tot
            For cont = 0 To List_Produtos.Items.Count - 1
                produtos = List_Produtos.Items(cont).SubItems(1).Text & "," & produtos
            Next

            'Arquivar venda
            AbrirBD()

            comando = New OleDbCommand("INSERT into venda_prod(cod_cliente,nome_cliente,nome_produtos,total,dia_venda) values (@cod_cli,@nome_cli,@nome_prod,@total,@agora)", Conexao)

            With comando
                .Parameters.Add(New OleDbParameter("@cod_cli", OleDbType.VarChar, 50))
                .Parameters("@cod_cli").Value = cod_cli.Text
                .Parameters.Add(New OleDbParameter("@nome_cli", OleDbType.VarChar, 50))
                .Parameters("@nome_cli").Value = nome_cli.Text.ToString
                .Parameters.Add(New OleDbParameter("@nome_prod", OleDbType.VarChar, 50))
                .Parameters("@nome_prod").Value = produtos
                .Parameters.Add(New OleDbParameter("@total", OleDbType.VarChar, 50))
                .Parameters("@total").Value = Total.Text
                .Parameters.Add(New OleDbParameter("@agora", OleDbType.VarChar, 50))
                .Parameters("@agora").Value = Now.Date.Today
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
            cmd_cli.Parameters("@codcli").Value = Me.cod_cli.Text
            dr = cmd_cli.ExecuteReader
            If dr.Read Then
                temp = Val(dr("saldo_cli") - (Total.Text))
            End If
            dr.Close()
            status.Panels.Item(0).Text = "Saldo atual de " & nome_cli.Text & " R$ " & temp


            If (temp > 0) Then
                comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                comando2.Parameters("@saldo").Value = temp
                comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                comando2.Parameters("@situacao").Value = "A receber"
                comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                comando2.Parameters("@codcli").Value = Me.cod_cli.Text
            Else
                If (temp = 0) Then
                    comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                    comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                    comando2.Parameters("@saldo").Value = temp
                    comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                    comando2.Parameters("@situacao").Value = "Normal"
                    comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                    comando2.Parameters("@codcli").Value = Me.cod_cli.Text
                Else
                    comando2 = New OleDbCommand("Update clientes set saldo_cli=@saldo,situa_cli=@situacao where cod_cli=@codcli", Conexao)
                    comando2.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
                    comando2.Parameters("@saldo").Value = temp
                    comando2.Parameters.Add(New OleDbParameter("@situacao", OleDbType.VarChar, 50))
                    comando2.Parameters("@situacao").Value = "A pagar"
                    comando2.Parameters.Add(New OleDbParameter("@codcli", OleDbType.VarChar, 50))
                    comando2.Parameters("@codcli").Value = Me.cod_cli.Text
                End If
                comando2.ExecuteNonQuery()
            End If

            FecharBD()
            List_Produtos.Items.Clear()
            nome_cli.Text = ""
            cod_cli.Text = ""
            Total.Text = ""
            'ÅEÉ÷ÅE` kwwweeee
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Visible = False
        principal.Visible = True
        principal.IconTray.Visible = False
    End Sub
End Class
