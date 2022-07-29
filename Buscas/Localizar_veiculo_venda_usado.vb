Imports System.Data.OleDb
Public Class Localizar_veiculo_venda_usado
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
    Friend WithEvents cmb_escolha As System.Windows.Forms.ComboBox
    Friend WithEvents BTNsair As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstvei As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label_X As System.Windows.Forms.Label
    Friend WithEvents Cb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents L_AUX2 As System.Windows.Forms.Label
    Friend WithEvents L_AUX As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Cb_Ano As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_modelo As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Localizar_veiculo_venda_usado))
        Me.cmb_escolha = New System.Windows.Forms.ComboBox
        Me.BTNsair = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lstvei = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.Label_X = New System.Windows.Forms.Label
        Me.Cb_marca = New System.Windows.Forms.ComboBox
        Me.Cb_modelo = New System.Windows.Forms.ComboBox
        Me.Cb_Ano = New System.Windows.Forms.ComboBox
        Me.L_AUX2 = New System.Windows.Forms.Label
        Me.L_AUX = New System.Windows.Forms.Label
        Me.Label = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_escolha
        '
        Me.cmb_escolha.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_escolha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_escolha.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_escolha.ItemHeight = 16
        Me.cmb_escolha.Items.AddRange(New Object() {"Modelo", "Marca", "Ano"})
        Me.cmb_escolha.Location = New System.Drawing.Point(360, 9)
        Me.cmb_escolha.Name = "cmb_escolha"
        Me.cmb_escolha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmb_escolha.Size = New System.Drawing.Size(96, 24)
        Me.cmb_escolha.TabIndex = 78
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
        Me.BTNsair.Size = New System.Drawing.Size(80, 54)
        Me.BTNsair.TabIndex = 76
        Me.BTNsair.Text = "Voltar"
        Me.BTNsair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(184, 381)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 70)
        Me.Label4.TabIndex = 77
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstvei)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox1.Location = New System.Drawing.Point(8, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 280)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veiculos"
        '
        'lstvei
        '
        Me.lstvei.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7})
        Me.lstvei.FullRowSelect = True
        Me.lstvei.GridLines = True
        Me.lstvei.Location = New System.Drawing.Point(8, 24)
        Me.lstvei.Name = "lstvei"
        Me.lstvei.Scrollable = False
        Me.lstvei.Size = New System.Drawing.Size(424, 248)
        Me.lstvei.TabIndex = 0
        Me.lstvei.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Codigo"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Modelo"
        Me.ColumnHeader1.Width = 116
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Marca"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cor"
        Me.ColumnHeader4.Width = 62
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Ano"
        Me.ColumnHeader5.Width = 67
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Preco(Venda)"
        Me.ColumnHeader7.Width = 106
        '
        'Label_X
        '
        Me.Label_X.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_X.ForeColor = System.Drawing.Color.Beige
        Me.Label_X.Location = New System.Drawing.Point(16, 52)
        Me.Label_X.Name = "Label_X"
        Me.Label_X.Size = New System.Drawing.Size(80, 23)
        Me.Label_X.TabIndex = 72
        Me.Label_X.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cb_marca
        '
        Me.Cb_marca.Location = New System.Drawing.Point(96, 52)
        Me.Cb_marca.Name = "Cb_marca"
        Me.Cb_marca.Size = New System.Drawing.Size(175, 21)
        Me.Cb_marca.TabIndex = 81
        '
        'Cb_modelo
        '
        Me.Cb_modelo.Location = New System.Drawing.Point(96, 52)
        Me.Cb_modelo.Name = "Cb_modelo"
        Me.Cb_modelo.Size = New System.Drawing.Size(176, 21)
        Me.Cb_modelo.TabIndex = 74
        '
        'Cb_Ano
        '
        Me.Cb_Ano.Location = New System.Drawing.Point(96, 52)
        Me.Cb_Ano.Name = "Cb_Ano"
        Me.Cb_Ano.Size = New System.Drawing.Size(176, 21)
        Me.Cb_Ano.TabIndex = 82
        '
        'L_AUX2
        '
        Me.L_AUX2.BackColor = System.Drawing.Color.LightGray
        Me.L_AUX2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_AUX2.ForeColor = System.Drawing.Color.Red
        Me.L_AUX2.Location = New System.Drawing.Point(224, 4)
        Me.L_AUX2.Name = "L_AUX2"
        Me.L_AUX2.Size = New System.Drawing.Size(122, 33)
        Me.L_AUX2.TabIndex = 80
        Me.L_AUX2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'L_AUX
        '
        Me.L_AUX.BackColor = System.Drawing.Color.LightGray
        Me.L_AUX.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_AUX.ForeColor = System.Drawing.Color.Red
        Me.L_AUX.Location = New System.Drawing.Point(232, 0)
        Me.L_AUX.Name = "L_AUX"
        Me.L_AUX.Size = New System.Drawing.Size(120, 40)
        Me.L_AUX.TabIndex = 79
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.Color.LightGray
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Black
        Me.Label.Location = New System.Drawing.Point(0, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(352, 40)
        Me.Label.TabIndex = 73
        Me.Label.Text = "Localizar por:"
        '
        'Localizar_veiculo_venda_usado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(456, 457)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmb_escolha)
        Me.Controls.Add(Me.BTNsair)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_X)
        Me.Controls.Add(Me.Cb_marca)
        Me.Controls.Add(Me.Cb_modelo)
        Me.Controls.Add(Me.Cb_Ano)
        Me.Controls.Add(Me.L_AUX2)
        Me.Controls.Add(Me.L_AUX)
        Me.Controls.Add(Me.Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Localizar_veiculo_venda_usado"
        Me.Text = "Localizar Veículo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Duplo Clique na Lista e Botao Sair"

    Private Sub lstvei_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstvei.DoubleClick
        Dim Comando As OleDbCommand
        Dim Dr As OleDbDataReader
        Dim cont As Integer
        Dim image_address_n_n As String

        AbrirBD()

        For cont = 0 To lstvei.Items.Count - 1
            Comando = New OleDbCommand("select * from veiculos_venda_usado where cod_vei=@cod", Conexao)
            Comando.Parameters.Add(New OleDbParameter("@cod", OleDbType.VarChar, 50))
            Comando.Parameters("@cod").Value = lstvei.FocusedItem.Text.ToString
        Next
        Try
            Dr = Comando.ExecuteReader
            If Dr.Read Then
                If buy_oldvei.Visible = True Then
                    image_address_n_n = Dr("img_vei")
                    Dim newimg As Bitmap = New Bitmap(image_address_n_n)
                    With buy_oldvei
                        .Pctemp.Image = newimg
                        .Pctemp.Show()
                        .marca_vei.Text = Dr("marca_vei")
                        .Cb_modelo.Text = Dr("modelo_vei")
                        .txtcod_vei.Text = Dr("cod_vei")
                        .txt_renavam.Text = Dr("cod_renavam_vei")
                        .cb_versao.Text = Dr("versao_vei")
                        .cb_ano.Text = Dr("ano_vei")
                        .cb_cli.Text = Dr("nome_cli")
                        .txt_codcli.Text = Dr("cod_cli")
                        .txt_quilometragem.Text = Dr("quilometragem_vei")
                        .cb_comb.Text = Dr("comb_vei")
                        .cb_cor.Text = Dr("cor_vei")
                        .txtchassi.Text = Dr("chassi_vei")
                        .txtplaca.Text = Dr("placa_vei")
                        .txtval.Text = Dr("preco_compra_vei")
                        .txttipo.Text = Dr("tipo_vei")
                        .txt_vvenda.Text = Dr("preco_venda_vei")
                        .txtpot.Text = Dr("pot_vei")
                        .cmbporta.Text = Dr("porta_vei")
                        .cb_dono.Checked = Dr("unicodono_vei")
                        .cb_abd.Checked = Dr("airbagduplo_vei")
                        .cb_alarme.Checked = Dr("alarme_vei")
                        .cb_arquente.Checked = Dr("arquente_vei")
                        .Cb_banco.Checked = Dr("bancocouro_vei")
                        .Cb_blindado.Checked = Dr("blindado_vei")
                        .cb_desembaca.Checked = Dr("desembaca_tras_vei")
                        .cb_abs.Checked = Dr("freioabs_vei")
                        .cb_limpa.Checked = Dr("limptraseiro_vei")
                        .cb_teto.Checked = Dr("tetosolar_vei")
                        .CBAC.Checked = Dr("ar_vei")
                        .CBSOM.Checked = Dr("som_vei")
                        .CBDVD.Checked = Dr("dvd_vei")
                        .CBTE.Checked = Dr("trava_vei")
                        .CBDH.Checked = Dr("direcao_vei")
                        .CBVE.Checked = Dr("vidro_vei")
                        .pc_change.Visible = True
                        .pc_del.Visible = True
                        .Excluir.Visible = False
                        .alterar_venda.Visible = False
                        .rb_alterar.Visible = True
                        .rb_excluir.Visible = True
                        .bt_obter.Visible = False
                    End With
                    Dim Controle As New Control
                    For Each Controle In buy_oldvei.Controls
                        If TypeOf Controle Is TextBox Or TypeOf Controle Is ComboBox Or TypeOf Controle Is CheckBox Then
                            Controle.Enabled = False
                        End If
                    Next
                    For Each Controle In buy_oldvei.GroupBox7.Controls
                        If TypeOf Controle Is CheckBox Then
                            Controle.Enabled = False
                        End If
                    Next
                    buy_oldvei.txtpot.Enabled = False
                End If

                If venda_veiculo_usado.Visible = True Then
                    image_address_n_n = Dr("img_vei")
                    Dim newimg As Bitmap = New Bitmap(image_address_n_n)
                    With venda_veiculo_usado
                        .Pctemp.Image = newimg
                        .Pctemp.Show()
                        .marca_vei.Text = Dr("marca_vei")
                        .Cb_modelo.Text = Dr("modelo_vei")
                        .txtcod_vei.Text = Dr("cod_vei")
                        .txt_vvenda.Text = Dr("preco_venda_vei")
                        .txtplaca.Text = Dr("placa_vei")
                        .cb_versao.Text = Dr("versao_vei")
                    End With
                End If

                If cadastro_veiculos_aluguel.Visible = True Then
                    image_address_n_n = Dr("img_vei")
                    Dim newimg As Bitmap = New Bitmap(image_address_n_n)
                    With cadastro_veiculos_aluguel
                        .Pctemp.Image = newimg
                        .Pctemp.Show()
                        .marca_vei.Text = Dr("marca_vei")
                        .Cb_modelo.Text = Dr("modelo_vei")
                        .txtcod_vei.Text = Dr("cod_vei")
                        .cb_versao.Text = Dr("versao_vei")
                        .cb_ano.Text = Dr("ano_vei")
                        .cb_comb.Text = Dr("comb_vei")
                        .cb_cor.Text = Dr("cor_vei")
                        .txtchassi.Text = Dr("chassi_vei")
                        .txtplaca.Text = Dr("placa_vei")
                        .txttipo.Text = Dr("tipo_vei")
                        .txtpot.Text = Dr("pot_vei")
                        .cmbporta.Text = Dr("porta_vei")
                        .cb_abd.Checked = Dr("airbagduplo_vei")
                        .cb_alarme.Checked = Dr("alarme_vei")
                        .cb_arquente.Checked = Dr("arquente_vei")
                        .Cb_banco.Checked = Dr("bancocouro_vei")
                        .Cb_blindado.Checked = Dr("blindado_vei")
                        .cb_desembaca.Checked = Dr("desembaca_tras_vei")
                        .cb_abs.Checked = Dr("freioabs_vei")
                        .cb_limpa.Checked = Dr("limptraseiro_vei")
                        .cb_teto.Checked = Dr("tetosolar_vei")
                        .CBAC.Checked = Dr("ar_vei")
                        .CBSOM.Checked = Dr("som_vei")
                        .CBDVD.Checked = Dr("dvd_vei")
                        .CBTE.Checked = Dr("trava_vei")
                        .CBDH.Checked = Dr("direcao_vei")
                        .CBVE.Checked = Dr("vidro_vei")
                        .txt_renavam.Text = Dr("cod_renavam_vei")
                        .bt_search.Visible = False
                        .bt_print.Visible = False
                        .lk_another.Visible = True
                        .cmbcond.Enabled = False
                        .cmbcond.Text = "D - Disponivel"
                        .bt_export.Visible = False
                        .bt_change.Visible = False
                        Dim Controle As New Control
                        For Each Controle In cadastro_veiculos_aluguel.Controls
                            If TypeOf Controle Is TextBox Or TypeOf Controle Is ComboBox Or TypeOf Controle Is CheckBox Then
                                Controle.Enabled = False
                            End If
                        Next
                        For Each Controle In cadastro_veiculos_aluguel.GroupBox7.Controls
                            If TypeOf Controle Is CheckBox Then
                                Controle.Enabled = False
                            End If
                        Next
                        .txt_diaria.Enabled = True
                        .txtpot.Enabled = False
                    End With
                End If


            End If
            FecharBD()

        Catch ex As Exception

            MsgBox(ex.Message.ToString, "ERRO", MessageBoxButtons.OK)
        Finally

            FecharBD()
        End Try

        FecharBD()
        buy_oldvei.Refresh()
        lstvei.Items.Clear()
        Dim Controlador As New Control
        For Each Controlador In Me.Controls
            If TypeOf Controlador Is ComboBox Then
                Controlador.Text = ""
            End If
        Next
        L_AUX.Text = ""
        L_AUX2.Text = ""
        Label_X.Text = ""
        Me.Close()
    End Sub

    Private Sub BTNsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNsair.Click
        Me.Close()
    End Sub

#End Region

#Region "Escolha de tipo de pesquisa e seus items..."
    Private Sub cmb_escolha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_escolha.SelectedIndexChanged

        If cmb_escolha.Text = "Modelo" Then
            Cb_Ano.Visible = False
            Cb_marca.Visible = False
            Cb_modelo.Visible = True
            L_AUX2.Visible = True
            L_AUX2.Text = "Modelo"
            L_AUX.Visible = False
            Label_X.Text = "Modelo:"
            Cb_modelo.Items.Clear()
            Cb_Ano.Items.Clear()
            Cb_Ano.Items.Clear()

            AbrirBD()
            Dim Cmd As OleDbCommand
            Dim DR As OleDbDataReader

            Cmd = New OleDbCommand("select distinct modelo_vei from veiculos_venda_usado order by modelo_vei", Conexao)

            Try
                DR = Cmd.ExecuteReader
                While DR.Read
                    Cb_modelo.Items.Add(DR("modelo_vei"))
                End While
                DR.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try
        End If

        If cmb_escolha.Text = "Marca" Then
            Cb_Ano.Visible = False
            Cb_modelo.Visible = False
            Cb_marca.Visible = True
            Cb_marca.Items.Clear()
            Cb_Ano.Items.Clear()
            Cb_modelo.Items.Clear()
            L_AUX.Visible = False
            L_AUX2.Text = "Marca"
            L_AUX2.Visible = True
            Label_X.Text = "Marca:"

            AbrirBD()
            Dim DRmarca As OleDbDataReader
            Dim Cmdmarca As OleDbCommand

            Cmdmarca = New OleDbCommand("select distinct marca_vei from veiculos_venda_usado order by marca_vei", Conexao)
            Try
                DRmarca = Cmdmarca.ExecuteReader
                While DRmarca.Read
                    Cb_marca.Items.Add(DRmarca("marca_vei"))
                End While
                DRmarca.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try
        End If




        If cmb_escolha.Text = "Ano" Then
            Cb_Ano.Visible = True
            Cb_modelo.Visible = False
            Cb_marca.Visible = False
            L_AUX2.Visible = False
            L_AUX.Text = "Ano"
            L_AUX.Visible = True
            Label_X.Text = "Ano:"
            Cb_modelo.Items.Clear()
            Cb_Ano.Items.Clear()
            Cb_marca.Items.Clear()

            AbrirBD()
            Dim DRano As OleDbDataReader
            Dim Cmdano As OleDbCommand
            Cmdano = New OleDbCommand("select distinct ano_vei from veiculos_venda_usado order by ano_vei", Conexao)
            Try
                DRano = Cmdano.ExecuteReader
                While DRano.Read
                    Cb_Ano.Items.Add(DRano("ano_vei"))
                End While
                DRano.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try
        End If
    End Sub

    Private Sub Cb_marca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_marca.SelectedIndexChanged
        lstvei.Items.Clear()

        Dim Comando As OleDbCommand
        Dim DataR As OleDbDataReader
        AbrirBD()

        Comando = New OleDbCommand("select * from veiculos_venda_usado where marca_vei='" & Cb_marca.Text & "'", Conexao)
        Try
            DataR = Comando.ExecuteReader
            While DataR.Read
                Dim lista As New ListViewItem
                lista.Text = DataR("cod_vei")
                lista.SubItems.Add(DataR("modelo_vei"))
                lista.SubItems.Add(DataR("marca_vei"))
                lista.SubItems.Add(DataR("cor_vei"))
                lista.SubItems.Add(DataR("ano_vei"))
                lista.SubItems.Add(DataR("preco_venda_vei"))
                lstvei.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DataR.Close()
            FecharBD()
        End Try
    End Sub

    Private Sub Cb_modelo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_modelo.SelectedIndexChanged
        lstvei.Items.Clear()
        Dim Comando As OleDbCommand
        Dim DRead As OleDbDataReader
        AbrirBD()

        Comando = New OleDbCommand("select * from veiculos_venda_usado where modelo_vei='" & Cb_modelo.Text & "'", Conexao)
        Try
            DRead = Comando.ExecuteReader
            While DRead.Read
                Dim lista As New ListViewItem
                lista.Text = DRead("cod_vei")
                lista.SubItems.Add(DRead("modelo_vei"))
                lista.SubItems.Add(DRead("marca_vei"))
                lista.SubItems.Add(DRead("cor_vei"))
                lista.SubItems.Add(DRead("ano_vei"))
                lista.SubItems.Add(DRead("preco_venda_vei"))
                lstvei.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DRead.Close()
            FecharBD()
        End Try
    End Sub

    Private Sub Cb_Ano_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Ano.SelectedIndexChanged
        lstvei.Items.Clear()

        Dim Comando As OleDbCommand
        Dim DataRead As OleDbDataReader
        AbrirBD()

        Comando = New OleDbCommand("select * from veiculos_venda_usado where ano_vei='" & Cb_Ano.Text.ToString & "'", Conexao)
        Try
            DataRead = Comando.ExecuteReader
            While DataRead.Read
                Dim lista As New ListViewItem
                lista.Text = DataRead("cod_vei")
                lista.SubItems.Add(DataRead("modelo_vei"))
                lista.SubItems.Add(DataRead("marca_vei"))
                lista.SubItems.Add(DataRead("cor_vei"))
                lista.SubItems.Add(DataRead("ano_vei"))
                lista.SubItems.Add(DataRead("preco_venda_vei"))
                lstvei.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DataRead.Close()
            FecharBD()
        End Try
    End Sub

#End Region

End Class
