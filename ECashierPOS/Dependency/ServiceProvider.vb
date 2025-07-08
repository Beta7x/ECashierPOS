Imports System.Configuration
Imports ECashierPOS.Controllers
Imports ECashierPOS.Database.Factories
Imports ECashierPOS.Models.Interfaces
Imports ECashierPOS.Models.Repositories
Imports ECashierPOS.Services
Imports ECashierPOS.Services.Interfaces
Imports Microsoft.Extensions.DependencyInjection

Namespace Dependency
    Public Module ServiceProviderFactory
        Public Function Build() As ServiceProvider
            ' Init DI container
            Dim services = New ServiceCollection()

            ' Load config from App.config
            Dim config As AppConfig = LoadAppConfig()
            services.AddSingleton(config)

            Dim factory As IDbConnectionFactory = ResolveConnectionFactory(config)
            services.AddSingleton(factory)

            ' Register all repositories
            services.AddSingleton(Of IProductRepository, ProductRepository)()
            services.AddSingleton(Of ICustomerRepository, CustomerRepository)()
            services.AddSingleton(Of IUserRepository, UserRepository)()
            services.AddSingleton(Of ICategoryRepository, CategoryRepository)()

            ' Register all services
            services.AddSingleton(Of IProductService, ProductService)()
            services.AddSingleton(Of ICategoryService, CategoryService)()
            services.AddSingleton(Of IAuthService, AuthService)()
            services.AddSingleton(Of IUserService, UserService)()

            ' Register all controllers
            services.AddSingleton(Of ProductController)()
            services.AddSingleton(Of CustomerController)()
            services.AddSingleton(Of CategoryController)()
            services.AddSingleton(Of UserController)()
            services.AddSingleton(Of AuthController)()

            ' Register all views or forms
            services.AddSingleton(Of FormDashboard)()
            services.AddSingleton(Of FormDashboardChild)()
            services.AddSingleton(Of FormCustomer)()
            services.AddSingleton(Of FormProduct)()
            services.AddSingleton(Of FormCategory)()
            services.AddSingleton(Of FormLogin)()
            services.AddSingleton(Of FormReport)()
            services.AddSingleton(Of FormTransaction)()
            services.AddSingleton(Of FormUser)()

            Return services.BuildServiceProvider()
        End Function

        Private Function ResolveConnectionFactory(config As AppConfig) As IDbConnectionFactory
            Select Case config.DatabaseType.ToLower()
                Case "mysql"
                    Return New MySqlConnectionFactory(config.ConnectionString)
                Case Else
                    Throw New Exception("Unsupported database type: " & config.DatabaseType)
            End Select
        End Function

        Private Function LoadAppConfig() As AppConfig
            Dim dbType = ConfigurationManager.AppSettings("DatabaseType")
            Dim connSetting As ConnectionStringSettings

            Select Case dbType.ToLower()
                Case "mysql"
                    connSetting = ConfigurationManager.ConnectionStrings("MySQLConn")
                Case "postgres"
                    connSetting = ConfigurationManager.ConnectionStrings("PostgresConn")
                Case "sqlite"
                    connSetting = ConfigurationManager.ConnectionStrings("SQLiteConn")
                Case Else
                    Throw New Exception("Unsupported database type: " & dbType)
            End Select

            Return New AppConfig With {
                .DatabaseType = dbType,
                .ConnectionString = connSetting.ConnectionString,
                .ProviderName = connSetting.ProviderName
            }
        End Function
    End Module
End Namespace
