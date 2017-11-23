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
        Me.btn_info = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_obs_motoboy = New System.Windows.Forms.TextBox()
        Me.cmb_sabores2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_sabores = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.cb_borda = New System.Windows.Forms.CheckBox()
        Me.cmb_borda = New System.Windows.Forms.ComboBox()
        Me.cb_entrega = New System.Windows.Forms.CheckBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_tamanho = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_quantidade = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tamanho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sabor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Borda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_valor = New System.Windows.Forms.MaskedTextBox()
        Me.txt_entrega = New System.Windows.Forms.MaskedTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EncerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btn_info)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_obs_motoboy)
        Me.GroupBox1.Controls.Add(Me.cmb_sabores2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmb_sabores)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_obs)
        Me.GroupBox1.Controls.Add(Me.cb_borda)
        Me.GroupBox1.Controls.Add(Me.cmb_borda)
        Me.GroupBox1.Controls.Add(Me.cb_entrega)
        Me.GroupBox1.Controls.Add(Me.btn_ok)
        Me.GroupBox1.Controls.Add(Me.btn_confirmar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_tamanho)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_quantidade)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txt_valor)
        Me.GroupBox1.Controls.Add(Me.txt_entrega)
        Me.GroupBox1.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Tomato
        Me.GroupBox1.Location = New System.Drawing.Point(46, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(842, 428)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btn_info
        '
        Me.btn_info.BackColor = System.Drawing.Color.LightGray
        Me.btn_info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_info.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_info.ForeColor = System.Drawing.Color.SandyBrown
        Me.btn_info.Image = CType(resources.GetObject("btn_info.Image"), System.Drawing.Image)
        Me.btn_info.Location = New System.Drawing.Point(546, 77)
        Me.btn_info.Name = "btn_info"
        Me.btn_info.Size = New System.Drawing.Size(43, 39)
        Me.btn_info.TabIndex = 21
        Me.btn_info.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 383)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(244, 30)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Observações para o motoboy:"
        '
        'txt_obs_motoboy
        '
        Me.txt_obs_motoboy.Font = New System.Drawing.Font("Moon Flower Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_obs_motoboy.Location = New System.Drawing.Point(262, 383)
        Me.txt_obs_motoboy.Multiline = True
        Me.txt_obs_motoboy.Name = "txt_obs_motoboy"
        Me.txt_obs_motoboy.Size = New System.Drawing.Size(371, 30)
        Me.txt_obs_motoboy.TabIndex = 19
        '
        'cmb_sabores2
        '
        Me.cmb_sabores2.FormattingEnabled = True
        Me.cmb_sabores2.Location = New System.Drawing.Point(377, 135)
        Me.cmb_sabores2.Name = "cmb_sabores2"
        Me.cmb_sabores2.Size = New System.Drawing.Size(163, 38)
        Me.cmb_sabores2.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sabores:"
        '
        'cmb_sabores
        '
        Me.cmb_sabores.FormattingEnabled = True
        Me.cmb_sabores.Location = New System.Drawing.Point(208, 135)
        Me.cmb_sabores.Name = "cmb_sabores"
        Me.cmb_sabores.Size = New System.Drawing.Size(163, 38)
        Me.cmb_sabores.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(372, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 30)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Observações:"
        '
        'txt_obs
        '
        Me.txt_obs.Font = New System.Drawing.Font("Moon Flower Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_obs.Location = New System.Drawing.Point(377, 68)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(163, 58)
        Me.txt_obs.TabIndex = 4
        '
        'cb_borda
        '
        Me.cb_borda.AutoSize = True
        Me.cb_borda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_borda.Location = New System.Drawing.Point(208, 39)
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
        Me.cmb_borda.Location = New System.Drawing.Point(208, 68)
        Me.cmb_borda.Name = "cmb_borda"
        Me.cmb_borda.Size = New System.Drawing.Size(163, 38)
        Me.cmb_borda.TabIndex = 2
        '
        'cb_entrega
        '
        Me.cb_entrega.AutoSize = True
        Me.cb_entrega.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_entrega.Location = New System.Drawing.Point(617, 35)
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
        Me.btn_ok.Location = New System.Drawing.Point(546, 122)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(43, 39)
        Me.btn_ok.TabIndex = 5
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
        Me.btn_confirmar.Location = New System.Drawing.Point(654, 383)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(182, 39)
        Me.btn_confirmar.TabIndex = 6
        Me.btn_confirmar.Text = "Confirmar Pedido"
        Me.btn_confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(612, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 30)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Valor Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tamanho:"
        '
        'cmb_tamanho
        '
        Me.cmb_tamanho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_tamanho.FormattingEnabled = True
        Me.cmb_tamanho.Location = New System.Drawing.Point(53, 135)
        Me.cmb_tamanho.Name = "cmb_tamanho"
        Me.cmb_tamanho.Size = New System.Drawing.Size(149, 38)
        Me.cmb_tamanho.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quantidade:"
        '
        'cmb_quantidade
        '
        Me.cmb_quantidade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_quantidade.FormattingEnabled = True
        Me.cmb_quantidade.Location = New System.Drawing.Point(53, 67)
        Me.cmb_quantidade.Name = "cmb_quantidade"
        Me.cmb_quantidade.Size = New System.Drawing.Size(149, 38)
        Me.cmb_quantidade.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num, Me.Quantidade, Me.Tamanho, Me.Sabor, Me.Borda, Me.Valor, Me.observacao, Me.Excluir})
        Me.DataGridView1.Location = New System.Drawing.Point(17, 189)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(806, 188)
        Me.DataGridView1.TabIndex = 8
        '
        'num
        '
        Me.num.Frozen = True
        Me.num.HeaderText = "-"
        Me.num.Name = "num"
        Me.num.ReadOnly = True
        Me.num.Width = 47
        '
        'Quantidade
        '
        Me.Quantidade.Frozen = True
        Me.Quantidade.HeaderText = "Quantidade"
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.ReadOnly = True
        Me.Quantidade.Width = 129
        '
        'Tamanho
        '
        Me.Tamanho.Frozen = True
        Me.Tamanho.HeaderText = "Tamanho"
        Me.Tamanho.Name = "Tamanho"
        Me.Tamanho.ReadOnly = True
        Me.Tamanho.Width = 104
        '
        'Sabor
        '
        Me.Sabor.Frozen = True
        Me.Sabor.HeaderText = "Sabor"
        Me.Sabor.Name = "Sabor"
        Me.Sabor.ReadOnly = True
        Me.Sabor.Width = 81
        '
        'Borda
        '
        Me.Borda.Frozen = True
        Me.Borda.HeaderText = "Borda"
        Me.Borda.Name = "Borda"
        Me.Borda.Width = 82
        '
        'Valor
        '
        Me.Valor.Frozen = True
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        Me.Valor.Width = 82
        '
        'observacao
        '
        Me.observacao.Frozen = True
        Me.observacao.HeaderText = "Observação"
        Me.observacao.Name = "observacao"
        Me.observacao.Width = 126
        '
        'Excluir
        '
        Me.Excluir.Frozen = True
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.Name = "Excluir"
        Me.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Excluir.Width = 80
        '
        'txt_valor
        '
        Me.txt_valor.Enabled = False
        Me.txt_valor.Location = New System.Drawing.Point(617, 132)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(149, 41)
        Me.txt_valor.TabIndex = 22
        Me.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_entrega
        '
        Me.txt_entrega.Location = New System.Drawing.Point(617, 64)
        Me.txt_entrega.Name = "txt_entrega"
        Me.txt_entrega.Size = New System.Drawing.Size(149, 41)
        Me.txt_entrega.TabIndex = 23
        Me.txt_entrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(921, 24)
        Me.MenuStrip1.TabIndex = 21
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
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Coral
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.Location = New System.Drawing.Point(46, 498)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(128, 39)
        Me.btn_cancelar.TabIndex = 22
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_user
        '
        Me.lbl_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Location = New System.Drawing.Point(824, 9)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(45, 13)
        Me.lbl_user.TabIndex = 27
        Me.lbl_user.Text = "Label11"
        '
        'frm_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(921, 557)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_pedidos"
        Me.Text = "Pedidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_quantidade As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_tamanho As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_entrega As CheckBox
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents Label4 As Label
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EncerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents cmb_sabores2 As ComboBox
    Friend WithEvents cmb_sabores As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_obs_motoboy As TextBox
    Friend WithEvents btn_info As Button
    Friend WithEvents lbl_user As Label
    Friend WithEvents txt_valor As MaskedTextBox
    Friend WithEvents txt_entrega As MaskedTextBox
End Class
