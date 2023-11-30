namespace AdapterExample
{
    public class App
    {
        private readonly ILogger _logger;

        public App(ILogger logger)
        {
            _logger = logger;
        }

        public void SomeMethod()
        {
            // some actions

            _logger.Log("Executed SomeMethod");
        }
    }
}
