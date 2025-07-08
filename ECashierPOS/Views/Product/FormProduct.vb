Imports ECashierPOS.Controllers
Imports ECashierPOS.Models.Entities

Public Class FormProduct
    Private ReadOnly controller As ProductController

    Public Sub New(productController As ProductController)
        Me.controller = productController

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub LoadProducts()
        Dim keyword As String = textSearch.Text.Trim()
        Dim products As New List(Of Product)

        If String.IsNullOrWhiteSpace(keyword) Then
            Dim result = controller.GetAllProducts()
            If result.Success AndAlso result.Data IsNot Nothing Then
                products = result.Data
            End If
        Else
            Dim result = controller.SearchProduct(keyword)
            If result.Success AndAlso result.Data IsNot Nothing Then
                products = result.Data
            End If
        End If

        ContentPanel.Controls.Clear()

        For Each product In products
            Dim productCard As New ProductCard(controller) With {
                .ProductId = product.Id,
                .ProductName = product.ProductName,
                .ProductDescription = product.Description,
                .ProductPrice = product.SellingPrice,
                .ProductImage = product.Image
            }
            AddHandler productCard.OnDeleteRequested, AddressOf HandleDeleteProduct
            AddHandler productCard.OnUpdateProduct, AddressOf LoadProducts

            ContentPanel.Controls.Add(productCard)
        Next
    End Sub

    Private Sub HandleDeleteProduct(productId As String)
        Dim result = controller.DeleteProduct(productId)

        If result.Success Then
            MessageBox.Show("Produk berhasil dihapus")
            LoadProducts()
        Else
            MessageBox.Show("Gagal hapus produk: " & result.Message)
        End If
    End Sub

    Private Sub FormProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim formAddProduct As New FormAddOrUpdateProduct(controller)

        AddHandler formAddProduct.OnReloadProducts, AddressOf LoadProducts

        formAddProduct.StartPosition = FormStartPosition.CenterScreen
        formAddProduct.ShowDialog()
    End Sub

    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles textSearch.TextChanged
        LoadProducts()
    End Sub
End Class