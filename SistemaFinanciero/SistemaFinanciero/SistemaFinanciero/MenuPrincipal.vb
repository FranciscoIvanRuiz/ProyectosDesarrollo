Public Class MenuPrincipal

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonItem6_Click(sender As Object, e As EventArgs) Handles ButtonItem6.Click
        Form_Buscar_Personas.MdiParent = Me

        Form_Buscar_Personas.Show()
    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        Form_Lista_Empleados.MdiParent = Me

        Form_Lista_Empleados.Show()
    End Sub
End Class