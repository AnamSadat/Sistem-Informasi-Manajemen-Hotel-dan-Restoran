Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim sqlx As String = "select * from user where username='" & usernameBtn.Text & "' and password='" & passwordBtn.Text & "'"
        instruksi = New MySqlCommand(sqlx, jembatan())
        translator = instruksi.ExecuteReader
        If translator.Read = True Then
            MsgBox("SELAMAT DATANG...", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Informasi")
            Me.Hide()
            MDIParent1.ShowDialog()
        Else
            MsgBox("Username dan Password salah...", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Informasi")
        End If
    End Sub

    Private Sub keluarBtnKamar_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        ' Konfirmasi sebelum keluar aplikasi
        Dim confirm As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Application.Exit() ' Menutup aplikasi sepenuhnya
        End If
    End Sub

    Private Sub tombol_MouseEnter(sender As Object, e As EventArgs) Handles logoutBtn.MouseEnter, loginBtn.MouseEnter
        ' Mengubah warna teks tombol menjadi hitam dan latar belakang menjadi putih saat cursor diarahkan ke tombol
        Dim btn As Button = CType(sender, Button)
        If btn.Name = "loginBtn" Then
            ' Mengembalikan warna background keluarBtn ke merah semula
            btn.BackColor = Color.FromArgb(5, 25, 30)
        Else
            ' Tombol lainnya
            btn.ForeColor = Color.White
            btn.BackColor = Color.FromArgb(64, 0, 0)
        End If
    End Sub

    ' Event untuk MouseLeave (ketika kursor meninggalkan tombol)
    Private Sub tombol_MouseLeave(sender As Object, e As EventArgs) Handles logoutBtn.MouseLeave, loginBtn.MouseLeave
        ' Mengembalikan warna teks tombol ke warna semula dan latar belakang ke transparan saat cursor meninggalkan tombol
        Dim btn As Button = CType(sender, Button)
        If btn.Name = "loginBtn" Then
            ' Mengembalikan warna background keluarBtn ke merah semula
            btn.BackColor = Color.FromArgb(0, 64, 64)
        Else
            ' Tombol lainnya
            btn.ForeColor = Color.White
            btn.BackColor = Color.Maroon
        End If
    End Sub
End Class
