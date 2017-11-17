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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.cb_borda = New System.Windows.Forms.CheckBox()
        Me.cmb_borda = New System.Windows.Forms.ComboBox()
        Me.cb_entrega = New System.Windows.Forms.CheckBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_entrega = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_tamanho = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clb_sabores = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_quantidade = New System.Windows.Forms.ComboBox()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tamanho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sabor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Borda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_obs)
        Me.GroupBox1.Controls.Add(Me.cb_borda)
        Me.GroupBox1.Controls.Add(Me.cmb_borda)
        Me.GroupBox1.Controls.Add(Me.cb_entrega)
        Me.GroupBox1.Controls.Add(Me.btn_ok)
        Me.GroupBox1.Controls.Add(Me.btn_confirmar)
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
        Me.GroupBox1.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Tomato
        Me.GroupBox1.Location = New System.Drawing.Point(36, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 428)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 30)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Observações:"
        '
        'txt_obs
        '
        Me.txt_obs.Font = New System.Drawing.Font("Moon Flower Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_obs.Location = New System.Drawing.Point(25, 347)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(149, 58)
        Me.txt_obs.TabIndex = 15
        '
        'cb_borda
        '
        Me.cb_borda.AutoSize = True
        Me.cb_borda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_borda.Location = New System.Drawing.Point(18, 247)
        Me.cb_borda.Name = "cb_borda"
        Me.cb_borda.Size = New System.Drawing.Size(76, 34)
        Me.cb_borda.TabIndex = 13
        Me.cb_borda.Text = "Borda"
        Me.cb_borda.UseVisualStyleBackColor = True
        '
        'cmb_borda
        '
        Me.cmb_borda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_borda.FormattingEnabled = True
        Me.cmb_borda.Location = New System.Drawing.Point(25, 273)
        Me.cmb_borda.Name = "cmb_borda"
        Me.cmb_borda.Size = New System.Drawing.Size(149, 38)
        Me.cmb_borda.TabIndex = 14
        '
        'cb_entrega
        '
        Me.cb_entrega.AutoSize = True
        Me.cb_entrega.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_entrega.Location = New System.Drawing.Point(18, 175)
        Me.cb_entrega.Name = "cb_entrega"
        Me.cb_entrega.Size = New System.Drawing.Size(95, 34)
        Me.cb_entrega.TabIndex = 6
        Me.cb_entrega.Text = "Entrega"
        Me.cb_entrega.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.LightGray
        Me.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.ForeColor = System.Drawing.Color.SandyBrown
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ok.Location = New System.Drawing.Point(358, 383)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(43, 39)
        Me.btn_ok.TabIndex = 12
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.LightGray
        Me.btn_confirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.ForeColor = System.Drawing.Color.SandyBrown
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_confirmar.Location = New System.Drawing.Point(624, 363)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(182, 39)
        Me.btn_confirmar.TabIndex = 11
        Me.btn_confirmar.Text = "Confirmar Pedido"
        Me.btn_confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(442, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 30)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Valor Total:"
        '
        'txt_valor
        '
        Me.txt_valor.Location = New System.Drawing.Point(466, 364)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(106, 41)
        Me.txt_valor.TabIndex = 9
        Me.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num, Me.Quantidade, Me.Tamanho, Me.Sabor, Me.Borda, Me.Valor, Me.observacao, Me.Excluir})
        Me.DataGridView1.Location = New System.Drawing.Point(407, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(401, 276)
        Me.DataGridView1.TabIndex = 8
        '
        'txt_entrega
        '
        Me.txt_entrega.Location = New System.Drawing.Point(25, 200)
        Me.txt_entrega.Name = "txt_entrega"
        Me.txt_entrega.Size = New System.Drawing.Size(149, 41)
        Me.txt_entrega.TabIndex = 7
        Me.txt_entrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tamanho:"
        '
        'cmb_tamanho
        '
        Me.cmb_tamanho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_tamanho.FormattingEnabled = True
        Me.cmb_tamanho.Location = New System.Drawing.Point(25, 129)
        Me.cmb_tamanho.Name = "cmb_tamanho"
        Me.cmb_tamanho.Size = New System.Drawing.Size(149, 38)
        Me.cmb_tamanho.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sabores:"
        '
        'clb_sabores
        '
        Me.clb_sabores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clb_sabores.Font = New System.Drawing.Font("Moon Flower", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_sabores.FormattingEnabled = True
        Me.clb_sabores.Location = New System.Drawing.Point(191, 63)
        Me.clb_sabores.Name = "clb_sabores"
        Me.clb_sabores.Size = New System.Drawing.Size(196, 328)
        Me.clb_sabores.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quantidade:"
        '
        'cmb_quantidade
        '
        Me.cmb_quantidade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_quantidade.FormattingEnabled = True
        Me.cmb_quantidade.Location = New System.Drawing.Point(25, 63)
        Me.cmb_quantidade.Name = "cmb_quantidade"
        Me.cmb_quantidade.Size = New System.Drawing.Size(149, 38)
        Me.cmb_quantidade.TabIndex = 0
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
        'Borda
        '
        Me.Borda.Frozen = True
        Me.Borda.HeaderText = "Borda"
        Me.Borda.Name = "Borda"
        '
        'Valor
        '
        Me.Valor.Frozen = True
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        '
        'observacao
        '
        Me.observacao.Frozen = True
        Me.observacao.HeaderText = "Observação"
        Me.observacao.Name = "observacao"
        '
        'Excluir
        '
        Me.Excluir.Frozen = True
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.Name = "Excluir"
        Me.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
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
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_obs As TextBox
    Friend WithEvents cb_borda As CheckBox
    Friend WithEvents cmb_borda As ComboBox
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents Tamanho As DataGridViewTextBoxColumn
    Friend WithEvents Sabor As DataGridViewTextBoxColumn
    Friend WithEvents Borda As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents observacao As DataGridViewTextBoxColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
End Class
