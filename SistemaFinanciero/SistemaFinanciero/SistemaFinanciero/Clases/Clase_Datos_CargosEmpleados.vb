Public Class Clase_Datos_CargosEmpleados
    Private _id As Integer
    Private _departamento As String
    Private _seccion As String
    Private _cargo As String
    Private _empleados_id As Integer
    Private _fechai As Date
    Private _fechas As Date

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Public Property departamento() As Integer
        Get
            Return _departamento
        End Get
        Set(ByVal value As Integer)
            _departamento = value
        End Set
    End Property


    Public Property seccion() As Integer
        Get
            Return _seccion
        End Get
        Set(ByVal value As Integer)
            _seccion = value
        End Set
    End Property

    Public Property cargo() As Integer
        Get
            Return _cargo
        End Get
        Set(ByVal value As Integer)
            _cargo = value
        End Set
    End Property

    Public Property empleados_id() As Integer
        Get
            Return _empleados_id
        End Get
        Set(ByVal value As Integer)
            _empleados_id = value
        End Set
    End Property


    Public Property fechai() As Date
        Get
            Return _fechai
        End Get
        Set(ByVal value As Date)
            _fechai = value
        End Set
    End Property

    Public Property fechas() As Date
        Get
            Return _fechas
        End Get
        Set(ByVal value As Date)
            _fechas = value
        End Set
    End Property


End Class
