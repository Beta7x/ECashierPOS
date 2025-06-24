Imports ECashierPOS.Controllers
Imports ECashierPOS.Models.DTO

Public Class FormAddOrUpdateProduct
    Private ReadOnly controller As ProductController
    Private productId As String = Nothing

    Public Event OnReloadProducts As EventHandler

    Public Sub New(productController As ProductController)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.controller = productController
    End Sub

    Public Sub New(productController As ProductController, productId As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.controller = productController
        Me.productId = productId
    End Sub

    Private Sub LoadCategories()
        Dim categories = controller.GetAllProductCategories().Data
        cmbProductCategories.DataSource = categories
        cmbProductCategories.DisplayMember = "CategoryName"
        cmbProductCategories.ValueMember = "Id"
    End Sub

    Private Sub FormAddOrUpdateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        If Not String.IsNullOrEmpty(productId) Then
            ' Edit mode
            Dim product = controller.GetProductById(productId)
            If product.Success AndAlso product.Data IsNot Nothing Then
                txtProductName.Text = product.Data.ProductName
                txtProductCode.Text = product.Data.ProductCode
                txtProductPrice.Text = product.Data.SellingPrice
                txtProductStock.Text = product.Data.Stock
                pbProductImage.ImageLocation = product.Data.Image
                btnSave.Text = "Perbarui"
            End If
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(productId) Then
            ' Insert mode
            Dim createProductRequest As New ProductDTO With {
                .CategoryId = cmbProductCategories.ValueMember,
                .ProductName = txtProductName.Text,
                .ProductCode = txtProductCode.Text,
                .SellingPrice = txtProductPrice.Text, ' TODO: Convert from String to Decimal
                .Stock = txtProductStock.Text,
                .Image = pbProductImage.ImageLocation
            }
            Dim createResult = controller.CreateProduct(createProductRequest)

            If createResult.Success Then
                MessageBox.Show($"{createResult.Message} produk")
            Else
                MessageBox.Show($"Gagal saat tambah data produk: {createResult.Message}")
            End If
        Else
            ' Edit mode
            Dim updateProductRequest As New ProductDTO With {
                .Id = productId,
                .CategoryId = cmbProductCategories.ValueMember,
                .ProductName = txtProductName.Text,
                .ProductCode = txtProductCode.Text,
                .SellingPrice = txtProductPrice.Text,
                .Stock = txtProductStock.Text,
                .Image = pbProductImage.ImageLocation
            }

            Dim updateResult = controller.UpdateProduct(updateProductRequest)
            If updateResult.Success Then
                MessageBox.Show($"{updateResult.Message} product")
            Else
                MessageBox.Show($"Product gagal diperbarui: {updateResult.Message}")
            End If
        End If

        RaiseEvent OnReloadProducts(Me, EventArgs.Empty)
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        Dim ofd As New OpenFileDialog With {
            .Filter = "Image Files|*.jpg;*.png;*.bmp"
        }

        If ofd.ShowDialog() = DialogResult.OK Then
            pbProductImage.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub
End Class