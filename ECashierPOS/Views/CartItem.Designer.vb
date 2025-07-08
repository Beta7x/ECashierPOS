<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartItem
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        pbProductImage = New Guna.UI2.WinForms.Guna2PictureBox()
        labelProductName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        labelProductPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnDecreaseQuantity = New Guna.UI2.WinForms.Guna2Button()
        btnIncreaseQuantity = New Guna.UI2.WinForms.Guna2Button()
        btnDelete = New Guna.UI2.WinForms.Guna2Button()
        txtQuantity = New Guna.UI2.WinForms.Guna2TextBox()
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
        pbProductImage.BorderRadius = 8
        pbProductImage.CustomizableEdges = CustomizableEdges9
        pbProductImage.ErrorImage = My.Resources.Resources.default_image
        pbProductImage.Image = My.Resources.Resources.default_image
        pbProductImage.ImageRotate = 0F
        pbProductImage.InitialImage = My.Resources.Resources.default_image
        pbProductImage.Location = New Point(10, 8)
        pbProductImage.Name = "pbProductImage"
        pbProductImage.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        pbProductImage.Size = New Size(51, 49)
        pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage
        pbProductImage.TabIndex = 0
        pbProductImage.TabStop = False
        ' 
        ' labelProductName
        ' 
        labelProductName.BackColor = Color.Transparent
        labelProductName.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelProductName.Location = New Point(81, 13)
        labelProductName.Name = "labelProductName"
        labelProductName.Size = New Size(87, 19)
        labelProductName.TabIndex = 1
        labelProductName.Text = "Nama Produk"
        ' 
        ' labelProductPrice
        ' 
        labelProductPrice.BackColor = Color.Transparent
        labelProductPrice.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelProductPrice.ForeColor = SystemColors.ControlDarkDark
        labelProductPrice.Location = New Point(81, 34)
        labelProductPrice.Name = "labelProductPrice"
        labelProductPrice.Size = New Size(56, 17)
        labelProductPrice.TabIndex = 2
        labelProductPrice.Text = "Rp. 15000"
        ' 
        ' btnDecreaseQuantity
        ' 
        btnDecreaseQuantity.Animated = True
        btnDecreaseQuantity.BorderColor = Color.DarkGray
        btnDecreaseQuantity.BorderRadius = 8
        btnDecreaseQuantity.BorderThickness = 1
        btnDecreaseQuantity.CustomizableEdges = CustomizableEdges7
        btnDecreaseQuantity.DisabledState.BorderColor = Color.DarkGray
        btnDecreaseQuantity.DisabledState.CustomBorderColor = Color.DarkGray
        btnDecreaseQuantity.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDecreaseQuantity.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDecreaseQuantity.FillColor = Color.Transparent
        btnDecreaseQuantity.Font = New Font("Segoe UI", 9F)
        btnDecreaseQuantity.ForeColor = Color.DimGray
        btnDecreaseQuantity.Image = My.Resources.Resources.pen
        btnDecreaseQuantity.Location = New Point(211, 17)
        btnDecreaseQuantity.Name = "btnDecreaseQuantity"
        btnDecreaseQuantity.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnDecreaseQuantity.Size = New Size(34, 34)
        btnDecreaseQuantity.TabIndex = 5
        ' 
        ' btnIncreaseQuantity
        ' 
        btnIncreaseQuantity.Animated = True
        btnIncreaseQuantity.BorderColor = Color.DarkGray
        btnIncreaseQuantity.BorderRadius = 8
        btnIncreaseQuantity.BorderThickness = 1
        btnIncreaseQuantity.CustomizableEdges = CustomizableEdges5
        btnIncreaseQuantity.DisabledState.BorderColor = Color.DarkGray
        btnIncreaseQuantity.DisabledState.CustomBorderColor = Color.DarkGray
        btnIncreaseQuantity.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnIncreaseQuantity.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnIncreaseQuantity.FillColor = Color.Transparent
        btnIncreaseQuantity.Font = New Font("Segoe UI", 9F)
        btnIncreaseQuantity.ForeColor = Color.DimGray
        btnIncreaseQuantity.Image = My.Resources.Resources.pen
        btnIncreaseQuantity.Location = New Point(304, 17)
        btnIncreaseQuantity.Name = "btnIncreaseQuantity"
        btnIncreaseQuantity.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnIncreaseQuantity.Size = New Size(34, 34)
        btnIncreaseQuantity.TabIndex = 6
        ' 
        ' btnDelete
        ' 
        btnDelete.Animated = True
        btnDelete.BorderColor = Color.DarkGray
        btnDelete.BorderRadius = 8
        btnDelete.CustomizableEdges = CustomizableEdges3
        btnDelete.DisabledState.BorderColor = Color.DarkGray
        btnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelete.FillColor = Color.Transparent
        btnDelete.Font = New Font("Segoe UI", 9F)
        btnDelete.ForeColor = Color.DimGray
        btnDelete.Image = My.Resources.Resources.delete__1_
        btnDelete.Location = New Point(351, 17)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnDelete.Size = New Size(34, 34)
        btnDelete.TabIndex = 7
        ' 
        ' txtQuantity
        ' 
        txtQuantity.BorderColor = Color.Transparent
        txtQuantity.BorderRadius = 8
        txtQuantity.BorderThickness = 0
        txtQuantity.CustomizableEdges = CustomizableEdges1
        txtQuantity.DefaultText = "1"
        txtQuantity.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtQuantity.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtQuantity.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtQuantity.FillColor = SystemColors.Control
        txtQuantity.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtQuantity.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtQuantity.ForeColor = Color.Black
        txtQuantity.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtQuantity.Location = New Point(254, 17)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.PlaceholderText = ""
        txtQuantity.SelectedText = ""
        txtQuantity.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtQuantity.Size = New Size(40, 34)
        txtQuantity.TabIndex = 8
        txtQuantity.TextAlign = HorizontalAlignment.Center
        ' 
        ' CartItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        Controls.Add(txtQuantity)
        Controls.Add(btnDelete)
        Controls.Add(btnIncreaseQuantity)
        Controls.Add(btnDecreaseQuantity)
        Controls.Add(labelProductPrice)
        Controls.Add(labelProductName)
        Controls.Add(pbProductImage)
        Name = "CartItem"
        Size = New Size(411, 68)
        CType(pbProductImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pbProductImage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents labelProductPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labelProductName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnDecreaseQuantity As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnIncreaseQuantity As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button

End Class
