Imports System.Data.OleDb

Public Class consultas
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
    Friend WithEvents bt_back As System.Windows.Forms.Button
    Friend WithEvents LIST As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents data_de As System.Windows.Forms.DateTimePicker
    Friend WithEvents data_ate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_consultapagamentos As System.Windows.Forms.Button
    Friend WithEvents rb_pagamentos As System.Windows.Forms.RadioButton
    Friend WithEvents rb_recebimentos As System.Windows.Forms.RadioButton
    Friend WithEvents bt_consulrecebi As System.Windows.Forms.Button
    Friend WithEvents bt_verificavendasprod As System.Windows.Forms.Button
    Friend WithEvents bt_consultacomprasprod As System.Windows.Forms.Button
    Friend WithEvents rb_vendavei As System.Windows.Forms.RadioButton
    Friend WithEvents rb_comprasvei As System.Windows.Forms.RadioButton
    Friend WithEvents rb_vendaProd As System.Windows.Forms.RadioButton
    Friend WithEvents rb_comprasprod As System.Windows.Forms.RadioButton
    Friend WithEvents bt_verificavendasvei As System.Windows.Forms.Button
    Friend WithEvents bt_consultacomprasvei As System.Windows.Forms.Button
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(consultas))
        Me.LIST = New System.Windows.Forms.ListView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bt_back = New System.Windows.Forms.Button
        Me.data_de = New System.Windows.Forms.DateTimePicker
        Me.data_ate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.bt_verificavendasprod = New System.Windows.Forms.Button
        Me.bt_consultacomprasprod = New System.Windows.Forms.Button
        Me.bt_consultapagamentos = New System.Windows.Forms.Button
        Me.bt_consulrecebi = New System.Windows.Forms.Button
        Me.rb_vendavei = New System.Windows.Forms.RadioButton
        Me.rb_comprasvei = New System.Windows.Forms.RadioButton
        Me.rb_pagamentos = New System.Windows.Forms.RadioButton
        Me.rb_recebimentos = New System.Windows.Forms.RadioButton
        Me.rb_vendaProd = New System.Windows.Forms.RadioButton
        Me.rb_comprasprod = New System.Windows.Forms.RadioButton
        Me.bt_verificavendasvei = New System.Windows.Forms.Button
        Me.bt_consultacomprasvei = New System.Windows.Forms.Button
        Me.Label = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LIST
        '
        Me.LIST.BackColor = System.Drawing.Color.DarkGray
        Me.LIST.FullRowSelect = True
        Me.LIST.GridLines = True
        Me.LIST.Location = New System.Drawing.Point(160, 8)
        Me.LIST.Name = "LIST"
        Me.LIST.Size = New System.Drawing.Size(328, 420)
        Me.LIST.StateImageList = Me.ImageList1
        Me.LIST.TabIndex = 3
        Me.LIST.View = System.Windows.Forms.View.Details
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'bt_back
        '
        Me.bt_back.BackColor = System.Drawing.Color.White
        Me.bt_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_back.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_back.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_back.Image = CType(resources.GetObject("bt_back.Image"), System.Drawing.Image)
        Me.bt_back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_back.Location = New System.Drawing.Point(-8, 360)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(65, 75)
        Me.bt_back.TabIndex = 265
        Me.bt_back.Text = "Voltar"
        Me.bt_back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'data_de
        '
        Me.data_de.Location = New System.Drawing.Point(40, 248)
        Me.data_de.Name = "data_de"
        Me.data_de.Size = New System.Drawing.Size(112, 19)
        Me.data_de.TabIndex = 270
        '
        'data_ate
        '
        Me.data_ate.Location = New System.Drawing.Point(40, 288)
        Me.data_ate.Name = "data_ate"
        Me.data_ate.Size = New System.Drawing.Size(112, 19)
        Me.data_ate.TabIndex = 271
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 272
        Me.Label1.Text = "De"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 273
        Me.Label2.Text = "Ate"
        '
        'bt_verificavendasprod
        '
        Me.bt_verificavendasprod.BackColor = System.Drawing.Color.Black
        Me.bt_verificavendasprod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_verificavendasprod.Location = New System.Drawing.Point(64, 352)
        Me.bt_verificavendasprod.Name = "bt_verificavendasprod"
        Me.bt_verificavendasprod.Size = New System.Drawing.Size(88, 40)
        Me.bt_verificavendasprod.TabIndex = 274
        Me.bt_verificavendasprod.Text = "Consultar Vendas de produtos"
        Me.bt_verificavendasprod.Visible = False
        '
        'bt_consultacomprasprod
        '
        Me.bt_consultacomprasprod.BackColor = System.Drawing.Color.Black
        Me.bt_consultacomprasprod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_consultacomprasprod.Location = New System.Drawing.Point(64, 352)
        Me.bt_consultacomprasprod.Name = "bt_consultacomprasprod"
        Me.bt_consultacomprasprod.Size = New System.Drawing.Size(88, 40)
        Me.bt_consultacomprasprod.TabIndex = 275
        Me.bt_consultacomprasprod.Text = "Consultar Compras de Produtos"
        Me.bt_consultacomprasprod.Visible = False
        '
        'bt_consultapagamentos
        '
        Me.bt_consultapagamentos.BackColor = System.Drawing.Color.Black
        Me.bt_consultapagamentos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_consultapagamentos.Location = New System.Drawing.Point(64, 352)
        Me.bt_consultapagamentos.Name = "bt_consultapagamentos"
        Me.bt_consultapagamentos.Size = New System.Drawing.Size(88, 40)
        Me.bt_consultapagamentos.TabIndex = 276
        Me.bt_consultapagamentos.Text = "Consultar Pagamentos"
        Me.bt_consultapagamentos.Visible = False
        '
        'bt_consulrecebi
        '
        Me.bt_consulrecebi.BackColor = System.Drawing.Color.Black
        Me.bt_consulrecebi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_consulrecebi.Location = New System.Drawing.Point(64, 352)
        Me.bt_consulrecebi.Name = "bt_consulrecebi"
        Me.bt_consulrecebi.Size = New System.Drawing.Size(88, 40)
        Me.bt_consulrecebi.TabIndex = 277
        Me.bt_consulrecebi.Text = "Consultar Recebimentos"
        Me.bt_consulrecebi.Visible = False
        '
        'rb_vendavei
        '
        Me.rb_vendavei.BackColor = System.Drawing.Color.SteelBlue
        Me.rb_vendavei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_vendavei.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_vendavei.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_vendavei.ForeColor = System.Drawing.Color.OrangeRed
        Me.rb_vendavei.Location = New System.Drawing.Point(16, 48)
        Me.rb_vendavei.Name = "rb_vendavei"
        Me.rb_vendavei.Size = New System.Drawing.Size(128, 32)
        Me.rb_vendavei.TabIndex = 278
        Me.rb_vendavei.Text = "Vendas de  Veiculos"
        '
        'rb_comprasvei
        '
        Me.rb_comprasvei.BackColor = System.Drawing.Color.SteelBlue
        Me.rb_comprasvei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_comprasvei.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_comprasvei.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_comprasvei.ForeColor = System.Drawing.Color.OrangeRed
        Me.rb_comprasvei.Location = New System.Drawing.Point(16, 112)
        Me.rb_comprasvei.Name = "rb_comprasvei"
        Me.rb_comprasvei.Size = New System.Drawing.Size(128, 32)
        Me.rb_comprasvei.TabIndex = 279
        Me.rb_comprasvei.Text = "Compras de Veiculos"
        '
        'rb_pagamentos
        '
        Me.rb_pagamentos.BackColor = System.Drawing.Color.SteelBlue
        Me.rb_pagamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_pagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_pagamentos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_pagamentos.ForeColor = System.Drawing.Color.OrangeRed
        Me.rb_pagamentos.Location = New System.Drawing.Point(16, 176)
        Me.rb_pagamentos.Name = "rb_pagamentos"
        Me.rb_pagamentos.Size = New System.Drawing.Size(128, 24)
        Me.rb_pagamentos.TabIndex = 280
        Me.rb_pagamentos.Text = "Pagamentos"
        '
        'rb_recebimentos
        '
        Me.rb_recebimentos.BackColor = System.Drawing.Color.SteelBlue
        Me.rb_recebimentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_recebimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_recebimentos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_recebimentos.ForeColor = System.Drawing.Color.OrangeRed
        Me.rb_recebimentos.Location = New System.Drawing.Point(16, 200)
        Me.rb_recebimentos.Name = "rb_recebimentos"
        Me.rb_recebimentos.Size = New System.Drawing.Size(128, 24)
        Me.rb_recebimentos.TabIndex = 281
        Me.rb_recebimentos.Text = "Recebimentos"
        '
        'rb_vendaProd
        '
        Me.rb_vendaProd.BackColor = System.Drawing.Color.SteelBlue
        Me.rb_vendaProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_vendaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_vendaProd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_vendaProd.ForeColor = System.Drawing.Color.OrangeRed
        Me.rb_vendaProd.Location = New System.Drawing.Point(16, 80)
        Me.rb_vendaProd.Name = "rb_vendaProd"
        Me.rb_vendaProd.Size = New System.Drawing.Size(128, 32)
        Me.rb_vendaProd.TabIndex = 282
        Me.rb_vendaProd.Text = "Vendas de Produtos"
        '
        'rb_comprasprod
        '
        Me.rb_comprasprod.BackColor = System.Drawing.Color.SteelBlue
        Me.rb_comprasprod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_comprasprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_comprasprod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_comprasprod.ForeColor = System.Drawing.Color.OrangeRed
        Me.rb_comprasprod.Location = New System.Drawing.Point(16, 144)
        Me.rb_comprasprod.Name = "rb_comprasprod"
        Me.rb_comprasprod.Size = New System.Drawing.Size(128, 32)
        Me.rb_comprasprod.TabIndex = 283
        Me.rb_comprasprod.Text = "Compras de Produtos"
        '
        'bt_verificavendasvei
        '
        Me.bt_verificavendasvei.BackColor = System.Drawing.Color.Black
        Me.bt_verificavendasvei.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_verificavendasvei.Location = New System.Drawing.Point(64, 352)
        Me.bt_verificavendasvei.Name = "bt_verificavendasvei"
        Me.bt_verificavendasvei.Size = New System.Drawing.Size(88, 40)
        Me.bt_verificavendasvei.TabIndex = 284
        Me.bt_verificavendasvei.Text = "Consultar Vendas de Veiculos"
        Me.bt_verificavendasvei.Visible = False
        '
        'bt_consultacomprasvei
        '
        Me.bt_consultacomprasvei.BackColor = System.Drawing.Color.Black
        Me.bt_consultacomprasvei.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_consultacomprasvei.Location = New System.Drawing.Point(64, 352)
        Me.bt_consultacomprasvei.Name = "bt_consultacomprasvei"
        Me.bt_consultacomprasvei.Size = New System.Drawing.Size(88, 40)
        Me.bt_consultacomprasvei.TabIndex = 275
        Me.bt_consultacomprasvei.Text = "Consultar Compras de Veiculos"
        Me.bt_consultacomprasvei.Visible = False
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.Color.LightGray
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Black
        Me.Label.Location = New System.Drawing.Point(0, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(152, 37)
        Me.Label.TabIndex = 285
        Me.Label.Text = "Consultas"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(-8, 332)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(168, 111)
        Me.Label20.TabIndex = 286
        '
        'consultas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(496, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.LIST)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.rb_comprasprod)
        Me.Controls.Add(Me.rb_vendaProd)
        Me.Controls.Add(Me.data_ate)
        Me.Controls.Add(Me.data_de)
        Me.Controls.Add(Me.bt_back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rb_vendavei)
        Me.Controls.Add(Me.rb_comprasvei)
        Me.Controls.Add(Me.rb_pagamentos)
        Me.Controls.Add(Me.rb_recebimentos)
        Me.Controls.Add(Me.bt_verificavendasprod)
        Me.Controls.Add(Me.bt_consulrecebi)
        Me.Controls.Add(Me.bt_consultapagamentos)
        Me.Controls.Add(Me.bt_consultacomprasprod)
        Me.Controls.Add(Me.bt_consultacomprasvei)
        Me.Controls.Add(Me.bt_verificavendasvei)
        Me.Controls.Add(Me.Label20)
        Me.Name = "consultas"
        Me.Text = "Consultas"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Radiobuttons"
    Private Sub rb_vendas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_vendavei.CheckedChanged
        bt_consulrecebi.Visible = False
        bt_consultapagamentos.Visible = False
        bt_verificavendasprod.Visible = False
        bt_verificavendasvei.Visible = True
        bt_consultacomprasprod.Visible = False
        bt_consultacomprasvei.Visible = False

    End Sub

    Private Sub rb_vendaProd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_vendaProd.CheckedChanged
        bt_consulrecebi.Visible = False
        bt_consultapagamentos.Visible = False
        bt_verificavendasprod.Visible = True
        bt_verificavendasvei.Visible = False
        bt_consultacomprasprod.Visible = False
        bt_consultacomprasvei.Visible = False
    End Sub

    Private Sub rb_recebimentos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_recebimentos.CheckedChanged
        bt_consulrecebi.Visible = True
        bt_consultapagamentos.Visible = False
        bt_verificavendasprod.Visible = False
        bt_verificavendasvei.Visible = False
        bt_consultacomprasprod.Visible = False
        bt_consultacomprasvei.Visible = False

    End Sub

    Private Sub rb_pagamentos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_pagamentos.CheckedChanged
        bt_consulrecebi.Visible = False
        bt_consultapagamentos.Visible = True
        bt_verificavendasprod.Visible = False
        bt_verificavendasvei.Visible = False
        bt_consultacomprasprod.Visible = False
        bt_consultacomprasvei.Visible = False
    End Sub

    Private Sub rb_compras_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_comprasvei.CheckedChanged
        bt_consulrecebi.Visible = False
        bt_consultapagamentos.Visible = False
        bt_verificavendasprod.Visible = False
        bt_verificavendasvei.Visible = False
        bt_consultacomprasprod.Visible = False
        bt_consultacomprasvei.Visible = True
    End Sub
    Private Sub rb_comprasprod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_comprasprod.CheckedChanged
        bt_consulrecebi.Visible = False
        bt_consultapagamentos.Visible = False
        bt_verificavendasprod.Visible = False
        bt_verificavendasvei.Visible = False
        bt_consultacomprasprod.Visible = True
        bt_consultacomprasvei.Visible = False
    End Sub

#End Region

    Private Sub bt_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_back.Click
        Me.Visible = False
        financas.Visible = True
    End Sub

    Private Sub bt_verificavendas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_verificavendasprod.Click
        LIST.Columns.Clear()
        LIST.Items.Clear()
        LIST.Columns.Add("Dia", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Valor", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Produtos", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Nome do cliente", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Codigo do cliente", 80, HorizontalAlignment.Left)
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        comando = New OleDbCommand("select * from venda_prod where dia_venda>=" & data_de.Value.Date.ToOADate & " and dia_venda<=" & data_ate.Value.Date.ToOADate, Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            While dr.Read
                Dim lista As New ListViewItem
                lista.StateImageIndex = 5
                lista.Text = dr("dia_venda")
                lista.SubItems.Add(dr("total"))
                lista.SubItems.Add(dr("nome_produtos"))
                lista.SubItems.Add(dr("nome_cliente"))
                lista.SubItems.Add(dr("cod_cliente"))
                LIST.Items.Add(lista)
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try

    End Sub

    Private Sub bt_consulrecebi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_consulrecebi.Click
        LIST.Columns.Clear()
        LIST.Items.Clear()
        LIST.Columns.Add("Dia", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Valor total", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Pago a vista(/entrada)", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Parcelas", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Valor das Parcelas", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Parcelas pagas", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Situacao do Parcelamento", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Nome do Cliente", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Codigo do Cliente", 80, HorizontalAlignment.Left)
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        comando = New OleDbCommand("select * from recebimentos where data_recebimento>=" & data_de.Value.Date.ToOADate & " and data_recebimento<=" & data_ate.Value.Date.ToOADate, Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            While dr.Read
                Dim lista As New ListViewItem
                lista.StateImageIndex = 3
                lista.Text = dr("data_recebimento")
                lista.SubItems.Add(dr("valor_total"))
                lista.SubItems.Add(dr("pago_a_vista"))
                lista.SubItems.Add(dr("parcelas"))
                lista.SubItems.Add(dr("qnt_kda_parcela"))
                lista.SubItems.Add(dr("parcelas_pagas"))
                lista.SubItems.Add(dr("situacao_parcelamento"))
                lista.SubItems.Add(dr("nome_cli"))
                lista.SubItems.Add(dr("cod_cli"))
                LIST.Items.Add(lista)
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub bt_consultapagamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_consultapagamentos.Click
        LIST.Columns.Clear()
        LIST.Items.Clear()
        LIST.Columns.Add("Nome", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Codigo de quem recebe", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Dia", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Valor", 80, HorizontalAlignment.Left)
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        Dim a As Integer
        comando = New OleDbCommand("select * from pagamentos where dia_pagamento>='" & data_de.Value.Date & "' and dia_pagamento<='" & data_ate.Value.Date & "'", Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            While dr.Read
                If dr("feito_a") = "funcionarios" Then
                    a = 2
                ElseIf dr("feito_a") = "clientes" Then
                    a = 3
                ElseIf dr("feito_a") = "fornecedor" Then
                    a = 4
                End If
                Dim lista As New ListViewItem
                Dim lista2 As New ListViewItem
                lista.StateImageIndex = a
                lista.Text = dr("nome")
                lista.SubItems.Add(dr("codigo"))
                lista.SubItems.Add(dr("dia_pagamento"))
                lista.SubItems.Add(dr("quantia"))
                LIST.Items.Add((lista))
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Erro")
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub bt_consultacomprasdiprodutus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_consultacomprasprod.Click
        LIST.Columns.Clear()
        LIST.Items.Clear()
        LIST.Columns.Add("Dia", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Valor", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Produto", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Nome do fornecedor", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Codigo do fornecedor", 80, HorizontalAlignment.Left)
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        comando = New OleDbCommand("select * from compra_prod where dia_compra>=" & data_de.Value.Date.ToOADate & " and dia_compra<=" & data_ate.Value.Date.ToOADate, Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            While dr.Read
                Dim lista As New ListViewItem
                lista.StateImageIndex = 5
                lista.Text = dr("dia_compra")
                lista.SubItems.Add(dr("total_compra"))
                lista.SubItems.Add(dr("nome_produto"))
                lista.SubItems.Add(dr("nome_fant_forn"))
                lista.SubItems.Add(dr("cod_forn"))
                LIST.Items.Add(lista)
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub bt_verificavendasvei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_verificavendasvei.Click
        LIST.Columns.Clear()
        LIST.Items.Clear()
        LIST.Columns.Add("Dia", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Valor", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("PLACA", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Modelo", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Nome do Cliente", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Codigo do cliente", 80, HorizontalAlignment.Left)
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        comando = New OleDbCommand("select * from venda_vei_novo where dia_venda>=" & data_de.Value.Date.ToOADate & " and dia_venda<=" & data_ate.Value.Date.ToOADate, Conexao)
        AbrirBD()

        Try
            dr = comando.ExecuteReader
            While dr.Read
                Dim lista As New ListViewItem
                lista.StateImageIndex = 0
                lista.Text = dr("dia_venda")
                lista.SubItems.Add(dr("preco_venda"))
                lista.SubItems.Add(dr("placa_veiculo"))
                lista.SubItems.Add(dr("modelo_veiculo"))
                lista.SubItems.Add(dr("nome_cliente"))
                lista.SubItems.Add(dr("cod_cliente"))
                LIST.Items.Add(lista)
            End While
            dr.Close()
            comando = New OleDbCommand("select * from venda_vei_usado where dia_venda>=" & data_de.Value.Date.ToOADate & " and dia_venda<=" & data_ate.Value.Date.ToOADate, Conexao)
            dr = comando.ExecuteReader
            While dr.Read
                Dim lista As New ListViewItem
                lista.StateImageIndex = 1
                lista.Text = dr("dia_venda")
                lista.SubItems.Add(dr("preco_venda"))
                lista.SubItems.Add(dr("placa_veiculo"))
                lista.SubItems.Add(dr("modelo_veiculo"))
                lista.SubItems.Add(dr("nome_cliente"))
                lista.SubItems.Add(dr("cod_cliente"))
                LIST.Items.Add(lista)
            End While
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub bt_consultacomprasvei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_consultacomprasvei.Click
        LIST.Columns.Clear()
        LIST.Items.Clear()
        LIST.Columns.Add("Dia", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Valor", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("PLACA", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Nome do fornecedor/Cliente", 80, HorizontalAlignment.Left)
        LIST.Columns.Add("Codigo do fornecedor/cliente", 80, HorizontalAlignment.Left)
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        comando = New OleDbCommand("select * from compra_vei_novo where dia_compra>=" & data_de.Value.Date.ToOADate & " and dia_compra<=" & data_ate.Value.Date.ToOADate, Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            While dr.Read
                Dim lista As New ListViewItem
                lista.StateImageIndex = 0
                lista.Text = dr("dia_compra")
                lista.SubItems.Add(dr("preco_compra_vei"))
                lista.SubItems.Add(dr("placa_vei"))
                lista.SubItems.Add(dr("nome_fant_forn"))
                lista.SubItems.Add(dr("cod_forn"))
                LIST.Items.Add(lista)
            End While
            dr.Close()
            comando = New OleDbCommand("select * from compra_vei_usado where dia_compra>=" & data_de.Value.Date.ToOADate & " and dia_compra<=" & data_ate.Value.Date.ToOADate, Conexao)
            dr = comando.ExecuteReader
            While dr.Read
                Dim lista As New ListViewItem
                lista.StateImageIndex = 1
                lista.Text = dr("dia_compra")
                lista.SubItems.Add(dr("preco_compra_vei"))
                lista.SubItems.Add(dr("placa_vei"))
                lista.SubItems.Add(dr("nome_cli"))
                lista.SubItems.Add(dr("cod_cli"))
                LIST.Items.Add(lista)
            End While
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try



    End Sub

    Private Sub consultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub data_ate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles data_ate.ValueChanged
        data_de.MaxDate = data_ate.Value.Date
    End Sub

    Private Sub data_de_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles data_de.ValueChanged
        data_ate.MinDate = data_de.Value.Date
    End Sub
End Class
