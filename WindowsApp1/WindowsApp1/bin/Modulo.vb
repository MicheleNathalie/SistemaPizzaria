Module Modulo
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, diretorio, tipo As String
    Public conexao = Application.StartupPath & "\cadastro.mdb"
    Public cont As Long
    Public verifica_edicao, id_sabor As Integer
    Public id_pedido As Integer
    Public nome_funcionario As String
    Public aux, resp, nivel, nome_cliente, numero_cliente, complemento_cliente, referencia_cliente, cidade_cliente, estado_cliente, rua_cliente, bairro_cliente As String


    Sub conecta_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=" & conexao)
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
            .txt_telres.Text = ("11")
            .txt_numero.Clear()
        End With
        With frm_login
            .txtcpf.Clear()
            .txt_senha.Clear()
        End With
        With frm_pedidos
            .txt_entrega.Clear()
            .cb_entrega.Checked = False
            .txt_valor.Clear()
            .cmb_quantidade.Text = ""
            .cmb_tamanho.Text = ""
        End With
        With frm_addsabores
            .txt_descricao.Clear()
            .txt_nome.Clear()
            .txt_valor.Clear()
        End With
        With frm_adduser
            .txt_cpf.Clear()
            .txt_data.Clear()
            .txt_nome.Clear()
            .txt_senha.Clear()
        End With
    End Sub
End Module
