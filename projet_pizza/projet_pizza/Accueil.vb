Imports projet_pizza.Pizza

Public Class Form1

    'Dim pizzas As New List(Of Pizza)
    'Dim pizzasSelected As New List(Of Pizza)
    Public Event PanierWindow()

    Private menu As menuConfigurer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Pizza()
        showChoices()

    End Sub

    Private Sub Load_Pizza()

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("./classeurPizza.csv")

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
                        Single.Parse(currentRow.GetValue(4)))
                    pizzas.Add(p)
                Catch ex As Exception

                End Try
            End While

        End Using

    End Sub

    Private Sub showChoices()
        For index = 0 To pizzas.Count - 1
            Dim zone As pizzaChoice
            zone = New pizzaChoice
            zone.Location = New Point(10, index * 150)
            zone.setPizza(pizzas(index))
            AddHandler zone.pizzaAdded, AddressOf ajouterPizzaButtonClicked
            PanelPizza.Controls.Add(zone)
        Next
    End Sub

    Private Sub ajouterPizzaButtonClicked(pizza As Pizza)
        Select Case state
            Case PossibleState.Idle
                menuOpened(pizza)
                state = PossibleState.ConfigurePizza
            Case PossibleState.AuMoinsUnePizza
                menuOpened(pizza)
                state = PossibleState.ConfigurePizza
            Case PossibleState.ConfigurePizza
                'impossible
            Case PossibleState.ModifierPizza
                'impossible
            Case PossibleState.PanierValide
                'impossible
        End Select
    End Sub

    Private Sub menuOpened(pizza As Pizza)
        menu = New menuConfigurer(pizza) With {
            .Location = New Point(150, 80)
        }
        AddHandler menu.CloseMenu, AddressOf closeMenuConfigue
        Controls.Add(menu)
        menu.BringToFront()
        PanelPizza.Enabled = False
    End Sub

    Private Sub closeMenuConfigue()
        Controls.Remove(menu)
        Panier.setButtonValide()
        PanelPizza.Enabled = True
    End Sub

    Private Sub ButtonToPanier_Click(sender As Object, e As EventArgs) Handles ButtonToPanier.Click
        RaiseEvent PanierWindow()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ButtonToPanier_Click(sender, e)
    End Sub
End Class
