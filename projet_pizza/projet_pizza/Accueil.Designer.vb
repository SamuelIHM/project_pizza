<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelPizza = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.ButtonToPanier = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LabelCountArticle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PanelPizza
        '
        Me.PanelPizza.AutoScroll = True
        Me.PanelPizza.Location = New System.Drawing.Point(53, 108)
        Me.PanelPizza.Name = "PanelPizza"
        Me.PanelPizza.Size = New System.Drawing.Size(700, 552)
        Me.PanelPizza.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(290, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 39)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pizza pour tous"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1, Me.ButtonToPanier})
        Me.ShapeContainer1.Size = New System.Drawing.Size(810, 689)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'ButtonToPanier
        '
        Me.ButtonToPanier.BackColor = System.Drawing.Color.White
        Me.ButtonToPanier.FillColor = System.Drawing.Color.White
        Me.ButtonToPanier.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ButtonToPanier.Location = New System.Drawing.Point(718, 13)
        Me.ButtonToPanier.Name = "ButtonToPanier"
        Me.ButtonToPanier.Size = New System.Drawing.Size(70, 70)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(735, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Panier"
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.Color.Red
        Me.OvalShape1.BorderColor = System.Drawing.SystemColors.Control
        Me.OvalShape1.FillColor = System.Drawing.Color.Red
        Me.OvalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape1.Location = New System.Drawing.Point(719, 10)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(24, 24)
        '
        'LabelCountArticle
        '
        Me.LabelCountArticle.AutoSize = True
        Me.LabelCountArticle.BackColor = System.Drawing.Color.Red
        Me.LabelCountArticle.Location = New System.Drawing.Point(725, 15)
        Me.LabelCountArticle.Name = "LabelCountArticle"
        Me.LabelCountArticle.Size = New System.Drawing.Size(13, 13)
        Me.LabelCountArticle.TabIndex = 5
        Me.LabelCountArticle.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(810, 689)
        Me.Controls.Add(Me.LabelCountArticle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelPizza)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelPizza As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents ButtonToPanier As PowerPacks.OvalShape
    Friend WithEvents Label1 As Label
    Friend WithEvents OvalShape1 As PowerPacks.OvalShape
    Friend WithEvents LabelCountArticle As Label
End Class
