Imports MySql.Data.MySqlClient

Namespace Database.Factories
    Public Class MySqlConnectionFactory
        Implements IDbConnectionFactory

        Private ReadOnly connectionString As String

        Public Sub New(connectionString As String)
            Me.connectionString = connectionString
        End Sub

        Public Function CreateConnection() As IDbConnection Implements IDbConnectionFactory.CreateConnection
            Return New MySqlConnection(connectionString)
        End Function
    End Class
End Namespace
