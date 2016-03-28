<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arcade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Arcade))
        Me.lblPoint = New System.Windows.Forms.Label()
        Me.lblFailed = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgChars = New System.Windows.Forms.ImageList(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPoint
        '
        Me.lblPoint.AutoSize = True
        Me.lblPoint.BackColor = System.Drawing.Color.Transparent
        Me.lblPoint.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint.ForeColor = System.Drawing.Color.Black
        Me.lblPoint.Location = New System.Drawing.Point(193, 54)
        Me.lblPoint.Name = "lblPoint"
        Me.lblPoint.Size = New System.Drawing.Size(49, 39)
        Me.lblPoint.TabIndex = 16
        Me.lblPoint.Text = "30"
        '
        'lblFailed
        '
        Me.lblFailed.AutoSize = True
        Me.lblFailed.BackColor = System.Drawing.Color.Transparent
        Me.lblFailed.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailed.Location = New System.Drawing.Point(839, 18)
        Me.lblFailed.Name = "lblFailed"
        Me.lblFailed.Size = New System.Drawing.Size(89, 33)
        Me.lblFailed.TabIndex = 17
        Me.lblFailed.Text = "FAILED"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(140, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(300, 35)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Arcade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Whitecollarlegit.My.Resources.Resources.Arcade
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblFailed)
        Me.Controls.Add(Me.lblPoint)
        Me.Name = "Arcade"
        Me.Text = "Arcade"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPoint As Label
    Friend WithEvents lblFailed As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents imgChars As ImageList
    Friend WithEvents btnStart As Button
    Friend WithEvents Button1 As Button
End Class
