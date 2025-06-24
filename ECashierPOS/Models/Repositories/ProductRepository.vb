Imports ECashierPOS.Database.Factories
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Utils
Imports MySql.Data.MySqlClient

Namespace Models.Repositories
    Public Class ProductRepository
        Inherits GenericRepository(Of Product)
        Implements IProductRepository

        Public Sub New(factory As IDbConnectionFactory)
            MyBase.New(factory)
        End Sub

        Protected Overrides ReadOnly Property DefaultOrderBy As String
            Get
                Return "product_name"
            End Get
        End Property

        Protected Overrides ReadOnly Property TableName As String
            Get
                Return "products"
            End Get
        End Property

        Protected Overrides Function MapEntity(reader As IDataReader) As Product
            Return New Product With {
                .Id = reader("id").ToString(),
                .CategoryId = reader("category_id").ToString(),
                .ProductName = reader("product_name").ToString(),
                .Description = reader("description").ToString(),
                .ProductCode = reader("product_code").ToString(),
                .PuchasePrice = Convert.ToDouble(reader("purchase_price")),
                .SellingPrice = Convert.ToDouble(reader("selling_price")),
                .Stock = Convert.ToInt32(reader("stock")),
                .MinumumStock = Convert.ToInt32(reader("minimum_stock")),
                .Image = reader("image").ToString(),
                .CreatedAt = Convert.ToDateTime(reader("created_at")),
                .UpdatedAt = If(IsDBNull(reader("updated_at")), Nothing, CType(reader("updated_at"), DateTime?))
            }
        End Function

        Protected Overrides Function MapFields(entity As Product) As Dictionary(Of String, Object)
            Return New Dictionary(Of String, Object) From {
                {"id", entity.Id},
                {"category_id", entity.CategoryId},
                {"product_name", entity.ProductName},
                {"description", entity.Description},
                {"product_code", entity.ProductCode},
                {"purchase_price", entity.PuchasePrice},
                {"selling_price", entity.SellingPrice},
                {"stock", entity.Stock},
                {"minimum_stock", entity.MinumumStock},
                {"image", entity.Image}
            }
        End Function

        Public Function SearchProduct(keyword As String) As OperationResult(Of List(Of Product)) Implements IProductRepository.SearchProduct
            Dim products As New List(Of Product)
            Dim sql As String =
                $"SELECT * FROM {TableName}
                WHERE product_name LIKE @keyword OR description LIKE @keyword ORDER BY product_name ASC"

            Try
                Using conn As IDbConnection = GetConnection()
                    conn.Open()
                    Using cmd As IDbCommand = conn.CreateCommand()
                        cmd.CommandText = sql

                        Dim param = cmd.CreateParameter()
                        param.ParameterName = "@keyword"
                        param.Value = "%" & keyword & "%"
                        cmd.Parameters.Add(param)

                        Using reader As IDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                products.Add(MapEntity(reader))
                            End While
                        End Using
                    End Using
                End Using

                If products.Count = 0 Then
                    Return OperationResult(Of List(Of Product)).Ok(Nothing, "Tidak ada data.")
                End If

                Return OperationResult(Of List(Of Product)).Ok(products, "Berhasil mendapatkan data.")
            Catch ex As Exception
                Return OperationResult(Of List(Of Product)).Fail($"[SEARCH] Gagal mendapatkan data: {ex.Message}", ex)
            End Try
        End Function
    End Class
End Namespace
