Public Class Fromlab2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gluta, computer, total, comGluta, comComp, totalComis As Integer

        gluta = txtgluta.Text
        computer = txtComp.Text

        total = gluta + computer
        lbltotal1.Text = total
        comGluta = gluta * 0.05
        lblcomGlu.Text = comGluta
        comComp = computer * 0.1
        lblComComp.Text = comComp
        totalComis = comComp + comGluta
        lblComTotal.Text = totalComis
    End Sub
End Class