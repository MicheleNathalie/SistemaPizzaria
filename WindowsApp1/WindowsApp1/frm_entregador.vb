﻿Public Class frm_entregador
    Private Sub frm_entregador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EncerrarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoToolStripMenuItem.Click
        Me.Close()
        frm_login.ShowDialog()
    End Sub

    Private Sub EncerrarSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSistemaToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class