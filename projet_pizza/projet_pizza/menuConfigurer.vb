Public Class menuConfigurer

    Private supplements As New List(Of String)({"Crème fraiche", "Viande hachée", "Olives", "Pommes de terre", "Poivron", "Ananas"})
    Private prix As New List(Of Single)({0.5, 1.0, 0.5, 0.5, 0.5, 0.5})

    Private oldPizza, newPizza As Pizza

    Public Event CloseMenu()
    Public Event Valider()

    Private Sub menuConfigurer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New(p As Pizza)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        oldPizza = p
        newPizza = New Pizza(p)

        LabelName.Text = p.name
        LabelPrice.Text = p.prix.ToString + " €"

        ' On voit quelle est la taille de la pizza
        Select Case p.taille
            Case 26
                RadioButton1.Checked = True
            Case 32
                RadioButton2.Checked = True
            Case 38
                RadioButton3.Checked = True
            Case Else
                RadioButton1.Checked = True
        End Select

        ' On fait la checkbox list des ingrédients déjà présents
        For Each ingredient As String In p.ingredients
            CheckedListBox1.Items.Add(ingredient, p.ingredientsAccepted.Contains(ingredient))
        Next

        ' On check les box des supplements
        For index = 0 To CheckedListBox2.Items.Count - 1
            If p.supplements.Contains(CheckedListBox2.Items(index).ToString) Then
                CheckedListBox2.SetItemCheckState(index, CheckState.Checked)
            Else
                CheckedListBox2.SetItemCheckState(index, CheckState.Unchecked)
            End If
        Next
    End Sub

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Private Sub Ingredient_Changed(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged, CheckedListBox1.SelectedValueChanged
        Select Case state
            Case PossibleState.Idle
                'impossible
            Case PossibleState.AuMoinsUnePizza
                'impossible
            Case PossibleState.ConfigurePizza
                changeIngredientAccepted()
                state = PossibleState.ConfigurePizza
            Case PossibleState.ModifierPizza
                changeIngredientAccepted()
                state = PossibleState.ModifierPizza
            Case PossibleState.PanierValide
                'impossible
        End Select
    End Sub

    Private Sub Supplement_Changed(sender As Object, e As EventArgs) Handles CheckedListBox2.SelectedIndexChanged, CheckedListBox2.SelectedValueChanged
        Select Case state
            Case PossibleState.Idle
                'impossible
            Case PossibleState.AuMoinsUnePizza
                'impossible
            Case PossibleState.ConfigurePizza
                changeSupplement()
                state = PossibleState.ConfigurePizza
            Case PossibleState.ModifierPizza
                changeSupplement()
                state = PossibleState.ModifierPizza
            Case PossibleState.PanierValide
                'impossible
        End Select
    End Sub

    Private Sub changeIngredientAccepted()
        Dim list As List(Of String)
        list = New List(Of String)
        For Each ingredient In CheckedListBox1.CheckedItems
            list.Add(ingredient.ToString)
        Next
        newPizza.ingredientsAccepted = list
    End Sub
    Private Sub changeSupplement()
        Dim list As List(Of String)
        list = New List(Of String)
        For Each ingredient In CheckedListBox2.CheckedItems
            list.Add(ingredient.ToString)
        Next
        newPizza.supplements = list
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        tailleRadioButtonChanged(26)
    End Sub


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        tailleRadioButtonChanged(32)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        tailleRadioButtonChanged(38)
    End Sub

    Private Sub tailleRadioButtonChanged(taille As Single)
        Select Case state
            Case PossibleState.Idle
                'impossible
            Case PossibleState.AuMoinsUnePizza
                'impossible
            Case PossibleState.ConfigurePizza
                newPizza.taille = taille
                state = PossibleState.ConfigurePizza
            Case PossibleState.ModifierPizza
                newPizza.taille = taille
                state = PossibleState.ModifierPizza
            Case PossibleState.PanierValide
                'impossible
        End Select
    End Sub

    Private Sub ButtonValidate_Click(sender As Object, e As EventArgs) Handles ButtonValidate.Click
        Select Case state
            Case PossibleState.Idle
                'impossible
            Case PossibleState.AuMoinsUnePizza
                'impossible
            Case PossibleState.ConfigurePizza
                pizzasInPannier.Add(newPizza)
                state = PossibleState.AuMoinsUnePizza
                RaiseEvent CloseMenu()
            Case PossibleState.ModifierPizza
                pizzasInPannier.Remove(oldPizza)
                pizzasInPannier.Add(newPizza)
                state = PossibleState.AuMoinsUnePizza
                RaiseEvent CloseMenu()
            Case PossibleState.PanierValide
                'impossible
        End Select
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Select Case state
            Case PossibleState.Idle
                'impossible
            Case PossibleState.AuMoinsUnePizza
                'impossible
            Case PossibleState.ConfigurePizza
                If pizzasInPannier.Count = 0 Then
                    state = PossibleState.Idle
                ElseIf pizzasInPannier.Count > 0 Then
                    state = PossibleState.AuMoinsUnePizza
                End If
                RaiseEvent CloseMenu()
            Case PossibleState.ModifierPizza
                state = PossibleState.AuMoinsUnePizza
                RaiseEvent CloseMenu()
            Case PossibleState.PanierValide
                'impossible
        End Select
    End Sub

End Class
