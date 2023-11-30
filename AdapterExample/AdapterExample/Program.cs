namespace AdapterExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            App app = new App(new LoggerAdapter());
            app.SomeMethod();
        }
    }
}