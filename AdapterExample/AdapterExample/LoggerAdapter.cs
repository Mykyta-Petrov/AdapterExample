using AdapterExample.External.Interfaces;
using AdapterExample.External.Services;

namespace AdapterExample
{
    public class LoggerAdapter : ILogger
    {
        private readonly IExternalLogger _logger;

        public LoggerAdapter()
        {
            _logger = new ExternalLogger(new ConsoleWriter());
        }

        public void Log(string message)
        {
            _logger.Log(message, IExternalLogger.LogLevels.Info);
        }
    }
}
