using AdapterExample.External.Interfaces;

namespace AdapterExample.External.Services
{
    public class DBWriter : ILogWriter
    {
        public void Write(string message)
        {
            // some database writing logic
        }
    }
}
