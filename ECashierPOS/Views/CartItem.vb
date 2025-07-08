Public Class CartItem
    Inherits UserControl

    Public Property ProductId As String
    Public Property Quantity As Integer

    Public Event OnRemoveItem(productId As String)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Public Property ProductName As String
        Get
            Return labelProductName.Text
        End Get
        Set(value As String)
            labelProductName.Text = value
        End Set
    End Property

    Public Property ProductPrice As Decimal
        Get
            Return Convert.ToDecimal(labelProductPrice.Text.Replace("Rp. ", "").Replace(".", "").Trim())
        End Get
        Set(value As Decimal)
            labelProductPrice.Text = "Rp. " & value.ToString("N0")
        End Set
    End Property

    Public Property ProductImage As String
        Get
            Return pbProductImage.ImageLocation
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) OrElse Not System.IO.File.Exists(value) Then
                pbProductImage.Image = My.Resources.default_image
            Else
                pbProductImage.Image = Image.FromFile(value)
            End If
        End Set
    End Property

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        RaiseEvent OnRemoveItem(ProductId)
    End Sub

    Private Sub BtnDecreaseQuantity_Click(sender As Object, e As EventArgs) Handles btnDecreaseQuantity.Click
        If Quantity = 1 Then
            Quantity = 1
        Else
            Quantity -= 1
        End If
        txtQuantity.Text = Quantity
    End Sub

    Private Sub BtnIncreaseQuantity_Click(sender As Object, e As EventArgs) Handles btnIncreaseQuantity.Click
        Quantity += 1
        txtQuantity.Text = Quantity
    End Sub
End Class
