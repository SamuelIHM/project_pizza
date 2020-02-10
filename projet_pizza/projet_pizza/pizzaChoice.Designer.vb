<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pizzaChoice
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pizzaName = New System.Windows.Forms.Label()
        Me.PizzaIngredients = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pizzaPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(113, 94)
        Me.Panel1.TabIndex = 0
        '
        'pizzaName
        '
        Me.pizzaName.AutoSize = True
        Me.pizzaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pizzaName.Location = New System.Drawing.Point(144, 13)
        Me.pizzaName.Name = "pizzaName"
        Me.pizzaName.Size = New System.Drawing.Size(71, 25)
        Me.pizzaName.TabIndex = 1
        Me.pizzaName.Text = "Label1"
        '
        'PizzaIngredients
        '
        Me.PizzaIngredients.AutoSize = True
        Me.PizzaIngredients.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PizzaIngredients.Location = New System.Drawing.Point(146, 53)
        Me.PizzaIngredients.Name = "PizzaIngredients"
        Me.PizzaIngredients.Size = New System.Drawing.Size(39, 13)
        Me.PizzaIngredients.TabIndex = 2
        Me.PizzaIngredients.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(392, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ajouter au panier"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pizzaPrice
        '
        Me.pizzaPrice.AutoSize = True
        Me.pizzaPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pizzaPrice.Location = New System.Drawing.Point(389, 25)
        Me.pizzaPrice.Name = "pizzaPrice"
        Me.pizzaPrice.Size = New System.Drawing.Size(57, 20)
        Me.pizzaPrice.TabIndex = 4
        Me.pizzaPrice.Text = "Label1"
        '
        'pizzaChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pizzaPrice)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PizzaIngredients)
        Me.Controls.Add(Me.pizzaName)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "pizzaChoice"
        Me.Size = New System.Drawing.Size(557, 122)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pizzaName As Label
    Friend WithEvents PizzaIngredients As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pizzaPrice As Label
End Class
