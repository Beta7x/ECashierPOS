Namespace Models.Entities
    Public Class Sales
        Implements IEntity

        Public Property Id As String Implements IEntity.Id
        'Public Property InvoiceNumber As String
        Public Property CashierId As String
        Public Property CustomerId As String
        Public Property TotalPrice As Decimal
        Public Property Discount As Decimal
        Public Property GrandTotal As Decimal
        Public Property Payment As Decimal
        Public Property Change As Decimal
        Public Property CreatedAt As DateTime
    End Class
End Namespace
