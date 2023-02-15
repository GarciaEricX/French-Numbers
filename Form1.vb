Public Class frmNumbers
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmNumber1_Click(sender As Object, e As EventArgs) Handles frmNumber1.Click
        lblFrench.Text = "Un"
        lblFrench.Visible = True
    End Sub

    Private Sub frmNumber2_Click(sender As Object, e As EventArgs) Handles frmNumber2.Click
        lblFrench.Text = "Duex"
        lblFrench.Visible = True
    End Sub

    Private Sub frmNumber3_Click(sender As Object, e As EventArgs) Handles frmNumber3.Click
        lblFrench.Text = "Trois"
        lblFrench.Visible = True
    End Sub

    Private Sub frmNumber4_Click(sender As Object, e As EventArgs) Handles frmNumber4.Click
        lblFrench.Text = "Quatre"
        lblFrench.Visible = True
    End Sub

    Private Sub frmNumber5_Click(sender As Object, e As EventArgs) Handles frmNumber5.Click
        lblFrench.Text = "Cinq"
        lblFrench.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
