Imports ECashierPOS.Models.DTO

Namespace Validators
    Public Class CustomerValidator
        Implements IValidator(Of CustomerDTO)

        Public Function ValidateCreate(input As CustomerDTO) As ValidationResult Implements IValidator(Of CustomerDTO).ValidateCreate
            Dim result As New ValidationResult

            If String.IsNullOrWhiteSpace(input.Name) Then
                result.AddError("Nama pelanggan tidak boleh kosong.")
            End If

            If String.IsNullOrWhiteSpace(input.Phone) Then
                result.AddError("Nomor telepon tidak boleh kosong.")
            End If

            If String.IsNullOrWhiteSpace(input.Address) Then
                result.AddError("Alamat tidak boleh kosong.")
            End If

            Return result
        End Function

        Public Function ValidateUpdate(input As CustomerDTO) As ValidationResult Implements IValidator(Of CustomerDTO).ValidateUpdate
            Dim result As New ValidationResult

            If String.IsNullOrWhiteSpace(input.Id) Then
                result.AddError("Id pelanggan tidak boleh kosong.")
            End If

            If String.IsNullOrWhiteSpace(input.Name) Then
                result.AddError("Nama pelanggan tidak boleh kosong.")
            End If

            If String.IsNullOrWhiteSpace(input.Phone) Then
                result.AddError("Nomor telepon tidak boleh kosong.")
            End If

            If String.IsNullOrWhiteSpace(input.Address) Then
                result.AddError("Alamat pelanggan tidak boleh kosong.")
            End If

            Return result
        End Function

        Public Function ValidateDelete(id As String) As ValidationResult Implements IValidator(Of CustomerDTO).ValidateDelete
            Dim result As New ValidationResult

            If String.IsNullOrWhiteSpace(id) Then
                result.AddError("Id pelanggan tidak boleh kosong.")
            End If

            Return result
        End Function

        Public Function ValidateGetById(id As String) As ValidationResult Implements IValidator(Of CustomerDTO).ValidateGetById
            Return ValidateDelete(id)
        End Function
    End Class
End Namespace
