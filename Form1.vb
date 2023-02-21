Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnNumber1_Click(sender As Object, e As EventArgs) Handles btnNumber1.Click
        lblFrench.Text = "Un"
        lblFrench.Visible = True
    End Sub

    Private Sub btnNumber2_Click(sender As Object, e As EventArgs) Handles btnNumber2.Click
        lblFrench.Text = "Duex"
        lblFrench.Visible = True
    End Sub

    Private Sub btnNumber3_Click(sender As Object, e As EventArgs) Handles btnNumber3.Click
        lblFrench.Text = "Trois"
        lblFrench.Visible = True
    End Sub

    Private Sub btnNumber4_Click(sender As Object, e As EventArgs) Handles btnNumber4.Click
        lblFrench.Text = "Quatre"
        lblFrench.Visible = True
    End Sub

    Private Sub btnNumber5_Click(sender As Object, e As EventArgs) Handles btnNumber5.Click
        lblFrench.Text = "Cinq"
        lblFrench.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
