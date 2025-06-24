<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddOrUpdateCategory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        txtCategoryName = New Guna.UI2.WinForms.Guna2TextBox()
        txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnCancel = New Guna.UI2.WinForms.Guna2Button()
        btnSave = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 12
        Guna2Elipse1.TargetControl = Me
        ' 
        ' txtCategoryName
        ' 
        txtCategoryName.BorderRadius = 8
        txtCategoryName.CustomizableEdges = CustomizableEdges7
        txtCategoryName.DefaultText = ""
        txtCategoryName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtCategoryName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtCategoryName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtCategoryName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtCategoryName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtCategoryName.Font = New Font("Segoe UI", 9.0F)
        txtCategoryName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtCategoryName.Location = New Point(38, 53)
        txtCategoryName.Name = "txtCategoryName"
        txtCategoryName.PlaceholderText = ""
        txtCategoryName.SelectedText = ""
        txtCategoryName.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtCategoryName.Size = New Size(380, 36)
        txtCategoryName.TabIndex = 0
        ' 
        ' txtDescription
        ' 
        txtDescription.BorderRadius = 8
        txtDescription.CustomizableEdges = CustomizableEdges5
        txtDescription.DefaultText = ""
        txtDescription.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtDescription.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtDescription.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtDescription.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtDescription.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtDescription.Font = New Font("Segoe UI", 9.0F)
        txtDescription.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtDescription.Location = New Point(38, 128)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.PlaceholderText = ""
        txtDescription.SelectedText = ""
        txtDescription.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtDescription.Size = New Size(380, 190)
        txtDescription.TabIndex = 1
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Guna2HtmlLabel1.ForeColor = SystemColors.ControlDarkDark
        Guna2HtmlLabel1.Location = New Point(38, 30)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(82, 17)
        Guna2HtmlLabel1.TabIndex = 2
        Guna2HtmlLabel1.Text = "Nama Kategori"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Guna2HtmlLabel2.ForeColor = SystemColors.ControlDarkDark
        Guna2HtmlLabel2.Location = New Point(38, 105)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(51, 17)
        Guna2HtmlLabel2.TabIndex = 3
        Guna2HtmlLabel2.Text = "Deskripsi"
        ' 
        ' btnCancel
        ' 
        btnCancel.Animated = True
        btnCancel.BackColor = Color.Transparent
        btnCancel.BorderColor = Color.WhiteSmoke
        btnCancel.BorderRadius = 8
        btnCancel.Cursor = Cursors.Hand
        btnCancel.CustomizableEdges = CustomizableEdges3
        btnCancel.DisabledState.BorderColor = Color.DarkGray
        btnCancel.DisabledState.CustomBorderColor = Color.DarkGray
        btnCancel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCancel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCancel.FillColor = Color.Gainsboro
        btnCancel.Font = New Font("Segoe UI", 9.0F)
        btnCancel.ForeColor = Color.FromArgb(CByte(240), CByte(138), CByte(8))
        btnCancel.Location = New Point(38, 341)
        btnCancel.Name = "btnCancel"
        btnCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnCancel.Size = New Size(180, 38)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Batal"
        ' 
        ' btnSave
        ' 
        btnSave.Animated = True
        btnSave.BorderRadius = 8
        btnSave.Cursor = Cursors.Hand
        btnSave.CustomizableEdges = CustomizableEdges1
        btnSave.DisabledState.BorderColor = Color.DarkGray
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray
        btnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSave.FillColor = Color.FromArgb(CByte(240), CByte(138), CByte(8))
        btnSave.Font = New Font("Segoe UI", 9.0F)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(238, 341)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnSave.Size = New Size(180, 38)
        btnSave.TabIndex = 5
        btnSave.Text = "Simpan"
        ' 
        ' FormAddOrUpdateCategory
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(459, 416)
        Controls.Add(btnSave)
        Controls.Add(btnCancel)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(txtDescription)
        Controls.Add(txtCategoryName)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormAddOrUpdateCategory"
        Text = "FormAddOrUpdateCategory"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCategoryName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
End Class
