Public Class frm_addsabores
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If txt_nome.Text = "" Or txt_valor.Text = "" Or txt_descricao.Text = "" Or cmb_tipo.Text = "" Then
            MsgBox("Campos em branco", vbInformation + vbOKOnly, "Atenção")
        Else
            If cmb_tipo.SelectedIndex = (0) Then
                sql = "insert into tb_pizzas (nome_pizza,preco_pizza,descricao_pizza) values ('" & txt_nome.Text & "', " & txt_valor.Text & ", '" & txt_descricao.Text & "')"
                rs = db.Execute(sql)
                MsgBox("nova pizza cadastrada!")
            Else
                sql = "insert into tb_bordas(nome_borda,preco_borda,descricao_borda) values ('" & txt_nome.Text & "', " & txt_valor.Text & ", '" & txt_descricao.Text & "')"
                rs = db.Execute(sql)
                MsgBox("nova borda cadastrada!")
            End If
        End If
        limpar()
    End Sub

    Private Sub frm_addsabores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cmb_tipo.Items
            .Add("Pizza")
            .Add("Borda")
        End With
    End Sub
End Class