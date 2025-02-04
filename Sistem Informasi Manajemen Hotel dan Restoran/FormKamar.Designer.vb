<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKamar
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
        Label1 = New Label()
        Panel1 = New Panel()
        transaksiBtnKamar = New Button()
        pegawaiBtnKamar = New Button()
        tamuBtnKamar = New Button()
        kamarBtnKamar = New Button()
        Panel2 = New Panel()
        Label4 = New Label()
        deleteBtnKamar = New Button()
        updateBtnKamar = New Button()
        simpanBtnKamar = New Button()
        Panel4 = New Panel()
        refreshBtnKamar = New Button()
        pencari = New TextBox()
        Label3 = New Label()
        Label8 = New Label()
        TextKodeKamar = New TextBox()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        TextTarif = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        ComboBoxKelas = New ComboBox()
        Label5 = New Label()
        Label2 = New Label()
        TextNamaKamar = New TextBox()
        ComboBoxStatus = New ComboBox()
        keluarBtn = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Geometr415 Blk BT", 25F)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(10, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 41)
        Label1.TabIndex = 0
        Label1.Text = "Dashboard"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(5), CByte(25), CByte(30))
        Panel1.Controls.Add(keluarBtn)
        Panel1.Controls.Add(transaksiBtnKamar)
        Panel1.Controls.Add(pegawaiBtnKamar)
        Panel1.Controls.Add(tamuBtnKamar)
        Panel1.Controls.Add(kamarBtnKamar)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 450)
        Panel1.TabIndex = 3
        ' 
        ' transaksiBtnKamar
        ' 
        transaksiBtnKamar.BackColor = Color.Transparent
        transaksiBtnKamar.Cursor = Cursors.Hand
        transaksiBtnKamar.FlatAppearance.BorderColor = Color.Black
        transaksiBtnKamar.FlatAppearance.BorderSize = 0
        transaksiBtnKamar.FlatAppearance.MouseDownBackColor = Color.Transparent
        transaksiBtnKamar.FlatStyle = FlatStyle.Flat
        transaksiBtnKamar.Font = New Font("Geometr415 Blk BT", 20F)
        transaksiBtnKamar.ForeColor = SystemColors.ControlLightLight
        transaksiBtnKamar.Location = New Point(0, 225)
        transaksiBtnKamar.Name = "transaksiBtnKamar"
        transaksiBtnKamar.Size = New Size(200, 37)
        transaksiBtnKamar.TabIndex = 10
        transaksiBtnKamar.Text = "Transaksi"
        transaksiBtnKamar.UseVisualStyleBackColor = False
        ' 
        ' pegawaiBtnKamar
        ' 
        pegawaiBtnKamar.BackColor = Color.Transparent
        pegawaiBtnKamar.Cursor = Cursors.Hand
        pegawaiBtnKamar.FlatAppearance.BorderColor = Color.Black
        pegawaiBtnKamar.FlatAppearance.BorderSize = 0
        pegawaiBtnKamar.FlatAppearance.MouseDownBackColor = Color.Transparent
        pegawaiBtnKamar.FlatStyle = FlatStyle.Flat
        pegawaiBtnKamar.Font = New Font("Geometr415 Blk BT", 20F)
        pegawaiBtnKamar.ForeColor = SystemColors.ControlLightLight
        pegawaiBtnKamar.Location = New Point(0, 171)
        pegawaiBtnKamar.Name = "pegawaiBtnKamar"
        pegawaiBtnKamar.Size = New Size(200, 48)
        pegawaiBtnKamar.TabIndex = 9
        pegawaiBtnKamar.Text = "Pegawai"
        pegawaiBtnKamar.UseVisualStyleBackColor = False
        ' 
        ' tamuBtnKamar
        ' 
        tamuBtnKamar.BackColor = Color.Transparent
        tamuBtnKamar.Cursor = Cursors.Hand
        tamuBtnKamar.FlatAppearance.BorderColor = Color.Black
        tamuBtnKamar.FlatAppearance.BorderSize = 0
        tamuBtnKamar.FlatAppearance.MouseDownBackColor = Color.Transparent
        tamuBtnKamar.FlatStyle = FlatStyle.Flat
        tamuBtnKamar.Font = New Font("Geometr415 Blk BT", 20F)
        tamuBtnKamar.ForeColor = SystemColors.ControlLightLight
        tamuBtnKamar.Location = New Point(0, 128)
        tamuBtnKamar.Name = "tamuBtnKamar"
        tamuBtnKamar.Size = New Size(200, 37)
        tamuBtnKamar.TabIndex = 8
        tamuBtnKamar.Text = "Tamu"
        tamuBtnKamar.UseVisualStyleBackColor = False
        ' 
        ' kamarBtnKamar
        ' 
        kamarBtnKamar.BackColor = Color.Transparent
        kamarBtnKamar.Cursor = Cursors.Hand
        kamarBtnKamar.FlatAppearance.BorderColor = Color.Black
        kamarBtnKamar.FlatAppearance.BorderSize = 0
        kamarBtnKamar.FlatAppearance.MouseDownBackColor = Color.Transparent
        kamarBtnKamar.FlatStyle = FlatStyle.Flat
        kamarBtnKamar.Font = New Font("Geometr415 Blk BT", 20.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        kamarBtnKamar.ForeColor = SystemColors.ControlLightLight
        kamarBtnKamar.Location = New Point(0, 77)
        kamarBtnKamar.Name = "kamarBtnKamar"
        kamarBtnKamar.Size = New Size(200, 37)
        kamarBtnKamar.TabIndex = 7
        kamarBtnKamar.Text = "Kamar"
        kamarBtnKamar.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(200, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(600, 55)
        Panel2.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Geometr415 Blk BT", 30F)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(230, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 48)
        Label4.TabIndex = 11
        Label4.Text = "Kamar"
        ' 
        ' deleteBtnKamar
        ' 
        deleteBtnKamar.Cursor = Cursors.Hand
        deleteBtnKamar.Location = New Point(698, 228)
        deleteBtnKamar.Name = "deleteBtnKamar"
        deleteBtnKamar.Size = New Size(75, 23)
        deleteBtnKamar.TabIndex = 40
        deleteBtnKamar.Text = "Delete"
        deleteBtnKamar.UseVisualStyleBackColor = True
        ' 
        ' updateBtnKamar
        ' 
        updateBtnKamar.Cursor = Cursors.Hand
        updateBtnKamar.Location = New Point(604, 228)
        updateBtnKamar.Name = "updateBtnKamar"
        updateBtnKamar.Size = New Size(75, 23)
        updateBtnKamar.TabIndex = 39
        updateBtnKamar.Text = "Update"
        updateBtnKamar.UseVisualStyleBackColor = True
        ' 
        ' simpanBtnKamar
        ' 
        simpanBtnKamar.Cursor = Cursors.Hand
        simpanBtnKamar.Location = New Point(510, 228)
        simpanBtnKamar.Name = "simpanBtnKamar"
        simpanBtnKamar.Size = New Size(75, 23)
        simpanBtnKamar.TabIndex = 38
        simpanBtnKamar.Text = "Simpan"
        simpanBtnKamar.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaption
        Panel4.Controls.Add(refreshBtnKamar)
        Panel4.Controls.Add(pencari)
        Panel4.Controls.Add(Label3)
        Panel4.Location = New Point(200, 263)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(600, 42)
        Panel4.TabIndex = 37
        ' 
        ' refreshBtnKamar
        ' 
        refreshBtnKamar.Cursor = Cursors.Hand
        refreshBtnKamar.Location = New Point(508, 9)
        refreshBtnKamar.Name = "refreshBtnKamar"
        refreshBtnKamar.Size = New Size(75, 23)
        refreshBtnKamar.TabIndex = 46
        refreshBtnKamar.Text = "Refresh"
        refreshBtnKamar.UseVisualStyleBackColor = True
        ' 
        ' pencari
        ' 
        pencari.Location = New Point(185, 9)
        pencari.Name = "pencari"
        pencari.Size = New Size(299, 23)
        pencari.TabIndex = 45
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 21)
        Label3.TabIndex = 44
        Label3.Text = "CARI KODE KAMAR"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(234, 90)
        Label8.Name = "Label8"
        Label8.Size = New Size(71, 15)
        Label8.TabIndex = 36
        Label8.Text = "Kode Kamar"
        ' 
        ' TextKodeKamar
        ' 
        TextKodeKamar.Location = New Point(370, 87)
        TextKodeKamar.Name = "TextKodeKamar"
        TextKodeKamar.Size = New Size(121, 23)
        TextKodeKamar.TabIndex = 35
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader6})
        ListView1.Location = New Point(200, 304)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(600, 146)
        ListView1.TabIndex = 34
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Kode Kamar"
        ColumnHeader1.Width = 80
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Nama Kamar"
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Kelas"
        ColumnHeader3.Width = 80
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Tarif"
        ColumnHeader4.Width = 80
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Status"
        ColumnHeader6.Width = 80
        ' 
        ' TextTarif
        ' 
        TextTarif.Enabled = False
        TextTarif.Location = New Point(652, 132)
        TextTarif.Name = "TextTarif"
        TextTarif.Size = New Size(121, 23)
        TextTarif.TabIndex = 32
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(234, 177)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 30
        Label7.Text = "Status"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(516, 135)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 15)
        Label6.TabIndex = 29
        Label6.Text = "Tarif"
        ' 
        ' ComboBoxKelas
        ' 
        ComboBoxKelas.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxKelas.FormattingEnabled = True
        ComboBoxKelas.Items.AddRange(New Object() {"Regular", "VIP"})
        ComboBoxKelas.Location = New Point(652, 87)
        ComboBoxKelas.Name = "ComboBoxKelas"
        ComboBoxKelas.Size = New Size(121, 23)
        ComboBoxKelas.TabIndex = 28
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(516, 91)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 15)
        Label5.TabIndex = 27
        Label5.Text = "Kelas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(234, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 25
        Label2.Text = "Nama Kamar"
        ' 
        ' TextNamaKamar
        ' 
        TextNamaKamar.Location = New Point(370, 129)
        TextNamaKamar.Name = "TextNamaKamar"
        TextNamaKamar.Size = New Size(121, 23)
        TextNamaKamar.TabIndex = 24
        ' 
        ' ComboBoxStatus
        ' 
        ComboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxStatus.FormattingEnabled = True
        ComboBoxStatus.Items.AddRange(New Object() {"Terisi", "Kosong"})
        ComboBoxStatus.Location = New Point(370, 174)
        ComboBoxStatus.Name = "ComboBoxStatus"
        ComboBoxStatus.Size = New Size(121, 23)
        ComboBoxStatus.TabIndex = 41
        ' 
        ' keluarBtn
        ' 
        keluarBtn.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        keluarBtn.Cursor = Cursors.Hand
        keluarBtn.FlatStyle = FlatStyle.Popup
        keluarBtn.Font = New Font("Geometr415 Blk BT", 15F)
        keluarBtn.ForeColor = SystemColors.ControlLightLight
        keluarBtn.Location = New Point(0, 405)
        keluarBtn.Name = "keluarBtn"
        keluarBtn.Size = New Size(200, 45)
        keluarBtn.TabIndex = 43
        keluarBtn.Text = "Keluar"
        keluarBtn.UseVisualStyleBackColor = False
        ' 
        ' FormKamar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ComboBoxStatus)
        Controls.Add(deleteBtnKamar)
        Controls.Add(updateBtnKamar)
        Controls.Add(simpanBtnKamar)
        Controls.Add(Panel4)
        Controls.Add(Label8)
        Controls.Add(TextKodeKamar)
        Controls.Add(ListView1)
        Controls.Add(TextTarif)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(ComboBoxKelas)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(TextNamaKamar)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FormKamar"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents kamarBtnKamar As Button
    Friend WithEvents transaksiBtnKamar As Button
    Friend WithEvents pegawaiBtnKamar As Button
    Friend WithEvents tamuBtnKamar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents deleteBtnKamar As Button
    Friend WithEvents updateBtnKamar As Button
    Friend WithEvents simpanBtnKamar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TextKodeKamar As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents TextTarif As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxKelas As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextNamaKamar As TextBox
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents refreshBtnKamar As Button
    Friend WithEvents pencari As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents keluarBtn As Button
End Class
