Public Class frm_sabores
    Private Sub frm_sabores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        atualiza()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        With DataGridView1
            If .CurrentRow.Cells(5).Selected Then
                resp = MsgBox("Deseja Excluir" + vbNewLine + "nome da pizza: " & .CurrentRow.Cells(1).Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete * from tb_pizzas where id_pizza= " & .CurrentRow.Cells(0).Value & ""
                    rs = db.Execute(sql)
                    MsgBox("Pizza excluida!!!")
                    .Rows.Clear()
                    atualiza()
                End If
            End If
            If .CurrentRow.Cells(4).Selected Then
                With frm_addsabores
                    .txt_nome.Text = DataGridView1.CurrentRow.Cells(1).Value
                    .txt_valor.Text = DataGridView1.CurrentRow.Cells(3).Value
                    .txt_descricao.Text = DataGridView1.CurrentRow.Cells(2).Value
                    .cmb_tipo.Text = "Pizza"
                End With
                id_sabor = .CurrentRow.Cells(0).Value
                verifica_edicao = 1
                frm_addsabores.Show()
                Me.Hide()
            End If
        End With
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        With DataGridView2
            If .CurrentRow.Cells(5).Selected Then
                resp = MsgBox("Deseja Excluir" + vbNewLine + "nome da borda" & .CurrentRow.Cells(1).Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete * from tb_bordas where id_borda= " & .CurrentRow.Cells(0).Value & ""
                    rs = db.Execute(sql)
                    MsgBox("Borda excluida!!!")
                    .Rows.Clear()
                    atualiza()
                End If
            End If
            If .CurrentRow.Cells(4).Selected Then
                With frm_addsabores
                    .txt_nome.Text = DataGridView2.CurrentRow.Cells(1).Value
                    .txt_valor.Text = DataGridView2.CurrentRow.Cells(3).Value
                    .txt_descricao.Text = DataGridView2.CurrentRow.Cells(2).Value
                    .cmb_tipo.Text = "Borda"
                End With
                id_sabor = .CurrentRow.Cells(0).Value
                verifica_edicao = 1
                frm_addsabores.Show()
                Me.Hide()
            End If
        End With
    End Sub
    Sub atualiza()
        With DataGridView1
            .Rows.Clear()
            sql = "select * from tb_pizzas"
            rs = db.Execute(sql)
            While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(2).Value, Nothing, Nothing)
                rs.MoveNext()
            End While
        End With
        With DataGridView2
            .Rows.Clear()
            sql = "select * from tb_bordas"
            rs = db.Execute(sql)
            While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(2).Value, Nothing, Nothing)
                rs.MoveNext()
            End While
        End With
    End Sub
End Class