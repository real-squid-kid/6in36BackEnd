<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TixInPlayLbl = New System.Windows.Forms.Label()
        Me.AddTixBtn = New System.Windows.Forms.Button()
        Me.AddTixTxt = New System.Windows.Forms.TextBox()
        Me.CheckNumberBtn = New System.Windows.Forms.Button()
        Me.CheckNumberTxt = New System.Windows.Forms.TextBox()
        Me.ShowScreen = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Test functionality (delete me)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 44)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 155)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(495, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tickets in play:"
        '
        'TixInPlayLbl
        '
        Me.TixInPlayLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TixInPlayLbl.Location = New System.Drawing.Point(445, 31)
        Me.TixInPlayLbl.Name = "TixInPlayLbl"
        Me.TixInPlayLbl.Size = New System.Drawing.Size(128, 34)
        Me.TixInPlayLbl.TabIndex = 3
        Me.TixInPlayLbl.Text = "0"
        Me.TixInPlayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddTixBtn
        '
        Me.AddTixBtn.Location = New System.Drawing.Point(191, 13)
        Me.AddTixBtn.Name = "AddTixBtn"
        Me.AddTixBtn.Size = New System.Drawing.Size(90, 23)
        Me.AddTixBtn.TabIndex = 4
        Me.AddTixBtn.Text = "Add tickets"
        Me.AddTixBtn.UseVisualStyleBackColor = True
        '
        'AddTixTxt
        '
        Me.AddTixTxt.Location = New System.Drawing.Point(287, 15)
        Me.AddTixTxt.Name = "AddTixTxt"
        Me.AddTixTxt.Size = New System.Drawing.Size(100, 20)
        Me.AddTixTxt.TabIndex = 5
        Me.AddTixTxt.Text = "1000"
        '
        'CheckNumberBtn
        '
        Me.CheckNumberBtn.Location = New System.Drawing.Point(191, 42)
        Me.CheckNumberBtn.Name = "CheckNumberBtn"
        Me.CheckNumberBtn.Size = New System.Drawing.Size(90, 23)
        Me.CheckNumberBtn.TabIndex = 6
        Me.CheckNumberBtn.Text = "Check number"
        Me.CheckNumberBtn.UseVisualStyleBackColor = True
        '
        'CheckNumberTxt
        '
        Me.CheckNumberTxt.Location = New System.Drawing.Point(287, 44)
        Me.CheckNumberTxt.Name = "CheckNumberTxt"
        Me.CheckNumberTxt.Size = New System.Drawing.Size(100, 20)
        Me.CheckNumberTxt.TabIndex = 5
        Me.CheckNumberTxt.Text = "1"
        '
        'ShowScreen
        '
        Me.ShowScreen.Location = New System.Drawing.Point(191, 95)
        Me.ShowScreen.Name = "ShowScreen"
        Me.ShowScreen.Size = New System.Drawing.Size(90, 23)
        Me.ShowScreen.TabIndex = 7
        Me.ShowScreen.Text = "Show Screen"
        Me.ShowScreen.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(191, 124)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(90, 23)
        Me.UpdateBtn.TabIndex = 7
        Me.UpdateBtn.Text = "Update stuff"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(316, 137)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 449)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.ShowScreen)
        Me.Controls.Add(Me.CheckNumberBtn)
        Me.Controls.Add(Me.CheckNumberTxt)
        Me.Controls.Add(Me.AddTixTxt)
        Me.Controls.Add(Me.AddTixBtn)
        Me.Controls.Add(Me.TixInPlayLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TixInPlayLbl As Label
    Friend WithEvents AddTixBtn As Button
    Friend WithEvents AddTixTxt As TextBox
    Friend WithEvents CheckNumberBtn As Button
    Friend WithEvents CheckNumberTxt As TextBox
    Friend WithEvents ShowScreen As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
