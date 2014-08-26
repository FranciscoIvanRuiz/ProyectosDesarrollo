Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class Clase_Empleados
    Private _adaptador As New MySqlDataAdapter

    Public Function Insertar_Empleados(ByVal datos As Clase_Datos_Empleados) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO empleados (cedula ,  nombre1 ,  nombre2 ,  apellido1 ,  apellido2,empresas_id, tiposdesangre_id,tiposdelicencia_id,fechanaci,   direccion,   telefono,   fax,   celular  ) values (@cedula ,  @nombre1 ,  @nombre2 ,  @apellido1 ,  @apellido2,@empresas,@tiposdesangre,@tiposdelicencia,@fechanaci,   @direccion,   @telefono,   @fax,   @celular  )", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@cedula", MySqlDbType.VarChar, 45).Value = datos.cedula
            _adaptador.InsertCommand.Parameters.Add("@nombre1", MySqlDbType.VarChar, 45).Value = datos.nombre1
            _adaptador.InsertCommand.Parameters.Add("@nombre2", MySqlDbType.VarChar, 45).Value = datos.nombre2
            _adaptador.InsertCommand.Parameters.Add("@apellido1", MySqlDbType.VarChar, 45).Value = datos.apellido1
            _adaptador.InsertCommand.Parameters.Add("@apellido2", MySqlDbType.VarChar, 45).Value = datos.apellido2
            _adaptador.InsertCommand.Parameters.Add("@empresas", MySqlDbType.Int32).Value = datos.empresas
            _adaptador.InsertCommand.Parameters.Add("@tiposdesangre", MySqlDbType.Int32).Value = datos.tiposdesangre
            _adaptador.InsertCommand.Parameters.Add("@tiposdelicencia", MySqlDbType.Int32).Value = datos.tiposdelicencia

            _adaptador.InsertCommand.Parameters.Add("@fechanaci", MySqlDbType.Date).Value = datos.fechanaci
            _adaptador.InsertCommand.Parameters.Add("@direccion", MySqlDbType.VarChar, 45).Value = datos.direccion
            _adaptador.InsertCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 45).Value = datos.telefono
            _adaptador.InsertCommand.Parameters.Add("@fax", MySqlDbType.VarChar, 45).Value = datos.fax
            _adaptador.InsertCommand.Parameters.Add("@celular", MySqlDbType.VarChar, 45).Value = datos.celular

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


    Public Function Actualiza_Empleados(ByVal datos As Clase_Datos_Empleados) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE empleados  SET cedula = @cedula,  nombre1 = @nombre1,   nombre2 = @nombre2,   apellido1 = @apellido1, apellido2 = @apellido2 ,tiposdesangre_id=@tiposdesangre , tiposdelicencia_id=@tiposdelicencia , fechanaci=@fechanaci,   direccion=@direccion,   telefono=@telefono,   fax=@fax,   celular=@celular   WHERE empleados.id = @id   ", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos.id
            _adaptador.UpdateCommand.Parameters.Add("@cedula", MySqlDbType.VarChar, 45).Value = datos.cedula
            _adaptador.UpdateCommand.Parameters.Add("@nombre1", MySqlDbType.VarChar, 45).Value = datos.nombre1
            _adaptador.UpdateCommand.Parameters.Add("@nombre2", MySqlDbType.VarChar, 45).Value = datos.nombre2
            _adaptador.UpdateCommand.Parameters.Add("@apellido1", MySqlDbType.VarChar, 45).Value = datos.apellido1
            _adaptador.UpdateCommand.Parameters.Add("@apellido2", MySqlDbType.VarChar, 45).Value = datos.apellido2
            _adaptador.UpdateCommand.Parameters.Add("@tiposdesangre", MySqlDbType.Int32).Value = datos.tiposdesangre
            _adaptador.UpdateCommand.Parameters.Add("@tiposdelicencia", MySqlDbType.Int32).Value = datos.tiposdelicencia

            _adaptador.UpdateCommand.Parameters.Add("@fechanaci", MySqlDbType.Date).Value = datos.fechanaci
            _adaptador.UpdateCommand.Parameters.Add("@direccion", MySqlDbType.VarChar, 45).Value = datos.direccion
            _adaptador.UpdateCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 45).Value = datos.telefono
            _adaptador.UpdateCommand.Parameters.Add("@fax", MySqlDbType.VarChar, 45).Value = datos.fax
            _adaptador.UpdateCommand.Parameters.Add("@celular", MySqlDbType.VarChar, 45).Value = datos.celular

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
