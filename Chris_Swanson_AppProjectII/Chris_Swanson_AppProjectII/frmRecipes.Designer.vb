<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecipes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecipes))
        Me.flpRecipes = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnMyRecipes = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'flpRecipes
        '
        Me.flpRecipes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpRecipes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpRecipes.Location = New System.Drawing.Point(0, 0)
        Me.flpRecipes.Name = "flpRecipes"
        Me.flpRecipes.Size = New System.Drawing.Size(825, 425)
        Me.flpRecipes.TabIndex = 0
        '
        'btnMyRecipes
        '
        Me.btnMyRecipes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMyRecipes.BackColor = System.Drawing.Color.White
        Me.btnMyRecipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyRecipes.Location = New System.Drawing.Point(186, 470)
        Me.btnMyRecipes.Name = "btnMyRecipes"
        Me.btnMyRecipes.Size = New System.Drawing.Size(105, 55)
        Me.btnMyRecipes.TabIndex = 0
        Me.btnMyRecipes.Text = "My Recipes"
        Me.btnMyRecipes.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpload.BackColor = System.Drawing.Color.White
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Location = New System.Drawing.Point(363, 470)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(100, 55)
        Me.btnUpload.TabIndex = 1
        Me.btnUpload.Text = "Upload Recipe"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.BackColor = System.Drawing.Color.White
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Location = New System.Drawing.Point(538, 470)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(85, 55)
        Me.btnLogOut.TabIndex = 2
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'frmRecipes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(824, 561)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnMyRecipes)
        Me.Controls.Add(Me.flpRecipes)
        Me.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmRecipes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recipes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpRecipes As FlowLayoutPanel
    Friend WithEvents btnMyRecipes As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnLogOut As Button
End Class
