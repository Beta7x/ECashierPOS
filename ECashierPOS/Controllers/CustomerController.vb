Imports ECashierPOS.Models.DTO
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Utils
Imports ECashierPOS.Validators

Namespace Controllers
    Public Class CustomerController
        Private ReadOnly repository As ICustomerRepository
        Private ReadOnly validator As CustomerValidator

        Public Sub New(customerRepository As ICustomerRepository)
            repository = customerRepository
            validator = New CustomerValidator()
        End Sub

        Public Function AddCustomer(createRequest As CustomerDTO) As OperationResult
            Dim validation = validator.ValidateCreate(createRequest)
            If Not validation.IsValid Then
                Dim errMessage As String = Nothing
                For Each errMsg In validation.Errors
                    errMessage &= errMsg
                Next

                Return OperationResult.Fail(errMessage)
            End If

            Dim customer As New Customer With {
                .Id = Guid.NewGuid().ToString(),
                .Name = createRequest.Name,
                .Phone = createRequest.Phone,
                .Address = createRequest.Address
            }

            Return repository.Insert(customer)
        End Function

        Public Function GetAllCustomers() As OperationResult(Of List(Of Customer))
            Return repository.GetAll()
        End Function

        Public Function GetCustomerById(id As String) As OperationResult(Of Customer)
            Dim validation = validator.ValidateGetById(id)
            If Not validation.IsValid Then
                Return OperationResult(Of Customer).Fail(validation.Errors(0))
            End If

            Return repository.GetById(id)
        End Function

        Public Function DeleteCustomer(id As String) As OperationResult
            Dim validation = validator.ValidateDelete(id)
            If Not validation.IsValid Then
                Return OperationResult.Fail(validation.Errors(0))
            End If

            Return repository.Delete(id)
        End Function

        Public Function UpdateCustomer(updateRequest As CustomerDTO) As OperationResult
            Dim validation = validator.ValidateUpdate(updateRequest)
            If Not validation.IsValid Then
                Dim errorMessage As String = Nothing
                For Each errMsg In validation.Errors
                    errorMessage &= errMsg
                Next

                Return OperationResult.Fail(errorMessage)
            End If

            Dim customer As New Customer With {
                .Id = updateRequest.Id,
                .Name = updateRequest.Name,
                .Phone = updateRequest.Phone,
                .Address = updateRequest.Address
            }

            Return repository.Update(customer)
        End Function

        Public Function SearchCustomer(keyword As String) As OperationResult(Of List(Of Customer))
            Return repository.SearchCustomer(keyword)
        End Function
    End Class
End Namespace
