<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CardProduct
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
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        pbProductImage = New Guna.UI2.WinForms.Guna2PictureBox()
        btnAddProduct = New Guna.UI2.WinForms.Guna2Button()
        labelProductName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        labelProductPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(components)
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
        pbProductImage.CustomizableEdges = CustomizableEdges3
        pbProductImage.ErrorImage = My.Resources.Resources.default_image
        pbProductImage.Image = My.Resources.Resources.default_image
        pbProductImage.ImageRotate = 0F
        pbProductImage.Location = New Point(12, 13)
        pbProductImage.Name = "pbProductImage"
        pbProductImage.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        pbProductImage.Size = New Size(209, 143)
        pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage
        pbProductImage.TabIndex = 0
        pbProductImage.TabStop = False
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.BorderRadius = 8
        btnAddProduct.CustomizableEdges = CustomizableEdges1
        btnAddProduct.DisabledState.BorderColor = Color.DarkGray
        btnAddProduct.DisabledState.CustomBorderColor = Color.DarkGray
        btnAddProduct.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAddProduct.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAddProduct.FillColor = Color.FromArgb(CByte(240), CByte(138), CByte(8))
        btnAddProduct.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddProduct.ForeColor = Color.White
        btnAddProduct.Image = My.Resources.Resources.plus__1_
        btnAddProduct.ImageAlign = HorizontalAlignment.Left
        btnAddProduct.ImageOffset = New Point(8, 0)
        btnAddProduct.Location = New Point(12, 237)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnAddProduct.Size = New Size(209, 40)
        btnAddProduct.TabIndex = 1
        btnAddProduct.Text = "Tambah"
        ' 
        ' labelProductName
        ' 
        labelProductName.BackColor = Color.Transparent
        labelProductName.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelProductName.Location = New Point(15, 170)
        labelProductName.Name = "labelProductName"
        labelProductName.Size = New Size(98, 22)
        labelProductName.TabIndex = 2
        labelProductName.Text = "Nama Produk"
        ' 
        ' labelProductPrice
        ' 
        labelProductPrice.BackColor = Color.Transparent
        labelProductPrice.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelProductPrice.ForeColor = SystemColors.ControlDarkDark
        labelProductPrice.Location = New Point(15, 199)
        labelProductPrice.Name = "labelProductPrice"
        labelProductPrice.Size = New Size(59, 19)
        labelProductPrice.TabIndex = 3
        labelProductPrice.Text = "Rp. 15000"
        ' 
        ' Guna2Elipse2
        ' 
        Guna2Elipse2.BorderRadius = 12
        Guna2Elipse2.TargetControl = pbProductImage
        ' 
        ' CardProduct
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        Controls.Add(labelProductPrice)
        Controls.Add(labelProductName)
        Controls.Add(btnAddProduct)
        Controls.Add(pbProductImage)
        Name = "CardProduct"
        Size = New Size(235, 296)
        CType(pbProductImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pbProductImage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnAddProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents labelProductPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labelProductName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse

End Class
