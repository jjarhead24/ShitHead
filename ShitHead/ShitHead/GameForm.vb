Public Class GameForm
    Dim playerCards As New List(Of Card)
    Dim SpareCards As New List(Of Card)
    Dim Comp1Cards As New List(Of Card)
    Dim card As Card


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PTableList As New List(Of PictureBox) From {TableCard1, TableCard2, TableCard3}
        Dim PFaceDList As New List(Of PictureBox) From {FaceDown1, FaceDown2, FaceDown3}
        Dim compList As New List(Of PictureBox) From {CompTable1, CompTable2, CompTable3}
        Dim CFaceDList As New List(Of PictureBox) From {CDown1, CDown2, CDown3}
        Dim PHandList As New List(Of PictureBox) From {HandCard1, HandCard2, HandCard3}
        Dim FaceDLblList As New List(Of Label) From {FaceD1, FaceD2, FaceD3}
        Me.WindowState = FormWindowState.Maximized
        SetUp(PHandList, PTableList, PFaceDList, FaceDLblList)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles CmdClose.Click
        Quit.Show()
        Me.Hide()
    End Sub

    Private Sub SetUp(PHandlist, PTableList, PFaceDList, FaceDLblList)
        Dim i As Integer = 0
        For i = 0 To 2
            PHandlist(i).Image = My.Resources.ResourceManager.GetObject(card_swap.handpics(i))
            PHandlist(i).Tag = card_swap.handtag(i)
        Next

        For i = 0 To 2
            PTableList(i).Image = My.Resources.ResourceManager.GetObject(card_swap.tablepics(i))
            PTableList(i).Tag = card_swap.tabletag(i)
        Next

        For i = 0 To 2
            PFaceDList(i).Tag = card_swap.FaceDownNumList(i)
            FaceDLblList(i).Text = card_swap.FaceDownPicList(i)
        Next

        For i = 0 To 2
            MsgBox(PFaceDList(i).Tag)
        Next
    End Sub
End Class
