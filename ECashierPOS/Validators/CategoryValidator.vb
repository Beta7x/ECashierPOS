Imports ECashierPOS.Models.DTO

Namespace Validators
    Public Class CategoryValidator
        Implements IValidator(Of CategoryDTO)
        Public Function ValidateCreate(input As CategoryDTO) As ValidationResult Implements IValidator(Of CategoryDTO).ValidateCreate
            Dim result As New ValidationResult

            If String.IsNullOrWhiteSpace(input.CategoryName) Then
                result.AddError("Nama kategori tidak boleh kosong.")
            End If

            Return result
        End Function

        Public Function ValidateUpdate(input As CategoryDTO) As ValidationResult Implements IValidator(Of CategoryDTO).ValidateUpdate
            Return Me.ValidateCreate(input)
        End Function

        Public Function ValidateDelete(id As String) As ValidationResult Implements IValidator(Of CategoryDTO).ValidateDelete
            Dim result As New ValidationResult

            If String.IsNullOrWhiteSpace(id) Then
                result.AddError("Id kategori tidak boleh kosong.")
            End If

            Return result
        End Function

        Public Function ValidateGetById(id As String) As ValidationResult Implements IValidator(Of CategoryDTO).ValidateGetById
            Return Me.ValidateDelete(id)
        End Function
    End Class
End Namespace
