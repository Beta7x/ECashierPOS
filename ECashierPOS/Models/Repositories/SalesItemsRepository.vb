Imports ECashierPOS.Database.Factories
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces

Namespace Models.Repositories
    Public Class SalesItemsRepository
        Inherits GenericRepository(Of SalesItems)
        Implements ISalesItemsRepository

        Public Sub New(factory As IDbConnectionFactory)
            MyBase.New(factory)
        End Sub

        Protected Overrides ReadOnly Property TableName As String
            Get
                Return "sales_items"
            End Get
        End Property

        Protected Overrides ReadOnly Property DefaultOrderBy As String
            Get
                Return "created_at DESC"
            End Get
        End Property

        Protected Overrides Function MapEntity(reader As IDataReader) As SalesItems
            Return New SalesItems With {
                .Id = reader("id").ToString(),
                .SalesId = reader("sales_id").ToString(),
                .ProductId = reader("product_id").ToString(),
                .Quantity = Convert.ToInt32(reader("quantity")),
                .Price = Convert.ToDecimal(reader("price")),
                .TotalPrice = Convert.ToDecimal(reader("total_price")),
                .CreatedAt = Convert.ToDateTime(reader("created_at"))
            }
        End Function

        Protected Overrides Function MapFields(entity As SalesItems) As Dictionary(Of String, Object)
            Return New Dictionary(Of String, Object) From {
                {"id", entity.Id},
                {"sales_id", entity.SalesId},
                {"product_id", entity.ProductId},
                {"quantity", entity.Quantity},
                {"price", entity.Price},
                {"total_price", entity.TotalPrice}
            }
        End Function
    End Class
End Namespace
