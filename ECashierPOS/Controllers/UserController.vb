Imports ECashierPOS.Models.DTO
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Models.Repositories
Imports ECashierPOS.Utils
Imports ECashierPOS.Validators

Namespace Controllers
    Public Class UserController
        Private ReadOnly repository As IUserRepository
        Private ReadOnly validator As UserValidator

        Public Sub New(userRepository As MySQLUserRepository)
            repository = userRepository
            validator = New UserValidator()
        End Sub

        Public Function GetAll() As OperationResult(Of List(Of User))
            Return repository.GetAll()
        End Function

        Public Function UpdateUser(updateRequest As UserDTO) As OperationResult
            Dim validation = validator.ValidateUpdate(updateRequest)

            If Not validation.IsValid Then
                Dim errorMessage As String = Nothing
                For Each errMsg In validation.Errors
                    errorMessage &= errMsg
                Next
                Return OperationResult.Fail(errorMessage)
            End If

            Dim user As New User With {
                .Id = updateRequest.Id,
                .FullName = updateRequest.FullName,
                .Username = updateRequest.Username,
                .Password = updateRequest.Password,
                .Role = updateRequest.Role
            }

            Return repository.Update(user)
        End Function

        Public Function AddUser(createRequest As UserDTO) As OperationResult
            Dim validation = validator.ValidateCreate(createRequest)

            If Not validation.IsValid Then
                Dim errorMessage As String = Nothing
                For Each errMsg In validation.Errors
                    errorMessage &= errMsg
                Next
                Return OperationResult.Fail(errorMessage)
            End If

            Dim user As New User With {
                .Id = Guid.NewGuid().ToString(),
                .FullName = createRequest.FullName,
                .Username = createRequest.Username,
                .Password = createRequest.Password,
                .Role = createRequest.Role
            }

            Return repository.Insert(user)
        End Function

        Public Function DeleteUser(id As String) As OperationResult
            Dim validation = validator.ValidateDelete(id)
            If Not validation.IsValid Then
                Return OperationResult.Fail(validation.Errors(0))
            End If

            Return repository.Delete(id)
        End Function
    End Class
End Namespace
