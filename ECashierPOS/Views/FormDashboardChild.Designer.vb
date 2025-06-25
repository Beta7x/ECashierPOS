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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        ProductPanel = New Guna.UI2.WinForms.Guna2Panel()
        CalculatePanel = New Guna.UI2.WinForms.Guna2Panel()
        PanelTotal = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        CalculatePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 8
        Guna2Elipse1.TargetControl = Me
        ' 
        ' ProductPanel
        ' 
        ProductPanel.BackColor = Color.White
        ProductPanel.CustomizableEdges = CustomizableEdges1
        ProductPanel.Dock = DockStyle.Fill
        ProductPanel.Location = New Point(0, 0)
        ProductPanel.Name = "ProductPanel"
        ProductPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ProductPanel.Size = New Size(479, 450)
        ProductPanel.TabIndex = 0
        ' 
        ' CalculatePanel
        ' 
        CalculatePanel.BackColor = Color.Transparent
        CalculatePanel.Controls.Add(PanelTotal)
        CalculatePanel.Controls.Add(Guna2Panel3)
        CalculatePanel.CustomizableEdges = CustomizableEdges7
        CalculatePanel.Dock = DockStyle.Right
        CalculatePanel.Location = New Point(479, 0)
        CalculatePanel.Name = "CalculatePanel"
        CalculatePanel.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        CalculatePanel.Size = New Size(321, 450)
        CalculatePanel.TabIndex = 1
        ' 
        ' PanelTotal
        ' 
        PanelTotal.BackColor = Color.White
        PanelTotal.CustomizableEdges = CustomizableEdges3
        PanelTotal.Dock = DockStyle.Fill
        PanelTotal.Location = New Point(0, 0)
        PanelTotal.Name = "PanelTotal"
        PanelTotal.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        PanelTotal.Size = New Size(321, 307)
        PanelTotal.TabIndex = 1
        ' 
        ' Guna2Panel3
        ' 
        Guna2Panel3.BackColor = Color.White
        Guna2Panel3.CustomizableEdges = CustomizableEdges5
        Guna2Panel3.Dock = DockStyle.Bottom
        Guna2Panel3.Location = New Point(0, 307)
        Guna2Panel3.Name = "Guna2Panel3"
        Guna2Panel3.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel3.Size = New Size(321, 143)
        Guna2Panel3.TabIndex = 0
        ' 
        ' FormDashboardChild
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ProductPanel)
        Controls.Add(CalculatePanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormDashboardChild"
        Text = "FormDashboardChild"
        CalculatePanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CalculatePanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ProductPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PanelTotal As Guna.UI2.WinForms.Guna2Panel
End Class
