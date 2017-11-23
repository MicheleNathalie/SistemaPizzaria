<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_adduser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_adduser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_cargo = New System.Windows.Forms.ComboBox()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_data = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(26, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nome"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(32, 55)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(411, 41)
        Me.txt_nome.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(443, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 34)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(26, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 34)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Senha"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(32, 134)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(195, 41)
        Me.txt_senha.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(227, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 34)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Data de Admissão"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Moon Flower Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(407, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 34)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cargo"
        '
        'cmb_cargo
        '
        Me.cmb_cargo.Font = New System.Drawing.Font("Moon Flower Bold", 23.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cargo.FormattingEnabled = True
        Me.cmb_cargo.Location = New System.Drawing.Point(407, 135)
        Me.cmb_cargo.Name = "cmb_cargo"
        Me.cmb_cargo.Size = New System.Drawing.Size(237, 40)
        Me.cmb_cargo.TabIndex = 4
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_confirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.Tomato
        Me.btn_confirmar.Font = New System.Drawing.Font("Moon Flower Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_confirmar.Location = New System.Drawing.Point(264, 191)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(149, 43)
        Me.btn_confirmar.TabIndex = 5
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!)
        Me.txt_cpf.Location = New System.Drawing.Point(449, 55)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(195, 41)
        Me.txt_cpf.TabIndex = 1
        '
        'txt_data
        '
        Me.txt_data.Font = New System.Drawing.Font("Moon Flower Bold", 21.75!)
        Me.txt_data.Location = New System.Drawing.Point(233, 135)
        Me.txt_data.Mask = "99/99/9999"
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(168, 41)
        Me.txt_data.TabIndex = 3
        Me.txt_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_adduser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(676, 246)
        Me.Controls.Add(Me.txt_data)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.cmb_cargo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_adduser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Usuários"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_cargo As ComboBox
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_data As MaskedTextBox
End Class
