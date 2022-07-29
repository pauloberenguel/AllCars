Imports System.Data.OleDb
Public Class pagamentos
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
    Friend WithEvents status As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents txt_apagar As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents LIST As System.Windows.Forms.ListView
    Friend WithEvents nome As System.Windows.Forms.ColumnHeader
    Friend WithEvents codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents bt_back As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nome As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents efetuar_pgto As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(pagamentos))
        Me.txt_apagar = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.status = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.LIST = New System.Windows.Forms.ListView
        Me.nome = New System.Windows.Forms.ColumnHeader
        Me.codigo = New System.Windows.Forms.ColumnHeader
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.bt_back = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_nome = New System.Windows.Forms.TextBox
        Me.txt_cod = New System.Windows.Forms.TextBox
        Me.Label = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.efetuar_pgto = New System.Windows.Forms.Button
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_apagar
        '
        Me.txt_apagar.Location = New System.Drawing.Point(72, 96)
        Me.txt_apagar.Name = "txt_apagar"
        Me.txt_apagar.ReadOnly = True
        Me.txt_apagar.Size = New System.Drawing.Size(120, 19)
        Me.txt_apagar.TabIndex = 4
        Me.txt_apagar.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Beige
        Me.Label3.Location = New System.Drawing.Point(8, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Valor"
        '
        'status
        '
        Me.status.Cursor = System.Windows.Forms.Cursors.Cross
        Me.status.Font = New System.Drawing.Font("Vrinda", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.Location = New System.Drawing.Point(0, 416)
        Me.status.Name = "status"
        Me.status.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.status.ShowPanels = True
        Me.status.Size = New System.Drawing.Size(370, 21)
        Me.status.TabIndex = 258
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Icon = CType(resources.GetObject("StatusBarPanel1.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel1.ToolTipText = "Atualizacao de saldo do fornecedor"
        Me.StatusBarPanel1.Width = 354
        '
        'LIST
        '
        Me.LIST.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nome, Me.codigo})
        Me.LIST.FullRowSelect = True
        Me.LIST.GridLines = True
        Me.LIST.Location = New System.Drawing.Point(0, 44)
        Me.LIST.MultiSelect = False
        Me.LIST.Name = "LIST"
        Me.LIST.Size = New System.Drawing.Size(160, 370)
        Me.LIST.StateImageList = Me.ImageList1
        Me.LIST.TabIndex = 259
        Me.LIST.View = System.Windows.Forms.View.List
        '
        'nome
        '
        Me.nome.Width = 500
        '
        'codigo
        '
        Me.codigo.Text = ""
        Me.codigo.Width = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton1.ForeColor = System.Drawing.Color.Beige
        Me.RadioButton1.Location = New System.Drawing.Point(8, 15)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(120, 24)
        Me.RadioButton1.TabIndex = 260
        Me.RadioButton1.Text = "Aos Funcionarios"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton2.ForeColor = System.Drawing.Color.Beige
        Me.RadioButton2.Location = New System.Drawing.Point(8, 52)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(120, 24)
        Me.RadioButton2.TabIndex = 261
        Me.RadioButton2.Text = "Aos Clientes"
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton3.ForeColor = System.Drawing.Color.Beige
        Me.RadioButton3.Location = New System.Drawing.Point(8, 89)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(128, 24)
        Me.RadioButton3.TabIndex = 262
        Me.RadioButton3.Text = "Aos Fornecedores"
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
        Me.bt_back.Location = New System.Drawing.Point(288, 288)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(65, 76)
        Me.bt_back.TabIndex = 263
        Me.bt_back.Text = "Voltar"
        Me.bt_back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(8, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 264
        Me.Label1.Text = "Nome"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(72, 59)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.ReadOnly = True
        Me.txt_nome.Size = New System.Drawing.Size(120, 19)
        Me.txt_nome.TabIndex = 265
        Me.txt_nome.Text = ""
        '
        'txt_cod
        '
        Me.txt_cod.Location = New System.Drawing.Point(160, 7)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.ReadOnly = True
        Me.txt_cod.Size = New System.Drawing.Size(40, 19)
        Me.txt_cod.TabIndex = 266
        Me.txt_cod.Text = "Código"
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.Color.LightGray
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Black
        Me.Label.Location = New System.Drawing.Point(0, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(224, 37)
        Me.Label.TabIndex = 275
        Me.Label.Text = "Pagamentos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Location = New System.Drawing.Point(232, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 118)
        Me.GroupBox1.TabIndex = 276
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_apagar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_nome)
        Me.GroupBox2.Controls.Add(Me.txt_cod)
        Me.GroupBox2.Location = New System.Drawing.Point(168, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 132)
        Me.GroupBox2.TabIndex = 277
        Me.GroupBox2.TabStop = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(184, 281)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(176, 88)
        Me.Label20.TabIndex = 278
        '
        'efetuar_pgto
        '
        Me.efetuar_pgto.BackColor = System.Drawing.Color.White
        Me.efetuar_pgto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.efetuar_pgto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.efetuar_pgto.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.efetuar_pgto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.efetuar_pgto.Image = CType(resources.GetObject("efetuar_pgto.Image"), System.Drawing.Image)
        Me.efetuar_pgto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.efetuar_pgto.Location = New System.Drawing.Point(200, 288)
        Me.efetuar_pgto.Name = "efetuar_pgto"
        Me.efetuar_pgto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.efetuar_pgto.Size = New System.Drawing.Size(65, 76)
        Me.efetuar_pgto.TabIndex = 279
        Me.efetuar_pgto.Text = "Pagar"
        Me.efetuar_pgto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'pagamentos
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(370, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.efetuar_pgto)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.bt_back)
        Me.Controls.Add(Me.LIST)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label20)
        Me.ForeColor = System.Drawing.Color.Beige
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "pagamentos"
        Me.Text = "Pagamentos"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        LIST.Items.Clear()
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader

        comando = New OleDbCommand("select * from funcionarios where recebeu=false", Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            While dr.Read
                Dim lista As New ListViewItem
                lista.StateImageIndex = 0
                lista.Text = dr("nome_func")
                lista.SubItems.Add(dr("cod_func"))
                LIST.Items.Add(lista)
            End While
        Catch ex As Exception
            MsgBox("Erro")
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        LIST.Items.Clear()
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader

        comando = New OleDbCommand("select * from clientes where situa_cli='A receber'", Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            While dr.Read
                Dim lista As New ListViewItem
                lista.StateImageIndex = 1
                lista.Text = dr("nome_cli")
                lista.SubItems.Add(dr("cod_cli"))
                LIST.Items.Add(lista)
            End While
        Catch ex As Exception
            MsgBox("Erro")
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        LIST.Items.Clear()
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader

        comando = New OleDbCommand("select * from fornecedor where saldo_forn > 0", Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            While dr.Read
                Dim lista As New ListViewItem
                lista.StateImageIndex = 2
                lista.Text = dr("nome_fant_forn")
                lista.SubItems.Add(dr("cod_forn"))
                LIST.Items.Add(lista)
            End While
        Catch ex As Exception
            MsgBox("Erro")
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub bt_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_back.Click
        Me.Visible = False
        financas.Visible = True
    End Sub



    Private Sub LIST_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LIST.DoubleClick
        If RadioButton1.Checked = True Then
            Dim comando As OleDbCommand
            Dim dr As OleDbDataReader
            comando = New OleDbCommand("select * from funcionarios where cod_func=" & LIST.FocusedItem.SubItems(1).Text.ToString, Conexao)
            AbrirBD()
            Try
                dr = comando.ExecuteReader
                If dr.Read Then
                    txt_nome.Text = dr("nome_func")
                    txt_apagar.Text = dr("salario_func")
                    txt_cod.Text = dr("cod_func")
                End If
            Catch ex As Exception
                MsgBox("erro")
            Finally
                FecharBD()
            End Try
        End If
        If RadioButton2.Checked = True Then
            Dim comando As OleDbCommand
            Dim dr As OleDbDataReader
            comando = New OleDbCommand("select * from clientes where cod_cli=" & LIST.FocusedItem.SubItems(1).Text.ToString, Conexao)
            AbrirBD()
            Try
                dr = comando.ExecuteReader
                If dr.Read Then
                    txt_nome.Text = dr("nome_cli")
                    txt_apagar.Text = dr("saldo_cli")
                    txt_cod.Text = dr("cod_cli")
                End If
            Catch ex As Exception
                MsgBox("erro")
            Finally
                FecharBD()
            End Try
        End If
        If RadioButton3.Checked = True Then
            Dim comando As OleDbCommand
            Dim dr As OleDbDataReader
            comando = New OleDbCommand("select * from fornecedor where cod_forn=" & LIST.FocusedItem.SubItems(1).Text.ToString, Conexao)
            AbrirBD()
            Try
                dr = comando.ExecuteReader
                If dr.Read Then
                    txt_nome.Text = Dr("nome_fant_forn")
                    txt_apagar.Text = dr("saldo_forn")
                    txt_cod.Text = dr("cod_forn")
                End If
            Catch ex As Exception
                MsgBox("erro")
            Finally
                FecharBD()
            End Try

        End If
    End Sub

    Private Sub efetuar_pgto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles efetuar_pgto.Click
        Dim feitoa As String
        Dim comando As OleDbCommand

        If RadioButton1.Checked = True Then
            comando = New OleDbCommand("Update funcionarios set recebeu=true where cod_func=" & txt_cod.Text, Conexao)
            AbrirBD()
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
            Finally
                feitoa = "funcionarios"
                FecharBD()
            End Try
        End If
        If RadioButton2.Checked = True Then
            comando = New OleDbCommand("Update clientes set saldo_cli='0',situa_cli='Normal' where cod_cli=" & txt_cod.Text, Conexao)
            AbrirBD()
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
            Finally
                feitoa = "clientes"
                FecharBD()
            End Try
        End If
        If RadioButton3.Checked = True Then
            comando = New OleDbCommand("Update fornecedor set saldo_forn=0 where cod_forn=" & txt_cod.Text, Conexao)
            AbrirBD()
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
            Finally
                feitoa = "fornecedor"
                FecharBD()
            End Try
        End If
        AbrirBD()
        comando = New OleDbCommand("Insert into pagamentos(feito_a,nome,codigo,quantia,dia_pagamento)values(@feito_a,@nome,@codigo,@quantia,@dia_pagamento)", Conexao)
        With comando
            .Parameters.Add(New OleDbParameter("@feito_a", OleDbType.VarChar, 50))
            .Parameters("@feito_a").Value = feitoa.ToString
            .Parameters.Add(New OleDbParameter("@nome", OleDbType.VarChar, 50))
            .Parameters("@nome").Value = txt_nome.Text.ToString
            .Parameters.Add(New OleDbParameter("@codigo", OleDbType.VarChar, 50))
            .Parameters("@codigo").Value = txt_cod.Text.ToString
            .Parameters.Add(New OleDbParameter("@quantia", OleDbType.Numeric, 50))
            .Parameters("@quantia").Value = Val(txt_apagar.Text)
            .Parameters.Add(New OleDbParameter("@dia_pagamento", OleDbType.VarChar, 50))
            .Parameters("@dia_pagamento").Value = System.DateTime.Today.ToShortDateString.ToString
        End With
        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Pagamento registrado com sucesso", "Pagamento efetuado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3, MessageBoxOptions.DefaultDesktopOnly)
            status.Text = "Dívida quitada"
        Catch ex As Exception
            MsgBox("erro")
        Finally
            FecharBD()
        End Try

        LIST.Items.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
    End Sub

    Private Sub pagamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
