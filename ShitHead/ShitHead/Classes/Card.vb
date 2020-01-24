Public Class Card

    Public Sub New(_suit As House, _number As Number)
        Suit = _suit
        Number = _number
    End Sub

    Public Suit As House
    Public Number As Number
    Public ReadOnly Property Text As String
        Get
            If Number <= Number.Ten Then
                Return DirectCast(Number, Integer).ToString()
            Else
                Return [Enum].GetName(GetType(Number), Number).ToString()
            End If
        End Get
    End Property

    Public ReadOnly Property Image As Image
        Get
            Return My.Resources.ResourceManager.GetObject($"{Text}{Suit.ToString().Substring(0, 1)}.png")
        End Get
    End Property
End Class

