<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRecipe
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
        Me.lblViews = New System.Windows.Forms.Label()
        Me.lblDownloads = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.pbxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxImage
        '
        Me.pbxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxImage.Location = New System.Drawing.Point(45, 15)
        Me.pbxImage.Name = "pbxImage"
        Me.pbxImage.Size = New System.Drawing.Size(130, 130)
        Me.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxImage.TabIndex = 0
        Me.pbxImage.TabStop = False
        '
        'lblViews
        '
        Me.lblViews.AutoSize = True
        Me.lblViews.Location = New System.Drawing.Point(0, 200)
        Me.lblViews.Name = "lblViews"
        Me.lblViews.Size = New System.Drawing.Size(69, 17)
        Me.lblViews.TabIndex = 1
        Me.lblViews.Text = "Views: 00"
        '
        'lblDownloads
        '
        Me.lblDownloads.AutoSize = True
        Me.lblDownloads.Location = New System.Drawing.Point(110, 200)
        Me.lblDownloads.Name = "lblDownloads"
        Me.lblDownloads.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDownloads.Size = New System.Drawing.Size(110, 17)
        Me.lblDownloads.TabIndex = 2
        Me.lblDownloads.Text = "Downloads: 000"
        Me.lblDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(0, 146)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(220, 35)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Label1"
        '
        'ucRecipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblDownloads)
        Me.Controls.Add(Me.lblViews)
        Me.Controls.Add(Me.pbxImage)
        Me.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucRecipe"
        Me.Size = New System.Drawing.Size(218, 218)
        CType(Me.pbxImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxImage As PictureBox
    Friend WithEvents lblViews As Label
    Friend WithEvents lblDownloads As Label
    Friend WithEvents lblTitle As Label
End Class
