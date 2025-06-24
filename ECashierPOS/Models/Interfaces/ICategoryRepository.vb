Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Utils

Namespace Models.Interfaces
    Public Interface ICategoryRepository
        Inherits IRepository(Of Category)

        Function IsCategoryInUse(id As String) As OperationResult(Of Boolean)
        Function SearchCategory(keyword As String) As OperationResult(Of List(Of Category))
        Function GetAllWithCountItems() As OperationResult(Of List(Of Category))
    End Interface
End Namespace
