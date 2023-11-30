namespace AdapterExample.External.Interfaces
{
    public interface IExternalLogger
    {
        enum LogLevels
        {
            Debug,
            Info,
            Warning,
            Error,
            Critical
        }
        void Log(string message, LogLevels level);
    }
}
