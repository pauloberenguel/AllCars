Imports System.Drawing.Drawing2D

Public Class index_fin
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_fechar As System.Windows.Forms.Button
    Friend WithEvents link_consultas As System.Windows.Forms.LinkLabel
    Friend WithEvents link_caixa As System.Windows.Forms.LinkLabel
    Friend WithEvents link_pagamentos As System.Windows.Forms.LinkLabel
    Friend WithEvents link_bp As System.Windows.Forms.LinkLabel
    Friend WithEvents bt_pagamentos As System.Windows.Forms.PictureBox
    Friend WithEvents bt_caixa As System.Windows.Forms.PictureBox
    Friend WithEvents bt_bp As System.Windows.Forms.PictureBox
    Friend WithEvents bt_consultas As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(index_fin))
        Me.Label2 = New System.Windows.Forms.Label
        Me.bt_fechar = New System.Windows.Forms.Button
        Me.link_consultas = New System.Windows.Forms.LinkLabel
        Me.link_caixa = New System.Windows.Forms.LinkLabel
        Me.link_pagamentos = New System.Windows.Forms.LinkLabel
        Me.link_bp = New System.Windows.Forms.LinkLabel
        Me.bt_pagamentos = New System.Windows.Forms.PictureBox
        Me.bt_caixa = New System.Windows.Forms.PictureBox
        Me.bt_bp = New System.Windows.Forms.PictureBox
        Me.bt_consultas = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(168, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 40)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Finanças"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_fechar
        '
        Me.bt_fechar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_fechar.Location = New System.Drawing.Point(456, 8)
        Me.bt_fechar.Name = "bt_fechar"
        Me.bt_fechar.Size = New System.Drawing.Size(24, 24)
        Me.bt_fechar.TabIndex = 76
        Me.bt_fechar.Text = "X"
        '
        'link_consultas
        '
        Me.link_consultas.ActiveLinkColor = System.Drawing.Color.Gold
        Me.link_consultas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.link_consultas.DisabledLinkColor = System.Drawing.Color.Gold
        Me.link_consultas.Font = New System.Drawing.Font("Niagara Engraved", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_consultas.ForeColor = System.Drawing.Color.Gold
        Me.link_consultas.LinkColor = System.Drawing.Color.Aqua
        Me.link_consultas.Location = New System.Drawing.Point(272, 156)
        Me.link_consultas.Name = "link_consultas"
        Me.link_consultas.Size = New System.Drawing.Size(64, 35)
        Me.link_consultas.TabIndex = 77
        Me.link_consultas.TabStop = True
        Me.link_consultas.Text = "Consultas"
        '
        'link_caixa
        '
        Me.link_caixa.ActiveLinkColor = System.Drawing.Color.Gold
        Me.link_caixa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.link_caixa.DisabledLinkColor = System.Drawing.Color.Gold
        Me.link_caixa.Font = New System.Drawing.Font("Niagara Engraved", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_caixa.ForeColor = System.Drawing.Color.Gold
        Me.link_caixa.LinkColor = System.Drawing.Color.Aqua
        Me.link_caixa.Location = New System.Drawing.Point(16, 160)
        Me.link_caixa.Name = "link_caixa"
        Me.link_caixa.Size = New System.Drawing.Size(88, 34)
        Me.link_caixa.TabIndex = 78
        Me.link_caixa.TabStop = True
        Me.link_caixa.Text = "Recebimentos"
        '
        'link_pagamentos
        '
        Me.link_pagamentos.ActiveLinkColor = System.Drawing.Color.Gold
        Me.link_pagamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.link_pagamentos.DisabledLinkColor = System.Drawing.Color.Gold
        Me.link_pagamentos.Font = New System.Drawing.Font("Niagara Engraved", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_pagamentos.ForeColor = System.Drawing.Color.Gold
        Me.link_pagamentos.LinkColor = System.Drawing.Color.Aqua
        Me.link_pagamentos.Location = New System.Drawing.Point(144, 176)
        Me.link_pagamentos.Name = "link_pagamentos"
        Me.link_pagamentos.Size = New System.Drawing.Size(80, 34)
        Me.link_pagamentos.TabIndex = 79
        Me.link_pagamentos.TabStop = True
        Me.link_pagamentos.Text = "Pagamentos"
        '
        'link_bp
        '
        Me.link_bp.ActiveLinkColor = System.Drawing.Color.Gold
        Me.link_bp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.link_bp.DisabledLinkColor = System.Drawing.Color.Gold
        Me.link_bp.Font = New System.Drawing.Font("Niagara Engraved", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_bp.ForeColor = System.Drawing.Color.Gold
        Me.link_bp.LinkColor = System.Drawing.Color.Aqua
        Me.link_bp.Location = New System.Drawing.Point(376, 160)
        Me.link_bp.Name = "link_bp"
        Me.link_bp.Size = New System.Drawing.Size(96, 61)
        Me.link_bp.TabIndex = 80
        Me.link_bp.TabStop = True
        Me.link_bp.Text = "Balanço Patrimonial"
        Me.link_bp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'bt_pagamentos
        '
        Me.bt_pagamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_pagamentos.Image = CType(resources.GetObject("bt_pagamentos.Image"), System.Drawing.Image)
        Me.bt_pagamentos.Location = New System.Drawing.Point(144, 61)
        Me.bt_pagamentos.Name = "bt_pagamentos"
        Me.bt_pagamentos.Size = New System.Drawing.Size(80, 86)
        Me.bt_pagamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bt_pagamentos.TabIndex = 83
        Me.bt_pagamentos.TabStop = False
        '
        'bt_caixa
        '
        Me.bt_caixa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_caixa.Image = CType(resources.GetObject("bt_caixa.Image"), System.Drawing.Image)
        Me.bt_caixa.Location = New System.Drawing.Point(16, 43)
        Me.bt_caixa.Name = "bt_caixa"
        Me.bt_caixa.Size = New System.Drawing.Size(80, 87)
        Me.bt_caixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bt_caixa.TabIndex = 84
        Me.bt_caixa.TabStop = False
        '
        'bt_bp
        '
        Me.bt_bp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_bp.Image = CType(resources.GetObject("bt_bp.Image"), System.Drawing.Image)
        Me.bt_bp.Location = New System.Drawing.Point(384, 56)
        Me.bt_bp.Name = "bt_bp"
        Me.bt_bp.Size = New System.Drawing.Size(80, 86)
        Me.bt_bp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bt_bp.TabIndex = 85
        Me.bt_bp.TabStop = False
        '
        'bt_consultas
        '
        Me.bt_consultas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_consultas.Image = CType(resources.GetObject("bt_consultas.Image"), System.Drawing.Image)
        Me.bt_consultas.Location = New System.Drawing.Point(264, 43)
        Me.bt_consultas.Name = "bt_consultas"
        Me.bt_consultas.Size = New System.Drawing.Size(80, 87)
        Me.bt_consultas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bt_consultas.TabIndex = 86
        Me.bt_consultas.TabStop = False
        '
        'index_fin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(488, 208)
        Me.ControlBox = False
        Me.Controls.Add(Me.bt_consultas)
        Me.Controls.Add(Me.bt_bp)
        Me.Controls.Add(Me.bt_caixa)
        Me.Controls.Add(Me.bt_pagamentos)
        Me.Controls.Add(Me.link_bp)
        Me.Controls.Add(Me.link_pagamentos)
        Me.Controls.Add(Me.link_caixa)
        Me.Controls.Add(Me.link_consultas)
        Me.Controls.Add(Me.bt_fechar)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "index_fin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finanças"
        Me.ResumeLayout(False)

    End Sub



#End Region

#Region "Mouse"
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    Private Sub frmSplForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If

    End Sub

    Private Sub frmSplForm_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub frmSplForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        Dim xOffset As Integer
        Dim yOffset As Integer

        If e.Button = MouseButtons.Left Then
            xOffset = -e.X - SystemInformation.FrameBorderSize.Width
            yOffset = -e.Y - SystemInformation.CaptionHeight - _
                    SystemInformation.FrameBorderSize.Height
            mouseOffset = New Point(xOffset, yOffset)
            isMouseDown = True
        End If
    End Sub

#End Region

    Private Sub bt_fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_fechar.Click
        Me.Visible = False
        principal.Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub index_fin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bolinha As New GraphicsPath
        bolinha.AddPie(0, 0, 80, 80, 0, 360)
        bt_caixa.Region = New Region(bolinha)
        bt_consultas.Region = New Region(bolinha)
        bt_pagamentos.Region = New Region(bolinha)
        bt_bp.Region = New Region(bolinha)
        bt_fechar.Region = New Region(bolinha)
    End Sub

    Private Sub bt_caixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_caixa.Click
        receive.Visible = True
        Me.Visible = False

    End Sub

    Private Sub link_caixa_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_caixa.LinkClicked

    End Sub

    Private Sub bt_consultas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_consultas.Click
        consul.Visible = True
        Me.Visible = False

    End Sub

    Private Sub link_consultas_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_consultas.LinkClicked

    End Sub

    Private Sub bt_pagamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_pagamentos.Click
        pgtos.Visible = True
        Me.Visible = False

    End Sub

    Private Sub link_pagamentos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_pagamentos.LinkClicked

    End Sub

    Private Sub bt_bp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_bp.Click
        balanco_pat.Visible = True
        Me.Visible = False

    End Sub

    Private Sub link_bp_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_bp.LinkClicked

    End Sub

    Private Sub bt_caixa_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt_caixa.MouseEnter
        link_caixa.LinkColor = Color.Gold
    End Sub

    Private Sub bt_caixa_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt_caixa.MouseLeave
        link_caixa.LinkColor = Color.Aqua
    End Sub

    Private Sub bt_pagamentos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt_pagamentos.MouseEnter
        link_pagamentos.LinkColor = Color.Gold

    End Sub

    Private Sub bt_pagamentos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt_pagamentos.MouseLeave
        link_pagamentos.LinkColor = Color.Aqua
    End Sub

    Private Sub bt_consultas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt_consultas.MouseEnter
        link_consultas.LinkColor = Color.Gold

    End Sub

    Private Sub bt_consultas_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt_consultas.MouseLeave
        link_consultas.LinkColor = Color.Aqua

    End Sub

    Private Sub bt_bp_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt_bp.MouseEnter
        link_bp.LinkColor = Color.Gold

    End Sub

    Private Sub bt_bp_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt_bp.MouseLeave
        link_bp.LinkColor = Color.Aqua
    End Sub
End Class
