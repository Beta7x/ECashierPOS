Imports ECashierPOS.Models.DTO

Namespace Validators
    Public Class UserValidator
        Implements IValidator(Of UserDTO)

        Public Function ValidateCreate(input As UserDTO) As ValidationResult Implements IValidator(Of UserDTO).ValidateCreate
            Dim result As New ValidationResult

            If String.IsNullOrWhiteSpace(input.FullName) Then
                result.AddError("Nama tidak boleh kosong.")
            End If

            If String.IsNullOrWhiteSpace(input.Username) Then
                result.AddError("Username tidak boleh kosong.")
            End If

            If String.IsNullOrWhiteSpace(input.Password) Then
                result.AddError("Password tidak boleh kosong.")
            End If

            If String.IsNullOrWhiteSpace(input.Role) Then
                result.AddError("Role user tidak boleh kosong.")
            End If

            Return result
        End Function

        Public Function ValidateUpdate(input As UserDTO) As ValidationResult Implements IValidator(Of UserDTO).ValidateUpdate
            Dim result As New ValidationResult

            If String.IsNullOrWhiteSpace(input.Id) Then
                result.AddError("Id user tidak boleh kosong.")
            End If

            If String.IsNullOrWhiteSpace(input.FullName) Then
                result.AddError("Nama tidak boleh kosong.")
            End If

            If String.IsNullOrWhiteSpace(input.Username) Then
                result.AddError("Username tidak boleh kosong.")
            End If

            If String.IsNullOrWhiteSpace(input.Password) Then
                result.AddError("Password tidak boleh kosong.")
            End If

            If String.IsNullOrWhiteSpace(input.Role) Then
                result.AddError("Role user tidak boleh kosong.")
            End If

            Return result
        End Function

        Public Function ValidateDelete(id As String) As ValidationResult Implements IValidator(Of UserDTO).ValidateDelete
            Dim result As New ValidationResult

            If String.IsNullOrWhiteSpace(id) Then
                result.AddError("Id user tidak boleh kosong.")
            End If

            Return result
        End Function

        Public Function ValidateGetById(id As String) As ValidationResult Implements IValidator(Of UserDTO).ValidateGetById
            Return Me.ValidateDelete(id)
        End Function
    End Class
End Namespace
