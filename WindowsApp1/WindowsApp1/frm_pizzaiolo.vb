Public Class frm_pizzaiolo
    Dim s As String
    Private Sub frm_pizzaiolo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        s = DateTime.Now.ToString("ddMMyyyy")
        lbl_user.Text = nome_funcionario
        conecta_banco()
        atualiza()
    End Sub

    Private Sub EncerrarSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSistemaToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub EncerrarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoToolStripMenuItem.Click
        Me.Close()
        frm_login.ShowDialog()
    End Sub
    Sub atualiza()
        sql = "select * from tb_pedidos where status='Fazendo'"
        rs = db.Execute(sql)
        While rs.EOF = False
            With DataGridView1
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(11).Value, Nothing)
                rs.MoveNext()
            End With
        End While
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        With DataGridView1
            If .CurrentRow.Cells(3).Selected = True Then
                sql = "update tb_pedidos set Status= 'Pronto',nome_pizzaiolo='" & nome_funcionario & "' where numero_pedido=" & .CurrentRow.Cells(0).Value & ""
                rs = db.Execute(sql)
                sql = "select * from tb_pedidos where numero_pedido=" & .CurrentRow.Cells(0).Value & ""
                rs = db.Execute(sql)
                sql = "insert into tb_gerente values " & .CurrentRow.Cells(0).Value & ", '" & rs.Fields(2).Value & "','" & s & "'"
                rs = db.Execute(sql)
                DataGridView1.Rows.Clear()
                atualiza()
            End If
        End With
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Hide()
        frm_gerente.Show()
    End Sub
End Class