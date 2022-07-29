Imports System.Data.OleDb
Module Module1
    Public Conexao As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" &
    "Data Source=" & "concessionaria.mdb")

    Public inicial As New frminicio
    Public users As New usuarios
    Public splashi As New splash

    Public calendario As New frmcalendario
    Public principal As New frminicio2

    Public Aluguel As New frmaluguel
    Public Efetua_alu As New efetua_aluguel
    Public devolve_alu As New devolucao_vei

    Public cadastrocli_alu As New frmcadastro

    Public cadastro_veiculos_aluguel As New cadastro_vei_alu
    Public funcionarios As New frmforn

    Public Mec As New MECANICA
    Public prod_mec As New produtos_mecanica

    Public fornecedor As New frm_fornecedores

    Public change_theme As New escolha_tema

    Public financas As New index_fin
    Public pgtos As New pagamentos
    Public receive As New recebimentos
    Public consul As New consultas
    Public balanco_pat As New balanca

    Public buy_prod As New frmcadastro_prod
    Public buy_newvei As New veiculos_venda
    Public buy_oldvei As New Cadastrar_veiculo_usado
    Public venda_produtos As New venda_prod
    Public venda_veiculo_novo As New Venda_Vei
    Public venda_veiculo_usado As New Venda_vei_usado

    Public localizar_funcionario As New Localizar_Funcionarios
    Public loccli As New Localizar_Clientes
    Public locvei As New Localizar_Veiculo
    Public locvei_venda As New Localizar_veiculo_vendas
    Public locvei_venda_usado As New Localizar_veiculo_venda_usado
    Public locprod As New Localizar_Produtos
    Public locforn As New Localizar_Fornecedores

    Public Capturar As New frmMain
    Public CamImagem As Bitmap

    Public tema As Theme
    Public tema_atual As String

    Public mecan As Boolean
    Public compras As Boolean
    Public vendas As Boolean
    Public financass As Boolean
    Public alugueis As Boolean
    Public cadastros As Boolean
    Public adm As Boolean

    Public Sub AbrirBD()
        If Conexao.State = ConnectionState.Closed Then
            Conexao.Open()
        End If
    End Sub

    Public Sub FecharBD()
        If Conexao.State = ConnectionState.Open Then
            Conexao.Close()
        End If
    End Sub

    Public Sub RefreshPrincipal()
        With principal
            If mecan = True Then
                .bt_mec.Enabled = True
                .mnu_mec.Enabled = True
                .Menu_mec.Enabled = True
            Else
                .bt_mec.Enabled = False
                .mnu_mec.Enabled = False
                .Menu_mec.Enabled = False
            End If
            If compras = True Then
                .Bt_Compra.Enabled = True
                .mnu_buy.Enabled = True
                .Menu_Compra.Enabled = True
            Else
                .Bt_Compra.Enabled = False
                .mnu_buy.Enabled = False
                .Menu_Compra.Enabled = False
            End If
            If vendas = True Then
                .bt_vendas.Enabled = True
                .mnu_sell.Enabled = True
                .Menu_vend.Enabled = True
            Else
                .mnu_sell.Enabled = False
                .bt_vendas.Enabled = False
                .Menu_vend.Enabled = False
            End If
            If financass = True Then
                .mnu_finan.Enabled = True
                .bt_financas.Enabled = True
            Else
                .mnu_finan.Enabled = False
                .bt_financas.Enabled = False
            End If
            If alugueis = True Then
                .bt_alugueis.Enabled = True
                .mnu_aluguel.Enabled = True
                .Menu_Aluguel.Enabled = True
            Else
                .bt_alugueis.Enabled = False
                .mnu_aluguel.Enabled = False
                .Menu_Aluguel.Enabled = False
            End If
            If cadastros = True Then
                .bt_forn.Enabled = True
                .bt_func.Enabled = True
                .menu_cli.Enabled = True
                .mnu_forn.Enabled = True
                .mnu_fun.Enabled = True
                .Menu_Cliente.Enabled = True
                .MenuForn.Enabled = True
                .Menu_Fun.Enabled = True
            Else
                .bt_forn.Enabled = False
                .bt_func.Enabled = False
                .menu_cli.Enabled = False
                .mnu_forn.Enabled = False
                .mnu_fun.Enabled = False
                .Menu_Cliente.Enabled = False
                .MenuForn.Enabled = False
                .Menu_Fun.Enabled = False
            End If
            If adm = True Then
                .mnu_users.Enabled = True
                .Menu_users.Enabled = True
            Else
                .mnu_users.Enabled = False
                .Menu_users.Enabled = False
            End If
            .IconTray.Visible = False
        End With
    End Sub



End Module
