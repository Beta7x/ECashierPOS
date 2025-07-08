Imports ECashierPOS.Models.DTO
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Utils

Namespace Services.Interfaces
    Public Interface IUserService
        Function AddUser(createUserRequest As UserDTO) As OperationResult
        Function UpdateUser(updateUserRequest As UserDTO) As OperationResult
        Function DeleteUser(userId As String) As OperationResult
        Function GetUserById(userId As String) As OperationResult(Of User)
        Function GetAllUsers() As OperationResult(Of List(Of User))
        Function SearchUser(keyword As String) As OperationResult(Of List(Of User))
    End Interface
End Namespace
