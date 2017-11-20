Public Class frm_adduser
    Private Sub txt_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_nome.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frm_adduser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        With cmb_cargo.Items
            .Add("Vendedor")
            .Add("Entregador")
            .Add("Pizzaiolo")
            .Add("Gerente")
        End With
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If txt_nome.Text = "" Or txt_cpf.Text = "" Or txt_data.Text = "" Or txt_senha.Text = "" Then
            MsgBox("Campos em branco", vbInformation + vbOKOnly, "Atenção")
        Else
            sql = "insert into tb_login values('" & txt_cpf.Text & "' , '" & txt_nome.Text & "' , '" & txt_senha.Text & "' , '" & cmb_cargo.Text & "', '" & txt_data.Text & "' , '', 'Ativo')"
            rs = db.Execute(sql)
            MsgBox("Funcionário cadastrado!!!")
            limpar()
        End If
    End Sub
End Class