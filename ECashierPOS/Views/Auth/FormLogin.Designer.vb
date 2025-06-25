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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
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
        cbClose = New Guna.UI2.WinForms.Guna2ControlBox()
        textUsername = New Guna.UI2.WinForms.Guna2TextBox()
        textPassword = New Guna.UI2.WinForms.Guna2TextBox()
        btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 15
        Guna2Elipse1.TargetControl = Me
        ' 
        ' cbClose
        ' 
        cbClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cbClose.Animated = True
        cbClose.BackColor = Color.Transparent
        cbClose.BorderRadius = 15
        cbClose.Cursor = Cursors.Hand
        cbClose.CustomizableEdges = CustomizableEdges11
        cbClose.FillColor = Color.Gainsboro
        cbClose.HoverState.FillColor = Color.FromArgb(CByte(241), CByte(137), CByte(10))
        cbClose.IconColor = Color.White
        cbClose.ImeMode = ImeMode.NoControl
        cbClose.Location = New Point(758, 12)
        cbClose.Name = "cbClose"
        cbClose.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        cbClose.Size = New Size(30, 30)
        cbClose.TabIndex = 0
        ' 
        ' textUsername
        ' 
        textUsername.Animated = True
        textUsername.BorderRadius = 8
        textUsername.CustomizableEdges = CustomizableEdges9
        textUsername.DefaultText = ""
        textUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        textUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        textUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textUsername.Font = New Font("Segoe UI", 9.0F)
        textUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textUsername.Location = New Point(453, 162)
        textUsername.Name = "textUsername"
        textUsername.PlaceholderText = "Username"
        textUsername.SelectedText = ""
        textUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        textUsername.Size = New Size(294, 36)
        textUsername.TabIndex = 1
        ' 
        ' textPassword
        ' 
        textPassword.Animated = True
        textPassword.BorderRadius = 8
        textPassword.CustomizableEdges = CustomizableEdges7
        textPassword.DefaultText = ""
        textPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        textPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        textPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textPassword.Font = New Font("Segoe UI", 9.0F)
        textPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textPassword.Location = New Point(453, 222)
        textPassword.Name = "textPassword"
        textPassword.PlaceholderText = "Password"
        textPassword.SelectedText = ""
        textPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        textPassword.Size = New Size(294, 36)
        textPassword.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.Animated = True
        btnLogin.BorderRadius = 8
        btnLogin.Cursor = Cursors.Hand
        btnLogin.CustomizableEdges = CustomizableEdges5
        btnLogin.DisabledState.BorderColor = Color.DarkGray
        btnLogin.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogin.FillColor = Color.FromArgb(CByte(241), CByte(137), CByte(10))
        btnLogin.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(453, 292)
        btnLogin.Name = "btnLogin"
        btnLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnLogin.Size = New Size(294, 41)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Masuk"
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges3
        Guna2PictureBox1.Dock = DockStyle.Left
        Guna2PictureBox1.Image = My.Resources.Resources.christiann_koepke_szqxBF4OUsc_unsplash
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(0, 0)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2PictureBox1.Size = New Size(395, 450)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2PictureBox1.TabIndex = 4
        Guna2PictureBox1.TabStop = False
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BackColor = Color.Transparent
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Transparent
        Guna2Button1.Font = New Font("Segoe UI Semibold", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.Black
        Guna2Button1.Image = My.Resources.Resources.bar_graph
        Guna2Button1.ImageAlign = HorizontalAlignment.Left
        Guna2Button1.Location = New Point(444, 36)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(176, 45)
        Guna2Button1.TabIndex = 5
        Guna2Button1.Text = "E-Cashier"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.Location = New Point(453, 115)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(167, 23)
        Guna2HtmlLabel1.TabIndex = 6
        Guna2HtmlLabel1.Text = "Log in to your account"
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = Me
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(Guna2Button1)
        Controls.Add(Guna2PictureBox1)
        Controls.Add(btnLogin)
        Controls.Add(textPassword)
        Controls.Add(textUsername)
        Controls.Add(cbClose)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormLogin"
        Text = "Form1"
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents cbClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents textPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents textUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl

End Class
