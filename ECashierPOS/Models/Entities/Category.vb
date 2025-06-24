Namespace Models.Entities
    Public Class Category
        Implements IEntity

        Public Property Id As String Implements IEntity.Id
        Public Property CategoryName As String
        Public Property Description As String
        Public Property CreatedAt As DateTime
        Public Property UpdatedAt As DateTime?
        Public Property ProductItems As Integer?
    End Class
End Namespace
