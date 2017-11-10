Module Modulo
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, diretorio As String
    Public conexao = Application.StartupPath & "\cadastro.mdb"
    Public cont As Long
    Public aux, resp, nivel As String


    Sub conecta_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=" & conexao)
            MsgBox("Conexão bem sucedida")
        Catch ex As Exception
            MsgBox("Erro de conexão")
        End Try
    End Sub
    Sub limpar()

    End Sub
End Module
