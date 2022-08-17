namespace TestServerNoChecks.Infrastructure
{
    public class SingletonInjectingTransient : ISingleton
    {
        private readonly ITransient _transient;

        public SingletonInjectingTransient(ITransient transient)
        {
            _transient = transient;
        }

        public IEnumerable<WeatherForecast> Get() => _transient.Get();
    }
}
