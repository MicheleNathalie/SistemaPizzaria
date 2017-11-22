Public Class frm_addsabores
    Dim id As Integer
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If txt_nome.Text = "" Or txt_valor.Text = "" Or txt_descricao.Text = "" Or cmb_tipo.Text = "" Then
            MsgBox("Campos em branco", vbInformation + vbOKOnly, "Atenção")
        Else
            If verifica_edicao = 1 Then
                atualiza_sabores()
                cmb_tipo.Enabled = True
                verifica_edicao = 0
                frm_sabores.atualiza()
                Me.Hide()
                frm_sabores.Show()
            Else
                If cmb_tipo.SelectedIndex = (0) Then
                    Verifica_Pizza()
                    sql = "insert into tb_pizzas (id_pizza,nome_pizza,preco_pizza,descricao_pizza) values (" & id & " , '" & txt_nome.Text & "' , '" & txt_valor.Text & "' , '" & txt_descricao.Text & "')"
                    rs = db.Execute(sql)
                    MsgBox("nova pizza cadastrada!")
                    limpar()
                Else
                    Verifica_Borda()
                    sql = "insert into tb_bordas(id_borda,nome_borda,preco_borda,descricao_borda) values (" & id & " , '" & txt_nome.Text & "' , '" & txt_valor.Text & "' , '" & txt_descricao.Text & "')"
                    rs = db.Execute(sql)
                    MsgBox("nova borda cadastrada!")
                    limpar()
                End If
            End If
        End If
        limpar()
    End Sub

    Private Sub frm_addsabores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        If verifica_edicao = 1 Then
            cmb_tipo.Enabled = False
        Else
            With cmb_tipo.Items
                .Clear()
                .Add("Pizza")
                .Add("Borda")
            End With
        End If
    End Sub
    Sub Verifica_Pizza()
        sql = "select * from tb_pizzas"
        rs = db.Execute(sql)
        If rs.BOF = True Then
            id = 1
        Else
            sql = "select MAX (id_pizza) as id from tb_pizzas"
            rs = db.Execute(sql)
            id = rs.Fields(0).Value + 1
        End If
    End Sub
    Sub Verifica_Borda()
        sql = "select * from tb_bordas"
        rs = db.Execute(sql)
        If rs.BOF = True Then
            id = 1
        Else
            sql = "select MAX (id_borda) as id from tb_bordas"
            rs = db.Execute(sql)
            id = rs.Fields(0).Value + 1
        End If
    End Sub
    Sub atualiza_sabores()
        If cmb_tipo.SelectedIndex = (0) Then
            sql = "update tb_pizzas set nome_pizza='" & txt_nome.Text & "', preco_pizza = '" & txt_valor.Text & "', descricao_pizza='" & txt_descricao.Text & "' where id_pizza= " & id_sabor & ""
            rs = db.Execute(sql)
            MsgBox("pizza alterada!")
            limpar()
        Else
            sql = "update tb_bordas set nome_borda='" & txt_nome.Text & "', preco_borda = '" & txt_valor.Text & "', descricao_borda='" & txt_descricao.Text & "' where id_borda= " & id_sabor & ""
            rs = db.Execute(sql)
            MsgBox("borda alterada!")
            limpar()
        End If
    End Sub

End Class