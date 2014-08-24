Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module Consulta_Personas
    'VARIABLES PRIVADAS
    Private _adaptador As New MySqlDataAdapter

    'VARIABLES PUBLICAS
    Public _dtspersonas As New DataSet
    Public _dtvpersonas As New DataView



    'BUSCAR PERSONAS PARA COMBOBOX
    Public Sub CargarPersonas()
        Try
            '_dtsciudad.Reset()
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from personas", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtspersonas, "personas")
            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    'BUSCAR CLIENTES DATAGRID
    Public Sub BuscarPersonas()
        Try
            conex_Global()
            Dim dts As New DataSet
            _adaptador.SelectCommand = New MySqlCommand("SELECT personas.id as id,   personas.cedula as cedula,   personas.nombre1 as nombre1,personas.nombre2 as nombre2,   personas.apellido1 as apellido1,   personas.apellido2 as apellido2 FROM personas ", _conexion)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(dts)
            _dtvpersonas.Table = dts.Tables(0)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    'COMPORTAMIENTO DE LA GRILLA DE BUSCAR PERSONAS
    Public Sub Grid_Personas()
        Try
            With (Form_Buscar_Personas.DGPersonas)
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
