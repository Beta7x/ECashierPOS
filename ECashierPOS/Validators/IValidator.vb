Namespace Validators
    Public Interface IValidator(Of T)
        Function ValidateCreate(input As T) As ValidationResult
        Function ValidateUpdate(input As T) As ValidationResult
        Function ValidateDelete(id As String) As ValidationResult
        Function ValidateGetById(id As String) As ValidationResult
    End Interface
End Namespace
