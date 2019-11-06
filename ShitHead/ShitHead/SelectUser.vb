Public Class SelectUser
    Private Sub lbUsers_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbUsers.MouseDoubleClick
        If lbUsers.SelectedIndex >= 0 Then
            Dim item = lbUsers.Items(lbUsers.SelectedIndex)
            MainMenu.CurrentUser = item
            Me.Hide()
            MainMenu.Show()
        End If
    End Sub

    Private Sub SelectUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMenu.LoadFromFile()
        For Each keypair In MainMenu.Scores
            lbUsers.Items.Add(keypair.Key)
        Next
        If Not MainMenu.Scores.ContainsKey(Environment.UserName) Then
            lbUsers.Items.Add(Environment.UserName)
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim input = InputBox("Enter new username", "New Username", Environment.UserName)
        If Not String.IsNullOrWhiteSpace(input) Then
            If input.Contains(" ") OrElse input.Contains(":") Then
                MsgBox("Invalid name")
                Return
            End If
            lbUsers.Items.Add(input)
            MainMenu.CurrentUser = input
            MainMenu.Scores(input) = 0
            MainMenu.SaveToFile()
        End If
    End Sub
End Class