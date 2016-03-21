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

    End Sub

    Private Sub BtnNavInstructions_Click(sender As Object, e As EventArgs) Handles BtnNavInstructions.Click
        Form2.Show()
    End Sub
End Class
