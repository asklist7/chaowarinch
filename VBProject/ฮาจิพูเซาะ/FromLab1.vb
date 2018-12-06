Public Class FromLab1
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        lblYear.Text = Val(txtSalary.Text) * 12
        lbltax.Text = Val(lblYear.Text) * 0.05
        lbltotal.Text = Val(lblYear.Text) - Val(lbltax.Text)
    End Sub
End Class