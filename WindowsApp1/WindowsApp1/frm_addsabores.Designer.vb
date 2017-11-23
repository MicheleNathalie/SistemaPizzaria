<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_addsabores
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_addsabores))
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.txt_valor = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(26, 57)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(303, 41)
        Me.txt_nome.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(329, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 34)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(20, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 34)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descrição"
        '
        'txt_descricao
        '
        Me.txt_descricao.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descricao.Location = New System.Drawing.Point(26, 143)
        Me.txt_descricao.Multiline = True
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(545, 94)
        Me.txt_descricao.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(450, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 34)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(450, 57)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(121, 42)
        Me.cmb_tipo.TabIndex = 2
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_confirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.Tomato
        Me.btn_confirmar.Font = New System.Drawing.Font("Moon Flower Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_confirmar.Location = New System.Drawing.Point(217, 247)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(149, 43)
        Me.btn_confirmar.TabIndex = 4
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'txt_valor
        '
        Me.txt_valor.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!)
        Me.txt_valor.Location = New System.Drawing.Point(335, 57)
        Me.txt_valor.Mask = "99.99"
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(109, 41)
        Me.txt_valor.TabIndex = 1
        Me.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_addsabores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(597, 313)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_addsabores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Sabores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_descricao As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents txt_valor As MaskedTextBox
End Class
