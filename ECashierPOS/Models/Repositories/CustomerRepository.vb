Imports ECashierPOS.Database.Factories
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Utils
Imports MySql.Data.MySqlClient

Namespace Models.Repositories
    Public Class CustomerRepository
        Inherits GenericRepository(Of Customer)
        Implements ICustomerRepository

        Public Sub New(factory As IDbConnectionFactory)
            MyBase.New(factory)
        End Sub

        Protected Overrides ReadOnly Property TableName As String
            Get
                Return "customers"
            End Get
        End Property

        Protected Overrides ReadOnly Property DefaultOrderBy As String
            Get
                Return "name"
            End Get
        End Property

        Protected Overrides Function MapEntity(reader As IDataReader) As Customer
            Return New Customer With {
                .Id = reader("id").ToString(),
                .Name = reader("name").ToString(),
                .Phone = reader("phone").ToString(),
                .Address = reader("address").ToString(),
                .CreatedAt = Convert.ToDateTime(reader("created_at")),
                .UpdatedAt = If(IsDBNull(reader("updated_at")), Nothing, CType(reader("updated_at"), DateTime?))
            }
        End Function

        Protected Overrides Function MapFields(entity As Customer) As Dictionary(Of String, Object)
            Return New Dictionary(Of String, Object) From {
                {"id", entity.Id},
                {"name", entity.Name},
                {"phone", entity.Phone},
                {"address", entity.Address}
            }
        End Function

        Public Function SearchCustomer(keyword As String) As OperationResult(Of List(Of Customer)) Implements ICustomerRepository.SearchCustomer
            Dim customers As New List(Of Customer)
            Dim sql As String =
                $"SELECT * FROM {TableName}
                WHERE name LIKE @keyword OR phone LIKE @keyword OR address LIKE @keyword
                ORDER BY name ASC"

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
                                customers.Add(MapEntity(reader))
                            End While

                        End Using
                    End Using
                End Using

                If customers.Count = 0 Then
                    Return OperationResult(Of List(Of Customer)).Ok(Nothing, "Tidak ada data.")
                End If

                Return OperationResult(Of List(Of Customer)).Ok(customers, "Berhasil mendapatkan data.")
            Catch ex As Exception
                Return OperationResult(Of List(Of Customer)).Fail($"[SEARCH] Gagal mendapatkan data: {ex.Message}", ex)
            End Try
        End Function
    End Class
End Namespace
