using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal abstract class DbConnection
    {
        // Public properties
        private string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString)) throw new InvalidOperationException("Connection string can't be null");
            ConnectionString = connectionString;
            Timeout = TimeSpan.FromSeconds(10);
        }

        public abstract void Open();

        public abstract void Close();

    }

    internal class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            if (Timeout >= TimeSpan.FromSeconds(5)) throw new InvalidOperationException("SQL Connection timed out");
            Console.WriteLine("SQL Connection opened");
        }

        public override void Close() { Console.WriteLine("SQL Connection closed"); }
    }

    internal class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            if (Timeout <= TimeSpan.FromSeconds(3)) throw new InvalidOperationException("Oracle Connection timed out");
            Console.WriteLine("Oracle Connection opened");
        }

        public override void Close() { Console.WriteLine("Oracle Connection closed"); }
    }

}
