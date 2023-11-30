using AdapterExample.External.Interfaces;

namespace AdapterExample.External.Services
{
    public class ExternalLogger : IExternalLogger
    {
        private readonly ILogWriter _writer;

        public ExternalLogger(ILogWriter writer)
        {
            _writer = writer;
        }

        public void Log(string message, IExternalLogger.LogLevels level)
        {
            _writer.Write($"[{DateTime.Now}] [{level}] {message}");
        }
    }
}
