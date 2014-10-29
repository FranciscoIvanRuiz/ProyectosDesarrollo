
Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module Consultas_Empleados
    'VARIABLES PRIVADAS
    Private _adaptador As New MySqlDataAdapter
    'VARIABLES PUBLICAS
    Public _dtsempleados, _dtstiposdesangre, _dtstiposdelicencia, _dtspais, _dtsprovincia, _dtsciudad, _dtscomunidad, _dtsdepartamento, _dtsseccion, _dtscargo, _dtsrubros As New DataSet
    Public _dtvempleados, _dtvcargoempleados As New DataView

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


    Public Sub CargarPaisCbx()
        Try
            '_dtsciudad.Reset()
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from pais", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtspais, "pais")
            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub


    Public Sub CargarProvinciaCbx()
        Try
            '_dtsciudad.Reset()
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from provincia", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtsprovincia, "provincia")
            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Public Sub CargarCiudadCbx()
        Try
            '_dtsciudad.Reset()
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from ciudad", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtsciudad, "ciudad")
            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Public Sub CargarComunidadCbx()
        Try
            '_dtsciudad.Reset()
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from comunidad", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtscomunidad, "comunidad")
            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub


    Public Sub CargarDepartamentoCbx()
        Try
            '_dtsciudad.Reset()
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from departamento", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtsdepartamento, "departamento")
            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub



    Public Sub CargarSeccionCbx()
        Try
            '_dtsciudad.Reset()
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from seccion", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtsseccion, "seccion")
            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Public Sub CargarCargoCbx()
        Try
            '_dtsciudad.Reset()
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from cargo", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtscargo, "cargo")
            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Public Sub CargarRubroCbx()
        Try
            '_dtsciudad.Reset()
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from rubros", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtsrubros, "rubros")
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
            _adaptador.SelectCommand = New MySqlCommand("SELECT empleados.id as id,   empleados.cedula as cedula,   empleados.nombre1 as nombre1,empleados.nombre2 as nombre2,   empleados.apellido1 as apellido1,   empleados.apellido2 as apellido2 , empleados.tiposdesangre_id as tiposdesangre_id , empleados.tiposdelicencia_id as tiposdelicencia_id , empleados.empresas_id as empresas_id , empleados.fechanaci,   empleados.direccion,   empleados.telefono,   empleados.fax,   empleados.celular , empleados.pais_id,   empleados.ciudad_id,  empleados.provincia_id,empleados.comunidad_id   FROM empleados ", _conexion)
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


    Public Sub BuscarCargoEmpleadosDgr(id As String)
        Try
            conex_Global()
            Dim dts As New DataSet
            _adaptador.SelectCommand = New MySqlCommand("SELECT cargoempleados.id as id,cargoempleados.fechai as fechai,cargoempleados.fechas as fechas,cargoempleados.empleados_id as cedula,cargoempleados.departamento_id as departamento,cargoempleados.seccion_id as seccion,cargoempleados.cargo_id as cargo,departamento.nombre as dnombre,seccion.nombre as snombre,cargo.cargo as scargo  FROM cargoempleados, departamento, seccion, cargo  WHERE  ( departamento.id = cargoempleados.departamento_id ) and  ( seccion.id = cargoempleados.seccion_id ) and  ( cargo.id = cargoempleados.cargo_id )  and (cargoempleados.empleados_id= " + CStr(id) + ")", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(dts)
            _dtvcargoempleados.Table = dts.Tables(0)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub


End Module
