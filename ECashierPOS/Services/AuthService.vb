Imports ECashierPOS.Helpers
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Services.Interfaces
Imports ECashierPOS.Utils

Namespace Services
    Public Class AuthService
        Implements IAuthService

        Private ReadOnly userRepository As IUserRepository

        Public Sub New(userRepository As IUserRepository)
            Me.userRepository = userRepository
        End Sub

        Public Function Login(username As String, password As String) As OperationResult(Of User) Implements IAuthService.Login
            Dim result = userRepository.GetByUsername(username)
            If Not result.Success OrElse result.Data Is Nothing Then
                Return OperationResult(Of User).Fail("Username tidak ditemukan.")
            End If

            Dim user = result.Data

            If Not PasswordHelper.VerifyPassword(password, user.Password) Then
                Return OperationResult(Of User).Fail("Username atau password salah.")
            End If

            Return OperationResult(Of User).Ok(user, "Login berhasil.")
        End Function
    End Class
End Namespace