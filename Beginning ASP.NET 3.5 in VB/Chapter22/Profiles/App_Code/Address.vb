
<Serializable()> _
Public Class Address

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _street As String
    Public Property Street() As String
        Get
            Return _street
        End Get
        Set(ByVal value As String)
            _street = value
        End Set
    End Property

    Private _city As String
    Public Property City() As String
        Get
            Return _city
        End Get
        Set(ByVal value As String)
            _city = value
        End Set
    End Property

    Private _zipCode As String
    Public Property ZipCode() As String
        Get
            Return _zipCode
        End Get
        Set(ByVal value As String)
            _zipCode = value
        End Set
    End Property


    Private _state As String
    Public Property State() As String
        Get
            Return _state
        End Get
        Set(ByVal value As String)
            _state = value
        End Set
    End Property

    Private _country As String
    Public Property Country() As String
        Get
            Return _country
        End Get
        Set(ByVal value As String)
            _country = value
        End Set
    End Property

    Public Sub New(ByVal name As String, ByVal street As String, _
    ByVal city As String, ByVal zipCode As String, ByVal state As String, _
    ByVal country As String)

        Me.Name = name
        Me.Street = street
        Me.City = city
        Me.ZipCode = zipCode
        Me.State = state
        Me.Country = country
    End Sub

    Public Sub New()
    End Sub

End Class

