using ProductViewLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductViewLibrary
{
    public class GlobalConfig
    {
        public static SqlConnector? Connection { get; private set; } = new SqlConnector();

        public static string? CnnString(string name)
        {
            try
            {
                foreach (ConnectionStringSettings connection in ConfigurationManager.ConnectionStrings)
                {
                    Console.WriteLine($"Name: {connection.Name}, ConnectionString: {connection.ConnectionString}");
                }
                return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Chyba pri načítaní connection string: {ex.Message}");
                return null;
            }

        }

    }
}
