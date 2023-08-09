<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        LblUsername = New Label()
        LblPassword = New Label()
        btnLogin = New Button()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        LblWelcome = New Label()
        lblPasswordError = New Label()
        BtnAddAdmin = New Button()
        SuspendLayout()
        ' 
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        LblUsername.Location = New Point(288, 229)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(124, 31)
        LblUsername.TabIndex = 0
        LblUsername.Text = "Username:"
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        LblPassword.Location = New Point(294, 293)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(118, 31)
        LblPassword.TabIndex = 1
        LblPassword.Text = "Password:"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Black
        btnLogin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.Location = New Point(493, 379)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(102, 42)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtUsername.Location = New Point(418, 235)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(308, 31)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtPassword.Location = New Point(418, 297)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(308, 31)
        txtPassword.TabIndex = 4
        ' 
        ' LblWelcome
        ' 
        LblWelcome.AutoSize = True
        LblWelcome.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        LblWelcome.Location = New Point(377, 146)
        LblWelcome.Name = "LblWelcome"
        LblWelcome.Size = New Size(397, 38)
        LblWelcome.TabIndex = 5
        LblWelcome.Text = "Hi! Welcome to Safari Drives  "
        ' 
        ' lblPasswordError
        ' 
        lblPasswordError.AutoSize = True
        lblPasswordError.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPasswordError.Location = New Point(823, 278)
        lblPasswordError.Name = "lblPasswordError"
        lblPasswordError.Size = New Size(0, 28)
        lblPasswordError.TabIndex = 7
        ' 
        ' BtnAddAdmin
        ' 
        BtnAddAdmin.BackColor = Color.Black
        BtnAddAdmin.Location = New Point(493, 481)
        BtnAddAdmin.Name = "BtnAddAdmin"
        BtnAddAdmin.Size = New Size(94, 29)
        BtnAddAdmin.TabIndex = 8
        BtnAddAdmin.Text = "Sign Up"
        BtnAddAdmin.UseVisualStyleBackColor = False
        BtnAddAdmin.Visible = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1182, 953)
        Controls.Add(BtnAddAdmin)
        Controls.Add(lblPasswordError)
        Controls.Add(LblWelcome)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(btnLogin)
        Controls.Add(LblPassword)
        Controls.Add(LblUsername)
        DoubleBuffered = True
        ForeColor = Color.Transparent
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents LblWelcome As Label
    Friend WithEvents lblPasswordError As Label
    Friend WithEvents BtnAddAdmin As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
