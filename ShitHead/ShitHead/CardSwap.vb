Public Class CardSwap
    Dim HandNums As New List(Of Label) From {HandLbl1, HandLbl2, HandLbl3}
    Dim TableNums As New List(Of Label) From {TableLbl1, TableLbl2, TableLbl3}
    Dim PBList As New List(Of PictureBox) From {Table1, Table2, Table3}
    Dim PhandList As New List(Of PictureBox) From {Hand1, Hand2, Hand3}
    Public FaceDownPicList As New List(Of String)
    Public FaceDownNumList As New List(Of Integer)

    Public GennedCards As CardsStructure

    Public Function GenCards() As CardsStructure
        Dim _deck As New Deck()
        Dim struct As New CardsStructure() With {
            .Deck = _deck,
            .Other1 = New List(Of Card)(),
            .Other2 = New List(Of Card)(),
            .Other3 = New List(Of Card)(),
            .Self = New List(Of Card)()
        }
        For i As Integer = 0 To 9
            Dim card = _deck.Draw()
            struct.Self.Add(card)
        Next
        If SettingsForGame.BotsIn >= 1 Then
            For i As Integer = 0 To 9
                Dim card = _deck.Draw()
                struct.Other1.Add(card)
            Next
        End If
        If SettingsForGame.BotsIn >= 2 Then
            For i As Integer = 0 To 9
                Dim card = _deck.Draw()
                struct.Other2.Add(card)
            Next
        End If
        If SettingsForGame.BotsIn >= 3 Then
            For i As Integer = 0 To 9
                Dim card = _deck.Draw()
                struct.Other3.Add(card)
            Next
        End If
        Return struct
    End Function

    Private Sub SetTableToCard(index As Integer, c As Card)
        PBList(index).Tag = c
        PBList(index).Image = c.Image
        TableNums(index).Text = c.Text
        TableNums(index).Tag = c
    End Sub

    Private Sub SetHandToCard(index As Integer, c As Card)
        PhandList(index).Image = c.Image
        PhandList(index).Tag = c
        HandNums(index).Text = c.Text
        HandNums(index).Tag = c
    End Sub

    Private Sub card_swap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        outline1.Hide()
        outline2.Hide()
        outline3.Hide()
        outline4.Hide()
        outline5.Hide()
        outline6.Hide()

        Dim card As Card
        PBList = New List(Of PictureBox) From {Table1, Table2, Table3}
        PhandList = New List(Of PictureBox) From {Hand1, Hand2, Hand3}
        TableNums = New List(Of Label) From {TableLbl1, TableLbl2, TableLbl3}
        HandNums = New List(Of Label) From {HandLbl1, HandLbl2, HandLbl3}

        GennedCards = GenCards()

        For l = 3 To 5
            card = GennedCards.Self(l)
            SetTableToCard(l - 3, card)
        Next

        For l = 6 To 8
            card = GennedCards.Self(l)
            SetHandToCard(l - 6, card)
        Next

    End Sub

    Private Sub SetOutLines()
        outline1.Visible = firstBox.Name = Hand1.Name Or secondBox.Name = Hand1.Name
        outline2.Visible = firstBox.Name = Hand2.Name Or secondBox.Name = Hand2.Name
        outline3.Visible = firstBox.Name = Hand3.Name Or secondBox.Name = Hand3.Name
        outline4.Visible = firstBox.Name = Table1.Name Or secondBox.Name = Table1.Name
        outline5.Visible = firstBox.Name = Table2.Name Or secondBox.Name = Table2.Name
        outline6.Visible = firstBox.Name = Table3.Name Or secondBox.Name = Table3.Name
    End Sub

    Dim firstBox As PictureBox = Nothing
    Dim secondBox As PictureBox = Nothing

    Private Sub CardClicked(sender As Object, e As EventArgs) Handles Hand1.Click, Hand2.Click, Hand3.Click
        firstBox = DirectCast(sender, PictureBox)
        SetOutLines()
    End Sub

    Private Sub HandClicked(sender As Object, e As EventArgs) Handles Table1.Click, Table2.Click, Table3.Click
        secondBox = DirectCast(sender, PictureBox)
    End Sub
    Private Sub Swap()
        If firstBox IsNot Nothing AndAlso secondBox IsNot Nothing Then
            Dim temp = DirectCast(secondBox.Tag, Card)
            secondBox.Tag = firstBox.Tag
            firstBox.Tag = temp

            firstBox.Image = DirectCast(firstBox.Tag, Card).Image
            secondBox.Image = DirectCast(secondBox.Tag, Card).Image
        End If
    End Sub


    Private Sub Done_Click(sender As Object, e As EventArgs) Handles Done.Click
        GennedCards.Self = New List(Of Card)()
        For Each thing As PictureBox In PBList
            GennedCards.Self.Add(thing.Tag)
        Next
        For Each thing As PictureBox In PhandList
            GennedCards.Self.Add(thing.Tag)
        Next
        GameForm.Show()
        Me.Hide()
    End Sub
End Class