Public Class frm_clientes
    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txt_telres.Text = "(11)"
        txt_cidade.Clear()
        txt_bairro.Clear()
        txt_comp.Clear()
        txt_estado.Text = "SP"
        txt_referencia.Clear()
        txt_rua.Clear()
    End Sub

    Private Sub btn_seguir_Click(sender As Object, e As EventArgs) Handles btn_seguir.Click
        If txt_telres.Text = "(11)" Or txt_telres.Text = "" Or txt_estado.Text = "" Or txt_bairro.Text = "" Or txt_cidade.Text = "" Or txt_comp.Text = "" Or txt_referencia.Text = "" Or txt_rua.Text = "" Then
            MsgBox("Campos em branco!", vbInformation + vbOKOnly, "Atenção")
        Else
            Me.Close()
            frm_pedidos.Show()
        End If
    End Sub

    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim privateFonts As New System.Drawing.Text.PrivateFontCollection()
        privateFonts.AddFontFile("C:\Users\miche\Documents\Documentos Memo\ADS\Módulo II\Sistemas de Informação\Projeto do Bertão - Pizzaria\SistemaPizzaria\WindowsApp1\WindowsApp1\bin\Debug\Fontes\Moon Flower Bold.ttf")
        Dim font As New System.Drawing.Font(privateFonts.Families(0), 22)
        Dim font2 As New System.Drawing.Font(privateFonts.Families(0), 25)
        Label1.Font = font2
        Label2.Font = font2
        Label3.Font = font2
        Label4.Font = font2
        Label5.Font = font2
        Label6.Font = font2
        Label7.Font = font2
        txt_bairro.Font = font
        txt_cidade.Font = font
        txt_comp.Font = font
        txt_estado.Font = font
        txt_referencia.Font = font
        txt_rua.Font = font
        txt_telres.Font = font
        btn_seguir.Font = font
        btn_limpar.Font = font
    End Sub
End Class