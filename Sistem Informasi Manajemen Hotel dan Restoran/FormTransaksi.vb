Imports MySql.Data.MySqlClient

Public Class FormTransaksi

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
    Private Sub pegawaiBtn_Click(sender As Object, e As EventArgs) Handles pegawaiBtn.Click
        ' Membuka form Tamu saat tombol ditekan
        Dim formPegawai As New FormPegawai() ' Ganti dengan nama form Tamu Anda
        formPegawai.Show()

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

    Private Sub HitungTotal()
        Dim hargaMakanan As Integer = 0
        Dim hargaKelas As Integer = 0
        Dim lamaInap As Integer = 1 ' Default 1 malam jika kosong

        ' Cek makanan yang dipilih
        Select Case ComboBoxMakanan.SelectedItem
            Case "Warteg"
                hargaMakanan = 25000
            Case "Padang"
                hargaMakanan = 75000
            Case "Jamblang"
                hargaMakanan = 50000
        End Select

        ' Cek kelas yang dipilih
        Select Case ComboBoxKelas.SelectedItem
            Case "Reguler"
                hargaKelas = 50000
            Case "VIP"
                hargaKelas = 100000
        End Select

        ' Ambil lama inap (jika kosong, dianggap 1 malam)
        If Not Integer.TryParse(textLamaInap.Text.Trim(), lamaInap) OrElse lamaInap <= 0 Then
            lamaInap = 1 ' Default ke 1 malam jika input salah
        End If

        ' Hitung total harga (makanan + (kelas * lama inap))
        Dim totalHarga As Integer = hargaMakanan + (hargaKelas * lamaInap)

        ' Tampilkan hasil ke textbox total
        textTotal.Text = totalHarga.ToString()

    End Sub

    ' Saat combo makanan, kelas, atau lama inap berubah, hitung total
    Private Sub ComboBoxMakanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMakanan.SelectedIndexChanged
        HitungTotal()
    End Sub

    Private Sub ComboBoxKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxKelas.SelectedIndexChanged
        HitungTotal()
    End Sub

    Private Sub textLamaInap_TextChanged(sender As Object, e As EventArgs) Handles textLamaInap.TextChanged
        HitungTotal()
    End Sub

    ' Fungsi untuk menghitung kembalian
    Private Sub hitungBtn_Click(sender As Object, e As EventArgs) Handles hitungBtn.Click
        Dim total As Decimal = Convert.ToDecimal(textTotal.Text.Trim())
        Dim bayar As Decimal = Convert.ToDecimal(textBayar.Text.Trim())

        ' Cek jika bayar cukup
        If bayar < total Then
            MsgBox("Uang bayar kurang!", MsgBoxStyle.Exclamation, "Peringatan")
            simpanBtn.Enabled = False
            Exit Sub
        End If

        ' Hitung kembalian
        Dim kembalian As Decimal = bayar - total
        textKembalian.Text = kembalian.ToString()
        simpanBtn.Enabled = True
    End Sub

    ' Fungsi untuk menyimpan data ke database
    Private Sub simpanBtn_Click(sender As Object, e As EventArgs) Handles simpanBtn.Click
        ' Ambil data dari TextBox, ComboBox, dan DateTimePicker
        Dim kd_transaksi As String = textKodeTransaksi.Text.Trim()
        Dim nama_pelanggan As String = textNamaPelanggan.Text.Trim()
        Dim makanan As String = If(ComboBoxMakanan.SelectedItem IsNot Nothing, ComboBoxMakanan.SelectedItem.ToString(), "")
        Dim kelas As String = If(ComboBoxKelas.SelectedItem IsNot Nothing, ComboBoxKelas.SelectedItem.ToString(), "")
        Dim lama_inap As Integer = Convert.ToInt32(textLamaInap.Text.Trim())
        Dim total As Decimal = Convert.ToDecimal(textTotal.Text.Trim())
        Dim bayar As Decimal = Convert.ToDecimal(textBayar.Text.Trim())
        Dim kembalian As Decimal = Convert.ToDecimal(textKembalian.Text.Trim())
        Dim nama_kamar As String = textNamaKamar.Text.Trim()
        Dim tanggal_transaksi As Date = dtpTransaksi.Value.Date ' Mengambil tanggal dari DateTimePicker

        ' Validasi jika ada field kosong
        If kd_transaksi = "" Or nama_pelanggan = "" Or makanan = "" Or kelas = "" Or lama_inap <= 0 Or total <= 0 Or bayar <= 0 Or kembalian < 0 Or nama_kamar = "" Then
            MsgBox("Semua field harus diisi dan valid!", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        ' Buka koneksi ke database
        Dim koneksi As MySqlConnection = jembatan() ' Pastikan fungsi jembatan() mengembalikan koneksi MySQL yang benar
        Dim sql As String = "INSERT INTO tb_transaksi (kd_transaksi, nama_pelanggan, tanggal_transaksi, nama_kamar, lama_inap, makanan, kelas, total, bayar, kembalian) " &
                            "VALUES (@kd_transaksi, @nama_pelanggan, @tanggal_transaksi, @nama_kamar, @lama_inap, @makanan, @kelas, @total, @bayar, @kembalian)"

        Try
            ' Siapkan command untuk eksekusi query
            Dim cmd As New MySqlCommand(sql, koneksi)
            cmd.Parameters.AddWithValue("@kd_transaksi", kd_transaksi)
            cmd.Parameters.AddWithValue("@nama_pelanggan", nama_pelanggan)
            cmd.Parameters.AddWithValue("@tanggal_transaksi", tanggal_transaksi)
            cmd.Parameters.AddWithValue("@nama_kamar", nama_kamar)
            cmd.Parameters.AddWithValue("@lama_inap", lama_inap)
            cmd.Parameters.AddWithValue("@makanan", makanan)
            cmd.Parameters.AddWithValue("@kelas", kelas)
            cmd.Parameters.AddWithValue("@total", total)
            cmd.Parameters.AddWithValue("@bayar", bayar)
            cmd.Parameters.AddWithValue("@kembalian", kembalian)

            ' Jalankan query
            cmd.ExecuteNonQuery()

            ' Menampilkan pesan sukses
            MsgBox("Data transaksi berhasil disimpan!", MsgBoxStyle.Information, "Sukses")

            ' Kosongkan input setelah menyimpan
            textKodeTransaksi.Clear()
            textNamaPelanggan.Clear()
            ComboBoxMakanan.SelectedIndex = -1
            ComboBoxKelas.SelectedIndex = -1
            textLamaInap.Clear()
            textTotal.Clear()
            textBayar.Clear()
            textKembalian.Clear()
            textNamaKamar.Clear()
            dtpTransaksi.Value = Date.Now ' Set tanggal ke default

            simpanBtn.Enabled = False

        Catch ex As Exception
            ' Tangani error
            MsgBox("Error saat menyimpan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Tutup koneksi
            koneksi.Close()
        End Try
    End Sub

    Private Sub LoadDataToListView()
        ' Kosongkan ListView sebelum menambah data baru
        ListView1.Items.Clear()

        ' Buka koneksi ke database
        Dim koneksi As MySqlConnection = jembatan()
        Dim sql As String = "SELECT * FROM tb_transaksi"
        Dim cmd As New MySqlCommand(sql, koneksi)
        Dim reader As MySqlDataReader

        Try
            reader = cmd.ExecuteReader()

            ' Baca data dari database dan tambahkan ke ListView
            While reader.Read()
                ' Buat item ListView baru berdasarkan kd_transaksi
                Dim item As New ListViewItem(reader("kd_transaksi").ToString())
                item.SubItems.Add(reader("nama_pelanggan").ToString())
                item.SubItems.Add(reader("nama_kamar").ToString())
                item.SubItems.Add(reader("makanan").ToString())
                item.SubItems.Add(Convert.ToDateTime(reader("tanggal_transaksi")).ToString("dd/MM/yyyy"))
                item.SubItems.Add(reader("kelas").ToString())
                item.SubItems.Add(reader("lama_inap").ToString())
                item.SubItems.Add(reader("total").ToString())
                item.SubItems.Add(reader("bayar").ToString())
                item.SubItems.Add(reader("kembalian").ToString())

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
        simpanBtn.Enabled = False
    End Sub

    Private Sub refreshBtnKamar_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        LoadDataToListView()
    End Sub

    Private Sub UpdateTransaksi()
        ' Pastikan koneksi ditutup sebelum membuka koneksi baru
        If penghubung.State = ConnectionState.Open Then
            penghubung.Close() ' Tutup koneksi jika terbuka
        End If

        ' Query untuk update transaksi
        Dim sql As String = "UPDATE tb_transaksi SET nama_pelanggan = @nama_pelanggan, makanan = @makanan, kelas = @kelas, lama_inap = @lama_inap, total = @total WHERE kd_transaksi = @kd_transaksi"

        Try
            ' Membuka koneksi ke database
            penghubung = New MySqlConnection(jalur)
            penghubung.Open()

            ' Menyiapkan command untuk update data
            Dim cmd As New MySqlCommand(sql, penghubung)
            cmd.Parameters.AddWithValue("@kd_transaksi", textKodeTransaksi.Text)
            cmd.Parameters.AddWithValue("@nama_pelanggan", textNamaPelanggan.Text)
            cmd.Parameters.AddWithValue("@makanan", ComboBoxMakanan.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@kelas", ComboBoxKelas.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@lama_inap", Convert.ToInt32(textLamaInap.Text))
            cmd.Parameters.AddWithValue("@total", Convert.ToInt32(textTotal.Text))

            ' Menjalankan perintah update
            cmd.ExecuteNonQuery()

            ' Memberikan pesan sukses
            MsgBox("Data transaksi berhasil diperbarui!", MsgBoxStyle.Information, "Sukses")

        Catch ex As Exception
            MsgBox("Error saat update transaksi: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Pastikan koneksi ditutup setelah operasi selesai
            If penghubung.State = ConnectionState.Open Then
                penghubung.Close()
            End If
        End Try
    End Sub

    Private Sub DeleteTransaksi()
        ' Pastikan koneksi ditutup sebelum membuka koneksi baru
        If penghubung.State = ConnectionState.Open Then
            penghubung.Close() ' Tutup koneksi jika terbuka
        End If

        ' Konfirmasi sebelum menghapus
        If MsgBox("Apakah Anda yakin ingin menghapus transaksi ini?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi") = MsgBoxResult.No Then
            Exit Sub
        End If

        ' Query untuk menghapus transaksi berdasarkan kode transaksi
        Dim sql As String = "DELETE FROM tb_transaksi WHERE kd_transaksi = @kd_transaksi"

        Try
            ' Membuka koneksi ke database
            penghubung = New MySqlConnection(jalur)
            penghubung.Open()

            ' Menyiapkan command untuk delete data
            Dim cmd As New MySqlCommand(sql, penghubung)
            cmd.Parameters.AddWithValue("@kd_transaksi", textKodeTransaksi.Text) ' Mengambil kode transaksi dari textbox

            ' Menjalankan perintah delete
            cmd.ExecuteNonQuery()

            ' Memberikan pesan sukses
            MsgBox("Data transaksi berhasil dihapus!", MsgBoxStyle.Information, "Sukses")

            ' Kosongkan input setelah delete
            textKodeTransaksi.Clear()
            textNamaPelanggan.Clear()
            ComboBoxMakanan.SelectedIndex = -1
            ComboBoxKelas.SelectedIndex = -1
            textLamaInap.Clear()
            textTotal.Clear()

        Catch ex As Exception
            MsgBox("Error saat menghapus transaksi: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Pastikan koneksi ditutup setelah operasi selesai
            If penghubung.State = ConnectionState.Open Then
                penghubung.Close()
            End If
        End Try
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        UpdateTransaksi()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        DeleteTransaksi()
    End Sub

    Private Sub CariDataTransaksi()
        Dim kdTransaksi As String = pencari.Text.Trim() ' Menghilangkan spasi ekstra pada Kode Transaksi

        ' Pastikan koneksi ditutup sebelum membuka koneksi baru
        If penghubung.State = ConnectionState.Open Then
            penghubung.Close() ' Tutup koneksi jika terbuka
        End If

        ' Query untuk mencari data berdasarkan kode transaksi
        Dim sql As String = "SELECT * FROM tb_transaksi WHERE kd_transaksi = @kd_transaksi"

        ' Kosongkan ListView sebelum memasukkan data baru
        ListView1.Items.Clear()

        Try
            ' Membuka koneksi ke database
            penghubung = New MySqlConnection(jalur)
            penghubung.Open()

            ' Menyiapkan command untuk mencari data
            Dim cmd As New MySqlCommand(sql, penghubung)
            cmd.Parameters.AddWithValue("@kd_transaksi", kdTransaksi) ' Mengambil Kode Transaksi yang sudah di-trim

            ' Membaca hasil query
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Periksa apakah ada data yang ditemukan
            If reader.HasRows Then
                While reader.Read()
                    ' Menambahkan item baru ke ListView
                    Dim item As New ListViewItem(reader("kd_transaksi").ToString())
                    item.SubItems.Add(reader("nama_pelanggan").ToString())
                    item.SubItems.Add(reader("nama_kamar").ToString())
                    item.SubItems.Add(reader("makanan").ToString())
                    item.SubItems.Add(Convert.ToDateTime(reader("tanggal_transaksi")).ToString("dd/MM/yyyy"))
                    item.SubItems.Add(reader("kelas").ToString())
                    item.SubItems.Add(reader("lama_inap").ToString())
                    item.SubItems.Add(reader("total").ToString())
                    item.SubItems.Add(reader("bayar").ToString())
                    item.SubItems.Add(reader("kembalian").ToString())

                    ' Menambahkan item ke ListView
                    ListView1.Items.Add(item)
                End While
            Else
                MsgBox("Kode Transaksi tidak ditemukan!", MsgBoxStyle.Information, "Not Found")
            End If

        Catch ex As Exception
            MsgBox("Error saat mencari transaksi: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Pastikan koneksi ditutup setelah operasi selesai
            If penghubung.State = ConnectionState.Open Then
                penghubung.Close()
            End If
        End Try
    End Sub

    Private Sub pencari_KeyDown(sender As Object, e As KeyEventArgs) Handles pencari.KeyDown
        If e.KeyCode = Keys.Enter Then
            CariDataTransaksi() ' Fungsi untuk mencari data berdasarkan kode kamar
        End If
    End Sub


End Class