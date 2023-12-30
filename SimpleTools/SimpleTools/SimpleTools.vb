Public Class SimpleTools

    'Simple Tools 1.0
    'Provided for non-commercial use. Please refer to Github Repo for more information. 
    'Contact: Sherman_tan@outlook.com
    '(C) Tan Wei Qiang Sherman. 
    Private Sub btnShutdown_Click(sender As Object, e As EventArgs) Handles btnShutdown.Click
        Process.Start("shutdown", "-s -f -t 00")
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Process.Start("restart", "-r -f -t 00")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
