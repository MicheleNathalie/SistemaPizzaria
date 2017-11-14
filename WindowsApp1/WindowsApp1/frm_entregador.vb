Public Class frm_entregador
    Private Sub frm_entregador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim privateFonts As New System.Drawing.Text.PrivateFontCollection()
        privateFonts.AddFontFile("C:\Users\miche\Documents\Documentos Memo\ADS\Módulo II\Sistemas de Informação\Projeto do Bertão - Pizzaria\SistemaPizzaria\WindowsApp1\WindowsApp1\bin\Debug\Fontes\Moon Flower Bold.ttf")
        Dim font As New System.Drawing.Font(privateFonts.Families(0), 22)
        ListView1.Font = font
    End Sub
End Class