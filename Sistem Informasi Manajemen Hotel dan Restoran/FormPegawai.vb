Imports MySql.Data.MySqlClient

Public Class FormPegawai

    Private Sub kamarBtn_Click(sender As Object, e As EventArgs) Handles kamarBtn.Click
        ' Membuka form Tamu saat tombol ditekan
        Dim formKamar As New FormKamar() ' Ganti dengan nama form Tamu Anda
        formKamar.Show()

        ' Menyembunyikan form yang sedang aktif, jika diperlukan
        Me.Hide()
    End Sub

    Private Sub tamuiBtn_Click(sender As Object, e As EventArgs) Handles tamuBtn.Click
        ' Membuka form Tamu saat tombol ditekan
        Dim formTamu As New FormTamu() ' Ganti dengan nama form Tamu Anda
        formTamu.Show()

        ' Menyembunyikan form yang sedang aktif, jika diperlukan
        Me.Hide()
    End Sub
    Private Sub transaksiBtn_Click(sender As Object, e As EventArgs) Handles transaksiBtn.Click
        ' Membuka form Tamu saat tombol ditekan
        Dim formTransaksi As New FormTransaksi() ' Ganti dengan nama form Tamu Anda
        formTransaksi.Show()

        ' Menyembunyikan form yang sedang aktif, jika diperlukan
        Me.Hide()
    End Sub

    ' Event untuk MouseEnter (ketika kursor diarahkan ke tombol)
    Private Sub tombol_MouseEnter(sender As Object, e As EventArgs) Handles tamuBtn.MouseEnter, pegawaiBtn.MouseEnter, transaksiBtn.MouseEnter, kamarBtn.MouseEnter
        ' Mengubah warna teks tombol menjadi hitam dan latar belakang menjadi putih saat cursor diarahkan ke tombol
        Dim btn As Button = CType(sender, Button)
        btn.ForeColor = Color.Black
        btn.BackColor = Color.White
    End Sub

    ' Event untuk MouseLeave (ketika kursor meninggalkan tombol)
    Private Sub tombol_MouseLeave(sender As Object, e As EventArgs) Handles tamuBtn.MouseLeave, pegawaiBtn.MouseLeave, transaksiBtn.MouseLeave, kamarBtn.MouseLeave
        ' Mengembalikan warna teks tombol ke warna semula dan latar belakang ke transparan saat cursor meninggalkan tombol
        Dim btn As Button = CType(sender, Button)
        btn.ForeColor = Color.White ' Ganti dengan warna teks awal
        btn.BackColor = Color.Transparent
    End Sub

    Private Sub keluarBtn_Click(sender As Object, e As EventArgs) Handles keluarBtn.Click
        ' Menutup koneksi jika terbuka
        If penghubung.State = ConnectionState.Open Then
            penghubung.Close()
        End If

        ' Menyembunyikan form saat logout dan menampilkan form login
        Dim loginForm As New FormLogin() ' Ganti dengan nama form login Anda
        loginForm.Show()

        ' Menutup form utama jika diperlukan (form utama ini akan tertutup setelah logout)
        Me.Hide()
    End Sub

    Private Sub simpanBtn_Click(sender As Object, e As EventArgs) Handles simpanBtn.Click
        ' Ambil data dari TextBox dan ComboBox
        Dim kd_pegawai As String = textKodePegawai.Text.Trim()
        Dim nama_pegawai As String = textNamaPegawai.Text.Trim()
        Dim jenis_kelamin As String = If(ComboBoxJenisKelamin.SelectedItem IsNot Nothing, ComboBoxJenisKelamin.SelectedItem.ToString(), "")
        Dim no_hp As String = textTelepon.Text.Trim()

        ' Validasi jika ada field kosong
        If kd_pegawai = "" Or nama_pegawai = "" Or jenis_kelamin = "" Or no_hp = "" Then
            MsgBox("Semua field harus diisi!", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        ' Buka koneksi ke database
        Dim koneksi As MySqlConnection = jembatan() ' Pastikan fungsi jembatan() mengembalikan koneksi MySQL yang benar
        Dim sql As String = "INSERT INTO tb_pegawai (kd_pegawai, nama_pegawai, jenis_kelamin, no_hp) VALUES (@kd_pegawai, @nama_pegawai, @jenis_kelamin, @no_hp)"

        Try
            Dim cmd As New MySqlCommand(sql, koneksi)
            cmd.Parameters.AddWithValue("@kd_pegawai", kd_pegawai)
            cmd.Parameters.AddWithValue("@nama_pegawai", nama_pegawai)
            cmd.Parameters.AddWithValue("@jenis_kelamin", jenis_kelamin)
            cmd.Parameters.AddWithValue("@no_hp", no_hp)

            cmd.ExecuteNonQuery() ' Jalankan Query
            MsgBox("Data pegawai berhasil disimpan!", MsgBoxStyle.Information, "Sukses")

            ' Kosongkan input setelah menyimpan
            textKodePegawai.Clear()
            textNamaPegawai.Clear()
            ComboBoxJenisKelamin.SelectedIndex = -1
            textTelepon.Clear()

        Catch ex As Exception
            MsgBox("Error saat menyimpan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            koneksi.Close() ' Tutup koneksi
        End Try
    End Sub

    Private Sub LoadDataToListView()
        ' Kosongkan ListView sebelum menambah data baru
        ListView1.Items.Clear()

        ' Buka koneksi ke database
        Dim koneksi As MySqlConnection = jembatan()
        Dim sql As String = "SELECT * FROM tb_pegawai"
        Dim cmd As New MySqlCommand(sql, koneksi)
        Dim reader As MySqlDataReader

        Try
            reader = cmd.ExecuteReader()

            ' Baca data dari database dan tambahkan ke ListView
            While reader.Read()
                ' Buat item ListView baru
                Dim item As New ListViewItem(reader("kd_pegawai").ToString())
                item.SubItems.Add(reader("nama_pegawai").ToString())
                item.SubItems.Add(reader("jenis_kelamin").ToString())
                item.SubItems.Add(reader("no_hp").ToString())

                ' Tambahkan item ke ListView
                ListView1.Items.Add(item)
            End While

        Catch ex As Exception
            MsgBox("Error saat mengambil data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            koneksi.Close() ' Tutup koneksi
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToListView()
    End Sub

    Private Sub refreshBtnKamar_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        LoadDataToListView()
    End Sub

    Private Sub UpdatePegawai()
        ' Pastikan koneksi ditutup sebelum membuka koneksi baru
        If penghubung.State = ConnectionState.Open Then
            penghubung.Close() ' Tutup koneksi jika terbuka
        End If

        ' Query untuk mengupdate data pegawai
        Dim sql As String = "UPDATE tb_pegawai SET nama_pegawai = @nama_pegawai, jenis_kelamin = @jenis_kelamin, no_hp = @no_hp WHERE kd_pegawai = @kd_pegawai"

        Try
            ' Membuka koneksi ke database
            penghubung = New MySqlConnection(jalur)
            penghubung.Open()

            ' Menyiapkan command untuk update data
            Dim cmd As New MySqlCommand(sql, penghubung)
            cmd.Parameters.AddWithValue("@kd_pegawai", textKodePegawai.Text)
            cmd.Parameters.AddWithValue("@nama_pegawai", textNamaPegawai.Text)
            cmd.Parameters.AddWithValue("@jenis_kelamin", ComboBoxJenisKelamin.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@no_hp", textTelepon.Text)

            ' Menjalankan perintah update
            cmd.ExecuteNonQuery()

            ' Memberikan pesan sukses
            MsgBox("Data pegawai berhasil diupdate!", MsgBoxStyle.Information, "Sukses")

        Catch ex As Exception
            MsgBox("Error saat update data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Pastikan koneksi ditutup setelah operasi selesai
            If penghubung.State = ConnectionState.Open Then
                penghubung.Close()
            End If
        End Try
    End Sub

    Private Sub DeletePegawai()
        ' Pastikan koneksi ditutup sebelum membuka koneksi baru
        If penghubung.State = ConnectionState.Open Then
            penghubung.Close() ' Tutup koneksi jika terbuka
        End If

        ' Konfirmasi sebelum menghapus
        If MsgBox("Apakah Anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi") = MsgBoxResult.No Then
            Exit Sub
        End If

        ' Query untuk menghapus data berdasarkan kode pegawai
        Dim sql As String = "DELETE FROM tb_pegawai WHERE kd_pegawai = @kd_pegawai"

        Try
            ' Membuka koneksi ke database
            penghubung = New MySqlConnection(jalur)
            penghubung.Open()

            ' Menyiapkan command untuk delete data
            Dim cmd As New MySqlCommand(sql, penghubung)
            cmd.Parameters.AddWithValue("@kd_pegawai", textKodePegawai.Text) ' Mengambil kode pegawai dari textbox

            ' Menjalankan perintah delete
            cmd.ExecuteNonQuery()

            ' Memberikan pesan sukses
            MsgBox("Data pegawai berhasil dihapus!", MsgBoxStyle.Information, "Sukses")

            ' Kosongkan input setelah delete
            textKodePegawai.Clear()
            textNamaPegawai.Clear()
            ComboBoxJenisKelamin.SelectedIndex = -1
            textTelepon.Clear()

        Catch ex As Exception
            MsgBox("Error saat menghapus data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Pastikan koneksi ditutup setelah operasi selesai
            If penghubung.State = ConnectionState.Open Then
                penghubung.Close()
            End If
        End Try
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        UpdatePegawai()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        DeletePegawai()
    End Sub

    Private Sub CariDataPegawai()
        Dim kdPegawai As String = pencari.Text.Trim() ' Menghilangkan spasi ekstra pada Kode Pegawai

        ' Pastikan koneksi ditutup sebelum membuka koneksi baru
        If penghubung.State = ConnectionState.Open Then
            penghubung.Close() ' Tutup koneksi jika terbuka
        End If

        ' Query untuk mencari data berdasarkan kode pegawai
        Dim sql As String = "SELECT * FROM tb_pegawai WHERE kd_pegawai = @kd_pegawai"

        ' Kosongkan ListView sebelum memasukkan data baru
        ListView1.Items.Clear()

        Try
            ' Membuka koneksi ke database
            penghubung = New MySqlConnection(jalur)
            penghubung.Open()

            ' Menyiapkan command untuk mencari data
            Dim cmd As New MySqlCommand(sql, penghubung)
            cmd.Parameters.AddWithValue("@kd_pegawai", kdPegawai) ' Mengambil Kode Pegawai yang sudah di-trim

            ' Membaca hasil query
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Periksa apakah ada data yang ditemukan
            If reader.HasRows Then
                While reader.Read()
                    ' Menambahkan item baru ke ListView
                    Dim item As New ListViewItem(reader("kd_pegawai").ToString()) ' Menambahkan Kode Pegawai ke kolom pertama
                    item.SubItems.Add(reader("nama_pegawai").ToString()) ' Menambahkan nama pegawai
                    item.SubItems.Add(reader("jenis_kelamin").ToString()) ' Menambahkan jenis kelamin
                    item.SubItems.Add(reader("no_hp").ToString()) ' Menambahkan nomor HP

                    ' Menambahkan item ke ListView
                    ListView1.Items.Add(item)
                End While
            Else
                MsgBox("Kode Pegawai tidak ditemukan!", MsgBoxStyle.Information, "Not Found")
            End If

        Catch ex As Exception
            MsgBox("Error saat mencari data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Pastikan koneksi ditutup setelah operasi selesai
            If penghubung.State = ConnectionState.Open Then
                penghubung.Close()
            End If
        End Try
    End Sub

    Private Sub pencari_KeyDown(sender As Object, e As KeyEventArgs) Handles pencari.KeyDown
        If e.KeyCode = Keys.Enter Then
            CariDataPegawai() ' Fungsi untuk mencari data berdasarkan kode kamar
        End If
    End Sub

End Class