using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class CustomOperation
    {
        IDatabaseFactory _databaseFactory;
        Connection _connection;
        Command _command;
        
        public CustomOperation(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _command=databaseFactory.CreateCommand();
            _connection=databaseFactory.CreateConnection();
        }

        public void RemoveById(int id)
        {
            _connection.OpenConnection();
            _command.ExecuteCommand($"DELETE TABLE1 WHERE ID = {id}");
            _connection.CloseConnection();
        }
    }
}
