Public Class Level2
    Public letters(25) As Button
    Dim accept As Integer
    Dim space As Button
    Dim buttonpoint As Point
    Dim qwerty As String = "QWERTYUIOPASDFGHJKLZXCVBNM"
    Dim myfont As Font = New Font(FontFamily.GenericSansSerif, 14.0F, FontStyle.Bold)
    Dim wordnum As Integer
    Dim guessletter As String
    Dim guesses As String
    Dim Words(5) As String
    Dim correct As Boolean
    Dim word As String
    Dim letterpos As Integer
    Private Sub Level2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

        'accept = MsgBox("Accept?", 4, "Accept")
        'If accept = 6 Then
        '    Me.Show()
        'Else
        '    End
        'End If


        buttonpoint.X = 535
        buttonpoint.Y = 65
        'Define buttons in button array
        For x = 0 To 25
            letters(x) = New Button
            letters(x).Width = 35
            letters(x).Height = 35
            letters(x).Location = buttonpoint
            buttonpoint.X = buttonpoint.X + 40
            letters(x).Text = Mid(qwerty, (x + 1), 1)
            letters(x).BackColor = Color.DodgerBlue
            letters(x).ForeColor = Color.White
            letters(x).FlatStyle = FlatStyle.Flat
            letters(x).Font = myfont
            If x = 9 Then
                buttonpoint.Y = 105
                buttonpoint.X = 555
            End If
            If x = 18 Then
                buttonpoint.Y = 145
                buttonpoint.X = 575
            End If
            AddHandler letters(x).Click, AddressOf Clicked
            Me.Controls.Add(letters(x))
        Next
        buttonpoint.X = 655
        buttonpoint.Y = 185
        Space = New Button
        Space.Width = 195
        Space.Height = 35
        Space.Location = buttonpoint
        Space.BackColor = Color.DodgerBlue
        Space.ForeColor = Color.White
        Space.FlatStyle = FlatStyle.Flat
        Space.Font = myfont
        Space.Text = "Space"
        AddHandler Space.Click, AddressOf Clicked
        Me.Controls.Add(Space)
        genWord()
    End Sub
End Class