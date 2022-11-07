Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox2.Text = (TextBox1.Text / 2.54).ToString("N2")
        TextBox3.Text = (TextBox1.Text * 0.01).ToString("N2")

    End Sub


End Class
