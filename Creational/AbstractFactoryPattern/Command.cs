using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal abstract class Command
    {
        public abstract void ExecuteCommand(string query);
    }

    class MySqlCommand : Command
    {
        public override void ExecuteCommand(string query)
        {
            Console.WriteLine($"MySql command, {query} executed");
        }
    }

    class OracleCommand : Command
    {
        public override void ExecuteCommand(string query)
        {
            Console.WriteLine($"Oracle command, {query} executed");
        }
    }
}
