<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMyRecipes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMyRecipes))
        Me.flpRecipes = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'flpRecipes
        '
        Me.flpRecipes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpRecipes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpRecipes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpRecipes.Location = New System.Drawing.Point(0, 0)
        Me.flpRecipes.Name = "flpRecipes"
        Me.flpRecipes.Size = New System.Drawing.Size(733, 360)
        Me.flpRecipes.TabIndex = 0
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.White
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Location = New System.Drawing.Point(140, 375)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(115, 65)
        Me.btnUpload.TabIndex = 1
        Me.btnUpload.Text = "Upload Recipe"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(475, 375)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(115, 65)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.White
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Location = New System.Drawing.Point(320, 375)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(94, 65)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "Print Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'frmMyRecipes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.flpRecipes)
        Me.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmMyRecipes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Recipes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpRecipes As FlowLayoutPanel
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReport As Button
End Class
