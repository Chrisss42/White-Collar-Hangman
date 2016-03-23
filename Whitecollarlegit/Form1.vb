Public Module Var
    Public Name As String
    Public file As System.IO.StreamWriter
    'Public fileReader As New System.IO.StreamReader("E:\Visual Studio Community 2015\VB\VBProjects\White-Collar-Hangman\Whitecollarlegit\Resources\accounts.txt")
    Public fileAccount As String
    Public Accounts(30) As String
End Module
Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As Integer = MessageBox.Show("Are you sure?", "Quit", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("Good choice!")
        ElseIf result = DialogResult.Yes Then
            'file = My.Computer.FileSystem.OpenTextFileWriter("E:\Visual Studio Community 2015\VB\VBProjects\White-Collar-Hangman\Whitecollarlegit\Resources\accounts.txt", True)
            'file.WriteLine(Points)
            'file.WriteLine(Trust)
            'file.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Name = InputBox("Input Name: ", "Name")
        'Do While fileReader.Peek <> -1
        '    fileAccount = fileReader.ReadLine()
        'Loop
        'Accounts = fileAccount.Split(",")
        'For x = 0 To UBound(Accounts)
        '    MsgBox(Accounts(x))
        'Next
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
