Imports ECashierPOS.Helpers
Imports Microsoft.Extensions.DependencyInjection

Public Class MainAppContext
    Inherits ApplicationContext

    Private loginForm As FormLogin
    Private dashboardForm As FormDashboard
    Private serviceProvider As IServiceProvider
    Private isLoggingOut As Boolean = False

    Public Sub New(provider As IServiceProvider)
        Me.serviceProvider = provider
        ShowLoginForm()
    End Sub

    Private Sub ShowLoginForm()
        ' Ambil form login dari DI
        loginForm = FormLoader.ResolveForm(Of FormLogin)(serviceProvider)

        AddHandler loginForm.FormClosed, AddressOf OnDashboardClosed

        ' Hook event untuk handle login success
        AddHandler loginForm.LoginSuccess, AddressOf OnLoginSuccess

        ' Tampilkan login form
        loginForm.StartPosition = FormStartPosition.CenterScreen
        loginForm.Show()
    End Sub

    Private Sub OnLoginSuccess(sender As Object, e As EventArgs)
        ' Tutup login form
        loginForm.Hide()

        ' Setelah login success, tampilkan dashboard
        dashboardForm = CType(serviceProvider.GetRequiredService(Of FormDashboard)(), FormDashboard)

        ' Handle close dashboard untuk exit program
        AddHandler dashboardForm.FormClosed, AddressOf OnDashboardClosed
        AddHandler dashboardForm.LogoutRequested, AddressOf OnLogoutRequested

        ' Tampilkan dashboard
        dashboardForm.StartPosition = FormStartPosition.CenterScreen
        dashboardForm.Show()
    End Sub

    Private Sub OnDashboardClosed(sender As Object, e As FormClosedEventArgs)
        If Not isLoggingOut Then
            ' Exit aplikasi sepenuhnya
            ExitThread()
        End If
    End Sub

    Private Sub OnLogoutRequested(sender As Object, e As EventArgs)
        isLoggingOut = True
        dashboardForm.Hide()
        RemoveHandler dashboardForm.FormClosed, AddressOf OnDashboardClosed ' <- cegah ExitThread ke-trigger

        ShowLoginForm()
        isLoggingOut = False
    End Sub
End Class
