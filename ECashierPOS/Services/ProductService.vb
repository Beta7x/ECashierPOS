Imports ECashierPOS.Models.DTO
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Services.Interfaces
Imports ECashierPOS.Utils
Imports ECashierPOS.Validators

Namespace Services
    Public Class ProductService
        Implements IProductService

        Private ReadOnly productRepository As IProductRepository
        Private ReadOnly categoryRepository As ICategoryRepository
        Private ReadOnly validator As ProductValidator

        Public Sub New(productRepository As IProductRepository, categoryRepository As ICategoryRepository)
            Me.productRepository = productRepository
            Me.categoryRepository = categoryRepository
            Me.validator = New ProductValidator()
        End Sub

        Public Function AddProduct(createProductRequest As ProductDTO) As OperationResult Implements IProductService.AddProduct
            Dim validation = validator.ValidateCreate(createProductRequest)

            If Not validation.IsValid Then
                Dim errorMessage As String = Nothing
                For Each errMsg In validation.Errors
                    errorMessage &= errMsg
                Next

                Return OperationResult.Fail(errorMessage)
            End If

            Dim newProduct As New Product With {
                .Id = Guid.NewGuid().ToString(),
                .CategoryId = createProductRequest.CategoryId,
                .ProductCode = createProductRequest.ProductCode,
                .Stock = createProductRequest.Stock,
                .MinumumStock = createProductRequest.MinimumStock,
                .PuchasePrice = createProductRequest.PurchasePrice,
                .SellingPrice = createProductRequest.SellingPrice,
                .Image = createProductRequest.Image
            }

            Return productRepository.Insert(newProduct)
        End Function

        Public Function UpdateProduct(updateProductRequest As ProductDTO) As OperationResult Implements IProductService.UpdateProduct
            Dim validation = validator.ValidateUpdate(updateProductRequest)
            If Not validation.IsValid Then
                Dim errorMessage As String = Nothing
                For Each errMsg In validation.Errors
                    errorMessage &= errMsg
                Next

                Return OperationResult.Fail(errorMessage)
            End If

            Dim product As New Product With {
                .Id = updateProductRequest.Id,
                .CategoryId = updateProductRequest.CategoryId,
                .ProductName = updateProductRequest.ProductName,
                .ProductCode = updateProductRequest.ProductCode,
                .Image = updateProductRequest.Image,
                .PuchasePrice = updateProductRequest.PurchasePrice,
                .SellingPrice = updateProductRequest.SellingPrice,
                .Stock = updateProductRequest.Stock,
                .MinumumStock = updateProductRequest.MinimumStock
            }

            Return productRepository.Update(product)
        End Function

        Public Function DeleteProduct(productId As String) As OperationResult Implements IProductService.DeleteProduct
            Dim validation = validator.ValidateDelete(productId)
            If Not validation.IsValid Then
                Return OperationResult.Fail(validation.Errors(0))
            End If

            Return productRepository.Delete(productId)
        End Function

        Public Function GetProductById(productId As String) As OperationResult(Of Product) Implements IProductService.GetProductById
            Dim validation = validator.ValidateGetById(productId)
            If Not validation.IsValid Then
                Return OperationResult(Of Product).Fail(validation.Errors(0))
            End If

            Return productRepository.GetById(productId)
        End Function

        Public Function SearchProduct(keyword As String) As OperationResult(Of List(Of Product)) Implements IProductService.SearchProduct
            Return productRepository.SearchProduct(keyword)
        End Function

        Public Function GetAllProducts() As OperationResult(Of List(Of Product)) Implements IProductService.GetAllProducts
            Return productRepository.GetAll()
        End Function

        Public Function GetAllProductCategories() As OperationResult(Of List(Of Category)) Implements IProductService.GetAllProductCategories
            Return categoryRepository.GetAll()
        End Function

    End Class
End Namespace
