Imports ProcessingVB

Public Class frmRUpload
    Friend mRecipes As frmMyRecipes = Nothing
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim proc As New Proc
        Dim good As Boolean = True

        'Verifies user added all information
        If String.IsNullOrEmpty(txtTitle.Text) OrElse txtTitle.Text.Contains("Title") Then
            MessageBox.Show("Other users need to know what you are sharing. Give your recipe a title.")
            Me.ActiveControl = txtTitle
            good = False
        ElseIf String.IsNullOrEmpty(txtIngredients.Text) OrElse txtIngredients.Text.Contains("Ingredient") Then
            MessageBox.Show("You make anything with nothing. Share the neccessary ingrediens.")
            Me.ActiveControl = txtIngredients
            good = False
        ElseIf String.IsNullOrEmpty(txtDirections.Text) OrElse txtDirections.Text.Contains("Direction") Then
            MessageBox.Show("We are fairly certain your recipe takes a least one step to make.")
            Me.ActiveControl = txtDirections
            good = False
        ElseIf pbxImage.Image Is Nothing Then
            MessageBox.Show("People are less likely to check out a recipe without a picture so be sure to add one!")
            Me.ActiveControl = btnBrowse
            good = False
        ElseIf cbxType.SelectedIndex = -1 Then
            MessageBox.Show("Let everyone know what kind dish your recipe is.")
            Me.ActiveControl = cbxType
            good = False
        End If

        'If entered info checks out, the recipe is uploaded
        If good = True Then
            Dim ingredients As New List(Of String)
            ingredients = txtIngredients.Text.Split(",").ToList

            'Uploads the recipe and then closes the form
            Dim res As String = proc.upload(txtTitle.Text, txtDirections.Text, ingredients, cbxType.SelectedItem.ToString, pbxImage.Image)
            If res = "Uploaded" Then
                'Updates appropriate form's recipe display
                If MessageBox.Show("Recipe Uploaded", "Upload Status") = DialogResult.OK Then
                    If Not mRecipes Is Nothing Then
                        mRecipes.loadRecipes()
                    End If
                    background.recipes.loadRecipes()
                    Me.Close()
                End If
            Else
                MessageBox.Show(res)
            End If
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'Lets user open image for recipe
        Dim open As New OpenFileDialog
        If open.ShowDialog = DialogResult.OK Then
            pbxImage.Image = Image.FromFile(open.FileName)
        End If
    End Sub

    'Selects all text in control to make entry easier
    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.Enter
        txtTitle.SelectAll()
    End Sub

    Private Sub txtIngredients_TextChanged(sender As Object, e As EventArgs) Handles txtIngredients.Enter
        txtIngredients.SelectAll()
    End Sub

    Private Sub txtDirections_TextChanged(sender As Object, e As EventArgs) Handles txtDirections.Enter
        txtDirections.SelectAll()
    End Sub
End Class