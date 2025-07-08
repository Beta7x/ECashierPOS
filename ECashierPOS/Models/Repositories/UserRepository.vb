Imports ECashierPOS.Database.Factories
Imports ECashierPOS.Helpers
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
                        param.Value = username
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

        Public Function SearchUser(keyword As String) As OperationResult(Of List(Of User)) Implements IUserRepository.SearchUser
            Dim users As New List(Of User)
            Dim sql As String =
                $"SELECT * FROM {TableName}
                WHERE full_name LIKE @keyword OR username LIKE @keyword OR role like @keyword ORDER BY full_name ASC"

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
                                users.Add(MapEntity(reader))
                            End While
                        End Using
                    End Using
                End Using

                If users.Count = 0 Then
                    Return OperationResult(Of List(Of User)).Ok(Nothing, "Tidak ada data.")
                End If

                Return OperationResult(Of List(Of User)).Ok(users, "Berhasil mendapatkan data.")
            Catch ex As Exception
                Return OperationResult(Of List(Of User)).Fail($"[SEARCH] Gagal mendapatkan data: {ex.Message}", ex)
            End Try
        End Function

        Public Function UpdateWithoutPassword(entity As User) As OperationResult Implements IUserRepository.UpdateWithoutPassword
            Try
                Using conn As IDbConnection = GetConnection()
                    conn.Open()
                    Dim fields = New Dictionary(Of String, Object) From {
                        {"id", entity.Id},
                        {"full_name", entity.FullName},
                        {"username", entity.Username},
                        {"role", entity.Role}
                    }
                    Dim cmd = SqlHelper.CreateUpdateCommand(TableName, fields, KeyField, entity.Id, conn,
                                                            excludedFields:=New List(Of String) From {KeyField})

                    If cmd.ExecuteNonQuery() > 0 Then
                        Return OperationResult.Ok("Berhasil memperbarui data.")
                    End If

                    Return OperationResult.Ok("Data sudah diperbarui.")
                End Using
            Catch ex As Exception
                Return OperationResult.Fail($"[UPDATE] Gagal memperbarui data: {ex.Message}", ex)
            End Try
        End Function
    End Class
End Namespace
