using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logger
{
    public static class Logger
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static void LogInfo(string message)
        {
            logger.Info(message);
        }

        public static void LogException(string message)
        {
            logger.Error(message);
        }
    }
}
