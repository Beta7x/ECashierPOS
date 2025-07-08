<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductCard
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        pbProductImage = New Guna.UI2.WinForms.Guna2PictureBox()
        labelProductName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        labelDescription = New Guna.UI2.WinForms.Guna2HtmlLabel()
        labelProductPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(components)
        btnDelete = New Guna.UI2.WinForms.Guna2Button()
        btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        CType(pbProductImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 12
        Guna2Elipse1.TargetControl = Me
        ' 
        ' pbProductImage
        ' 
        pbProductImage.BackColor = Color.White
        pbProductImage.BackgroundImageLayout = ImageLayout.Center
        pbProductImage.BorderRadius = 6
        pbProductImage.CustomizableEdges = CustomizableEdges5
        pbProductImage.Image = My.Resources.Resources.default_image
        pbProductImage.ImageRotate = 0F
        pbProductImage.Location = New Point(16, 14)
        pbProductImage.Name = "pbProductImage"
        pbProductImage.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        pbProductImage.Size = New Size(225, 180)
        pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage
        pbProductImage.TabIndex = 0
        pbProductImage.TabStop = False
        ' 
        ' labelProductName
        ' 
        labelProductName.BackColor = Color.Transparent
        labelProductName.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelProductName.Location = New Point(16, 215)
        labelProductName.Name = "labelProductName"
        labelProductName.Size = New Size(87, 19)
        labelProductName.TabIndex = 1
        labelProductName.Text = "Nama Produk"
        ' 
        ' labelDescription
        ' 
        labelDescription.BackColor = Color.Transparent
        labelDescription.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelDescription.ForeColor = SystemColors.GrayText
        labelDescription.Location = New Point(16, 240)
        labelDescription.MaximumSize = New Size(239, 0)
        labelDescription.Name = "labelDescription"
        labelDescription.Size = New Size(92, 17)
        labelDescription.TabIndex = 1
        labelDescription.TabStop = False
        labelDescription.Text = "Deskripsi produk"
        ' 
        ' labelProductPrice
        ' 
        labelProductPrice.BackColor = Color.Transparent
        labelProductPrice.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelProductPrice.Location = New Point(16, 300)
        labelProductPrice.MaximumSize = New Size(220, 0)
        labelProductPrice.Name = "labelProductPrice"
        labelProductPrice.Size = New Size(33, 19)
        labelProductPrice.TabIndex = 1
        labelProductPrice.Text = "Rp. 0"
        ' 
        ' Guna2Elipse2
        ' 
        Guna2Elipse2.BorderRadius = 8
        Guna2Elipse2.TargetControl = pbProductImage
        ' 
        ' btnDelete
        ' 
        btnDelete.Animated = True
        btnDelete.BorderColor = Color.DarkGray
        btnDelete.BorderRadius = 8
        btnDelete.BorderThickness = 1
        btnDelete.CustomizableEdges = CustomizableEdges3
        btnDelete.DisabledState.BorderColor = Color.DarkGray
        btnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelete.FillColor = Color.Transparent
        btnDelete.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.Transparent
        btnDelete.Image = My.Resources.Resources.delete__1_
        btnDelete.Location = New Point(207, 290)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnDelete.Size = New Size(34, 34)
        btnDelete.TabIndex = 4
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Animated = True
        btnUpdate.BorderColor = Color.DarkGray
        btnUpdate.BorderRadius = 8
        btnUpdate.BorderThickness = 1
        btnUpdate.CustomizableEdges = CustomizableEdges1
        btnUpdate.DisabledState.BorderColor = Color.DarkGray
        btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray
        btnUpdate.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnUpdate.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnUpdate.FillColor = Color.Transparent
        btnUpdate.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.Transparent
        btnUpdate.Image = My.Resources.Resources.pen
        btnUpdate.Location = New Point(162, 290)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnUpdate.Size = New Size(34, 34)
        btnUpdate.TabIndex = 5
        ' 
        ' ProductCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(labelProductPrice)
        Controls.Add(labelDescription)
        Controls.Add(labelProductName)
        Controls.Add(pbProductImage)
        Name = "ProductCard"
        Size = New Size(257, 348)
        CType(pbProductImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pbProductImage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents labelProductName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labelDescription As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labelProductPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button

End Class
