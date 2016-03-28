Public Module Variables
    Public Points As Integer
End Module
Public Class Arcade
    Dim buttonpoint As Point
    Dim myfont As Font = New Font(FontFamily.GenericSansSerif, 14.0F, FontStyle.Bold)
    Dim letterpos As Integer
    Dim characters(35) As Button
    Dim correct As Integer
    Dim incorrect As Integer
    Private Sub Arcade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buttonpoint.X = 140
        buttonpoint.Y = 420
        For x = 0 To 35
            characters(x) = New Button
            characters(x).Width = 300
            characters(x).Height = 35
            characters(x).Location = buttonpoint
            characters(x).BackColor = Color.DodgerBlue
            characters(x).ForeColor = Color.White
            characters(x).FlatStyle = FlatStyle.Flat
            characters(x).Font = myfont
            AddHandler characters(x).Click, AddressOf Clicked
            Me.Controls.Add(characters(x))
            If x Mod 4 = 0 Then
                buttonpoint.Y = 420
            End If
        Next
        characters(0).Text = "Peter Burke"
        characters(1).Text = "Sara Ellis"
        characters(2).Text = "Neal Caffrey"
        characters(3).Text = "Mozzie"
        characters(2).AccessibleDescription = "!"
        characters(4).Text = "Elizabeth Burke"
        characters(5).Text = "Peter Burke"
        characters(6).Text = "Clinton Jones"
        characters(7).Text = "Neal Caffrey"
        characters(5).AccessibleDescription = "!"
        characters(8).Text = "Diana Berrigan"
        characters(9).Text = "Elizabeth Burke"
        characters(10).Text = "Alexandra Hunter"
        characters(11).Text = "Mozzie"
        characters(8).AccessibleDescription = "!"
        characters(12).Text = "Peter Burke"
        characters(13).Text = "Sara Ellis"
        characters(14).Text = "Kate Moreau"
        characters(15).Text = "Elizabeth Burke"
        characters(15).AccessibleDescription = "!"
        characters(16).Text = "Clinton Jones"
        characters(17).Text = "Peter Burke"
        characters(18).Text = "Neal Caffrey"
        characters(19).Text = "Mozzie"
        characters(16).AccessibleDescription = "!"
        characters(20).Text = "Sara Ellis"
        characters(21).Text = "June Ellington"
        characters(22).Text = "Kate Moreau"
        characters(23).Text = "Diana Berrigan"
        characters(21).AccessibleDescription = "!"
        characters(24).Text = "Sara Ellis"
        characters(25).Text = "Peter Burke"
        characters(26).Text = "Mozzie"
        characters(27).Text = "Kate Moreau"
        characters(27).AccessibleDescription = "!"
        characters(28).Text = "Mozzie"
        characters(29).Text = "Peter Burke"
        characters(30).Text = "Neal Caffrey"
        characters(31).Text = "Clinton Jones"
        characters(28).AccessibleDescription = "!"
        characters(32).Text = "Sara Ellis"
        characters(33).Text = "Diana Berrigan"
        characters(34).Text = "Kate Moreau"
        characters(35).Text = "June Ellington"
        characters(32).AccessibleDescription = "!"
        For x = 0 To 35
            characters(x).Enabled = False
            characters(x).Hide()
        Next
        Randomize()
        lblPoint.Text = ""
    End Sub


    Private Sub Clicked(sender As System.Object, e As System.EventArgs)
        If sender.AccessibleDescription = "!" Then
            lblTime.Text += 10
            correct += 1
        Else lblTime.Text -= 10
            incorrect += 1
        End If
        lblPoint.Text = correct / incorrect
        genPic()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        genPic()
        Timer1.Start()
        btnStart.Enabled = False
    End Sub

    Private Sub genPic()
        Dim pic As Integer
        pic = (9 * Rnd() - 1)
        If pic = 1 Then
            picChar.Image = imgChars.Images(1)
            For x = 0 To 3
                characters(x).Show()
                characters(x).Enabled = True
            Next
        ElseIf pic = 2
            picChar.Image = imgChars.Images(2)
            For x = 4 To 7
                characters(x).Show()
                characters(x).Enabled = True
            Next
        ElseIf pic = 3
            picChar.Image = imgChars.Images(3)
            For x = 8 To 11
                characters(x).Show()
                characters(x).Enabled = True
            Next
        ElseIf pic = 4
            picChar.Image = imgChars.Images(4)
            For x = 12 To 15
                characters(x).Show()
                characters(x).Enabled = True
            Next
        ElseIf pic = 5
            picChar.Image = imgChars.Images(5)
            For x = 16 To 19
                characters(x).Show()
                characters(x).Enabled = True
            Next
        ElseIf pic = 6
            picChar.Image = imgChars.Images(6)
            For x = 20 To 23
                characters(x).Show()
                characters(x).Enabled = True
            Next
        ElseIf pic = 7
            picChar.Image = imgChars.Images(7)
            For x = 24 To 27
                characters(x).Show()
                characters(x).Enabled = True
            Next
        ElseIf pic = 8
            picChar.Image = imgChars.Images(8)
            For x = 28 To 31
                characters(x).Show()
                characters(x).Enabled = True
            Next
        ElseIf pic = 9
            picChar.Image = imgChars.Images(9)
            For x = 32 To 35
                characters(x).Show()
                characters(x).Enabled = True
            Next
        End If
    End Sub

    Private Sub Time_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text -= 1
        If lblTime.Text = 0 Then
            Points = Points + (correct / incorrect)
            MsgBox("Congrats, " & Name & " you got:" & vbCrLf & correct & "correct!" & vbCrLf & "&" & incorrect & "incorrect" & "Your score is: " & (correct / incorrect) & vbCrLf & "Press 'Start' to play again!")
            btnStart.Enabled = True
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        MsgBox("Total points earned:" & Points)

        Me.Close()
        Form1.Show()
    End Sub
End Class