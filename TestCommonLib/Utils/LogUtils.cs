using log4net;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]

namespace TestCommonLib.Utils
{
    public static class LogUtils
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection
            .MethodBase.GetCurrentMethod().DeclaringType); 
        public static void Info(string message)
        {
            log.Info(message);
        }
        public static void Error(string message)
        {
            log.Error(message);
        }
    }
}

