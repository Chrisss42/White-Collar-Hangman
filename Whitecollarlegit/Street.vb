Public Module StreetVar
    Public ATime As Boolean = False
    Public ATDep As Boolean = False
    Public ADouble As Boolean = False
    Public CDTrust As Boolean = False
    Public CHandicap As Boolean = False
End Module

Public Class Street
    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
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

        lblPoints.Text = "Points: " & Points
        lblTrust.Text = "Trust: " & Trust & "%"
    End Sub

    Private Sub btnATime_Click(sender As Object, e As EventArgs) Handles btnATime.Click
        If Points >= 20 Then
            Points -= 20
            ATime = True
            btnATime.Enabled = False
            lblPoints.Text = "Points: " & Points
            lblTrust.Text = "Trust: " & Trust & "%"
        End If
    End Sub

    Private Sub btnATDep_Click(sender As Object, e As EventArgs) Handles btnATDep.Click
        If Points >= 30 Then
            Points -= 30
            ATDep = True
            btnATDep.Enabled = False
            lblPoints.Text = "Points: " & Points
            lblTrust.Text = "Trust: " & Trust & "%"
        End If
    End Sub

    Private Sub btnADouble_Click(sender As Object, e As EventArgs) Handles btnADouble.Click
        If Points >= 40 Then
            Points -= 40
            ADouble = True
            btnADouble.Enabled = False
            lblPoints.Text = "Points: " & Points
            lblTrust.Text = "Trust: " & Trust & "%"
        End If
    End Sub

    Private Sub btnCDTrust_Click(sender As Object, e As EventArgs) Handles btnCDTrust.Click
        If Trust >= 90 Then
            Trust -= 90
            CDTrust = True
            btnCDTrust.Enabled = False
            lblPoints.Text = "Points: " & Points
            lblTrust.Text = "Trust: " & Trust & "%"
        End If
    End Sub

    Private Sub btnCHandicap_Click(sender As Object, e As EventArgs) Handles btnCHandicap.Click
        If Trust >= 75 Then
            Trust -= 75
            CHandicap = True
            btnCHandicap.Enabled = False
            lblPoints.Text = "Points: " & Points
            lblTrust.Text = "Trust: " & Trust & "%"
        End If
    End Sub
End Class