'By Ayush Gupta and Chris Green (31/3/2016)
'Shows the instructions for the game
Public Class Instructions
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Font for label1
        Dim Font As New Font("Instructions", 26, FontStyle.Bold)
        Label1.Font = Font
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Return to main menu
        Me.Close()
        MainMenu.Show()
    End Sub
End Class