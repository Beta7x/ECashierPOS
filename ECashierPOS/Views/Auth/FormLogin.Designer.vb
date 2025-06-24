<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        cbClose = New Guna.UI2.WinForms.Guna2ControlBox()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 8
        Guna2Elipse1.TargetControl = Me
        ' 
        ' cbClose
        ' 
        cbClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cbClose.BorderRadius = 15
        cbClose.CustomizableEdges = CustomizableEdges3
        cbClose.FillColor = Color.FromArgb(CByte(139), CByte(152), CByte(166))
        cbClose.IconColor = Color.White
        cbClose.Location = New Point(758, 12)
        cbClose.Name = "cbClose"
        cbClose.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        cbClose.Size = New Size(30, 30)
        cbClose.TabIndex = 0
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cbClose)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormLogin"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents cbClose As Guna.UI2.WinForms.Guna2ControlBox

End Class
