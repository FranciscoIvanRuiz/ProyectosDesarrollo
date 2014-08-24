Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form_Empresas

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If (MsgBox("Desea salir?", MsgBoxStyle.YesNo, "Salir")) = MsgBoxResult.Yes Then
            t_ruc.Clear()
            t_nombre.Clear()
            t_telefono.Clear()
            t_correo.Clear()
            t_direccion.Clear()
            t_web.Clear()
            t_renta.Clear()
            t_iva.Clear()
            t_fax.Clear()
            t_id.Text = "0"
            t_responsable.Text = "0"
            Me.Close()
        End If
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim conexion As New Clase_Empresas
        Dim datos As New Clase_Datos_Empresas
        Dim accion As Boolean

        datos.ruc = t_ruc.Text
        datos.nombre = t_nombre.Text
        datos.telefono = t_telefono.Text
        datos.correo = t_correo.Text
        datos.direccion = t_direccion.Text
        datos.id = t_id.Text
        datos.web = t_web.Text
        datos.renta = t_renta.Text
        datos.iva = t_iva.Text
        datos.personas_id = t_responsable.Text
        datos.fax = t_fax.Text

        If datos.id <> "0" Then accion = True

        If accion = False Then


            If (MsgBox("Desea Guardar el Registro?", MsgBoxStyle.YesNo, "Guardar")) = MsgBoxResult.Yes Then
                Try
                    If conexion.Insertar_Empresas(datos) Then
                        MessageBox.Show("los datos han sido guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se pudieron guardar los datos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                End Try
                t_ruc.Clear()
                t_nombre.Clear()
                t_telefono.Clear()
                t_correo.Clear()
                t_direccion.Clear()
                t_web.Clear()
                t_renta.Clear()
                t_iva.Clear()
                t_id.Text = "0"
                t_responsable.Text = "0"
                t_fax.Clear()
            End If

        Else

            If (MsgBox("Desea Actualizar el Registro?", MsgBoxStyle.YesNo, "Actualizar")) = MsgBoxResult.Yes Then
                Try
                    datos.id = t_id.Text
                    If conexion.Actualiza_Empresas(datos) Then
                        MessageBox.Show("los datos han sido actualizados", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("los datos no se han actualizados", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception

                End Try
            End If

        End If

    End Sub

    Private Sub Form_Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            
            CargarPersonas()
            cbx_responsable.DataSource = _dtspersonas.Tables("personas")
            cbx_responsable.DisplayMember = "cedula"
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub cbx_responsable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_responsable.SelectedIndexChanged
        Try
            t_responsable.Text = cbx_responsable.DataSource.rows(cbx_responsable.SelectedIndex)("id")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class