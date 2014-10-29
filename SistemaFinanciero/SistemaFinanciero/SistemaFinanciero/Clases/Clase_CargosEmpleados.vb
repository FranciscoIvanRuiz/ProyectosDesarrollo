Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class Clase_CargosEmpleados
    Private _adaptador As New MySqlDataAdapter

    Public Function Insertar_CargosEmpleados(ByVal datos As Clase_Datos_CargosEmpleados) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO cargoempleados  (  fechai,fechas,empleados_id,departamento_id,seccion_id, cargo_id )  VALUES ( @fechai,@fechas, @empleados_id,@departamento_id, @seccion_id,@cargo_id ) ", _conexion)
           
            _adaptador.InsertCommand.Parameters.Add("@fechai", MySqlDbType.Date).Value = datos.fechai
            _adaptador.InsertCommand.Parameters.Add("@fechas", MySqlDbType.Date).Value = datos.fechas
            _adaptador.InsertCommand.Parameters.Add("@empleados_id", MySqlDbType.Int32).Value = datos.empleados_id
            _adaptador.InsertCommand.Parameters.Add("@departamento_id", MySqlDbType.Int32).Value = datos.departamento
            _adaptador.InsertCommand.Parameters.Add("@seccion_id", MySqlDbType.Int32).Value = datos.seccion
            _adaptador.InsertCommand.Parameters.Add("@cargo_id", MySqlDbType.Int32).Value = datos.cargo


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


    Public Function Actualiza_CargosEmpleados(ByVal datos As Clase_Datos_CargosEmpleados) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("update cargoempleados set fechai= @fechai, fechas=@fechas, departamento_id=@departamento_id, seccion_id= @seccion_id , cargo_id=@cargo_id  where id = @id", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos.id
            _adaptador.UpdateCommand.Parameters.Add("@fechai", MySqlDbType.Date).Value = datos.fechai
            _adaptador.UpdateCommand.Parameters.Add("@fechas", MySqlDbType.Date).Value = datos.fechas
            _adaptador.UpdateCommand.Parameters.Add("@departamento_id", MySqlDbType.Int32).Value = datos.departamento
            _adaptador.UpdateCommand.Parameters.Add("@seccion_id", MySqlDbType.Int32).Value = datos.seccion
            _adaptador.UpdateCommand.Parameters.Add("@cargo_id", MySqlDbType.Int32).Value = datos.cargo

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
