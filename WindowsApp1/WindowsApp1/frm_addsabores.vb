Public Class frm_addsabores
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If txt_nome.Text = "" Or txt_valor.Text = "" Or txt_descricao.Text = "" Or cmb_tipo.Text = "" Then
            MsgBox("Campos em branco", vbInformation + vbOKOnly, "Atenção")
        Else

        End If
    End Sub

    Private Sub frm_addsabores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cmb_tipo.Items
            .Add("Pizza")
            .Add("Borda")
        End With
    End Sub
End Class