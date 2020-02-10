Imports projet_pizza.Pizza


Public Class Form1




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("toto")

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\costedo\Documents\classeurPizza.csv")

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
                Catch ex As Exception

                End Try
            End While





        End Using
    End Sub
End Class
