<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sabores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sabores))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.nome_borda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao_borda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_borda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar_borda = New System.Windows.Forms.DataGridViewImageColumn()
        Me.excluir_borda = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nome, Me.descricao, Me.valor, Me.editar, Me.excluir})
        Me.DataGridView1.Location = New System.Drawing.Point(56, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(709, 244)
        Me.DataGridView1.TabIndex = 0
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        Me.nome.Width = 60
        '
        'descricao
        '
        Me.descricao.HeaderText = "Descrição"
        Me.descricao.Name = "descricao"
        Me.descricao.Width = 80
        '
        'valor
        '
        Me.valor.HeaderText = "Valor"
        Me.valor.Name = "valor"
        Me.valor.Width = 56
        '
        'editar
        '
        Me.editar.HeaderText = "Editar"
        Me.editar.Image = CType(resources.GetObject("editar.Image"), System.Drawing.Image)
        Me.editar.Name = "editar"
        Me.editar.Width = 40
        '
        'excluir
        '
        Me.excluir.HeaderText = "Excluir"
        Me.excluir.Image = CType(resources.GetObject("excluir.Image"), System.Drawing.Image)
        Me.excluir.Name = "excluir"
        Me.excluir.Width = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(51, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pizzas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(51, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Bordas"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nome_borda, Me.descricao_borda, Me.valor_borda, Me.editar_borda, Me.excluir_borda})
        Me.DataGridView2.Location = New System.Drawing.Point(56, 351)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(709, 150)
        Me.DataGridView2.TabIndex = 3
        '
        'nome_borda
        '
        Me.nome_borda.HeaderText = "Nome"
        Me.nome_borda.Name = "nome_borda"
        Me.nome_borda.Width = 60
        '
        'descricao_borda
        '
        Me.descricao_borda.HeaderText = "Descrição"
        Me.descricao_borda.Name = "descricao_borda"
        Me.descricao_borda.Width = 80
        '
        'valor_borda
        '
        Me.valor_borda.HeaderText = "Valor"
        Me.valor_borda.Name = "valor_borda"
        Me.valor_borda.Width = 56
        '
        'editar_borda
        '
        Me.editar_borda.HeaderText = "Editar"
        Me.editar_borda.Image = CType(resources.GetObject("editar_borda.Image"), System.Drawing.Image)
        Me.editar_borda.Name = "editar_borda"
        Me.editar_borda.Width = 40
        '
        'excluir_borda
        '
        Me.excluir_borda.HeaderText = "Excluir"
        Me.excluir_borda.Image = CType(resources.GetObject("excluir_borda.Image"), System.Drawing.Image)
        Me.excluir_borda.Name = "excluir_borda"
        Me.excluir_borda.Width = 44
        '
        'frm_sabores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(821, 526)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_sabores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sabores"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents nome_borda As DataGridViewTextBoxColumn
    Friend WithEvents descricao_borda As DataGridViewTextBoxColumn
    Friend WithEvents valor_borda As DataGridViewTextBoxColumn
    Friend WithEvents editar_borda As DataGridViewImageColumn
    Friend WithEvents excluir_borda As DataGridViewImageColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents editar As DataGridViewImageColumn
    Friend WithEvents excluir As DataGridViewImageColumn
End Class
