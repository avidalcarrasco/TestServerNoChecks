namespace TestServerNoChecks.Infrastructure
{
    public class SingletonInjectingScoped : ISingleton
    {
        private readonly IScoped _scoped;

        public SingletonInjectingScoped(IScoped scoped)
        {
            _scoped = scoped;
        }

        public IEnumerable<WeatherForecast> Get() => _scoped.Get();
    }
}
