Public Class SplashScreen
    Dim progress As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim newProgress = progress + 1
        If (newProgress <= 100) Then
            lbl_loading.Text = newProgress & " %"

            progress = newProgress
        Else
            Timer1.Stop()
            FormMenuUtama.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

End Class