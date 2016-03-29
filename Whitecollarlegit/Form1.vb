Public Module Var
    Public playerName As String
    Public file As System.IO.StreamWriter
    Public fileAccount As String
    Public Accounts(30) As String
End Module
Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As Integer = MessageBox.Show("Are you sure?", "Quit", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("Good choice!")
        ElseIf result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Name = InputBox("Input Name: ", "Name")
    End Sub

    Private Sub BtnNavInstructions_Click(sender As Object, e As EventArgs) Handles BtnNavInstructions.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Level1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Arcade.Show()
    End Sub
End Class
