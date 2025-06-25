Namespace Helpers
    Public Module FormLoader
        Public Function ResolveForm(Of T As Form)(provider As IServiceProvider) As T
            Return CType(provider.GetService(GetType(T)), T)
        End Function
    End Module
End Namespace
