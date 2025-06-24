Imports ECashierPOS.Dependency
Imports Microsoft.Extensions.DependencyInjection

Module Program
    Public ServiceProvider As ServiceProvider

    <STAThread>
    Public Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Build DI container
        ServiceProvider = ServiceProviderFactory.Build()

        Dim mainForm = ServiceProvider.GetService(Of FormDashboard)()
        mainForm.StartPosition = FormStartPosition.CenterScreen

        Application.Run(mainForm)
    End Sub

End Module
