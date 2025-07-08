Imports ECashierPOS.Models.DTO
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Services.Interfaces
Imports ECashierPOS.Utils

Namespace Controllers
    Public Class UserController
        Private ReadOnly userService As IUserService

        Public Sub New(userService As IUserService, userRepository As IUserRepository)
            Me.userService = userService
        End Sub

        Public Function GetAll() As OperationResult(Of List(Of User))
            Return userService.GetAllUsers()
        End Function

        Public Function GetUserById(id As String) As OperationResult(Of User)
            Return userService.GetUserById(id)
        End Function

        Public Function UpdateUser(updateRequest As UserDTO) As OperationResult
            Return userService.UpdateUser(updateRequest)
        End Function

        Public Function AddUser(createRequest As UserDTO) As OperationResult
            Return userService.AddUser(createRequest)
        End Function

        Public Function DeleteUser(id As String) As OperationResult
            Return userService.DeleteUser(id)
        End Function
    End Class
End Namespace
