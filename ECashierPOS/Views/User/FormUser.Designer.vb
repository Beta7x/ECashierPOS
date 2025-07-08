<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        textSearch = New Guna.UI2.WinForms.Guna2TextBox()
        btnInsert = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        tableUsers = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2Panel2.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        Guna2Panel3.SuspendLayout()
        CType(tableUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 8
        Guna2Elipse1.TargetControl = Me
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.Controls.Add(textSearch)
        Guna2Panel2.Controls.Add(btnInsert)
        Guna2Panel2.CustomizableEdges = CustomizableEdges7
        Guna2Panel2.Dock = DockStyle.Right
        Guna2Panel2.Location = New Point(569, 0)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel2.Size = New Size(434, 65)
        Guna2Panel2.TabIndex = 1
        ' 
        ' textSearch
        ' 
        textSearch.Animated = True
        textSearch.BorderColor = Color.Gainsboro
        textSearch.BorderRadius = 8
        textSearch.CustomizableEdges = CustomizableEdges3
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
        textSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        textSearch.Size = New Size(200, 36)
        textSearch.TabIndex = 1
        ' 
        ' btnInsert
        ' 
        btnInsert.Animated = True
        btnInsert.BorderRadius = 8
        btnInsert.CustomizableEdges = CustomizableEdges5
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
        btnInsert.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnInsert.Size = New Size(166, 38)
        btnInsert.TabIndex = 0
        btnInsert.Text = "Tambah Pengguna"
        btnInsert.TextAlign = HorizontalAlignment.Left
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.White
        Guna2Panel1.Controls.Add(Guna2Panel2)
        Guna2Panel1.Controls.Add(Guna2HtmlLabel1)
        Guna2Panel1.CustomizableEdges = CustomizableEdges9
        Guna2Panel1.Dock = DockStyle.Top
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Panel1.Size = New Size(1003, 65)
        Guna2Panel1.TabIndex = 3
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = SystemColors.WindowFrame
        Guna2HtmlLabel1.Location = New Point(29, 18)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(135, 27)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "Data Pengguna"
        ' 
        ' Guna2Panel3
        ' 
        Guna2Panel3.BackColor = Color.White
        Guna2Panel3.Controls.Add(tableUsers)
        Guna2Panel3.CustomizableEdges = CustomizableEdges1
        Guna2Panel3.Dock = DockStyle.Fill
        Guna2Panel3.Location = New Point(0, 65)
        Guna2Panel3.Name = "Guna2Panel3"
        Guna2Panel3.Padding = New Padding(30, 20, 30, 20)
        Guna2Panel3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel3.Size = New Size(1003, 462)
        Guna2Panel3.TabIndex = 4
        ' 
        ' tableUsers
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        tableUsers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        tableUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        tableUsers.ColumnHeadersHeight = 4
        tableUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        tableUsers.DefaultCellStyle = DataGridViewCellStyle3
        tableUsers.Dock = DockStyle.Fill
        tableUsers.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        tableUsers.Location = New Point(30, 20)
        tableUsers.Name = "tableUsers"
        tableUsers.RowHeadersVisible = False
        tableUsers.Size = New Size(943, 422)
        tableUsers.TabIndex = 0
        tableUsers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        tableUsers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        tableUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        tableUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        tableUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        tableUsers.ThemeStyle.BackColor = Color.White
        tableUsers.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        tableUsers.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        tableUsers.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        tableUsers.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        tableUsers.ThemeStyle.HeaderStyle.ForeColor = Color.White
        tableUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        tableUsers.ThemeStyle.HeaderStyle.Height = 4
        tableUsers.ThemeStyle.ReadOnly = False
        tableUsers.ThemeStyle.RowsStyle.BackColor = Color.White
        tableUsers.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        tableUsers.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        tableUsers.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        tableUsers.ThemeStyle.RowsStyle.Height = 25
        tableUsers.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        tableUsers.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' FormUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1003, 527)
        Controls.Add(Guna2Panel3)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormUser"
        Text = "FormUser"
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        Guna2Panel3.ResumeLayout(False)
        CType(tableUsers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents textSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnInsert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tableUsers As Guna.UI2.WinForms.Guna2DataGridView
End Class
