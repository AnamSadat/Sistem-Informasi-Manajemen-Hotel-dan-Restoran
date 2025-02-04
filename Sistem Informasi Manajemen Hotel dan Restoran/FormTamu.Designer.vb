<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTamu
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
        Panel3 = New Panel()
        pegawaiBtn = New Button()
        tamuBtn = New Button()
        kamarBtn = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        textNamaTamu = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        ComboBoxJenisKelamin = New ComboBox()
        Label6 = New Label()
        Label7 = New Label()
        textAlamat = New TextBox()
        textTelepon = New TextBox()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        Label8 = New Label()
        textNik = New TextBox()
        Panel4 = New Panel()
        refreshBtn = New Button()
        pencari = New TextBox()
        Label9 = New Label()
        simpanBtn = New Button()
        updateBtn = New Button()
        deleteBtn = New Button()
        dtpTTL = New DateTimePicker()
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
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(pegawaiBtn)
        Panel1.Controls.Add(tamuBtn)
        Panel1.Controls.Add(kamarBtn)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 450)
        Panel1.TabIndex = 4
        ' 
        ' transaksiBtn
        ' 
        transaksiBtn.BackColor = Color.Transparent
        transaksiBtn.Cursor = Cursors.Hand
        transaksiBtn.FlatAppearance.BorderColor = Color.Black
        transaksiBtn.FlatAppearance.BorderSize = 0
        transaksiBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        transaksiBtn.FlatStyle = FlatStyle.Flat
        transaksiBtn.Font = New Font("Geometr415 Blk BT", 20.0F)
        transaksiBtn.ForeColor = SystemColors.ControlLightLight
        transaksiBtn.Location = New Point(0, 225)
        transaksiBtn.Name = "transaksiBtn"
        transaksiBtn.Size = New Size(200, 37)
        transaksiBtn.TabIndex = 10
        transaksiBtn.Text = "Transaksi"
        transaksiBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.MediumAquamarine
        Panel3.Location = New Point(200, 266)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(600, 37)
        Panel3.TabIndex = 16
        ' 
        ' pegawaiBtn
        ' 
        pegawaiBtn.BackColor = Color.Transparent
        pegawaiBtn.Cursor = Cursors.Hand
        pegawaiBtn.FlatAppearance.BorderColor = Color.Black
        pegawaiBtn.FlatAppearance.BorderSize = 0
        pegawaiBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        pegawaiBtn.FlatStyle = FlatStyle.Flat
        pegawaiBtn.Font = New Font("Geometr415 Blk BT", 20.0F)
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
        tamuBtn.Font = New Font("Geometr415 Blk BT", 20.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
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
        Panel2.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Geometr415 Blk BT", 30.0F)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(230, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 48)
        Label4.TabIndex = 11
        Label4.Text = "Tamu"
        ' 
        ' textNamaTamu
        ' 
        textNamaTamu.Location = New Point(370, 129)
        textNamaTamu.Name = "textNamaTamu"
        textNamaTamu.Size = New Size(121, 23)
        textNamaTamu.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(234, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 7
        Label2.Text = "Nama Tamu"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(234, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 15)
        Label3.TabIndex = 8
        Label3.Text = "Tempat, Tanggal Lahir"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(516, 91)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 15)
        Label5.TabIndex = 9
        Label5.Text = "Jenis Kelamin"
        ' 
        ' ComboBoxJenisKelamin
        ' 
        ComboBoxJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxJenisKelamin.FormattingEnabled = True
        ComboBoxJenisKelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        ComboBoxJenisKelamin.Location = New Point(652, 87)
        ComboBoxJenisKelamin.Name = "ComboBoxJenisKelamin"
        ComboBoxJenisKelamin.Size = New Size(121, 23)
        ComboBoxJenisKelamin.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(516, 135)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 15)
        Label6.TabIndex = 11
        Label6.Text = "Alamat"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(516, 177)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 15)
        Label7.TabIndex = 12
        Label7.Text = "No. Telepon"
        ' 
        ' textAlamat
        ' 
        textAlamat.Location = New Point(652, 132)
        textAlamat.Name = "textAlamat"
        textAlamat.Size = New Size(121, 23)
        textAlamat.TabIndex = 14
        ' 
        ' textTelepon
        ' 
        textTelepon.Location = New Point(652, 171)
        textTelepon.Name = "textTelepon"
        textTelepon.Size = New Size(121, 23)
        textTelepon.TabIndex = 15
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6})
        ListView1.Location = New Point(200, 304)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(600, 146)
        ListView1.TabIndex = 17
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "NIK"
        ColumnHeader1.Width = 80
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Nama Tamu"
        ColumnHeader2.Width = 80
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "TTL"
        ColumnHeader3.Width = 90
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Jenis Kelamin"
        ColumnHeader4.Width = 80
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Alamat"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "No Telepon"
        ColumnHeader6.Width = 80
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(234, 90)
        Label8.Name = "Label8"
        Label8.Size = New Size(26, 15)
        Label8.TabIndex = 19
        Label8.Text = "NIK"
        ' 
        ' textNik
        ' 
        textNik.Location = New Point(370, 87)
        textNik.Name = "textNik"
        textNik.Size = New Size(121, 23)
        textNik.TabIndex = 18
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaption
        Panel4.Controls.Add(refreshBtn)
        Panel4.Controls.Add(pencari)
        Panel4.Controls.Add(Label9)
        Panel4.Location = New Point(200, 263)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(600, 42)
        Panel4.TabIndex = 20
        ' 
        ' refreshBtn
        ' 
        refreshBtn.Cursor = Cursors.Hand
        refreshBtn.Location = New Point(508, 10)
        refreshBtn.Name = "refreshBtn"
        refreshBtn.Size = New Size(75, 23)
        refreshBtn.TabIndex = 46
        refreshBtn.Text = "Refresh"
        refreshBtn.UseVisualStyleBackColor = True
        ' 
        ' pencari
        ' 
        pencari.Location = New Point(113, 10)
        pencari.Name = "pencari"
        pencari.Size = New Size(371, 23)
        pencari.TabIndex = 45
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(19, 10)
        Label9.Name = "Label9"
        Label9.Size = New Size(78, 21)
        Label9.TabIndex = 44
        Label9.Text = "CARI NIK"
        ' 
        ' simpanBtn
        ' 
        simpanBtn.Cursor = Cursors.Hand
        simpanBtn.Location = New Point(510, 228)
        simpanBtn.Name = "simpanBtn"
        simpanBtn.Size = New Size(75, 23)
        simpanBtn.TabIndex = 21
        simpanBtn.Text = "Simpan"
        simpanBtn.UseVisualStyleBackColor = True
        ' 
        ' updateBtn
        ' 
        updateBtn.Cursor = Cursors.Hand
        updateBtn.Location = New Point(604, 228)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(75, 23)
        updateBtn.TabIndex = 22
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = True
        ' 
        ' deleteBtn
        ' 
        deleteBtn.Cursor = Cursors.Hand
        deleteBtn.Location = New Point(698, 228)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(75, 23)
        deleteBtn.TabIndex = 23
        deleteBtn.Text = "Delete"
        deleteBtn.UseVisualStyleBackColor = True
        ' 
        ' dtpTTL
        ' 
        dtpTTL.Location = New Point(370, 174)
        dtpTTL.Name = "dtpTTL"
        dtpTTL.Size = New Size(121, 23)
        dtpTTL.TabIndex = 24
        ' 
        ' keluarBtn
        ' 
        keluarBtn.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        keluarBtn.Cursor = Cursors.Hand
        keluarBtn.FlatStyle = FlatStyle.Popup
        keluarBtn.Font = New Font("Geometr415 Blk BT", 15.0F)
        keluarBtn.ForeColor = SystemColors.ControlLightLight
        keluarBtn.Location = New Point(0, 405)
        keluarBtn.Name = "keluarBtn"
        keluarBtn.Size = New Size(200, 45)
        keluarBtn.TabIndex = 43
        keluarBtn.Text = "Keluar"
        keluarBtn.UseVisualStyleBackColor = False
        ' 
        ' FormTamu
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dtpTTL)
        Controls.Add(deleteBtn)
        Controls.Add(updateBtn)
        Controls.Add(simpanBtn)
        Controls.Add(Panel4)
        Controls.Add(Label8)
        Controls.Add(textNik)
        Controls.Add(ListView1)
        Controls.Add(textTelepon)
        Controls.Add(textAlamat)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(ComboBoxJenisKelamin)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(textNamaTamu)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FormTamu"
        Text = "FormTamu"
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
    Friend WithEvents textNamaTamu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxJenisKelamin As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents textAlamat As TextBox
    Friend WithEvents textTelepon As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label8 As Label
    Friend WithEvents textNik As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Panel4 As Panel
    Friend WithEvents simpanBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents dtpTTL As DateTimePicker
    Friend WithEvents refreshBtn As Button
    Friend WithEvents pencari As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents keluarBtn As Button
End Class
