Public Class LinkClickedEventArgs
    Inherits System.EventArgs

    Private _url As String
    Public Property Url() As String
        Get
            Return _url
        End Get
        Set(ByVal value As String)
            _url = value
        End Set
    End Property

    Private _cancel As Boolean = False
    Public Property Cancel() As Boolean
        Get
            Return _cancel
        End Get
        Set(ByVal value As Boolean)
            _cancel = value
        End Set
    End Property

    Public Sub New(ByVal url As String)
        Me.Url = url
    End Sub

End Class

