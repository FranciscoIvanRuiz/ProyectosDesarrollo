Public Class Clase_Datos_Empleados
    Private _id As Integer
    Private _cedula As String
    Private _nombre1 As String
    Private _nombre2 As String
    Private _apellido1 As String
    Private _apellido2 As String
    Private _empresas As Integer
    Private _tiposdelicencia As Integer
    Private _tiposdesangre As Integer

    Private _fechanaci As Date
    Private _direccion As String
    Private _telefono As String
    Private _fax As String
    Private _celular As String

    Private _pais As Integer
    Private _provincia As Integer
    Private _ciudad As Integer
    Private _comunidad As Integer



    Public Property pais() As String
        Get
            Return _pais
        End Get
        Set(ByVal value As String)
            _pais = value
        End Set
    End Property

    Public Property provincia() As String
        Get
            Return _provincia
        End Get
        Set(ByVal value As String)
            _provincia = value
        End Set
    End Property

    Public Property ciudad() As String
        Get
            Return _ciudad
        End Get
        Set(ByVal value As String)
            _ciudad = value
        End Set
    End Property

    Public Property comunidad() As String
        Get
            Return _comunidad
        End Get
        Set(ByVal value As String)
            _comunidad = value
        End Set
    End Property

    Public Property fechanaci() As Date
        Get
            Return _fechanaci
        End Get
        Set(ByVal value As Date)
            _fechanaci = value
        End Set
    End Property


    Public Property celular() As String
        Get
            Return _celular
        End Get
        Set(ByVal value As String)
            _celular = value
        End Set
    End Property


    Public Property fax() As String
        Get
            Return _fax
        End Get
        Set(ByVal value As String)
            _fax = value
        End Set
    End Property


    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property


    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property




    Public Property tiposdesangre() As Integer
        Get
            Return _tiposdesangre
        End Get
        Set(ByVal value As Integer)
            _tiposdesangre = value
        End Set
    End Property

    Public Property tiposdelicencia() As Integer
        Get
            Return _tiposdelicencia
        End Get
        Set(ByVal value As Integer)
            _tiposdelicencia = value
        End Set
    End Property

    Public Property empresas() As Integer
        Get
            Return _empresas
        End Get
        Set(ByVal value As Integer)
            _empresas = value
        End Set
    End Property



    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property cedula() As String
        Get
            Return _cedula
        End Get
        Set(ByVal value As String)
            _cedula = value
        End Set
    End Property

    Public Property nombre1() As String
        Get
            Return _nombre1
        End Get
        Set(ByVal value As String)
            _nombre1 = value
        End Set
    End Property

    Public Property nombre2() As String
        Get
            Return _nombre2
        End Get
        Set(ByVal value As String)
            _nombre2 = value
        End Set
    End Property

    Public Property apellido1() As String
        Get
            Return _apellido1
        End Get
        Set(ByVal value As String)
            _apellido1 = value
        End Set
    End Property

    Public Property apellido2() As String
        Get
            Return _apellido2
        End Get
        Set(ByVal value As String)
            _apellido2 = value
        End Set
    End Property

End Class
