<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.back = New System.Windows.Forms.Button()
        Me.but_exit = New System.Windows.Forms.Button()
        Me.but_res = New System.Windows.Forms.Button()
        Me.sound_enable = New System.Windows.Forms.Button()
        Me.Time_Left = New System.Windows.Forms.Timer(Me.components)
        Me.labeltimeleft = New System.Windows.Forms.Label()
        Me.secleft = New System.Windows.Forms.Label()
        Me.minleft = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbessai = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbpaires = New System.Windows.Forms.Label()
        Me.pnlCards = New System.Windows.Forms.Panel()
        Me.flag_1 = New System.Windows.Forms.PictureBox()
        Me.flag_2 = New System.Windows.Forms.PictureBox()
        Me.anim = New System.Windows.Forms.PictureBox()
        Me.lb_flag1 = New System.Windows.Forms.Label()
        Me.lb_flag2 = New System.Windows.Forms.Label()
        Me.anim2 = New System.Windows.Forms.PictureBox()
        CType(Me.flag_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flag_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.anim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.anim2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(266, 30)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(254, 71)
        Me.back.TabIndex = 1
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'but_exit
        '
        Me.but_exit.Location = New System.Drawing.Point(956, 30)
        Me.but_exit.Name = "but_exit"
        Me.but_exit.Size = New System.Drawing.Size(254, 71)
        Me.but_exit.TabIndex = 2
        Me.but_exit.Text = "Exit"
        Me.but_exit.UseVisualStyleBackColor = True
        '
        'but_res
        '
        Me.but_res.Location = New System.Drawing.Point(1587, 30)
        Me.but_res.Name = "but_res"
        Me.but_res.Size = New System.Drawing.Size(254, 71)
        Me.but_res.TabIndex = 3
        Me.but_res.Text = "Restart"
        Me.but_res.UseVisualStyleBackColor = True
        '
        'sound_enable
        '
        Me.sound_enable.Location = New System.Drawing.Point(2216, 30)
        Me.sound_enable.Name = "sound_enable"
        Me.sound_enable.Size = New System.Drawing.Size(254, 71)
        Me.sound_enable.TabIndex = 4
        Me.sound_enable.Text = "Sound"
        Me.sound_enable.UseVisualStyleBackColor = True
        '
        'Time_Left
        '
        Me.Time_Left.Enabled = True
        Me.Time_Left.Interval = 1000
        '
        'labeltimeleft
        '
        Me.labeltimeleft.AutoSize = True
        Me.labeltimeleft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltimeleft.Location = New System.Drawing.Point(639, 168)
        Me.labeltimeleft.Name = "labeltimeleft"
        Me.labeltimeleft.Size = New System.Drawing.Size(185, 46)
        Me.labeltimeleft.TabIndex = 6
        Me.labeltimeleft.Text = "Time Left"
        '
        'secleft
        '
        Me.secleft.AutoSize = True
        Me.secleft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secleft.Location = New System.Drawing.Point(994, 168)
        Me.secleft.Name = "secleft"
        Me.secleft.Size = New System.Drawing.Size(64, 46)
        Me.secleft.TabIndex = 7
        Me.secleft.Text = "00"
        '
        'minleft
        '
        Me.minleft.AutoSize = True
        Me.minleft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minleft.Location = New System.Drawing.Point(909, 168)
        Me.minleft.Name = "minleft"
        Me.minleft.Size = New System.Drawing.Size(42, 46)
        Me.minleft.TabIndex = 8
        Me.minleft.Text = "3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(957, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 46)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1252, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 46)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre d'essais"
        '
        'Lbessai
        '
        Me.Lbessai.AutoSize = True
        Me.Lbessai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbessai.Location = New System.Drawing.Point(1579, 168)
        Me.Lbessai.Name = "Lbessai"
        Me.Lbessai.Size = New System.Drawing.Size(42, 46)
        Me.Lbessai.TabIndex = 11
        Me.Lbessai.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1892, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(274, 46)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Paires trouvés"
        '
        'Lbpaires
        '
        Me.Lbpaires.AutoSize = True
        Me.Lbpaires.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbpaires.Location = New System.Drawing.Point(2208, 168)
        Me.Lbpaires.Name = "Lbpaires"
        Me.Lbpaires.Size = New System.Drawing.Size(42, 46)
        Me.Lbpaires.TabIndex = 13
        Me.Lbpaires.Text = "0"
        '
        'pnlCards
        '
        Me.pnlCards.Location = New System.Drawing.Point(77, 287)
        Me.pnlCards.Name = "pnlCards"
        Me.pnlCards.Size = New System.Drawing.Size(2515, 1401)
        Me.pnlCards.TabIndex = 14
        '
        'flag_1
        '
        Me.flag_1.Location = New System.Drawing.Point(2763, 472)
        Me.flag_1.Name = "flag_1"
        Me.flag_1.Size = New System.Drawing.Size(324, 178)
        Me.flag_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.flag_1.TabIndex = 15
        Me.flag_1.TabStop = False
        '
        'flag_2
        '
        Me.flag_2.Location = New System.Drawing.Point(2763, 708)
        Me.flag_2.Name = "flag_2"
        Me.flag_2.Size = New System.Drawing.Size(324, 178)
        Me.flag_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.flag_2.TabIndex = 17
        Me.flag_2.TabStop = False
        '
        'anim
        '
        Me.anim.Image = Global.MemoGame.My.Resources.Resources.nice
        Me.anim.Location = New System.Drawing.Point(2763, 956)
        Me.anim.Name = "anim"
        Me.anim.Size = New System.Drawing.Size(792, 732)
        Me.anim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.anim.TabIndex = 19
        Me.anim.TabStop = False
        '
        'lb_flag1
        '
        Me.lb_flag1.AutoSize = True
        Me.lb_flag1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.lb_flag1.Font = New System.Drawing.Font("Old English Text MT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_flag1.Location = New System.Drawing.Point(3185, 472)
        Me.lb_flag1.Name = "lb_flag1"
        Me.lb_flag1.Size = New System.Drawing.Size(361, 95)
        Me.lb_flag1.TabIndex = 20
        Me.lb_flag1.Text = "Unknown"
        '
        'lb_flag2
        '
        Me.lb_flag2.AutoSize = True
        Me.lb_flag2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.lb_flag2.Font = New System.Drawing.Font("Old English Text MT", 24.0!)
        Me.lb_flag2.Location = New System.Drawing.Point(3185, 708)
        Me.lb_flag2.Name = "lb_flag2"
        Me.lb_flag2.Size = New System.Drawing.Size(361, 95)
        Me.lb_flag2.TabIndex = 21
        Me.lb_flag2.Text = "Unknown"
        '
        'anim2
        '
        Me.anim2.Image = Global.MemoGame.My.Resources.Resources.no
        Me.anim2.Location = New System.Drawing.Point(2763, 933)
        Me.anim2.Name = "anim2"
        Me.anim2.Size = New System.Drawing.Size(792, 732)
        Me.anim2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.anim2.TabIndex = 22
        Me.anim2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(3689, 1764)
        Me.Controls.Add(Me.anim2)
        Me.Controls.Add(Me.lb_flag2)
        Me.Controls.Add(Me.lb_flag1)
        Me.Controls.Add(Me.anim)
        Me.Controls.Add(Me.flag_2)
        Me.Controls.Add(Me.flag_1)
        Me.Controls.Add(Me.pnlCards)
        Me.Controls.Add(Me.Lbpaires)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lbessai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.minleft)
        Me.Controls.Add(Me.secleft)
        Me.Controls.Add(Me.labeltimeleft)
        Me.Controls.Add(Me.sound_enable)
        Me.Controls.Add(Me.but_res)
        Me.Controls.Add(Me.but_exit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.flag_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flag_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.anim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.anim2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back As Button
    Friend WithEvents but_exit As Button
    Friend WithEvents but_res As Button
    Friend WithEvents sound_enable As Button
    Friend WithEvents Time_Left As Timer
    Friend WithEvents labeltimeleft As Label
    Friend WithEvents secleft As Label
    Friend WithEvents minleft As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbessai As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbpaires As Label
    Friend WithEvents pnlCards As Panel
    Friend WithEvents flag_1 As PictureBox
    Friend WithEvents flag_2 As PictureBox
    Friend WithEvents anim As PictureBox
    Friend WithEvents lb_flag1 As Label
    Friend WithEvents lb_flag2 As Label
    Friend WithEvents anim2 As PictureBox
End Class
