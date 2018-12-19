Imports ProcessingVB

Public Class frmNewAccount
    Dim goodUN As Boolean = False
    Dim goodPW As Boolean = False
    Dim vpw As Boolean = False

    Private Sub txtUN_TextChanged(sender As Object, e As EventArgs) Handles txtUN.TextChanged
        'Verifies username is minimum length
        If txtUN.Text.Length < 8 Then
            lblUC.Text = "8 - 15 characters: X"
            goodUN = False
        Else
            lblUC.Text = $"8 - 15 characters: {ChrW(2714)}"
            goodUN = True
        End If
    End Sub

    Private Sub txtPW_TextChanged(sender As Object, e As EventArgs) Handles txtPW.TextChanged
        Dim check1 As Boolean = False
        Dim check2 As Boolean = False

        'Check1 - Verifies password is minimum length
        If txtPW.Text.Length < 8 Then
            lblPC.Text = "8 - 15 characters: X"
            check1 = False
        Else
            lblPC.Text = $"8 - 15 characters: {ChrW(2714)}"
            check1 = True
        End If

        'Check2 - Verifies password features special character
        If Not System.Text.RegularExpressions.Regex.Match(txtPW.Text, "[!@#$%?&]", System.Text.RegularExpressions.RegexOptions.ECMAScript).Success Then
            lblSC.Text = "Special character: X \n(!,@,#,$,%,&)"
            check2 = False
        Else
            lblSC.Text = "Special character: \u2714 \n(!,@,#,$,%,&)"
            check2 = True
        End If

        'If password meets both requirements, password flag is switched to true
        If check1 = True AndAlso check2 = True Then
            goodPW = True
        Else
            goodPW = False
        End If

    End Sub

    Private Sub txtVPW_TextChanged(sender As Object, e As EventArgs) Handles txtVPW.TextChanged
        If Not txtPW.Text = txtVPW.Text Then
            lblVP.Text = "Passwords match : X"
            vpw = False
        Else
            lblVP.Text = $"Passwords match : {ChrW(2714)}"
            vpw = True
        End If
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        If goodUN = True AndAlso goodPW = True AndAlso vpw = True Then
            Dim proc As New Proc
            If proc.newAccount(txtUN.Text, txtPW.Text) = "Registered" Then
                If MessageBox.Show("Account registered", "Account Registration") = DialogResult.OK Then
                    Proc.Logged = True
                    Me.Close()
                End If
            Else
                MessageBox.Show("There is already an existing account with this username.", "Account Registration")
            End If
        Else
            MessageBox.Show("Not all credentials meet specified criteria.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class