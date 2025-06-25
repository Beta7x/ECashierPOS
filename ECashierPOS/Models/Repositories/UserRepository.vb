Imports ECashierPOS.Database.Factories
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Utils

Namespace Models.Repositories
    Public Class UserRepository
        Inherits GenericRepository(Of User)
        Implements IUserRepository

        Public Sub New(factory As IDbConnectionFactory)
            MyBase.New(factory)
        End Sub

        Protected Overrides ReadOnly Property TableName As String
            Get
                Return "users"
            End Get
        End Property

        Protected Overrides ReadOnly Property DefaultOrderBy As String
            Get
                Return "full_name"
            End Get
        End Property

        Protected Overrides Function MapEntity(reader As IDataReader) As User
            Return New User With {
                .Id = reader("id").ToString(),
                .FullName = reader("full_name").ToString(),
                .Username = reader("username").ToString(),
                .Password = reader("password").ToString(),
                .Role = reader("role").ToString(),
                .CreatedAt = Convert.ToDateTime(reader("created_at")),
                .UpdatedAt = If(IsDBNull(reader("updated_at")), Nothing, CType(reader("updated_at"), DateTime?))
            }
        End Function

        Protected Overrides Function MapFields(entity As User) As Dictionary(Of String, Object)
            Return New Dictionary(Of String, Object) From {
                {"id", entity.Id},
                {"full_name", entity.FullName},
                {"username", entity.Username},
                {"password", entity.Password},
                {"role", entity.Role}
            }
        End Function

        Public Function GetByUsername(username As String) As OperationResult(Of User) Implements IUserRepository.GetByUsername
            Dim sql As String = $"SELECT * FROM {TableName} WHERE username=@username"
            Try
                Using conn As IDbConnection = GetConnection()
                    conn.Open()
                    Using cmd As IDbCommand = conn.CreateCommand()
                        cmd.CommandText = sql

                        Dim param = cmd.CreateParameter()
                        param.ParameterName = "@username"
                        param.Value = "%" & username & "%"
                        cmd.Parameters.Add(param)

                        Using reader As IDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                Return OperationResult(Of User).Ok(MapEntity(reader), "Berhasil mendapatkan data.")
                            End If
                        End Using

                        Return OperationResult(Of User).Ok(Nothing, "Tidak ada data.")
                    End Using
                End Using
            Catch ex As Exception
                Return OperationResult(Of User).Fail($"[GET BY USERNAME] Gagal mendapatkan data: {ex.Message}", ex)
            End Try
        End Function
    End Class
End Namespace
