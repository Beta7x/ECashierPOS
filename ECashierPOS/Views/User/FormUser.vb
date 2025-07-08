Imports ECashierPOS.Controllers

Public Class FormUser
    Private ReadOnly controller As UserController

    Public Sub New(userController As UserController)
        Me.controller = userController
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupProductTable()
        LoadUsers()
    End Sub

    Private Sub SetupProductTable()
        With tableUsers
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 137, 10)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersHeight = 40
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            .DefaultCellStyle.Font = New Font("Segoe UI", 10)
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 229, 255)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 255)

            .GridColor = Color.FromArgb(231, 229, 255)
            .AutoGenerateColumns = False
            .BorderStyle = BorderStyle.None
            .RowTemplate.Height = 40
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .RowHeadersVisible = False
        End With

        ' Clear existing columns if any
        tableUsers.Columns.Clear()

        ' Kolom ID (hidden)
        Dim colId As New DataGridViewTextBoxColumn()
        colId.Name = "id"
        colId.HeaderText = "ID"
        colId.Visible = False
        tableUsers.Columns.Add(colId)

        ' Tambahkan kolom manual (jika tidak binding otomatis)
        tableUsers.Columns.Add("full_name", "Nama Lengkap")
        tableUsers.Columns.Add("username", "Username")
        tableUsers.Columns.Add("role", "Role")
        tableUsers.Columns.Add("created_at", "Dibuat")
        tableUsers.Columns.Add("updated_at", "Diperbarui")

        Dim colEdit As New DataGridViewImageColumn()
        colEdit.Name = "btnEdit"
        colEdit.HeaderText = "Edit"
        colEdit.Image = My.Resources.pen ' Ganti dengan ikon edit yang sesuai
        colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom
        colEdit.Width = 36

        Dim colDelete As New DataGridViewImageColumn()
        colDelete.Name = "btnDelete"
        colDelete.HeaderText = "Hapus"
        colDelete.Image = My.Resources.delete
        colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom
        colDelete.Width = 36

        tableUsers.Columns.Add(colEdit)
        tableUsers.Columns.Add(colDelete)
    End Sub

    Private Sub LoadUsers()
        Dim result = controller.GetAll()
        If result.Success AndAlso result.Data IsNot Nothing Then
            tableUsers.Rows.Clear()
            For Each user In result.Data
                tableUsers.Rows.Add(user.Id, user.FullName, user.Username, user.Role, user.CreatedAt, user.UpdatedAt)
            Next
        Else
            MessageBox.Show("Gagal memuat data pengguna: " & result.Message)
        End If
    End Sub

    Private Sub TableUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableUsers.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            'Dim clickedColumn = tableUsers.Columns(e.ColumnIndex)
            'clickedColumn.HeaderCell.Style.BackColor = Color.FromArgb(241, 137, 10)

            Dim colName = tableUsers.Columns(e.ColumnIndex).Name
            Dim userId = tableUsers.Rows(e.RowIndex).Cells("id").Value.ToString

            If colName = "btnDelete" Then
                ' Konfirmasi dan hapus user
                If MessageBox.Show("Yakin ingin hapus user?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    controller.DeleteUser(userId)
                    LoadUsers()
                End If
            ElseIf colName = "btnEdit" Then
                ' Tampilkan form edit user
                Dim formEdit As New FormAddOrUpdateUser(controller, userId)
                formEdit.ShowDialog()
                LoadUsers()
            End If
        End If
    End Sub

    Private Sub TableUsers_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles tableUsers.CellPainting
        If e.RowIndex = -1 AndAlso e.ColumnIndex >= 0 Then
            e.PaintBackground(e.ClipBounds, True)
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(241, 137, 10)), e.CellBounds)

            TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(),
                                  New Font("Segoe UI", 10, FontStyle.Bold),
                                  e.CellBounds,
                                  Color.White,
                                  TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)

            e.Handled = True
        End If
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim formAddUser As New FormAddOrUpdateUser(controller)

        AddHandler formAddUser.OnReloadUsers, AddressOf LoadUsers

        formAddUser.StartPosition = FormStartPosition.CenterScreen
        formAddUser.ShowDialog()
    End Sub
End Class