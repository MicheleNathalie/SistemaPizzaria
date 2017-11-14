Public Class frm_pizzaiolo
    Private Sub frm_pizzaiolo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim privateFonts As New System.Drawing.Text.PrivateFontCollection()
        privateFonts.AddFontFile(Application.StartupPath & "\Fontes\Moon Flower Bold.ttf")
        Dim font As New System.Drawing.Font(privateFonts.Families(0), 22)
        ListView1.Font = font
    End Sub
End Class