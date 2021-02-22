using MicroORMWrapper;
using System.Data.Common;

namespace WebApp.MySQLTest.DatabaseConnections {
    public class MySqlTestConnection : IDatabaseConnection {
        public string ConnectionName { get; set; } = null!;

        public DbConnection DbConnection { get; set; } = null!;
    }
}
