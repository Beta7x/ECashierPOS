Namespace Models.Entities
    Public Class TransactionItem
        Public Property Product As Product
        Public Property Qty As Integer
        Public ReadOnly Property Total As Decimal
            Get
                Return Product.SellingPrice * Qty
            End Get
        End Property
    End Class
End Namespace
