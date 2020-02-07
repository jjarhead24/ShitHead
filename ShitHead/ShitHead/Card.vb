Public Class Card
    Public Suit As String
    Public Number As Integer
    Public Type As String
    Public imagecode As String 'give all cards the right code (ineffeicently) 

    Public Shared Function GenCards() As Tuple(Of List(Of Card), List(Of Card), List(Of Card), List(Of Card), List(Of Card))
        Dim playerCards As New List(Of Card)
        Dim SpareCards As New List(Of Card)
        Dim Comp1Cards As New List(Of Card)
        Dim Comp2Cards As New List(Of Card)
        Dim Comp3Cards As New List(Of Card)
        Dim usedNums As New List(Of Integer)
        Dim NewCards As New Random()
        Dim CurrCard As Integer

        For x = 1 To 52
            CurrCard = NewCards.Next(1, 53)

            If usedNums.Contains(CurrCard) Then
                While usedNums.Contains(CurrCard)
                    CurrCard = NewCards.Next(1, 53)
                End While
            End If
            usedNums.Add(CurrCard)
            Dim MadeCard As New Card

            If CurrCard >= 1 And CurrCard <= 13 Then
                MadeCard.Suit = "H"
                If CurrCard >= 1 And CurrCard < 10 Then
                    If CurrCard = 1 Then
                        MadeCard.Number = 1
                        MadeCard.Type = "2"
                        MadeCard.imagecode = "_2H"
                    ElseIf CurrCard = 2 Then
                        MadeCard.Number = 2
                        MadeCard.Type = "3"
                        MadeCard.imagecode = "_3H"
                    ElseIf CurrCard = 3 Then
                        MadeCard.Number = 3
                        MadeCard.Type = "4"
                        MadeCard.imagecode = "_4H"
                    ElseIf CurrCard = 4 Then
                        MadeCard.Number = 4
                        MadeCard.Type = "5"
                        MadeCard.imagecode = "_5H"
                    ElseIf CurrCard = 5 Then
                        MadeCard.Number = 5
                        MadeCard.Type = "6"
                        MadeCard.imagecode = "_6H"
                    ElseIf CurrCard = 6 Then
                        MadeCard.Number = 6
                        MadeCard.Type = "7"
                        MadeCard.imagecode = "_7H"
                    ElseIf CurrCard = 7 Then
                        MadeCard.Number = 7
                        MadeCard.Type = "8"
                        MadeCard.imagecode = "_8H"
                    ElseIf CurrCard = 8 Then
                        MadeCard.Number = 8
                        MadeCard.Type = "9"
                        MadeCard.imagecode = "_9H"
                    ElseIf CurrCard = 9 Then
                        MadeCard.Number = 9
                        MadeCard.Type = "10"
                        MadeCard.imagecode = "_10H"
                    End If

                ElseIf CurrCard = 10 Then
                    MadeCard.Number = 13
                    MadeCard.Type = "A"
                    MadeCard.imagecode = "_AH"

                ElseIf CurrCard > 10 And CurrCard <= 13 Then
                    If CurrCard = 11 Then
                        MadeCard.Type = "J"
                        MadeCard.imagecode = "_JH"
                        MadeCard.Number = 10
                    ElseIf CurrCard = 12 Then
                        MadeCard.Type = "Q"
                        MadeCard.imagecode = "_QH"
                        MadeCard.Number = 11
                    ElseIf CurrCard = 13 Then
                        MadeCard.Type = "K"
                        MadeCard.imagecode = "_KH"
                        MadeCard.Number = 12
                    End If

                End If
            End If



            If CurrCard > 13 And CurrCard <= 26 Then
                MadeCard.Suit = "S"
                If CurrCard > 13 And CurrCard <= 22 Then
                    If CurrCard = 14 Then
                        MadeCard.Number = 1
                        MadeCard.Type = "2"
                        MadeCard.imagecode = "_2S"
                    ElseIf CurrCard = 15 Then
                        MadeCard.Number = 2
                        MadeCard.Type = "3"
                        MadeCard.imagecode = "_3S"
                    ElseIf CurrCard = 16 Then
                        MadeCard.Number = 3
                        MadeCard.Type = "4"
                        MadeCard.imagecode = "_4S"
                    ElseIf CurrCard = 17 Then
                        MadeCard.Number = 4
                        MadeCard.Type = "5"
                        MadeCard.imagecode = "_5S"
                    ElseIf CurrCard = 18 Then
                        MadeCard.Number = 5
                        MadeCard.Type = "6"
                        MadeCard.imagecode = "_6S"
                    ElseIf CurrCard = 19 Then
                        MadeCard.Number = 6
                        MadeCard.Type = "7"
                        MadeCard.imagecode = "_7S"
                    ElseIf CurrCard = 20 Then
                        MadeCard.Number = 7
                        MadeCard.Type = "8"
                        MadeCard.imagecode = "_8S"
                    ElseIf CurrCard = 21 Then
                        MadeCard.Number = 8
                        MadeCard.Type = "9"
                        MadeCard.imagecode = "_9S"
                    ElseIf CurrCard = 22 Then
                        MadeCard.Number = 9
                        MadeCard.Type = "10"
                        MadeCard.imagecode = "_10S"
                    End If

                ElseIf CurrCard = 23 Then
                    MadeCard.Number = 13
                    MadeCard.Type = "A"
                    MadeCard.imagecode = "_AS"

                ElseIf CurrCard > 23 And CurrCard <= 26 Then
                    If CurrCard = 24 Then
                        MadeCard.Type = "J"
                        MadeCard.Number = 10
                        MadeCard.imagecode = "_JS"
                    ElseIf CurrCard = 25 Then
                        MadeCard.Type = "Q"
                        MadeCard.imagecode = "_QS"
                        MadeCard.Number = 11
                    ElseIf CurrCard = 26 Then
                        MadeCard.Type = "K"
                        MadeCard.imagecode = "_KS"
                        MadeCard.Number = 12
                    End If


                End If
            End If



            If CurrCard > 26 And CurrCard <= 39 Then
                MadeCard.Suit = "C"
                If CurrCard > 26 And CurrCard <= 35 Then
                    If CurrCard = 27 Then
                        MadeCard.Number = 1
                        MadeCard.Type = "2"
                        MadeCard.imagecode = "_2C"
                    ElseIf CurrCard = 28 Then
                        MadeCard.Number = 2
                        MadeCard.Type = "3"
                        MadeCard.imagecode = "_3C"
                    ElseIf CurrCard = 29 Then
                        MadeCard.Number = 3
                        MadeCard.Type = "4"
                        MadeCard.imagecode = "_4C"
                    ElseIf CurrCard = 30 Then
                        MadeCard.Number = 4
                        MadeCard.Type = "5"
                        MadeCard.imagecode = "_5C"
                    ElseIf CurrCard = 31 Then
                        MadeCard.Number = 5
                        MadeCard.Type = "6"
                        MadeCard.imagecode = "_6C"
                    ElseIf CurrCard = 32 Then
                        MadeCard.Number = 6
                        MadeCard.Type = "7"
                        MadeCard.imagecode = "_7C"
                    ElseIf CurrCard = 33 Then
                        MadeCard.Number = 7
                        MadeCard.Type = "8"
                        MadeCard.imagecode = "_8C"
                    ElseIf CurrCard = 34 Then
                        MadeCard.Number = 8
                        MadeCard.Type = "9"
                        MadeCard.imagecode = "_9C"
                    ElseIf CurrCard = 35 Then
                        MadeCard.Number = 9
                        MadeCard.Type = "10"
                        MadeCard.imagecode = "_10C"
                    End If

                ElseIf CurrCard = 36 Then
                    MadeCard.Number = 13
                    MadeCard.Type = "A"
                    MadeCard.imagecode = "_AC"

                ElseIf CurrCard > 36 And CurrCard <= 39 Then
                    If CurrCard = 37 Then
                        MadeCard.Type = "J"
                        MadeCard.imagecode = "_JC"
                        MadeCard.Number = 10
                    ElseIf CurrCard = 38 Then
                        MadeCard.Type = "Q"
                        MadeCard.imagecode = "_QC"
                        MadeCard.Number = 11
                    ElseIf CurrCard = 39 Then
                        MadeCard.Type = "K"
                        MadeCard.imagecode = "_KC"
                        MadeCard.Number = 12
                    End If
                End If
            End If



            If CurrCard > 39 And CurrCard <= 52 Then
                MadeCard.Suit = "D"
                If CurrCard > 39 And CurrCard <= 48 Then
                    If CurrCard = 40 Then
                        MadeCard.Number = 1
                        MadeCard.Type = "2"
                        MadeCard.imagecode = "_2D"
                    ElseIf CurrCard = 41 Then
                        MadeCard.Number = 2
                        MadeCard.Type = "3"
                        MadeCard.imagecode = "_3D"
                    ElseIf CurrCard = 42 Then
                        MadeCard.Number = 3
                        MadeCard.Type = "4"
                        MadeCard.imagecode = "_4D"
                    ElseIf CurrCard = 43 Then
                        MadeCard.Number = 4
                        MadeCard.Type = "5"
                        MadeCard.imagecode = "_5D"
                    ElseIf CurrCard = 44 Then
                        MadeCard.Number = 5
                        MadeCard.Type = "6"
                        MadeCard.imagecode = "_6D"
                    ElseIf CurrCard = 45 Then
                        MadeCard.Number = 6
                        MadeCard.Type = "7"
                        MadeCard.imagecode = "_7D"
                    ElseIf CurrCard = 46 Then
                        MadeCard.Number = 7
                        MadeCard.Type = "8"
                        MadeCard.imagecode = "_8D"
                    ElseIf CurrCard = 47 Then
                        MadeCard.Number = 8
                        MadeCard.Type = "9"
                        MadeCard.imagecode = "_9D"
                    ElseIf CurrCard = 48 Then
                        MadeCard.Number = 9
                        MadeCard.Type = "10"
                        MadeCard.imagecode = "_10D"
                    End If

                ElseIf CurrCard = 49 Then
                    MadeCard.Number = 13
                    MadeCard.Type = "A"
                    MadeCard.imagecode = "_AD"


                ElseIf CurrCard >= 50 And CurrCard <= 52 Then
                    If CurrCard = 50 Then
                        MadeCard.Type = "J"
                        MadeCard.imagecode = "_JD"
                        MadeCard.Number = 10
                    ElseIf CurrCard = 51 Then
                        MadeCard.Type = "Q"
                        MadeCard.imagecode = "_QD"
                        MadeCard.Number = 11
                    ElseIf CurrCard = 52 Then
                        MadeCard.Type = "K"
                        MadeCard.imagecode = "_KD"
                        MadeCard.Number = 12
                    End If

                End If
            End If

            If SettingsForGame.BotsIn = 1 Then
                If playerCards.Count <> 9 Then
                    playerCards.Add(MadeCard)
                ElseIf Comp1Cards.Count <> 9 Then

                    Comp1Cards.Add(MadeCard)
                Else
                    SpareCards.Add(MadeCard)
                End If

            ElseIf SettingsForGame.BotsIn = 2 Then
                If playerCards.Count <> 9 Then
                    playerCards.Add(MadeCard)
                ElseIf Comp1Cards.Count <> 9 Then
                    Comp1Cards.Add(MadeCard)
                ElseIf Comp2Cards.Count <> 9 Then
                    Comp2Cards.Add(MadeCard)
                Else
                    SpareCards.Add(MadeCard)
                End If

            ElseIf SettingsForGame.BotsIn Then
                If playerCards.Count <> 9 Then
                    playerCards.Add(MadeCard)
                ElseIf Comp1Cards.Count <> 9 Then
                    Comp1Cards.Add(MadeCard)
                ElseIf Comp2Cards.Count <> 9 Then
                    Comp2Cards.Add(MadeCard)
                ElseIf Comp3Cards.Count <> 9 Then
                    Comp3Cards.Add(MadeCard)
                Else
                    SpareCards.Add(MadeCard)
                End If
            End If



        Next
        Return New Tuple(Of List(Of Card), List(Of Card), List(Of Card), List(Of Card), List(Of Card))(playerCards, SpareCards, Comp1Cards, Comp2Cards, Comp3Cards)

    End Function
End Class

