Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '        Dim i As New Tix
        '       i.PrepareTix()
        '       Button1.Text = i.MakeString
        Dim i As New List(Of Tix)
        For a = 1 To 10
            i.Add(New Tix)
        Next
        For Each a As Tix In i
            a.PrepareTix()
            TextBox1.AppendText(a.MakeString & vbCrLf)
        Next
    End Sub
End Class
