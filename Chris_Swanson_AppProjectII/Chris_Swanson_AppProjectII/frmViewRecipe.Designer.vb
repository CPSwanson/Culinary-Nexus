<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewRecipe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewRecipe))
        Me.crvViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'crvViewer
        '
        Me.crvViewer.ActiveViewIndex = -1
        Me.crvViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvViewer.Location = New System.Drawing.Point(0, 0)
        Me.crvViewer.Name = "crvViewer"
        Me.crvViewer.ShowCloseButton = False
        Me.crvViewer.ShowCopyButton = False
        Me.crvViewer.ShowExportButton = False
        Me.crvViewer.ShowGroupTreeButton = False
        Me.crvViewer.ShowLogo = False
        Me.crvViewer.ShowPrintButton = False
        Me.crvViewer.ShowRefreshButton = False
        Me.crvViewer.Size = New System.Drawing.Size(904, 514)
        Me.crvViewer.TabIndex = 0
        Me.crvViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnDownload
        '
        Me.btnDownload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDownload.BackColor = System.Drawing.Color.White
        Me.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownload.Location = New System.Drawing.Point(257, 581)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(114, 39)
        Me.btnDownload.TabIndex = 1
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(537, 581)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 39)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmViewRecipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(904, 661)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.crvViewer)
        Me.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmViewRecipe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Recipe"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnDownload As Button
    Friend WithEvents btnClose As Button
End Class
