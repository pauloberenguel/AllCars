Imports AllCars.Module1
Public Class frminicio2
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtProd As System.Windows.Forms.Button
    Friend WithEvents btVei As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Bt_usados As System.Windows.Forms.Button
    Friend WithEvents bt_novos As System.Windows.Forms.Button
    Friend WithEvents Bt_Compra As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Bt_Cvei As System.Windows.Forms.Button
    Friend WithEvents bt_cprod As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BT_COLD As System.Windows.Forms.Button
    Friend WithEvents Bt_CNew As System.Windows.Forms.Button
    Friend WithEvents ProvedordAjuda As System.Windows.Forms.HelpProvider
    Friend WithEvents MenuPrincipal As System.Windows.Forms.MainMenu
    Friend WithEvents FerramentaDica As System.Windows.Forms.ToolTip
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents Menuzinho As System.Windows.Forms.ContextMenu
    Friend WithEvents Menu_Abrir As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Sair As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Aluguel As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Compra As System.Windows.Forms.MenuItem
    Friend WithEvents MenuForn As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Fun As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_mec As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_vend As System.Windows.Forms.MenuItem
    Friend WithEvents venda_prod As System.Windows.Forms.MenuItem
    Friend WithEvents Venda_vei As System.Windows.Forms.MenuItem
    Friend WithEvents venda_newvei As System.Windows.Forms.MenuItem
    Friend WithEvents venda_oldvei As System.Windows.Forms.MenuItem
    Friend WithEvents compra_prod As System.Windows.Forms.MenuItem
    Friend WithEvents compra_vei As System.Windows.Forms.MenuItem
    Friend WithEvents compra_newvei As System.Windows.Forms.MenuItem
    Friend WithEvents compra_oldvei As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Cliente As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents bt_financas As System.Windows.Forms.Button
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents menu_cli As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_aluguel As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_buy As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_buyProd As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_buy_newvei As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_buy_oldvei As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_finan As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_forn As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_fun As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_mec As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_sell As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_sell_prod As System.Windows.Forms.MenuItem
    Friend WithEvents menu_sell_newvei As System.Windows.Forms.MenuItem
    Friend WithEvents menu_sell_oldvei As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_logoff As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_sair As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_systray As System.Windows.Forms.MenuItem
    Public WithEvents IconTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents mnu_users As System.Windows.Forms.MenuItem
    Friend WithEvents bt_mec As System.Windows.Forms.Button
    Friend WithEvents bt_vendas As System.Windows.Forms.Button
    Friend WithEvents bt_alugueis As System.Windows.Forms.Button
    Friend WithEvents bt_func As System.Windows.Forms.Button
    Friend WithEvents bt_forn As System.Windows.Forms.Button
    Friend WithEvents Menu_users As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frminicio2))
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.bt_func = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.bt_alugueis = New System.Windows.Forms.Button
        Me.bt_vendas = New System.Windows.Forms.Button
        Me.bt_mec = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.bt_forn = New System.Windows.Forms.Button
        Me.ProvedordAjuda = New System.Windows.Forms.HelpProvider
        Me.Bt_Compra = New System.Windows.Forms.Button
        Me.bt_financas = New System.Windows.Forms.Button
        Me.BtProd = New System.Windows.Forms.Button
        Me.btVei = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Bt_usados = New System.Windows.Forms.Button
        Me.bt_novos = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Bt_Cvei = New System.Windows.Forms.Button
        Me.bt_cprod = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.BT_COLD = New System.Windows.Forms.Button
        Me.Bt_CNew = New System.Windows.Forms.Button
        Me.MenuPrincipal = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.menu_cli = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.mnu_aluguel = New System.Windows.Forms.MenuItem
        Me.mnu_buy = New System.Windows.Forms.MenuItem
        Me.mnu_buyProd = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.mnu_buy_newvei = New System.Windows.Forms.MenuItem
        Me.mnu_buy_oldvei = New System.Windows.Forms.MenuItem
        Me.mnu_finan = New System.Windows.Forms.MenuItem
        Me.mnu_forn = New System.Windows.Forms.MenuItem
        Me.mnu_fun = New System.Windows.Forms.MenuItem
        Me.mnu_mec = New System.Windows.Forms.MenuItem
        Me.mnu_sell = New System.Windows.Forms.MenuItem
        Me.mnu_sell_prod = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.menu_sell_newvei = New System.Windows.Forms.MenuItem
        Me.menu_sell_oldvei = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.mnu_logoff = New System.Windows.Forms.MenuItem
        Me.mnu_sair = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.mnu_systray = New System.Windows.Forms.MenuItem
        Me.mnu_users = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.FerramentaDica = New System.Windows.Forms.ToolTip(Me.components)
        Me.IconTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Menuzinho = New System.Windows.Forms.ContextMenu
        Me.Menu_Abrir = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.Menu_Cliente = New System.Windows.Forms.MenuItem
        Me.Menu_Aluguel = New System.Windows.Forms.MenuItem
        Me.Menu_Compra = New System.Windows.Forms.MenuItem
        Me.compra_prod = New System.Windows.Forms.MenuItem
        Me.compra_vei = New System.Windows.Forms.MenuItem
        Me.compra_newvei = New System.Windows.Forms.MenuItem
        Me.compra_oldvei = New System.Windows.Forms.MenuItem
        Me.MenuForn = New System.Windows.Forms.MenuItem
        Me.Menu_Fun = New System.Windows.Forms.MenuItem
        Me.Menu_mec = New System.Windows.Forms.MenuItem
        Me.Menu_users = New System.Windows.Forms.MenuItem
        Me.Menu_vend = New System.Windows.Forms.MenuItem
        Me.venda_prod = New System.Windows.Forms.MenuItem
        Me.Venda_vei = New System.Windows.Forms.MenuItem
        Me.venda_newvei = New System.Windows.Forms.MenuItem
        Me.venda_oldvei = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.Menu_Sair = New System.Windows.Forms.MenuItem
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = resources.GetString("Label3.AccessibleDescription")
        Me.Label3.AccessibleName = resources.GetString("Label3.AccessibleName")
        Me.Label3.Anchor = CType(resources.GetObject("Label3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = CType(resources.GetObject("Label3.AutoSize"), Boolean)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = CType(resources.GetObject("Label3.Dock"), System.Windows.Forms.DockStyle)
        Me.Label3.Enabled = CType(resources.GetObject("Label3.Enabled"), Boolean)
        Me.Label3.Font = CType(resources.GetObject("Label3.Font"), System.Drawing.Font)
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ProvedordAjuda.SetHelpKeyword(Me.Label3, resources.GetString("Label3.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Label3, CType(resources.GetObject("Label3.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Label3, resources.GetString("Label3.HelpString"))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = CType(resources.GetObject("Label3.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label3.ImageIndex = CType(resources.GetObject("Label3.ImageIndex"), Integer)
        Me.Label3.ImeMode = CType(resources.GetObject("Label3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label3.Location = CType(resources.GetObject("Label3.Location"), System.Drawing.Point)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = CType(resources.GetObject("Label3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.Label3, CType(resources.GetObject("Label3.ShowHelp"), Boolean))
        Me.Label3.Size = CType(resources.GetObject("Label3.Size"), System.Drawing.Size)
        Me.Label3.TabIndex = CType(resources.GetObject("Label3.TabIndex"), Integer)
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = CType(resources.GetObject("Label3.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        Me.Label3.Visible = CType(resources.GetObject("Label3.Visible"), Boolean)
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = resources.GetString("Label2.AccessibleDescription")
        Me.Label2.AccessibleName = resources.GetString("Label2.AccessibleName")
        Me.Label2.Anchor = CType(resources.GetObject("Label2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = CType(resources.GetObject("Label2.AutoSize"), Boolean)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = CType(resources.GetObject("Label2.Dock"), System.Windows.Forms.DockStyle)
        Me.Label2.Enabled = CType(resources.GetObject("Label2.Enabled"), Boolean)
        Me.Label2.Font = CType(resources.GetObject("Label2.Font"), System.Drawing.Font)
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ProvedordAjuda.SetHelpKeyword(Me.Label2, resources.GetString("Label2.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Label2, CType(resources.GetObject("Label2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Label2, resources.GetString("Label2.HelpString"))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = CType(resources.GetObject("Label2.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label2.ImageIndex = CType(resources.GetObject("Label2.ImageIndex"), Integer)
        Me.Label2.ImeMode = CType(resources.GetObject("Label2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label2.Location = CType(resources.GetObject("Label2.Location"), System.Drawing.Point)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = CType(resources.GetObject("Label2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.Label2, CType(resources.GetObject("Label2.ShowHelp"), Boolean))
        Me.Label2.Size = CType(resources.GetObject("Label2.Size"), System.Drawing.Size)
        Me.Label2.TabIndex = CType(resources.GetObject("Label2.TabIndex"), Integer)
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = CType(resources.GetObject("Label2.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.Label2, resources.GetString("Label2.ToolTip"))
        Me.Label2.Visible = CType(resources.GetObject("Label2.Visible"), Boolean)
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = resources.GetString("PictureBox1.AccessibleDescription")
        Me.PictureBox1.AccessibleName = resources.GetString("PictureBox1.AccessibleName")
        Me.PictureBox1.Anchor = CType(resources.GetObject("PictureBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Dock = CType(resources.GetObject("PictureBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.PictureBox1.Enabled = CType(resources.GetObject("PictureBox1.Enabled"), Boolean)
        Me.PictureBox1.Font = CType(resources.GetObject("PictureBox1.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.PictureBox1, resources.GetString("PictureBox1.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.PictureBox1, CType(resources.GetObject("PictureBox1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.PictureBox1, resources.GetString("PictureBox1.HelpString"))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = CType(resources.GetObject("PictureBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.PictureBox1.Location = CType(resources.GetObject("PictureBox1.Location"), System.Drawing.Point)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.RightToLeft = CType(resources.GetObject("PictureBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.PictureBox1, CType(resources.GetObject("PictureBox1.ShowHelp"), Boolean))
        Me.PictureBox1.Size = CType(resources.GetObject("PictureBox1.Size"), System.Drawing.Size)
        Me.PictureBox1.SizeMode = CType(resources.GetObject("PictureBox1.SizeMode"), System.Windows.Forms.PictureBoxSizeMode)
        Me.PictureBox1.TabIndex = CType(resources.GetObject("PictureBox1.TabIndex"), Integer)
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Text = resources.GetString("PictureBox1.Text")
        Me.FerramentaDica.SetToolTip(Me.PictureBox1, resources.GetString("PictureBox1.ToolTip"))
        Me.PictureBox1.Visible = CType(resources.GetObject("PictureBox1.Visible"), Boolean)
        '
        'bt_func
        '
        Me.bt_func.AccessibleDescription = resources.GetString("bt_func.AccessibleDescription")
        Me.bt_func.AccessibleName = resources.GetString("bt_func.AccessibleName")
        Me.bt_func.Anchor = CType(resources.GetObject("bt_func.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.bt_func.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_func.BackgroundImage = CType(resources.GetObject("bt_func.BackgroundImage"), System.Drawing.Image)
        Me.bt_func.Dock = CType(resources.GetObject("bt_func.Dock"), System.Windows.Forms.DockStyle)
        Me.bt_func.Enabled = CType(resources.GetObject("bt_func.Enabled"), Boolean)
        Me.bt_func.FlatStyle = CType(resources.GetObject("bt_func.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.bt_func.Font = CType(resources.GetObject("bt_func.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_func, resources.GetString("bt_func.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_func, CType(resources.GetObject("bt_func.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_func, resources.GetString("bt_func.HelpString"))
        Me.bt_func.Image = CType(resources.GetObject("bt_func.Image"), System.Drawing.Image)
        Me.bt_func.ImageAlign = CType(resources.GetObject("bt_func.ImageAlign"), System.Drawing.ContentAlignment)
        Me.bt_func.ImageIndex = CType(resources.GetObject("bt_func.ImageIndex"), Integer)
        Me.bt_func.ImeMode = CType(resources.GetObject("bt_func.ImeMode"), System.Windows.Forms.ImeMode)
        Me.bt_func.Location = CType(resources.GetObject("bt_func.Location"), System.Drawing.Point)
        Me.bt_func.Name = "bt_func"
        Me.bt_func.RightToLeft = CType(resources.GetObject("bt_func.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.bt_func, CType(resources.GetObject("bt_func.ShowHelp"), Boolean))
        Me.bt_func.Size = CType(resources.GetObject("bt_func.Size"), System.Drawing.Size)
        Me.bt_func.TabIndex = CType(resources.GetObject("bt_func.TabIndex"), Integer)
        Me.bt_func.Text = resources.GetString("bt_func.Text")
        Me.bt_func.TextAlign = CType(resources.GetObject("bt_func.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.bt_func, resources.GetString("bt_func.ToolTip"))
        Me.bt_func.Visible = CType(resources.GetObject("bt_func.Visible"), Boolean)
        '
        'PictureBox2
        '
        Me.PictureBox2.AccessibleDescription = resources.GetString("PictureBox2.AccessibleDescription")
        Me.PictureBox2.AccessibleName = resources.GetString("PictureBox2.AccessibleName")
        Me.PictureBox2.Anchor = CType(resources.GetObject("PictureBox2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Dock = CType(resources.GetObject("PictureBox2.Dock"), System.Windows.Forms.DockStyle)
        Me.PictureBox2.Enabled = CType(resources.GetObject("PictureBox2.Enabled"), Boolean)
        Me.PictureBox2.Font = CType(resources.GetObject("PictureBox2.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.PictureBox2, resources.GetString("PictureBox2.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.PictureBox2, CType(resources.GetObject("PictureBox2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.PictureBox2, resources.GetString("PictureBox2.HelpString"))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = CType(resources.GetObject("PictureBox2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.PictureBox2.Location = CType(resources.GetObject("PictureBox2.Location"), System.Drawing.Point)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.RightToLeft = CType(resources.GetObject("PictureBox2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.PictureBox2, CType(resources.GetObject("PictureBox2.ShowHelp"), Boolean))
        Me.PictureBox2.Size = CType(resources.GetObject("PictureBox2.Size"), System.Drawing.Size)
        Me.PictureBox2.SizeMode = CType(resources.GetObject("PictureBox2.SizeMode"), System.Windows.Forms.PictureBoxSizeMode)
        Me.PictureBox2.TabIndex = CType(resources.GetObject("PictureBox2.TabIndex"), Integer)
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Text = resources.GetString("PictureBox2.Text")
        Me.FerramentaDica.SetToolTip(Me.PictureBox2, resources.GetString("PictureBox2.ToolTip"))
        Me.PictureBox2.Visible = CType(resources.GetObject("PictureBox2.Visible"), Boolean)
        '
        'bt_alugueis
        '
        Me.bt_alugueis.AccessibleDescription = resources.GetString("bt_alugueis.AccessibleDescription")
        Me.bt_alugueis.AccessibleName = resources.GetString("bt_alugueis.AccessibleName")
        Me.bt_alugueis.Anchor = CType(resources.GetObject("bt_alugueis.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.bt_alugueis.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_alugueis.BackgroundImage = CType(resources.GetObject("bt_alugueis.BackgroundImage"), System.Drawing.Image)
        Me.bt_alugueis.Dock = CType(resources.GetObject("bt_alugueis.Dock"), System.Windows.Forms.DockStyle)
        Me.bt_alugueis.Enabled = CType(resources.GetObject("bt_alugueis.Enabled"), Boolean)
        Me.bt_alugueis.FlatStyle = CType(resources.GetObject("bt_alugueis.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.bt_alugueis.Font = CType(resources.GetObject("bt_alugueis.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_alugueis, resources.GetString("bt_alugueis.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_alugueis, CType(resources.GetObject("bt_alugueis.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_alugueis, resources.GetString("bt_alugueis.HelpString"))
        Me.bt_alugueis.Image = CType(resources.GetObject("bt_alugueis.Image"), System.Drawing.Image)
        Me.bt_alugueis.ImageAlign = CType(resources.GetObject("bt_alugueis.ImageAlign"), System.Drawing.ContentAlignment)
        Me.bt_alugueis.ImageIndex = CType(resources.GetObject("bt_alugueis.ImageIndex"), Integer)
        Me.bt_alugueis.ImeMode = CType(resources.GetObject("bt_alugueis.ImeMode"), System.Windows.Forms.ImeMode)
        Me.bt_alugueis.Location = CType(resources.GetObject("bt_alugueis.Location"), System.Drawing.Point)
        Me.bt_alugueis.Name = "bt_alugueis"
        Me.bt_alugueis.RightToLeft = CType(resources.GetObject("bt_alugueis.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.bt_alugueis, CType(resources.GetObject("bt_alugueis.ShowHelp"), Boolean))
        Me.bt_alugueis.Size = CType(resources.GetObject("bt_alugueis.Size"), System.Drawing.Size)
        Me.bt_alugueis.TabIndex = CType(resources.GetObject("bt_alugueis.TabIndex"), Integer)
        Me.bt_alugueis.Text = resources.GetString("bt_alugueis.Text")
        Me.bt_alugueis.TextAlign = CType(resources.GetObject("bt_alugueis.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.bt_alugueis, resources.GetString("bt_alugueis.ToolTip"))
        Me.bt_alugueis.Visible = CType(resources.GetObject("bt_alugueis.Visible"), Boolean)
        '
        'bt_vendas
        '
        Me.bt_vendas.AccessibleDescription = resources.GetString("bt_vendas.AccessibleDescription")
        Me.bt_vendas.AccessibleName = resources.GetString("bt_vendas.AccessibleName")
        Me.bt_vendas.Anchor = CType(resources.GetObject("bt_vendas.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.bt_vendas.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_vendas.BackgroundImage = CType(resources.GetObject("bt_vendas.BackgroundImage"), System.Drawing.Image)
        Me.bt_vendas.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_vendas.Dock = CType(resources.GetObject("bt_vendas.Dock"), System.Windows.Forms.DockStyle)
        Me.bt_vendas.Enabled = CType(resources.GetObject("bt_vendas.Enabled"), Boolean)
        Me.bt_vendas.FlatStyle = CType(resources.GetObject("bt_vendas.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.bt_vendas.Font = CType(resources.GetObject("bt_vendas.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_vendas, resources.GetString("bt_vendas.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_vendas, CType(resources.GetObject("bt_vendas.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_vendas, resources.GetString("bt_vendas.HelpString"))
        Me.bt_vendas.Image = CType(resources.GetObject("bt_vendas.Image"), System.Drawing.Image)
        Me.bt_vendas.ImageAlign = CType(resources.GetObject("bt_vendas.ImageAlign"), System.Drawing.ContentAlignment)
        Me.bt_vendas.ImageIndex = CType(resources.GetObject("bt_vendas.ImageIndex"), Integer)
        Me.bt_vendas.ImeMode = CType(resources.GetObject("bt_vendas.ImeMode"), System.Windows.Forms.ImeMode)
        Me.bt_vendas.Location = CType(resources.GetObject("bt_vendas.Location"), System.Drawing.Point)
        Me.bt_vendas.Name = "bt_vendas"
        Me.bt_vendas.RightToLeft = CType(resources.GetObject("bt_vendas.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.bt_vendas, CType(resources.GetObject("bt_vendas.ShowHelp"), Boolean))
        Me.bt_vendas.Size = CType(resources.GetObject("bt_vendas.Size"), System.Drawing.Size)
        Me.bt_vendas.TabIndex = CType(resources.GetObject("bt_vendas.TabIndex"), Integer)
        Me.bt_vendas.Text = resources.GetString("bt_vendas.Text")
        Me.bt_vendas.TextAlign = CType(resources.GetObject("bt_vendas.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.bt_vendas, resources.GetString("bt_vendas.ToolTip"))
        Me.bt_vendas.Visible = CType(resources.GetObject("bt_vendas.Visible"), Boolean)
        '
        'bt_mec
        '
        Me.bt_mec.AccessibleDescription = resources.GetString("bt_mec.AccessibleDescription")
        Me.bt_mec.AccessibleName = resources.GetString("bt_mec.AccessibleName")
        Me.bt_mec.Anchor = CType(resources.GetObject("bt_mec.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.bt_mec.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_mec.BackgroundImage = CType(resources.GetObject("bt_mec.BackgroundImage"), System.Drawing.Image)
        Me.bt_mec.Dock = CType(resources.GetObject("bt_mec.Dock"), System.Windows.Forms.DockStyle)
        Me.bt_mec.Enabled = CType(resources.GetObject("bt_mec.Enabled"), Boolean)
        Me.bt_mec.FlatStyle = CType(resources.GetObject("bt_mec.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.bt_mec.Font = CType(resources.GetObject("bt_mec.Font"), System.Drawing.Font)
        Me.bt_mec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_mec, resources.GetString("bt_mec.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_mec, CType(resources.GetObject("bt_mec.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_mec, resources.GetString("bt_mec.HelpString"))
        Me.bt_mec.Image = CType(resources.GetObject("bt_mec.Image"), System.Drawing.Image)
        Me.bt_mec.ImageAlign = CType(resources.GetObject("bt_mec.ImageAlign"), System.Drawing.ContentAlignment)
        Me.bt_mec.ImageIndex = CType(resources.GetObject("bt_mec.ImageIndex"), Integer)
        Me.bt_mec.ImeMode = CType(resources.GetObject("bt_mec.ImeMode"), System.Windows.Forms.ImeMode)
        Me.bt_mec.Location = CType(resources.GetObject("bt_mec.Location"), System.Drawing.Point)
        Me.bt_mec.Name = "bt_mec"
        Me.bt_mec.RightToLeft = CType(resources.GetObject("bt_mec.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.bt_mec, CType(resources.GetObject("bt_mec.ShowHelp"), Boolean))
        Me.bt_mec.Size = CType(resources.GetObject("bt_mec.Size"), System.Drawing.Size)
        Me.bt_mec.TabIndex = CType(resources.GetObject("bt_mec.TabIndex"), Integer)
        Me.bt_mec.Text = resources.GetString("bt_mec.Text")
        Me.bt_mec.TextAlign = CType(resources.GetObject("bt_mec.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.bt_mec, resources.GetString("bt_mec.ToolTip"))
        Me.bt_mec.Visible = CType(resources.GetObject("bt_mec.Visible"), Boolean)
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = resources.GetString("Label1.AccessibleDescription")
        Me.Label1.AccessibleName = resources.GetString("Label1.AccessibleName")
        Me.Label1.Anchor = CType(resources.GetObject("Label1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = CType(resources.GetObject("Label1.AutoSize"), Boolean)
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Dock = CType(resources.GetObject("Label1.Dock"), System.Windows.Forms.DockStyle)
        Me.Label1.Enabled = CType(resources.GetObject("Label1.Enabled"), Boolean)
        Me.Label1.Font = CType(resources.GetObject("Label1.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.Label1, resources.GetString("Label1.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Label1, CType(resources.GetObject("Label1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Label1, resources.GetString("Label1.HelpString"))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = CType(resources.GetObject("Label1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label1.ImageIndex = CType(resources.GetObject("Label1.ImageIndex"), Integer)
        Me.Label1.ImeMode = CType(resources.GetObject("Label1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label1.Location = CType(resources.GetObject("Label1.Location"), System.Drawing.Point)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = CType(resources.GetObject("Label1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.Label1, CType(resources.GetObject("Label1.ShowHelp"), Boolean))
        Me.Label1.Size = CType(resources.GetObject("Label1.Size"), System.Drawing.Size)
        Me.Label1.TabIndex = CType(resources.GetObject("Label1.TabIndex"), Integer)
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = CType(resources.GetObject("Label1.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip"))
        Me.Label1.Visible = CType(resources.GetObject("Label1.Visible"), Boolean)
        '
        'bt_forn
        '
        Me.bt_forn.AccessibleDescription = resources.GetString("bt_forn.AccessibleDescription")
        Me.bt_forn.AccessibleName = resources.GetString("bt_forn.AccessibleName")
        Me.bt_forn.Anchor = CType(resources.GetObject("bt_forn.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.bt_forn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_forn.BackgroundImage = CType(resources.GetObject("bt_forn.BackgroundImage"), System.Drawing.Image)
        Me.bt_forn.Dock = CType(resources.GetObject("bt_forn.Dock"), System.Windows.Forms.DockStyle)
        Me.bt_forn.Enabled = CType(resources.GetObject("bt_forn.Enabled"), Boolean)
        Me.bt_forn.FlatStyle = CType(resources.GetObject("bt_forn.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.bt_forn.Font = CType(resources.GetObject("bt_forn.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_forn, resources.GetString("bt_forn.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_forn, CType(resources.GetObject("bt_forn.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_forn, resources.GetString("bt_forn.HelpString"))
        Me.bt_forn.Image = CType(resources.GetObject("bt_forn.Image"), System.Drawing.Image)
        Me.bt_forn.ImageAlign = CType(resources.GetObject("bt_forn.ImageAlign"), System.Drawing.ContentAlignment)
        Me.bt_forn.ImageIndex = CType(resources.GetObject("bt_forn.ImageIndex"), Integer)
        Me.bt_forn.ImeMode = CType(resources.GetObject("bt_forn.ImeMode"), System.Windows.Forms.ImeMode)
        Me.bt_forn.Location = CType(resources.GetObject("bt_forn.Location"), System.Drawing.Point)
        Me.bt_forn.Name = "bt_forn"
        Me.bt_forn.RightToLeft = CType(resources.GetObject("bt_forn.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.bt_forn, CType(resources.GetObject("bt_forn.ShowHelp"), Boolean))
        Me.bt_forn.Size = CType(resources.GetObject("bt_forn.Size"), System.Drawing.Size)
        Me.bt_forn.TabIndex = CType(resources.GetObject("bt_forn.TabIndex"), Integer)
        Me.bt_forn.Text = resources.GetString("bt_forn.Text")
        Me.bt_forn.TextAlign = CType(resources.GetObject("bt_forn.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.bt_forn, resources.GetString("bt_forn.ToolTip"))
        Me.bt_forn.Visible = CType(resources.GetObject("bt_forn.Visible"), Boolean)
        '
        'ProvedordAjuda
        '
        Me.ProvedordAjuda.HelpNamespace = resources.GetString("ProvedordAjuda.HelpNamespace")
        '
        'Bt_Compra
        '
        Me.Bt_Compra.AccessibleDescription = resources.GetString("Bt_Compra.AccessibleDescription")
        Me.Bt_Compra.AccessibleName = resources.GetString("Bt_Compra.AccessibleName")
        Me.Bt_Compra.Anchor = CType(resources.GetObject("Bt_Compra.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Bt_Compra.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bt_Compra.BackgroundImage = CType(resources.GetObject("Bt_Compra.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Compra.Dock = CType(resources.GetObject("Bt_Compra.Dock"), System.Windows.Forms.DockStyle)
        Me.Bt_Compra.Enabled = CType(resources.GetObject("Bt_Compra.Enabled"), Boolean)
        Me.Bt_Compra.FlatStyle = CType(resources.GetObject("Bt_Compra.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Bt_Compra.Font = CType(resources.GetObject("Bt_Compra.Font"), System.Drawing.Font)
        Me.Bt_Compra.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProvedordAjuda.SetHelpKeyword(Me.Bt_Compra, resources.GetString("Bt_Compra.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Bt_Compra, CType(resources.GetObject("Bt_Compra.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Bt_Compra, resources.GetString("Bt_Compra.HelpString"))
        Me.Bt_Compra.Image = CType(resources.GetObject("Bt_Compra.Image"), System.Drawing.Image)
        Me.Bt_Compra.ImageAlign = CType(resources.GetObject("Bt_Compra.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Bt_Compra.ImageIndex = CType(resources.GetObject("Bt_Compra.ImageIndex"), Integer)
        Me.Bt_Compra.ImeMode = CType(resources.GetObject("Bt_Compra.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Bt_Compra.Location = CType(resources.GetObject("Bt_Compra.Location"), System.Drawing.Point)
        Me.Bt_Compra.Name = "Bt_Compra"
        Me.Bt_Compra.RightToLeft = CType(resources.GetObject("Bt_Compra.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.Bt_Compra, CType(resources.GetObject("Bt_Compra.ShowHelp"), Boolean))
        Me.Bt_Compra.Size = CType(resources.GetObject("Bt_Compra.Size"), System.Drawing.Size)
        Me.Bt_Compra.TabIndex = CType(resources.GetObject("Bt_Compra.TabIndex"), Integer)
        Me.Bt_Compra.Text = resources.GetString("Bt_Compra.Text")
        Me.Bt_Compra.TextAlign = CType(resources.GetObject("Bt_Compra.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.Bt_Compra, resources.GetString("Bt_Compra.ToolTip"))
        Me.Bt_Compra.Visible = CType(resources.GetObject("Bt_Compra.Visible"), Boolean)
        '
        'bt_financas
        '
        Me.bt_financas.AccessibleDescription = resources.GetString("bt_financas.AccessibleDescription")
        Me.bt_financas.AccessibleName = resources.GetString("bt_financas.AccessibleName")
        Me.bt_financas.Anchor = CType(resources.GetObject("bt_financas.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.bt_financas.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bt_financas.BackgroundImage = CType(resources.GetObject("bt_financas.BackgroundImage"), System.Drawing.Image)
        Me.bt_financas.Dock = CType(resources.GetObject("bt_financas.Dock"), System.Windows.Forms.DockStyle)
        Me.bt_financas.Enabled = CType(resources.GetObject("bt_financas.Enabled"), Boolean)
        Me.bt_financas.FlatStyle = CType(resources.GetObject("bt_financas.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.bt_financas.Font = CType(resources.GetObject("bt_financas.Font"), System.Drawing.Font)
        Me.bt_financas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_financas, resources.GetString("bt_financas.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_financas, CType(resources.GetObject("bt_financas.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_financas, resources.GetString("bt_financas.HelpString"))
        Me.bt_financas.Image = CType(resources.GetObject("bt_financas.Image"), System.Drawing.Image)
        Me.bt_financas.ImageAlign = CType(resources.GetObject("bt_financas.ImageAlign"), System.Drawing.ContentAlignment)
        Me.bt_financas.ImageIndex = CType(resources.GetObject("bt_financas.ImageIndex"), Integer)
        Me.bt_financas.ImeMode = CType(resources.GetObject("bt_financas.ImeMode"), System.Windows.Forms.ImeMode)
        Me.bt_financas.Location = CType(resources.GetObject("bt_financas.Location"), System.Drawing.Point)
        Me.bt_financas.Name = "bt_financas"
        Me.bt_financas.RightToLeft = CType(resources.GetObject("bt_financas.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.bt_financas, CType(resources.GetObject("bt_financas.ShowHelp"), Boolean))
        Me.bt_financas.Size = CType(resources.GetObject("bt_financas.Size"), System.Drawing.Size)
        Me.bt_financas.TabIndex = CType(resources.GetObject("bt_financas.TabIndex"), Integer)
        Me.bt_financas.Text = resources.GetString("bt_financas.Text")
        Me.bt_financas.TextAlign = CType(resources.GetObject("bt_financas.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.bt_financas, resources.GetString("bt_financas.ToolTip"))
        Me.bt_financas.Visible = CType(resources.GetObject("bt_financas.Visible"), Boolean)
        '
        'BtProd
        '
        Me.BtProd.AccessibleDescription = resources.GetString("BtProd.AccessibleDescription")
        Me.BtProd.AccessibleName = resources.GetString("BtProd.AccessibleName")
        Me.BtProd.Anchor = CType(resources.GetObject("BtProd.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.BtProd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtProd.BackgroundImage = CType(resources.GetObject("BtProd.BackgroundImage"), System.Drawing.Image)
        Me.BtProd.Dock = CType(resources.GetObject("BtProd.Dock"), System.Windows.Forms.DockStyle)
        Me.BtProd.Enabled = CType(resources.GetObject("BtProd.Enabled"), Boolean)
        Me.BtProd.FlatStyle = CType(resources.GetObject("BtProd.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.BtProd.Font = CType(resources.GetObject("BtProd.Font"), System.Drawing.Font)
        Me.BtProd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProvedordAjuda.SetHelpKeyword(Me.BtProd, resources.GetString("BtProd.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.BtProd, CType(resources.GetObject("BtProd.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.BtProd, resources.GetString("BtProd.HelpString"))
        Me.BtProd.Image = CType(resources.GetObject("BtProd.Image"), System.Drawing.Image)
        Me.BtProd.ImageAlign = CType(resources.GetObject("BtProd.ImageAlign"), System.Drawing.ContentAlignment)
        Me.BtProd.ImageIndex = CType(resources.GetObject("BtProd.ImageIndex"), Integer)
        Me.BtProd.ImeMode = CType(resources.GetObject("BtProd.ImeMode"), System.Windows.Forms.ImeMode)
        Me.BtProd.Location = CType(resources.GetObject("BtProd.Location"), System.Drawing.Point)
        Me.BtProd.Name = "BtProd"
        Me.BtProd.RightToLeft = CType(resources.GetObject("BtProd.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.BtProd, CType(resources.GetObject("BtProd.ShowHelp"), Boolean))
        Me.BtProd.Size = CType(resources.GetObject("BtProd.Size"), System.Drawing.Size)
        Me.BtProd.TabIndex = CType(resources.GetObject("BtProd.TabIndex"), Integer)
        Me.BtProd.Text = resources.GetString("BtProd.Text")
        Me.BtProd.TextAlign = CType(resources.GetObject("BtProd.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.BtProd, resources.GetString("BtProd.ToolTip"))
        Me.BtProd.Visible = CType(resources.GetObject("BtProd.Visible"), Boolean)
        '
        'btVei
        '
        Me.btVei.AccessibleDescription = resources.GetString("btVei.AccessibleDescription")
        Me.btVei.AccessibleName = resources.GetString("btVei.AccessibleName")
        Me.btVei.Anchor = CType(resources.GetObject("btVei.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btVei.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btVei.BackgroundImage = CType(resources.GetObject("btVei.BackgroundImage"), System.Drawing.Image)
        Me.btVei.Dock = CType(resources.GetObject("btVei.Dock"), System.Windows.Forms.DockStyle)
        Me.btVei.Enabled = CType(resources.GetObject("btVei.Enabled"), Boolean)
        Me.btVei.FlatStyle = CType(resources.GetObject("btVei.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btVei.Font = CType(resources.GetObject("btVei.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.btVei, resources.GetString("btVei.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.btVei, CType(resources.GetObject("btVei.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.btVei, resources.GetString("btVei.HelpString"))
        Me.btVei.Image = CType(resources.GetObject("btVei.Image"), System.Drawing.Image)
        Me.btVei.ImageAlign = CType(resources.GetObject("btVei.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btVei.ImageIndex = CType(resources.GetObject("btVei.ImageIndex"), Integer)
        Me.btVei.ImeMode = CType(resources.GetObject("btVei.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btVei.Location = CType(resources.GetObject("btVei.Location"), System.Drawing.Point)
        Me.btVei.Name = "btVei"
        Me.btVei.RightToLeft = CType(resources.GetObject("btVei.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.btVei, CType(resources.GetObject("btVei.ShowHelp"), Boolean))
        Me.btVei.Size = CType(resources.GetObject("btVei.Size"), System.Drawing.Size)
        Me.btVei.TabIndex = CType(resources.GetObject("btVei.TabIndex"), Integer)
        Me.btVei.Text = resources.GetString("btVei.Text")
        Me.btVei.TextAlign = CType(resources.GetObject("btVei.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.btVei, resources.GetString("btVei.ToolTip"))
        Me.btVei.Visible = CType(resources.GetObject("btVei.Visible"), Boolean)
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = resources.GetString("Panel1.AccessibleDescription")
        Me.Panel1.AccessibleName = resources.GetString("Panel1.AccessibleName")
        Me.Panel1.Anchor = CType(resources.GetObject("Panel1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = CType(resources.GetObject("Panel1.AutoScroll"), Boolean)
        Me.Panel1.AutoScrollMargin = CType(resources.GetObject("Panel1.AutoScrollMargin"), System.Drawing.Size)
        Me.Panel1.AutoScrollMinSize = CType(resources.GetObject("Panel1.AutoScrollMinSize"), System.Drawing.Size)
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.btVei)
        Me.Panel1.Controls.Add(Me.BtProd)
        Me.Panel1.Dock = CType(resources.GetObject("Panel1.Dock"), System.Windows.Forms.DockStyle)
        Me.Panel1.Enabled = CType(resources.GetObject("Panel1.Enabled"), Boolean)
        Me.Panel1.Font = CType(resources.GetObject("Panel1.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.Panel1, resources.GetString("Panel1.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Panel1, CType(resources.GetObject("Panel1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Panel1, resources.GetString("Panel1.HelpString"))
        Me.Panel1.ImeMode = CType(resources.GetObject("Panel1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Panel1.Location = CType(resources.GetObject("Panel1.Location"), System.Drawing.Point)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = CType(resources.GetObject("Panel1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.Panel1, CType(resources.GetObject("Panel1.ShowHelp"), Boolean))
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
        Me.Panel1.TabIndex = CType(resources.GetObject("Panel1.TabIndex"), Integer)
        Me.Panel1.Text = resources.GetString("Panel1.Text")
        Me.FerramentaDica.SetToolTip(Me.Panel1, resources.GetString("Panel1.ToolTip"))
        Me.Panel1.Visible = CType(resources.GetObject("Panel1.Visible"), Boolean)
        '
        'Panel2
        '
        Me.Panel2.AccessibleDescription = resources.GetString("Panel2.AccessibleDescription")
        Me.Panel2.AccessibleName = resources.GetString("Panel2.AccessibleName")
        Me.Panel2.Anchor = CType(resources.GetObject("Panel2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = CType(resources.GetObject("Panel2.AutoScroll"), Boolean)
        Me.Panel2.AutoScrollMargin = CType(resources.GetObject("Panel2.AutoScrollMargin"), System.Drawing.Size)
        Me.Panel2.AutoScrollMinSize = CType(resources.GetObject("Panel2.AutoScrollMinSize"), System.Drawing.Size)
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Bt_usados)
        Me.Panel2.Controls.Add(Me.bt_novos)
        Me.Panel2.Dock = CType(resources.GetObject("Panel2.Dock"), System.Windows.Forms.DockStyle)
        Me.Panel2.Enabled = CType(resources.GetObject("Panel2.Enabled"), Boolean)
        Me.Panel2.Font = CType(resources.GetObject("Panel2.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.Panel2, resources.GetString("Panel2.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Panel2, CType(resources.GetObject("Panel2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Panel2, resources.GetString("Panel2.HelpString"))
        Me.Panel2.ImeMode = CType(resources.GetObject("Panel2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Panel2.Location = CType(resources.GetObject("Panel2.Location"), System.Drawing.Point)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = CType(resources.GetObject("Panel2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.Panel2, CType(resources.GetObject("Panel2.ShowHelp"), Boolean))
        Me.Panel2.Size = CType(resources.GetObject("Panel2.Size"), System.Drawing.Size)
        Me.Panel2.TabIndex = CType(resources.GetObject("Panel2.TabIndex"), Integer)
        Me.Panel2.Text = resources.GetString("Panel2.Text")
        Me.FerramentaDica.SetToolTip(Me.Panel2, resources.GetString("Panel2.ToolTip"))
        Me.Panel2.Visible = CType(resources.GetObject("Panel2.Visible"), Boolean)
        '
        'Bt_usados
        '
        Me.Bt_usados.AccessibleDescription = resources.GetString("Bt_usados.AccessibleDescription")
        Me.Bt_usados.AccessibleName = resources.GetString("Bt_usados.AccessibleName")
        Me.Bt_usados.Anchor = CType(resources.GetObject("Bt_usados.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Bt_usados.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bt_usados.BackgroundImage = CType(resources.GetObject("Bt_usados.BackgroundImage"), System.Drawing.Image)
        Me.Bt_usados.Dock = CType(resources.GetObject("Bt_usados.Dock"), System.Windows.Forms.DockStyle)
        Me.Bt_usados.Enabled = CType(resources.GetObject("Bt_usados.Enabled"), Boolean)
        Me.Bt_usados.FlatStyle = CType(resources.GetObject("Bt_usados.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Bt_usados.Font = CType(resources.GetObject("Bt_usados.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.Bt_usados, resources.GetString("Bt_usados.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Bt_usados, CType(resources.GetObject("Bt_usados.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Bt_usados, resources.GetString("Bt_usados.HelpString"))
        Me.Bt_usados.Image = CType(resources.GetObject("Bt_usados.Image"), System.Drawing.Image)
        Me.Bt_usados.ImageAlign = CType(resources.GetObject("Bt_usados.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Bt_usados.ImageIndex = CType(resources.GetObject("Bt_usados.ImageIndex"), Integer)
        Me.Bt_usados.ImeMode = CType(resources.GetObject("Bt_usados.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Bt_usados.Location = CType(resources.GetObject("Bt_usados.Location"), System.Drawing.Point)
        Me.Bt_usados.Name = "Bt_usados"
        Me.Bt_usados.RightToLeft = CType(resources.GetObject("Bt_usados.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.Bt_usados, CType(resources.GetObject("Bt_usados.ShowHelp"), Boolean))
        Me.Bt_usados.Size = CType(resources.GetObject("Bt_usados.Size"), System.Drawing.Size)
        Me.Bt_usados.TabIndex = CType(resources.GetObject("Bt_usados.TabIndex"), Integer)
        Me.Bt_usados.Text = resources.GetString("Bt_usados.Text")
        Me.Bt_usados.TextAlign = CType(resources.GetObject("Bt_usados.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.Bt_usados, resources.GetString("Bt_usados.ToolTip"))
        Me.Bt_usados.Visible = CType(resources.GetObject("Bt_usados.Visible"), Boolean)
        '
        'bt_novos
        '
        Me.bt_novos.AccessibleDescription = resources.GetString("bt_novos.AccessibleDescription")
        Me.bt_novos.AccessibleName = resources.GetString("bt_novos.AccessibleName")
        Me.bt_novos.Anchor = CType(resources.GetObject("bt_novos.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.bt_novos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_novos.BackgroundImage = CType(resources.GetObject("bt_novos.BackgroundImage"), System.Drawing.Image)
        Me.bt_novos.Dock = CType(resources.GetObject("bt_novos.Dock"), System.Windows.Forms.DockStyle)
        Me.bt_novos.Enabled = CType(resources.GetObject("bt_novos.Enabled"), Boolean)
        Me.bt_novos.FlatStyle = CType(resources.GetObject("bt_novos.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.bt_novos.Font = CType(resources.GetObject("bt_novos.Font"), System.Drawing.Font)
        Me.bt_novos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_novos, resources.GetString("bt_novos.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_novos, CType(resources.GetObject("bt_novos.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_novos, resources.GetString("bt_novos.HelpString"))
        Me.bt_novos.Image = CType(resources.GetObject("bt_novos.Image"), System.Drawing.Image)
        Me.bt_novos.ImageAlign = CType(resources.GetObject("bt_novos.ImageAlign"), System.Drawing.ContentAlignment)
        Me.bt_novos.ImageIndex = CType(resources.GetObject("bt_novos.ImageIndex"), Integer)
        Me.bt_novos.ImeMode = CType(resources.GetObject("bt_novos.ImeMode"), System.Windows.Forms.ImeMode)
        Me.bt_novos.Location = CType(resources.GetObject("bt_novos.Location"), System.Drawing.Point)
        Me.bt_novos.Name = "bt_novos"
        Me.bt_novos.RightToLeft = CType(resources.GetObject("bt_novos.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.bt_novos, CType(resources.GetObject("bt_novos.ShowHelp"), Boolean))
        Me.bt_novos.Size = CType(resources.GetObject("bt_novos.Size"), System.Drawing.Size)
        Me.bt_novos.TabIndex = CType(resources.GetObject("bt_novos.TabIndex"), Integer)
        Me.bt_novos.Text = resources.GetString("bt_novos.Text")
        Me.bt_novos.TextAlign = CType(resources.GetObject("bt_novos.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.bt_novos, resources.GetString("bt_novos.ToolTip"))
        Me.bt_novos.Visible = CType(resources.GetObject("bt_novos.Visible"), Boolean)
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = resources.GetString("Label4.AccessibleDescription")
        Me.Label4.AccessibleName = resources.GetString("Label4.AccessibleName")
        Me.Label4.Anchor = CType(resources.GetObject("Label4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = CType(resources.GetObject("Label4.AutoSize"), Boolean)
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Dock = CType(resources.GetObject("Label4.Dock"), System.Windows.Forms.DockStyle)
        Me.Label4.Enabled = CType(resources.GetObject("Label4.Enabled"), Boolean)
        Me.Label4.Font = CType(resources.GetObject("Label4.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.Label4, resources.GetString("Label4.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Label4, CType(resources.GetObject("Label4.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Label4, resources.GetString("Label4.HelpString"))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = CType(resources.GetObject("Label4.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label4.ImageIndex = CType(resources.GetObject("Label4.ImageIndex"), Integer)
        Me.Label4.ImeMode = CType(resources.GetObject("Label4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label4.Location = CType(resources.GetObject("Label4.Location"), System.Drawing.Point)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = CType(resources.GetObject("Label4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.Label4, CType(resources.GetObject("Label4.ShowHelp"), Boolean))
        Me.Label4.Size = CType(resources.GetObject("Label4.Size"), System.Drawing.Size)
        Me.Label4.TabIndex = CType(resources.GetObject("Label4.TabIndex"), Integer)
        Me.Label4.Text = resources.GetString("Label4.Text")
        Me.Label4.TextAlign = CType(resources.GetObject("Label4.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.Label4, resources.GetString("Label4.ToolTip"))
        Me.Label4.Visible = CType(resources.GetObject("Label4.Visible"), Boolean)
        '
        'Panel3
        '
        Me.Panel3.AccessibleDescription = resources.GetString("Panel3.AccessibleDescription")
        Me.Panel3.AccessibleName = resources.GetString("Panel3.AccessibleName")
        Me.Panel3.Anchor = CType(resources.GetObject("Panel3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Panel3.AutoScroll = CType(resources.GetObject("Panel3.AutoScroll"), Boolean)
        Me.Panel3.AutoScrollMargin = CType(resources.GetObject("Panel3.AutoScrollMargin"), System.Drawing.Size)
        Me.Panel3.AutoScrollMinSize = CType(resources.GetObject("Panel3.AutoScrollMinSize"), System.Drawing.Size)
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.Bt_Cvei)
        Me.Panel3.Controls.Add(Me.bt_cprod)
        Me.Panel3.Dock = CType(resources.GetObject("Panel3.Dock"), System.Windows.Forms.DockStyle)
        Me.Panel3.Enabled = CType(resources.GetObject("Panel3.Enabled"), Boolean)
        Me.Panel3.Font = CType(resources.GetObject("Panel3.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.Panel3, resources.GetString("Panel3.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Panel3, CType(resources.GetObject("Panel3.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Panel3, resources.GetString("Panel3.HelpString"))
        Me.Panel3.ImeMode = CType(resources.GetObject("Panel3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Panel3.Location = CType(resources.GetObject("Panel3.Location"), System.Drawing.Point)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.RightToLeft = CType(resources.GetObject("Panel3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.Panel3, CType(resources.GetObject("Panel3.ShowHelp"), Boolean))
        Me.Panel3.Size = CType(resources.GetObject("Panel3.Size"), System.Drawing.Size)
        Me.Panel3.TabIndex = CType(resources.GetObject("Panel3.TabIndex"), Integer)
        Me.Panel3.Text = resources.GetString("Panel3.Text")
        Me.FerramentaDica.SetToolTip(Me.Panel3, resources.GetString("Panel3.ToolTip"))
        Me.Panel3.Visible = CType(resources.GetObject("Panel3.Visible"), Boolean)
        '
        'Bt_Cvei
        '
        Me.Bt_Cvei.AccessibleDescription = resources.GetString("Bt_Cvei.AccessibleDescription")
        Me.Bt_Cvei.AccessibleName = resources.GetString("Bt_Cvei.AccessibleName")
        Me.Bt_Cvei.Anchor = CType(resources.GetObject("Bt_Cvei.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Bt_Cvei.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bt_Cvei.BackgroundImage = CType(resources.GetObject("Bt_Cvei.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Cvei.Dock = CType(resources.GetObject("Bt_Cvei.Dock"), System.Windows.Forms.DockStyle)
        Me.Bt_Cvei.Enabled = CType(resources.GetObject("Bt_Cvei.Enabled"), Boolean)
        Me.Bt_Cvei.FlatStyle = CType(resources.GetObject("Bt_Cvei.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Bt_Cvei.Font = CType(resources.GetObject("Bt_Cvei.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.Bt_Cvei, resources.GetString("Bt_Cvei.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Bt_Cvei, CType(resources.GetObject("Bt_Cvei.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Bt_Cvei, resources.GetString("Bt_Cvei.HelpString"))
        Me.Bt_Cvei.Image = CType(resources.GetObject("Bt_Cvei.Image"), System.Drawing.Image)
        Me.Bt_Cvei.ImageAlign = CType(resources.GetObject("Bt_Cvei.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Bt_Cvei.ImageIndex = CType(resources.GetObject("Bt_Cvei.ImageIndex"), Integer)
        Me.Bt_Cvei.ImeMode = CType(resources.GetObject("Bt_Cvei.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Bt_Cvei.Location = CType(resources.GetObject("Bt_Cvei.Location"), System.Drawing.Point)
        Me.Bt_Cvei.Name = "Bt_Cvei"
        Me.Bt_Cvei.RightToLeft = CType(resources.GetObject("Bt_Cvei.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.Bt_Cvei, CType(resources.GetObject("Bt_Cvei.ShowHelp"), Boolean))
        Me.Bt_Cvei.Size = CType(resources.GetObject("Bt_Cvei.Size"), System.Drawing.Size)
        Me.Bt_Cvei.TabIndex = CType(resources.GetObject("Bt_Cvei.TabIndex"), Integer)
        Me.Bt_Cvei.Text = resources.GetString("Bt_Cvei.Text")
        Me.Bt_Cvei.TextAlign = CType(resources.GetObject("Bt_Cvei.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.Bt_Cvei, resources.GetString("Bt_Cvei.ToolTip"))
        Me.Bt_Cvei.Visible = CType(resources.GetObject("Bt_Cvei.Visible"), Boolean)
        '
        'bt_cprod
        '
        Me.bt_cprod.AccessibleDescription = resources.GetString("bt_cprod.AccessibleDescription")
        Me.bt_cprod.AccessibleName = resources.GetString("bt_cprod.AccessibleName")
        Me.bt_cprod.Anchor = CType(resources.GetObject("bt_cprod.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.bt_cprod.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_cprod.BackgroundImage = CType(resources.GetObject("bt_cprod.BackgroundImage"), System.Drawing.Image)
        Me.bt_cprod.Dock = CType(resources.GetObject("bt_cprod.Dock"), System.Windows.Forms.DockStyle)
        Me.bt_cprod.Enabled = CType(resources.GetObject("bt_cprod.Enabled"), Boolean)
        Me.bt_cprod.FlatStyle = CType(resources.GetObject("bt_cprod.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.bt_cprod.Font = CType(resources.GetObject("bt_cprod.Font"), System.Drawing.Font)
        Me.bt_cprod.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_cprod, resources.GetString("bt_cprod.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_cprod, CType(resources.GetObject("bt_cprod.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_cprod, resources.GetString("bt_cprod.HelpString"))
        Me.bt_cprod.Image = CType(resources.GetObject("bt_cprod.Image"), System.Drawing.Image)
        Me.bt_cprod.ImageAlign = CType(resources.GetObject("bt_cprod.ImageAlign"), System.Drawing.ContentAlignment)
        Me.bt_cprod.ImageIndex = CType(resources.GetObject("bt_cprod.ImageIndex"), Integer)
        Me.bt_cprod.ImeMode = CType(resources.GetObject("bt_cprod.ImeMode"), System.Windows.Forms.ImeMode)
        Me.bt_cprod.Location = CType(resources.GetObject("bt_cprod.Location"), System.Drawing.Point)
        Me.bt_cprod.Name = "bt_cprod"
        Me.bt_cprod.RightToLeft = CType(resources.GetObject("bt_cprod.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.bt_cprod, CType(resources.GetObject("bt_cprod.ShowHelp"), Boolean))
        Me.bt_cprod.Size = CType(resources.GetObject("bt_cprod.Size"), System.Drawing.Size)
        Me.bt_cprod.TabIndex = CType(resources.GetObject("bt_cprod.TabIndex"), Integer)
        Me.bt_cprod.Text = resources.GetString("bt_cprod.Text")
        Me.bt_cprod.TextAlign = CType(resources.GetObject("bt_cprod.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.bt_cprod, resources.GetString("bt_cprod.ToolTip"))
        Me.bt_cprod.Visible = CType(resources.GetObject("bt_cprod.Visible"), Boolean)
        '
        'Panel4
        '
        Me.Panel4.AccessibleDescription = resources.GetString("Panel4.AccessibleDescription")
        Me.Panel4.AccessibleName = resources.GetString("Panel4.AccessibleName")
        Me.Panel4.Anchor = CType(resources.GetObject("Panel4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Panel4.AutoScroll = CType(resources.GetObject("Panel4.AutoScroll"), Boolean)
        Me.Panel4.AutoScrollMargin = CType(resources.GetObject("Panel4.AutoScrollMargin"), System.Drawing.Size)
        Me.Panel4.AutoScrollMinSize = CType(resources.GetObject("Panel4.AutoScrollMinSize"), System.Drawing.Size)
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Controls.Add(Me.BT_COLD)
        Me.Panel4.Controls.Add(Me.Bt_CNew)
        Me.Panel4.Dock = CType(resources.GetObject("Panel4.Dock"), System.Windows.Forms.DockStyle)
        Me.Panel4.Enabled = CType(resources.GetObject("Panel4.Enabled"), Boolean)
        Me.Panel4.Font = CType(resources.GetObject("Panel4.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.Panel4, resources.GetString("Panel4.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Panel4, CType(resources.GetObject("Panel4.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Panel4, resources.GetString("Panel4.HelpString"))
        Me.Panel4.ImeMode = CType(resources.GetObject("Panel4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Panel4.Location = CType(resources.GetObject("Panel4.Location"), System.Drawing.Point)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.RightToLeft = CType(resources.GetObject("Panel4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.Panel4, CType(resources.GetObject("Panel4.ShowHelp"), Boolean))
        Me.Panel4.Size = CType(resources.GetObject("Panel4.Size"), System.Drawing.Size)
        Me.Panel4.TabIndex = CType(resources.GetObject("Panel4.TabIndex"), Integer)
        Me.Panel4.Text = resources.GetString("Panel4.Text")
        Me.FerramentaDica.SetToolTip(Me.Panel4, resources.GetString("Panel4.ToolTip"))
        Me.Panel4.Visible = CType(resources.GetObject("Panel4.Visible"), Boolean)
        '
        'BT_COLD
        '
        Me.BT_COLD.AccessibleDescription = resources.GetString("BT_COLD.AccessibleDescription")
        Me.BT_COLD.AccessibleName = resources.GetString("BT_COLD.AccessibleName")
        Me.BT_COLD.Anchor = CType(resources.GetObject("BT_COLD.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.BT_COLD.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BT_COLD.BackgroundImage = CType(resources.GetObject("BT_COLD.BackgroundImage"), System.Drawing.Image)
        Me.BT_COLD.Dock = CType(resources.GetObject("BT_COLD.Dock"), System.Windows.Forms.DockStyle)
        Me.BT_COLD.Enabled = CType(resources.GetObject("BT_COLD.Enabled"), Boolean)
        Me.BT_COLD.FlatStyle = CType(resources.GetObject("BT_COLD.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.BT_COLD.Font = CType(resources.GetObject("BT_COLD.Font"), System.Drawing.Font)
        Me.ProvedordAjuda.SetHelpKeyword(Me.BT_COLD, resources.GetString("BT_COLD.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.BT_COLD, CType(resources.GetObject("BT_COLD.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.BT_COLD, resources.GetString("BT_COLD.HelpString"))
        Me.BT_COLD.Image = CType(resources.GetObject("BT_COLD.Image"), System.Drawing.Image)
        Me.BT_COLD.ImageAlign = CType(resources.GetObject("BT_COLD.ImageAlign"), System.Drawing.ContentAlignment)
        Me.BT_COLD.ImageIndex = CType(resources.GetObject("BT_COLD.ImageIndex"), Integer)
        Me.BT_COLD.ImeMode = CType(resources.GetObject("BT_COLD.ImeMode"), System.Windows.Forms.ImeMode)
        Me.BT_COLD.Location = CType(resources.GetObject("BT_COLD.Location"), System.Drawing.Point)
        Me.BT_COLD.Name = "BT_COLD"
        Me.BT_COLD.RightToLeft = CType(resources.GetObject("BT_COLD.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.BT_COLD, CType(resources.GetObject("BT_COLD.ShowHelp"), Boolean))
        Me.BT_COLD.Size = CType(resources.GetObject("BT_COLD.Size"), System.Drawing.Size)
        Me.BT_COLD.TabIndex = CType(resources.GetObject("BT_COLD.TabIndex"), Integer)
        Me.BT_COLD.Text = resources.GetString("BT_COLD.Text")
        Me.BT_COLD.TextAlign = CType(resources.GetObject("BT_COLD.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.BT_COLD, resources.GetString("BT_COLD.ToolTip"))
        Me.BT_COLD.Visible = CType(resources.GetObject("BT_COLD.Visible"), Boolean)
        '
        'Bt_CNew
        '
        Me.Bt_CNew.AccessibleDescription = resources.GetString("Bt_CNew.AccessibleDescription")
        Me.Bt_CNew.AccessibleName = resources.GetString("Bt_CNew.AccessibleName")
        Me.Bt_CNew.Anchor = CType(resources.GetObject("Bt_CNew.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Bt_CNew.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bt_CNew.BackgroundImage = CType(resources.GetObject("Bt_CNew.BackgroundImage"), System.Drawing.Image)
        Me.Bt_CNew.Dock = CType(resources.GetObject("Bt_CNew.Dock"), System.Windows.Forms.DockStyle)
        Me.Bt_CNew.Enabled = CType(resources.GetObject("Bt_CNew.Enabled"), Boolean)
        Me.Bt_CNew.FlatStyle = CType(resources.GetObject("Bt_CNew.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Bt_CNew.Font = CType(resources.GetObject("Bt_CNew.Font"), System.Drawing.Font)
        Me.Bt_CNew.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProvedordAjuda.SetHelpKeyword(Me.Bt_CNew, resources.GetString("Bt_CNew.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Bt_CNew, CType(resources.GetObject("Bt_CNew.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Bt_CNew, resources.GetString("Bt_CNew.HelpString"))
        Me.Bt_CNew.Image = CType(resources.GetObject("Bt_CNew.Image"), System.Drawing.Image)
        Me.Bt_CNew.ImageAlign = CType(resources.GetObject("Bt_CNew.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Bt_CNew.ImageIndex = CType(resources.GetObject("Bt_CNew.ImageIndex"), Integer)
        Me.Bt_CNew.ImeMode = CType(resources.GetObject("Bt_CNew.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Bt_CNew.Location = CType(resources.GetObject("Bt_CNew.Location"), System.Drawing.Point)
        Me.Bt_CNew.Name = "Bt_CNew"
        Me.Bt_CNew.RightToLeft = CType(resources.GetObject("Bt_CNew.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me.Bt_CNew, CType(resources.GetObject("Bt_CNew.ShowHelp"), Boolean))
        Me.Bt_CNew.Size = CType(resources.GetObject("Bt_CNew.Size"), System.Drawing.Size)
        Me.Bt_CNew.TabIndex = CType(resources.GetObject("Bt_CNew.TabIndex"), Integer)
        Me.Bt_CNew.Text = resources.GetString("Bt_CNew.Text")
        Me.Bt_CNew.TextAlign = CType(resources.GetObject("Bt_CNew.TextAlign"), System.Drawing.ContentAlignment)
        Me.FerramentaDica.SetToolTip(Me.Bt_CNew, resources.GetString("Bt_CNew.ToolTip"))
        Me.Bt_CNew.Visible = CType(resources.GetObject("Bt_CNew.Visible"), Boolean)
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
        Me.MenuPrincipal.RightToLeft = CType(resources.GetObject("MenuPrincipal.RightToLeft"), System.Windows.Forms.RightToLeft)
        '
        'MenuItem1
        '
        Me.MenuItem1.Enabled = CType(resources.GetObject("MenuItem1.Enabled"), Boolean)
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menu_cli, Me.MenuItem17, Me.MenuItem16, Me.mnu_logoff, Me.mnu_sair})
        Me.MenuItem1.Shortcut = CType(resources.GetObject("MenuItem1.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem1.ShowShortcut = CType(resources.GetObject("MenuItem1.ShowShortcut"), Boolean)
        Me.MenuItem1.Text = resources.GetString("MenuItem1.Text")
        Me.MenuItem1.Visible = CType(resources.GetObject("MenuItem1.Visible"), Boolean)
        '
        'menu_cli
        '
        Me.menu_cli.Enabled = CType(resources.GetObject("menu_cli.Enabled"), Boolean)
        Me.menu_cli.Index = 0
        Me.menu_cli.Shortcut = CType(resources.GetObject("menu_cli.Shortcut"), System.Windows.Forms.Shortcut)
        Me.menu_cli.ShowShortcut = CType(resources.GetObject("menu_cli.ShowShortcut"), Boolean)
        Me.menu_cli.Text = resources.GetString("menu_cli.Text")
        Me.menu_cli.Visible = CType(resources.GetObject("menu_cli.Visible"), Boolean)
        '
        'MenuItem17
        '
        Me.MenuItem17.Enabled = CType(resources.GetObject("MenuItem17.Enabled"), Boolean)
        Me.MenuItem17.Index = 1
        Me.MenuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_aluguel, Me.mnu_buy, Me.mnu_finan, Me.mnu_forn, Me.mnu_fun, Me.mnu_mec, Me.mnu_sell})
        Me.MenuItem17.Shortcut = CType(resources.GetObject("MenuItem17.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem17.ShowShortcut = CType(resources.GetObject("MenuItem17.ShowShortcut"), Boolean)
        Me.MenuItem17.Text = resources.GetString("MenuItem17.Text")
        Me.MenuItem17.Visible = CType(resources.GetObject("MenuItem17.Visible"), Boolean)
        '
        'mnu_aluguel
        '
        Me.mnu_aluguel.Enabled = CType(resources.GetObject("mnu_aluguel.Enabled"), Boolean)
        Me.mnu_aluguel.Index = 0
        Me.mnu_aluguel.Shortcut = CType(resources.GetObject("mnu_aluguel.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu_aluguel.ShowShortcut = CType(resources.GetObject("mnu_aluguel.ShowShortcut"), Boolean)
        Me.mnu_aluguel.Text = resources.GetString("mnu_aluguel.Text")
        Me.mnu_aluguel.Visible = CType(resources.GetObject("mnu_aluguel.Visible"), Boolean)
        '
        'mnu_buy
        '
        Me.mnu_buy.Enabled = CType(resources.GetObject("mnu_buy.Enabled"), Boolean)
        Me.mnu_buy.Index = 1
        Me.mnu_buy.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_buyProd, Me.MenuItem30})
        Me.mnu_buy.Shortcut = CType(resources.GetObject("mnu_buy.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu_buy.ShowShortcut = CType(resources.GetObject("mnu_buy.ShowShortcut"), Boolean)
        Me.mnu_buy.Text = resources.GetString("mnu_buy.Text")
        Me.mnu_buy.Visible = CType(resources.GetObject("mnu_buy.Visible"), Boolean)
        '
        'mnu_buyProd
        '
        Me.mnu_buyProd.Enabled = CType(resources.GetObject("mnu_buyProd.Enabled"), Boolean)
        Me.mnu_buyProd.Index = 0
        Me.mnu_buyProd.Shortcut = CType(resources.GetObject("mnu_buyProd.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu_buyProd.ShowShortcut = CType(resources.GetObject("mnu_buyProd.ShowShortcut"), Boolean)
        Me.mnu_buyProd.Text = resources.GetString("mnu_buyProd.Text")
        Me.mnu_buyProd.Visible = CType(resources.GetObject("mnu_buyProd.Visible"), Boolean)
        '
        'MenuItem30
        '
        Me.MenuItem30.Enabled = CType(resources.GetObject("MenuItem30.Enabled"), Boolean)
        Me.MenuItem30.Index = 1
        Me.MenuItem30.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_buy_newvei, Me.mnu_buy_oldvei})
        Me.MenuItem30.Shortcut = CType(resources.GetObject("MenuItem30.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem30.ShowShortcut = CType(resources.GetObject("MenuItem30.ShowShortcut"), Boolean)
        Me.MenuItem30.Text = resources.GetString("MenuItem30.Text")
        Me.MenuItem30.Visible = CType(resources.GetObject("MenuItem30.Visible"), Boolean)
        '
        'mnu_buy_newvei
        '
        Me.mnu_buy_newvei.Enabled = CType(resources.GetObject("mnu_buy_newvei.Enabled"), Boolean)
        Me.mnu_buy_newvei.Index = 0
        Me.mnu_buy_newvei.Shortcut = CType(resources.GetObject("mnu_buy_newvei.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu_buy_newvei.ShowShortcut = CType(resources.GetObject("mnu_buy_newvei.ShowShortcut"), Boolean)
        Me.mnu_buy_newvei.Text = resources.GetString("mnu_buy_newvei.Text")
        Me.mnu_buy_newvei.Visible = CType(resources.GetObject("mnu_buy_newvei.Visible"), Boolean)
        '
        'mnu_buy_oldvei
        '
        Me.mnu_buy_oldvei.Enabled = CType(resources.GetObject("mnu_buy_oldvei.Enabled"), Boolean)
        Me.mnu_buy_oldvei.Index = 1
        Me.mnu_buy_oldvei.Shortcut = CType(resources.GetObject("mnu_buy_oldvei.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu_buy_oldvei.ShowShortcut = CType(resources.GetObject("mnu_buy_oldvei.ShowShortcut"), Boolean)
        Me.mnu_buy_oldvei.Text = resources.GetString("mnu_buy_oldvei.Text")
        Me.mnu_buy_oldvei.Visible = CType(resources.GetObject("mnu_buy_oldvei.Visible"), Boolean)
        '
        'mnu_finan
        '
        Me.mnu_finan.Enabled = CType(resources.GetObject("mnu_finan.Enabled"), Boolean)
        Me.mnu_finan.Index = 2
        Me.mnu_finan.Shortcut = CType(resources.GetObject("mnu_finan.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu_finan.ShowShortcut = CType(resources.GetObject("mnu_finan.ShowShortcut"), Boolean)
        Me.mnu_finan.Text = resources.GetString("mnu_finan.Text")
        Me.mnu_finan.Visible = CType(resources.GetObject("mnu_finan.Visible"), Boolean)
        '
        'mnu_forn
        '
        Me.mnu_forn.Enabled = CType(resources.GetObject("mnu_forn.Enabled"), Boolean)
        Me.mnu_forn.Index = 3
        Me.mnu_forn.Shortcut = CType(resources.GetObject("mnu_forn.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu_forn.ShowShortcut = CType(resources.GetObject("mnu_forn.ShowShortcut"), Boolean)
        Me.mnu_forn.Text = resources.GetString("mnu_forn.Text")
        Me.mnu_forn.Visible = CType(resources.GetObject("mnu_forn.Visible"), Boolean)
        '
        'mnu_fun
        '
        Me.mnu_fun.Enabled = CType(resources.GetObject("mnu_fun.Enabled"), Boolean)
        Me.mnu_fun.Index = 4
        Me.mnu_fun.Shortcut = CType(resources.GetObject("mnu_fun.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu_fun.ShowShortcut = CType(resources.GetObject("mnu_fun.ShowShortcut"), Boolean)
        Me.mnu_fun.Text = resources.GetString("mnu_fun.Text")
        Me.mnu_fun.Visible = CType(resources.GetObject("mnu_fun.Visible"), Boolean)
        '
        'mnu_mec
        '
        Me.mnu_mec.Enabled = CType(resources.GetObject("mnu_mec.Enabled"), Boolean)
        Me.mnu_mec.Index = 5
        Me.mnu_mec.Shortcut = CType(resources.GetObject("mnu_mec.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu_mec.ShowShortcut = CType(resources.GetObject("mnu_mec.ShowShortcut"), Boolean)
        Me.mnu_mec.Text = resources.GetString("mnu_mec.Text")
        Me.mnu_mec.Visible = CType(resources.GetObject("mnu_mec.Visible"), Boolean)
        '
        'mnu_sell
        '
        Me.mnu_sell.Enabled = CType(resources.GetObject("mnu_sell.Enabled"), Boolean)
        Me.mnu_sell.Index = 6
        Me.mnu_sell.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_sell_prod, Me.MenuItem26})
        Me.mnu_sell.Shortcut = CType(resources.GetObject("mnu_sell.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu_sell.ShowShortcut = CType(resources.GetObject("mnu_sell.ShowShortcut"), Boolean)
        Me.mnu_sell.Text = resources.GetString("mnu_sell.Text")
        Me.mnu_sell.Visible = CType(resources.GetObject("mnu_sell.Visible"), Boolean)
        '
        'mnu_sell_prod
        '
        Me.mnu_sell_prod.Enabled = CType(resources.GetObject("mnu_sell_prod.Enabled"), Boolean)
        Me.mnu_sell_prod.Index = 0
        Me.mnu_sell_prod.Shortcut = CType(resources.GetObject("mnu_sell_prod.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu_sell_prod.ShowShortcut = CType(resources.GetObject("mnu_sell_prod.ShowShortcut"), Boolean)
        Me.mnu_sell_prod.Text = resources.GetString("mnu_sell_prod.Text")
        Me.mnu_sell_prod.Visible = CType(resources.GetObject("mnu_sell_prod.Visible"), Boolean)
        '
        'MenuItem26
        '
        Me.MenuItem26.Enabled = CType(resources.GetObject("MenuItem26.Enabled"), Boolean)
        Me.MenuItem26.Index = 1
        Me.MenuItem26.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menu_sell_newvei, Me.menu_sell_oldvei})
        Me.MenuItem26.Shortcut = CType(resources.GetObject("MenuItem26.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem26.ShowShortcut = CType(resources.GetObject("MenuItem26.ShowShortcut"), Boolean)
        Me.MenuItem26.Text = resources.GetString("MenuItem26.Text")
        Me.MenuItem26.Visible = CType(resources.GetObject("MenuItem26.Visible"), Boolean)
        '
        'menu_sell_newvei
        '
        Me.menu_sell_newvei.Enabled = CType(resources.GetObject("menu_sell_newvei.Enabled"), Boolean)
        Me.menu_sell_newvei.Index = 0
        Me.menu_sell_newvei.Shortcut = CType(resources.GetObject("menu_sell_newvei.Shortcut"), System.Windows.Forms.Shortcut)
        Me.menu_sell_newvei.ShowShortcut = CType(resources.GetObject("menu_sell_newvei.ShowShortcut"), Boolean)
        Me.menu_sell_newvei.Text = resources.GetString("menu_sell_newvei.Text")
        Me.menu_sell_newvei.Visible = CType(resources.GetObject("menu_sell_newvei.Visible"), Boolean)
        '
        'menu_sell_oldvei
        '
        Me.menu_sell_oldvei.Enabled = CType(resources.GetObject("menu_sell_oldvei.Enabled"), Boolean)
        Me.menu_sell_oldvei.Index = 1
        Me.menu_sell_oldvei.Shortcut = CType(resources.GetObject("menu_sell_oldvei.Shortcut"), System.Windows.Forms.Shortcut)
        Me.menu_sell_oldvei.ShowShortcut = CType(resources.GetObject("menu_sell_oldvei.ShowShortcut"), Boolean)
        Me.menu_sell_oldvei.Text = resources.GetString("menu_sell_oldvei.Text")
        Me.menu_sell_oldvei.Visible = CType(resources.GetObject("menu_sell_oldvei.Visible"), Boolean)
        '
        'MenuItem16
        '
        Me.MenuItem16.Enabled = CType(resources.GetObject("MenuItem16.Enabled"), Boolean)
        Me.MenuItem16.Index = 2
        Me.MenuItem16.Shortcut = CType(resources.GetObject("MenuItem16.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem16.ShowShortcut = CType(resources.GetObject("MenuItem16.ShowShortcut"), Boolean)
        Me.MenuItem16.Text = resources.GetString("MenuItem16.Text")
        Me.MenuItem16.Visible = CType(resources.GetObject("MenuItem16.Visible"), Boolean)
        '
        'mnu_logoff
        '
        Me.mnu_logoff.Enabled = CType(resources.GetObject("mnu_logoff.Enabled"), Boolean)
        Me.mnu_logoff.Index = 3
        Me.mnu_logoff.Shortcut = CType(resources.GetObject("mnu_logoff.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu_logoff.ShowShortcut = CType(resources.GetObject("mnu_logoff.ShowShortcut"), Boolean)
        Me.mnu_logoff.Text = resources.GetString("mnu_logoff.Text")
        Me.mnu_logoff.Visible = CType(resources.GetObject("mnu_logoff.Visible"), Boolean)
        '
        'mnu_sair
        '
        Me.mnu_sair.Enabled = CType(resources.GetObject("mnu_sair.Enabled"), Boolean)
        Me.mnu_sair.Index = 4
        Me.mnu_sair.Shortcut = CType(resources.GetObject("mnu_sair.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu_sair.ShowShortcut = CType(resources.GetObject("mnu_sair.ShowShortcut"), Boolean)
        Me.mnu_sair.Text = resources.GetString("mnu_sair.Text")
        Me.mnu_sair.Visible = CType(resources.GetObject("mnu_sair.Visible"), Boolean)
        '
        'MenuItem2
        '
        Me.MenuItem2.Enabled = CType(resources.GetObject("MenuItem2.Enabled"), Boolean)
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_systray, Me.mnu_users})
        Me.MenuItem2.Shortcut = CType(resources.GetObject("MenuItem2.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem2.ShowShortcut = CType(resources.GetObject("MenuItem2.ShowShortcut"), Boolean)
        Me.MenuItem2.Text = resources.GetString("MenuItem2.Text")
        Me.MenuItem2.Visible = CType(resources.GetObject("MenuItem2.Visible"), Boolean)
        '
        'mnu_systray
        '
        Me.mnu_systray.Enabled = CType(resources.GetObject("mnu_systray.Enabled"), Boolean)
        Me.mnu_systray.Index = 0
        Me.mnu_systray.Shortcut = CType(resources.GetObject("mnu_systray.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu_systray.ShowShortcut = CType(resources.GetObject("mnu_systray.ShowShortcut"), Boolean)
        Me.mnu_systray.Text = resources.GetString("mnu_systray.Text")
        Me.mnu_systray.Visible = CType(resources.GetObject("mnu_systray.Visible"), Boolean)
        '
        'mnu_users
        '
        Me.mnu_users.Enabled = CType(resources.GetObject("mnu_users.Enabled"), Boolean)
        Me.mnu_users.Index = 1
        Me.mnu_users.Shortcut = CType(resources.GetObject("mnu_users.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu_users.ShowShortcut = CType(resources.GetObject("mnu_users.ShowShortcut"), Boolean)
        Me.mnu_users.Text = resources.GetString("mnu_users.Text")
        Me.mnu_users.Visible = CType(resources.GetObject("mnu_users.Visible"), Boolean)
        '
        'MenuItem3
        '
        Me.MenuItem3.Enabled = CType(resources.GetObject("MenuItem3.Enabled"), Boolean)
        Me.MenuItem3.Index = 2
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem12, Me.MenuItem13, Me.MenuItem14, Me.MenuItem11})
        Me.MenuItem3.Shortcut = CType(resources.GetObject("MenuItem3.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem3.ShowShortcut = CType(resources.GetObject("MenuItem3.ShowShortcut"), Boolean)
        Me.MenuItem3.Text = resources.GetString("MenuItem3.Text")
        Me.MenuItem3.Visible = CType(resources.GetObject("MenuItem3.Visible"), Boolean)
        '
        'MenuItem6
        '
        Me.MenuItem6.Enabled = CType(resources.GetObject("MenuItem6.Enabled"), Boolean)
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Shortcut = CType(resources.GetObject("MenuItem6.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem6.ShowShortcut = CType(resources.GetObject("MenuItem6.ShowShortcut"), Boolean)
        Me.MenuItem6.Text = resources.GetString("MenuItem6.Text")
        Me.MenuItem6.Visible = CType(resources.GetObject("MenuItem6.Visible"), Boolean)
        '
        'MenuItem12
        '
        Me.MenuItem12.Enabled = CType(resources.GetObject("MenuItem12.Enabled"), Boolean)
        Me.MenuItem12.Index = 1
        Me.MenuItem12.Shortcut = CType(resources.GetObject("MenuItem12.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem12.ShowShortcut = CType(resources.GetObject("MenuItem12.ShowShortcut"), Boolean)
        Me.MenuItem12.Text = resources.GetString("MenuItem12.Text")
        Me.MenuItem12.Visible = CType(resources.GetObject("MenuItem12.Visible"), Boolean)
        '
        'MenuItem13
        '
        Me.MenuItem13.Enabled = CType(resources.GetObject("MenuItem13.Enabled"), Boolean)
        Me.MenuItem13.Index = 2
        Me.MenuItem13.Shortcut = CType(resources.GetObject("MenuItem13.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem13.ShowShortcut = CType(resources.GetObject("MenuItem13.ShowShortcut"), Boolean)
        Me.MenuItem13.Text = resources.GetString("MenuItem13.Text")
        Me.MenuItem13.Visible = CType(resources.GetObject("MenuItem13.Visible"), Boolean)
        '
        'MenuItem14
        '
        Me.MenuItem14.Enabled = CType(resources.GetObject("MenuItem14.Enabled"), Boolean)
        Me.MenuItem14.Index = 3
        Me.MenuItem14.Shortcut = CType(resources.GetObject("MenuItem14.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem14.ShowShortcut = CType(resources.GetObject("MenuItem14.ShowShortcut"), Boolean)
        Me.MenuItem14.Text = resources.GetString("MenuItem14.Text")
        Me.MenuItem14.Visible = CType(resources.GetObject("MenuItem14.Visible"), Boolean)
        '
        'MenuItem11
        '
        Me.MenuItem11.Enabled = CType(resources.GetObject("MenuItem11.Enabled"), Boolean)
        Me.MenuItem11.Index = 4
        Me.MenuItem11.Shortcut = CType(resources.GetObject("MenuItem11.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem11.ShowShortcut = CType(resources.GetObject("MenuItem11.ShowShortcut"), Boolean)
        Me.MenuItem11.Text = resources.GetString("MenuItem11.Text")
        Me.MenuItem11.Visible = CType(resources.GetObject("MenuItem11.Visible"), Boolean)
        '
        'IconTray
        '
        Me.IconTray.ContextMenu = Me.Menuzinho
        Me.IconTray.Icon = CType(resources.GetObject("IconTray.Icon"), System.Drawing.Icon)
        Me.IconTray.Text = CType(configurationAppSettings.GetValue("IconTray.Text", GetType(System.String)), String)
        Me.IconTray.Visible = CType(configurationAppSettings.GetValue("IconTray.Visible", GetType(System.Boolean)), Boolean)
        '
        'Menuzinho
        '
        Me.Menuzinho.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_Abrir, Me.MenuItem8, Me.MenuItem10, Me.MenuItem4, Me.Menu_Sair})
        Me.Menuzinho.RightToLeft = CType(resources.GetObject("Menuzinho.RightToLeft"), System.Windows.Forms.RightToLeft)
        '
        'Menu_Abrir
        '
        Me.Menu_Abrir.DefaultItem = True
        Me.Menu_Abrir.Enabled = CType(resources.GetObject("Menu_Abrir.Enabled"), Boolean)
        Me.Menu_Abrir.Index = 0
        Me.Menu_Abrir.Shortcut = CType(resources.GetObject("Menu_Abrir.Shortcut"), System.Windows.Forms.Shortcut)
        Me.Menu_Abrir.ShowShortcut = CType(resources.GetObject("Menu_Abrir.ShowShortcut"), Boolean)
        Me.Menu_Abrir.Text = resources.GetString("Menu_Abrir.Text")
        Me.Menu_Abrir.Visible = CType(resources.GetObject("Menu_Abrir.Visible"), Boolean)
        '
        'MenuItem8
        '
        Me.MenuItem8.Enabled = CType(resources.GetObject("MenuItem8.Enabled"), Boolean)
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Shortcut = CType(resources.GetObject("MenuItem8.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem8.ShowShortcut = CType(resources.GetObject("MenuItem8.ShowShortcut"), Boolean)
        Me.MenuItem8.Text = resources.GetString("MenuItem8.Text")
        Me.MenuItem8.Visible = CType(resources.GetObject("MenuItem8.Visible"), Boolean)
        '
        'MenuItem10
        '
        Me.MenuItem10.Enabled = CType(resources.GetObject("MenuItem10.Enabled"), Boolean)
        Me.MenuItem10.Index = 2
        Me.MenuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_Cliente, Me.Menu_Aluguel, Me.Menu_Compra, Me.MenuForn, Me.Menu_Fun, Me.Menu_mec, Me.Menu_users, Me.Menu_vend})
        Me.MenuItem10.Shortcut = CType(resources.GetObject("MenuItem10.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem10.ShowShortcut = CType(resources.GetObject("MenuItem10.ShowShortcut"), Boolean)
        Me.MenuItem10.Text = resources.GetString("MenuItem10.Text")
        Me.MenuItem10.Visible = CType(resources.GetObject("MenuItem10.Visible"), Boolean)
        '
        'Menu_Cliente
        '
        Me.Menu_Cliente.DefaultItem = True
        Me.Menu_Cliente.Enabled = CType(resources.GetObject("Menu_Cliente.Enabled"), Boolean)
        Me.Menu_Cliente.Index = 0
        Me.Menu_Cliente.Shortcut = CType(resources.GetObject("Menu_Cliente.Shortcut"), System.Windows.Forms.Shortcut)
        Me.Menu_Cliente.ShowShortcut = CType(resources.GetObject("Menu_Cliente.ShowShortcut"), Boolean)
        Me.Menu_Cliente.Text = resources.GetString("Menu_Cliente.Text")
        Me.Menu_Cliente.Visible = CType(resources.GetObject("Menu_Cliente.Visible"), Boolean)
        '
        'Menu_Aluguel
        '
        Me.Menu_Aluguel.Enabled = CType(resources.GetObject("Menu_Aluguel.Enabled"), Boolean)
        Me.Menu_Aluguel.Index = 1
        Me.Menu_Aluguel.Shortcut = CType(resources.GetObject("Menu_Aluguel.Shortcut"), System.Windows.Forms.Shortcut)
        Me.Menu_Aluguel.ShowShortcut = CType(resources.GetObject("Menu_Aluguel.ShowShortcut"), Boolean)
        Me.Menu_Aluguel.Text = resources.GetString("Menu_Aluguel.Text")
        Me.Menu_Aluguel.Visible = CType(resources.GetObject("Menu_Aluguel.Visible"), Boolean)
        '
        'Menu_Compra
        '
        Me.Menu_Compra.Enabled = CType(resources.GetObject("Menu_Compra.Enabled"), Boolean)
        Me.Menu_Compra.Index = 2
        Me.Menu_Compra.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.compra_prod, Me.compra_vei})
        Me.Menu_Compra.Shortcut = CType(resources.GetObject("Menu_Compra.Shortcut"), System.Windows.Forms.Shortcut)
        Me.Menu_Compra.ShowShortcut = CType(resources.GetObject("Menu_Compra.ShowShortcut"), Boolean)
        Me.Menu_Compra.Text = resources.GetString("Menu_Compra.Text")
        Me.Menu_Compra.Visible = CType(resources.GetObject("Menu_Compra.Visible"), Boolean)
        '
        'compra_prod
        '
        Me.compra_prod.Enabled = CType(resources.GetObject("compra_prod.Enabled"), Boolean)
        Me.compra_prod.Index = 0
        Me.compra_prod.Shortcut = CType(resources.GetObject("compra_prod.Shortcut"), System.Windows.Forms.Shortcut)
        Me.compra_prod.ShowShortcut = CType(resources.GetObject("compra_prod.ShowShortcut"), Boolean)
        Me.compra_prod.Text = resources.GetString("compra_prod.Text")
        Me.compra_prod.Visible = CType(resources.GetObject("compra_prod.Visible"), Boolean)
        '
        'compra_vei
        '
        Me.compra_vei.Enabled = CType(resources.GetObject("compra_vei.Enabled"), Boolean)
        Me.compra_vei.Index = 1
        Me.compra_vei.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.compra_newvei, Me.compra_oldvei})
        Me.compra_vei.Shortcut = CType(resources.GetObject("compra_vei.Shortcut"), System.Windows.Forms.Shortcut)
        Me.compra_vei.ShowShortcut = CType(resources.GetObject("compra_vei.ShowShortcut"), Boolean)
        Me.compra_vei.Text = resources.GetString("compra_vei.Text")
        Me.compra_vei.Visible = CType(resources.GetObject("compra_vei.Visible"), Boolean)
        '
        'compra_newvei
        '
        Me.compra_newvei.Enabled = CType(resources.GetObject("compra_newvei.Enabled"), Boolean)
        Me.compra_newvei.Index = 0
        Me.compra_newvei.Shortcut = CType(resources.GetObject("compra_newvei.Shortcut"), System.Windows.Forms.Shortcut)
        Me.compra_newvei.ShowShortcut = CType(resources.GetObject("compra_newvei.ShowShortcut"), Boolean)
        Me.compra_newvei.Text = resources.GetString("compra_newvei.Text")
        Me.compra_newvei.Visible = CType(resources.GetObject("compra_newvei.Visible"), Boolean)
        '
        'compra_oldvei
        '
        Me.compra_oldvei.Enabled = CType(resources.GetObject("compra_oldvei.Enabled"), Boolean)
        Me.compra_oldvei.Index = 1
        Me.compra_oldvei.Shortcut = CType(resources.GetObject("compra_oldvei.Shortcut"), System.Windows.Forms.Shortcut)
        Me.compra_oldvei.ShowShortcut = CType(resources.GetObject("compra_oldvei.ShowShortcut"), Boolean)
        Me.compra_oldvei.Text = resources.GetString("compra_oldvei.Text")
        Me.compra_oldvei.Visible = CType(resources.GetObject("compra_oldvei.Visible"), Boolean)
        '
        'MenuForn
        '
        Me.MenuForn.Enabled = CType(resources.GetObject("MenuForn.Enabled"), Boolean)
        Me.MenuForn.Index = 3
        Me.MenuForn.Shortcut = CType(resources.GetObject("MenuForn.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuForn.ShowShortcut = CType(resources.GetObject("MenuForn.ShowShortcut"), Boolean)
        Me.MenuForn.Text = resources.GetString("MenuForn.Text")
        Me.MenuForn.Visible = CType(resources.GetObject("MenuForn.Visible"), Boolean)
        '
        'Menu_Fun
        '
        Me.Menu_Fun.Enabled = CType(resources.GetObject("Menu_Fun.Enabled"), Boolean)
        Me.Menu_Fun.Index = 4
        Me.Menu_Fun.Shortcut = CType(resources.GetObject("Menu_Fun.Shortcut"), System.Windows.Forms.Shortcut)
        Me.Menu_Fun.ShowShortcut = CType(resources.GetObject("Menu_Fun.ShowShortcut"), Boolean)
        Me.Menu_Fun.Text = resources.GetString("Menu_Fun.Text")
        Me.Menu_Fun.Visible = CType(resources.GetObject("Menu_Fun.Visible"), Boolean)
        '
        'Menu_mec
        '
        Me.Menu_mec.Enabled = CType(resources.GetObject("Menu_mec.Enabled"), Boolean)
        Me.Menu_mec.Index = 5
        Me.Menu_mec.Shortcut = CType(resources.GetObject("Menu_mec.Shortcut"), System.Windows.Forms.Shortcut)
        Me.Menu_mec.ShowShortcut = CType(resources.GetObject("Menu_mec.ShowShortcut"), Boolean)
        Me.Menu_mec.Text = resources.GetString("Menu_mec.Text")
        Me.Menu_mec.Visible = CType(resources.GetObject("Menu_mec.Visible"), Boolean)
        '
        'Menu_users
        '
        Me.Menu_users.Enabled = CType(resources.GetObject("Menu_users.Enabled"), Boolean)
        Me.Menu_users.Index = 6
        Me.Menu_users.Shortcut = CType(resources.GetObject("Menu_users.Shortcut"), System.Windows.Forms.Shortcut)
        Me.Menu_users.ShowShortcut = CType(resources.GetObject("Menu_users.ShowShortcut"), Boolean)
        Me.Menu_users.Text = resources.GetString("Menu_users.Text")
        Me.Menu_users.Visible = CType(resources.GetObject("Menu_users.Visible"), Boolean)
        '
        'Menu_vend
        '
        Me.Menu_vend.Enabled = CType(resources.GetObject("Menu_vend.Enabled"), Boolean)
        Me.Menu_vend.Index = 7
        Me.Menu_vend.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.venda_prod, Me.Venda_vei})
        Me.Menu_vend.Shortcut = CType(resources.GetObject("Menu_vend.Shortcut"), System.Windows.Forms.Shortcut)
        Me.Menu_vend.ShowShortcut = CType(resources.GetObject("Menu_vend.ShowShortcut"), Boolean)
        Me.Menu_vend.Text = resources.GetString("Menu_vend.Text")
        Me.Menu_vend.Visible = CType(resources.GetObject("Menu_vend.Visible"), Boolean)
        '
        'venda_prod
        '
        Me.venda_prod.Enabled = CType(resources.GetObject("venda_prod.Enabled"), Boolean)
        Me.venda_prod.Index = 0
        Me.venda_prod.Shortcut = CType(resources.GetObject("venda_prod.Shortcut"), System.Windows.Forms.Shortcut)
        Me.venda_prod.ShowShortcut = CType(resources.GetObject("venda_prod.ShowShortcut"), Boolean)
        Me.venda_prod.Text = resources.GetString("venda_prod.Text")
        Me.venda_prod.Visible = CType(resources.GetObject("venda_prod.Visible"), Boolean)
        '
        'Venda_vei
        '
        Me.Venda_vei.Enabled = CType(resources.GetObject("Venda_vei.Enabled"), Boolean)
        Me.Venda_vei.Index = 1
        Me.Venda_vei.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.venda_newvei, Me.venda_oldvei})
        Me.Venda_vei.Shortcut = CType(resources.GetObject("Venda_vei.Shortcut"), System.Windows.Forms.Shortcut)
        Me.Venda_vei.ShowShortcut = CType(resources.GetObject("Venda_vei.ShowShortcut"), Boolean)
        Me.Venda_vei.Text = resources.GetString("Venda_vei.Text")
        Me.Venda_vei.Visible = CType(resources.GetObject("Venda_vei.Visible"), Boolean)
        '
        'venda_newvei
        '
        Me.venda_newvei.Enabled = CType(resources.GetObject("venda_newvei.Enabled"), Boolean)
        Me.venda_newvei.Index = 0
        Me.venda_newvei.Shortcut = CType(resources.GetObject("venda_newvei.Shortcut"), System.Windows.Forms.Shortcut)
        Me.venda_newvei.ShowShortcut = CType(resources.GetObject("venda_newvei.ShowShortcut"), Boolean)
        Me.venda_newvei.Text = resources.GetString("venda_newvei.Text")
        Me.venda_newvei.Visible = CType(resources.GetObject("venda_newvei.Visible"), Boolean)
        '
        'venda_oldvei
        '
        Me.venda_oldvei.Enabled = CType(resources.GetObject("venda_oldvei.Enabled"), Boolean)
        Me.venda_oldvei.Index = 1
        Me.venda_oldvei.Shortcut = CType(resources.GetObject("venda_oldvei.Shortcut"), System.Windows.Forms.Shortcut)
        Me.venda_oldvei.ShowShortcut = CType(resources.GetObject("venda_oldvei.ShowShortcut"), Boolean)
        Me.venda_oldvei.Text = resources.GetString("venda_oldvei.Text")
        Me.venda_oldvei.Visible = CType(resources.GetObject("venda_oldvei.Visible"), Boolean)
        '
        'MenuItem4
        '
        Me.MenuItem4.Enabled = CType(resources.GetObject("MenuItem4.Enabled"), Boolean)
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Shortcut = CType(resources.GetObject("MenuItem4.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem4.ShowShortcut = CType(resources.GetObject("MenuItem4.ShowShortcut"), Boolean)
        Me.MenuItem4.Text = resources.GetString("MenuItem4.Text")
        Me.MenuItem4.Visible = CType(resources.GetObject("MenuItem4.Visible"), Boolean)
        '
        'Menu_Sair
        '
        Me.Menu_Sair.Enabled = CType(resources.GetObject("Menu_Sair.Enabled"), Boolean)
        Me.Menu_Sair.Index = 4
        Me.Menu_Sair.Shortcut = CType(resources.GetObject("Menu_Sair.Shortcut"), System.Windows.Forms.Shortcut)
        Me.Menu_Sair.ShowShortcut = CType(resources.GetObject("Menu_Sair.ShowShortcut"), Boolean)
        Me.Menu_Sair.Text = resources.GetString("Menu_Sair.Text")
        Me.Menu_Sair.Visible = CType(resources.GetObject("Menu_Sair.Visible"), Boolean)
        '
        'frminicio2
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.ControlBox = False
        Me.Controls.Add(Me.bt_financas)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bt_forn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bt_func)
        Me.Controls.Add(Me.bt_alugueis)
        Me.Controls.Add(Me.bt_vendas)
        Me.Controls.Add(Me.bt_mec)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Bt_Compra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.HelpButton = True
        Me.ProvedordAjuda.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me, resources.GetString("$this.HelpString"))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.Menu = Me.MenuPrincipal
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frminicio2"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ProvedordAjuda.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.FerramentaDica.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public cont As Integer = 1
    Public cont_vei As Integer = 1
    Public cont_compra As Integer = 1
    Public cont_compra_vei As Integer = 1

#Region "Botoes"

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_alugueis.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False


        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        Aluguel.Show()
        Me.Visible = False
        IconTray.Visible = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_func.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        funcionarios.Visible = True
        Me.Visible = False
        IconTray.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_vendas.Click
        Panel2.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False
        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1

        cont = cont + 1
        If cont Mod 2 = 0 Then
            BtProd.Visible = True
            btVei.Visible = True
            Panel1.Visible = True
        Else
            BtProd.Visible = False
            btVei.Visible = False
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mec.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        Mec.Show()

        Me.Visible = False
        IconTray.Visible = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_forn.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        fornecedor.Show()
        Me.Visible = False
        IconTray.Visible = True
    End Sub

    Private Sub BtProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtProd.Click

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        venda_produtos.Show()
        Me.Visible = False
        IconTray.Visible = True


    End Sub

    Private Sub btVei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVei.Click
        cont_vei = cont_vei + 1
        If cont_vei Mod 2 = 0 Then
            Panel2.Visible = True
            bt_novos.Visible = True
            Bt_usados.Visible = True
        Else
            Panel2.Visible = False
            bt_novos.Visible = False
            Bt_usados.Visible = False
        End If

    End Sub

    Private Sub bt_novos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_novos.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont = 1
        cont_vei = 1
        venda_veiculo_novo.Show()
        Me.Visible = False
        IconTray.Visible = True
    End Sub

    Private Sub Bt_usados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_usados.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False



        cont_compra_vei = 1
        cont_compra = 1
        cont = 1
        cont_vei = 1
        venda_veiculo_usado.Show()
        Me.Visible = False
        IconTray.Visible = True

    End Sub

    Private Sub Bt_Compra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Compra.Click

        Panel1.Visible = False
        Panel2.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False
        Panel4.Visible = False
        cont = 1
        cont_vei = 1
        cont_compra_vei = 1

        cont_compra = cont_compra + 1
        If cont_compra Mod 2 = 0 Then
            Panel3.Visible = True
            bt_cprod.Visible = True
            Bt_Cvei.Visible = True
        Else
            Panel3.Visible = False
            bt_cprod.Visible = False
            Bt_Cvei.Visible = False
        End If
    End Sub

    Private Sub Bt_CNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_CNew.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont = 1
        cont_vei = 1
        buy_newvei.Show()
        Me.Visible = False
        IconTray.Visible = True
    End Sub

    Private Sub BT_COLD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_COLD.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont = 1
        cont_vei = 1
        buy_oldvei.Show()
        Me.Visible = False
        IconTray.Visible = True

    End Sub

    Private Sub Bt_Cvei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Cvei.Click
        cont_compra_vei = cont_compra_vei + 1
        If cont_compra_vei Mod 2 = 0 Then
            Panel4.Visible = True
            Bt_CNew.Visible = True
            BT_COLD.Visible = True
        Else
            Panel4.Visible = False
            Bt_CNew.Visible = False
            BT_COLD.Visible = False
        End If
    End Sub

    Private Sub bt_cprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cprod.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont = 1
        cont_vei = 1
        buy_prod.Show()
        Me.Visible = False
        IconTray.Visible = True
    End Sub

#End Region

#Region " Menu(tray)"

    Private Sub mnu_users_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_users.Click
        users.Visible = True
        Me.Visible = False
    End Sub

    Private Sub mnu_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_sair.Click
        Application.Exit()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        inicial.Refresh()
        IconTray.Visible = False
        IconTray.Visible = False
        IconTray.Visible = False
        Me.Visible = False
        mecan = False
        compras = False
        vendas = False
        financass = False
        alugueis = False
        cadastros = False
        adm = False
        inicial.Visible = True
    End Sub

    Private Sub IconTray_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IconTray.DoubleClick

        Me.Visible = True
        IconTray.Visible = False

    End Sub

    Private Sub Menu_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Cliente.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        cadastrocli_alu.ShowDialog()
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_systray.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        Me.Visible = False
        IconTray.Visible = True
    End Sub

    Private Sub mnu_logoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_logoff.Click
        inicial.Refresh()
        IconTray.Visible = False
        IconTray.Visible = False
        IconTray.Visible = False
        Me.Visible = False
        mecan = False
        compras = False
        vendas = False
        financass = False
        alugueis = False
        cadastros = False
        adm = False
        inicial.Visible = True
    End Sub

    Private Sub Menu_Abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Abrir.Click
        Me.Visible = True
        IconTray.Visible = False
    End Sub

    Private Sub Menu_Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Sair.Click
        IconTray.Visible = False
        Application.Exit()
    End Sub

    Private Sub Menu_Aluguel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Aluguel.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        If Aluguel.Visible = False Then
            Aluguel.Visible = True

        End If


    End Sub

    Private Sub MenuForn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuForn.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        fornecedor.ShowDialog()
    End Sub

    Private Sub Menu_Fun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Fun.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        funcionarios.ShowDialog()
    End Sub

    Private Sub Menu_mec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_mec.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        Mec.ShowDialog()
    End Sub

    Private Sub compra_prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles compra_prod.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont = 1
        cont_vei = 1
        buy_prod.ShowDialog()
    End Sub

    Private Sub compra_newvei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles compra_newvei.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont = 1
        cont_vei = 1
        buy_newvei.ShowDialog()
    End Sub

    Private Sub compra_oldvei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles compra_oldvei.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont = 1
        cont_vei = 1
        buy_oldvei.ShowDialog()

    End Sub

    Private Sub venda_prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles venda_prod.Click

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        venda_produtos.ShowDialog()
    End Sub

    Private Sub venda_newvei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles venda_newvei.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont = 1
        cont_vei = 1
        venda_veiculo_novo.ShowDialog()
    End Sub

    Private Sub venda_oldvei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles venda_oldvei.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False



        cont_compra_vei = 1
        cont_compra = 1
        cont = 1
        cont_vei = 1
        venda_veiculo_novo.ShowDialog()
    End Sub
#End Region

#Region "Menu(Form)"

    Private Sub menu_cli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_cli.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        cadastrocli_alu.ShowDialog()
    End Sub

    Private Sub mnu_aluguel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_aluguel.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        Aluguel.ShowDialog()
    End Sub

    Private Sub mnu_buyProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_buyProd.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont = 1
        cont_vei = 1
        buy_prod.ShowDialog()
    End Sub

    Private Sub mnu_buy_newvei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_buy_newvei.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont = 1
        cont_vei = 1
        buy_newvei.ShowDialog()
    End Sub

    Private Sub mnu_buy_oldvei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_buy_oldvei.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont = 1
        cont_vei = 1
        buy_oldvei.ShowDialog()
    End Sub

    Private Sub mnu_finan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_finan.Click

    End Sub

    Private Sub mnu_forn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_forn.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        fornecedor.ShowDialog()
    End Sub

    Private Sub mnu_fun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_fun.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        funcionarios.ShowDialog()
    End Sub

    Private Sub mnu_mec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_mec.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        Mec.ShowDialog()
    End Sub

    Private Sub mnu_sell_prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_sell_prod.Click

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont_vei = 1
        cont = 1
        venda_produtos.ShowDialog()
    End Sub

    Private Sub menu_sell_newvei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_sell_newvei.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False

        cont_compra_vei = 1
        cont_compra = 1
        cont = 1
        cont_vei = 1
        venda_veiculo_novo.ShowDialog()
    End Sub

    Private Sub menu_sell_oldvei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_sell_oldvei.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        BtProd.Visible = False
        btVei.Visible = False
        bt_novos.Visible = False
        Bt_usados.Visible = False
        bt_cprod.Visible = False
        Bt_Cvei.Visible = False
        Bt_CNew.Visible = False
        BT_COLD.Visible = False


        cont_compra_vei = 1
        cont_compra = 1
        cont = 1
        cont_vei = 1
        venda_veiculo_novo.ShowDialog()
    End Sub

#End Region

    Private Sub frminicio2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IconTray.Visible = False

    End Sub

    Private Sub mnu_changetheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        change_theme.ShowDialog()
    End Sub

    Private Sub bt_financas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_financas.Click
        Me.Visible = False
        financas.Visible = True
    End Sub

End Class
