namespace TestServerNoChecks.Infrastructure
{
    public class Singleton : ISingleton
    {
        private readonly IScoped _scoped;

        public Singleton(IScoped scoped)
        {
            _scoped = scoped;
        }

        public IEnumerable<WeatherForecast> Get() => _scoped.Get();
    }
}
