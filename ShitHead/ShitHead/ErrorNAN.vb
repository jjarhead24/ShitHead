Public Class ErrorNAN
    Private Sub Okay_Click(sender As Object, e As EventArgs) Handles Okay.Click
        Me.Close()

    End Sub

    Private Sub ErrorNAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SettingsForGame.ErrorType = "NAN" Then

        ElseIf SettingsForGame.ErrorType = "Too many" Then
            Label1.Text = "The amount of bills you entered is too" & ControlChars.NewLine & "many please enter a lower amount"
        End If
    End Sub
End Class