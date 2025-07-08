Namespace Models.Entities
    Public Class Product
        Implements IEntity
        Public Property Id As String Implements IEntity.Id
        Public Property CategoryId As String
        Public Property ProductName As String
        Public Property Description As String
        Public Property ProductCode As String
        Public Property PuchasePrice As Double
        Public Property SellingPrice As Double
        Public Property Stock As Integer
        Public Property MinimumStock As Integer
        Public Property Image As String
        Public Property CreatedAt As DateTime
        Public Property UpdatedAt As DateTime?
        Public Property CategoryName As String ' Join table
    End Class
End Namespace
