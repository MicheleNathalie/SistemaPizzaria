<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.gb_login = New System.Windows.Forms.GroupBox()
        Me.txtcpf = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.gb_login.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_login
        '
        Me.gb_login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gb_login.BackColor = System.Drawing.Color.White
        Me.gb_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gb_login.Controls.Add(Me.txtcpf)
        Me.gb_login.Controls.Add(Me.PictureBox1)
        Me.gb_login.Controls.Add(Me.Label2)
        Me.gb_login.Controls.Add(Me.Label1)
        Me.gb_login.Controls.Add(Me.txt_senha)
        Me.gb_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gb_login.Font = New System.Drawing.Font("Moon Flower Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_login.ForeColor = System.Drawing.Color.Tomato
        Me.gb_login.Location = New System.Drawing.Point(226, 86)
        Me.gb_login.Name = "gb_login"
        Me.gb_login.Size = New System.Drawing.Size(351, 239)
        Me.gb_login.TabIndex = 0
        Me.gb_login.TabStop = False
        Me.gb_login.Text = "Login"
        '
        'txtcpf
        '
        Me.txtcpf.Font = New System.Drawing.Font("Moon Flower Bold", 20.25!)
        Me.txtcpf.Location = New System.Drawing.Point(167, 76)
        Me.txtcpf.Mask = "999,999,999-99"
        Me.txtcpf.Name = "txtcpf"
        Me.txtcpf.Size = New System.Drawing.Size(165, 39)
        Me.txtcpf.TabIndex = 0
        Me.txtcpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Moon Flower Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(161, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Senha: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Moon Flower Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(161, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CPF: "
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Moon Flower Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.ForeColor = System.Drawing.Color.Black
        Me.txt_senha.Location = New System.Drawing.Point(167, 165)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(165, 39)
        Me.txt_senha.TabIndex = 1
        Me.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'btn_entrar
        '
        Me.btn_entrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_entrar.BackColor = System.Drawing.Color.SeaShell
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_entrar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_entrar.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.Color.Tomato
        Me.btn_entrar.Image = CType(resources.GetObject("btn_entrar.Image"), System.Drawing.Image)
        Me.btn_entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_entrar.Location = New System.Drawing.Point(472, 331)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(105, 42)
        Me.btn_entrar.TabIndex = 2
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_entrar.UseVisualStyleBackColor = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(796, 458)
        Me.Controls.Add(Me.gb_login)
        Me.Controls.Add(Me.btn_entrar)
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gb_login.ResumeLayout(False)
        Me.gb_login.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_login As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_entrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtcpf As MaskedTextBox
End Class
