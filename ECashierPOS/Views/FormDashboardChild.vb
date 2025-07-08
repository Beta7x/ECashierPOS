Imports ECashierPOS.Controllers
Imports ECashierPOS.Models.Entities

Public Class FormDashboardChild
    Private ReadOnly controller As ProductController
    Private salesItems As New List(Of SalesItems)

    Public Sub New(productController As ProductController)
        Me.controller = productController
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles textSearch.TextChanged
        LoadProducts()
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

        ProductPanel.Controls.Clear()

        For Each product In products
            Dim productCard As New CardProduct()
            AddHandler productCard.OnAddProductToCart, AddressOf HandleAddProductToCart
            productCard.LoadProduct(product)
            ProductPanel.Controls.Add(productCard)
        Next
    End Sub

    Private Sub RenderCart()
        CartPanel.Controls.Clear()
        For Each product In salesItems
            Dim cartItem As New CartItem() With {
                .ProductId = product.Id,
                .ProductName = product.ProductName,
                .ProductPrice = product.Price,
                .ProductImage = product.ProductImage,
                .Quantity = product.Quantity
            }

            ' Tambahkan event handler
            AddHandler cartItem.OnRemoveItem, AddressOf HandleRemoveCartItem


            'cartItem.LoadCartItem(p)
            CartPanel.Controls.Add(cartItem)
        Next
    End Sub

    Private Sub HandleAddProductToCart(product As Product)
        ' Cek apakah produk sudah di keranjang
        Dim existingItem = salesItems.FirstOrDefault(Function(p) p.Id = product.Id)
        If existingItem Is Nothing Then
            salesItems.Add(New SalesItems With {
                .Id = product.Id,
                .ProductImage = product.Image,
                .ProductName = product.ProductName,
                .Price = product.SellingPrice,
                .Quantity = 1
            })
        Else
            existingItem.Quantity += 1
        End If

        RenderCart()
    End Sub

    Private Sub HandleRemoveCartItem(productId As String)
        Dim itemToRemove = salesItems.FirstOrDefault(Function(p) p.ProductId = productId)
        If itemToRemove IsNot Nothing Then
            salesItems.Remove(itemToRemove)
        End If

        For Each item As Control In CartPanel.Controls
            If TypeOf item Is CartItem Then
                Dim cartItem = CType(item, CartItem)
                If cartItem.ProductId = productId Then
                    CartPanel.Controls.Remove(cartItem)
                    cartItem.Dispose()
                    Exit For
                End If
            End If
        Next
    End Sub

    Private Sub FormDashboardChild_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub
End Class