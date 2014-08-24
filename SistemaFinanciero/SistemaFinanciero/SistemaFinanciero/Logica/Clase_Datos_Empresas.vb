Public Class Clase_Datos_Empresas
    Private _id As Integer
    Private _nombre As String
    Private _ruc As String
    Private _telefono As String
    Private _fax As String
    Private _correo As String
    Private _direccion As String
    Private _web As String
    Private _personas_id As Integer
    Private _renta As String
    Private _iva As String

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property ruc() As String
        Get
            Return _ruc
        End Get
        Set(ByVal value As String)
            _ruc = value
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

    Public Property fax() As String
        Get
            Return _fax
        End Get
        Set(ByVal value As String)
            _fax = value
        End Set
    End Property

    Public Property correo() As String
        Get
            Return _correo
        End Get
        Set(ByVal value As String)
            _correo = value
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

    Public Property web() As String
        Get
            Return _web
        End Get
        Set(ByVal value As String)
            _web = value
        End Set
    End Property

    Public Property iva() As String
        Get
            Return _iva
        End Get
        Set(ByVal value As String)
            _iva = value
        End Set
    End Property

    Public Property renta() As String
        Get
            Return _renta
        End Get
        Set(ByVal value As String)
            _renta = value
        End Set
    End Property

    Public Property personas_id() As Integer
        Get
            Return _personas_id
        End Get
        Set(ByVal value As Integer)
            _personas_id = value
        End Set
    End Property




End Class
