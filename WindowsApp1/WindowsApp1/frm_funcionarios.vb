Public Class frm_funcionarios
    Private Sub frm_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        sql = "select * from tb_login"
        rs = db.Execute(sql)
        While rs.EOF = False
            With DataGridView1
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing, Nothing, Nothing)
                rs.MoveNext()
            End With
        End While
    End Sub
End Class