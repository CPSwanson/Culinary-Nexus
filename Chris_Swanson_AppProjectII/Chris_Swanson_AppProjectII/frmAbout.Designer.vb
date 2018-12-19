<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAbout
        '
        Me.lblAbout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAbout.Location = New System.Drawing.Point(13, 13)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(569, 186)
        Me.lblAbout.TabIndex = 0
        Me.lblAbout.Text = resources.GetString("lblAbout.Text")
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(243, 237)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 39)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(594, 318)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblAbout)
        Me.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About Culinary Nexus"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblAbout As Label
    Friend WithEvents btnClose As Button
End Class
