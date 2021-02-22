using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApp.MySQLTest.DatabaseConnections;

namespace WebApp.MySQLTest {
    public static class StartupExtensionLibrary {
        internal static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services, IConfiguration configuration) =>
            services.AddSqlManager<MySqlTestConnection>((connectionName: "MySqlTestDatabase", connectionString: configuration[$"mysqlTestDatabaseConfig:connectionString"]));
    }
}
