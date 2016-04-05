Public Module Var
    Public playerName As String
End Module
Public Class MainMenu
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Quit confirmation
        Dim result As Integer = MessageBox.Show("Are you sure?", "Quit", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("Good choice!")
        ElseIf result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get player's name into a global variable
        playerName = InputBox("Input Name: ", "Name")
        'Play opening music
        PlayBGMusic()
    End Sub

    Sub PlayBGMusic()
        'My.Computer.Audio.Play(My.Resources.WCOpening)
    End Sub

    Private Sub BtnNavInstructions_Click(sender As Object, e As EventArgs) Handles BtnNavInstructions.Click
        'Show instructions
        Instructions.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Go to campaign
        Me.Hide()
        Level1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Start arcade
        Me.Hide()
        Arcade.Show()
    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        'Go to the street (shop)
        Me.Hide()
        Street.Show()
    End Sub
End Class
