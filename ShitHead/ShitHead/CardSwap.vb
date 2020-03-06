Public Class card_swap
    Dim playerCards As New List(Of Card)
    Public SpareCards As New List(Of Card)
    Public Comp1Cards As New List(Of Card)
    Public Comp2Cards As New List(Of Card)
    Public Comp3Cards As New List(Of Card)
    Dim card1 As String
    Dim card2 As String
    Dim HandNums As New List(Of Label) From {HandLbl1, HandLbl2, HandLbl3}
    Dim TableNums As New List(Of Label) From {TableLbl1, TableLbl2, TableLbl3}
    Public FaceDownPicList As New List(Of String)
    Public FaceDownNumList As New List(Of Integer)
    Private Sub card_swap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        outline1.Hide()
        outline2.Hide()
        outline3.Hide()
        outline4.Hide()
        outline5.Hide()
        outline6.Hide()



        Dim CardVal As String
        Dim card As Card
        Dim PBList As New List(Of PictureBox) From {Table1, Table2, Table3}
        Dim PhandList As New List(Of PictureBox) From {Hand1, Hand2, Hand3}
        TableNums = New List(Of Label) From {TableLbl1, TableLbl2, TableLbl3}
        HandNums = New List(Of Label) From {HandLbl1, HandLbl2, HandLbl3}

        Dim ReturnedLists = card.GenCards()
        playerCards = ReturnedLists.Item1
        SpareCards = ReturnedLists.Item2
        Comp1Cards = ReturnedLists.Item3
        Comp2Cards = ReturnedLists.Item4
        Comp3Cards = ReturnedLists.Item5

        Dim l As Integer

        For l = 0 To 2

            card = playerCards(l)
            CardVal = "_" + card.Type + card.Suit
            FaceDownPicList.Add(CardVal)
            FaceDownNumList.Add(card.Number)
        Next

        For l = 3 To 5


            card = playerCards(l)
            CardVal = "_" + card.Type + card.Suit
            PBList(l - 3).Image = My.Resources.ResourceManager.GetObject(CardVal)
            PBList(l - 3).Tag = CardVal
            TableNums(l - 3).Text = (card.Number)

        Next

        For l = 6 To 8
            card = playerCards(l)
            CardVal = "_" + card.Type + card.Suit
            PhandList(l - 6).Image = My.Resources.ResourceManager.GetObject(CardVal)
            PhandList(l - 6).Tag = CardVal
            HandNums(l - 6).Text = (card.Number)
        Next

    End Sub

    Private Sub Hand1_Click(sender As Object, e As EventArgs) Handles Hand1.Click
        If card1 = "" Then
            card1 = "hand1"
            outline1.Show()

        ElseIf card2 = "" Then
            card2 = "hand1"
            outline1.Hide()
            outline2.Hide()
            outline3.Hide()
            outline4.Hide()
            outline5.Hide()
            outline6.Hide()
            Swap()
        End If
    End Sub

    Private Sub Hand2_Click(sender As Object, e As EventArgs) Handles Hand2.Click
        If card1 = "" Then
            card1 = "hand2"
            outline2.Show()

        ElseIf card2 = "" Then
            card2 = "hand2"
            outline1.Hide()
            outline2.Hide()
            outline3.Hide()
            outline4.Hide()
            outline5.Hide()
            outline6.Hide()
            Swap()
        End If
    End Sub

    Private Sub Hand3_Click(sender As Object, e As EventArgs) Handles Hand3.Click
        If card1 = "" Then
            card1 = "hand3"
            outline3.Show()

        ElseIf card2 = "" Then
            card2 = "hand3"
            outline1.Hide()
            outline2.Hide()
            outline3.Hide()
            outline4.Hide()
            outline5.Hide()
            outline6.Hide()
            Swap()
        End If
    End Sub

    Private Sub Table1_Click(sender As Object, e As EventArgs) Handles Table1.Click
        If card1 = "" Then
            card1 = "table1"
            outline4.Show()

        ElseIf card2 = "" Then
            card2 = "table1"
            outline1.Hide()
            outline2.Hide()
            outline3.Hide()
            outline4.Hide()
            outline5.Hide()
            outline6.Hide()
            Swap()
        End If
    End Sub

    Private Sub Table2_Click(sender As Object, e As EventArgs) Handles Table2.Click
        If card1 = "" Then
            card1 = "table2"
            outline5.Show()

        ElseIf card2 = "" Then
            card2 = "table2"
            outline1.Hide()
            outline2.Hide()
            outline3.Hide()
            outline4.Hide()
            outline5.Hide()
            outline6.Hide()
            Swap()
        End If
    End Sub

    Private Sub Table3_Click(sender As Object, e As EventArgs) Handles Table3.Click
        If card1 = "" Then
            card1 = "table3"
            outline6.Show()

        ElseIf card2 = "" Then
            card2 = "table3"
            outline1.Hide()
            outline2.Hide()
            outline3.Hide()
            outline4.Hide()
            outline5.Hide()
            outline6.Hide()
            Swap()
        End If
    End Sub

    Private Sub Swap()
        Dim tempTag As String
        Dim tempPic As Image
        Dim tempLbl As Integer

        If card1 = "hand1" Then
            If card2 = "table1" Then
                tempTag = Hand1.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand1.Tag)
                tempLbl = HandLbl1.Text

                Hand1.Image = My.Resources.ResourceManager.GetObject(Table1.Tag)
                Hand1.Tag = Table1.Tag
                HandLbl1.Text = TableLbl1.Text

                Table1.Image = tempPic
                Table1.Tag = tempTag
                TableLbl1.Text = tempLbl

                card1 = ""
                card2 = ""
            ElseIf card2 = "table2" Then
                tempTag = Hand1.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand1.Tag)
                tempLbl = HandLbl1.Text

                Hand1.Image = My.Resources.ResourceManager.GetObject(Table2.Tag)
                Hand1.Tag = Table2.Tag
                HandLbl1.Text = TableLbl2.Text

                Table2.Image = tempPic
                Table2.Tag = tempTag
                TableLbl2.Text = tempLbl
                card1 = ""
                card2 = ""
            ElseIf card2 = "table3" Then
                tempTag = Hand1.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand1.Tag)
                tempLbl = HandLbl1.Text

                Hand1.Image = My.Resources.ResourceManager.GetObject(Table3.Tag)
                Hand1.Tag = Table3.Tag
                HandLbl1.Text = TableLbl3.Text

                Table3.Image = tempPic
                Table3.Tag = tempTag
                TableLbl3.Text = tempLbl
                card1 = ""
                card2 = ""
            ElseIf card2 = "hand2" Then
                tempTag = Hand1.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand1.Tag)
                tempLbl = HandLbl1.Text

                Hand1.Image = My.Resources.ResourceManager.GetObject(Hand2.Tag)
                Hand1.Tag = Hand2.Tag
                HandLbl1.Text = HandLbl2.Text

                Hand2.Image = tempPic
                Hand2.Tag = tempTag
                HandLbl2.Text = tempLbl

                card1 = ""
                card2 = ""

            ElseIf card2 = "hand3" Then
                tempTag = Hand1.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand1.Tag)
                tempLbl = HandLbl1.Text

                Hand1.Image = My.Resources.ResourceManager.GetObject(Hand3.Tag)
                Hand1.Tag = Hand3.Tag
                HandLbl1.Text = HandLbl3.Text

                Hand3.Image = tempPic
                Hand3.Tag = tempTag
                HandLbl3.Text = tempLbl

                card1 = ""
                card2 = ""

            Else
                card1 = ""
                card2 = ""
            End If


        ElseIf card1 = "hand2" Then
            If card2 = "table1" Then
                tempTag = Hand2.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand2.Tag)
                tempLbl = HandLbl2.Text

                Hand2.Image = My.Resources.ResourceManager.GetObject(Table1.Tag)
                Hand2.Tag = Table1.Tag
                HandLbl2.Text = TableLbl1.Text

                Table1.Image = tempPic
                Table1.Tag = tempTag
                TableLbl1.Text = tempLbl

                card1 = ""
                card2 = ""
            ElseIf card2 = "table2" Then
                tempTag = Hand2.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand2.Tag)
                tempLbl = HandLbl2.Text

                Hand2.Image = My.Resources.ResourceManager.GetObject(Table2.Tag)
                Hand2.Tag = Table2.Tag
                HandLbl2.Text = TableLbl2.Text

                Table2.Image = tempPic
                Table2.Tag = tempTag
                TableLbl2.Text = tempLbl

                card1 = ""
                card2 = ""
            ElseIf card2 = "table3" Then
                tempTag = Hand2.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand2.Tag)
                tempLbl = HandLbl2.Text

                Hand2.Image = My.Resources.ResourceManager.GetObject(Table3.Tag)
                Hand2.Tag = Table3.Tag
                HandLbl2.Text = TableLbl3.Text

                Table3.Image = tempPic
                Table3.Tag = tempTag
                TableLbl3.Text = tempLbl

                card1 = ""
                card2 = ""
            ElseIf card2 = "hand1" Then
                tempTag = Hand1.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand1.Tag)
                tempLbl = HandLbl1.Text

                Hand1.Image = My.Resources.ResourceManager.GetObject(Hand2.Tag)
                Hand1.Tag = Hand2.Tag
                HandLbl1.Text = HandLbl2.Text

                Hand2.Image = tempPic
                Hand2.Tag = tempTag
                HandLbl2.Text = tempLbl

                card1 = ""
                card2 = ""

            ElseIf card2 = "hand3" Then
                tempTag = Hand2.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand2.Tag)
                tempLbl = HandLbl2.Text

                Hand2.Image = My.Resources.ResourceManager.GetObject(Hand3.Tag)
                Hand2.Tag = Hand3.Tag
                HandLbl2.Text = HandLbl3.Text

                Hand3.Image = tempPic
                Hand3.Tag = tempTag
                HandLbl3.Text = tempLbl

                card1 = ""
                card2 = ""

            Else
                card1 = ""
                card2 = ""
            End If


        ElseIf card1 = "hand3" Then
            If card2 = "table1" Then
                tempTag = Hand3.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand3.Tag)
                tempLbl = HandLbl3.Text

                Hand3.Image = My.Resources.ResourceManager.GetObject(Table1.Tag)
                Hand3.Tag = Table1.Tag
                HandLbl3.Text = TableLbl1.Text

                Table1.Image = tempPic
                Table1.Tag = tempTag
                TableLbl1.Text = tempLbl

                card1 = ""
                card2 = ""
            ElseIf card2 = "table2" Then
                tempTag = Hand3.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand3.Tag)
                tempLbl = HandLbl3.Text

                Hand3.Image = My.Resources.ResourceManager.GetObject(Table2.Tag)
                Hand3.Tag = Table2.Tag
                HandLbl3.Text = TableLbl2.Text

                Table2.Image = tempPic
                Table2.Tag = tempTag
                TableLbl2.Text = tempLbl

                card1 = ""
                card2 = ""
            ElseIf card2 = "table3" Then
                tempTag = Hand3.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand3.Tag)
                tempLbl = HandLbl3.Text

                Hand3.Image = My.Resources.ResourceManager.GetObject(Table3.Tag)
                Hand3.Tag = Table3.Tag
                HandLbl3.Text = TableLbl3.Text

                Table3.Image = tempPic
                Table3.Tag = tempTag
                TableLbl3.Text = tempLbl

                card1 = ""
                card2 = ""
            ElseIf card2 = "hand1" Then
                tempTag = Hand1.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand1.Tag)
                tempLbl = HandLbl1.Text

                Hand1.Image = My.Resources.ResourceManager.GetObject(Hand3.Tag)
                Hand1.Tag = Hand3.Tag
                HandLbl1.Text = HandLbl3.Text

                Hand3.Image = tempPic
                Hand3.Tag = tempTag
                HandLbl3.Text = tempLbl

                card1 = ""
                card2 = ""

            ElseIf card2 = "hand2" Then
                tempTag = Hand2.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand2.Tag)
                tempLbl = HandLbl2.Text

                Hand2.Image = My.Resources.ResourceManager.GetObject(Hand3.Tag)
                Hand2.Tag = Hand3.Tag
                HandLbl2.Text = HandLbl3.Text

                Hand3.Image = tempPic
                Hand3.Tag = tempTag
                HandLbl3.Text = tempLbl

                card1 = ""
                card2 = ""

            Else
                card1 = ""
                card2 = ""
            End If


        ElseIf card1 = "table1" Then
            If card2 = "hand1" Then
                tempTag = Hand1.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand1.Tag)
                tempLbl = HandLbl1.Text

                Hand1.Image = My.Resources.ResourceManager.GetObject(Table1.Tag)
                Hand1.Tag = Table1.Tag
                HandLbl1.Text = TableLbl1.Text

                Table1.Image = tempPic
                Table1.Tag = tempTag
                TableLbl1.Text = tempLbl

                card1 = ""
                card2 = ""
            ElseIf card2 = "hand2" Then
                tempTag = Hand2.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand2.Tag)
                tempLbl = HandLbl2.Text

                Hand2.Image = My.Resources.ResourceManager.GetObject(Table1.Tag)
                Hand2.Tag = Table1.Tag
                HandLbl2.Text = TableLbl1.Text

                Table1.Image = tempPic
                Table1.Tag = tempTag
                TableLbl1.Text = tempLbl

                card1 = ""
                card2 = ""
            ElseIf card2 = "hand3" Then
                tempTag = Hand3.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand3.Tag)
                tempLbl = HandLbl3.Text

                Hand3.Image = My.Resources.ResourceManager.GetObject(Table1.Tag)
                Hand3.Tag = Table1.Tag
                HandLbl3.Text = TableLbl1.Text

                Table1.Image = tempPic
                Table1.Tag = tempTag
                TableLbl1.Text = tempLbl

                card1 = ""
                card2 = ""

            ElseIf card2 = "table2" Then
                tempTag = Table2.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Table2.Tag)
                tempLbl = TableLbl2.Text

                Table2.Image = My.Resources.ResourceManager.GetObject(Table1.Tag)
                Table2.Tag = Table1.Tag
                TableLbl2.Text = TableLbl1.Text

                Table1.Image = tempPic
                Table1.Tag = tempTag
                TableLbl1.Text = tempLbl

                card1 = ""
                card2 = ""

            ElseIf card2 = "table3" Then
                tempTag = Table3.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Table3.Tag)
                tempLbl = TableLbl3.Text

                Table3.Image = My.Resources.ResourceManager.GetObject(Table1.Tag)
                Table3.Tag = Table1.Tag
                TableLbl3.Text = TableLbl1.Text

                Table1.Image = tempPic
                Table1.Tag = tempTag
                TableLbl1.Text = tempLbl

                card1 = ""
                card2 = ""
            Else

                card1 = ""
                card2 = ""
            End If


        ElseIf card1 = "table2" Then
            If card2 = "hand1" Then
                tempTag = Hand1.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand1.Tag)
                tempLbl = HandLbl1.Text

                Hand1.Image = My.Resources.ResourceManager.GetObject(Table2.Tag)
                Hand1.Tag = Table2.Tag
                HandLbl1.Text = TableLbl2.Text

                Table2.Image = tempPic
                Table2.Tag = tempTag
                TableLbl2.Text = tempLbl

                card1 = ""
                card2 = ""
            ElseIf card2 = "hand2" Then
                tempTag = Hand2.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand2.Tag)
                tempLbl = HandLbl2.Text

                Hand2.Image = My.Resources.ResourceManager.GetObject(Table2.Tag)
                Hand2.Tag = Table2.Tag
                HandLbl2.Text = TableLbl2.Text

                Table2.Image = tempPic
                Table2.Tag = tempTag
                TableLbl2.Text = tempLbl

                card1 = ""
                card2 = ""
            ElseIf card2 = "hand3" Then
                tempTag = Hand3.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand3.Tag)
                tempLbl = HandLbl3.Text

                Hand3.Image = My.Resources.ResourceManager.GetObject(Table2.Tag)
                Hand3.Tag = Table2.Tag
                HandLbl3.Text = TableLbl2.Text

                Table2.Image = tempPic
                Table2.Tag = tempTag
                TableLbl2.Text = tempLbl

                card1 = ""
                card2 = ""

            ElseIf card2 = "table1" Then
                tempTag = Table1.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Table1.Tag)
                tempLbl = TableLbl1.Text

                Table1.Image = My.Resources.ResourceManager.GetObject(Table2.Tag)
                Table1.Tag = Table2.Tag
                TableLbl1.Text = TableLbl2.Text

                Table2.Image = tempPic
                Table2.Tag = tempTag
                TableLbl2.Text = tempLbl

                card1 = ""
                card2 = ""

            ElseIf card2 = "table3" Then
                tempTag = Table3.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Table3.Tag)
                tempLbl = TableLbl3.Text

                Table3.Image = My.Resources.ResourceManager.GetObject(Table2.Tag)
                Table3.Tag = Table2.Tag
                TableLbl3.Text = TableLbl2.Text

                Table2.Image = tempPic
                Table2.Tag = tempTag
                TableLbl2.Text = tempLbl

                card1 = ""
                card2 = ""
            Else

                card1 = ""
                card2 = ""
            End If


        ElseIf card1 = "table3" Then
            If card2 = "hand1" Then
                tempTag = Hand1.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand1.Tag)
                tempLbl = HandLbl1.Text

                Hand1.Image = My.Resources.ResourceManager.GetObject(Table3.Tag)
                Hand1.Tag = Table3.Tag
                HandLbl1.Text = TableLbl3.Text

                Table3.Image = tempPic
                Table3.Tag = tempTag
                TableLbl3.Text = tempLbl

                card1 = ""
                card2 = ""
            ElseIf card2 = "hand2" Then
                tempTag = Hand2.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand2.Tag)
                tempLbl = HandLbl2.Text

                Hand2.Image = My.Resources.ResourceManager.GetObject(Table3.Tag)
                Hand2.Tag = Table3.Tag
                HandLbl2.Text = TableLbl3.Text

                Table3.Image = tempPic
                Table3.Tag = tempTag
                TableLbl3.Text = tempLbl

                card1 = ""
                card2 = ""
            ElseIf card2 = "hand3" Then
                tempTag = Hand3.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Hand3.Tag)
                tempLbl = HandLbl3.Text

                Hand3.Image = My.Resources.ResourceManager.GetObject(Table3.Tag)
                Hand3.Tag = Table3.Tag
                HandLbl3.Text = TableLbl3.Text

                Table3.Image = tempPic
                Table3.Tag = tempTag
                TableLbl3.Text = tempLbl

                card1 = ""
                card2 = ""

            ElseIf card2 = "table1" Then
                tempTag = Table1.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Table1.Tag)
                tempLbl = TableLbl1.Text

                Table1.Image = My.Resources.ResourceManager.GetObject(Table3.Tag)
                Table1.Tag = Table3.Tag
                TableLbl1.Text = TableLbl3.Text

                Table3.Image = tempPic
                Table3.Tag = tempTag
                TableLbl3.Text = tempLbl

                card1 = ""
                card2 = ""

            ElseIf card2 = "table2" Then
                tempTag = Table2.Tag
                tempPic = My.Resources.ResourceManager.GetObject(Table2.Tag)
                tempLbl = TableLbl2.Text

                Table2.Image = My.Resources.ResourceManager.GetObject(Table3.Tag)
                Table2.Tag = Table3.Tag
                TableLbl2.Text = TableLbl3.Text

                Table3.Image = tempPic
                Table3.Tag = tempTag
                TableLbl3.Text = tempLbl

                card1 = ""
                card2 = ""
            Else

                card1 = ""
                card2 = ""
            End If


        Else
            MsgBox("you can only swap table and hand cards")
            card1 = ""
            card2 = ""
        End If


    End Sub

    Public handpics As New List(Of String)
    Public handtag As New List(Of Integer)
    Public tablepics As New List(Of String)
    Public tabletag As New List(Of Integer)
    Public HandCards As New List(Of Card)


    Private Sub Done_Click(sender As Object, e As EventArgs) Handles Done.Click
        Dim j As Integer = 0
        Dim NEWcard As New Card
        Dim handsPicsList As New List(Of String) From {Hand1.Tag, Hand2.Tag, Hand3.Tag}
        Dim handNumLists As New List(Of Integer) From {HandLbl1.Text, HandLbl2.Text, HandLbl3.Text}

        handpics.Add(Hand1.Tag)
        handpics.Add(Hand2.Tag)
        handpics.Add(Hand3.Tag)

        handtag.Add(HandLbl1.Text)
        handtag.Add(HandLbl2.Text)
        handtag.Add(HandLbl3.Text)

        For i = 0 To 3
            NEWcard.imagecode = handsPicsList(i)
            NEWcard.Number = handNumLists(i)
        Next


        tablepics.Add(Table1.Tag)
        tablepics.Add(Table2.Tag)
        tablepics.Add(Table3.Tag)

        tabletag.Add(TableLbl1.Text)
        tabletag.Add(TableLbl2.Text)
        tabletag.Add(TableLbl3.Text)


        GameForm.Show()
        Me.Hide()
    End Sub
End Class