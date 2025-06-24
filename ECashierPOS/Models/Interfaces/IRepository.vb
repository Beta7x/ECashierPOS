Imports ECashierPOS.Utils

Namespace Models.Interfaces
    Public Interface IRepository(Of T)
        Function Insert(item As T) As OperationResult
        Function Update(item As T) As OperationResult
        Function Delete(id As String) As OperationResult
        Function GetById(id As String) As OperationResult(Of T)
        Function GetAll() As OperationResult(Of List(Of T))
    End Interface
End Namespace
