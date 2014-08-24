Public Class Clase_Datos_Personas
    
    Private _id As Integer
    Private _cedula As String
    Private _nombre1 As String
    Private _nombre2 As String
    Private _apellido1 As String
    Private _apellido2 As String


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
