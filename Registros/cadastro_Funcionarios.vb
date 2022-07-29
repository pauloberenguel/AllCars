Imports System.Data.OleDb
Public Class frmforn
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtfunc As System.Windows.Forms.TextBox
    Friend WithEvents cmbsetor As System.Windows.Forms.ComboBox
    Friend WithEvents cb_search As System.Windows.Forms.Button
    Friend WithEvents Bt_clear As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cb_apaga As System.Windows.Forms.Button
    Friend WithEvents cb_print As System.Windows.Forms.Button
    Friend WithEvents cb_altera As System.Windows.Forms.Button
    Friend WithEvents cadastro_venda As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtsalario As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmforn))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtcod = New System.Windows.Forms.TextBox
        Me.txtnome = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbsetor = New System.Windows.Forms.ComboBox
        Me.txtfunc = New System.Windows.Forms.TextBox
        Me.cb_search = New System.Windows.Forms.Button
        Me.Bt_clear = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cb_apaga = New System.Windows.Forms.Button
        Me.cb_print = New System.Windows.Forms.Button
        Me.cb_altera = New System.Windows.Forms.Button
        Me.cadastro_venda = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtsalario = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(392, 40)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Cadastrar Funcionario"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Beige
        Me.Label16.Location = New System.Drawing.Point(8, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 24)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Código"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(8, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Nome"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Beige
        Me.Label2.Location = New System.Drawing.Point(8, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Função"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(104, 56)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.ReadOnly = True
        Me.txtcod.Size = New System.Drawing.Size(88, 20)
        Me.txtcod.TabIndex = 78
        Me.txtcod.Text = ""
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(104, 88)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(296, 20)
        Me.txtnome.TabIndex = 79
        Me.txtnome.Text = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Beige
        Me.Label5.Location = New System.Drawing.Point(8, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Setor"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbsetor
        '
        Me.cmbsetor.Items.AddRange(New Object() {"Alugueis", "Mecanica", "Vendas", "Financeiro", "Outros"})
        Me.cmbsetor.Location = New System.Drawing.Point(104, 120)
        Me.cmbsetor.Name = "cmbsetor"
        Me.cmbsetor.Size = New System.Drawing.Size(152, 21)
        Me.cmbsetor.TabIndex = 82
        Me.cmbsetor.Text = "--Selecionar--"
        '
        'txtfunc
        '
        Me.txtfunc.Location = New System.Drawing.Point(104, 152)
        Me.txtfunc.Name = "txtfunc"
        Me.txtfunc.Size = New System.Drawing.Size(152, 20)
        Me.txtfunc.TabIndex = 83
        Me.txtfunc.Text = ""
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
        Me.cb_search.Location = New System.Drawing.Point(448, 243)
        Me.cb_search.Name = "cb_search"
        Me.cb_search.Size = New System.Drawing.Size(144, 34)
        Me.cb_search.TabIndex = 241
        Me.cb_search.Text = "Localizar"
        Me.cb_search.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Bt_clear
        '
        Me.Bt_clear.BackColor = System.Drawing.Color.White
        Me.Bt_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Bt_clear.Font = New System.Drawing.Font("Arial", 10.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Bt_clear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bt_clear.Image = CType(resources.GetObject("Bt_clear.Image"), System.Drawing.Image)
        Me.Bt_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_clear.Location = New System.Drawing.Point(128, 199)
        Me.Bt_clear.Name = "Bt_clear"
        Me.Bt_clear.Size = New System.Drawing.Size(65, 82)
        Me.Bt_clear.TabIndex = 236
        Me.Bt_clear.Text = "Limpar"
        Me.Bt_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(368, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 82)
        Me.Button2.TabIndex = 240
        Me.Button2.Text = "Voltar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cb_apaga
        '
        Me.cb_apaga.BackColor = System.Drawing.Color.White
        Me.cb_apaga.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_apaga.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_apaga.Font = New System.Drawing.Font("Arial", 9.01!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.cb_apaga.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cb_apaga.Image = CType(resources.GetObject("cb_apaga.Image"), System.Drawing.Image)
        Me.cb_apaga.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cb_apaga.Location = New System.Drawing.Point(208, 199)
        Me.cb_apaga.Name = "cb_apaga"
        Me.cb_apaga.Size = New System.Drawing.Size(65, 82)
        Me.cb_apaga.TabIndex = 239
        Me.cb_apaga.Text = "Remover"
        Me.cb_apaga.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.cb_print.Location = New System.Drawing.Point(448, 199)
        Me.cb_print.Name = "cb_print"
        Me.cb_print.Size = New System.Drawing.Size(144, 35)
        Me.cb_print.TabIndex = 238
        Me.cb_print.Text = "Imprimir"
        Me.cb_print.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cb_altera
        '
        Me.cb_altera.BackColor = System.Drawing.Color.White
        Me.cb_altera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_altera.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_altera.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_altera.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cb_altera.Image = CType(resources.GetObject("cb_altera.Image"), System.Drawing.Image)
        Me.cb_altera.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.cb_altera.Location = New System.Drawing.Point(288, 199)
        Me.cb_altera.Name = "cb_altera"
        Me.cb_altera.Size = New System.Drawing.Size(65, 82)
        Me.cb_altera.TabIndex = 237
        Me.cb_altera.Text = "Alterar"
        Me.cb_altera.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.cadastro_venda.Location = New System.Drawing.Point(48, 199)
        Me.cadastro_venda.Name = "cadastro_venda"
        Me.cadastro_venda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cadastro_venda.Size = New System.Drawing.Size(65, 82)
        Me.cadastro_venda.TabIndex = 235
        Me.cadastro_venda.Text = "Salvar"
        Me.cadastro_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(40, 191)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(560, 95)
        Me.Label20.TabIndex = 242
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Beige
        Me.Label6.Location = New System.Drawing.Point(392, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 243
        Me.Label6.Text = "Salário"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtsalario
        '
        Me.txtsalario.Location = New System.Drawing.Point(480, 147)
        Me.txtsalario.Name = "txtsalario"
        Me.txtsalario.Size = New System.Drawing.Size(112, 20)
        Me.txtsalario.TabIndex = 244
        Me.txtsalario.Text = ""
        '
        'frmforn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(624, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtsalario)
        Me.Controls.Add(Me.cb_search)
        Me.Controls.Add(Me.Bt_clear)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cb_apaga)
        Me.Controls.Add(Me.cb_print)
        Me.Controls.Add(Me.cb_altera)
        Me.Controls.Add(Me.cadastro_venda)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtfunc)
        Me.Controls.Add(Me.cmbsetor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.MaximizeBox = False
        Me.Name = "frmforn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Funcionario"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cadastro_alug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtnome.Text = "" Or cmbsetor.SelectedItem = "--Selecionar--" Or txtfunc.Text = "" Or txtsalario.Text = "" Then
            MessageBox.Show("Todos os campos devem ser preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim comando As OleDbCommand

            Conexao.Open()
            comando = New OleDbCommand("INSERT into funcionarios(nome_func,setor_func,func_func,data_func) values (@nome,@setor,@func,@data)", Conexao)
            With comando
                .Parameters.Add(New OleDbParameter("@nome", OleDbType.VarChar, 50))
                .Parameters("@nome").Value = txtnome.Text.ToString
                .Parameters.Add(New OleDbParameter("@setor", OleDbType.VarChar, 50))
                .Parameters("@setor").Value = cmbsetor.Text.ToString
                .Parameters.Add(New OleDbParameter("@func", OleDbType.VarChar, 50))
                .Parameters("@func").Value = txtfunc.Text.ToString
                .Parameters.Add(New OleDbParameter("@data", OleDbType.VarChar, 50))
                .Parameters("@data").Value = txtsalario.Text.ToString

            End With
            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("Funcionário cadastrado", "Inclusão de funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Erro")
            Finally
                FecharBD()
            End Try


        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Controle As New Control
        For Each Controle In Me.Controls
            If TypeOf Controle Is TextBox Or TypeOf Controle Is ComboBox Then
                Controle.Text = ""
            End If
        Next
    End Sub

    Private Sub Excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Comando As OleDbCommand
        AbrirBD()

        Comando = New OleDbCommand("delete from funcionarios where cod_func=@cod", Conexao)
        Comando.Parameters.Add(New OleDbParameter("@cod", OleDbType.Integer, 50))
        Comando.Parameters("@cod").Value = Me.txtcod.Text.ToString
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

    Private Sub bot_localizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        localizar_funcionario.ShowDialog()
    End Sub
    Private Sub alterar_alug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtnome.Text = "" Or cmbsetor.SelectedItem = "--Selecionar--" Or txtfunc.Text = "" Or txtsalario.Text = "" Then
            MessageBox.Show("Todos os campos devem ser preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim comando As OleDbCommand

            Conexao.Open()
            comando = New OleDbCommand("Update funcionarios set nome_func=@nome,setor_func=@setor,func_func=@func,salario_func=@salario_func where cod_func=@codfun", Conexao)

            With comando
                .Parameters.Add(New OleDbParameter("@nome", OleDbType.VarChar, 50))
                .Parameters("@nome").Value = txtnome.Text.ToString
                .Parameters.Add(New OleDbParameter("@setor", OleDbType.VarChar, 50))
                .Parameters("@setor").Value = cmbsetor.Text.ToString
                .Parameters.Add(New OleDbParameter("@func", OleDbType.VarChar, 50))
                .Parameters("@func").Value = txtfunc.Text.ToString
                .Parameters.Add(New OleDbParameter("@salario_func", OleDbType.VarChar, 50))
                .Parameters("@salario_func").Value = txtsalario.Text.ToString
                .Parameters.Add(New OleDbParameter("@codfun", OleDbType.VarChar, 50))
                .Parameters("@codfun").Value = txtcod.Text.ToString
            End With
            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("Funcionário cadastrado", "Inclusão de funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Erro")
            Finally
                FecharBD()
            End Try


        End If

    End Sub

    Private Sub cmdcal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        calendario.ShowDialog()

    End Sub

    Private Sub frmforn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Controle As New Control
        For Each Controle In Me.Controls
            If TypeOf Controle Is TextBox Then
                Controle.Text = ""
            End If
        Next
    End Sub

    Private Sub cadastro_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadastro_venda.Click
        If txtnome.Text = "" Or cmbsetor.SelectedItem = "--Selecionar--" Or txtfunc.Text = "" Or txtsalario.Text = "" Then
            MessageBox.Show("Todos os campos devem ser preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim comando As OleDbCommand

            Conexao.Open()
            comando = New OleDbCommand("INSERT into funcionarios(nome_func,setor_func,func_func,salario_func) values (@nome,@setor,@func,@salario_func)", Conexao)
            With comando
                .Parameters.Add(New OleDbParameter("@nome", OleDbType.VarChar, 50))
                .Parameters("@nome").Value = txtnome.Text.ToString
                .Parameters.Add(New OleDbParameter("@setor", OleDbType.VarChar, 50))
                .Parameters("@setor").Value = cmbsetor.Text.ToString
                .Parameters.Add(New OleDbParameter("@func", OleDbType.VarChar, 50))
                .Parameters("@func").Value = txtfunc.Text.ToString
                .Parameters.Add(New OleDbParameter("@salario_func", OleDbType.VarChar, 50))
                .Parameters("@salario_func").Value = txtsalario.Text

            End With
            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("Funcionario cadastrado", "Inclusao de funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Erro")
            Finally
                FecharBD()
            End Try


        End If
    End Sub

    Private Sub Bt_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_clear.Click
        Dim Controle As New Control
        For Each Controle In Me.Controls
            If TypeOf Controle Is TextBox Or TypeOf Controle Is ComboBox Then
                Controle.Text = ""
            End If
        Next
    End Sub

    Private Sub cb_altera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_altera.Click
        If txtnome.Text = "" Or cmbsetor.SelectedItem = "--Selecionar--" Or txtfunc.Text = "" Or txtsalario.Text = "" Then
            MessageBox.Show("Todos os campos devem ser preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim comando As OleDbCommand

            Conexao.Open()
            comando = New OleDbCommand("Update funcionarios set nome_func=@nome,setor_func=@setor,func_func=@func,salario_func=@salario_func where cod_func=@codfun", Conexao)

            With comando
                .Parameters.Add(New OleDbParameter("@nome", OleDbType.VarChar, 50))
                .Parameters("@nome").Value = txtnome.Text.ToString
                .Parameters.Add(New OleDbParameter("@setor", OleDbType.VarChar, 50))
                .Parameters("@setor").Value = cmbsetor.Text.ToString
                .Parameters.Add(New OleDbParameter("@func", OleDbType.VarChar, 50))
                .Parameters("@func").Value = txtfunc.Text.ToString
                .Parameters.Add(New OleDbParameter("@salario_func", OleDbType.VarChar, 50))
                .Parameters("@salario_func").Value = txtsalario.Text.ToString
                .Parameters.Add(New OleDbParameter("@codfun", OleDbType.VarChar, 50))
                .Parameters("@codfun").Value = txtcod.Text.ToString
            End With
            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("Funcionário cadastrado", "Inclusão de funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Erro")
            Finally
                FecharBD()
            End Try


        End If

    End Sub

    Private Sub cb_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_search.Click
        localizar_funcionario.ShowDialog()

    End Sub

    Private Sub cb_apaga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_apaga.Click
        Dim Comando As OleDbCommand
        AbrirBD()

        Comando = New OleDbCommand("delete from funcionarios where cod_func=@cod", Conexao)
        Comando.Parameters.Add(New OleDbParameter("@cod", OleDbType.Integer, 50))
        Comando.Parameters("@cod").Value = Me.txtcod.Text.ToString
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
        principal.Visible = True
        principal.IconTray.Visible = False

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsalario.TextChanged

    End Sub
End Class
