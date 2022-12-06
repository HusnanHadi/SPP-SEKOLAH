Public Class Form_login
    Sub terbuka()
        FormMenuUtama.login.Enabled = False
        FormMenuUtama.logout.Enabled = True
        FormMenuUtama.masterData.Enabled = True
        FormMenuUtama.transaksi.Enabled = True
        FormMenuUtama.laporan.Enabled = True
    End Sub
    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If tb_username.Text = "" Or tb_password.Text = "" Then
            MsgBox("Semua kolom tidak boleh kosong", vbCritical, "Warning")
            tb_username.Focus()
        Else
            If tb_username.Text = "admin" And tb_password.Text = "admin" Then
                Me.Close()
                Call terbuka()
            Else
                MsgBox("Username atau Password anda salah", vbCritical, "Warning")
                tb_username.Clear()
                tb_password.Clear()
                tb_username.Focus()
            End If
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_username.MaxLength = 10
        tb_password.PasswordChar = "*"
        tb_username.Clear()
        tb_password.Clear()
        tb_username.Focus()
    End Sub

    Private Sub Cb_tmplPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cb_tmplPassword.CheckedChanged
        If cb_tmplPassword.Checked = True Then
            tb_password.PasswordChar = ""
        Else
            tb_password.PasswordChar = "*"
        End If
    End Sub

    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub tb_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_password.KeyPress
        If e.KeyChar = Chr(13) Then
            btn_login.PerformClick()
        End If
    End Sub
End Class