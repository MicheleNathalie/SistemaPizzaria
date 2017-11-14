Public Class frm_clientes
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
            Me.Close()
            frm_pedidos.Show()
        End If
    End Sub

    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
    End Sub
End Class