'By Ayush Gupta and Chris Green (31/3/2016)
'In game store. Uses in game currency to purchase upgrades for easier progression. Can also convert between currencies.
Public Module StreetVar
    'Global upgrade variables
    Public ATime As Boolean = False
    Public ATDep As Boolean = False
    Public ADouble As Boolean = False
    Public CDTrust As Boolean = False
    Public CHandicap As Boolean = False
End Module

Public Class Street
    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        'Refreshes the labels on the main menu
        My.Forms.MainMenu.lblTrust.Text = "Trust: " & intTrust & "%"
        My.Forms.MainMenu.lblPoints.Text = "Points: " & intPoints
        My.Forms.MainMenu.lblLevel.Text = "Campaign Level: " & intLevel
        'Return to main menu
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub Street_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Checks if they have already purchased the upgrade, hides if true
        If ATime = True Then
            btnATime.Enabled = False
        End If
        If ADouble = True Then
            btnADouble.Enabled = False
        End If

        If ATDep = True Then
            btnATDep.Enabled = False
        End If

        If CDTrust = True Then
            btnCDTrust.Enabled = False
        End If

        If CHandicap = True Then
            btnCHandicap.Enabled = False
        End If

        lblPoints.Text = "Points: " & intPoints
        lblTrust.Text = "Trust: " & intTrust & "%"
    End Sub

    Private Sub btnATime_Click(sender As Object, e As EventArgs) Handles btnATime.Click
        'Gives more time in Arcade mode; the code here checks if they have enough and then subtracts it, then it refreshes the labels
        If intPoints >= 20 Then
            intPoints -= 20
            ATime = True
            btnATime.Enabled = False
            lblPoints.Text = "Points: " & intPoints
            lblTrust.Text = "Trust: " & intTrust & "%"
        End If
    End Sub

    Private Sub btnATDep_Click(sender As Object, e As EventArgs) Handles btnATDep.Click
        'Time depletes slower in arcade; the code here checks if they have enough and then subtracts it, then it refreshes the labels

        If intPoints >= 30 Then
            intPoints -= 30
            ATDep = True
            btnATDep.Enabled = False
            lblPoints.Text = "Points: " & intPoints
            lblTrust.Text = "Trust: " & intTrust & "%"
        End If
    End Sub

    Private Sub btnADouble_Click(sender As Object, e As EventArgs) Handles btnADouble.Click
        'Double points in arcade; the code here checks if they have enough and then subtracts it, then it refreshes the labels

        If intPoints >= 40 Then
            intPoints -= 40
            ADouble = True
            btnADouble.Enabled = False
            lblPoints.Text = "Points: " & intPoints
            lblTrust.Text = "Trust: " & intTrust & "%"
        End If
    End Sub

    Private Sub btnCDTrust_Click(sender As Object, e As EventArgs) Handles btnCDTrust.Click
        'Double trust in campaign; the code here checks if they have enough and then subtracts it, then it refreshes the labels

        If intTrust >= 90 Then
            intTrust -= 90
            CDTrust = True
            btnCDTrust.Enabled = False
            lblPoints.Text = "Points: " & intPoints
            lblTrust.Text = "Trust: " & intTrust & "%"
        End If
    End Sub

    Private Sub btnCHandicap_Click(sender As Object, e As EventArgs) Handles btnCHandicap.Click
        'Gets rid of the handicap (less points based on what you already have), makes it possible for >100%; the code here checks if they have enough and then subtracts it, then it refreshes the labels

        If intTrust >= 75 Then
            intTrust -= 75
            CHandicap = True
            btnCHandicap.Enabled = False
            lblPoints.Text = "Points: " & intPoints
            lblTrust.Text = "Trust: " & intTrust & "%"
        End If
    End Sub

    Private Sub btnCGetaway_Click(sender As Object, e As EventArgs) Handles btnCGetaway.Click
        'Buy one more getaway; the code here checks if they have enough and then subtracts it, then it refreshes the labels. If they don't have enough and they have no getaways it tells them about the conversion

        If intTrust >= 50 Then
            intTrust -= 50
            intGetaways += 1
            lblPoints.Text = "Points: " & intPoints
            lblTrust.Text = "Trust: " & intTrust & "%"
        ElseIf (intGetaways <= 0 And intTrust < 50) Then
            MsgBox("Try to play arcade and convert points to trust.")
        End If
    End Sub

    Private Sub btnTtoP_Click(sender As Object, e As EventArgs) Handles btnTtoP.Click
        'Converts trust to points, checks value in textbox and changes it to points. Refreshes labels
        If (IsNumeric(txtTtoP.Text) = True) Then
            Dim TrustConvert As Integer
            TrustConvert = txtTtoP.Text
            If TrustConvert > intTrust Then
                MsgBox("Not enough Trust")
            Else
                intTrust -= TrustConvert
                intPoints += TrustConvert
                lblPoints.Text = "Points: " & intPoints
                lblTrust.Text = "Trust: " & intTrust & "%"
            End If
        Else MsgBox("Invalid entry, input a number.")
        End If
        txtTtoP.Text = ""
    End Sub

    Private Sub btnPtoT_Click(sender As Object, e As EventArgs) Handles btnPtoT.Click
        'Converts points to trust, checks value in textbox and changes it to trust. Refreshes labels

        If (IsNumeric(txtPtoT.Text) = True) Then
            Dim PointConvert As Integer
            PointConvert = txtPtoT.Text
            If PointConvert > intPoints Then
                MsgBox("Not enough Points")
            Else
                intPoints -= PointConvert
                intTrust += PointConvert
                lblPoints.Text = "Points: " & intPoints
                lblTrust.Text = "Trust: " & intTrust & "%"
            End If
        Else MsgBox("Invalid entry, input a number.")
        End If
        txtPtoT.Text = ""
    End Sub
End Class