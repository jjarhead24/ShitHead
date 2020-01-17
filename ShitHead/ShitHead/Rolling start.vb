Public Class Rolling_start
    Structure Results
        Dim resPlayer As Integer
        Dim resNumber As Integer
    End Structure
    Dim Reslist As New List(Of Results)
    Dim Bot1res As New Results
    Dim Bot2res As New Results
    Dim Bot3res As New Results
    Dim playerRes As New Results
    Dim diceval As String
    Dim r As New Random
    Dim DiceList As New List(Of PictureBox) From {DiceShow, Bot1Dice, Bot2Dice, Bot3Dice}
    Dim draws As New List(Of Integer)
    Dim endList As Integer
    Dim drawlist As New List(Of Integer)
    Dim peopletoplay As New List(Of String)
    Private Sub RollDice_Click(sender As Object, e As EventArgs) Handles RollDice.Click
        Dim DiceList As New List(Of PictureBox) From {DiceShow, Bot1Dice, Bot2Dice, Bot3Dice}
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
            diceval = "Dice_" + Reslist(x).resNumber.ToString()
            MsgBox(diceval)
            DiceList(x).Image = My.Resources.ResourceManager.GetObject(diceval)
        Next

        endList = Reslist.Count

        For x = 0 To endList - 1
            For i = 0 To endList - 1
                If Reslist(x).resNumber = Reslist(i).resNumber Then
                    draws.Add(Reslist(x).resPlayer)
                    draws.Add(Reslist(i).resPlayer)
                End If
            Next
        Next
        For i = 0 To endList
            draws.Remove(i)
        Next
        draws.Add(0)
        If draws.Count = 0 Then
            FindWinner(Reslist)
        Else
            For i = 0 To Reslist.Count - 1
                drawlist.Add(Reslist(i).resPlayer)

            Next
        End If
        If drawlist.Contains(0) Then
            peopletoplay.Add("Player")
        ElseIf drawlist.Contains(1) Then
            peopletoplay.Add("Bot1")
        ElseIf drawlist.Contains(2) Then
            peopletoplay.Add("Bot2")
        ElseIf drawlist.Contains(3) Then
            peopletoplay.Add("Bot3")
        End If
        Rollagain(peopletoplay)
    End Sub

    Private Sub FindWinner(Reslist)
        Dim listPlayers As New List(Of Results)
        Dim highest As Integer = 0
        Dim highestplayer As Integer
        listPlayers.Add(Bot1res)
        listPlayers.Add(Bot2res)
        listPlayers.Add(Bot3res)
        listPlayers.Add(playerRes)
        For i = 0 To listPlayers.Count
            If listPlayers(i).resNumber > highest Then
                highest = listPlayers(i).resNumber
                highestplayer = listPlayers(i).resPlayer
            End If
        Next
        If highestplayer = 0 Then
            GameForm.FirstPlayer = 0
        ElseIf highestplayer = 1 Then
            GameForm.FirstPlayer = 1
        ElseIf highestplayer = 2 Then
            GameForm.FirstPlayer = 2
        ElseIf highestplayer = 3 Then
            GameForm.FirstPlayer = 3
        End If
    End Sub

    Dim NewRollerList As New List(Of String)

    Private Sub Rollagain(peopletoplay)

        RollDice.Hide()
        RollDiceAgain.Show()
        Reslist.Clear()
        If peopletoplay.Contains("Bot1") Then
            Bot1res.resNumber = r.Next(1, 6)
            NewRollerList.Add("Bot1")
        Else
            Bot1res.resNumber = 0
        End If
        If peopletoplay.Contains("Bot2") Then
            Bot2res.resNumber = r.Next(1, 6)
            NewRollerList.Add("Bot2")
        Else
            Bot2res.resNumber = 0
        End If
        If peopletoplay.Contains("Bot3") Then
            Bot2res.resNumber = r.Next(1, 6)
            NewRollerList.Add("Bot3")
        Else
            Bot3res.resNumber = 0
        End If
        If peopletoplay.Contains("Player") Then
            playerRes.resNumber = r.Next(1, 6)
            NewRollerList.Add("Player")
        Else
            playerRes.resNumber = 0
        End If
    End Sub

    Private Sub Rolling_start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RollDiceAgain.Hide()
    End Sub

    Private Sub RollDiceAgain_Click(sender As Object, e As EventArgs) Handles RollDiceAgain.Click
        If NewRollerList.Contains("Bot1") Then
            diceval = "Dice_" + Bot1res.ToString()
            MsgBox(diceval)
            Bot1Dice.Image = My.Resources.ResourceManager.GetObject(diceval)
            Reslist.Add(Bot1res)
        Else
            Bot1Dice.Hide()
            Bot1Roll.Hide()
        End If

        If NewRollerList.Contains("Bot2") Then
            diceval = "Dice_" + Bot2res.ToString()
            MsgBox(diceval)
            Bot2Dice.Image = My.Resources.ResourceManager.GetObject(diceval)
            Reslist.Add(Bot2res)
        Else
            Bot2Dice.Hide()
            Bot2Roll.Hide()
        End If

        If NewRollerList.Contains("Bot3") Then
            diceval = "Dice_" + Bot3res.ToString()
            MsgBox(diceval)
            Bot3Dice.Image = My.Resources.ResourceManager.GetObject(diceval)
            Reslist.Add(Bot3res)
        Else
            Bot3Dice.Hide()
            Bot3Roll.Hide()
        End If

        If NewRollerList.Contains("Player") Then
            diceval = "Dice_" + playerRes.ToString()
            MsgBox(diceval)
            DiceShow.Image = My.Resources.ResourceManager.GetObject(diceval)
            Reslist.Add(playerRes)
        Else
            DiceShow.Hide()
        End If
        endList = Reslist.Count

        For x = 0 To endList - 1
            For i = 0 To endList - 1
                If Reslist(x).resNumber = Reslist(i).resNumber Then
                    draws.Add(Reslist(x).resPlayer) 'wtf 
                    draws.Add(Reslist(i).resPlayer)
                End If
            Next
        Next
        For i = 0 To endList
            draws.Remove(i)
        Next

        If draws.Count = 0 Then
            FindWinner(Reslist)
        Else
            For i = 0 To Reslist.Count - 1
                drawlist.Add(Reslist(i).resPlayer)

            Next
        End If
        If drawlist.Contains(0) Then
            peopletoplay.Add("Player")
        ElseIf drawlist.Contains(1) Then
            peopletoplay.Add("Bot1")
        ElseIf drawlist.Contains(2) Then
            peopletoplay.Add("Bot2")
        ElseIf drawlist.Contains(3) Then
            peopletoplay.Add("Bot3")
        End If
        Rollagain(peopletoplay)

    End Sub
End Class