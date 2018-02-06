Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filepath As String
        OpenFileDialog1.ShowDialog()

        filepath = OpenFileDialog1.FileName

        MsgBox("Dateiname: " & filepath)

    End Sub
End Class
