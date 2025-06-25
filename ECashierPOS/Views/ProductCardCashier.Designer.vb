<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductCardCashier
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductCardCashier))
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        labelProductPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        labelProductName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        pbProductImage = New Guna.UI2.WinForms.Guna2PictureBox()
        labelDescription = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnAddToCart = New Guna.UI2.WinForms.Guna2Button()
        CType(pbProductImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 12
        Guna2Elipse1.TargetControl = Me
        ' 
        ' labelProductPrice
        ' 
        labelProductPrice.BackColor = Color.Transparent
        labelProductPrice.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelProductPrice.Location = New Point(17, 292)
        labelProductPrice.MaximumSize = New Size(220, 0)
        labelProductPrice.Name = "labelProductPrice"
        labelProductPrice.Size = New Size(62, 19)
        labelProductPrice.TabIndex = 3
        labelProductPrice.Text = "Rp. 15.000"
        ' 
        ' labelProductName
        ' 
        labelProductName.BackColor = Color.Transparent
        labelProductName.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelProductName.Location = New Point(17, 218)
        labelProductName.Name = "labelProductName"
        labelProductName.Size = New Size(87, 19)
        labelProductName.TabIndex = 5
        labelProductName.Text = "Nama Produk"
        ' 
        ' pbProductImage
        ' 
        pbProductImage.BackColor = Color.White
        pbProductImage.BackgroundImageLayout = ImageLayout.Center
        pbProductImage.BorderRadius = 6
        pbProductImage.CustomizableEdges = CustomizableEdges3
        pbProductImage.Image = CType(resources.GetObject("pbProductImage.Image"), Image)
        pbProductImage.ImageRotate = 0F
        pbProductImage.Location = New Point(17, 17)
        pbProductImage.Name = "pbProductImage"
        pbProductImage.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        pbProductImage.Size = New Size(239, 183)
        pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage
        pbProductImage.TabIndex = 2
        pbProductImage.TabStop = False
        ' 
        ' labelDescription
        ' 
        labelDescription.BackColor = Color.Transparent
        labelDescription.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelDescription.ForeColor = SystemColors.GrayText
        labelDescription.Location = New Point(17, 243)
        labelDescription.MaximumSize = New Size(239, 0)
        labelDescription.Name = "labelDescription"
        labelDescription.Size = New Size(239, 32)
        labelDescription.TabIndex = 4
        labelDescription.TabStop = False
        labelDescription.Text = "Deskripsi text asdasdadasdasdasdasdasdasdsaddasdasdsadasd"
        ' 
        ' btnAddToCart
        ' 
        btnAddToCart.Animated = True
        btnAddToCart.BorderColor = Color.Transparent
        btnAddToCart.BorderRadius = 8
        btnAddToCart.BorderThickness = 1
        btnAddToCart.CustomizableEdges = CustomizableEdges1
        btnAddToCart.DisabledState.BorderColor = Color.DarkGray
        btnAddToCart.DisabledState.CustomBorderColor = Color.DarkGray
        btnAddToCart.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAddToCart.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAddToCart.FillColor = Color.FromArgb(CByte(241), CByte(137), CByte(10))
        btnAddToCart.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddToCart.ForeColor = Color.White
        btnAddToCart.Image = My.Resources.Resources.plus__1_
        btnAddToCart.ImageAlign = HorizontalAlignment.Left
        btnAddToCart.ImageSize = New Size(15, 15)
        btnAddToCart.Location = New Point(129, 288)
        btnAddToCart.Name = "btnAddToCart"
        btnAddToCart.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnAddToCart.Size = New Size(127, 34)
        btnAddToCart.TabIndex = 6
        btnAddToCart.Text = "Tambah"
        ' 
        ' ProductCardCashier
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnAddToCart)
        Controls.Add(labelProductPrice)
        Controls.Add(labelDescription)
        Controls.Add(labelProductName)
        Controls.Add(pbProductImage)
        Name = "ProductCardCashier"
        Size = New Size(272, 336)
        CType(pbProductImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents labelProductPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labelDescription As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labelProductName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pbProductImage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnAddToCart As Guna.UI2.WinForms.Guna2Button

End Class
