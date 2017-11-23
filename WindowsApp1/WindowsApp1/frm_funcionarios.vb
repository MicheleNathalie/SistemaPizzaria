Public Class frm_funcionarios
    Private Sub frm_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        atualiza()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        With DataGridView1
            If .CurrentRow.Cells(8).Selected Then
                resp = MsgBox("Deseja Excluir" + vbNewLine + "CPF:" & .CurrentRow.Cells(0).Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete * from tb_login where cpf= '" & .CurrentRow.Cells(0).Value & "'"
                    rs = db.Execute(sql)
                    MsgBox("Funcionário excluido!!!")
                    atualiza()
                End If
            End If
            If .CurrentRow.Cells(7).Selected Then
                resp = MsgBox("Deseja bloquear?" + vbNewLine + "CPF:" & .CurrentRow.Cells(0).Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "update tb_login set status='Bloqueada' where cpf= '" & .CurrentRow.Cells(0).Value & "'"
                    rs = db.Execute(sql)
                    MsgBox("Funcionário bloqueado!!!")
                    atualiza()
                End If
            End If
            If .CurrentRow.Cells(6).Selected Then
                With frm_adduser
                    .txt_cpf.Text = DataGridView1.CurrentRow.Cells(0).Value
                    .txt_data.Text = DataGridView1.CurrentRow.Cells(4).Value
                    .txt_nome.Text = DataGridView1.CurrentRow.Cells(1).Value
                    .txt_senha.Text = DataGridView1.CurrentRow.Cells(3).Value
                    .cmb_cargo.Text = DataGridView1.CurrentRow.Cells(2).Value
                End With
                verifica_edicao = 1
                Me.Hide()
                frm_adduser.Show()
            End If
        End With
    End Sub
    Sub atualiza()
        sql = "select * from tb_login"
        rs = db.Execute(sql)
        DataGridView1.Rows.Clear()
        While rs.EOF = False
            With DataGridView1
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing, Nothing, Nothing)
                rs.MoveNext()
            End With
        End While
    End Sub
End Class