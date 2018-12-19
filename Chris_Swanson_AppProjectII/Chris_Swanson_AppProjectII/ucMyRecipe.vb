Imports ProcessingVB

Public Class ucMyRecipe
    Friend _parent As frmMyRecipes
    Friend rId As Int32
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim proc As New Proc
        Dim res As String = proc.deleteRecipe(rId)
        If res = "Deleted" Then
            _parent.loadRecipes()
            background.recipes.loadRecipes()
        End If
    End Sub
End Class
