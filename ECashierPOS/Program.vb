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

        ' Jalankan context khusus
        Application.Run(New MainAppContext(ServiceProvider))
    End Sub

End Module
