<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMyRecipe
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pbxImage = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblViews = New System.Windows.Forms.Label()
        Me.lblDownloads = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.pbxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxImage
        '
        Me.pbxImage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxImage.BackColor = System.Drawing.Color.White
        Me.pbxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxImage.Location = New System.Drawing.Point(25, 25)
        Me.pbxImage.Name = "pbxImage"
        Me.pbxImage.Size = New System.Drawing.Size(198, 198)
        Me.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxImage.TabIndex = 0
        Me.pbxImage.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(245, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(460, 30)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Recipe Name"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblViews
        '
        Me.lblViews.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblViews.AutoSize = True
        Me.lblViews.Location = New System.Drawing.Point(249, 93)
        Me.lblViews.Name = "lblViews"
        Me.lblViews.Size = New System.Drawing.Size(89, 22)
        Me.lblViews.TabIndex = 2
        Me.lblViews.Text = "Views: 00"
        '
        'lblDownloads
        '
        Me.lblDownloads.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDownloads.AutoSize = True
        Me.lblDownloads.Location = New System.Drawing.Point(575, 93)
        Me.lblDownloads.Name = "lblDownloads"
        Me.lblDownloads.Size = New System.Drawing.Size(133, 22)
        Me.lblDownloads.TabIndex = 3
        Me.lblDownloads.Text = "Downloads: 00"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(419, 125)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 40)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'ucMyRecipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblDownloads)
        Me.Controls.Add(Me.lblViews)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pbxImage)
        Me.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ucMyRecipe"
        Me.Size = New System.Drawing.Size(733, 248)
        CType(Me.pbxImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxImage As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblViews As Label
    Friend WithEvents lblDownloads As Label
    Friend WithEvents btnDelete As Button
End Class
