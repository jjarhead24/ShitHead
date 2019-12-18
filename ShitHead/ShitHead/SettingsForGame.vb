Public Class SettingsForGame
    Public BillsIn As Integer
    Public ErrorType As String
    Public BotsIn As Integer
    Private Sub SettingsForGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BotNum.Text = BotCount.Value

        PayIn.Maximum = MainMenu.Score
        PayIn.TickFrequency = PayIn.Maximum / 22

        PayInNum.Text = PayIn.Value
    End Sub

    Private Sub BotCount_Scroll(sender As Object, e As EventArgs) Handles BotCount.Scroll
        BotNum.Text = BotCount.Value
    End Sub

    Private Sub SubmitBills_Click(sender As Object, e As EventArgs) Handles SubmitBills.Click
        Try
            BillsIn = CustomAmount.Text
            If BillsIn > MainMenu.Score Then
                BillsIn = MainMenu.Score
                PayInNum.Text = BillsIn
                PayIn.Value = BillsIn
                ErrorType = "Too many"
                ErrorNAN.Show()
                PayInNum.Text = 0
                CustomAmount.Text = ""
                PayIn.Value = 0
            Else
                PayInNum.Text = BillsIn
                PayIn.Value = BillsIn
            End If
        Catch ex As Exception
            ErrorType = "NAN"
            ErrorNAN.Show()
            PayInNum.Text = 0
            CustomAmount.Text = ""
        End Try

    End Sub

    Private Sub PayIn_Scroll(sender As Object, e As EventArgs) Handles PayIn.Scroll
        PayInNum.Text = PayIn.Value
    End Sub

    Private Sub CustomAmount_Click(sender As Object, e As EventArgs) Handles CustomAmount.Click
        CustomAmount.Text = ""
    End Sub

    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click
        BotsIn = BotNum.Text
        BillsIn = PayInNum.Text
        card_swap.Show()
        Me.Hide()
    End Sub
End Class