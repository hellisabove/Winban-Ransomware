Public Class Form3
    Private Sub Click_Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("C:\ProgramData\Project00")
        Process.GetProcessesByName("WinBan Ransomware")(0).Kill()
        Process.GetProcessesByName("WinBan Ransomware.vshost.exe")(0).Kill()
    End Sub
End Class