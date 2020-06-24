Public Class frmMenu
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub BTNFormBolsas_Click(sender As Object, e As EventArgs) Handles BTNFormBolsas.Click
        BolsasSolidarias.Show()

    End Sub
End Class
