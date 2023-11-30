using AdapterExample.External.Interfaces;

namespace AdapterExample.External.Services
{
    public class FileWriter : ILogWriter
    {
        public void Write(string message)
        {
            // some filewriting logic
        }
    }
}
