Imports Microsoft.VisualBasic

Public Class Pizza

    Public id, taille As Integer
    Public name As String
    Public ingredients, ingredientsAccepted, supplements As List(Of String)
    Public prix, prixTotal As Single

    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal taille As Integer, ByVal ingredients As String, ByVal prix As Single)
        Me.id = id
        Me.name = name
        Me.taille = taille
        Me.prix = prix
        Me.prixTotal = prix

        Me.ingredients = New List(Of String)
        Me.supplements = New List(Of String)
        Me.ingredientsAccepted = New List(Of String)

        Dim ingArray = Split(ingredients, ",")
        For i As Integer = 0 To ingArray.Length - 1
            Me.ingredients.Add(ingArray(i))
            Me.ingredientsAccepted.Add(ingArray(i))
        Next

    End Sub


    Public Sub New(p As Pizza)
        Me.id = p.id
        Me.name = p.name
        Me.taille = p.taille
        Me.prix = p.prix
        Me.prixTotal = p.prixTotal

        Me.ingredients = New List(Of String)
        Me.supplements = New List(Of String)
        Me.ingredientsAccepted = New List(Of String)

        Me.ingredients = p.ingredients
        Me.supplements = p.supplements
        Me.ingredientsAccepted = p.ingredientsAccepted
    End Sub


End Class