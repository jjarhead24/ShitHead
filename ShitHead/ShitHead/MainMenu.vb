Imports System.IO

Public Class MainMenu
    Public Scores As New Dictionary(Of String, Integer)

    Public CurrentUser As String = Environment.UserName
    Public Property Score As Integer
        Get
            Dim scrcccc = 0
            Scores.TryGetValue(CurrentUser, scrcccc)
            Return scrcccc
        End Get
        Set(value As Integer)
            Scores(CurrentUser) = value
        End Set
    End Property

    ''' <summary>
    ''' Loads the Scores dictionary from the text file
    ''' </summary>
    Public Sub LoadFromFile()
        Dim contents As String()
        Try
            contents = System.IO.File.ReadAllLines("scores.txt")
        Catch ex As FileNotFoundException
            contents = {$"{Environment.UserName}:0"}
        End Try
        For Each line As String In contents
            line = line.TrimEnd()
            Dim split = line.Split(":")
            Scores(split(0)) = Integer.Parse(split(1))
        Next
    End Sub

    ''' <summary>
    ''' To be called when the <see cref="Scores"/> dictionary is updated
    ''' Causes it to be wrote to text file
    ''' MainMenu.Score = 
    ''' </summary>
    Public Sub SaveToFile()
        Dim contents = ""
        For Each keypair In Scores
            contents += $"{keypair.Key}:{keypair.Value}{Environment.NewLine}"
        Next
        System.IO.File.WriteAllText("scores.txt", contents)
    End Sub


    Private Sub cmdPlay_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click
        SettingsForGame.Show()
        Me.Hide()
    End Sub

    Private Sub cmdStore_Click(sender As Object, e As EventArgs) Handles cmdStore.Click
        Store.Show()
        Me.Hide()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        GameForm.FormFrom = "Menu"
        Me.Hide()
        Quit.Show()
    End Sub

    Private Sub cmdLogOut_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFromFile()
        Label2.Text = "Your Bill balance is: " & Score
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        CurrentUser = Nothing
        Me.Hide()
        SelectUser.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox($"{CurrentUser} = {Score}")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class