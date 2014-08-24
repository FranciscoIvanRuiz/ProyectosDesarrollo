Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class Clase_Empresas
    Private _adaptador As New MySqlDataAdapter


    Public Function Insertar_Empresas(ByVal datos As Clase_Datos_Empresas) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO empresas(nombre, ruc, telefono,fax, correo, direccion,web,personas_id, renta,iva )VALUES (@nombre,@ruc, @telefono,@fax, @correo, @direccion,@web, @personas_id,@renta, @iva )", _conexion)


            _adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos.nombre
            _adaptador.InsertCommand.Parameters.Add("@ruc", MySqlDbType.VarChar, 45).Value = datos.ruc
            _adaptador.InsertCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 45).Value = datos.telefono
            _adaptador.InsertCommand.Parameters.Add("@fax", MySqlDbType.VarChar, 45).Value = datos.fax
            _adaptador.InsertCommand.Parameters.Add("@correo", MySqlDbType.VarChar, 45).Value = datos.correo
            _adaptador.InsertCommand.Parameters.Add("@direccion", MySqlDbType.VarChar, 45).Value = datos.direccion
            _adaptador.InsertCommand.Parameters.Add("@web", MySqlDbType.VarChar, 45).Value = datos.web
            _adaptador.InsertCommand.Parameters.Add("@personas_id", MySqlDbType.Int32, 45).Value = datos.personas_id
            _adaptador.InsertCommand.Parameters.Add("@renta", MySqlDbType.VarChar, 45).Value = datos.renta
            _adaptador.InsertCommand.Parameters.Add("@iva", MySqlDbType.VarChar, 45).Value = datos.iva

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
    Public Function Actualiza_Empresas(ByVal datos As Clase_Datos_Empresas) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE empresas SET nombre = @nombre, ruc = @ruc, telefono = @telefono, fax = @fax, correo = @correo, direccion = @direccion, web = @web, personas_id = @personas_id, renta = @renta, iva = @iva WHERE empresas.id = @id ", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos.id
            _adaptador.UpdateCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos.nombre
            _adaptador.UpdateCommand.Parameters.Add("@ruc", MySqlDbType.VarChar, 45).Value = datos.ruc
            _adaptador.UpdateCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 45).Value = datos.telefono
            _adaptador.UpdateCommand.Parameters.Add("@fax", MySqlDbType.VarChar, 45).Value = datos.fax
            _adaptador.UpdateCommand.Parameters.Add("@correo", MySqlDbType.VarChar, 45).Value = datos.correo
            _adaptador.UpdateCommand.Parameters.Add("@direccion", MySqlDbType.VarChar, 45).Value = datos.direccion
            _adaptador.UpdateCommand.Parameters.Add("@web", MySqlDbType.VarChar, 45).Value = datos.web
            _adaptador.UpdateCommand.Parameters.Add("@personas_id", MySqlDbType.Int32, 45).Value = datos.personas_id
            _adaptador.UpdateCommand.Parameters.Add("@renta", MySqlDbType.VarChar, 45).Value = datos.renta
            _adaptador.UpdateCommand.Parameters.Add("@iva", MySqlDbType.VarChar, 45).Value = datos.iva

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
