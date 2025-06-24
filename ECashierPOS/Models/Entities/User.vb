Namespace Models.Entities
    Public Class User
        Implements IEntity
        Public Property Id As String Implements IEntity.Id
        Public Property FullName As String
        Public Property Username As String
        Public Property Password As String
        Public Property Role As String
        Public Property CreatedAt As DateTime
        Public Property UpdatedAt As DateTime?
    End Class
End Namespace
