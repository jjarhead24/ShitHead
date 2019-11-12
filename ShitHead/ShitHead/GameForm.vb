Public Class GameForm
    Dim playerCards As New List(Of Card)
    Dim SpareCards As New List(Of Card)
    Dim Comp1Cards As New List(Of Card)
    Dim card As Card
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PBList As New List(Of PictureBox) From {TableCard1, TableCard2, TableCard3}
        Dim PFaceDList As New List(Of PictureBox) From {FaceDown1, FaceDown2, FaceDown3}
        Dim compList As New List(Of PictureBox) From {CompTable1, CompTable2, CompTable3}
        Dim CFaceDList As New List(Of PictureBox) From {CDown1, CDown2, CDown3}
        Dim PHandList As New List(Of PictureBox) From {HandCard1, HandCard2, HandCard3}
        Dim CardVal As String

        Me.WindowState = FormWindowState.Maximized




        'Try
        '    For Each card In playerCards
        '        ListBox1.Items.Add($"{card.Suit} - {card.Type} ")
        '    Next
        '    For Each card In SpareCards
        '        ListBox2.Items.Add($"{card.Suit} - {card.Type} ")
        '    Next
        'Catch ex As Exception

        'End Try
        'Dim l As Integer
        'For l = 3 To 5


        '    card = playerCards(l)
        '    CardVal = "_" + card.Type + card.Suit
        '    PBList(l - 3).Image = My.Resources.ResourceManager.GetObject(CardVal)
        '    PBList(l - 3).Tag = card.Number


        'Next
        'For l = 0 To 2
        '    PFaceDList(l).Tag = card.Number
        'Next

        'For l = 6 To 8
        '    card = playerCards(l)
        '    CardVal = "_" + card.Type + card.Suit
        '    PHandList(l - 6).Image = My.Resources.ResourceManager.GetObject(CardVal)
        '    PHandList(l - 6).Tag = card.Number
        'Next



        'For l = 3 To 5

        '    card = Comp1Cards(l)
        '    CardVal = "_" + card.Type + card.Suit
        '    compList(l - 3).Image = My.Resources.ResourceManager.GetObject(CardVal)
        '    compList(l - 3).Tag = card.Number


        'Next
        'For l = 0 To 2
        '    CFaceDList(l).Tag = card.Number
        'Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles CmdClose.Click
        Quit.Show()
        Me.Hide()
    End Sub
End Class
