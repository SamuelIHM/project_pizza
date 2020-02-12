Public Class PizzaChoice

    ' Permet d'afficher les choix de pizza dans la liste de l'accueil

    Public Event PizzaAdded(pizza As Pizza)

    Private pizza As Pizza

    Public Sub SetPizza(piz As Pizza)
        pizza = piz
        pizzaPrice.Text = pizza.prix.ToString + " €"
        pizzaName.Text = pizza.name
        PizzaIngredients.Text = ""
        For Each ingredient As String In pizza.ingredients
            PizzaIngredients.Text += ingredient + " "
        Next

        Dim image As Image
        image = Image.FromFile("img/" + pizza.img)
        PanelPhoto.BackgroundImage = New Bitmap(image, New Point(PanelPhoto.Width, PanelPhoto.Height))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RaiseEvent PizzaAdded(pizza)
    End Sub

End Class
