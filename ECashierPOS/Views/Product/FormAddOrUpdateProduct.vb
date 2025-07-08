Imports ECashierPOS.Controllers
Imports ECashierPOS.Models.DTO
Imports ECashierPOS.Models.Entities

Public Class FormAddOrUpdateProduct
    Private ReadOnly controller As ProductController
    Private productId As String = Nothing
    Private imagePath As String = Nothing

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
        lableProductDescription.SelectionIndent = 0
        LoadCategories()
        If Not String.IsNullOrEmpty(productId) Then
            ' Edit mode
            Dim product = controller.GetProductById(productId)
            If product.Success AndAlso product.Data IsNot Nothing Then
                txtProductName.Text = product.Data.ProductName
                txtProductCode.Text = product.Data.ProductCode
                txtProductPrice.Text = product.Data.SellingPrice
                txtProductPriceBuy.Text = product.Data.PuchasePrice
                txtProductStock.Text = product.Data.Stock
                txtProductMinimumStock.Text = product.Data.MinimumStock
                pbProductImage.ImageLocation = product.Data.Image
                txtProductDescription.Text = product.Data.Description
                btnSave.Text = "Perbarui"
                txtProductDescription.Text = product.Data.Description
                imagePath = product.Data.Image
            End If
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(productId) Then
            ' Insert mode
            Dim createProductRequest As New ProductDTO With {
                .CategoryId = cmbProductCategories.SelectedValue,
                .ProductName = txtProductName.Text,
                .ProductCode = txtProductCode.Text,
                .SellingPrice = Convert.ToDecimal(txtProductPrice.Text), ' TODO: Convert from String to Decimal
                .PurchasePrice = Convert.ToDecimal(txtProductPriceBuy.Text), ' TODO: Convert from String to Decimal
                .Stock = Convert.ToInt32(txtProductStock.Text),
                .MinimumStock = Convert.ToInt32(txtProductMinimumStock.Text),
                .Image = imagePath,
                .Description = txtProductDescription.Text
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
                .CategoryId = cmbProductCategories.SelectedValue,
                .ProductName = txtProductName.Text,
                .ProductCode = txtProductCode.Text,
                .SellingPrice = Convert.ToDecimal(txtProductPrice.Text),
                .PurchasePrice = Convert.ToDecimal(txtProductPriceBuy.Text),
                .Stock = Convert.ToInt32(txtProductStock.Text),
                .MinimumStock = Convert.ToInt32(txtProductMinimumStock.Text),
                .Image = imagePath,
                .Description = txtProductDescription.Text
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
            .Filter = "Image Files|*.jpg;*.png;*.bmp",
            .Title = "Pilih Gambar Produk"
        }

        If ofd.ShowDialog() = DialogResult.OK Then
            imagePath = ofd.FileName ' Simpan path gambar yang dipilih
            pbProductImage.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub TxtProductPrice_TextChanged(sender As Object, e As EventArgs) Handles txtProductPrice.TextChanged
        ' Hapus semua karakter non-numerik kecuali titik desimal dan merubah lableProductPrice sesuai text yang diinput
        Dim input As String = txtProductPrice.Text
        Dim cleanedInput As String = System.Text.RegularExpressions.Regex.Replace(input, "[^\d.]", "")
        ' Perbarui teks dengan input yang sudah dibersihkan
        txtProductPrice.Text = cleanedInput
        ' Pindahkan kursor ke akhir teks
        txtProductPrice.SelectionStart = txtProductPrice.Text.Length
        ' Merubah lableProductPrice sesuai dengan teks yang diinput
        If String.IsNullOrWhiteSpace(txtProductPrice.Text) Then
            lableProductPrice.Text = "Harga Jual"
        Else
            lableProductPrice.Text = txtProductPrice.Text
        End If
    End Sub

    Private Sub TxtProductStock_TextChanged(sender As Object, e As EventArgs) Handles txtProductStock.TextChanged
        ' Hapus semua karakter non-numerik
        Dim input As String = txtProductStock.Text
        Dim cleanedInput As String = System.Text.RegularExpressions.Regex.Replace(input, "[^\d]", "")
        ' Perbarui teks dengan input yang sudah dibersihkan
        txtProductStock.Text = cleanedInput
        ' Pindahkan kursor ke akhir teks
        txtProductStock.SelectionStart = txtProductStock.Text.Length
    End Sub

    Private Sub TxtProductName_TextChanged(sender As Object, e As EventArgs) Handles txtProductName.TextChanged
        ' Merubah lableProductName sesuai dengan teks yang diinput
        If String.IsNullOrWhiteSpace(txtProductName.Text) Then
            lableProductName.Text = "Nama Produk"
        Else
            lableProductName.Text = txtProductName.Text
        End If
    End Sub

    Private Sub TxtProductCode_TextChanged(sender As Object, e As EventArgs) Handles txtProductCode.TextChanged
        ' Merubah lableProductCode sesuai dengan teks yang diinput
        If String.IsNullOrWhiteSpace(txtProductCode.Text) Then
            lableProductCode.Text = "Kode Produk"
        Else
            lableProductCode.Text = txtProductCode.Text
        End If
    End Sub

    Private Sub CmbProductCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductCategories.SelectedIndexChanged
        ' Merubah lableProductCategory sesuai dengan kategori yang dipilih
        If cmbProductCategories.SelectedItem IsNot Nothing Then
            Dim selectedCategory = CType(cmbProductCategories.SelectedItem, Category)
            lableProductCategoryName.Text = selectedCategory.CategoryName
        Else
            lableProductCategoryName.Text = "Kategori Produk"
        End If
    End Sub

    Private Sub TxtProductMinimumStock_TextChanged(sender As Object, e As EventArgs) Handles txtProductMinimumStock.TextChanged
        ' Hapus semua karakter non-numerik
        Dim input As String = txtProductMinimumStock.Text
        Dim cleanedInput As String = System.Text.RegularExpressions.Regex.Replace(input, "[^\d]", "")
        ' Perbarui teks dengan input yang sudah dibersihkan
        txtProductMinimumStock.Text = cleanedInput
        ' Pindahkan kursor ke akhir teks
        txtProductMinimumStock.SelectionStart = txtProductMinimumStock.Text.Length
    End Sub

    Private Sub TxtProductPriceBuy_TextChanged(sender As Object, e As EventArgs) Handles txtProductPriceBuy.TextChanged
        ' Hapus semua karakter non-numerik kecuali titik desimal
        Dim input As String = txtProductPriceBuy.Text
        Dim cleanedInput As String = System.Text.RegularExpressions.Regex.Replace(input, "[^\d.]", "")
        ' Perbarui teks dengan input yang sudah dibersihkan
        txtProductPriceBuy.Text = cleanedInput
        ' Pindahkan kursor ke akhir teks
        txtProductPriceBuy.SelectionStart = txtProductPriceBuy.Text.Length
    End Sub

    Private Sub TxtProductDescription_TextChanged(sender As Object, e As EventArgs) Handles txtProductDescription.TextChanged
        ' Merubah lableProductDescription sesuai dengan teks yang diinput
        If String.IsNullOrWhiteSpace(txtProductDescription.Text) Then
            lableProductDescription.Text = "Deskripsi Produk"
        Else
            lableProductDescription.Text = txtProductDescription.Text
        End If
    End Sub
End Class