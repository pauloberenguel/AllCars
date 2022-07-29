Imports System.Drawing.Drawing2D
Imports System.Data.OleDb
Imports System.DateTime

Public Class frminicio
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cb_salv As System.Windows.Forms.CheckBox
    Friend WithEvents bt_sair As System.Windows.Forms.Button
    Friend WithEvents bt_ok As System.Windows.Forms.Button
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label_forgotten As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rc_text As System.Windows.Forms.RichTextBox
    Friend WithEvents bt_closelemb As System.Windows.Forms.Button
    Friend WithEvents Panel As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frminicio))
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_user = New System.Windows.Forms.TextBox
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.bt_ok = New System.Windows.Forms.Button
        Me.bt_sair = New System.Windows.Forms.Button
        Me.cb_salv = New System.Windows.Forms.CheckBox
        Me.Label_forgotten = New System.Windows.Forms.Label
        Me.Panel = New System.Windows.Forms.Panel
        Me.rc_text = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.bt_closelemb = New System.Windows.Forms.Button
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(416, 433)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 52)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "LOGIN"
        '
        'txt_user
        '
        Me.txt_user.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(416, 61)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(136, 31)
        Me.txt_user.TabIndex = 2
        Me.txt_user.Text = ""
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(416, 130)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Microsoft.VisualBasic.ChrW(65290)
        Me.txt_pass.Size = New System.Drawing.Size(136, 31)
        Me.txt_pass.TabIndex = 3
        Me.txt_pass.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Niagara Engraved", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(376, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Senha"
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Niagara Engraved", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(376, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Login"
        '
        'bt_ok
        '
        Me.bt_ok.BackColor = System.Drawing.Color.Black
        Me.bt_ok.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.bt_ok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_ok.Location = New System.Drawing.Point(544, 165)
        Me.bt_ok.Name = "bt_ok"
        Me.bt_ok.Size = New System.Drawing.Size(40, 34)
        Me.bt_ok.TabIndex = 8
        Me.bt_ok.Text = "OK"
        Me.bt_ok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bt_sair
        '
        Me.bt_sair.BackColor = System.Drawing.Color.DimGray
        Me.bt_sair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_sair.Font = New System.Drawing.Font("Kristen ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_sair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_sair.Location = New System.Drawing.Point(568, 43)
        Me.bt_sair.Name = "bt_sair"
        Me.bt_sair.Size = New System.Drawing.Size(32, 26)
        Me.bt_sair.TabIndex = 9
        Me.bt_sair.Text = "X"
        '
        'cb_salv
        '
        Me.cb_salv.BackColor = System.Drawing.Color.Transparent
        Me.cb_salv.Cursor = System.Windows.Forms.Cursors.No
        Me.cb_salv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_salv.Font = New System.Drawing.Font("Niagara Solid", 14.25!)
        Me.cb_salv.Location = New System.Drawing.Point(400, 95)
        Me.cb_salv.Name = "cb_salv"
        Me.cb_salv.Size = New System.Drawing.Size(160, 26)
        Me.cb_salv.TabIndex = 10
        Me.cb_salv.Text = "Salvar meu nome de usuário"
        '
        'Label_forgotten
        '
        Me.Label_forgotten.BackColor = System.Drawing.Color.Transparent
        Me.Label_forgotten.Font = New System.Drawing.Font("Niagara Solid", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_forgotten.ForeColor = System.Drawing.Color.Navy
        Me.Label_forgotten.Location = New System.Drawing.Point(416, 165)
        Me.Label_forgotten.Name = "Label_forgotten"
        Me.Label_forgotten.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_forgotten.Size = New System.Drawing.Size(104, 25)
        Me.Label_forgotten.TabIndex = 11
        Me.Label_forgotten.Text = "Esqueceu sua senha?"
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.Transparent
        Me.Panel.Controls.Add(Me.rc_text)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Controls.Add(Me.bt_closelemb)
        Me.Panel.Location = New System.Drawing.Point(16, 251)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(240, 156)
        Me.Panel.TabIndex = 12
        Me.Panel.Visible = False
        '
        'rc_text
        '
        Me.rc_text.BackColor = System.Drawing.Color.Silver
        Me.rc_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rc_text.Cursor = System.Windows.Forms.Cursors.No
        Me.rc_text.Font = New System.Drawing.Font("Niagara Engraved", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rc_text.Location = New System.Drawing.Point(32, 43)
        Me.rc_text.Name = "rc_text"
        Me.rc_text.ReadOnly = True
        Me.rc_text.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rc_text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rc_text.Size = New System.Drawing.Size(184, 87)
        Me.rc_text.TabIndex = 1
        Me.rc_text.Text = "" & Microsoft.VisualBasic.ChrW(10) & "        D i g i t e   s e u   l o g i n"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Niagara Engraved", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(120, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lembrete de Senha"
        '
        'bt_closelemb
        '
        Me.bt_closelemb.BackColor = System.Drawing.Color.DimGray
        Me.bt_closelemb.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_closelemb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_closelemb.Font = New System.Drawing.Font("Kristen ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_closelemb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_closelemb.Location = New System.Drawing.Point(8, 9)
        Me.bt_closelemb.Name = "bt_closelemb"
        Me.bt_closelemb.Size = New System.Drawing.Size(32, 26)
        Me.bt_closelemb.TabIndex = 13
        Me.bt_closelemb.Text = "X"
        '
        'frminicio
        '
        Me.AcceptButton = Me.bt_ok
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.bt_sair
        Me.ClientSize = New System.Drawing.Size(600, 541)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.Label_forgotten)
        Me.Controls.Add(Me.cb_salv)
        Me.Controls.Add(Me.bt_sair)
        Me.Controls.Add(Me.bt_ok)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frminicio"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "||Login||"
        Me.Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Forminhas ^^"

    Private Sub frminicio_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim forma As New GraphicsPath
        forma.AddPie(0, 0, 775, 555, 0, -358)
        Me.Region = New System.Drawing.Region(forma)



    End Sub



    Private Sub frminicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        comando = New OleDbCommand("UPDATE usuarios set allowed=@true where dia_aux >=" & System.DateTime.Today.AddDays(1).ToOADate, Conexao)

        comando.Parameters.Add(New OleDbParameter("@true", OleDbType.Boolean))
        comando.Parameters("@true").Value = True
        AbrirBD()
        Try
            comando.ExecuteNonQuery()
            comando = New OleDbCommand("select username from ultimouser", Conexao)
            dr = comando.ExecuteReader
            If dr.Read Then
                txt_user.Text = dr("username")
            End If
            dr.Close()
            cb_salv.Checked = True
            FecharBD()
        Catch ex As Exception
            MessageBox.Show("Erro", "Erro", MessageBoxButtons.OK)
        Finally
            FecharBD()
        End Try

        Dim bolinha As New GraphicsPath
        bolinha.AddPie(0, 0, 30, 30, 0, 360)
        bt_ok.Region = New System.Drawing.Region(bolinha)
        bt_closelemb.Region = New System.Drawing.Region(bolinha)
        bt_sair.Region = New System.Drawing.Region(bolinha)

        Try
            bt_closelemb.Cursor = New Cursor("..\l_yuki01.cur")
            cb_salv.Cursor = New Cursor("..\l_yuki01.cur")
            Label_forgotten.Cursor = New Cursor("..\l_yuki01.cur")
            bt_sair.Cursor = New Cursor("..\large3.cur")
            bt_ok.Cursor = New Cursor("..\l_yuki01.cur")
        Catch ex As Exception
            bt_closelemb.Cursor = Cursors.Hand
            Label_forgotten.Cursor = Cursors.Hand
            cb_salv.Cursor = Cursors.Hand
            bt_sair.Cursor = Cursors.Hand
            bt_ok.Cursor = Cursors.Hand
        End Try
    End Sub



#End Region

#Region "Publics"
    Public count As Integer
    Public jaera As Boolean = False
    Public allow As Boolean
#End Region

#Region "Verificacao....."

    Private Sub Label_forgotten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_forgotten.Click
        Panel.Visible = True
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader
        comando = New OleDbCommand("select * from usuarios where username='" & txt_user.Text & "'", Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            If dr.Read Then
                rc_text.Text = dr("pass_help")
            End If
            dr.Close()

        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub bt_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ok.Click
        Dim comando As OleDbCommand
        Dim data As OleDbDataReader
        Dim pass As String
        Dim verificacao_time As Date
        Dim mec_temp As Boolean
        Dim compras_temp As Boolean
        Dim vendas_temp As Boolean
        Dim financas_temp As Boolean
        Dim alugueis_temp As Boolean
        Dim cadastros_temp As Boolean
        Dim adm_temp As Boolean

        comando = New OleDbCommand("select * from usuarios where username='" & txt_user.Text & "'", Conexao)
        Try
            AbrirBD()
            data = comando.ExecuteReader
            If data.Read Then
                pass = data("passwordd")
                verificacao_time = data("time_again")
                allow = data("allowed")
                mec_temp = data("mecanica")
                compras_temp = data("compras")
                vendas_temp = data("vendas")
                financas_temp = data("financas")
                alugueis_temp = data("alugueis")
                cadastros_temp = data("cadastros")
                adm_temp = data("adm")
            End If
        Catch ex As Exception
            MsgBox("Verifique campos digitados", MsgBoxStyle.OKOnly, "Campos")
        Finally
            FecharBD()
        End Try

        If allow = False Then
            If System.DateTime.Compare(verificacao_time, System.DateTime.Now.ToShortTimeString) < 0 Then
                allow = True
                Dim comando2 As OleDbCommand
                comando2 = New OleDbCommand("Update usuarios set allowed=@allowed where username=@username", Conexao)
                comando2.Parameters.Add(New OleDbParameter("@allowed", OleDbType.Boolean, 50))
                comando2.Parameters("@allowed").Value = allow
                comando2.Parameters.Add(New OleDbParameter("@username", OleDbType.VarChar, 50))
                comando2.Parameters("@username").Value = txt_user.Text
                AbrirBD()
                comando2.ExecuteNonQuery()
                FecharBD()
            Else
                MsgBox("Tente novamente mais tarde.....", MsgBoxStyle.OKOnly, "Aguarde")
                FecharBD()
                Exit Sub
            End If
        End If

        If jaera = False Then
            If (txt_pass.Text.ToString = pass) Then

                If cb_salv.Checked = True Then
                    comando = New OleDbCommand("update ultimouser set username='" & txt_user.Text & "' where cod='" & 1 & "'", Conexao)
                    AbrirBD()
                    comando.ExecuteNonQuery()
                    FecharBD()
                ElseIf cb_salv.Checked = False Then
                    comando = New OleDbCommand("update ultimouser set username='' where cod='" & 1 & "'", Conexao)
                    AbrirBD()
                    comando.ExecuteNonQuery()
                    FecharBD()
                    txt_user.Text = ""
                End If
                mecan = mec_temp
                compras = compras_temp
                vendas = vendas_temp
                financass = financas_temp
                alugueis = alugueis_temp
                cadastros = cadastros_temp
                adm = adm_temp
                txt_pass.Text = ""
                count = 1
                RefreshPrincipal()
                splashi.Visible = True
                Me.Visible = False
            Else
                count = count + 1
                MsgBox("Password errado | Erros:  " & count & " | Tentativas restantes:  " & Val(5 - count))
            End If
        End If

        If count = 5 Then
            jaera = True
            Dim comando2 As OleDbCommand
            allow = False
            comando2 = New OleDbCommand("Update usuarios set time_again=@tempo,allowed=@allowed,dia_aux=@day where username=@username", Conexao)
            comando2.Parameters.Add(New OleDbParameter("@tempo", OleDbType.VarChar, 50))
            comando2.Parameters("@tempo").Value = System.DateTime.Now.AddMinutes(10).ToShortTimeString
            comando2.Parameters.Add(New OleDbParameter("@day", OleDbType.DBDate))
            comando2.Parameters("@day").Value = System.DateTime.Today.ToShortDateString
            comando2.Parameters.Add(New OleDbParameter("@allowed", OleDbType.Boolean, 50))
            comando2.Parameters("@allowed").Value = allow
            comando2.Parameters.Add(New OleDbParameter("@username", OleDbType.VarChar, 50))
            comando2.Parameters("@username").Value = txt_user.Text
            MsgBox("Números excedentes de erros permitidos, aguarde 10 minutos", MsgBoxStyle.OKOnly, "Aguarde")
            AbrirBD()
            comando2.ExecuteNonQuery()
        End If

        FecharBD()

        If (count > 5) And allow = False Then
            MsgBox("Aguarde..............", MsgBoxStyle.OKOnly, "Aguarde")
        End If

    End Sub

#End Region

    Private Sub bt_closelemb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_closelemb.Click
        Panel.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_sair.Click
        Me.Close()
        Application.Exit()
    End Sub

End Class
