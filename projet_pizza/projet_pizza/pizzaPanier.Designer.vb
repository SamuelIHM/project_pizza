<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pizzaPanier
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
        Me.PanelImg = New System.Windows.Forms.Panel()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.ButtonModifier = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.LabelMinus = New System.Windows.Forms.Label()
        Me.LabelPlus = New System.Windows.Forms.Label()
        Me.LabelPrix = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PanelImg
        '
        Me.PanelImg.Location = New System.Drawing.Point(4, 4)
        Me.PanelImg.Name = "PanelImg"
        Me.PanelImg.Size = New System.Drawing.Size(158, 90)
        Me.PanelImg.TabIndex = 0
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(169, 7)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(95, 31)
        Me.LabelName.TabIndex = 1
        Me.LabelName.Text = "Label1"
        '
        'ButtonModifier
        '
        Me.ButtonModifier.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonModifier.Location = New System.Drawing.Point(598, 17)
        Me.ButtonModifier.Name = "ButtonModifier"
        Me.ButtonModifier.Size = New System.Drawing.Size(64, 23)
        Me.ButtonModifier.TabIndex = 2
        Me.ButtonModifier.Text = "Modifier"
        Me.ButtonModifier.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonDelete.Location = New System.Drawing.Point(598, 46)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(64, 23)
        Me.ButtonDelete.TabIndex = 3
        Me.ButtonDelete.Text = "Supprimer"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'LabelMinus
        '
        Me.LabelMinus.AutoSize = True
        Me.LabelMinus.ForeColor = System.Drawing.Color.Red
        Me.LabelMinus.Location = New System.Drawing.Point(176, 45)
        Me.LabelMinus.Name = "LabelMinus"
        Me.LabelMinus.Size = New System.Drawing.Size(39, 13)
        Me.LabelMinus.TabIndex = 4
        Me.LabelMinus.Text = "Label1"
        '
        'LabelPlus
        '
        Me.LabelPlus.AutoSize = True
        Me.LabelPlus.ForeColor = System.Drawing.Color.Green
        Me.LabelPlus.Location = New System.Drawing.Point(176, 65)
        Me.LabelPlus.Name = "LabelPlus"
        Me.LabelPlus.Size = New System.Drawing.Size(39, 13)
        Me.LabelPlus.TabIndex = 5
        Me.LabelPlus.Text = "Label2"
        '
        'LabelPrix
        '
        Me.LabelPrix.AutoSize = True
        Me.LabelPrix.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrix.Location = New System.Drawing.Point(512, 33)
        Me.LabelPrix.Name = "LabelPrix"
        Me.LabelPrix.Size = New System.Drawing.Size(71, 25)
        Me.LabelPrix.TabIndex = 6
        Me.LabelPrix.Text = "Label1"
        '
        'pizzaPanier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.LabelPrix)
        Me.Controls.Add(Me.LabelPlus)
        Me.Controls.Add(Me.LabelMinus)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonModifier)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.PanelImg)
        Me.Name = "pizzaPanier"
        Me.Size = New System.Drawing.Size(683, 97)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelImg As Panel
    Friend WithEvents LabelName As Label
    Friend WithEvents ButtonModifier As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents LabelMinus As Label
    Friend WithEvents LabelPlus As Label
    Friend WithEvents LabelPrix As Label
End Class
