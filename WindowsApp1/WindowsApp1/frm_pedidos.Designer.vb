<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pedidos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_entrega = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tamanho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sabor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_entrega = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_tamanho = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clb_sabores = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_quantidade = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cb_entrega)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_valor)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txt_entrega)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_tamanho)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.clb_sabores)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_quantidade)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Tomato
        Me.GroupBox1.Location = New System.Drawing.Point(36, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 428)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cb_entrega
        '
        Me.cb_entrega.AutoSize = True
        Me.cb_entrega.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_entrega.Location = New System.Drawing.Point(18, 254)
        Me.cb_entrega.Name = "cb_entrega"
        Me.cb_entrega.Size = New System.Drawing.Size(128, 35)
        Me.cb_entrega.TabIndex = 6
        Me.cb_entrega.Text = "Entrega"
        Me.cb_entrega.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGray
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.SandyBrown
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(348, 380)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 39)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "OK"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(601, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 39)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Confirmar Pedido"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(417, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 31)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Valor Total:"
        '
        'txt_valor
        '
        Me.txt_valor.Location = New System.Drawing.Point(441, 379)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(106, 38)
        Me.txt_valor.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num, Me.Quantidade, Me.Tamanho, Me.Sabor, Me.Valor, Me.Excluir})
        Me.DataGridView1.Location = New System.Drawing.Point(405, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(401, 290)
        Me.DataGridView1.TabIndex = 8
        '
        'num
        '
        Me.num.Frozen = True
        Me.num.HeaderText = "-"
        Me.num.Name = "num"
        Me.num.ReadOnly = True
        '
        'Quantidade
        '
        Me.Quantidade.Frozen = True
        Me.Quantidade.HeaderText = "Quantidade"
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.ReadOnly = True
        '
        'Tamanho
        '
        Me.Tamanho.Frozen = True
        Me.Tamanho.HeaderText = "Tamanho"
        Me.Tamanho.Name = "Tamanho"
        Me.Tamanho.ReadOnly = True
        '
        'Sabor
        '
        Me.Sabor.Frozen = True
        Me.Sabor.HeaderText = "Sabor"
        Me.Sabor.Name = "Sabor"
        Me.Sabor.ReadOnly = True
        '
        'Valor
        '
        Me.Valor.Frozen = True
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        '
        'Excluir
        '
        Me.Excluir.Frozen = True
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.Name = "Excluir"
        Me.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'txt_entrega
        '
        Me.txt_entrega.Location = New System.Drawing.Point(25, 279)
        Me.txt_entrega.Name = "txt_entrega"
        Me.txt_entrega.Size = New System.Drawing.Size(149, 38)
        Me.txt_entrega.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tamanho:"
        '
        'cmb_tamanho
        '
        Me.cmb_tamanho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_tamanho.FormattingEnabled = True
        Me.cmb_tamanho.Location = New System.Drawing.Point(25, 198)
        Me.cmb_tamanho.Name = "cmb_tamanho"
        Me.cmb_tamanho.Size = New System.Drawing.Size(149, 39)
        Me.cmb_tamanho.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sabores:"
        '
        'clb_sabores
        '
        Me.clb_sabores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clb_sabores.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_sabores.FormattingEnabled = True
        Me.clb_sabores.Location = New System.Drawing.Point(191, 63)
        Me.clb_sabores.Name = "clb_sabores"
        Me.clb_sabores.Size = New System.Drawing.Size(196, 342)
        Me.clb_sabores.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quantidade:"
        '
        'cmb_quantidade
        '
        Me.cmb_quantidade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_quantidade.FormattingEnabled = True
        Me.cmb_quantidade.Location = New System.Drawing.Point(25, 115)
        Me.cmb_quantidade.Name = "cmb_quantidade"
        Me.cmb_quantidade.Size = New System.Drawing.Size(149, 39)
        Me.cmb_quantidade.TabIndex = 0
        '
        'frm_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(915, 517)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_pedidos"
        Me.Text = "Pedidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents clb_sabores As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_quantidade As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_tamanho As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_entrega As TextBox
    Friend WithEvents cb_entrega As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents Tamanho As DataGridViewTextBoxColumn
    Friend WithEvents Sabor As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
End Class
