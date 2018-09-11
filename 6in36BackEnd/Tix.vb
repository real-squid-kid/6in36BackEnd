Public Class Tix

    Public Numbers(5) As Integer

    Public Sub PrepareTix()
        Dim dup As Boolean = True
        Randomize()
        Do Until dup = False
            For i = 0 To 5
                Dim a As Integer
                a = Int(Rnd() * 37) + 1
                Numbers(i) = a
            Next
            dup = HasDuplicates()
        Loop
    End Sub

    Private Function HasDuplicates() As Boolean
        For i As Integer = 0 To Numbers.Length - 1
            Dim l As Integer = Array.LastIndexOf(Numbers, Numbers(i))
            If l <> i Then Return True
        Next
        Return False
    End Function

    Public Function MakeString() As String
        Dim i As String = ""
        For Each a In Numbers
            i = i & a & ", "
        Next
        Return i
    End Function

End Class
