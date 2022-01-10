Public Class Marks
    Private Sub Command_Click(sender As Object, e As EventArgs) Handles Command.Click
        Total.Text = Val(English.Text) + Val(Maths.Text) + Val(Computer.Text)
        Average.Text = Val(Total.Text) / 3
    End Sub
End Class