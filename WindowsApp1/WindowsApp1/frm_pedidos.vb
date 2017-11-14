Public Class frm_pedidos
    Private Sub frm_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim privateFonts As New System.Drawing.Text.PrivateFontCollection()
        privateFonts.AddFontFile("C:\Users\miche\Documents\Documentos Memo\ADS\Módulo II\Sistemas de Informação\Projeto do Bertão - Pizzaria\SistemaPizzaria\WindowsApp1\WindowsApp1\bin\Debug\Fontes\Moon Flower Bold.ttf")
        Dim font As New System.Drawing.Font(privateFonts.Families(0), 22)
        Dim font2 As New System.Drawing.Font(privateFonts.Families(0), 25)
        Label1.Font = font2
        Label2.Font = font2
        Label3.Font = font2
        Label4.Font = font2
        Label5.Font = font2
        cb_entrega.Font = font2
        cb_borda.Font = font2
        btn_confirmar.Font = font2
        btn_ok.Font = font2
        cmb_quantidade.Font = font
        cmb_borda.Font = font
        cmb_tamanho.Font = font
        txt_entrega.Font = font
        txt_obs.Font = font
        txt_valor.Font = font
        clb_sabores.Font = font
        DataGridView1.Font = font


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
        With cmb_borda.Items
            .Add("Catupiry")
            .Add("Cheddar")
            .Add("Alho")
            .Add("Chocolate")
            .Add("Doce de Leite")
        End With
        cmb_borda.SelectedIndex = 0
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


    Private Sub cb_entrega_CheckedChanged(sender As Object, e As EventArgs) Handles cb_entrega.CheckedChanged
        txt_entrega.Enabled = True
    End Sub


    Private Sub cb_borda_CheckedChanged(sender As Object, e As EventArgs) Handles cb_borda.CheckedChanged
        cmb_borda.Enabled = True
    End Sub
End Class