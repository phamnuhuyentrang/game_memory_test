Public Class Cards_match
    ' Class Variables
    Public _name As String
    Public _picImage As PictureBox
    Public _Cover As Button

    Public Sub New(ByRef cardNumber As Integer, ByRef imgImage As Image, ByVal location As Point)
        ' This is the constructor for the Matching Card object. It requires an image, an integer, and a point
        ' as parameters. These parameters will decide the number for the card, the image under the card, and
        ' the location of the card.

        Me._name = "MatchingCard_" & cardNumber

        Me._picImage = New PictureBox
        Me._picImage.Size = New Size(54, 54)
        Me._picImage.BackgroundImage = imgImage
        Me._picImage.BackgroundImageLayout = ImageLayout.Stretch
        Me._picImage.Location = location
        Me._picImage.SendToBack()

        Me._Cover = New Button
        Me._Cover.Size = New Size(54, 74)
        Me._Cover.BackgroundImage = My.Resources.Wereldkaart_Vintage
        Me._Cover.BackgroundImageLayout = ImageLayout.Stretch

        Me._Cover.Location = location
        Me._Cover.BringToFront()

        AddHandler _Cover.Click, AddressOf CardIsClicked
    End Sub

    Public Sub CardIsClicked(ByVal sender As Object, ByVal e As EventArgs)
        ' This event handler fires when the user clicks a MatchingCard object.
        ' This will "flip" the card over and check if the next card the user clicks
        ' matches the first one.

        Dim btn As Button = DirectCast(sender, Button)

        btn.Visible = False
        If Form1.crdCard1 Is Nothing Then
            Form1.crdCard1 = Me
            Form1.flag_1.BackgroundImage = Form1.crdCard1._picImage.BackgroundImage
            Form1.flag_1.BackgroundImageLayout = ImageLayout.Stretch
            Dim temp As String = Mid(Form1.crdCard1._name, 14)
            Select Case Val(temp)
                Case 0
                    Form1.lb_flag1.Text = "Belgium"
                Case 1
                    Form1.lb_flag1.Text = "Croatia"
                Case 2
                    Form1.lb_flag1.Text = "Denmark"
                Case 3
                    Form1.lb_flag1.Text = "Finland"
                Case 4
                    Form1.lb_flag1.Text = "France"
                Case 5
                    Form1.lb_flag1.Text = "Germany"
                Case 6
                    Form1.lb_flag1.Text = "Hungary"
                Case 7
                    Form1.lb_flag1.Text = "Italy"
                Case 8
                    Form1.lb_flag1.Text = "Portugal"
                Case 9
                    Form1.lb_flag1.Text = "Spain"
                Case 10
                    Form1.lb_flag1.Text = "Switzerland"
                Case 11
                    Form1.lb_flag1.Text = "United Kingdom"
            End Select
        ElseIf Form1.crdCard2 Is Nothing Then
            Form1.crdCard2 = Me
            Form1.flag_2.BackgroundImage = Form1.crdCard2._picImage.BackgroundImage
            Form1.flag_2.BackgroundImageLayout = ImageLayout.Stretch
            Dim temp As String = Mid(Form1.crdCard2._name, 14)
            Select Case Val(temp)
                Case 0
                    Form1.lb_flag2.Text = "Belgium"
                Case 1
                    Form1.lb_flag2.Text = "Croatia"
                Case 2
                    Form1.lb_flag2.Text = "Denmark"
                Case 3
                    Form1.lb_flag2.Text = "Finland"
                Case 4
                    Form1.lb_flag2.Text = "France"
                Case 5
                    Form1.lb_flag2.Text = "Germany"
                Case 6
                    Form1.lb_flag2.Text = "Hungary"
                Case 7
                    Form1.lb_flag2.Text = "Italy"
                Case 8
                    Form1.lb_flag2.Text = "Portugal"
                Case 9
                    Form1.lb_flag2.Text = "Spain"
                Case 10
                    Form1.lb_flag2.Text = "Switzerland"
                Case 11
                    Form1.lb_flag2.Text = "United Kingdom"
            End Select
            Check(Form1.crdCard1, Form1.crdCard2)
        Else
            btn.Visible = True
        End If

        Form1.nombre_essais += 1
        Form1.Lbessai.Text = Form1.nombre_essais
    End Sub

    Public Sub Check(ByRef crdCard1 As Cards_match, ByRef crdCard2 As Cards_match)
        ' This Sub procedure will compare two cards to see if they match. If they do,
        ' the two card objects will be disposed and the total number of cards is reduced by two.

        If (crdCard1._name = crdCard2._name) Then
            Form1.intTotalCards -= 2
            Form1.nombre_paires += 1
            Form1.Lbpaires.Text = Form1.nombre_paires
            crdCard1._picImage.Dispose()
            crdCard1._Cover.Dispose()
            crdCard2._picImage.Dispose()
            crdCard2._Cover.Dispose()

            If (Form1.sound_en = True) Then
                'à corriger le répertoire 
                My.Computer.Audio.Play("C:\Users\ynhib\Desktop\Projet NF22\Ressources\yeahoo.wav")
            End If
            Form1.anim.Visible = True
            Form1.anim2.Visible = False

            Form1.crdCard1 = Nothing
            Form1.crdCard2 = Nothing
            If Form1.intTotalCards = 0 Then
                Form1.Time_Left.Stop()
                MsgBox("You Win")
            End If
        Else
            If (Form1.sound_en = True) Then
                'à corriger le répertoire
                My.Computer.Audio.Play("C:\Users\ynhib\Desktop\Projet NF22\Ressources\uhoh.wav")
            End If
            crdCard1._Cover.Visible = True
            Form1.crdCard1 = Form1.crdCard2
            Form1.crdCard2 = Nothing

            Form1.anim.Visible = False
            Form1.anim2.Visible = True
        End If
    End Sub
End Class
