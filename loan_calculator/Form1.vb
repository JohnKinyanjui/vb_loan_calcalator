Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim phone As String
        Dim password As String

        phone = TextBox1.Text
        password = TextBox2.Text

        If phone = "07123456" And password = "0000" Then
            Form2.Show()
        Else
            MsgBox("Credemtials are not wrong")
        End If





    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
