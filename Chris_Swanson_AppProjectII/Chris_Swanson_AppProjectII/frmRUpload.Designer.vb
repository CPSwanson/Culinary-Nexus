<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRUpload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRUpload))
        Me.pbxImage = New System.Windows.Forms.PictureBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtIngredients = New System.Windows.Forms.TextBox()
        Me.txtDirections = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.cbxType = New System.Windows.Forms.ComboBox()
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
        Me.pbxImage.Location = New System.Drawing.Point(39, 35)
        Me.pbxImage.Name = "pbxImage"
        Me.pbxImage.Size = New System.Drawing.Size(250, 250)
        Me.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxImage.TabIndex = 0
        Me.pbxImage.TabStop = False
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTitle.Location = New System.Drawing.Point(320, 35)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(460, 30)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.Text = "Recipe Name"
        '
        'txtIngredients
        '
        Me.txtIngredients.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIngredients.Location = New System.Drawing.Point(320, 80)
        Me.txtIngredients.Multiline = True
        Me.txtIngredients.Name = "txtIngredients"
        Me.txtIngredients.Size = New System.Drawing.Size(460, 75)
        Me.txtIngredients.TabIndex = 2
        Me.txtIngredients.Text = "Ingredient 1 : Amount, Ingredient 2 : Amount, Ingredient 3 : Amount,..."
        '
        'txtDirections
        '
        Me.txtDirections.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDirections.Location = New System.Drawing.Point(320, 185)
        Me.txtDirections.Multiline = True
        Me.txtDirections.Name = "txtDirections"
        Me.txtDirections.Size = New System.Drawing.Size(460, 345)
        Me.txtDirections.TabIndex = 3
        Me.txtDirections.Text = "Directions..."
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.BackColor = System.Drawing.Color.White
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Location = New System.Drawing.Point(107, 304)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(115, 35)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpload.BackColor = System.Drawing.Color.White
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Location = New System.Drawing.Point(495, 545)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(115, 55)
        Me.btnUpload.TabIndex = 5
        Me.btnUpload.Text = "Upload Recipe"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'cbxType
        '
        Me.cbxType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxType.BackColor = System.Drawing.Color.White
        Me.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxType.FormattingEnabled = True
        Me.cbxType.Items.AddRange(New Object() {"Breakfast", "Pastry", "Dessert", "Casserole", "Muffin", "Pasta", "Salad", "Roast", "Curry", "Soup", "BBQ", "Grilled", "Sandwhich", "Stew", "Burger", "Other"})
        Me.cbxType.Location = New System.Drawing.Point(97, 424)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(134, 30)
        Me.cbxType.TabIndex = 7
        '
        'frmRUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(844, 641)
        Me.Controls.Add(Me.cbxType)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtDirections)
        Me.Controls.Add(Me.txtIngredients)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.pbxImage)
        Me.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmRUpload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Upload Recipe"
        CType(Me.pbxImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxImage As PictureBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtIngredients As TextBox
    Friend WithEvents txtDirections As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents cbxType As ComboBox
End Class
