Imports ECashierPOS.Controllers

Public Class ProductCard
    Public Property ProductId As String
    Private ReadOnly controller As ProductController

    Public Event OnDeleteRequested(productId As String)
    Public Event OnUpdateProduct As EventHandler

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
            Return labelProductPrice.Text
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

    Public Sub New(productController As ProductController)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.controller = productController
    End Sub

    Private Sub HandleReloadProducts(sender As Object, e As EventArgs)
        RaiseEvent OnUpdateProduct(Me, EventArgs.Empty)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim formUpdate = New FormAddOrUpdateProduct(controller, ProductId)

        AddHandler formUpdate.OnReloadProducts, AddressOf HandleReloadProducts

        formUpdate.StartPosition = FormStartPosition.CenterParent
        formUpdate.ShowDialog()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Yakin hapus produk?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            RaiseEvent OnDeleteRequested(ProductId)
        End If
    End Sub

End Class
