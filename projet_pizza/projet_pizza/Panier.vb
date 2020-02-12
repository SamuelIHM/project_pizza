Public Class Form2
    Public Event AccueilWindow()
    Public Event ValiderCommande()
    Private menuConfig As MenuConfigurer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_OnActivated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CreateListPizza()
        SetButtonValide()
    End Sub

    Private Sub ButtonToAccueil_Click(sender As Object, e As EventArgs) Handles ButtonToAccueil.Click
        RaiseEvent AccueilWindow()
    End Sub

    Private Sub CreateListPizza()
        ' Permet d'afficher la liste des pizzas selectionnées avec des userControl
        ' Permet aussi d'avoir le prix total
        Dim prix As Single
        PanelPizzaPanier.Controls.Clear()
        For index = 0 To pizzasInPannier.Count - 1
            Dim uc As pizzaPanier
            uc = New pizzaPanier(pizzasInPannier(index)) With {
                .Location = New Point(10, 100 * index)
            }
            AddHandler uc.modifierPizza, AddressOf MenuOpened
            AddHandler uc.deletePizza, AddressOf PizzaDeleted
            PanelPizzaPanier.Controls.Add(uc)

            prix += pizzasInPannier(index).prix
        Next
        LabelTotalPrice.Text = prix.ToString + " €"
    End Sub

    Private Sub PizzaDeleted(p As Pizza)
        CreateListPizza()
        SetButtonValide()
    End Sub

    Private Sub MenuOpened(pizza As Pizza)
        ' Ouvre le menu de modification de la pizza
        menuConfig = New MenuConfigurer(pizza) With {
            .Location = New Point(150, 80)
        }
        AddHandler menuConfig.CloseMenu, AddressOf CloseMenuConfigue
        Controls.Add(menuConfig)
        menuConfig.BringToFront()
        PanelPizzaPanier.Enabled = False
    End Sub

    Private Sub CloseMenuConfigue()
        ' Ferme le menu de modification
        Controls.Remove(menuConfig)
        CreateListPizza()
        PanelPizzaPanier.Enabled = True
    End Sub

    Public Sub SetButtonValide()
        ' Permet de désactiver ou activé le bouton de validation selon le nombre d'item dans le panier
        If pizzasInPannier.Count = 0 Then
            ButtonValidate.Enabled = False
        ElseIf pizzasInPannier.Count > 0 Then
            ButtonValidate.Enabled = True
        End If
    End Sub

    Private Sub ButtonValidate_Click(sender As Object, e As EventArgs) Handles ButtonValidate.Click
        Select Case state
            Case PossibleState.Idle
                'impossible
            Case PossibleState.AuMoinsUnePizza
                RaiseEvent ValiderCommande()
            Case PossibleState.ConfigurePizza
                'impossible
            Case PossibleState.ModifierPizza
                'impossible
            Case PossibleState.PanierValide
                'impossible
        End Select
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ' Soulève un évènement pour aller dans la fenêtre d'accueil
        ButtonToAccueil_Click(sender, e)
    End Sub
End Class