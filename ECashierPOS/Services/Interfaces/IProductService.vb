Imports ECashierPOS.Models.DTO
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Utils

Namespace Services.Interfaces
    Public Interface IProductService
        Function AddProduct(createProductRequest As ProductDTO) As OperationResult
        Function UpdateProduct(updateProductRequest As ProductDTO) As OperationResult
        Function DeleteProduct(productId As String) As OperationResult
        Function GetProductById(productId As String) As OperationResult(Of Product)
        Function SearchProduct(keyword As String) As OperationResult(Of List(Of Product))
        Function GetAllProducts() As OperationResult(Of List(Of Product))
        Function GetAllProductCategories() As OperationResult(Of List(Of Category))
    End Interface
End Namespace
