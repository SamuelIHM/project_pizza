Public Class pizzaChoice

    Public Event pizzaAdded(pizza As Pizza)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RaiseEvent pizzaAdded(pizza)
    End Sub
End Class
