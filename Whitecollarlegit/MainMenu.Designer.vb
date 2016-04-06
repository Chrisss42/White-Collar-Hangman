<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.BtnNavInstructions = New System.Windows.Forms.Button()
        Me.btnCampaign = New System.Windows.Forms.Button()
        Me.btnArcade = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnShop = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTrust = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.pnlStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnNavInstructions
        '
        Me.BtnNavInstructions.BackColor = System.Drawing.Color.HotPink
        Me.BtnNavInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNavInstructions.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNavInstructions.ForeColor = System.Drawing.Color.White
        Me.BtnNavInstructions.Location = New System.Drawing.Point(17, 320)
        Me.BtnNavInstructions.Name = "BtnNavInstructions"
        Me.BtnNavInstructions.Size = New System.Drawing.Size(155, 42)
        Me.BtnNavInstructions.TabIndex = 1
        Me.BtnNavInstructions.Text = "Instructions"
        Me.BtnNavInstructions.UseVisualStyleBackColor = False
        '
        'btnCampaign
        '
        Me.btnCampaign.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnCampaign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCampaign.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCampaign.ForeColor = System.Drawing.Color.White
        Me.btnCampaign.Location = New System.Drawing.Point(17, 416)
        Me.btnCampaign.Name = "btnCampaign"
        Me.btnCampaign.Size = New System.Drawing.Size(155, 42)
        Me.btnCampaign.TabIndex = 2
        Me.btnCampaign.Text = "Start Campaign"
        Me.btnCampaign.UseVisualStyleBackColor = False
        '
        'btnArcade
        '
        Me.btnArcade.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnArcade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArcade.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArcade.ForeColor = System.Drawing.Color.White
        Me.btnArcade.Location = New System.Drawing.Point(17, 464)
        Me.btnArcade.Name = "btnArcade"
        Me.btnArcade.Size = New System.Drawing.Size(155, 42)
        Me.btnArcade.TabIndex = 3
        Me.btnArcade.Text = "Arcade"
        Me.btnArcade.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.OrangeRed
        Me.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.White
        Me.btnQuit.Location = New System.Drawing.Point(633, 464)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(155, 42)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnShop
        '
        Me.btnShop.BackColor = System.Drawing.Color.Gold
        Me.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShop.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShop.ForeColor = System.Drawing.Color.White
        Me.btnShop.Location = New System.Drawing.Point(17, 368)
        Me.btnShop.Name = "btnShop"
        Me.btnShop.Size = New System.Drawing.Size(155, 42)
        Me.btnShop.TabIndex = 5
        Me.btnShop.Text = "The Street"
        Me.btnShop.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(3, 44)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(78, 29)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "Name:"
        '
        'lblTrust
        '
        Me.lblTrust.AutoSize = True
        Me.lblTrust.BackColor = System.Drawing.Color.Transparent
        Me.lblTrust.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrust.ForeColor = System.Drawing.Color.White
        Me.lblTrust.Location = New System.Drawing.Point(3, 73)
        Me.lblTrust.Name = "lblTrust"
        Me.lblTrust.Size = New System.Drawing.Size(68, 29)
        Me.lblTrust.TabIndex = 15
        Me.lblTrust.Text = "Trust:"
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.BackColor = System.Drawing.Color.Transparent
        Me.lblPoints.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.ForeColor = System.Drawing.Color.White
        Me.lblPoints.Location = New System.Drawing.Point(3, 102)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(80, 29)
        Me.lblPoints.TabIndex = 16
        Me.lblPoints.Text = "Points:"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblLevel.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.White
        Me.lblLevel.Location = New System.Drawing.Point(3, 131)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(174, 29)
        Me.lblLevel.TabIndex = 17
        Me.lblLevel.Text = "Campaign Level:"
        '
        'pnlStats
        '
        Me.pnlStats.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlStats.Controls.Add(Me.lblStats)
        Me.pnlStats.Controls.Add(Me.lblName)
        Me.pnlStats.Controls.Add(Me.lblLevel)
        Me.pnlStats.Controls.Add(Me.lblTrust)
        Me.pnlStats.Controls.Add(Me.lblPoints)
        Me.pnlStats.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlStats.Location = New System.Drawing.Point(12, 116)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(336, 171)
        Me.pnlStats.TabIndex = 18
        '
        'lblStats
        '
        Me.lblStats.AutoSize = True
        Me.lblStats.BackColor = System.Drawing.Color.Transparent
        Me.lblStats.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStats.ForeColor = System.Drawing.Color.White
        Me.lblStats.Location = New System.Drawing.Point(78, 11)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(115, 33)
        Me.lblStats.TabIndex = 18
        Me.lblStats.Text = "Statistics"
        '
        'btnStats
        '
        Me.btnStats.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStats.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStats.ForeColor = System.Drawing.Color.White
        Me.btnStats.Location = New System.Drawing.Point(12, 75)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(68, 35)
        Me.btnStats.TabIndex = 19
        Me.btnStats.Text = "Stats"
        Me.btnStats.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 518)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.btnShop)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnArcade)
        Me.Controls.Add(Me.btnCampaign)
        Me.Controls.Add(Me.BtnNavInstructions)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.pnlStats.ResumeLayout(False)
        Me.pnlStats.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnNavInstructions As Button
    Friend WithEvents btnCampaign As Button
    Friend WithEvents btnArcade As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnShop As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblTrust As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents lblLevel As Label
    Friend WithEvents pnlStats As Panel
    Friend WithEvents lblStats As Label
    Friend WithEvents btnStats As Button
End Class
