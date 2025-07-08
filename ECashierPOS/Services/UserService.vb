Imports ECashierPOS.Helpers
Imports ECashierPOS.Models.DTO
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Services.Interfaces
Imports ECashierPOS.Utils
Imports ECashierPOS.Validators

Namespace Services
    Public Class UserService
        Implements IUserService

        Private ReadOnly userRepository As IUserRepository
        Private ReadOnly validator As UserValidator

        Public Sub New(userRepository As IUserRepository)
            Me.userRepository = userRepository
            Me.validator = New UserValidator()
        End Sub

        Public Function AddUser(createUserRequest As UserDTO) As OperationResult Implements IUserService.AddUser
            Dim validation = validator.ValidateCreate(createUserRequest)

            If Not validation.IsValid Then
                Dim errorMessage As String = Nothing
                For Each errMsg In validation.Errors
                    errorMessage &= errMsg
                Next

                Return OperationResult.Fail(errorMessage)
            End If

            Dim hashPassword = PasswordHelper.HashPassword(createUserRequest.Password)

            Dim newUser As New User With {
                .Id = Guid.NewGuid().ToString(),
                .FullName = createUserRequest.FullName,
                .Username = createUserRequest.Username,
                .Role = createUserRequest.Role,
                .Password = hashPassword
            }

            Return userRepository.Insert(newUser)
        End Function

        Public Function UpdateUser(updateUserRequest As UserDTO) As OperationResult Implements IUserService.UpdateUser
            Dim validation = validator.ValidateUpdate(updateUserRequest)

            If Not validation.IsValid Then
                Dim errorMessage As String = Nothing
                For Each errMsg In validation.Errors
                    errorMessage &= errMsg
                Next
                Return OperationResult.Fail(errorMessage)
            End If

            Dim user As New User With {
                .Id = updateUserRequest.Id,
                .FullName = updateUserRequest.FullName,
                .Username = updateUserRequest.Username,
                .Role = updateUserRequest.Role
            }

            If String.IsNullOrWhiteSpace(updateUserRequest.Password) Then
                Return userRepository.UpdateWithoutPassword(user)
            End If

            Dim newPasswordHash = PasswordHelper.HashPassword(updateUserRequest.Password)
            user.Password = newPasswordHash

            Return userRepository.Update(user)
        End Function

        Public Function GetAllUsers() As OperationResult(Of List(Of User)) Implements IUserService.GetAllUsers
            Return userRepository.GetAll()
        End Function

        Public Function DeleteUser(userId As String) As OperationResult Implements IUserService.DeleteUser
            Dim validation = validator.ValidateDelete(userId)
            If Not validation.IsValid Then
                Return OperationResult.Fail(validation.Errors(0))
            End If

            Return userRepository.Delete(userId)
        End Function

        Public Function GetUserById(userId As String) As OperationResult(Of User) Implements IUserService.GetUserById
            Dim validation = validator.ValidateGetById(userId)
            If Not validation.IsValid Then
                Return OperationResult(Of User).Fail(validation.Errors(0))
            End If
            Return userRepository.GetById(userId)
        End Function

        Public Function SearchUser(keyword As String) As OperationResult(Of List(Of User)) Implements IUserService.SearchUser
            Return userRepository.SearchUser(keyword)
        End Function
    End Class
End Namespace
