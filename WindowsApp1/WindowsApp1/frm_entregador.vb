Public Class frm_entregador
    Private Sub frm_entregador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_user.Text = nome_funcionario
        conecta_banco()
        atualiza()
    End Sub

    Private Sub EncerrarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoToolStripMenuItem.Click
        Me.Close()
        frm_login.ShowDialog()
    End Sub

    Private Sub EncerrarSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSistemaToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Sub atualiza()
        DataGridView1.Rows.Clear()
        sql = "select * from tb_pedidos where status='Pronto' and entrega ='Sim'"
        rs = db.Execute(sql)
        While rs.EOF = False
            With DataGridView1
                .Rows.Add(rs.Fields(0).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(7).Value, rs.Fields(6).Value, rs.Fields(10).Value, rs.Fields(9).Value, rs.Fields(3).Value, rs.Fields(13).Value, Nothing)
                rs.MoveNext()
            End With
        End While
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        With DataGridView1
            If .CurrentRow.Cells(9).Selected = True Then
                sql = "update tb_pedidos set Status= 'Entregue',nome_motoboy='" & nome_funcionario & "' where numero_pedido=" & .CurrentRow.Cells(0).Value & ""
                rs = db.Execute(sql)
                atualiza()
            End If
        End With
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Hide()
        frm_gerente.Show()
    End Sub
End Class