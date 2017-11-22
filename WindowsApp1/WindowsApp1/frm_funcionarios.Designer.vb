<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_funcionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_funcionarios))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.senha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.admissao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.demissao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.bloquear = New System.Windows.Forms.DataGridViewImageColumn()
        Me.demitir = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cpf, Me.nome, Me.cargo, Me.senha, Me.admissao, Me.demissao, Me.editar, Me.bloquear, Me.demitir})
        Me.DataGridView1.Location = New System.Drawing.Point(65, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(772, 399)
        Me.DataGridView1.TabIndex = 0
        '
        'cpf
        '
        Me.cpf.HeaderText = "CPF"
        Me.cpf.Name = "cpf"
        Me.cpf.Width = 52
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        Me.nome.Width = 60
        '
        'cargo
        '
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.Name = "cargo"
        Me.cargo.Width = 60
        '
        'senha
        '
        Me.senha.HeaderText = "Senha"
        Me.senha.Name = "senha"
        Me.senha.Width = 63
        '
        'admissao
        '
        Me.admissao.HeaderText = "Data de Admissão"
        Me.admissao.Name = "admissao"
        Me.admissao.Width = 108
        '
        'demissao
        '
        Me.demissao.HeaderText = "Data de Demissao"
        Me.demissao.Name = "demissao"
        Me.demissao.Width = 109
        '
        'editar
        '
        Me.editar.HeaderText = "Editar"
        Me.editar.Image = CType(resources.GetObject("editar.Image"), System.Drawing.Image)
        Me.editar.Name = "editar"
        Me.editar.Width = 40
        '
        'bloquear
        '
        Me.bloquear.HeaderText = "Bloquear"
        Me.bloquear.Image = CType(resources.GetObject("bloquear.Image"), System.Drawing.Image)
        Me.bloquear.Name = "bloquear"
        Me.bloquear.Width = 55
        '
        'demitir
        '
        Me.demitir.HeaderText = "Demissão"
        Me.demitir.Image = CType(resources.GetObject("demitir.Image"), System.Drawing.Image)
        Me.demitir.Name = "demitir"
        Me.demitir.Width = 59
        '
        'frm_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(896, 475)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funcionários"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents senha As DataGridViewTextBoxColumn
    Friend WithEvents admissao As DataGridViewTextBoxColumn
    Friend WithEvents demissao As DataGridViewTextBoxColumn
    Friend WithEvents editar As DataGridViewImageColumn
    Friend WithEvents bloquear As DataGridViewImageColumn
    Friend WithEvents demitir As DataGridViewImageColumn
End Class
