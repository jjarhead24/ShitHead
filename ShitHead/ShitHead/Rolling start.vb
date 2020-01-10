Public Class Rolling_start
    Private Sub RollDice_Click(sender As Object, e As EventArgs) Handles RollDice.Click
        Dim r As New Random
        Dim playerRes As New Integer
        Dim Bot1res As New Integer
        Dim Bot2res As New Integer
        Dim Bot3res As New Integer
        Dim DiceList As New List(Of PictureBox) From {DiceShow, Bot1Dice, Bot2Dice, Bot3Dice}
        Dim Reslist As New List(Of Integer)
        Dim diceval As String
        Bot1res = r.Next(1, 6)
        Bot2res = r.Next(1, 6)
        Bot3res = r.Next(1, 6)
        playerRes = r.Next(1, 6)

        Reslist.Add(playerRes)
        Reslist.Add(Bot1res)
        Reslist.Add(Bot2res)
        Reslist.Add(Bot3res)

        For x = 0 To 3
            diceval = "Dice_" + Reslist(x).ToString()
            MsgBox(diceval)
            DiceList(x).Image = My.Resources.ResourceManager.GetObject(diceval)
        Next
    End Sub
End Class