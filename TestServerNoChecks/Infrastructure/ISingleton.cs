namespace TestServerNoChecks.Infrastructure
{
    public interface ISingleton
    {
        IEnumerable<WeatherForecast> Get();
    }
}
