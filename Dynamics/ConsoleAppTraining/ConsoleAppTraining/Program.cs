using DynamicsConnection;
using System.Configuration;
using Logger;

namespace ConsoleAppTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionHelper connectionHelper = new ConnectionHelper(ConfigurationManager.ConnectionStrings["dev"].ToString());

            Log.LogInformation("Teste");
        }
    }
}
