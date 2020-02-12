Public Class pizzaPanier

    Private pizza As Pizza
    Public Event modifierPizza(p As Pizza)
    Public Event deletePizza(p As Pizza)

    Public Sub New(piz As Pizza)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        pizza = piz
        LabelName.Text = pizza.name
        LabelPrix.Text = pizza.prixTotal.ToString + " €"


        LabelPlus.Text = ""
        LabelMinus.Text = ""

        ' On ajoute les aliments enlevés et ajoutés
        If pizza.ingredientsAccepted.Count < pizza.ingredients.Count Then
            LabelMinus.Text = "- "
        End If

        If pizza.supplements.Count > 0 Then
            LabelPlus.Text = "+ "
        End If

        For Each sup In pizza.supplements
            LabelPlus.Text += sup + "  "
        Next

        For Each ingredient In pizza.ingredients
            If Not pizza.ingredientsAccepted.Contains(ingredient) Then
                LabelMinus.Text += ingredient + "  "
            End If
        Next

        Dim image As Image
        image = Image.FromFile("img/" + pizza.img)
        PanelPhoto.BackgroundImage = New Bitmap(image, New Point(PanelPhoto.Width, PanelPhoto.Height))
    End Sub

    Private Sub PizzaPanier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonModifier_Click(sender As Object, e As EventArgs) Handles ButtonModifier.Click
        Select Case state
            Case PossibleState.Idle
                'impossible
            Case PossibleState.AuMoinsUnePizza
                RaiseEvent modifierPizza(pizza)
                state = PossibleState.ModifierPizza
            Case PossibleState.ConfigurePizza
                'impossible
            Case PossibleState.ModifierPizza
                'impossible
            Case PossibleState.PanierValide
                'impossible
        End Select

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Select Case state
            Case PossibleState.Idle
                'impossible
            Case PossibleState.AuMoinsUnePizza
                'TODO:
                If pizzasInPannier.Count = 1 Then
                    pizzasInPannier.Remove(pizza)
                    state = PossibleState.Idle
                    RaiseEvent deletePizza(pizza)
                ElseIf pizzasInPannier.Count > 1 Then
                    pizzasInPannier.Remove(pizza)
                    state = PossibleState.AuMoinsUnePizza
                    RaiseEvent deletePizza(pizza)
                End If
            Case PossibleState.ConfigurePizza
                'impossible
            Case PossibleState.ModifierPizza
                'impossible
            Case PossibleState.PanierValide
                'impossible
        End Select
    End Sub
End Class
