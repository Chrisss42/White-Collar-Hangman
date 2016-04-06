'By Ayush Gupta and Chris Green (31/3/2016)
'Arcade mode. Gives points for spending at the Street. Randomly generates buttons associated with a picture to be guessed.
Public Module Variables
    Public intPoints As Integer
End Module
Public Class Arcade
    Dim buttonpoint As Point
    Dim myfont As Font = New Font(FontFamily.GenericSansSerif, 14.0F, FontStyle.Bold)
    Dim characters(35) As Button
    Dim intCorrect As Integer
    Dim intInCorrect As Integer
    Dim intAddPoints As Integer
    Private Sub Arcade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create all buttons then hide & disable all of them
        buttonpoint.X = 140
        buttonpoint.Y = 420
        For x = 0 To 35
            If x Mod 4 = 0 Then
                buttonpoint.Y = 420
            End If
            characters(x) = New Button
            characters(x).Width = 300
            characters(x).Height = 35
            characters(x).Location = buttonpoint
            characters(x).BackColor = Color.DodgerBlue
            characters(x).ForeColor = Color.White
            characters(x).FlatStyle = FlatStyle.Flat
            characters(x).Font = myfont
            buttonpoint.Y += 45
            AddHandler characters(x).Click, AddressOf Clicked
            Me.Controls.Add(characters(x))
        Next
        'Name the buttons, the exclamation mark shows the correct one
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
            characters(x).Visible = False
        Next
        Randomize() 'Fair :)
        lblPoint.Text = ""
    End Sub


    Private Sub Clicked(sender As System.Object, e As System.EventArgs)
        'If the answer is correct +10 sec and +1 correct, else -10 sec and +1 incorrect
        If sender.AccessibleDescription = "!" Then
            lblTime.Text += 10
            intCorrect += 1
        Else lblTime.Text -= 10
            intInCorrect += 1
        End If
        intAddPoints = intCorrect - intInCorrect
        lblPoint.Text = intPoints + intAddPoints
        genPic()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Reset incorrect/correct, and start the round
        intInCorrect = 0
        intCorrect = 0
        genPic()
        'Checks upgrade
        If ATime = True Then
            lblTime.Text = 60
        Else
            lblTime.Text = 30
        End If
        Timer1.Start()
        btnStart.Enabled = False
    End Sub

    Private Sub genPic()
        'Sub routine to create picture and buttons associated with said picture
        For x = 0 To 35
            characters(x).Enabled = False
            characters(x).Visible = False
        Next
        Dim pic As Integer
        pic = 9 * Rnd()
        If pic = 0 Then
            picChar.Image = imgChars.Images(0)
            For x = 0 To 3
                characters(x).Visible = True
                characters(x).Enabled = True
            Next
        ElseIf pic = 1
            picChar.Image = imgChars.Images(1)
            For x = 4 To 7
                characters(x).Visible = True
                characters(x).Enabled = True
            Next
        ElseIf pic = 2
            picChar.Image = imgChars.Images(2)
            For x = 8 To 11
                characters(x).Visible = True
                characters(x).Enabled = True
            Next
        ElseIf pic = 3
            picChar.Image = imgChars.Images(3)
            For x = 12 To 15
                characters(x).Visible = True
                characters(x).Enabled = True
            Next
        ElseIf pic = 4
            picChar.Image = imgChars.Images(4)
            For x = 16 To 19
                characters(x).Visible = True
                characters(x).Enabled = True
            Next
        ElseIf pic = 5
            picChar.Image = imgChars.Images(5)
            For x = 20 To 23
                characters(x).Visible = True
                characters(x).Enabled = True
            Next
        ElseIf pic = 6
            picChar.Image = imgChars.Images(6)
            For x = 24 To 27
                characters(x).Visible = True
                characters(x).Enabled = True
            Next
        ElseIf pic = 7
            picChar.Image = imgChars.Images(7)
            For x = 28 To 31
                characters(x).Visible = True
                characters(x).Enabled = True
            Next
        ElseIf pic = 8
            picChar.Image = imgChars.Images(8)
            For x = 32 To 35
                characters(x).Visible = True
                characters(x).Enabled = True
            Next
        End If
    End Sub

    Private Sub Time_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Ticks the timer, if it is <= 0 then it shows your score. Checks for upgrade
        If ATDep = True Then
            lblTime.Text -= 0.5
        Else lblTime.Text -= 1
        End If
        If lblTime.Text <= 30 Then
            'Plays 30 sec music
            ' My.Computer.Audio.Play(My.Resources.WCCredit)
        Else My.Computer.Audio.Stop()
        End If
        If lblTime.Text <= 0 Then
            Timer1.Stop()
            MsgBox("Congrats, " & playerName & " you got: " & vbCrLf & intCorrect & " correct!" & " & " & intInCorrect & " incorrect" & vbCrLf & "Your score is: " & intAddPoints & vbCrLf & "Press 'Start' to play again!")
            btnStart.Enabled = True
            lblPoint.Text = intPoints
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Shows total points before quitting
        If ADouble = True Then
            intAddPoints = intAddPoints * 2
        End If
        intPoints = intPoints + intAddPoints
        MsgBox("Total points earned: " & intPoints, 0, "Points")
        'Refreshes the labels on the main menu
        My.Forms.MainMenu.lblTrust.Text = "Trust: " & intTrust & "%"
        My.Forms.MainMenu.lblPoints.Text = "Points: " & intPoints
        My.Forms.MainMenu.lblLevel.Text = "Campaign Level: " & intLevel
        Me.Close()
        MainMenu.Show()
    End Sub
End Class