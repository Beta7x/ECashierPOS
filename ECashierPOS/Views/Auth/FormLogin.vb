Imports ECashierPOS.Controllers
Imports ECashierPOS.Models.Entities

Public Class FormLogin
    Private ReadOnly authController As AuthController
    Private ReadOnly serviceProvider As IServiceProvider

    Public Event LoginSuccess As EventHandler

    Public Sub New(authController As AuthController, provider As IServiceProvider)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.authController = authController
        Me.serviceProvider = provider
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = textUsername.Text
        Dim password As String = textPassword.Text

        Dim result = authController.Login(username, password)

        Dim user As New User With {
                .Id = Guid.NewGuid().ToString(),
                .FullName = "Admin nih bosss",
                .Role = "admin",
                .Password = "admin123",
                .Username = "admin",
                .CreatedAt = DateTime.Now(),
                .UpdatedAt = DateTime.Now()
            }

        Session.CurrentUser = user

        RaiseEvent LoginSuccess(Me, EventArgs.Empty)

        'If result.Success Then
        '    Session.CurrentUser = result.Data

        '    Dim dashboard = CType(serviceProvider.GetService(GetType(FormDashboard)), FormDashboard)
        '    RaiseEvent LoginSuccess(Me, EventArgs.Empty)

        '    Me.Hide()
        'Else
        '    MessageBox.Show(result.Message, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
    End Sub
End Class
