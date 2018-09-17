Public Class Screen

    Dim ScreenHits() As Integer = {0, 0, 0, 0, 0, 0, 0}
    Dim NewNumber As Integer
    Dim GlobalTimer As Integer
    Dim IfWon As Boolean
    Private Sub Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub UpdateStuff(hits As Integer(), newnumber As Integer)
        GlobalTimer = 0
        ProgressBar1.Value = 0
        ScreenHits = hits
        Timer1.Enabled = True
        CurrentNumberLbl.Text = newnumber
        LastNumbersLbl.Text += ", " & newnumber
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GlobalTimer += 1
        PrgBackground.BackColor = Color.LightCyan
        ProgressBar1.Value = GlobalTimer
        If IfWon = False Then
            If GlobalTimer / 10 = Int(GlobalTimer / 10) Then
                Dim trd As New Threading.Thread(AddressOf ShortBeep)
                trd.IsBackground = True
                trd.Start()
                PrgBackground.BackColor = Color.Yellow
            End If
        Else
            If GlobalTimer / 2 = Int(GlobalTimer / 2) Then
                PrgBackground.BackColor = Color.Red

            Else
                PrgBackground.BackColor = Color.LightCyan
            End If
        End If
        If GlobalTimer > 25 And ScreenHits(6) > 0 Then

            If IfWon = False Then
                IfWon = True
                Dim trd As New Threading.Thread(AddressOf FastBeep)
                trd.IsBackground = True
                trd.Start()
            End If
        End If
        If GlobalTimer = 50 Then
            ProgressBar1.Value = 0
            Timer1.Enabled = False
            PrgBackground.BackColor = Color.LightCyan
            StatsLbl.Text = "6 - " & ScreenHits(6) & vbCrLf & "5 - " & ScreenHits(5) & vbCrLf & "4 - " & ScreenHits(4) & vbCrLf & "3 - " & ScreenHits(3) & vbCrLf & "2 - " & ScreenHits(2) & vbCrLf & "1 - " & ScreenHits(1)
        End If
    End Sub

    Private Sub ShortBeep()
        Console.Beep(1250, 200)
    End Sub

    Private Sub FastBeep()
        Console.Beep(2500, 2500)
    End Sub
End Class