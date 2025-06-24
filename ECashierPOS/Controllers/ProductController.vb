Imports ECashierPOS.Models.DTO
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Services.Interfaces
Imports ECashierPOS.Utils
Imports ECashierPOS.Validators

Namespace Controllers
    Public Class ProductController
        Private ReadOnly productService As IProductService

        Public Sub New(productService As IProductService)
            Me.productService = productService
        End Sub

        Public Function CreateProduct(product As ProductDTO) As OperationResult
            Return productService.AddProduct(product)
        End Function

        Public Function GetAllProducts() As OperationResult(Of List(Of Product))
            Return productService.GetAllProducts()
        End Function

        Public Function GetAllProductCategories() As OperationResult(Of List(Of Category))
            Return productService.GetAllProductCategories()
        End Function

        Public Function GetProductById(id As String) As OperationResult(Of Product)
            Return productService.GetProductById(id)
        End Function

        Public Function DeleteProduct(id As String) As OperationResult
            Return productService.DeleteProduct(id)
        End Function

        Public Function UpdateProduct(updateRequest As ProductDTO) As OperationResult
            Return productService.UpdateProduct(updateRequest)
        End Function

        Public Function SearchProduct(keyword As String) As OperationResult(Of List(Of Product))
            Return productService.SearchProduct(keyword)
        End Function
    End Class
End Namespace
