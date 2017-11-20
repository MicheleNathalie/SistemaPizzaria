<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_entregador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_entregador))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EncerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.numpedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rua = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entregar = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numpedido, Me.rua, Me.numero, Me.comp, Me.bairro, Me.cidade, Me.estado, Me.nome, Me.entregar})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(894, 383)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(906, 24)
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
        'numpedido
        '
        Me.numpedido.HeaderText = "Número de Pedido"
        Me.numpedido.Name = "numpedido"
        '
        'rua
        '
        Me.rua.HeaderText = "Rua"
        Me.rua.Name = "rua"
        '
        'numero
        '
        Me.numero.HeaderText = "Número"
        Me.numero.Name = "numero"
        '
        'comp
        '
        Me.comp.HeaderText = "Complemento"
        Me.comp.Name = "comp"
        '
        'bairro
        '
        Me.bairro.HeaderText = "Bairro"
        Me.bairro.Name = "bairro"
        '
        'cidade
        '
        Me.cidade.HeaderText = "Cidade"
        Me.cidade.Name = "cidade"
        '
        'estado
        '
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        '
        'entregar
        '
        Me.entregar.HeaderText = "Entregar"
        Me.entregar.Image = CType(resources.GetObject("entregar.Image"), System.Drawing.Image)
        Me.entregar.Name = "entregar"
        '
        'frm_entregador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(906, 487)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_entregador"
        Me.Text = "Entregador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EncerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents numpedido As DataGridViewTextBoxColumn
    Friend WithEvents rua As DataGridViewTextBoxColumn
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents comp As DataGridViewTextBoxColumn
    Friend WithEvents bairro As DataGridViewTextBoxColumn
    Friend WithEvents cidade As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents entregar As DataGridViewImageColumn
End Class
