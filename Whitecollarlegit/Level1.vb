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
    Private Sub Level1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMsg1.ShowDialog(Me)
        picJail.BackgroundImage = Jailed.Images(0)
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
        guessletter = sender.text
        For x = 0 To 3
            If Words(0).Contains(guessletter) = False And Words(1).Contains(guessletter) = False And Words(2).Contains(guessletter) = False And Words(3).Contains(guessletter) = False Then
                If Len(lblFailed.Text) = 9 Then
                    response = MsgBox("You lose one getaway. Buy more on The Street.", 4, "Defeated!")
                    If response = 6 Then
                        Me.Refresh()
                    Else

                        Form1.Show()
                        Me.Close()
                    End If
                End If
                lblErrors.Text = (Len(lblFailed.Text) + 1)
                picJail.Image = Jailed.Images((Len(lblFailed.Text) + 1))
                If lblFailed.Text.Contains(guessletter) = False Then
                    lblFailed.Text = lblFailed.Text & guessletter
                End If
            Else
                letterpos = 0
                Do While InStr(letterpos + 1, Words(x), guessletter) > 0
                    letterpos = InStr(letterpos + 1, Words(x), guessletter)
                    Mid(lblWords(x).Text, letterpos, 1) = guessletter
                Loop
            End If
        Next

        'Sorry for the cancerous if statements
        If Not lblWords(0).Text.Contains("?") Then
            If Not lblWords(1).Text.Contains("?") Then
                If Not lblWords(2).Text.Contains("?") Then
                    If Not lblWords(3).Text.Contains("?") Then
                        If Trust <> 100 Then
                            If (Len(lblFailed.Text) <= 3) Then
                                If (Trust >= 0 And Trust <= 25) Then
                                    Trust += 40
                                ElseIf (Trust >= 26 And Trust <= 50) Then
                                    Trust += 35
                                Else Trust += 30
                                End If
                            ElseIf (Len(lblFailed.Text) <= 6) Then
                                If (Trust >= 0 And Trust <= 25) Then
                                    Trust += 30
                                ElseIf (Trust >= 26 And Trust <= 50) Then
                                    Trust += 25
                                Else Trust += 20
                                End If
                            Else
                                If (Trust >= 0 And Trust <= 25) Then
                                    Trust += 20
                                ElseIf (Trust >= 26 And Trust <= 50) Then
                                    Trust += 15
                                Else Trust += 10
                                End If
                            End If
                        End If
                        MsgBox("Congrats, " & Name & " you passed!" & vbCrLf & "Peter's trust total: " & Trust & "%")

                        Me.Close()
                        Form1.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Level1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
    End Sub
End Class
