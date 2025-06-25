Public Class ProductCardCashier
    Public Property ProductId As String

    Public Event OnAddtoCart(productId As String)

    Public Property ProductName As String
        Get
            Return labelProductName.Text
        End Get
        Set(value As String)
            labelProductName.Text = value
        End Set
    End Property

    Public Property ProductDescription As String
        Get
            Return labelDescription.Text
        End Get
        Set(value As String)
            labelDescription.Text = value
        End Set
    End Property

    Public Property ProductPrice As Decimal
        Get
            Return Convert.ToDecimal(labelProductPrice.Text)
        End Get
        Set(value As Decimal)
            labelProductPrice.Text = value
        End Set
    End Property

    Public Property ProductImage As String
        Get
            Return pbProductImage.ImageLocation
        End Get
        Set(value As String)
            pbProductImage.Image = Image.FromFile(value)
        End Set
    End Property

    Private Sub BtnAddtoCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        RaiseEvent OnAddtoCart(ProductId)
    End Sub
End Class
