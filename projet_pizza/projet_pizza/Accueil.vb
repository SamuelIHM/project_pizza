Imports projet_pizza.Pizza

Public Class Form1

    Public Event PanierWindow()

    Private menuConfig As MenuConfigurer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Pizza()
        ShowChoices()

    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        SetNbArticles()
    End Sub

    Private Sub SetNbArticles()
        LabelCountArticle.Text = pizzasInPannier.Count.ToString
    End Sub

    Private Sub Load_Pizza()

        Using MyReader As New FileIO.TextFieldParser("./classeurPizza.csv")

            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(";")

            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields
                    currentRow.GetValue(0)
                    Dim p = New Pizza(
                        Integer.Parse(currentRow.GetValue(0)),
                        currentRow.GetValue(1),
                        26,
                        currentRow.GetValue(3),
                        Single.Parse(currentRow.GetValue(4)),
                        currentRow.GetValue(5))
                    pizzas.Add(p)
                Catch ex As Exception

                End Try
            End While

        End Using

    End Sub

    Private Sub ShowChoices()
        For index = 0 To pizzas.Count - 1
            Dim zone As pizzaChoice
            zone = New pizzaChoice With {
                .Location = New Point(10, index * 150)
            }
            zone.setPizza(pizzas(index))
            AddHandler zone.pizzaAdded, AddressOf AjouterPizzaButtonClicked
            PanelPizza.Controls.Add(zone)
        Next
    End Sub

    Private Sub AjouterPizzaButtonClicked(pizza As Pizza)
        Select Case state
            Case PossibleState.Idle
                MenuConfigOpened(pizza)
                state = PossibleState.ConfigurePizza
            Case PossibleState.AuMoinsUnePizza
                MenuConfigOpened(pizza)
                state = PossibleState.ConfigurePizza
            Case PossibleState.ConfigurePizza
                'impossible
            Case PossibleState.ModifierPizza
                'impossible
            Case PossibleState.PanierValide
                'impossible
        End Select
    End Sub

    Private Sub MenuConfigOpened(pizza As Pizza)
        menuConfig = New MenuConfigurer(pizza) With {
            .Location = New Point(150, 80)
        }
        AddHandler menuConfig.CloseMenu, AddressOf MenuConfigClose
        Controls.Add(menuConfig)
        menuConfig.BringToFront()
        PanelPizza.Enabled = False
    End Sub

    Private Sub MenuConfigClose()
        Controls.Remove(menuConfig)
        Panier.SetButtonValide()
        PanelPizza.Enabled = True
        SetNbArticles()
    End Sub

    Private Sub ButtonToPanier_Click(sender As Object, e As EventArgs) Handles ButtonToPanier.Click
        RaiseEvent PanierWindow()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ButtonToPanier_Click(sender, e)
    End Sub
End Class
