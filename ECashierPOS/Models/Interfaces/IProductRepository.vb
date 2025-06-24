Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Utils

Namespace Models.Interfaces
    Public Interface IProductRepository
        Inherits IRepository(Of Product)
        Function SearchProduct(keyword As String) As OperationResult(Of List(Of Product))
    End Interface
End Namespace
