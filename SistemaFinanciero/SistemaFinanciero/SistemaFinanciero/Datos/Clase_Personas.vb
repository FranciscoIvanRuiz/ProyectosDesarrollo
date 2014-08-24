Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class Clase_Personas
    Private _adaptador As New MySqlDataAdapter


    Public Function Insertar_Personas(ByVal datos As Clase_Datos_Personas) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO personas (cedula ,  nombre1 ,  nombre2 ,  apellido1 ,  apellido2) values (@cedula ,  @nombre1 ,  @nombre2 ,  @apellido1 ,  @apellido2)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@cedula", MySqlDbType.VarChar, 45).Value = datos.cedula
            _adaptador.InsertCommand.Parameters.Add("@nombre1", MySqlDbType.VarChar, 45).Value = datos.nombre1
            _adaptador.InsertCommand.Parameters.Add("@nombre2", MySqlDbType.VarChar, 45).Value = datos.nombre2
            _adaptador.InsertCommand.Parameters.Add("@apellido1", MySqlDbType.VarChar, 45).Value = datos.apellido1
            _adaptador.InsertCommand.Parameters.Add("@apellido2", MySqlDbType.VarChar, 45).Value = datos.apellido2
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado

    End Function


    'ACTUALIZAR DATOS DE LA PERSONA
    Public Function Actualiza_Personas(ByVal datos As Clase_Datos_Personas) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE personas  SET cedula = @cedula,  nombre1 = @nombre1,   nombre2 = @nombre2,   apellido1 = @apellido1, apellido2 = @apellido2  WHERE personas.id = @id   ", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos.id
            _adaptador.UpdateCommand.Parameters.Add("@cedula", MySqlDbType.VarChar, 45).Value = datos.cedula
            _adaptador.UpdateCommand.Parameters.Add("@nombre1", MySqlDbType.VarChar, 45).Value = datos.nombre1
            _adaptador.UpdateCommand.Parameters.Add("@nombre2", MySqlDbType.VarChar, 45).Value = datos.nombre2
            _adaptador.UpdateCommand.Parameters.Add("@apellido1", MySqlDbType.VarChar, 45).Value = datos.apellido1
            _adaptador.UpdateCommand.Parameters.Add("@apellido2", MySqlDbType.VarChar, 45).Value = datos.apellido2
            _conexion.Open()
            _adaptador.UpdateCommand.Connection = _conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function


End Class
