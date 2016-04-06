'By Ayush Gupta and Chris Green (31/3/2016)
'Main menu and principle form of the application. Used for navigation between other forms. Accessible from all other forms.
Public Module Var
    Public playerName As String
End Module
Public Class MainMenu
    Dim intResponse As Integer

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get player's name into a global variable
        playerName = StrConv(InputBox("Input Name: ", "Name"), vbProperCase)
        lblName.Text = "Name: " & playerName
        lblTrust.Text = "Trust: " & intTrust & "%"
        lblPoints.Text = "Points: " & intPoints
        lblLevel.Text = "Campaign Level: " & intLevel
        'Hides panel
        pnlStats.Visible = False
        'Play opening music
        PlayBGMusic()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Quit confirmation
        Dim intResult As Integer = MessageBox.Show("Are you sure?", "Quit", MessageBoxButtons.YesNo)
        If intResult = DialogResult.No Then
            MessageBox.Show("Good choice!")
        ElseIf intResult = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub



    Sub PlayBGMusic()
        'My.Computer.Audio.Play(My.Resources.WCOpening)
    End Sub

    Private Sub BtnNavInstructions_Click(sender As Object, e As EventArgs) Handles BtnNavInstructions.Click
        'Show instructions
        Instructions.Show()
    End Sub

    Private Sub btnCampaign_Click(sender As Object, e As EventArgs) Handles btnCampaign.Click
        'Go to campaign
        Me.Hide()
        'Gives the option to continue at the previous level won
        If intLevel <> 0 Then
            intResponse = MsgBox("Continue at level " & (intLevel + 1) & "?", 4, "Continue?")
            If intResponse = 6 Then
                If intLevel = 1 Then
                    Level2.Show()
                Else MsgBox("You have beat the game in its current state. Please wait for new levels. Thank you for playing!")
                    Me.Show()
                End If
            Else Level1.Show()
            End If
        Else Level1.Show()
        End If
    End Sub

    Private Sub btnArcade_Click(sender As Object, e As EventArgs) Handles btnArcade.Click
        'Start arcade
        Me.Hide()
        Arcade.Show()
    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        'Go to the street (shop)
        Me.Hide()
        Street.Show()
    End Sub

    Private Sub btnStats_MouseHover(sender As Object, e As EventArgs) Handles btnStats.MouseHover
        'Shows panel on mouse over
        pnlStats.Visible = True
    End Sub

    Private Sub btnStats_MouseLeave(sender As Object, e As EventArgs) Handles btnStats.MouseLeave
        'Hides panel on mouse leave
        pnlStats.Visible = False
    End Sub
End Class
