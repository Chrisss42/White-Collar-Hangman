Public Class Arcade
    Public letters(25) As Button
    Dim accept As Integer
    Dim space As Button
    Dim buttonpoint As Point
    Dim qwerty As String = "QWERTYUIOPASDFGHJKLZXCVBNM"
    Dim myfont As Font = New Font(FontFamily.GenericSansSerif, 14.0F, FontStyle.Bold)
    Dim wordnum As Integer
    Dim guessletter As String
    Dim correct As Boolean
    Dim letterpos As Integer
    Dim characters(35) As Button
    Private Sub Arcade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x = 0 To 35
            characters(x) = New Button
            characters(x).Width = 300
            characters(x).Height = 35
            characters(x).Location = buttonpoint
            characters(x).BackColor = Color.DodgerBlue
            characters(x).ForeColor = Color.White
            characters(x).FlatStyle = FlatStyle.Flat
            characters(x).Font = myfont
            If x Mod 4 = 0 Then
                buttonpoint.Y = 420
            End If
        Next
        characters(0).Text = ""
        characters(1).Text = ""
        characters(2).Text = ""
        characters(3).Text = ""
        characters(4).Text = ""
        characters(5).Text = ""
        characters(6).Text = ""
        characters(7).Text = ""
        characters(8).Text = ""
        characters(9).Text = ""
        characters(10).Text = ""
        characters(11).Text = ""
        characters(12).Text = ""
        characters(13).Text = ""
        characters(14).Text = ""
        characters(15).Text = ""
        characters(16).Text = ""
        characters(17).Text = ""
        characters(18).Text = ""
        characters(19).Text = ""
        characters(20).Text = ""
        characters(21).Text = ""
        characters(22).Text = ""
        characters(23).Text = ""
        characters(24).Text = ""
        characters(25).Text = ""
        characters(26).Text = ""
        characters(27).Text = ""
        characters(28).Text = ""
        characters(29).Text = ""
        characters(30).Text = ""
        characters(31).Text = ""
        characters(32).Text = ""
        characters(33).Text = ""
        characters(34).Text = ""
        characters(35).Text = ""

        For x = 0 To 35
            characters(x).Enabled = False
            characters(x).Hide()
        Next

        buttonpoint.X = 140
        buttonpoint.Y = 420
        lblFailed.Text = ""
        letterpos = 0
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
                buttonpoint.Y = 135
                buttonpoint.X = 855
            End If
            If x = 18 Then
                buttonpoint.Y = 175
                buttonpoint.X = 875
            End If
            AddHandler letters(x).Click, AddressOf Clicked
            Me.Controls.Add(letters(x))
        Next
        'Add a space bar!
        buttonpoint.X = 955
        buttonpoint.Y = 215
        Space = New Button
        Space.Width = 195
        Space.Height = 35
        Space.Location = buttonpoint
        Space.BackColor = Color.DodgerBlue
        Space.ForeColor = Color.White
        Space.FlatStyle = FlatStyle.Flat
        Space.Font = myfont
        Space.Text = " "
        AddHandler Space.Click, AddressOf Clicked
        Me.Controls.Add(Space)

    End Sub


    Private Sub Clicked(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

    End Sub
End Class