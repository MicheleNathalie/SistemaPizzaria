<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_anual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_anual))
        Me.lbl_valor = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Numpedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorpedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.Font = New System.Drawing.Font("Moon Flower Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor.Location = New System.Drawing.Point(213, 436)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(29, 39)
        Me.lbl_valor.TabIndex = 5
        Me.lbl_valor.Text = "-"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Moon Flower Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(59, 436)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(148, 39)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Valor Total:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numpedido, Me.valorpedido, Me.data})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(318, 400)
        Me.DataGridView1.TabIndex = 3
        '
        'Numpedido
        '
        Me.Numpedido.HeaderText = "Numero do Pedido"
        Me.Numpedido.Name = "Numpedido"
        Me.Numpedido.Width = 80
        '
        'valorpedido
        '
        Me.valorpedido.HeaderText = "Valor do Pedido"
        Me.valorpedido.Name = "valorpedido"
        Me.valorpedido.Width = 98
        '
        'data
        '
        Me.data.HeaderText = "Data do Pedido"
        Me.data.Name = "data"
        Me.data.Width = 97
        '
        'frm_anual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(366, 486)
        Me.Controls.Add(Me.lbl_valor)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_anual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório Anual"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_valor As Label
    Friend WithEvents label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Numpedido As DataGridViewTextBoxColumn
    Friend WithEvents valorpedido As DataGridViewTextBoxColumn
    Friend WithEvents data As DataGridViewTextBoxColumn
End Class
