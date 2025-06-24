Namespace Validators
    Public Class ValidationResult
        Public Property IsValid As Boolean
        Public Property Errors As List(Of String)

        Public Sub New()
            IsValid = True
            Errors = New List(Of String)()
        End Sub

        Public Sub AddError(errorMessage As String)
            IsValid = False
            Errors.Add(errorMessage)
        End Sub
    End Class
End Namespace
