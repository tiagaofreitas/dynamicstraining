using DynamicsConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Logger;

namespace ConsoleAppTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionHelper connectionHelper = new ConnectionHelper(ConfigurationManager.ConnectionStrings["dev"].ToString());
            Log log = new Log();

            log.LogInformation("Teste");
        }
    }
}
