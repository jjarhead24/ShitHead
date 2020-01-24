Public Class Deck
    Private cards As New List(Of Card)
    Private Sub Shuffle()
        Dim shuffled As New List(Of Card)
        Dim RANDOM As New Random()
        While cards.Count > 0
            Dim selected = cards(RANDOM.Next(0, cards.Count))
            cards.Remove(selected)
            shuffled.Add(selected)
        End While
        cards = shuffled
    End Sub
    Private Sub CreateNew()
        cards = New List(Of Card)
        For Each suit In [Enum].GetValues(GetType(House))
            For Each value In [Enum].GetValues(GetType(Number))
                Dim card As New Card(suit, value)
                cards.Add(card)
            Next
        Next
    End Sub
    Public Sub New()
        CreateNew()
        Shuffle()
    End Sub

    Public Function Draw() As Card
        Dim c = cards(0)
        cards.RemoveAt(0)
        Return c
    End Function
End Class
