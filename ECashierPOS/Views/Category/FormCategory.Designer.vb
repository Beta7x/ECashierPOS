<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCategory
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        textSearch = New Guna.UI2.WinForms.Guna2TextBox()
        btnInsert = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        ContentPanel = New FlowLayoutPanel()
        Guna2Panel1.SuspendLayout()
        Guna2Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 18
        Guna2Elipse1.TargetControl = Me
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.Controls.Add(Guna2Panel2)
        Guna2Panel1.Controls.Add(Guna2HtmlLabel1)
        Guna2Panel1.CustomizableEdges = CustomizableEdges7
        Guna2Panel1.Dock = DockStyle.Top
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel1.Size = New Size(1003, 65)
        Guna2Panel1.TabIndex = 1
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.Controls.Add(textSearch)
        Guna2Panel2.Controls.Add(btnInsert)
        Guna2Panel2.CustomizableEdges = CustomizableEdges5
        Guna2Panel2.Dock = DockStyle.Right
        Guna2Panel2.Location = New Point(585, 0)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel2.Size = New Size(418, 65)
        Guna2Panel2.TabIndex = 1
        ' 
        ' textSearch
        ' 
        textSearch.Animated = True
        textSearch.BorderColor = Color.Gainsboro
        textSearch.BorderRadius = 8
        textSearch.CustomizableEdges = CustomizableEdges1
        textSearch.DefaultText = ""
        textSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        textSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        textSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textSearch.Font = New Font("Segoe UI", 9F)
        textSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textSearch.Location = New Point(21, 15)
        textSearch.Name = "textSearch"
        textSearch.PlaceholderText = "Cari..."
        textSearch.SelectedText = ""
        textSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        textSearch.Size = New Size(200, 36)
        textSearch.TabIndex = 1
        ' 
        ' btnInsert
        ' 
        btnInsert.Animated = True
        btnInsert.BorderRadius = 8
        btnInsert.CustomizableEdges = CustomizableEdges3
        btnInsert.DisabledState.BorderColor = Color.DarkGray
        btnInsert.DisabledState.CustomBorderColor = Color.DarkGray
        btnInsert.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnInsert.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnInsert.FillColor = Color.FromArgb(CByte(241), CByte(137), CByte(10))
        btnInsert.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInsert.ForeColor = Color.White
        btnInsert.Image = My.Resources.Resources.plus__1_
        btnInsert.ImageAlign = HorizontalAlignment.Left
        btnInsert.Location = New Point(235, 13)
        btnInsert.Name = "btnInsert"
        btnInsert.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnInsert.Size = New Size(166, 38)
        btnInsert.TabIndex = 0
        btnInsert.Text = "Tambah Kategori"
        btnInsert.TextAlign = HorizontalAlignment.Left
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = SystemColors.WindowFrame
        Guna2HtmlLabel1.Location = New Point(29, 18)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(142, 27)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "Kategori Produk"
        ' 
        ' ContentPanel
        ' 
        ContentPanel.AutoScroll = True
        ContentPanel.Dock = DockStyle.Fill
        ContentPanel.Location = New Point(0, 65)
        ContentPanel.Name = "ContentPanel"
        ContentPanel.Padding = New Padding(25, 10, 0, 0)
        ContentPanel.Size = New Size(1003, 462)
        ContentPanel.TabIndex = 2
        ' 
        ' FormCategory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1003, 527)
        Controls.Add(ContentPanel)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormCategory"
        Text = "FormCategory"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        Guna2Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents textSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnInsert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ContentPanel As FlowLayoutPanel
End Class
