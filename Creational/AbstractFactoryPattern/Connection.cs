namespace AbstractFactoryPattern
{
    abstract class Connection
    {
        public abstract bool OpenConnection();
        public abstract bool CloseConnection();
    }

    class MySqlConnection : Connection
    {
        public override bool CloseConnection()
        {
            Console.WriteLine("MySqlConnection closed");
            return true;
        }

        public override bool OpenConnection()
        {
            Console.WriteLine("MySqlConnection opened");
            return true;
        }
    }

    class OracleConnection : Connection
    {
        public override bool CloseConnection()
        {
            Console.WriteLine("OracleConnection closed");
            return true;
        }

        public override bool OpenConnection()
        {
            Console.WriteLine("OracleConnection opened");
            return true;
        }
    }
}
