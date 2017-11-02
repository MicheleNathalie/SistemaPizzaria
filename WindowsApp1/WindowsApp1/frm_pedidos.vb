Public Class frm_pedidos
    Private Sub frm_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cmb_quantidade.Items
            .Add("Meia")
            .Add("1")
            .Add("2")
            .Add("3")
            .Add("4")
            .Add("5")
            .Add("6")
            .Add("7")
            .Add("8")
            .Add("9")
            .Add("10")
        End With
        With cmb_tamanho.Items
            .Add("Brotinho (4 Pedaços)")
            .Add("Media (6 Pedaços)")
            .Add("Grande (8 pedaços)")
            .Add("Familia (10 Pedaços)")
        End With
        cmb_tamanho.SelectedIndex = 2
        clb_sabores.Enabled = False
        With clb_sabores.Items
            .Add("Alho e Óleo")
            .Add("Atum")
            .Add("Catu-Atum")
            .Add("Aliche")
            .Add("Calabresa")
            .Add("Baiana")
            .Add("4 Queijos")
            .Add("3 Queijos")
            .Add("Mozzarela")
            .Add("Marguerita")
            .Add("Portuguesa")
            .Add("Caipira")
            .Add("Catu-Frango")
            .Add("Catu-Frango Palmito")
            .Add("Bacon")
            .Add("Peperoni")
            .Add("Peperoni Especial")
            .Add("Cheddar")
        End With
        txt_entrega.Enabled = False
    End Sub

    Private Sub cmb_quantidade_TextChanged(sender As Object, e As EventArgs) Handles cmb_quantidade.TextChanged
        clb_sabores.Enabled = True
        clb_sabores.ClearSelected()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cb_entrega_CheckedChanged(sender As Object, e As EventArgs) Handles cb_entrega.CheckedChanged
        txt_entrega.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class