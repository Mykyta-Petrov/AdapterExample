using AdapterExample.External.Interfaces;

namespace AdapterExample.External.Services
{
    public class ConsoleWriter : ILogWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
