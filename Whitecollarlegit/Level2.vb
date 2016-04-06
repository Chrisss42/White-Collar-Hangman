'By Ayush Gupta and Chris Green (31/3/2016)
'Level two of the campaign. Gain trust from winning to spend in the Street. Users can guess the words based on the show White Collar.
Public Class Level2
    Public letters(26) As Button
    Dim buttonpoint As Point
    Dim strQWERTY As String = "QWERTYUIOPASDFGHJKLZXCVBNM "
    Dim myfont As Font = New Font(FontFamily.GenericSansSerif, 14.0F, FontStyle.Bold)
    Dim intWordNum As Integer
    Dim strGuessLetter As String
    Dim Words(5) As String
    Dim boolCorrect As Boolean
    Dim intLetterPos As Integer
    Dim lblWords(5) As Label
    Dim intAddTrust As Integer
    Private Sub Level2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If you are in prison, you can't play the campaign
        If intGetaways = -1 Then
            MsgBox("Sorry you are in prison. Buy more Getaways on The Street")
            Me.Close()
            Street.Show()
        End If
        'My.Computer.Audio.Play(My.Resources.WCBTDH)
        frmMsg2.ShowDialog(Me)
        picJail.BackgroundImage = Jailed.Images(0)
        'Creates the buttons
        buttonpoint.X = 835
        buttonpoint.Y = 95
        lblFailed.Text = ""
        intLetterPos = 0
        'Define buttons in button array
        For x = 0 To 26
            letters(x) = New Button
            letters(x).Width = 35
            letters(x).Height = 35
            letters(x).Location = buttonpoint
            buttonpoint.X = buttonpoint.X + 40
            letters(x).Text = Mid(strQWERTY, (x + 1), 1)
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
            If x = 25 Then
                buttonpoint.X = 955
                buttonpoint.Y = 215
            End If
            If x = 26 Then
                letters(x).Width = 195
                letters(x).Height = 35
            End If
            AddHandler letters(x).Click, AddressOf Clicked
            Me.Controls.Add(letters(x))
        Next
        'Words
        Words(0) = "GHOVAT"
        Words(1) = "VIOLENT CRIMES UNIT"
        Words(2) = "SAN DIEGO"
        Words(3) = "THE GHOST"
        Words(4) = "KIDNAPPED"
        Words(5) = "GOODBYE"
        'Labels
        lblWords(0) = lblWord1
        lblWords(1) = lblWord2
        lblWords(2) = lblWord3
        lblWords(3) = lblWord4
        lblWords(4) = lblWord5
        lblWords(5) = lblWord6
        lblPoint.Text = intTrust & "%"
    End Sub

    Private Sub Clicked(sender As System.Object, e As System.EventArgs)
        'Checks if the letter is in any of the labels; if not, adds letter to failed guesses and adds one to the picture
        strGuessLetter = sender.text
        sender.visible = False
        For x = 0 To 5
            If Words(0).Contains(strGuessLetter) = False And Words(1).Contains(strGuessLetter) = False And Words(2).Contains(strGuessLetter) = False And Words(3).Contains(strGuessLetter) = False And Words(4).Contains(strGuessLetter) = False And Words(5).Contains(strGuessLetter) = False Then
                If Len(lblFailed.Text) = 9 Then
                    MsgBox("You lose one getaway. Buy more on The Street.")
                    MainMenu.Show()
                    Me.Close()
                End If
                lblErrors.Text = Len(lblFailed.Text)
                picJail.Image = Jailed.Images(Len(lblFailed.Text))
                If lblFailed.Text.Contains(strGuessLetter) = False Then
                    lblFailed.Text = lblFailed.Text & strGuessLetter
                End If
            Else
                intLetterPos = 0
                'Makes sure if there are multiple letters of the same value, they are revealed
                Do While InStr(intLetterPos + 1, Words(x), strGuessLetter) > 0
                    intLetterPos = InStr(intLetterPos + 1, Words(x), strGuessLetter)
                    Mid(lblWords(x).Text, intLetterPos, 1) = strGuessLetter
                Loop
            End If
        Next

        'Sorry for the if statements, nothing else worked. I tried everything else.
        If Not lblWords(0).Text.Contains("?") Then
            If Not lblWords(1).Text.Contains("?") Then
                If Not lblWords(2).Text.Contains("?") Then
                    If Not lblWords(3).Text.Contains("?") Then
                        If Not lblWords(4).Text.Contains("?") Then
                            If Not lblWords(5).Text.Contains("?") Then
                                'Checks handicap upgrade and gives points without a handicap
                                If CHandicap = True Then
                                    If (Len(lblFailed.Text) <= 3) Then
                                        intAddTrust += 40
                                    ElseIf (Len(lblFailed.Text) <= 6) Then
                                        intAddTrust += 30
                                    Else intAddTrust += 20
                                    End If
                                End If
                                'Gives trust based on amount of letters the player got wrong and how much they already had
                                If CHandicap = False Then
                                    If intTrust <> 100 Then
                                        If (Len(lblFailed.Text) <= 3) Then
                                            If (intTrust >= 0 And intTrust <= 25) Then
                                                intAddTrust += 40
                                            ElseIf (intTrust >= 26 And intTrust <= 50) Then
                                                intAddTrust += 35
                                            Else intAddTrust += 30
                                            End If
                                        ElseIf (Len(lblFailed.Text) <= 6) Then
                                            If (intTrust >= 0 And intTrust <= 25) Then
                                                intAddTrust += 30
                                            ElseIf (intTrust >= 26 And intTrust <= 50) Then
                                                intAddTrust += 25
                                            Else intAddTrust += 20
                                            End If
                                        Else
                                            If (intTrust >= 0 And intTrust <= 25) Then
                                                intAddTrust += 20
                                            ElseIf (intTrust >= 26 And intTrust <= 50) Then
                                                intAddTrust += 15
                                            Else intAddTrust += 10
                                            End If
                                        End If
                                    End If
                                End If
                                'Shows trust earned, Doubles it if you have such upgrade
                                If CDTrust = True Then
                                    intAddTrust = intAddTrust * 2
                                End If
                                intTrust = intTrust + intAddTrust
                                MsgBox("Congrats, " & playerName & " you passed!" & vbCrLf & "Peter's trust gained: " & intAddTrust & "%" & vbCrLf & "Peter's trust total: " & intTrust & "%")
                                MsgBox("More levels to come...")
                                intLevel = 2
                                'Refreshes the labels on the main menu
                                My.Forms.MainMenu.lblTrust.Text = "Trust: " & intTrust & "%"
                                My.Forms.MainMenu.lblPoints.Text = "Points: " & intPoints
                                My.Forms.MainMenu.lblLevel.Text = "Campaign Level: " & intLevel
                                Me.Close()
                                MainMenu.Show()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Level2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        'Same as above, but for keyboard!
        'Checks key and gets rid of appropriate button on the screen.
        strGuessLetter = UCase(e.KeyChar)
        For x = 0 To 26
            If letters(x).Text = strGuessLetter Then
                letters(x).Visible = False
            End If
        Next
        For x = 0 To 5
            If Words(0).Contains(strGuessLetter) = False And Words(1).Contains(strGuessLetter) = False And Words(2).Contains(strGuessLetter) = False And Words(3).Contains(strGuessLetter) = False And Words(4).Contains(strGuessLetter) = False And Words(5).Contains(strGuessLetter) = False Then
                If Len(lblFailed.Text) = 9 Then
                    MsgBox("You lose one getaway. Buy more on The Street.")
                    MainMenu.Show()
                    Me.Close()
                End If
                lblErrors.Text = Len(lblFailed.Text)
                picJail.Image = Jailed.Images(Len(lblFailed.Text))
                If lblFailed.Text.Contains(strGuessLetter) = False Then
                    lblFailed.Text = lblFailed.Text & strGuessLetter
                End If
            Else
                intLetterPos = 0
                'Makes sure if there are multiple letters of the same value, they are revealed
                Do While InStr(intLetterPos + 1, Words(x), strGuessLetter) > 0
                    intLetterPos = InStr(intLetterPos + 1, Words(x), strGuessLetter)
                    Mid(lblWords(x).Text, intLetterPos, 1) = strGuessLetter
                Loop
            End If
        Next

        'Sorry for the if statements, nothing else worked. I tried everything else.
        If Not lblWords(0).Text.Contains("?") Then
            If Not lblWords(1).Text.Contains("?") Then
                If Not lblWords(2).Text.Contains("?") Then
                    If Not lblWords(3).Text.Contains("?") Then
                        If Not lblWords(4).Text.Contains("?") Then
                            If Not lblWords(5).Text.Contains("?") Then
                                'Checks handicap upgrade and gives points without a handicap
                                If CHandicap = True Then
                                    If (Len(lblFailed.Text) <= 3) Then
                                        intAddTrust += 40
                                    ElseIf (Len(lblFailed.Text) <= 6) Then
                                        intAddTrust += 30
                                    Else intAddTrust += 20
                                    End If
                                End If
                                'Gives trust based on amount of letters the player got wrong and how much they already had
                                If CHandicap = False Then
                                    If intTrust <> 100 Then
                                        If (Len(lblFailed.Text) <= 3) Then
                                            If (intTrust >= 0 And intTrust <= 25) Then
                                                intAddTrust += 40
                                            ElseIf (intTrust >= 26 And intTrust <= 50) Then
                                                intAddTrust += 35
                                            Else intAddTrust += 30
                                            End If
                                        ElseIf (Len(lblFailed.Text) <= 6) Then
                                            If (intTrust >= 0 And intTrust <= 25) Then
                                                intAddTrust += 30
                                            ElseIf (intTrust >= 26 And intTrust <= 50) Then
                                                intAddTrust += 25
                                            Else intAddTrust += 20
                                            End If
                                        Else
                                            If (intTrust >= 0 And intTrust <= 25) Then
                                                intAddTrust += 20
                                            ElseIf (intTrust >= 26 And intTrust <= 50) Then
                                                intAddTrust += 15
                                            Else intAddTrust += 10
                                            End If
                                        End If
                                    End If
                                End If
                                'Shows trust earned, Doubles it if you have such upgrade
                                If CDTrust = True Then
                                    intAddTrust = intAddTrust * 2
                                End If
                                intTrust = intTrust + intAddTrust
                                MsgBox("Congrats, " & playerName & " you passed!" & vbCrLf & "Peter's trust gained: " & intAddTrust & "%" & vbCrLf & "Peter's trust total: " & intTrust & "%")
                                MsgBox("More levels to come...")
                                intLevel = 2
                                'Refreshes the labels on the main menu
                                My.Forms.MainMenu.lblTrust.Text = "Trust: " & intTrust & "%"
                                My.Forms.MainMenu.lblPoints.Text = "Points: " & intPoints
                                My.Forms.MainMenu.lblLevel.Text = "Campaign Level: " & intLevel

                                Me.Close()
                                MainMenu.Show()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        'Refreshes the labels on the main menu
        My.Forms.MainMenu.lblTrust.Text = "Trust: " & intTrust & "%"
        My.Forms.MainMenu.lblPoints.Text = "Points: " & intPoints
        My.Forms.MainMenu.lblLevel.Text = "Campaign Level: " & intLevel
        'Returns to main menu
        Me.Close()
        MainMenu.Show()

    End Sub
End Class
