Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar.SuperGrid

Public Class Form_Lista_Empleados


    Private Sub Form_Lista_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
       
        t_cedula.CharacterCasing = CharacterCasing.Upper
        t_nombre1.CharacterCasing = CharacterCasing.Upper
        t_nombre2.CharacterCasing = CharacterCasing.Upper
        t_apellido1.CharacterCasing = CharacterCasing.Upper
        t_apellido2.CharacterCasing = CharacterCasing.Upper
        t_direccion.CharacterCasing = CharacterCasing.Upper
        t_telefono.CharacterCasing = CharacterCasing.Upper
        t_celular.CharacterCasing = CharacterCasing.Upper
        t_fax.CharacterCasing = CharacterCasing.Upper

        '...........recorrer el BuscarEmpleadosDgr - 
        Dim panel As GridPanel = SuperGridControl1.PrimaryGrid
        SuperGridControl1.BeginUpdate()

        Dim drv As DataRowView
        Dim s As String = ""
        BuscarEmpleadosDgr()

        For Each drv In _dtvempleados
            Dim ob1() As Object = {drv("id").ToString,
                                   drv("cedula").ToString,
                                   drv("nombre1").ToString,
                                   drv("nombre2").ToString,
                                   drv("apellido1").ToString,
                                   drv("apellido2").ToString,
                                   drv("empresas_id").ToString,
                                   drv("tiposdesangre_id").ToString,
                                   drv("tiposdelicencia_id").ToString,
                                   drv("fechanaci").ToString,
                                   drv("direccion").ToString,
                                   drv("telefono").ToString,
                                   drv("celular").ToString,
                                   drv("fax").ToString}
            panel.Rows.Add(New GridRow(ob1))
        Next
        SuperGridControl1.EndUpdate()


        Try
            CargarEmpresas()
            cbx_empresas.DataSource = _dtsempresas.Tables("empresas")
            cbx_empresas.ValueMember = "id"
            cbx_empresas.DisplayMember = "nombre"
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        Try
            CargarTiposdeLicenciaCbx()
            cbx_tiposdelicencia.DataSource = _dtstiposdelicencia.Tables("tiposdelicencia")
            cbx_tiposdelicencia.ValueMember = "id"
            cbx_tiposdelicencia.DisplayMember = "tipo"
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        Try
            CargarTiposdeSangreCbx()
            cbx_tiposdesangre.DataSource = _dtstiposdesangre.Tables("tiposdesangre")
            cbx_tiposdesangre.ValueMember = "id"
            cbx_tiposdesangre.DisplayMember = "tipo"
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try


        
    End Sub

    

   

    Private Sub SuperGridControl1_RowClick(sender As Object, e As GridRowClickEventArgs) Handles SuperGridControl1.RowClick
        Dim panel As GridPanel = SuperGridControl1.PrimaryGrid
        Dim Fila As Integer
        Fila = e.GridRow.Index
        'MsgBox(SuperGridControl1.GetCell(Fila, 1).Value)
        t_id.Text = SuperGridControl1.GetCell(Fila, 0).Value
        t_cedula.Text = SuperGridControl1.GetCell(Fila, 1).Value
        t_nombre1.Text = SuperGridControl1.GetCell(Fila, 2).Value
        t_nombre2.Text = SuperGridControl1.GetCell(Fila, 3).Value
        t_apellido1.Text = SuperGridControl1.GetCell(Fila, 4).Value
        t_apellido2.Text = SuperGridControl1.GetCell(Fila, 5).Value

        t_empresas.Text = SuperGridControl1.GetCell(Fila, 6).Value
        cbx_empresas.SelectedValue = SuperGridControl1.GetCell(Fila, 6).Value

        t_tiposdesangre.Text = SuperGridControl1.GetCell(Fila, 7).Value
        cbx_tiposdesangre.SelectedValue = SuperGridControl1.GetCell(Fila, 7).Value

        t_tiposdelicencia.Text = SuperGridControl1.GetCell(Fila, 8).Value
        cbx_tiposdelicencia.SelectedValue = SuperGridControl1.GetCell(Fila, 8).Value

        t_fechanaci.Text = SuperGridControl1.GetCell(Fila, 9).Value
        t_direccion.Text = SuperGridControl1.GetCell(Fila, 10).Value
        t_telefono.Text = SuperGridControl1.GetCell(Fila, 11).Value
        t_celular.Text = SuperGridControl1.GetCell(Fila, 12).Value
        t_fax.Text = SuperGridControl1.GetCell(Fila, 13).Value

        GroupPanel1.Text = t_cedula.Text + " - " + t_nombre1.Text + " " + t_nombre2.Text + " " + t_apellido1.Text + " " + t_apellido2.Text


    End Sub

    Private Sub SuperGridControl1_Click(sender As Object, e As EventArgs) Handles SuperGridControl1.Click

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim conexion As New Clase_Empleados
        Dim datos As New Clase_Datos_Empleados
        Dim accion As Boolean

        datos.cedula = t_cedula.Text
        datos.nombre1 = t_nombre1.Text
        datos.nombre2 = t_nombre2.Text
        datos.apellido1 = t_apellido1.Text
        datos.apellido2 = t_apellido2.Text
        datos.id = t_id.Text
        datos.empresas = t_empresas.Text
        datos.tiposdesangre = t_tiposdesangre.Text
        datos.tiposdelicencia = t_tiposdelicencia.Text

        datos.fechanaci = t_fechanaci.Text
        datos.direccion = t_direccion.Text
        datos.telefono = t_telefono.Text
        datos.celular = t_celular.Text
        datos.fax = t_fax.Text

        If datos.id <> "0" Then accion = True

        If accion = False Then


            If (MsgBox("Desea Guardar el Registro?", MsgBoxStyle.YesNo, "Guardar")) = MsgBoxResult.Yes Then
                Try
                    If conexion.Insertar_Empleados(datos) Then
                        MessageBox.Show("los datos han sido guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se pudieron guardar los datos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                End Try
                t_cedula.Clear()
                t_nombre1.Clear()
                t_nombre2.Clear()
                t_apellido1.Clear()
                t_apellido2.Clear()
                t_fechanaci.Text = ""
                t_direccion.Clear()
                t_telefono.Clear()
                t_celular.Clear()
                t_fax.Clear()

            End If

        Else

            If (MsgBox("Desea Actualizar el Registro?", MsgBoxStyle.YesNo, "Actualizar")) = MsgBoxResult.Yes Then
                Try
                    datos.id = t_id.Text
                    If conexion.Actualiza_Empleados(datos) Then
                        MessageBox.Show("los datos han sido actualizados", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("los datos no se han actualizados", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception

                End Try

                t_cedula.Clear()
                t_nombre1.Clear()
                t_nombre2.Clear()
                t_apellido1.Clear()
                t_apellido2.Clear()
                t_fechanaci.Text = ""
                t_direccion.Clear()
                t_telefono.Clear()
                t_celular.Clear()
                t_fax.Clear()

            End If

        End If

    End Sub

    Private Sub cbx_empresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_empresas.SelectedIndexChanged
        Try
            t_empresas.Text = cbx_empresas.DataSource.rows(cbx_empresas.SelectedIndex)("id")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbx_tiposdesangre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tiposdesangre.SelectedIndexChanged
        Try
            t_tiposdesangre.Text = cbx_tiposdesangre.DataSource.rows(cbx_tiposdesangre.SelectedIndex)("id")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbx_tiposdelicencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tiposdelicencia.SelectedIndexChanged
        Try
            t_tiposdelicencia.Text = cbx_tiposdelicencia.DataSource.rows(cbx_tiposdelicencia.SelectedIndex)("id")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class