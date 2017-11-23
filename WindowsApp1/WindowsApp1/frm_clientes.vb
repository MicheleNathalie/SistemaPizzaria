Public Class frm_clientes
    Dim verifica_cliente As Integer
    Private Sub btn_seguir_Click(sender As Object, e As EventArgs) Handles btn_seguir.Click
        numero_cliente = txt_numero.Text
        bairro_cliente = txt_bairro.Text
        cidade_cliente = txt_cidade.Text
        complemento_cliente = txt_comp.Text
        referencia_cliente = txt_referencia.Text
        estado_cliente = txt_estado.Text
        nome_cliente = txt_nome.Text
        rua_cliente = txt_rua.Text
        Try


            If (txt_telres.Text = "(11)_____-____" Or txt_telres.Text = "11" Or txt_telres.Text = "") Or txt_estado.Text = "" Or txt_bairro.Text = "" Or txt_cidade.Text = "" Or txt_rua.Text = "" Then
                MsgBox("Campos em branco!", vbInformation + vbOKOnly, "Atenção")
            Else
                If (verifica_cliente = 1) Then
                    sql = "insert into tb_cliente(telefone,nome,rua,numero,bairro,complemento,referencia,cidade,estado)  values ('" & txt_telres.Text & "', '" & txt_nome.Text & "' , '" & txt_rua.Text & "'," &
                        "" & txt_numero.Text & ",'" & txt_bairro.Text & "','" & txt_comp.Text & "','" & txt_referencia.Text & "'," &
                        "'" & txt_cidade.Text & "','" & txt_estado.Text & "')"
                    rs = db.Execute(sql)
                    MsgBox("Novo cliente cadastrado.", vbInformation + vbOKOnly, "Sucesso")
                End If
                txt_telres.Text = "11"
                txt_cidade.Clear()
                txt_bairro.Clear()
                txt_comp.Clear()
                txt_estado.Text = "SP"
                txt_referencia.Clear()
                txt_rua.Clear()
                Me.Hide()
                frm_pedidos.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Erro!", vbExclamation + vbOKOnly)
        End Try
    End Sub

    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_user.Text = nome_funcionario
        verifica_cliente = 0
        conecta_banco()
    End Sub

    Private Sub txt_telres_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_nome.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub EncerrarSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSistemaToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub EncerrarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoToolStripMenuItem.Click
        Me.Hide()
        frm_login.Show()
    End Sub

    Private Sub btn_limp_Click(sender As Object, e As EventArgs) Handles btn_limp.Click
        txt_telres.Text = "11"
        txt_cidade.Clear()
        txt_bairro.Clear()
        txt_comp.Clear()
        txt_estado.Text = "SP"
        txt_referencia.Clear()
        txt_rua.Clear()
    End Sub

    Private Sub txt_telres_LostFocus(sender As Object, e As EventArgs) Handles txt_telres.LostFocus
        verifica_cliente = 0
        sql = "select * from tb_cliente where telefone='" & txt_telres.Text & "'"
        rs = db.Execute(sql)
        If rs.BOF = True Then
            verifica_cliente = 1
        Else
            txt_bairro.Text = rs.Fields(4).Value
            txt_cidade.Text = rs.Fields(7).Value
            txt_comp.Text = rs.Fields(5).Value
            txt_estado.Text = rs.Fields(8).Value
            txt_numero.Text = rs.Fields(3).Value
            txt_referencia.Text = rs.Fields(6).Value
            txt_rua.Text = rs.Fields(2).Value
            txt_nome.Text = rs.Fields(1).Value
        End If
    End Sub
End Class