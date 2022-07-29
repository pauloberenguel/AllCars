Imports ProjetoConcessionária.Module1
Imports System.Data.OleDb
Public Class venda_prod
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents cod_cli As System.Windows.Forms.TextBox
    Friend WithEvents nome_cli As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Public WithEvents List_Produtos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Remover As System.Windows.Forms.Button
    Friend WithEvents Atualizar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Preco As System.Windows.Forms.ColumnHeader
    Friend WithEvents Total As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(venda_prod))
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.nome_cli = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.cod_cli = New System.Windows.Forms.TextBox
        Me.List_Produtos = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Preco = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.Remover = New System.Windows.Forms.Button
        Me.Atualizar = New System.Windows.Forms.Button
        Me.Total = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 66)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(232, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 24)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(8, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 88)
        Me.Label4.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(8, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 15)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Cliente:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(16, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Efetuar Venda"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(104, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Cadastrar produtos"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(192, 248)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 40)
        Me.Button4.TabIndex = 47
        Me.Button4.Text = "Cadastrar cliente"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(16, 296)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 40)
        Me.Button5.TabIndex = 48
        Me.Button5.Text = "Localizar cliente"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'nome_cli
        '
        Me.nome_cli.Location = New System.Drawing.Point(104, 72)
        Me.nome_cli.Name = "nome_cli"
        Me.nome_cli.Size = New System.Drawing.Size(168, 19)
        Me.nome_cli.TabIndex = 49
        Me.nome_cli.Text = ""
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(104, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "Localizar produtos"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(192, 296)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 40)
        Me.Button6.TabIndex = 51
        Me.Button6.Text = "Voltar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cod_cli
        '
        Me.cod_cli.Location = New System.Drawing.Point(168, 48)
        Me.cod_cli.Name = "cod_cli"
        Me.cod_cli.ReadOnly = True
        Me.cod_cli.TabIndex = 53
        Me.cod_cli.Text = "Codigo do Cliente"
        '
        'List_Produtos
        '
        Me.List_Produtos.AllowDrop = True
        Me.List_Produtos.AutoArrange = False
        Me.List_Produtos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.List_Produtos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader2, Me.Preco, Me.ColumnHeader1})
        Me.List_Produtos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.List_Produtos.FullRowSelect = True
        Me.List_Produtos.GridLines = True
        Me.List_Produtos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.List_Produtos.HoverSelection = True
        Me.List_Produtos.ImeMode = System.Windows.Forms.ImeMode.On
        Me.List_Produtos.LabelEdit = True
        Me.List_Produtos.LabelWrap = False
        Me.List_Produtos.Location = New System.Drawing.Point(8, 104)
        Me.List_Produtos.MultiSelect = False
        Me.List_Produtos.Name = "List_Produtos"
        Me.List_Produtos.Size = New System.Drawing.Size(264, 89)
        Me.List_Produtos.TabIndex = 52
        Me.List_Produtos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = CType(configurationAppSettings.GetValue("ColumnHeader3.Text", GetType(System.String)), String)
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Produto"
        Me.ColumnHeader2.Width = 123
        '
        'Preco
        '
        Me.Preco.Text = "Preco Unit."
        Me.Preco.Width = 71
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo do Produto"
        Me.ColumnHeader1.Width = 0
        '
        'Remover
        '
        Me.Remover.BackColor = System.Drawing.Color.AliceBlue
        Me.Remover.Location = New System.Drawing.Point(16, 208)
        Me.Remover.Name = "Remover"
        Me.Remover.Size = New System.Drawing.Size(64, 24)
        Me.Remover.TabIndex = 54
        Me.Remover.Text = "Remover"
        '
        'Atualizar
        '
        Me.Atualizar.BackColor = System.Drawing.Color.AliceBlue
        Me.Atualizar.Location = New System.Drawing.Point(96, 208)
        Me.Atualizar.Name = "Atualizar"
        Me.Atualizar.Size = New System.Drawing.Size(64, 24)
        Me.Atualizar.TabIndex = 55
        Me.Atualizar.Text = "$ Total"
        '
        'Total
        '
        Me.Total.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Total.Location = New System.Drawing.Point(176, 216)
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.TabIndex = 56
        Me.Total.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Beige
        Me.Label3.Location = New System.Drawing.Point(176, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Total"
        '
        'venda_prod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(280, 342)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Atualizar)
        Me.Controls.Add(Me.Remover)
        Me.Controls.Add(Me.cod_cli)
        Me.Controls.Add(Me.nome_cli)
        Me.Controls.Add(Me.List_Produtos)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.Name = "venda_prod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Venda de Produtos"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Cadastrar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cadastrocli_alu.ShowDialog()
    End Sub

    Private Sub Cadastrar_Prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        produtos.ShowDialog()

    End Sub

    Private Sub Localizar_Prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        locprod.ShowDialog()
    End Sub

    Private Sub Efetuar_Venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim comando As OleDbCommand
        Dim produtos As String
        Dim cont As Integer


        For cont = 0 To List_Produtos.Items.Count - 1
            produtos = List_Produtos.Items(cont).Text & "," & produtos

        Next

        Conexao.Open()
        comando = New OleDbCommand("INSERT into venda_prod(cod_cliente,nome_cliente,nome_produtos) values (@cod_cli,@nome_cli,@nome_prod)", Conexao)


        With comando
            .Parameters.Add(New OleDbParameter("@cod_cli", OleDbType.VarChar, 50))
            .Parameters("@cod_cli").Value = cod_cli.Text
            .Parameters.Add(New OleDbParameter("@nome_cli", OleDbType.VarChar, 50))
            .Parameters("@nome_cli").Value = nome_cli.Text.ToString
            .Parameters.Add(New OleDbParameter("@nome_prod", OleDbType.VarChar, 50))
            .Parameters("@nome_prod").Value = produtos
        End With
        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Venda Cadastrada", "Efetuar Venda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Erro")
        Finally
            FecharBD()
        End Try


    End Sub

    Private Sub Localizar_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        loccli.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()

    End Sub

    Private Sub Remover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remover.Click
        List_Produtos.FocusedItem.Remove()
    End Sub

    Private Sub Atualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Atualizar.Click
        Dim cont As Integer
        Dim tot As Single
        Dim vtemp As Single

        For cont = 0 To List_Produtos.Items.Count - 1
            vtemp = List_Produtos.Items.Item(cont).Text.ToString * List_Produtos.Items.Item(cont).SubItems(2).Text.ToString
            tot = vtemp + tot
        Next
        Total.Text = tot
    End Sub

    Private Sub List_Produtos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles List_Produtos.SelectedIndexChanged

    End Sub
End Class
