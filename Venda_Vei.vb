Public Class Venda_Vei
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
    Friend WithEvents cod_cli As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nome_cli As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Nome_vei As System.Windows.Forms.TextBox
    Friend WithEvents placa_vei As System.Windows.Forms.TextBox
    Friend WithEvents BTCadastra_cliente As System.Windows.Forms.Button
    Friend WithEvents BTCadastra_vei As System.Windows.Forms.Button
    Friend WithEvents Bt_Back As System.Windows.Forms.Button
    Friend WithEvents BTLocaliza_vei As System.Windows.Forms.Button
    Friend WithEvents BTLocaliza_Cli As System.Windows.Forms.Button
    Friend WithEvents Bt_venda As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Venda_Vei))
        Me.cod_cli = New System.Windows.Forms.TextBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Bt_Back = New System.Windows.Forms.Button
        Me.BTLocaliza_vei = New System.Windows.Forms.Button
        Me.BTLocaliza_Cli = New System.Windows.Forms.Button
        Me.BTCadastra_cliente = New System.Windows.Forms.Button
        Me.BTCadastra_vei = New System.Windows.Forms.Button
        Me.Bt_venda = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.nome_cli = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Nome_vei = New System.Windows.Forms.TextBox
        Me.placa_vei = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cod_cli
        '
        Me.cod_cli.Location = New System.Drawing.Point(160, 32)
        Me.cod_cli.Name = "cod_cli"
        Me.cod_cli.ReadOnly = True
        Me.cod_cli.TabIndex = 56
        Me.cod_cli.Text = "Codigo do Cliente"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(216, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 24)
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 66)
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'Bt_Back
        '
        Me.Bt_Back.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bt_Back.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Back.Image = CType(resources.GetObject("Bt_Back.Image"), System.Drawing.Image)
        Me.Bt_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_Back.Location = New System.Drawing.Point(184, 288)
        Me.Bt_Back.Name = "Bt_Back"
        Me.Bt_Back.Size = New System.Drawing.Size(75, 52)
        Me.Bt_Back.TabIndex = 63
        Me.Bt_Back.Text = "Voltar"
        Me.Bt_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BTLocaliza_vei
        '
        Me.BTLocaliza_vei.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTLocaliza_vei.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTLocaliza_vei.Image = CType(resources.GetObject("BTLocaliza_vei.Image"), System.Drawing.Image)
        Me.BTLocaliza_vei.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTLocaliza_vei.Location = New System.Drawing.Point(96, 288)
        Me.BTLocaliza_vei.Name = "BTLocaliza_vei"
        Me.BTLocaliza_vei.Size = New System.Drawing.Size(75, 52)
        Me.BTLocaliza_vei.TabIndex = 62
        Me.BTLocaliza_vei.Text = "Localizar veiculo"
        Me.BTLocaliza_vei.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BTLocaliza_Cli
        '
        Me.BTLocaliza_Cli.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTLocaliza_Cli.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTLocaliza_Cli.Image = CType(resources.GetObject("BTLocaliza_Cli.Image"), System.Drawing.Image)
        Me.BTLocaliza_Cli.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTLocaliza_Cli.Location = New System.Drawing.Point(8, 288)
        Me.BTLocaliza_Cli.Name = "BTLocaliza_Cli"
        Me.BTLocaliza_Cli.Size = New System.Drawing.Size(75, 52)
        Me.BTLocaliza_Cli.TabIndex = 61
        Me.BTLocaliza_Cli.Text = "Localizar cliente"
        Me.BTLocaliza_Cli.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BTCadastra_cliente
        '
        Me.BTCadastra_cliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTCadastra_cliente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCadastra_cliente.Image = CType(resources.GetObject("BTCadastra_cliente.Image"), System.Drawing.Image)
        Me.BTCadastra_cliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTCadastra_cliente.Location = New System.Drawing.Point(184, 232)
        Me.BTCadastra_cliente.Name = "BTCadastra_cliente"
        Me.BTCadastra_cliente.Size = New System.Drawing.Size(75, 52)
        Me.BTCadastra_cliente.TabIndex = 60
        Me.BTCadastra_cliente.Text = "Cadastrar cliente"
        Me.BTCadastra_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BTCadastra_vei
        '
        Me.BTCadastra_vei.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTCadastra_vei.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCadastra_vei.Image = CType(resources.GetObject("BTCadastra_vei.Image"), System.Drawing.Image)
        Me.BTCadastra_vei.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTCadastra_vei.Location = New System.Drawing.Point(96, 232)
        Me.BTCadastra_vei.Name = "BTCadastra_vei"
        Me.BTCadastra_vei.Size = New System.Drawing.Size(75, 52)
        Me.BTCadastra_vei.TabIndex = 59
        Me.BTCadastra_vei.Text = "Cadastrar veiculo"
        Me.BTCadastra_vei.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Bt_venda
        '
        Me.Bt_venda.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bt_venda.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_venda.Image = CType(resources.GetObject("Bt_venda.Image"), System.Drawing.Image)
        Me.Bt_venda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_venda.Location = New System.Drawing.Point(8, 232)
        Me.Bt_venda.Name = "Bt_venda"
        Me.Bt_venda.Size = New System.Drawing.Size(75, 52)
        Me.Bt_venda.TabIndex = 58
        Me.Bt_venda.Text = "Efetuar Venda"
        Me.Bt_venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(0, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 125)
        Me.Label4.TabIndex = 57
        '
        'nome_cli
        '
        Me.nome_cli.Location = New System.Drawing.Point(72, 88)
        Me.nome_cli.Name = "nome_cli"
        Me.nome_cli.Size = New System.Drawing.Size(184, 19)
        Me.nome_cli.TabIndex = 66
        Me.nome_cli.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Beige
        Me.Label2.Location = New System.Drawing.Point(0, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 15)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Veiculo:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(0, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 15)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Cliente:"
        '
        'Nome_vei
        '
        Me.Nome_vei.Location = New System.Drawing.Point(72, 120)
        Me.Nome_vei.Name = "Nome_vei"
        Me.Nome_vei.Size = New System.Drawing.Size(184, 19)
        Me.Nome_vei.TabIndex = 67
        Me.Nome_vei.Text = ""
        '
        'placa_vei
        '
        Me.placa_vei.Location = New System.Drawing.Point(160, 56)
        Me.placa_vei.Name = "placa_vei"
        Me.placa_vei.ReadOnly = True
        Me.placa_vei.TabIndex = 68
        Me.placa_vei.Text = "Placa do veiculo"
        '
        'Venda_Vei
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(264, 350)
        Me.Controls.Add(Me.placa_vei)
        Me.Controls.Add(Me.Nome_vei)
        Me.Controls.Add(Me.nome_cli)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bt_Back)
        Me.Controls.Add(Me.BTLocaliza_vei)
        Me.Controls.Add(Me.BTLocaliza_Cli)
        Me.Controls.Add(Me.BTCadastra_cliente)
        Me.Controls.Add(Me.BTCadastra_vei)
        Me.Controls.Add(Me.Bt_venda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cod_cli)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Venda_Vei"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venda de Veiculos"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub BTCadastra_vei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTCadastra_vei.Click
        cadastro_veiculos_venda.ShowDialog()

    End Sub

    Private Sub BTCadastra_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTCadastra_cliente.Click
        cadastrocli_alu.ShowDialog()
    End Sub

    Private Sub BTLocaliza_Cli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTLocaliza_Cli.Click
        loccli.ShowDialog()
    End Sub

    Private Sub BTLocaliza_vei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTLocaliza_vei.Click
        locvei_venda.ShowDialog()
    End Sub

    Private Sub Bt_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Back.Click
        Me.Close()

    End Sub

    Private Sub Bt_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_venda.Click

    End Sub
End Class
