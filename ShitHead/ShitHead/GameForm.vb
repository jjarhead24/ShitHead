Public Class GameForm
    Dim playerCards As New List(Of Card)
    Dim SpareCards As New List(Of Card)
    Dim Comp1Card As New List(Of Card)
    Public FormFrom As String
    Dim FirstPlayer As Integer
    Dim card As Card


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PTableList As New List(Of PictureBox) From {TableCard1, TableCard2, TableCard3}
        Dim PFaceDList As New List(Of PictureBox) From {FaceDown1, FaceDown2, FaceDown3}
        Dim compList As New List(Of PictureBox) From {CompTable1, CompTable2, CompTable3}
        Dim CFaceDList As New List(Of PictureBox) From {CDown1, CDown2, CDown3}
        Dim PHandList As New List(Of PictureBox) From {HandCard1, HandCard2, HandCard3}
        Dim FaceDLblList As New List(Of Label) From {FaceD1, FaceD2, FaceD3}
        Dim CompTableUp As New List(Of PictureBox) From {CompUp1, CompUp2, CompUp3}
        Dim CompTableDown As New List(Of PictureBox) From {CompTable1, CompTable2, CompTable3}
        Dim Comp2TableCards As New List(Of PictureBox) From {Comp2Table1, Comp2table2, Comp2Table3}
        Dim Comp2DownCard As New List(Of PictureBox) From {Comp2Down1, Comp2Down2, Comp2Down3}
        Dim Comp3TableCards As New List(Of PictureBox) From {Comp3Table1, Comp3Table2, Comp3Table3}
        Dim Comp3DownCards As New List(Of PictureBox) From {Comp3Down1, Comp3Down2, Comp3Down3}
        Me.WindowState = FormWindowState.Maximized
        UpdateCardCount()
        SetUp(PHandList, PTableList, PFaceDList, FaceDLblList, CompTableUp, CompTableDown, Comp2TableCards, Comp2DownCard, Comp3TableCards, Comp3DownCards)
        If card_swap.handpics.Count <= 3 Then
            HandRight.Enabled = False
            'LeftClick.Enabled = False
        End If
        Comp1Card = card_swap.Comp1Cards

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles CmdClose.Click
        FormFrom = "Game"
        Quit.Show()
        Me.Hide()
    End Sub

    Dim i As Integer = 0

    Dim j As Integer = 2

    Private Sub SetUp(PHandlist, PTableList, PFaceDList, FaceDLblList, CompTableUp, CompTableDown, Comp2TableCards, Comp2DownCard, Comp3TableCards, Comp3DownCards)
        Dim CardVal As String
        For i = 0 To 2
            PHandlist(i).Image = My.Resources.ResourceManager.GetObject(card_swap.handpics(i))
            PHandlist(i).Tag = card_swap.handtag(i)

            PTableList(i).Image = My.Resources.ResourceManager.GetObject(card_swap.tablepics(i))
            PTableList(i).Tag = card_swap.tabletag(i)

            PFaceDList(i).Tag = card_swap.FaceDownNumList(i)
            FaceDLblList(i).Text = card_swap.FaceDownPicList(i)

            CompTableUp(i).tag = card_swap.Comp1Cards(i + 3).Number
            card = card_swap.Comp1Cards(i + 3)
            CardVal = "_" + card.Type + card.Suit
            CompTableUp(i).image = My.Resources.ResourceManager.GetObject(CardVal)

            CompTableDown(i).tag = card_swap.Comp1Cards(i).Number

            If SettingsForGame.BotsIn = 2 Then
                Comp2TableCards(i).tag = card_swap.Comp2Cards(i + 3).Number
                card = card_swap.Comp2Cards(i + 3)
                CardVal = "_" + card.Type + card.Suit + "R"
                Comp2TableCards(i).image = My.Resources.ResourceManager.GetObject(CardVal)

                card = card_swap.Comp2Cards(i)
                Comp2DownCard(i).tag = card.Number
            End If
            If SettingsForGame.BotsIn = 3 Then
                Comp2TableCards(i).tag = card_swap.Comp2Cards(i + 3).Number
                card = card_swap.Comp2Cards(i + 3)
                CardVal = "_" + card.Type + card.Suit + "R"
                Comp2TableCards(i).image = My.Resources.ResourceManager.GetObject(CardVal)

                card = card_swap.Comp2Cards(i)
                Comp2DownCard(i).tag = card.Number

                Comp3TableCards(i).tag = card_swap.Comp3Cards(i + 3).Number
                card = card_swap.Comp3Cards(i + 3)
                CardVal = "_" + card.Type + card.Suit + "R"
                Comp3TableCards(i).image = My.Resources.ResourceManager.GetObject(CardVal)

                card = card_swap.Comp3Cards(i)
                Comp3DownCards(i).tag = card.Number
            End If
        Next
    End Sub

    Private Sub HandRight_Click(sender As Object, e As EventArgs) Handles HandRight.Click
       
        If card_swap.handpics.Count > 3 Then
            Dim PHandList As New List(Of PictureBox) From {HandCard1, HandCard2, HandCard3}

            HandCard1.Image = HandCard2.Image
            HandCard1.Tag = HandCard2.Tag

            HandCard2.Image = HandCard3.Image
            HandCard2.Tag = HandCard3.Tag

            j = j + 1
            If j = card_swap.handpics.Count Then
                j = 0
            End If

            HandCard3.Image = My.Resources.ResourceManager.GetObject(card_swap.handpics(j))
            HandCard3.Tag = card_swap.handtag(j)
        End If

    End Sub

    Dim u As Integer = card_swap.handpics.Count

    'Private Sub LeftClick_Click(sender As Object, e As EventArgs) Handles LeftClick.Click
    '    Dim PHandList As New List(Of PictureBox) From {HandCard1, HandCard2, HandCard3}

    '    HandCard3.Image = HandCard2.Image
    '    HandCard3.Tag = HandCard2.Tag

    '    HandCard2.Image = HandCard1.Image
    '    HandCard2.Tag = HandCard1.Tag

    '    u = u - 1
    '    If u = 0 Then
    '        u = card_swap.handpics.Count - 1

    '    End If

    '    HandCard1.Image = My.Resources.ResourceManager.GetObject(card_swap.handpics(u))
    '    HandCard1.Tag = card_swap.handtag(u)
    'End Sub

    Private Sub PickUpPile_Click(sender As Object, e As EventArgs) Handles PickUpPile.Click
        Dim CardVal As String
        'check if players turn


        If card_swap.SpareCards.Count = 0 Then
            PickUpPile.Hide()
        End If
        card = card_swap.SpareCards(0)
        CardVal = "_" + card.Type + card.Suit
        card_swap.handpics.Add(CardVal)
        card_swap.handtag.Add(card.Number)

        card_swap.SpareCards.Remove(card)

        If card_swap.SpareCards.Count = 0 Then
            PickUpPile.Hide()
        End If
        If card_swap.handpics.Count <= 3 Then
            HandRight.Enabled = False
            'LeftClick.Enabled = False
        Else

            HandRight.Enabled = True
            'LeftClick.Enabled = True

        End If
        UpdateCardCount()
    End Sub
    Dim mess As String
    Private Sub HandCard1_Click(sender As Object, e As EventArgs) Handles HandCard1.Click
        mess = HandCard1.Tag
        MsgBox(mess)
    End Sub

    Private Sub HandCard2_Click(sender As Object, e As EventArgs) Handles HandCard2.Click
        mess = HandCard2.Tag
        MsgBox(mess)
    End Sub

    Private Sub HandCard3_Click(sender As Object, e As EventArgs) Handles HandCard3.Click
        mess = HandCard3.Tag
        MsgBox(mess)
    End Sub

    Private Sub CompTable3_Click(sender As Object, e As EventArgs) Handles CompTable3.Click
        mess = CompTable3.Tag
        MsgBox(mess)
    End Sub

    Private Sub CompTable2_Click(sender As Object, e As EventArgs) Handles CompTable2.Click
        mess = CompTable2.Tag
        MsgBox(mess)
    End Sub

    Private Sub CompTable1_Click(sender As Object, e As EventArgs) Handles CompTable1.Click
        mess = CompTable1.Tag
        MsgBox(mess)
    End Sub
    Dim passon As Boolean = True
    Private Sub SortCards_Click(sender As Object, e As EventArgs) Handles SortCards.Click
        Dim Temp As Integer
        Dim PHandList As New List(Of PictureBox) From {HandCard1, HandCard2, HandCard3}
        Dim temp2 As String
        Dim changes As Integer = 0
        Dim cont As Boolean
        i = 0
        For k = 0 To 1
            For j = 0 To card_swap.handtag.Count
                cont = True
                While cont = True
                    Try
                        If card_swap.handtag(i) > card_swap.handtag(i + 1) Then
                            Temp = card_swap.handtag(i)
                            card_swap.handtag(i) = card_swap.handtag(i + 1)
                            card_swap.handtag(i + 1) = Temp

                            temp2 = card_swap.handpics(i)
                            card_swap.handpics(i) = card_swap.handpics(i + 1)
                            card_swap.handpics(i + 1) = temp2
                            changes = changes + 1
                            For i = 0 To 2
                                PHandList(i).Image = My.Resources.ResourceManager.GetObject(card_swap.handpics(i))
                                PHandList(i).Tag = card_swap.handtag(i)
                            Next
                        End If
                    Catch
                        cont = False
                    End Try
                    If i = card_swap.handpics.Count Then
                        i = 0
                    End If
                    i = i + 1
                End While
            Next
            j = 2
            If card_swap.handtag(1) > card_swap.handtag(2) Then
                k = 0
            End If
        Next
        If passon = True Then
            passon = False
            SortCards.PerformClick()
        Else
            passon = True
        End If
    End Sub

    Private Sub Comp3Table3_Click(sender As Object, e As EventArgs) Handles Comp3Table3.Click
        MsgBox(Str(Comp3Table3.Tag))
    End Sub

    Private Sub UpdateCardCount()
        Dim countCard As String
        countCard = "You have " & card_swap.handpics.Count & " cards in your hand"
        CardCount.Text = countCard
    End Sub

    Private Sub RollStart_Click(sender As Object, e As EventArgs) Handles RollStart.Click
        Rolling_start.Show()
    End Sub

    Private Sub RNDplayer_Click(sender As Object, e As EventArgs) Handles RNDplayer.Click
        Dim r As New Random
        FirstPlayer = r.Next(1, 4)
    End Sub
End Class
