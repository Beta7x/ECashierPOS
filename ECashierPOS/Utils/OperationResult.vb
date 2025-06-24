Namespace Utils
    Public Class OperationResult
        Public Property Success As Boolean
        Public Property Message As String
        Public Property [Error] As Exception

        Public Shared Function Ok(Optional message As String = "Success") As OperationResult
            Return New OperationResult With {
                .Success = True,
                .Message = message
            }
        End Function

        Public Shared Function Fail(Optional message As String = "Failed", Optional ex As Exception = Nothing) As OperationResult
            Return New OperationResult With {
                .Success = False,
                .Message = message,
                .[Error] = ex
            }
        End Function
    End Class

    Public Class OperationResult(Of T)
        Inherits OperationResult

        Public Property Data As T

        Public Shared Function Ok(data As T, Optional message As String = "Success") As OperationResult(Of T)
            Return New OperationResult(Of T) With {
                .Success = True,
                .Message = message,
                .Data = data
            }
        End Function

        Public Shared Function Fail(Optional message As String = "Failed", Optional ex As Exception = Nothing) As OperationResult(Of T)
            Return New OperationResult(Of T) With {
                .Success = False,
                .Data = Nothing,
                .[Error] = ex,
                .Message = message
            }
        End Function
    End Class
End Namespace
