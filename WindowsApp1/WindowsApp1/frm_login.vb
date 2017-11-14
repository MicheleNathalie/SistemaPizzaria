Public Class frm_login
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If txt_cpf.Text = "" Or txt_senha.Text = "" Then
                'refinar isso se der tempo
                MsgBox("Campos em branco!", vbInformation + vbOKOnly, "Atenção")
                txt_cpf.Focus()
                Exit Sub
            Else
                sql = "select * from tb_login where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(sql)
                If rs.BOF = True Then
                    MsgBox("Conta não cadastrada!", vbExclamation + vbOKOnly, "Erro")
                    limpar()
                    ' fazer a parte de cadastro para o gerente-sama
                    ' Cadastro.ShowDialog()
                    ' Me.Hide()
                    Exit Sub
                Else
                    If txt_cpf.Text = rs.Fields(1).Value Then
                        sql = "select * from tb_login where senha='" & txt_senha.Text & "'"
                        If txt_senha.Text = rs.Fields(3).Value Then
                            MsgBox("Acesso permitido!", vbOKOnly, "Bem vindo")
                            tipo = rs.Fields(4).Value
                            If tipo = "Vendedor" Then
                                frm_clientes.ShowDialog()
                                Me.Hide()
                                limpar()
                                '  Exit Sub
                            End If
                            If tipo = "Pizzaiolo" Then
                                frm_pizzaiolo.ShowDialog()
                                Me.Hide()
                                limpar()
                                ' Exit Sub
                            End If
                            If tipo = "Entregador" Then
                                frm_entregador.ShowDialog()
                                Me.Hide()
                                limpar()
                                Exit Sub
                            End If
                            If tipo = "Gerente" Then
                                frm_gerente.ShowDialog()
                                Me.Hide()
                                limpar()
                                Exit Sub
                            End If

                        Else
                            MsgBox("Usuário correto e senha  errada")
                            txt_senha.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro!!")
        End Try
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim privateFonts As New System.Drawing.Text.PrivateFontCollection()
        privateFonts.AddFontFile(Application.StartupPath & "\Fontes\Moon Flower Bold.ttf")
        Dim font As New System.Drawing.Font(privateFonts.Families(0), 22)
        Dim font2 As New System.Drawing.Font(privateFonts.Families(0), 25)
        Label1.Font = font2
        Label2.Font = font2
        gb_login.Font = font
        btn_entrar.Font = font
        txt_cpf.Font = font
        txt_senha.Font = font
        conecta_banco()
    End Sub
End Class
