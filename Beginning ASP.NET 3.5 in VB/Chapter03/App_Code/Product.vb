Public Class Product
    Private _name As String
    Private _price As Decimal
    Private _imageUrl As String

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Event PriceChanged()

    Public Property Price() As Decimal
        Get
            Return _price
        End Get
        Set(value As Decimal)
            _price = value

            ' Fire the event to all listeners.
            RaiseEvent PriceChanged()
        End Set
    End Property

    Public Property ImageUrl() As String
        Get
            Return _imageUrl
        End Get
        Set(ByVal value As String)
            _imageUrl = value
        End Set
    End Property

    Public Function GetHtml() As String
        Dim htmlString As String
        htmlString = "<h1>" & name & "</h1><br />"
        htmlString &= "<h3>Costs: " & Price.ToString() & "</h3><br />"
        htmlString &= "<img src='" & ImageUrl & "' />"
        Return htmlString
    End Function

    Public Sub New(ByVal name As String, ByVal price As Decimal)
        _name = name
        _price = price
    End Sub

End Class

