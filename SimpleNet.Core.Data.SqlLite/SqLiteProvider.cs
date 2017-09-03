using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;

namespace SimpleNet.Core.Data.SqLite
{
    /// <summary>
    /// Sq lite provider.
    /// </summary>
    public class SqLiteProvider : ISimpleDatabaseProvider
    {
		readonly string _connectionString;

		public SqLiteProvider(string connectionString)
		{
			_connectionString = connectionString;
		}

		public DbConnection GetConnection()
		{
            var connection = new SQLiteConnection(_connectionString);
                connection.Open();
            return connection;
		}   

        public DbCommand GetCommand()
        {
            return new SQLiteCommand();
        }


        public DbParameter GetParameter(string name, object value)
        {
            return new SQLiteParameter(name, value);
        }

        public DbParameter GetParameter(string name, object value, ParameterDirection direction)
        {
            return new SQLiteParameter(name, value) { Direction = direction };
        }
    }
}
