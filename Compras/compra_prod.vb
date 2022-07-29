Imports AllCars.Module1
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbforn As System.Windows.Forms.ComboBox
    Friend WithEvents txtcod_forn As System.Windows.Forms.TextBox
    Friend WithEvents ValorCompra As System.Windows.Forms.TextBox
    Friend WithEvents ValorVenda As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Cb_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents cod_prod As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents marca_produto As System.Windows.Forms.ComboBox
    Friend WithEvents cb_search As System.Windows.Forms.Button
    Friend WithEvents Limpar As System.Windows.Forms.Button
    Friend WithEvents cb_print As System.Windows.Forms.Button
    Friend WithEvents cadastro_venda As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents NomeProduto As System.Windows.Forms.ComboBox
    Friend WithEvents status As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents txt_quantidade As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmcadastro_prod))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtcod_forn = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbforn = New System.Windows.Forms.ComboBox
        Me.ValorCompra = New System.Windows.Forms.TextBox
        Me.ValorVenda = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Cb_Tipo = New System.Windows.Forms.ComboBox
        Me.cod_prod = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.marca_produto = New System.Windows.Forms.ComboBox
        Me.cb_search = New System.Windows.Forms.Button
        Me.Limpar = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.cb_print = New System.Windows.Forms.Button
        Me.cadastro_venda = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_total = New System.Windows.Forms.TextBox
        Me.NomeProduto = New System.Windows.Forms.ComboBox
        Me.status = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.txt_quantidade = New System.Windows.Forms.NumericUpDown
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_quantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(376, 40)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Compra de Produtos"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(8, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Modelo do Produto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Beige
        Me.Label4.Location = New System.Drawing.Point(8, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 17)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Valor Uni. Compra"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Beige
        Me.Label5.Location = New System.Drawing.Point(328, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 43)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Valor Unit. de venda"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcod_forn
        '
        Me.txtcod_forn.Enabled = False
        Me.txtcod_forn.Location = New System.Drawing.Point(384, 0)
        Me.txtcod_forn.Name = "txtcod_forn"
        Me.txtcod_forn.ReadOnly = True
        Me.txtcod_forn.Size = New System.Drawing.Size(48, 20)
        Me.txtcod_forn.TabIndex = 84
        Me.txtcod_forn.Text = ""
        Me.txtcod_forn.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Beige
        Me.Label6.Location = New System.Drawing.Point(8, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 15)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Nome do Fornecedor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbforn
        '
        Me.cmbforn.Location = New System.Drawing.Point(160, 52)
        Me.cmbforn.Name = "cmbforn"
        Me.cmbforn.Size = New System.Drawing.Size(152, 21)
        Me.cmbforn.TabIndex = 88
        '
        'ValorCompra
        '
        Me.ValorCompra.Location = New System.Drawing.Point(160, 121)
        Me.ValorCompra.Name = "ValorCompra"
        Me.ValorCompra.Size = New System.Drawing.Size(152, 20)
        Me.ValorCompra.TabIndex = 90
        Me.ValorCompra.Text = ""
        '
        'ValorVenda
        '
        Me.ValorVenda.Location = New System.Drawing.Point(424, 147)
        Me.ValorVenda.Name = "ValorVenda"
        Me.ValorVenda.Size = New System.Drawing.Size(152, 20)
        Me.ValorVenda.TabIndex = 91
        Me.ValorVenda.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SlateGray
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Beige
        Me.Label7.Location = New System.Drawing.Point(331, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 15)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Tipo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cb_Tipo
        '
        Me.Cb_Tipo.Items.AddRange(New Object() {"Acessorios", "Pneus", "Rodas", "Som", "Vidros", "Outros"})
        Me.Cb_Tipo.Location = New System.Drawing.Point(424, 87)
        Me.Cb_Tipo.Name = "Cb_Tipo"
        Me.Cb_Tipo.Size = New System.Drawing.Size(121, 21)
        Me.Cb_Tipo.TabIndex = 94
        '
        'cod_prod
        '
        Me.cod_prod.Location = New System.Drawing.Point(496, 9)
        Me.cod_prod.Name = "cod_prod"
        Me.cod_prod.ReadOnly = True
        Me.cod_prod.Size = New System.Drawing.Size(104, 20)
        Me.cod_prod.TabIndex = 95
        Me.cod_prod.Text = "Codigo do Produto"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Beige
        Me.Label8.Location = New System.Drawing.Point(329, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Marca"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'marca_produto
        '
        Me.marca_produto.Location = New System.Drawing.Point(424, 52)
        Me.marca_produto.Name = "marca_produto"
        Me.marca_produto.Size = New System.Drawing.Size(152, 21)
        Me.marca_produto.TabIndex = 98
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
        Me.cb_search.Location = New System.Drawing.Point(320, 243)
        Me.cb_search.Name = "cb_search"
        Me.cb_search.Size = New System.Drawing.Size(120, 78)
        Me.cb_search.TabIndex = 233
        Me.cb_search.Text = "Localizar Produtos"
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
        Me.Limpar.Location = New System.Drawing.Point(160, 243)
        Me.Limpar.Name = "Limpar"
        Me.Limpar.Size = New System.Drawing.Size(65, 81)
        Me.Limpar.TabIndex = 228
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
        Me.Button7.Location = New System.Drawing.Point(456, 243)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(65, 81)
        Me.Button7.TabIndex = 232
        Me.Button7.Text = "Voltar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cb_print
        '
        Me.cb_print.BackColor = System.Drawing.Color.White
        Me.cb_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_print.Font = New System.Drawing.Font("Arial", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.cb_print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cb_print.Image = CType(resources.GetObject("cb_print.Image"), System.Drawing.Image)
        Me.cb_print.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cb_print.Location = New System.Drawing.Point(240, 243)
        Me.cb_print.Name = "cb_print"
        Me.cb_print.Size = New System.Drawing.Size(65, 81)
        Me.cb_print.TabIndex = 230
        Me.cb_print.Text = "Imprimir"
        Me.cb_print.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.cadastro_venda.Location = New System.Drawing.Point(80, 243)
        Me.cadastro_venda.Name = "cadastro_venda"
        Me.cadastro_venda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cadastro_venda.Size = New System.Drawing.Size(65, 81)
        Me.cadastro_venda.TabIndex = 227
        Me.cadastro_venda.Text = "Salvar"
        Me.cadastro_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(72, 234)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(456, 95)
        Me.Label20.TabIndex = 234
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SlateGray
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Beige
        Me.Label2.Location = New System.Drawing.Point(40, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 235
        Me.Label2.Text = "Quantidade"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SlateGray
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Beige
        Me.Label9.Location = New System.Drawing.Point(56, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 26)
        Me.Label9.TabIndex = 237
        Me.Label9.Text = "Total da Compra"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(160, 191)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(152, 20)
        Me.txt_total.TabIndex = 238
        Me.txt_total.Text = ""
        '
        'NomeProduto
        '
        Me.NomeProduto.Location = New System.Drawing.Point(160, 87)
        Me.NomeProduto.Name = "NomeProduto"
        Me.NomeProduto.Size = New System.Drawing.Size(152, 21)
        Me.NomeProduto.TabIndex = 239
        '
        'status
        '
        Me.status.Cursor = System.Windows.Forms.Cursors.Cross
        Me.status.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.status.Location = New System.Drawing.Point(0, 338)
        Me.status.Name = "status"
        Me.status.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.status.ShowPanels = True
        Me.status.Size = New System.Drawing.Size(600, 22)
        Me.status.TabIndex = 240
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
        'txt_quantidade
        '
        Me.txt_quantidade.Location = New System.Drawing.Point(160, 152)
        Me.txt_quantidade.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_quantidade.Name = "txt_quantidade"
        Me.txt_quantidade.Size = New System.Drawing.Size(152, 20)
        Me.txt_quantidade.TabIndex = 241
        Me.txt_quantidade.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frmcadastro_prod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(600, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_quantidade)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.NomeProduto)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_search)
        Me.Controls.Add(Me.Limpar)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.cb_print)
        Me.Controls.Add(Me.cadastro_venda)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.marca_produto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cod_prod)
        Me.Controls.Add(Me.Cb_Tipo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ValorVenda)
        Me.Controls.Add(Me.ValorCompra)
        Me.Controls.Add(Me.cmbforn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcod_forn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmcadastro_prod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadastrar Produtos"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_quantidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Subs Basicas"
    Private Sub cb_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_search.Click
        FecharBD()
        locprod.ShowDialog()
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Visible = False
        principal.Visible = True
        principal.IconTray.Visible = False
        venda_produtos.List_Produtos.Items.Clear()
    End Sub

    Private Sub ValorCompra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorCompra.TextChanged
        If ValorCompra.Text = "" Then
            Exit Sub
        Else
            ValorVenda.Text = Val(ValorCompra.Text) * 1.2
        End If

        If ValorCompra.Text = "" Or txt_quantidade.Value = "" Then
            Exit Sub
        Else
            txt_total.Text = Val(txt_quantidade.Value * ValorCompra.Text)
        End If
    End Sub

    Private Sub marca_produto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles marca_produto.GotFocus
        NomeProduto.Items.Clear()
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        AbrirBD()
        comando = New OleDbCommand("select distinct modelo_prod from produtos where marca_prod='" & marca_produto.Text & "' order by modelo_prod", Conexao)
        dr = comando.ExecuteReader
        While dr.Read
            NomeProduto.Items.Add(dr("modelo_prod"))
        End While
        dr.Close()
        FecharBD()
    End Sub

    Private Sub cmbforn_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbforn.GotFocus
        If cmbforn.Text = "" Then
            Exit Sub
        Else
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
        End If

    End Sub

    Private Sub Limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpar.Click
        Cb_Tipo.Text = ""
        marca_produto.Text = ""
        cod_prod.Text = "Codigo do Produto"
        NomeProduto.Text = ""
        txtcod_forn.Text = ""
        ValorCompra.Text = ""
        ValorVenda.Text = ""
        cmbforn.Text = ""
    End Sub

    Private Sub cb_apaga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub txt_quantidade_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If ValorCompra.Text = "" Or txt_quantidade.Text = "" Then
            Exit Sub
        Else
            txt_total.Text = Val(txt_quantidade.Value * ValorCompra.Text)
        End If

    End Sub

    Private Sub txt_quantidade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ValorCompra.Text = "" Or txt_quantidade.Text = "" Then
            Exit Sub
        Else
            txt_total.Text = Val(txt_quantidade.Value * ValorCompra.Text)
        End If
    End Sub

#End Region

#Region " Cadastro da compra "

    Private Sub cadastro_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadastro_venda.Click
        If NomeProduto.Text = "" Or cmbforn.Text = "" Or ValorCompra.Text = "" Or ValorVenda.Text = "" Or txtcod_forn.Text = "" Or Cb_Tipo.Text = "" Then
            MessageBox.Show("Todos os campos devem ser preenchidos", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            'Atualizacao dos dados da compra

            Dim cmd_compra As OleDbCommand
            AbrirBD()
            cmd_compra = New OleDbCommand("INSERT into compra_prod(cod_forn,nome_fant_forn,nome_produto,total_compra,dia_compra)values(@codforn,@forn,@produto,@total,@agora)", Conexao)
            With cmd_compra
                .Parameters.Add(New OleDbParameter("@codforn", OleDbType.VarChar, 100))
                .Parameters("@codforn").Value = txtcod_forn.Text
                .Parameters.Add(New OleDbParameter("@forn", OleDbType.VarChar, 100))
                .Parameters("@forn").Value = cmbforn.Text
                .Parameters.Add(New OleDbParameter("@produto", OleDbType.VarChar, 100))
                .Parameters("@produto").Value = NomeProduto.Text
                .Parameters.Add(New OleDbParameter("@total", OleDbType.VarChar, 100))
                .Parameters("@total").Value = txt_total.Text
                .Parameters.Add(New OleDbParameter("@agora", OleDbType.VarChar, 100))
                .Parameters("@agora").Value = Now.Date.Today
            End With
            cmd_compra.ExecuteNonQuery()
            FecharBD()

            Dim newcmd As OleDbCommand
            Dim dr As OleDbDataReader
            'Variaveis para estoque do produtos
            Dim cont As Integer
            Dim estoque_anterior As Long
            Dim novo_estoque As Long

            'Variaveis para forn
            Dim novo_saldo As Long
            Dim comando_forn As OleDbCommand

            'Controle de saldo do fornecedor
            AbrirBD()

            comando_forn = New OleDbCommand("select * from fornecedor where cod_forn=@codforn", Conexao)
            comando_forn.Parameters.Add(New OleDbParameter("@codforn", OleDbType.VarChar, 50))
            comando_forn.Parameters("@codforn").Value = txtcod_forn.Text

            dr = comando_forn.ExecuteReader
            If dr.Read Then
                novo_saldo = Val(dr("saldo_forn") + (txt_total.Text))
            End If
            dr.Close()
            comando_forn = New OleDbCommand("Update fornecedor set saldo_forn=@saldo where cod_forn=@codforn", Conexao)
            comando_forn.Parameters.Add(New OleDbParameter("@saldo", OleDbType.VarChar, 50))
            comando_forn.Parameters("@saldo").Value = novo_saldo
            comando_forn.Parameters.Add(New OleDbParameter("@codforn", OleDbType.VarChar, 50))
            comando_forn.Parameters("@codforn").Value = txtcod_forn.Text
            'TDE
            Try
                comando_forn.ExecuteNonQuery()
                status.Panels.Item(0).Text = "Saldo do fornecedor atualizado para R$ " & novo_saldo
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Erro")
            Finally
                FecharBD()
            End Try



            'Controle de estoque acrescentando produtos em estoque_prod
            newcmd = New OleDbCommand("select * from produtos", Conexao)
            AbrirBD()

            dr = newcmd.ExecuteReader
            While dr.Read
                estoque_anterior = dr("estoque_prod")
                novo_estoque = Val(estoque_anterior + txt_quantidade.Text)
                If dr("modelo_prod") = NomeProduto.Text.ToString And dr("marca_prod") = marca_produto.Text.ToString And dr("cod_forn") = txtcod_forn.Text And dr("tipo_prod") = Cb_Tipo.Text Then
                    Dim cmd_up As OleDbCommand
                    AbrirBD()
                    cmd_up = New OleDbCommand("Update produtos set vcompra_prod=@vcompra,vvenda_prod=@vvenda,estoque_prod=@estoque where cod_prod=" & dr("cod_prod"), Conexao)
                    With cmd_up
                        .Parameters.Add(New OleDbParameter("@vcompra", OleDbType.VarChar, 100))
                        .Parameters("@vcompra").Value = ValorCompra.Text
                        .Parameters.Add(New OleDbParameter("@vvenda", OleDbType.VarChar, 100))
                        .Parameters("@vvenda").Value = ValorVenda.Text
                        .Parameters.Add(New OleDbParameter("@estoque", OleDbType.VarChar, 100))
                        .Parameters("@estoque").Value = novo_estoque
                    End With
                    'TDE
                    Try
                        dr.Close()
                        cmd_up.ExecuteNonQuery()
                        MessageBox.Show("Estoque de Produto Atualizado", "Compra de produtos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message.ToString(), "Erro")
                    Finally
                        FecharBD()
                    End Try
                    Exit Sub
                    Exit While
                End If
            End While
            FecharBD()

            'Cadastro de produtos novos 
            '     Declaracao da unica var used
            Dim comando As OleDbCommand
            AbrirBD()
            comando = New OleDbCommand("INSERT into produtos(modelo_prod,marca_prod,cod_forn,vcompra_prod,vvenda_prod,tipo_prod,nome_fant_forn,estoque_prod) values (@modelo,@marca,@forn,@vcompra,@vvenda,@tipo,@nomeforn,@estoque)", Conexao)
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
                .Parameters.Add(New OleDbParameter("@nomeforn", OleDbType.VarChar, 100))
                .Parameters("@nomeforn").Value = cmbforn.Text.ToString
                .Parameters.Add(New OleDbParameter("@estoque", OleDbType.VarChar, 100))
                .Parameters("@estoque").Value = Me.txt_quantidade.Text
            End With
            'TDE
            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("Produto cadastrado", "Compra de produtos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Erro")
            Finally
                FecharBD()
            End Try
        End If

        cod_prod.Text = ""
    End Sub

#End Region

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
        AbrirBD()
        Comandoa = New OleDbCommand("select distinct modelo_prod from produtos order by modelo_prod", Conexao)
        DRa = Comandoa.ExecuteReader
        While DRa.Read
            NomeProduto.Items.Add(DRa("modelo_prod"))
        End While
        DRa.Close()
        DR.Close()
        FecharBD()
    End Sub

    Private Sub cmbforn_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbforn.Leave
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        comando = New OleDbCommand("select cod_forn from fornecedor where nome_fant_forn='" & Me.cmbforn.Text.ToString & "'", Conexao)
        AbrirBD()
        dr = comando.ExecuteReader
        If dr.Read Then
            Me.txtcod_forn.Text = dr("cod_forn")
        End If
        FecharBD()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_quantidade.ValueChanged
        If ValorCompra.Text = "" Then
            Exit Sub
        Else
            ValorVenda.Text = Val(ValorCompra.Text) * 1.2
        End If

        If ValorCompra.Text = "" Or txt_quantidade.Value = "" Then
            Exit Sub
        Else
            txt_total.Text = Val(txt_quantidade.Value * ValorCompra.Text)
        End If
    End Sub
End Class
