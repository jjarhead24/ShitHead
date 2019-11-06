Public Class GameForm
    Dim playerCards As New List(Of Card)
    Dim SpareCards As New List(Of Card)
    Dim PBList As New List(Of PictureBox) From {TableCard1, TableCard2, TableCard3}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim ReturnedLists = Card.GenCards()
        playerCards = ReturnedLists.Item1
        SpareCards = ReturnedLists.Item2
        Try
            For Each card In playerCards
                ListBox1.Items.Add($"{card.Suit} - {card.Type} ")
            Next
            For Each card In SpareCards
                ListBox2.Items.Add($"{card.Suit} - {card.Type} ")
            Next
        Catch ex As Exception

        End Try
        'PBList
        Dim l As Integer
        For l = 0 To 2
            Dim pb = PBList(l)
            Dim CardVal As String
            Dim CardSuit As String
            Dim CardType As String

            'CardVal = "_" + Card.Type + Card.Suit
            'TableCard1.Image = My.Resources.ResourceManager.GetObject(CardVal)


        Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles CmdClose.Click
        Quit.Show()
        Me.Hide()
    End Sub
End Class
