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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_referencia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_comp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_rua = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_telres = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_referencia)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_estado)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_cidade)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_bairro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_comp)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_rua)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_cel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_telres)
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(270, 188)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 29)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Ponto de Referência:"
        '
        'txt_referencia
        '
        Me.txt_referencia.Font = New System.Drawing.Font("Moon Flower", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_referencia.Location = New System.Drawing.Point(272, 211)
        Me.txt_referencia.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_referencia.Name = "txt_referencia"
        Me.txt_referencia.Size = New System.Drawing.Size(369, 39)
        Me.txt_referencia.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(189, 188)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 29)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Estado:"
        '
        'txt_estado
        '
        Me.txt_estado.Font = New System.Drawing.Font("Moon Flower", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_estado.Location = New System.Drawing.Point(194, 211)
        Me.txt_estado.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(72, 39)
        Me.txt_estado.TabIndex = 12
        Me.txt_estado.Text = "SP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(21, 188)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cidade:"
        '
        'txt_cidade
        '
        Me.txt_cidade.Font = New System.Drawing.Font("Moon Flower", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cidade.Location = New System.Drawing.Point(26, 211)
        Me.txt_cidade.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(162, 39)
        Me.txt_cidade.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(394, 113)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Bairro:"
        '
        'txt_bairro
        '
        Me.txt_bairro.Font = New System.Drawing.Font("Moon Flower", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bairro.Location = New System.Drawing.Point(397, 136)
        Me.txt_bairro.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(245, 39)
        Me.txt_bairro.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(297, 113)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Comp.:"
        '
        'txt_comp
        '
        Me.txt_comp.Font = New System.Drawing.Font("Moon Flower", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comp.Location = New System.Drawing.Point(302, 136)
        Me.txt_comp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_comp.Name = "txt_comp"
        Me.txt_comp.Size = New System.Drawing.Size(88, 39)
        Me.txt_comp.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(21, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Rua:"
        '
        'txt_rua
        '
        Me.txt_rua.Font = New System.Drawing.Font("Moon Flower", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rua.Location = New System.Drawing.Point(26, 136)
        Me.txt_rua.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_rua.Name = "txt_rua"
        Me.txt_rua.Size = New System.Drawing.Size(270, 39)
        Me.txt_rua.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(324, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Celular:"
        '
        'txt_cel
        '
        Me.txt_cel.Font = New System.Drawing.Font("Moon Flower", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cel.Location = New System.Drawing.Point(329, 64)
        Me.txt_cel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_cel.Name = "txt_cel"
        Me.txt_cel.Size = New System.Drawing.Size(200, 39)
        Me.txt_cel.TabIndex = 2
        Me.txt_cel.Text = "(11)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(108, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Telefone Residencial:"
        '
        'txt_telres
        '
        Me.txt_telres.Font = New System.Drawing.Font("Moon Flower", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telres.Location = New System.Drawing.Point(113, 65)
        Me.txt_telres.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_telres.Name = "txt_telres"
        Me.txt_telres.Size = New System.Drawing.Size(200, 39)
        Me.txt_telres.TabIndex = 0
        Me.txt_telres.Text = "(11)"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Coral
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(124, 370)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 39)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Limpar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(910, 494)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_seguir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_clientes"
        Me.Text = "Cliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_telres As TextBox
    Friend WithEvents Button1 As Button
End Class
