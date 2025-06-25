Imports ECashierPOS.Controllers
Imports ECashierPOS.Models.Entities

Public Class FormCategory
    Private controller As CategoryController

    Public Sub New(categoryController As CategoryController)
        Me.controller = categoryController

        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub FormCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim formAddCategory As New FormAddOrUpdateCategory(controller)

        AddHandler formAddCategory.OnReloadCategory, AddressOf LoadCategories

        formAddCategory.StartPosition = FormStartPosition.CenterScreen
        formAddCategory.ShowDialog()
    End Sub

    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles textSearch.TextChanged
        LoadCategories()
    End Sub

    Private Sub LoadCategories()
        Dim keyword As String = textSearch.Text.Trim()
        Console.WriteLine($"Keyword dari textSearch: {keyword}")
        Dim categories As New List(Of Category)

        If String.IsNullOrWhiteSpace(keyword) Then
            Dim result = controller.GetAllCategories()
            If result.Success AndAlso result.Data IsNot Nothing Then
                categories = result.Data
            End If
        Else
            Dim result = controller.SearchCategory(keyword)
            If result.Success AndAlso result.Data IsNot Nothing Then
                categories = result.Data
            End If
        End If

        ContentPanel.Controls.Clear()

        'If categories.Count > 0 Then
        For Each category In categories
            Dim card As New CategoryCard(controller) With {
                .CategoryId = category.Id,
                .Title = category.CategoryName,
                .Content = category.Description,
                .CountItem = category.ProductItems,
                .CreatedAt = category.CreatedAt.ToString()
            }
            AddHandler card.OnDeleteRequested, AddressOf HandleDeleteCategory
            AddHandler card.OnUpdateCategory, AddressOf LoadCategories

            ContentPanel.Controls.Add(card)
        Next
        'End If
    End Sub

    Private Sub HandleDeleteCategory(categoryId As String)
        Dim result = controller.DeleteCategory(categoryId)

        If result.Success Then
            MessageBox.Show("Kategori berhasil dihapus")
            LoadCategories()
        Else
            MessageBox.Show("Gagal hapus kategori: " & result.Message)
        End If
    End Sub
End Class