Imports ProcessingVB

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        background.login = Me
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        'Validates user entered credentials
        If Not String.IsNullOrEmpty(txtUN.Text) AndAlso Not String.IsNullOrEmpty(txtPW.Text) Then
            Dim proc As New Proc
            'Checks if login was successful
            If proc.login(txtUN.Text, txtPW.Text) = "Success" Then
                Dim recipes As New frmRecipes
                Proc.Logged = True
                Me.Hide()
                recipes.ShowDialog()
            Else
                MessageBox.Show("Invalid credentials.")
            End If
        Else
            MessageBox.Show("Fill in all credentials.")
        End If
    End Sub

    'Logs user in as guest
    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        Dim recipes As New frmRecipes
        Me.Hide()
        recipes.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        gpbNewAccount.Visible = True
    End Sub

    'Allows user to set up new account
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim good As Boolean = True

        'Verifies user entered all info correctly
        If Not String.IsNullOrEmpty(txtNUN.Text) AndAlso Not String.IsNullOrEmpty(txtNPW.Text) AndAlso Not String.IsNullOrEmpty(txtVPW.Text) Then
            If txtNUN.Text.Length < 8 Then
                If MessageBox.Show("Username must be between 8 - 15 characters long.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning) = DialogResult.OK Then
                    good = False
                    Me.ActiveControl = txtNUN
                End If
            ElseIf txtNPW.Text.Length < 8 Then
                If MessageBox.Show("Password must be between 8 - 15 characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning) = DialogResult.OK Then
                    good = False
                    Me.ActiveControl = txtNPW
                End If
            ElseIf Not System.Text.RegularExpressions.Regex.Match(txtNPW.Text, "[!@#$%&]", System.Text.RegularExpressions.RegexOptions.ECMAScript).Success Then
                If MessageBox.Show("Password must at least one special character: (!,@,#,$,%,&).", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning) = DialogResult.OK Then
                    good = False
                    Me.ActiveControl = txtNPW
                End If
            ElseIf txtNPW.Text = txtVPW.Text = False Then
                If MessageBox.Show("Password do not match.", "Verify Password", MessageBoxButtons.OK, MessageBoxIcon.Warning) = DialogResult.OK Then
                    good = False
                    Me.ActiveControl = txtVPW
                End If
            End If

            'If entered credentials are valid, a new account will attemp to be created.
            If good = True Then
                Dim proc As New Proc
                Dim res As String = proc.newAccount(txtNUN.Text, txtNPW.Text)
                If res = "Registered" Then
                    'Allows the user to proceed as a logged in user
                    If (MessageBox.Show("Account registered.", "Account registration.") = DialogResult.OK) Then
                        Dim recipes As New frmRecipes
                        Proc.Logged = True
                        Me.Hide()
                        recipes.ShowDialog()
                    End If
                Else
                    'Executes if program found an existing account with the entered username
                    MessageBox.Show(res)
                    Me.ActiveControl = txtNUN
                End If
            End If
        Else
            MessageBox.Show("Fill in all credentials.")
        End If
    End Sub

    'Modifies password textboxes to match entry
    Private Sub txtNPW_TextChanged(sender As Object, e As EventArgs) Handles txtNPW.TextChanged
        txtNPW.PasswordChar = "*"
    End Sub

    Private Sub txtVPW_TextChanged(sender As Object, e As EventArgs) Handles txtVPW.TextChanged
        txtVPW.PasswordChar = "*"
    End Sub

    Private Sub txtNPW_Enter(sender As Object, e As EventArgs) Handles txtNPW.Enter
        txtNPW.Clear()
    End Sub

    Private Sub txtVPW_Enter(sender As Object, e As EventArgs) Handles txtVPW.Enter
        txtVPW.Clear()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim about As New frmAbout
        about.ShowDialog()
    End Sub
End Class
