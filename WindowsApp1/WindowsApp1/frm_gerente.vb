Public Class frm_gerente
    Private Sub CardápioDePizzasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CardápioDePizzasToolStripMenuItem.Click

    End Sub

    Private Sub AdcionarNovosSaboresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdcionarNovosSaboresToolStripMenuItem.Click
        frm_addsabores.ShowDialog()
    End Sub

    Private Sub ListaDeSaboresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeSaboresToolStripMenuItem.Click
        frm_sabores.ShowDialog()
    End Sub

    Private Sub CadastrarNovoUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarNovoUsuárioToolStripMenuItem.Click
        frm_adduser.ShowDialog()
    End Sub

    Private Sub GerenciarUsuáriosExistentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarUsuáriosExistentesToolStripMenuItem.Click
        frm_funcionarios.ShowDialog()
    End Sub

    Private Sub EntrarComoVendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntrarComoVendedorToolStripMenuItem.Click
        frm_clientes.ShowDialog()
    End Sub

    Private Sub EntrarComoPizzaioloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntrarComoPizzaioloToolStripMenuItem.Click
        frm_pizzaiolo.ShowDialog()
    End Sub

    Private Sub EntrarComoEntregadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntrarComoEntregadorToolStripMenuItem.Click
        frm_entregador.ShowDialog()
    End Sub

    Private Sub EncessarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncessarSessãoToolStripMenuItem.Click
        Me.Close()
        frm_login.ShowDialog()
    End Sub

    Private Sub EncerrarSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSistemaToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub frm_gerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        verifica_edicao = 0
    End Sub
End Class