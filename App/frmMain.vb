Option Explicit On 
Option Strict On

Public Class frmMain
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
    Friend WithEvents picOutput As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuStartCam As System.Windows.Forms.MenuItem
    Friend WithEvents mnuStopCam As System.Windows.Forms.MenuItem
    Friend WithEvents mnuResetCam As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSetFrame As System.Windows.Forms.MenuItem
    Friend WithEvents topMenu As System.Windows.Forms.MainMenu
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents sBar As System.Windows.Forms.Label
    Friend WithEvents cmdViewStill As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.picOutput = New System.Windows.Forms.PictureBox
        Me.topMenu = New System.Windows.Forms.MainMenu
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuExit = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.mnuStartCam = New System.Windows.Forms.MenuItem
        Me.mnuStopCam = New System.Windows.Forms.MenuItem
        Me.mnuResetCam = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.mnuSetFrame = New System.Windows.Forms.MenuItem
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.sBar = New System.Windows.Forms.Label
        Me.cmdViewStill = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'picOutput
        '
        Me.picOutput.BackColor = System.Drawing.Color.Black
        Me.picOutput.Location = New System.Drawing.Point(8, 8)
        Me.picOutput.Name = "picOutput"
        Me.picOutput.Size = New System.Drawing.Size(344, 240)
        Me.picOutput.TabIndex = 0
        Me.picOutput.TabStop = False
        '
        'topMenu
        '
        Me.topMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.MenuItem2, Me.MenuItem6})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuExit})
        Me.mnuFile.Text = "Arquivo"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 0
        Me.mnuExit.Text = "Sair"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuStartCam, Me.mnuStopCam, Me.mnuResetCam})
        Me.MenuItem2.Text = "Câmera"
        '
        'mnuStartCam
        '
        Me.mnuStartCam.Index = 0
        Me.mnuStartCam.Text = "Iniciar Camera"
        '
        'mnuStopCam
        '
        Me.mnuStopCam.Index = 1
        Me.mnuStopCam.Text = "Parar Camera"
        '
        'mnuResetCam
        '
        Me.mnuResetCam.Index = 2
        Me.mnuResetCam.Text = "Reiniciar Camera"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSetFrame})
        Me.MenuItem6.Text = "Opções"
        '
        'mnuSetFrame
        '
        Me.mnuSetFrame.Index = 0
        Me.mnuSetFrame.Text = "Definir Taxa de Quadros"
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 500
        '
        'sBar
        '
        Me.sBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sBar.ForeColor = System.Drawing.Color.Beige
        Me.sBar.Location = New System.Drawing.Point(8, 280)
        Me.sBar.Name = "sBar"
        Me.sBar.Size = New System.Drawing.Size(344, 24)
        Me.sBar.TabIndex = 1
        Me.sBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdViewStill
        '
        Me.cmdViewStill.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewStill.ForeColor = System.Drawing.Color.Beige
        Me.cmdViewStill.Location = New System.Drawing.Point(8, 248)
        Me.cmdViewStill.Name = "cmdViewStill"
        Me.cmdViewStill.Size = New System.Drawing.Size(344, 24)
        Me.cmdViewStill.TabIndex = 2
        Me.cmdViewStill.Text = "Tirar foto"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(8, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(344, 24)
        Me.Label10.TabIndex = 60
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(360, 304)
        Me.ControlBox = False
        Me.Controls.Add(Me.sBar)
        Me.Controls.Add(Me.cmdViewStill)
        Me.Controls.Add(Me.picOutput)
        Me.Controls.Add(Me.Label10)
        Me.Menu = Me.topMenu
        Me.Name = "frmMain"
        Me.Text = "Visualizador de WebCam"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private myCam As iCam


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.picOutput.SizeMode = PictureBoxSizeMode.StretchImage
        myCam = New iCam
    End Sub

#Region "Menu items"

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        myCam.closeCam()
        Me.Visible = False
    End Sub

    Private Sub mnuStartCam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStartCam.Click
        myCam.initCam(Me.picOutput.Handle.ToInt32)
    End Sub

    Private Sub mnuStopCam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStopCam.Click
        myCam.closeCam()
    End Sub

    Private Sub mnuResetCam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuResetCam.Click
        myCam.resetCam()
    End Sub

    Private Sub mnuSetFrame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetFrame.Click
        Dim myFrames As String
        Try
            myFrames = InputBox("Insira um valor para quadros por segundo (FPS)", "Setar FPS")

            myCam.setFrameRate(CInt(myFrames))
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


#End Region

    Private Sub tmrUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdate.Tick
        Try
            Dim XXX As String
            If myCam.iRunning = False Then
                XXX = "Desligada"
            Else
                XXX = "Ligada"
            End If
            With sBar
                .Text = ("Atual FPS = " & myCam.FPS & "   " & _
                "Camera = " & XXX)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdViewStill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewStill.Click
        If myCam.iRunning Then

            CamImagem = New Bitmap(myCam.copyFrame(Me.picOutput, New RectangleF(0, 0, Me.picOutput.Width, Me.picOutput.Height)))

            If buy_oldvei.Visible = True Or buy_oldvei.WindowState = FormWindowState.Minimized Then
                buy_oldvei.Pctemp.Show()
                buy_oldvei.Pctemp.Image = CamImagem
            End If

            If cadastro_veiculos_aluguel.Visible = True Or cadastro_veiculos_aluguel.WindowState = FormWindowState.Minimized Then
                cadastro_veiculos_aluguel.Pctemp.Show()
                cadastro_veiculos_aluguel.Pctemp.Image = CamImagem
            End If

            If buy_newvei.Visible = True Or buy_newvei.WindowState = FormWindowState.Minimized Then
                buy_newvei.Pctemp.Show()
                buy_newvei.Pctemp.Image = CamImagem
            End If

        Else
            MessageBox.Show("Câmera não está ligada!")

        End If
        Me.Visible = False

    End Sub
End Class