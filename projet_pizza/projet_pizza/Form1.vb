Imports projet_pizza.Pizza

Public Class Form1

    Dim pizzas As New List(Of Pizza)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("toto")
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
                    p.Print()
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
            zone.Location = New Point(10, index * 130)
            zone.setPizza(pizzas(index))
            AddHandler zone.pizzaAdded, AddressOf ajouterPizzaButtonClicked
            PanelPizza.Controls.Add(zone)
        Next
    End Sub

    Private Sub ajouterPizzaButtonClicked(pizza As Pizza)
        Console.WriteLine(pizza.name)
    End Sub

End Class
