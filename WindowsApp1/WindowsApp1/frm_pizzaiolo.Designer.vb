<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pizzaiolo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pizzaiolo))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EncerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.numpedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feito = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(887, 24)
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
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numpedido, Me.pedido, Me.Column2, Me.feito})
        Me.DataGridView1.Location = New System.Drawing.Point(81, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(725, 383)
        Me.DataGridView1.TabIndex = 22
        '
        'numpedido
        '
        Me.numpedido.HeaderText = "Número de Pedido"
        Me.numpedido.Name = "numpedido"
        '
        'pedido
        '
        Me.pedido.HeaderText = "Pedido"
        Me.pedido.Name = "pedido"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Entrega"
        Me.Column2.Name = "Column2"
        '
        'feito
        '
        Me.feito.HeaderText = "Feito"
        Me.feito.Image = CType(resources.GetObject("feito.Image"), System.Drawing.Image)
        Me.feito.Name = "feito"
        '
        'btn_voltar
        '
        Me.btn_voltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.Coral
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_voltar.Location = New System.Drawing.Point(11, 440)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(108, 39)
        Me.btn_voltar.TabIndex = 24
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'lbl_user
        '
        Me.lbl_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Location = New System.Drawing.Point(796, 9)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(45, 13)
        Me.lbl_user.TabIndex = 27
        Me.lbl_user.Text = "Label11"
        '
        'frm_pizzaiolo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(887, 485)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_pizzaiolo"
        Me.Text = "Pedidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EncerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents numpedido As DataGridViewTextBoxColumn
    Friend WithEvents pedido As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents feito As DataGridViewImageColumn
    Friend WithEvents btn_voltar As Button
    Friend WithEvents lbl_user As Label
End Class
