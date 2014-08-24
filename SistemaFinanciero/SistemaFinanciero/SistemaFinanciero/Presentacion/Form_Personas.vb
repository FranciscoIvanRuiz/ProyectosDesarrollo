Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form_Personas

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim conexion As New Clase_Personas
        Dim datos As New Clase_Datos_Personas
        Dim accion As Boolean

        datos.cedula = t_cedula.Text
        datos.nombre1 = t_nombre1.Text
        datos.nombre2 = t_nombre2.Text
        datos.apellido1 = t_apellido1.Text
        datos.apellido2 = t_apellido2.Text
        datos.id = t_id.Text

        If datos.id <> "0" Then accion = True

        If accion = False Then


            If (MsgBox("Desea Guardar el Registro?", MsgBoxStyle.YesNo, "Guardar")) = MsgBoxResult.Yes Then
                Try
                    If conexion.Insertar_Personas(datos) Then
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
            End If

        Else

            If (MsgBox("Desea Actualizar el Registro?", MsgBoxStyle.YesNo, "Actualizar")) = MsgBoxResult.Yes Then
                Try
                    datos.id = t_id.Text
                    If conexion.Actualiza_Personas(datos) Then
                        MessageBox.Show("los datos han sido actualizados", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("los datos no se han actualizados", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception

                End Try
            End If

        End If

    End Sub

    Private Sub Form_Personas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        t_cedula.CharacterCasing = CharacterCasing.Upper
        t_nombre1.CharacterCasing = CharacterCasing.Upper
        t_nombre2.CharacterCasing = CharacterCasing.Upper
        t_apellido1.CharacterCasing = CharacterCasing.Upper
        t_apellido2.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If (MsgBox("Desea salir?", MsgBoxStyle.YesNo, "Salir")) = MsgBoxResult.Yes Then
            t_cedula.Clear()
            t_nombre1.Clear()
            t_nombre2.Clear()
            t_apellido1.Clear()
            t_apellido2.Clear()
            t_id.Text = "0"
            Me.Close()
        End If
    End Sub
End Class