<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_clientes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_clientes))
        Me.btn_seguir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_comp = New System.Windows.Forms.TextBox()
        Me.txt_referencia = New System.Windows.Forms.TextBox()
        Me.txt_rua = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_telres = New System.Windows.Forms.TextBox()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EncerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_limp = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_seguir
        '
        Me.btn_seguir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_seguir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_seguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_seguir.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_seguir.ForeColor = System.Drawing.Color.Coral
        Me.btn_seguir.Image = CType(resources.GetObject("btn_seguir.Image"), System.Drawing.Image)
        Me.btn_seguir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_seguir.Location = New System.Drawing.Point(685, 370)
        Me.btn_seguir.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_seguir.Name = "btn_seguir"
        Me.btn_seguir.Size = New System.Drawing.Size(101, 39)
        Me.btn_seguir.TabIndex = 18
        Me.btn_seguir.Text = "Seguir"
        Me.btn_seguir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_seguir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_nome)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_cidade)
        Me.GroupBox1.Controls.Add(Me.txt_numero)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_bairro)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_comp)
        Me.GroupBox1.Controls.Add(Me.txt_referencia)
        Me.GroupBox1.Controls.Add(Me.txt_rua)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_telres)
        Me.GroupBox1.Controls.Add(Me.txt_estado)
        Me.GroupBox1.Font = New System.Drawing.Font("Moon Flower Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Tomato
        Me.GroupBox1.Location = New System.Drawing.Point(124, 86)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(662, 278)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Cadastrais"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 184)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 34)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cidade:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(318, 114)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 34)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Comp.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(410, 114)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 34)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Bairro:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(228, 40)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 34)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Nome:"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Moon Flower Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(228, 72)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(411, 39)
        Me.txt_nome.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(235, 114)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 34)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Número:"
        '
        'txt_cidade
        '
        Me.txt_cidade.Font = New System.Drawing.Font("Moon Flower Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cidade.Location = New System.Drawing.Point(24, 215)
        Me.txt_cidade.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(168, 39)
        Me.txt_cidade.TabIndex = 10
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Moon Flower Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(236, 142)
        Me.txt_numero.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(84, 39)
        Me.txt_numero.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(266, 184)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 34)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Ponto de Referência:"
        '
        'txt_bairro
        '
        Me.txt_bairro.Font = New System.Drawing.Font("Moon Flower Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bairro.Location = New System.Drawing.Point(416, 142)
        Me.txt_bairro.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(223, 39)
        Me.txt_bairro.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 34)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Rua:"
        '
        'txt_comp
        '
        Me.txt_comp.Font = New System.Drawing.Font("Moon Flower Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comp.Location = New System.Drawing.Point(324, 142)
        Me.txt_comp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_comp.Name = "txt_comp"
        Me.txt_comp.Size = New System.Drawing.Size(88, 39)
        Me.txt_comp.TabIndex = 6
        '
        'txt_referencia
        '
        Me.txt_referencia.Font = New System.Drawing.Font("Moon Flower Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_referencia.Location = New System.Drawing.Point(270, 215)
        Me.txt_referencia.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_referencia.Name = "txt_referencia"
        Me.txt_referencia.Size = New System.Drawing.Size(369, 39)
        Me.txt_referencia.TabIndex = 14
        '
        'txt_rua
        '
        Me.txt_rua.Font = New System.Drawing.Font("Moon Flower Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rua.Location = New System.Drawing.Point(26, 142)
        Me.txt_rua.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_rua.Name = "txt_rua"
        Me.txt_rua.Size = New System.Drawing.Size(206, 39)
        Me.txt_rua.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(184, 184)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 34)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Estado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Telefone:"
        '
        'txt_telres
        '
        Me.txt_telres.Font = New System.Drawing.Font("Moon Flower Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telres.Location = New System.Drawing.Point(24, 72)
        Me.txt_telres.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_telres.Name = "txt_telres"
        Me.txt_telres.Size = New System.Drawing.Size(200, 39)
        Me.txt_telres.TabIndex = 0
        Me.txt_telres.Text = "(11)"
        '
        'txt_estado
        '
        Me.txt_estado.Font = New System.Drawing.Font("Moon Flower Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_estado.Location = New System.Drawing.Point(196, 215)
        Me.txt_estado.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(72, 39)
        Me.txt_estado.TabIndex = 12
        Me.txt_estado.Text = "SP"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(910, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EncerrarToolStripMenuItem
        '
        Me.EncerrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncerrarSessãoToolStripMenuItem, Me.EncerrarSistemaToolStripMenuItem})
        Me.EncerrarToolStripMenuItem.Name = "EncerrarToolStripMenuItem"
        Me.EncerrarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.EncerrarToolStripMenuItem.Text = "Encerrar"
        '
        'EncerrarSessãoToolStripMenuItem
        '
        Me.EncerrarSessãoToolStripMenuItem.Image = CType(resources.GetObject("EncerrarSessãoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EncerrarSessãoToolStripMenuItem.Name = "EncerrarSessãoToolStripMenuItem"
        Me.EncerrarSessãoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.EncerrarSessãoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EncerrarSessãoToolStripMenuItem.Text = "Encerrar Sessão"
        '
        'EncerrarSistemaToolStripMenuItem
        '
        Me.EncerrarSistemaToolStripMenuItem.Image = CType(resources.GetObject("EncerrarSistemaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EncerrarSistemaToolStripMenuItem.Name = "EncerrarSistemaToolStripMenuItem"
        Me.EncerrarSistemaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.EncerrarSistemaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EncerrarSistemaToolStripMenuItem.Text = "Encerrar Sistema"
        '
        'btn_limp
        '
        Me.btn_limp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_limp.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_limp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limp.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limp.ForeColor = System.Drawing.Color.Coral
        Me.btn_limp.Image = CType(resources.GetObject("btn_limp.Image"), System.Drawing.Image)
        Me.btn_limp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limp.Location = New System.Drawing.Point(124, 370)
        Me.btn_limp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_limp.Name = "btn_limp"
        Me.btn_limp.Size = New System.Drawing.Size(102, 39)
        Me.btn_limp.TabIndex = 21
        Me.btn_limp.Text = "Limpar"
        Me.btn_limp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limp.UseVisualStyleBackColor = True
        '
        'frm_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(910, 494)
        Me.Controls.Add(Me.btn_limp)
        Me.Controls.Add(Me.btn_seguir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frm_clientes"
        Me.Text = "Cliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_seguir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_referencia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_estado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_comp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_rua As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_telres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EncerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_limp As Button
End Class
