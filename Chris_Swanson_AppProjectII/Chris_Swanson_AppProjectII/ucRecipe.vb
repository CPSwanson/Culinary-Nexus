Public Class ucRecipe
    Friend rID As Int32
    'Brings up form with crystal report for recipe
    Private Sub ucRecipe_Click(sender As Object, e As EventArgs) Handles pbxImage.Click
        Dim frmRecipe As New frmViewRecipe
        Dim proc As New ProcessingVB.Proc
        frmRecipe.rID = rID
        proc.viewed(rID)
        background.recipes.loadRecipes()
        frmRecipe.ShowDialog()
    End Sub
End Class
