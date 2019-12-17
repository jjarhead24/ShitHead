Public Class SettingsForGame
    Private Sub SettingsForGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BotNum.Text = BotCount.Value

        PayIn.Maximum = MainMenu.Score
        PayIn.TickFrequency = PayIn.Maximum / 22
    End Sub

    Private Sub BotCount_Scroll(sender As Object, e As EventArgs) Handles BotCount.Scroll
        BotNum.Text = BotCount.Value
    End Sub
End Class