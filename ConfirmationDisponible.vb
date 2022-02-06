Public Class ConfirmationDisponible
    Private Sub ConfirmationDisponible_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Voulez vous passer en Disponible ?"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case EcranPrincipal.etatactuel
            Case EcranPrincipal.etat.EcranPrincipal
            Case EcranPrincipal.etat.EcranTableau
            Case EcranPrincipal.etat.Disponible
            Case EcranPrincipal.etat.ConfirmDisponible
                EcranPrincipal.Label1.Text = "Disponible"
                EcranPrincipal.Voiture1.Image = EcranPrincipal.ChangeOpacity(EcranPrincipal.VoitureOpacite.Image, 1)
                EcranPrincipal.Réparation1.Visible = False
                InformationVoiture.TextBox1.Enabled = False
                InformationVoiture.TextBox1.Text = ""
                InformationVoiture.TextBox2.Enabled = False
                InformationVoiture.TextBox2.Text = ""
                InformationVoiture.TextBox3.Enabled = False
                InformationVoiture.TextBox3.Text = ""
                InformationVoiture.TextBox4.Enabled = False
                InformationVoiture.TextBox5.Enabled = False
                EcranPrincipal.etatactuel = EcranPrincipal.etat.Disponible
                Me.Close()
            Case EcranPrincipal.etat.Réparée
            Case EcranPrincipal.etat.ConfirmRéparée
            Case EcranPrincipal.etat.Louée
            Case EcranPrincipal.etat.ConfirmLouée
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case EcranPrincipal.etatactuel
            Case EcranPrincipal.etat.EcranPrincipal
            Case EcranPrincipal.etat.EcranTableau
            Case EcranPrincipal.etat.Disponible
            Case EcranPrincipal.etat.ConfirmDisponible
                If EcranPrincipal.Label1.Text = "Réparation" Then
                    InformationVoiture.ListBox1.SelectedItem = "Réparation"
                End If
                If EcranPrincipal.Label1.Text = "Loué" Then
                    InformationVoiture.ListBox1.SelectedItem = "Loué"
                End If
                EcranPrincipal.etatactuel = InformationVoiture.EtatRetour
                Me.Close()
            Case EcranPrincipal.etat.Réparée
            Case EcranPrincipal.etat.ConfirmRéparée
            Case EcranPrincipal.etat.Louée
            Case EcranPrincipal.etat.ConfirmLouée
        End Select
    End Sub

    Private Sub ConfirmationDisponible_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case EcranPrincipal.etatactuel
            Case EcranPrincipal.etat.EcranPrincipal
            Case EcranPrincipal.etat.EcranTableau
            Case EcranPrincipal.etat.Disponible
            Case EcranPrincipal.etat.ConfirmDisponible
                If EcranPrincipal.Label1.Text = "Réparation" Then
                    InformationVoiture.ListBox1.SelectedItem = "Réparation"
                End If
                If EcranPrincipal.Label1.Text = "Loué" Then
                    InformationVoiture.ListBox1.SelectedItem = "Loué"
                End If
                EcranPrincipal.etatactuel = InformationVoiture.EtatRetour
                Me.Close()
            Case EcranPrincipal.etat.Réparée
            Case EcranPrincipal.etat.ConfirmRéparée
            Case EcranPrincipal.etat.Louée
            Case EcranPrincipal.etat.ConfirmLouée
        End Select
    End Sub
End Class