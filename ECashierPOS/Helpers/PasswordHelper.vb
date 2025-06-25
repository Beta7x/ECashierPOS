Namespace Helpers
    Public Module PasswordHelper
        ''' <summary>
        ''' Generate hashed password menggunakan Bcrypt
        ''' </summary>
        Public Function HashPassword(password As String) As String
            Return BCrypt.Net.BCrypt.HashPassword(password, workFactor:=12)
        End Function

        ''' <summary>
        ''' Verifikasi input password terhadap hashed password
        ''' </summary>
        Public Function VerifyPassword(password As String, hashedPassword As String) As Boolean
            Return BCrypt.Net.BCrypt.Verify(password, hashedPassword)
        End Function
    End Module
End Namespace
