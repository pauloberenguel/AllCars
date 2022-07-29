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
    Friend WithEvents Remover As System.Windows.Forms.Button
    Public WithEvents List_Produtos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Preco As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(produtos_mecanica))
        Me.Total = New System.Windows.Forms.TextBox
        Me.Remover = New System.Windows.Forms.Button
        Me.List_Produtos = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Preco = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.Button7 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Total
        '
        Me.Total.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Total.Location = New System.Drawing.Point(168, 199)
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.TabIndex = 61
        Me.Total.Text = ""
        '
        'Remover
        '
        Me.Remover.BackColor = System.Drawing.Color.AliceBlue
        Me.Remover.Location = New System.Drawing.Point(0, 269)
        Me.Remover.Name = "Remover"
        Me.Remover.Size = New System.Drawing.Size(64, 26)
        Me.Remover.TabIndex = 59
        Me.Remover.Text = "Remover"
        '
        'List_Produtos
        '
        Me.List_Produtos.AllowDrop = True
        Me.List_Produtos.AutoArrange = False
        Me.List_Produtos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.List_Produtos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader2, Me.ColumnHeader4, Me.Preco, Me.ColumnHeader1})
        Me.List_Produtos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.List_Produtos.FullRowSelect = True
        Me.List_Produtos.GridLines = True
        Me.List_Produtos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.List_Produtos.HoverSelection = True
        Me.List_Produtos.ImeMode = System.Windows.Forms.ImeMode.On
        Me.List_Produtos.LabelEdit = True
        Me.List_Produtos.LabelWrap = False
        Me.List_Produtos.Location = New System.Drawing.Point(0, 52)
        Me.List_Produtos.MultiSelect = False
        Me.List_Produtos.Name = "List_Produtos"
        Me.List_Produtos.Size = New System.Drawing.Size(272, 130)
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
        Me.ColumnHeader2.Width = 65
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Marca"
        Me.ColumnHeader4.Width = 75
        '
        'Preco
        '
        Me.Preco.Text = "Preço Unit."
        Me.Preco.Width = 62
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
        Me.Label3.Location = New System.Drawing.Point(168, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Total"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 40)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Produtos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(16, 199)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 68
        Me.PictureBox3.TabStop = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Lime
        Me.LinkLabel2.Location = New System.Drawing.Point(48, 225)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(100, 18)
        Me.LinkLabel2.TabIndex = 67
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Adicionar Produto"
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.Lime
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(216, 234)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 61)
        Me.Button7.TabIndex = 253
        Me.Button7.Text = "Voltar"
        '
        'produtos_mecanica
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(274, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Remover)
        Me.Controls.Add(Me.List_Produtos)
        Me.Controls.Add(Me.Label3)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "produtos_mecanica"
        Me.Text = "Produtos"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "basica"
    Private Sub Remover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remover.Click
        List_Produtos.FocusedItem.Remove()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        locprod.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        locprod.ShowDialog()
    End Sub

    Private Sub List_Produtos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles List_Produtos.KeyDown
        Dim cont As Integer
        Dim tot As Single
        Dim vtemp As Single

        For cont = 0 To List_Produtos.Items.Count - 1
            vtemp = Val(List_Produtos.Items.Item(cont).Text * List_Produtos.Items.Item(cont).SubItems(3).Text)
            tot = vtemp + tot
        Next
        Total.Text = tot
        Mec.txt_prodtotal.Text = tot

    End Sub

    Private Sub List_Produtos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles List_Produtos.MouseMove
        Dim cont As Integer
        Dim tot As Single
        Dim vtemp As Single

        For cont = 0 To List_Produtos.Items.Count - 1
            vtemp = Val(List_Produtos.Items.Item(cont).Text * List_Produtos.Items.Item(cont).SubItems(3).Text)
            tot = vtemp + tot
        Next
        Total.Text = tot
        Mec.txt_prodtotal.Text = tot
    End Sub

    Private Sub List_Produtos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles List_Produtos.SelectedIndexChanged
        Dim cont As Integer
        Dim tot As Single
        Dim vtemp As Single

        For cont = 0 To List_Produtos.Items.Count - 1
            vtemp = Val(List_Produtos.Items.Item(cont).Text * List_Produtos.Items.Item(cont).SubItems(3).Text)
            tot = vtemp + tot
        Next
        Total.Text = tot
        Mec.txt_prodtotal.Text = tot
    End Sub


#End Region



End Class
