Imports System.Drawing.Imaging

Public Class EcranPrincipal
    Public NomClient As String
    Public DateDepart As String
    Public DateArrive As String
    Public DebutReparation As String
    Public FinReparation As String

    Public Enum etat
        EcranPrincipal
        EcranTableau
        Disponible
        ConfirmDisponible
        Réparée
        ConfirmRéparée
        Louée
        ConfirmLouée
        EcranPrincipalDate2
    End Enum
    Public etatactuel As etat

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ini()
        Select Case etatactuel
            Case etat.EcranPrincipal
                IniDate1()
            Case etat.EcranTableau
            Case etat.Disponible
            Case etat.ConfirmDisponible
            Case etat.Réparée
            Case etat.ConfirmRéparée
            Case etat.Louée
            Case etat.ConfirmLouée
            Case etat.EcranPrincipalDate2
        End Select
        Console.WriteLine(etatactuel)
    End Sub



    Private Sub Ini()
        Console.WriteLine("Initialisation")
        etatactuel = etat.EcranPrincipal

        'Parking 1
        Voiture1.Visible = True
        Voiture1.Width = 80
        Voiture1.Height = 120
        Voiture1.Top = 20
        Voiture1.Left = 105
        Label1.Top = 150
        Label1.Left = 115
        Réparation1.Top = 12
        Réparation1.Left = 100
        Réparation1.Visible = False

        'Parking 2
        Voiture2.Visible = True
        Voiture2.Width = 80
        Voiture2.Height = 120
        Voiture2.Top = 20
        Voiture2.Left = 225
        Label2.Top = 150
        Label2.Left = 235
        Réparation2.Top = 12
        Réparation2.Left = 225


        'Parking 3
        Voiture3.Visible = True
        Voiture3.Width = 80
        Voiture3.Height = 120
        Voiture3.Top = 20
        Voiture3.Left = 345
        Label3.Top = 150
        Label3.Left = 355
    End Sub



    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Console.WriteLine("Paint")

        Using blackPen As New Pen(Color.Black),
            formGraphics As Graphics = Me.CreateGraphics()

            'Parking 1
            formGraphics.DrawLine(blackPen, 100, 10, 190, 10)
            formGraphics.DrawLine(blackPen, 100, 10, 100, 150)
            formGraphics.DrawLine(blackPen, 190, 10, 190, 150)

            'Parking 2
            formGraphics.DrawLine(blackPen, 220, 10, 310, 10)
            formGraphics.DrawLine(blackPen, 220, 10, 220, 150)
            formGraphics.DrawLine(blackPen, 310, 10, 310, 150)

            'Parking 3
            formGraphics.DrawLine(blackPen, 340, 10, 430, 10)
            formGraphics.DrawLine(blackPen, 340, 10, 340, 150)
            formGraphics.DrawLine(blackPen, 430, 10, 430, 150)
        End Using

    End Sub



    Private Sub IniDate1()
        Console.WriteLine("Initialisation Date 1")

        'Parking 1
        Voiture1.Image = ChangeOpacity(VoitureOpacite.Image, 1)
        If Label1.Text = "Loué" Then
            Voiture1.Image = ChangeOpacity(VoitureOpacite.Image, 0.5)
        End If

        'Parking 2
        Voiture2.Image = ChangeOpacity(VoitureOpacite.Image, 0.5)
        Label2.Text = "Réparation"
        Réparation2.Visible = True

        'Parking 3
        Voiture3.Image = ChangeOpacity(VoitureOpacite.Image, 0.5)
        Label3.Text = "Loué"
    End Sub



    Private Sub IniDate2()
        Console.WriteLine("Initialisation Date 2")

        'Parking 1
        Voiture1.Image = ChangeOpacity(VoitureOpacite.Image, 1)
        Label1.Text = "Disponible"

        'Parking 2
        Voiture2.Image = ChangeOpacity(VoitureOpacite.Image, 1)
        Label2.Text = "Disponible"
        Réparation2.Visible = False

        'Parking 3
        Voiture3.Image = ChangeOpacity(VoitureOpacite.Image, 0.5)
        Label3.Text = "Loué"
    End Sub



    Public Shared Function ChangeOpacity(ByVal img As Image, ByVal opacityvalue As Single) As Bitmap
        Dim bmp As New Bitmap(img.Width, img.Height)
        Dim graphics__1 As Graphics = Graphics.FromImage(bmp)
        Dim colormatrix As New ColorMatrix
        colormatrix.Matrix33 = opacityvalue
        Dim imgAttribute As New ImageAttributes
        imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.[Default], ColorAdjustType.Bitmap)
        graphics__1.DrawImage(img, New Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height,
         GraphicsUnit.Pixel, imgAttribute)
        graphics__1.Dispose()
        Return bmp
    End Function



    Private Sub ListBoxDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxDate.SelectedIndexChanged
        Console.WriteLine(ListBoxDate.SelectedItem)

        Select Case etatactuel
            Case etat.EcranPrincipal
                If ListBoxDate.SelectedItem = "01/05" Then
                    etatactuel = etat.EcranPrincipal
                    IniDate1()
                ElseIf ListBoxDate.SelectedItem = "02/05" Then
                    etatactuel = etat.EcranPrincipalDate2
                    IniDate2()
                End If
            Case etat.EcranTableau
            Case etat.Disponible
            Case etat.ConfirmDisponible
            Case etat.Réparée
            Case etat.ConfirmRéparée
            Case etat.Louée
            Case etat.ConfirmLouée
            Case etat.EcranPrincipalDate2
                If ListBoxDate.SelectedItem = "01/05" Then
                    etatactuel = etat.EcranPrincipal
                    IniDate1()
                ElseIf ListBoxDate.SelectedItem = "02/05" Then
                    etatactuel = etat.EcranPrincipalDate2
                    IniDate2()
                End If
        End Select

    End Sub



    Private Sub Voiture1_Click(sender As Object, e As EventArgs) Handles Voiture1.Click
        Console.WriteLine("Clique Voiture1")

        Select Case etatactuel
            Case etat.EcranPrincipal
                If Label1.Text = "Disponible" Then
                    etatactuel = etat.Disponible
                    InformationVoiture.Visible = True
                    InformationVoiture.ListBox1.SelectedItem = "Disponible"
                    InformationVoiture.TextBox1.Enabled = False
                    InformationVoiture.TextBox2.Enabled = False
                    InformationVoiture.TextBox3.Enabled = False
                    InformationVoiture.TextBox4.Enabled = False
                    InformationVoiture.TextBox5.Enabled = False
                End If
                If Label1.Text = "Réparation" Then
                    etatactuel = etat.Réparée
                    InformationVoiture.Visible = True
                    InformationVoiture.ListBox1.SelectedItem = "Réparation"
                    InformationVoiture.TextBox1.Enabled = False
                    InformationVoiture.TextBox2.Enabled = False
                    InformationVoiture.TextBox3.Enabled = False
                    InformationVoiture.TextBox4.Enabled = True
                    InformationVoiture.TextBox4.Text = DebutReparation
                    InformationVoiture.TextBox5.Enabled = True
                    InformationVoiture.TextBox5.Text = FinReparation
                End If
                If Label1.Text = "Loué" Then
                    etatactuel = etat.Louée
                    InformationVoiture.Visible = True
                    InformationVoiture.ListBox1.SelectedItem = "Loué"
                    InformationVoiture.TextBox1.Enabled = True
                    InformationVoiture.TextBox1.Text = DateDepart
                    InformationVoiture.TextBox2.Enabled = True
                    InformationVoiture.TextBox2.Text = DateArrive
                    InformationVoiture.TextBox3.Enabled = True
                    InformationVoiture.TextBox3.Text = NomClient
                    InformationVoiture.TextBox4.Enabled = False
                    InformationVoiture.TextBox5.Enabled = False
                End If
            Case etat.EcranTableau
            Case etat.Disponible
            Case etat.ConfirmDisponible
            Case etat.Réparée
            Case etat.ConfirmRéparée
            Case etat.Louée
            Case etat.ConfirmLouée
            Case etat.EcranPrincipalDate2
        End Select
    End Sub




    Private Sub BtnReservation_Click(sender As Object, e As EventArgs) Handles BtnReservation.Click
        Console.WriteLine("Réservation")

        Select Case etatactuel
            Case etat.EcranPrincipal
                etatactuel = etat.EcranTableau
                TableauReservation.Visible = True
            Case etat.EcranTableau
            Case etat.Disponible
            Case etat.ConfirmDisponible
            Case etat.Réparée
            Case etat.ConfirmRéparée
            Case etat.Louée
            Case etat.ConfirmLouée
            Case etat.EcranPrincipalDate2
        End Select
    End Sub
End Class
