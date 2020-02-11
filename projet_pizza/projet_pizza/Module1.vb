Module Module1
    Public WithEvents Accueil As New Form1
    Public WithEvents Panier As New Form1

    Public state As PossibleState

    Public pizzas As New List(Of Pizza)
    Public pizzasSelected As New List(Of Pizza)

    Enum PossibleState
        Idle
        ConfigurePizza
        AuMoinsUnePizza
        ModifierPizza
        PanierValide
    End Enum

    Public Sub Main()
        state = PossibleState.Idle
        Accueil.Show()
        Panier.Hide()
    End Sub

End Module
