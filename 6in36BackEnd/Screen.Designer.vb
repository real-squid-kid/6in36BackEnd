<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PrgBackground = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.CurrentNumberLbl = New System.Windows.Forms.Label()
        Me.StatsLbl = New System.Windows.Forms.Label()
        Me.LastNumbersLbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'PrgBackground
        '
        Me.PrgBackground.BackColor = System.Drawing.Color.LightCyan
        Me.PrgBackground.Location = New System.Drawing.Point(12, 385)
        Me.PrgBackground.Name = "PrgBackground"
        Me.PrgBackground.Size = New System.Drawing.Size(660, 47)
        Me.PrgBackground.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(22, 394)
        Me.ProgressBar1.Maximum = 50
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(640, 30)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 2
        '
        'CurrentNumberLbl
        '
        Me.CurrentNumberLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CurrentNumberLbl.Font = New System.Drawing.Font("Arial", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CurrentNumberLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CurrentNumberLbl.Location = New System.Drawing.Point(519, 9)
        Me.CurrentNumberLbl.Name = "CurrentNumberLbl"
        Me.CurrentNumberLbl.Size = New System.Drawing.Size(153, 111)
        Me.CurrentNumberLbl.TabIndex = 3
        Me.CurrentNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatsLbl
        '
        Me.StatsLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatsLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.StatsLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StatsLbl.Location = New System.Drawing.Point(19, 9)
        Me.StatsLbl.Name = "StatsLbl"
        Me.StatsLbl.Size = New System.Drawing.Size(163, 138)
        Me.StatsLbl.TabIndex = 4
        Me.StatsLbl.Text = "6 - 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5 - 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4 - 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3 - 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2 - 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 - 0"
        '
        'LastNumbersLbl
        '
        Me.LastNumbersLbl.AutoEllipsis = True
        Me.LastNumbersLbl.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LastNumbersLbl.ForeColor = System.Drawing.Color.DarkOrange
        Me.LastNumbersLbl.Location = New System.Drawing.Point(50, 299)
        Me.LastNumbersLbl.Name = "LastNumbersLbl"
        Me.LastNumbersLbl.Size = New System.Drawing.Size(585, 86)
        Me.LastNumbersLbl.TabIndex = 5
        Me.LastNumbersLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Timer1
        '
        '
        'Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(684, 441)
        Me.Controls.Add(Me.LastNumbersLbl)
        Me.Controls.Add(Me.StatsLbl)
        Me.Controls.Add(Me.CurrentNumberLbl)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PrgBackground)
        Me.Name = "Screen"
        Me.Text = "Screen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrgBackground As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents CurrentNumberLbl As Label
    Friend WithEvents StatsLbl As Label
    Friend WithEvents LastNumbersLbl As Label
    Friend WithEvents Timer1 As Timer
End Class
