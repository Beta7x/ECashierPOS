Imports ECashierPOS.Database.Factories
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Utils
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Bcpg.Sig

Namespace Models.Repositories
    Public Class CategoryRepository
        Inherits GenericRepository(Of Category)
        Implements ICategoryRepository

        Public Sub New(factory As IDbConnectionFactory)
            MyBase.New(factory)
        End Sub

        Protected Overrides ReadOnly Property TableName As String
            Get
                Return "categories"
            End Get
        End Property

        Protected Overrides ReadOnly Property DefaultOrderBy As String
            Get
                Return "category_name"
            End Get
        End Property

        Protected Overrides Function MapEntity(reader As IDataReader) As Category
            Return New Category With {
                .Id = reader("id").ToString(),
                .CategoryName = reader("category_name").ToString(),
                .Description = If(IsDBNull(reader("description")), Nothing, CType(reader("description"), String)),
                .CreatedAt = Convert.ToDateTime(reader("created_at")),
                .UpdatedAt = If(IsDBNull(reader("updated_at")), Nothing, CType(reader("updated_at"), DateTime?))
            }
        End Function

        Protected Overrides Function MapFields(entity As Category) As Dictionary(Of String, Object)
            Return New Dictionary(Of String, Object) From {
                {"id", entity.Id},
                {"category_name", entity.CategoryName},
                {"description", entity.Description}
            }
        End Function

        Public Function IsCategoryInUse(id As String) As OperationResult(Of Boolean) Implements ICategoryRepository.IsCategoryInUse
            Dim sql As String = "SELECT COUNT(*) FROM products WHERE category_id = @id"
            Try
                Using conn As IDbConnection = GetConnection()
                    conn.Open()

                    Using cmd As IDbCommand = conn.CreateCommand()
                        cmd.CommandText = sql

                        Dim param = cmd.CreateParameter()
                        param.ParameterName = "@id"
                        param.Value = id
                        cmd.Parameters.Add(param)

                        Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                        If result > 0 Then
                            Return OperationResult(Of Boolean).Ok(True, "Kategori tidak dipakai oleh produk lain.")
                        End If

                        Return OperationResult(Of Boolean).Ok(False, "Kategori digunakan oleh produk lain.")
                    End Using
                End Using
            Catch ex As Exception
                Return OperationResult(Of Boolean).Fail($"[GET COUNT] Gagal mendapatkan data: {ex.Message}", ex)
            End Try
        End Function

        Public Function SearchCategory(keyword As String) As OperationResult(Of List(Of Category)) Implements ICategoryRepository.SearchCategory
            Dim categories As New List(Of Category)
            Dim sql As String =
                $"SELECT 
                    c.id,
                    c.category_name,
                    c.description,
                    c.created_at,
                    COUNT(p.id) AS product_items
                FROM {TableName} c
                LEFT JOIN products p ON p.category_id = c.id
                WHERE c.category_name LIKE @keyword OR c.description LIKE @keyword
                GROUP BY
                    c.id,
                    c.category_name
                ORDER BY c.category_name ASC"

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
                                categories.Add(New Category With {
                                    .Id = reader("id").ToString(),
                                    .CategoryName = reader("category_name").ToString(),
                                    .Description = reader("description").ToString(),
                                    .CreatedAt = Convert.ToDateTime(reader("created_at")),
                                    .ProductItems = Convert.ToInt32(reader("product_items"))
                                })
                            End While
                        End Using
                    End Using

                    If categories.Count = 0 Then
                        Return OperationResult(Of List(Of Category)).Ok(Nothing, "Tidak ada data.")
                    End If

                    Return OperationResult(Of List(Of Category)).Ok(categories, "Berhasil mendapatkan data.")
                End Using
            Catch ex As Exception
                Return OperationResult(Of List(Of Category)).Fail($"[SEARCH] Gagal mendapatkan data: {ex.Message}", ex)
            End Try
        End Function

        Public Function GetAllWithCountItems() As OperationResult(Of List(Of Category)) Implements ICategoryRepository.GetAllWithCountItems
            Dim list As New List(Of Category)()
            Dim sql As String = $"
                SELECT 
                    c.id,
                    c.category_name,
                    c.description,
                    c.created_at,
                    COUNT(p.id) AS product_items
                FROM {TableName} c
                LEFT JOIN products p ON p.category_id = c.id
                GROUP BY
                    c.id,
                    c.category_name
                ORDER BY c.category_name ASC"

            Try
                Using conn As IDbConnection = GetConnection()
                    conn.Open()
                    Using cmd As IDbCommand = conn.CreateCommand()
                        Using reader As IDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                list.Add(New Category With {
                                    .Id = reader("id").ToString(),
                                    .CategoryName = reader("category_name").ToString(),
                                    .Description = reader("description").ToString(),
                                    .CreatedAt = Convert.ToDateTime(reader("created_at")),
                                    .ProductItems = Convert.ToInt32(reader("product_items"))
                                })
                            End While
                        End Using
                    End Using
                End Using

                If list.Count = 0 Then
                    Return OperationResult(Of List(Of Category)).Ok(Nothing, "Tidak ada data.")
                End If

                Return OperationResult(Of List(Of Category)).Ok(list, "Berhasil mendapatkan seluruh data.")
            Catch ex As Exception
                Return OperationResult(Of List(Of Category)).Fail($"[GET ALL] Gagal mendapatkan data: {ex.Message}", ex)
            End Try
        End Function
    End Class
End Namespace
