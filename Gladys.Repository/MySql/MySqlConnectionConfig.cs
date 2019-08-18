namespace Gladys.Repository.MySql
{
    public class MySqlConnectionConfig
    {
        public MySqlConnectionConfig(string user, string password, string server, string database)
        {
            User = user;
            Password = password;
            Server = server;
            Database = database;
        }
        
        public string User { get; }
        
        public string Password { get; }
        
        public string Server { get; }
        
        public string Database { get; }
    }
}