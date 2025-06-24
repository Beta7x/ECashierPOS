Imports System.Security.Cryptography.X509Certificates
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Models.Repositories
Imports MySql.Data.MySqlClient
Imports NUnit.Framework

<TestFixture>
Public Class MySQLProductRepositoryTest
    Private productRepository As IProductRepository
    Private categoryRepository As ICategoryRepository
    Private connectionString As String

    <SetUp>
    Public Sub Setup()
        connectionString = "server=localhost;user=root;password=beta7x;database=e_cashier_test;"
        productRepository = New MySQLProductRepository(connectionString)
        categoryRepository = New MySQLCategoryRepository(connectionString)

        ClearAllProducts()
        ClearAllCategories()
        SeedingCategories()
        SeedingProducts()
    End Sub

    <TearDown>
    Public Sub Teardown()
        ClearAllProducts()
        ClearAllCategories()
    End Sub

    Private Sub ClearAllProducts()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand("DELETE FROM products", conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub ClearAllCategories()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand("DELETE FROM categories", conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub SeedingCategories()
        Dim categories As New List(Of Category) From {
            New Category With {
                .Id = Guid.NewGuid().ToString(),
                .CategoryName = "Makanan",
                .Description = "Kategori untuk produk konsumsi berupa makanan"
            },
            New Category With {
                .Id = Guid.NewGuid().ToString(),
                .CategoryName = "Minuman",
                .Description = "Kategori untuk produk konsumsi berupa minuman"
            },
            New Category With {
                .Id = Guid.NewGuid().ToString(),
                .CategoryName = "Obat",
                .Description = "Kategori untuk produk konsumsi berupa obat-obatan"
            }
        }

        For Each category In categories
            categoryRepository.Insert(category)
        Next
    End Sub

    Private Sub SeedingProducts()
        Dim categories = categoryRepository.GetAll().Data()
        Dim products As New List(Of Product) From {
            New Product With {
                .Id = Guid.NewGuid().ToString(),
                .CategoryId = categories(0).Id,
                .ProductName = "Mie Instant",
                .ProductCode = "FD-01-MI",
                .Image = "/paht/to/image.jpg",
                .PuchasePrice = 10000,
                .SellingPrice = 11000,
                .Stock = 10,
                .MinumumStock = 1
            },
            New Product With {
                .Id = Guid.NewGuid().ToString(),
                .CategoryId = categories(1).Id,
                .ProductName = "Sirup",
                .ProductCode = "DR-01-SR",
                .Image = "/path/to/image.jpg",
                .PuchasePrice = 10000,
                .SellingPrice = 11000,
                .Stock = 10,
                .MinumumStock = 1
            },
            New Product With {
                .Id = Guid.NewGuid().ToString(),
                .CategoryId = categories(2).Id,
                .ProductName = "Paracetamol",
                .ProductCode = "MC-01-PM",
                .Image = "/path/to/image.jpg",
                .PuchasePrice = 10000,
                .SellingPrice = 11000,
                .Stock = 10,
                .MinumumStock = 1
            },
            New Product With {
                .Id = Guid.NewGuid().ToString(),
                .CategoryId = categories(0).Id,
                .ProductName = "Biskuit",
                .ProductCode = "FD-02-BC",
                .Image = "/path/to/image.jpg",
                .PuchasePrice = 10000,
                .SellingPrice = 11000,
                .Stock = 10,
                .MinumumStock = 1
            }
        }

        For Each product In products
            productRepository.Insert(product)
        Next
    End Sub

    ' Test Insert Product
    <Test>
    Public Sub TestInsertProduct_ShouldReturnSuccessWithValidData()
        Dim categories = categoryRepository.GetAll().Data()
        Dim productId As String = Guid.NewGuid().ToString()
        Dim product As New Product With {
            .Id = productId,
            .CategoryId = categories(0).Id,
            .ProductName = "Beras",
            .ProductCode = "FD-03-BR",
            .PuchasePrice = 15000,
            .SellingPrice = 16000,
            .Image = "/path/to/image.jpg",
            .Stock = 11,
            .MinumumStock = 1
        }

        Dim insertProductResult = productRepository.Insert(product)
        Assert.That(insertProductResult.Error, [Is].Null, "Error from insert product should be null")
        Assert.That(insertProductResult.Success, [Is].True, "Success from insert product should be True")
        Assert.That(insertProductResult.Message, [Is].EqualTo("Berhasil tambah data."), "Message from insert product response should be match")

        Dim getProductResult = productRepository.GetById(productId)
        Assert.That(getProductResult.Error, [Is].Null, "Error from get product should be null")
        Assert.That(getProductResult.Success, [Is].True, "Success from get product should be True")
        Assert.That(getProductResult.Message, [Is].EqualTo("Berhasil mendapatkan data."), "Message from get product response should be match")
        Assert.That(getProductResult.Data, [Is].Not.Null, "Product data should be not null")
        Assert.That(getProductResult.Data.ProductName, [Is].EqualTo("Beras"), "Product name should be match with insert product data")
        Assert.That(getProductResult.Data.ProductCode, [Is].EqualTo("FD-03-BR"), "Product code should be match with insert product data")
        Assert.That(getProductResult.Data.CategoryId, [Is].EqualTo(categories(0).Id), "Product category id should be match with insert product data")
    End Sub

    ' Test Update Product
    <Test>
    Public Sub TestUpdateProduct_ShouldReturnSuccessWithNewProductDataAfterUpdated()
        Dim categories = categoryRepository.GetAll().Data()
        Dim productId As String = Guid.NewGuid().ToString()
        Dim product As New Product With {
            .Id = productId,
            .CategoryId = categories(0).Id,
            .ProductName = "Telur",
            .ProductCode = "FD-04-EGG",
            .Image = "/path/to/image.jpg",
            .PuchasePrice = "14000",
            .SellingPrice = "16000",
            .Stock = 100,
            .MinumumStock = 1
        }

        Dim insertProductResult = productRepository.Insert(product)
        Assert.That(insertProductResult.Error, [Is].Null, "Error from insert product response should be null")
        Assert.That(insertProductResult.Success, [Is].True, "Success from insert product response should be True")
        Assert.That(insertProductResult.Message, [Is].EqualTo("Berhasil tambah data."), "Message from insert product response should be match")

        Dim getProductResult = productRepository.GetById(productId)
        Assert.That(getProductResult.Error, [Is].Null, "Error from get product response should be null")
        Assert.That(getProductResult.Success, [Is].True, "Success from get product response should be True")
        Assert.That(getProductResult.Message, [Is].EqualTo("Berhasil mendapatkan data."), "Message from get product response should be match")
        Assert.That(getProductResult.Data, [Is].Not.Null, "Product data should be not null")
        Assert.That(getProductResult.Data.ProductName, [Is].EqualTo("Telur"), "Product name should be match")
        Assert.That(getProductResult.Data.ProductCode, [Is].EqualTo("FD-04-EGG"), "Product code should be match")

        Dim getCategoryResult = categoryRepository.GetById(categories(0).Id)
        Assert.That(getCategoryResult.Error, [Is].Null, "Error from get category should be null")
        Assert.That(getCategoryResult.Success, [Is].True, "Success from get category response should be True")
        Assert.That(getCategoryResult.Message, [Is].EqualTo("Berhasil mendapatkan data."), "Message from get category response should be match")
        Assert.That(getCategoryResult.Data, [Is].Not.Null, "Category data should be not null")
        Assert.That(getCategoryResult.Data.CategoryName, [Is].EqualTo("Makanan"), "Category name should be match")

        Dim updatedProduct = getProductResult.Data()
        updatedProduct.ProductName = "Salep panu"
        updatedProduct.CategoryId = categories(2).Id
        updatedProduct.ProductCode = "MC-02-SP"
        updatedProduct.Image = "/new/path/to/image.jpg"
        updatedProduct.PuchasePrice = 23000
        updatedProduct.SellingPrice = 25000
        updatedProduct.Stock = 50

        Dim updateProductResult = productRepository.Update(updatedProduct)
        Assert.That(updateProductResult.Error, [Is].Null, "Error from update product response should be null")
        Assert.That(updateProductResult.Success, [Is].True, "Success from update product response should be True")
        Assert.That(updateProductResult.Message, [Is].EqualTo("Berhasil memperbarui data."), "Message from update product response should be match")

        Dim getUpdatedProductResult = productRepository.GetById(productId)
        Assert.That(getUpdatedProductResult.Error, [Is].Null, "Error from get updated product should be null")
        Assert.That(getUpdatedProductResult.Success, [Is].True, "Success from get updated product should be True")
        Assert.That(getUpdatedProductResult.Message, [Is].EqualTo("Berhasil mendapatkan data."), "Message from get updated product should be match")
        Assert.That(getUpdatedProductResult.Data, [Is].Not.Null, "Product data should be not null")
        Assert.That(getUpdatedProductResult.Data.ProductName, [Is].EqualTo("Salep panu"), "Product name should be match with updated data")
        Assert.That(getUpdatedProductResult.Data.ProductCode, [Is].EqualTo("MC-02-SP"), "Product code should be match with updated data")
        Assert.That(getUpdatedProductResult.Data.CategoryId, [Is].EqualTo(categories(2).Id), "Product category id should be match with new product category id")
    End Sub

    ' Test Delete Product
    <Test>
    Public Sub TestDeleteProduct_ShouldReturnSuccessWithNoExistsProduct()
        ' Insert product first
        Dim foodCategory As Category = categoryRepository.GetAll().Data(0)
        Dim productId As String = Guid.NewGuid().ToString()
        Dim product As New Product With {
            .Id = productId,
            .CategoryId = foodCategory.Id,
            .ProductName = "Sereal",
            .ProductCode = "FD-01-SE",
            .Image = "/path/to/image.jpg",
            .PuchasePrice = 10000,
            .SellingPrice = 11000,
            .Stock = 100,
            .MinumumStock = 1
        }

        Dim insertProductResult = productRepository.Insert(product)
        Assert.That(insertProductResult.Error, [Is].Null, "Error from insert product response should be null")
        Assert.That(insertProductResult.Success, [Is].True, "Success from insert product response should be True")
        Assert.That(insertProductResult.Message, [Is].EqualTo("Berhasil tambah data."), "Message from insert product response should be match")

        ' Delete product
        Dim deleteProductResult = productRepository.Delete(productId)
        Assert.That(deleteProductResult.Error, [Is].Null, "Error from delete product response should be null")
        Assert.That(deleteProductResult.Success, [Is].True, "Success from delete product response should be True")
        Assert.That(deleteProductResult.Message, [Is].EqualTo("Berhasil hapus data."), "Message from delete product response should be match")

        ' Check existing product
        Dim getDeletedProduct = productRepository.GetById(productId)
        Assert.That(getDeletedProduct.Error, [Is].Null, "Error from get product response should be null")
        Assert.That(getDeletedProduct.Success, [Is].True, "Success from get product response should be True")
        Assert.That(getDeletedProduct.Message, [Is].EqualTo("Tidak ada data."), "Message from get product response should be match")
        Assert.That(getDeletedProduct.Data, [Is].Null, "Product data should be null")
    End Sub

    ' Test Get All Products
    <Test>
    Public Sub TestGetAllProduct_ShouldReturnSuccessWithAllProducts()
        Dim getAllProductResult = productRepository.GetAll()
        Assert.That(getAllProductResult.Error, [Is].Null, "Error from get all product response should be null")
        Assert.That(getAllProductResult.Success, [Is].True, "Success from get all product response should be True")
        Assert.That(getAllProductResult.Message, [Is].EqualTo("Berhasil mendapatkan seluruh data."), "Message from get all product response should be match")
        Assert.That(getAllProductResult.Data, [Is].Not.Null, "Product data should be not null")
    End Sub

    <Test>
    Public Sub TestGetAllProduct_ShouldReturnSuccessWithEmptyProduct()
        ClearAllProducts() ' Clear all product first

        Dim getAllProductResult = productRepository.GetAll()
        Assert.That(getAllProductResult.Error, [Is].Null, "Error from get all product response should be null")
        Assert.That(getAllProductResult.Success, [Is].True, "Success from get all product response should be True")
        Assert.That(getAllProductResult.Message, [Is].EqualTo("Tidak ada data."), "Message from get all product response should be match")
        Assert.That(getAllProductResult.Data, [Is].Null, "Product data should be null")
    End Sub
End Class
