Imports System.Data.OleDb

Public Class Localizar_Produtos
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BTNsair As System.Windows.Forms.Button
    Friend WithEvents cmb_escolha As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Nome As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label_suporte As System.Windows.Forms.Label
    Friend WithEvents label_supBOT As System.Windows.Forms.Label
    Friend WithEvents label_escolha As System.Windows.Forms.Label
    Friend WithEvents Label_AUX2 As System.Windows.Forms.Label
    Friend WithEvents Label_AUX1 As System.Windows.Forms.Label
    Friend WithEvents Cb_Fornecedor As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lista_produtos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Localizar_Produtos))
        Me.Label_suporte = New System.Windows.Forms.Label
        Me.Label_AUX2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lista_produtos = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.BTNsair = New System.Windows.Forms.Button
        Me.label_supBOT = New System.Windows.Forms.Label
        Me.Cb_Nome = New System.Windows.Forms.ComboBox
        Me.cmb_escolha = New System.Windows.Forms.ComboBox
        Me.Cb_Tipo = New System.Windows.Forms.ComboBox
        Me.label_escolha = New System.Windows.Forms.Label
        Me.Label_AUX1 = New System.Windows.Forms.Label
        Me.Cb_Fornecedor = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_suporte
        '
        Me.Label_suporte.BackColor = System.Drawing.Color.LightGray
        Me.Label_suporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_suporte.ForeColor = System.Drawing.Color.Black
        Me.Label_suporte.Location = New System.Drawing.Point(0, 0)
        Me.Label_suporte.Name = "Label_suporte"
        Me.Label_suporte.Size = New System.Drawing.Size(352, 37)
        Me.Label_suporte.TabIndex = 45
        Me.Label_suporte.Text = "Localizar por:"
        '
        'Label_AUX2
        '
        Me.Label_AUX2.BackColor = System.Drawing.Color.LightGray
        Me.Label_AUX2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_AUX2.ForeColor = System.Drawing.Color.Red
        Me.Label_AUX2.Location = New System.Drawing.Point(225, 7)
        Me.Label_AUX2.Name = "Label_AUX2"
        Me.Label_AUX2.Size = New System.Drawing.Size(127, 30)
        Me.Label_AUX2.TabIndex = 52
        Me.Label_AUX2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lista_produtos)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox1.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 258)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Produtos"
        '
        'lista_produtos
        '
        Me.lista_produtos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader3, Me.ColumnHeader2, Me.ColumnHeader8})
        Me.lista_produtos.FullRowSelect = True
        Me.lista_produtos.GridLines = True
        Me.lista_produtos.Location = New System.Drawing.Point(8, 16)
        Me.lista_produtos.Name = "lista_produtos"
        Me.lista_produtos.Scrollable = False
        Me.lista_produtos.Size = New System.Drawing.Size(424, 232)
        Me.lista_produtos.TabIndex = 0
        Me.lista_produtos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Cod"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Modelo"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Marca"
        Me.ColumnHeader4.Width = 89
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tipo"
        Me.ColumnHeader3.Width = 75
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Fornecedor"
        Me.ColumnHeader2.Width = 98
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "$ Venda"
        Me.ColumnHeader8.Width = 131
        '
        'BTNsair
        '
        Me.BTNsair.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNsair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNsair.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNsair.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BTNsair.Image = CType(resources.GetObject("BTNsair.Image"), System.Drawing.Image)
        Me.BTNsair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNsair.Location = New System.Drawing.Point(188, 375)
        Me.BTNsair.Name = "BTNsair"
        Me.BTNsair.Size = New System.Drawing.Size(80, 49)
        Me.BTNsair.TabIndex = 54
        Me.BTNsair.Text = "Voltar"
        Me.BTNsair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'label_supBOT
        '
        Me.label_supBOT.BackColor = System.Drawing.SystemColors.ControlLight
        Me.label_supBOT.ForeColor = System.Drawing.Color.DarkGray
        Me.label_supBOT.Location = New System.Drawing.Point(180, 367)
        Me.label_supBOT.Name = "label_supBOT"
        Me.label_supBOT.Size = New System.Drawing.Size(96, 65)
        Me.label_supBOT.TabIndex = 55
        '
        'Cb_Nome
        '
        Me.Cb_Nome.Location = New System.Drawing.Point(91, 62)
        Me.Cb_Nome.Name = "Cb_Nome"
        Me.Cb_Nome.Size = New System.Drawing.Size(176, 20)
        Me.Cb_Nome.TabIndex = 56
        '
        'cmb_escolha
        '
        Me.cmb_escolha.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_escolha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_escolha.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_escolha.ItemHeight = 16
        Me.cmb_escolha.Items.AddRange(New Object() {"Marca", "Tipo", "Fornecedor"})
        Me.cmb_escolha.Location = New System.Drawing.Point(360, 15)
        Me.cmb_escolha.Name = "cmb_escolha"
        Me.cmb_escolha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmb_escolha.Size = New System.Drawing.Size(96, 24)
        Me.cmb_escolha.TabIndex = 57
        '
        'Cb_Tipo
        '
        Me.Cb_Tipo.Items.AddRange(New Object() {"Acessorios", "Pneus", "Rodas", "Som", "Vidros", "Outros"})
        Me.Cb_Tipo.Location = New System.Drawing.Point(91, 62)
        Me.Cb_Tipo.Name = "Cb_Tipo"
        Me.Cb_Tipo.Size = New System.Drawing.Size(176, 20)
        Me.Cb_Tipo.TabIndex = 58
        '
        'label_escolha
        '
        Me.label_escolha.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label_escolha.ForeColor = System.Drawing.Color.Beige
        Me.label_escolha.Location = New System.Drawing.Point(3, 64)
        Me.label_escolha.Name = "label_escolha"
        Me.label_escolha.Size = New System.Drawing.Size(85, 16)
        Me.label_escolha.TabIndex = 60
        '
        'Label_AUX1
        '
        Me.Label_AUX1.BackColor = System.Drawing.Color.LightGray
        Me.Label_AUX1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_AUX1.ForeColor = System.Drawing.Color.Red
        Me.Label_AUX1.Location = New System.Drawing.Point(225, 6)
        Me.Label_AUX1.Name = "Label_AUX1"
        Me.Label_AUX1.Size = New System.Drawing.Size(122, 30)
        Me.Label_AUX1.TabIndex = 61
        Me.Label_AUX1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cb_Fornecedor
        '
        Me.Cb_Fornecedor.Location = New System.Drawing.Point(91, 62)
        Me.Cb_Fornecedor.Name = "Cb_Fornecedor"
        Me.Cb_Fornecedor.Size = New System.Drawing.Size(176, 20)
        Me.Cb_Fornecedor.TabIndex = 62
        '
        'Localizar_Produtos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.CancelButton = Me.BTNsair
        Me.ClientSize = New System.Drawing.Size(456, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTNsair)
        Me.Controls.Add(Me.label_supBOT)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_AUX2)
        Me.Controls.Add(Me.Label_AUX1)
        Me.Controls.Add(Me.Label_suporte)
        Me.Controls.Add(Me.cmb_escolha)
        Me.Controls.Add(Me.label_escolha)
        Me.Controls.Add(Me.Cb_Nome)
        Me.Controls.Add(Me.Cb_Fornecedor)
        Me.Controls.Add(Me.Cb_Tipo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Localizar_Produtos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localizar Produtos"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Localizar_Produtos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_escolha.Text = ""
        Label_AUX1.Visible = False
        Label_AUX2.Visible = False
        Cb_Nome.Visible = False
        Cb_Tipo.Visible = False
        Cb_Fornecedor.Visible = False
        Cb_Nome.Items.Clear()
        Cb_Fornecedor.Items.Clear()
        cmb_escolha.Text = ""

    End Sub

    Private Sub cmb_escolha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_escolha.SelectedIndexChanged
        If cmb_escolha.Text = "Marca" Then
            Cb_Tipo.Visible = False
            Cb_Fornecedor.Visible = False
            Cb_Nome.Visible = True
            Label_AUX2.Visible = False
            Label_AUX1.Visible = True
            Label_AUX1.Text = "Marca"
            label_escolha.Text = "Marca:"
            Cb_Fornecedor.Items.Clear()
            Cb_Nome.Items.Clear()

            Dim CmdNOME As OleDbCommand
            Dim DRNOME As OleDbDataReader
            AbrirBD()

            CmdNOME = New OleDbCommand("select distinct marca_prod from produtos order by marca_prod", Conexao)

            Try
                DRNOME = CmdNOME.ExecuteReader
                While DRNOME.Read
                    Cb_Nome.Items.Add(DRNOME("marca_prod"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                DRNOME.Close()
                FecharBD()
            End Try
        End If

        If cmb_escolha.Text = "Tipo" Then
            Cb_Fornecedor.Visible = False
            Cb_Nome.Visible = False
            Cb_Tipo.Visible = True
            Label_AUX1.Visible = True
            Label_AUX2.Visible = False
            Label_AUX1.Text = "Tipo"
            label_escolha.Text = "Tipo:"

        End If

        If cmb_escolha.Text = "Fornecedor" Then
            Cb_Nome.Items.Clear()
            Cb_Fornecedor.Visible = True
            Cb_Nome.Visible = False
            Cb_Tipo.Visible = False
            Label_AUX2.Visible = True
            Label_AUX1.Visible = False
            Label_AUX2.Text = "Fornecedor"
            label_escolha.Text = "Fornecedor:"
            Cb_Fornecedor.Items.Clear()

            Cb_Fornecedor.Items.Clear()
            Dim Comando As OleDbCommand
            Dim DR As OleDbDataReader

            Comando = New OleDbCommand("select nome_fant_forn from fornecedor order by nome_fant_forn", Conexao)
            AbrirBD()
            DR = Comando.ExecuteReader
            While DR.Read
                Cb_Fornecedor.Items.Add(DR("nome_fant_forn"))
            End While
            DR.Close()
            FecharBD()
        End If
    End Sub

    Private Sub Cb_Nome_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Nome.SelectedIndexChanged
        lista_produtos.Items.Clear()

        Dim DR As OleDbDataReader
        Dim comando As OleDbCommand

        AbrirBD()

        comando = New OleDbCommand("select * from produtos where marca_prod='" & Cb_Nome.Text & "'", Conexao)
        DR = comando.ExecuteReader
        Try
            While DR.Read
                Dim lista As New ListViewItem
                lista.Text = DR("cod_prod")
                lista.SubItems.Add(DR("modelo_prod"))
                lista.SubItems.Add(DR("marca_prod"))
                lista.SubItems.Add(DR("tipo_prod"))
                lista.SubItems.Add(DR("nome_fant_forn"))
                lista.SubItems.Add(DR("vvenda_prod"))
                lista_produtos.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DR.Close()
            FecharBD()
        End Try
    End Sub

    Private Sub Cb_Tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Tipo.SelectedIndexChanged
        lista_produtos.Items.Clear()

        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader

        AbrirBD()
        Comando = New OleDbCommand("select * from produtos where tipo_prod='" & Cb_Tipo.Text & "'", Conexao)
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                Dim lista As New ListViewItem
                lista.Text = DR("cod_prod")
                lista.SubItems.Add(DR("modelo_prod"))
                lista.SubItems.Add(DR("marca_prod"))
                lista.SubItems.Add(DR("tipo_prod"))
                lista.SubItems.Add(DR("nome_fant_forn"))
                lista.SubItems.Add(DR("vvenda_prod"))
                lista_produtos.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DR.Close()
            FecharBD()
        End Try
    End Sub

    Private Sub BTNsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNsair.Click
        Me.Close()

    End Sub

    Private Sub Cb_Fornecedor_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Fornecedor.SelectedIndexChanged
        lista_produtos.Items.Clear()
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        AbrirBD()
        Comando = New OleDbCommand("select * from produtos where nome_fant_forn='" & Cb_Fornecedor.Text & "'", Conexao)
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                Dim lista As New ListViewItem
                lista.Text = DR("cod_prod")
                lista.SubItems.Add(DR("modelo_prod"))
                lista.SubItems.Add(DR("marca_prod"))
                lista.SubItems.Add(DR("tipo_prod"))
                lista.SubItems.Add(DR("nome_fant_forn"))
                lista.SubItems.Add(DR("vvenda_prod"))
                lista_produtos.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try


    End Sub

    Private Sub lista_produtos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lista_produtos.DoubleClick
        Dim Comando As OleDbCommand
        Dim Dr As OleDbDataReader
        Dim cont As Integer
        Dim nomeforn As String
        FecharBD()
        AbrirBD()

        For cont = 0 To lista_produtos.Items.Count - 1

            Comando = New OleDbCommand("select * from produtos where cod_prod=" & lista_produtos.FocusedItem.Text & "", Conexao)
            nomeforn = lista_produtos.FocusedItem.SubItems(4).Text.ToString
        Next
        Try
            Dr = Comando.ExecuteReader
            If Dr.Read Then
                If venda_produtos.Visible = True Then
                    Dim lista As New ListViewItem
                    lista.Text = "1"
                    lista.SubItems.Add(Dr("modelo_prod"))
                    lista.SubItems.Add(Dr("marca_prod"))
                    lista.SubItems.Add(Dr("vvenda_prod"))
                    lista.SubItems.Add(Dr("cod_prod"))
                    venda_produtos.List_Produtos.Items.Add(lista)
                    Dim tot As Single
                    Dim vtemp As Single

                    For cont = 0 To venda_produtos.List_Produtos.Items.Count - 1
                        vtemp = Val(venda_produtos.List_Produtos.Items.Item(cont).Text * venda_produtos.List_Produtos.Items.Item(cont).SubItems(3).Text)
                        tot = vtemp + tot
                    Next
                    venda_produtos.Total.Text = tot

                End If

                If Mec.Visible = True Then
                    Dim lista As New ListViewItem
                    lista.Text = "1"
                    lista.SubItems.Add(Dr("modelo_prod"))
                    lista.SubItems.Add(Dr("marca_prod"))
                    lista.SubItems.Add(Dr("vvenda_prod"))
                    lista.SubItems.Add(Dr("cod_prod"))
                    prod_mec.List_Produtos.Items.Add(lista)
                End If

                If buy_prod.Visible = True Then
                    buy_prod.cod_prod.Text = Dr("cod_prod")
                    buy_prod.NomeProduto.Text = Dr("modelo_prod")
                    buy_prod.Cb_Tipo.Text = Dr("tipo_prod")
                    buy_prod.cmbforn.Text = Dr("nome_fant_forn")
                    buy_prod.ValorCompra.Text = Dr("vcompra_prod")
                    buy_prod.ValorVenda.Text = Dr("vvenda_prod")
                    buy_prod.marca_produto.Text = Dr("marca_prod")
                    buy_prod.txtcod_forn.Text = Dr("cod_forn")
                    buy_prod.txt_quantidade.Text = Dr("estoque_prod")
                    buy_prod.cmbforn.Text = Dr("nome_fant_forn")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            buy_prod.Refresh()
            Dr.Close()
            FecharBD()
        End Try
        If Dr.IsClosed = True Then
            Me.Close()
        End If
        lista_produtos.Items.Clear()
        Cb_Nome.Text = ""
    End Sub

    Private Sub lista_produtos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lista_produtos.SelectedIndexChanged

    End Sub
End Class

