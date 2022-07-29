Imports System.Data.Oledb

Public Class Localizar_Funcionarios
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
    Friend WithEvents Cb_Nome As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Setor As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_funcao As System.Windows.Forms.ComboBox
    Friend WithEvents listview1 As System.Windows.Forms.ListView
    Friend WithEvents Setor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Funcao As System.Windows.Forms.ColumnHeader
    Friend WithEvents Salario As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Localizar_Funcionarios))
        Me.L_AUX2 = New System.Windows.Forms.Label
        Me.cmb_escolha = New System.Windows.Forms.ComboBox
        Me.BTNsair = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.listview1 = New System.Windows.Forms.ListView
        Me.Codigo = New System.Windows.Forms.ColumnHeader
        Me.Nome = New System.Windows.Forms.ColumnHeader
        Me.Setor = New System.Windows.Forms.ColumnHeader
        Me.Funcao = New System.Windows.Forms.ColumnHeader
        Me.Salario = New System.Windows.Forms.ColumnHeader
        Me.Label_X = New System.Windows.Forms.Label
        Me.Label = New System.Windows.Forms.Label
        Me.Cb_Setor = New System.Windows.Forms.ComboBox
        Me.Cb_funcao = New System.Windows.Forms.ComboBox
        Me.Cb_Nome = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'L_AUX2
        '
        Me.L_AUX2.BackColor = System.Drawing.Color.LightGray
        Me.L_AUX2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_AUX2.ForeColor = System.Drawing.Color.Red
        Me.L_AUX2.Location = New System.Drawing.Point(224, 8)
        Me.L_AUX2.Name = "L_AUX2"
        Me.L_AUX2.Size = New System.Drawing.Size(128, 32)
        Me.L_AUX2.TabIndex = 73
        Me.L_AUX2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_escolha
        '
        Me.cmb_escolha.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_escolha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_escolha.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_escolha.Items.AddRange(New Object() {"Nome", "Setor", "Funcao"})
        Me.cmb_escolha.Location = New System.Drawing.Point(360, 9)
        Me.cmb_escolha.Name = "cmb_escolha"
        Me.cmb_escolha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmb_escolha.Size = New System.Drawing.Size(96, 24)
        Me.cmb_escolha.TabIndex = 72
        '
        'BTNsair
        '
        Me.BTNsair.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNsair.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNsair.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BTNsair.Image = CType(resources.GetObject("BTNsair.Image"), System.Drawing.Image)
        Me.BTNsair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNsair.Location = New System.Drawing.Point(193, 381)
        Me.BTNsair.Name = "BTNsair"
        Me.BTNsair.Size = New System.Drawing.Size(80, 57)
        Me.BTNsair.TabIndex = 70
        Me.BTNsair.Text = "Voltar"
        Me.BTNsair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(185, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 72)
        Me.Label4.TabIndex = 71
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.listview1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Beige
        Me.GroupBox1.Location = New System.Drawing.Point(8, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 280)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Funcionários"
        '
        'listview1
        '
        Me.listview1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Nome, Me.Setor, Me.Funcao, Me.Salario})
        Me.listview1.FullRowSelect = True
        Me.listview1.GridLines = True
        Me.listview1.Location = New System.Drawing.Point(8, 24)
        Me.listview1.MultiSelect = False
        Me.listview1.Name = "listview1"
        Me.listview1.Scrollable = False
        Me.listview1.Size = New System.Drawing.Size(424, 248)
        Me.listview1.TabIndex = 0
        Me.listview1.View = System.Windows.Forms.View.Details
        '
        'Codigo
        '
        Me.Codigo.Text = "Código"
        Me.Codigo.Width = 0
        '
        'Nome
        '
        Me.Nome.Text = "Nome"
        Me.Nome.Width = 120
        '
        'Setor
        '
        Me.Setor.Text = "Setor"
        Me.Setor.Width = 101
        '
        'Funcao
        '
        Me.Funcao.Text = "Funcao"
        Me.Funcao.Width = 115
        '
        'Salario
        '
        Me.Salario.Text = "Salario"
        Me.Salario.Width = 83
        '
        'Label_X
        '
        Me.Label_X.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_X.ForeColor = System.Drawing.Color.Beige
        Me.Label_X.Location = New System.Drawing.Point(16, 52)
        Me.Label_X.Name = "Label_X"
        Me.Label_X.Size = New System.Drawing.Size(80, 23)
        Me.Label_X.TabIndex = 66
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
        Me.Label.TabIndex = 67
        Me.Label.Text = "Localizar por:"
        '
        'Cb_Setor
        '
        Me.Cb_Setor.Items.AddRange(New Object() {"Mecanica", "Alugueis", "Vendas", "Outros"})
        Me.Cb_Setor.Location = New System.Drawing.Point(96, 52)
        Me.Cb_Setor.Name = "Cb_Setor"
        Me.Cb_Setor.Size = New System.Drawing.Size(176, 21)
        Me.Cb_Setor.TabIndex = 75
        '
        'Cb_funcao
        '
        Me.Cb_funcao.Location = New System.Drawing.Point(96, 52)
        Me.Cb_funcao.Name = "Cb_funcao"
        Me.Cb_funcao.Size = New System.Drawing.Size(175, 21)
        Me.Cb_funcao.TabIndex = 74
        '
        'Cb_Nome
        '
        Me.Cb_Nome.Location = New System.Drawing.Point(96, 52)
        Me.Cb_Nome.Name = "Cb_Nome"
        Me.Cb_Nome.Size = New System.Drawing.Size(176, 21)
        Me.Cb_Nome.TabIndex = 68
        '
        'Localizar_Funcionarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(456, 445)
        Me.ControlBox = False
        Me.Controls.Add(Me.L_AUX2)
        Me.Controls.Add(Me.cmb_escolha)
        Me.Controls.Add(Me.BTNsair)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_X)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Cb_Setor)
        Me.Controls.Add(Me.Cb_funcao)
        Me.Controls.Add(Me.Cb_Nome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Localizar_Funcionarios"
        Me.Text = "Localizar Funcionários"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Cb_Setor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Setor.SelectedIndexChanged
        listview1.Items.Clear()

        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Conexao.Open()
        Comando = New OleDbCommand("select * from funcionarios where setor_func='" & Cb_Setor.Text & "'", Conexao)
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                Dim lista As New ListViewItem
                lista.Text = DR("cod_func")
                lista.SubItems.Add(DR("nome_func"))
                lista.SubItems.Add(DR("setor_func"))
                lista.SubItems.Add(DR("func_func"))
                lista.SubItems.Add(DR("salario_func"))
                listview1.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub Cb_funcao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_funcao.SelectedIndexChanged
        listview1.Items.Clear()
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Conexao.Open()
        Comando = New OleDbCommand("select * from funcionarios where func_func='" & Cb_funcao.Text & "'", Conexao)
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                Dim lista As New ListViewItem
                lista.Text = DR("cod_func")
                lista.SubItems.Add(DR("nome_func"))
                lista.SubItems.Add(DR("setor_func"))
                lista.SubItems.Add(DR("func_func"))
                lista.SubItems.Add(DR("salario_func"))
                listview1.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub Cb_Nome_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Nome.SelectedIndexChanged
        listview1.Items.Clear()
        Dim Comando As OleDbCommand
        Dim DR As OleDbDataReader
        Conexao.Open()
        Comando = New OleDbCommand("select * from funcionarios where nome_func='" & Cb_Nome.Text & "'", Conexao)
        Try
            DR = Comando.ExecuteReader
            While DR.Read
                Dim lista As New ListViewItem
                lista.Text = DR("cod_func")
                lista.SubItems.Add(DR("nome_func"))
                lista.SubItems.Add(DR("setor_func"))
                lista.SubItems.Add(DR("func_func"))
                lista.SubItems.Add(DR("salario_func"))
                listview1.Items.Add(lista)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try

    End Sub

    Private Sub Localizar_Funcionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_escolha.Text = ""
        L_AUX2.Visible = False
        Cb_Nome.Visible = False
        Cb_Setor.Visible = False
        Cb_funcao.Visible = False
        Cb_Nome.Items.Clear()
        Cb_funcao.Items.Clear()


      
    End Sub

    Private Sub cmb_escolha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_escolha.SelectedIndexChanged
        If cmb_escolha.Text = "Nome" Then
            Cb_funcao.Visible = False
            Cb_Setor.Visible = False
            Cb_Nome.Visible = True
            L_AUX2.Visible = True
            L_AUX2.Text = "Nome"
            Label_X.Text = "Nome:"

            Cb_Nome.Items.Clear()
            Cb_funcao.Items.Clear()


            Dim CmdNOME As OleDbCommand
            Dim DRNOME As OleDbDataReader
            AbrirBD()

            CmdNOME = New OleDbCommand("select distinct nome_func from funcionarios order by nome_func", Conexao)

            Try
                DRNOME = CmdNOME.ExecuteReader
                While DRNOME.Read
                    Cb_Nome.Items.Add(DRNOME("nome_func"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try
        End If



       
        If cmb_escolha.Text = "Setor" Then
            Cb_Nome.Visible = False
            Cb_funcao.Visible = False
            Cb_Setor.Visible = True

            Cb_funcao.Items.Clear()
            Cb_Nome.Items.Clear()

            L_AUX2.Visible = True
            L_AUX2.Text = "Setor"
            Label_X.Text = "Setor:"
        End If

        If cmb_escolha.Text = "Funcao" Then
            Cb_funcao.Visible = True
            Cb_Nome.Visible = False
            Cb_Setor.Visible = False
            L_AUX2.Visible = True
            L_AUX2.Text = "Funcao"
            Label_X.Text = "Funcao:"
            Cb_Nome.Items.Clear()
            Cb_funcao.Items.Clear()


            Dim DRFun As OleDbDataReader
            Dim CmdFun As OleDbCommand
            AbrirBD()
            CmdFun = New OleDbCommand("select distinct func_func from funcionarios order by func_func", Conexao)
            Try
                DRFun = CmdFun.ExecuteReader
                While DRFun.Read
                    Cb_funcao.Items.Add(DRFun("func_func"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try
        End If
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listview1.DoubleClick
        Dim Comando As OleDbCommand
        Dim Dr As OleDbDataReader
        Dim cont As Integer

        AbrirBD()

        For cont = 0 To listview1.Items.Count - 1
            Comando = New OleDbCommand("select * from funcionarios where cod_func=@cod", Conexao)
            Comando.Parameters.Add(New OleDbParameter("@cod", OleDbType.VarChar, 50))
            Comando.Parameters("@cod").Value = listview1.FocusedItem.Text.ToString
        Next
        Try
            Dr = Comando.ExecuteReader
            If Dr.Read Then
                With funcionarios
                    .txtcod.Text = Dr("cod_func")
                    .txtnome.Text = Dr("nome_func")
                    .cmbsetor.Text = Dr("setor_func")
                    .txtfunc.Text = Dr("func_func")
                    .txtsalario.Text = Dr("salario_func")
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
        Me.Close()
        listview1.Items.Clear()
        Cb_Nome.Text = ""
    End Sub

    Private Sub BTNsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNsair.Click
        Me.Close()

    End Sub

    Private Sub listview1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listview1.SelectedIndexChanged

    End Sub
End Class
