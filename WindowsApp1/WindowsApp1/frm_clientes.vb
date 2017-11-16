Public Class frm_clientes
    Dim verifica_cliente As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_telres.Text = "(11)"
        txt_cidade.Clear()
        txt_bairro.Clear()
        txt_comp.Clear()
        txt_estado.Text = "SP"
        txt_referencia.Clear()
        txt_rua.Clear()
    End Sub

    Private Sub btn_seguir_Click(sender As Object, e As EventArgs) Handles btn_seguir.Click
        If (txt_telres.Text = "(11)" Or txt_telres.Text = "") Or txt_estado.Text = "" Or txt_bairro.Text = "" Or txt_cidade.Text = "" Or txt_comp.Text = "" Or txt_referencia.Text = "" Or txt_rua.Text = "" Then
            MsgBox("Campos em branco!", vbInformation + vbOKOnly, "Atenção")
        Else
            If (verifica_cliente = 1) Then
                sql = "insert into tb_clientes(telefone,rua,complemento,bairro,cidade,estado,referencia,numero)  values ('" & txt_telres.Text & "', '" & txt_rua.Text & "' , '" & txt_comp.Text & "'," &
                    "'" & txt_bairro.Text & "','" & txt_bairro.Text & "','" & txt_cidade.Text & "','" & txt_estado.Text & "'," &
                    "'" & txt_referencia.Text & "'," & txt_numero.Text & ")"
                rs = db.Execute(sql)
                MsgBox("Novo cliente cadastrado!!")
            End If
            limpar()
            Me.Close()
            frm_pedidos.Show()
        End If
    End Sub

    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'verifica_cliente = 0
        conecta_banco()
    End Sub

    Private Sub txt_telres_TextChanged(sender As Object, e As EventArgs) Handles txt_telres.TextChanged

    End Sub

    Private Sub txt_telres_LostFocus(sender As Object, e As EventArgs) Handles txt_telres.LostFocus
        sql = "select * from tb_clientes where telefone='" & txt_telres.Text & "'"
        rs = db.Execute(sql)
        If rs.BOF = True Then
            MessageBox.Show("Usuário não cadastrado!!" + vbNewLine + "Ele será cadastro ao clicar em seguinte", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            verifica_cliente = 1
        Else
            txt_bairro.Text = rs.Fields(3).Value
            txt_cidade.Text = rs.Fields(4).Value
            txt_comp.Text = rs.Fields(2).Value
            txt_estado.Text = rs.Fields(5).Value
            txt_numero.Text = rs.Fields(7).Value
            txt_referencia.Text = rs.Fields(6).Value
            txt_rua.Text = rs.Fields(1).Value
        End If
    End Sub
End Class