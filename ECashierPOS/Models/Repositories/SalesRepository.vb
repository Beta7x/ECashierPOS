Imports ECashierPOS.Database.Factories
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces

Namespace Models.Repositories
    Public Class SalesRepository
        Inherits GenericRepository(Of Sales)
        Implements ISalesRepository

        Public Sub New(factory As IDbConnectionFactory)
            MyBase.New(factory)
        End Sub

        Protected Overrides ReadOnly Property TableName As String
            Get
                Return "sales"
            End Get
        End Property

        Protected Overrides ReadOnly Property DefaultOrderBy As String
            Get
                Return "created_at DESC"
            End Get
        End Property

        Protected Overrides Function MapEntity(reader As IDataReader) As Sales
            Return New Sales With {
                .Id = reader("id").ToString(),
                .CashierId = reader("cashier_id").ToString(),
                .CustomerId = reader("customer_id").ToString(),
                .TotalPrice = Convert.ToDecimal(reader("total_price")),
                .Discount = Convert.ToDecimal(reader("discount")),
                .GrandTotal = Convert.ToDecimal(reader("grand_total")),
                .Payment = Convert.ToDecimal(reader("payment")),
                .Change = Convert.ToDecimal(reader("change")),
                .CreatedAt = Convert.ToDateTime(reader("created_at"))
            }
        End Function

        Protected Overrides Function MapFields(entity As Sales) As Dictionary(Of String, Object)
            Return New Dictionary(Of String, Object) From {
                {"id", entity.Id},
                {"cashier_id", entity.CashierId},
                {"customer_id", entity.CustomerId},
                {"total_price", entity.TotalPrice},
                {"discount", entity.Discount},
                {"grand_total", entity.GrandTotal},
                {"payment", entity.Payment},
                {"change", entity.Change}
            }
        End Function
    End Class
End Namespace
