Public Class Form1

    Dim AllTix As New List(Of Tix)
    Dim result As Integer()
    Dim TixImage As New Bitmap(300, 300)
    Dim TixImageMaker As Graphics = Graphics.FromImage(TixImage)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '       Dim i As New Tix
        '       i.PrepareTix()
        '       Button1.Text = i.MakeString
        '       Dim i As New List(Of Tix)
        '       For a = 1 To 10
        '       i.Add(New Tix)
        '       Next
        '       For Each a As Tix In i
        '       a.PrepareTix()
        '       TextBox1.AppendText(a.MakeString & vbCrLf)
        '       Next
        AllTix.Clear()
        Dim trd As New Threading.Thread(AddressOf TestFunctionality)
        trd.IsBackground = True
        trd.Start()
    End Sub

    Private Sub TestFunctionality()
        TextBox1.AppendText("Creating 100000 tickets..." & vbCrLf)
        AddTix(100000)
        TextBox1.AppendText("Checking tickets with number 1..." & vbCrLf)
        CheckTickets(AllTix, 1)
        TextBox1.AppendText("Checking tickets with number 2..." & vbCrLf)
        CheckTickets(AllTix, 2)
        TextBox1.AppendText("Checking tickets with number 3..." & vbCrLf)
        CheckTickets(AllTix, 3)
        TextBox1.AppendText("Checking tickets with number 4..." & vbCrLf)
        CheckTickets(AllTix, 4)
        TextBox1.AppendText("Checking tickets with number 5..." & vbCrLf)
        CheckTickets(AllTix, 5)
        TextBox1.AppendText("Checking tickets with number 6..." & vbCrLf)
        CheckTickets(AllTix, 6)
        TextBox1.AppendText("Collecting results..." & vbCrLf)
        Dim result As Integer()
        result = GetTixHitStats(AllTix)
        TextBox1.AppendText("Done." & vbCrLf)
        TextBox1.AppendText("6 hits - " & result(6) & vbCrLf)
        TextBox1.AppendText("5 hits - " & result(5) & vbCrLf)
        TextBox1.AppendText("4 hits - " & result(4) & vbCrLf)
        TextBox1.AppendText("3 hits - " & result(3) & vbCrLf)
        TextBox1.AppendText("2 hits - " & result(2) & vbCrLf)
        TextBox1.AppendText("1 hits - " & result(1) & vbCrLf)
        TextBox1.AppendText("0 hits - " & result(0) & vbCrLf)
    End Sub

    Private Sub AddTix(e As Integer)
        For i = 1 To e
            AllTix.Add(New Tix)
            AllTix.Last.PrepareTix()
        Next
    End Sub

    Private Sub CheckTickets(e As List(Of Tix), number As Integer)
        For Each ticket In e
            Dim found As String
            found = Array.IndexOf(ticket.Numbers, number)
            If found >= 0 Then ticket.Hits += 1
        Next
    End Sub

    Private Function GetTixHitStats(e As List(Of Tix))
        Dim out As Integer() = {0, 0, 0, 0, 0, 0, 0}
        For Each ticket In e
            out(ticket.Hits) += 1
        Next
        Return out
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Dim center As Point
        center.X = 150
        center.Y = 150
        Dim cellsize As Size
        cellsize.Height = 40
        cellsize.Width = 40
        Grafika.DrawGrid(TixImageMaker, center, 6, 6, cellsize)
        PictureBox1.Image = TixImage
    End Sub

    Private Sub AddTixBtn_Click(sender As Object, e As EventArgs) Handles AddTixBtn.Click
        AddTix(AddTixTxt.Text)
        TixInPlayLbl.Text = AllTix.Count
    End Sub

    Private Sub CheckNumberBtn_Click(sender As Object, e As EventArgs) Handles CheckNumberBtn.Click
        TextBox1.AppendText("Checking tickets with number..." & vbCrLf)
        CheckTickets(AllTix, CheckNumberTxt.Text)
        TextBox1.AppendText("Collecting results..." & vbCrLf)

        result = GetTixHitStats(AllTix)
        TextBox1.AppendText("Done." & vbCrLf)
        TextBox1.AppendText("6 hits - " & result(6) & vbCrLf)
        TextBox1.AppendText("5 hits - " & result(5) & vbCrLf)
        TextBox1.AppendText("4 hits - " & result(4) & vbCrLf)
        TextBox1.AppendText("3 hits - " & result(3) & vbCrLf)
        TextBox1.AppendText("2 hits - " & result(2) & vbCrLf)
        TextBox1.AppendText("1 hits - " & result(1) & vbCrLf)
        TextBox1.AppendText("0 hits - " & result(0) & vbCrLf)
    End Sub

    Private Sub ShowScreen_Click(sender As Object, e As EventArgs) Handles ShowScreen.Click
        Screen.Show()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Screen.UpdateStuff(result, CheckNumberTxt.Text)
    End Sub
End Class
