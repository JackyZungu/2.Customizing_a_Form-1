Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "My first App in 2023"
        Me.BackColor = Color.BlueViolet
        Me.MaximizeBox = True
        Me.MinimizeBox = False
        Me.Size = New Size(700, 500)
        Me.Opacity = 0.85  'makes it bit transparent
        Me.CenterToParent() 'centers the execution box
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
        Me.BackColor = Color.Beige
    End Sub

    Private Sub btnJackyZungu_Click(sender As Object, e As EventArgs) Handles btnJackyZungu.Click
        MsgBox("this is jacky",, "Hi") 'this customise the box to display a message after click
    End Sub
End Class
