Imports ECashierPOS.Models.Entities

Public NotInheritable Class Session
    Public Shared Property CurrentUser As User

    Public Shared Sub Clear()
        CurrentUser = Nothing
    End Sub
End Class
