Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class FormKamar
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles kamarBtnKamar.Click

    End Sub

    Private Sub simpanBtnKamar_Click(sender As Object, e As EventArgs) Handles simpanBtnKamar.Click
        ' Ambil data dari TextBox dan ComboBox
        Dim kd_kamar As String = TextKodeKamar.Text
        Dim nama_kamar As String = TextNamaKamar.Text
        Dim status As String = ComboBoxStatus.Text
        Dim kelas As String = ComboBoxKelas.Text
        Dim tarif As String = TextTarif.Text

        ' Validasi jika ada field kosong
        If kd_kamar = "" Or nama_kamar = "" Or status = "" Or kelas = "" Or tarif = "" Then
            MsgBox("Semua field harus diisi!", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        ' Buka koneksi ke database
        Dim koneksi As MySqlConnection = jembatan()
        Dim sql As String = "INSERT INTO tb_kamar (kd_kamar, nama_kamar, status, kelas, tarif) VALUES (@kd_kamar, @nama_kamar, @status, @kelas, @tarif)"

        Try
            Dim cmd As New MySqlCommand(sql, koneksi)
            cmd.Parameters.AddWithValue("@kd_kamar", kd_kamar)
            cmd.Parameters.AddWithValue("@nama_kamar", nama_kamar)
            cmd.Parameters.AddWithValue("@status", status)
            cmd.Parameters.AddWithValue("@kelas", kelas)
            cmd.Parameters.AddWithValue("@tarif", tarif)

            cmd.ExecuteNonQuery() ' Jalankan Query
            MsgBox("Data kamar berhasil disimpan!", MsgBoxStyle.Information, "Sukses")

            ' Kosongkan input setelah menyimpan
            TextKodeKamar.Clear()
            TextNamaKamar.Clear()
            ComboBoxStatus.SelectedIndex = -1
            ComboBoxKelas.SelectedIndex = -1
            TextTarif.Clear()

        Catch ex As Exception
            MsgBox("Error saat menyimpan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            koneksi.Close() ' Tutup koneksi
        End Try
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick

    End Sub

    Private Sub ComboBoxKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxKelas.SelectedIndexChanged
        ' Menentukan tarif berdasarkan pilihan kelas
        If ComboBoxKelas.SelectedItem = "Regular" Then
            TextTarif.Text = 50000 ' Menampilkan tarif untuk kelas Regular
        ElseIf ComboBoxKelas.SelectedItem = "VIP" Then
            TextTarif.Text = 100000 ' Menampilkan tarif untuk kelas VIP
        Else
            TextTarif.Clear() ' Jika kelas tidak dipilih, kosongkan tarif
        End If

        ' Membuat TextBox tarif tidak bisa diubah (read-only)
        TextTarif.ReadOnly = True
    End Sub

    Private Sub LoadDataToListView()
        ' Kosongkan ListView sebelum menambah data baru
        ListView1.Items.Clear()

        ' Buka koneksi ke database
        Dim koneksi As MySqlConnection = jembatan()
        Dim sql As String = "SELECT * FROM tb_kamar"
        Dim cmd As New MySqlCommand(sql, koneksi)
        Dim reader As MySqlDataReader

        Try
            reader = cmd.ExecuteReader()

            ' Baca data dari database dan tambahkan ke ListView
            While reader.Read()
                ' Buat item ListView baru
                Dim item As New ListViewItem(reader("kd_kamar").ToString())
                item.SubItems.Add(reader("nama_kamar").ToString())
                item.SubItems.Add(reader("kelas").ToString())
                item.SubItems.Add(reader("tarif").ToString())
                item.SubItems.Add(reader("status").ToString())

                ' Tambahkan item ke ListView
                ListView1.Items.Add(item)
            End While

        Catch ex As Exception
            MsgBox("Error saat mengambil data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            koneksi.Close() ' Tutup koneksi
        End Try
    End Sub

    Private Sub UpdateKamar()
        ' Pastikan koneksi ditutup sebelum membuka koneksi baru
        If penghubung.State = ConnectionState.Open Then
            penghubung.Close() ' Tutup koneksi jika terbuka
        End If

        ' Query untuk mengupdate data
        Dim sql As String = "UPDATE tb_kamar SET nama_kamar = @nama_kamar, status = @status, kelas = @kelas, tarif = @tarif WHERE kd_kamar = @kd_kamar"

        Try
            ' Membuka koneksi ke database
            penghubung = New MySqlConnection(jalur)
            penghubung.Open()

            ' Menyiapkan command untuk update data
            Dim cmd As New MySqlCommand(sql, penghubung)
            cmd.Parameters.AddWithValue("@kd_kamar", TextKodeKamar.Text)
            cmd.Parameters.AddWithValue("@nama_kamar", TextNamaKamar.Text)
            cmd.Parameters.AddWithValue("@status", ComboBoxStatus.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@kelas", ComboBoxKelas.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@tarif", TextTarif.Text)

            ' Menjalankan perintah update
            cmd.ExecuteNonQuery()

            ' Memberikan pesan sukses
            MsgBox("Data berhasil diupdate!", MsgBoxStyle.Information, "Sukses")

        Catch ex As Exception
            MsgBox("Error saat update data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Pastikan koneksi ditutup setelah operasi selesai
            If penghubung.State = ConnectionState.Open Then
                penghubung.Close()
            End If
        End Try
    End Sub



    Private Sub DeleteKamar()
        ' Pastikan koneksi ditutup sebelum membuka koneksi baru
        If penghubung.State = ConnectionState.Open Then
            penghubung.Close() ' Tutup koneksi jika terbuka
        End If

        If MsgBox("Apakah Anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi") = MsgBoxResult.No Then
            Exit Sub
        End If

        ' Query untuk menghapus data berdasarkan kode kamar
        Dim sql As String = "DELETE FROM tb_kamar WHERE kd_kamar = @kd_kamar"

        Try
            ' Membuka koneksi ke database
            penghubung = New MySqlConnection(jalur)
            penghubung.Open()

            ' Menyiapkan command untuk delete data
            Dim cmd As New MySqlCommand(sql, penghubung)
            cmd.Parameters.AddWithValue("@kd_kamar", TextKodeKamar.Text) ' Mengambil kode kamar dari textbox

            ' Menjalankan perintah delete
            cmd.ExecuteNonQuery()

            ' Memberikan pesan sukses
            MsgBox("Data berhasil dihapus!", MsgBoxStyle.Information, "Sukses")

        Catch ex As Exception
            MsgBox("Error saat menghapus data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Pastikan koneksi ditutup setelah operasi selesai
            If penghubung.State = ConnectionState.Open Then
                penghubung.Close()
            End If
        End Try
    End Sub

    Private Sub CariDataKamar()
        Dim kodeKamar As String = pencari.Text.Trim() ' Menghilangkan spasi ekstra

        ' Pastikan koneksi ditutup sebelum membuka koneksi baru
        If penghubung.State = ConnectionState.Open Then
            penghubung.Close() ' Tutup koneksi jika terbuka
        End If

        ' Query untuk mencari data berdasarkan kode kamar
        Dim sql As String = "SELECT * FROM tb_kamar WHERE kd_kamar = @kd_kamar"

        ' Kosongkan ListView sebelum memasukkan data baru
        ListView1.Items.Clear()

        Try
            ' Membuka koneksi ke database
            penghubung = New MySqlConnection(jalur)
            penghubung.Open()

            ' Menyiapkan command untuk mencari data
            Dim cmd As New MySqlCommand(sql, penghubung)
            cmd.Parameters.AddWithValue("@kd_kamar", kodeKamar) ' Mengambil kode kamar yang sudah di-trim

            ' Membaca hasil query
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Periksa apakah ada data yang ditemukan
            If reader.HasRows Then
                While reader.Read()
                    ' Menambahkan item baru ke ListView
                    Dim item As New ListViewItem(reader("kd_kamar").ToString()) ' Menambahkan kode kamar ke kolom pertama
                    item.SubItems.Add(reader("nama_kamar").ToString()) ' Menambahkan nama kamar
                    item.SubItems.Add(reader("status").ToString()) ' Menambahkan status
                    item.SubItems.Add(reader("kelas").ToString()) ' Menambahkan kelas
                    item.SubItems.Add(reader("tarif").ToString()) ' Menambahkan tarif

                    ' Menambahkan item ke ListView
                    ListView1.Items.Add(item)
                End While
            Else
                MsgBox("Kode kamar tidak ditemukan!", MsgBoxStyle.Information, "Not Found")
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
            CariDataKamar() ' Fungsi untuk mencari data berdasarkan kode kamar
        End If
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


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToListView()
    End Sub

    Private Sub updateBtnKamar_Click(sender As Object, e As EventArgs) Handles updateBtnKamar.Click
        UpdateKamar()
    End Sub

    Private Sub deleteBtnKamar_Click(sender As Object, e As EventArgs) Handles deleteBtnKamar.Click
        DeleteKamar()
    End Sub

    Private Sub refreshBtnKamar_Click(sender As Object, e As EventArgs) Handles refreshBtnKamar.Click
        LoadDataToListView()
    End Sub

    Private Sub tamuBtnKamar_Click(sender As Object, e As EventArgs) Handles tamuBtnKamar.Click
        ' Membuka form Tamu saat tombol ditekan
        Dim formTamu As New FormTamu() ' Ganti dengan nama form Tamu Anda
        formTamu.Show()

        ' Menyembunyikan form yang sedang aktif, jika diperlukan
        Me.Hide()
    End Sub

    Private Sub pegawaiBtnKamar_Click(sender As Object, e As EventArgs) Handles pegawaiBtnKamar.Click
        ' Membuka form Tamu saat tombol ditekan
        Dim formPegawai As New FormPegawai() ' Ganti dengan nama form Tamu Anda
        formPegawai.Show()

        ' Menyembunyikan form yang sedang aktif, jika diperlukan
        Me.Hide()
    End Sub
    Private Sub transaksiBtnKamar_Click(sender As Object, e As EventArgs) Handles transaksiBtnKamar.Click
        ' Membuka form Tamu saat tombol ditekan
        Dim formTransaksi As New FormTransaksi() ' Ganti dengan nama form Tamu Anda
        formTransaksi.Show()

        ' Menyembunyikan form yang sedang aktif, jika diperlukan
        Me.Hide()
    End Sub

    ' Event untuk MouseEnter (ketika kursor diarahkan ke tombol)
    Private Sub tombol_MouseEnter(sender As Object, e As EventArgs) Handles tamuBtnKamar.MouseEnter, pegawaiBtnKamar.MouseEnter, transaksiBtnKamar.MouseEnter, kamarBtnKamar.MouseEnter
        ' Mengubah warna teks tombol menjadi hitam dan latar belakang menjadi putih saat cursor diarahkan ke tombol
        Dim btn As Button = CType(sender, Button)
        btn.ForeColor = Color.Black
        btn.BackColor = Color.White
    End Sub

    ' Event untuk MouseLeave (ketika kursor meninggalkan tombol)
    Private Sub tombol_MouseLeave(sender As Object, e As EventArgs) Handles tamuBtnKamar.MouseLeave, pegawaiBtnKamar.MouseLeave, transaksiBtnKamar.MouseLeave, kamarBtnKamar.MouseLeave
        ' Mengembalikan warna teks tombol ke warna semula dan latar belakang ke transparan saat cursor meninggalkan tombol
        Dim btn As Button = CType(sender, Button)
        btn.ForeColor = Color.White ' Ganti dengan warna teks awal
        btn.BackColor = Color.Transparent
    End Sub

    Private Sub TextKodeKamar_TextChanged(sender As Object, e As EventArgs) Handles TextKodeKamar.TextChanged

    End Sub


End Class