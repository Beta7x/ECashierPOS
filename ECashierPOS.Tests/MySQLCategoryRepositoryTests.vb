Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Models.Repositories
Imports MySql.Data.MySqlClient
Imports NUnit.Framework

<TestFixture>
Public Class MySQLCategoryRepositoryTests
    Private repository As ICategoryRepository
    Private connectionString As String

    <SetUp>
    Public Sub Setup()
        connectionString = "server=localhost;user=root;password=beta7x;database=e_cashier_test;"
        repository = New MySQLCategoryRepository(connectionString)

        ClearCategories()
        SeedingCategories()
    End Sub

    <TearDown>
    Public Sub Teardown()
        ClearCategories()
    End Sub

    Private Sub ClearCategories()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM categories", conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
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
                .CategoryName = "Perkakas",
                .Description = "Kategori untuk produk berupa bahan bangunan dan kelengkapan kerja"
            }
        }

        For Each categori In categories
            repository.Insert(categori)
        Next
    End Sub

    <Test>
    Public Sub TestInsertCategory_ShouldRetunSuccessWithValidData()
        Dim categoryId As String = Guid.NewGuid().ToString()
        Dim category As New Category With {
            .Id = categoryId,
            .CategoryName = "Kategori A",
            .Description = "Test kategori untuk tipe jenis barang A"
        }

        Dim result = repository.Insert(category)
        Assert.That(result.Error, [Is].Null, "Error should be null")
        Assert.That(result.Success, [Is].True, "Success should be True")
        Assert.That(result.Message, [Is].EqualTo("Berhasil tambah data."), "Message should be match from response")

        Dim newCategory = repository.GetById(categoryId)
        Assert.That(newCategory.Error, [Is].Null, "Error should be null")
        Assert.That(newCategory.Success, [Is].True, "Success should be True")
        Assert.That(newCategory.Data, [Is].Not.Null, "Data should be not null")
        Assert.That(newCategory.Data.CategoryName, [Is].EqualTo("Kategori A"), "Category name should be match")
        Assert.That(newCategory.Data.Description, [Is].EqualTo("Test kategori untuk tipe jenis barang A"))
    End Sub
End Class
