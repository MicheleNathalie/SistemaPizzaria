Module Modulo
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, diretorio, tipo As String
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
        With frm_clientes
            .txt_bairro.Clear()
            .txt_cidade.Clear()
            .txt_comp.Clear()
            .txt_estado.Text = ("SP")
            .txt_referencia.Clear()
            .txt_rua.Clear()
            .txt_telres.Text = ("(11)")
            .txt_numero.Clear()
        End With
        With frm_login
            .txt_cpf.Clear()
            .txt_senha.Clear()
        End With
        With frm_pedidos
            .txt_entrega.Clear()
            .clb_sabores.ClearSelected()
            .cb_entrega.Checked = False
            .txt_valor.Clear()
            .cmb_quantidade.Text = ""
            .cmb_tamanho.SelectedIndex = 2
        End With
    End Sub
End Module
