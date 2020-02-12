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
        Me.Panel1.Size = New System.Drawing.Size(146, 109)
        Me.Panel1.TabIndex = 0
        '
        'pizzaName
        '
        Me.pizzaName.AutoSize = True
        Me.pizzaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pizzaName.Location = New System.Drawing.Point(178, 13)
        Me.pizzaName.Name = "pizzaName"
        Me.pizzaName.Size = New System.Drawing.Size(86, 29)
        Me.pizzaName.TabIndex = 1
        Me.pizzaName.Text = "Label1"
        '
        'PizzaIngredients
        '
        Me.PizzaIngredients.AutoSize = True
        Me.PizzaIngredients.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PizzaIngredients.Location = New System.Drawing.Point(180, 58)
        Me.PizzaIngredients.Name = "PizzaIngredients"
        Me.PizzaIngredients.Size = New System.Drawing.Size(39, 13)
        Me.PizzaIngredients.TabIndex = 2
        Me.PizzaIngredients.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(509, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ajouter au panier"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pizzaPrice
        '
        Me.pizzaPrice.AutoSize = True
        Me.pizzaPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pizzaPrice.Location = New System.Drawing.Point(553, 45)
        Me.pizzaPrice.Name = "pizzaPrice"
        Me.pizzaPrice.Size = New System.Drawing.Size(77, 26)
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
        Me.Size = New System.Drawing.Size(660, 138)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pizzaName As Label
    Friend WithEvents PizzaIngredients As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pizzaPrice As Label
End Class
