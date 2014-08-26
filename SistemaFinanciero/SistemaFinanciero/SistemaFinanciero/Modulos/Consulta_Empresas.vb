Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module Consulta_Empresas
    'VARIABLES PRIVADAS
    Private _adaptador As New MySqlDataAdapter

    'VARIABLES PUBLICAS
    Public _dtsempresas As New DataSet
    Public _dtvempresas As New DataView



    'BUSCAR PERSONAS PARA COMBOBOX
    Public Sub CargarEmpresas()
        Try
            '_dtsciudad.Reset()
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from empresas", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtsempresas, "empresas")
            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    'BUSCAR CLIENTES DATAGRID
    Public Sub BuscarEmpresas()
        Try
            conex_Global()
            Dim dts As New DataSet
            _adaptador.SelectCommand = New MySqlCommand("SELECT empresas.id as id,empresas.nombre as nombre,empresas.ruc as ruc,empresas.telefono as telefono,empresas.fax as fax,empresas.correo as correo,empresas.direccion as direccion,empresas.web as web,empresas.personas_id as responsable,empresas.renta as renta,empresas.iva as iva FROM empresas ", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(dts)
            _dtvempresas.Table = dts.Tables(0)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    'COMPORTAMIENTO DE LA GRILLA DE BUSCAR PERSONAS
    Public Sub Grid_Empresas()
        Try
            With (Form_Buscar_Empresas.DGEmpresas)
                .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                .DefaultCellStyle.BackColor = Color.White
            End With
            ' Form_Buscar_Personas.DGPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            'Form_Buscar_Personas.DGPersonas.ColumnHeadersHeight = 30
            'Form_Buscar_Personas.DGPersonas.Columns(0).Visible = False
            'Form_Buscar_Personas.DGPersonas.Columns(1).Width = 150
            'Form_Buscar_Personas.DGPersonas.Columns(2).Width = 300
            'Form_Buscar_Personas.DGPersonas.Columns(3).Visible = False
            'Form_Buscar_Personas.DGPersonas.Columns(4).Visible = False
            'Form_Buscar_Personas.DGPersonas.Columns(5).Visible = False
            'Form_Buscar_Personas.DGPersonas.Columns(6).Visible = False
            'Form_Buscar_Personas.DGPersonas.Columns(7).Visible = False
            'Form_Buscar_Personas.DGPersonas.Columns(8).Width = 158

        Catch ex As NullReferenceException
            MessageBox.Show(ex.Message)
        End Try


    End Sub

End Module
