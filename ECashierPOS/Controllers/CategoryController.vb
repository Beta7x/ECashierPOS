Imports ECashierPOS.Models.DTO
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Utils
Imports ECashierPOS.Validators

Namespace Controllers
    Public Class CategoryController
        Private ReadOnly repository As ICategoryRepository
        Private ReadOnly validator As CategoryValidator

        Public Sub New(repo As ICategoryRepository)
            repository = repo
            validator = New CategoryValidator()
        End Sub

        Public Function GetAllCategories() As OperationResult(Of List(Of Category))
            Return repository.GetAllWithCountItems()
        End Function

        Public Function GetById(id As String) As OperationResult(Of Category)
            Dim validation = validator.ValidateGetById(id)
            If Not validation.IsValid Then
                Return OperationResult(Of Category).Fail(validation.Errors(0))
            End If

            Return repository.GetById(id)
        End Function

        Public Function DeleteCategory(id As String) As OperationResult
            Dim validation = validator.ValidateDelete(id)
            If repository.IsCategoryInUse(id).Data Then
                validation.AddError("Kategori masih digunakan oleh produk lain. Tidak bisa dihapus.")
            End If

            If Not validation.IsValid Then
                Dim errorMessage As String = Nothing
                For Each errMsg In validation.Errors
                    errorMessage &= errMsg
                Next

                Return OperationResult.Fail(errorMessage)
            End If

            Return repository.Delete(id)
        End Function

        Public Function InsertCategory(createRequest As CategoryDTO) As OperationResult
            Dim validation = validator.ValidateCreate(createRequest)
            If Not validation.IsValid Then
                Dim errorMessage As String = Nothing
                For Each errMsg In validation.Errors
                    errorMessage &= errMsg
                Next

                Return OperationResult.Fail(errorMessage)
            End If

            Dim category As New Category With {
                .Id = Guid.NewGuid().ToString(),
                .CategoryName = createRequest.CategoryName,
                .Description = createRequest.Description
            }

            Return repository.Insert(category)
        End Function

        Public Function UpdateCategory(updateRequest As CategoryDTO) As OperationResult
            Dim validation = validator.ValidateUpdate(updateRequest)
            If Not validation.IsValid Then
                Dim errorMessage As String = Nothing
                For Each errMsg In validation.Errors
                    errorMessage &= errMsg
                Next

                Return OperationResult.Fail(errorMessage)
            End If

            Dim category As New Category With {
                .Id = updateRequest.Id,
                .CategoryName = updateRequest.CategoryName,
                .Description = updateRequest.Description
            }

            Return repository.Update(category)
        End Function

        Public Function SearchCategory(keyword As String) As OperationResult(Of List(Of Category))
            Return repository.SearchCategory(keyword)
        End Function
    End Class
End Namespace
