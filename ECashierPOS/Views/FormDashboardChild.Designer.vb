<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboardChild
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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        CalculatePanel = New Guna.UI2.WinForms.Guna2Panel()
        CartPanel = New FlowLayoutPanel()
        Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        textSearch = New Guna.UI2.WinForms.Guna2TextBox()
        ProductPanel = New FlowLayoutPanel()
        CalculatePanel.SuspendLayout()
        Guna2Panel4.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        Guna2Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 8
        Guna2Elipse1.TargetControl = Me
        ' 
        ' CalculatePanel
        ' 
        CalculatePanel.BackColor = Color.White
        CalculatePanel.Controls.Add(CartPanel)
        CalculatePanel.Controls.Add(Guna2Panel4)
        CalculatePanel.Controls.Add(Guna2Panel3)
        CalculatePanel.CustomizableEdges = CustomizableEdges11
        CalculatePanel.Dock = DockStyle.Right
        CalculatePanel.Location = New Point(479, 0)
        CalculatePanel.Name = "CalculatePanel"
        CalculatePanel.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        CalculatePanel.Size = New Size(321, 450)
        CalculatePanel.TabIndex = 1
        ' 
        ' CartPanel
        ' 
        CartPanel.AutoScroll = True
        CartPanel.BackColor = Color.White
        CartPanel.Dock = DockStyle.Fill
        CartPanel.FlowDirection = FlowDirection.TopDown
        CartPanel.Location = New Point(0, 51)
        CartPanel.Name = "CartPanel"
        CartPanel.Padding = New Padding(25, 10, 0, 0)
        CartPanel.Size = New Size(321, 256)
        CartPanel.TabIndex = 3
        ' 
        ' Guna2Panel4
        ' 
        Guna2Panel4.Controls.Add(Guna2HtmlLabel2)
        Guna2Panel4.CustomizableEdges = CustomizableEdges7
        Guna2Panel4.Dock = DockStyle.Top
        Guna2Panel4.FillColor = Color.White
        Guna2Panel4.Location = New Point(0, 0)
        Guna2Panel4.Name = "Guna2Panel4"
        Guna2Panel4.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel4.Size = New Size(321, 51)
        Guna2Panel4.TabIndex = 2
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.Location = New Point(22, 12)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(76, 23)
        Guna2HtmlLabel2.TabIndex = 1
        Guna2HtmlLabel2.Text = "Keranjang"
        ' 
        ' Guna2Panel3
        ' 
        Guna2Panel3.BackColor = Color.White
        Guna2Panel3.BorderColor = Color.Black
        Guna2Panel3.CustomizableEdges = CustomizableEdges9
        Guna2Panel3.Dock = DockStyle.Bottom
        Guna2Panel3.Location = New Point(0, 307)
        Guna2Panel3.Name = "Guna2Panel3"
        Guna2Panel3.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Panel3.Size = New Size(321, 143)
        Guna2Panel3.TabIndex = 0
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.White
        Guna2Panel1.Controls.Add(Guna2HtmlLabel1)
        Guna2Panel1.Controls.Add(Guna2Panel2)
        Guna2Panel1.CustomizableEdges = CustomizableEdges5
        Guna2Panel1.Dock = DockStyle.Top
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel1.Size = New Size(479, 51)
        Guna2Panel1.TabIndex = 2
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.Location = New Point(25, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(38, 23)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "Kasir"
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.Controls.Add(textSearch)
        Guna2Panel2.CustomizableEdges = CustomizableEdges3
        Guna2Panel2.Dock = DockStyle.Right
        Guna2Panel2.Location = New Point(256, 0)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel2.Size = New Size(223, 51)
        Guna2Panel2.TabIndex = 3
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
        textSearch.Location = New Point(13, 7)
        textSearch.Name = "textSearch"
        textSearch.PlaceholderText = "Cari..."
        textSearch.SelectedText = ""
        textSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        textSearch.Size = New Size(200, 36)
        textSearch.TabIndex = 2
        ' 
        ' ProductPanel
        ' 
        ProductPanel.AutoScroll = True
        ProductPanel.BackColor = Color.White
        ProductPanel.Dock = DockStyle.Fill
        ProductPanel.Location = New Point(0, 51)
        ProductPanel.Name = "ProductPanel"
        ProductPanel.Padding = New Padding(25, 10, 0, 0)
        ProductPanel.Size = New Size(479, 399)
        ProductPanel.TabIndex = 0
        ' 
        ' FormDashboardChild
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ProductPanel)
        Controls.Add(Guna2Panel1)
        Controls.Add(CalculatePanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormDashboardChild"
        Text = "FormDashboardChild"
        CalculatePanel.ResumeLayout(False)
        Guna2Panel4.ResumeLayout(False)
        Guna2Panel4.PerformLayout()
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        Guna2Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CalculatePanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents textSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ProductPanel As FlowLayoutPanel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CartPanel As FlowLayoutPanel
End Class
