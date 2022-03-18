Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim first As String
        Dim second As String
        Dim amount As Integer
        Dim interest As Integer

        first = TextBox1.Text
        second = TextBox2.Text
        amount = TextBox4.Text * ((interest + 100) / 100)
        interest = TextBox4.Text

        Label9.Text = first
        Label10.Text = second
        Label12.Text = "KES " + amount.ToString()
        Label14.Text = interest.ToString() + " %"





    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class