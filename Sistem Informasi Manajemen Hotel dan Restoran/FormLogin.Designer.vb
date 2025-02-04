<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        usernameBtn = New TextBox()
        passwordBtn = New TextBox()
        Label2 = New Label()
        loginBtn = New Button()
        logoutBtn = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(247, 153)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 28)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' usernameBtn
        ' 
        usernameBtn.Location = New Point(247, 184)
        usernameBtn.Name = "usernameBtn"
        usernameBtn.Size = New Size(277, 23)
        usernameBtn.TabIndex = 1
        ' 
        ' passwordBtn
        ' 
        passwordBtn.Location = New Point(247, 241)
        passwordBtn.Name = "passwordBtn"
        passwordBtn.Size = New Size(277, 23)
        passwordBtn.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(247, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 28)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' loginBtn
        ' 
        loginBtn.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        loginBtn.Cursor = Cursors.Hand
        loginBtn.FlatStyle = FlatStyle.Flat
        loginBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loginBtn.ForeColor = SystemColors.ControlLightLight
        loginBtn.Location = New Point(292, 283)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(187, 34)
        loginBtn.TabIndex = 4
        loginBtn.Text = "Login"
        loginBtn.UseVisualStyleBackColor = False
        ' 
        ' logoutBtn
        ' 
        logoutBtn.BackColor = Color.Maroon
        logoutBtn.Cursor = Cursors.Hand
        logoutBtn.FlatStyle = FlatStyle.Flat
        logoutBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        logoutBtn.ForeColor = SystemColors.ControlLightLight
        logoutBtn.Location = New Point(292, 323)
        logoutBtn.Name = "logoutBtn"
        logoutBtn.Size = New Size(187, 35)
        logoutBtn.TabIndex = 42
        logoutBtn.Text = "Log Out"
        logoutBtn.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Segoe UI Black", 24.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(202, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(406, 92)
        Label3.TabIndex = 43
        Label3.Text = "SISTEM INFORMASI" & vbCrLf & "HOTEL DAN RESTORAN"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Desain_tanpa_judul__1_
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(logoutBtn)
        Controls.Add(loginBtn)
        Controls.Add(Label2)
        Controls.Add(passwordBtn)
        Controls.Add(usernameBtn)
        Controls.Add(Label1)
        Name = "FormLogin"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents usernameBtn As TextBox
    Friend WithEvents passwordBtn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents loginBtn As Button
    Friend WithEvents logoutBtn As Button
    Friend WithEvents Label3 As Label

End Class
