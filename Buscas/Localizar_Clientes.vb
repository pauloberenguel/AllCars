Imports System.Data.OleDb

Public Class Localizar_Clientes
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_X As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Cb_Estado As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_sit As System.Windows.Forms.ComboBox
    Friend WithEvents lstCli As System.Windows.Forms.ListView
    Friend WithEvents Cb_Nome As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Cidade As System.Windows.Forms.ComboBox
    Friend WithEvents Codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Nome As System.Windows.Forms.ColumnHeader
    Friend WithEvents Estado As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cidade As System.Windows.Forms.ColumnHeader
    Friend WithEvents Bairro As System.Windows.Forms.ColumnHeader
    Friend WithEvents Situacao As System.Windows.Forms.ColumnHeader
    Friend WithEvents BTNsair As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Localizar_Clientes))
        Me.Cb_Estado = New System.Windows.Forms.ComboBox
        Me.Cb_sit = New System.Windows.Forms.ComboBox
        Me.L_AUX2 = New System.Windows.Forms.Label
        Me.cmb_escolha = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lstCli = New System.Windows.Forms.ListView
        Me.Codigo = New System.Windows.Forms.ColumnHeader
        Me.Nome = New System.Windows.Forms.ColumnHeader
        Me.Estado = New System.Windows.Forms.ColumnHeader
        Me.Cidade = New System.Windows.Forms.ColumnHeader
        Me.Bairro = New System.Windows.Forms.ColumnHeader
        Me.Situacao = New System.Windows.Forms.ColumnHeader
        Me.Cb_Nome = New System.Windows.Forms.ComboBox
        Me.Label_X = New System.Windows.Forms.Label
        Me.Label = New System.Windows.Forms.Label
        Me.Cb_Cidade = New System.Windows.Forms.ComboBox
        Me.BTNsair = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cb_Estado
        '
        Me.Cb_Estado.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"})
        Me.Cb_Estado.Location = New System.Drawing.Point(96, 56)
        Me.Cb_Estado.Name = "Cb_Estado"
        Me.Cb_Estado.Size = New System.Drawing.Size(176, 21)
        Me.Cb_Estado.TabIndex = 64
        '
        'Cb_sit
        '
        Me.Cb_sit.Items.AddRange(New Object() {"Normal", "A pagar", "A receber"})
        Me.Cb_sit.Location = New System.Drawing.Point(96, 56)
        Me.Cb_sit.Name = "Cb_sit"
        Me.Cb_sit.Size = New System.Drawing.Size(175, 21)
        Me.Cb_sit.TabIndex = 63
        '
        'L_AUX2
        '
        Me.L_AUX2.BackColor = System.Drawing.Color.LightGray
        Me.L_AUX2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_AUX2.ForeColor = System.Drawing.Color.Red
        Me.L_AUX2.Location = New System.Drawing.Point(224, 8)
        Me.L_AUX2.Name = "L_AUX2"
        Me.L_AUX2.Size = New System.Drawing.Size(128, 32)
        Me.L_AUX2.TabIndex = 62
        Me.L_AUX2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_escolha
        '
        Me.cmb_escolha.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_escolha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_escolha.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_escolha.Items.AddRange(New Object() {"Nome", "Cidade", "Estado", "Situação"})
        Me.cmb_escolha.Location = New System.Drawing.Point(360, 8)
        Me.cmb_escolha.Name = "cmb_escolha"
        Me.cmb_escolha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmb_escolha.Size = New System.Drawing.Size(96, 24)
        Me.cmb_escolha.TabIndex = 60
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstCli)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox1.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 280)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clientes"
        '
        'lstCli
        '
        Me.lstCli.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Nome, Me.Estado, Me.Cidade, Me.Bairro, Me.Situacao})
        Me.lstCli.FullRowSelect = True
        Me.lstCli.GridLines = True
        Me.lstCli.Location = New System.Drawing.Point(8, 24)
        Me.lstCli.MultiSelect = False
        Me.lstCli.Name = "lstCli"
        Me.lstCli.Scrollable = False
        Me.lstCli.Size = New System.Drawing.Size(424, 248)
        Me.lstCli.TabIndex = 0
        Me.lstCli.View = System.Windows.Forms.View.Details
        '
        'Codigo
        '
        Me.Codigo.Text = "Codigo"
        Me.Codigo.Width = 0
        '
        'Nome
        '
        Me.Nome.Text = "Nome"
        Me.Nome.Width = 69
        '
        'Estado
        '
        Me.Estado.Text = "Estado"
        Me.Estado.Width = 80
        '
        'Cidade
        '
        Me.Cidade.Text = "Cidade"
        Me.Cidade.Width = 87
        '
        'Bairro
        '
        Me.Bairro.Text = "Bairro"
        Me.Bairro.Width = 103
        '
        'Situacao
        '
        Me.Situacao.Text = "Situacao"
        Me.Situacao.Width = 80
        '
        'Cb_Nome
        '
        Me.Cb_Nome.Location = New System.Drawing.Point(96, 56)
        Me.Cb_Nome.Name = "Cb_Nome"
        Me.Cb_Nome.Size = New System.Drawing.Size(176, 21)
        Me.Cb_Nome.TabIndex = 56
        '
        'Label_X
        '
        Me.Label_X.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_X.ForeColor = System.Drawing.Color.Beige
        Me.Label_X.Location = New System.Drawing.Point(16, 56)
        Me.Label_X.Name = "Label_X"
        Me.Label_X.Size = New System.Drawing.Size(80, 23)
        Me.Label_X.TabIndex = 54
        Me.Label_X.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.Color.LightGray
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Black
        Me.Label.Location = New System.Drawing.Point(0, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(352, 40)
        Me.Label.TabIndex = 55
        Me.Label.Text = "Localizar por:"
        '
        'Cb_Cidade
        '
        Me.Cb_Cidade.Location = New System.Drawing.Point(96, 56)
        Me.Cb_Cidade.Name = "Cb_Cidade"
        Me.Cb_Cidade.Size = New System.Drawing.Size(176, 21)
        Me.Cb_Cidade.TabIndex = 65
        '
        'BTNsair
        '
        Me.BTNsair.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNsair.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNsair.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BTNsair.Image = CType(resources.GetObject("BTNsair.Image"), System.Drawing.Image)
        Me.BTNsair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNsair.Location = New System.Drawing.Point(192, 390)
        Me.BTNsair.Name = "BTNsair"
        Me.BTNsair.Size = New System.Drawing.Size(80, 56)
        Me.BTNsair.TabIndex = 234
        Me.BTNsair.Text = "Voltar"
        Me.BTNsair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(184, 381)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 73)
        Me.Label1.TabIndex = 235
        '
        'Localizar_Clientes
        '
        Me.AllowDrop = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(456, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTNsair)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.L_AUX2)
        Me.Controls.Add(Me.cmb_escolha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_X)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Cb_Nome)
        Me.Controls.Add(Me.Cb_Cidade)
        Me.Controls.Add(Me.Cb_Estado)
        Me.Controls.Add(Me.Cb_sit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Localizar_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localizar Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Localizar_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_escolha.Text = ""
        L_AUX2.Visible = False
        Cb_Nome.Visible = False
        Cb_sit.Visible = False
        Cb_Cidade.Visible = False
        Cb_Estado.Visible = False
        Cb_Nome.Items.Clear()
        Cb_Cidade.Items.Clear()
    End Sub

    Private Sub lstCli_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCli.DoubleClick
        Dim Comando As OleDbCommand
        Dim Dr As OleDbDataReader
        Dim cont As Integer

        AbrirBD()

        For cont = 0 To lstCli.Items.Count - 1
            Comando = New OleDbCommand("select * from clientes where cod_cli=@cod", Conexao)
            Comando.Parameters.Add(New OleDbParameter("@cod", OleDbType.VarChar, 50))
            Comando.Parameters("@cod").Value = lstCli.FocusedItem.Text.ToString
        Next
        Try
            Dr = Comando.ExecuteReader

            If Dr.Read Then

                If venda_produtos.Visible = True Then
                    venda_produtos.cod_cli.Text = Dr("cod_cli")
                    venda_produtos.nome_cli.Text = Dr("nome_cli")
                End If
                If venda_veiculo_novo.Visible = True Then
                    venda_veiculo_novo.txt_codcli.Text = Dr("cod_cli")
                    venda_veiculo_novo.cb_cli.Text = Dr("nome_cli")
                End If
                If venda_veiculo_usado.Visible = True Then
                    venda_veiculo_usado.txt_codcli.Text = Dr("cod_cli")
                    venda_veiculo_usado.cb_cli.Text = Dr("nome_cli")
                End If

                If Efetua_alu.Visible = True Then
                    Efetua_alu.cb_Cli.Text = Dr("nome_cli")
                    Efetua_alu.CodCLI.Text = Dr("cod_cli")
                End If

                If cadastrocli_alu.Visible = True Then
                    With cadastrocli_alu
                        .txtcod_cli.Text = Dr("cod_cli")
                        .txtnome_cli.Text = Dr("nome_cli")
                        .txtend_cli.Text = Dr("endereco_cli")
                        .txtbairro_cli.Text = Dr("bairro_cli")
                        .txtcep_cli.Text = Dr("cep_cli")
                        .cmbestado_cli.Text = Dr("estado_cli")
                        .txtcidade_cli.Text = Dr("cidade_cli")
                        .txttelefone_cli.Text = Dr("telefone_cli")
                        .txtcelular_cli.Text = Dr("cel_cli")
                        .txtrg_cli.Text = Dr("rg_cli")
                        .txtcpf_cli.Text = Dr("cpf_cli")
                        .txtcnpj_cli.Text = Dr("cnpj_cli")
                        .txt_situacao.Text = Dr("situa_cli")
                        .txtsaldo.Text = Dr("saldo_cli")
                    End With


                    If cadastrocli_alu.txtcnpj_cli.Text = "" Then
                        cadastrocli_alu.txtcnpj_cli.ReadOnly = True
                        cadastrocli_alu.rdbcnpj_cli.Checked = False
                        cadastrocli_alu.rdbcpf_cli.Checked = True
                    Else
                        cadastrocli_alu.txtcnpj_cli.ReadOnly = False
                        cadastrocli_alu.rdbcnpj_cli.Checked = True
                        cadastrocli_alu.rdbcpf_cli.Checked = False
                    End If
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
        Me.Close()
        lstCli.Items.Clear()
    End Sub

    Private Sub BTNsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstCli.Items.Clear()
        cmb_escolha.Text = ""
        Me.Close()
    End Sub

    Private Sub Cb_Nome_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Nome.SelectedIndexChanged
        lstCli.Items.Clear()
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        AbrirBD()
        Comando = New OleDbCommand("select * from clientes where nome_cli='" & Cb_Nome.Text & "'", Conexao)
        Try

            DR = Comando.ExecuteReader
            While DR.Read
                Dim lista As New ListViewItem

                lista.Text = DR("cod_cli")
                lista.SubItems.Add(DR("nome_cli"))
                lista.SubItems.Add(DR("estado_cli"))
                lista.SubItems.Add(DR("cidade_cli"))
                lista.SubItems.Add(DR("bairro_cli"))
                lista.SubItems.Add(DR("situa_cli"))

                lstCli.Items.Add(lista)
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try

    End Sub

    Private Sub Cb_Cidade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Cidade.SelectedIndexChanged
        lstCli.Items.Clear()
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        AbrirBD()
        Comando = New OleDbCommand("select * from Clientes where cidade_cli='" & Cb_Cidade.Text & "'", Conexao)
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                Dim lista As New ListViewItem
                lista.Text = DR("cod_cli")
                lista.SubItems.Add(DR("nome_cli"))
                lista.SubItems.Add(DR("estado_cli"))
                lista.SubItems.Add(DR("cidade_cli"))
                lista.SubItems.Add(DR("bairro_cli"))
                lista.SubItems.Add(DR("situa_cli"))
                lstCli.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub Cb_Estado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Estado.SelectedIndexChanged
        lstCli.Items.Clear()
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        AbrirBD()
        Comando = New OleDbCommand("select * from Clientes where estado_cli='" & Cb_Estado.Text & "'", Conexao)
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                Dim lista As New ListViewItem
                lista.Text = DR("cod_cli")
                lista.SubItems.Add(DR("nome_cli"))
                lista.SubItems.Add(DR("estado_cli"))
                lista.SubItems.Add(DR("cidade_cli"))
                lista.SubItems.Add(DR("bairro_cli"))
                lista.SubItems.Add(DR("situa_cli"))
                lstCli.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub Cb_sit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_sit.SelectedIndexChanged
        lstCli.Items.Clear()
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        AbrirBD()
        Comando = New OleDbCommand("select * from Clientes where situa_cli='" & Cb_sit.Text & "'", Conexao)
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                Dim lista As New ListViewItem
                lista.Text = DR("cod_cli")
                lista.SubItems.Add(DR("nome_cli"))
                lista.SubItems.Add(DR("estado_cli"))
                lista.SubItems.Add(DR("cidade_cli"))
                lista.SubItems.Add(DR("bairro_cli"))
                lista.SubItems.Add(DR("situa_cli"))
                lstCli.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub cmb_escolha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_escolha.SelectedIndexChanged
        If cmb_escolha.Text = "Nome" Then
            Cb_Estado.Visible = False
            Cb_Cidade.Visible = False
            Cb_Estado.Visible = False
            Cb_Nome.Visible = True
            L_AUX2.Visible = True
            L_AUX2.Text = "Nome"
            Label_X.Text = "Nome:"
            Cb_Nome.Items.Clear()
            Cb_Cidade.Items.Clear()

            Dim CmdNOME As OleDbCommand
            Dim DRNOME As OleDbDataReader
            AbrirBD()

            CmdNOME = New OleDbCommand("select distinct nome_cli from Clientes order by nome_cli", Conexao)

            Try
                DRNOME = CmdNOME.ExecuteReader
                While DRNOME.Read
                    Cb_Nome.Items.Add(DRNOME("nome_cli"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try


        End If

        If cmb_escolha.Text = "Estado" Then
            Cb_Cidade.Visible = False
            Cb_Nome.Visible = False
            Cb_sit.Visible = False
            Cb_Estado.Visible = True
            Cb_Nome.Items.Clear()
            Cb_Cidade.Items.Clear()

            L_AUX2.Visible = True
            L_AUX2.Text = "Estado"
            Label_X.Text = "Estado:"
        End If

        If cmb_escolha.Text = "Cidade" Then
            Cb_Cidade.Visible = True
            Cb_Nome.Visible = False
            Cb_Estado.Visible = False
            Cb_sit.Visible = False
            L_AUX2.Visible = True
            L_AUX2.Text = "Cidade"
            Cb_Nome.Items.Clear()
            Cb_Cidade.Items.Clear()

            Label_X.Text = "Cidade:"
            Dim DRCid As OleDbDataReader
            Dim CmdCid As OleDbCommand
            AbrirBD()
            CmdCid = New OleDbCommand("select distinct cidade_cli from Clientes order by cidade_cli", Conexao)
            Try
                DRCid = CmdCid.ExecuteReader
                While DRCid.Read
                    Cb_Cidade.Items.Add(DRCid("cidade_cli"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try
        End If

        If cmb_escolha.Text = "Situação" Then
            Cb_Nome.Items.Clear()
            Cb_Cidade.Items.Clear()

            Cb_Cidade.Visible = False
            Cb_Nome.Visible = False
            Cb_Estado.Visible = False
            Cb_sit.Visible = True
            L_AUX2.Visible = True
            L_AUX2.Text = "Situação"
            Label_X.Text = "Situação:"
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstCli.Items.Clear()
        cmb_escolha.Text = ""
        Me.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BTNsair_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNsair.Click
        lstCli.Items.Clear()
        cmb_escolha.Text = ""
        Me.Visible = False

    End Sub

    Private Sub lstCli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCli.SelectedIndexChanged

    End Sub
End Class
