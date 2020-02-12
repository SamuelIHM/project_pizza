Public Class Form2
    Public Event AccueilWindow()
    Public Event ValiderCommande()
    Private Menu As menuConfigurer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_OnActivated(sender As Object, e As EventArgs) Handles MyBase.Activated
        createListPizza()
        setButtonValide()
    End Sub

    Private Sub ButtonToAccueil_Click(sender As Object, e As EventArgs) Handles ButtonToAccueil.Click
        RaiseEvent AccueilWindow()
    End Sub

    Private Sub createListPizza()
        Dim prix As Single
        PanelPizzaPanier.Controls.Clear()
        For index = 0 To pizzasInPannier.Count - 1
            Dim uc As pizzaPanier
            uc = New pizzaPanier(pizzasInPannier(index))
            uc.Location = New Point(10, 100 * index)
            AddHandler uc.modifierPizza, AddressOf menuOpened
            AddHandler uc.deletePizza, AddressOf pizzaDeleted
            PanelPizzaPanier.Controls.Add(uc)

            prix += pizzasInPannier(index).prix
        Next
        LabelTotalPrice.Text = prix.ToString + " €"
    End Sub

    Private Sub pizzaDeleted(p As Pizza)
        createListPizza()
        setButtonValide()
    End Sub

    Private Sub menuOpened(pizza As Pizza)
        Menu = New menuConfigurer(pizza) With {
            .Location = New Point(150, 80)
        }
        AddHandler Menu.CloseMenu, AddressOf closeMenuConfigue
        Controls.Add(Menu)
        Menu.BringToFront()
        PanelPizzaPanier.Enabled = False
    End Sub

    Private Sub closeMenuConfigue()
        Controls.Remove(Menu)
        createListPizza()
        PanelPizzaPanier.Enabled = True
    End Sub

    Public Sub setButtonValide()
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
        ButtonToAccueil_Click(sender, e)
    End Sub
End Class