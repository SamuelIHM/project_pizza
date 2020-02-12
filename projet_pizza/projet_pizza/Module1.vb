Module Module1
    Public WithEvents Accueil As New Form1
    Public WithEvents Panier As New Form2
    Public WithEvents Valider As New Validation

    Public state As PossibleState

    Public pizzas As New List(Of Pizza)
    Public pizzasInPannier As New List(Of Pizza)

    Enum PossibleState
        Idle
        ConfigurePizza
        AuMoinsUnePizza
        ModifierPizza
        PanierValide
    End Enum

    Public Sub Main()
        state = PossibleState.Idle
        AddHandler Accueil.PanierWindow, AddressOf To_Panier
        AddHandler Panier.AccueilWindow, AddressOf To_Accueil
        AddHandler Panier.ValiderCommande, AddressOf To_End
        To_Accueil()
    End Sub

    ' Fonction pour aller sur la fenêtre du panier
    Private Sub To_Panier()
        Accueil.Hide()
        Panier.Show()
        Validation.Hide()
    End Sub

    Private Sub To_Accueil()
        Panier.Hide()
        Accueil.Show()
        Validation.Hide()
    End Sub
    Private Sub To_End()
        Panier.Hide()
        Accueil.Hide()
        Validation.Show()
    End Sub

End Module
