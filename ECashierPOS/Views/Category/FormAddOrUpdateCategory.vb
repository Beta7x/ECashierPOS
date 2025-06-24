Imports ECashierPOS.Controllers
Imports ECashierPOS.Models.DTO

Public Class FormAddOrUpdateCategory
    Private ReadOnly controller As CategoryController
    Private categoryId As String = Nothing ' Default Nothing mean add mode
    Public Event OnReloadCategory As EventHandler

    Public Sub New(categoryController As CategoryController)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.controller = categoryController
    End Sub

    Public Sub New(categoryController As CategoryController, categoryId As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.controller = categoryController
        Me.categoryId = categoryId
    End Sub

    Private Sub FormAddOrUpdateCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(categoryId) Then
            ' Edit mode
            Dim category = controller.GetById(categoryId)
            If category.Success AndAlso category.Data IsNot Nothing Then
                txtCategoryName.Text = category.Data.CategoryName
                txtDescription.Text = category.Data.Description
                btnSave.Text = "Perbarui"
            End If
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(categoryId) Then
            ' Add Mode
            Dim createRequest As New CategoryDTO With {
                .CategoryName = txtCategoryName.Text,
                .Description = txtDescription.Text
            }
            Dim result = controller.InsertCategory(createRequest)

            If result.Success Then
                MessageBox.Show("Berhasil tambah kategori")
            Else
                MessageBox.Show($"Gagal saat tambah kategori: {result.Message}")
            End If
        Else
            ' Edit Mode
            Dim updateRequest As New CategoryDTO With {
                .Id = categoryId,
                .CategoryName = txtCategoryName.Text,
                .Description = txtDescription.Text
            }
            Dim result = controller.UpdateCategory(updateRequest)
            If result.Success Then
                MessageBox.Show("Kategori berhasil diperbarui")
            Else
                MessageBox.Show($"Kategori gagal diperbarui: {result.Message}")
            End If
        End If

        RaiseEvent OnReloadCategory(Me, EventArgs.Empty)
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class