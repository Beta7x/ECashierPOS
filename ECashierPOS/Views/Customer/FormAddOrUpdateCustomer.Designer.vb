<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddOrUpdateCustomer
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
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtCustomerName = New Guna.UI2.WinForms.Guna2TextBox()
        txtCustomerPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtCustomerAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnCancel = New Guna.UI2.WinForms.Guna2Button()
        btnSave = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 12
        Guna2Elipse1.TargetControl = Me
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Guna2HtmlLabel1.ForeColor = SystemColors.ControlDarkDark
        Guna2HtmlLabel1.Location = New Point(38, 30)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(94, 17)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "Nama Pelanggan"
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.BorderRadius = 8
        txtCustomerName.CustomizableEdges = CustomizableEdges9
        txtCustomerName.DefaultText = ""
        txtCustomerName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtCustomerName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtCustomerName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtCustomerName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtCustomerName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtCustomerName.Font = New Font("Segoe UI", 9.0F)
        txtCustomerName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtCustomerName.Location = New Point(38, 53)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.PlaceholderText = ""
        txtCustomerName.SelectedText = ""
        txtCustomerName.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtCustomerName.Size = New Size(380, 36)
        txtCustomerName.TabIndex = 1
        ' 
        ' txtCustomerPhone
        ' 
        txtCustomerPhone.BorderRadius = 8
        txtCustomerPhone.CustomizableEdges = CustomizableEdges7
        txtCustomerPhone.DefaultText = ""
        txtCustomerPhone.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtCustomerPhone.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtCustomerPhone.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtCustomerPhone.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtCustomerPhone.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtCustomerPhone.Font = New Font("Segoe UI", 9.0F)
        txtCustomerPhone.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtCustomerPhone.Location = New Point(38, 128)
        txtCustomerPhone.Name = "txtCustomerPhone"
        txtCustomerPhone.PlaceholderText = ""
        txtCustomerPhone.SelectedText = ""
        txtCustomerPhone.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtCustomerPhone.Size = New Size(380, 36)
        txtCustomerPhone.TabIndex = 3
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Guna2HtmlLabel2.ForeColor = SystemColors.ControlDarkDark
        Guna2HtmlLabel2.Location = New Point(38, 105)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(87, 17)
        Guna2HtmlLabel2.TabIndex = 2
        Guna2HtmlLabel2.Text = "Nomor Telepon"
        ' 
        ' txtCustomerAddress
        ' 
        txtCustomerAddress.BorderRadius = 8
        txtCustomerAddress.CustomizableEdges = CustomizableEdges5
        txtCustomerAddress.DefaultText = ""
        txtCustomerAddress.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtCustomerAddress.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtCustomerAddress.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtCustomerAddress.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtCustomerAddress.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtCustomerAddress.Font = New Font("Segoe UI", 9.0F)
        txtCustomerAddress.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtCustomerAddress.Location = New Point(38, 205)
        txtCustomerAddress.Multiline = True
        txtCustomerAddress.Name = "txtCustomerAddress"
        txtCustomerAddress.PlaceholderText = ""
        txtCustomerAddress.SelectedText = ""
        txtCustomerAddress.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtCustomerAddress.Size = New Size(380, 190)
        txtCustomerAddress.TabIndex = 1
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Guna2HtmlLabel3.ForeColor = SystemColors.ControlDarkDark
        Guna2HtmlLabel3.Location = New Point(38, 182)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(41, 17)
        Guna2HtmlLabel3.TabIndex = 4
        Guna2HtmlLabel3.Text = "Alamat"
        ' 
        ' btnCancel
        ' 
        btnCancel.Animated = True
        btnCancel.BorderRadius = 8
        btnCancel.CustomizableEdges = CustomizableEdges3
        btnCancel.DisabledState.BorderColor = Color.DarkGray
        btnCancel.DisabledState.CustomBorderColor = Color.DarkGray
        btnCancel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCancel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCancel.FillColor = Color.Gainsboro
        btnCancel.Font = New Font("Segoe UI", 9.0F)
        btnCancel.ForeColor = Color.FromArgb(CByte(240), CByte(138), CByte(8))
        btnCancel.Location = New Point(38, 417)
        btnCancel.Name = "btnCancel"
        btnCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnCancel.Size = New Size(180, 38)
        btnCancel.TabIndex = 6
        btnCancel.Text = "Batal"
        ' 
        ' btnSave
        ' 
        btnSave.Animated = True
        btnSave.BorderRadius = 8
        btnSave.CustomizableEdges = CustomizableEdges1
        btnSave.DisabledState.BorderColor = Color.DarkGray
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray
        btnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSave.FillColor = Color.FromArgb(CByte(240), CByte(138), CByte(8))
        btnSave.Font = New Font("Segoe UI", 9.0F)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(238, 417)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnSave.Size = New Size(180, 38)
        btnSave.TabIndex = 7
        btnSave.Text = "Simpan"
        ' 
        ' FormAddOrUpdateCustomer
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(459, 493)
        Controls.Add(btnSave)
        Controls.Add(btnCancel)
        Controls.Add(txtCustomerAddress)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(txtCustomerPhone)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(txtCustomerName)
        Controls.Add(Guna2HtmlLabel1)
        Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        ForeColor = SystemColors.ControlDarkDark
        FormBorderStyle = FormBorderStyle.None
        Name = "FormAddOrUpdateCustomer"
        Text = "FormAddOrUpdateCustomer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents txtCustomerName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtCustomerPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtCustomerAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
End Class
