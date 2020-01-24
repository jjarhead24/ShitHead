Public Class Player
    Public Name As String
    Public IsSelf As Boolean
    Public Cards As List(Of Card)
    Public Sub New(_name As String)
        Name = _name
        IsSelf = _name = Environment.UserName
        Cards = New List(Of Card)()
    End Sub
End Class
