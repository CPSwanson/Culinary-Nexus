<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewAccount))
        Me.txtUN = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.txtVPW = New System.Windows.Forms.TextBox()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblVpassword = New System.Windows.Forms.Label()
        Me.lblUC = New System.Windows.Forms.Label()
        Me.lblPC = New System.Windows.Forms.Label()
        Me.lblSC = New System.Windows.Forms.Label()
        Me.lblVP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUN
        '
        Me.txtUN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUN.BackColor = System.Drawing.Color.White
        Me.txtUN.Location = New System.Drawing.Point(216, 40)
        Me.txtUN.MaxLength = 15
        Me.txtUN.Name = "txtUN"
        Me.txtUN.Size = New System.Drawing.Size(180, 30)
        Me.txtUN.TabIndex = 0
        '
        'txtPW
        '
        Me.txtPW.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPW.Location = New System.Drawing.Point(216, 105)
        Me.txtPW.MaxLength = 15
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(180, 30)
        Me.txtPW.TabIndex = 1
        '
        'txtVPW
        '
        Me.txtVPW.Location = New System.Drawing.Point(216, 170)
        Me.txtVPW.MaxLength = 15
        Me.txtVPW.Name = "txtVPW"
        Me.txtVPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtVPW.Size = New System.Drawing.Size(180, 30)
        Me.txtVPW.TabIndex = 2
        '
        'btnReg
        '
        Me.btnReg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReg.BackColor = System.Drawing.Color.White
        Me.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg.Location = New System.Drawing.Point(126, 235)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(95, 35)
        Me.btnReg.TabIndex = 3
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(276, 235)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 35)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(79, 43)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(97, 22)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(81, 108)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(95, 22)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password:"
        '
        'lblVpassword
        '
        Me.lblVpassword.AutoSize = True
        Me.lblVpassword.Location = New System.Drawing.Point(29, 173)
        Me.lblVpassword.Name = "lblVpassword"
        Me.lblVpassword.Size = New System.Drawing.Size(147, 22)
        Me.lblVpassword.TabIndex = 7
        Me.lblVpassword.Text = "Verify Password:"
        '
        'lblUC
        '
        Me.lblUC.AutoSize = True
        Me.lblUC.Location = New System.Drawing.Point(423, 43)
        Me.lblUC.Name = "lblUC"
        Me.lblUC.Size = New System.Drawing.Size(149, 22)
        Me.lblUC.TabIndex = 8
        Me.lblUC.Text = "8 - 15 characters:"
        '
        'lblPC
        '
        Me.lblPC.AutoSize = True
        Me.lblPC.Location = New System.Drawing.Point(423, 108)
        Me.lblPC.Name = "lblPC"
        Me.lblPC.Size = New System.Drawing.Size(153, 22)
        Me.lblPC.TabIndex = 9
        Me.lblPC.Text = "8 - 15 characters: "
        '
        'lblSC
        '
        Me.lblSC.AutoSize = True
        Me.lblSC.Location = New System.Drawing.Point(422, 151)
        Me.lblSC.Name = "lblSC"
        Me.lblSC.Size = New System.Drawing.Size(154, 44)
        Me.lblSC.TabIndex = 10
        Me.lblSC.Text = "Special character: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(!,@,#,$,%,&)"
        '
        'lblVP
        '
        Me.lblVP.AutoSize = True
        Me.lblVP.Location = New System.Drawing.Point(422, 215)
        Me.lblVP.Name = "lblVP"
        Me.lblVP.Size = New System.Drawing.Size(156, 22)
        Me.lblVP.TabIndex = 11
        Me.lblVP.Text = "Passwords match:"
        '
        'frmNewAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(614, 336)
        Me.Controls.Add(Me.lblVP)
        Me.Controls.Add(Me.lblSC)
        Me.Controls.Add(Me.lblPC)
        Me.Controls.Add(Me.lblUC)
        Me.Controls.Add(Me.lblVpassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.txtVPW)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtUN)
        Me.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmNewAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Register New Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUN As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents txtVPW As TextBox
    Friend WithEvents btnReg As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblVpassword As Label
    Friend WithEvents lblUC As Label
    Friend WithEvents lblPC As Label
    Friend WithEvents lblSC As Label
    Friend WithEvents lblVP As Label
End Class
