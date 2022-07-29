Imports System.Data.OleDb

Public Class Localizar_Veiculo
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
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvei As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents COMBOX As System.Windows.Forms.ComboBox
    Friend WithEvents BTNsair As System.Windows.Forms.Button
    Friend WithEvents L_AUX As System.Windows.Forms.Label
    Friend WithEvents L_AUX2 As System.Windows.Forms.Label
    Friend WithEvents Label_X As System.Windows.Forms.Label
    Friend WithEvents Cb_cond As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Cor As System.Windows.Forms.ComboBox
    Private WithEvents cmb_escolha As System.Windows.Forms.ComboBox
    Friend WithEvents cb_marca As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Localizar_Veiculo))
        Me.Label_X = New System.Windows.Forms.Label
        Me.Label = New System.Windows.Forms.Label
        Me.COMBOX = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lstvei = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.BTNsair = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.L_AUX = New System.Windows.Forms.Label
        Me.L_AUX2 = New System.Windows.Forms.Label
        Me.Cb_cond = New System.Windows.Forms.ComboBox
        Me.Cb_Cor = New System.Windows.Forms.ComboBox
        Me.cmb_escolha = New System.Windows.Forms.ComboBox
        Me.cb_marca = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_X
        '
        Me.Label_X.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_X.ForeColor = System.Drawing.Color.Beige
        Me.Label_X.Location = New System.Drawing.Point(16, 56)
        Me.Label_X.Name = "Label_X"
        Me.Label_X.Size = New System.Drawing.Size(80, 23)
        Me.Label_X.TabIndex = 43
        Me.Label_X.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.Color.LightGray
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Black
        Me.Label.Location = New System.Drawing.Point(0, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(360, 40)
        Me.Label.TabIndex = 44
        Me.Label.Text = "Localizar por:"
        '
        'COMBOX
        '
        Me.COMBOX.Location = New System.Drawing.Point(96, 56)
        Me.COMBOX.Name = "COMBOX"
        Me.COMBOX.Size = New System.Drawing.Size(176, 21)
        Me.COMBOX.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstvei)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox1.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 280)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veículos"
        '
        'lstvei
        '
        Me.lstvei.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstvei.FullRowSelect = True
        Me.lstvei.GridLines = True
        Me.lstvei.Location = New System.Drawing.Point(8, 24)
        Me.lstvei.Name = "lstvei"
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
        Me.ColumnHeader1.Width = 62
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tipo"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Condição"
        Me.ColumnHeader3.Width = 103
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cor"
        Me.ColumnHeader4.Width = 81
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Marca"
        Me.ColumnHeader5.Width = 94
        '
        'BTNsair
        '
        Me.BTNsair.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNsair.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNsair.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BTNsair.Image = CType(resources.GetObject("BTNsair.Image"), System.Drawing.Image)
        Me.BTNsair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNsair.Location = New System.Drawing.Point(191, 387)
        Me.BTNsair.Name = "BTNsair"
        Me.BTNsair.Size = New System.Drawing.Size(80, 54)
        Me.BTNsair.TabIndex = 47
        Me.BTNsair.Text = "Voltar"
        Me.BTNsair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(183, 379)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 70)
        Me.Label4.TabIndex = 48
        '
        'L_AUX
        '
        Me.L_AUX.BackColor = System.Drawing.Color.LightGray
        Me.L_AUX.Font = New System.Drawing.Font("Arial", 24.5!, System.Drawing.FontStyle.Bold)
        Me.L_AUX.ForeColor = System.Drawing.Color.Red
        Me.L_AUX.Location = New System.Drawing.Point(228, 0)
        Me.L_AUX.Name = "L_AUX"
        Me.L_AUX.Size = New System.Drawing.Size(135, 40)
        Me.L_AUX.TabIndex = 50
        '
        'L_AUX2
        '
        Me.L_AUX2.BackColor = System.Drawing.Color.LightGray
        Me.L_AUX2.Font = New System.Drawing.Font("Arial", 18.25!, System.Drawing.FontStyle.Bold)
        Me.L_AUX2.ForeColor = System.Drawing.Color.Red
        Me.L_AUX2.Location = New System.Drawing.Point(227, 5)
        Me.L_AUX2.Name = "L_AUX2"
        Me.L_AUX2.Size = New System.Drawing.Size(132, 33)
        Me.L_AUX2.TabIndex = 51
        Me.L_AUX2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cb_cond
        '
        Me.Cb_cond.Items.AddRange(New Object() {"D - Disponivel", "A - Alugado"})
        Me.Cb_cond.Location = New System.Drawing.Point(97, 56)
        Me.Cb_cond.Name = "Cb_cond"
        Me.Cb_cond.Size = New System.Drawing.Size(175, 21)
        Me.Cb_cond.TabIndex = 52
        '
        'Cb_Cor
        '
        Me.Cb_Cor.Location = New System.Drawing.Point(96, 56)
        Me.Cb_Cor.Name = "Cb_Cor"
        Me.Cb_Cor.Size = New System.Drawing.Size(176, 21)
        Me.Cb_Cor.TabIndex = 53
        '
        'cmb_escolha
        '
        Me.cmb_escolha.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_escolha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_escolha.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_escolha.ItemHeight = 16
        Me.cmb_escolha.Items.AddRange(New Object() {"Modelo", "Marca", "Condição", "Cor"})
        Me.cmb_escolha.Location = New System.Drawing.Point(368, 8)
        Me.cmb_escolha.Name = "cmb_escolha"
        Me.cmb_escolha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmb_escolha.Size = New System.Drawing.Size(88, 24)
        Me.cmb_escolha.TabIndex = 49
        '
        'cb_marca
        '
        Me.cb_marca.Location = New System.Drawing.Point(96, 56)
        Me.cb_marca.Name = "cb_marca"
        Me.cb_marca.Size = New System.Drawing.Size(177, 21)
        Me.cb_marca.TabIndex = 54
        '
        'Localizar_Veiculo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(454, 458)
        Me.ControlBox = False
        Me.Controls.Add(Me.L_AUX)
        Me.Controls.Add(Me.cmb_escolha)
        Me.Controls.Add(Me.BTNsair)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_X)
        Me.Controls.Add(Me.Cb_cond)
        Me.Controls.Add(Me.COMBOX)
        Me.Controls.Add(Me.Cb_Cor)
        Me.Controls.Add(Me.cb_marca)
        Me.Controls.Add(Me.L_AUX2)
        Me.Controls.Add(Me.Label)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Localizar_Veiculo"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Localizar Veículo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Localizar_Veiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        L_AUX.Visible = False
        L_AUX2.Visible = False
        COMBOX.Visible = False
        Cb_cond.Visible = False
        Cb_Cor.Visible = False
        COMBOX.Items.Clear()
        Cb_Cor.Items.Clear()
        cmb_escolha.Text = ""




    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvei.DoubleClick
        Dim Comando As OleDbCommand
        Dim Dr As OleDbDataReader
        Dim cont As Integer
        Dim image_address_n_n As String

        AbrirBD()

        For cont = 0 To lstvei.Items.Count - 1
            Comando = New OleDbCommand("select * from veiculos_alu where cod_vei=@cod", Conexao)
            Comando.Parameters.Add(New OleDbParameter("@cod", OleDbType.VarChar, 50))
            Comando.Parameters("@cod").Value = lstvei.FocusedItem.Text.ToString
        Next
        Try
            Dr = Comando.ExecuteReader
            If Dr.Read Then

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
                        .cmbcond.Text = Dr("estado_vei")
                        .bt_search.Visible = False
                        .bt_print.Visible = False
                        .cmbcond.Enabled = False
                        .bt_change.Visible = False
                        .txtpot.Enabled = False
                        .lk_another.Visible = False
                        .bt_imports.Visible = False
                        .bt_change.Visible = False
                        .bt_export.Visible = False
                        .lk_export.Visible = True
                        .bt_export2.Visible = True
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
                        .txtpot.Enabled = False
                    End With
                End If

                If Efetua_alu.Visible = True Then
                    image_address_n_n = Dr("img_vei")
                    Dim newimg As Bitmap = New Bitmap(image_address_n_n)
                    With Efetua_alu
                        .txt_cod_vei.Text = Dr("cod_vei")
                        .v_diaria.Text = Dr("diaria_vei")
                        .placa_vei.Text = Dr("placa_vei")
                        .txt_modelo.Text = Dr("modelo_vei")
                        .txt_sit.Text = Dr("estado_vei")
                        .pc_thumb.Image = newimg
                        .pc_thumb.Show()
                    End With


                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
        Me.Close()
        lstvei.Items.Clear()
        COMBOX.Text = ""
    End Sub

    Private Sub BTNsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNsair.Click
        lstvei.Items.Clear()
        cmb_escolha.Text = ""
        Me.Close()
    End Sub

    Private Sub cmb_escolha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_escolha.SelectedIndexChanged
        If cmb_escolha.Text = "Marca" Then
            Cb_Cor.Visible = False
            Cb_cond.Visible = False
            COMBOX.Visible = False
            cb_marca.Visible = True
            cb_marca.Items.Clear()
            COMBOX.Items.Clear()
            Cb_Cor.Items.Clear()
            L_AUX2.Visible = False
            L_AUX.Text = "Marca"
            L_AUX.Visible = True
            Label_X.Text = "Marca:"
            Dim CmdMarca As OleDbCommand
            Dim DRMarca As OleDbDataReader
            AbrirBD()

            CmdMarca = New OleDbCommand("select distinct marca_vei from veiculos_alu order by marca_vei", Conexao)

            Try
                DRMarca = CmdMarca.ExecuteReader
                While DRMarca.Read
                    cb_marca.Items.Add(DRMarca("marca_vei"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try


        End If

        If cmb_escolha.Text = "Modelo" Then
            Cb_Cor.Visible = False
            Cb_cond.Visible = False
            COMBOX.Visible = True
            cb_marca.Visible = False

            L_AUX2.Visible = False
            L_AUX.Text = "Modelo"
            L_AUX.Visible = True
            Label_X.Text = "Modelo:"
            cb_marca.Items.Clear()
            COMBOX.Items.Clear()
            Cb_Cor.Items.Clear()

            Dim CmdNOME As OleDbCommand
            Dim DRNOME As OleDbDataReader
            AbrirBD()

            CmdNOME = New OleDbCommand("select distinct modelo_vei from veiculos_alu order by modelo_vei", Conexao)

            Try
                DRNOME = CmdNOME.ExecuteReader
                While DRNOME.Read
                    COMBOX.Items.Add(DRNOME("modelo_vei"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try

        End If

        If cmb_escolha.Text = "Condição" Then
            cb_marca.Items.Clear()
            COMBOX.Items.Clear()
            Cb_Cor.Items.Clear()
            Cb_Cor.Visible = False
            COMBOX.Visible = False
            Cb_cond.Visible = True
            cb_marca.Visible = False

            L_AUX.Visible = False
            L_AUX2.Text = "Condição"
            L_AUX2.Visible = True
            Label_X.Text = "Condição:"
        End If




        If cmb_escolha.Text = "Cor" Then
            Cb_Cor.Visible = True
            COMBOX.Visible = False
            Cb_cond.Visible = False
            L_AUX2.Visible = False
            cb_marca.Visible = False
            L_AUX.Text = "Cor"
            L_AUX.Visible = True
            Label_X.Text = "Cor:"
            cb_marca.Items.Clear()
            COMBOX.Items.Clear()
            Cb_Cor.Items.Clear()

            Dim DRCOR As OleDbDataReader
            Dim CmdCOR As OleDbCommand
            AbrirBD()
            CmdCOR = New OleDbCommand("select distinct cor_vei from veiculos_alu order by cor_vei", Conexao)
            Try
                DRCOR = CmdCOR.ExecuteReader
                While DRCOR.Read
                    Cb_Cor.Items.Add(DRCOR("cor_vei"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try
        End If


    End Sub

    Private Sub COMBOX_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMBOX.SelectedIndexChanged
        lstvei.Items.Clear()

        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Conexao.Open()
        Comando = New OleDbCommand("select * from veiculos_alu where modelo_vei='" & COMBOX.Text & "'", Conexao)

        Try
            DR = Comando.ExecuteReader
            While DR.Read
                Dim lista As New ListViewItem
                lista.Text = DR("cod_vei")
                lista.SubItems.Add(DR("modelo_vei"))
                lista.SubItems.Add(DR("tipo_vei"))
                lista.SubItems.Add(DR("estado_vei"))
                lista.SubItems.Add(DR("cor_vei"))
                lista.SubItems.Add(DR("marca_vei"))
                lstvei.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try

    End Sub

    Private Sub Cb_Cor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Cor.SelectedIndexChanged
        lstvei.Items.Clear()
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Conexao.Open()
        Comando = New OleDbCommand("select * from veiculos_alu where cor_vei='" & Cb_Cor.Text & "'", Conexao)
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                Dim lista As New ListViewItem
                lista.Text = DR("cod_vei")
                lista.SubItems.Add(DR("modelo_vei"))
                lista.SubItems.Add(DR("tipo_vei"))
                lista.SubItems.Add(DR("estado_vei"))
                lista.SubItems.Add(DR("cor_vei"))
                lista.SubItems.Add(DR("marca_vei"))
                lstvei.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try

    End Sub

    Private Sub Cb_cond_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cb_cond.SelectedIndexChanged
        lstvei.Items.Clear()
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Conexao.Open()

        Comando = New OleDbCommand("select * from veiculos_alu where estado_vei='" & Cb_cond.Text & "'", Conexao)
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                Dim lista As New ListViewItem
                lista.Text = DR("cod_vei")
                lista.SubItems.Add(DR("modelo_vei"))
                lista.SubItems.Add(DR("tipo_vei"))
                lista.SubItems.Add(DR("estado_vei"))
                lista.SubItems.Add(DR("cor_vei"))
                lista.SubItems.Add(DR("marca_vei"))
                lstvei.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub cb_marca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_marca.SelectedIndexChanged
        lstvei.Items.Clear()
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Conexao.Open()

        Comando = New OleDbCommand("select * from veiculos_alu where marca_vei='" & cb_marca.Text & "'", Conexao)
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                Dim lista As New ListViewItem
                lista.Text = DR("cod_vei")
                lista.SubItems.Add(DR("modelo_vei"))
                lista.SubItems.Add(DR("tipo_vei"))
                lista.SubItems.Add(DR("estado_vei"))
                lista.SubItems.Add(DR("cor_vei"))
                lista.SubItems.Add(DR("marca_vei"))
                lstvei.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub lstvei_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvei.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
