<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level2))
        Me.Jailed = New System.Windows.Forms.ImageList(Me.components)
        Me.lblErrors = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFailed = New System.Windows.Forms.Label()
        Me.lblWord4 = New System.Windows.Forms.Label()
        Me.lblWord3 = New System.Windows.Forms.Label()
        Me.lblWord2 = New System.Windows.Forms.Label()
        Me.picJail = New System.Windows.Forms.PictureBox()
        Me.lblPoint = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblWord1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWord6 = New System.Windows.Forms.Label()
        Me.lblWord5 = New System.Windows.Forms.Label()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picJail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Jailed
        '
        Me.Jailed.ImageStream = CType(resources.GetObject("Jailed.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Jailed.TransparentColor = System.Drawing.Color.Transparent
        Me.Jailed.Images.SetKeyName(0, "0.png")
        Me.Jailed.Images.SetKeyName(1, "1.png")
        Me.Jailed.Images.SetKeyName(2, "2.png")
        Me.Jailed.Images.SetKeyName(3, "3.png")
        Me.Jailed.Images.SetKeyName(4, "4.png")
        Me.Jailed.Images.SetKeyName(5, "5.png")
        Me.Jailed.Images.SetKeyName(6, "6.png")
        Me.Jailed.Images.SetKeyName(7, "7.png")
        Me.Jailed.Images.SetKeyName(8, "8.png")
        Me.Jailed.Images.SetKeyName(9, "9.png")
        '
        'lblErrors
        '
        Me.lblErrors.AutoSize = True
        Me.lblErrors.BackColor = System.Drawing.Color.Transparent
        Me.lblErrors.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrors.ForeColor = System.Drawing.Color.White
        Me.lblErrors.Location = New System.Drawing.Point(773, 602)
        Me.lblErrors.Name = "lblErrors"
        Me.lblErrors.Size = New System.Drawing.Size(29, 33)
        Me.lblErrors.TabIndex = 33
        Me.lblErrors.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(794, 602)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 33)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "/ 9"
        '
        'lblFailed
        '
        Me.lblFailed.AutoSize = True
        Me.lblFailed.BackColor = System.Drawing.Color.Transparent
        Me.lblFailed.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailed.ForeColor = System.Drawing.Color.White
        Me.lblFailed.Location = New System.Drawing.Point(839, 17)
        Me.lblFailed.Name = "lblFailed"
        Me.lblFailed.Size = New System.Drawing.Size(89, 33)
        Me.lblFailed.TabIndex = 23
        Me.lblFailed.Text = "FAILED"
        '
        'lblWord4
        '
        Me.lblWord4.BackColor = System.Drawing.Color.White
        Me.lblWord4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord4.Location = New System.Drawing.Point(3, 427)
        Me.lblWord4.Name = "lblWord4"
        Me.lblWord4.Size = New System.Drawing.Size(86, 22)
        Me.lblWord4.TabIndex = 31
        Me.lblWord4.Text = "?????????"
        Me.lblWord4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWord3
        '
        Me.lblWord3.BackColor = System.Drawing.Color.White
        Me.lblWord3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord3.Location = New System.Drawing.Point(441, 282)
        Me.lblWord3.Name = "lblWord3"
        Me.lblWord3.Size = New System.Drawing.Size(81, 22)
        Me.lblWord3.TabIndex = 30
        Me.lblWord3.Text = "?????????"
        Me.lblWord3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWord2
        '
        Me.lblWord2.BackColor = System.Drawing.Color.White
        Me.lblWord2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord2.Location = New System.Drawing.Point(142, 228)
        Me.lblWord2.Name = "lblWord2"
        Me.lblWord2.Size = New System.Drawing.Size(142, 22)
        Me.lblWord2.TabIndex = 29
        Me.lblWord2.Text = "???????????????????"
        Me.lblWord2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picJail
        '
        Me.picJail.BackgroundImage = Global.Whitecollarlegit.My.Resources.Resources._0
        Me.picJail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picJail.Location = New System.Drawing.Point(706, 343)
        Me.picJail.Name = "picJail"
        Me.picJail.Size = New System.Drawing.Size(205, 256)
        Me.picJail.TabIndex = 27
        Me.picJail.TabStop = False
        '
        'lblPoint
        '
        Me.lblPoint.AutoSize = True
        Me.lblPoint.BackColor = System.Drawing.Color.Transparent
        Me.lblPoint.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint.ForeColor = System.Drawing.Color.White
        Me.lblPoint.Location = New System.Drawing.Point(361, 58)
        Me.lblPoint.Name = "lblPoint"
        Me.lblPoint.Size = New System.Drawing.Size(48, 33)
        Me.lblPoint.TabIndex = 26
        Me.lblPoint.Text = "0%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(122, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 25
        '
        'lblWord1
        '
        Me.lblWord1.BackColor = System.Drawing.Color.White
        Me.lblWord1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord1.Location = New System.Drawing.Point(3, 121)
        Me.lblWord1.Name = "lblWord1"
        Me.lblWord1.Size = New System.Drawing.Size(55, 22)
        Me.lblWord1.TabIndex = 24
        Me.lblWord1.Text = "??????"
        Me.lblWord1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(697, 573)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'lblWord6
        '
        Me.lblWord6.BackColor = System.Drawing.Color.White
        Me.lblWord6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord6.Location = New System.Drawing.Point(597, 625)
        Me.lblWord6.Name = "lblWord6"
        Me.lblWord6.Size = New System.Drawing.Size(86, 22)
        Me.lblWord6.TabIndex = 34
        Me.lblWord6.Text = "???????"
        Me.lblWord6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWord5
        '
        Me.lblWord5.BackColor = System.Drawing.Color.White
        Me.lblWord5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord5.Location = New System.Drawing.Point(3, 499)
        Me.lblWord5.Name = "lblWord5"
        Me.lblWord5.Size = New System.Drawing.Size(86, 22)
        Me.lblWord5.TabIndex = 35
        Me.lblWord5.Text = "?????????"
        Me.lblWord5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMain
        '
        Me.btnMain.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMain.Location = New System.Drawing.Point(978, 633)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(274, 36)
        Me.btnMain.TabIndex = 36
        Me.btnMain.Text = "Back to Main Menu"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(800, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Level2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Whitecollarlegit.My.Resources.Resources.Ep_2
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.lblWord5)
        Me.Controls.Add(Me.lblWord6)
        Me.Controls.Add(Me.lblErrors)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFailed)
        Me.Controls.Add(Me.lblWord4)
        Me.Controls.Add(Me.lblWord3)
        Me.Controls.Add(Me.lblWord2)
        Me.Controls.Add(Me.picJail)
        Me.Controls.Add(Me.lblPoint)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblWord1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.KeyPreview = True
        Me.Name = "Level2"
        Me.Text = "Level 2"
        CType(Me.picJail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Jailed As ImageList
    Friend WithEvents lblErrors As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFailed As Label
    Friend WithEvents lblWord4 As Label
    Friend WithEvents lblWord3 As Label
    Friend WithEvents lblWord2 As Label
    Friend WithEvents picJail As PictureBox
    Friend WithEvents lblPoint As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblWord1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWord6 As Label
    Friend WithEvents lblWord5 As Label
    Friend WithEvents btnMain As Button
    Friend WithEvents Button1 As Button
End Class
