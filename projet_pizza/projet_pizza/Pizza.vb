Imports Microsoft.VisualBasic

Public Class Pizza

    Dim id, taille As Integer
    Dim name As String
    Dim ingredients, supplements As List(Of String)
    Dim prix As Single

    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal taille As Integer, ByVal ingredients As String, ByVal prix As Single)
        Me.id = id
        Me.name = name
        Me.taille = taille
        Me.prix = prix

        Me.ingredients = New List(Of String)
        Me.supplements = New List(Of String)

        Dim ingArray = Split(ingredients, ",")
        For i As Integer = 0 To ingArray.Length - 1
            Me.ingredients.Add(ingArray(i))
        Next

    End Sub

    Public Sub Print()
        Console.WriteLine(Me.name)
        Console.WriteLine(Me.ingredients(0))

    End Sub


End Class
