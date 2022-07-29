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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frminicio2))
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bt_func = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.bt_alugueis = New System.Windows.Forms.Button()
        Me.bt_vendas = New System.Windows.Forms.Button()
        Me.bt_mec = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_forn = New System.Windows.Forms.Button()
        Me.ProvedordAjuda = New System.Windows.Forms.HelpProvider()
        Me.Bt_Compra = New System.Windows.Forms.Button()
        Me.bt_financas = New System.Windows.Forms.Button()
        Me.BtProd = New System.Windows.Forms.Button()
        Me.btVei = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Bt_usados = New System.Windows.Forms.Button()
        Me.bt_novos = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Bt_Cvei = New System.Windows.Forms.Button()
        Me.bt_cprod = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BT_COLD = New System.Windows.Forms.Button()
        Me.Bt_CNew = New System.Windows.Forms.Button()
        Me.MenuPrincipal = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.menu_cli = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.mnu_aluguel = New System.Windows.Forms.MenuItem()
        Me.mnu_buy = New System.Windows.Forms.MenuItem()
        Me.mnu_buyProd = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.mnu_buy_newvei = New System.Windows.Forms.MenuItem()
        Me.mnu_buy_oldvei = New System.Windows.Forms.MenuItem()
        Me.mnu_finan = New System.Windows.Forms.MenuItem()
        Me.mnu_forn = New System.Windows.Forms.MenuItem()
        Me.mnu_fun = New System.Windows.Forms.MenuItem()
        Me.mnu_mec = New System.Windows.Forms.MenuItem()
        Me.mnu_sell = New System.Windows.Forms.MenuItem()
        Me.mnu_sell_prod = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.menu_sell_newvei = New System.Windows.Forms.MenuItem()
        Me.menu_sell_oldvei = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.mnu_logoff = New System.Windows.Forms.MenuItem()
        Me.mnu_sair = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.mnu_systray = New System.Windows.Forms.MenuItem()
        Me.mnu_users = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.FerramentaDica = New System.Windows.Forms.ToolTip(Me.components)
        Me.IconTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Menuzinho = New System.Windows.Forms.ContextMenu()
        Me.Menu_Abrir = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.Menu_Cliente = New System.Windows.Forms.MenuItem()
        Me.Menu_Aluguel = New System.Windows.Forms.MenuItem()
        Me.Menu_Compra = New System.Windows.Forms.MenuItem()
        Me.compra_prod = New System.Windows.Forms.MenuItem()
        Me.compra_vei = New System.Windows.Forms.MenuItem()
        Me.compra_newvei = New System.Windows.Forms.MenuItem()
        Me.compra_oldvei = New System.Windows.Forms.MenuItem()
        Me.MenuForn = New System.Windows.Forms.MenuItem()
        Me.Menu_Fun = New System.Windows.Forms.MenuItem()
        Me.Menu_mec = New System.Windows.Forms.MenuItem()
        Me.Menu_users = New System.Windows.Forms.MenuItem()
        Me.Menu_vend = New System.Windows.Forms.MenuItem()
        Me.venda_prod = New System.Windows.Forms.MenuItem()
        Me.Venda_vei = New System.Windows.Forms.MenuItem()
        Me.venda_newvei = New System.Windows.Forms.MenuItem()
        Me.venda_oldvei = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.Menu_Sair = New System.Windows.Forms.MenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ProvedordAjuda.SetHelpKeyword(Me.Label3, resources.GetString("Label3.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Label3, CType(resources.GetObject("Label3.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Label3, resources.GetString("Label3.HelpString"))
        Me.Label3.Name = "Label3"
        Me.ProvedordAjuda.SetShowHelp(Me.Label3, CType(resources.GetObject("Label3.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ProvedordAjuda.SetHelpKeyword(Me.Label2, resources.GetString("Label2.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Label2, CType(resources.GetObject("Label2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Label2, resources.GetString("Label2.HelpString"))
        Me.Label2.Name = "Label2"
        Me.ProvedordAjuda.SetShowHelp(Me.Label2, CType(resources.GetObject("Label2.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.Label2, resources.GetString("Label2.ToolTip"))
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.ProvedordAjuda.SetHelpKeyword(Me.PictureBox1, resources.GetString("PictureBox1.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.PictureBox1, CType(resources.GetObject("PictureBox1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.PictureBox1, resources.GetString("PictureBox1.HelpString"))
        Me.PictureBox1.Name = "PictureBox1"
        Me.ProvedordAjuda.SetShowHelp(Me.PictureBox1, CType(resources.GetObject("PictureBox1.ShowHelp"), Boolean))
        Me.PictureBox1.TabStop = False
        Me.FerramentaDica.SetToolTip(Me.PictureBox1, resources.GetString("PictureBox1.ToolTip"))
        '
        'bt_func
        '
        resources.ApplyResources(Me.bt_func, "bt_func")
        Me.bt_func.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_func.ForeColor = System.Drawing.Color.White
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_func, resources.GetString("bt_func.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_func, CType(resources.GetObject("bt_func.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_func, resources.GetString("bt_func.HelpString"))
        Me.bt_func.Name = "bt_func"
        Me.ProvedordAjuda.SetShowHelp(Me.bt_func, CType(resources.GetObject("bt_func.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.bt_func, resources.GetString("bt_func.ToolTip"))
        Me.bt_func.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.ProvedordAjuda.SetHelpKeyword(Me.PictureBox2, resources.GetString("PictureBox2.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.PictureBox2, CType(resources.GetObject("PictureBox2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.PictureBox2, resources.GetString("PictureBox2.HelpString"))
        Me.PictureBox2.Name = "PictureBox2"
        Me.ProvedordAjuda.SetShowHelp(Me.PictureBox2, CType(resources.GetObject("PictureBox2.ShowHelp"), Boolean))
        Me.PictureBox2.TabStop = False
        Me.FerramentaDica.SetToolTip(Me.PictureBox2, resources.GetString("PictureBox2.ToolTip"))
        '
        'bt_alugueis
        '
        resources.ApplyResources(Me.bt_alugueis, "bt_alugueis")
        Me.bt_alugueis.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_alugueis.ForeColor = System.Drawing.Color.White
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_alugueis, resources.GetString("bt_alugueis.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_alugueis, CType(resources.GetObject("bt_alugueis.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_alugueis, resources.GetString("bt_alugueis.HelpString"))
        Me.bt_alugueis.Name = "bt_alugueis"
        Me.ProvedordAjuda.SetShowHelp(Me.bt_alugueis, CType(resources.GetObject("bt_alugueis.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.bt_alugueis, resources.GetString("bt_alugueis.ToolTip"))
        Me.bt_alugueis.UseVisualStyleBackColor = False
        '
        'bt_vendas
        '
        resources.ApplyResources(Me.bt_vendas, "bt_vendas")
        Me.bt_vendas.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_vendas.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_vendas.ForeColor = System.Drawing.Color.White
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_vendas, resources.GetString("bt_vendas.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_vendas, CType(resources.GetObject("bt_vendas.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_vendas, resources.GetString("bt_vendas.HelpString"))
        Me.bt_vendas.Name = "bt_vendas"
        Me.ProvedordAjuda.SetShowHelp(Me.bt_vendas, CType(resources.GetObject("bt_vendas.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.bt_vendas, resources.GetString("bt_vendas.ToolTip"))
        Me.bt_vendas.UseVisualStyleBackColor = False
        '
        'bt_mec
        '
        resources.ApplyResources(Me.bt_mec, "bt_mec")
        Me.bt_mec.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_mec.ForeColor = System.Drawing.Color.White
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_mec, resources.GetString("bt_mec.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_mec, CType(resources.GetObject("bt_mec.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_mec, resources.GetString("bt_mec.HelpString"))
        Me.bt_mec.Name = "bt_mec"
        Me.ProvedordAjuda.SetShowHelp(Me.bt_mec, CType(resources.GetObject("bt_mec.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.bt_mec, resources.GetString("bt_mec.ToolTip"))
        Me.bt_mec.UseVisualStyleBackColor = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProvedordAjuda.SetHelpKeyword(Me.Label1, resources.GetString("Label1.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Label1, CType(resources.GetObject("Label1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Label1, resources.GetString("Label1.HelpString"))
        Me.Label1.Name = "Label1"
        Me.ProvedordAjuda.SetShowHelp(Me.Label1, CType(resources.GetObject("Label1.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip"))
        '
        'bt_forn
        '
        resources.ApplyResources(Me.bt_forn, "bt_forn")
        Me.bt_forn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_forn.ForeColor = System.Drawing.Color.White
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_forn, resources.GetString("bt_forn.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_forn, CType(resources.GetObject("bt_forn.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_forn, resources.GetString("bt_forn.HelpString"))
        Me.bt_forn.Name = "bt_forn"
        Me.ProvedordAjuda.SetShowHelp(Me.bt_forn, CType(resources.GetObject("bt_forn.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.bt_forn, resources.GetString("bt_forn.ToolTip"))
        Me.bt_forn.UseVisualStyleBackColor = False
        '
        'ProvedordAjuda
        '
        resources.ApplyResources(Me.ProvedordAjuda, "ProvedordAjuda")
        '
        'Bt_Compra
        '
        resources.ApplyResources(Me.Bt_Compra, "Bt_Compra")
        Me.Bt_Compra.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bt_Compra.ForeColor = System.Drawing.Color.White
        Me.ProvedordAjuda.SetHelpKeyword(Me.Bt_Compra, resources.GetString("Bt_Compra.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Bt_Compra, CType(resources.GetObject("Bt_Compra.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Bt_Compra, resources.GetString("Bt_Compra.HelpString"))
        Me.Bt_Compra.Name = "Bt_Compra"
        Me.ProvedordAjuda.SetShowHelp(Me.Bt_Compra, CType(resources.GetObject("Bt_Compra.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.Bt_Compra, resources.GetString("Bt_Compra.ToolTip"))
        Me.Bt_Compra.UseVisualStyleBackColor = False
        '
        'bt_financas
        '
        resources.ApplyResources(Me.bt_financas, "bt_financas")
        Me.bt_financas.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bt_financas.ForeColor = System.Drawing.Color.Red
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_financas, resources.GetString("bt_financas.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_financas, CType(resources.GetObject("bt_financas.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_financas, resources.GetString("bt_financas.HelpString"))
        Me.bt_financas.Name = "bt_financas"
        Me.ProvedordAjuda.SetShowHelp(Me.bt_financas, CType(resources.GetObject("bt_financas.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.bt_financas, resources.GetString("bt_financas.ToolTip"))
        Me.bt_financas.UseVisualStyleBackColor = False
        '
        'BtProd
        '
        resources.ApplyResources(Me.BtProd, "BtProd")
        Me.BtProd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtProd.ForeColor = System.Drawing.Color.White
        Me.ProvedordAjuda.SetHelpKeyword(Me.BtProd, resources.GetString("BtProd.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.BtProd, CType(resources.GetObject("BtProd.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.BtProd, resources.GetString("BtProd.HelpString"))
        Me.BtProd.Name = "BtProd"
        Me.ProvedordAjuda.SetShowHelp(Me.BtProd, CType(resources.GetObject("BtProd.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.BtProd, resources.GetString("BtProd.ToolTip"))
        Me.BtProd.UseVisualStyleBackColor = False
        '
        'btVei
        '
        resources.ApplyResources(Me.btVei, "btVei")
        Me.btVei.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btVei.ForeColor = System.Drawing.Color.White
        Me.ProvedordAjuda.SetHelpKeyword(Me.btVei, resources.GetString("btVei.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.btVei, CType(resources.GetObject("btVei.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.btVei, resources.GetString("btVei.HelpString"))
        Me.btVei.Name = "btVei"
        Me.ProvedordAjuda.SetShowHelp(Me.btVei, CType(resources.GetObject("btVei.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.btVei, resources.GetString("btVei.ToolTip"))
        Me.btVei.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.btVei)
        Me.Panel1.Controls.Add(Me.BtProd)
        Me.ProvedordAjuda.SetHelpKeyword(Me.Panel1, resources.GetString("Panel1.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Panel1, CType(resources.GetObject("Panel1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Panel1, resources.GetString("Panel1.HelpString"))
        Me.Panel1.Name = "Panel1"
        Me.ProvedordAjuda.SetShowHelp(Me.Panel1, CType(resources.GetObject("Panel1.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.Panel1, resources.GetString("Panel1.ToolTip"))
        '
        'Panel2
        '
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Controls.Add(Me.Bt_usados)
        Me.Panel2.Controls.Add(Me.bt_novos)
        Me.ProvedordAjuda.SetHelpKeyword(Me.Panel2, resources.GetString("Panel2.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Panel2, CType(resources.GetObject("Panel2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Panel2, resources.GetString("Panel2.HelpString"))
        Me.Panel2.Name = "Panel2"
        Me.ProvedordAjuda.SetShowHelp(Me.Panel2, CType(resources.GetObject("Panel2.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.Panel2, resources.GetString("Panel2.ToolTip"))
        '
        'Bt_usados
        '
        resources.ApplyResources(Me.Bt_usados, "Bt_usados")
        Me.Bt_usados.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bt_usados.ForeColor = System.Drawing.Color.White
        Me.ProvedordAjuda.SetHelpKeyword(Me.Bt_usados, resources.GetString("Bt_usados.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Bt_usados, CType(resources.GetObject("Bt_usados.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Bt_usados, resources.GetString("Bt_usados.HelpString"))
        Me.Bt_usados.Name = "Bt_usados"
        Me.ProvedordAjuda.SetShowHelp(Me.Bt_usados, CType(resources.GetObject("Bt_usados.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.Bt_usados, resources.GetString("Bt_usados.ToolTip"))
        Me.Bt_usados.UseVisualStyleBackColor = False
        '
        'bt_novos
        '
        resources.ApplyResources(Me.bt_novos, "bt_novos")
        Me.bt_novos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_novos.ForeColor = System.Drawing.Color.White
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_novos, resources.GetString("bt_novos.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_novos, CType(resources.GetObject("bt_novos.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_novos, resources.GetString("bt_novos.HelpString"))
        Me.bt_novos.Name = "bt_novos"
        Me.ProvedordAjuda.SetShowHelp(Me.bt_novos, CType(resources.GetObject("bt_novos.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.bt_novos, resources.GetString("bt_novos.ToolTip"))
        Me.bt_novos.UseVisualStyleBackColor = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProvedordAjuda.SetHelpKeyword(Me.Label4, resources.GetString("Label4.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Label4, CType(resources.GetObject("Label4.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Label4, resources.GetString("Label4.HelpString"))
        Me.Label4.Name = "Label4"
        Me.ProvedordAjuda.SetShowHelp(Me.Label4, CType(resources.GetObject("Label4.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.Label4, resources.GetString("Label4.ToolTip"))
        '
        'Panel3
        '
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Controls.Add(Me.Bt_Cvei)
        Me.Panel3.Controls.Add(Me.bt_cprod)
        Me.ProvedordAjuda.SetHelpKeyword(Me.Panel3, resources.GetString("Panel3.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Panel3, CType(resources.GetObject("Panel3.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Panel3, resources.GetString("Panel3.HelpString"))
        Me.Panel3.Name = "Panel3"
        Me.ProvedordAjuda.SetShowHelp(Me.Panel3, CType(resources.GetObject("Panel3.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.Panel3, resources.GetString("Panel3.ToolTip"))
        '
        'Bt_Cvei
        '
        resources.ApplyResources(Me.Bt_Cvei, "Bt_Cvei")
        Me.Bt_Cvei.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bt_Cvei.ForeColor = System.Drawing.Color.White
        Me.ProvedordAjuda.SetHelpKeyword(Me.Bt_Cvei, resources.GetString("Bt_Cvei.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Bt_Cvei, CType(resources.GetObject("Bt_Cvei.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Bt_Cvei, resources.GetString("Bt_Cvei.HelpString"))
        Me.Bt_Cvei.Name = "Bt_Cvei"
        Me.ProvedordAjuda.SetShowHelp(Me.Bt_Cvei, CType(resources.GetObject("Bt_Cvei.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.Bt_Cvei, resources.GetString("Bt_Cvei.ToolTip"))
        Me.Bt_Cvei.UseVisualStyleBackColor = False
        '
        'bt_cprod
        '
        resources.ApplyResources(Me.bt_cprod, "bt_cprod")
        Me.bt_cprod.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_cprod.ForeColor = System.Drawing.Color.White
        Me.ProvedordAjuda.SetHelpKeyword(Me.bt_cprod, resources.GetString("bt_cprod.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.bt_cprod, CType(resources.GetObject("bt_cprod.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.bt_cprod, resources.GetString("bt_cprod.HelpString"))
        Me.bt_cprod.Name = "bt_cprod"
        Me.ProvedordAjuda.SetShowHelp(Me.bt_cprod, CType(resources.GetObject("bt_cprod.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.bt_cprod, resources.GetString("bt_cprod.ToolTip"))
        Me.bt_cprod.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Controls.Add(Me.BT_COLD)
        Me.Panel4.Controls.Add(Me.Bt_CNew)
        Me.ProvedordAjuda.SetHelpKeyword(Me.Panel4, resources.GetString("Panel4.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Panel4, CType(resources.GetObject("Panel4.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Panel4, resources.GetString("Panel4.HelpString"))
        Me.Panel4.Name = "Panel4"
        Me.ProvedordAjuda.SetShowHelp(Me.Panel4, CType(resources.GetObject("Panel4.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.Panel4, resources.GetString("Panel4.ToolTip"))
        '
        'BT_COLD
        '
        resources.ApplyResources(Me.BT_COLD, "BT_COLD")
        Me.BT_COLD.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BT_COLD.ForeColor = System.Drawing.Color.White
        Me.ProvedordAjuda.SetHelpKeyword(Me.BT_COLD, resources.GetString("BT_COLD.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.BT_COLD, CType(resources.GetObject("BT_COLD.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.BT_COLD, resources.GetString("BT_COLD.HelpString"))
        Me.BT_COLD.Name = "BT_COLD"
        Me.ProvedordAjuda.SetShowHelp(Me.BT_COLD, CType(resources.GetObject("BT_COLD.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.BT_COLD, resources.GetString("BT_COLD.ToolTip"))
        Me.BT_COLD.UseVisualStyleBackColor = False
        '
        'Bt_CNew
        '
        resources.ApplyResources(Me.Bt_CNew, "Bt_CNew")
        Me.Bt_CNew.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bt_CNew.ForeColor = System.Drawing.Color.White
        Me.ProvedordAjuda.SetHelpKeyword(Me.Bt_CNew, resources.GetString("Bt_CNew.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me.Bt_CNew, CType(resources.GetObject("Bt_CNew.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me.Bt_CNew, resources.GetString("Bt_CNew.HelpString"))
        Me.Bt_CNew.Name = "Bt_CNew"
        Me.ProvedordAjuda.SetShowHelp(Me.Bt_CNew, CType(resources.GetObject("Bt_CNew.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me.Bt_CNew, resources.GetString("Bt_CNew.ToolTip"))
        Me.Bt_CNew.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
        resources.ApplyResources(Me.MenuPrincipal, "MenuPrincipal")
        '
        'MenuItem1
        '
        resources.ApplyResources(Me.MenuItem1, "MenuItem1")
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menu_cli, Me.MenuItem17, Me.MenuItem16, Me.mnu_logoff, Me.mnu_sair})
        '
        'menu_cli
        '
        resources.ApplyResources(Me.menu_cli, "menu_cli")
        Me.menu_cli.Index = 0
        '
        'MenuItem17
        '
        resources.ApplyResources(Me.MenuItem17, "MenuItem17")
        Me.MenuItem17.Index = 1
        Me.MenuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_aluguel, Me.mnu_buy, Me.mnu_finan, Me.mnu_forn, Me.mnu_fun, Me.mnu_mec, Me.mnu_sell})
        '
        'mnu_aluguel
        '
        resources.ApplyResources(Me.mnu_aluguel, "mnu_aluguel")
        Me.mnu_aluguel.Index = 0
        '
        'mnu_buy
        '
        resources.ApplyResources(Me.mnu_buy, "mnu_buy")
        Me.mnu_buy.Index = 1
        Me.mnu_buy.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_buyProd, Me.MenuItem30})
        '
        'mnu_buyProd
        '
        resources.ApplyResources(Me.mnu_buyProd, "mnu_buyProd")
        Me.mnu_buyProd.Index = 0
        '
        'MenuItem30
        '
        resources.ApplyResources(Me.MenuItem30, "MenuItem30")
        Me.MenuItem30.Index = 1
        Me.MenuItem30.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_buy_newvei, Me.mnu_buy_oldvei})
        '
        'mnu_buy_newvei
        '
        resources.ApplyResources(Me.mnu_buy_newvei, "mnu_buy_newvei")
        Me.mnu_buy_newvei.Index = 0
        '
        'mnu_buy_oldvei
        '
        resources.ApplyResources(Me.mnu_buy_oldvei, "mnu_buy_oldvei")
        Me.mnu_buy_oldvei.Index = 1
        '
        'mnu_finan
        '
        resources.ApplyResources(Me.mnu_finan, "mnu_finan")
        Me.mnu_finan.Index = 2
        '
        'mnu_forn
        '
        resources.ApplyResources(Me.mnu_forn, "mnu_forn")
        Me.mnu_forn.Index = 3
        '
        'mnu_fun
        '
        resources.ApplyResources(Me.mnu_fun, "mnu_fun")
        Me.mnu_fun.Index = 4
        '
        'mnu_mec
        '
        resources.ApplyResources(Me.mnu_mec, "mnu_mec")
        Me.mnu_mec.Index = 5
        '
        'mnu_sell
        '
        resources.ApplyResources(Me.mnu_sell, "mnu_sell")
        Me.mnu_sell.Index = 6
        Me.mnu_sell.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_sell_prod, Me.MenuItem26})
        '
        'mnu_sell_prod
        '
        resources.ApplyResources(Me.mnu_sell_prod, "mnu_sell_prod")
        Me.mnu_sell_prod.Index = 0
        '
        'MenuItem26
        '
        resources.ApplyResources(Me.MenuItem26, "MenuItem26")
        Me.MenuItem26.Index = 1
        Me.MenuItem26.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menu_sell_newvei, Me.menu_sell_oldvei})
        '
        'menu_sell_newvei
        '
        resources.ApplyResources(Me.menu_sell_newvei, "menu_sell_newvei")
        Me.menu_sell_newvei.Index = 0
        '
        'menu_sell_oldvei
        '
        resources.ApplyResources(Me.menu_sell_oldvei, "menu_sell_oldvei")
        Me.menu_sell_oldvei.Index = 1
        '
        'MenuItem16
        '
        resources.ApplyResources(Me.MenuItem16, "MenuItem16")
        Me.MenuItem16.Index = 2
        '
        'mnu_logoff
        '
        resources.ApplyResources(Me.mnu_logoff, "mnu_logoff")
        Me.mnu_logoff.Index = 3
        '
        'mnu_sair
        '
        resources.ApplyResources(Me.mnu_sair, "mnu_sair")
        Me.mnu_sair.Index = 4
        '
        'MenuItem2
        '
        resources.ApplyResources(Me.MenuItem2, "MenuItem2")
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_systray, Me.mnu_users})
        '
        'mnu_systray
        '
        resources.ApplyResources(Me.mnu_systray, "mnu_systray")
        Me.mnu_systray.Index = 0
        '
        'mnu_users
        '
        resources.ApplyResources(Me.mnu_users, "mnu_users")
        Me.mnu_users.Index = 1
        '
        'MenuItem3
        '
        resources.ApplyResources(Me.MenuItem3, "MenuItem3")
        Me.MenuItem3.Index = 2
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem12, Me.MenuItem13, Me.MenuItem14, Me.MenuItem11})
        '
        'MenuItem6
        '
        resources.ApplyResources(Me.MenuItem6, "MenuItem6")
        Me.MenuItem6.Index = 0
        '
        'MenuItem12
        '
        resources.ApplyResources(Me.MenuItem12, "MenuItem12")
        Me.MenuItem12.Index = 1
        '
        'MenuItem13
        '
        resources.ApplyResources(Me.MenuItem13, "MenuItem13")
        Me.MenuItem13.Index = 2
        '
        'MenuItem14
        '
        resources.ApplyResources(Me.MenuItem14, "MenuItem14")
        Me.MenuItem14.Index = 3
        '
        'MenuItem11
        '
        resources.ApplyResources(Me.MenuItem11, "MenuItem11")
        Me.MenuItem11.Index = 4
        '
        'IconTray
        '
        resources.ApplyResources(Me.IconTray, "IconTray")
        Me.IconTray.ContextMenu = Me.Menuzinho
        Me.IconTray.Text = CType(configurationAppSettings.GetValue("IconTray.Text", GetType(String)), String)
        Me.IconTray.Visible = CType(configurationAppSettings.GetValue("IconTray.Visible", GetType(Boolean)), Boolean)
        '
        'Menuzinho
        '
        Me.Menuzinho.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_Abrir, Me.MenuItem8, Me.MenuItem10, Me.MenuItem4, Me.Menu_Sair})
        resources.ApplyResources(Me.Menuzinho, "Menuzinho")
        '
        'Menu_Abrir
        '
        Me.Menu_Abrir.DefaultItem = True
        resources.ApplyResources(Me.Menu_Abrir, "Menu_Abrir")
        Me.Menu_Abrir.Index = 0
        '
        'MenuItem8
        '
        resources.ApplyResources(Me.MenuItem8, "MenuItem8")
        Me.MenuItem8.Index = 1
        '
        'MenuItem10
        '
        resources.ApplyResources(Me.MenuItem10, "MenuItem10")
        Me.MenuItem10.Index = 2
        Me.MenuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_Cliente, Me.Menu_Aluguel, Me.Menu_Compra, Me.MenuForn, Me.Menu_Fun, Me.Menu_mec, Me.Menu_users, Me.Menu_vend})
        '
        'Menu_Cliente
        '
        Me.Menu_Cliente.DefaultItem = True
        resources.ApplyResources(Me.Menu_Cliente, "Menu_Cliente")
        Me.Menu_Cliente.Index = 0
        '
        'Menu_Aluguel
        '
        resources.ApplyResources(Me.Menu_Aluguel, "Menu_Aluguel")
        Me.Menu_Aluguel.Index = 1
        '
        'Menu_Compra
        '
        resources.ApplyResources(Me.Menu_Compra, "Menu_Compra")
        Me.Menu_Compra.Index = 2
        Me.Menu_Compra.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.compra_prod, Me.compra_vei})
        '
        'compra_prod
        '
        resources.ApplyResources(Me.compra_prod, "compra_prod")
        Me.compra_prod.Index = 0
        '
        'compra_vei
        '
        resources.ApplyResources(Me.compra_vei, "compra_vei")
        Me.compra_vei.Index = 1
        Me.compra_vei.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.compra_newvei, Me.compra_oldvei})
        '
        'compra_newvei
        '
        resources.ApplyResources(Me.compra_newvei, "compra_newvei")
        Me.compra_newvei.Index = 0
        '
        'compra_oldvei
        '
        resources.ApplyResources(Me.compra_oldvei, "compra_oldvei")
        Me.compra_oldvei.Index = 1
        '
        'MenuForn
        '
        resources.ApplyResources(Me.MenuForn, "MenuForn")
        Me.MenuForn.Index = 3
        '
        'Menu_Fun
        '
        resources.ApplyResources(Me.Menu_Fun, "Menu_Fun")
        Me.Menu_Fun.Index = 4
        '
        'Menu_mec
        '
        resources.ApplyResources(Me.Menu_mec, "Menu_mec")
        Me.Menu_mec.Index = 5
        '
        'Menu_users
        '
        resources.ApplyResources(Me.Menu_users, "Menu_users")
        Me.Menu_users.Index = 6
        '
        'Menu_vend
        '
        resources.ApplyResources(Me.Menu_vend, "Menu_vend")
        Me.Menu_vend.Index = 7
        Me.Menu_vend.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.venda_prod, Me.Venda_vei})
        '
        'venda_prod
        '
        resources.ApplyResources(Me.venda_prod, "venda_prod")
        Me.venda_prod.Index = 0
        '
        'Venda_vei
        '
        resources.ApplyResources(Me.Venda_vei, "Venda_vei")
        Me.Venda_vei.Index = 1
        Me.Venda_vei.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.venda_newvei, Me.venda_oldvei})
        '
        'venda_newvei
        '
        resources.ApplyResources(Me.venda_newvei, "venda_newvei")
        Me.venda_newvei.Index = 0
        '
        'venda_oldvei
        '
        resources.ApplyResources(Me.venda_oldvei, "venda_oldvei")
        Me.venda_oldvei.Index = 1
        '
        'MenuItem4
        '
        resources.ApplyResources(Me.MenuItem4, "MenuItem4")
        Me.MenuItem4.Index = 3
        '
        'Menu_Sair
        '
        resources.ApplyResources(Me.Menu_Sair, "Menu_Sair")
        Me.Menu_Sair.Index = 4
        '
        'frminicio2
        '
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.SlateGray
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
        Me.HelpButton = True
        Me.ProvedordAjuda.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        Me.ProvedordAjuda.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.ProvedordAjuda.SetHelpString(Me, resources.GetString("$this.HelpString"))
        Me.MaximizeBox = False
        Me.Menu = Me.MenuPrincipal
        Me.MinimizeBox = False
        Me.Name = "frminicio2"
        Me.ProvedordAjuda.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.FerramentaDica.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
