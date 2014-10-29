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
                                   drv("fax").ToString,
                                   drv("pais_id").ToString,
                                   drv("provincia_id").ToString,
                                   drv("ciudad_id").ToString,
                                   drv("comunidad_id").ToString}
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

        Try
            CargarPaisCbx()
            cbx_pais.DataSource = _dtspais.Tables("pais")
            cbx_pais.ValueMember = "id"
            cbx_pais.DisplayMember = "nombre"
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        '-----------------------------------------------------
        Try
            CargarProvinciaCbx()
            cbx_provincia.DataSource = _dtsprovincia.Tables("provincia")
            cbx_provincia.ValueMember = "id"
            cbx_provincia.DisplayMember = "nombre"
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        Try
            CargarComunidadCbx()
            cbx_comunidad.DataSource = _dtscomunidad.Tables("comunidad")
            cbx_comunidad.ValueMember = "id"
            cbx_comunidad.DisplayMember = "nombre"
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        Try
            CargarCiudadCbx()
            cbx_ciudad.DataSource = _dtsciudad.Tables("ciudad")
            cbx_ciudad.ValueMember = "id"
            cbx_ciudad.DisplayMember = "nombre"
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try


        Try
            CargarDepartamentoCbx()
            cbx_departamento.DataSource = _dtsdepartamento.Tables("departamento")
            cbx_departamento.ValueMember = "id"
            cbx_departamento.DisplayMember = "nombre"
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try


        Try
            CargarSeccionCbx()
            cbx_seccion.DataSource = _dtsseccion.Tables("seccion")
            cbx_seccion.ValueMember = "id"
            cbx_seccion.DisplayMember = "nombre"
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try



        Try
            CargarCargoCbx()
            cbx_cargo.DataSource = _dtscargo.Tables("cargo")
            cbx_cargo.ValueMember = "id"
            cbx_cargo.DisplayMember = "cargo"
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

        t_pais.Text = SuperGridControl1.GetCell(Fila, 14).Value
        cbx_pais.SelectedValue = SuperGridControl1.GetCell(Fila, 14).Value

        t_provincia.Text = SuperGridControl1.GetCell(Fila, 15).Value
        cbx_provincia.SelectedValue = SuperGridControl1.GetCell(Fila, 15).Value


        t_ciudad.Text = SuperGridControl1.GetCell(Fila, 16).Value
        cbx_ciudad.SelectedValue = SuperGridControl1.GetCell(Fila, 16).Value


        t_comunidad.Text = SuperGridControl1.GetCell(Fila, 17).Value
        cbx_comunidad.SelectedValue = SuperGridControl1.GetCell(Fila, 17).Value



        GroupPanel1.Text = t_cedula.Text + " - " + t_nombre1.Text + " " + t_nombre2.Text + " " + t_apellido1.Text + " " + t_apellido2.Text
        SuperTabItem2.Text = t_cedula.Text + " - " + t_nombre1.Text + " " + t_nombre2.Text + " " + t_apellido1.Text + " " + t_apellido2.Text

        '.................despliego cargos por empleados
        Dim panel1 As GridPanel = SuperGridControl2.PrimaryGrid


        SuperGridControl2.PrimaryGrid.ClearAll()
        panel1.Rows.Clear()

        BuscarCargoEmpleadosDgr(t_id.Text)
        SuperGridControl2.BeginUpdate()


        Dim drv As DataRowView
        Dim s As String = ""


        For Each drv In _dtvcargoempleados
            Dim ob1() As Object = {drv("id").ToString,
                                   drv("departamento").ToString,
                                   drv("seccion").ToString,
                                   drv("cargo").ToString,
                                   drv("fechai").ToString,
                                   drv("fechas").ToString,
                                   drv("cedula").ToString}
            panel1.Rows.Add(New GridRow(ob1))
        Next
        SuperGridControl2.EndUpdate()
        t_cedulaestructura.Text = t_cedula.Text
        t_idestructura.Text = t_id.Text


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

        datos.pais = t_pais.Text
        datos.provincia = t_provincia.Text
        datos.ciudad = t_ciudad.Text
        datos.comunidad = t_comunidad.Text



        If datos.id <> "0" Then accion = True

        If accion = False Then


            If (MsgBox("Desea Guardar el Registro?", MsgBoxStyle.YesNo, "Guardar")) = MsgBoxResult.Yes Then
                Try
                    If conexion.Insertar_Empleados(datos) Then
                        MessageBox.Show("Los datos han sido guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                        MessageBox.Show("Los datos han sido actualizados", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Los datos no se han actualizados", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub ComboBoxEx2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_provincia.SelectedIndexChanged
        Try
            t_provincia.Text = cbx_provincia.DataSource.rows(cbx_provincia.SelectedIndex)("id")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbx_pais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_pais.SelectedIndexChanged
        Try
            t_pais.Text = cbx_pais.DataSource.rows(cbx_pais.SelectedIndex)("id")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbx_ciudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_ciudad.SelectedIndexChanged
        Try
            t_ciudad.Text = cbx_ciudad.DataSource.rows(cbx_ciudad.SelectedIndex)("id")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbx_comunidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_comunidad.SelectedIndexChanged
        Try
            t_comunidad.Text = cbx_comunidad.DataSource.rows(cbx_comunidad.SelectedIndex)("id")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
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
        t_id.Text = "0"

    End Sub

    Private Sub cbx_departamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_departamento.SelectedIndexChanged
        Try
            t_departamento.Text = cbx_departamento.DataSource.rows(cbx_departamento.SelectedIndex)("id")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbx_seccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_seccion.SelectedIndexChanged
        Try
            t_seccion.Text = cbx_seccion.DataSource.rows(cbx_seccion.SelectedIndex)("id")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbx_cargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_cargo.SelectedIndexChanged
        Try
            t_cargo.Text = cbx_cargo.DataSource.rows(cbx_cargo.SelectedIndex)("id")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        Dim conexion As New Clase_CargosEmpleados
        Dim datos As New Clase_Datos_CargosEmpleados
        Dim accion As Boolean

        datos.empleados_id = t_idestructura.Text
        datos.departamento = t_departamento.Text
        datos.seccion = t_seccion.Text
        datos.cargo = t_cargo.Text
        datos.fechai = t_fechai.Text

        If t_fechas.Text <> "" Then datos.fechas = t_fechas.Text
        datos.id = t_ides.Text


        If datos.id <> "0" Then accion = True

        If accion = False Then


            If (MsgBox("Desea Guardar el Registro?", MsgBoxStyle.YesNo, "Guardar")) = MsgBoxResult.Yes Then
                Try
                    If conexion.Insertar_CargosEmpleados(datos) Then
                        MessageBox.Show("Los datos han sido guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se pudieron guardar los datos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                End Try


            End If

        Else

            If (MsgBox("Desea Actualizar el Registro?", MsgBoxStyle.YesNo, "Actualizar")) = MsgBoxResult.Yes Then
                Try
                    datos.id = t_ides.Text
                    If conexion.Actualiza_CargosEmpleados(datos) Then
                        MessageBox.Show("Los datos han sido actualizados", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Los datos no se han actualizados", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception

                End Try



            End If

        End If

    End Sub




    Private Sub SuperGridControl2_RowClick(sender As Object, e As GridRowClickEventArgs) Handles SuperGridControl2.RowClick
        Dim panel As GridPanel = SuperGridControl2.PrimaryGrid
        Dim Fila As Integer
        Fila = e.GridRow.Index
        t_ides.Text = SuperGridControl2.GetCell(Fila, 0).Value

        t_departamento.Text = SuperGridControl2.GetCell(Fila, 1).Value
        cbx_departamento.SelectedValue = SuperGridControl2.GetCell(Fila, 1).Value

        t_seccion.Text = SuperGridControl2.GetCell(Fila, 2).Value
        cbx_seccion.SelectedValue = SuperGridControl2.GetCell(Fila, 2).Value

        t_cargo.Text = SuperGridControl2.GetCell(Fila, 3).Value
        cbx_cargo.SelectedValue = SuperGridControl2.GetCell(Fila, 3).Value




        t_fechai.Text = SuperGridControl2.GetCell(Fila, 4).Value
        t_fechas.Text = SuperGridControl2.GetCell(Fila, 5).Value

        
    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        t_ides.Text = "0"
        t_fechai.Text = ""
        t_fechas.Text = ""
    End Sub
End Class