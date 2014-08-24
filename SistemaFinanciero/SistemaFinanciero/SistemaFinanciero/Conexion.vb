Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module Conexion
    'VARIABLE CADENA 
    Public _cadena As String
    'VARIABLE DE CONEXION
    Public _conexion As New MySqlConnection

    'CONEXION GLOBAL 
    Public Sub conex_Global()
        Try
            _cadena = ("server=localhost;user id=root;password=1980;database=sistemajava")
            _conexion = New MySqlConnection(_cadena)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'CERRAR CONEXION GLOBAL
    Public Sub cerrar()
        _conexion.Close()
    End Sub
End Module
