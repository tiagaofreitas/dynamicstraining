using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Log
    {
        private ILog _logger;
        public Log()
        {
            _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public void LogInformation(string message)
        {
            _logger.Info(message);
        }

        public void LogError(string message)
        {
            _logger.Error(message);
        }
    }
}
