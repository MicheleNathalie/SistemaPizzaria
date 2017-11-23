Public Class frm_adduser
    Dim objeto As New Valida_CPF_CNPJ
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
        If verifica_edicao = 1 Then
            atualiza_usuario()
            verifica_edicao = 0
        Else
            If txt_nome.Text = "" Or txt_cpf.Text = "" Or txt_data.Text = "" Or txt_senha.Text = "" Then
                MsgBox("Campos em branco", vbInformation + vbOKOnly, "Atenção")
            Else
                objeto.cnpj = txt_cpf.Text

                If objeto.isCpfValido = False Then
                    MessageBox.Show("CPF Iválido!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txt_cpf.Clear()
                    Exit Sub
                End If
                sql = "select* from tb_login where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("CPF ja cadastrado!!!" + vbNewLine + "Escolha outro")
                    Exit Sub
                Else
                    sql = "insert into tb_login values('" & txt_cpf.Text & "' , '" & txt_nome.Text & "' , '" & txt_senha.Text & "' , '" & cmb_cargo.Text & "', '" & txt_data.Text & "' , '', 'Ativo')"
                    rs = db.Execute(sql)
                    MsgBox("Funcionário cadastrado!!!")
                    limpar()
                End If
            End If
        End If
    End Sub
    Sub atualiza_usuario()
        objeto.cnpj = txt_cpf.Text

        If objeto.isCpfValido = False Then
            MessageBox.Show("CPF Iválido!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_cpf.Clear()
            Exit Sub
        End If
        sql = "update tb_login set nome='" & txt_nome.Text & "',senha= '" & txt_senha.Text & "' , tipo=  '" & cmb_cargo.Text & "', data_contratacao= '" & txt_data.Text & "' where cpf= '" & txt_cpf.Text & "'"
        rs = db.Execute(sql)
        MsgBox("funcionário alterado!!")
        limpar()
        frm_funcionarios.atualiza()
        Me.Hide()
        frm_funcionarios.Show()
    End Sub

    
    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        objeto.cnpj = txt_cpf.Text

        If objeto.isCpfValido = False Then
            MessageBox.Show("CPF Iválido!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_cpf.Clear()
            Exit Sub
        End If
    End Sub
End Class