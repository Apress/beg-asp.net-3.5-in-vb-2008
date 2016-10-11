Imports Microsoft.VisualBasic

Public Class Product
    Private _id As Integer
    Private _name As String
    Private _price As Decimal

    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property

    Public Property Price() As Decimal
        Get
            Return _price
        End Get
        Set(ByVal Value As Decimal)
            _price = Value
        End Set
    End Property

End Class

