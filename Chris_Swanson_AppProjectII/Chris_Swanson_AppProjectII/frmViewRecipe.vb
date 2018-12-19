Imports ProcessingVB

Public Class frmViewRecipe
    Friend rID As Int32

    Private Sub frmViewRecipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim proc As New Proc

        Try
            Dim dsRecipe As New DataSet
            dsRecipe = proc.getRec(rID)
            dsRecipe.DataSetName = "Recipe"
            dsRecipe.Tables(0).TableName = "Recipe"
            dsRecipe.WriteXml("..\..\Recipe.xml")

            Dim dsIng As New DataSet
            dsIng = proc.getIng(rID)
            dsIng.DataSetName = "Ingredients"
            dsIng.Tables(0).TableName = "Ingredient"
            dsIng.WriteXml("..\..\Ingredients.xml")

            Dim recipe As New crRecipe
            recipe.Refresh()
            crvViewer.ReportSource = recipe

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Dim proc As New Proc
        proc.downloaded(rID)

        Dim save As New SaveFileDialog
        If save.ShowDialog() = DialogResult.OK Then
            Dim recipe As crRecipe = crvViewer.ReportSource
            recipe.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, save.FileName + ".pdf")
        End If
    End Sub
End Class