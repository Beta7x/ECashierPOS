Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Utils

Namespace Models.Interfaces
    Public Interface IUserRepository
        Inherits IRepository(Of User)

        Function GetByUsername(username As String) As OperationResult(Of User)
    End Interface
End Namespace
