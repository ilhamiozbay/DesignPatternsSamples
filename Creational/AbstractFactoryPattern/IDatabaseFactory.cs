namespace AbstractFactoryPattern
{
    interface IDatabaseFactory
    {
        Connection CreateConnection();
        Command CreateCommand();
    }

    class OracleDatabaseFactory : IDatabaseFactory
    {
        public Command CreateCommand()
        {
            return new OracleCommand();
        }

        public Connection CreateConnection()
        {
            return new OracleConnection();
        }
    }

    class MySqlDatabaseFactory : IDatabaseFactory
    {
        public Command CreateCommand()
        {
            return new MySqlCommand();
        }

        public Connection CreateConnection()
        {
            return new MySqlConnection();   
        }
    }
}
