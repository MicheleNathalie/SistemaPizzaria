Public Class frm_mensal
    Private Sub frm_mensal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        Dim ano As String = InputBox("Digite o mês desejado para consulta: ")
    End Sub
End Class