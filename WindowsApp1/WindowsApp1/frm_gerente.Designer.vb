<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_gerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerente))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GerênciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioDeVendasDiárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MensalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CardápioDePizzasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntrarComoVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PizzaioloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntrarComoPizzaioloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntregadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntrarComoEntregadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerênciaToolStripMenuItem, Me.VendedorToolStripMenuItem, Me.PizzaioloToolStripMenuItem, Me.EntregadorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(919, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GerênciaToolStripMenuItem
        '
        Me.GerênciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatórioDeVendasDiárioToolStripMenuItem, Me.CardápioDePizzasToolStripMenuItem, Me.FuncionáriosToolStripMenuItem})
        Me.GerênciaToolStripMenuItem.Name = "GerênciaToolStripMenuItem"
        Me.GerênciaToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.GerênciaToolStripMenuItem.Text = "Gerência"
        '
        'RelatórioDeVendasDiárioToolStripMenuItem
        '
        Me.RelatórioDeVendasDiárioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiárioToolStripMenuItem, Me.MensalToolStripMenuItem, Me.AnualToolStripMenuItem})
        Me.RelatórioDeVendasDiárioToolStripMenuItem.Image = CType(resources.GetObject("RelatórioDeVendasDiárioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RelatórioDeVendasDiárioToolStripMenuItem.Name = "RelatórioDeVendasDiárioToolStripMenuItem"
        Me.RelatórioDeVendasDiárioToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RelatórioDeVendasDiárioToolStripMenuItem.Text = "Relatório de Vendas"
        '
        'DiárioToolStripMenuItem
        '
        Me.DiárioToolStripMenuItem.Name = "DiárioToolStripMenuItem"
        Me.DiárioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DiárioToolStripMenuItem.Text = "Diário"
        '
        'MensalToolStripMenuItem
        '
        Me.MensalToolStripMenuItem.Name = "MensalToolStripMenuItem"
        Me.MensalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MensalToolStripMenuItem.Text = "Mensal"
        '
        'AnualToolStripMenuItem
        '
        Me.AnualToolStripMenuItem.Name = "AnualToolStripMenuItem"
        Me.AnualToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AnualToolStripMenuItem.Text = "Anual"
        '
        'CardápioDePizzasToolStripMenuItem
        '
        Me.CardápioDePizzasToolStripMenuItem.Image = CType(resources.GetObject("CardápioDePizzasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CardápioDePizzasToolStripMenuItem.Name = "CardápioDePizzasToolStripMenuItem"
        Me.CardápioDePizzasToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CardápioDePizzasToolStripMenuItem.Text = "Cardápio de Pizzas"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.Image = CType(resources.GetObject("FuncionáriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'VendedorToolStripMenuItem
        '
        Me.VendedorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntrarComoVendedorToolStripMenuItem})
        Me.VendedorToolStripMenuItem.Name = "VendedorToolStripMenuItem"
        Me.VendedorToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.VendedorToolStripMenuItem.Text = "Vendedor"
        '
        'EntrarComoVendedorToolStripMenuItem
        '
        Me.EntrarComoVendedorToolStripMenuItem.Image = CType(resources.GetObject("EntrarComoVendedorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EntrarComoVendedorToolStripMenuItem.Name = "EntrarComoVendedorToolStripMenuItem"
        Me.EntrarComoVendedorToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.EntrarComoVendedorToolStripMenuItem.Text = "Entrar Como Vendedor"
        '
        'PizzaioloToolStripMenuItem
        '
        Me.PizzaioloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntrarComoPizzaioloToolStripMenuItem})
        Me.PizzaioloToolStripMenuItem.Name = "PizzaioloToolStripMenuItem"
        Me.PizzaioloToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PizzaioloToolStripMenuItem.Text = "Pizzaiolo"
        '
        'EntrarComoPizzaioloToolStripMenuItem
        '
        Me.EntrarComoPizzaioloToolStripMenuItem.Image = CType(resources.GetObject("EntrarComoPizzaioloToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EntrarComoPizzaioloToolStripMenuItem.Name = "EntrarComoPizzaioloToolStripMenuItem"
        Me.EntrarComoPizzaioloToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.EntrarComoPizzaioloToolStripMenuItem.Text = "Entrar Como Pizzaiolo"
        '
        'EntregadorToolStripMenuItem
        '
        Me.EntregadorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntrarComoEntregadorToolStripMenuItem})
        Me.EntregadorToolStripMenuItem.Name = "EntregadorToolStripMenuItem"
        Me.EntregadorToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EntregadorToolStripMenuItem.Text = "Entregador"
        '
        'EntrarComoEntregadorToolStripMenuItem
        '
        Me.EntrarComoEntregadorToolStripMenuItem.Image = CType(resources.GetObject("EntrarComoEntregadorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EntrarComoEntregadorToolStripMenuItem.Name = "EntrarComoEntregadorToolStripMenuItem"
        Me.EntrarComoEntregadorToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.EntrarComoEntregadorToolStripMenuItem.Text = "Entrar Como Entregador"
        '
        'frm_gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(919, 498)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frm_gerente"
        Me.Text = "Gerencia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GerênciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioDeVendasDiárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PizzaioloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntregadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MensalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CardápioDePizzasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntrarComoVendedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntrarComoPizzaioloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntrarComoEntregadorToolStripMenuItem As ToolStripMenuItem
End Class
