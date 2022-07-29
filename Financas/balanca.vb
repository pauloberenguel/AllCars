Public Class balanca
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
    Friend WithEvents bt_back As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(balanca))
        Me.bt_back = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.bt_back.Location = New System.Drawing.Point(272, 458)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(65, 76)
        Me.bt_back.TabIndex = 264
        Me.bt_back.Text = "Voltar"
        Me.bt_back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 440)
        Me.GroupBox1.TabIndex = 265
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ATIVO"
        '
        'GroupBox7
        '
        Me.GroupBox7.Location = New System.Drawing.Point(0, 30)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(216, 73)
        Me.GroupBox7.TabIndex = 270
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Caixa"
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(8, 111)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(216, 74)
        Me.GroupBox5.TabIndex = 269
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "M/U"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(0, 192)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(216, 92)
        Me.GroupBox4.TabIndex = 268
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Duplicatas a receber"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox8)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(232, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 440)
        Me.GroupBox2.TabIndex = 266
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PASSIVO"
        '
        'GroupBox8
        '
        Me.GroupBox8.Location = New System.Drawing.Point(8, 140)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(216, 89)
        Me.GroupBox8.TabIndex = 271
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Outras Dividas"
        '
        'GroupBox6
        '
        Me.GroupBox6.Location = New System.Drawing.Point(8, 236)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(216, 74)
        Me.GroupBox6.TabIndex = 270
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Capital"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(0, 37)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 96)
        Me.GroupBox3.TabIndex = 267
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Duplicatas a pagar"
        '
        'balanca
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(472, 552)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bt_back)
        Me.Name = "balanca"
        Me.Text = "balanca"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub bt_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_back.Click
        Me.Visible = False
        financas.Visible = True
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub balanca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
