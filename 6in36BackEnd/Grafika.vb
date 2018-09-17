Module Grafika

    Sub DrawGrid(g As Graphics, origin As Point, rows As Integer, columns As Integer, cellSize As Size)
        Dim mainpen As New Pen(Color.Black, 3)
        Dim gridWidth As Integer = columns * cellSize.Width
        Dim gridHeight As Integer = rows * cellSize.Height
        Dim left As Integer = origin.X - (gridWidth \ 2)
        Dim right As Integer = origin.X + (gridWidth \ 2)
        Dim top As Integer = origin.Y - (gridHeight \ 2)
        Dim bottom As Integer = origin.Y + (gridHeight \ 2)

        For y As Integer = top To bottom + 1 Step cellSize.Height
            Dim pt1 As New Point(left, y)
            Dim pt2 As New Point(right, y)
            g.DrawLine(mainpen, pt1, pt2)
        Next
        For x As Integer = left To right + 1 Step cellSize.Width
            Dim pt1 As New Point(x, top)
            Dim pt2 As New Point(x, bottom)
            g.DrawLine(mainpen, pt1, pt2)
        Next
        '       g.DrawEllipse(Pens.Red, New Rectangle(origin.X - 5, origin.Y - 5, 10, 10))
    End Sub

End Module
