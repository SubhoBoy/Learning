<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.English = New System.Windows.Forms.TextBox()
        Me.Maths = New System.Windows.Forms.TextBox()
        Me.Computer = New System.Windows.Forms.TextBox()
        Me.Command = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.TextBox()
        Me.Average = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Marks of English"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Marks of Maths"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter Marks of IT"
        '
        'English
        '
        Me.English.Location = New System.Drawing.Point(369, 73)
        Me.English.Name = "English"
        Me.English.Size = New System.Drawing.Size(150, 31)
        Me.English.TabIndex = 3
        '
        'Maths
        '
        Me.Maths.Location = New System.Drawing.Point(369, 129)
        Me.Maths.Name = "Maths"
        Me.Maths.Size = New System.Drawing.Size(150, 31)
        Me.Maths.TabIndex = 4
        '
        'Computer
        '
        Me.Computer.Location = New System.Drawing.Point(369, 191)
        Me.Computer.Name = "Computer"
        Me.Computer.Size = New System.Drawing.Size(150, 31)
        Me.Computer.TabIndex = 5
        '
        'Command
        '
        Me.Command.Location = New System.Drawing.Point(252, 294)
        Me.Command.Name = "Command"
        Me.Command.Size = New System.Drawing.Size(112, 34)
        Me.Command.TabIndex = 6
        Me.Command.Text = "Calculate"
        Me.Command.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(121, 379)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Marks"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(429, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Average Marks"
        '
        'Total
        '
        Me.Total.Location = New System.Drawing.Point(229, 376)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(105, 31)
        Me.Total.TabIndex = 9
        '
        'Average
        '
        Me.Average.Location = New System.Drawing.Point(565, 373)
        Me.Average.Name = "Average"
        Me.Average.Size = New System.Drawing.Size(110, 31)
        Me.Average.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(485, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Marks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Average)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Command)
        Me.Controls.Add(Me.Computer)
        Me.Controls.Add(Me.Maths)
        Me.Controls.Add(Me.English)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Marks"
        Me.Text = "Marks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents English As TextBox
    Friend WithEvents Maths As TextBox
    Friend WithEvents Computer As TextBox
    Friend WithEvents Command As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Total As TextBox
    Friend WithEvents Average As TextBox
    Friend WithEvents Button1 As Button
End Class
