Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class Clase_TiposDeSangre
 Private _adaptador As New MySqlDataAdapter


    Public Function Insertar_TiposDeSangre(ByVal datos As Clase_Datos_TiposDeSangre) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO tiposdesangre (tipo) values (@tipo)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@tipo", MySqlDbType.VarChar, 45).Value = datos.tipo
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



End Class
