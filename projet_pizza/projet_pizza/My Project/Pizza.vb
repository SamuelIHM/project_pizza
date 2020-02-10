Imports Microsoft.VisualBasic

Public Class Pizza

    Dim id, taille As int
    Dim name As String
    Dim ingredients, supplements As List(Of String)
    Dim prix As float

    Public Sub New(ByVal id As int, ByVal name As int, ByVal taille As int, ByVal ingredients As String, ByVal prix As float)
        Me.id = id
        Me.name = name
        Me.taille = taille
        Me.prix = prix

        Me.ingredients = New List(Of String)
        Me.supplements = New List(Of String)

        Dim ingArray = Split(ingredients, ",")
        For i As Integer = 0 To ingArray.length - 1
            Me.ingredients.add(ingArray(i))
        Next

    End Sub


End Class
