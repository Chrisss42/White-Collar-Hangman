Public Module GlobalVariables
    Public Trust As Integer
End Module
Public Class Level1
    Public letters(25) As Button
    Dim accept As Integer
    Dim space As Button
    Dim buttonpoint As Point
    Dim qwerty As String = "QWERTYUIOPASDFGHJKLZXCVBNM"
    Dim myfont As Font = New Font(FontFamily.GenericSansSerif, 14.0F, FontStyle.Bold)
    Dim wordnum As Integer
    Dim guessletter As String
    Dim Words(3) As String
    Dim correct As Boolean
    Dim letterpos As Integer
    Dim lblWords(3) As Label
    Dim response As Integer
    Dim addTrust As Integer
    Private Sub Level1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMsg1.ShowDialog(Me)
        picJail.BackgroundImage = Jailed.Images(0)
        'Creates the buttons
        buttonpoint.X = 835
        buttonpoint.Y = 95
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
        space = New Button
        space.Width = 195
        space.Height = 35
        space.Location = buttonpoint
        space.BackColor = Color.DodgerBlue
        space.ForeColor = Color.White
        space.FlatStyle = FlatStyle.Flat
        space.Font = myfont
        space.Text = " "
        AddHandler space.Click, AddressOf Clicked
        Me.Controls.Add(space)
        'Words
        Words(0) = "THE DUTCHMAN"
        Words(1) = "TRACKING ANKLET"
        Words(2) = "BOOKS"
        Words(3) = "KATE"
        'Labels
        lblWords(0) = lblWord1
        lblWords(1) = lblWord2
        lblWords(2) = lblWord3
        lblWords(3) = lblWord4
        lblPoint.Text = Trust & "%"
    End Sub

    Private Sub Clicked(sender As System.Object, e As System.EventArgs)
        'Checks if the letter is in any of the labels; if not, adds letter to failed guesses and adds one to the picture
        guessletter = sender.text
        sender.visible = False
        For x = 0 To 3
            If Words(0).Contains(guessletter) = False And Words(1).Contains(guessletter) = False And Words(2).Contains(guessletter) = False And Words(3).Contains(guessletter) = False Then
                If Len(lblFailed.Text) = 9 Then
                    response = MsgBox("You lose one getaway. Buy more on The Street.", 4, "Defeated!")
                    If response = 6 Then
                        Me.Refresh()
                    Else

                        MainMenu.Show()
                        Me.Close()
                    End If
                End If
                lblErrors.Text = Len(lblFailed.Text)
                picJail.Image = Jailed.Images(Len(lblFailed.Text))
                If lblFailed.Text.Contains(guessletter) = False Then
                    lblFailed.Text = lblFailed.Text & guessletter
                End If
            Else
                letterpos = 0
                'Makes sure if there are multiple letters of the same value, they are revealed
                Do While InStr(letterpos + 1, Words(x), guessletter) > 0
                    letterpos = InStr(letterpos + 1, Words(x), guessletter)
                    Mid(lblWords(x).Text, letterpos, 1) = guessletter
                Loop
            End If
        Next

        'Sorry for the if statements, nothing else worked. I tried everything else.
        If Not lblWords(0).Text.Contains("?") Then
            If Not lblWords(1).Text.Contains("?") Then
                If Not lblWords(2).Text.Contains("?") Then
                    If Not lblWords(3).Text.Contains("?") Then
                        'Checks handicap upgrade and gives points without a handicap
                        If CHandicap = True Then
                            If (Len(lblFailed.Text) <= 3) Then
                                addTrust += 40
                            ElseIf (Len(lblFailed.Text) <= 6) Then
                                addTrust += 30
                            Else addTrust += 20
                            End If
                        End If
                    End If
                    'Gives trust based on amount of letters the player got wrong and how much they already had
                    If CHandicap = False Then
                        If Trust <> 100 Then
                            If (Len(lblFailed.Text) <= 3) Then
                                If (Trust >= 0 And Trust <= 25) Then
                                    addTrust += 40
                                ElseIf (Trust >= 26 And Trust <= 50) Then
                                    addTrust += 35
                                Else addTrust += 30
                                End If
                            ElseIf (Len(lblFailed.Text) <= 6) Then
                                If (Trust >= 0 And Trust <= 25) Then
                                    addTrust += 30
                                ElseIf (Trust >= 26 And Trust <= 50) Then
                                    addTrust += 25
                                Else addTrust += 20
                                End If
                            Else
                                If (Trust >= 0 And Trust <= 25) Then
                                    addTrust += 20
                                ElseIf (Trust >= 26 And Trust <= 50) Then
                                    addTrust += 15
                                Else addTrust += 10
                                End If
                            End If
                        End If
                    End If
                    'Shows trust earned, Doubles it if you have such upgrade
                    If CDTrust = True Then
                        addTrust = addTrust * 2
                    End If
                    MsgBox("Congrats, " & playerName & " you passed!" & vbCrLf & "Peter's trust total: " & (Trust + addTrust) & "%")

                    Me.Close()
                    MainMenu.Show()
                End If
            End If
        End If
    End Sub

    Private Sub Level1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        'Same as above, but for keyboard!
        guessletter = UCase(e.KeyChar)
        For x = 0 To 25
            If letters(x).Text = guessletter Then
                letters(x).Visible = False
            End If
            If guessletter = " " Then
                space.Visible = False
            End If
        Next
        For x = 0 To 3
            If Words(0).Contains(guessletter) = False And Words(1).Contains(guessletter) = False And Words(2).Contains(guessletter) = False And Words(3).Contains(guessletter) = False Then
                If Len(lblFailed.Text) = 9 Then
                    response = MsgBox("You lose one getaway. Buy more on The Street.", 4, "Defeated!")
                    If response = 6 Then
                        Me.Refresh()
                    Else

                        MainMenu.Show()
                        Me.Close()
                    End If
                End If
                lblErrors.Text = Len(lblFailed.Text)
                picJail.Image = Jailed.Images(Len(lblFailed.Text))
                If lblFailed.Text.Contains(guessletter) = False Then
                    lblFailed.Text = lblFailed.Text & guessletter
                End If
            Else
                letterpos = 0
                'Makes sure if there are multiple letters of the same value, they are revealed
                Do While InStr(letterpos + 1, Words(x), guessletter) > 0
                    letterpos = InStr(letterpos + 1, Words(x), guessletter)
                    Mid(lblWords(x).Text, letterpos, 1) = guessletter
                Loop
            End If
        Next

        'Sorry for the if statements, nothing else worked. I tried everything else.
        If Not lblWords(0).Text.Contains("?") Then
            If Not lblWords(1).Text.Contains("?") Then
                If Not lblWords(2).Text.Contains("?") Then
                    If Not lblWords(3).Text.Contains("?") Then
                        'Checks handicap upgrade and gives points without a handicap
                        If CHandicap = True Then
                            If (Len(lblFailed.Text) <= 3) Then
                                addTrust += 40
                            ElseIf (Len(lblFailed.Text) <= 6) Then
                                addTrust += 30
                            Else addTrust += 20
                            End If
                        End If
                    End If
                    'Gives trust based on amount of letters the player got wrong and how much they already had
                    If CHandicap = False Then
                        If Trust <> 100 Then
                            If (Len(lblFailed.Text) <= 3) Then
                                If (Trust >= 0 And Trust <= 25) Then
                                    addTrust += 40
                                ElseIf (Trust >= 26 And Trust <= 50) Then
                                    addTrust += 35
                                Else addTrust += 30
                                End If
                            ElseIf (Len(lblFailed.Text) <= 6) Then
                                If (Trust >= 0 And Trust <= 25) Then
                                    addTrust += 30
                                ElseIf (Trust >= 26 And Trust <= 50) Then
                                    addTrust += 25
                                Else addTrust += 20
                                End If
                            Else
                                If (Trust >= 0 And Trust <= 25) Then
                                    addTrust += 20
                                ElseIf (Trust >= 26 And Trust <= 50) Then
                                    addTrust += 15
                                Else addTrust += 10
                                End If
                            End If
                        End If
                    End If
                    'Shows trust earned, Doubles it if you have such upgrade
                    If CDTrust = True Then
                        addTrust = addTrust * 2
                    End If
                    MsgBox("Congrats, " & playerName & " you passed!" & vbCrLf & "Peter's trust total: " & (Trust + addTrust) & "%")

                    Me.Close()
                    MainMenu.Show()
                End If
            End If
        End If
    End Sub
End Class
