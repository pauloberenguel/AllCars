Imports AllCars.Module1
Imports System.DateTime

Public Class frmaluguel
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
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents bt_devol As System.Windows.Forms.Button
    Friend WithEvents bt_cadvei As System.Windows.Forms.Button
    Friend WithEvents bt_back As System.Windows.Forms.Button
    Friend WithEvents bt_efetuar_aluguel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmaluguel))
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.bt_back = New System.Windows.Forms.Button
        Me.bt_efetuar_aluguel = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.bt_cadvei = New System.Windows.Forms.Button
        Me.bt_devol = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 40)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Aluguéis"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(440, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 264
        Me.Label4.Text = "Voltar"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(320, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 16)
        Me.Label13.TabIndex = 262
        Me.Label13.Text = "Efetua Aluguel"
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
        Me.bt_back.Location = New System.Drawing.Point(432, 8)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(56, 56)
        Me.bt_back.TabIndex = 260
        Me.bt_back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_efetuar_aluguel
        '
        Me.bt_efetuar_aluguel.BackColor = System.Drawing.Color.White
        Me.bt_efetuar_aluguel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_efetuar_aluguel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_efetuar_aluguel.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_efetuar_aluguel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_efetuar_aluguel.Image = CType(resources.GetObject("bt_efetuar_aluguel.Image"), System.Drawing.Image)
        Me.bt_efetuar_aluguel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_efetuar_aluguel.Location = New System.Drawing.Point(336, 8)
        Me.bt_efetuar_aluguel.Name = "bt_efetuar_aluguel"
        Me.bt_efetuar_aluguel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.bt_efetuar_aluguel.Size = New System.Drawing.Size(56, 56)
        Me.bt_efetuar_aluguel.TabIndex = 258
        Me.bt_efetuar_aluguel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(304, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(208, 152)
        Me.Label20.TabIndex = 261
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(336, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 267
        Me.Label14.Text = "Veú€ulos"
        '
        'bt_cadvei
        '
        Me.bt_cadvei.BackColor = System.Drawing.Color.White
        Me.bt_cadvei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_cadvei.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cadvei.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_cadvei.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cadvei.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_cadvei.Image = CType(resources.GetObject("bt_cadvei.Image"), System.Drawing.Image)
        Me.bt_cadvei.Location = New System.Drawing.Point(336, 80)
        Me.bt_cadvei.Name = "bt_cadvei"
        Me.bt_cadvei.Size = New System.Drawing.Size(56, 56)
        Me.bt_cadvei.TabIndex = 266
        Me.bt_cadvei.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_devol
        '
        Me.bt_devol.BackColor = System.Drawing.Color.White
        Me.bt_devol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_devol.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_devol.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_devol.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_devol.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_devol.Image = CType(resources.GetObject("bt_devol.Image"), System.Drawing.Image)
        Me.bt_devol.Location = New System.Drawing.Point(432, 80)
        Me.bt_devol.Name = "bt_devol"
        Me.bt_devol.Size = New System.Drawing.Size(56, 56)
        Me.bt_devol.TabIndex = 268
        Me.bt_devol.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(416, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 269
        Me.Label15.Text = "Devoluções"
        '
        'frmaluguel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(520, 149)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.bt_devol)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.bt_cadvei)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.bt_back)
        Me.Controls.Add(Me.bt_efetuar_aluguel)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmaluguel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alugueis"
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub bt_cadvei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cadvei.Click
        cadastro_veiculos_aluguel.Visible = True
        Me.Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        locvei.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        loccli.ShowDialog()
    End Sub



    Private Sub bt_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_back.Click
        Me.Visible = False
        principal.Visible = True
        principal.IconTray.Visible = False

    End Sub

    Private Sub bt_efetuar_aluguel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_efetuar_aluguel.Click
        Efetua_alu.Visible = True
        Me.Visible = False
    End Sub

    Private Sub bt_devol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_devol.Click
        devolve_alu.Visible = True
        Me.Visible = False
    End Sub

    Private Sub frmaluguel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
