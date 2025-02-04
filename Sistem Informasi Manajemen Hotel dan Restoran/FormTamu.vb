Imports System.Windows.Forms.VisualStyles
Imports MySql.Data.MySqlClient

Public Class FormTamu

    Private Sub kamarBtn_Click(sender As Object, e As EventArgs) Handles kamarBtn.Click
        ' Membuka form Tamu saat tombol ditekan
        Dim formKamar As New FormKamar() ' Ganti dengan nama form Tamu Anda
        formKamar.Show()

        ' Menyembunyikan form yang sedang aktif, jika diperlukan
        Me.Hide()
    End Sub

    Private Sub pegawaiBtn_Click(sender As Object, e As EventArgs) Handles pegawaiBtn.Click
        ' Membuka form Tamu saat tombol ditekan
        Dim formPegawai As New FormPegawai() ' Ganti dengan nama form Tamu Anda
        formPegawai.Show()

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
        Dim loginForm As New FormLogin ' Ganti dengan nama form login Anda
        loginForm.Show()

        ' Menutup form utama jika diperlukan (form utama ini akan tertutup setelah logout)
        Hide()
    End Sub

    Private Sub simpanBtn_Click(sender As Object, e As EventArgs) Handles simpanBtn.Click
        ' Ambil data dari TextBox, DateTimePicker, dan ComboBox
        Dim nik As String = textNik.Text.Trim()
        Dim nama_tamu As String = textNamaTamu.Text.Trim()
        Dim ttl As String = dtpTTL.Value.ToString("yyyy-MM-dd") ' Format tanggal ke format MySQL
        Dim jenis_kelamin As String = If(ComboBoxJenisKelamin.SelectedItem IsNot Nothing, ComboBoxJenisKelamin.SelectedItem.ToString(), "")
        Dim alamat As String = textAlamat.Text.Trim()
        Dim no_hp As String = textTelepon.Text.Trim()

        ' Validasi jika ada field kosong
        If nik = "" Or nama_tamu = "" Or jenis_kelamin = "" Or alamat = "" Or no_hp = "" Then
            MsgBox("Semua field harus diisi!", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        ' Buka koneksi ke database
        Dim koneksi As MySqlConnection = jembatan()
        Dim sql As String = "INSERT INTO tb_tamu (nik, nama_tamu, ttl, jenis_kelamin, alamat, no_hp) VALUES (@nik, @nama_tamu, @ttl, @jenis_kelamin, @alamat, @no_hp)"

        Try
            Dim cmd As New MySqlCommand(sql, koneksi)
            cmd.Parameters.AddWithValue("@nik", nik)
            cmd.Parameters.AddWithValue("@nama_tamu", nama_tamu)
            cmd.Parameters.AddWithValue("@ttl", ttl)
            cmd.Parameters.AddWithValue("@jenis_kelamin", jenis_kelamin)
            cmd.Parameters.AddWithValue("@alamat", alamat)
            cmd.Parameters.AddWithValue("@no_hp", no_hp)

            cmd.ExecuteNonQuery() ' Jalankan Query
            MsgBox("Data tamu berhasil disimpan!", MsgBoxStyle.Information, "Sukses")

            ' Kosongkan input setelah menyimpan
            textNik.Clear()
            textNamaTamu.Clear()
            dtpTTL.Value = DateTime.Now ' Reset tanggal ke hari ini
            ComboBoxJenisKelamin.SelectedIndex = -1
            textAlamat.Clear()
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
        Dim sql As String = "SELECT * FROM tb_tamu"
        Dim cmd As New MySqlCommand(sql, koneksi)
        Dim reader As MySqlDataReader

        Try
            reader = cmd.ExecuteReader()

            ' Baca data dari database dan tambahkan ke ListView
            While reader.Read()
                ' Buat item ListView baru
                Dim item As New ListViewItem(reader("nik").ToString())
                item.SubItems.Add(reader("nama_tamu").ToString())
                item.SubItems.Add(Convert.ToDateTime(reader("ttl")).ToString("yyyy-MM-dd")) ' Format TTL
                item.SubItems.Add(reader("jenis_kelamin").ToString())
                item.SubItems.Add(reader("alamat").ToString())
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

    Private Sub UpdateTamu()
        ' Pastikan koneksi ditutup sebelum membuka koneksi baru
        If penghubung.State = ConnectionState.Open Then
            penghubung.Close() ' Tutup koneksi jika terbuka
        End If

        ' Query untuk mengupdate data tamu
        Dim sql As String = "UPDATE tb_tamu SET nama_tamu = @nama_tamu, ttl = @ttl, jenis_kelamin = @jenis_kelamin, alamat = @alamat, no_hp = @no_hp WHERE nik = @nik"

        Try
            ' Membuka koneksi ke database
            penghubung = New MySqlConnection(jalur)
            penghubung.Open()

            ' Menyiapkan command untuk update data
            Dim cmd As New MySqlCommand(sql, penghubung)
            cmd.Parameters.AddWithValue("@nik", textNik.Text)
            cmd.Parameters.AddWithValue("@nama_tamu", textNamaTamu.Text)
            cmd.Parameters.AddWithValue("@ttl", dtpTTL.Value.ToString("yyyy-MM-dd")) ' Format TTL ke Date
            cmd.Parameters.AddWithValue("@jenis_kelamin", ComboBoxJenisKelamin.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@alamat", textAlamat.Text)
            cmd.Parameters.AddWithValue("@no_hp", textTelepon.Text)

            ' Menjalankan perintah update
            cmd.ExecuteNonQuery()

            ' Memberikan pesan sukses
            MsgBox("Data tamu berhasil diupdate!", MsgBoxStyle.Information, "Sukses")

        Catch ex As Exception
            MsgBox("Error saat update data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Pastikan koneksi ditutup setelah operasi selesai
            If penghubung.State = ConnectionState.Open Then
                penghubung.Close()
            End If
        End Try
    End Sub

    Private Sub DeleteTamu()
        ' Pastikan koneksi ditutup sebelum membuka koneksi baru
        If penghubung.State = ConnectionState.Open Then
            penghubung.Close() ' Tutup koneksi jika terbuka
        End If

        ' Konfirmasi sebelum menghapus
        If MsgBox("Apakah Anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi") = MsgBoxResult.No Then
            Exit Sub
        End If

        ' Query untuk menghapus data berdasarkan NIK
        Dim sql As String = "DELETE FROM tb_tamu WHERE nik = @nik"

        Try
            ' Membuka koneksi ke database
            penghubung = New MySqlConnection(jalur)
            penghubung.Open()

            ' Menyiapkan command untuk delete data
            Dim cmd As New MySqlCommand(sql, penghubung)
            cmd.Parameters.AddWithValue("@nik", textNik.Text) ' Mengambil NIK dari textbox

            ' Menjalankan perintah delete
            cmd.ExecuteNonQuery()

            ' Memberikan pesan sukses
            MsgBox("Data tamu berhasil dihapus!", MsgBoxStyle.Information, "Sukses")

            ' Kosongkan input setelah delete
            textNik.Clear()
            textNamaTamu.Clear()
            dtpTTL.Value = DateTime.Now
            ComboBoxJenisKelamin.SelectedIndex = -1
            textAlamat.Clear()
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

    Private Sub CariDataTamu()
        Dim nikTamu As String = pencari.Text.Trim() ' Menghilangkan spasi ekstra pada NIK

        ' Pastikan koneksi ditutup sebelum membuka koneksi baru
        If penghubung.State = ConnectionState.Open Then
            penghubung.Close() ' Tutup koneksi jika terbuka
        End If

        ' Query untuk mencari data berdasarkan NIK
        Dim sql As String = "SELECT * FROM tb_tamu WHERE nik = @nik"

        ' Kosongkan ListView sebelum memasukkan data baru
        ListView1.Items.Clear()

        Try
            ' Membuka koneksi ke database
            penghubung = New MySqlConnection(jalur)
            penghubung.Open()

            ' Menyiapkan command untuk mencari data
            Dim cmd As New MySqlCommand(sql, penghubung)
            cmd.Parameters.AddWithValue("@nik", nikTamu) ' Mengambil NIK yang sudah di-trim

            ' Membaca hasil query
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Periksa apakah ada data yang ditemukan
            If reader.HasRows Then
                While reader.Read()
                    ' Menambahkan item baru ke ListView
                    Dim item As New ListViewItem(reader("nik").ToString()) ' Menambahkan NIK ke kolom pertama
                    item.SubItems.Add(reader("nama_tamu").ToString()) ' Menambahkan nama tamu
                    item.SubItems.Add(reader("ttl").ToString()) ' Menambahkan tanggal lahir
                    item.SubItems.Add(reader("jenis_kelamin").ToString()) ' Menambahkan jenis kelamin
                    item.SubItems.Add(reader("alamat").ToString()) ' Menambahkan alamat
                    item.SubItems.Add(reader("no_hp").ToString()) ' Menambahkan nomor HP

                    ' Menambahkan item ke ListView
                    ListView1.Items.Add(item)
                End While
            Else
                MsgBox("NIK tidak ditemukan!", MsgBoxStyle.Information, "Not Found")
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
            CariDataTamu() ' Fungsi untuk mencari data berdasarkan kode kamar
        End If
    End Sub


    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        UpdateTamu()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        DeleteTamu()
    End Sub

    Private Sub refreshBtnKamar_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        LoadDataToListView()
    End Sub

End Class