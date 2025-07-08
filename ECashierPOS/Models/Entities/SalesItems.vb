Namespace Models.Entities
    Public Class SalesItems
        Implements IEntity

        Public Property Id As String Implements IEntity.Id
        Public Property SalesId As String
        Public Property ProductId As String
        Public Property ProductName As String ' Join table
        Public Property ProductImage As String ' Join table
        Public Property Price As Decimal
        Public Property Quantity As Integer
        Public Property TotalPrice As Decimal
        Public Property CreatedAt As DateTime
    End Class
End Namespace
