Public Class Principal

    Private Sub TiposDeSangreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeSangreToolStripMenuItem.Click
        Form_TiposDeSangre.MdiParent = Me

        Form_TiposDeSangre.Show()
    End Sub

 

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub TiposDeLicenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeLicenciaToolStripMenuItem.Click

        Form_TiposDeLicencia.MdiParent = Me

        Form_TiposDeLicencia.Show()
    End Sub

    Private Sub TiposDeComunicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeComunicacionToolStripMenuItem.Click

        Form_TiposDeComunicacion.MdiParent = Me

        Form_TiposDeComunicacion.Show()
    End Sub

    Private Sub PersonasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonasToolStripMenuItem.Click
        Form_Personas.MdiParent = Me

        Form_Personas.Show()
    End Sub

    Private Sub BuscarPersonasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPersonasToolStripMenuItem.Click
        Form_Buscar_Personas.MdiParent = Me

        Form_Buscar_Personas.Show()
    End Sub

    Private Sub EmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem.Click
        Form_Empresas.MdiParent = Me

        Form_Empresas.Show()
    End Sub

    Private Sub BuscarEmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarEmpresasToolStripMenuItem.Click
        Form_Buscar_Empresas.MdiParent = Me

        Form_Buscar_Empresas.Show()
    End Sub
End Class
