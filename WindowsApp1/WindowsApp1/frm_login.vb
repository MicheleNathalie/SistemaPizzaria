Public Class frm_login
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If txtcpf.Text = "" Or txt_senha.Text = "" Then
                'refinar isso se der tempo
                MsgBox("Campos em branco!", vbInformation + vbOKOnly, "Atenção")
                txtcpf.Focus()
                Exit Sub
            Else
                sql = "select * from tb_login where cpf='" & txtcpf.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = True Then
                    MsgBox("Conta não cadastrada!", vbExclamation + vbOKOnly, "Erro")
                    Exit Sub
                Else
                    If txtcpf.Text = rs.Fields(0).Value Then
                        sql = "select * from tb_login where senha='" & txt_senha.Text & "'"
                        If txt_senha.Text = rs.Fields(2).Value Then
                            MsgBox("Acesso permitido!", vbOKOnly, "Bem vindo")
                            nome_funcionario = rs.Fields(1).Value
                            tipo = rs.Fields(3).Value
                            If tipo = "Vendedor" Then
                                frm_clientes.ShowDialog()
                                limpar()
                                Me.Hide()
                            End If
                            If tipo = "Pizzaiolo" Then
                                frm_pizzaiolo.ShowDialog()
                                Me.Hide()
                            End If
                            If tipo = "Entregador" Then
                                frm_entregador.ShowDialog()
                                Me.Hide()
                                Exit Sub
                            End If
                            If tipo = "Gerente" Then
                                frm_gerente.ShowDialog()
                                Me.Hide()
                                Exit Sub
                            End If

                        Else
                            MsgBox("Senha incorreta", vbExclamation + vbOKOnly, "Erro")
                            txt_senha.Focus()
                        End If
                    Else
                        MsgBox("CPF incorreto", vbInformation + vbOKOnly, "Erro")
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox("Erro!", vbExclamation + vbOKOnly)
        End Try

        txtcpf.Clear()
        txt_senha.Clear()

    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Dim privateFonts As New System.Drawing.Text.PrivateFontCollection()
        ' privateFonts.AddFontFile(Application.StartupPath & "\Fontes\Moon Flower Bold.ttf")
        'Dim font As New System.Drawing.Font(privateFonts.Families(0), 22)
        'Dim font2 As New System.Drawing.Font(privateFonts.Families(0), 25)
        'Label1.Font = font2
        'Label2.Font = font2
        'gb_login.Font = Font
        'btn_entrar.Font = Font
        'txt_cpf.Font = Font
        'txt_senha.Font = Font
        conecta_banco()
    End Sub
End Class
