Public Class FormTransaction
    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SetupTableStyle()
        With gunaTableProducts

            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.Font = New Font("Segoe UI", 10)

            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeight = 30
            .RowTemplate.Height = 28

            .GridColor = Color.LightGray
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AllowUserToAddRows = False
            .ReadOnly = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub
End Class