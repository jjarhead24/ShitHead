Public Class card_swap
    Dim playerCards As New List(Of Card)
    Dim SpareCards As New List(Of Card)
    Dim Comp1Cards As New List(Of Card)
    Private Sub card_swap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CardVal As String
        Dim card As Card
        Dim PBList As New List(Of PictureBox) From {Table1, Table2, Table3}
        Dim PhandList As New List(Of PictureBox) From {Hand1, Hand2, Hand3}


        Dim ReturnedLists = Card.GenCards()
        playerCards = ReturnedLists.Item1
        SpareCards = ReturnedLists.Item2
        Comp1Cards = ReturnedLists.Item3

        Dim l As Integer
        For l = 3 To 5


            card = playerCards(l)
            CardVal = "_" + card.Type + card.Suit
            PBList(l - 3).Image = My.Resources.ResourceManager.GetObject(CardVal)
            PBList(l - 3).Tag = card.Number


        Next

        For l = 6 To 8
            card = playerCards(l)
            CardVal = "_" + card.Type + card.Suit
            PHandList(l - 6).Image = My.Resources.ResourceManager.GetObject(CardVal)
            PHandList(l - 6).Tag = card.Number
        Next

    End Sub
End Class