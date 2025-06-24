Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Utils

Namespace Models.Interfaces
    Public Interface ICustomerRepository
        Inherits IRepository(Of Customer)

        Function SearchCustomer(keyword As String) As OperationResult(Of List(Of Customer))
    End Interface
End Namespace
