Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Utils

Namespace Models.Interfaces
    Public Interface IUserRepository
        Inherits IRepository(Of User)

        Function GetByUsername(username As String) As OperationResult(Of User)
        Function SearchUser(keyword As String) As OperationResult(Of List(Of User))
        Function UpdateWithoutPassword(entity As User) As OperationResult
    End Interface
End Namespace
