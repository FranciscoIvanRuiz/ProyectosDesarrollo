Public Class Form_Buscar_Empresas
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    Private filtrado As String



    Private Sub Form_Buscar_Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarEmpresas()
        DGEmpresas.DataSource = _dtvempresas
        Grid_Empresas()
        t_buscar.CharacterCasing = CharacterCasing.Upper
    End Sub


    Private Sub t_buscar1_TextChanged(sender As Object, e As EventArgs)
        Try
            filtrado = "nombre"
            _dtvempresas.RowFilter = filtrado & " like '%" & t_buscar.Text & "%'"
        Catch ex As NullReferenceException

        End Try
    End Sub


    Private Sub DGEmpresas_DoubleClick(sender As Object, e As EventArgs)
        Try
            Form_Empresas.MdiParent = Principal
            Form_Empresas.Show()

            Form_Empresas.t_id.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(0).Value 'ID
            Form_Empresas.t_nombre.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(1).Value 'ID
            Form_Empresas.t_ruc.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(2).Value 'ID
            Form_Empresas.t_telefono.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(3).Value 'ID
            Form_Empresas.t_fax.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(4).Value 'ID
            Form_Empresas.t_correo.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(5).Value 'ID
            Form_Empresas.t_direccion.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(6).Value 'ID
            Form_Empresas.t_web.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(7).Value 'ID
            Form_Empresas.t_responsable.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(8).Value 'ID
            Form_Empresas.t_renta.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(9).Value 'ID
            Form_Empresas.t_iva.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(10).Value 'ID
            Me.Close()
        Catch ex As NullReferenceException

        End Try
    End Sub

    Private Sub DGEmpresas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub t_buscar_TextChanged(sender As Object, e As EventArgs) Handles t_buscar.TextChanged
        Try
            filtrado = "nombre"
            _dtvempresas.RowFilter = filtrado & " like '%" & t_buscar.Text & "%'"
        Catch ex As NullReferenceException

        End Try
    End Sub

    Private Sub DGEmpresas_DoubleClick1(sender As Object, e As EventArgs) Handles DGEmpresas.DoubleClick
        Try
            Form_Empresas.MdiParent = Principal
            Form_Empresas.Show()

            Form_Empresas.t_id.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(0).Value 'ID
            Form_Empresas.t_nombre.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(1).Value 'ID
            Form_Empresas.t_ruc.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(2).Value 'ID
            Form_Empresas.t_telefono.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(3).Value 'ID
            Form_Empresas.t_fax.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(4).Value 'ID
            Form_Empresas.t_correo.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(5).Value 'ID
            Form_Empresas.t_direccion.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(6).Value 'ID
            Form_Empresas.t_web.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(7).Value 'ID
            Form_Empresas.t_responsable.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(8).Value 'ID
            Form_Empresas.t_renta.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(9).Value 'ID
            Form_Empresas.t_iva.Text = DGEmpresas.Rows(DGEmpresas.CurrentRow.Index).Cells(10).Value 'ID
            Me.Close()
        Catch ex As NullReferenceException

        End Try
    End Sub
End Class