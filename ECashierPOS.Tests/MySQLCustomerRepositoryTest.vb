Imports System.Configuration
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Models.Repositories
Imports MySql.Data.MySqlClient
Imports NUnit.Framework

<TestFixture>
Public Class MySQLCustomerRepositoryTest
    Private repository As ICustomerRepository
    Private connectionString As String

    <SetUp>
    Public Sub Setup()
        connectionString = "server=localhost;user=root;password=beta7x;database=e_cashier_test;"
        'connectionString = ConfigurationManager.ConnectionStrings("MySQLConn").ConnectionString
        repository = New MySQLCustomerRepository(connectionString)

        ClearAllCustomers()
        SeedingCustomers()
    End Sub

    <TearDown>
    Public Sub Teardown()
        ClearAllCustomers()
    End Sub

    Private Sub ClearAllCustomers()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM customers", conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SeedingCustomers()
        Dim customers As New List(Of Customer) From {
            New Customer With {
                .Id = Guid.NewGuid().ToString(),
                .Name = "Customer A",
                .Phone = "000011112222",
                .Address = "Address of customer A"
            },
            New Customer With {
                .Id = Guid.NewGuid().ToString(),
                .Name = "Customer B",
                .Phone = "111122223333",
                .Address = "Address of customer B"
            },
            New Customer With {
                .Id = Guid.NewGuid().ToString(),
                .Name = "Customer C",
                .Phone = "222233334444",
                .Address = "Address of customer C"
            }
        }

        For Each customer In customers
            repository.Insert(customer)
        Next
    End Sub

    ' Test Insert Customer
    <Test>
    Public Sub TestInsertCustomer_ShouldReturnSuccessWithValidData()
        Dim customerId As String = Guid.NewGuid().ToString()
        Dim customer As New Customer With {
            .Id = customerId,
            .Name = "John Doe",
            .Phone = "000055551111",
            .Address = "John Doe Address"
        }

        Dim result = repository.Insert(customer)
        Assert.That(result.Error, [Is].Null, "Error insert customer should be null")
        Assert.That(result.Success, [Is].True, "Success insert customer should be True")
        Assert.That(result.Message, [Is].EqualTo("Berhasil tambah data."), "Message from insert customer response should be match")

        Dim newCustomer = repository.GetById(customerId)
        Assert.That(newCustomer.Error, [Is].Null, "Error get customer should be null")
        Assert.That(newCustomer.Success, [Is].True, "Success get customer should be True")
        Assert.That(newCustomer.Message, [Is].EqualTo("Berhasil mendapatkan data."), "Message from get customer response should be match")
        Assert.That(newCustomer.Data.Name, [Is].EqualTo("John Doe"), "Customer name should be match")
        Assert.That(newCustomer.Data.Phone, [Is].EqualTo("000055551111"), "Customer phone should be match")
    End Sub

    ' Test Get All Customers
    <Test>
    Public Sub TestGetAllCustomers_ShouldReturnSuccessWithNoEmptyData()
        Dim result = repository.GetAll()
        Assert.That(result.Error, [Is].Null, "Error get all customer should be null")
        Assert.That(result.Success, [Is].True, "Success get all customer should be True")
        Assert.That(result.Message, [Is].EqualTo("Berhasil mendapatkan seluruh data."), "Message from get all customers response should be match")
        Assert.That(result.Data, [Is].Not.Null, "Data from response should be not null")
        Assert.That(result.Data(0).Name, [Is].EqualTo("Customer A"), "First customer name should be match")
        Assert.That(result.Data(1).Name, [Is].EqualTo("Customer B"), "Second customer name should be match")
        Assert.That(result.Data(2).Name, [Is].EqualTo("Customer C"), "Third customer name should be match")
    End Sub

    ' Test Delete Customer
    <Test>
    Public Sub TestDeleteCustomer_ShouldSuccessWithNoCustomerDataExists()
        Dim customerId As String = Guid.NewGuid().ToString()
        Dim customer As New Customer With {
            .Id = customerId,
            .Name = "Deleted Customer",
            .Phone = "000000000000",
            .Address = "Deleted customer address"
        }

        Dim insertResult = repository.Insert(customer)
        Assert.That(insertResult.Error, [Is].Null, "Error insert customer should be null")
        Assert.That(insertResult.Success, [Is].True, "Success insert customer should be True")
        Assert.That(insertResult.Message, [Is].EqualTo("Berhasil tambah data."), "Message from insert customer response should be match")

        Dim deleteResult = repository.Delete(customerId)
        Assert.That(deleteResult.Error, [Is].Null, "Error delete customer should be null")
        Assert.That(deleteResult.Success, [Is].True, "Success delete customer should be True")
        Assert.That(deleteResult.Message, [Is].EqualTo("Berhasil hapus data."), "Message from delete customer response should be match")

        Dim customerResult = repository.GetById(customerId)
        Assert.That(customerResult.Error, [Is].Null, "Error get customer should be null")
        Assert.That(customerResult.Success, [Is].True, "Success get customer should be true")
        Assert.That(customerResult.Message, [Is].EqualTo("Tidak ada data."), "Message from get customer response should be match")
        Assert.That(customerResult.Data, [Is].Null, "Customer data should be null")
    End Sub

    <Test>
    Public Sub TestDeleteCustomer_WithNoExistingCustomerData_ShouldReturnSuccessWithNoCustumerData()
        Dim customerId As String = Guid.NewGuid().ToString()

        Dim deleteResult = repository.Delete(customerId)
        Assert.That(deleteResult.Error, [Is].Null, "Error delete customer should be null")
        Assert.That(deleteResult.Success, [Is].True, "Success delete customer should be True")
        Assert.That(deleteResult.Message, [Is].EqualTo("Data sudah dihapus."), "Message from delete customer response should be match")

        Dim getCustomerResult = repository.GetById(customerId)
        Assert.That(getCustomerResult.Error, [Is].Null, "Error get customer should be null")
        Assert.That(getCustomerResult.Success, [Is].True, "Success get customer should be True")
        Assert.That(getCustomerResult.Message, [Is].EqualTo("Tidak ada data."), "Message from get customer reponse should be match")
        Assert.That(getCustomerResult.Data, [Is].Null, "Customer data should be null")
    End Sub

    ' Test Update Customer
    <Test>
    Public Sub TestUpdateCustomer_ShouldReturnSuccesWithNewUpdatedCustomerData()
        Dim customerId As String = Guid.NewGuid().ToString()
        Dim customer As New Customer With {
            .Id = customerId,
            .Name = "John Doe",
            .Phone = "000011112222",
            .Address = "John Doe Address"
        }

        Dim insertResult = repository.Insert(customer)
        Assert.That(insertResult.Error, [Is].Null, "Error insert customer should be null")
        Assert.That(insertResult.Success, [Is].True, "Success insert customer should be True")
        Assert.That(insertResult.Message, [Is].EqualTo("Berhasil tambah data."), "Message from insert customer response should be match")

        Dim getCustomerResult = repository.GetById(customerId)
        Assert.That(getCustomerResult.Error, [Is].Null, "Error get customer should be null")
        Assert.That(getCustomerResult.Success, [Is].True, "Success get customer should be True")
        Assert.That(getCustomerResult.Message, [Is].EqualTo("Berhasil mendapatkan data."), "Message from get customer response should be match")
        Assert.That(getCustomerResult.Data.Name, [Is].EqualTo("John Doe"), "Customer name should be match")
        Assert.That(getCustomerResult.Data.Phone, [Is].EqualTo("000011112222"), "Customer phone should be match")
        Assert.That(getCustomerResult.Data.Address, [Is].EqualTo("John Doe Address"), "Customer address should be match")

        Dim updatedCustomer = getCustomerResult.Data
        updatedCustomer.Name = "Jane Doe"
        updatedCustomer.Address = "Jane Doe Address"

        Dim updateCustomerResutlt = repository.Update(updatedCustomer)
        Assert.That(updateCustomerResutlt.Error, [Is].Null, "Error update customer should be null")
        Assert.That(updateCustomerResutlt.Success, [Is].True, "Success update customer should be True")
        Assert.That(updateCustomerResutlt.Message, [Is].EqualTo("Berhasil memperbarui data."), "Message from update reponse customer should be match")

        Dim getUpdatedCustomerResult = repository.GetById(customerId)
        Assert.That(getUpdatedCustomerResult.Error, [Is].Null, "Error get customer should be null")
        Assert.That(getUpdatedCustomerResult.Success, [Is].True, "Success get customer should be True")
        Assert.That(getUpdatedCustomerResult.Message, [Is].EqualTo("Berhasil mendapatkan data."), "Message from get customer response should be match")
        Assert.That(getUpdatedCustomerResult.Data, [Is].Not.Null, "Data should be not null")
        Assert.That(getUpdatedCustomerResult.Data.Name, [Is].EqualTo("Jane Doe"), "Customer name should be match with new current name")
        Assert.That(getUpdatedCustomerResult.Data.Address, [Is].EqualTo("Jane Doe Address"), "Customer address should be match with new current address")
        Assert.That(getUpdatedCustomerResult.Data.UpdatedAt, [Is].Not.Null, "Customer UpdatedAt should be not null")
    End Sub
End Class
