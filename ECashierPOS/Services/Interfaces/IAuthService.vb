Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Utils

Namespace Services.Interfaces
    Public Interface IAuthService
        Function Login(username As String, password As String) As OperationResult(Of User)
    End Interface
End Namespace
