Public Class Test1
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        'ค่าจ้าง = ชม.การทำงาน * อัตราค่าจ้างต่อ ชม.'
        lbltotall.Text = Val(txtHour.Text) * Val(txtPerday.Text)
        lbltax.Text = Val(lbltotall.Text) * 0.03
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCal2_Click(sender As Object, e As EventArgs) Handles btnCal2.Click
        Dim hours As Integer
        Dim payrate, total, tax As Double
        hours = Val(txtHour.Text)
        payrate = Val(txtPerday.Text)

        total = hours * payrate
        tax = total * 0.03

        lbltotall.Text = total
        lbltax.Text = tax
    End Sub
End Class
