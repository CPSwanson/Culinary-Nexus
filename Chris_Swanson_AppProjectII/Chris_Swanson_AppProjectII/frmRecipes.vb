Imports ProcessingVB
Imports System.Threading

Public Class frmRecipes
    Dim _exit As Boolean = True

    Public Sub loadRecipes()

        flpRecipes.Visible = False
        flpRecipes.Controls.Clear()

        Dim proc As New Proc
        proc.loadData()

        'Reads in and displays all uploaded recipes
        For Each row As DataRow In Proc.DTRecipes.Rows
            Dim recipe As New ucRecipe
            recipe.rID = Int32.Parse(row(0).ToString)
            recipe.lblTitle.Text = row(2).ToString
            recipe.pbxImage.Image = proc.getImage(Int32.Parse(row(0).ToString))
            recipe.lblViews.Text = $"Views: {row(4).ToString}"
            recipe.lblDownloads.Text = $"Downloads: {row(5).ToString}"
            flpRecipes.Controls.Add(recipe)
        Next

        flpRecipes.Visible = True
    End Sub

    Private Sub frmRecipes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        background.recipes = Me
        Dim loading As New frmLoading

        loading.Show()
        loadRecipes()
        My.Computer.Audio.Play(My.Resources.music, AudioPlayMode.BackgroundLoop)
        loading.Close()

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        'Checks if user is logged in
        If Not Proc.Logged = True Then
            Dim res As DialogResult = MessageBox.Show("You must be logged in to upload a recipe. Would you like to set up a account?", "Access Restricted", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'Allows user to create a new account
            If res = DialogResult.Yes Then
                Dim newAcc As New frmNewAccount
                newAcc.ShowDialog()
            End If
        Else
            Dim upload As New frmRUpload
            upload.ShowDialog()
        End If
    End Sub

    Private Sub frmRecipes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Computer.Audio.Stop()

        'Warns user they are about to close the app and let's them cancel
        If _exit = True Then
            Dim res As DialogResult = MessageBox.Show("You are about to close the application. Are you sure you wish to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If res = DialogResult.Yes Then
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    'Sends user back to log in screen
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        _exit = False
        Proc.Logged = False
        background.login.Show()
        Me.Close()
    End Sub

    Private Sub btnMyRecipes_Click(sender As Object, e As EventArgs) Handles btnMyRecipes.Click
        'Checks if user is logged in
        If Not Proc.Logged = True Then
            Dim res As DialogResult = MessageBox.Show("You must be logged in to view your recipes. Would you like to set up a account?", "Access Restricted", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'Allows user to create a new account
            If res = DialogResult.Yes Then
                Dim newAcc As New frmNewAccount
                newAcc.ShowDialog()
            End If
        Else
            Dim mRecipes As New frmMyRecipes
            mRecipes.ShowDialog()
        End If
    End Sub
End Class