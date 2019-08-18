using System;
using Gladys.Repository.Log;
using MySql.Data.MySqlClient;

namespace Gladys.Repository.MySql
{
    public class MySqlConnectionManager
    {
        private MySqlConnection _connection;
        private readonly ILogger _logger;
        
        public MySqlConnectionManager(ILogger logger = null)
        {
            _logger = logger;
        }

        public MySqlConnection GetConnection(MySqlConnectionConfig config)
        {
            if (Connect(config.User, config.Password, config.Server, config.Database))
            {
                return _connection;
            }

            return null;
        }

        private bool Connect(string user, string password, string server, string database)
        {
            if (String.IsNullOrEmpty(server) || String.IsNullOrEmpty(database))
            {
                Log(@"Error: could not connect to database because server or database input is null or empty");
                return false;
            }

            try
            {
                Disconnect();
                string connectionString = $"Server={server}; database={database}; UID={user}; password={password}";
                _connection = new MySqlConnection(connectionString);
                _connection.Open();
                Log($"Database connection is open to '{database}' at '{server}'");
                return true;
            }
            catch (Exception e)
            {
                Log($"Error: failed to connect to database. An exception was thrown: {e.Message}");
                if (_connection != null)
                {
                    Log(@"Database connection has been closed due to an exception");
                    _connection.Close();
                }
            }

            return false;
        }

        public void Disconnect()
        {
            if (_connection != null)
            {
                Log(@"Database connection has been closed");
                _connection.Close();
            }
        }

        private void Log(string message)
        {
            _logger?.Log(message);
        }
    }
}