Imports ProcessingVB

Public Class frmMyRecipes
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmMyRecipes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRecipes()
    End Sub

    Public Sub loadRecipes()
        flpRecipes.Visible = False
        flpRecipes.Controls.Clear()

        Dim proc As New Proc
        proc.loadData()

        'Reads in recipes uploaded by logged in user
        For Each row As DataRow In proc.DTRecipes.Rows
            If row(1).ToString = Proc.ID.ToString Then
                Dim recipe As New ucMyRecipe
                recipe._parent = Me
                recipe.rId = Int32.Parse(row(0).ToString)
                recipe.lblTitle.Text = row(2).ToString
                recipe.pbxImage.Image = proc.getImage(recipe.rId)
                recipe.lblViews.Text = $"Views: {row(4).ToString}"
                recipe.lblDownloads.Text = $"Dowanloads: {row(5).ToString}"
                flpRecipes.Controls.Add(recipe)
            End If
        Next

        flpRecipes.Visible = True
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim upload As New frmRUpload
        upload.mRecipes = Me
        upload.ShowDialog()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim _proc As New Proc
        Dim temp As New DataSet("Report")

        temp = _proc.getMyRec()
        temp.Tables(0).TableName = "Recipes"
        temp.WriteXml("..\..\Report.xml", XmlWriteMode.WriteSchema)

        Dim report As New crReport
        Dim save As New SaveFileDialog
        If save.ShowDialog() = DialogResult.OK Then
            report.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, save.FileName + ".pdf")
        End If
    End Sub
End Class