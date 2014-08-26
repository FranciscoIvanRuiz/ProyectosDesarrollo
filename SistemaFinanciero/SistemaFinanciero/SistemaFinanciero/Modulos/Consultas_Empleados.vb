
Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module Consultas_Empleados
    'VARIABLES PRIVADAS
    Private _adaptador As New MySqlDataAdapter
    'VARIABLES PUBLICAS
    Public _dtsempleados, _dtstiposdesangre, _dtstiposdelicencia As New DataSet
    Public _dtvempleados As New DataView

    Public Sub CargarEmpleadosCbx()
        Try
            '_dtsciudad.Reset()
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from empleados", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtsempleados, "empleados")
            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Public Sub CargarTiposdeSangreCbx()
        Try
            '_dtsciudad.Reset()
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tiposdesangre", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtstiposdesangre, "tiposdesangre")
            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Public Sub CargarTiposdeLicenciaCbx()
        Try
            '_dtsciudad.Reset()
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tiposdelicencia", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtstiposdelicencia, "tiposdelicencia")
            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub


    Public Sub BuscarEmpleadosDgr()
        Try
            conex_Global()
            Dim dts As New DataSet
            _adaptador.SelectCommand = New MySqlCommand("SELECT empleados.id as id,   empleados.cedula as cedula,   empleados.nombre1 as nombre1,empleados.nombre2 as nombre2,   empleados.apellido1 as apellido1,   empleados.apellido2 as apellido2 , empleados.tiposdesangre_id as tiposdesangre_id , empleados.tiposdelicencia_id as tiposdelicencia_id , empleados.empresas_id as empresas_id , empleados.fechanaci,   empleados.direccion,   empleados.telefono,   empleados.fax,   empleados.celular  FROM empleados ", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(dts)
            _dtvempleados.Table = dts.Tables(0)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub


End Module
