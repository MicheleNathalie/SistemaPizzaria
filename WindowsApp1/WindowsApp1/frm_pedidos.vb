Public Class frm_pedidos
    Dim valor_pizza, valor_total As Double
    Dim verifica_meia, numero_pedido, i As Integer
    Dim sabor_pizza, pedido, s As String
    Private Sub frm_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        s = DateTime.Now.ToString("ddMMyyyy")
        lbl_user.Text = nome_funcionario
        txt_entrega.Text = "Não"
        conecta_banco()
        Verifica_Pedido()
        verifica_meia = 0
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
        cmb_sabores2.Enabled = False
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
        With cmb_sabores.Items
            Do While rs.EOF = False
                .Add(rs.Fields(1).Value)
                rs.MoveNext()
            Loop
        End With
        sql = "select * from tb_pizzas"
        rs = db.Execute(sql)
        With cmb_sabores2.Items
            Do While rs.EOF = False
                .Add(rs.Fields(1).Value)
                rs.MoveNext()
            Loop
        End With
        txt_entrega.Enabled = False
    End Sub
    Private Sub cb_entrega_CheckedChanged(sender As Object, e As EventArgs) Handles cb_entrega.CheckedChanged
        If cb_entrega.Checked = True Then
            txt_entrega.Enabled = True
            txt_entrega.Text = "Sim"
        Else
            txt_entrega.Enabled = False
            txt_entrega.Text = "Não"
        End If
    End Sub

    Private Sub cmb_quantidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_quantidade.SelectedIndexChanged
        If cmb_quantidade.SelectedIndex = 0 Then
            verifica_meia = 1
            cmb_sabores2.Enabled = True
        Else
            verifica_meia = 0
            cmb_sabores2.Enabled = False
        End If
    End Sub
    Private Sub cb_borda_CheckedChanged(sender As Object, e As EventArgs) Handles cb_borda.CheckedChanged
        If cb_borda.Checked = True Then
            cmb_borda.Enabled = True
        Else
            cmb_borda.Enabled = False
            cmb_borda.Text = Nothing
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        With DataGridView1
            If .CurrentRow.Cells(7).Selected = True Then
                resp = MsgBox("Deseja mesmo excluir essa linha?", MessageBoxButtons.YesNo)
                If resp = vbYes Then
                    valor_total = valor_total - .CurrentRow.Cells(5).Value
                    txt_valor.Text = valor_total
                    .Rows.RemoveAt(.CurrentRow.Index)
                End If
            End If
        End With
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        sql = "select * from tb_pizzas where nome_pizza= '" & cmb_sabores.Text & "'"
        rs = db.Execute(sql)
        valor_pizza = rs.Fields(2).Value
        If verifica_meia = 1 Then
            sabor_pizza = cmb_sabores.Text & " e " & cmb_sabores2.Text
            sql = "select * from tb_pizzas where nome_pizza= '" & cmb_sabores2.Text & "'"
            rs = db.Execute(sql)
            If (rs.Fields(2).Value > valor_pizza) Then
                valor_pizza = rs.Fields(2).Value
            End If
        Else
            sabor_pizza = cmb_sabores.Text
            valor_pizza = valor_pizza * cmb_quantidade.Text
        End If
        If cmb_borda.Enabled = True Then
            sql = "select* from tb_bordas where nome_borda = '" & cmb_borda.Text & "'"
            rs = db.Execute(sql)
            valor_pizza = valor_pizza + rs.Fields(2).Value
        End If
        With DataGridView1
            .Rows.Add(numero_pedido, cmb_quantidade.Text, cmb_tamanho.Text, sabor_pizza, cmb_borda.Text, valor_pizza, txt_obs.Text, Nothing)
        End With
        valor_total = valor_total + valor_pizza
        txt_valor.Text = valor_total
        verifica_meia = 0
        txt_obs.Text = Nothing
        cmb_borda.Text = Nothing
        cmb_sabores.Text = Nothing
        cmb_sabores2.Text = Nothing
        cmb_sabores2.Enabled = False
        cmb_tamanho.Text = Nothing
    End Sub

    Private Sub EncerrarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoToolStripMenuItem.Click
        Me.Close()
        frm_login.ShowDialog()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        resp = MessageBox.Show("Tem certeza que deseja fechar o pedido?", "AVISO", MessageBoxButtons.YesNo)
        If resp = vbYes Then
            i = 0
            While i < DataGridView1.RowCount - 1
                pedido = pedido & DataGridView1.Rows(i).Cells(1).Value & " " & DataGridView1.Rows(i).Cells(2).Value & " " & DataGridView1.Rows(i).Cells(3).Value & "borda de" & DataGridView1.Rows(i).Cells(4).Value & " " & DataGridView1.Rows(i).Cells(6).Value & ". "
                i = i + 1
            End While
            sql = "insert into tb_pedidos (numero_pedido,pedido,valor_pedido,nome,rua,numero,bairro,complemento,referencia,estado,cidade,entrega,status,observacao_motoboy,nome_vendedor,data_pedido)  values(" & numero_pedido & " , '" & pedido & "' , '" & txt_valor.Text & "','" & nome_cliente & "' , '" & rua_cliente & "' , '" & numero_cliente & "' , '" & bairro_cliente & "' , '" & complemento_cliente & "' , '" & referencia_cliente & "' , '" & estado_cliente & "' , '" & cidade_cliente & "' , '" & txt_entrega.Text & "','Fazendo','" & txt_obs_motoboy.Text & "', '" & nome_funcionario & "','" & s & "')"
            rs = db.Execute(sql)
            i = i + 1
            MsgBox("pedido feito com sucesso!!!")
            DataGridView1.Rows.Clear()
            limpar()
            pedido = Nothing
            With frm_pizzaiolo
                .atualiza()
            End With
            Verifica_Pedido()
        End If
    End Sub

    Sub Verifica_Pedido()
        sql = "select * from tb_pedidos"
        rs = db.Execute(sql)
        If rs.BOF = True Then
            numero_pedido = 1
        Else
            sql = "select MAX (numero_pedido) as numero_pedido from tb_pedidos"
            rs = db.Execute(sql)
            numero_pedido = rs.Fields(0).Value + 1
        End If
    End Sub


    Private Sub EncerrarSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSistemaToolStripMenuItem.Click
        Application.Exit()
    End Sub

End Class