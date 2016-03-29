<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Arcade
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Arcade))
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblPoint = New System.Windows.Forms.Label()
        Me.picChar = New System.Windows.Forms.PictureBox()
        Me.imgChars = New System.Windows.Forms.ImageList(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnQuit = New System.Windows.Forms.Button()
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Location = New System.Drawing.Point(193, 54)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(49, 39)
        Me.lblTime.TabIndex = 16
        Me.lblTime.Text = "30"
        '
        'lblPoint
        '
        Me.lblPoint.AutoSize = True
        Me.lblPoint.BackColor = System.Drawing.Color.Transparent
        Me.lblPoint.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint.Location = New System.Drawing.Point(839, 18)
        Me.lblPoint.Name = "lblPoint"
        Me.lblPoint.Size = New System.Drawing.Size(89, 33)
        Me.lblPoint.TabIndex = 17
        Me.lblPoint.Text = "FAILED"
        '
        'picChar
        '
        Me.picChar.Location = New System.Drawing.Point(140, 96)
        Me.picChar.Name = "picChar"
        Me.picChar.Size = New System.Drawing.Size(300, 300)
        Me.picChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChar.TabIndex = 18
        Me.picChar.TabStop = False
        '
        'imgChars
        '
        Me.imgChars.ImageStream = CType(resources.GetObject("imgChars.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgChars.TransparentColor = System.Drawing.Color.Transparent
        Me.imgChars.Images.SetKeyName(0, "img-thing.jpg")
        Me.imgChars.Images.SetKeyName(1, "tim-1.jpg")
        Me.imgChars.Images.SetKeyName(2, "whitecollar_diana.jpg")
        Me.imgChars.Images.SetKeyName(3, "whitecollar_elizabeth.png")
        Me.imgChars.Images.SetKeyName(4, "whitecollar_jones.jpg")
        Me.imgChars.Images.SetKeyName(5, "whitecollar_june.jpg")
        Me.imgChars.Images.SetKeyName(6, "whitecollar_kate.jpg")
        Me.imgChars.Images.SetKeyName(7, "whitecollar_mozzie.JPG")
        Me.imgChars.Images.SetKeyName(8, "whitecollar_sara.jpg")
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(658, 96)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 57)
        Me.btnStart.TabIndex = 19
        Me.btnStart.Text = "Start!"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(1155, 9)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(97, 74)
        Me.btnQuit.TabIndex = 20
        Me.btnQuit.Text = "Save + Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Arcade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Whitecollarlegit.My.Resources.Resources.Arcade
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picChar)
        Me.Controls.Add(Me.lblPoint)
        Me.Controls.Add(Me.lblTime)
        Me.Name = "Arcade"
        Me.Text = "Arcade"
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTime As Label
    Friend WithEvents lblPoint As Label
    Friend WithEvents picChar As PictureBox
    Friend WithEvents imgChars As ImageList
    Friend WithEvents btnStart As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnQuit As Button
End Class
