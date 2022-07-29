Imports System.Data.OleDb
Public Class Localizar_Fornecedores
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
    Friend WithEvents L_AUX2 As System.Windows.Forms.Label
    Friend WithEvents cmb_escolha As System.Windows.Forms.ComboBox
    Friend WithEvents BTNsair As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Nome As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label_X As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents produto As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cb_produtos As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_fantasia As System.Windows.Forms.ComboBox
    Friend WithEvents estado As System.Windows.Forms.ColumnHeader
    Friend WithEvents lista_fornecedores As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Localizar_Fornecedores))
        Me.L_AUX2 = New System.Windows.Forms.Label
        Me.cmb_escolha = New System.Windows.Forms.ComboBox
        Me.BTNsair = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lista_fornecedores = New System.Windows.Forms.ListView
        Me.Codigo = New System.Windows.Forms.ColumnHeader
        Me.Nome = New System.Windows.Forms.ColumnHeader
        Me.estado = New System.Windows.Forms.ColumnHeader
        Me.produto = New System.Windows.Forms.ColumnHeader
        Me.Label_X = New System.Windows.Forms.Label
        Me.Label = New System.Windows.Forms.Label
        Me.Cb_produtos = New System.Windows.Forms.ComboBox
        Me.Cb_estado = New System.Windows.Forms.ComboBox
        Me.Cb_fantasia = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'L_AUX2
        '
        Me.L_AUX2.BackColor = System.Drawing.Color.LightGray
        Me.L_AUX2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_AUX2.ForeColor = System.Drawing.Color.Red
        Me.L_AUX2.Location = New System.Drawing.Point(224, 7)
        Me.L_AUX2.Name = "L_AUX2"
        Me.L_AUX2.Size = New System.Drawing.Size(128, 30)
        Me.L_AUX2.TabIndex = 83
        Me.L_AUX2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_escolha
        '
        Me.cmb_escolha.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_escolha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_escolha.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_escolha.Items.AddRange(New Object() {"Fantasia", "Estado", "Produto"})
        Me.cmb_escolha.Location = New System.Drawing.Point(360, 7)
        Me.cmb_escolha.Name = "cmb_escolha"
        Me.cmb_escolha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmb_escolha.Size = New System.Drawing.Size(96, 24)
        Me.cmb_escolha.TabIndex = 82
        '
        'BTNsair
        '
        Me.BTNsair.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNsair.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNsair.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BTNsair.Image = CType(resources.GetObject("BTNsair.Image"), System.Drawing.Image)
        Me.BTNsair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNsair.Location = New System.Drawing.Point(200, 354)
        Me.BTNsair.Name = "BTNsair"
        Me.BTNsair.Size = New System.Drawing.Size(80, 52)
        Me.BTNsair.TabIndex = 80
        Me.BTNsair.Text = "Voltar"
        Me.BTNsair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(192, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 67)
        Me.Label4.TabIndex = 81
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lista_fornecedores)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox1.Location = New System.Drawing.Point(8, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 259)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fornecedores"
        '
        'lista_fornecedores
        '
        Me.lista_fornecedores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Nome, Me.estado, Me.produto})
        Me.lista_fornecedores.FullRowSelect = True
        Me.lista_fornecedores.GridLines = True
        Me.lista_fornecedores.Location = New System.Drawing.Point(8, 22)
        Me.lista_fornecedores.MultiSelect = False
        Me.lista_fornecedores.Name = "lista_fornecedores"
        Me.lista_fornecedores.Size = New System.Drawing.Size(424, 229)
        Me.lista_fornecedores.TabIndex = 0
        Me.lista_fornecedores.View = System.Windows.Forms.View.Details
        '
        'Codigo
        '
        Me.Codigo.Text = "Codigo"
        Me.Codigo.Width = 0
        '
        'Nome
        '
        Me.Nome.Text = "Nome Fantasia"
        Me.Nome.Width = 159
        '
        'estado
        '
        Me.estado.Text = "Estado"
        Me.estado.Width = 146
        '
        'produto
        '
        Me.produto.Text = "Produto"
        Me.produto.Width = 113
        '
        'Label_X
        '
        Me.Label_X.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_X.ForeColor = System.Drawing.Color.Beige
        Me.Label_X.Location = New System.Drawing.Point(16, 52)
        Me.Label_X.Name = "Label_X"
        Me.Label_X.Size = New System.Drawing.Size(80, 21)
        Me.Label_X.TabIndex = 76
        Me.Label_X.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.Color.LightGray
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Black
        Me.Label.Location = New System.Drawing.Point(0, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(352, 37)
        Me.Label.TabIndex = 77
        Me.Label.Text = "Localizar por:"
        '
        'Cb_produtos
        '
        Me.Cb_produtos.Items.AddRange(New Object() {"Acessorios", "Vidros", "Som", "Pneus", "Rodas", "Outros"})
        Me.Cb_produtos.Location = New System.Drawing.Point(96, 52)
        Me.Cb_produtos.Name = "Cb_produtos"
        Me.Cb_produtos.Size = New System.Drawing.Size(176, 20)
        Me.Cb_produtos.TabIndex = 85
        '
        'Cb_estado
        '
        Me.Cb_estado.Location = New System.Drawing.Point(96, 52)
        Me.Cb_estado.Name = "Cb_estado"
        Me.Cb_estado.Size = New System.Drawing.Size(175, 20)
        Me.Cb_estado.TabIndex = 84
        '
        'Cb_fantasia
        '
        Me.Cb_fantasia.Location = New System.Drawing.Point(96, 52)
        Me.Cb_fantasia.Name = "Cb_fantasia"
        Me.Cb_fantasia.Size = New System.Drawing.Size(176, 20)
        Me.Cb_fantasia.TabIndex = 78
        '
        'Localizar_Fornecedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(456, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.L_AUX2)
        Me.Controls.Add(Me.cmb_escolha)
        Me.Controls.Add(Me.BTNsair)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_X)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Cb_fantasia)
        Me.Controls.Add(Me.Cb_produtos)
        Me.Controls.Add(Me.Cb_estado)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Localizar_Fornecedores"
        Me.Text = "Localizar Fornecedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmb_escolha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_escolha.SelectedIndexChanged
        lista_fornecedores.Items.Clear()
        Cb_estado.Items.Clear()
        Cb_fantasia.Items.Clear()

        If cmb_escolha.Text = "Fantasia" Then
            Cb_estado.Visible = False
            Cb_produtos.Visible = False
            Cb_fantasia.Visible = True
            L_AUX2.Visible = True
            L_AUX2.Text = "Fantasia"
            Label_X.Text = "Fantasia:"
            Cb_fantasia.Items.Clear()

            Dim CmdNOME As OleDbCommand
            Dim DRNOME As OleDbDataReader
            AbrirBD()
            CmdNOME = New OleDbCommand("select distinct nome_fant_forn from fornecedor order by nome_fant_forn", Conexao)
            Try
                DRNOME = CmdNOME.ExecuteReader
                While DRNOME.Read
                    Cb_fantasia.Items.Add(DRNOME("nome_fant_forn"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try
        End If

        If cmb_escolha.Text = "Estado" Then
            Cb_estado.Items.Clear()
            Cb_fantasia.Visible = False
            Cb_produtos.Visible = False
            Cb_estado.Visible = True
            L_AUX2.Visible = True
            L_AUX2.Text = "Estado"
            Label_X.Text = "Estado:"
            Dim Cmdestado As OleDbCommand
            Dim DRestado As OleDbDataReader
            AbrirBD()
            Cmdestado = New OleDbCommand("select distinct est_forn from fornecedor order by est_forn", Conexao)
            Try
                DRestado = Cmdestado.ExecuteReader
                While DRestado.Read
                    Cb_estado.Items.Add(DRestado("est_forn"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try
        End If

        If cmb_escolha.Text = "Produto" Then
            Cb_produtos.Visible = True
            Cb_fantasia.Visible = False
            Cb_estado.Visible = False
            L_AUX2.Visible = True
            L_AUX2.Text = "Produto"
            Label_X.Text = "Produto:"
        End If
    End Sub

    Private Sub Cb_produtos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_produtos.SelectedIndexChanged
        lista_fornecedores.Items.Clear()
        Dim produto As String
        If Cb_produtos.Text = "Acessorios" Then
            produto = "acessorios"
        End If
        If Cb_produtos.Text = "Vidros" Then
            produto = "vidros"
        End If
        If Cb_produtos.Text = "Som" Then
            produto = "som"
        End If
        If Cb_produtos.Text = "Pneus" Then
            produto = "pneus"
        End If
        If Cb_produtos.Text = "Rodas" Then
            produto = "rodas"
        End If
        If Cb_produtos.Text = "Outros" Then
            produto = "outros"
        End If

        Dim Comando As OleDbCommand
        Dim Data_Reader As OleDbDataReader
        AbrirBD()
        Comando = New OleDbCommand("select * from fornecedor where " & produto & "= true", Conexao)

        Try
            Data_Reader = Comando.ExecuteReader
            While Data_Reader.Read
                Dim lista As New ListViewItem
                lista.Text = Data_Reader("cod_forn")
                lista.SubItems.Add(Data_Reader("nome_fant_forn"))
                lista.SubItems.Add(Data_Reader("est_forn"))
                lista.SubItems.Add(Cb_produtos.Text)
                lista_fornecedores.Items.Add(lista)
            End While


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try

    End Sub

    Private Sub BTNsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNsair.Click
        Me.Close()

    End Sub

    Private Sub Cb_estado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_estado.SelectedIndexChanged
        lista_fornecedores.Items.Clear()
        Dim Comando As OleDbCommand
        Dim Data_Reader As OleDbDataReader
        AbrirBD()
        Comando = New OleDbCommand("select * from fornecedor where est_forn='" & Cb_estado.Text.ToString & "'", Conexao)
        Try
            Data_Reader = Comando.ExecuteReader
            While Data_Reader.Read
                Dim lista As New ListViewItem
                lista.Text = Data_Reader("cod_forn")
                lista.SubItems.Add(Data_Reader("nome_fant_forn"))
                lista.SubItems.Add(Data_Reader("est_forn"))
                lista.SubItems.Add("####")
                lista_fornecedores.Items.Add(lista)
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try

    End Sub

    Private Sub Cb_fantasia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_fantasia.SelectedIndexChanged
        lista_fornecedores.Items.Clear()
        Dim Comando As OleDbCommand
        Dim Data_Reader As OleDbDataReader
        AbrirBD()
        Comando = New OleDbCommand("select * from fornecedor where nome_fant_forn='" & Cb_fantasia.Text.ToString & "'", Conexao)
        Try
            Data_Reader = Comando.ExecuteReader
            While Data_Reader.Read
                Dim lista As New ListViewItem
                lista.Text = Data_Reader("cod_forn")
                lista.SubItems.Add(Data_Reader("nome_fant_forn"))
                lista.SubItems.Add(Data_Reader("est_forn"))
                lista.SubItems.Add("####")
                lista_fornecedores.Items.Add(lista)
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub lista_fornecedores_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lista_fornecedores.DoubleClick

        Dim Comando As OleDbCommand
        Dim Dr As OleDbDataReader
        Dim cont As Integer
        Dim image_address As String

        AbrirBD()


        For cont = 0 To lista_fornecedores.Items.Count - 1

            Comando = New OleDbCommand("select * from fornecedor where cod_forn=" & lista_fornecedores.FocusedItem.Text.ToString, Conexao)

        Next

        Try
            Dr = Comando.ExecuteReader
            If Dr.Read Then
                image_address = Dr("logo_forn")
                Dim newimg As Bitmap = New Bitmap(image_address)
                fornecedor.Logo = image_address
                With fornecedor
                    .txtcod_forn.Text = Dr("cod_forn")
                    .txtnome_forn.Text = Dr("nome_forn")
                    .txt_fantasia.Text = Dr("nome_fant_forn")
                    .txtend_forn.Text = Dr("endereco_forn")
                    .txtpais_forn.Text = Dr("pais_forn")
                    .txtcnpj_forn.Text = Dr("cnpj_forn")
                    .txtestado_forn.Text = Dr("est_forn")
                    .txt_telefone.Text = Dr("telefone_forn")
                    .txtcida_forn.Text = Dr("cidade_forn")
                    .txt_email.Text = Dr("email_forn")
                    .cb_acessorios.Checked = Dr("acessorios")
                    .cb_som.Checked = Dr("som")
                    .cb_pneus.Checked = Dr("pneus")
                    .cb_vidros.Checked = Dr("vidros")
                    .cb_rodas.Checked = Dr("rodas")
                    .cb_outros.Checked = Dr("outros")
                    .picture_logo.Show()
                    .picture_logo.Image = newimg
                End With
                If buy_newvei.Visible = True Then
                    buy_newvei.txt_codforn.Text = Dr("cod_forn")
                    buy_newvei.cb_forn.Text = Dr("nome_fant_forn")
                End If
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
        Me.Close()
        lista_fornecedores.Items.Clear()
    End Sub


    Private Sub Localizar_Fornecedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lista_fornecedores.Items.Clear()
        Cb_fantasia.Items.Clear()
        Cb_estado.Items.Clear()
    End Sub

    Private Sub lista_fornecedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lista_fornecedores.SelectedIndexChanged

    End Sub
End Class
