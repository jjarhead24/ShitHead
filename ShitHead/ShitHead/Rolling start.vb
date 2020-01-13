Public Class Rolling_start
    Structure Results
        Dim resPlayer As Integer
        Dim resNumber As Integer
    End Structure
    Private Sub RollDice_Click(sender As Object, e As EventArgs) Handles RollDice.Click

        Dim r As New Random
        Dim playerRes As New Results
        Dim Bot1res As New Results
        Dim Bot2res As New Results
        Dim Bot3res As New Results
        Dim DiceList As New List(Of PictureBox) From {DiceShow, Bot1Dice, Bot2Dice, Bot3Dice}
        Dim Reslist As New List(Of Results)
        Dim diceval As String
        Dim draws As New List(Of Integer)

        Bot1res.resNumber = r.Next(1, 6)
        Bot2res.resNumber = r.Next(1, 6)
        Bot3res.resNumber = r.Next(1, 6)
        playerRes.resNumber = r.Next(1, 6)

        playerRes.resPlayer = 0
        Bot1res.resPlayer = 1
        Bot2res.resPlayer = 2
        Bot3res.resPlayer = 3

        Reslist.Add(playerRes)
        Reslist.Add(Bot1res)
        Reslist.Add(Bot2res)
        Reslist.Add(Bot3res)

        For x = 0 To 3
            diceval = "Dice_" + Reslist(x).ToString()
            MsgBox(diceval)
            DiceList(x).Image = My.Resources.ResourceManager.GetObject(diceval)
        Next

        For x = 0 To Reslist.Count
            For i = 0 To Reslist.Count
                If Reslist(x).resNumber = Reslist(i).resNumber Then
                    draws.Add(Reslist(x).resPlayer)
                    draws.Add(Reslist(i).resPlayer)
                End If
            Next
        Next

        If draws.Count = 0 Then
            FindWinner(Reslist)
        Else

        End If

    End Sub

    Private Sub FindWinner(Reslist)

    End Sub
End Class