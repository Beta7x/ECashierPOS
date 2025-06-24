Imports ECashierPOS.Models.DTO

Namespace Validators
    Public Class ProductValidator
        Implements IValidator(Of ProductDTO)

        Public Function ValidateCreate(input As ProductDTO) As ValidationResult Implements IValidator(Of ProductDTO).ValidateCreate
            Dim result As New ValidationResult()

            If String.IsNullOrWhiteSpace(input.ProductName) Then
                result.AddError("Nama produk tidak boleh kosong.")
            End If

            If String.IsNullOrWhiteSpace(input.ProductCode) Then
                result.AddError("Kode produk tidak boleh kosong.")
            End If

            If String.IsNullOrWhiteSpace(input.CategoryId) Then
                result.AddError("Kategori tidak boleh kosong.")
            End If

            If input.Stock <= 0 Then
                result.AddError("Stok produk harus lebih besar dari 0.")
            End If

            If input.MinimumStock <= 0 Then
                result.AddError("Stok minimal harus lebih besar dari 0.")
            End If

            If input.PurchasePrice <= 0.0 Then
                result.AddError("Harga beli harus lebih besar dari 0.")
            End If

            If input.SellingPrice <= 0.0 Then
                result.AddError("Harga jual harus lebih besar dari 0.")
            End If

            Return result
        End Function

        Public Function ValidateUpdate(input As ProductDTO) As ValidationResult Implements IValidator(Of ProductDTO).ValidateUpdate
            Return Me.ValidateCreate(input)
        End Function

        Public Function ValidateDelete(id As String) As ValidationResult Implements IValidator(Of ProductDTO).ValidateDelete
            Dim result As New ValidationResult()

            If String.IsNullOrWhiteSpace(id) Then
                result.AddError("Id produk tidak boleh kosong.")
            End If

            Return result
        End Function

        Public Function ValidateGetById(id As String) As ValidationResult Implements IValidator(Of ProductDTO).ValidateGetById
            Return Me.ValidateDelete(id)
        End Function
    End Class
End Namespace
