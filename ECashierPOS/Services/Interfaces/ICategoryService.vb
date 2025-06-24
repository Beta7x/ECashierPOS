Imports ECashierPOS.Models.DTO
Imports ECashierPOS.Utils

Namespace Services.Interfaces
    Public Interface ICategoryService
        Function AddCategor(category As CategoryDTO) As OperationResult
    End Interface
End Namespace
