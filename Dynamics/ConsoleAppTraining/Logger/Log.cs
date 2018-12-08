using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class Log
    {
        private static ILog _logger;
        static Log()
        {
            _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public static void LogInformation(string message)
        {
            _logger.Info(message);
        }

        public static void LogWarn(string message)
        {
            _logger.Warn(message);
        }

        public static void LogError(string message)
        {
            _logger.Error($"ERROR DURING APPLICATION EXECUTION: {message}. METHOD: {_logger.Logger.Name}");
        }
    }
}
