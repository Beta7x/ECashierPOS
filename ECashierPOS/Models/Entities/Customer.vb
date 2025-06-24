Namespace Models.Entities
    Public Class Customer
        Implements IEntity

        Public Property Id As String Implements IEntity.Id
        Public Property Name As String
        Public Property Phone As String
        Public Property Address As String
        Public Property CreatedAt As DateTime
        Public Property UpdatedAt As DateTime?
    End Class
End Namespace
