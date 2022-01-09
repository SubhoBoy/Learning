<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Maths
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Num1Box = New System.Windows.Forms.TextBox()
        Me.Num2Box = New System.Windows.Forms.TextBox()
        Me.ResultBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.MinusButton = New System.Windows.Forms.Button()
        Me.MultButton = New System.Windows.Forms.Button()
        Me.DivButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(207, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mathematical Calculations"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter First Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter Second Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Result"
        '
        'Num1Box
        '
        Me.Num1Box.Location = New System.Drawing.Point(382, 134)
        Me.Num1Box.Name = "Num1Box"
        Me.Num1Box.Size = New System.Drawing.Size(150, 31)
        Me.Num1Box.TabIndex = 4
        '
        'Num2Box
        '
        Me.Num2Box.Location = New System.Drawing.Point(382, 209)
        Me.Num2Box.Name = "Num2Box"
        Me.Num2Box.Size = New System.Drawing.Size(150, 31)
        Me.Num2Box.TabIndex = 5
        '
        'ResultBox
        '
        Me.ResultBox.Enabled = False
        Me.ResultBox.Location = New System.Drawing.Point(382, 283)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.Size = New System.Drawing.Size(150, 31)
        Me.ResultBox.TabIndex = 6
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(240, 375)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(112, 34)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(404, 375)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(112, 34)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(618, 150)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(129, 34)
        Me.AddButton.TabIndex = 9
        Me.AddButton.Text = "Addition"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'MinusButton
        '
        Me.MinusButton.Location = New System.Drawing.Point(618, 190)
        Me.MinusButton.Name = "MinusButton"
        Me.MinusButton.Size = New System.Drawing.Size(129, 34)
        Me.MinusButton.TabIndex = 10
        Me.MinusButton.Text = "Subtraction"
        Me.MinusButton.UseVisualStyleBackColor = True
        '
        'MultButton
        '
        Me.MultButton.Location = New System.Drawing.Point(618, 230)
        Me.MultButton.Name = "MultButton"
        Me.MultButton.Size = New System.Drawing.Size(129, 34)
        Me.MultButton.TabIndex = 11
        Me.MultButton.Text = "Multiplication"
        Me.MultButton.UseVisualStyleBackColor = True
        '
        'DivButton
        '
        Me.DivButton.Location = New System.Drawing.Point(618, 270)
        Me.DivButton.Name = "DivButton"
        Me.DivButton.Size = New System.Drawing.Size(129, 34)
        Me.DivButton.TabIndex = 12
        Me.DivButton.Text = "Division"
        Me.DivButton.UseVisualStyleBackColor = True
        '
        'Maths
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DivButton)
        Me.Controls.Add(Me.MultButton)
        Me.Controls.Add(Me.MinusButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.Num2Box)
        Me.Controls.Add(Me.Num1Box)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Maths"
        Me.Text = "Basic Maths"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Num1Box As TextBox
    Friend WithEvents Num2Box As TextBox
    Friend WithEvents ResultBox As TextBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents MinusButton As Button
    Friend WithEvents MultButton As Button
    Friend WithEvents DivButton As Button
End Class
