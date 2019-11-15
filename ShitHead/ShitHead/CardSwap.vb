Public Class card_swap
    Dim playerCards As New List(Of Card)
    Dim SpareCards As New List(Of Card)
    Dim Comp1Cards As New List(Of Card)
    Dim card1 As String
    Dim card2 As String
    Dim HandNums As New List(Of Label) From {HandLbl1, HandLbl2, HandLbl3}
    Dim TableNums As New List(Of Label) From {TableLbl1, TableLbl2, TableLbl3}
    Private Sub card_swap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CardVal As String
        Dim card As Card
        Dim PBList As New List(Of PictureBox) From {Table1, Table2, Table3}
        Dim PhandList As New List(Of PictureBox) From {Hand1, Hand2, Hand3}
        TableNums = New List(Of Label) From {TableLbl1, TableLbl2, TableLbl3}
        HandNums = New List(Of Label) From {HandLbl1, HandLbl2, HandLbl3}

        Dim ReturnedLists = Card.GenCards()
        playerCards = ReturnedLists.Item1
        SpareCards = ReturnedLists.Item2
        Comp1Cards = ReturnedLists.Item3

        Dim l As Integer
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
            PHandList(l - 6).Image = My.Resources.ResourceManager.GetObject(CardVal)
            PhandList(l - 6).Tag = CardVal
            HandNums(l - 6).Text = (card.Number)
        Next

    End Sub

    Private Sub Hand1_Click(sender As Object, e As EventArgs) Handles Hand1.Click
        If card1 = "" Then
            card1 = "hand1"

        ElseIf card2 = "" Then
            card2 = "hand1"
            Swap()
        End If
    End Sub

    Private Sub Hand2_Click(sender As Object, e As EventArgs) Handles Hand2.Click
        If card1 = "" Then
            card1 = "hand1"

        ElseIf card2 = "" Then
            card2 = "hand2"
            Swap()
        End If
    End Sub

    Private Sub Hand3_Click(sender As Object, e As EventArgs) Handles Hand3.Click
        If card1 = "" Then
            card1 = "hand3"

        ElseIf card2 = "" Then
            card2 = "hand3"
            Swap()
        End If
    End Sub

    Private Sub Table1_Click(sender As Object, e As EventArgs) Handles Table1.Click
        If card1 = "" Then
            card1 = "table1"

        ElseIf card2 = "" Then
            card2 = "table1"
            Swap()
        End If
    End Sub

    Private Sub Table2_Click(sender As Object, e As EventArgs) Handles Table2.Click
        If card1 = "" Then
            card1 = "table1"

        ElseIf card2 = "" Then
            card2 = "table1"
            Swap()
        End If
    End Sub

    Private Sub Table3_Click(sender As Object, e As EventArgs) Handles Table3.Click
        If card1 = "" Then
            card1 = "table1"

        ElseIf card2 = "" Then
            card2 = "table1"
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
                card1 = ""
                card2 = ""
            ElseIf card2 = "table3" Then
                card1 = ""
                card2 = ""
            Else
                MsgBox("You can only swap hand and table cards")
                card1 = ""
                card2 = ""
            End If


        ElseIf card1 = "hand2" Then
            If card2 = "table1" Then
                card1 = ""
                card2 = ""
            ElseIf card2 = "table2" Then
                card1 = ""
                card2 = ""
            ElseIf card2 = "table3" Then
                card1 = ""
                card2 = ""
            Else
                MsgBox("You can only swap hand and table cards")
                card1 = ""
                card2 = ""
            End If


        ElseIf card1 = "hand3" Then
            If card2 = "table1" Then
                card1 = ""
                card2 = ""
            ElseIf card2 = "table2" Then
                card1 = ""
                card2 = ""
            ElseIf card2 = "table3" Then
                card1 = ""
                card2 = ""
            Else
                MsgBox("You can only swap hand and table cards")
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
                card1 = ""
                card2 = ""
            ElseIf card2 = "hand3" Then
                card1 = ""
                card2 = ""
            Else
                MsgBox("You can only swap hand and table cards")
                card1 = ""
                card2 = ""
            End If


        ElseIf card1 = "table2" Then
            If card2 = "hand1" Then
                card1 = ""
                card2 = ""
            ElseIf card2 = "hand2" Then
                card1 = ""
                card2 = ""
            ElseIf card2 = "hand3" Then
                card1 = ""
                card2 = ""
            Else
                MsgBox("You can only swap hand and table cards")
                card1 = ""
                card2 = ""
            End If


        ElseIf card1 = "table3" Then
            If card2 = "hand1" Then
                card1 = ""
                card2 = ""
            ElseIf card2 = "hand2" Then
                card1 = ""
                card2 = ""
            ElseIf card2 = "hand3" Then
                card1 = ""
                card2 = ""
            Else
                MsgBox("You can only swap hand and table cards")
                card1 = ""
                card2 = ""
            End If


        Else
            MsgBox("you can only swap table and hand cards")
            card1 = ""
            card2 = ""
        End If


    End Sub

End Class