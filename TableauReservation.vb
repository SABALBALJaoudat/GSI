Public Class TableauReservation
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If EcranPrincipal.Label1.Text = "Loué" Then
            Label_5_1.Text = EcranPrincipal.NomClient
            Label_5_2.Text = InformationVoiture.Label2.Text
            Label_5_3.Text = EcranPrincipal.DateDepart
            Label_5_4.Text = EcranPrincipal.DateArrive
        Else
            Label_5_1.Text = ""
            Label_5_2.Text = ""
            Label_5_3.Text = ""
            Label_5_4.Text = ""
        End If

    End Sub

    Private Sub TableauReservation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Select Case EcranPrincipal.etatactuel
            Case EcranPrincipal.etat.EcranPrincipal
            Case EcranPrincipal.etat.EcranTableau
                EcranPrincipal.etatactuel = EcranPrincipal.etat.EcranPrincipal
            Case EcranPrincipal.etat.Disponible
            Case EcranPrincipal.etat.ConfirmDisponible
            Case EcranPrincipal.etat.Réparée
            Case EcranPrincipal.etat.ConfirmRéparée
            Case EcranPrincipal.etat.Louée
            Case EcranPrincipal.etat.ConfirmLouée
        End Select

    End Sub
End Class