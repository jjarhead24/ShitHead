Public Class Quit
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdYes.Click
        MainMenu.SaveToFile()
        Me.Close()

    End Sub

    Private Sub cmdNo_Click(sender As Object, e As EventArgs) Handles cmdNo.Click
        MainMenu.Show()
        Me.Hide()
    End Sub
End Class