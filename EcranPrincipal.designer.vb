<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EcranPrincipal
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EcranPrincipal))
        Me.Voiture1 = New System.Windows.Forms.PictureBox()
        Me.Voiture2 = New System.Windows.Forms.PictureBox()
        Me.ListBoxDate = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Voiture3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VoitureOpacite = New System.Windows.Forms.PictureBox()
        Me.BtnReservation = New System.Windows.Forms.Button()
        Me.Réparation1 = New System.Windows.Forms.PictureBox()
        Me.Réparation2 = New System.Windows.Forms.PictureBox()
        CType(Me.Voiture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Voiture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Voiture3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoitureOpacite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Réparation1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Réparation2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Voiture1
        '
        Me.Voiture1.Image = CType(resources.GetObject("Voiture1.Image"), System.Drawing.Image)
        Me.Voiture1.Location = New System.Drawing.Point(379, 224)
        Me.Voiture1.Name = "Voiture1"
        Me.Voiture1.Size = New System.Drawing.Size(101, 136)
        Me.Voiture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Voiture1.TabIndex = 0
        Me.Voiture1.TabStop = False
        '
        'Voiture2
        '
        Me.Voiture2.Image = CType(resources.GetObject("Voiture2.Image"), System.Drawing.Image)
        Me.Voiture2.Location = New System.Drawing.Point(522, 224)
        Me.Voiture2.Name = "Voiture2"
        Me.Voiture2.Size = New System.Drawing.Size(101, 136)
        Me.Voiture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Voiture2.TabIndex = 1
        Me.Voiture2.TabStop = False
        '
        'ListBoxDate
        '
        Me.ListBoxDate.FormattingEnabled = True
        Me.ListBoxDate.ItemHeight = 16
        Me.ListBoxDate.Items.AddRange(New Object() {"01/05", "02/05", "03/05", "04/05", "05/05", "06/05", "07/05", "08/05", "09/05", "10/05", "11/05", "12/05", "13/05", "14/05", "15/05", "16/05", "18/05", "19/05", "20/05", "21/05", "22/05", "23/05", "24/05", "25/05", "26/05", "27/05", "28/05", "29/05", "30/05", "31/05"})
        Me.ListBoxDate.Location = New System.Drawing.Point(12, 60)
        Me.ListBoxDate.Name = "ListBoxDate"
        Me.ListBoxDate.Size = New System.Drawing.Size(104, 356)
        Me.ListBoxDate.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(393, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Disponible"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(528, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Disponible"
        '
        'Voiture3
        '
        Me.Voiture3.Image = CType(resources.GetObject("Voiture3.Image"), System.Drawing.Image)
        Me.Voiture3.Location = New System.Drawing.Point(656, 224)
        Me.Voiture3.Name = "Voiture3"
        Me.Voiture3.Size = New System.Drawing.Size(101, 136)
        Me.Voiture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Voiture3.TabIndex = 7
        Me.Voiture3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(664, 367)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Disponible"
        '
        'VoitureOpacite
        '
        Me.VoitureOpacite.Image = CType(resources.GetObject("VoitureOpacite.Image"), System.Drawing.Image)
        Me.VoitureOpacite.Location = New System.Drawing.Point(204, 302)
        Me.VoitureOpacite.Name = "VoitureOpacite"
        Me.VoitureOpacite.Size = New System.Drawing.Size(101, 136)
        Me.VoitureOpacite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VoitureOpacite.TabIndex = 9
        Me.VoitureOpacite.TabStop = False
        Me.VoitureOpacite.Visible = False
        '
        'BtnReservation
        '
        Me.BtnReservation.Location = New System.Drawing.Point(13, 12)
        Me.BtnReservation.Name = "BtnReservation"
        Me.BtnReservation.Size = New System.Drawing.Size(103, 37)
        Me.BtnReservation.TabIndex = 10
        Me.BtnReservation.Text = "Reservation"
        Me.BtnReservation.UseVisualStyleBackColor = True
        '
        'Réparation1
        '
        Me.Réparation1.Image = CType(resources.GetObject("Réparation1.Image"), System.Drawing.Image)
        Me.Réparation1.Location = New System.Drawing.Point(690, 402)
        Me.Réparation1.Name = "Réparation1"
        Me.Réparation1.Size = New System.Drawing.Size(45, 45)
        Me.Réparation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Réparation1.TabIndex = 11
        Me.Réparation1.TabStop = False
        '
        'Réparation2
        '
        Me.Réparation2.Image = CType(resources.GetObject("Réparation2.Image"), System.Drawing.Image)
        Me.Réparation2.Location = New System.Drawing.Point(602, 402)
        Me.Réparation2.Name = "Réparation2"
        Me.Réparation2.Size = New System.Drawing.Size(45, 45)
        Me.Réparation2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Réparation2.TabIndex = 12
        Me.Réparation2.TabStop = False
        Me.Réparation2.Visible = False
        Me.Réparation2.WaitOnLoad = True
        '
        'EcranPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Réparation2)
        Me.Controls.Add(Me.Réparation1)
        Me.Controls.Add(Me.BtnReservation)
        Me.Controls.Add(Me.VoitureOpacite)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Voiture3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxDate)
        Me.Controls.Add(Me.Voiture2)
        Me.Controls.Add(Me.Voiture1)
        Me.Name = "EcranPrincipal"
        Me.Text = "EcranPrincipal"
        CType(Me.Voiture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Voiture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Voiture3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoitureOpacite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Réparation1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Réparation2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Voiture1 As PictureBox
    Friend WithEvents Voiture2 As PictureBox
    Friend WithEvents ListBoxDate As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Voiture3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents VoitureOpacite As PictureBox
    Friend WithEvents BtnReservation As Button
    Friend WithEvents Réparation1 As PictureBox
    Friend WithEvents Réparation2 As PictureBox
End Class
