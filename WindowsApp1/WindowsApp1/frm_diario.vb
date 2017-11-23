Public Class frm_diario
    Private Sub frm_diario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        atualiza()
    End Sub

    Dim s As String
    Dim soma As Double

    Sub atualiza()
        s = DateTime.Now.ToString("ddMMyyyy")
        sql = "select * from tb_pedidos"
        rs = db.Execute(sql)
        DataGridView1.Rows.Clear()
        While rs.EOF = False
            If s = rs.Fields(17).Value Then
                With DataGridView1
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(17).Value)
                    rs.MoveNext()
                    soma += rs.Fields(2).Value
                End With
            End If
        End While
        lbl_valor.Text = soma
    End Sub

End Class