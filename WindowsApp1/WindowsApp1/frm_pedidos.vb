Public Class frm_pedidos
    Dim valor_pizza, valor_total As Double
    Dim verifica_meia, verifica_sabores, numero_pedido As Integer
    Private Sub frm_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Verifica_Pedido()
        verifica_meia = 0
        verifica_sabores = 0
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
        cmb_borda.Enabled = False
        sql = "select * from tb_bordas"
        rs = db.Execute(sql)
        With cmb_borda.Items
            Do While rs.EOF = False
                .Add(rs.Fields(1).Value)
                rs.MoveNext()
            Loop
        End With
        cmb_borda.SelectedIndex = 0
        sql = "select * from tb_pizzas"
        rs = db.Execute(sql)
        With clb_sabores.Items
            Do While rs.EOF = False
                .Add(rs.Fields(1).Value)
                rs.MoveNext()
            Loop
        End With
        txt_entrega.Enabled = False
    End Sub

    Private Sub cmb_quantidade_TextChanged(sender As Object, e As EventArgs) Handles cmb_quantidade.TextChanged
        clb_sabores.Enabled = True
        clb_sabores.ClearSelected()
    End Sub


    Private Sub cb_entrega_CheckedChanged(sender As Object, e As EventArgs) Handles cb_entrega.CheckedChanged
        txt_entrega.Enabled = True
    End Sub

    Private Sub cmb_quantidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_quantidade.SelectedIndexChanged
        If cmb_quantidade.SelectedIndex = 1 Then
            verifica_meia = 1
        End If
    End Sub

    Private Sub clb_sabores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clb_sabores.SelectedIndexChanged
        MsgBox("sabor= " & clb_sabores.SelectedIndex)

    End Sub

    Private Sub cb_borda_CheckedChanged(sender As Object, e As EventArgs) Handles cb_borda.CheckedChanged
        cmb_borda.Enabled = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Sub Verifica_Pedido()
        sql = "select * from tb_pedidos"
        rs = db.Execute(sql)
        If rs.BOF = True Then
            numero_pedido = 1
        Else
            sql = "select MAX (numero_pedido) as numero_pedido from tb_pedidos"
            rs = db.Execute(sql)
            numero_pedido = rs.Fields(1).Value + 1
        End If
    End Sub
End Class