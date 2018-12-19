<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblUN = New System.Windows.Forms.Label()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.gpbNewAccount = New System.Windows.Forms.GroupBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtVPW = New System.Windows.Forms.TextBox()
        Me.txtNPW = New System.Windows.Forms.TextBox()
        Me.txtNUN = New System.Windows.Forms.TextBox()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.txtUN = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnGuest = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.gpbNewAccount.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUN
        '
        Me.lblUN.AutoSize = True
        Me.lblUN.Location = New System.Drawing.Point(29, 99)
        Me.lblUN.Name = "lblUN"
        Me.lblUN.Size = New System.Drawing.Size(109, 25)
        Me.lblUN.TabIndex = 0
        Me.lblUN.Text = "Username:"
        '
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.Location = New System.Drawing.Point(29, 152)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(106, 25)
        Me.lblPW.TabIndex = 1
        Me.lblPW.Text = "Password:"
        '
        'gpbNewAccount
        '
        Me.gpbNewAccount.Controls.Add(Me.btnRegister)
        Me.gpbNewAccount.Controls.Add(Me.txtVPW)
        Me.gpbNewAccount.Controls.Add(Me.txtNPW)
        Me.gpbNewAccount.Controls.Add(Me.txtNUN)
        Me.gpbNewAccount.Location = New System.Drawing.Point(385, 99)
        Me.gpbNewAccount.Name = "gpbNewAccount"
        Me.gpbNewAccount.Size = New System.Drawing.Size(242, 222)
        Me.gpbNewAccount.TabIndex = 5
        Me.gpbNewAccount.TabStop = False
        Me.gpbNewAccount.Text = "New Account"
        Me.gpbNewAccount.Visible = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.White
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Location = New System.Drawing.Point(65, 174)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(104, 42)
        Me.btnRegister.TabIndex = 3
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'txtVPW
        '
        Me.txtVPW.Location = New System.Drawing.Point(7, 136)
        Me.txtVPW.MaxLength = 15
        Me.txtVPW.Name = "txtVPW"
        Me.txtVPW.Size = New System.Drawing.Size(229, 32)
        Me.txtVPW.TabIndex = 2
        Me.txtVPW.Text = "Verify Password..."
        '
        'txtNPW
        '
        Me.txtNPW.Location = New System.Drawing.Point(7, 84)
        Me.txtNPW.MaxLength = 15
        Me.txtNPW.Name = "txtNPW"
        Me.txtNPW.Size = New System.Drawing.Size(229, 32)
        Me.txtNPW.TabIndex = 1
        Me.txtNPW.Text = "Password..."
        '
        'txtNUN
        '
        Me.txtNUN.Location = New System.Drawing.Point(7, 32)
        Me.txtNUN.MaxLength = 15
        Me.txtNUN.Name = "txtNUN"
        Me.txtNUN.Size = New System.Drawing.Size(229, 32)
        Me.txtNUN.TabIndex = 0
        Me.txtNUN.Text = "Username..."
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.Location = New System.Drawing.Point(380, 29)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(252, 25)
        Me.lblReg.TabIndex = 3
        Me.lblReg.Text = "New User? Register Today!"
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.White
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Location = New System.Drawing.Point(450, 57)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(96, 36)
        Me.btnSignUp.TabIndex = 4
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'txtUN
        '
        Me.txtUN.Location = New System.Drawing.Point(146, 96)
        Me.txtUN.MaxLength = 15
        Me.txtUN.Name = "txtUN"
        Me.txtUN.Size = New System.Drawing.Size(180, 32)
        Me.txtUN.TabIndex = 0
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(146, 149)
        Me.txtPW.MaxLength = 15
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(180, 32)
        Me.txtPW.TabIndex = 1
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.White
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.Location = New System.Drawing.Point(73, 218)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(99, 34)
        Me.btnLogIn.TabIndex = 2
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'btnGuest
        '
        Me.btnGuest.BackColor = System.Drawing.Color.White
        Me.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuest.Location = New System.Drawing.Point(207, 218)
        Me.btnGuest.Name = "btnGuest"
        Me.btnGuest.Size = New System.Drawing.Size(87, 34)
        Me.btnGuest.TabIndex = 3
        Me.btnGuest.Text = "Guest"
        Me.btnGuest.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(142, 277)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 35)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.White
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(13, 298)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(51, 23)
        Me.btnAbout.TabIndex = 10
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(648, 333)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGuest)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtUN)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.lblReg)
        Me.Controls.Add(Me.gpbNewAccount)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.lblUN)
        Me.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.gpbNewAccount.ResumeLayout(False)
        Me.gpbNewAccount.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUN As Label
    Friend WithEvents lblPW As Label
    Friend WithEvents gpbNewAccount As GroupBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtVPW As TextBox
    Friend WithEvents txtNPW As TextBox
    Friend WithEvents txtNUN As TextBox
    Friend WithEvents lblReg As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents txtUN As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnGuest As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAbout As Button
End Class
