Public Class Principal
    Inherits DevComponents.DotNetBar.OfficeForm

    Private Sub TiposDeSangreToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form_TiposDeSangre.MdiParent = Me
        Form_TiposDeSangre.Show()
    End Sub

 

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub TiposDeLicenciaToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Form_TiposDeLicencia.MdiParent = Me

        Form_TiposDeLicencia.Show()
    End Sub

    Private Sub TiposDeComunicacionToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Form_TiposDeComunicacion.MdiParent = Me

        Form_TiposDeComunicacion.Show()
    End Sub

    Private Sub PersonasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form_Personas.MdiParent = Me

        Form_Personas.Show()
    End Sub

    Private Sub BuscarPersonasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form_Buscar_Personas.MdiParent = Me

        Form_Buscar_Personas.Show()
    End Sub

    Private Sub EmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form_Empresas.MdiParent = Me

        Form_Empresas.Show()
    End Sub

    Private Sub BuscarEmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form_Buscar_Empresas.MdiParent = Me

        Form_Buscar_Empresas.Show()
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem2_Click_1(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        Form_TiposDeSangre.MdiParent = Me
        Form_TiposDeSangre.Show()
    End Sub

    Private Sub ButtonItem3_Click(sender As Object, e As EventArgs) Handles ButtonItem3.Click
        Form_TiposDeLicencia.MdiParent = Me

        Form_TiposDeLicencia.Show()
    End Sub

    Private Sub ButtonItem4_Click(sender As Object, e As EventArgs) Handles ButtonItem4.Click
        Form_TiposDeComunicacion.MdiParent = Me

        Form_TiposDeComunicacion.Show()
    End Sub

    Private Sub ButtonItem5_Click(sender As Object, e As EventArgs) Handles ButtonItem5.Click
        Form_Buscar_Personas.MdiParent = Me

        Form_Buscar_Personas.Show()
    End Sub

    Private Sub ButtonItem6_Click(sender As Object, e As EventArgs) Handles ButtonItem6.Click
        Form_Buscar_Empresas.MdiParent = Me

        Form_Buscar_Empresas.Show()
    End Sub

    Private Sub BuscarEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonItem7_Click(sender As Object, e As EventArgs) Handles ButtonItem7.Click
        Form_Buscar_Empleados.MdiParent = Me

        Form_Buscar_Empleados.Show()
    End Sub
End Class
