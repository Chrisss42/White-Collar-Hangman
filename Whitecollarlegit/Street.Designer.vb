<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Street
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
        Me.btnMain = New System.Windows.Forms.Button()
        Me.btnATime = New System.Windows.Forms.Button()
        Me.lblTheStreet = New System.Windows.Forms.Label()
        Me.lblArcade = New System.Windows.Forms.Label()
        Me.lblCampaign = New System.Windows.Forms.Label()
        Me.btnATDep = New System.Windows.Forms.Button()
        Me.btnADouble = New System.Windows.Forms.Button()
        Me.btnCDTrust = New System.Windows.Forms.Button()
        Me.btnCHandicap = New System.Windows.Forms.Button()
        Me.lblTrust = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.btnCGetaway = New System.Windows.Forms.Button()
        Me.btnPtoT = New System.Windows.Forms.Button()
        Me.btnTtoP = New System.Windows.Forms.Button()
        Me.txtTtoP = New System.Windows.Forms.TextBox()
        Me.txtPtoT = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnMain
        '
        Me.btnMain.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMain.Location = New System.Drawing.Point(12, 473)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(274, 36)
        Me.btnMain.TabIndex = 2
        Me.btnMain.Text = "Back to home screen"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'btnATime
        '
        Me.btnATime.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnATime.Location = New System.Drawing.Point(18, 146)
        Me.btnATime.Name = "btnATime"
        Me.btnATime.Size = New System.Drawing.Size(121, 58)
        Me.btnATime.TabIndex = 3
        Me.btnATime.Text = "More Time    (20 Points)"
        Me.btnATime.UseVisualStyleBackColor = True
        '
        'lblTheStreet
        '
        Me.lblTheStreet.AutoSize = True
        Me.lblTheStreet.BackColor = System.Drawing.Color.Transparent
        Me.lblTheStreet.Font = New System.Drawing.Font("Lucida Console", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTheStreet.ForeColor = System.Drawing.Color.White
        Me.lblTheStreet.Location = New System.Drawing.Point(12, 22)
        Me.lblTheStreet.Name = "lblTheStreet"
        Me.lblTheStreet.Size = New System.Drawing.Size(225, 35)
        Me.lblTheStreet.TabIndex = 4
        Me.lblTheStreet.Text = "The Street"
        '
        'lblArcade
        '
        Me.lblArcade.AutoSize = True
        Me.lblArcade.BackColor = System.Drawing.Color.Transparent
        Me.lblArcade.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArcade.ForeColor = System.Drawing.Color.White
        Me.lblArcade.Location = New System.Drawing.Point(25, 97)
        Me.lblArcade.Name = "lblArcade"
        Me.lblArcade.Size = New System.Drawing.Size(108, 27)
        Me.lblArcade.TabIndex = 5
        Me.lblArcade.Text = "Arcade"
        '
        'lblCampaign
        '
        Me.lblCampaign.AutoSize = True
        Me.lblCampaign.BackColor = System.Drawing.Color.Transparent
        Me.lblCampaign.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampaign.ForeColor = System.Drawing.Color.White
        Me.lblCampaign.Location = New System.Drawing.Point(339, 97)
        Me.lblCampaign.Name = "lblCampaign"
        Me.lblCampaign.Size = New System.Drawing.Size(140, 27)
        Me.lblCampaign.TabIndex = 6
        Me.lblCampaign.Text = "Campaign"
        '
        'btnATDep
        '
        Me.btnATDep.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnATDep.Location = New System.Drawing.Point(18, 208)
        Me.btnATDep.Name = "btnATDep"
        Me.btnATDep.Size = New System.Drawing.Size(121, 58)
        Me.btnATDep.TabIndex = 7
        Me.btnATDep.Text = "Time Depletion (30 Points)"
        Me.btnATDep.UseVisualStyleBackColor = True
        '
        'btnADouble
        '
        Me.btnADouble.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADouble.Location = New System.Drawing.Point(18, 272)
        Me.btnADouble.Name = "btnADouble"
        Me.btnADouble.Size = New System.Drawing.Size(121, 58)
        Me.btnADouble.TabIndex = 8
        Me.btnADouble.Text = "Double Points (40 Points)"
        Me.btnADouble.UseVisualStyleBackColor = True
        '
        'btnCDTrust
        '
        Me.btnCDTrust.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCDTrust.Location = New System.Drawing.Point(344, 146)
        Me.btnCDTrust.Name = "btnCDTrust"
        Me.btnCDTrust.Size = New System.Drawing.Size(121, 58)
        Me.btnCDTrust.TabIndex = 10
        Me.btnCDTrust.Text = "Double Trust (90% Trust)"
        Me.btnCDTrust.UseVisualStyleBackColor = True
        '
        'btnCHandicap
        '
        Me.btnCHandicap.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCHandicap.Location = New System.Drawing.Point(344, 210)
        Me.btnCHandicap.Name = "btnCHandicap"
        Me.btnCHandicap.Size = New System.Drawing.Size(121, 58)
        Me.btnCHandicap.TabIndex = 11
        Me.btnCHandicap.Text = "No Handicap (75% Trust)"
        Me.btnCHandicap.UseVisualStyleBackColor = True
        '
        'lblTrust
        '
        Me.lblTrust.AutoSize = True
        Me.lblTrust.BackColor = System.Drawing.Color.Transparent
        Me.lblTrust.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrust.ForeColor = System.Drawing.Color.White
        Me.lblTrust.Location = New System.Drawing.Point(303, 477)
        Me.lblTrust.Name = "lblTrust"
        Me.lblTrust.Size = New System.Drawing.Size(108, 27)
        Me.lblTrust.TabIndex = 12
        Me.lblTrust.Text = "Trust:"
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.BackColor = System.Drawing.Color.Transparent
        Me.lblPoints.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.ForeColor = System.Drawing.Color.White
        Me.lblPoints.Location = New System.Drawing.Point(303, 438)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(124, 27)
        Me.lblPoints.TabIndex = 13
        Me.lblPoints.Text = "Points:"
        '
        'btnCGetaway
        '
        Me.btnCGetaway.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCGetaway.Location = New System.Drawing.Point(344, 272)
        Me.btnCGetaway.Name = "btnCGetaway"
        Me.btnCGetaway.Size = New System.Drawing.Size(121, 58)
        Me.btnCGetaway.TabIndex = 14
        Me.btnCGetaway.Text = "+1 Getaway (50% Trust)"
        Me.btnCGetaway.UseVisualStyleBackColor = True
        '
        'btnPtoT
        '
        Me.btnPtoT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPtoT.Location = New System.Drawing.Point(532, 356)
        Me.btnPtoT.Name = "btnPtoT"
        Me.btnPtoT.Size = New System.Drawing.Size(121, 58)
        Me.btnPtoT.TabIndex = 15
        Me.btnPtoT.Text = "Convert Points to Trust"
        Me.btnPtoT.UseVisualStyleBackColor = True
        '
        'btnTtoP
        '
        Me.btnTtoP.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTtoP.Location = New System.Drawing.Point(226, 356)
        Me.btnTtoP.Name = "btnTtoP"
        Me.btnTtoP.Size = New System.Drawing.Size(121, 58)
        Me.btnTtoP.TabIndex = 16
        Me.btnTtoP.Text = "Convert Trust to Points"
        Me.btnTtoP.UseVisualStyleBackColor = True
        '
        'txtTtoP
        '
        Me.txtTtoP.Location = New System.Drawing.Point(120, 377)
        Me.txtTtoP.Name = "txtTtoP"
        Me.txtTtoP.Size = New System.Drawing.Size(100, 20)
        Me.txtTtoP.TabIndex = 17
        '
        'txtPtoT
        '
        Me.txtPtoT.Location = New System.Drawing.Point(426, 377)
        Me.txtPtoT.Name = "txtPtoT"
        Me.txtPtoT.Size = New System.Drawing.Size(100, 20)
        Me.txtPtoT.TabIndex = 18
        '
        'Street
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Whitecollarlegit.My.Resources.Resources.a3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(692, 521)
        Me.Controls.Add(Me.txtPtoT)
        Me.Controls.Add(Me.txtTtoP)
        Me.Controls.Add(Me.btnTtoP)
        Me.Controls.Add(Me.btnPtoT)
        Me.Controls.Add(Me.btnCGetaway)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.lblTrust)
        Me.Controls.Add(Me.btnCHandicap)
        Me.Controls.Add(Me.btnCDTrust)
        Me.Controls.Add(Me.btnADouble)
        Me.Controls.Add(Me.btnATDep)
        Me.Controls.Add(Me.lblCampaign)
        Me.Controls.Add(Me.lblArcade)
        Me.Controls.Add(Me.lblTheStreet)
        Me.Controls.Add(Me.btnATime)
        Me.Controls.Add(Me.btnMain)
        Me.Name = "Street"
        Me.Text = "The Street"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMain As Button
    Friend WithEvents btnATime As Button
    Friend WithEvents lblTheStreet As Label
    Friend WithEvents lblArcade As Label
    Friend WithEvents lblCampaign As Label
    Friend WithEvents btnATDep As Button
    Friend WithEvents btnADouble As Button
    Friend WithEvents btnCDTrust As Button
    Friend WithEvents btnCHandicap As Button
    Friend WithEvents lblTrust As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents btnCGetaway As Button
    Friend WithEvents btnPtoT As Button
    Friend WithEvents btnTtoP As Button
    Friend WithEvents txtTtoP As TextBox
    Friend WithEvents txtPtoT As TextBox
End Class
