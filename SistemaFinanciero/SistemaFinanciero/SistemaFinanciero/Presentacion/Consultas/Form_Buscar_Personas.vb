Public Class Form_Buscar_Personas
    Private filtrado As String


    Private Sub t_buscar_TextChanged(sender As Object, e As EventArgs) Handles t_buscar.TextChanged
        Try
            filtrado = "nombre1"
            _dtvpersonas.RowFilter = filtrado & " like '%" & t_buscar.Text & "%'"
        Catch ex As NullReferenceException

        End Try
    End Sub

    Private Sub Form_Buscar_Personas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarPersonas()
        DGPersonas.DataSource = _dtvpersonas
        Grid_Personas()
        t_buscar.CharacterCasing = CharacterCasing.Upper
    End Sub

   



    Private Sub DGPersonas_DoubleClick(sender As Object, e As EventArgs) Handles DGPersonas.DoubleClick
        Try
            Form_Personas.MdiParent = Principal
            Form_Personas.Show()
            Form_Personas.t_id.Text = DGPersonas.Rows(DGPersonas.CurrentRow.Index).Cells(0).Value 'ID
            Form_Personas.t_cedula.Text = DGPersonas.Rows(DGPersonas.CurrentRow.Index).Cells(1).Value 'ID
            Form_Personas.t_nombre1.Text = DGPersonas.Rows(DGPersonas.CurrentRow.Index).Cells(2).Value 'ID
            Form_Personas.t_nombre2.Text = DGPersonas.Rows(DGPersonas.CurrentRow.Index).Cells(3).Value 'ID
            Form_Personas.t_apellido1.Text = DGPersonas.Rows(DGPersonas.CurrentRow.Index).Cells(4).Value 'ID
            Form_Personas.t_apellido2.Text = DGPersonas.Rows(DGPersonas.CurrentRow.Index).Cells(5).Value 'ID
            Me.Close()
        Catch ex As NullReferenceException

        End Try
    End Sub



    Private Sub DGPersonas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPersonas.CellContentClick

    End Sub
End Class