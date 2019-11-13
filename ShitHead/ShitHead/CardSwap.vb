Public Class card_swap
    Dim playerCards As New List(Of Card)
    Dim SpareCards As New List(Of Card)
    Dim Comp1Cards As New List(Of Card)
    Dim card1 As String
    Dim card2 As String
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

    Private Sub Hand1_Click(sender As Object, e As EventArgs) Handles Hand1.Click
        If card1 = "" Then
            card1 = "hand1"
            Swap()
        ElseIf card2 = "" Then
            card2 = "hand1"
        End If
    End Sub

    Private Sub Hand2_Click(sender As Object, e As EventArgs) Handles Hand2.Click
        If card1 = "" Then
            card1 = "hand1"
            Swap()
        ElseIf card2 = "" Then
            card2 = "hand2"
        End If
    End Sub

    Private Sub Hand3_Click(sender As Object, e As EventArgs) Handles Hand3.Click
        If card1 = "" Then
            card1 = "hand3"
            Swap()
        ElseIf card2 = "" Then
            card2 = "hand3"
        End If
    End Sub

    Private Sub Table1_Click(sender As Object, e As EventArgs) Handles Table1.Click
        If card1 = "" Then
            card1 = "table1"
            Swap()
        ElseIf card2 = "" Then
            card2 = "table1"
        End If
    End Sub

    Private Sub Table2_Click(sender As Object, e As EventArgs) Handles Table2.Click
        If card1 = "" Then
            card1 = "table1"
            Swap()
        ElseIf card2 = "" Then
            card2 = "table1"
        End If
    End Sub

    Private Sub Table3_Click(sender As Object, e As EventArgs) Handles Table3.Click
        If card1 = "" Then
            card1 = "table1"
            Swap()
        ElseIf card2 = "" Then
            card2 = "table1"
        End If
    End Sub

    Private Sub Swap()
        Dim tempTag As String
        Dim tempPic As String

        If card1 = "hand1" Then
            If card2 = "table1" Then

            ElseIf card2 = "table2" Then

            ElseIf card2 = "table3" Then

            Else
                MsgBox("You can only swap hand and table cards")
            End If


        ElseIf card1 = "hand2" Then
            If card2 = "table1" Then

            ElseIf card2 = "table2" Then

            ElseIf card2 = "table3" Then

            Else
                MsgBox("You can only swap hand and table cards")
            End If


        ElseIf card1 = "hand3" Then
            If card2 = "table1" Then

            ElseIf card2 = "table2" Then

            ElseIf card2 = "table3" Then

            Else
                MsgBox("You can only swap hand and table cards")
            End If


        ElseIf card1 = "table1" Then
            If card2 = "hand1" Then

            ElseIf card2 = "hand2" Then

            ElseIf card2 = "hand3" Then

            Else
                MsgBox("You can only swap hand and table cards")
            End If


        ElseIf card1 = "table2" Then
            If card2 = "hand1" Then

            ElseIf card2 = "hand2" Then

            ElseIf card2 = "hand3" Then

            Else
                MsgBox("You can only swap hand and table cards")
            End If


        ElseIf card1 = "table3" Then
            If card2 = "hand1" Then

            ElseIf card2 = "hand2" Then

            ElseIf card2 = "hand3" Then

            Else
                MsgBox("You can only swap hand and table cards")
            End If


        Else
            MsgBox("you can only swap table and hand cards")
        End If


    End Sub

End Class