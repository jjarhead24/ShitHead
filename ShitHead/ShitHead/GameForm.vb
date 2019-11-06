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
                ListBox1.Items.Add($"{card.Suit} - {card.Type} - {card.Number}")
            Next
            For Each card In SpareCards
                ListBox2.Items.Add($"{card.Suit} - {card.Type} - {card.Number}")
            Next
        Catch ex As Exception

        End Try
        Dim l As Integer
        For l = 0 To 2
            Dim rm As Resources.ResourceManager = My.Resources.ResourceManager
            Dim resname As String = "5C"
            Dim p As Image = CType(rm.GetObject("\\cca07\C14\SeyJar14\GitHub\ShitHead\ShitHead\ShitHead\Resources\2H.png"), Image)
            Dim pb = PBList(l)

            'Dim cardim As Image = Image.FromFile("\\cca07\C14\SeyJar14\GitHub\ShitHead\ShitHead\ShitHead\Resources\2H.png")

            Dim CardVal As String = "5C"

            'pb.Image = CType(rm.GetObject("AC.png"), Image)


            'pb.Image = My.Resources.AC




        Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles CmdClose.Click
        Quit.Show()
        Me.Hide()
    End Sub
End Class
