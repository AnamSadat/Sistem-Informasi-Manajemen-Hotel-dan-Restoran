<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        transaksiBtn = New Button()
        pegawaiBtn = New Button()
        tamuBtn = New Button()
        kamarBtn = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        Label8 = New Label()
        textKodeTransaksi = New TextBox()
        textNamaKamar = New TextBox()
        Label7 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        textNamaPelanggan = New TextBox()
        textBayar = New TextBox()
        Label3 = New Label()
        Label6 = New Label()
        textLamaInap = New TextBox()
        deleteBtn = New Button()
        updateBtn = New Button()
        simpanBtn = New Button()
        dtpTransaksi = New DateTimePicker()
        Panel4 = New Panel()
        refreshBtn = New Button()
        pencari = New TextBox()
        Label9 = New Label()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        ColumnHeader10 = New ColumnHeader()
        Label10 = New Label()
        ComboBoxMakanan = New ComboBox()
        Label11 = New Label()
        textTotal = New TextBox()
        textKembalian = New TextBox()
        Label12 = New Label()
        hitungBtn = New Button()
        ComboBoxKelas = New ComboBox()
        Label13 = New Label()
        keluarBtn = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(5), CByte(25), CByte(30))
        Panel1.Controls.Add(keluarBtn)
        Panel1.Controls.Add(transaksiBtn)
        Panel1.Controls.Add(pegawaiBtn)
        Panel1.Controls.Add(tamuBtn)
        Panel1.Controls.Add(kamarBtn)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 450)
        Panel1.TabIndex = 6
        ' 
        ' transaksiBtn
        ' 
        transaksiBtn.BackColor = Color.Transparent
        transaksiBtn.Cursor = Cursors.Hand
        transaksiBtn.FlatAppearance.BorderColor = Color.Black
        transaksiBtn.FlatAppearance.BorderSize = 0
        transaksiBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        transaksiBtn.FlatStyle = FlatStyle.Flat
        transaksiBtn.Font = New Font("Geometr415 Blk BT", 20.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        transaksiBtn.ForeColor = SystemColors.ControlLightLight
        transaksiBtn.Location = New Point(0, 225)
        transaksiBtn.Name = "transaksiBtn"
        transaksiBtn.Size = New Size(200, 37)
        transaksiBtn.TabIndex = 10
        transaksiBtn.Text = "Transaksi"
        transaksiBtn.UseVisualStyleBackColor = False
        ' 
        ' pegawaiBtn
        ' 
        pegawaiBtn.BackColor = Color.Transparent
        pegawaiBtn.Cursor = Cursors.Hand
        pegawaiBtn.FlatAppearance.BorderColor = Color.Black
        pegawaiBtn.FlatAppearance.BorderSize = 0
        pegawaiBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        pegawaiBtn.FlatStyle = FlatStyle.Flat
        pegawaiBtn.Font = New Font("Geometr415 Blk BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pegawaiBtn.ForeColor = SystemColors.ControlLightLight
        pegawaiBtn.Location = New Point(0, 171)
        pegawaiBtn.Name = "pegawaiBtn"
        pegawaiBtn.Size = New Size(200, 48)
        pegawaiBtn.TabIndex = 9
        pegawaiBtn.Text = "Pegawai"
        pegawaiBtn.UseVisualStyleBackColor = False
        ' 
        ' tamuBtn
        ' 
        tamuBtn.BackColor = Color.Transparent
        tamuBtn.Cursor = Cursors.Hand
        tamuBtn.FlatAppearance.BorderColor = Color.Black
        tamuBtn.FlatAppearance.BorderSize = 0
        tamuBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        tamuBtn.FlatStyle = FlatStyle.Flat
        tamuBtn.Font = New Font("Geometr415 Blk BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tamuBtn.ForeColor = SystemColors.ControlLightLight
        tamuBtn.Location = New Point(0, 128)
        tamuBtn.Name = "tamuBtn"
        tamuBtn.Size = New Size(200, 37)
        tamuBtn.TabIndex = 8
        tamuBtn.Text = "Tamu"
        tamuBtn.UseVisualStyleBackColor = False
        ' 
        ' kamarBtn
        ' 
        kamarBtn.BackColor = Color.Transparent
        kamarBtn.Cursor = Cursors.Hand
        kamarBtn.FlatAppearance.BorderColor = Color.Black
        kamarBtn.FlatAppearance.BorderSize = 0
        kamarBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        kamarBtn.FlatStyle = FlatStyle.Flat
        kamarBtn.Font = New Font("Geometr415 Blk BT", 20.0F)
        kamarBtn.ForeColor = SystemColors.ControlLightLight
        kamarBtn.Location = New Point(0, 77)
        kamarBtn.Name = "kamarBtn"
        kamarBtn.Size = New Size(200, 37)
        kamarBtn.TabIndex = 7
        kamarBtn.Text = "Kamar"
        kamarBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Geometr415 Blk BT", 25.0F)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(10, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 41)
        Label1.TabIndex = 0
        Label1.Text = "Dashboard"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(200, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(600, 55)
        Panel2.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Geometr415 Blk BT", 30.0F)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(211, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(193, 48)
        Label4.TabIndex = 11
        Label4.Text = "Transaksi"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(234, 73)
        Label8.Name = "Label8"
        Label8.Size = New Size(85, 15)
        Label8.TabIndex = 44
        Label8.Text = "Kode Transaksi"
        ' 
        ' textKodeTransaksi
        ' 
        textKodeTransaksi.Location = New Point(370, 70)
        textKodeTransaksi.Name = "textKodeTransaksi"
        textKodeTransaksi.Size = New Size(121, 23)
        textKodeTransaksi.TabIndex = 43
        ' 
        ' textNamaKamar
        ' 
        textNamaKamar.Location = New Point(652, 99)
        textNamaKamar.Name = "textNamaKamar"
        textNamaKamar.Size = New Size(121, 23)
        textNamaKamar.TabIndex = 42
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(516, 109)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 15)
        Label7.TabIndex = 41
        Label7.Text = "Nama Kamar"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(516, 74)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 15)
        Label5.TabIndex = 39
        Label5.Text = "Tanggal Transasksi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(234, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 15)
        Label2.TabIndex = 38
        Label2.Text = "Nama Pelanggan"
        ' 
        ' textNamaPelanggan
        ' 
        textNamaPelanggan.Location = New Point(370, 100)
        textNamaPelanggan.Name = "textNamaPelanggan"
        textNamaPelanggan.Size = New Size(121, 23)
        textNamaPelanggan.TabIndex = 37
        ' 
        ' textBayar
        ' 
        textBayar.Location = New Point(652, 138)
        textBayar.Name = "textBayar"
        textBayar.Size = New Size(121, 23)
        textBayar.TabIndex = 48
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(516, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 47
        Label3.Text = "Bayar"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(234, 139)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 15)
        Label6.TabIndex = 46
        Label6.Text = "Lama Inap"
        ' 
        ' textLamaInap
        ' 
        textLamaInap.Location = New Point(370, 136)
        textLamaInap.Name = "textLamaInap"
        textLamaInap.Size = New Size(121, 23)
        textLamaInap.TabIndex = 45
        ' 
        ' deleteBtn
        ' 
        deleteBtn.Cursor = Cursors.Hand
        deleteBtn.Location = New Point(713, 236)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(75, 23)
        deleteBtn.TabIndex = 51
        deleteBtn.Text = "Delete"
        deleteBtn.UseVisualStyleBackColor = True
        ' 
        ' updateBtn
        ' 
        updateBtn.Cursor = Cursors.Hand
        updateBtn.Location = New Point(619, 236)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(75, 23)
        updateBtn.TabIndex = 50
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = True
        ' 
        ' simpanBtn
        ' 
        simpanBtn.Cursor = Cursors.Hand
        simpanBtn.Location = New Point(525, 236)
        simpanBtn.Name = "simpanBtn"
        simpanBtn.Size = New Size(75, 23)
        simpanBtn.TabIndex = 49
        simpanBtn.Text = "Simpan"
        simpanBtn.UseVisualStyleBackColor = True
        ' 
        ' dtpTransaksi
        ' 
        dtpTransaksi.Enabled = False
        dtpTransaksi.Location = New Point(652, 70)
        dtpTransaksi.Name = "dtpTransaksi"
        dtpTransaksi.Size = New Size(121, 23)
        dtpTransaksi.TabIndex = 52
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaption
        Panel4.Controls.Add(refreshBtn)
        Panel4.Controls.Add(pencari)
        Panel4.Controls.Add(Label9)
        Panel4.Location = New Point(200, 265)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(600, 42)
        Panel4.TabIndex = 54
        ' 
        ' refreshBtn
        ' 
        refreshBtn.Cursor = Cursors.Hand
        refreshBtn.Location = New Point(502, 11)
        refreshBtn.Name = "refreshBtn"
        refreshBtn.Size = New Size(75, 23)
        refreshBtn.TabIndex = 43
        refreshBtn.Text = "Refresh"
        refreshBtn.UseVisualStyleBackColor = True
        ' 
        ' pencari
        ' 
        pencari.Location = New Point(191, 11)
        pencari.Name = "pencari"
        pencari.Size = New Size(299, 23)
        pencari.TabIndex = 42
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(6, 10)
        Label9.Name = "Label9"
        Label9.Size = New Size(184, 21)
        Label9.TabIndex = 41
        Label9.Text = "CARI KODE TRANSAKSI"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9, ColumnHeader10})
        ListView1.Location = New Point(200, 306)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(600, 146)
        ListView1.TabIndex = 53
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Kode Transaksi"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Nama Pelanggan"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Nama Kamar"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Makanan"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Tanggal Transaksi"
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Kelas"
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Lama Inap"
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Total"
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Bayar"
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.Text = "Kembalian"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(234, 174)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 15)
        Label10.TabIndex = 56
        Label10.Text = "Makanan"
        ' 
        ' ComboBoxMakanan
        ' 
        ComboBoxMakanan.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxMakanan.FormattingEnabled = True
        ComboBoxMakanan.Items.AddRange(New Object() {"Padang", "Jamblang", "Warteg"})
        ComboBoxMakanan.Location = New Point(370, 174)
        ComboBoxMakanan.Name = "ComboBoxMakanan"
        ComboBoxMakanan.Size = New Size(121, 23)
        ComboBoxMakanan.TabIndex = 57
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(234, 239)
        Label11.Name = "Label11"
        Label11.Size = New Size(33, 15)
        Label11.TabIndex = 59
        Label11.Text = "Total"
        ' 
        ' textTotal
        ' 
        textTotal.Enabled = False
        textTotal.Location = New Point(370, 236)
        textTotal.Name = "textTotal"
        textTotal.Size = New Size(121, 23)
        textTotal.TabIndex = 58
        ' 
        ' textKembalian
        ' 
        textKembalian.Enabled = False
        textKembalian.Location = New Point(652, 174)
        textKembalian.Name = "textKembalian"
        textKembalian.Size = New Size(121, 23)
        textKembalian.TabIndex = 61
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(516, 177)
        Label12.Name = "Label12"
        Label12.Size = New Size(63, 15)
        Label12.TabIndex = 60
        Label12.Text = "Kembalian"
        ' 
        ' hitungBtn
        ' 
        hitungBtn.Cursor = Cursors.Hand
        hitungBtn.Location = New Point(698, 203)
        hitungBtn.Name = "hitungBtn"
        hitungBtn.Size = New Size(75, 23)
        hitungBtn.TabIndex = 62
        hitungBtn.Text = "Hitung"
        hitungBtn.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxKelas
        ' 
        ComboBoxKelas.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxKelas.FormattingEnabled = True
        ComboBoxKelas.Items.AddRange(New Object() {"Reguler", "VIP"})
        ComboBoxKelas.Location = New Point(370, 207)
        ComboBoxKelas.Name = "ComboBoxKelas"
        ComboBoxKelas.Size = New Size(121, 23)
        ComboBoxKelas.TabIndex = 64
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(234, 207)
        Label13.Name = "Label13"
        Label13.Size = New Size(34, 15)
        Label13.TabIndex = 63
        Label13.Text = "Kelas"
        ' 
        ' keluarBtn
        ' 
        keluarBtn.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        keluarBtn.Cursor = Cursors.Hand
        keluarBtn.FlatStyle = FlatStyle.Popup
        keluarBtn.Font = New Font("Geometr415 Blk BT", 15.0F)
        keluarBtn.ForeColor = SystemColors.ControlLightLight
        keluarBtn.Location = New Point(0, 407)
        keluarBtn.Name = "keluarBtn"
        keluarBtn.Size = New Size(200, 45)
        keluarBtn.TabIndex = 43
        keluarBtn.Text = "Keluar"
        keluarBtn.UseVisualStyleBackColor = False
        ' 
        ' FormTransaksi
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ComboBoxKelas)
        Controls.Add(Label13)
        Controls.Add(hitungBtn)
        Controls.Add(textKembalian)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(textTotal)
        Controls.Add(ComboBoxMakanan)
        Controls.Add(Label10)
        Controls.Add(Panel4)
        Controls.Add(ListView1)
        Controls.Add(dtpTransaksi)
        Controls.Add(deleteBtn)
        Controls.Add(updateBtn)
        Controls.Add(simpanBtn)
        Controls.Add(textBayar)
        Controls.Add(Label3)
        Controls.Add(Label6)
        Controls.Add(textLamaInap)
        Controls.Add(Label8)
        Controls.Add(textKodeTransaksi)
        Controls.Add(textNamaKamar)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(textNamaPelanggan)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FormTransaksi"
        Text = "FormTransaksi"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents transaksiBtn As Button
    Friend WithEvents pegawaiBtn As Button
    Friend WithEvents tamuBtn As Button
    Friend WithEvents kamarBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents textKodeTransaksi As TextBox
    Friend WithEvents textNamaKamar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textNamaPelanggan As TextBox
    Friend WithEvents textBayar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents textLamaInap As TextBox
    Friend WithEvents deleteBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents simpanBtn As Button
    Friend WithEvents dtpTransaksi As DateTimePicker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents refreshBtn As Button
    Friend WithEvents pencari As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBoxMakanan As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents textTotal As TextBox
    Friend WithEvents textKembalian As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents hitungBtn As Button
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ComboBoxKelas As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents keluarBtn As Button
End Class
