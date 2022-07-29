Public Class produtos_mecanica
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
    Friend WithEvents Total As System.Windows.Forms.TextBox
    Friend WithEvents Atualizar As System.Windows.Forms.Button
    Friend WithEvents Remover As System.Windows.Forms.Button
    Public WithEvents List_Produtos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Preco As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(produtos_mecanica))
        Me.Total = New System.Windows.Forms.TextBox
        Me.Atualizar = New System.Windows.Forms.Button
        Me.Remover = New System.Windows.Forms.Button
        Me.List_Produtos = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Preco = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Total
        '
        Me.Total.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Total.Location = New System.Drawing.Point(168, 168)
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.TabIndex = 61
        Me.Total.Text = ""
        '
        'Atualizar
        '
        Me.Atualizar.BackColor = System.Drawing.Color.AliceBlue
        Me.Atualizar.Location = New System.Drawing.Point(88, 160)
        Me.Atualizar.Name = "Atualizar"
        Me.Atualizar.Size = New System.Drawing.Size(64, 24)
        Me.Atualizar.TabIndex = 60
        Me.Atualizar.Text = "$ Total"
        '
        'Remover
        '
        Me.Remover.BackColor = System.Drawing.Color.AliceBlue
        Me.Remover.Location = New System.Drawing.Point(8, 160)
        Me.Remover.Name = "Remover"
        Me.Remover.Size = New System.Drawing.Size(64, 24)
        Me.Remover.TabIndex = 59
        Me.Remover.Text = "Remover"
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
        Me.List_Produtos.Location = New System.Drawing.Point(8, 56)
        Me.List_Produtos.MultiSelect = False
        Me.List_Produtos.Name = "List_Produtos"
        Me.List_Produtos.Size = New System.Drawing.Size(264, 89)
        Me.List_Produtos.TabIndex = 58
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
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Beige
        Me.Label3.Location = New System.Drawing.Point(168, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Total"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(40, 200)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 63
        Me.Button3.Text = "Localizar produtos"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(160, 200)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 40)
        Me.Button6.TabIndex = 65
        Me.Button6.Text = "Voltar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 37)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Produtos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'produtos_mecanica
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(280, 248)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Atualizar)
        Me.Controls.Add(Me.Remover)
        Me.Controls.Add(Me.List_Produtos)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "produtos_mecanica"
        Me.Text = "Produtos"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Atualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Atualizar.Click
        Dim cont As Integer
        Dim tot As Single
        Dim vtemp As Single

        For cont = 0 To List_Produtos.Items.Count - 1
            vtemp = List_Produtos.Items.Item(cont).Text.ToString * List_Produtos.Items.Item(cont).SubItems(2).Text.ToString
            tot = vtemp + tot
        Next
        Total.Text = tot
        Mec.txt_prodtotal.Text = tot
    End Sub

    Private Sub Remover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remover.Click
        List_Produtos.FocusedItem.Remove()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        locprod.ShowDialog()
    End Sub
End Class
