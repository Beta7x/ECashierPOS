Imports ECashierPOS.Models.Entities

Public Class CardProduct
    Inherits UserControl

    Public Event OnAddProductToCart(product As Product)

    Private currentProduct As Product

    Public Sub LoadProduct(product As Product)
        currentProduct = product
        labelProductName.Text = product.ProductName
        labelProductPrice.Text = "Rp. " & product.SellingPrice.ToString("N0")

        If String.IsNullOrWhiteSpace(product.Image) OrElse Not IO.File.Exists(product.Image) Then
            pbProductImage.Image = My.Resources.default_image
        Else
            pbProductImage.Image = Image.FromFile(product.Image)
        End If
    End Sub

    Private Sub BtnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        If currentProduct IsNot Nothing Then
            RaiseEvent OnAddProductToCart(currentProduct)
        End If
    End Sub
End Class
