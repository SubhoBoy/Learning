Public Class Maths
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Num1Box.Text = ""
        Num2Box.Text = ""
        ResultBox.Text = ""
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        ResultBox.Text = Val(Num1Box.Text) + Val(Num2Box.Text)
    End Sub

    Private Sub MinusButton_Click(sender As Object, e As EventArgs) Handles MinusButton.Click
        ResultBox.Text = Val(Num1Box.Text) - Val(Num2Box.Text)
    End Sub

    Private Sub MultButton_Click(sender As Object, e As EventArgs) Handles MultButton.Click
        ResultBox.Text = Val(Num1Box.Text) * Val(Num2Box.Text)
    End Sub

    Private Sub DivButton_Click(sender As Object, e As EventArgs) Handles DivButton.Click
        ResultBox.Text = Val(Num1Box.Text) / Val(Num2Box.Text)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim MainF As New Main
        MainF.Show()
        Me.Close()
    End Sub
End Class
