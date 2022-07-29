Imports System.Data.OleDb

Public Class splash
    Inherits System.Windows.Forms.Form
    Friend sbcButton, sbcProgressBar As StatusBarChild

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
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(splash))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(72, 152)
        Me.ProgressBar1.Maximum = 1000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.Visible = False
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 191)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(480, 25)
        Me.StatusBar1.TabIndex = 2
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.MinWidth = 60
        Me.StatusBarPanel1.Text = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 232
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel2.MinWidth = 100
        Me.StatusBarPanel2.Text = "StatusBarPanel2"
        Me.StatusBarPanel2.Width = 232
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 72)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bemvindo a AllCars System"
        '
        'Timer1
        '
        '
        'splash
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(4, 11)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(480, 216)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "splash"
        Me.Opacity = 0.95
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash"
        Me.TopMost = True
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Not sbcProgressBar Is Nothing Then
            sbcProgressBar.Resize()
        End If
    End Sub

    Private Sub splash_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        sbcProgressBar = New StatusBarChild(ProgressBar1, StatusBar1, 1)
        If (Timer1.Enabled) Then
            Timer1.Stop()
        Else
            startTime = DateTime.Now()
            Timer1.Start()
        End If
        Dim atuparcela As Integer
        Dim data As Date
        Dim listinha As New ListView
        Dim listahelp As New ListViewItem
        Dim comando As OleDbCommand
        Dim dr As OleDbDataReader

        comando = New OleDbCommand("select * from recebimentos where situacao_parcelamento='Pagando' ", Conexao)
        AbrirBD()
        Try
            dr = comando.ExecuteReader
            While dr.Read
                data = dr("data_recebimento")

                If data.Date.Day.ToString = Today.Date.Day.ToString Or data.Date.Day.ToString = Today.Date.AddDays(-1).ToString Or data.Date.Day.ToString = Today.Date.AddDays(-2).ToString Or data.Date.Day.ToString = Today.Date.AddDays(-3).ToString Or data.Date.Day.ToString = Today.Date.AddDays(-4).ToString Or data.Date.Day.ToString = Today.Date.AddDays(-5).ToString Then
                    listahelp.Text = dr("cod_recebimento")
                    atuparcela = Val(dr("parcelas_pagas") + 1)
                    If atuparcela = dr("parcelas") Then
                        listahelp.SubItems.Add(atuparcela)
                        listahelp.SubItems.Add("Pago")
                    Else
                        listahelp.SubItems.Add(atuparcela)
                        listahelp.SubItems.Add("Pagando")
                    End If
                End If
                listinha.Items.Add(listahelp)
            End While
            dr.Close()
            For atuparcela = 0 To listinha.Items.Count - 1
                comando = New OleDbCommand("update recebimentos set situacao_parcelamento=@situ,parcelas_pagas=@pp where cod_recebimento=@codrece", Conexao)
                comando.Parameters.Add(New OleDbParameter("@situ", OleDbType.VarChar, 50))
                comando.Parameters("@situ").Value = listinha.Items.Item(atuparcela).SubItems(2).Text
                comando.Parameters.Add(New OleDbParameter("@pp", OleDbType.VarChar, 50))
                comando.Parameters("@pp").Value = listinha.Items.Item(atuparcela).SubItems(1).Text
                comando.Parameters.Add(New OleDbParameter("@codrece", OleDbType.VarChar, 50))
                comando.Parameters("@codrece").Value = listinha.Items.Item(atuparcela).Text
                Try
                    comando.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("erro...1!")
                End Try
            Next
        Catch ex As Exception
            MsgBox("erro...!")
        Finally
            FecharBD()
        End Try


    End Sub

    Public Timer As New Timer
    Public Property Interval() As Integer
        Get
            Return timer.Interval
        End Get
        Set(ByVal Value As Integer)
            timer.Interval = Value
        End Set
    End Property


    Dim startTime As DateTime

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim span As TimeSpan = DateTime.Now.Subtract(startTime)
        Me.Text = "Welcome to AllCars System"
        If span.Seconds = 0 Then
            Dim i As Long
            For i = 1 To 100
                ProgressBar1.Step = 1
                ProgressBar1.PerformStep()
                StatusBar1.Panels.Item(0).Text = "Atualizando dados....."
            Next
        End If

        If span.Seconds = 4 Then
            Dim i As Long
            For i = 1 To 700
                ProgressBar1.PerformStep()
                StatusBar1.Panels.Item(0).Text = "Carregado!"
            Next
        End If
        If span.Seconds = 5 Then
            Timer1.Stop()
            Me.Visible = False
            principal.Visible = True
        End If
    End Sub
End Class
