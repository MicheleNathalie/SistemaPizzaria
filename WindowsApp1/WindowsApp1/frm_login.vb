Public Class frm_login
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If txt_cpf.Text = "" Or txt_senha.Text = "" Then
                MsgBox("Campos em branco!", vbInformation + vbOKOnly, "Atenção")
            Else
                If txt_cpf.Text = "111" And txt_senha.Text = "111" Then
                    txt_cpf.Text = ""
                    txt_senha.Text = ""
                    frm_clientes.Show()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
