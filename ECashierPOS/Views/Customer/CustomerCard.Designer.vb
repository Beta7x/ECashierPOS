<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerCard
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
        lableCustomerName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lablePhoneNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lableCustomerCreatedAt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        labelCustomerAddress = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        btnDelete = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 8
        Guna2Elipse1.TargetControl = Me
        ' 
        ' lableCustomerName
        ' 
        lableCustomerName.BackColor = Color.Transparent
        lableCustomerName.Font = New Font("Segoe UI", 9.75F)
        lableCustomerName.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lableCustomerName.Location = New Point(30, 12)
        lableCustomerName.Name = "lableCustomerName"
        lableCustomerName.Size = New Size(98, 19)
        lableCustomerName.TabIndex = 0
        lableCustomerName.Text = "Nama Customer"
        ' 
        ' lablePhoneNumber
        ' 
        lablePhoneNumber.BackColor = Color.Transparent
        lablePhoneNumber.Font = New Font("Segoe UI", 9.75F)
        lablePhoneNumber.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lablePhoneNumber.Location = New Point(235, 12)
        lablePhoneNumber.Name = "lablePhoneNumber"
        lablePhoneNumber.Size = New Size(87, 19)
        lablePhoneNumber.TabIndex = 1
        lablePhoneNumber.Text = "081122223333"
        ' 
        ' lableCustomerCreatedAt
        ' 
        lableCustomerCreatedAt.BackColor = Color.Transparent
        lableCustomerCreatedAt.Font = New Font("Segoe UI", 9.75F)
        lableCustomerCreatedAt.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lableCustomerCreatedAt.Location = New Point(426, 12)
        lableCustomerCreatedAt.Name = "lableCustomerCreatedAt"
        lableCustomerCreatedAt.Size = New Size(121, 19)
        lableCustomerCreatedAt.TabIndex = 2
        lableCustomerCreatedAt.Text = "2025-06-14 14:41:29"
        ' 
        ' labelCustomerAddress
        ' 
        labelCustomerAddress.BackColor = Color.Transparent
        labelCustomerAddress.Font = New Font("Segoe UI", 9.75F)
        labelCustomerAddress.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        labelCustomerAddress.Location = New Point(615, 12)
        labelCustomerAddress.Name = "labelCustomerAddress"
        labelCustomerAddress.Size = New Size(107, 19)
        labelCustomerAddress.TabIndex = 3
        labelCustomerAddress.Text = "Jakarta, Indonesia"
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
        btnUpdate.Font = New Font("Segoe UI", 9F)
        btnUpdate.ForeColor = Color.DimGray
        btnUpdate.Image = My.Resources.Resources.pen
        btnUpdate.Location = New Point(902, 5)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnUpdate.Size = New Size(34, 34)
        btnUpdate.TabIndex = 4
        ' 
        ' btnDelete
        ' 
        btnDelete.Animated = True
        btnDelete.BorderColor = Color.DarkGray
        btnDelete.BorderRadius = 8
        btnDelete.BorderThickness = 1
        btnDelete.CustomizableEdges = CustomizableEdges1
        btnDelete.DisabledState.BorderColor = Color.DarkGray
        btnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelete.FillColor = Color.Transparent
        btnDelete.Font = New Font("Segoe UI", 9F)
        btnDelete.ForeColor = Color.DimGray
        btnDelete.Image = My.Resources.Resources.delete__1_
        btnDelete.Location = New Point(946, 5)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnDelete.Size = New Size(34, 34)
        btnDelete.TabIndex = 5
        ' 
        ' CustomerCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(labelCustomerAddress)
        Controls.Add(lableCustomerCreatedAt)
        Controls.Add(lablePhoneNumber)
        Controls.Add(lableCustomerName)
        Margin = New Padding(1)
        Name = "CustomerCard"
        Size = New Size(1011, 45)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents labelCustomerAddress As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lableCustomerCreatedAt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lablePhoneNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lableCustomerName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button

End Class
