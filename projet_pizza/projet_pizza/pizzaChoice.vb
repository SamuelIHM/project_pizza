Public Class pizzaChoice

    Private pizza As Pizza

    Public Sub setPizza(piz As Pizza)
        pizza = piz
        pizzaPrice.Text = pizza.prix.ToString + " €"
        pizzaName.Text = pizza.name
        PizzaIngredients.Text = ""
        For Each ingredient As String In pizza.ingredients
            PizzaIngredients.Text += ingredient + " "
        Next
    End Sub

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
