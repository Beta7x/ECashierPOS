Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Services.Interfaces
Imports ECashierPOS.Utils

Namespace Controllers
    Public Class AuthController
        Private ReadOnly authService As IAuthService

        Public Sub New(authService As IAuthService)
            Me.authService = authService
        End Sub

        Public Function Login(username As String, password As String) As OperationResult(Of User)
            Return authService.Login(username, password)
        End Function
    End Class
End Namespace
