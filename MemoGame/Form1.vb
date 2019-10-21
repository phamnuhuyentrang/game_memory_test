Public Class Form1
    Public crdCard1 As Cards_match
    Public crdCard2 As Cards_match
    Public intTotalCards As Integer = 24
    Public sound_en As Boolean = True

    Public nombre_paires As Integer
    Public nombre_essais As Integer

    Dim box_image As PictureBox

    Private MesImages As Image() = New Image(11) {My.Resources.belgium, My.Resources.croatia,
                                                My.Resources.denmark, My.Resources.finland,
                                                My.Resources.france, My.Resources.germany,
                                                My.Resources.hungary, My.Resources.italy, My.Resources.portugal, My.Resources.spain,
                                                My.Resources.switzerland, My.Resources.uk}

    Private LocationsList As List(Of Point) = New List(Of Point)
    Private basicList As List(Of Image) = New List(Of Image)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'InitializeComponent()
        StartGame()
        'Time_Left.Start()
        nombre_paires = 0 'initialisation du nombre de paires
        nombre_essais = 0 'initialisation du nombre d'essais
    End Sub

    Private Sub Time_Left_Tick(sender As Object, e As EventArgs) Handles Time_Left.Tick
        Time_Left.Start()
        Time_Left.Interval = 1000
        secleft.ForeColor = Color.Green
        minleft.ForeColor = Color.Green
        If secleft.Text = 30 And minleft.Text = 1 Then
            secleft.ForeColor = Color.Red
            minleft.ForeColor = Color.Red
            If Val(secleft.Text) = 0 Then
                minleft.Text = Val(minleft.Text) - 1
                secleft.Text = Val(secleft.Text) + 59
            Else
                secleft.Text = Val(secleft.Text) - 1
            End If
        ElseIf Val(secleft.Text) = 0 And Val(minleft.Text) = 0 Then
            Time_Left.Stop()
            MsgBox("Time out")
        Else
            If Val(secleft.Text) = 0 Then
                minleft.Text = Val(minleft.Text) - 1
                secleft.Text = Val(secleft.Text) + 59
            Else
                If Val(secleft.Text) <= 10 Then
                    secleft.Text = "0" + CStr(Val(secleft.Text) - 1)
                Else
                    secleft.Text = Val(secleft.Text) - 1
                End If
            End If
        End If
    End Sub

    Private Sub InstantiateLists()
        LocationsList.Add(New Point(17, 27))
        LocationsList.Add(New Point(96, 27))
        LocationsList.Add(New Point(175, 27))
        LocationsList.Add(New Point(254, 27))
        LocationsList.Add(New Point(333, 27))
        LocationsList.Add(New Point(412, 27))
        LocationsList.Add(New Point(491, 27))
        LocationsList.Add(New Point(570, 27))
        LocationsList.Add(New Point(17, 150))
        LocationsList.Add(New Point(96, 150))
        LocationsList.Add(New Point(175, 150))
        LocationsList.Add(New Point(254, 150))
        LocationsList.Add(New Point(333, 150))
        LocationsList.Add(New Point(412, 150))
        LocationsList.Add(New Point(491, 150))
        LocationsList.Add(New Point(570, 150))
        LocationsList.Add(New Point(17, 273))
        LocationsList.Add(New Point(96, 273))
        LocationsList.Add(New Point(175, 273))
        LocationsList.Add(New Point(254, 273))
        LocationsList.Add(New Point(333, 273))
        LocationsList.Add(New Point(412, 273))
        LocationsList.Add(New Point(491, 273))
        LocationsList.Add(New Point(570, 273))

        For l = 0 To 11
            basicList.Add(MesImages(l))
        Next

    End Sub

    Private Sub but_exit_Click(sender As Object, e As EventArgs) Handles but_exit.Click
        Application.Exit()
    End Sub

    Private Sub StartGame()
        InstantiateLists()
        pnlCards.Controls.Clear()
        Dim full As Boolean = False
        Dim cardIndex As Integer = 0
        Dim indexes As List(Of Integer) = New List(Of Integer)
        Dim cards As List(Of Cards_match) = New List(Of Cards_match)

        Dim random As New Random()
        Dim intIndex As Integer
        Dim cardLocation As New Point()

        anim.Visible = False
        anim2.Visible = False

        For i As Integer = 0 To 11
            cards.Add(New Cards_match(i, basicList(i), New Point(2133, 3)))
            cards.Add(New Cards_match(i, basicList(i), New Point(2133, 3)))
        Next

        While full = False
            Try
                intIndex = random.Next(0, LocationsList.Count - 1)
            Catch e As ArgumentOutOfRangeException
                full = True
                Continue While
            End Try

            If LocationsList(intIndex) = Nothing Then
                Continue While
            ElseIf Not LocationsList(intIndex) = Nothing And cardIndex < 24 Then
                cards(cardIndex)._picImage.Location = LocationsList(intIndex)
                cards(cardIndex)._Cover.Location = LocationsList(intIndex)
                pnlCards.Controls.Add(cards(cardIndex)._Cover)
                pnlCards.Controls.Add(cards(cardIndex)._picImage)
                LocationsList.RemoveAt(intIndex)
                cardIndex += 1
            Else
                full = True
            End If

        End While


        nombre_essais = 0
        nombre_paires = 0

        Lbessai.Text = nombre_essais
        Lbpaires.Text = nombre_paires

        pnlCards.Visible = True
        Time_Left.Start()
        LocationsList.Clear()
        LocationsList.TrimExcess()
    End Sub

    Private Sub but_res_Click(sender As Object, e As EventArgs) Handles but_res.Click
        Time_Left.Stop()
        'InstantiateLists()
        secleft.Text = "00"
        minleft.Text = 3
        StartGame()
    End Sub

    Private Sub sound_enable_Click(sender As Object, e As EventArgs) Handles sound_enable.Click
        If (Me.sound_en = True) Then
            Me.sound_en = False
        Else
            Me.sound_en = True
        End If
    End Sub
End Class
