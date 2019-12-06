Public Class Quit
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdYes.Click
        MainMenu.SaveToFile()
        End
    End Sub

    Private Sub cmdNo_Click(sender As Object, e As EventArgs) Handles cmdNo.Click
        If GameForm.FormFrom = "Menu" Then
            MainMenu.Show()
            Me.Hide()
        ElseIf GameForm.FormFrom = "Game" Then
            GameForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Quit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdYes.Focus()
    End Sub
End Class