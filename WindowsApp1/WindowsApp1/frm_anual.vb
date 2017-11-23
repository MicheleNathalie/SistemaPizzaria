Public Class frm_anual
    Private Sub frm_anual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        Dim ano As String = InputBox("Digite o ano desejado para consulta: ")
    End Sub
End Class