Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show
    End Sub
    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub DATAMASTERToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DATAKAMARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAKAMARToolStripMenuItem.Click
        FormKamar.MdiParent = Me
        FormKamar.Show()
    End Sub

    Private Sub DATAPEGAWAIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAPEGAWAIToolStripMenuItem.Click
        FormPegawai.MdiParent = Me
        FormPegawai.Show()
    End Sub

    Private Sub DATATAMUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATATAMUToolStripMenuItem.Click
        FormTamu.MdiParent = Me
        FormTamu.Show()
    End Sub

    Private Sub DATATRANSAKSIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATATRANSAKSIToolStripMenuItem.Click
        FormTransaksi.MdiParent = Me
        FormTransaksi.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
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
End Class
