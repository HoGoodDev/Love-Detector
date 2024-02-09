<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPerson1 = New System.Windows.Forms.Label()
        Me.lblPerson2 = New System.Windows.Forms.Label()
        Me.txtPerson1 = New System.Windows.Forms.TextBox()
        Me.txtPerson2 = New System.Windows.Forms.TextBox()
        Me.btnDetermineStrength = New System.Windows.Forms.Button()
        Me.lblPeopleMath = New System.Windows.Forms.Label()
        Me.lblMatchStrength = New System.Windows.Forms.Label()
        Me.picLove = New System.Windows.Forms.PictureBox()
        CType(Me.picLove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 60.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(458, 97)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Love Detector"
        '
        'lblPerson1
        '
        Me.lblPerson1.AutoSize = True
        Me.lblPerson1.BackColor = System.Drawing.Color.Transparent
        Me.lblPerson1.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerson1.Location = New System.Drawing.Point(12, 122)
        Me.lblPerson1.Name = "lblPerson1"
        Me.lblPerson1.Size = New System.Drawing.Size(145, 49)
        Me.lblPerson1.TabIndex = 1
        Me.lblPerson1.Text = "Person1:"
        '
        'lblPerson2
        '
        Me.lblPerson2.AutoSize = True
        Me.lblPerson2.BackColor = System.Drawing.Color.Transparent
        Me.lblPerson2.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerson2.Location = New System.Drawing.Point(389, 122)
        Me.lblPerson2.Name = "lblPerson2"
        Me.lblPerson2.Size = New System.Drawing.Size(145, 49)
        Me.lblPerson2.TabIndex = 2
        Me.lblPerson2.Text = "Person2:"
        '
        'txtPerson1
        '
        Me.txtPerson1.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerson1.Location = New System.Drawing.Point(163, 126)
        Me.txtPerson1.Name = "txtPerson1"
        Me.txtPerson1.Size = New System.Drawing.Size(202, 52)
        Me.txtPerson1.TabIndex = 3
        '
        'txtPerson2
        '
        Me.txtPerson2.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerson2.Location = New System.Drawing.Point(540, 126)
        Me.txtPerson2.Name = "txtPerson2"
        Me.txtPerson2.Size = New System.Drawing.Size(202, 52)
        Me.txtPerson2.TabIndex = 4
        '
        'btnDetermineStrength
        '
        Me.btnDetermineStrength.BackColor = System.Drawing.Color.White
        Me.btnDetermineStrength.Font = New System.Drawing.Font("Monotype Corsiva", 25.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetermineStrength.Location = New System.Drawing.Point(234, 194)
        Me.btnDetermineStrength.Name = "btnDetermineStrength"
        Me.btnDetermineStrength.Size = New System.Drawing.Size(290, 49)
        Me.btnDetermineStrength.TabIndex = 5
        Me.btnDetermineStrength.Text = "Determine Strength"
        Me.btnDetermineStrength.UseVisualStyleBackColor = False
        '
        'lblPeopleMath
        '
        Me.lblPeopleMath.BackColor = System.Drawing.Color.Transparent
        Me.lblPeopleMath.Font = New System.Drawing.Font("Monotype Corsiva", 25.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeopleMath.Location = New System.Drawing.Point(28, 246)
        Me.lblPeopleMath.Name = "lblPeopleMath"
        Me.lblPeopleMath.Size = New System.Drawing.Size(721, 41)
        Me.lblPeopleMath.TabIndex = 6
        Me.lblPeopleMath.Text = "Person 1 + Person 2"
        Me.lblPeopleMath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPeopleMath.Visible = False
        '
        'lblMatchStrength
        '
        Me.lblMatchStrength.BackColor = System.Drawing.Color.Transparent
        Me.lblMatchStrength.Font = New System.Drawing.Font("Monotype Corsiva", 25.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatchStrength.Location = New System.Drawing.Point(28, 551)
        Me.lblMatchStrength.Name = "lblMatchStrength"
        Me.lblMatchStrength.Size = New System.Drawing.Size(714, 41)
        Me.lblMatchStrength.TabIndex = 7
        Me.lblMatchStrength.Text = "Match Outcome"
        Me.lblMatchStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMatchStrength.Visible = False
        '
        'picLove
        '
        Me.picLove.BackColor = System.Drawing.Color.Transparent
        Me.picLove.Location = New System.Drawing.Point(239, 304)
        Me.picLove.Name = "picLove"
        Me.picLove.Size = New System.Drawing.Size(295, 232)
        Me.picLove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLove.TabIndex = 8
        Me.picLove.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(776, 601)
        Me.Controls.Add(Me.picLove)
        Me.Controls.Add(Me.lblMatchStrength)
        Me.Controls.Add(Me.lblPeopleMath)
        Me.Controls.Add(Me.btnDetermineStrength)
        Me.Controls.Add(Me.txtPerson2)
        Me.Controls.Add(Me.txtPerson1)
        Me.Controls.Add(Me.lblPerson2)
        Me.Controls.Add(Me.lblPerson1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Palace Script MT", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Love Detector"
        CType(Me.picLove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPerson1 As Label
    Friend WithEvents lblPerson2 As Label
    Friend WithEvents txtPerson1 As TextBox
    Friend WithEvents txtPerson2 As TextBox
    Friend WithEvents btnDetermineStrength As Button
    Friend WithEvents lblPeopleMath As Label
    Friend WithEvents lblMatchStrength As Label
    Friend WithEvents picLove As PictureBox
End Class
