Public Class ConfirmationLouée
    Private Sub ConfirmationLouée_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Voulez vous passez en Loué ?"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case EcranPrincipal.etatactuel
            Case EcranPrincipal.etat.EcranPrincipal
            Case EcranPrincipal.etat.EcranTableau
            Case EcranPrincipal.etat.Disponible
            Case EcranPrincipal.etat.ConfirmDisponible
            Case EcranPrincipal.etat.Réparée
            Case EcranPrincipal.etat.ConfirmRéparée
            Case EcranPrincipal.etat.Louée
            Case EcranPrincipal.etat.ConfirmLouée
                EcranPrincipal.Label1.Text = "Loué"
                EcranPrincipal.Voiture1.Image = EcranPrincipal.ChangeOpacity(EcranPrincipal.VoitureOpacite.Image, 0.5)
                EcranPrincipal.Réparation1.Visible = False
                InformationVoiture.TextBox1.Enabled = True
                InformationVoiture.TextBox2.Enabled = True
                InformationVoiture.TextBox3.Enabled = True
                InformationVoiture.TextBox4.Enabled = False
                InformationVoiture.TextBox4.Text = ""
                InformationVoiture.TextBox5.Enabled = False
                InformationVoiture.TextBox5.Text = ""
                EcranPrincipal.etatactuel = EcranPrincipal.etat.Louée
                Me.Close()
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case EcranPrincipal.etatactuel
            Case EcranPrincipal.etat.EcranPrincipal
            Case EcranPrincipal.etat.EcranTableau
            Case EcranPrincipal.etat.Disponible
            Case EcranPrincipal.etat.ConfirmDisponible
            Case EcranPrincipal.etat.Réparée
            Case EcranPrincipal.etat.ConfirmRéparée
            Case EcranPrincipal.etat.Louée
            Case EcranPrincipal.etat.ConfirmLouée
                If EcranPrincipal.Label1.Text = "Disponible" Then
                    InformationVoiture.ListBox1.SelectedItem = "Disponible"
                End If
                If EcranPrincipal.Label1.Text = "Réparation" Then
                    InformationVoiture.ListBox1.SelectedItem = "Réparation"
                End If
                EcranPrincipal.etatactuel = InformationVoiture.EtatRetour
                Me.Close()
        End Select
    End Sub

    Private Sub ConfirmationLouée_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case EcranPrincipal.etatactuel
            Case EcranPrincipal.etat.EcranPrincipal
            Case EcranPrincipal.etat.EcranTableau
            Case EcranPrincipal.etat.Disponible
            Case EcranPrincipal.etat.ConfirmDisponible
            Case EcranPrincipal.etat.Réparée
            Case EcranPrincipal.etat.ConfirmRéparée
            Case EcranPrincipal.etat.Louée
            Case EcranPrincipal.etat.ConfirmLouée
                If EcranPrincipal.Label1.Text = "Disponible" Then
                    InformationVoiture.ListBox1.SelectedItem = "Disponible"
                End If
                If EcranPrincipal.Label1.Text = "Réparation" Then
                    InformationVoiture.ListBox1.SelectedItem = "Réparation"
                End If
                EcranPrincipal.etatactuel = InformationVoiture.EtatRetour
                Me.Close()
        End Select
    End Sub
End Class