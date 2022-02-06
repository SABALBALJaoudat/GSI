Public Class InformationVoiture

    Public EtatRetour As EcranPrincipal.etat

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Select Case EcranPrincipal.etatactuel
            Case EcranPrincipal.etat.EcranPrincipal
            Case EcranPrincipal.etat.EcranTableau
            Case EcranPrincipal.etat.Disponible
                If ListBox1.SelectedItem = "Disponible" Then
                    'Pas possible
                ElseIf ListBox1.SelectedItem = "Réparation" Then
                    EcranPrincipal.etatactuel = EcranPrincipal.etat.ConfirmRéparée
                    EtatRetour = EcranPrincipal.etat.Disponible
                    ConfirmationRéparation.Visible = True
                ElseIf ListBox1.SelectedItem = "Loué" Then
                    EcranPrincipal.etatactuel = EcranPrincipal.etat.ConfirmLouée
                    EtatRetour = EcranPrincipal.etat.Disponible
                    ConfirmationLouée.Visible = True
                End If
            Case EcranPrincipal.etat.ConfirmDisponible
            Case EcranPrincipal.etat.Réparée
                If ListBox1.SelectedItem = "Disponible" Then
                    EcranPrincipal.etatactuel = EcranPrincipal.etat.ConfirmDisponible
                    EtatRetour = EcranPrincipal.etat.Réparée
                    ConfirmationDisponible.Visible = True
                ElseIf ListBox1.SelectedItem = "Réparation" Then
                    'Pas possible
                ElseIf ListBox1.SelectedItem = "Loué" Then
                    EcranPrincipal.etatactuel = EcranPrincipal.etat.ConfirmLouée
                    EtatRetour = EcranPrincipal.etat.Réparée
                    ConfirmationLouée.Visible = True
                End If
            Case EcranPrincipal.etat.ConfirmRéparée
            Case EcranPrincipal.etat.Louée
                If ListBox1.SelectedItem = "Disponible" Then
                    EcranPrincipal.etatactuel = EcranPrincipal.etat.ConfirmDisponible
                    EtatRetour = EcranPrincipal.etat.Louée
                    ConfirmationDisponible.Visible = True
                ElseIf ListBox1.SelectedItem = "Réparation" Then
                    EcranPrincipal.etatactuel = EcranPrincipal.etat.ConfirmRéparée
                    EtatRetour = EcranPrincipal.etat.Louée
                    ConfirmationRéparation.Visible = True
                ElseIf ListBox1.SelectedItem = "Loué" Then
                    'Pas possible
                End If
            Case EcranPrincipal.etat.ConfirmLouée
        End Select

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        EcranPrincipal.DateDepart = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        EcranPrincipal.DateArrive = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        EcranPrincipal.NomClient = TextBox3.Text
    End Sub

    Private Sub InformationVoiture_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Select Case EcranPrincipal.etatactuel
            Case EcranPrincipal.etat.EcranPrincipal
            Case EcranPrincipal.etat.EcranTableau
            Case EcranPrincipal.etat.Disponible
                EcranPrincipal.etatactuel = EcranPrincipal.etat.EcranPrincipal
            Case EcranPrincipal.etat.ConfirmDisponible
            Case EcranPrincipal.etat.Réparée
                EcranPrincipal.etatactuel = EcranPrincipal.etat.EcranPrincipal
            Case EcranPrincipal.etat.ConfirmRéparée
            Case EcranPrincipal.etat.Louée
                EcranPrincipal.etatactuel = EcranPrincipal.etat.EcranPrincipal
            Case EcranPrincipal.etat.ConfirmLouée
        End Select

    End Sub

End Class