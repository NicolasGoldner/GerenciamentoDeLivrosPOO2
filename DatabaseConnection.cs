using MySql.Data.MySqlClient;

namespace TrabalhoWagnerBiblioteca
{
    public sealed class DatabaseConnection
    {
        private static DatabaseConnection? _instance;
        private static readonly object _lock = new object();
        private MySqlConnection _connection;

        private DatabaseConnection()
        {
            string connectionString = "server=localhost;user id=root;password=nicolas1;database=biblioteca;";
            _connection = new MySqlConnection(connectionString);
        }

        public static DatabaseConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new DatabaseConnection();
                    return _instance;
                }
            }
        }

        public MySqlConnection Connection
        {
            get
            {
                if (_connection.State == System.Data.ConnectionState.Closed || _connection.State == System.Data.ConnectionState.Broken)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }
    }
}

