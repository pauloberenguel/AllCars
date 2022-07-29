Imports System.Data.OleDb

Public Class recebimentos
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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lista_cli As System.Windows.Forms.ListView
    Friend WithEvents txt_nomecli As System.Windows.Forms.TextBox
    Friend WithEvents txt_codcli As System.Windows.Forms.TextBox
    Friend WithEvents txt_quantiaapagar As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_qntientrada As System.Windows.Forms.TextBox
    Friend WithEvents qnti_parcela As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_valorparcela As System.Windows.Forms.TextBox
    Friend WithEvents rb_parcelado As System.Windows.Forms.RadioButton
    Friend WithEvents rb_avista As System.Windows.Forms.RadioButton
    Friend WithEvents grupo_parcelado As System.Windows.Forms.GroupBox
    Friend WithEvents notas As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents cb_print As System.Windows.Forms.Button
    Friend WithEvents efetuar_venda As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(recebimentos))
        Me.lista_cli = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.txt_nomecli = New System.Windows.Forms.TextBox
        Me.txt_codcli = New System.Windows.Forms.TextBox
        Me.txt_quantiaapagar = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_qntientrada = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.rb_parcelado = New System.Windows.Forms.RadioButton
        Me.rb_avista = New System.Windows.Forms.RadioButton
        Me.qnti_parcela = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_valorparcela = New System.Windows.Forms.TextBox
        Me.notas = New System.Windows.Forms.RichTextBox
        Me.grupo_parcelado = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.cb_print = New System.Windows.Forms.Button
        Me.efetuar_venda = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        CType(Me.qnti_parcela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_parcelado.SuspendLayout()
        Me.SuspendLayout()
        '
        'lista_cli
        '
        Me.lista_cli.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader1})
        Me.lista_cli.Location = New System.Drawing.Point(0, 52)
        Me.lista_cli.MultiSelect = False
        Me.lista_cli.Name = "lista_cli"
        Me.lista_cli.Size = New System.Drawing.Size(136, 352)
        Me.lista_cli.TabIndex = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nome"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        '
        'txt_nomecli
        '
        Me.txt_nomecli.Location = New System.Drawing.Point(288, 89)
        Me.txt_nomecli.Name = "txt_nomecli"
        Me.txt_nomecli.ReadOnly = True
        Me.txt_nomecli.TabIndex = 2
        Me.txt_nomecli.Text = ""
        '
        'txt_codcli
        '
        Me.txt_codcli.Location = New System.Drawing.Point(288, 44)
        Me.txt_codcli.Name = "txt_codcli"
        Me.txt_codcli.ReadOnly = True
        Me.txt_codcli.Size = New System.Drawing.Size(48, 19)
        Me.txt_codcli.TabIndex = 3
        Me.txt_codcli.Text = ""
        '
        'txt_quantiaapagar
        '
        Me.txt_quantiaapagar.Location = New System.Drawing.Point(288, 133)
        Me.txt_quantiaapagar.Name = "txt_quantiaapagar"
        Me.txt_quantiaapagar.ReadOnly = True
        Me.txt_quantiaapagar.TabIndex = 4
        Me.txt_quantiaapagar.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Beige
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ENTRADA"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(152, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "VALOR:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Beige
        Me.Label2.Location = New System.Drawing.Point(152, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nome do Cliente"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Beige
        Me.Label4.Location = New System.Drawing.Point(152, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Código do Cliente"
        '
        'txt_qntientrada
        '
        Me.txt_qntientrada.Location = New System.Drawing.Point(96, 22)
        Me.txt_qntientrada.Name = "txt_qntientrada"
        Me.txt_qntientrada.TabIndex = 10
        Me.txt_qntientrada.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Beige
        Me.Label6.Location = New System.Drawing.Point(8, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 265
        Me.Label6.Text = "Parcelas"
        '
        'rb_parcelado
        '
        Me.rb_parcelado.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rb_parcelado.ForeColor = System.Drawing.Color.Beige
        Me.rb_parcelado.Location = New System.Drawing.Point(304, 170)
        Me.rb_parcelado.Name = "rb_parcelado"
        Me.rb_parcelado.Size = New System.Drawing.Size(104, 20)
        Me.rb_parcelado.TabIndex = 267
        Me.rb_parcelado.Text = "PARCELADO"
        '
        'rb_avista
        '
        Me.rb_avista.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rb_avista.ForeColor = System.Drawing.Color.Beige
        Me.rb_avista.Location = New System.Drawing.Point(184, 170)
        Me.rb_avista.Name = "rb_avista"
        Me.rb_avista.Size = New System.Drawing.Size(88, 20)
        Me.rb_avista.TabIndex = 268
        Me.rb_avista.Text = "A VISTA"
        '
        'qnti_parcela
        '
        Me.qnti_parcela.Location = New System.Drawing.Point(96, 56)
        Me.qnti_parcela.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.qnti_parcela.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.qnti_parcela.Name = "qnti_parcela"
        Me.qnti_parcela.Size = New System.Drawing.Size(40, 19)
        Me.qnti_parcela.TabIndex = 269
        Me.qnti_parcela.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Beige
        Me.Label7.Location = New System.Drawing.Point(144, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 16)
        Me.Label7.TabIndex = 270
        Me.Label7.Text = "X"
        '
        'txt_valorparcela
        '
        Me.txt_valorparcela.Location = New System.Drawing.Point(160, 56)
        Me.txt_valorparcela.Name = "txt_valorparcela"
        Me.txt_valorparcela.ReadOnly = True
        Me.txt_valorparcela.TabIndex = 271
        Me.txt_valorparcela.Text = ""
        '
        'notas
        '
        Me.notas.Location = New System.Drawing.Point(240, 207)
        Me.notas.Name = "notas"
        Me.notas.Size = New System.Drawing.Size(136, 64)
        Me.notas.TabIndex = 272
        Me.notas.Text = ""
        '
        'grupo_parcelado
        '
        Me.grupo_parcelado.Controls.Add(Me.Label8)
        Me.grupo_parcelado.Controls.Add(Me.txt_valorparcela)
        Me.grupo_parcelado.Controls.Add(Me.Label7)
        Me.grupo_parcelado.Controls.Add(Me.txt_qntientrada)
        Me.grupo_parcelado.Controls.Add(Me.qnti_parcela)
        Me.grupo_parcelado.Controls.Add(Me.Label6)
        Me.grupo_parcelado.Controls.Add(Me.Label3)
        Me.grupo_parcelado.Location = New System.Drawing.Point(160, 281)
        Me.grupo_parcelado.Name = "grupo_parcelado"
        Me.grupo_parcelado.Size = New System.Drawing.Size(280, 96)
        Me.grupo_parcelado.TabIndex = 273
        Me.grupo_parcelado.TabStop = False
        Me.grupo_parcelado.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Beige
        Me.Label8.Location = New System.Drawing.Point(8, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 15)
        Me.Label8.TabIndex = 272
        Me.Label8.Text = "Contada após 30 dias"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Beige
        Me.Label5.Location = New System.Drawing.Point(152, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 272
        Me.Label5.Text = "Notas:"
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.Color.LightGray
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Black
        Me.Label.Location = New System.Drawing.Point(0, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(256, 37)
        Me.Label.TabIndex = 274
        Me.Label.Text = "Recebimentos"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(304, 473)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 279
        Me.Label10.Text = "Voltar"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(184, 473)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 278
        Me.Label9.Text = "Imprimir"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(64, 473)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 277
        Me.Label11.Text = "Receber pgto"
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
        Me.Button7.Location = New System.Drawing.Point(296, 414)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 55)
        Me.Button7.TabIndex = 275
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
        Me.cb_print.Location = New System.Drawing.Point(184, 414)
        Me.cb_print.Name = "cb_print"
        Me.cb_print.Size = New System.Drawing.Size(56, 55)
        Me.cb_print.TabIndex = 274
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
        Me.efetuar_venda.Location = New System.Drawing.Point(72, 414)
        Me.efetuar_venda.Name = "efetuar_venda"
        Me.efetuar_venda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.efetuar_venda.Size = New System.Drawing.Size(56, 55)
        Me.efetuar_venda.TabIndex = 273
        Me.efetuar_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(64, 406)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(304, 81)
        Me.Label20.TabIndex = 276
        '
        'recebimentos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(448, 485)
        Me.ControlBox = False
        Me.Controls.Add(Me.efetuar_venda)
        Me.Controls.Add(Me.cb_print)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.grupo_parcelado)
        Me.Controls.Add(Me.notas)
        Me.Controls.Add(Me.rb_parcelado)
        Me.Controls.Add(Me.txt_quantiaapagar)
        Me.Controls.Add(Me.txt_codcli)
        Me.Controls.Add(Me.txt_nomecli)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lista_cli)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rb_avista)
        Me.Controls.Add(Me.Label20)
        Me.Name = "recebimentos"
        Me.Text = "Recebimentos"
        CType(Me.qnti_parcela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_parcelado.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub bt_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        financas.Visible = True
    End Sub


    Private Sub rb_parcelado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_parcelado.CheckedChanged
        grupo_parcelado.Visible = True
    End Sub

    Private Sub txt_qntientrada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_qntientrada.TextChanged
        If txt_quantiaapagar.Text = "" Or txt_qntientrada.Text = "" Or qnti_parcela.Text = "" Then
            Exit Sub
        Else
            Dim a As Double = Val(txt_quantiaapagar.Text) - Val(txt_qntientrada.Text)
            Dim b As Double = Val(qnti_parcela.Value)
            Dim c As Double = Val(a / b)
            txt_valorparcela.Text = c.ToString
        End If
    End Sub


    Private Sub qnti_parcela_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qnti_parcela.ValueChanged
        If txt_quantiaapagar.Text = "" Or txt_qntientrada.Text = "" Or qnti_parcela.Text = "" Then
            Exit Sub
        Else
            Dim a As Double = Val(txt_quantiaapagar.Text) - Val(txt_qntientrada.Text)
            Dim b As Double = Val(qnti_parcela.Value)
            Dim c As Double = Val(a / b)
            txt_valorparcela.Text = c.ToString
        End If
    End Sub

    Private Sub rb_avista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_avista.CheckedChanged
        grupo_parcelado.Visible = False
        txt_qntientrada.Text = txt_quantiaapagar.Text
        txt_valorparcela.Text = txt_quantiaapagar.Text
        qnti_parcela.Text = "0"
    End Sub


    Private Sub efetuar_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles efetuar_venda.Click
        Dim situacao As String
        If Val(qnti_parcela.Text) = 0 Then
            situacao = "Pagando"
        ElseIf Val(qnti_parcela.Text) > 0 Then
            situacao = "Pago"
        End If
        Dim comando As OleDbCommand
        comando = New OleDbCommand("insert into recebimentos(cod_cli,nome_cli,valor_total,pago_a_vista,parcelas,qnt_kda_parcela,notas,data_recebimento,parcelas_pagas,situacao_parcelamento) values (@cod_cli,@nome_cli,@valor_total,@pago_a_vista,@parcelas,@qnt_kda_parcela,@notas,@data_recebimento,@parcelas_pagas,@situacao_parcelamento)", Conexao)
        With comando
            .Parameters.Add(New OleDbParameter("@cod_cli", OleDbType.Numeric, 50))
            .Parameters("@cod_cli").Value = txt_codcli.Text
            .Parameters.Add(New OleDbParameter("@nome_cli", OleDbType.VarChar, 50))
            .Parameters("@nome_cli").Value = txt_nomecli.Text
            .Parameters.Add(New OleDbParameter("@valor_total", OleDbType.Numeric, 50))
            .Parameters("@valor_total").Value = txt_quantiaapagar.Text
            .Parameters.Add(New OleDbParameter("@pago_a_vista", OleDbType.Numeric, 50))
            .Parameters("@pago_a_vista").Value = txt_qntientrada.Text
            .Parameters.Add(New OleDbParameter("@parcelas", OleDbType.Numeric, 50))
            .Parameters("@parcelas").Value = qnti_parcela.Text
            .Parameters.Add(New OleDbParameter("@qnt_kda_parcela", OleDbType.Numeric, 50))
            .Parameters("@qnt_kda_parcela").Value = txt_valorparcela.Text
            .Parameters.Add(New OleDbParameter("@notas", OleDbType.VarChar, 50))
            .Parameters("@notas").Value = notas.Text
            .Parameters.Add(New OleDbParameter("@data_recebimento", OleDbType.VarChar, 50))
            .Parameters("@data_recebimento").Value = System.DateTime.Today.Date.ToShortDateString
            .Parameters.Add(New OleDbParameter("@parcelas_pagas", OleDbType.VarChar, 50))
            .Parameters("@parcelas_pagas").Value = "0"
            .Parameters.Add(New OleDbParameter("@situacao_parcelamento", OleDbType.VarChar, 50))
            .Parameters("@situacao_parcelamento").Value = situacao
        End With
        AbrirBD()
        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Recebimento registrado com sucesso", "Pagamento efetuado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3, MessageBoxOptions.DefaultDesktopOnly)
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try

        comando = New OleDbCommand("Update clientes set saldo_cli='0',situa_cli='Normal' where cod_cli=" & txt_codcli.Text, Conexao)
        AbrirBD()
        Try
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try
        lista_cli.Items.Clear()

        Dim dr As OleDbDataReader
        comando = New OleDbCommand("select * from clientes where situa_cli='A pagar'", Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            While dr.Read
                Dim lista As New ListViewItem
                lista.Text = dr("nome_cli")
                lista.SubItems.Add(dr("cod_cli"))
                lista_cli.Items.Add(lista)
            End While
        Catch ex As Exception
            MsgBox("Erro")
        Finally
            FecharBD()
        End Try

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Visible = False
        financas.Visible = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        cadastrocli_alu.Visible = True

    End Sub

    Private Sub lista_cli_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lista_cli.DoubleClick
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        comando = New OleDbCommand("select * from clientes where cod_cli=" & lista_cli.FocusedItem.SubItems(1).Text.ToString, Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            If dr.Read Then
                txt_nomecli.Text = dr("nome_cli")
                txt_codcli.Text = dr("cod_cli")
                txt_quantiaapagar.Text = Val(dr("saldo_cli") * -1)
            End If
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub recebimentos_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        comando = New OleDbCommand("select * from clientes where situa_cli='A pagar'", Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            While dr.Read
                Dim lista As New ListViewItem
                lista.Text = dr("nome_cli")
                lista.SubItems.Add(dr("cod_cli"))
                lista_cli.Items.Add(lista)
            End While
        Catch ex As Exception
            MsgBox("Erro")
        Finally
            FecharBD()
        End Try
    End Sub
End Class
