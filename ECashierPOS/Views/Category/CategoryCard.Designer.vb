<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoryCard))
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblContent = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnItem = New Guna.UI2.WinForms.Guna2Button()
        btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblCreatedAt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.TargetControl = Me
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Black
        lblTitle.Location = New Point(22, 16)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(66, 23)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Kategori"
        ' 
        ' lblContent
        ' 
        lblContent.BackColor = Color.Transparent
        lblContent.Location = New Point(22, 51)
        lblContent.MaximumSize = New Size(220, 0)
        lblContent.Name = "lblContent"
        lblContent.Size = New Size(220, 107)
        lblContent.TabIndex = 1
        lblContent.Text = resources.GetString("lblContent.Text")
        ' 
        ' btnItem
        ' 
        btnItem.Animated = True
        btnItem.BorderRadius = 8
        btnItem.CustomizableEdges = CustomizableEdges5
        btnItem.DisabledState.BorderColor = Color.DarkGray
        btnItem.DisabledState.CustomBorderColor = Color.DarkGray
        btnItem.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnItem.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnItem.FillColor = Color.FromArgb(CByte(241), CByte(137), CByte(10))
        btnItem.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnItem.ForeColor = Color.White
        btnItem.Location = New Point(22, 223)
        btnItem.Name = "btnItem"
        btnItem.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnItem.Size = New Size(130, 34)
        btnItem.TabIndex = 2
        btnItem.Text = "Item 125"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Animated = True
        btnUpdate.BorderColor = Color.DarkGray
        btnUpdate.BorderRadius = 8
        btnUpdate.BorderThickness = 1
        btnUpdate.CustomizableEdges = CustomizableEdges3
        btnUpdate.DisabledState.BorderColor = Color.DarkGray
        btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray
        btnUpdate.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnUpdate.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnUpdate.FillColor = Color.Transparent
        btnUpdate.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.Transparent
        btnUpdate.Image = My.Resources.Resources.pen
        btnUpdate.Location = New Point(158, 223)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnUpdate.Size = New Size(34, 34)
        btnUpdate.TabIndex = 3
        ' 
        ' btnDelete
        ' 
        btnDelete.Animated = True
        btnDelete.BackColor = Color.Transparent
        btnDelete.BorderColor = Color.DarkGray
        btnDelete.BorderRadius = 8
        btnDelete.BorderThickness = 1
        btnDelete.CustomizableEdges = CustomizableEdges1
        btnDelete.DisabledState.BorderColor = Color.DarkGray
        btnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelete.FillColor = Color.Transparent
        btnDelete.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.Transparent
        btnDelete.Image = My.Resources.Resources.delete__1_
        btnDelete.Location = New Point(199, 223)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnDelete.Size = New Size(34, 34)
        btnDelete.TabIndex = 4
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel3.Location = New Point(19, 161)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(121, 19)
        Guna2HtmlLabel3.TabIndex = 5
        Guna2HtmlLabel3.Text = "Ditambahkan pada:"
        ' 
        ' lblCreatedAt
        ' 
        lblCreatedAt.BackColor = Color.Transparent
        lblCreatedAt.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCreatedAt.ForeColor = SystemColors.ControlDarkDark
        lblCreatedAt.Location = New Point(19, 184)
        lblCreatedAt.Name = "lblCreatedAt"
        lblCreatedAt.Size = New Size(67, 19)
        lblCreatedAt.TabIndex = 6
        lblCreatedAt.Text = "12-04-2025"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderColor = SystemColors.ScrollBar
        Guna2Panel1.BorderRadius = 8
        Guna2Panel1.BorderThickness = 1
        Guna2Panel1.Controls.Add(Guna2HtmlLabel3)
        Guna2Panel1.Controls.Add(lblCreatedAt)
        Guna2Panel1.CustomizableEdges = CustomizableEdges7
        Guna2Panel1.Location = New Point(3, 3)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel1.Size = New Size(248, 277)
        Guna2Panel1.TabIndex = 7
        ' 
        ' CategoryCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnItem)
        Controls.Add(lblContent)
        Controls.Add(lblTitle)
        Controls.Add(Guna2Panel1)
        Name = "CategoryCard"
        Size = New Size(254, 283)
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblContent As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnItem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCreatedAt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel

End Class
