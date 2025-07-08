<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaction
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        gunaTableProducts = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(gunaTableProducts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gunaTableProducts
        ' 
        gunaTableProducts.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        gunaTableProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        gunaTableProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        gunaTableProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        gunaTableProducts.DefaultCellStyle = DataGridViewCellStyle3
        gunaTableProducts.Dock = DockStyle.Fill
        gunaTableProducts.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        gunaTableProducts.Location = New Point(10, 10)
        gunaTableProducts.Name = "gunaTableProducts"
        gunaTableProducts.ReadOnly = True
        gunaTableProducts.RowHeadersVisible = False
        gunaTableProducts.Size = New Size(780, 430)
        gunaTableProducts.TabIndex = 0
        gunaTableProducts.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        gunaTableProducts.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        gunaTableProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        gunaTableProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        gunaTableProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        gunaTableProducts.ThemeStyle.BackColor = Color.White
        gunaTableProducts.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        gunaTableProducts.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        gunaTableProducts.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        gunaTableProducts.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        gunaTableProducts.ThemeStyle.HeaderStyle.ForeColor = Color.White
        gunaTableProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gunaTableProducts.ThemeStyle.HeaderStyle.Height = 4
        gunaTableProducts.ThemeStyle.ReadOnly = True
        gunaTableProducts.ThemeStyle.RowsStyle.BackColor = Color.White
        gunaTableProducts.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        gunaTableProducts.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        gunaTableProducts.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        gunaTableProducts.ThemeStyle.RowsStyle.Height = 25
        gunaTableProducts.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        gunaTableProducts.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' FormTransaction
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(gunaTableProducts)
        Name = "FormTransaction"
        Padding = New Padding(10)
        Text = "FormTransaction"
        CType(gunaTableProducts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents gunaTableProducts As Guna.UI2.WinForms.Guna2DataGridView
End Class
