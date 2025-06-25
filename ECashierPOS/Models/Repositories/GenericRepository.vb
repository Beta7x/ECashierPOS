Imports ECashierPOS.Database.Factories
Imports ECashierPOS.Helpers
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Utils

Namespace Models.Repositories
    Public MustInherit Class GenericRepository(Of T As {Class, IEntity})
        Implements IRepository(Of T)

        Private ReadOnly connectionFactory As IDbConnectionFactory

        Public Sub New(connectionFactory As IDbConnectionFactory)
            Me.connectionFactory = connectionFactory
        End Sub

        Protected MustOverride ReadOnly Property TableName As String
        Protected Overridable ReadOnly Property KeyField As String
            Get
                Return "id"
            End Get
        End Property

        Protected Overridable ReadOnly Property DefaultOrderBy As String
            Get
                Return "created_at" ' default: no ordering
            End Get
        End Property

        Protected Overridable ReadOnly Property DefaultSortDirection As String
            Get
                Return "ASC"
            End Get
        End Property

        Protected MustOverride Function MapEntity(reader As IDataReader) As T
        Protected MustOverride Function MapFields(entity As T) As Dictionary(Of String, Object)


        Protected Function GetConnection() As IDbConnection
            Return connectionFactory.CreateConnection()
        End Function

        Public Function Insert(item As T) As OperationResult Implements IRepository(Of T).Insert
            Try
                Using conn As IDbConnection = GetConnection()
                    conn.Open()
                    Dim fields = MapFields(item)
                    Dim cmd = SqlHelper.CreateInsertCommand(TableName, fields, conn)

                    If cmd.ExecuteNonQuery() > 0 Then
                        Return OperationResult.Ok("Berhasil tambah data.")
                    End If

                    Return OperationResult.Ok("Data sudah ditambahkan.")
                End Using
            Catch ex As Exception
                Return OperationResult.Fail($"[INSERT] Gagal menyimpan data: {ex.Message}", ex)
            End Try
        End Function

        Public Function Update(item As T) As OperationResult Implements IRepository(Of T).Update
            Try
                Using conn As IDbConnection = GetConnection()
                    conn.Open()
                    Dim fields = MapFields(item)
                    Dim cmd = SqlHelper.CreateUpdateCommand(TableName, fields, KeyField, item.Id, conn,
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

        Public Function Delete(id As String) As OperationResult Implements IRepository(Of T).Delete
            Try
                Using conn As IDbConnection = GetConnection()
                    conn.Open()
                    Dim cmd = SqlHelper.CreateDeleteCommand(TableName, KeyField, id, conn)
                    If cmd.ExecuteNonQuery() > 0 Then
                        Return OperationResult.Ok("Berhasil hapus data.")
                    End If

                    Return OperationResult.Ok("Data sudah dihapus.")
                End Using
            Catch ex As Exception
                Return OperationResult.Fail($"[DELETE] Gagal menghapus data: {ex.Message}", ex)
            End Try
        End Function

        Public Function GetById(id As String) As OperationResult(Of T) Implements IRepository(Of T).GetById
            Dim result As T
            Try
                Using conn As IDbConnection = GetConnection()
                    conn.Open()
                    Dim cmd = SqlHelper.CreateSelectByIdCommand(TableName, KeyField, id, conn)
                    Using reader As IDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            result = MapEntity(reader)
                            Return OperationResult(Of T).Ok(result, "Berhasil mendapatkan data.")
                        End If
                    End Using

                    Return OperationResult(Of T).Ok(Nothing, "Tidak ada data.")
                End Using
            Catch ex As Exception
                Return OperationResult(Of T).Fail($"[GET BY ID] Gagal mendapatkan data: {ex.Message}", ex)
            End Try
        End Function

        Public Function GetAll() As OperationResult(Of List(Of T)) Implements IRepository(Of T).GetAll
            Dim list As New List(Of T)()
            Try
                Using conn As IDbConnection = GetConnection()
                    conn.Open()
                    Dim cmd = SqlHelper.CreateSelectAllCommand(TableName, conn, DefaultOrderBy, DefaultSortDirection)
                    Using reader As IDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            list.Add(MapEntity(reader))
                        End While
                    End Using
                End Using

                If list.Count = 0 Then
                    Return OperationResult(Of List(Of T)).Ok(Nothing, "Tidak ada data.")
                End If

                Return OperationResult(Of List(Of T)).Ok(list, "Berhasil mendapatkan seluruh data.")
            Catch ex As Exception
                Return OperationResult(Of List(Of T)).Fail($"[GET ALL] Gagal mendapatkan data: {ex.Message}", ex)
            End Try
        End Function
    End Class
End Namespace
